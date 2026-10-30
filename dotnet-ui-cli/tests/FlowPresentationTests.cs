using Spectre.Console;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Maui.Manifest;
using Syncfusion.DotNet.Cli.Presentation;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class FlowPresentationTests
{
    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void NameConflictAllowsReentryWithoutChangingExistingDestination(bool file)
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-name-retry-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var busy = Path.Combine(root, "Busy");
            if (file) File.WriteAllText(busy, "keep"); else Directory.CreateDirectory(busy);
            using var capture = new ConsoleCapture();
            using var writer = new StringWriter();
            var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
            var keys = new Queue<ConsoleKeyInfo>("Busy".Select(character => new ConsoleKeyInfo(character, ConsoleKey.A, false, false, false))
                .Append(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false))
                .Concat("Fresh".Select(character => new ConsoleKeyInfo(character, ConsoleKey.A, false, false, false)))
                .Append(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false)));
            var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), true);
            Assert.Equal("Fresh", NewCommand.AskProjectLocationAndName(Framework.Maui, root, new ConsolePresenter(true), input).Name);
            Assert.Contains($"'Busy' already exists in Project location '{root}'. Enter a different name:", writer.ToString());
            Assert.DoesNotContain("already exists", capture.Error);
            Assert.False(Directory.Exists(Path.Combine(root, "Fresh")));
            Assert.True(file ? File.ReadAllText(busy) == "keep" : Directory.Exists(busy));
        }
        finally { Directory.Delete(root, true); }
    }

    [Fact]
    public async Task InstalledPackagesAlignUnknownAliasesAndKeepJsonExactly()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-list-align-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            File.WriteAllText(Path.Combine(root, "App.csproj"), "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><UseMaui>true</UseMaui><TargetFramework>net10.0-android</TargetFramework></PropertyGroup><ItemGroup><PackageReference Include=\"Syncfusion.Maui.DataGrid\" Version=\"32.1.29\"/><PackageReference Include=\"Syncfusion.Maui.Unlisted\" Version=\"1.0.0\"/></ItemGroup></Project>");
            var request = new ListRequest(ListCategory.Installed, Framework.Maui);
            using (var capture = new ConsoleCapture())
            {
                Assert.Equal(0, await ListCommand.ExecuteListAsync(new ConsolePresenter(true), request, new GlobalOptions { NoInteractive = true }, root, default));
                var lines = capture.Out.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                var header = Assert.Single(lines, line => line.Contains("Alias") && line.Contains("NuGet"));
                var start = header.IndexOf("NuGet", StringComparison.Ordinal);
                Assert.All(lines.Where(line => line.Contains("Syncfusion.Maui.")), line => Assert.Equal(start, line.IndexOf("Syncfusion.Maui.", StringComparison.Ordinal)));
                Assert.Contains("Version", header);
            }
            using (var capture = new ConsoleCapture())
            {
                Assert.Equal(0, await ListCommand.ExecuteListAsync(new ConsolePresenter(true), request, new GlobalOptions { Json = true }, root, default));
                Assert.Equal(DiscoveryService.ToJson(DiscoveryService.ListInstalledPackages(Path.Combine(root, "App.csproj"))) + Environment.NewLine, capture.Out);
            }
            var manifest = new SyncfusionManifest { SchemaVersion = 2, ProjectFile = "App.csproj", Framework = "maui", ProjectType = "app", InstalledControls = ["datagrid"],
                InstalledTemplates = [new InstalledTemplateRecord { Id = "datagrid", Family = "datagrid", PackageId = "Syncfusion.Maui.DataGrid" }] };
            Directory.CreateDirectory(Path.Combine(root, "Syncfusion"));
            File.WriteAllText(Path.Combine(root, "Syncfusion", "syncfusion.json"), manifest.ToJson());
            using (var capture = new ConsoleCapture())
            {
                Assert.Equal(0, await ListCommand.ExecuteListAsync(new ConsolePresenter(true), new ListRequest(ListCategory.InstalledTemplates, Framework.Maui), new GlobalOptions { NoInteractive = true }, root, default));
                var lines = capture.Out.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                var header = Assert.Single(lines, line => line.Contains("Control ID"));
                var row = Assert.Single(lines, line => line.Contains("Syncfusion.Maui.DataGrid"));
                Assert.Equal(header.IndexOf("NuGet", StringComparison.Ordinal), row.IndexOf("Syncfusion.Maui.DataGrid", StringComparison.Ordinal));
                Assert.Equal(header.IndexOf("Name", StringComparison.Ordinal), row.IndexOf("DataGrid", StringComparison.Ordinal));
            }
        }
        finally { Directory.Delete(root, true); }
    }

    [Fact]
    public void BlankGenerationDoesNotClaimPackageRegistrationRestoreOrBuildWork()
    {
        var request = new NewProjectRequest(Framework.Maui, "App", "/tmp", "net10.0", "empty", MauiProjectType.App, false, false, false, false);
        Assert.Equal([1, 2], Enumerable.Range(1, 7).Where(index => NewCommand.ShouldDisplayProgress(request, new ProgressStep(index, 7, "stage"))));
        Assert.Equal([1, 2, 7], Enumerable.Range(1, 7).Where(index => NewCommand.ShouldDisplayProgress(request with { Restore = true, Build = true }, new ProgressStep(index, 7, "stage"))));
        Assert.Equal([1, 2, 6], Enumerable.Range(1, 7).Where(index => NewCommand.ShouldDisplayProgress(request with { Restore = true }, new ProgressStep(index, 7, "stage"))));
    }
}
