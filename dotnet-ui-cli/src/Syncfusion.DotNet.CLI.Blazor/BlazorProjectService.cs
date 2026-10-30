using System.Text.Json;
using System.Xml.Linq;
using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Blazor;

public sealed class BlazorProjectService(ToolRunner? runner = null)
{
    private readonly ToolRunner _runner = runner ?? new ToolRunner();

    public async Task<DesktopResult> CreateAsync(BlazorNewRequest request, IProgress<string>? progress = null,
        CancellationToken cancellationToken = default)
    {
        var frameworks = await new BlazorTemplateCapabilities(_runner).FrameworksAsync(request.AppType, cancellationToken).ConfigureAwait(false);
        if (BlazorConfiguration.Validate(request, frameworks) is { } validation) return new(ExitCodes.Error, validation);
        request = request with
        {
            Controls = request.Controls.Select(control => BlazorCatalog.Resolve(control)!.Alias)
                .Distinct(StringComparer.OrdinalIgnoreCase).ToArray(),
        };
        var root = Path.GetFullPath(request.ProjectDirectory);
        if (File.Exists(root) || Directory.Exists(root)) return new(ExitCodes.Error, $"'{request.Name}' already exists in project location '{request.Location}'.");
        var protection = DesktopProjectService.ValidateLocation(request.Location);
        if (protection is not null) return new(ExitCodes.Error, protection);
        if (request.DryRun) return new(0, "Planned Blazor project. No changes made (--dry-run).", root);
        using var rollback = new FileRollback();
        using var stages = new OperationStages(progress);
        try
        {
            stages.Start("Creating project");
            rollback.TrackCreatedDirectoryTree(root);
            Directory.CreateDirectory(request.Location);
            var args = TemplateArguments(request, root);
            DesktopProjectService.RequireSuccess(await _runner.RunAsync(args, request.Location, cancellationToken).ConfigureAwait(false), "creating from the official Blazor template");
            stages.Complete();
            if (request.DemoPages)
            {
                stages.Start("Adding Syncfusion components");
                await ConfigureProjectAsync(request, root, cancellationToken).ConfigureAwait(false);
                stages.Complete();
            }
            BlazorWelcomeTemplate.Install(root, request.Controls, request.DemoPages);
            if (request.Restore || request.Build)
            {
                stages.Start("Restoring packages");
                var restore = new List<string> { "restore", root };
                NuGetSources.AppendSourceAndConfigFile(restore, request.Source, null);
                if (request.ConfigFile is not null) restore.AddRange(["--configfile", request.ConfigFile]);
                // IDE-installed machine-wide sources (for example a local toolbox feed) are added through this property and may not exist.
                restore.Add("-p:RestoreAdditionalProjectSources=");
                DesktopProjectService.RequireSuccess(await _runner.RunAsync(restore, root, cancellationToken).ConfigureAwait(false), "restoring packages");
                stages.Complete();
            }
            if (request.Build)
            {
                stages.Start("Building project");
                DesktopProjectService.RequireSuccess(await _runner.RunAsync(["build", root, "--no-restore"], root, cancellationToken).ConfigureAwait(false), "building project");
                stages.Complete();
            }
            rollback.Commit();
            return new(0, $"Project created at {root}", root);
        }
        catch (OperationCanceledException) { rollback.Rollback(); throw; }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or InvalidOperationException or System.ComponentModel.Win32Exception)
        {
            var errors = rollback.Rollback();
            return new(ExitCodes.Error, "Blazor project creation failed; generated files were rolled back.", root,
                Errors: new[] { exception.Message }.Concat(errors).ToArray(), RolledBack: true);
        }
    }

    internal static IReadOnlyList<string> TemplateArguments(BlazorNewRequest request, string output)
    {
        var args = new List<string> { "new", BlazorConfiguration.Template(request.AppType), "-n", request.Name, "-o", output,
            "--framework", request.TargetFramework, "--auth", request.Authentication == BlazorAuthentication.Individual ? "Individual" : "None", "--no-restore" };
        if (request.AppType == BlazorAppType.WebApp)
        {
            args.AddRange(["--interactivity", request.RenderMode.ToString()]);
            if (request.Interactivity == BlazorInteractivity.Global) args.Add("--all-interactive");
        }
        if (!request.Https && request.Authentication == BlazorAuthentication.None) args.Add("--no-https");
        if (!request.DemoPages) args.Add("--empty");
        return args;
    }

    private async Task ConfigureProjectAsync(BlazorNewRequest request, string root, CancellationToken cancellationToken)
    {
        var projects = Directory.GetFiles(root, "*.csproj", SearchOption.AllDirectories);
        var hostProject = projects.FirstOrDefault(path => Path.GetFileNameWithoutExtension(path) == request.Name)
            ?? throw new InvalidOperationException("The official template did not create the expected project.");
        var clientProject = projects.FirstOrDefault(path => Path.GetFileNameWithoutExtension(path) == request.Name + ".Client");
        var componentProject = request.AppType == BlazorAppType.WebAssemblyStandalone || request.RenderMode == BlazorRenderMode.Server
            ? hostProject : clientProject ?? throw new InvalidOperationException("The selected render mode did not create a client project.");
        var componentRoot = Path.GetDirectoryName(componentProject)!;
        var hostRoot = Path.GetDirectoryName(hostProject)!;
        var packages = BlazorCatalog.RequiredPackages(request.Controls);
        var versions = new Dictionary<string, string>();
        foreach (var package in packages)
            versions[package] = await NuGetPackageVersions.ResolveAsync(package, request.Version, _runner, cancellationToken).ConfigureAwait(false);
        AddPackages(componentProject, versions);
        AddSyncfusionServices(Path.Combine(componentRoot, "Program.cs"), request.Controls.Contains("pdf-viewer"));
        // Prerendering of WebAssembly/Auto components runs on the host, which needs the same services and imports.
        if (componentRoot != hostRoot)
        {
            AddSyncfusionServices(Path.Combine(hostRoot, "Program.cs"), request.Controls.Contains("pdf-viewer"));
            AddImports(FindFile(hostRoot, "_Imports.razor"));
        }
        AddImports(FindFile(componentRoot, "_Imports.razor"));
        var renderDirective = request.AppType == BlazorAppType.WebAssemblyStandalone || request.Interactivity == BlazorInteractivity.Global
            ? "" : request.RenderMode switch { BlazorRenderMode.Server => "@rendermode InteractiveServer", BlazorRenderMode.WebAssembly => "@rendermode InteractiveWebAssembly", _ => "@rendermode InteractiveAuto" };
        var pages = Path.Combine(componentRoot, request.AppType == BlazorAppType.WebApp && request.RenderMode == BlazorRenderMode.Server ? "Components/Pages" : "Pages");
        Directory.CreateDirectory(pages);
        var pageNamespace = Path.GetFileNameWithoutExtension(componentProject) +
            (request.AppType == BlazorAppType.WebApp && request.RenderMode == BlazorRenderMode.Server ? ".Components.Pages" : ".Pages");
        foreach (var control in request.Controls)
            foreach (var source in BlazorDemoTemplates.Sources(control, renderDirective, pageNamespace, request.AppType))
                File.WriteAllText(Path.Combine(pages, source.Key), source.Value);
        AddNavigation(FindFile(root, "NavMenu.razor"), request.Controls);
        var theme = BlazorCatalog.Themes.Single(theme => theme.Id == request.Theme);
        if (request.AppType == BlazorAppType.WebAssemblyStandalone) AddWasmAssets(Path.Combine(root, "wwwroot/index.html"), theme, request.Controls);
        else AddWebAssets(Path.Combine(hostRoot, "Components/App.razor"), theme, request.Controls);
        Directory.CreateDirectory(Path.Combine(componentRoot, "Syncfusion"));
        var manifest = new BlazorManifest
        {
            Platform = "blazor",
            ProjectFile = Path.GetFileName(componentProject),
            Theme = request.Theme,
            Controls = request.Controls.Order().ToList(),
            RequiredPackages = packages.ToList(),
            AppType = request.AppType == BlazorAppType.WebApp ? "web-app" : "webassembly-standalone",
            RenderMode = request.RenderMode.ToString().ToLowerInvariant(),
            Interactivity = request.Interactivity == BlazorInteractivity.Global ? "global" : "per-page",
            Authentication = request.Authentication.ToString().ToLowerInvariant(),
            Https = request.Https,
        };
        File.WriteAllText(Path.Combine(componentRoot, DesktopProjectService.ManifestName), JsonSerializer.Serialize(manifest, new JsonSerializerOptions { WriteIndented = true }));
    }

    private static void AddPackages(string project, IReadOnlyDictionary<string, string> packages)
    {
        var xml = XDocument.Load(project);
        var ns = xml.Root!.Name.Namespace;
        xml.Root.Add(new XElement(ns + "ItemGroup", packages.Select(package => new XElement(ns + "PackageReference", new XAttribute("Include", package.Key), new XAttribute("Version", package.Value)))));
        xml.Save(project);
    }

    private static void AddSyncfusionServices(string program, bool includeMemoryCache)
    {
        var text = File.ReadAllText(program);
        if (!text.Contains("AddSyncfusionBlazor", StringComparison.Ordinal))
        {
            var service = "builder.Services.AddSyncfusionBlazor();\n" +
                (includeMemoryCache ? "builder.Services.AddMemoryCache();\n" : "") + "\n";
            text = text.Contains("var app = builder.Build();", StringComparison.Ordinal)
                ? text.Replace("var app = builder.Build();", service + "var app = builder.Build();", StringComparison.Ordinal)
                : text.Replace("await builder.Build().RunAsync();", service + "await builder.Build().RunAsync();", StringComparison.Ordinal);
        }
        File.WriteAllText(program, "using Syncfusion.Blazor;\n" + text);
    }

    private static void AddImports(string imports)
    {
        File.AppendAllText(imports, "\n@using Syncfusion.Blazor\n");
    }

    private static void AddNavigation(string nav, IReadOnlyList<string> controls)
    {
        var text = File.ReadAllText(nav);
        var marker = "</nav>";
        var links = string.Join("\n", controls.Select(control => $"        <div class=\"nav-item px-3\"><NavLink class=\"nav-link\" href=\"{control}\">{BlazorDemoTemplates.Display(control)}</NavLink></div>"));
        File.WriteAllText(nav, text.Replace(marker, links + "\n    " + marker, StringComparison.Ordinal));
    }

    internal static string ScriptTags(IReadOnlyList<string> controls)
    {
        var scripts = new List<string> { "_content/Syncfusion.Blazor.Core/scripts/syncfusion-blazor.min.js" };
        foreach (var (alias, package, bundle) in new[]
        {
            ("pdf-viewer", "SfPdfViewer", "sfpdfviewer"),
            ("document-editor", "WordProcessor", "documenteditor"),
            ("spreadsheet", "Spreadsheet", "spreadsheet"),
        })
            if (controls.Contains(alias))
                scripts.Add($"_content/Syncfusion.Blazor.{package}/scripts/syncfusion-blazor-{bundle}.min.js");
        return string.Join("\n", scripts.Select(script => $"    <script src=\"{script}\"></script>"));
    }

    private static void AddWebAssets(string app, BlazorTheme theme, IReadOnlyList<string> controls)
    {
        var text = File.ReadAllText(app).Replace("</head>", $"    <link rel=\"stylesheet\" href=\"_content/Syncfusion.Blazor.Themes/{theme.Stylesheet}\" />\n</head>", StringComparison.Ordinal)
            .Replace("</body>", ScriptTags(controls) + "\n</body>", StringComparison.Ordinal);
        File.WriteAllText(app, text);
    }

    private static void AddWasmAssets(string index, BlazorTheme theme, IReadOnlyList<string> controls)
    {
        var text = File.ReadAllText(index).Replace("</head>", $"    <link rel=\"stylesheet\" href=\"_content/Syncfusion.Blazor.Themes/{theme.Stylesheet}\" />\n</head>", StringComparison.Ordinal)
            .Replace("</body>", ScriptTags(controls) + "\n</body>", StringComparison.Ordinal);
        File.WriteAllText(index, text);
    }

    // Templates with authentication add extra _Imports.razor files in sub-folders; the shallowest match is the project-wide one.
    internal static string FindFile(string root, string name) => Directory.GetFiles(root, name, SearchOption.AllDirectories)
        .Where(path => !path.Contains($"{Path.DirectorySeparatorChar}obj{Path.DirectorySeparatorChar}") && !path.Contains($"{Path.DirectorySeparatorChar}bin{Path.DirectorySeparatorChar}"))
        .OrderBy(path => path.Count(c => c == Path.DirectorySeparatorChar)).ThenBy(path => path, StringComparer.Ordinal)
        .FirstOrDefault() ?? throw new InvalidOperationException($"The official template did not create the expected file '{name}' under '{root}'.");
}
