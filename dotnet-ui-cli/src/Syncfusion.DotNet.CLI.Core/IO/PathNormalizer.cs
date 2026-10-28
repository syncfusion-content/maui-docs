using System.IO;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>
/// Normalizes the <c>--path</c> value supplied to commands. Phase 2 only
/// normalizes the string; it does not inspect or search the filesystem.
/// </summary>
public static class PathNormalizer
{
    /// <summary>
    /// Resolves the supplied path. A null/empty value or "." returns the
    /// current directory; otherwise the value is normalized to a full path.
    /// </summary>
    public static string Normalize(string? path)
    {
        if (string.IsNullOrWhiteSpace(path) || path == ".")
        {
            return SafeCurrentDirectory();
        }

        try
        {
            return Path.GetFullPath(path);
        }
        catch (Exception ex) when (ex is UnauthorizedAccessException or IOException)
        {
            // Relative paths need the working directory, which may be unreadable.
            return Path.GetFullPath(path, SafeCurrentDirectory());
        }
    }

    /// <summary>
    /// Returns the working directory, falling back to the user's home directory
    /// when the OS denies access to it (e.g. a macOS-protected folder).
    /// </summary>
    public static string SafeCurrentDirectory()
    {
        try
        {
            return Environment.CurrentDirectory;
        }
        catch (Exception ex) when (ex is UnauthorizedAccessException or IOException or FileNotFoundException)
        {
            var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return string.IsNullOrEmpty(home) ? Path.GetTempPath() : home;
        }
    }

    /// <summary>Returns the display form for the equivalent command, quoting when needed.</summary>
    public static string ForDisplay(string normalizedPath)
    {
        return normalizedPath.Contains(' ')
            ? "\"" + normalizedPath + "\""
            : normalizedPath;
    }
}
