using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>MAUI-specific stage vocabulary kept outside shared CLI presentation.</summary>
public sealed class MauiPackageAddPresentationProvider : IPackageAddPresentationProvider
{
    public MauiPackageAddPresentationProvider(ProjectDetector.ProjectInfo project)
    {
        _ = MauiProjectResolver.ValidateMauiProject(project);
    }
    public static string ProjectSelectionTitle => "Which MAUI project would you like to use?";
    public string PlatformName => ".NET MAUI";
    public string Group(string stage) => stage switch
    {
        "Adding package" or "Adding packages" => "Adding package",
        "Restoring" => "Restoring packages",
        "Building" => "Building project",
        _ => "Updating project files",
    };
    public string FailureDetail(string stage) => char.ToLowerInvariant(stage[0]) + stage[1..];
}
