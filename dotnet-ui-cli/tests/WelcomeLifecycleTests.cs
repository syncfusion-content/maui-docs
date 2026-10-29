using System.Text.Json;
using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Injection;
using Syncfusion.DotNet.CLI.Maui.Manifest;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class WelcomeLifecycleTests
{
    [Fact]
    public async Task ChartAndListGenerationUsesTheCurrentEmbeddedTemplates()
    {
        using var app = new App();
        string[] ids = ["cartesian-chart", "circular-chart", "listview"];
        var result = await app.Installer.ExecuteAddBatchAsync(ids);
        Assert.Equal(0, result.ExitCode);
        foreach (var id in ids)
        {
            Assert.True(TemplateCatalog.TryResolveOperableTemplate(id, out var entry));
            var values = PlaceholderReplacer.BuildValues("Demo", "Demo", entry.ControlName, MauiTemplateNames.ViewName(entry.ControlName));
            foreach (var file in entry.GeneratedFiles)
            {
                var expected = PlaceholderReplacer.Replace(EmbeddedResourceLoader.ReadText(
                    TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource)), values);
                Assert.Equal(expected, app.Read(file.Destination));
            }
        }
        var registry = app.Read(WelcomeProjectGenerator.RegistryPath);
        Assert.Contains("new global::Demo.CartesianChart.CartesianChartView()", registry);
        Assert.Contains("new global::Demo.CircularChart.CircularChartView()", registry);
        Assert.Contains("new global::Demo.ListView.ListViewPage()", registry);
    }

    [Fact]
    public async Task NewControlReferencesKeepConcreteVersionsAfterGeneration()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["datagrid", "cartesian-chart"])).ExitCode);
        var references = XDocument.Load(app.Project.CsprojPath).Descendants("PackageReference").ToArray();
        Assert.NotEmpty(references);
        Assert.All(references, reference => Assert.True(NuGetPackageVersions.IsExact((string?)reference.Attribute("Version") ?? "")));
        Assert.All(app.DotNet.Calls.Where(args => args.Count > 1 && args[0] == "package"), args =>
            Assert.Equal(NuGetSources.DefaultPublicFeed, args[args.ToList().IndexOf("--source") + 1]));
    }

    [Fact]
    public async Task AllSamples_AreRegisteredOnce_AndFinalRemovalRestoresEmptyWelcome()
    {
        using var app = new App();
        var ids = TemplateCatalog.Operable.Select(entry => entry.Id).ToArray();
        var added = await app.Installer.ExecuteAddBatchAsync(ids);
        Assert.True(added.ExitCode == ExitCodes.Success, added.Message);
        var manifest = app.Manifest;
        Assert.Equal(ids.Length, manifest.InstalledTemplates.Count);
        foreach (var entry in TemplateCatalog.Operable)
        {
            var record = Assert.Single(manifest.InstalledTemplates, record => record.Id == entry.Id);
            Assert.Contains(entry.PackageId, record.PackageDependencies);
            Assert.Equal(entry.Id, record.WelcomeEntry);
            Assert.Contains(WelcomeProjectGenerator.RegistryPath + "#" + entry.Id, record.NavigationEntries);
            Assert.All(record.GeneratedFiles, file => Assert.True(File.Exists(app.Path(file))));
            foreach (var file in record.GeneratedFiles.Where(file => file.EndsWith(".xaml"))) _ = XDocument.Load(app.Path(file));
        }
        Assert.Equal(ids.Length, app.Read(WelcomeProjectGenerator.RegistryPath).Split("        new(").Length - 1);
        Assert.DoesNotContain("OnOpen", app.Read("Welcome/WelcomeView.xaml.cs"));
        var before = app.Snapshot();
        var repeated = await app.Installer.ExecuteAddBatchAsync(ids);
        Assert.Equal(ExitCodes.Success, repeated.ExitCode);
        Assert.True(repeated.Plan!.IsEmpty);
        Assert.Equal(before, app.Snapshot());
        app.Write("Syncfusion/Controls/UserNotes.txt", "keep this user file");
        Assert.Equal(ExitCodes.Success, (await app.Installer.ExecuteRemoveBatchAsync(ids)).ExitCode);
        Assert.Empty(app.Manifest.InstalledControls);
        Assert.Empty(app.Manifest.InstalledTemplates);
        Assert.DoesNotContain("new(", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.DoesNotContain("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
        Assert.Equal("keep this user file", app.Read("Syncfusion/Controls/UserNotes.txt"));
        Assert.Contains("IsEmpty", app.Read("Welcome/WelcomeView.xaml"));
        Assert.All(app.Manifest.GeneratedFiles, path => Assert.True(File.Exists(app.Path(path))));
        before = app.Snapshot();
        Assert.Equal(ExitCodes.Success, (await app.Installer.ExecuteRemoveBatchAsync(ids)).ExitCode);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task SharedPickerCatalogChartsAddOnePackageAndRestoreBuildOnce()
    {
        using var app = new App();
        var provider = new MauiControlSelectionProvider(app.Project);
        var ids = provider.Controls.Where(control => control.Id is "cartesian-chart" or "circular-chart")
            .Select(control => control.Id).ToArray();
        Assert.Equal(new[] { "Syncfusion.Maui.Charts" }, provider.ResolvePackages(ids));
        var result = await app.Installer.ExecuteAddBatchAsync(ids);
        Assert.Equal(ExitCodes.Success, result.ExitCode);
        Assert.Equal(1, app.NuGet.Calls.Count(call => call == "Add:Syncfusion.Maui.Charts"));
        Assert.Equal(1, app.DotNet.Calls.Count(call => call[0] == "restore"));
        Assert.Equal(1, app.DotNet.Calls.Count(call => call[0] == "build"));
        Assert.Contains("cartesian-chart", app.Manifest.InstalledControls);
        Assert.Contains("circular-chart", app.Manifest.InstalledControls);
    }

    [Fact]
    public async Task SharedChartsPackage_AndRegistrationRemainUntilLastSample()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["cartesian-chart", "circular-chart"])).ExitCode);
        var result = await app.Installer.ExecuteRemoveAsync("cartesian-chart");
        Assert.Equal(0, result.ExitCode);
        Assert.Contains(result.Plan!.Warnings, warning => warning.Contains("required by another sample"));
        Assert.Contains("Syncfusion.Maui.Charts", app.Read("Demo.csproj"));
        Assert.Contains("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
        Assert.DoesNotContain("ChartsView()", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Contains("CircularChartView()", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("circular-chart")).ExitCode);
        Assert.DoesNotContain("Syncfusion.Maui.Charts", app.Read("Demo.csproj"));
        Assert.DoesNotContain("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task PackageRemoval_AfterCustomUseEnds_CleansOwnedRegistrationOrReportsEditedBlock(bool editBlock)
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write("Custom.cs", "using Syncfusion.Maui.DataGrid; class Custom { }");
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("datagrid")).ExitCode);
        Assert.Empty(app.Manifest.InstalledControls);
        Assert.Contains("Syncfusion.Maui.DataGrid", app.Read("Demo.csproj"));
        File.Delete(app.Path("Custom.cs"));
        if (editBlock) app.Write("MauiProgram.cs", app.Read("MauiProgram.cs").Replace("builder.ConfigureSyncfusionCore();", "builder.ConfigureSyncfusionCore(); // edited"));
        var before = app.Snapshot();
        var service = new PackageOperationService(app.NuGet);
        var result = await service.ExecuteAsync(app.Project, "datagrid", "Syncfusion.Maui.DataGrid", NuGetOperationKind.Remove);
        if (editBlock)
        {
            Assert.NotEqual(0, result.ExitCode);
            Assert.Equal(before, app.Snapshot());
        }
        else
        {
            Assert.Equal(0, result.ExitCode);
            Assert.DoesNotContain("Syncfusion.Maui.DataGrid", app.Read("Demo.csproj"));
            Assert.DoesNotContain("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
            Assert.Empty(app.Manifest.GeneratedBlocks);
        }
    }

    [Fact]
    public async Task UserRegistrationCall_RetainsCoreProvider_AndOnlyOwnedUsingIsCleanedAfterward()
    {
        using var app = new App();
        app.Write("MauiProgram.cs", app.Read("MauiProgram.cs").Replace("var builder = MauiApp.CreateBuilder();",
            "var builder = MauiApp.CreateBuilder();\n        builder.ConfigureSyncfusionCore();"));
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        Assert.False(app.Manifest.RegistrationOwned);
        Assert.Single(app.Manifest.GeneratedBlocks);
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("datagrid")).ExitCode);
        Assert.Contains("Syncfusion.Maui.DataGrid", app.Read("Demo.csproj"));
        Assert.Contains("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
        app.Write("MauiProgram.cs", app.Read("MauiProgram.cs").Replace("builder.ConfigureSyncfusionCore();", ""));
        var result = await new PackageOperationService(app.NuGet).ExecuteAsync(app.Project, "datagrid", "Syncfusion.Maui.DataGrid", NuGetOperationKind.Remove);
        Assert.Equal(0, result.ExitCode);
        Assert.DoesNotContain("Syncfusion.Maui.Core.Hosting", app.Read("MauiProgram.cs"));
        Assert.Empty(app.Manifest.GeneratedBlocks);
    }

    [Fact]
    public async Task CustomDataGridUse_RetainsItsProviderWithoutKeepingUnrelatedChartsPackage()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["datagrid", "cartesian-chart"])).ExitCode);
        app.Write("Custom.cs", "using Syncfusion.Maui.DataGrid; class Custom { }");
        Assert.Equal(0, (await app.Installer.ExecuteRemoveBatchAsync(["datagrid", "cartesian-chart"])).ExitCode);
        Assert.Contains("Syncfusion.Maui.DataGrid", app.Read("Demo.csproj"));
        Assert.DoesNotContain("Syncfusion.Maui.Charts", app.Read("Demo.csproj"));
        Assert.Contains("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
    }

    [Fact]
    public async Task MissingOwnedView_AddRepairsVerifiedFileWithoutDuplicatingSetup()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        File.Delete(app.Path("DataGrid/DataGridView.xaml"));
        var before = app.Snapshot();
        var result = await app.Installer.ExecuteAddAsync("datagrid");
        Assert.Equal(0, result.ExitCode);
        Assert.True(File.Exists(app.Path("DataGrid/DataGridView.xaml")));
        Assert.Single(app.Manifest.InstalledControls);
        Assert.Single(app.Manifest.InstalledTemplates);
    }

    [Theory]
    [InlineData("DataGrid/DataGridView.xaml")]
    [InlineData("DataGrid/DataGridViewModel.cs")]
    [InlineData(WelcomeProjectGenerator.RegistryPath)]
    public async Task EditedGeneratedContent_ConflictsBeforeAnyMutation(string file)
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write(file, app.Read(file) + "\n// user edit");
        var before = app.Snapshot();
        var calls = app.NuGet.Calls.Count;
        Assert.NotEqual(0, (await app.Installer.ExecuteRemoveAsync("datagrid", force: true)).ExitCode);
        Assert.Equal(before, app.Snapshot());
        Assert.Equal(calls, app.NuGet.Calls.Count);
        Assert.NotEqual(0, (await app.Installer.ExecuteAddAsync("datagrid", force: true)).ExitCode);
        Assert.Equal(before, app.Snapshot());
    }

    [Theory]
    [InlineData("core-registration")]
    [InlineData("core-using")]
    public async Task EditedInsertedBlocks_ConflictButUnrelatedProgramEditsArePreserved(string marker)
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        Assert.Contains(app.Manifest.GeneratedBlocks, block => block.Marker == marker);
        app.Write("MauiProgram.cs", app.Read("MauiProgram.cs").Replace("<sf-cli:" + marker + ">", "<sf-cli:" + marker + ">\n// user code"));
        var before = app.Snapshot();
        var result = await app.Installer.ExecuteRemoveAsync("datagrid");
        Assert.NotEqual(0, result.ExitCode);
        Assert.Contains("Conflict", result.Message);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task UnrelatedUserCodeOutsideBlocks_IsPreserved()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write("MauiProgram.cs", app.Read("MauiProgram.cs") + "\n// My custom startup configuration\n");
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("datagrid")).ExitCode);
        Assert.Contains("My custom startup configuration", app.Read("MauiProgram.cs"));
        Assert.DoesNotContain("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
    }

    [Theory]
    [InlineData("using Syncfusion.Maui.Charts; class Custom { SfCartesianChart chart = new(); }")]
    [InlineData("using Syncfusion.Maui.Core; class Custom { SfView view = new(); }")]
    public async Task CustomCode_RetainsPackageAndSharedRegistration(string custom)
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("cartesian-chart")).ExitCode);
        app.Write("Custom.cs", custom);
        var result = await app.Installer.ExecuteRemoveAsync("cartesian-chart");
        Assert.Equal(0, result.ExitCode);
        Assert.Empty(app.Manifest.InstalledControls);
        Assert.Contains("Syncfusion.Maui.Charts", app.Read("Demo.csproj"));
        Assert.Contains("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
        Assert.Contains(result.Plan!.Warnings, warning => warning.Contains("custom"));
        Assert.Equal(custom, app.Read("Custom.cs"));
    }

    [Fact]
    public async Task UserReferenceToGeneratedSample_ConflictsAndRetainsEntireSample()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write("Custom.cs", "class Custom { Demo.Syncfusion.Controls.DataGrid.Views.DataGridView page = new(); }");
        var before = app.Snapshot();
        var result = await app.Installer.ExecuteRemoveAsync("datagrid");
        Assert.NotEqual(0, result.ExitCode);
        Assert.Contains("Custom.cs", result.Message);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task PackageRemoval_CleansAllSamplesBelongingToPackage()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["cartesian-chart", "circular-chart", "datagrid"])).ExitCode);
        var result = await new PackageOperationService(app.NuGet).ExecuteAsync(app.Project, "charts", "Syncfusion.Maui.Charts", NuGetOperationKind.Remove);
        Assert.Equal(0, result.ExitCode);
        Assert.Equal("datagrid", Assert.Single(app.Manifest.InstalledControls));
        Assert.DoesNotContain("CircularChartView", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Contains("DataGridView", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.False(File.Exists(app.Path("CircularChart/CircularChartView.xaml")));
        Assert.Contains("Rebuild", result.Message);
    }

    [Fact]
    public async Task FailedPackageRemoval_RollsBackEntireBatchIncludingRegistryAndBlocks()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["datagrid", "listview"])).ExitCode);
        var before = app.Snapshot();
        app.NuGet.FailRemove = "Syncfusion.Maui.ListView";
        var result = await app.Installer.ExecuteRemoveBatchAsync(["datagrid", "listview"]);
        Assert.NotEqual(0, result.ExitCode);
        Assert.Contains("rolled back", result.Message);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task FailedBuild_RollsBackAddedRegistryEntriesPackagesAndSamples()
    {
        using var app = new App();
        var before = app.Snapshot();
        app.DotNet.FailBuild = true;
        var result = await app.Installer.ExecuteAddBatchAsync(["datagrid", "listview"]);
        Assert.NotEqual(0, result.ExitCode);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task CancellationDuringRemoval_RollsBackBatch()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["datagrid", "listview"])).ExitCode);
        var before = app.Snapshot();
        app.NuGet.CancelRemove = true;
        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => app.Installer.ExecuteRemoveBatchAsync(["datagrid", "listview"]));
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task ExistingUserPackageReference_IsRetainedOnIndividualSampleRemoval()
    {
        using var app = new App();
        app.NuGet.AddReference(app.Path("Demo.csproj"), "Syncfusion.Maui.DataGrid", "32.1.29");
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        Assert.False(Assert.Single(app.Manifest.InstalledTemplates).PackageReferenceOwned);
        var result = await app.Installer.ExecuteRemoveAsync("datagrid");
        Assert.Equal(0, result.ExitCode);
        Assert.Contains("Syncfusion.Maui.DataGrid", app.Read("Demo.csproj"));
        Assert.Contains(result.Plan!.Warnings, warning => warning.Contains("user-owned"));
    }

    [Fact]
    public async Task DryRunAndAbsentRemoval_LeaveAllFilesUnchanged()
    {
        using var app = new App();
        var before = app.Snapshot();
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("datagrid")).ExitCode);
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["datagrid", "listview"], dryRun: true)).ExitCode);
        Assert.Equal(before, app.Snapshot());
        Assert.Empty(app.NuGet.Calls);
    }

    [Fact]
    public void NativeWelcome_HasAdaptiveLayoutThemesWrappingSafeAreasAndAccessibleCommands()
    {
        using var app = new App();
        var xaml = app.Read("Welcome/WelcomeView.xaml");
        _ = XDocument.Parse(xaml);
        Assert.Contains("Welcome to Your New .NET MAUI App", xaml);
        Assert.Contains("Your application is running successfully.", xaml);
        Assert.Single(XDocument.Parse(xaml).Descendants(), element => element.Name.LocalName == "ScrollView");
        Assert.All(XDocument.Parse(xaml).Descendants().Where(element => element.Name.LocalName is "Label" or "Grid" or "VerticalStackLayout" or "FlexLayout" or "Border"),
            element => Assert.Equal("0", (string?)element.Attribute("MinimumHeightRequest")));
        Assert.Contains("SafeAreaEdges=\"All\"", xaml);
        Assert.Contains("Wrap=\"Wrap\"", xaml);
        Assert.Contains("AppThemeBinding", xaml);
        Assert.Contains("SemanticProperties.HeadingLevel", xaml);
        Assert.Contains("OpenSampleCommand", xaml);
        Assert.Contains("IsEmpty", xaml);
        Assert.Equal(4, app.Read("Welcome/WelcomeViewModel.cs").Split("new(\"").Length - 1);
        Assert.Equal(2, app.Manifest.SchemaVersion);
        Assert.All(app.Manifest.WelcomeFiles, file => Assert.NotNull(app.Manifest.OriginalHashes.GetValueOrDefault(file)));
    }

    [Fact]
    public void NativeWelcome_FooterUsesOfficialBrowserLinksAndSdkThemeResources()
    {
        using var app = new App();
        var root = XDocument.Parse(app.Read("Welcome/WelcomeView.xaml"));
        var copyright = root.Descendants().Single(e => (string?)e.Attribute("Text") ==
            "Copyright © 2001 - 2026 Syncfusion®, Inc. All Rights Reserved");
        Assert.Equal("WordWrap", (string?)root.Descendants().First(e =>
            e.Name.LocalName == "Setter" && (string?)e.Attribute("Property") == "LineBreakMode" &&
            (string?)e.Attribute("Value") == "WordWrap").Attribute("Value"));
        Assert.Equal("Start", (string?)copyright.Attribute("HorizontalTextAlignment"));
        var destinations = new Dictionary<string, string>
        {
            ["Privacy Policy"] = "https://www.syncfusion.com/legal/privacy-policy/",
            ["Terms of Service"] = "https://www.syncfusion.com/legal/website-terms-of-use/",
            ["Contact Us"] = "https://www.syncfusion.com/company/contact-us"
        };
        foreach (var (text, url) in destinations)
        {
            var link = root.Descendants().Single(e => (string?)e.Attribute("Text") == text);
            Assert.Equal(url, (string?)link.Attribute("CommandParameter"));
            Assert.Equal("{Binding OpenLinkCommand}", (string?)link.Attribute("Command"));
            Assert.NotNull(link.Attribute("SemanticProperties.Hint"));
        }
        Assert.DoesNotContain(root.Descendants(), e => (string?)e.Attribute("Text") is "Syncfusion" or "Support");
        var links = root.Descendants().Single(e =>
            (string?)e.Attribute(XName.Get("Name", "http://schemas.microsoft.com/winfx/2009/xaml")) == "FooterLinks");
        Assert.Equal("Grid", links.Name.LocalName);
        Assert.Equal("*,*,*", (string?)links.Attribute("ColumnDefinitions"));
        Assert.Equal("End", (string?)links.Attribute("HorizontalOptions"));
        Assert.Equal(3, links.Elements().Count());
        // Grid.Children exposes IView; its row/column overloads are instance methods.
        var codeBehind = app.Read("Welcome/WelcomeView.xaml.cs");
        Assert.Contains("FooterLinks.SetRow(FooterLinks.Children[index], index / columns);", codeBehind);
        Assert.Contains("FooterLinks.SetColumn(FooterLinks.Children[index], index % columns);", codeBehind);
        Assert.DoesNotContain("Grid.SetRow(FooterLinks.Children", codeBehind);
        Assert.DoesNotContain("Grid.SetColumn(FooterLinks.Children", codeBehind);
        // MAUI SourceGen requires literal StaticResource keys; implicit type keys fail compilation.
        Assert.All(root.Descendants().Where(e => e.Name.LocalName == "Style"),
            style => Assert.Null(style.Attribute("BasedOn")));
        Assert.Null(root.Root!.Attribute("BackgroundColor"));
        Assert.DoesNotContain("#", app.Read("Welcome/WelcomeView.xaml"));
        Assert.Contains("BrowserLaunchMode.SystemPreferred", app.Read("Welcome/WelcomeViewModel.cs"));
    }

    [Fact]
    public void Net9Welcome_UsesCompatibleSafeAreaProperty()
    {
        using var app = new App(welcome: false);
        app.Write("Demo.csproj", app.Read("Demo.csproj").Replace("net10.0-android", "net9.0-android"));
        using var rollback = new FileRollback();
        WelcomeProjectGenerator.Install(app.Root, "Demo", rollback);
        rollback.Commit();
        var xaml = app.Read("Welcome/WelcomeView.xaml");
        _ = XDocument.Parse(xaml);
        Assert.DoesNotContain("SafeAreaEdges", xaml);
        Assert.Contains("ios:Page.UseSafeArea=\"True\"", xaml);
        Assert.Contains("net9.0-android", app.Manifest.TargetFramework);
    }

    [Fact]
    public async Task RestoredPackageBatchAddsSamplesForEverySupportedPackage()
    {
        using var app = new App();
        var service = new PackageOperationService(app.NuGet, app.DotNet);
        var results = new List<PackageOperationResult>();
        var exit = await Syncfusion.DotNet.CLI.Commands.Operations.CommandOperations.RunPackageSelectionAsync(
            ["datagrid", "kanban"], async (alias, last) =>
            {
                Assert.True(PackageCatalog.TryResolve(alias, out var package));
                var result = await service.ExecuteAsync(app.Project, package, NuGetOperationKind.Add,
                    noRestore: false, build: last);
                results.Add(result);
                return result.ExitCode;
            });
        Assert.Equal(0, exit);
        Assert.All(results, result => Assert.True(result.SampleGenerationSucceeded));
        Assert.Contains("added DataGrid", results[0].Message);
        Assert.Contains("added Kanban", results[1].Message);
        Assert.Contains("datagrid", app.Manifest.InstalledControls);
        Assert.Contains("kanban", app.Manifest.InstalledControls);
        var picker = new MauiControlSelectionProvider(app.Project);
        Assert.True(picker.Controls.Single(control => control.Id == "datagrid").Added);
        Assert.True(picker.Controls.Single(control => control.Id == "kanban").Added);
        Assert.True(picker.Packages.Single(package => package.Id == "datagrid").Added);
        Assert.True(picker.Packages.Single(package => package.Id == "kanban").Added);
        Assert.Single(app.DotNet.Calls, call => call[0] == "build");
    }

    [Theory]
    [InlineData("datagrid", "Syncfusion.Maui.DataGrid", "package restore was skipped")]
    [InlineData("inputs", "Syncfusion.Maui.Inputs", "this package has no sample template")]
    public async Task MissingSampleReasonUsesPlainLanguage(string alias, string packageId, string reason)
    {
        using var app = new App();
        var result = await new PackageOperationService(app.NuGet, app.DotNet).ExecuteAsync(
            app.Project, alias, packageId, NuGetOperationKind.Add, noRestore: true);
        Assert.Equal(0, result.ExitCode);
        Assert.Contains("No sample added: " + reason, result.Message);
        Assert.DoesNotContain("Package-only operation", result.Message);
    }

    [Theory]
    [InlineData("datagrid", "Syncfusion.Maui.DataGrid")]
    [InlineData("inputs", "Syncfusion.Maui.Inputs")]
    public async Task PackageOnlyAdd_RemainsPackageOnly_AndExplainsSampleAvailability(string alias, string packageId)
    {
        using var app = new App(welcome: false);
        var result = await new PackageOperationService(app.NuGet).ExecuteAsync(app.Project, alias, packageId, NuGetOperationKind.Add);
        Assert.Equal(0, result.ExitCode);
        Assert.Contains("no sample", result.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Null(WelcomeProjectGenerator.ReadManifest(app.Root));
        Assert.False(File.Exists(app.Path(WelcomeProjectGenerator.RegistryPath)));
        Assert.Contains("My existing app", app.Read("MainPage.xaml"));
    }

    [Fact]
    public async Task FailedPackageOnlyAdd_RestoresReferenceWrittenBeforeRestoreFailure()
    {
        using var app = new App();
        var before = app.Snapshot();
        app.NuGet.FailAdd = true;
        var result = await new PackageOperationService(app.NuGet).ExecuteAsync(app.Project, "inputs", "Syncfusion.Maui.Inputs", NuGetOperationKind.Add);
        Assert.NotEqual(0, result.ExitCode);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task LegacyPage_UsesTrackedBlocksAndPreservesUserContents()
    {
        using var app = new App(welcome: false, legacy: true);
        var original = app.Read("MainPage.xaml");
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        Assert.Equal(2, app.Manifest.GeneratedBlocks.Count(block => block.Marker == "sf-nav:DataGrid"));
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("datagrid")).ExitCode);
        Assert.DoesNotContain("sf-nav:", app.Read("MainPage.xaml"));
        Assert.Contains("My existing app", app.Read("MainPage.xaml"));
        Assert.Contains("My existing app", original);
    }

    [Fact]
    public void Rollback_PreservesBinaryBytesAndTextEncoding()
    {
        using var app = new App();
        var bytes = new byte[] { 0xef, 0xbb, 0xbf, 0x61, 0x0d, 0x0a, 0xff, 0x00 };
        var path = app.Path("encoded.bin");
        File.WriteAllBytes(path, bytes);
        using var rollback = new FileRollback();
        rollback.TrackModified(path);
        File.WriteAllBytes(path, [1, 2, 3]);
        Assert.Empty(rollback.Rollback());
        Assert.Equal(bytes, File.ReadAllBytes(path));
    }

    [Theory]
    [InlineData("{\"schemaVersion\":2,\"generatedFiles\":null}")]
    [InlineData("{\"schemaVersion\":2,\"generatedFiles\":[\"../user.cs\"]}")]
    [InlineData("{\"schemaVersion\":2,\"installedControls\":[\"datagrid\",\"datagrid\"]}")]
    [InlineData("{\"schemaVersion\":2,\"installedTemplates\":[{\"id\":\"datagrid\"}]}")]
    public void InvalidManifest_IsRejectedBeforeModifyingAnything(string json)
        => Assert.Throws<InvalidOperationException>(() => SyncfusionManifest.FromJson(json));

    [Fact]
    public async Task EditedLegacyNavigationBlock_ConflictsBeforeDeletingSample()
    {
        using var app = new App(welcome: false, legacy: true);
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write("MainPage.xaml", app.Read("MainPage.xaml").Replace("OnOpenDataGridClicked", "MyCustomHandler"));
        var before = app.Snapshot();
        var result = await app.Installer.ExecuteRemoveAsync("datagrid");
        Assert.NotEqual(0, result.ExitCode);
        Assert.Contains("MainPage.xaml", result.Message);
        Assert.Equal(before, app.Snapshot());
    }

    [Theory]
    [InlineData("datagrid", "Syncfusion.Maui.DataGrid", "datagrid")]
    [InlineData("kanban", "Syncfusion.Maui.Kanban", "kanban")]
    [InlineData("charts", "Syncfusion.Maui.Charts", "cartesian-chart")]
    public async Task ManagedPackageAlias_UsesSharedSampleWorkflow(string alias, string package, string control)
    {
        using var app = new App();
        var page = app.Read("Welcome/WelcomeView.xaml");
        var service = new PackageOperationService(app.NuGet, app.DotNet);
        var result = await service.ExecuteAsync(app.Project, alias, package, NuGetOperationKind.Add);
        Assert.Equal(0, result.ExitCode);
        Assert.True(result.SampleGenerationSucceeded);
        Assert.True(result.BuildSucceeded);
        Assert.Equal(control, Assert.Single(app.Manifest.InstalledControls));
        Assert.Contains('"' + control + '"', app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Equal(page, app.Read("Welcome/WelcomeView.xaml"));
        Assert.Equal(new[] { "build", app.Project.CsprojPath }, Assert.Single(app.DotNet.Calls, call => call[0] == "build"));
        var snapshot = app.Snapshot();
        var calls = app.NuGet.Calls.Count;
        Assert.Equal(0, (await service.ExecuteAsync(app.Project, alias, package, NuGetOperationKind.Add)).ExitCode);
        Assert.Equal(snapshot, app.Snapshot());
        Assert.Equal(calls, app.NuGet.Calls.Count);
    }

    [Fact]
    public async Task SharedPackage_AddSecondSamplePreservesVersionAndOwnedReference()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("cartesian-chart", version: "32.1.29")).ExitCode);
        var packageCalls = app.NuGet.Calls.Count;
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("circular-chart")).ExitCode);
        Assert.Equal(packageCalls, app.NuGet.Calls.Count);
        Assert.Equal("32.1.29", (string?)XDocument.Load(app.Path("Demo.csproj")).Descendants("PackageReference").Single().Attribute("Version"));
        Assert.Contains("CircularChartView", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("cartesian-chart")).ExitCode);
        Assert.Contains("Syncfusion.Maui.Charts", app.Read("Demo.csproj"));
        Assert.Contains("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("cartesian-chart")).ExitCode);
        Assert.Equal(2, app.Manifest.InstalledControls.Count);
        Assert.Equal(0, (await app.Installer.ExecuteRemoveBatchAsync(["cartesian-chart", "circular-chart"])).ExitCode);
        Assert.Empty(app.Manifest.InstalledControls);
        Assert.DoesNotContain("new(", app.Read(WelcomeProjectGenerator.RegistryPath));
    }

    [Theory]
    [InlineData("registry")]
    [InlineData("registration")]
    [InlineData("package")]
    public async Task RepeatedAdd_RepairsIncompleteOwnedSetup(string missing)
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        if (missing == "registry") File.Delete(app.Path(WelcomeProjectGenerator.RegistryPath));
        if (missing == "registration") app.Write("MauiProgram.cs", GeneratedCodeBlocks.Remove(app.Read("MauiProgram.cs"), "core-registration"));
        if (missing == "package")
        {
            var document = XDocument.Load(app.Path("Demo.csproj"));
            document.Descendants("PackageReference").Remove();
            document.Save(app.Path("Demo.csproj"));
        }
        var result = await app.Installer.ExecuteAddAsync("datagrid");
        Assert.Equal(0, result.ExitCode);
        Assert.Single(app.Manifest.InstalledControls);
        Assert.Single(app.Manifest.InstalledTemplates);
        Assert.Single(app.Manifest.GeneratedBlocks, block => block.Marker == "core-registration");
        Assert.Contains("DataGridView", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Contains("ConfigureSyncfusionCore", app.Read("MauiProgram.cs"));
        Assert.Single(XDocument.Load(app.Path("Demo.csproj")).Descendants("PackageReference"));
    }

    [Fact]
    public async Task MissingFileWithEditedRecordedContent_CannotBeReconstructed()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        var file = "DataGrid/DataGridView.xaml";
        var manifest = app.Manifest;
        manifest.OriginalHashes[file] = ProjectControlState.HashContent("previous custom content");
        app.Write(WelcomeProjectGenerator.ManifestPath, manifest.ToJson());
        File.Delete(app.Path(file));
        var before = app.Snapshot();
        Assert.NotEqual(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        Assert.Equal(before, app.Snapshot());
    }

    [Theory]
    [InlineData(true)]  // ownership hash matches the embedded PDF bytes: repair succeeds
    [InlineData(false)] // ownership hash does not match: conflict, nothing changes
    public async Task MissingPdfResource_IsHandledThroughBinaryOwnership(bool recordedHashMatches)
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["pdf-viewer"], deferBuild: true)).ExitCode);
        const string pdfDestination = "PdfViewer/Pdf/PDF_Succinctly.pdf";
        var pdfResource = TemplatePathResolver.ResolveResourceName(
            TemplateCatalog.All.Single(entry => entry.Id == "pdf-viewer").TemplatePath, "Pdf/PDF_Succinctly.pdf");

        var manifest = app.Manifest;
        if (!recordedHashMatches)
        {
            // Corrupt the recorded ownership hash so reconstruction must refuse.
            manifest.OriginalHashes[pdfDestination] = ProjectControlState.HashContent("not the real pdf");
        }
        app.Write(WelcomeProjectGenerator.ManifestPath, manifest.ToJson());
        File.Delete(app.Path(pdfDestination));
        var before = app.Snapshot();

        var result = await app.Installer.ExecuteAddBatchAsync(["pdf-viewer"], deferBuild: true);
        if (recordedHashMatches)
        {
            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.Equal(EmbeddedResourceLoader.ReadBytes(pdfResource), File.ReadAllBytes(app.Path(pdfDestination)));
        }
        else
        {
            Assert.NotEqual(0, result.ExitCode);
            Assert.Equal(before, app.Snapshot());
        }
    }

    [Fact]
    public async Task LegacyManifest_ReconstructsVerifiedOwnershipAndPersistsOnlyAfterSuccess()
    {
        using var app = new App(welcome: false, legacy: true);
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("charts")).ExitCode);
        var manifest = app.Manifest;
        manifest.SchemaVersion = 1;
        manifest.InstalledControls = ["charts"];
        manifest.InstalledTemplates.Clear();
        foreach (var file in manifest.GeneratedFiles.Where(file => file.StartsWith("CartesianChart/"))) manifest.OriginalHashes.Remove(file);
        app.Write(WelcomeProjectGenerator.ManifestPath, manifest.ToJson());
        var before = app.Snapshot();
        Assert.Equal(0, app.Installer.PlanAdd("circular-chart").ExitCode);
        Assert.Equal(before, app.Snapshot());
        app.DotNet.FailBuild = true;
        Assert.NotEqual(0, (await app.Installer.ExecuteAddAsync("circular-chart")).ExitCode);
        Assert.Equal(before, app.Snapshot());
        app.DotNet.FailBuild = false;
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("circular-chart")).ExitCode);
        Assert.Equal(2, app.Manifest.SchemaVersion);
        Assert.Contains("cartesian-chart", app.Manifest.InstalledControls);
        Assert.Equal(2, app.Manifest.InstalledTemplates.Count);
        Assert.Equal(0, (await app.Installer.ExecuteRemoveBatchAsync(["cartesian-chart", "circular-chart"])).ExitCode);
        Assert.DoesNotContain("OnOpen", app.Read("MainPage.xaml.cs"));
    }

    [Fact]
    public async Task OrdinaryProject_ControlGenerationPreservesStartupAndReportsUnavailableNavigation()
    {
        using var app = new App(welcome: false);
        var page = app.Read("MainPage.xaml");
        var code = app.Read("MainPage.xaml.cs");
        var result = await app.Installer.ExecuteAddAsync("datagrid");
        Assert.Equal(0, result.ExitCode);
        Assert.Equal(page, app.Read("MainPage.xaml"));
        Assert.Equal(code, app.Read("MainPage.xaml.cs"));
        Assert.Contains(result.Plan!.Warnings, warning => warning.Contains("navigation is unavailable"));
        Assert.Empty(Assert.Single(app.Manifest.InstalledTemplates).NavigationEntries);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("net10.0-android")]
    public async Task BuildsUseConfiguredTargetsOrExplicitSelection(string? framework)
    {
        using var app = new App();
        var result = await app.Installer.ExecuteAddBatchAsync(["datagrid"], buildFramework: framework);
        Assert.Equal(0, result.ExitCode);
        var expected = framework is null ? new[] { "build", app.Project.CsprojPath }
            : new[] { "build", app.Project.CsprojPath, "-f", framework };
        Assert.Equal(expected, Assert.Single(app.DotNet.Calls, call => call[0] == "build"));
    }

    [Fact]
    public async Task InvalidExplicitBuildTarget_IsRejectedBeforeMutation()
    {
        using var app = new App();
        var before = app.Snapshot();
        var result = await app.Installer.ExecuteAddBatchAsync(["datagrid"], buildFramework: "net10.0-ios");
        Assert.NotEqual(0, result.ExitCode);
        Assert.Contains("not enabled", result.Message);
        Assert.Empty(app.NuGet.Calls);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task PackageUpdate_KeepsSharedControlVersionMetadataSynchronized()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["cartesian-chart", "circular-chart"], version: "32.1.29")).ExitCode);
        var result = await new PackageOperationService(app.NuGet, app.DotNet).ExecuteAsync(app.Project, "charts", "Syncfusion.Maui.Charts",
            NuGetOperationKind.Add, version: "35.1.39", update: true);
        Assert.Equal(0, result.ExitCode);
        Assert.Equal("35.1.39", app.Manifest.PackageVersions["Syncfusion.Maui.Charts"]);
        Assert.All(app.Manifest.InstalledTemplates, record => Assert.Equal("35.1.39", record.ResolvedVersion));
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("circular-chart", version: "35.1.39")).ExitCode);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("net10.0-android")]
    public async Task RemovalBuild_UsesPlannedCommandAndRollsBackFailure(string? framework)
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.DotNet.Calls.Clear();
        var before = app.Snapshot();
        app.DotNet.FailBuild = true;
        var failed = await app.Installer.ExecuteRemoveBatchAsync(["datagrid"], build: true, buildFramework: framework);
        Assert.NotEqual(0, failed.ExitCode);
        Assert.False(failed.PackageChangesSucceeded);
        Assert.False(failed.SampleGenerationSucceeded);
        Assert.False(failed.BuildSucceeded);
        Assert.Equal(before, app.Snapshot());
        app.DotNet.Calls.Clear();
        app.DotNet.FailBuild = false;
        Assert.Equal(0, (await app.Installer.ExecuteRemoveBatchAsync(["datagrid"], build: true, buildFramework: framework)).ExitCode);
        Assert.Equal(MauiPostCreationBuild.Arguments(app.Project.CsprojPath, framework), Assert.Single(app.DotNet.Calls, call => call[0] == "build"));
        Assert.Empty(app.Manifest.InstalledControls);
    }

    [Fact]
    public async Task HybridTemplate_IntegratesRegistryButtonsAndKeepsBlazorContent()
    {
        using var app = new App(welcome: false, hybrid: true);
        Assert.Equal(0, (await new PackageOperationService(app.NuGet, app.DotNet)
            .ExecuteAsync(app.Project, "datagrid", "Syncfusion.Maui.DataGrid", NuGetOperationKind.Add)).ExitCode);
        var page = app.Read("MainPage.xaml");
        _ = XDocument.Parse(page);
        Assert.Contains("BlazorWebView", page);
        Assert.Contains("Wrap=\"Wrap\"", page);
        Assert.Contains("CornerRadius=\"20\"", page);
        Assert.Contains("BindableLayout.ItemsSource=\"{Binding Samples}\"", page);
        Assert.Contains("PushModalAsync(new NavigationPage(page))", app.Read("MainPage.xaml.cs"));
        Assert.Equal("datagrid", Assert.Single(app.Manifest.InstalledTemplates).WelcomeEntry);
        var next = await app.Installer.ExecuteAddAsync("kanban");
        Assert.True(next.ExitCode == 0, next.Message + string.Join("\n", next.Errors));
        Assert.Equal(page, app.Read("MainPage.xaml"));
        Assert.Equal(0, (await app.Installer.ExecuteRemoveBatchAsync(["datagrid", "kanban"])).ExitCode);
        Assert.DoesNotContain("new(", app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Contains("IsEmpty", app.Read("MainPage.xaml"));
    }

    [Fact]
    public async Task EditedHybridPageWithoutOwnership_PreservesPageAndReportsUnavailableIntegration()
    {
        using var app = new App(welcome: false, hybrid: true);
        app.Write("MainPage.xaml", app.Read("MainPage.xaml").Replace("wwwroot/index.html", "wwwroot/custom.html"));
        var before = app.Read("MainPage.xaml");
        var result = await app.Installer.ExecuteAddAsync("datagrid");
        Assert.Equal(0, result.ExitCode);
        Assert.Equal(before, app.Read("MainPage.xaml"));
        Assert.Contains(result.Plan!.Warnings, warning => warning.Contains("navigation is unavailable"));
    }

    [Fact]
    public async Task LegacyNavigation_MissingOwnedBlockIsRepairedAndUnrelatedEditsRemain()
    {
        using var app = new App(welcome: false, legacy: true);
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write("MainPage.xaml", GeneratedCodeBlocks.Remove(app.Read("MainPage.xaml"), "sf-nav:DataGrid"));
        app.Write("MainPage.xaml.cs", app.Read("MainPage.xaml.cs") + "\n// Customer feature\n");
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        Assert.Single(app.Manifest.GeneratedBlocks, block => block.Path == "MainPage.xaml" && block.Marker == "sf-nav:DataGrid");
        Assert.Contains("OnOpenDataGridClicked", app.Read("MainPage.xaml"));
        Assert.Contains("Customer feature", app.Read("MainPage.xaml.cs"));
    }

    [Fact]
    public async Task UntrackedDuplicateNavigationMarker_BlocksRemovalWithoutDeletingCustomerCode()
    {
        using var app = new App(welcome: false, legacy: true);
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write("MainPage.xaml", app.Read("MainPage.xaml") + "\n<!-- Customer feature -->\n<Button Text=\"Customer action\" /> <!-- sf-nav:DataGrid -->\n");
        var before = app.Snapshot();
        var result = await app.Installer.ExecuteRemoveAsync("datagrid");
        Assert.NotEqual(0, result.ExitCode);
        Assert.Contains("duplicated outside", result.Message);
        Assert.Equal(before, app.Snapshot());
    }

    [Fact]
    public async Task InvalidManagedManifest_StopsPackageAddBeforeChangingProject()
    {
        using var app = new App();
        app.Write(WelcomeProjectGenerator.ManifestPath, "{ invalid }");
        var before = app.Snapshot();
        var result = await new PackageOperationService(app.NuGet, app.DotNet)
            .ExecuteAsync(app.Project, "datagrid", "Syncfusion.Maui.DataGrid", NuGetOperationKind.Add);
        Assert.NotEqual(0, result.ExitCode);
        Assert.Contains("No changes made", result.Message);
        Assert.Equal(before, app.Snapshot());
        Assert.Empty(app.NuGet.Calls);
    }

    [Fact]
    public async Task OlderInlineNavigation_IsReconstructedFromVerifiedSamplesAndRemovedSafely()
    {
        using var app = new App(welcome: false);
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("charts")).ExitCode);
        app.Write("MainPage.xaml", app.Read("MainPage.xaml").Replace("</VerticalStackLayout>",
            "\n<Button Text=\"Cartesian Chart\" Clicked=\"OnOpenCartesianChartClicked\" HorizontalOptions=\"Fill\" /> <!-- sf-nav:CartesianChart -->\n</VerticalStackLayout>"));
        app.Write("MainPage.xaml.cs", app.Read("MainPage.xaml.cs").Replace("    public MainPage()", "    private async void OnOpenCartesianChartClicked(object? sender, EventArgs e) => await Navigation.PushAsync(new global::Demo.CartesianChart.CartesianChartView()); // sf-nav:CartesianChart\n    public MainPage()"));
        var legacy = app.Manifest;
        legacy.SchemaVersion = 1;
        legacy.InstalledTemplates.Clear();
        app.Write(WelcomeProjectGenerator.ManifestPath, legacy.ToJson());
        var snapshot = app.Snapshot();
        Assert.Equal(2, app.Manifest.GeneratedBlocks.Count(block => block.Marker == "sf-nav:CartesianChart"));
        Assert.Equal(snapshot, app.Snapshot());
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("circular-chart")).ExitCode);
        Assert.Contains("OnOpenCircularChartClicked", app.Read("MainPage.xaml"));
        Assert.Equal(0, (await app.Installer.ExecuteRemoveAsync("cartesian-chart")).ExitCode);
        Assert.DoesNotContain("sf-nav:CartesianChart", app.Read("MainPage.xaml"));
        Assert.DoesNotContain("OnOpenCartesianChartClicked", app.Read("MainPage.xaml.cs"));
        Assert.Contains("My existing app", app.Read("MainPage.xaml"));
        Assert.Contains("OnOpenCircularChartClicked", app.Read("MainPage.xaml.cs"));
    }

    [Fact]
    public async Task ExplicitOtherProjectInSameDirectory_DoesNotModifyOwnersSamplesOrManifest()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("datagrid")).ExitCode);
        app.Write("Other.csproj", app.Read("Demo.csproj").Replace("<RootNamespace>Demo</RootNamespace>", "<RootNamespace>Other</RootNamespace>"));
        var manifest = app.Read(WelcomeProjectGenerator.ManifestPath);
        var registry = app.Read(WelcomeProjectGenerator.RegistryPath);
        var page = app.Read("Welcome/WelcomeView.xaml");
        var other = MauiProjectResolver.Resolve(app.Path("Other.csproj"));
        var result = await new PackageOperationService(app.NuGet, app.DotNet)
            .ExecuteAsync(other, "inputs", "Syncfusion.Maui.Inputs", NuGetOperationKind.Add);
        Assert.Equal(0, result.ExitCode);
        Assert.Contains("no sample", result.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Equal(manifest, app.Read(WelcomeProjectGenerator.ManifestPath));
        Assert.Equal(registry, app.Read(WelcomeProjectGenerator.RegistryPath));
        Assert.Equal(page, app.Read("Welcome/WelcomeView.xaml"));
        Assert.False(File.Exists(app.Path("Syncfusion/Controls/ComboBox/Views/ComboBoxView.xaml")));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task ControlStagesReflectActualAddRemoveWork(bool build)
    {
        using var app = new App();
        var stages = new StageRecorder();
        var added = await app.Installer.ExecuteAddBatchAsync(["datagrid"], deferBuild: !build, progress: stages);
        Assert.Equal(0, added.ExitCode);
        Assert.Equal(build ? ["Adding packages", "Restoring", "Generating files", "Registering in MauiProgram.cs", "Building"]
            : new[] { "Adding packages", "Restoring", "Generating files", "Registering in MauiProgram.cs" }, stages.Values);
        stages.Values.Clear();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["datagrid"], deferBuild: !build, progress: stages)).ExitCode);
        Assert.Empty(stages.Values);
        Assert.Equal(0, (await app.Installer.ExecuteRemoveBatchAsync(["datagrid"], build: build, progress: stages)).ExitCode);
        Assert.Equal(build ? ["Removing files", "Updating registration", "Removing packages", "Building"]
            : new[] { "Removing files", "Updating registration", "Removing packages" }, stages.Values);
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(true, true)]
    public async Task PackageStagesHonorRestoreAndRetainPackageOnlyBehavior(bool update, bool noRestore)
    {
        using var app = new App(welcome: false);
        var stages = new StageRecorder();
        var result = await new PackageOperationService(app.NuGet, app.DotNet).ExecuteAsync(
            app.Project, "inputs", "Syncfusion.Maui.Inputs", NuGetOperationKind.Add,
            update: update, noRestore: noRestore, progress: stages);
        Assert.Equal(0, result.ExitCode);
        Assert.Equal(noRestore ? new[] { update ? "Updating package" : "Adding package" }
            : [update ? "Updating package" : "Adding package", "Restoring"], stages.Values);
        Assert.DoesNotContain(app.DotNet.Calls, call => call[0] == "build");
        stages.Values.Clear();
        Assert.Equal(0, (await new PackageOperationService(app.NuGet, app.DotNet).ExecuteAsync(
            app.Project, "inputs", "Syncfusion.Maui.Inputs", NuGetOperationKind.Remove, progress: stages)).ExitCode);
        Assert.Equal(["Removing packages"], stages.Values); // dotnet remove performs no restore.
    }

    [Fact]
    public async Task SharedPackageAddReportsOnlyStagesThatApply()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("cartesian-chart")).ExitCode);
        var stages = new StageRecorder();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["circular-chart"], deferBuild: true, progress: stages)).ExitCode);
        Assert.Equal(["Restoring", "Generating files"], stages.Values);
    }

    private sealed class StageRecorder : IProgress<string>
    {
        public List<string> Values { get; } = [];
        public void Report(string value) => Values.Add(value);
    }

    [Theory]
    [InlineData("none")]
    [InlineData("package")]
    [InlineData("restore")]
    [InlineData("build")]
    public async Task ControlLifecycleTracksActualWorkAndPreservesRollbackOnFailure(string failure)
    {
        using var app = new App();
        var snapshot = app.Snapshot();
        app.NuGet.FailAdd = failure == "package";
        app.DotNet.FailRestore = failure == "restore";
        app.DotNet.FailBuild = failure == "build";
        var stages = new RecordingOperationStages();
        var result = await app.Installer.ExecuteAddBatchAsync(["datagrid"], progress: stages);
        Assert.Equal(failure == "none" ? 0 : 1, result.ExitCode);
        if (failure != "none")
        {
            var label = failure == "package" ? "Adding packages" : failure == "restore" ? "Restoring" : "Building";
            Assert.Contains((label, "failed"), stages.Events);
            Assert.DoesNotContain((label, "completed"), stages.Events);
            Assert.Equal(snapshot, app.Snapshot());
        }
        else
        {
            Assert.Equal(["Adding packages", "Restoring", "Generating files", "Registering in MauiProgram.cs", "Updating navigation", "Writing control manifest", "Building"],
                stages.Events.Where(item => item.State == "completed").Select(item => item.Label));
            Assert.Contains("DataGridView", app.Read(WelcomeProjectGenerator.RegistryPath));
            Assert.DoesNotContain(stages.Events, item => item.State == "failed");
            Assert.Contains(stages.Measurements, item => item.Label == "Generating files" && item.Completed == item.Total && item.Total > 0);
        }
    }

    [Fact]
    public async Task SharedPackageLifecycleOmitsPackageAndRegistrationWorkAndRepeatedAddHasNoStages()
    {
        using var app = new App();
        Assert.Equal(0, (await app.Installer.ExecuteAddAsync("cartesian-chart")).ExitCode);
        var stages = new RecordingOperationStages();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["circular-chart"], deferBuild: true, progress: stages)).ExitCode);
        Assert.DoesNotContain("Adding packages", stages.Planned);
        Assert.DoesNotContain("Registering in MauiProgram.cs", stages.Planned);
        Assert.DoesNotContain("Building", stages.Planned);
        Assert.Contains(("Updating navigation", "completed"), stages.Events);
        stages.Events.Clear(); stages.Planned.Clear();
        Assert.Equal(0, (await app.Installer.ExecuteAddBatchAsync(["circular-chart"], deferBuild: true, progress: stages)).ExitCode);
        Assert.Empty(stages.Events);
        Assert.Empty(stages.Planned);
    }

    [Fact]
    public async Task ControlManifestAndAllGeneratedFilesAreWrittenBeforeBuild()
    {
        using var app = new App();
        string? atBuild = null;
        app.DotNet.BeforeBuild = () =>
        {
            Assert.Contains(app.Manifest.InstalledTemplates, entry => entry.Id == "datagrid");
            Assert.Contains("DataGridView", app.Read(WelcomeProjectGenerator.RegistryPath));
            atBuild = app.Snapshot();
        };
        var result = await app.Installer.ExecuteAddBatchAsync(["datagrid"]);
        Assert.Equal(ExitCodes.Success, result.ExitCode);
        Assert.NotNull(atBuild);
        Assert.Equal(atBuild, app.Snapshot());
    }

    private sealed class App : IDisposable
    {
        public string Root { get; } = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "sf-welcome-tests-" + Guid.NewGuid().ToString("N"));
        public FakeNuGet NuGet { get; } = new();
        public FakeDotNet DotNet { get; } = new();
        public ProjectDetector.ProjectInfo Project => MauiProjectResolver.Resolve(Root);
        public ControlInstaller Installer { get; }
        public SyncfusionManifest Manifest => WelcomeProjectGenerator.ReadManifest(Root)!;
        public App(bool welcome = true, bool legacy = false, bool hybrid = false)
        {
            Directory.CreateDirectory(Root);
            Write("Demo.csproj", "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><UseMaui>true</UseMaui><TargetFramework>net10.0-android</TargetFramework><RootNamespace>Demo</RootNamespace></PropertyGroup></Project>");
            Write("MauiProgram.cs", "namespace Demo;\npublic static class MauiProgram\n{\n    public static MauiApp CreateMauiApp()\n    {\n        var builder = MauiApp.CreateBuilder();\n        return builder.Build();\n    }\n}\n");
            Write("MainPage.xaml", "<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"><VerticalStackLayout><Label Text=\"My existing app\" /></VerticalStackLayout></ContentPage>");
            Write("MainPage.xaml.cs", "namespace Demo;\npublic partial class MainPage : ContentPage\n{\n    public MainPage() { InitializeComponent(); }\n}\n");
            if (welcome)
            {
                using var rollback = new FileRollback();
                WelcomeProjectGenerator.Install(Root, "Demo", rollback);
                rollback.Commit();
            }
            if (legacy)
            {
                var manifest = new SyncfusionManifest { SchemaVersion = 1, CliVersion = "0.1.0-preview.1", Framework = "maui", ProjectType = "app",
                    ModifiedFiles = ["MainPage.xaml", "MainPage.xaml.cs"] };
                foreach (var file in manifest.ModifiedFiles) manifest.OriginalHashes[file] = FileRollback.ComputeHash(Path(file))!;
                Write(WelcomeProjectGenerator.ManifestPath, manifest.ToJson());
            }
            if (hybrid)
            {
                foreach (var file in new[] { "MainPage.xaml", "MainPage.xaml.cs" })
                    Write(file, EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResourcePrefix + "Templates.Welcome.HybridReference." + file)
                        .Replace("__ROOT_NAMESPACE__", "Demo"));
                Write(WelcomeProjectGenerator.ManifestPath, new SyncfusionManifest
                    { CliVersion = "0.1.0-preview.1", Framework = "maui", ProjectType = "blazor-hybrid" }.ToJson());
            }
            Installer = new ControlInstaller(Project, NuGet, DotNet);
        }
        public string Path(string relative) => TemplatePathResolver.ResolveDestination(Root, relative);
        public string Read(string relative) => File.ReadAllText(Path(relative));
        public void Write(string relative, string content) { var path = Path(relative); Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!); File.WriteAllText(path, content); }
        public string Snapshot() => string.Join("\n", Directory.GetFiles(Root, "*", SearchOption.AllDirectories).OrderBy(path => path)
            .Select(path => System.IO.Path.GetRelativePath(Root, path) + ":" + FileRollback.ComputeHash(path)));
        public void Dispose() => Directory.Delete(Root, true);
    }

    private sealed class FakeNuGet : NuGetRunner
    {
        public List<string> Calls { get; } = [];
        public string? FailRemove { get; set; }
        public bool CancelRemove { get; set; }
        public bool FailAdd { get; set; }
        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
        {
            Calls.Add(operation.Kind + ":" + operation.PackageId);
            if (operation.Kind == NuGetOperationKind.Add && !operation.NoRestore && !operation.DryRun) operation.StageProgress?.Report("Restoring");
            if (operation.Kind == NuGetOperationKind.Remove && CancelRemove) throw new OperationCanceledException(cancellationToken);
            if (operation.Kind == NuGetOperationKind.Remove && operation.PackageId == FailRemove)
                return Task.FromResult(new NuGetCommandResult { ExitCode = 1, StandardOutput = "", StandardError = "simulated failure" });
            if (!operation.DryRun)
            {
                var xml = XDocument.Load(operation.ProjectPath);
                var reference = xml.Descendants("PackageReference").FirstOrDefault(element => (string?)element.Attribute("Include") == operation.PackageId);
                if (operation.Kind == NuGetOperationKind.Remove) { reference?.Remove(); xml.Save(operation.ProjectPath); }
                else AddReference(operation.ProjectPath, operation.PackageId, operation.Version ?? "32.1.29");
            }
            return Task.FromResult(new NuGetCommandResult { ExitCode = FailAdd ? 1 : 0, StandardOutput = "version 32.1.29", StandardError = FailAdd ? "simulated restore failure" : "" });
        }
        public void AddReference(string path, string packageId, string version)
        {
            var xml = XDocument.Load(path);
            var reference = xml.Descendants("PackageReference").FirstOrDefault(element => (string?)element.Attribute("Include") == packageId);
            if (reference is null) xml.Root!.Add(new XElement("ItemGroup", new XElement("PackageReference", new XAttribute("Include", packageId), new XAttribute("Version", version))));
            else reference.SetAttributeValue("Version", version);
            xml.Save(path);
        }
    }

    private sealed class FakeDotNet : DotNetRunner
    {
        public bool FailBuild { get; set; }
        public Action? BeforeBuild { get; set; }
        public bool FailRestore { get; set; }
        public List<IReadOnlyList<string>> Calls { get; } = [];
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2]), StandardError = "" });
            Calls.Add(args.ToArray());
            if (args[0] == "build") BeforeBuild?.Invoke();
            var output = args.Any(argument => argument.Contains("-getProperty:TargetFrameworks,TargetFramework"))
                ? JsonSerializer.Serialize(new { Properties = new { TargetFrameworks = "net10.0-android", TargetFramework = "" } })
                : args.Any(argument => argument.Contains("-getProperty:TargetFrameworks"))
                ? JsonSerializer.Serialize(new { Properties = new { TargetFrameworks = "net10.0-android" } })
                : args.Any(argument => argument.Contains("ManagePackageVersionsCentrally"))
                    ? JsonSerializer.Serialize(new { Properties = new { ManagePackageVersionsCentrally = "false", DirectoryPackagesPropsPath = "" } }) : "";
            return Task.FromResult(new ProcessCommandResult { ExitCode = FailBuild && args[0] == "build" || FailRestore && args[0] == "restore" ? 1 : 0, StandardOutput = output, StandardError = "" });
        }
    }
}
