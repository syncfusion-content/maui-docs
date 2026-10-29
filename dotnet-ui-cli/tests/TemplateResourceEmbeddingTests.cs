using System.Runtime.CompilerServices;
using System.Text.Json;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Manifest;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class TemplateResourceEmbeddingTests
{
    [Theory]
    [InlineData("cartesian-chart")]
    [InlineData("circular-chart")]
    [InlineData("listview")]
    public void EmbeddedTemplatesMatchTheCurrentPhysicalTemplateFiles(string id)
    {
        Assert.True(TemplateCatalog.TryResolveOperableTemplate(id, out var entry));
        var projectRoot = Path.GetDirectoryName(ProjectSourcePath())!;
        foreach (var file in entry.GeneratedFiles)
        {
            var expected = File.ReadAllText(Path.Combine(projectRoot, "Templates", entry.ControlName, file.TemplateResource));
            var embedded = EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource));
            Assert.Equal(expected.Replace("\r\n", "\n"), embedded.Replace("\r\n", "\n"));
        }
    }

    /// <summary>
    /// Regression for the corrupted-PDF defect: the shipped PDF resource must be
    /// embedded byte-for-byte, and any destination the CLI treats as binary must
    /// be a genuine binary extension so it never goes through text generation.
    /// </summary>
    [Fact]
    public void ShippedPdfTemplateIsEmbeddedByteIdenticalAndClassifiedBinary()
    {
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("pdf-viewer", out var entry));
        var pdf = Assert.Single(entry.GeneratedFiles, file =>
            file.Destination.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase));
        Assert.True(EmbeddedResourceLoader.IsBinaryFile(pdf.Destination));

        var projectRoot = Path.GetDirectoryName(ProjectSourcePath())!;
        var original = File.ReadAllBytes(Path.Combine(projectRoot, "Templates", entry.ControlName, pdf.TemplateResource));
        var embedded = EmbeddedResourceLoader.ReadBytes(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, pdf.TemplateResource));
        Assert.Equal(Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(original)),
            Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(embedded)));
        Assert.StartsWith("%PDF-", System.Text.Encoding.Latin1.GetString(embedded, 0, 5));
    }

    [Fact]
    public void BinaryDestinationIsNeverRenderedAsText()
    {
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("pdf-viewer", out var entry));
        foreach (var file in entry.GeneratedFiles)
        {
            // Text destinations must not be classified binary; binary destinations
            // must be, so the installer picks the matching write path.
            var isTextExtension = file.Destination.EndsWith(".cs", StringComparison.OrdinalIgnoreCase)
                || file.Destination.EndsWith(".xaml", StringComparison.OrdinalIgnoreCase)
                || file.Destination.EndsWith(".md", StringComparison.OrdinalIgnoreCase);
            Assert.Equal(!isTextExtension, EmbeddedResourceLoader.IsBinaryFile(file.Destination));
        }
    }

    [Fact]
    public async Task ProjectEmbeddingExcludesMacMetadataAtEveryDepthAndKeepsTemplates()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-template-embedding-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var projectPath = Path.Combine(root, "Templates.csproj");
            File.Copy(ProjectSourcePath(), projectPath);
            string[] templates =
            [
                "Templates/Controls/AssistView/Views/AssistView.xaml",
                "Templates/Controls/AssistView/Views/AssistView.xaml.cs",
                "Templates/Controls/AssistView/ViewModels/AssistViewModel.cs",
                "Templates/Controls/AssistView/README.md",
            ];
            string[] metadata =
            [
                "Templates/Controls/.DS_Store",
                "Templates/Controls/AssistView/.DS_Store",
                "Templates/Controls/AssistView/Views/.DS_Store",
                "Templates/Controls/._AssistView",
                "Templates/Controls/AssistView/Views/._AssistView.xaml",
                "Templates/Controls/__MACOSX/AssistView/Views/AssistView.xaml",
                "Templates/Controls/AssistView/__MACOSX/metadata.txt",
            ];
            foreach (var file in templates.Concat(metadata))
            {
                var path = Path.Combine(root, file);
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllText(path, "fixture");
            }

            // Evaluate the real project's resource globs in an isolated fixture;
            // no restore, build, or changes to the checkout are needed.
            var result = await new DotNetRunner().RunAsync(
                ["msbuild", projectPath, "-nologo", "-getItem:EmbeddedResource"], root, dryRun: false);
            Assert.True(result.Success, result.StandardError + result.StandardOutput);
            using var json = JsonDocument.Parse(result.StandardOutput);
            var embedded = json.RootElement.GetProperty("Items").GetProperty("EmbeddedResource")
                .EnumerateArray()
                .Select(item => item.GetProperty("Identity").GetString()!.Replace('\\', '/'))
                .Where(path => path.StartsWith("Templates/Controls/", StringComparison.Ordinal))
                .Order(StringComparer.Ordinal).ToArray();
            Assert.Equal(templates.Order(StringComparer.Ordinal), embedded);
            Assert.DoesNotContain(embedded, path => metadata.Contains(path, StringComparer.Ordinal));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public async Task PdfViewerResourcesMatchCatalogNames()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-pdf-casing-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var projectPath = Path.Combine(root, "Templates.csproj");
            File.Copy(ProjectSourcePath(), projectPath);
            Assert.True(TemplateCatalog.TryResolveOperableTemplate("pdf-viewer", out var template));
            foreach (var file in template.GeneratedFiles)
            {
                var path = Path.Combine(root, "Templates", "PdfViewer", file.TemplateResource);
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllText(path, "fixture");
            }
            var result = await new DotNetRunner().RunAsync(
                ["msbuild", projectPath, "-nologo", "-getItem:EmbeddedResource"], root, dryRun: false);
            Assert.True(result.Success, result.StandardError + result.StandardOutput);
            using var json = JsonDocument.Parse(result.StandardOutput);
            var resources = json.RootElement.GetProperty("Items").GetProperty("EmbeddedResource")
                .EnumerateArray()
                .Where(item => item.GetProperty("Identity").GetString()!.Replace('\\', '/').StartsWith("Templates/", StringComparison.Ordinal))
                .Select(item => item.GetProperty("LogicalName").GetString()!)
                .Order(StringComparer.Ordinal).ToArray();
            var expected = template.GeneratedFiles.Select(file => TemplatePathResolver.ResolveResourceName(
                template.TemplatePath, file.TemplateResource)).Order(StringComparer.Ordinal).ToArray();
            Assert.Equal(expected, resources);
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public void CatalogStillRejectsUnexpectedRealTemplateResources()
    {
        const string unexpected = "Syncfusion.DotNet.CLI.Maui.Templates.Controls.AssistView.Views.Unexpected.xaml";
        var resources = typeof(ControlInstaller).Assembly.GetManifestResourceNames().Append(unexpected).ToArray();
        var errors = TemplateCatalogValidator.Validate(TemplateCatalog.All, PackageCatalog.All, resources);
        Assert.Contains(errors, error => error.Contains(unexpected, StringComparison.Ordinal)
            && error.Contains("not referenced", StringComparison.Ordinal));
    }

    /// <summary>
    /// Drives the real installer add flow with fake runners and asserts the
    /// generated PDF sample is written byte-identically to the embedded
    /// resource, with a consistent manifest ownership hash.
    /// </summary>
    [Fact]
    public async Task InstallerWritesGeneratedPdfByteIdenticalToEmbeddedResource()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-pdf-installer-" + Guid.NewGuid().ToString("N"));
        try
        {
            var projectDir = Path.Combine(root, "PdfApp");
            Directory.CreateDirectory(projectDir);
            File.WriteAllText(Path.Combine(projectDir, "PdfApp.csproj"),
                "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><OutputType>Exe</OutputType></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(projectDir, "MauiProgram.cs"),
                "namespace PdfApp;\npublic static class MauiProgram\n{\n    public static MauiApp CreateMauiApp()\n    {\n        var builder = MauiApp.CreateBuilder();\n        builder.UseMauiApp<App>();\n        return builder.Build();\n    }\n}\n");

            var installer = new ControlInstaller(projectDir, new RecordingNuGetRunner(), new FakeDotNetRunner());
            var result = await installer.ExecuteAddBatchAsync(["pdf-viewer"], version: "32.1.29", deferBuild: true);
            if (result.ExitCode != ExitCodes.Success)
                throw new Xunit.Sdk.XunitException($"add failed: {result.Message} | {string.Join("; ", result.Errors)}");

            var generated = File.ReadAllBytes(Path.Combine(projectDir, "PdfViewer", "Pdf", "PDF_Succinctly.pdf"));
            var resourceName = TemplatePathResolver.ResolveResourceName("Templates/Controls/PdfViewer", "Pdf/PDF_Succinctly.pdf");
            var embedded = EmbeddedResourceLoader.ReadBytes(resourceName);
            Assert.Equal(Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(embedded)),
                Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(generated)));

            var manifest = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            Assert.Equal(Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(embedded)).ToLowerInvariant(),
                manifest.OriginalHashes["PdfViewer/Pdf/PDF_Succinctly.pdf"]);

            // The PDF must be an EmbeddedResource in the generated project so the
            // sample's GetManifestResourceStream lookup succeeds.
            var csproj = File.ReadAllText(Path.Combine(projectDir, "PdfApp.csproj"));
            Assert.Contains("<EmbeddedResource Include=\"PdfViewer/Pdf/PDF_Succinctly.pdf\"", csproj);
            Assert.Contains("LogicalName=\"PdfViewer.Pdf.PDF_Succinctly.pdf\"", csproj);
            Assert.Contains("sf-cli:pdf-resource", csproj);
            Assert.Contains(manifest.GeneratedBlocks, block => block.Marker == "pdf-resource" && block.Path == "PdfApp.csproj");

            // Text files still carry resolved placeholders.
            var page = File.ReadAllText(Path.Combine(projectDir, "PdfViewer", "PdfViewerPage.xaml"));
            Assert.Contains("namespace PdfApp.PdfViewer", File.ReadAllText(Path.Combine(projectDir, "PdfViewer", "PdfViewerPage.xaml.cs")));
            Assert.DoesNotContain("__ROOT_NAMESPACE__", page);

            // Removing the sample removes the owned embedding block again.
            var removal = await installer.ExecuteRemoveBatchAsync(["pdf-viewer"]);
            Assert.Equal(ExitCodes.Success, removal.ExitCode);
            var csprojAfterRemoval = File.ReadAllText(Path.Combine(projectDir, "PdfApp.csproj"));
            Assert.DoesNotContain("EmbeddedResource", csprojAfterRemoval);
            Assert.DoesNotContain("sf-cli:pdf-resource", csprojAfterRemoval);
            var manifestAfterRemoval = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            Assert.DoesNotContain(manifestAfterRemoval.GeneratedBlocks, block => block.Marker == "pdf-resource");
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    /// <summary>
    /// Drives the real installer update flow with fake runners and asserts a
    /// regenerated (forced) PDF sample is written byte-identically to the
    /// embedded resource — never through a text round-trip.
    /// </summary>
    [Fact]
    public async Task UpdateFlowRegeneratesPdfByteIdenticalToEmbeddedResource()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-pdf-update-" + Guid.NewGuid().ToString("N"));
        try
        {
            var projectDir = Path.Combine(root, "PdfApp");
            Directory.CreateDirectory(projectDir);
            File.WriteAllText(Path.Combine(projectDir, "PdfApp.csproj"),
                "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><OutputType>Exe</OutputType></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(projectDir, "MauiProgram.cs"),
                "namespace PdfApp;\npublic static class MauiProgram\n{\n    public static MauiApp CreateMauiApp()\n    {\n        var builder = MauiApp.CreateBuilder();\n        builder.UseMauiApp<App>();\n        return builder.Build();\n    }\n}\n");

            var installer = new ControlInstaller(projectDir, new RecordingNuGetRunner(), new FakeDotNetRunner());
            var add = await installer.ExecuteAddBatchAsync(["pdf-viewer"], version: "32.1.29", deferBuild: true);
            Assert.Equal(ExitCodes.Success, add.ExitCode);

            // Corrupt the generated PDF so the update detects modification and,
            // with --force, regenerates it from the embedded resource.
            var pdfPath = Path.Combine(projectDir, "PdfViewer", "Pdf", "PDF_Succinctly.pdf");
            File.WriteAllBytes(pdfPath, "corrupted"u8.ToArray());

            var update = await installer.ExecuteUpdateAsync("pdf-viewer", version: "32.1.30", force: true);
            Assert.Equal(ExitCodes.Success, update.ExitCode);

            var resourceName = TemplatePathResolver.ResolveResourceName("Templates/Controls/PdfViewer", "Pdf/PDF_Succinctly.pdf");
            var embedded = EmbeddedResourceLoader.ReadBytes(resourceName);
            var regenerated = File.ReadAllBytes(pdfPath);
            Assert.Equal(Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(embedded)),
                Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(regenerated)));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    private sealed class RecordingNuGetRunner : NuGetRunner
    {
        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
        {
            if (!operation.DryRun && File.Exists(operation.ProjectPath))
            {
                var xml = System.Xml.Linq.XDocument.Load(operation.ProjectPath);
                xml.Root!.Add(new System.Xml.Linq.XElement("ItemGroup",
                    new System.Xml.Linq.XElement("PackageReference", new System.Xml.Linq.XAttribute("Include", operation.PackageId),
                        new System.Xml.Linq.XAttribute("Version", operation.Version ?? "32.1.29"))));
                xml.Save(operation.ProjectPath);
            }
            return Task.FromResult(new NuGetCommandResult { ExitCode = 0, StandardOutput = "version 32.1.29", StandardError = string.Empty });
        }
    }

    private sealed class FakeDotNetRunner : DotNetRunner
    {
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
            => Task.FromResult(args.Any(argument => argument.StartsWith("-getProperty:", StringComparison.Ordinal))
                ? new ProcessCommandResult
                {
                    ExitCode = 0,
                    StandardOutput = System.Text.Json.JsonSerializer.Serialize(new
                    {
                        Properties = args.Any(argument => argument.Contains("ManagePackageVersionsCentrally", StringComparison.Ordinal))
                            ? (object)new { ManagePackageVersionsCentrally = "false", DirectoryPackagesPropsPath = "" }
                            : new { TargetFrameworks = "net10.0", TargetFramework = "net10.0" },
                    }),
                    StandardError = string.Empty,
                }
                : new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty });
    }

    private static string ProjectSourcePath([CallerFilePath] string testFile = "")
        => Path.GetFullPath(Path.Combine(Path.GetDirectoryName(testFile)!, "..",
            "src", "Syncfusion.DotNet.CLI.Maui", "Syncfusion.DotNet.CLI.Maui.csproj"));
}
