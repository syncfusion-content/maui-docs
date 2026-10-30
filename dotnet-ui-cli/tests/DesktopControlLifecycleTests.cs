using System.Text.Json;
using System.Xml.Linq;
using Syncfusion.DotNet.Cli.Commands.Desktop;
using Syncfusion.DotNet.Cli.Core;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

public sealed class DesktopControlLifecycleTests
{
    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public async Task GenerationUsesDiscoveredVersionInsteadOfProviderDefault(string platform)
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var chartControl = platform == "winui" ? "cartesian-chart" : "chart";
        var result = await new DesktopProjectService(new Tools { SearchVersion = "36.2.7" })
            .CreateAsync(provider, Request(provider, temp.Root, [chartControl]));
        Assert.True(result.Success, result.Message);
        var references = XDocument.Load(Path.Combine(result.ProjectPath!, "LifecycleApp.csproj"))
            .Descendants("PackageReference").Where(reference => ((string?)reference.Attribute("Include"))?.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase) == true).ToArray();
        Assert.NotEmpty(references);
        Assert.All(references, reference => Assert.Equal("36.2.7", (string?)reference.Attribute("Version")));
    }

    [Theory]
    [InlineData("wpf", 11)]
    [InlineData("winforms", 10)]
    [InlineData("winui", 11)]
    public void EverySuppliedControlIsEmbeddedAndGeneratesCompleteSources(string platform, int count)
    {
        var provider = DesktopProviders.Find(platform)!;
        Assert.Equal(count, provider.Controls.Count);
        foreach (var control in provider.Controls)
        {
            var request = Request(provider, Path.GetTempPath(), [control.Alias]);
            var sources = provider.Generate(request);
            var assets = provider.TemplateAssets(request);
            Assert.Contains(sources.Keys, path => path.EndsWith("Page.cs") || path.EndsWith("Page.xaml.cs"));
            Assert.DoesNotContain(sources.Values, source => source.Contains("__ROOT_NAMESPACE__") || source.Contains("__VIEW_NAME__") || source.Contains("SyncfusionWpfApp2"));
            foreach (var source in sources.Where(pair => pair.Key.EndsWith(".xaml"))) _ = XDocument.Parse(source.Value);
            var project = XDocument.Parse(sources["LifecycleApp.csproj"]);
            foreach (var asset in assets.Keys)
                Assert.Contains(project.Descendants(), element => (string?)element.Attribute("Include") == asset || (string?)element.Attribute("Update") == asset);
        }
    }

    [Theory]
    [InlineData("wpf", "C#")]
    [InlineData("winforms", "C#")]
    [InlineData("winui", "C#")]
    [InlineData("wpf", "VB")]
    [InlineData("winforms", "VB")]
    public async Task AddRemoveAndUpdateMaintainOwnedSamplesNavigationAndAssets(string platform, string language)
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var created = await new DesktopProjectService(new Tools()).CreateAsync(provider, Request(provider, temp.Root, []) with { Language = language });
        Assert.True(created.Success, string.Join("\n", created.Errors ?? []));
        var project = Path.Combine(created.ProjectPath!, "LifecycleApp" + DesktopConfiguration.ProjectExtension(language));
        var service = new DesktopPackageService(new Packages(), new Tools());
        foreach (var control in provider.Controls)
        {
            var added = await service.ExecuteAsync(provider, "add", project, control.Alias, restore: false);
            Assert.True(added.Success, added.Message + string.Join("\n", added.Errors ?? []));
        }
        var root = created.ProjectPath!;
        Assert.Equal(provider.Controls.Count, Manifest(root).Controls.Count);
        Assert.NotEmpty(Directory.GetFiles(Path.Combine(root, "DataGrid"), language == "VB" ? "*.vb" : "*.cs"));
        var page = Directory.GetFiles(Path.Combine(root, "DataGrid"), language == "VB" ? "*Page*.vb" : "*Page*.cs").Single();
        var customization = language == "VB" ? "\n' User-owned customization\n" : "\n// User-owned customization\n";
        var edited = File.ReadAllText(page) + customization;
        File.WriteAllText(page, edited);
        var beforeRepeatedAdd = Snapshot(root);
        Assert.True((await service.ExecuteAsync(provider, "add", project, "datagrid", restore: false)).Success);
        Assert.Equal(beforeRepeatedAdd, Snapshot(root));
        var updated = await service.ExecuteAsync(provider, "update", project, "datagrid", "35.1.40", restore: false);
        Assert.True(updated.Success);
        Assert.Equal(edited, File.ReadAllText(page));
        var snapshot = Snapshot(root);
        var blocked = await service.ExecuteAsync(provider, "remove", project, "datagrid", restore: false);
        Assert.False(blocked.Success);
        Assert.Contains("edited", blocked.Message);
        Assert.Equal(snapshot, Snapshot(root));
        File.WriteAllText(page, edited.Replace(customization, "", StringComparison.Ordinal));
        foreach (var control in provider.Controls.Reverse())
        {
            var removed = await service.ExecuteAsync(provider, "remove", project, control.Alias, restore: false);
            Assert.True(removed.Success, removed.Message + string.Join("\n", removed.Errors ?? []));
        }
        Assert.Empty(Manifest(root).Controls);
        var emptyProject = XDocument.Load(project);
        Assert.DoesNotContain(emptyProject.Descendants(), element =>
            ((string?)element.Attribute("Include") ?? (string?)element.Attribute("Update"))?.StartsWith("Ribbon/", StringComparison.Ordinal) == true);
        Assert.Contains("You’re all set!", File.ReadAllText(Path.Combine(root, platform != "winforms" ? "Welcome/WelcomeView.xaml" : "Welcome/WelcomeView." + (language == "VB" ? "vb" : "cs"))));
        Assert.All(Manifest(root).OriginalHashes, pair => Assert.Equal(pair.Value, FileRollback.ComputeHash(Path.Combine(root, pair.Key))));
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public async Task FailedRestoreRollsBackPackagesSourcesAssetsAndManifest(string platform)
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var created = await new DesktopProjectService(new Tools()).CreateAsync(provider, Request(provider, temp.Root, []));
        var root = created.ProjectPath!;
        var before = Snapshot(root);
        var service = new DesktopPackageService(new Packages(), new Tools { FailRestore = true });
        var result = await service.ExecuteAsync(provider, "add", root, "datagrid");
        Assert.False(result.Success);
        Assert.True(result.RolledBack);
        Assert.Equal(before, Snapshot(root));
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    public async Task DryRunAndUnownedFileCollisionLeaveProjectUntouched(string platform)
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var created = await new DesktopProjectService(new Tools()).CreateAsync(provider, Request(provider, temp.Root, []));
        var root = created.ProjectPath!;
        var service = new DesktopPackageService(new Packages(), new Tools());
        var chartControl = platform == "winui" ? "cartesian-chart" : "chart";
        var chartFile = provider.Generate(Request(provider, temp.Root, [chartControl])).Keys
            .Single(path => path.EndsWith("Page.xaml.cs") || path.EndsWith("Page.cs"));
        var before = Snapshot(root);
        var dry = await service.ExecuteAsync(provider, "add", root, chartControl, restore: false, dryRun: true);
        Assert.True(dry.Success);
        Assert.Equal(before, Snapshot(root));
        Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(root, chartFile))!);
        File.WriteAllText(Path.Combine(root, chartFile), "// Existing user file");
        before = Snapshot(root);
        var blocked = await service.ExecuteAsync(provider, "add", root, chartControl, restore: false);
        Assert.False(blocked.Success);
        Assert.Equal(before, Snapshot(root));
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winui")]
    public async Task EarlierOwnedInlineHostMigratesAndCreatesExistingControlFiles(string platform)
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find(platform)!;
        var chartControl = platform == "winui" ? "cartesian-chart" : "chart";
        var created = await new DesktopProjectService(new Tools()).CreateAsync(provider, Request(provider, temp.Root, [chartControl]));
        var root = created.ProjectPath!;
        var manifest = Manifest(root);
        var chartDir = platform == "winui" ? "CartesianChart" : "Chart";
        Directory.Delete(Path.Combine(root, chartDir), true);
        foreach (var key in manifest.OriginalHashes.Keys.Where(key => key.StartsWith($"{chartDir}/", StringComparison.Ordinal)).ToArray()) manifest.OriginalHashes.Remove(key);
        var host = Path.Combine(root, "MainWindow.xaml.cs");
        File.AppendAllText(host, "\n// Earlier CLI-owned host\n");
        manifest.OriginalHashes["MainWindow.xaml.cs"] = FileRollback.ComputeHash(host)!;
        File.WriteAllText(Path.Combine(root, DesktopProjectService.ManifestName), JsonSerializer.Serialize(manifest));
        var result = await new DesktopPackageService(new Packages(), new Tools()).ExecuteAsync(provider, "add", root, "datagrid", restore: false);
        Assert.True(result.Success, result.Message);
        var pageExt = platform == "winui" ? "CartesianChartPage.xaml" : "ChartPage.xaml";
        Assert.True(File.Exists(Path.Combine(root, $"{chartDir}/{pageExt}")));
        Assert.True(File.Exists(Path.Combine(root, "DataGrid/DataGridPage.xaml")));
        Assert.DoesNotContain("Earlier CLI-owned host", File.ReadAllText(host));
    }

    [Fact]
    public async Task ManagedUpdateAlignsReleaseDependenciesAndKeepsSampleFiles()
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find("winforms")!;
        var created = await new DesktopProjectService(new Tools()).CreateAsync(provider, Request(provider, temp.Root, ["chart", "datagrid"]) with { Version = "35.1.39" });
        var project = Path.Combine(created.ProjectPath!, "LifecycleApp.csproj");
        var result = await new DesktopPackageService(new Packages(), new Tools()).ExecuteAsync(provider, "update", project, "chart", "35.1.40", restore: false);
        Assert.True(result.Success, result.Message);
        var xml = XDocument.Load(project);
        Assert.All(xml.Descendants().Where(e => e.Name.LocalName == "PackageReference" && ((string?)e.Attribute("Include"))?.StartsWith("Syncfusion.", StringComparison.Ordinal) == true),
            e => Assert.Equal("35.1.40", (string?)e.Attribute("Version")));
        Assert.True(File.Exists(Path.Combine(created.ProjectPath!, "DataGrid/DataGridPage.cs")));
    }

    [Fact]
    public async Task CentralManagementNormalizesNoRestoreReferencesAndAlignsVersions()
    {
        using var temp = new Temp();
        var centralPath = Path.Combine(temp.Root, "Directory.Packages.props");
        File.WriteAllText(centralPath, "<Project><PropertyGroup><ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally></PropertyGroup></Project>");
        var provider = DesktopProviders.Find("wpf")!;
        var tools = new Tools { Central = true };
        var created = await new DesktopProjectService(tools).CreateAsync(provider, Request(provider, temp.Root, []) with { Version = "35.1.39" });
        var project = Path.Combine(created.ProjectPath!, "LifecycleApp.csproj");
        var service = new DesktopPackageService(new Packages(), tools);
        Assert.True((await service.ExecuteAsync(provider, "add", project, "chart", restore: false)).Success);
        Assert.DoesNotContain(XDocument.Load(project).Descendants(), e => e.Name.LocalName == "PackageReference" && e.Attribute("Version") is not null);
        Assert.Contains(XDocument.Load(centralPath).Descendants(), e => (string?)e.Attribute("Include") == "Syncfusion.SfChart.WPF" && (string?)e.Attribute("Version") == "35.1.40");
        Assert.True((await service.ExecuteAsync(provider, "update", project, "chart", "35.1.40", restore: false)).Success);
        Assert.DoesNotContain(XDocument.Load(project).Descendants(), e => e.Name.LocalName == "PackageReference" && e.Attribute("Version") is not null);
        Assert.All(XDocument.Load(centralPath).Descendants().Where(e => e.Name.LocalName == "PackageVersion" && ((string?)e.Attribute("Include"))?.StartsWith("Syncfusion.", StringComparison.Ordinal) == true),
            e => Assert.Equal("35.1.40", (string?)e.Attribute("Version")));
    }

    [Fact]
    public async Task RemovingOneToolsControlRetainsSharedPackageAndOtherControl()
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find("winforms")!;
        var created = await new DesktopProjectService(new Tools()).CreateAsync(provider, Request(provider, temp.Root, ["docking-manager", "navigation-drawer"]));
        var result = await new DesktopPackageService(new Packages(), new Tools()).ExecuteAsync(provider, "remove", created.ProjectPath!, "docking-manager", restore: false);
        Assert.True(result.Success, result.Message);
        var xml = XDocument.Load(Path.Combine(created.ProjectPath!, "LifecycleApp.csproj"));
        Assert.Contains(xml.Descendants(), e => (string?)e.Attribute("Include") == "Syncfusion.Tools.Windows");
        Assert.True(File.Exists(Path.Combine(created.ProjectPath!, "NavigationDrawer/NavigationDrawerPage.cs")));
        Assert.False(File.Exists(Path.Combine(created.ProjectPath!, "DockingManager/DockingManagerPage.cs")));
    }

    [Fact]
    public async Task WinUITreeGridAndDataGridShareDependencyWithoutLosingEitherSample()
    {
        using var temp = new Temp();
        var provider = DesktopProviders.Find("winui")!;
        var created = await new DesktopProjectService(new Tools()).CreateAsync(provider,
            Request(provider, temp.Root, ["datagrid", "treegrid"]));
        Assert.True(created.Success, created.Message);
        var service = new DesktopPackageService(new Packages(), new Tools());
        var ambiguous = await service.ExecuteAsync(provider, "add", created.ProjectPath!, "Syncfusion.Grid.WinUI", restore: false);
        Assert.False(ambiguous.Success);
        Assert.Contains("multiple control templates", ambiguous.Message);
        var updated = await service.ExecuteAsync(provider, "update", created.ProjectPath!, "treegrid", "35.1.40", restore: false);
        Assert.True(updated.Success, updated.Message);
        var removed = await service.ExecuteAsync(provider, "remove", created.ProjectPath!, "treegrid", restore: false);
        Assert.True(removed.Success, removed.Message);
        Assert.True(File.Exists(Path.Combine(created.ProjectPath!, "DataGrid/DataGridPage.xaml")));
        Assert.False(File.Exists(Path.Combine(created.ProjectPath!, "TreeGrid/TreeGridPage.xaml")));
        var project = XDocument.Load(Path.Combine(created.ProjectPath!, "LifecycleApp.csproj"));
        Assert.Single(project.Descendants("PackageReference"), item => (string?)item.Attribute("Include") == "Syncfusion.Grid.WinUI");
        Assert.Single(Manifest(created.ProjectPath!).Controls);
    }

    private static DesktopNewRequest Request(IDesktopPlatformProvider provider, string root, IReadOnlyList<string> controls)
        => new(provider.Platform, "LifecycleApp", root, "C#", "net10.0", provider.DefaultTheme, controls, false, false);
    private static DesktopManifest Manifest(string root) => JsonSerializer.Deserialize<DesktopManifest>(File.ReadAllText(Path.Combine(root, DesktopProjectService.ManifestName)))!;
    private static string Snapshot(string root) => string.Join("\n", Directory.GetFiles(root, "*", SearchOption.AllDirectories).Order().Select(file => Path.GetRelativePath(root, file) + "=" + FileRollback.ComputeHash(file)));
    private sealed class Tools : ToolRunner
    {
        public bool FailRestore { get; init; }
        public bool Central { get; init; }
        public string SearchVersion { get; init; } = "35.1.40";
        public override Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null, CancellationToken cancellationToken = default, string? executable = null)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ToolResult(0, PackageSearchFixture.Response(args[2], SearchVersion), ""));
            if (args[0] == "new") Directory.CreateDirectory(args[args.ToList().IndexOf("-o") + 1]);
            return Task.FromResult(FailRestore && args[0] == "restore" ? new ToolResult(1, "", "restore failed") : new ToolResult(0, args[0] == "--list-sdks" ? "10.0.100 [sdk]" : Central.ToString().ToLowerInvariant(), ""));
        }
    }
    private sealed class Packages : NuGetRunner
    {
        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
        {
            var xml = XDocument.Load(operation.ProjectPath);
            var ns = xml.Root!.Name.Namespace;
            var reference = xml.Descendants().FirstOrDefault(e => e.Name.LocalName == "PackageReference" && (string?)e.Attribute("Include") == operation.PackageId);
            if (operation.Kind == NuGetOperationKind.Remove) reference?.Remove();
            else if (reference is null) xml.Root.Add(new XElement(ns + "ItemGroup", new XElement(ns + "PackageReference", new XAttribute("Include", operation.PackageId!), new XAttribute("Version", operation.Version ?? "35.1.40"))));
            else reference.SetAttributeValue("Version", operation.Version ?? "35.1.40");
            xml.Save(operation.ProjectPath);
            return Task.FromResult(new NuGetCommandResult { ExitCode = 0, StandardOutput = "", StandardError = "" });
        }
    }
    private sealed class Temp : IDisposable
    {
        public string Root { get; } = Path.Combine(Path.GetTempPath(), "sf-control-lifecycle-" + Guid.NewGuid().ToString("N"));
        public Temp() => Directory.CreateDirectory(Root);
        public void Dispose() => Directory.Delete(Root, true);
    }
}
