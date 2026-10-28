using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Hosting;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>Checks the supported command, package, and template vocabulary.</summary>
[Collection("Console output")]
public static class CommandTaxonomyTests
{
    public static IEnumerable<object[]> DisabledRemovalCases()
    {
        foreach (var platform in new[] { "maui", "blazor", "wpf", "winforms", "winui" })
        {
            yield return [new[] { "remove", platform, "datagrid" }];
            yield return [new[] { "remove", "datagrid", platform }];
            yield return [new[] { "remove", platform, "--control", "datagrid" }];
            yield return [new[] { "remove", platform, "--template", "datagrid" }];
            yield return [new[] { "remove", "datagrid", "--framework", platform }];
            yield return [new[] { "remove", platform }];
        }
    }

    [Theory]
    [MemberData(nameof(DisabledRemovalCases))]
    public static async Task RemovalCommandsAreRejectedWithoutChangingAnyProjectFiles(string[] command)
    {
        var directory = CreateProjectDirectory();
        try
        {
            WriteProject(directory, "MauiApp.csproj", true, true);
            File.WriteAllText(Path.Combine(directory, "Sample.cs"), "// Existing sample must remain.");
            var before = Directory.GetFiles(directory).ToDictionary(path => Path.GetFileName(path)!, File.ReadAllText);
            var result = await RunCapturedAsync(command.Concat(new[] { "--path", directory, "--no-interactive" }).ToArray());
            Assert.NotEqual(ExitCodes.Success, result.ExitCode);
            Assert.Equal(before.OrderBy(file => file.Key), Directory.GetFiles(directory)
                .ToDictionary(path => Path.GetFileName(path)!, File.ReadAllText).OrderBy(file => file.Key));
        }
        finally { Directory.Delete(directory, true); }
    }

    [Theory]
    [InlineData("maui")]
    [InlineData("blazor")]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public static async Task PreservedRemoveCommandFactoryCannotExecuteRemoval(string platform)
    {
        using var capture = new ConsoleCapture();
        var parsed = Syncfusion.DotNet.CLI.Commands.RemoveCommand.Create().Parse([platform, "datagrid"]);
        var exitCode = await parsed.InvokeAsync(parsed.InvocationConfiguration);
        Assert.NotEqual(ExitCodes.Success, exitCode);
        Assert.Contains("temporarily unavailable", capture.Error);
    }

    [Theory]
    [InlineData("maui")]
    [InlineData("blazor")]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public static async Task PlatformHelpDoesNotOfferDisabledRemoval(string platform)
    {
        var result = await RunCapturedAsync("help", platform, "--no-interactive");
        Assert.Equal(ExitCodes.Success, result.ExitCode);
        Assert.DoesNotContain("sf remove", result.Stdout);
        Assert.Contains("sf add", result.Stdout);
        Assert.Contains("sf update", result.Stdout);
    }

    [Fact]
    public static void OperableTemplates_AreExactlyTheApprovedFamilies()
    {
        var approved = new[] { "assistview", "cartesian-chart", "circular-chart", "datagrid", "diagram", "kanban", "listview", "pdf-viewer", "rich-text-editor", "scheduler" };

        Assert.Equal(
            approved.Order(StringComparer.Ordinal),
            DiscoveryService.ListTemplates().Select(template => template.TemplateId).Order(StringComparer.Ordinal));
    }

    [Fact]
    public static void PackageResolution_UsesPackageAliasesAndExactPackageIdsOnly()
    {
        Assert.True(PackageCatalog.TryResolve("CHARTS", out var alias));
        Assert.Equal("charts", alias.Alias);
        Assert.True(PackageCatalog.TryResolve("Syncfusion.Maui.DataGrid", out var packageId));
        Assert.Equal("datagrid", packageId.Alias);
        Assert.True(PackageCatalog.TryResolve("Syncfusion DataGrid for .NET MAUI", out var displayName));
        Assert.Equal("datagrid", displayName.Alias);
        Assert.False(PackageCatalog.TryResolve("sfdatagrid", out _));
        Assert.False(PackageCatalog.TryResolve("combobox", out _));
        Assert.True(PackageCatalog.TryResolve("core", out var core));
        Assert.Equal("Syncfusion.Maui.Core", core.PackageId);
        Assert.False(PackageCatalog.TryResolve("data", out _));
    }

