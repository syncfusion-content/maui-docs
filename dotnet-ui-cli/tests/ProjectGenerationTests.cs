using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Manifest;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

/// <summary>
/// Tests for the Phase 4 follow-up work: manifest schema-version guard,
/// legacy manifest compatibility, and native project generation.
/// </summary>
public static class ProjectGenerationTests
{
    private static string TempDir()
    {
        var path = Path.Combine(Path.GetTempPath(), "sf-enh-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(path);
        return path;
    }

    // ---- Manifest max schema version ----------------------------------------

    [Fact]
    public static void Manifest_FromJson_RejectsNewerSchemaVersion()
    {
        var json = """
        {
            "schemaVersion": 99,
            "cliVersion": "1.0.0",
            "framework": "maui"
        }
        """;
        var ex = Assert.Throws<InvalidOperationException>(() => SyncfusionManifest.FromJson(json));
        Assert.Contains("schema version 99", ex.Message);
        Assert.Contains("maximum version", ex.Message);
    }

    [Fact]
    public static void Manifest_FromJson_AcceptsCurrentSchemaVersion()
    {
        var json = new SyncfusionManifest { SchemaVersion = 1, CliVersion = "0.1.0-preview.1" }.ToJson();
        var manifest = SyncfusionManifest.FromJson(json);
        Assert.Equal(1, manifest.SchemaVersion);
    }

    [Fact]
    public static void Manifest_MaxSupportedSchemaVersion_IsTwo()
    {
        Assert.Equal(2, SyncfusionManifest.MaxSupportedSchemaVersion);
    }

    [Fact]
    public static void Manifest_FromJson_IgnoresLegacySkillsAndMcpFieldsAndOmitsThemOnWrite()
    {
        const string legacyManifest = """
        {
            "schemaVersion": 1,
            "cliVersion": "0.1.0-preview.1",
            "framework": "maui",
            "skills": { "enabled": true, "configuration": "private-skills-value" },
            "mcp": { "enabled": true, "configuration": "private-mcp-value" }
        }
        """;

        var manifest = SyncfusionManifest.FromJson(legacyManifest);
        var updatedManifest = manifest.ToJson();

        Assert.Equal(1, manifest.SchemaVersion);
        Assert.Contains("\"framework\": \"maui\"", updatedManifest, StringComparison.Ordinal);
        Assert.DoesNotContain("skills", updatedManifest, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("mcp", updatedManifest, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("private-", updatedManifest, StringComparison.Ordinal);
    }

    [Fact]
    public static void SkillsAndMcpEnhancementServices_AreNotAvailable()
    {
        Assert.Null(typeof(NewProjectScaffolder).Assembly.GetType("Syncfusion.DotNet.Cli.Maui.ProjectEnhancements"));
        Assert.Null(typeof(NewCommand).GetMethod(
            "ExecuteNewAsync",
            System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic));
    }

    // ---- Native project appearance ------------------------------------------

    [Fact]
    public static async Task NewProject_UsesNativeWelcomeWithTrackedResources()
    {
        var root = TempDir();
        try
        {
            var dotnet = new NativeAppearanceTestDotNet();
            var nuget = new NativeAppearanceTestNuGet();
            var scaffolder = new NewProjectScaffolder(dotnet, nuget);
            var request = new NewProjectRequest(
                Framework: Framework.Maui,
                Name: "NativeAppearanceApp",
                Path: root,
                TargetFramework: "net10.0",
                Template: "empty",
                ProjectType: MauiProjectType.App,
                Restore: false,
                Build: false,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);
            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.Empty(result.Warnings);
            var projectRoot = Path.Combine(root, "NativeAppearanceApp");
            Assert.True(File.Exists(Path.Combine(projectRoot, "Syncfusion", "syncfusion.json")));
            Assert.Contains("Welcome to Your New .NET MAUI App", File.ReadAllText(Path.Combine(projectRoot, "Welcome", "WelcomeView.xaml")));
            var manifest = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(projectRoot, "Syncfusion", "syncfusion.json")));
            Assert.Equal(2, manifest.SchemaVersion);
            Assert.Empty(manifest.InstalledControls);
            Assert.Equal(10, manifest.WelcomeFiles.Count);
            Assert.DoesNotContain(
                Directory.EnumerateFiles(projectRoot, "*", SearchOption.AllDirectories),
                path => IsSkillsOrMcpConfiguration(Path.GetFileName(path)));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task NewProject_InvalidNameDoesNotCreateProjectFiles()
    {
        var root = TempDir();
        try
        {
            var scaffolder = new NewProjectScaffolder(new NativeAppearanceTestDotNet(), new NativeAppearanceTestNuGet());
            var request = new NewProjectRequest(
                Framework: Framework.Maui,
                Name: "Invalid-Name",
                Path: root,
                TargetFramework: "net10.0",
                Template: "empty",
                ProjectType: MauiProjectType.App,
                Restore: false,
                Build: false,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("project name", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.False(Directory.Exists(Path.Combine(root, request.Name)));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task NewProject_ExistingDestinationIsNotModified()
    {
        var root = TempDir();
        try
        {
            var destination = Path.Combine(root, "ExistingApp");
            Directory.CreateDirectory(destination);
            var existingFile = Path.Combine(destination, "user.txt");
            File.WriteAllText(existingFile, "user data");
            var scaffolder = new NewProjectScaffolder(new NativeAppearanceTestDotNet(), new NativeAppearanceTestNuGet());
            var request = new NewProjectRequest(
                Framework: Framework.Maui,
                Name: "ExistingApp",
                Path: root,
                TargetFramework: "net10.0",
                Template: "empty",
                ProjectType: MauiProjectType.App,
                Restore: false,
                Build: false,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("already exists", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Equal("user data", File.ReadAllText(existingFile));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task NewProject_CreatesAtTheResolvedOutputLocation()
    {
        var root = TempDir();
        try
        {
            var outputPath = Path.Combine(root, "nested", "output");
            var scaffolder = new NewProjectScaffolder(new NativeAppearanceTestDotNet(), new NativeAppearanceTestNuGet());
            var request = new NewProjectRequest(
                Framework: Framework.Maui,
                Name: "NestedApp",
                Path: outputPath,
                TargetFramework: "net10.0",
                Template: "empty",
                ProjectType: MauiProjectType.App,
                Restore: false,
                Build: false,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.Equal(Path.Combine(outputPath, request.Name), result.ProjectPath);
            Assert.True(File.Exists(Path.Combine(result.ProjectPath!, "NestedApp.csproj")));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task NewProject_PreservesExistingSkillsAndMcpConfiguration()
    {
        var root = TempDir();
        try
        {
            var dotnet = new NativeAppearanceTestDotNet
            {
                ExistingConfigurationFiles = new Dictionary<string, string>
                {
                    [".mcp.json"] = "{\"user\":\"mcp-configuration\"}",
                    [Path.Combine(".github", "copilot-instructions.md")] = "user skills configuration",
                },
            };
            var scaffolder = new NewProjectScaffolder(dotnet, new NativeAppearanceTestNuGet());
            var request = new NewProjectRequest(
                Framework: Framework.Maui,
                Name: "ExistingConfigurationApp",
                Path: root,
                TargetFramework: "net10.0",
                Template: "empty",
                ProjectType: MauiProjectType.App,
                Restore: false,
                Build: false,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);
            Assert.Equal(ExitCodes.Success, result.ExitCode);
            foreach (var (relativePath, expectedContents) in dotnet.ExistingConfigurationFiles)
            {
                Assert.Equal(expectedContents, File.ReadAllText(Path.Combine(result.ProjectPath!, relativePath)));
            }
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    private static bool IsSkillsOrMcpConfiguration(string fileName)
        => fileName.Contains("skill", StringComparison.OrdinalIgnoreCase)
            || fileName.Contains("mcp", StringComparison.OrdinalIgnoreCase)
            || fileName.Contains("copilot", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// A minimal fake DotNetRunner that creates the csproj + MauiProgram so
    /// the scaffolder's downstream ControlInstaller can resolve the project.
    /// Uses the public DotNetRunner override seam.
    /// </summary>
    [Fact]
    public static async Task NewHybrid_UsesSupportedTemplateArgumentsAndTrackedRegistryIntegration()
    {
        var root = TempDir();
        try
        {
            var dotnet = new NativeAppearanceTestDotNet();
            var request = new NewProjectRequest(Framework.Maui, "Hybrid", root, "net10.0", "empty", MauiProjectType.BlazorHybrid,
                Restore: false, Build: false, DryRun: false, Force: false);
            var result = await new NewProjectScaffolder(dotnet, new NativeAppearanceTestNuGet()).ExecuteAsync(request);
            Assert.True(result.ExitCode == 0, result.Message);
            var creation = Assert.Single(dotnet.Calls, call => call[0] == "new");
            Assert.Equal("maui-blazor", creation[1]);
            Assert.DoesNotContain("--no-restore", creation);
            var projectRoot = Path.Combine(root, "Hybrid");
            var manifest = WelcomeProjectGenerator.ReadManifest(projectRoot)!;
            Assert.Equal("blazor-hybrid", manifest.ProjectType);
            Assert.Contains(manifest.GeneratedBlocks, block => block.Marker == "hybrid-binding");
            Assert.Contains(manifest.GeneratedBlocks, block => block.Marker == "hybrid-xaml-inflator");
            Assert.Contains("BlazorWebView", File.ReadAllText(Path.Combine(projectRoot, "MainPage.xaml")));
            Assert.Contains("Inflator=\"Runtime\"", File.ReadAllText(Path.Combine(projectRoot, "Hybrid.csproj")));
            Assert.Contains("Inflator=\"XamlC\"", File.ReadAllText(Path.Combine(projectRoot, "Hybrid.csproj")));
            Assert.Empty(manifest.InstalledControls);
        }
        finally { Directory.Delete(root, true); }
    }

    private sealed class NativeAppearanceTestDotNet : DotNetRunner
    {
        public IReadOnlyDictionary<string, string> ExistingConfigurationFiles { get; init; }
            = new Dictionary<string, string>();
        public List<IReadOnlyList<string>> Calls { get; } = [];

        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2]), StandardError = "" });
            var list = args.ToList();
            Calls.Add(args.ToArray());
            if (list.Count > 1 && list[1] is "maui" or "maui-blazor")
            {
                var name = list[list.IndexOf("-n") + 1];
                var outDir = list[list.IndexOf("-o") + 1];
                Directory.CreateDirectory(outDir);
                File.WriteAllText(Path.Combine(outDir, $"{name}.csproj"),
                    "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");
                File.WriteAllText(Path.Combine(outDir, "MauiProgram.cs"),
                    "namespace " + name + ";\npublic static class MauiProgram { public static MauiApp CreateMauiApp() { var builder = MauiApp.CreateBuilder(); return builder.Build(); } }");
                if (list[1] == "maui-blazor")
                {
                    File.WriteAllText(Path.Combine(outDir, name + ".csproj"),
                        "<Project Sdk=\"Microsoft.NET.Sdk.Razor\"><PropertyGroup><UseMaui>true</UseMaui><TargetFramework>net10.0</TargetFramework><MauiXamlInflator>SourceGen</MauiXamlInflator></PropertyGroup></Project>");
                    foreach (var file in new[] { "MainPage.xaml", "MainPage.xaml.cs" })
                        File.WriteAllText(Path.Combine(outDir, file), EmbeddedResourceLoader.ReadText(
                            TemplatePathResolver.ResourcePrefix + "Templates.Welcome.HybridReference." + file).Replace("__ROOT_NAMESPACE__", name));
                }
                foreach (var (relativePath, contents) in ExistingConfigurationFiles)
                {
                    var path = Path.Combine(outDir, relativePath);
                    Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                    File.WriteAllText(path, contents);
                }
            }

            return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty });
        }
    }

    /// <summary>A minimal fake NuGetRunner that always succeeds.</summary>
    private sealed class NativeAppearanceTestNuGet : NuGetRunner
    {
        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
            => Task.FromResult(new NuGetCommandResult { ExitCode = 0, StandardOutput = "version 32.1.29", StandardError = string.Empty });
    }
}
