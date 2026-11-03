using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Wizard;

/// <summary>Default location and directory safeguards for project creation.</summary>
internal static class ProjectCreationDirectory
{
    internal static string DefaultParent() => Core.Naming.ProjectDefaults.Location();

    internal static string DefaultParent(string profile, bool windows) => Core.Naming.ProjectDefaults.Location(profile, windows);

    internal static string Prepare(string value)
    {
        var path = PathNormalizer.Normalize(value);
        if (IsProtected(path))
            throw new UnauthorizedAccessException($"Project location '{path}' is a protected system directory. Choose a different project location.");
        Directory.CreateDirectory(path);
        return path;
    }

    internal static bool IsProtected(string path)
    {
        path = ResolveLinks(Path.GetFullPath(path));
        var root = Path.GetPathRoot(path)!;
        if (Path.TrimEndingDirectorySeparator(path).Equals(Path.TrimEndingDirectorySeparator(root),
            OperatingSystem.IsWindows() ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal)) return true;
        var protectedRoots = OperatingSystem.IsWindows()
            ? new[]
            {
                Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                Environment.GetFolderPath(Environment.SpecialFolder.System),
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                Path.Combine(root, "Windows"), Path.Combine(root, "Program Files"),
                Path.Combine(root, "Program Files (x86)"), Path.Combine(root, "ProgramData"),
            }
            : new[] { "/bin", "/sbin", "/usr", "/etc", "/var", "/lib", "/lib64", "/boot", "/dev", "/proc", "/sys", "/System", "/Library", "/Applications", "/private/etc", "/private/var" };
        return protectedRoots.Where(folder => !string.IsNullOrWhiteSpace(folder))
            .Any(folder => IsWithin(path, ResolveLinks(folder), OperatingSystem.IsWindows()));
    }

    internal static bool IsWithin(string path, string folder, bool windows)
    {
        var comparison = windows ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
        folder = Path.TrimEndingDirectorySeparator(folder);
        return path.Equals(folder, comparison) || path.StartsWith(folder + Path.DirectorySeparatorChar, comparison);
    }

    private static string ResolveLinks(string path)
    {
        var resolved = Path.GetPathRoot(path)!;
        foreach (var segment in path[resolved.Length..].Split(Path.DirectorySeparatorChar, StringSplitOptions.RemoveEmptyEntries))
        {
            resolved = Path.Combine(resolved, segment);
            var directory = new DirectoryInfo(resolved);
            if (directory.LinkTarget is not null)
                resolved = directory.ResolveLinkTarget(returnFinalTarget: true)?.FullName
                    ?? throw new IOException($"Could not resolve project location link '{resolved}'.");
        }
        return resolved;
    }
}
