namespace Syncfusion.DotNet.Cli.Core;

public sealed record DesktopPackage(string Alias, string DisplayName, string Id, bool HasTemplate = false)
{
    public string Description { get; init; } = "";
    public string Category { get; init; } = "Controls";
    public string Classification { get; init; } = "control";
    public string Status { get; init; } = "stable";
}
public sealed record DesktopTheme(string Name, string DisplayName, string? PackageId);
public sealed record DesktopNewRequest(Framework Platform, string Name, string Location, string Language,
    string TargetFramework, string Theme, IReadOnlyList<string> Controls, bool Restore = true, bool Build = true,
    bool DryRun = false, string? Version = null, string? Source = null, string? ConfigFile = null);

/// <summary>Desktop-specific capabilities and source generation, owned by each platform assembly.</summary>
public interface IDesktopPlatformProvider
{
    Framework Platform { get; }
    string DisplayName { get; }
    string? OfficialTemplate { get; }
    IReadOnlyList<string> Languages { get; }
    IReadOnlyList<string> TargetFrameworks { get; }
    IReadOnlyList<DesktopTheme> Themes { get; }
    IReadOnlyList<DesktopPackage> Packages { get; }
    string DefaultTheme { get; }
    IReadOnlyList<DesktopPackage> Controls => Packages.Where(package => package.HasTemplate).OrderBy(package => package.DisplayName, StringComparer.OrdinalIgnoreCase).ToArray();
    bool RequiresWindowsBuild(DesktopNewRequest request) => DesktopConfiguration.IsLegacy(request.TargetFramework);
    string PackageVersion(string packageId, string? requestedVersion) => requestedVersion ?? DesktopConfiguration.SyncfusionVersion;
    bool SupportsControlTemplates => false;
    IReadOnlyDictionary<string, byte[]> TemplateAssets(DesktopNewRequest request) => new Dictionary<string, byte[]>();
    IReadOnlyDictionary<string, string> Generate(DesktopNewRequest request);
    IReadOnlyList<string> RequiredPackages(DesktopNewRequest request);
}

public static class DesktopConfiguration
{
    public const string SyncfusionVersion = "35.1.40";
    public static bool IsLegacy(string framework) => framework is "net462" or "net47" or "net48";
    public static string ProjectExtension(string language) => language == "VB" ? ".vbproj" : ".csproj";
    public static string CanonicalLanguage(string language) => language.ToLowerInvariant() switch
    {
        "c#" or "csharp" or "cs" => "C#",
        "vb" or "visualbasic" => "VB",
        _ => language,
    };
    public static string? ValidateProjectName(string name) => Naming.ProjectNaming.ValidateIdentifier(name);

    public static string? Validate(IDesktopPlatformProvider provider, DesktopNewRequest request)
    {
        if (request.Build && !request.Restore) return "Desktop creation with build requires restore. Remove --no-restore or choose --post-action generate.";
        if (request.Platform != provider.Platform) return "The requested platform does not match its provider.";
        if (ValidateProjectName(request.Name) is { } nameError) return nameError;
        if (!provider.Languages.Contains(request.Language)) return $"{provider.DisplayName} supports: {string.Join(", ", provider.Languages)}.";
        if (!provider.TargetFrameworks.Contains(request.TargetFramework)) return $"Unsupported target framework '{request.TargetFramework}' for {provider.DisplayName}. Supported: {string.Join(", ", provider.TargetFrameworks)}.";
        if (!provider.Themes.Any(theme => theme.Name == request.Theme)) return $"Unsupported theme '{request.Theme}' for {provider.DisplayName}.";
        if (request.Controls.Any(control => !provider.Controls.Any(item => item.Alias == control))) return "Available controls: " + string.Join(", ", provider.Controls.Select(item => item.Alias)) + ".";
        if (request.Version is not null && !System.Text.RegularExpressions.Regex.IsMatch(request.Version, "^[0-9]+\\.[0-9]+\\.[0-9]+(?:[-+][A-Za-z0-9.-]+)?$"))
            return "Package version must be an explicit valid NuGet version.";
        return null;
    }
}
