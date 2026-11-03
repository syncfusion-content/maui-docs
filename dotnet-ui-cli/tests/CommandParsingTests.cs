using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;
using System.Text.Json;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Hosting;
using Syncfusion.DotNet.Cli.Maui;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

/// <summary>
/// Tests for Phase 2 command parsing, validation, and request creation.
/// These call each command's pure <c>Parse</c> method (no prompting) so they
/// are deterministic and do not require a terminal.
/// </summary>
[Collection("Console output")]
public static class CommandParsingTests
{
    private static ParseResult ParseRoot(params string[] args)
    {
        var root = new RootCommand();
        root.Add(NewCommand.Create());
        root.Add(AddCommand.Create());
        root.Add(RemoveCommand.Create());
        root.Add(UpdateCommand.Create());
        root.Add(ListCommand.Create());
        root.Add(SearchCommand.Create());
        root.Add(InfoCommand.Create());
        return root.Parse(args);
    }

    [Fact]
    public static void New_WithPositionalFramework_CreatesRequest()
    {
        var pr = ParseRoot("new", "maui", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(Framework.Maui, outcome.Request!.Framework);
        Assert.Equal("MyApp", outcome.Request!.Name);
    }

    [Fact]
    public static void New_WithFrameworkOption_CreatesRequest()
    {
        var pr = ParseRoot("new", "-f", "maui", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(Framework.Maui, outcome.Request!.Framework);
    }

    [Fact]
    public static void New_BothFrameworkForms_ReturnsValidationError()
    {
        var pr = ParseRoot("new", "maui", "-f", "maui", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.False(outcome.IsSuccess);
        Assert.Contains("not both", outcome.Error);
        Assert.Equal(ExitCodes.Error, outcome.ExitCode);
    }

    [Fact]
    public static void New_BlazorFramework_IsAccepted()
    {
        var pr = ParseRoot("new", "blazor", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(Framework.Blazor, outcome.Request!.Framework);
    }

    [Fact]
    public static void New_UnknownFramework_ReturnsValidationError()
    {
        var pr = ParseRoot("new", "xamarin", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.False(outcome.IsSuccess);
        Assert.Contains("Unknown framework", outcome.Error);
    }

    [Fact]
    public static void New_MissingNameNonInteractive_ReturnsValidationError()
    {
        var pr = ParseRoot("new", "maui");
        var outcome = NewCommand.Parse(pr);
        Assert.False(outcome.IsSuccess);
        Assert.Contains("project name", outcome.Error);
    }

    [Theory]
    [InlineData("bad-name")]
    [InlineData("1MyApp")]
    [InlineData("class")]
    [InlineData("My App")]
    [InlineData("My..App")]
    [InlineData("CON")]
    public static void New_InvalidProjectName_ReturnsValidationError(string name)
    {
        var outcome = NewCommand.Parse(ParseRoot("new", "maui", "-n", name));

        Assert.False(outcome.IsSuccess);
        Assert.Contains("project name", outcome.Error, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public static void New_ProjectNameIsTrimmedBeforeValidation()
    {
        var outcome = NewCommand.Parse(ParseRoot("new", "maui", "-n", "  MyApp  "));

        Assert.True(outcome.IsSuccess);
        Assert.Equal("MyApp", outcome.Request!.Name);
    }

    [Fact]
    public static void New_ExplicitEmptyProjectNameReturnsValidationError()
    {
        var outcome = NewCommand.Parse(ParseRoot("new", "maui", "-n", ""));

        Assert.False(outcome.IsSuccess);
        Assert.Contains("project name", outcome.Error, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public static void New_MissingFrameworkNonInteractive_ReturnsValidationError()
    {
        var pr = ParseRoot("new", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.False(outcome.IsSuccess);
        Assert.Contains("framework", outcome.Error);
    }

    [Fact]
    public static void New_DefaultPath_IsCurrentDirectory()
    {
        var pr = ParseRoot("new", "maui", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(System.Environment.CurrentDirectory, outcome.Request!.Path);
    }

    [Fact]
    public static void New_DotPath_NormalizesToCurrentDirectory()
    {
        var pr = ParseRoot("new", "maui", "-n", "MyApp", "-p", ".");
        var outcome = NewCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(System.Environment.CurrentDirectory, outcome.Request!.Path);
    }

    [Fact]
    public static void New_DefaultProjectType_HasNoThemeSelection()
    {
        var pr = ParseRoot("new", "maui", "-n", "MyApp");
        var outcome = NewCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(MauiProjectType.App, outcome.Request!.ProjectType);
        Assert.Null(typeof(NewProjectRequest).GetProperty("Theme"));
    }

    [Theory]
    [InlineData("material")]
    [InlineData("cupertino")]
    [InlineData("neumorphism")]
    public static async Task New_ObsoleteThemeInputReturnsJsonMigrationErrorWithoutCreatingProject(string value)
    {
        var path = Path.Combine(Path.GetTempPath(), "sf-cli-obsolete-option-" + Guid.NewGuid().ToString("N"));
        try
        {
            using var capture = new ConsoleCapture();
            var exitCode = await CliApp.Build().RunAsync(
                ["new", "maui", "-n", "MyApp", "-p", path, "--theme", value, "--json", "--no-interactive"]);

            Assert.Equal(ExitCodes.Error, exitCode);
            using var json = JsonDocument.Parse(capture.Out);
            var root = json.RootElement;
            Assert.False(root.GetProperty("success").GetBoolean());
            Assert.Equal(ExitCodes.Error, root.GetProperty("exitCode").GetInt32());
            Assert.Contains("The --theme option is no longer supported.", root.GetProperty("error").GetString());
            Assert.Contains("native MAUI appearance", root.GetProperty("error").GetString());
            Assert.False(Directory.Exists(path));
        }
        finally
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, recursive: true);
            }
        }
    }

    [Theory]
    [InlineData("badge-view")]
    [InlineData("button")]
    [InlineData("slider")]
    [InlineData("switch")]
    [InlineData("tab-view")]
    public static void New_RejectsUnsupportedLegacyTemplateIds(string templateId)
    {
        var outcome = NewCommand.Parse(ParseRoot("new", "maui", "-n", "MyApp", "--template", templateId));

        Assert.False(outcome.IsSuccess);
        Assert.Equal(TemplateSelection.NotAvailableMessage(templateId), outcome.Error);
    }

    [Theory]
    [InlineData("badge-view")]
    [InlineData("button")]
    [InlineData("slider")]
    [InlineData("switch")]
    [InlineData("tab-view")]
    public static void Add_RejectsUnsupportedLegacyTemplateIds(string templateId)
    {
        var outcome = AddCommand.BuildTemplate(
            ParseRoot("add", "maui", "--template", templateId),
            new GlobalOptions { NoInteractive = true });

        Assert.False(outcome.IsSuccess);
        Assert.Equal(TemplateSelection.NotAvailableMessage(templateId), outcome.Error);
    }

    [Fact]
    public static void New_Defaults_RestoreYes_BuildNo()
    {
        var pr = ParseRoot("new", "maui", "-n", "MyApp", "--no-build");
        var outcome = NewCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.True(outcome.Request!.Restore);
        Assert.False(outcome.Request!.Build);
    }

    [Fact]
    public static void New_RejectsUnknownTemplate()
    {
        var outcome = NewCommand.Parse(ParseRoot("new", "maui", "-n", "MyApp", "--template", "not-a-template"));
        Assert.False(outcome.IsSuccess);
        Assert.Contains("sfdotnet help maui", outcome.Error);
    }

    [Fact]
    public static void New_AcceptsEmptyAsAnExplicitProjectChoice()
    {
        var outcome = NewCommand.Parse(ParseRoot("new", "maui", "-n", "MyApp", "--template", "empty"));
        Assert.True(outcome.IsSuccess);
        Assert.Empty(outcome.Request!.SelectedTemplateIds);
    }

    [Fact]
    public static void New_AcceptsMultipleConcreteTemplates()
    {
        var outcome = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--template", "datagrid", "kanban", "--target-framework", "net10.0"));

        Assert.True(outcome.IsSuccess);
        Assert.Equal(["datagrid", "kanban"], outcome.Request!.SelectedTemplateIds);
    }

    [Fact]
    public static void New_AcceptsOneControlOption()
    {
        var outcome = NewCommand.Parse(ParseRoot("new", "maui", "-n", "MyApp", "--control", "datagrid"));

        Assert.True(outcome.IsSuccess);
        Assert.Equal(["datagrid"], outcome.Request!.SelectedTemplateIds);
    }

    [Fact]
    public static void New_AcceptsOneChartControl()
    {
        var outcome = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--control", "cartesian-chart"));

        Assert.True(outcome.IsSuccess);
        Assert.Equal(["cartesian-chart"], outcome.Request!.SelectedTemplateIds);
    }

    [Fact]
    public static void New_AcceptsMultipleControlValues()
    {
        var outcome = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--control", "datagrid", "kanban"));

        Assert.True(outcome.IsSuccess);
        Assert.Equal(["datagrid", "kanban"], outcome.Request!.SelectedTemplateIds);
    }

    [Fact]
    public static void New_LegacyTemplateOptionCreatesSameRequestAsControlOption()
    {
        var control = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--control", "cartesian-chart", "circular-chart"));
        var legacy = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--template", "cartesian-chart", "circular-chart"));

        Assert.True(control.IsSuccess);
        Assert.True(legacy.IsSuccess);
        Assert.Equal(control.Request!.Framework, legacy.Request!.Framework);
        Assert.Equal(control.Request.Name, legacy.Request.Name);
        Assert.Equal(control.Request.Path, legacy.Request.Path);
        Assert.Equal(control.Request.TargetFramework, legacy.Request.TargetFramework);
        Assert.Equal(control.Request.SelectedTemplateIds, legacy.Request.SelectedTemplateIds);
        Assert.Equal(control.Request.ProjectType, legacy.Request.ProjectType);
    }

    [Fact]
    public static void New_DirectAndInteractiveSelectionsCreateEquivalentRequests()
    {
        var direct = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "-p", ".", "--control", "datagrid", "kanban"));
        Assert.True(direct.IsSuccess);

        var interactive = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "MyApp",
            PathNormalizer.Normalize("."),
            "net10.0",
            MauiProjectType.App,
            ["datagrid", "kanban"],
            restore: true,
            build: true,
            dryRun: false,
            force: false);

        Assert.Equal(direct.Request!.Framework, interactive.Framework);
        Assert.Equal(direct.Request.Name, interactive.Name);
        Assert.Equal(direct.Request.Path, interactive.Path);
        Assert.Equal(direct.Request.TargetFramework, interactive.TargetFramework);
        Assert.Equal(direct.Request.Template, interactive.Template);
        Assert.Equal(direct.Request.SelectedTemplateIds, interactive.SelectedTemplateIds);
        Assert.Equal(direct.Request.ProjectType, interactive.ProjectType);
        Assert.Equal(direct.Request.Restore, interactive.Restore);
        Assert.Equal(direct.Request.Build, interactive.Build);
        Assert.Equal(direct.Request.DryRun, interactive.DryRun);
        Assert.Equal(direct.Request.Force, interactive.Force);
    }

    [Fact]
    public static void New_DirectAndInteractivePostCreationActionNoneAreEquivalent()
    {
        // `--no-build` in the direct path maps to the interactive "None" choice.
        // Selected controls require build validation, so this pair is only valid for empty projects.
        var direct = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--no-build"));
        Assert.True(direct.IsSuccess);
        Assert.False(direct.Request!.Build);

        var interactive = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "MyApp",
            PathNormalizer.Normalize(null),
            "net10.0",
            MauiProjectType.App,
            [],
            restore: false,
            build: false,
            dryRun: false,
            force: false);

        Assert.Equal(direct.Request.Build, interactive.Build);
        Assert.Equal(direct.Request.SelectedTemplateIds, interactive.SelectedTemplateIds);
    }

    [Fact]
    public static void New_DirectAndInteractivePostCreationActionBuildAreEquivalent()
    {
        var direct = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--control", "datagrid"));
        Assert.True(direct.IsSuccess);
        Assert.True(direct.Request!.Build);

        var interactive = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "MyApp",
            PathNormalizer.Normalize(null),
            "net10.0",
            MauiProjectType.App,
            ["datagrid"],
            restore: true,
            build: true,
            dryRun: false,
            force: false);

        Assert.Equal(direct.Request.Build, interactive.Build);
        Assert.Equal(direct.Request.SelectedTemplateIds, interactive.SelectedTemplateIds);
    }

    [Fact]
    public static void New_TargetFrameworkOptionFlowsThroughToTheRequest()
    {
        var outcome = NewCommand.Parse(ParseRoot(
            "new", "maui", "-n", "MyApp", "--target-framework", "net10.0"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal("net10.0", outcome.Request!.TargetFramework);
    }

    [Fact]
    public static void New_DestinationResolvesToParentAndNameWithoutNesting()
    {
        // The scaffolder must place the project at <parent>/<name>, never <parent>/<name>/<name>.
        var root = Path.Combine(Path.GetTempPath(), "sf-nest-" + Guid.NewGuid().ToString("N"));
        try
        {
            Directory.CreateDirectory(root);
            var outcome = NewCommand.Parse(ParseRoot(
                "new", "maui", "-n", "MyApp", "-p", root));
            Assert.True(outcome.IsSuccess);
            var expected = Path.GetFullPath(Path.Combine(root, "MyApp"));
            Assert.Equal(expected, Path.GetFullPath(Path.Combine(outcome.Request!.Path, outcome.Request.Name)));
            Assert.DoesNotContain(
                Path.Combine(outcome.Request.Path, outcome.Request.Name, outcome.Request.Name),
                Path.GetFullPath(Path.Combine(outcome.Request.Path, outcome.Request.Name)));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void Add_PositionalFramework_CreatesRequest()
    {
        var pr = ParseRoot("add", "datagrid", "maui");
        var outcome = AddCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.PackageAliasOrId);
        Assert.Equal(Framework.Maui, outcome.Request!.Framework);
    }

    [Fact]
    public static void Add_PrimarySyntax_ResolvesCanonicalPackageAlias()
    {
        var outcome = AddCommand.Parse(ParseRoot("add", "maui", "charts"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal("charts", outcome.Request!.PackageAliasOrId);
    }

    [Fact]
    public static void Add_FullPackageId_ResolvesToCanonicalAlias()
    {
        var outcome = AddCommand.Parse(ParseRoot("add", "maui", "Syncfusion.Maui.DataGrid"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.PackageAliasOrId);
    }

    [Fact]
    public static void Add_CorePackage_IsSupportedWithoutTemplate()
    {
        var outcome = AddCommand.Parse(ParseRoot("add", "maui", "core"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal("core", outcome.Request!.PackageAliasOrId);
    }

    [Fact]
    public static void Add_TemplateOption_IsDistinctFromPackageAdd()
    {
        var outcome = AddCommand.BuildTemplate(ParseRoot("add", "maui", "--template", "datagrid"), new GlobalOptions { NoInteractive = true });
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.TemplateId);
    }

    [Fact]
    public static void Add_LegacyChartsTemplateAlias_ResolvesToConcreteCartesianChartTemplate()
    {
        var outcome = AddCommand.BuildTemplate(
            ParseRoot("add", "maui", "--template", "charts"),
            new GlobalOptions { NoInteractive = true });
        Assert.True(outcome.IsSuccess);
        Assert.Equal("cartesian-chart", outcome.Request!.TemplateId);
    }

    [Fact]
    public static void Add_NormalizesAliasesBeforeRejectingDuplicates()
    {
        var outcome = AddCommand.BuildTemplate(
            ParseRoot("add", "maui", "--template", "charts", "cartesian-chart"),
            new GlobalOptions { NoInteractive = true });

        Assert.False(outcome.IsSuccess);
        Assert.Contains("duplicates canonical control 'cartesian-chart'", outcome.Error);
    }

    [Fact]
    public static void Add_RejectsPackageAndTemplateTogether()
    {
        var outcome = AddCommand.Parse(ParseRoot("add", "maui", "datagrid", "--template", "charts"));
        Assert.False(outcome.IsSuccess);
        Assert.Contains("cannot be combined with a control selection", outcome.Error);
    }

    [Fact]
    public static void Add_RejectsPreviewTemplate()
    {
        var outcome = AddCommand.BuildTemplate(ParseRoot("add", "maui", "--template", "not-a-template"), new GlobalOptions { NoInteractive = true });
        Assert.False(outcome.IsSuccess);
        Assert.Contains("sfdotnet help maui", outcome.Error);
    }

    [Fact]
    public static void List_LegacyAndExplicitTemplateFormsUseSameCategory()
    {
        var legacy = ListCommand.Parse(ParseRoot("list", "maui", "templates"));
        var explicitTemplate = ListCommand.Parse(ParseRoot("list", "maui", "--template"));

        Assert.True(legacy.IsSuccess);
        Assert.True(explicitTemplate.IsSuccess);
        Assert.Equal(ListCategory.Templates, legacy.Request!.Category);
        Assert.Equal(legacy.Request.Category, explicitTemplate.Request!.Category);
    }

    [Fact]
    public static void List_InstalledTemplatesRequiresExplicitTemplateMode()
    {
        var outcome = ListCommand.Parse(ParseRoot("list", "maui", "--installed"));

        Assert.False(outcome.IsSuccess);
        Assert.Contains("installed listing option", outcome.Error);
    }

    [Fact]
    public static void Add_WithVersion_CreatesRequest()
    {
        var pr = ParseRoot("add", "datagrid", "maui", "-v", "32.1.29");
        var outcome = AddCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal("32.1.29", outcome.Request!.Version);
    }

    [Fact]
    public static void Add_BothFrameworkForms_ReturnsValidationError()
    {
        var pr = ParseRoot("add", "datagrid", "maui", "-f", "maui");
        var outcome = AddCommand.Parse(pr);
        Assert.False(outcome.IsSuccess);
        Assert.Contains("not both", outcome.Error);
    }

    [Fact]
    public static void Remove_CreatesRequest()
    {
        var pr = ParseRoot("remove", "datagrid", "maui");
        var outcome = RemoveCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.PackageAliasOrId);
    }

    [Fact]
    public static void Remove_PrimarySyntax_CreatesPackageRequest()
    {
        var outcome = RemoveCommand.Parse(ParseRoot("remove", "maui", "datagrid"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.PackageAliasOrId);
    }

    [Fact]
    public static void Remove_TemplateRequiresLongOption()
    {
        var outcome = RemoveCommand.BuildTemplate(ParseRoot("remove", "maui", "--template", "datagrid"), new GlobalOptions { NoInteractive = true });
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.TemplateId);
    }

    [Fact]
    public static void Update_CreatesRequest()
    {
        var pr = ParseRoot("update", "datagrid", "maui", "-v", "32.2.0");
        var outcome = UpdateCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal("32.2.0", outcome.Request!.Version);
    }

    [Fact]
    public static void Update_PrimarySyntax_CreatesPackageRequest()
    {
        var outcome = UpdateCommand.Parse(ParseRoot("update", "maui", "datagrid"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.PackageAliasOrId);
    }

    [Fact]
    public static void List_ValidCategory_CreatesRequest()
    {
        var pr = ParseRoot("list", "templates", "maui");
        var outcome = ListCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(ListCategory.Templates, outcome.Request!.Category);
    }

    [Fact]
    public static void List_PrimarySyntax_CreatesRequest()
    {
        var outcome = ListCommand.Parse(ParseRoot("list", "maui", "packages"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal(ListCategory.Packages, outcome.Request!.Category);
        Assert.Equal(Framework.Maui, outcome.Request.Framework);
    }

    [Fact]
    public static void List_InvalidCategory_ReturnsValidationError()
    {
        var pr = ParseRoot("list", "widgets", "maui");
        var outcome = ListCommand.Parse(pr);
        Assert.False(outcome.IsSuccess);
        Assert.Contains("Unknown list category", outcome.Error);
    }

    [Fact]
    public static void Search_CreatesRequest()
    {
        var pr = ParseRoot("search", "grid", "maui");
        var outcome = SearchCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal("grid", outcome.Request!.Text);
        Assert.Equal(Framework.Maui, outcome.Request!.Framework);
    }

    [Fact]
    public static void Search_PrimarySyntax_CreatesRequest()
    {
        var outcome = SearchCommand.Parse(ParseRoot("search", "maui", "datagrid"));
        Assert.True(outcome.IsSuccess);
        Assert.Equal("datagrid", outcome.Request!.Text);
    }

    [Fact]
    public static void BlazorFramework_IsAcceptedForPackageCommands()
    {
        var pr = ParseRoot("add", "datagrid", "blazor");
        var outcome = AddCommand.Parse(pr);
        Assert.True(outcome.IsSuccess);
        Assert.Equal(Framework.Blazor, outcome.Request!.Framework);
    }
}