    [Fact]
    public static async Task JsonCommands_WriteOneJsonDocumentToStdout()
    {
        var project = CreateProjectDirectory();
        try
        {
            WriteProject(project, "MauiApp.csproj", isMaui: true, packageReference: true);
            var commands = new[]
            {
                new[] { "add", "maui", "core", "--dry-run", "-p", project },
                new[] { "add", "maui", "--template", "datagrid", "--dry-run", "-p", project },
                new[] { "update", "maui", "core", "--dry-run", "-p", project },
                new[] { "new", "maui", "-n", "NewApp", "-p", project, "--dry-run" },
                new[] { "list", "maui", "packages" },
                new[] { "list", "maui", "installed", "-p", project },
                new[] { "list", "maui", "templates" },
                new[] { "search", "maui", "datagrid" },
                new[] { "info" },
            };

            foreach (var command in commands)
            {
                var args = new string[command.Length + 2];
                Array.Copy(command, args, command.Length);
                args[^2] = "--json";
                args[^1] = "--no-interactive";
                var (exitCode, stdout, stderr) = await RunCapturedAsync(args);
                Assert.True(exitCode == ExitCodes.Success, $"Command '{string.Join(' ', args)}' failed: {stderr}");
                Assert.False(string.IsNullOrWhiteSpace(stdout), $"Command '{string.Join(' ', args)}' wrote no JSON to stdout. stderr: {stderr}");
                JsonDocument document;
                try
                {
                    document = JsonDocument.Parse(stdout);
                }
                catch (JsonException exception)
                {
                    throw new Xunit.Sdk.XunitException(
                        $"Command '{string.Join(' ', args)}' did not write one JSON document. stdout: {stdout}; stderr: {stderr}; {exception.Message}");
                }
                using (document)
                {
                    Assert.NotEqual(JsonValueKind.Undefined, document.RootElement.ValueKind);
                }
            }
        }
        finally
        {
            Directory.Delete(project, recursive: true);
        }
    }

    [Fact]
    public static async Task PackageJsonResult_ReportsCanonicalAliasAndPackageId()
    {
        var project = CreateProjectDirectory();
        try
        {
            var (exitCode, stdout, _) = await RunCapturedAsync(
                "add", "maui", "Syncfusion.Maui.Core", "--dry-run", "-p", project, "--json", "--no-interactive");
            Assert.Equal(ExitCodes.Success, exitCode);
            using var document = JsonDocument.Parse(stdout);
            Assert.Equal("core", document.RootElement.GetProperty("packageAlias").GetString());
            Assert.Equal("Syncfusion.Maui.Core", document.RootElement.GetProperty("packageId").GetString());
            Assert.Equal(Path.Combine(project, "MauiApp.csproj"), document.RootElement.GetProperty("projectPath").GetString());
        }
        finally
        {
            Directory.Delete(project, recursive: true);
        }
    }

