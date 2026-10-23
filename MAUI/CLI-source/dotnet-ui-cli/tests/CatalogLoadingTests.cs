using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>Checks catalog contents, resource names, and template files.</summary>
public static class CatalogLoadingTests
{
    [Fact]
    public static void TemplateCatalog_LoadsApprovedConcreteTemplates()
    {
        var expectedIds = new[] { "assistview", "cartesian-chart", "circular-chart", "datagrid", "diagram", "kanban", "listview", "pdf-viewer", "rich-text-editor", "scheduler" };

        Assert.Equal(expectedIds.Length, TemplateCatalog.Operable.Count);
        Assert.Equal(expectedIds.Length, TemplateCatalog.All.Count);
        Assert.Equal(expectedIds, TemplateCatalog.Operable.Select(template => template.Id).Order(StringComparer.Ordinal));
        Assert.All(TemplateCatalog.Operable, template =>
        {
            Assert.True(template.Verified);
            Assert.True(template.Available);
            Assert.True(template.Operable);
        });
    }

    [Fact]
    public static void EveryOperableTemplate_HasEmbeddedResourcesAndMatchingXamlIdentity()
    {
        foreach (var template in TemplateCatalog.Operable)
        {
            Assert.True(PackageCatalog.TryResolve(template.PackageId, out var package));
            Assert.Equal(template.PackageId, package.PackageId);
            Assert.Contains(template.Family, _expectedFamilies, StringComparer.OrdinalIgnoreCase);
            Assert.True(template.RegistrationVerified);
            Assert.Contains(template.RegistrationRequirement, new[] { "none", "syncfusion-core" });

            var values = PlaceholderReplacer.BuildValues(
                "Example.App",
                "Example.App",
                template.ControlName);
            var renderedByDestination = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var generatedFile in template.GeneratedFiles)
            {
                TemplatePathResolver.ValidateRelativePath(generatedFile.Destination);
                TemplatePathResolver.ValidateRelativePath(generatedFile.TemplateResource);
                var resourceName = TemplatePathResolver.ResolveResourceName(template.TemplatePath, generatedFile.TemplateResource);
                var content = PlaceholderReplacer.Replace(EmbeddedResourceLoader.ReadText(resourceName), values);
                Assert.DoesNotContain(PlaceholderReplacer.Tokens, token => content.Contains(token, StringComparison.Ordinal));
                Assert.True(renderedByDestination.TryAdd(generatedFile.Destination, content));
            }

            foreach (var xamlFile in template.GeneratedFiles.Where(file => file.Destination.EndsWith(".xaml", StringComparison.OrdinalIgnoreCase)))
            {
                var xaml = XDocument.Parse(renderedByDestination[xamlFile.Destination]);
                var xClass = xaml.Root?.Attribute(XName.Get("Class", "http://schemas.microsoft.com/winfx/2009/xaml"))?.Value;
                Assert.NotNull(xClass);
                Assert.True(renderedByDestination.TryGetValue(xamlFile.Destination + ".cs", out var codeBehind));
                var namespaceMatch = Regex.Match(codeBehind!, @"\bnamespace\s+([\p{L}_][\p{L}\p{N}_.]*)", RegexOptions.CultureInvariant);
                var classMatch = Regex.Match(codeBehind!, @"\bpartial\s+class\s+([\p{L}_][\p{L}\p{N}_]*)", RegexOptions.CultureInvariant);
                Assert.True(namespaceMatch.Success && classMatch.Success);
                Assert.Equal($"{namespaceMatch.Groups[1].Value}.{classMatch.Groups[1].Value}", xClass);
            }
        }
    }

    [Fact]
    public static void VersionSensitiveTemplates_UseDocumentedDataBindingProperties()
    {
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("datagrid", out var dataGrid));
        var dataGridXaml = ReadTemplateResource(dataGrid, "DataGridView.xaml");
        Assert.Contains("AutoGenerateColumnsMode=\"None\"", dataGridXaml, StringComparison.Ordinal);
        Assert.DoesNotContain("AutoGenerateColumns=", dataGridXaml, StringComparison.Ordinal);

        Assert.True(TemplateCatalog.TryResolveOperableTemplate("scheduler", out var scheduler));
        var schedulerXaml = ReadTemplateResource(scheduler, "SchedulerView.xaml");
        Assert.Contains("SchedulerAppointmentMapping", schedulerXaml, StringComparison.Ordinal);
        Assert.Contains("AppointmentsSource=\"{Binding Appointments}\"", schedulerXaml, StringComparison.Ordinal);

        Assert.True(TemplateCatalog.TryResolveOperableTemplate("pdf-viewer", out var pdf));
        var pdfXaml = ReadTemplateResource(pdf, "PdfViewerPage.xaml");
        Assert.Contains("DocumentSource=\"{Binding DocumentStream}\"", pdfXaml, StringComparison.Ordinal);

        Assert.True(TemplateCatalog.TryResolveOperableTemplate("assistview", out var assistView));
        var assistViewXaml = ReadTemplateResource(assistView, "AIAssistViewPage.xaml");
        var assistViewModel = ReadTemplateResource(assistView, "AIAssistViewViewModel.cs");
        Assert.Contains("AssistItems=\"{Binding AssistItems}\"", assistViewXaml, StringComparison.Ordinal);
        Assert.Contains("ObservableCollection<IAssistItem>", assistViewModel, StringComparison.Ordinal);

        Assert.True(TemplateCatalog.TryResolveOperableTemplate("rich-text-editor", out var richTextEditor));
        var richTextEditorXaml = ReadTemplateResource(richTextEditor, "RichTextEditorView.xaml");
        Assert.Contains("Value=\"{Binding HtmlText, Mode=TwoWay}\"", richTextEditorXaml, StringComparison.Ordinal);
        Assert.DoesNotContain("HtmlText=\"{Binding", richTextEditorXaml, StringComparison.Ordinal);
    }

    private static string ReadTemplateResource(ControlCatalogEntry template, string resource)
        => EmbeddedResourceLoader.ReadText(
            TemplatePathResolver.ResolveResourceName(template.TemplatePath, resource));

    private static readonly string[] _expectedFamilies = ["assistview", "charts", "datagrid", "diagram", "kanban", "listview", "pdf-viewer", "rich-text-editor", "scheduler"];

    [Fact]
    public static void TemplateCatalog_IncludesConcreteChartTemplateAndLegacyAlias()
    {
        Assert.Contains(TemplateCatalog.All, template => template.Id == "cartesian-chart");
        Assert.DoesNotContain(TemplateCatalog.All, template => template.Id == "charts");
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("charts", out var template));
        Assert.Equal("cartesian-chart", template.Id);
        Assert.Contains(TemplateCatalog.Operable, item => item.Id == "circular-chart");
    }

    [Fact]
    public static void TryResolve_KnownTemplate_ReturnsControlIdentityAndPackage()
    {
        Assert.True(TemplateCatalog.TryResolve("datagrid", out var template));
        Assert.Equal("SfDataGrid", template.ControlType);
        Assert.Equal("Syncfusion.Maui.DataGrid", template.PackageId);
        Assert.Equal("Syncfusion.Maui.DataGrid.SfDataGrid", template.ControlIdentity);
    }

    [Fact]
    public static void TryResolve_IsCaseInsensitiveAndAcceptsLegacyTemplateAlias()
    {
        Assert.True(TemplateCatalog.TryResolve("DataGrid", out var dataGrid));
        Assert.Equal("datagrid", dataGrid.Id);
        Assert.True(TemplateCatalog.TryResolve("sfdatagrid", out var legacyAlias));
        Assert.Equal("datagrid", legacyAlias.Id);
    }

    [Fact]
    public static void TryResolve_RejectsUnknownOrEmptyTemplateIds()
    {
        Assert.False(TemplateCatalog.TryResolve("not-a-template", out _));
        Assert.False(TemplateCatalog.TryResolve(null, out _));
        Assert.False(TemplateCatalog.TryResolve("", out _));
        Assert.False(TemplateCatalog.TryResolve("   ", out _));
    }

    [Fact]
    public static void EveryTemplate_HasRequiredMetadataAndResourceReferences()
    {
        foreach (var template in TemplateCatalog.All)
        {
            Assert.False(string.IsNullOrWhiteSpace(template.Id));
            Assert.False(string.IsNullOrWhiteSpace(template.Family));
            Assert.False(string.IsNullOrWhiteSpace(template.ControlIdentity));
            Assert.False(string.IsNullOrWhiteSpace(template.DisplayName));
            Assert.False(string.IsNullOrWhiteSpace(template.PackageId));
            Assert.False(string.IsNullOrWhiteSpace(template.DocumentationUrl));
            Assert.NotEmpty(template.EmbeddedResources);
            Assert.Equal(template.EmbeddedResources.Order(StringComparer.Ordinal), template.GeneratedFiles.Select(file => file.TemplateResource).Order(StringComparer.Ordinal));
        }
    }

    [Fact]
    public static void EveryTemplate_UsesItsDeclaredVerifiedRegistration()
    {
        Assert.All(TemplateCatalog.All, template =>
        {
            Assert.True(template.RegistrationVerified);
            if (template.RegistrationRequirement == "none")
            {
                Assert.Empty(template.RegistrationUsing);
                Assert.Empty(template.RegistrationCall);
            }
            else
            {
                Assert.Equal("syncfusion-core", template.RegistrationRequirement);
                Assert.Equal("Syncfusion.Maui.Core.Hosting", template.RegistrationUsing);
                Assert.Equal("builder.ConfigureSyncfusionCore();", template.RegistrationCall);
            }
        });
    }

    [Fact]
    public static void InputsPackageRemainsAvailableWithoutAnInteractiveControlTemplate()
    {
        Assert.True(PackageCatalog.TryResolve("inputs", out var package));
        Assert.Equal("Syncfusion.Maui.Inputs", package.PackageId);
        Assert.False(TemplateCatalog.TryResolveOperableTemplate("combobox", out _));
    }

    [Fact]
    public static void DataGridTemplate_ReferencesExistingGeneratedFiles()
    {
        Assert.True(TemplateCatalog.TryResolve("datagrid", out var template));
        var destinations = template.GeneratedFiles.Select(file => file.Destination).ToHashSet();
        Assert.Contains("DataGrid/DataGridView.xaml", destinations);
        Assert.Contains("DataGrid/DataGridView.xaml.cs", destinations);
        Assert.Contains("DataGrid/DataGridViewModel.cs", destinations);
        Assert.Contains("DataGrid/DataGridModel.cs", destinations);
        Assert.Contains("DataGrid/README.md", destinations);
    }

    [Fact]
    public static void TemplateCatalogJson_CanBeParsedDirectly()
    {
        var json = """
        {
          "schemaVersion": 1,
          "templates": [
            {
              "id": "datagrid",
              "family": "datagrid",
              "controlIdentity": "Syncfusion.Maui.DataGrid.SfDataGrid",
              "available": true,
              "verified": true,
              "operable": true,
              "legacyAliases": ["datagrid"],
              "embeddedResources": ["README.md"],
              "displayName": "DataGrid",
              "description": "Grid",
              "packageId": "Syncfusion.Maui.DataGrid",
              "dependentPackageIds": [],
              "documentationUrl": "https://help.syncfusion.com/maui/datagrid/getting-started",
              "xamlNamespace": "clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid",
              "xamlPrefix": "syncfusion",
              "controlType": "SfDataGrid",
              "csharpNamespace": "Syncfusion.Maui.DataGrid",
              "registrationUsing": "Syncfusion.Maui.Core.Hosting",
              "registrationCall": "builder.ConfigureSyncfusionCore();",
              "supportedProjectTypes": ["app"],
              "templatePath": "Templates/Controls/DataGrid",
              "generatedFiles": [
                { "destination": "DataGrid/README.md", "templateResource": "README.md" }
              ]
            }
          ]
        }
        """;
        using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
        var templates = CatalogLoader.Parse(stream);
        Assert.Single(templates);
        Assert.Equal("datagrid", templates[0].Id);
        Assert.Equal("SfDataGrid", templates[0].ControlType);
    }
}
