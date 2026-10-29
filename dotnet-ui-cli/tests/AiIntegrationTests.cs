using System.Text.Json;
using System.Text.Json.Nodes;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Core.AI;
using Syncfusion.DotNet.CLI.Hosting;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class AiIntegrationTests
{
    [Theory]
    [MemberData(nameof(AiCommandTests.PlatformClients), MemberType = typeof(AiCommandTests))]
    public void ConfigurationUsesExactPlatformPackageAndClientSchema(string platformName, string package, string clientName)
    {
        var platform = AiCatalog.Platform(platformName);
        var client = AiCatalog.Client(clientName);
        var server = McpConfiguration.Server(platform, client, "outside-workspace.key", local: false);
        var change = McpConfiguration.Merge("{}", client, platform.ServerName, server, false);
        var root = JsonNode.Parse(change.Content)!;
        var written = root[client.ServerProperty]![platform.ServerName]!;
        Assert.Equal(package, written["args"]![0]!.GetValue<string>());
        Assert.Equal("dnx", written["command"]!.GetValue<string>());
        Assert.Equal("outside-workspace.key", written["env"]!["Syncfusion_API_Key_Path"]!.GetValue<string>());
        Assert.Equal(clientName is "vscode" or "codestudio", written["type"] is not null);
        Assert.False(McpConfiguration.Merge(change.Content, client, platform.ServerName, server, false).Changed);
    }

    [Theory]
    [InlineData("{}")]
    [InlineData("{ /* keep this */ }")]
    [InlineData("{\"inputs\":[],}")]
    [InlineData("{\"servers\":{ /* keep this */ }}")]
    [InlineData("{\"servers\":{\"other\":{\"command\":\"custom\",\"env\":{\"PRIVATE\":\"do-not-log\"}},},\"inputs\":[],}")]
    [InlineData("// keep this\n{\"servers\":{},\"label\":\"caf\u00e9\"}\n// end")]
    public void ConfigurationPreservesExistingJsoncAndIsByteStableOnRepeat(string original)
    {
        var client = AiCatalog.Client("vscode");
        var server = McpConfiguration.Server(AiCatalog.Platform("maui"), client, "external.key", false);
        var first = McpConfiguration.Merge(original, client, "sf-maui-mcp", server, false);
        Assert.True(first.Changed);
        var second = McpConfiguration.Merge(first.Content, client, "sf-maui-mcp", server, false);
        Assert.Equal(first.Content, second.Content);
        Assert.False(second.Changed);
        using var parsed = JsonDocument.Parse(first.Content, new() { AllowTrailingCommas = true, CommentHandling = JsonCommentHandling.Skip });
        if (original.Contains("keep this")) Assert.Contains("keep this", first.Content);
        if (original.Contains("custom")) Assert.Contains("\"other\":{\"command\":\"custom\",\"env\":{\"PRIVATE\":\"do-not-log\"}}", first.Content);
        if (original.Contains("caf")) Assert.Contains("caf\u00e9", first.Content);
    }

    [Fact]
    public void ConflictRequiresForceAndReplacementPreservesOtherText()
    {
        const string original = "{\"servers\":{\"sf-maui-mcp\":{\"command\":\"old\"},\"other\":{\"command\":\"keep\"}},\"inputs\":[]}";
        var client = AiCatalog.Client("vscode");
        var server = McpConfiguration.Server(AiCatalog.Platform("maui"), client, "external.key", false);
        Assert.Throws<InvalidOperationException>(() => McpConfiguration.Merge(original, client, "sf-maui-mcp", server, false));
        var result = McpConfiguration.Merge(original, client, "sf-maui-mcp", server, true);
        Assert.Contains("\"other\":{\"command\":\"keep\"}", result.Content);
        Assert.Contains("\"inputs\":[]", result.Content);
        Assert.DoesNotContain("\"old\"", result.Content);
    }

    [Theory]
    [InlineData("[]")]
    [InlineData("{\"servers\":null}")]
    [InlineData("{\"servers\":[],\"another\":123}")]
    [InlineData("{\"servers\":{},\"servers\":{}}")]
    [InlineData("{\"servers\":{\"other\":{\"env\":{\"x\":1,\"x\":2}}}}")]
    public void InvalidConfigurationIsRejectedWithoutReplacingAnything(string original)
    {
        var client = AiCatalog.Client("vscode");
        Assert.Throws<InvalidOperationException>(() => McpConfiguration.Merge(original, client, "sf-maui-mcp", new JsonObject(), true));
    }

    [Theory]
    [MemberData(nameof(AiCommandTests.PlatformClients), MemberType = typeof(AiCommandTests))]
    public async Task SetupWritesOnlyTheSelectedClientAndNeverCopiesKeyContents(string platformName, string package, string clientName)
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner();
        var service = new McpSetupService(runner);
        var request = new McpSetupRequest(platformName, clientName, temp.Workspace, temp.KeyFile);
        var first = await service.SetupAsync(request);
        Assert.True(first.Changed);
        Assert.False(first.ConnectionVerified);
        Assert.Equal("dnx", first.Runner);
        var contents = File.ReadAllText(first.ConfigurationPath);
        Assert.Contains(package, contents);
        Assert.DoesNotContain("not-a-real-credential", contents);
        var client = AiCatalog.Client(clientName);
        Assert.Equal(Path.Combine(temp.Workspace, client.ConfigDirectory, client.ConfigFile), first.ConfigurationPath);
        var before = File.GetLastWriteTimeUtc(first.ConfigurationPath);
        var second = await service.SetupAsync(request);
        Assert.False(second.Changed);
        Assert.Equal(contents, File.ReadAllText(first.ConfigurationPath));
        Assert.Equal(before, File.GetLastWriteTimeUtc(first.ConfigurationPath));
        Assert.All(runner.Calls, args => Assert.Equal(new[] { "--version" }, args));
        Assert.Single(Directory.GetFiles(temp.Workspace, "*", SearchOption.AllDirectories));
    }

    [Theory]
    [InlineData("8.0.400", "maui", "syncfusion-maui-mcp")]
    [InlineData("9.0.200", "blazor", "syncfusion-blazor-mcp")]
    [InlineData("9.0.200", "wpf", "syncfusion-wpf-mcp")]
    [InlineData("8.0.400", "winforms", "syncfusion-winforms-mcp")]
    [InlineData("10.0.403", "winui", "syncfusion-winui-mcp")]
    public async Task LocalRunnerInstallsTheExactToolWithoutGlobalInstallation(string sdk, string platform, string tool)
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner(sdk);
        var request = new McpSetupRequest(platform, "vscode", temp.Workspace, temp.KeyFile,
            Runner: sdk.StartsWith("10", StringComparison.Ordinal) ? "local" : "auto");
        var result = await new McpSetupService(runner).SetupAsync(request);
        Assert.Equal("local", result.Runner);
        var root = JsonNode.Parse(File.ReadAllText(result.ConfigurationPath))!;
        Assert.Equal(tool, root["servers"]![$"sf-{platform}-mcp"]!["args"]![2]!.GetValue<string>());
        Assert.Contains(runner.Calls, args => args.Take(3).SequenceEqual(["tool", "install", AiCatalog.Platform(platform).McpPackage]));
        Assert.DoesNotContain(runner.Calls.SelectMany(args => args), arg => arg is "--global" or "-g");
        Assert.True(File.Exists(Path.Combine(temp.Workspace, ".config", "dotnet-tools.json")));
    }

    [Fact]
    public async Task ExistingLocalEntryIsIdempotentWhenAutoSelectsAnOlderSdk()
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner("9.0.200");
        var service = new McpSetupService(runner);
        var request = new McpSetupRequest("maui", "cursor", temp.Workspace, temp.KeyFile);
        var first = await service.SetupAsync(request);
        var second = await service.SetupAsync(request);
        Assert.True(first.Changed);
        Assert.False(second.Changed);
        Assert.Contains(runner.Calls, args => args.Take(2).SequenceEqual(["tool", "restore"]));
    }

    [Theory]
    [InlineData("7.0.400", "auto")]
    [InlineData("9.0.200", "dnx")]
    [InlineData("not-an-sdk", "auto")]
    public async Task UnsupportedSdkDoesNotWriteConfiguration(string sdk, string mode)
    {
        using var temp = new AiTestDirectory();
        await Assert.ThrowsAsync<InvalidOperationException>(() => new McpSetupService(new RecordingAiRunner(sdk))
            .SetupAsync(new("maui", "vscode", temp.Workspace, temp.KeyFile, Runner: mode)));
        Assert.Empty(Directory.GetFileSystemEntries(temp.Workspace));
    }

    [Theory]
    [InlineData("{broken")]
    [InlineData("{\"servers\":[]}")]
    [InlineData("{\"servers\":{\"sf-maui-mcp\":{\"command\":\"custom\"}}}")]
    public async Task InvalidOrConflictingConfigurationIsNotOverwrittenOrInstalled(string contents)
    {
        using var temp = new AiTestDirectory();
        var path = Path.Combine(temp.Workspace, ".vscode", "mcp.json");
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        File.WriteAllText(path, contents);
        var runner = new RecordingAiRunner("9.0.200");
        var action = () => new McpSetupService(runner).SetupAsync(new("maui", "vscode", temp.Workspace, temp.KeyFile));
        if (contents == "{broken") await Assert.ThrowsAnyAsync<JsonException>(action);
        else await Assert.ThrowsAsync<InvalidOperationException>(action);
        Assert.Equal(contents, File.ReadAllText(path));
        Assert.DoesNotContain(runner.Calls, args => args.Contains("install"));
    }

    [Fact]
    public async Task ToolInstallFailureDoesNotSaveClientConfiguration()
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner("9.0.200") { ToolExitCode = 17 };
        var error = await Assert.ThrowsAsync<AiToolException>(() => new McpSetupService(runner)
            .SetupAsync(new("maui", "vscode", temp.Workspace, temp.KeyFile)));
        Assert.Equal(17, error.ExitCode);
        Assert.False(Directory.Exists(Path.Combine(temp.Workspace, ".vscode")));
        Assert.Contains("install", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task CancellationDuringInstallDoesNotSaveClientConfiguration()
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner("9.0.200") { CancelOnInstall = true };
        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => new McpSetupService(runner)
            .SetupAsync(new("maui", "vscode", temp.Workspace, temp.KeyFile)));
        Assert.False(Directory.Exists(Path.Combine(temp.Workspace, ".vscode")));
    }

    [Fact]
    public async Task ConcurrentConfigurationChangesAreNotOverwritten()
    {
        using var temp = new AiTestDirectory();
        var path = Path.Combine(temp.Workspace, ".mcp.json");
        File.WriteAllText(path, "{}");
        var runner = new RecordingAiRunner { AfterVersion = () => File.WriteAllText(path, "{\"userEdit\":true}") };
        await Assert.ThrowsAsync<InvalidOperationException>(() => new McpSetupService(runner)
            .SetupAsync(new("maui", "claude-code", temp.Workspace, temp.KeyFile)));
        Assert.Equal("{\"userEdit\":true}", File.ReadAllText(path));
        Assert.Single(Directory.GetFiles(temp.Workspace));
    }

    [Fact]
    public async Task CredentialsInsideWorkspaceAreRejectedWithoutExecutingTools()
    {
        using var temp = new AiTestDirectory();
        var inside = Path.Combine(temp.Workspace, "key.txt");
        File.Copy(temp.KeyFile, inside);
        var runner = new RecordingAiRunner();
        await Assert.ThrowsAsync<ArgumentException>(() => new McpSetupService(runner)
            .SetupAsync(new("maui", "cursor", temp.Workspace, inside)));
        Assert.Empty(runner.Calls);
        Assert.Single(Directory.GetFiles(temp.Workspace));
    }

    [Theory]
    [InlineData("mcp")]
    [InlineData("skills")]
    public async Task DryRunDoesNotEvenLocateOrExecuteExternalTools(string operation)
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner();
        if (operation == "mcp")
            await new McpSetupService(runner).SetupAsync(new("maui", "cursor", temp.Workspace, temp.KeyFile, DryRun: true));
        else
            await new SkillsInstaller(runner, () => throw new InvalidOperationException("Must not locate Node"))
                .InstallAsync(new("maui", temp.Workspace, ["cursor"], [], All: true, Yes: true, DryRun: true));
        Assert.Empty(runner.Calls);
        Assert.Empty(runner.ProcessCalls);
        Assert.Empty(Directory.GetFileSystemEntries(temp.Workspace));
    }

    [Fact]
    public async Task SkillsRunsNpxThroughNodeWithArgumentBoundariesAndTelemetryDisabled()
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner("v22.20.0");
        const string skill = "component with spaces;$(not-a-command)";
        var request = new SkillsInstallRequest("maui", temp.Workspace, ["cursor", "claude-code"], [skill], Global: true, Yes: true);
        var result = await new SkillsInstaller(runner, () => new("node-test", "npx entry.js")).InstallAsync(request);
        var invocation = Assert.Single(runner.ProcessCalls);
        Assert.Equal("node-test", invocation.Executable);
        Assert.Equal("npx entry.js", invocation.Arguments[0]);
        Assert.Contains(SkillsInstaller.SkillsPackage, invocation.Arguments);
        Assert.Contains(skill, invocation.Arguments);
        Assert.Contains("--global", invocation.Arguments);
        Assert.Contains("--copy", invocation.Arguments);
        Assert.Equal("1", invocation.Environment!["DISABLE_TELEMETRY"]);
        Assert.Equal("1", invocation.Environment["DO_NOT_TRACK"]);
        Assert.False(invocation.InheritConsole);
        Assert.Equal("completed", result.Status);
    }

    [Theory]
    [InlineData("v16.20.0")]
    [InlineData("v22.19.0")]
    [InlineData("not-node")]
    public async Task SkillsRejectsUnsupportedNodeBeforeInstalling(string version)
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner(version);
        await Assert.ThrowsAsync<InvalidOperationException>(() => new SkillsInstaller(runner, () => new("node", "npx.js"))
            .InstallAsync(new("maui", temp.Workspace, ["cursor"], [], All: true, Yes: true)));
        Assert.Empty(runner.ProcessCalls);
    }

    [Fact]
    public async Task SkillsPreservesFailureAndListDoesNotRequireInstallConfirmation()
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner("v24.0.0") { ToolExitCode = 19 };
        var error = await Assert.ThrowsAsync<AiToolException>(() => new SkillsInstaller(runner, () => new("node", "npx.js"))
            .InstallAsync(new("wpf", temp.Workspace, [], [], List: true)));
        Assert.Equal(19, error.ExitCode);
        Assert.Contains("--list", Assert.Single(runner.ProcessCalls).Arguments);
    }

    [Fact]
    public async Task InteractiveSkillsInheritsTheConsoleWithoutForcingAllSkillsOrAgents()
    {
        using var temp = new AiTestDirectory();
        var runner = new RecordingAiRunner("v22.20.0");
        await new SkillsInstaller(runner, () => new("node", "npx.js"))
            .InstallAsync(new("maui", temp.Workspace, [], [], Interactive: true));
        var call = Assert.Single(runner.ProcessCalls);
        Assert.True(call.InheritConsole);
        Assert.DoesNotContain("--skill", call.Arguments);
        Assert.DoesNotContain("--agent", call.Arguments);
        Assert.DoesNotContain("--all", call.Arguments);
        Assert.DoesNotContain("--yes", call.Arguments.Skip(2));
    }

    [Theory]
    [InlineData(false, false, false)]
    [InlineData(true, false, true)]
    [InlineData(false, true, true)]
    [InlineData(true, true, false)]
    public void NoninteractiveSkillsRequiresAnExplicitSelectionAgentAndConfirmation(bool agent, bool all, bool yes)
    {
        using var temp = new AiTestDirectory();
        Assert.Throws<ArgumentException>(() => SkillsInstaller.BuildArguments(
            new("maui", temp.Workspace, agent ? ["cursor"] : [], [], All: all, Yes: yes)));
    }

    [Fact]
    public async Task LinkedClientDirectoryIsRejectedBeforeExecutingAnyTool()
    {
        using var temp = new AiTestDirectory();
        var target = Path.Combine(Path.GetDirectoryName(temp.KeyFile)!, "outside");
        Directory.CreateDirectory(target);
        var link = Path.Combine(temp.Workspace, ".vscode");
        if (OperatingSystem.IsWindows())
        {
            var script = "$ErrorActionPreference='Stop'; New-Item -ItemType Junction -Path '"
                + link.Replace("'", "''") + "' -Target '" + target.Replace("'", "''") + "' | Out-Null";
            var encoded = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(script));
            var result = await new ToolRunner().RunAsync(
                ["-NoProfile", "-NonInteractive", "-EncodedCommand", encoded], executable: "powershell.exe");
            Assert.True(result.Success, result.Error);
        }
        else Directory.CreateSymbolicLink(link, target);
        try
        {
            var runner = new RecordingAiRunner();
            await Assert.ThrowsAsync<InvalidOperationException>(() => new McpSetupService(runner)
                .SetupAsync(new("maui", "vscode", temp.Workspace, temp.KeyFile)));
            Assert.Empty(runner.Calls);
            Assert.Empty(Directory.GetFileSystemEntries(target));
        }
        finally { Directory.Delete(link); }
    }

    [Theory]
    [InlineData("maui", "Syncfusion.Maui.MCP")]
    [InlineData("blazor", "Syncfusion.Blazor.MCP")]
    [InlineData("wpf", "Syncfusion.WPF.MCP")]
    [InlineData("winforms", "Syncfusion.WinForms.MCP")]
    [InlineData("winui", "Syncfusion.WinUI.MCP")]
    public async Task RealCliPersistsMcpConfigurationAndRepeatsWithoutRewriting(string platform, string package)
    {
        using var temp = new AiTestDirectory();
        var tests = typeof(AiIntegrationTests).Assembly.Location;
        var executable = typeof(CliApp).Assembly.Location;
        var hostArguments = new[]
        {
            "exec", "--runtimeconfig", Path.ChangeExtension(tests, ".runtimeconfig.json"),
            "--depsfile", Path.ChangeExtension(tests, ".deps.json"), executable,
        };
        var arguments = hostArguments.Concat([
            "mcp", "init", platform, "--client", "claude-code", "--runner", "dnx",
            "--key-file", temp.KeyFile, "--path", temp.Workspace, "--json", "--no-interactive",
        ]).ToArray();
        var runner = new ToolRunner();
        var first = await runner.RunAsync(arguments, temp.Workspace);
        Assert.True(first.Success, first.Error);
        using var response = JsonDocument.Parse(first.Output);
        Assert.True(response.RootElement.GetProperty("changed").GetBoolean());
        var path = Path.Combine(temp.Workspace, ".mcp.json");
        var bytes = File.ReadAllBytes(path);
        using var config = JsonDocument.Parse(bytes);
        var server = config.RootElement.GetProperty("mcpServers").GetProperty($"sf-{platform}-mcp");
        Assert.Equal(package, server.GetProperty("args")[0].GetString());
        Assert.Equal(temp.KeyFile, server.GetProperty("env").GetProperty("Syncfusion_API_Key_Path").GetString());
        Assert.DoesNotContain("not-a-real-credential", first.Output + File.ReadAllText(path));
        var second = await runner.RunAsync(arguments, temp.Workspace);
        Assert.True(second.Success, second.Error);
        using var secondResponse = JsonDocument.Parse(second.Output);
        Assert.False(secondResponse.RootElement.GetProperty("changed").GetBoolean());
        Assert.Equal(bytes, File.ReadAllBytes(path));
    }
}