    [Fact]
    public static async Task LegacyGeneratedContentListingUsesControlWording()
    {
        var (exitCode, stdout, stderr) = await RunCapturedAsync(
            "list", "maui", "templates", "--no-interactive");

        Assert.Equal(ExitCodes.Success, exitCode);
        Assert.Empty(stderr);
        Assert.Contains("Available Syncfusion MAUI controls", stdout);
        Assert.DoesNotContain("template", stdout, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public static async Task PackageOnlyOperation_DoesNotGenerateTemplateFiles()
    {
        var directory = CreateProjectDirectory();
        try
        {
            Assert.True(PackageCatalog.TryResolve("datagrid", out var package));
            var runner = new RecordingNuGetRunner();
            var project = MauiProjectResolver.Resolve(directory);
            var result = await new PackageOperationService(runner).ExecuteAsync(
                project,
                package,
                NuGetOperationKind.Add,
                noRestore: true);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.Equal("datagrid", result.Alias);
            Assert.Equal("Syncfusion.Maui.DataGrid", runner.Operation!.PackageId);
            Assert.False(Directory.Exists(Path.Combine(directory, "Syncfusion")));
            Assert.Single(Directory.GetFiles(directory));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Fact]
    public static async Task PackageFailure_ReportsSanitizedNuGetDiagnostics()
    {
        var directory = CreateProjectDirectory();
        const string source = NuGetSources.DefaultPublicFeed;
        const string configFile = "/private/nuget.config";
        const string diagnostic = "Package not found.";
        try
        {
            Assert.True(PackageCatalog.TryResolve("datagrid", out var package));
            var project = MauiProjectResolver.Resolve(directory);
            var result = await new PackageOperationService(
                new FailingNuGetRunner(source, configFile, diagnostic)).ExecuteAsync(
                    project,
                    package,
                    NuGetOperationKind.Add,
                    source: source,
                    configFile: configFile);

            Assert.Contains(diagnostic, result.Error, StringComparison.Ordinal);
            Assert.DoesNotContain(source, result.Error, StringComparison.Ordinal);
            Assert.DoesNotContain(configFile, result.Error, StringComparison.Ordinal);

            using (var capture = new ConsoleCapture())
            {
                CommandOperations.ReportPackageResult(
                    new ConsolePresenter(noColor: true),
                    new GlobalOptions { Json = true },
                    result);
                using var json = JsonDocument.Parse(capture.Out);
                Assert.Contains(diagnostic, json.RootElement.GetProperty("error").GetString(), StringComparison.Ordinal);
            }

            using (var capture = new ConsoleCapture())
            {
                CommandOperations.ReportPackageResult(
                    new ConsolePresenter(noColor: true),
                    new GlobalOptions(),
                    result);
                Assert.Contains(diagnostic, capture.Error, StringComparison.Ordinal);
            }
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Theory]
    [InlineData("charts", "Syncfusion.Maui.Charts")]
    [InlineData("datagrid", "Syncfusion.Maui.DataGrid")]
    [InlineData("inputs", "Syncfusion.Maui.Inputs")]
    [InlineData("smart-pdf-viewer", "Syncfusion.Maui.SmartPdfViewer")]
    public static async Task AddPackage_DryRunAddsOnlyRequestedNuGetPackage(string packageAlias, string expectedPackageId)
    {
        var directory = CreateProjectDirectory();
        try
        {
            var (exitCode, stdout, stderr) = await RunCapturedAsync(
                "add", "maui", packageAlias, "--dry-run", "-p", directory, "--json", "--no-interactive");

            Assert.Equal(ExitCodes.Success, exitCode);
            Assert.Empty(stderr);
            using var result = JsonDocument.Parse(stdout);
            Assert.Equal(expectedPackageId, result.RootElement.GetProperty("packageId").GetString());
            Assert.False(Directory.Exists(Path.Combine(directory, "Syncfusion")));
            Assert.Single(Directory.GetFiles(directory));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Fact]
    public static async Task Add_UnambiguousControlAlias_SelectsItsSample()
    {
        var directory = CreateProjectDirectory();
        try
        {
            var (exitCode, stdout, _) = await RunCapturedAsync(
                "add", "maui", "cartesian-chart", "--dry-run", "-p", directory, "--json", "--no-interactive");

            Assert.Equal(ExitCodes.Success, exitCode);
            using var result = JsonDocument.Parse(stdout);
            Assert.Contains("cartesian-chart", result.RootElement.GetRawText());
            Assert.Contains("Syncfusion.Maui.Charts", result.RootElement.GetRawText());
            Assert.False(Directory.Exists(Path.Combine(directory, "Syncfusion")));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Fact]
    public static async Task AddPackageAndTemplate_TargetsAreExplicitAndMutuallyExclusive()
    {
        var directory = CreateProjectDirectory();
        try
        {
            var (conflictCode, conflictOutput, _) = await RunCapturedAsync(
                "add", "maui", "datagrid", "--template", "combobox", "--dry-run", "-p", directory, "--json", "--no-interactive");
            Assert.Equal(ExitCodes.Error, conflictCode);
            using (var conflict = JsonDocument.Parse(conflictOutput))
            {
                Assert.Contains("cannot be combined with a control selection", conflict.RootElement.GetProperty("error").GetString(), StringComparison.OrdinalIgnoreCase);
            }

            var (templateCode, templateOutput, _) = await RunCapturedAsync(
                "add", "maui", "--template", "cartesian-chart", "--dry-run", "-p", directory, "--json", "--no-interactive");
            Assert.Equal(ExitCodes.Success, templateCode);
            using var template = JsonDocument.Parse(templateOutput);
            Assert.Equal("cartesian-chart", template.RootElement.GetProperty("templateId").GetString());
            Assert.Equal("Syncfusion.Maui.Charts", template.RootElement.GetProperty("requiredPackageId").GetString());
            Assert.NotEqual("package", template.RootElement.GetProperty("operation").GetString());
            Assert.False(Directory.Exists(Path.Combine(directory, "Syncfusion")));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Fact]
    public static void ProjectResolver_RejectsAmbiguityAndSelectsDeterministically()
    {
        var directory = CreateProjectDirectory();
        try
        {
            WriteProject(directory, "Second.csproj", isMaui: true);
            WriteProject(directory, "Other.csproj", isMaui: false);
            Assert.Throws<InvalidOperationException>(() => MauiProjectResolver.Resolve(directory));

            string[] candidates = [];
            var selected = MauiProjectResolver.Resolve(directory, projects =>
            {
                candidates = projects.Select(project => Path.GetFileName(project.CsprojPath)).ToArray();
                return projects[^1];
            });
            Assert.Equal(new[] { "MauiApp.csproj", "Second.csproj" }, candidates);
            Assert.Equal("Second.csproj", Path.GetFileName(selected.CsprojPath));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [CollectionDefinition("Console output", DisableParallelization = true)]
    public sealed class ConsoleOutputCollection
    {
    }

    [Fact]
    public static async Task Help_ListsDesktopPlatformsAndPreservesMauiSyntax()
    {
        var (rootExit, rootHelp, _) = await RunCapturedAsync("--help");
        Assert.Equal(ExitCodes.Success, rootExit);
        Assert.Contains("Usage: sf <action> <platform> <target>", rootHelp);
        Assert.Contains("sf add maui <package>", rootHelp);
        Assert.Contains("wpf", rootHelp.ToLowerInvariant());

        var (helpExit, mauiHelp, _) = await RunCapturedAsync("help", "maui");
        Assert.Equal(ExitCodes.Success, helpExit);
        Assert.Contains("Project", mauiHelp);
        Assert.Contains("Packages", mauiHelp);
        Assert.DoesNotContain(Environment.NewLine + "Controls" + Environment.NewLine, mauiHelp);
        Assert.Contains("Available package aliases:", mauiHelp);
        Assert.Contains("--control datagrid listview", mauiHelp);
        Assert.DoesNotContain("combobox", mauiHelp);
        Assert.DoesNotContain("template", mauiHelp, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("Discovery and information", mauiHelp);
    }

    [Fact]
    public static async Task VersionJson_IsOneDocument()
    {
        var (exitCode, stdout, stderr) = await RunCapturedAsync("--version", "--json");
        Assert.Equal(ExitCodes.Success, exitCode);
        Assert.Empty(stderr);
        using var document = JsonDocument.Parse(stdout);
        Assert.Equal("sf", document.RootElement.GetProperty("toolCommand").GetString());
    }

    private static string CreateProjectDirectory()
    {
        var directory = Path.Combine(Path.GetTempPath(), "sf-taxonomy-tests-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);
        WriteProject(directory, "MauiApp.csproj", isMaui: true);
        return directory;
    }

    private static void WriteProject(string directory, string name, bool isMaui, bool packageReference = false)
    {
        var project = isMaui
            ? $"<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup>{(packageReference ? "<ItemGroup><PackageReference Include=\"Syncfusion.Maui.Core\" Version=\"1.0.0\" /></ItemGroup>" : string.Empty)}</Project>"
            : "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>";
        File.WriteAllText(Path.Combine(directory, name), project);
    }

    private static async Task<(int ExitCode, string Stdout, string Stderr)> RunCapturedAsync(params string[] args)
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(args);
        return (exitCode, capture.Out, capture.Error);
    }

    [Theory]
    [InlineData("add", "--control")]
    [InlineData("add", "--template")]
    public static async Task ExplicitControlOptions_AcceptMultipleControlsWithoutPrompts(string command, string option)
    {
        var directory = CreateProjectDirectory();
        try
        {
            var (exitCode, stdout, _) = await RunCapturedAsync(command, "maui", option, "datagrid", "listview",
                "--dry-run", "--path", directory, "--json", "--no-interactive");
            Assert.Equal(ExitCodes.Success, exitCode);
            using var result = JsonDocument.Parse(stdout);
            Assert.True(result.RootElement.GetProperty("success").GetBoolean());
            Assert.Contains("datagrid", stdout);
            Assert.Contains("listview", stdout);
            Assert.False(Directory.Exists(Path.Combine(directory, "Syncfusion")));
        }
        finally { Directory.Delete(directory, true); }
    }

    private sealed class RecordingNuGetRunner : NuGetRunner
    {
        public NuGetOperation? Operation { get; private set; }

        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
        {
            Operation = operation;
            return Task.FromResult(new NuGetCommandResult
            {
                ExitCode = 0,
                StandardOutput = string.Empty,
                StandardError = string.Empty,
            });
        }
    }

    private sealed class FailingNuGetRunner(string source, string configFile, string diagnostic) : NuGetRunner
    {
        public override Task<NuGetCommandResult> RunAsync(
            NuGetOperation operation,
            CancellationToken cancellationToken = default)
            => Task.FromResult(new NuGetCommandResult
            {
                ExitCode = 1,
                StandardOutput = string.Empty,
                StandardError = $"{diagnostic} Source: {source} Config: {configFile}",
            });
    }
}
