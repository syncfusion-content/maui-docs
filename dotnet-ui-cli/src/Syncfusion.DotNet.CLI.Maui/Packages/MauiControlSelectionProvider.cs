using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Shares the verified MAUI catalog between creation and existing-project additions.</summary>
public sealed class MauiControlSelectionProvider : IControlSelectionProvider
{
    private readonly string? _projectPath;
    public IReadOnlyList<ControlSelectionItem> Controls { get; }
    public IReadOnlyList<PackageSelectionItem> Packages => PackageSelectionState.MarkInstalled(PackageCatalog.All
        .Where(package => package.SupportsPackageReference && !HiddenPackages.IsHidden(package.PackageId))
        .OrderBy(package => package.DisplayName, StringComparer.OrdinalIgnoreCase)
        .Select(package => new PackageSelectionItem(package.Alias, package.DisplayName, PackageId: package.PackageId)).ToArray(), _projectPath);
    public MauiControlSelectionProvider(MauiProjectType projectType)
        => Controls = Catalog(projectType).Select(entry => new ControlSelectionItem(entry.Id, entry.DisplayName)).ToArray();
    public MauiControlSelectionProvider(ProjectDetector.ProjectInfo project)
    {
        _ = MauiProjectResolver.ValidateMauiProject(project);
        _projectPath = project.CsprojPath;
        var manifest = WelcomeProjectGenerator.ReadManifest(Path.GetDirectoryName(project.CsprojPath)!, project);
        var added = (manifest?.InstalledControls ?? []).Concat(manifest?.InstalledTemplates.Select(record => record.Id) ?? [])
            .Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry) ? entry.Id : id).ToHashSet(StringComparer.OrdinalIgnoreCase);
        Controls = Catalog(manifest?.ProjectType == "blazor-hybrid" ? MauiProjectType.BlazorHybrid : MauiProjectType.App)
            .Select(entry => new ControlSelectionItem(entry.Id, entry.DisplayName, added.Contains(entry.Id))).ToArray();
    }
    public static IEnumerable<ControlCatalogEntry> OrderControls(IEnumerable<ControlCatalogEntry> entries)
        => entries.OrderBy(entry => entry.DisplayName, StringComparer.OrdinalIgnoreCase);

    private static IEnumerable<ControlCatalogEntry> Catalog(MauiProjectType projectType)
        => OrderControls(TemplateCatalog.Operable.Where(entry => entry.SupportedProjectTypes.Contains(projectType)
            && !entry.Id.Equals("welcome", StringComparison.OrdinalIgnoreCase)));
    public IReadOnlyList<string> ResolvePackages(IEnumerable<string> controlIds)
        => controlIds.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry) ? entry
                : throw new ArgumentException($"Control '{id}' is not available.", nameof(controlIds)))
            .SelectMany(entry => new[] { entry.PackageId }.Concat(entry.DependentPackageIds)).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();

    public static string GetTemplateFamilyDisplayName(string family)
        => family.ToLowerInvariant() switch
        {
            "datagrid" => "DataGrid",
            "listview" => "ListView",
            "assistview" => "AI AssistView",
            "rich-text-editor" => "Rich Text Editor",
            "combobox" => "ComboBox",
            "image-editor" => "Image Editor",
            "treeview" => "TreeView",
            _ => char.ToUpperInvariant(family[0]) + family[1..],
        };

}
