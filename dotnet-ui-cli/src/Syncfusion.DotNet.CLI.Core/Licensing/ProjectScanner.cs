using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Syncfusion.DotNet.CLI.Core.Licensing;

public sealed record ProjectScan(string ProjectFile, string Platform, int Major, IReadOnlyList<string> Products)
{
    public string ProjectDirectory => Path.GetDirectoryName(ProjectFile)!;
}

/// <summary>Detects the platform, major version and Syncfusion packages of a .NET project.</summary>
public static class ProjectScanner
{
    public static ProjectScan Scan(string pathOrDirectory)
    {
        var file = ResolveProjectFile(pathOrDirectory);
        var doc = XDocument.Load(file);
        var central = CentralVersions(Path.GetDirectoryName(file)!);
        var refs = doc.Descendants("PackageReference")
            .Select(e => (Id: (string?)e.Attribute("Include") ?? "", Version: (string?)e.Attribute("Version") ?? e.Element("Version")?.Value))
            .Where(r => r.Id.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase) && !r.Id.StartsWith("Syncfusion.Licensing", StringComparison.OrdinalIgnoreCase))
            .Select(r => (r.Id, Version: r.Version ?? (central.TryGetValue(r.Id, out var v) ? v : null)))
            .ToList();
        if (refs.Count == 0)
            throw new LicenseException(LicenseExitCodes.NoSyncfusionPackages, $"No Syncfusion packages detected in {Path.GetFileName(file)}.");

        var platforms = refs.Select(r => PlatformOf(r.Id)).Where(p => p is not null).Distinct().ToList();
        if (platforms.Count == 0 && PlatformFromProject(doc) is { } fromProject) platforms.Add(fromProject);
        if (platforms.Count > 1)
            throw new LicenseException(LicenseExitCodes.AmbiguousProject, $"Multiple platforms detected: {string.Join(", ", platforms)}. Run from a single-platform project.");
        var platform = platforms.Count == 1 ? platforms[0]! : ".NET";

        var majors = refs.Select(r => MajorOf(r.Version)).Distinct().ToList();
        if (majors.Count > 1)
            throw new LicenseException(LicenseExitCodes.AmbiguousProject, "Mixed major versions detected across Syncfusion packages. Maintain all Syncfusion packages to the same major version.");
        return new ProjectScan(file, platform, majors[0], refs.Select(r => r.Id).Distinct(StringComparer.OrdinalIgnoreCase).ToList());
    }

    internal static string? PlatformOf(string id)
    {
        if (id.Contains(".Maui", StringComparison.OrdinalIgnoreCase)) return "MAUI";
        if (id.Contains("Blazor", StringComparison.OrdinalIgnoreCase)) return "Blazor";
        if (id.EndsWith(".WPF", StringComparison.OrdinalIgnoreCase)) return "WPF";
        if (id.EndsWith(".WinForms", StringComparison.OrdinalIgnoreCase)) return "WinForms";
        if (id.EndsWith(".WinUI", StringComparison.OrdinalIgnoreCase)) return "WinUI";
        return null;
    }

    private static string? PlatformFromProject(XDocument doc)
    {
        bool Flag(string name) => doc.Descendants(name).Any(e => e.Value.Trim().Equals("true", StringComparison.OrdinalIgnoreCase));
        if (Flag("UseMaui")) return "MAUI";
        if (Flag("UseWPF")) return "WPF";
        if (Flag("UseWindowsForms")) return "WinForms";
        if (Flag("UseWinUI") || Flag("EnableMsixTooling")) return "WinUI";
        var sdk = (string?)doc.Root?.Attribute("Sdk") ?? "";
        return sdk.Contains("Web", StringComparison.OrdinalIgnoreCase) ? "Blazor" : null;
    }

    internal static int MajorOf(string? version)
    {
        var match = Regex.Match(version ?? "", @"^[\[\(]?\s*(\d+)");
        if (!match.Success) throw new LicenseException(LicenseExitCodes.AmbiguousProject, "Cannot resolve the Syncfusion version from a '*' or missing version. Pin an explicit version.");
        return int.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
    }

    private static string ResolveProjectFile(string path)
    {
        if (File.Exists(path)) return Path.GetFullPath(path);
        var projects = Directory.Exists(path)
            ? Directory.GetFiles(path).Where(f => f.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase) || f.EndsWith(".vbproj", StringComparison.OrdinalIgnoreCase)).ToArray()
            : [];
        return projects.Length switch
        {
            1 => Path.GetFullPath(projects[0]),
            0 => throw new LicenseException(LicenseExitCodes.NoSyncfusionPackages, "No .csproj/.vbproj found. Run from a project folder or pass --path."),
            _ => throw new LicenseException(LicenseExitCodes.AmbiguousProject, "Multiple project files found. Pass --path to select one."),
        };
    }

    private static Dictionary<string, string> CentralVersions(string dir)
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        for (var d = new DirectoryInfo(dir); d is not null; d = d.Parent)
        {
            var file = Path.Combine(d.FullName, "Directory.Packages.props");
            if (!File.Exists(file)) continue;
            foreach (var e in XDocument.Load(file).Descendants("PackageVersion"))
                if ((string?)e.Attribute("Include") is { } id && (string?)e.Attribute("Version") is { } v) result[id] = v;
            break;
        }

        return result;
    }
}
