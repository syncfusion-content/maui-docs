using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Blazor;

public sealed record BlazorTheme(string Id, string DisplayName, string Stylesheet);

public sealed class BlazorPlatformProvider : IDesktopPlatformProvider
{
    public const string Version = "35.1.40";
    public Framework Platform => Framework.Blazor;
    public string DisplayName => "Blazor";
    public string? OfficialTemplate => null;
    public IReadOnlyList<string> Languages { get; } = ["C#"];
    public IReadOnlyList<string> TargetFrameworks { get; } = ["net10.0", "net9.0", "net8.0"];
    public string DefaultTheme => "fluent2";
    public IReadOnlyList<DesktopTheme> Themes => BlazorCatalog.Themes.Select(theme => new DesktopTheme(theme.Id, theme.DisplayName, "Syncfusion.Blazor.Themes")).ToArray();
    public IReadOnlyList<DesktopPackage> Packages => BlazorCatalog.Packages;
    public IReadOnlyList<DesktopPackage> Controls => Packages.Where(package => package.HasTemplate).OrderBy(package => package.DisplayName, StringComparer.OrdinalIgnoreCase).ToArray();
    public IReadOnlyDictionary<string, string> Generate(DesktopNewRequest request) => throw new NotSupportedException("Blazor projects use the official template orchestrator.");
    public IReadOnlyList<string> RequiredPackages(DesktopNewRequest request) => [];
    public string PackageVersion(string packageId, string? requestedVersion) => requestedVersion ?? Version;
}

public static class BlazorCatalog
{
    public static IReadOnlyList<BlazorTheme> Themes { get; } =
    [
        new("fluent2", "Fluent 2", "fluent2.css"),
        new("bootstrap5.3", "Bootstrap 5.3", "bootstrap5.3.css"),
        new("material3", "Material 3", "material3.css"),
        new("tailwind3", "Tailwind 3", "tailwind3.css"),
        new("bootstrap5", "Bootstrap 5", "bootstrap5.css"),
    ];

    public static IReadOnlyList<DesktopPackage> Packages { get; } = DesktopPackageCatalog.Combine(typeof(BlazorPlatformProvider),
    [
        new("ai-assistview", "AI AssistView", "Syncfusion.Blazor.InteractiveChat", true),
        new("block-editor", "Block Editor", "Syncfusion.Blazor.BlockEditor", true),
        new("pivot-table", "Pivot Table", "Syncfusion.Blazor.PivotTable", true),
        new("grid", "Grid", "Syncfusion.Blazor.Grid", true),
        new("charts", "Charts", "Syncfusion.Blazor.Charts", true),
        new("scheduler", "Scheduler", "Syncfusion.Blazor.Schedule", true),
        new("gantt", "Gantt", "Syncfusion.Blazor.Gantt", true),
        new("diagram", "Diagram", "Syncfusion.Blazor.Diagram", true),
        new("rich-text-editor", "Rich Text Editor", "Syncfusion.Blazor.RichTextEditor", true),
        new("file-manager", "File Manager", "Syncfusion.Blazor.FileManager", true),
        new("pdf-viewer", "PDF Viewer", "Syncfusion.Blazor.SfPdfViewer", true),
        new("document-editor", "Document Editor", "Syncfusion.Blazor.WordProcessor", true),
        new("spreadsheet", "Spreadsheet", "Syncfusion.Blazor.Spreadsheet", true),
        new("kanban", "Kanban", "Syncfusion.Blazor.Kanban", true),
        new("query-builder", "Query Builder", "Syncfusion.Blazor.QueryBuilder", true),
        new("core", "Core", "Syncfusion.Blazor.Core"),
        new("themes", "Themes", "Syncfusion.Blazor.Themes"),
    ]);

    public static IReadOnlyList<string> RequiredPackages(IReadOnlyList<string> controls)
    {
        var packages = controls.Select(control => Resolve(control)!.Id).ToList();
        if (controls.Contains("diagram")) packages.Add("Syncfusion.Blazor.Inputs");
        if (controls.Contains("rich-text-editor")) packages.Add("Syncfusion.Blazor.DropDowns");
        packages.Add("Syncfusion.Blazor.Themes");
        return packages.Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
    }

    public static DesktopPackage? Resolve(string value) => Packages.FirstOrDefault(package =>
        package.Alias.Equals(value, StringComparison.OrdinalIgnoreCase)
        || package.Id.Equals(value, StringComparison.OrdinalIgnoreCase));
}
