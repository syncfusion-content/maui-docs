namespace Syncfusion.DotNet.CLI.Core.Naming;

/// <summary>
/// The single source of truth for where new projects go by default and what they are called.
/// Windows: %USERPROFILE%\source\repos. macOS and Linux: ~/Projects. The working directory is never used.
/// </summary>
public static class ProjectDefaults
{
    public static string UserHome()
    {
        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        if (string.IsNullOrWhiteSpace(home)) home = Environment.GetEnvironmentVariable(OperatingSystem.IsWindows() ? "USERPROFILE" : "HOME");
        if (string.IsNullOrWhiteSpace(home))
            throw new IOException("Could not determine the user home directory. Pass --path to choose a project location.");
        return home;
    }

    public static string Location() => Location(UserHome(), OperatingSystem.IsWindows());

    public static string Location(string home, bool windows)
        => windows ? Path.Combine(home, "source", "repos") : Path.Combine(home, "Projects");

    public static string BaseName(Framework framework) => framework switch
    {
        Framework.WPF => "SyncfusionWpfApp",
        Framework.WinUI => "SyncfusionWinUIApp",
        Framework.WinForms => "SyncfusionWinFormsApp",
        Framework.Maui => "SyncfusionMauiApp",
        Framework.Blazor => "SyncfusionBlazorApp",
        _ => throw new ArgumentOutOfRangeException(nameof(framework), framework, "No default project name for this platform."),
    };

    /// <summary>The platform base name, or the first free <c>{base}1</c>, <c>{base}2</c>, ... under <paramref name="location"/>.</summary>
    public static string Name(Framework framework, string location) => Naming.ProjectNaming.ResolveAvailableName(BaseName(framework), location);
}
