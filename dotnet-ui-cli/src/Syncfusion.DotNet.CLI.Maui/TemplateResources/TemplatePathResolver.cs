using System.IO;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// Resolves template destination paths and embedded resource names. Keeps a
/// single, normalized rule for combining the project root with the
/// per-control destination paths declared in the catalog, and for turning a
/// catalog <c>templatePath</c> + a relative template resource into a manifest
/// resource name. Rejects destination links that could write outside the owned project files.
/// </summary>
public static class TemplatePathResolver
{
    /// <summary>The common root for generated control folders.</summary>
    public const string ControlsRoot = "";

    /// <summary>
    /// Resolves a relative destination path (from the catalog) against the
    /// project root, normalizing separators to the platform default.
    /// </summary>
    public static string ResolveDestination(string projectRoot, string relativeDestination)
    {
        var relative = NormalizeRelative(relativeDestination);
        ValidateRelativePath(relativeDestination);
        var root = Path.GetFullPath(projectRoot);
        var destination = Path.GetFullPath(Path.Combine(root, relative));
        var relativeToRoot = Path.GetRelativePath(root, destination);
        if (Path.IsPathRooted(relativeToRoot)
            || relativeToRoot.Equals("..", StringComparison.Ordinal)
            || relativeToRoot.StartsWith(".." + Path.DirectorySeparatorChar, StringComparison.Ordinal))
        {
            throw new InvalidOperationException($"Template destination '{relativeDestination}' escapes the project directory.");
        }

        for (var current = destination; !current.Equals(root, StringComparison.Ordinal); current = Path.GetDirectoryName(current)!)
        {
            if ((File.Exists(current) || Directory.Exists(current))
                && (File.GetAttributes(current) & FileAttributes.ReparsePoint) != 0)
                throw new InvalidOperationException($"Generated destination '{relativeDestination}' contains a symbolic link. No changes can be made safely.");
        }
        return destination;
    }

    /// <summary>The default-namespace prefix for embedded template resources.</summary>
    public const string ResourcePrefix = "Syncfusion.DotNet.CLI.Maui.";

    /// <summary>
    /// Builds the manifest resource name for an embedded template resource.
    /// Template resources are embedded under
    /// <c>Syncfusion.DotNet.CLI.Maui.Templates.Controls.&lt;Folder&gt;.&lt;file&gt;</c>.
    /// </summary>
    public static string ResolveResourceName(string templatePath, string templateResource)
    {
        var folder = NormalizeRelative(templatePath).Replace('/', '.').Replace('\\', '.');
        var file = NormalizeRelative(templateResource).Replace('/', '.').Replace('\\', '.');
        return $"{ResourcePrefix}{folder}.{file}";
    }

    /// <summary>Normalizes a relative path to forward slashes then trims leading separators.</summary>
    public static string NormalizeRelative(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            return string.Empty;
        }

        return path.Replace('\\', '/');
    }

    /// <summary>Rejects absolute, drive-qualified, empty, or traversing template paths.</summary>
    public static void ValidateRelativePath(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new InvalidOperationException("Template paths must not be empty.");
        }

        var normalized = path.Replace('\\', '/');
        if (Path.IsPathRooted(path)
            || normalized.StartsWith("/", StringComparison.Ordinal)
            || (normalized.Length >= 2 && char.IsLetter(normalized[0]) && normalized[1] == ':')
            || normalized.Split('/').Any(segment => segment is "" or "." or ".."))
        {
            throw new InvalidOperationException($"Template path '{path}' must be a safe relative path.");
        }
    }
}
