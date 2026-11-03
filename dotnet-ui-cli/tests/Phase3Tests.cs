using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Manifest;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

/// <summary>
/// Tests for Phase 3 embedded-resource loading: the resource loader finds
/// embedded template resources by their manifest resource name.
/// </summary>
public static class EmbeddedResourceLoadingTests
{
    [Fact]
    public static void ReadText_LoadsDataGridViewTemplate()
    {
        var name = TemplatePathResolver.ResolveResourceName(
            "Templates/Controls/DataGrid", "DataGridView.xaml");
        var content = EmbeddedResourceLoader.ReadText(name);
        Assert.Contains("SfDataGrid", content);
        Assert.Contains("__ROOT_NAMESPACE__", content);
        Assert.Contains("__VIEW_NAME__", content);
    }

    [Fact]
    public static void ReadText_LoadsAllPrimaryControlViewTemplates()
    {
        foreach (var entry in ControlCatalog.Primary)
        {
            var view = entry.GeneratedFiles.First(f => f.Destination.EndsWith(".xaml") && !f.Destination.EndsWith(".xaml.cs"));
            var name = TemplatePathResolver.ResolveResourceName(entry.TemplatePath, view.TemplateResource);
            var content = EmbeddedResourceLoader.ReadText(name);
            Assert.Contains(entry.ControlType, content);
        }
    }

    [Fact]
    public static void ReadText_LoadsAdditionalControlViewTemplates()
    {
        // Additional (preview) controls still ship their embedded view templates
        // so the interactive "Others" list can describe and preview them.
        foreach (var entry in ControlCatalog.Additional)
        {
            var view = entry.GeneratedFiles.First(f => f.Destination.EndsWith(".xaml") && !f.Destination.EndsWith(".xaml.cs"));
            var name = TemplatePathResolver.ResolveResourceName(entry.TemplatePath, view.TemplateResource);
            var content = EmbeddedResourceLoader.ReadText(name);
            Assert.Contains(entry.ControlType, content);
        }
    }

    [Fact]
    public static void Open_UnknownResource_ThrowsFileNotFoundException()
    {
        Assert.Throws<FileNotFoundException>(() => EmbeddedResourceLoader.Open("Does.Not.Exist.txt"));
    }

    [Fact]
    public static void Open_EmptyName_ThrowsArgumentException()
    {
        Assert.Throws<System.ArgumentException>(() => EmbeddedResourceLoader.Open(""));
    }
}

/// <summary>
/// Tests for Phase 3 placeholder replacement. Only the five supported
/// placeholders are substituted; unknown tokens are left untouched.
/// </summary>
public static class PlaceholderReplacementTests
{
    [Fact]
    public static void Replace_AllFiveTokens()
    {
        var input = "__PROJECT_NAME__ __ROOT_NAMESPACE__ __CONTROL_NAME__ __VIEW_NAME__ __VIEW_MODEL_NAME__";
        var values = PlaceholderReplacer.BuildValues("MyApp", "MyApp", "DataGrid");
        var result = PlaceholderReplacer.Replace(input, values);
        Assert.Equal("MyApp MyApp DataGrid DataGridView DataGridViewModel", result);
    }

    [Fact]
    public static void Replace_RepeatedOccurrences()
    {
        var input = "ns __ROOT_NAMESPACE__.Syncfusion.Controls.__CONTROL_NAME__; cls __VIEW_NAME__ : __VIEW_NAME__";
        var values = PlaceholderReplacer.BuildValues("MyApp", "MyApp", "ListView");
        var result = PlaceholderReplacer.Replace(input, values);
        Assert.Equal("ns MyApp.Syncfusion.Controls.ListView; cls ListViewView : ListViewView", result);
    }

    [Fact]
    public static void Replace_UnknownTokensLeftUntouched()
    {
        var input = "__UNKNOWN__ __PROJECT_NAME__";
        var values = PlaceholderReplacer.BuildValues("MyApp", "MyApp", "DataGrid");
        var result = PlaceholderReplacer.Replace(input, values);
        Assert.Equal("__UNKNOWN__ MyApp", result);
    }

    [Fact]
    public static void Replace_EmptyInput_ReturnsEmpty()
    {
        Assert.Equal("", PlaceholderReplacer.Replace("", PlaceholderReplacer.BuildValues("a", "a", "b")));
        Assert.Null(PlaceholderReplacer.Replace(null!, PlaceholderReplacer.BuildValues("a", "a", "b")));
    }

