using Spectre.Console;
using System.Text.Json;
using Syncfusion.DotNet.Cli.Commands.Operations;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Hosting;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Manifest;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class AddControlSelectionTests
{
    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void MauiPackageChoicesExcludeMcpWithoutRemovingApplicationPackages(bool existingProject)
    {
        using var project = new Project();
        var provider = existingProject
            ? new MauiControlSelectionProvider(project.Info)
            : new MauiControlSelectionProvider(MauiProjectType.App);
        var expected = PackageCatalog.All
            .Where(package => package.PackageId != "Syncfusion.Maui.MCP" && !HiddenPackages.IsHidden(package.PackageId))
            .OrderBy(package => package.DisplayName, StringComparer.OrdinalIgnoreCase);

        Assert.Equal(expected.Select(package => package.Alias), provider.Packages.Select(package => package.Id));
        Assert.DoesNotContain(provider.Packages, package => package.PackageId == "Syncfusion.Maui.MCP");
        Assert.True(PackageCatalog.TryResolve("mcp", out var mcp));
        Assert.Equal("Syncfusion.Maui.MCP", mcp.PackageId);
    }

    [Theory]
    [InlineData("mcp", false)]
    [InlineData("Syncfusion.Maui.MCP", false)]
    [InlineData("SYNCFUSION.MAUI.MCP", false)]
    [InlineData("mcp", true)]
    [InlineData("Syncfusion.Maui.MCP", true)]
    public async Task McpPackageAddIsRejectedBeforeProjectResolution(string package, bool json)
    {
        var missingPath = Path.Combine(Path.GetTempPath(), "sf-mcp-add-" + Guid.NewGuid().ToString("N"));
        using var capture = new ConsoleCapture();
        var args = new List<string> { "add", "maui", package, "--path", missingPath, "--no-interactive", "--no-color" };
        if (json) args.Add("--json");

        Assert.Equal(ExitCodes.Error, await CliApp.Build().RunAsync(args.ToArray()));
        var error = capture.Out + capture.Error;
        if (json)
        {
            using var document = JsonDocument.Parse(capture.Out);
            Assert.False(document.RootElement.GetProperty("success").GetBoolean());
            Assert.Equal(ExitCodes.Error, document.RootElement.GetProperty("exitCode").GetInt32());
            error = document.RootElement.GetProperty("error").GetString()!;
        }
        Assert.Contains("development tool", error, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("sfdotnet mcp init maui", error);
        Assert.False(Directory.Exists(missingPath));
    }

    [Fact]
    public async Task MauiHelpDoesNotAdvertiseMcpAsAnApplicationPackageAlias()
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(ExitCodes.Success, await CliApp.Build().RunAsync(["help", "maui", "--no-color", "--no-interactive"]));
        var aliases = capture.Out.Split("Available package aliases:", 2)[1]
            .Split("Package commands accept", 2)[0];
        Assert.DoesNotMatch(@"\bmcp\b", aliases);
        Assert.Contains("inputs", aliases);
    }

    [Fact]
    public void CreateAndAddShareCatalogNamesAndChartsResolveToOnePackage()
    {
        using var project = new Project();
        var create = new MauiControlSelectionProvider(MauiProjectType.App);
        var add = new MauiControlSelectionProvider(project.Info);
        Assert.Equal(create.Controls.Select(control => (control.Id, control.DisplayName)), add.Controls.Select(control => (control.Id, control.DisplayName)));
        Assert.Equal(new[] { "AI AssistView", "Cartesian Chart", "Circular Chart", "DataGrid", "Diagram", "Kanban", "ListView", "PDF Viewer", "Rich Text Editor", "Scheduler" }, add.Controls.Select(control => control.DisplayName));
        Assert.DoesNotContain(add.Controls, control => control.DisplayName == "Welcome");
        Assert.Equal(new[] { "Syncfusion.Maui.Charts" }, add.ResolvePackages(["cartesian-chart", "circular-chart"]));
        foreach (var alias in new[] { "buttons", "maps", "sliders", "tabview", "image-editor", "inputs" })
        {
            Assert.True(PackageCatalog.TryResolve(alias, out var package));
            Assert.Contains(add.Packages, choice => choice.Id == package.Alias);
        }
    }

    [Fact]
    public void ManifestEntriesAreAddedAndCannotBeSelected()
    {
        using var project = new Project();
        project.SaveAdded(["datagrid"]);
        var provider = new MauiControlSelectionProvider(project.Info);
        Assert.True(provider.Controls.Single(control => control.Id == "datagrid").Added);
        var grid = provider.Controls.ToList().FindIndex(control => control.Id == "datagrid");
        var keys = Enumerable.Repeat(Key(ConsoleKey.DownArrow), grid)
            .Append(Key(ConsoleKey.Spacebar)).Append(Key(ConsoleKey.DownArrow))
            .Append(Key(ConsoleKey.Spacebar)).Append(Key(ConsoleKey.Enter));
        using var writer = new StringWriter();
        var result = InteractivePrompt.AskAddControls(provider, true, default, Input(writer, keys));
        Assert.Equal(new[] { "diagram" }, result);
        Assert.Contains("[Added] DataGrid", writer.ToString());
        Assert.DoesNotContain("[x] DataGrid", writer.ToString());
        Assert.Contains("Which controls would you like to add?", writer.ToString());
        Assert.Contains(InteractivePrompt.AddControlSelectionGuidance, writer.ToString());
    }

    [Fact]
    public void OtherPackagesIsLastAndOpensItsRouteInsteadOfSelectingControls()
    {
        using var project = new Project();
        var provider = new MauiControlSelectionProvider(project.Info);
        using var writer = new StringWriter();
        var keys = Enumerable.Repeat(Key(ConsoleKey.DownArrow), provider.Controls.Count).Append(Key(ConsoleKey.Enter));
        Assert.Equal(new[] { InteractivePrompt.OtherPackagesId }, InteractivePrompt.AskAddControls(provider, true, default, Input(writer, keys)));
        var rendered = writer.ToString();
        Assert.True(rendered.IndexOf("Other packages...", StringComparison.Ordinal) > rendered.IndexOf("Scheduler", StringComparison.Ordinal));
    }

    [Fact]
    public async Task AllAddedControlsKeepOtherPackagesAvailableWithoutWritingProjectFiles()
    {
        using var project = new Project();
        project.SaveAdded(new MauiControlSelectionProvider(MauiProjectType.App).Controls.Select(control => control.Id));
        var before = File.ReadAllText(project.ManifestPath);
        using var capture = new ConsoleCapture();
        using var writer = new StringWriter();
        await Assert.ThrowsAsync<InteractivePromptCancelledException>(() => CommandOperations.AddInteractiveControlsAsync(
            new ConsolePresenter(true), project.Info, new GlobalOptions(), default,
            input: Input(writer, [Key(ConsoleKey.Escape)])));
        Assert.Contains("Other packages...", writer.ToString());
        Assert.Contains("[Added] DataGrid", writer.ToString());
        Assert.Contains("All available controls are already added", capture.Out);
        Assert.Equal(before, File.ReadAllText(project.ManifestPath));
        Assert.False(File.Exists(Path.Combine(project.Root, "MauiProgram.cs")));
    }

    [Theory]
    [InlineData(ConsoleKey.Enter)]
    [InlineData(ConsoleKey.Spacebar)]
    public void AllAddedControlsFocusOtherPackagesAndAllowOpeningIt(ConsoleKey key)
    {
        using var project = new Project();
        project.SaveAdded(new MauiControlSelectionProvider(MauiProjectType.App).Controls.Select(control => control.Id));
        var provider = new MauiControlSelectionProvider(project.Info);
        using var writer = new StringWriter();
        Assert.Equal(new[] { InteractivePrompt.OtherPackagesId },
            InteractivePrompt.AskAddControls(provider, true, default, Input(writer, [Key(key)])));
        Assert.All(provider.Controls, control => Assert.True(control.Added));
    }

    [Fact]
    public void ControlsReviewUsesDisplayNamesAndSharedAlignmentInsteadOfPackageRow()
    {
        using var project = new Project();
        var entries = new[] { "circular-chart", "cartesian-chart" }.Select(id =>
        {
            Assert.True(TemplateCatalog.TryResolveOperableTemplate(id, out var entry));
            return entry;
        }).ToArray();
        var request = new AddTemplateRequest(Framework.Maui, entries[0].Id, project.Info.CsprojPath, null, true, false, false, TemplateIds: entries.Select(entry => entry.Id).ToArray());
        var rows = CommandOperations.ControlAddReviewValues(request, project.Info, entries);
        Assert.Equal(new[] { "Action:", "Platform:", "Project file:", "Controls:", "Post-add:" }, rows.Select(row => row.Label));
        Assert.Contains(("Controls:", "Cartesian Chart, Circular Chart"), rows);
        Assert.DoesNotContain(rows, row => row.Label == "Package:");
        Assert.Contains("Controls:".PadRight(ProjectFlowLayout.ValueColumn) + "Cartesian Chart, Circular Chart", SummaryRows.Format(rows, 160, ProjectFlowLayout.ValueColumn));
    }

    [Fact]
    public void PickerAcceptsAnotherPlatformsCatalogWithoutMauiNames()
    {
        using var writer = new StringWriter();
        var result = InteractivePrompt.AskAddControls(new TestProvider(), true, default,
            Input(writer, [Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)]));
        Assert.Equal(new[] { "custom-control" }, result);
        Assert.Contains("Custom platform control", writer.ToString());
        Assert.DoesNotContain("DataGrid", writer.ToString());
    }
    private sealed class TestProvider : IControlSelectionProvider
    {
        public IReadOnlyList<ControlSelectionItem> Controls => [new("custom-control", "Custom platform control")];
        public IReadOnlyList<PackageSelectionItem> Packages => [new("custom-package", "Custom platform package")];
        public IReadOnlyList<string> ResolvePackages(IEnumerable<string> ids) => ["Custom.Package"];
    }

    private static InteractiveConsoleInput Input(StringWriter writer, IEnumerable<ConsoleKeyInfo> keys)
    {
        var queue = new Queue<ConsoleKeyInfo>(keys);
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = 120; console.Profile.Height = 40;
        return new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(queue.Dequeue()), true);
    }
    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);
    private sealed class Project : IDisposable
    {
        public string Root { get; } = Path.Combine(Path.GetTempPath(), "sf-control-picker-" + Guid.NewGuid().ToString("N"));
        public ProjectDetector.ProjectInfo Info { get; }
        public string ManifestPath => Path.Combine(Root, "Syncfusion", "syncfusion.json");
        public Project()
        {
            Directory.CreateDirectory(Root);
            var path = Path.Combine(Root, "App.csproj");
            File.WriteAllText(path, "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><UseMaui>true</UseMaui><TargetFramework>net10.0-android</TargetFramework></PropertyGroup></Project>");
            Info = MauiProjectResolver.Resolve(path);
        }
        public void SaveAdded(IEnumerable<string> ids)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(ManifestPath)!);
            File.WriteAllText(ManifestPath, new SyncfusionManifest { ProjectFile = "App.csproj", Framework = "maui", CliVersion = "test", InstalledControls = ids.ToList() }.ToJson());
        }
        public void Dispose() => Directory.Delete(Root, true);
    }
}
