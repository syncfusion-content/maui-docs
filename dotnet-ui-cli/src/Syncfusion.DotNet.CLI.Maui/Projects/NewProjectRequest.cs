using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// A parsed MAUI project-creation request. Direct and interactive input both
/// produce this same record.
/// </summary>
public sealed record NewProjectRequest(
    Framework Framework,
    string Name,
    string Path,
    string TargetFramework,
    string Template,
    MauiProjectType ProjectType,
    bool Restore,
    bool Build,
    bool DryRun,
    bool Force,
    string? Version = null,
    string? Source = null,
    string? ConfigFile = null,
    IReadOnlyList<string>? TemplateIds = null,
    string? BuildFramework = null)
{
    /// <summary>The parent joined with the project name once; identical names deliberately nest.</summary>
    public string ProjectDirectory => System.IO.Path.GetFullPath(System.IO.Path.Combine(Path, Name));

    public IReadOnlyList<string> SelectedTemplateIds
        => TemplateIds ?? (string.IsNullOrWhiteSpace(Template) || Template.Equals("empty", StringComparison.OrdinalIgnoreCase)
            ? []
            : [Template]);
}