    [Fact]
    public static void Replace_MissingValue_LeavesTokenUntouched()
    {
        var values = new Dictionary<string, string> { ["__PROJECT_NAME__"] = "MyApp" };
        var result = PlaceholderReplacer.Replace("__PROJECT_NAME__ __ROOT_NAMESPACE__", values);
        Assert.Equal("MyApp __ROOT_NAMESPACE__", result);
    }

    [Fact]
    public static void Tokens_AreTheFixedSet()
    {
        Assert.Equal(5, PlaceholderReplacer.Tokens.Count);
        Assert.Contains("__PROJECT_NAME__", PlaceholderReplacer.Tokens);
        Assert.Contains("__ROOT_NAMESPACE__", PlaceholderReplacer.Tokens);
        Assert.Contains("__CONTROL_NAME__", PlaceholderReplacer.Tokens);
        Assert.Contains("__VIEW_NAME__", PlaceholderReplacer.Tokens);
        Assert.Contains("__VIEW_MODEL_NAME__", PlaceholderReplacer.Tokens);
    }
}

/// <summary>
/// Tests for Phase 3 manifest serialization. The manifest round-trips through
/// JSON with all required properties intact.
/// </summary>
public static class ManifestSerializationTests
{
    [Fact]
    public static void Manifest_RoundTripsThroughJson()
    {
        var manifest = new SyncfusionManifest
        {
            SchemaVersion = 1,
            CliVersion = "0.1.0-preview.1",
            Framework = "maui",
            ProjectType = "app",
            TargetFramework = "net10.0",
            InstalledControls = ["datagrid", "charts"],
            PackageIds = ["Syncfusion.Maui.DataGrid", "Syncfusion.Maui.Charts"],
            PackageVersions = new() { ["Syncfusion.Maui.DataGrid"] = "32.1.29" },
            GeneratedFiles = ["DataGrid/DataGridView.xaml"],
            ModifiedFiles = ["MauiProgram.cs"],
            OriginalHashes = new() { ["DataGrid/README.md"] = "abc123" },
        };

        var json = manifest.ToJson();
        var roundTripped = SyncfusionManifest.FromJson(json);

        Assert.Equal(1, roundTripped.SchemaVersion);
        Assert.Equal("0.1.0-preview.1", roundTripped.CliVersion);
        Assert.Equal("maui", roundTripped.Framework);
        Assert.Equal("app", roundTripped.ProjectType);
        Assert.Equal("net10.0", roundTripped.TargetFramework);
        Assert.Equal(["datagrid", "charts"], roundTripped.InstalledControls);
        Assert.Equal("32.1.29", roundTripped.PackageVersions["Syncfusion.Maui.DataGrid"]);
        Assert.Equal("abc123", roundTripped.OriginalHashes["DataGrid/README.md"]);
    }

    [Fact]
    public static void Manifest_LegacyThemeIsIgnoredAndNotWrittenToNewState()
    {
        const string oldJson = """
            {
              "schemaVersion": 1,
              "framework": "maui",
              "theme": "material",
              "packageIds": ["Syncfusion.Maui.DataGrid"],
              "installedTemplates": []
            }
            """;

        var manifest = SyncfusionManifest.FromJson(oldJson);
        var rewritten = manifest.ToJson();

        Assert.Contains("Syncfusion.Maui.DataGrid", rewritten, StringComparison.Ordinal);
        Assert.DoesNotContain("\"theme\"", rewritten, StringComparison.Ordinal);
        Assert.Equal(["Syncfusion.Maui.DataGrid"], SyncfusionManifest.FromJson(rewritten).PackageIds);
    }

    [Fact]
    public static void Manifest_DefaultsArePopulated()
    {
        var manifest = new SyncfusionManifest();
        Assert.Equal(1, manifest.SchemaVersion);
        Assert.Empty(manifest.InstalledControls);
        Assert.Empty(manifest.PackageIds);
        Assert.Empty(manifest.GeneratedFiles);
    }

    [Fact]
    public static void ToJson_IsIndented()
    {
        var manifest = new SyncfusionManifest { CliVersion = "1.0" };
        Assert.Contains("\n  \"cliVersion\"", manifest.ToJson());
    }
}

