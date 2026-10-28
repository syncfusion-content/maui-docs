using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Blazor;
using Syncfusion.DotNet.CLI.Core;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class BlazorPlatformTests
{
    private static readonly IReadOnlyList<string> Frameworks = ["net10.0", "net9.0", "net8.0"];

    [Fact]
    public void SpecializedScriptsAreIncludedOnlyForSelectedControls()
    {
        var scripts = BlazorProjectService.ScriptTags(["pdf-viewer", "document-editor", "spreadsheet"]);
        Assert.Contains("Syncfusion.Blazor.SfPdfViewer/scripts/syncfusion-blazor-sfpdfviewer.min.js", scripts);
        Assert.Contains("Syncfusion.Blazor.WordProcessor/scripts/syncfusion-blazor-documenteditor.min.js", scripts);
        Assert.Contains("Syncfusion.Blazor.Spreadsheet/scripts/syncfusion-blazor-spreadsheet.min.js", scripts);
        Assert.DoesNotContain("sfpdfviewer", BlazorProjectService.ScriptTags(["grid"]));
        Assert.DoesNotContain("documenteditor", BlazorProjectService.ScriptTags(["grid"]));
        Assert.DoesNotContain("spreadsheet", BlazorProjectService.ScriptTags(["grid"]));
    }

    [Fact]
    public void FindFilePicksProjectWideImportsWhenAuthTemplateAddsNestedOnes()
    {
        var root = Directory.CreateTempSubdirectory("blazor-find").FullName;
        try
        {
            Directory.CreateDirectory(Path.Combine(root, "Components", "Account", "Pages"));
            var top = Path.Combine(root, "Components", "_Imports.razor");
            File.WriteAllText(top, "");
            File.WriteAllText(Path.Combine(root, "Components", "Account", "Pages", "_Imports.razor"), "");
            Assert.Equal(top, BlazorProjectService.FindFile(root, "_Imports.razor"));
            Assert.Throws<InvalidOperationException>(() => BlazorProjectService.FindFile(root, "Missing.razor"));
        }
        finally { Directory.Delete(root, true); }
    }

    [Fact]
    public void CatalogContainsRequestedThemesAndComponents()
    {
        Assert.Equal(["fluent2", "bootstrap5.3", "material3", "tailwind3", "bootstrap5"], BlazorCatalog.Themes.Select(theme => theme.Id));
        Assert.Equal(15, new BlazorPlatformProvider().Controls.Count);
        Assert.Equal("Syncfusion.Blazor.WordProcessor", BlazorCatalog.Resolve("document-editor")!.Id);
        Assert.Equal("Syncfusion.Blazor.SfPdfViewer", BlazorCatalog.Resolve("pdf-viewer")!.Id);
    }

    [Theory]
    [InlineData(BlazorAppType.WebApp)]
    [InlineData(BlazorAppType.WebAssemblyStandalone)]
    public void EveryControlHasDedicatedTemplatesWithResolvedNamespaces(BlazorAppType appType)
    {
        var controls = BlazorCatalog.Packages.Where(package => package.HasTemplate).ToArray();
        Assert.Equal(15, controls.Length);
        foreach (var control in controls)
        {
            var files = BlazorDemoTemplates.Sources(control.Alias, appType == BlazorAppType.WebApp ? "@rendermode InteractiveServer" : "", "Sample.Components.Pages", appType);
            var page = Assert.Single(files, file => file.Key.EndsWith(".razor", StringComparison.Ordinal));
            Assert.Contains($"@page \"/{control.Alias}\"", page.Value);
            Assert.Contains("@namespace Sample.Components.Pages", page.Value);
            if (appType == BlazorAppType.WebApp) Assert.Contains("@rendermode InteractiveServer", page.Value);
            else Assert.DoesNotContain("@rendermode", page.Value);
            foreach (var file in files)
                Assert.DoesNotContain("__", file.Value);
            foreach (var file in files.Where(file => file.Key.EndsWith(".cs", StringComparison.Ordinal)))
                Assert.Contains("namespace Sample.Components.Pages;", file.Value);
        }
    }

    [Fact]
    public void FeatureSamplesIncludeTheirAdditionalControlPackages()
    {
        Assert.Contains("Syncfusion.Blazor.Inputs", BlazorCatalog.RequiredPackages(["diagram"]));
        Assert.Contains("Syncfusion.Blazor.DropDowns", BlazorCatalog.RequiredPackages(["rich-text-editor"]));
        Assert.DoesNotContain("Syncfusion.Blazor.Inputs", BlazorCatalog.RequiredPackages(["charts"]));
    }

    [Theory]
    [InlineData(BlazorAppType.WebApp, "Web")]
    [InlineData(BlazorAppType.WebAssemblyStandalone, "Wasm")]
    public void EmbeddedControlPayloadMatchesTheSelectedAppTypeSources(BlazorAppType appType, string variant)
    {
        var root = Path.GetDirectoryName(SourcePath())!;
        var templates = Path.GetFullPath(Path.Combine(root, "..", "src", "Syncfusion.DotNet.CLI.Blazor", "Templates", "Controls"));
        foreach (var control in new BlazorPlatformProvider().Controls)
        {
            var folder = Path.Combine(templates, variant, control.Alias);
            if (!Directory.Exists(folder)) folder = Path.Combine(templates, "Shared", control.Alias);
            var files = BlazorDemoTemplates.Sources(control.Alias, "", "Proof.Pages", appType);
            Assert.Equal(Directory.GetFiles(folder).Length, files.Count);
            foreach (var file in Directory.GetFiles(folder))
            {
                var expected = File.ReadAllText(file).Replace("__RENDER_DIRECTIVE__", "")
                    .Replace("__PAGE_NAMESPACE__", "Proof.Pages").Replace("__DISPLAY_NAME__", control.DisplayName);
                Assert.Equal(expected.Replace("\r\n", "\n"), files[Path.GetFileName(file)].Replace("\r\n", "\n"));
            }
        }
    }

    private static string SourcePath([System.Runtime.CompilerServices.CallerFilePath] string path = "") => path;

    [Theory]
    [InlineData(BlazorAppType.WebApp, "blazor")]
    [InlineData(BlazorAppType.WebAssemblyStandalone, "blazorwasm")]
    public void UsesOfficialMicrosoftTemplate(BlazorAppType appType, string template)
        => Assert.Equal(template, BlazorConfiguration.Template(appType));

    [Fact]
    public void TemplateArgumentsRepresentWebAppConfiguration()
    {
        var request = Request() with { RenderMode = BlazorRenderMode.Auto, Interactivity = BlazorInteractivity.Global,
            Authentication = BlazorAuthentication.Individual, Https = true };
        var args = BlazorProjectService.TemplateArguments(request, "/tmp/App");
        Assert.Contains("blazor", args);
        Assert.Contains("Auto", args);
        Assert.Contains("--all-interactive", args);
        Assert.Contains("Individual", args);
        Assert.DoesNotContain("--no-https", args);
    }

    [Fact]
    public void EmptyTemplateSkipsSyncfusionConfiguration()
    {
        var request = Request() with { DemoPages = false, Controls = [] };
        Assert.Contains("--empty", BlazorProjectService.TemplateArguments(request, "/tmp/App"));
        Assert.Null(BlazorConfiguration.Validate(request, Frameworks));
    }

    [Theory]
    [InlineData("net7.0", "does not support")]
    [InlineData("net11.0", "does not support")]
    public void RejectsFrameworkNotReportedByInstalledTemplate(string framework, string expected)
        => Assert.Contains(expected, BlazorConfiguration.Validate(Request() with { TargetFramework = framework }, Frameworks)!);

    [Fact]
    public void StandaloneRejectsPlaceholderIndividualAuthentication()
    {
        var request = Request() with { AppType = BlazorAppType.WebAssemblyStandalone,
            RenderMode = BlazorRenderMode.WebAssembly, Authentication = BlazorAuthentication.Individual };
        Assert.Contains("authority and client ID", BlazorConfiguration.Validate(request, Frameworks)!);
    }

    [Fact]
    public void IndividualAuthenticationRequiresHttps()
        => Assert.Contains("require HTTPS", BlazorConfiguration.Validate(Request() with
        { Authentication = BlazorAuthentication.Individual, Https = false }, Frameworks)!);

    [Fact]
    public void EmptyProjectCannotContainComponents()
        => Assert.Contains("Empty project", BlazorConfiguration.Validate(Request() with { DemoPages = false }, Frameworks)!);

    [Fact]
    public async Task FrameworkAvailabilityComesFromInstalledTemplateOutput()
    {
        var frameworks = await new BlazorTemplateCapabilities(new CapabilityRunner()).FrameworksAsync(BlazorAppType.WebApp);
        Assert.Equal(["net10.0", "net8.0", "net11.0"], frameworks);
    }

    [Theory]
    [InlineData("Microsoft.NET.Sdk.Web", null)]
    [InlineData("Microsoft.NET.Sdk.BlazorWebAssembly", "Microsoft.AspNetCore.Components.WebAssembly")]
    public void DetectsExistingBlazorProjects(string sdk, string? package)
    {
        var packageReference = package is null ? "" : $"<ItemGroup><PackageReference Include=\"{package}\" /></ItemGroup>";
        Assert.Equal(Framework.Blazor, DesktopProjectFiles.Detect(XDocument.Parse($"<Project Sdk=\"{sdk}\">{packageReference}</Project>")));
    }

    [Fact]
    public void GeneratedPageContainsRouteRenderModeAndInteractiveControl()
    {
        var page = BlazorDemoTemplates.Page("grid", "@rendermode InteractiveAuto");
        Assert.Contains("@page \"/grid\"", page);
        Assert.Contains("@rendermode InteractiveAuto", page);
        Assert.Contains("<SfGrid", page);
    }

    [Theory]
    [InlineData("Home.razor")]
    [InlineData("Index.razor")]
    public void WelcomeReplacesOnlyHomeRouteAndPreservesSamplePages(string home)
    {
        using var directory = new TestDirectory();
        var pages = Path.Combine(directory.Path, "Pages");
        Directory.CreateDirectory(pages);
        File.WriteAllText(Path.Combine(pages, home), "@page \"/\"\n<h1>Hello</h1>");
        File.WriteAllText(Path.Combine(pages, "Grid.razor"), "@page \"/grid\"\n<SfGrid />");
        BlazorWelcomeTemplate.Install(directory.Path, ["grid"]);
        Assert.Contains("<WelcomeView />", File.ReadAllText(Path.Combine(pages, home)));
        var page = File.ReadAllText(Path.Combine(directory.Path, "Welcome/WelcomeView.razor"));
        Assert.Contains("Welcome to Your New Blazor App", page);
        Assert.Contains(WelcomeContent.Copyright, page);
        Assert.Contains("href=\"grid\"", page);
        foreach (var (title, url) in WelcomeContent.FooterLinks)
        {
            Assert.Contains(title, page);
            Assert.Contains(url, page);
        }
        Assert.Equal("@page \"/grid\"\n<SfGrid />", File.ReadAllText(Path.Combine(pages, "Grid.razor")));
        Assert.True(File.Exists(Path.Combine(directory.Path, "Welcome/WelcomeView.razor.css")));
        Assert.Contains("prefers-color-scheme: dark", BlazorWelcomeTemplate.Css);
        Assert.Contains(":focus-visible", BlazorWelcomeTemplate.Css);
    }

    [Fact]
    public async Task CreationFailureRollsBackGeneratedDirectory()
    {
        using var directory = new TestDirectory();
        var request = Request() with { Location = directory.Path, Restore = false, Build = false };
        var result = await new BlazorProjectService(new FailingTemplateRunner()).CreateAsync(request);
        Assert.False(result.Success);
        Assert.True(result.RolledBack);
        Assert.False(Directory.Exists(request.ProjectDirectory));
        Assert.Contains(result.Errors!, error => error.Contains("template failure", StringComparison.Ordinal));
    }

    [Fact]
    public async Task CancellationRollsBackGeneratedDirectory()
    {
        using var directory = new TestDirectory();
        var request = Request() with { Location = directory.Path, Restore = false, Build = false };
        await Assert.ThrowsAsync<OperationCanceledException>(() =>
            new BlazorProjectService(new CancellingTemplateRunner()).CreateAsync(request));
        Assert.False(Directory.Exists(request.ProjectDirectory));
    }

    private static BlazorNewRequest Request() => new("App", "/tmp", BlazorAppType.WebApp, "net10.0",
        BlazorRenderMode.Server, BlazorInteractivity.PerPage, BlazorAuthentication.None, true,
        true, "fluent2", ["grid"], true, true);

    private sealed class CapabilityRunner : ToolRunner
    {
        public override Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null,
            CancellationToken cancellationToken = default, string? executable = null)
            => Task.FromResult(new ToolResult(0, "Target framework net8.0, net10.0, net11.0", ""));
    }

    private sealed class FailingTemplateRunner : ToolRunner
    {
        public override Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null,
            CancellationToken cancellationToken = default, string? executable = null)
        {
            if (args.Contains("--help")) return Task.FromResult(new ToolResult(0, "net10.0", ""));
            var output = args[args.ToList().IndexOf("-o") + 1];
            Directory.CreateDirectory(output);
            File.WriteAllText(Path.Combine(output, "partial.txt"), "partial");
            return Task.FromResult(new ToolResult(1, "", "template failure"));
        }
    }

    private sealed class CancellingTemplateRunner : ToolRunner
    {
        public override Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null,
            CancellationToken cancellationToken = default, string? executable = null)
        {
            if (args.Contains("--help")) return Task.FromResult(new ToolResult(0, "net10.0", ""));
            var output = args[args.ToList().IndexOf("-o") + 1];
            Directory.CreateDirectory(output);
            throw new OperationCanceledException(cancellationToken);
        }
    }

    private sealed class TestDirectory : IDisposable
    {
        public string Path { get; } = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "sf-blazor-tests-" + Guid.NewGuid().ToString("N"));
        public TestDirectory() => Directory.CreateDirectory(Path);
        public void Dispose()
        {
            if (Directory.Exists(Path)) Directory.Delete(Path, recursive: true);
        }
    }

    [Fact]
    public void StandaloneReviewOmitsLanguageAndPlacesThemeAfterComponents()
    {
        var request = new Syncfusion.DotNet.CLI.Blazor.BlazorNewRequest("App", "/tmp", Syncfusion.DotNet.CLI.Blazor.BlazorAppType.WebAssemblyStandalone, "net10.0",
            Syncfusion.DotNet.CLI.Blazor.BlazorRenderMode.WebAssembly, Syncfusion.DotNet.CLI.Blazor.BlazorInteractivity.PerPage,
            Syncfusion.DotNet.CLI.Blazor.BlazorAuthentication.None, true, true, "fluent2", ["grid"], false, false);
        var rows = Syncfusion.DotNet.CLI.Commands.Blazor.BlazorCommands.Review(request).Select(row => row.Label).ToArray();
        Assert.DoesNotContain("Language:", rows);
        Assert.DoesNotContain("Render mode:", rows);
        Assert.Contains("Components:", rows);
        Assert.True(Array.IndexOf(rows, "Components:") < Array.IndexOf(rows, "Theme:"));
    }
}
