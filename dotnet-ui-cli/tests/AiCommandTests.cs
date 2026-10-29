using System.Text.Json;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Core.AI;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Hosting;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class AiCommandTests
{
    public static IEnumerable<object[]> PlatformClients()
    {
        foreach (var (platform, package) in new[]
        {
            ("maui", "Syncfusion.Maui.MCP"), ("blazor", "Syncfusion.Blazor.MCP"),
            ("wpf", "Syncfusion.WPF.MCP"), ("winforms", "Syncfusion.WinForms.MCP"),
            ("winui", "Syncfusion.WinUI.MCP"),
        })
            foreach (var client in new[] { "vscode", "cursor", "codestudio", "claude-code" })
                yield return [platform, package, client];
    }

    [Theory]
    [MemberData(nameof(PlatformClients))]
    public async Task McpDryRunSupportsEveryPlatformAndClientWithoutWritingFiles(string platform, string package, string client)
    {
        using var temp = new AiTestDirectory();
        using var capture = new ConsoleCapture();
        var exit = await CliApp.Build().RunAsync([
            "mcp", "init", platform, "--client", client, "--key-file", temp.KeyFile,
            "--path", temp.Workspace, "--dry-run", "--json", "--no-interactive",
        ]);
        Assert.Equal(ExitCodes.Success, exit);
        using var document = JsonDocument.Parse(capture.Out);
        var result = document.RootElement;
        Assert.True(result.GetProperty("dryRun").GetBoolean());
        Assert.False(result.GetProperty("connectionVerified").GetBoolean());
        Assert.Equal(package, result.GetProperty("package").GetString());
        Assert.Equal(client, result.GetProperty("client").GetString());
        Assert.Empty(Directory.GetFileSystemEntries(temp.Workspace));
        Assert.DoesNotContain("not-a-real-credential", capture.Out + capture.Error);
    }

    [Theory]
    [MemberData(nameof(PlatformClients))]
    public async Task SkillsDryRunUsesOfficialRepositoryAndExplicitAgent(string platform, string _, string client)
    {
        using var temp = new AiTestDirectory();
        using var capture = new ConsoleCapture();
        var agent = client == "vscode" ? "github-copilot" : client;
        var exit = await CliApp.Build().RunAsync([
            "skills", "install", platform, "--agent", agent, "--all", "--yes",
            "--path", temp.Workspace, "--dry-run", "--json", "--no-interactive",
        ]);
        Assert.Equal(ExitCodes.Success, exit);
        using var document = JsonDocument.Parse(capture.Out);
        var result = document.RootElement;
        Assert.Equal($"syncfusion/{platform}-ui-components-skills", result.GetProperty("repository").GetString());
        var args = result.GetProperty("arguments").EnumerateArray().Select(value => value.GetString()).ToArray();
        Assert.Contains(agent, args);
        Assert.Contains("*", args);
        Assert.DoesNotContain("--all", args);
        Assert.Empty(Directory.GetFileSystemEntries(temp.Workspace));
    }

    [Theory]
    [InlineData("mcp", "init")]
    [InlineData("skills", "install")]
    public async Task MissingInputsAreJsonErrorsWithoutPrompts(string command, string operation)
    {
        using var capture = new ConsoleCapture();
        var exit = await CliApp.Build().RunAsync([command, operation, "--json", "--no-interactive"]);
        Assert.Equal(ExitCodes.Error, exit);
        using var document = JsonDocument.Parse(capture.Out);
        Assert.False(document.RootElement.GetProperty("success").GetBoolean());
        Assert.Contains("platform", document.RootElement.GetProperty("error").GetString(), StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("react", "cursor", "--all")]
    [InlineData("maui", "unknown", "--all")]
    [InlineData("maui", "cursor", "--skill")]
    public async Task SkillsRejectsInvalidInputsBeforeStartingAnyInstaller(string platform, string agent, string selection)
    {
        using var temp = new AiTestDirectory();
        using var capture = new ConsoleCapture();
        var args = new List<string> { "skills", "install", platform, "--agent", agent, selection };
        if (selection == "--skill") args.Add("--bad-name");
        args.AddRange(["--path", temp.Workspace, "--yes", "--no-interactive"]);
        Assert.NotEqual(ExitCodes.Success, await CliApp.Build().RunAsync(args.ToArray()));
        Assert.Empty(Directory.GetFileSystemEntries(temp.Workspace));
    }

    [Fact]
    public async Task SkillsFailurePropagatesExitCodeAndProducesOneJsonDocument()
    {
        using var temp = new AiTestDirectory();
        using var capture = new ConsoleCapture();
        var result = await AiCommands.InstallSkillsAsync(new() { Json = true, NoInteractive = true },
            new ConsolePresenter(true, json: true), default,
            new("maui", temp.Workspace, ["cursor"], [], All: true, Yes: true),
            new RecordingAiRunner("v22.20.0") { ToolExitCode = 23 }, () => new("node", "npx.js"));
        Assert.Equal(23, result);
        using var document = JsonDocument.Parse(capture.Out);
        Assert.False(document.RootElement.GetProperty("success").GetBoolean());
        Assert.Contains("23", document.RootElement.GetProperty("error").GetString());
    }

    [Fact]
    public async Task McpCancellationHasAJsonErrorAndNoClientFile()
    {
        using var temp = new AiTestDirectory();
        using var capture = new ConsoleCapture();
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();
        var result = await AiCommands.SetupMcpAsync(new() { Json = true, NoInteractive = true },
            new ConsolePresenter(true, json: true), cancellation.Token,
            new("maui", "cursor", temp.Workspace, temp.KeyFile), new RecordingAiRunner());
        Assert.Equal(ExitCodes.Cancelled, result);
        using var document = JsonDocument.Parse(capture.Out);
        Assert.True(document.RootElement.GetProperty("cancelled").GetBoolean());
        Assert.Empty(Directory.GetFileSystemEntries(temp.Workspace));
    }

    [Theory]
    [InlineData("mcp", "init", "--key-file", "--runner")]
    [InlineData("skills", "install", "--agent", "--skill")]
    public async Task NestedHelpShowsItsOwnRequiredOptions(string command, string operation, string firstOption, string secondOption)
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync([command, operation, "--help"]));
        Assert.Contains(firstOption, capture.Out);
        Assert.Contains(secondOption, capture.Out);
        Assert.Contains("--dry-run", capture.Out);
        Assert.DoesNotContain("sf new maui", capture.Out);
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(false, true)]
    [InlineData(true, false)]
    public async Task McpCompletionHasSuccessMarkerAndOneBlankLineBeforeInstructions(bool dryRun, bool alreadyConfigured)
    {
        using var temp = new AiTestDirectory();
        using var capture = new ConsoleCapture();
        var originalConsole = Spectre.Console.AnsiConsole.Console;
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings
        {
            Ansi = Spectre.Console.AnsiSupport.No,
            Out = new Spectre.Console.AnsiConsoleOutput(Console.Out),
        });
        console.Profile.Capabilities.Unicode = true;
        Spectre.Console.AnsiConsole.Console = console;
        try
        {
            var request = new McpSetupRequest("maui", "vscode", temp.Workspace, temp.KeyFile, DryRun: dryRun);
            if (alreadyConfigured) await new McpSetupService(new RecordingAiRunner()).SetupAsync(request);
            var exit = await AiCommands.SetupMcpAsync(new() { NoInteractive = true, NoColor = true },
                new ConsolePresenter(true), default, request, new RecordingAiRunner());
            Assert.Equal(0, exit);
            var lines = capture.Out.Split(Environment.NewLine);
            Assert.Equal(5, lines.Length);
            if (dryRun)
            {
                Assert.StartsWith("MCP setup preview:", lines[0]);
                Assert.DoesNotContain("✓", lines[0]);
            }
            else Assert.StartsWith(alreadyConfigured ? "✓ MCP configuration already up to date:" : "✓ MCP configuration saved:", lines[0]);
            Assert.Equal("", lines[1]);
            Assert.StartsWith("Connection not verified.", lines[2]);
            Assert.StartsWith("Then ask a Syncfusion documentation question.", lines[3]);
            Assert.DoesNotContain('\u001b', capture.Out);
        }
        finally { Spectre.Console.AnsiConsole.Console = originalConsole; }
    }
}

internal sealed class AiTestDirectory : IDisposable
{
    private readonly string _root = Path.Combine(Path.GetTempPath(), "sf-ai-tests-" + Guid.NewGuid().ToString("N"));
    public string Workspace { get; }
    public string KeyFile { get; }

    public AiTestDirectory()
    {
        Workspace = Path.Combine(_root, "workspace with spaces");
        KeyFile = Path.Combine(_root, "api-key.txt");
        Directory.CreateDirectory(Workspace);
        File.WriteAllText(KeyFile, "not-a-real-credential");
    }

    public void Dispose() => Directory.Delete(_root, recursive: true);
}