/// <summary>
/// Tests for Phase 3 path resolution: destination paths and embedded resource
/// names are computed consistently across platforms.
/// </summary>
public static class PathResolutionTests
{
    [Fact]
    public static void ResolveDestination_CombinesRootAndRelative()
    {
        var projectRoot = Path.Combine(Path.GetTempPath(), "sf-cli-tests-" + Guid.NewGuid().ToString("N"));
        var dest = TemplatePathResolver.ResolveDestination(projectRoot, "DataGrid/README.md");
        var expected = Path.Combine(projectRoot, "DataGrid", "README.md");
        Assert.Equal(Path.GetFullPath(expected), Path.GetFullPath(dest));
    }

    [Fact]
    public static void ResolveDestination_NormalizesBackslashes()
    {
        var projectRoot = Path.Combine(Path.GetTempPath(), "sf-cli-tests-" + Guid.NewGuid().ToString("N"));
        var dest = TemplatePathResolver.ResolveDestination(projectRoot, @"DataGrid\README.md");
        var expected = Path.Combine(projectRoot, "DataGrid", "README.md");
        Assert.Equal(Path.GetFullPath(expected), Path.GetFullPath(dest));
        Assert.True(Path.IsPathRooted(dest));
        Assert.EndsWith("README.md", dest);
    }

    [Fact]
    public static void ResolveResourceName_BuildsDottedName()
    {
        var name = TemplatePathResolver.ResolveResourceName("Templates/Controls/DataGrid", "DataGridView.xaml");
        Assert.Equal("Syncfusion.DotNet.Cli.Maui.Templates.Controls.DataGrid.DataGridView.xaml", name);
    }

    [Fact]
    public static void ResolveResourceName_AcceptsBackslashes()
    {
        var name = TemplatePathResolver.ResolveResourceName(@"Templates\Controls\DataGrid", @"DataGridView.xaml");
        Assert.Equal("Syncfusion.DotNet.Cli.Maui.Templates.Controls.DataGrid.DataGridView.xaml", name);
    }

    [Fact]
    public static void ResolveResourceName_MatchesActualEmbeddedResource()
    {
        // The computed name must resolve to a real embedded resource.
        var name = TemplatePathResolver.ResolveResourceName("Templates/Controls/CartesianChart", "CartesianChartView.xaml");
        var content = EmbeddedResourceLoader.ReadText(name);
        Assert.Contains("SfCartesianChart", content);
    }
}

