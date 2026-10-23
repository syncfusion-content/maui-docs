using System.Text.RegularExpressions;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui.Manifest;
using Syncfusion.DotNet.CLI.Maui.Injection;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>Conservative source scan: ambiguous references are retained rather than deleted.</summary>
internal static class CustomDependencyInspector
{
    public static string? FindPackageUse(string root, string packageId, SyncfusionManifest? manifest,
        IReadOnlySet<string> excluded)
    {
        var names = TemplateCatalog.All.Where(entry => entry.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase))
            .SelectMany(entry => new[] { entry.CSharpNamespace, entry.ControlType }).Append(packageId).Distinct().ToArray();
        if (packageId.Equals("Syncfusion.Maui.Core", StringComparison.OrdinalIgnoreCase)) names = ["Syncfusion.Maui", "ConfigureSyncfusionCore"];
        return FindUse(root, manifest, excluded, names);
    }

    public static string? FindSampleUse(string root, ControlCatalogEntry entry, SyncfusionManifest manifest,
        IReadOnlySet<string> excluded)
        => FindUse(root, manifest, excluded, [MauiTemplateNames.ViewName(entry.ControlName), $"{entry.ControlName}ViewModel", $".{entry.ControlName}"]);

    private static string? FindUse(string root, SyncfusionManifest? manifest, IReadOnlySet<string> excluded, IReadOnlyList<string> names)
    {
        foreach (var path in SourceFiles(root))
        {
            var relative = Path.GetRelativePath(root, path).Replace('\\', '/');
            if (excluded.Contains(relative)) continue;
            if (manifest?.GeneratedFiles.Contains(relative, StringComparer.OrdinalIgnoreCase) == true
                && manifest.OriginalHashes.GetValueOrDefault(relative) == FileRollback.ComputeHash(path)) continue;
            var content = File.ReadAllText(path);
            foreach (var block in manifest?.GeneratedBlocks.Where(block => block.Path.Equals(relative, StringComparison.OrdinalIgnoreCase)) ?? [])
                if (GeneratedCodeBlocks.Conflict(root, block) is null) content = GeneratedCodeBlocks.Remove(content, block.Marker);
            if (names.Any(name => Regex.IsMatch(content, @"(?<![A-Za-z0-9_])" + Regex.Escape(name) + @"(?![A-Za-z0-9_])"))) return relative;
        }
        return null;
    }

    private static IEnumerable<string> SourceFiles(string directory)
    {
        foreach (var path in Directory.EnumerateFiles(directory))
        {
            if ((File.GetAttributes(path) & FileAttributes.ReparsePoint) != 0) continue;
            if (Path.GetExtension(path).ToLowerInvariant() is ".cs" or ".xaml" or ".razor" or ".resx") yield return path;
        }
        foreach (var child in Directory.EnumerateDirectories(directory))
        {
            if (Path.GetFileName(child) is "bin" or "obj" or ".git" or ".vs") continue;
            if ((File.GetAttributes(child) & FileAttributes.ReparsePoint) == 0)
                foreach (var path in SourceFiles(child)) yield return path;
        }
    }
}