internal sealed class RecordingAiRunner(string version = "10.0.403") : ToolRunner
{
    public List<string[]> Calls { get; } = [];
    public List<(string? Executable, IReadOnlyList<string> Arguments, bool InheritConsole, IReadOnlyDictionary<string, string>? Environment)> ProcessCalls { get; } = [];
    public int ToolExitCode { get; init; }
    public bool CancelOnInstall { get; init; }
    public Action? AfterVersion { get; init; }

    public override Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null,
        CancellationToken cancellationToken = default, string? executable = null)
    {
        cancellationToken.ThrowIfCancellationRequested();
        Calls.Add(args.ToArray());
        if (args.SequenceEqual(["--version"]))
        {
            AfterVersion?.Invoke();
            return Task.FromResult(new ToolResult(0, version, ""));
        }
        if (args.Take(2).SequenceEqual(["new", "tool-manifest"]))
        {
            var path = Path.Combine(directory!, ".config", "dotnet-tools.json");
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            File.WriteAllText(path, "{\"version\":1,\"isRoot\":true,\"tools\":{}}");
        }
        if (args.Contains("install"))
        {
            if (CancelOnInstall) throw new OperationCanceledException(cancellationToken);
            if (ToolExitCode == 0)
            {
                var path = Path.Combine(directory!, ".config", "dotnet-tools.json");
                var manifest = JsonNode.Parse(File.ReadAllText(path))!;
                manifest["tools"]![args[2].ToLowerInvariant()] = new JsonObject { ["version"] = "2.0.0" };
                File.WriteAllText(path, manifest.ToJsonString());
            }
        }
        return Task.FromResult(new ToolResult(args[0] == "new" ? 0 : ToolExitCode, "", ToolExitCode == 0 ? "" : "Tool failed"));
    }

    public override Task<ToolResult> RunProcessAsync(IReadOnlyList<string> args, string? directory = null,
        CancellationToken cancellationToken = default, string? executable = null, bool inheritConsole = false,
        IReadOnlyDictionary<string, string>? environment = null)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ProcessCalls.Add((executable, args.ToArray(), inheritConsole, environment));
        return Task.FromResult(new ToolResult(ToolExitCode, "Skills output", ToolExitCode == 0 ? "" : "Skills failed"));
    }
}