/// <summary>
/// Tests for Phase 3 NuGet argument creation. The argument builder is pure
/// and produces the exact dotnet add|remove package invocation.
/// </summary>
public static class NuGetArgumentTests
{
    [Fact]
    public static void AddOperation_BuildsCorrectArgs()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Add,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.True(args.SequenceEqual(
        [
            "add", "MyApp.csproj", "package", "Syncfusion.Maui.DataGrid",
            "--source", NuGetSources.DefaultPublicFeed,
        ]));
    }

    [Fact]
    public static void AddOperation_WithVersion_IncludesVersionFlag()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Add,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
            Version = "32.1.29",
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.Contains("--version", args);
        var idx = args.ToList().IndexOf("--version");
        Assert.Equal("32.1.29", args[idx + 1]);
    }

    [Fact]
    public static void AddOperation_WithSourceAndConfigFile()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Add,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
            Source = "https://api.nuget.org/v3/index.json",
            ConfigFile = "nuget.config",
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.Contains("--source", args);
        Assert.Contains("--configfile", args);
        Assert.Contains("nuget.config", args);
    }

    [Fact]
    public static void AddOperation_NoRestore_IncludesFlag()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Add,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
            NoRestore = true,
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.Contains("--no-restore", args);
    }

    [Fact]
    public static void RemoveOperation_BuildsCorrectArgs()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Remove,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.True(args.SequenceEqual(
        [
            "remove", "MyApp.csproj", "package", "Syncfusion.Maui.DataGrid",
        ]));
    }

    [Fact]
    public static void RemoveOperation_DoesNotIncludeVersionFlag()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Remove,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
            Version = "32.1.29",
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.DoesNotContain("--version", args);
    }

    [Fact]
    public static void RemoveOperation_NoRestore_DoesNotIncludeUnsupportedFlag()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Remove,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
            NoRestore = true,
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.DoesNotContain("--no-restore", args);
    }

    [Fact]
    public static void DryRun_IncludesDryRunFlag()
    {
        var op = new NuGetOperation
        {
            Kind = NuGetOperationKind.Add,
            ProjectPath = "MyApp.csproj",
            PackageId = "Syncfusion.Maui.DataGrid",
            DryRun = true,
        };
        var args = NuGetArgumentBuilder.Build(op);
        Assert.Contains("--dry-run", args);
    }

    [Fact]
    public static void FormatCommandLine_QuotesSpaces()
    {
        var args = new List<string> { "add", "D:\\My Projects\\MyApp.csproj", "package", "Syncfusion.Maui.DataGrid" };
        var cmd = NuGetArgumentBuilder.FormatCommandLine(args);
        Assert.StartsWith("dotnet add \"D:\\My Projects\\MyApp.csproj\"", cmd);
    }

    [Fact]
    public static void NuGetSources_ResolveSource_RejectsOtherFeeds()
    {
        Assert.Throws<ArgumentException>(() => NuGetSources.ResolveSource("https://example.test/feed"));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public static void NuGetSources_ResolveSource_FallsBackToNugetOrgWhenMissing(string? value)
    {
        Assert.Equal(NuGetSources.DefaultPublicFeed, NuGetSources.ResolveSource(value));
    }

    [Fact]
    public static void NuGetSources_AppendSourceAndConfigFile_AlwaysIncludesSource()
    {
        var args = new List<string> { "restore", "MyApp.csproj" };
        NuGetSources.AppendSourceAndConfigFile(args, userSource: null, userConfigFile: null);
        Assert.Equal(
            new[] { "restore", "MyApp.csproj", "--source", NuGetSources.DefaultPublicFeed },
            args);
    }

    [Fact]
    public static void NuGetSources_AppendSourceAndConfigFile_UsesOfficialSourceAndHonorsConfigFile()
    {
        var args = new List<string>();
        NuGetSources.AppendSourceAndConfigFile(
            args,
            userSource: NuGetSources.DefaultPublicFeed,
            userConfigFile: "nuget.config");
        Assert.Equal(
            new[] { "--source", NuGetSources.DefaultPublicFeed, "--configfile", "nuget.config" },
            args);
    }
}

