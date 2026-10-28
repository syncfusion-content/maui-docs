using System.IO;
using System.Linq;
using System.Text.Json;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Hosting;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Maui.Manifest;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>Checks compatibility behavior when removing old template records.</summary>
[Collection("Console output")]
public static class UnsupportedTemplateCleanupTests
{
    [Fact]
    public static void TemplateCatalog_ContainsOnlyApprovedFamiliesAndConcreteTemplates()
    {
        var expectedFamilies = new[] { "assistview", "charts", "datagrid", "diagram", "kanban", "listview", "pdf-viewer", "rich-text-editor", "scheduler" };

        Assert.Equal(10, TemplateCatalog.Operable.Count);
        Assert.Equal(expectedFamilies, TemplateCatalog.Operable
            .Select(template => template.Family)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .Order(StringComparer.OrdinalIgnoreCase));
        Assert.Equal(2, TemplateCatalog.Operable.Count(template =>
            template.Family.Equals("charts", StringComparison.OrdinalIgnoreCase)));
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("charts", out var cartesianChart));
        Assert.Equal("cartesian-chart", cartesianChart.Id);
    }

    [Theory]
    [InlineData("badge-view")]
    [InlineData("button")]
    [InlineData("slider")]
    [InlineData("switch")]
    [InlineData("tab-view")]
    public static void UnsupportedTemplateIds_AreSeparateFromAvailableCatalog(string templateId)
    {
        Assert.DoesNotContain(TemplateCatalog.All, template =>
            template.Id.Equals(templateId, StringComparison.OrdinalIgnoreCase));
        Assert.True(LegacyUnsupportedTemplateCatalog.Contains(templateId));
        Assert.False(TemplateSelection.TryNormalize(
            [templateId],
            allowEmpty: false,
            "sf add maui --template <template-id>",
            out _,
            out var error));
        Assert.Equal(TemplateSelection.NotAvailableMessage(templateId), error);
        Assert.DoesNotContain(DiscoveryService.ListTemplates(), template =>
            template.TemplateId.Equals(templateId, StringComparison.OrdinalIgnoreCase));
    }

    [Fact]
    public static void RemovedTemplatesDoNotRemoveTheirAvailablePackageOperations()
    {
        Assert.True(PackageCatalog.TryResolve("buttons", out var buttons));
        Assert.Equal("Syncfusion.Maui.Buttons", buttons.PackageId);
        Assert.True(PackageCatalog.TryResolve("sliders", out var sliders));
        Assert.Equal("Syncfusion.Maui.Sliders", sliders.PackageId);
        Assert.True(PackageCatalog.TryResolve("tabview", out var tabView));
        Assert.Equal("Syncfusion.Maui.TabView", tabView.PackageId);
    }

    [Fact]
    public static void EmbeddedResources_ContainNoRemovedTemplateOrThemeFolders()
    {
        var resources = typeof(DiscoveryService).Assembly.GetManifestResourceNames();

        Assert.DoesNotContain(resources, resource =>
            resource.Contains(".Templates.Controls.BadgeView.", StringComparison.Ordinal)
            || resource.Contains(".Templates.Controls.Button.", StringComparison.Ordinal)
            || resource.Contains(".Templates.Controls.Slider.", StringComparison.Ordinal)
            || resource.Contains(".Templates.Controls.Switch.", StringComparison.Ordinal)
            || resource.Contains(".Templates.Controls.TabView.", StringComparison.Ordinal)
            || resource.Contains(".Themes.", StringComparison.Ordinal));
    }

    [Fact]
    public static async Task InstalledTemplateListing_RetainsLegacyUnsupportedManifestRecords()
    {
        var root = CreateMauiProject();
        try
        {
            var manifestDirectory = Path.Combine(root, "Syncfusion");
            Directory.CreateDirectory(manifestDirectory);
            File.WriteAllText(Path.Combine(manifestDirectory, "syncfusion.json"), new SyncfusionManifest
            {
                InstalledTemplates = [CreateLegacyRecord("badge-view", [])],
            }.ToJson());

            using var capture = new ConsoleCapture();
            var exitCode = await CliApp.Build().RunAsync(
                ["list", "maui", "--template", "--installed", "--path", root, "--json", "--no-interactive"]);

            Assert.Equal(ExitCodes.Success, exitCode);
            using var json = JsonDocument.Parse(capture.Out);
            var record = Assert.Single(json.RootElement.EnumerateArray().ToArray());
            Assert.Equal("badge-view", record.GetProperty("templateId").GetString());
            Assert.Equal("unsupported legacy template", record.GetProperty("templateStatus").GetString());
            Assert.False(record.GetProperty("available").GetBoolean());
            Assert.True(LegacyUnsupportedTemplateCatalog.TryResolve("badge-view", out var displayName));
            Assert.Equal("BadgeView", displayName);
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public static void LegacyRemoval_DeletesOnlyTrackedFilesAndPreservesPackageRegistrationAndUserFiles()
    {
        var root = CreateMauiProject();
        try
        {
            const string ownedPath = "Syncfusion/Controls/BadgeView/Views/BadgeViewView.xaml";
            var ownedFile = Path.Combine(root, ownedPath.Replace('/', Path.DirectorySeparatorChar));
            Directory.CreateDirectory(Path.GetDirectoryName(ownedFile)!);
            File.WriteAllText(ownedFile, "CLI-owned view");
            var userFile = Path.Combine(root, "Syncfusion", "Controls", "BadgeView", "UserNotes.txt");
            File.WriteAllText(userFile, "user-owned");

            var manifest = CreateOwnershipManifest("badge-view", ownedPath, FileRollback.ComputeHash(ownedFile)!);
            var manifestPath = Path.Combine(root, "Syncfusion", "syncfusion.json");
            Directory.CreateDirectory(Path.GetDirectoryName(manifestPath)!);
            var oldJson = manifest.ToJson().Replace(
                "\"schemaVersion\": 1,",
                "\"schemaVersion\": 1,\n  \"theme\": \"cupertino\",",
                StringComparison.Ordinal);
            File.WriteAllText(manifestPath, oldJson);

            var result = new LegacyTemplateRemovalService(CreateProjectInfo(root))
                .ExecuteRemove(["badge-view"]);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.False(File.Exists(ownedFile));
            Assert.Equal("user-owned", File.ReadAllText(userFile));
            var updatedManifestJson = File.ReadAllText(manifestPath);
            Assert.DoesNotContain("\"theme\"", updatedManifestJson, StringComparison.Ordinal);
            var updatedManifest = SyncfusionManifest.FromJson(updatedManifestJson);
            Assert.Empty(updatedManifest.InstalledTemplates);
            Assert.Empty(updatedManifest.InstalledControls);
            Assert.Contains("Syncfusion.Maui.BadgeView", updatedManifest.PackageIds);
            Assert.True(updatedManifest.RegistrationOwned);
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public static void LegacyRemoval_WithIncompleteOwnershipPreservesFilesAndManifestRecord()
    {
        var root = CreateMauiProject();
        try
        {
            const string ownedPath = "Syncfusion/Controls/Slider/Views/SliderView.xaml";
            var ownedFile = Path.Combine(root, ownedPath.Replace('/', Path.DirectorySeparatorChar));
            Directory.CreateDirectory(Path.GetDirectoryName(ownedFile)!);
            File.WriteAllText(ownedFile, "must be preserved");
            var manifestPath = Path.Combine(root, "Syncfusion", "syncfusion.json");
            Directory.CreateDirectory(Path.GetDirectoryName(manifestPath)!);
            File.WriteAllText(manifestPath, CreateOwnershipManifest("slider", ownedPath, null).ToJson());

            var result = new LegacyTemplateRemovalService(CreateProjectInfo(root))
                .ExecuteRemove(["slider"]);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("no valid recorded ownership hash", result.Message);
            Assert.Contains("Next action:", result.Message);
            Assert.Equal("must be preserved", File.ReadAllText(ownedFile));
            Assert.Equal("slider", Assert.Single(
                SyncfusionManifest.FromJson(File.ReadAllText(manifestPath)).InstalledTemplates).Id);
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    private static SyncfusionManifest CreateOwnershipManifest(string id, string relativePath, string? hash)
    {
        var manifest = new SyncfusionManifest
        {
            InstalledControls = [id],
            InstalledTemplates = [CreateLegacyRecord(id, [relativePath])],
            PackageIds = ["Syncfusion.Maui." + (id == "badge-view" ? "BadgeView" : "Sliders")],
            RegistrationOwned = true,
            GeneratedFiles = [relativePath],
        };
        if (hash is not null)
        {
            manifest.OriginalHashes[relativePath] = hash;
        }

        return manifest;
    }

    private static InstalledTemplateRecord CreateLegacyRecord(string id, IReadOnlyList<string> files)
        => new()
        {
            Id = id,
            Family = id,
            PackageId = "Syncfusion.Maui." + (id == "badge-view" ? "BadgeView" : "Sliders"),
            ResolvedVersion = "32.1.29",
            GeneratedFiles = files.ToList(),
            RegistrationApplied = true,
            PackageReferenceOwned = true,
            TargetFrameworks = ["net10.0-android"],
            CompatibilityDecision = "legacy record",
        };

    private static string CreateMauiProject()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-cli-legacy-tests-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        File.WriteAllText(
            Path.Combine(root, "LegacyApp.csproj"),
            "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");
        return root;
    }

    private static ProjectDetector.ProjectInfo CreateProjectInfo(string root)
        => new()
        {
            CsprojPath = Path.Combine(root, "LegacyApp.csproj"),
            Sdk = "Microsoft.NET.Maui.Sdk",
            TargetFrameworks = ["net10.0"],
        };
}