/// <summary>
/// Tests for Phase 3 dry-run planning. The installer builds a non-mutating
/// change plan for --dry-run without touching the filesystem.
/// </summary>
public static class DryRunPlanningTests
{
    private static string CreateTempProject()
    {
        var dir = Path.Combine(Path.GetTempPath(), "sf-cli-tests-" + System.Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        File.WriteAllText(Path.Combine(dir, "MyApp.csproj"),
            """
            <Project Sdk="Microsoft.NET.Maui.Sdk">
              <PropertyGroup>
                <TargetFramework>net10.0</TargetFramework>
                <OutputType>Exe</OutputType>
              </PropertyGroup>
            </Project>
            """);
        return dir;
    }

    [Fact]
    public static void PlanAdd_DryRun_DoesNotCreateFiles()
    {
        var dir = CreateTempProject();
        try
        {
            var installer = new Syncfusion.DotNet.Cli.Maui.ControlInstaller(dir);
            var result = installer.PlanAdd("datagrid", dryRun: true);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.True(result.Plan!.IsDryRun);
            Assert.Contains("Syncfusion.Maui.DataGrid", result.Plan.PackagesToAdd);
            Assert.NotEmpty(result.Plan.FilesToCreate);
            // No files created under the project.
            Assert.False(Directory.Exists(Path.Combine(dir, "Syncfusion")));
        }
        finally
        {
            Directory.Delete(dir, recursive: true);
        }
    }

    [Fact]
    public static void PlanAdd_UnknownControl_ReturnsError()
    {
        var dir = CreateTempProject();
        try
        {
            var installer = new Syncfusion.DotNet.Cli.Maui.ControlInstaller(dir);
            var result = installer.PlanAdd("notreal", dryRun: true);
            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("not supported", result.Message);
        }
        finally
        {
            Directory.Delete(dir, recursive: true);
        }
    }

    [Fact]
    public static void PlanRemove_AbsentControl_IsNoOp()
    {
        var dir = CreateTempProject();
        try
        {
            var installer = new Syncfusion.DotNet.Cli.Maui.ControlInstaller(dir);
            var result = installer.PlanRemove("datagrid", dryRun: true);
            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.Empty(result.Plan!.PackagesToRemove);
            Assert.Empty(result.Plan.FilesToDelete);
        }
        finally
        {
            Directory.Delete(dir, recursive: true);
        }
    }

    [Fact]
    public static void Installer_NoCsproj_ThrowsDirectoryNotFound()
    {
        var dir = Path.Combine(Path.GetTempPath(), "sf-cli-empty-" + System.Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        try
        {
            Assert.Throws<DirectoryNotFoundException>(() =>
                new Syncfusion.DotNet.Cli.Maui.ControlInstaller(dir));
        }
        finally
        {
            Directory.Delete(dir, recursive: true);
        }
    }
}

/// <summary>
/// Tests for Phase 3 file rollback. Created files are deleted on rollback;
/// modified files are restored to their original content.
/// </summary>
public static class FileRollbackTests
{
    [Fact]
    public static void Rollback_DeletesCreatedFiles()
    {
        var dir = Path.Combine(Path.GetTempPath(), "sf-rollback-" + System.Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        var path = Path.Combine(dir, "new.txt");
        try
        {
            using var rollback = new FileRollback();
            File.WriteAllText(path, "new content");
            rollback.TrackCreated(path);
            Assert.True(File.Exists(path));

            var errors = rollback.Rollback();
            Assert.Empty(errors);
            Assert.False(File.Exists(path));
        }
        finally
        {
            if (Directory.Exists(dir)) { Directory.Delete(dir, recursive: true); }
        }
    }

    [Fact]
    public static void Rollback_RestoresModifiedFiles()
    {
        var dir = Path.Combine(Path.GetTempPath(), "sf-rollback-" + System.Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        var path = Path.Combine(dir, "existing.txt");
        File.WriteAllText(path, "original");
        try
        {
            using var rollback = new FileRollback();
            rollback.TrackModified(path);
            File.WriteAllText(path, "modified");

            var errors = rollback.Rollback();
            Assert.Empty(errors);
            Assert.Equal("original", File.ReadAllText(path));
        }
        finally
        {
            if (Directory.Exists(dir)) { Directory.Delete(dir, recursive: true); }
        }
    }

    [Fact]
    public static void TrackModified_NonExistentFile_TreatedAsCreated()
    {
        var dir = Path.Combine(Path.GetTempPath(), "sf-rollback-" + System.Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        var path = Path.Combine(dir, "ghost.txt");
        try
        {
            using var rollback = new FileRollback();
            rollback.TrackModified(path);
            File.WriteAllText(path, "ghost");
            rollback.Rollback();
            Assert.False(File.Exists(path));
        }
        finally
        {
            if (Directory.Exists(dir)) { Directory.Delete(dir, recursive: true); }
        }
    }

    [Fact]
    public static void ComputeHash_ReturnsLowercaseHexOrnull()
    {
        var dir = Path.Combine(Path.GetTempPath(), "sf-hash-" + System.Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        var path = Path.Combine(dir, "h.txt");
        try
        {
            Assert.Null(FileRollback.ComputeHash(path));
            File.WriteAllText(path, "hello");
            var hash = FileRollback.ComputeHash(path);
            Assert.NotNull(hash);
            Assert.Equal(64, hash!.Length); // SHA-256 hex = 64 chars
            Assert.True(hash.All(c => "0123456789abcdef".Contains(c)));
        }
        finally
        {
            if (Directory.Exists(dir)) { Directory.Delete(dir, recursive: true); }
        }
    }

    [Fact]
    public static void Commit_ClearsTrackingWithoutRollback()
    {
        var dir = Path.Combine(Path.GetTempPath(), "sf-commit-" + System.Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        var path = Path.Combine(dir, "c.txt");
        try
        {
            using var rollback = new FileRollback();
            File.WriteAllText(path, "kept");
            rollback.TrackCreated(path);
            rollback.Commit();
            // Commit does not delete; file remains.
            Assert.True(File.Exists(path));
            // A subsequent rollback has nothing to undo.
            Assert.Empty(rollback.Rollback());
        }
        finally
        {
            if (Directory.Exists(dir)) { Directory.Delete(dir, recursive: true); }
        }
    }
}
