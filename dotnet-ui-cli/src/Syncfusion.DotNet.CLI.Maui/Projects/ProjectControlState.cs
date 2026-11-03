using System.Text;
using System.Security.Cryptography;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui.Injection;
using Syncfusion.DotNet.Cli.Maui.Manifest;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Reconstructs older ownership records in memory, without claiming customer files.</summary>
public static class ProjectControlState
{
    public static bool IsManaged(SyncfusionManifest? manifest)
        => manifest is not null && (manifest.WelcomeFiles.Count > 0 || manifest.InstalledControls.Count > 0
            || manifest.Framework == "maui" && !string.IsNullOrWhiteSpace(manifest.CliVersion));

    public static bool HasWelcome(SyncfusionManifest? manifest)
        => manifest?.WelcomeFiles.Any(path => path.Equals("Welcome/WelcomeView.xaml", StringComparison.OrdinalIgnoreCase)
            || path.Equals("MainPage.xaml", StringComparison.OrdinalIgnoreCase)) == true;

    public static bool HasLegacyNavigation(SyncfusionManifest? manifest)
        => manifest is not null && !HasWelcome(manifest)
            && !manifest.GeneratedBlocks.Any(block => block.Marker == "hybrid-binding")
            && (manifest.GeneratedBlocks.Any(block => block.Marker.StartsWith("sf-nav:", StringComparison.Ordinal))
                || manifest.ModifiedFiles.Contains("MainPage.xaml", StringComparer.OrdinalIgnoreCase)
                    && manifest.ModifiedFiles.Contains("MainPage.xaml.cs", StringComparer.OrdinalIgnoreCase));

    public static void Reconstruct(string root, SyncfusionManifest manifest, ProjectDetector.ProjectInfo? project = null)
    {
        if (manifest.SchemaVersion != 1) return;
        project ??= MauiProjectResolver.Resolve(root);
        var projectName = Path.GetFileNameWithoutExtension(project.CsprojPath);
        var rootNamespace = PlaceholderReplacer.NormalizeRootNamespace(project.RootNamespace ?? projectName);
        var entries = manifest.InstalledControls.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry) ? entry : null)
            .Where(entry => entry is not null).Cast<ControlCatalogEntry>().DistinctBy(entry => entry.Id).ToList();
        foreach (var entry in entries)
        {
            // A legacy path record plus an exact shipped template is evidence
            // for a missing hash. Edited/untracked files remain unowned.
            var values = PlaceholderReplacer.BuildValues(projectName, rootNamespace, entry.ControlName, MauiTemplateNames.ViewName(entry.ControlName));
            foreach (var file in entry.GeneratedFiles)
            {
                var path = TemplatePathResolver.ResolveDestination(root, file.Destination);
                if (!manifest.GeneratedFiles.Contains(file.Destination) || !File.Exists(path)
                    || manifest.OriginalHashes.ContainsKey(file.Destination)) continue;
                if (EmbeddedResourceLoader.IsBinaryFile(file.Destination))
                {
                    // Binary resources are owned verbatim; hash the file bytes.
                    if (EmbeddedResourceLoader.ReadBytes(TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource))
                        .SequenceEqual(File.ReadAllBytes(path)))
                        manifest.OriginalHashes[file.Destination] = FileRollback.ComputeHash(path)!;
                    continue;
                }
                var expected = PlaceholderReplacer.Replace(EmbeddedResourceLoader.ReadText(
                    TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource)), values);
                if (File.ReadAllText(path) == expected) manifest.OriginalHashes[file.Destination] = FileRollback.ComputeHash(path)!;
            }
            if (!manifest.InstalledTemplates.Any(record => record.Id == entry.Id))
                manifest.InstalledTemplates.Add(new InstalledTemplateRecord
                {
                    Id = entry.Id, Family = entry.Family, PackageId = entry.PackageId,
                    GeneratedFiles = entry.GeneratedFiles.Select(file => file.Destination).ToList(),
                    PackageReferenceOwned = manifest.PackageIds.Contains(entry.PackageId),
                    ResolvedVersion = manifest.PackageVersions.GetValueOrDefault(entry.PackageId, ""),
                    TargetFrameworks = project.TargetFrameworks.ToList(),
                });
        }
        manifest.InstalledControls = manifest.InstalledControls.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry) ? entry.Id : id)
            .Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        foreach (var path in manifest.ModifiedFiles)
        {
            var absolute = TemplatePathResolver.ResolveDestination(root, path);
            if (manifest.OriginalHashes.GetValueOrDefault(path) != FileRollback.ComputeHash(absolute) || !File.Exists(absolute)) continue;
            foreach (var block in GeneratedCodeBlocks.CaptureNew(path, "", File.ReadAllText(absolute)))
                if (!manifest.GeneratedBlocks.Any(other => other.Path == path && other.Marker == block.Marker)) manifest.GeneratedBlocks.Add(block);
        }
        foreach (var entry in entries)
        {
            if (entry.GeneratedFiles.All(file => manifest.GeneratedFiles.Contains(file.Destination)
                && manifest.OriginalHashes.GetValueOrDefault(file.Destination) is { } hash
                && hash == FileRollback.ComputeHash(TemplatePathResolver.ResolveDestination(root, file.Destination))))
            {
                var legacyBlocks = new List<GeneratedBlockRecord>();
                foreach (var file in new[] { "MainPage.xaml", "MainPage.xaml.cs" })
                {
                    var path = TemplatePathResolver.ResolveDestination(root, file);
                    if (!File.Exists(path)) continue;
                    var expected = file.EndsWith(".cs")
                        ? $"private async void OnOpen{entry.ControlName}Clicked(object? sender, EventArgs e) => await Navigation.PushAsync(new global::{rootNamespace}.{entry.ControlName}.{MauiTemplateNames.ViewName(entry.ControlName)}()); // sf-nav:{entry.ControlName}"
                        : $"<Button Text=\"{System.Security.SecurityElement.Escape(entry.DisplayName)}\" Clicked=\"OnOpen{entry.ControlName}Clicked\" HorizontalOptions=\"Fill\" /> <!-- sf-nav:{entry.ControlName} -->";
                    if (GeneratedCodeBlocks.ReconstructLegacyNavigation(file, File.ReadAllText(path), entry.ControlName, expected) is { } block)
                        legacyBlocks.Add(block);
                }
                if (legacyBlocks.Count == 2)
                    foreach (var block in legacyBlocks)
                        if (!manifest.GeneratedBlocks.Any(other => other.Path == block.Path && other.Marker == block.Marker)) manifest.GeneratedBlocks.Add(block);
            }
            var record = manifest.InstalledTemplates.Single(record => record.Id == entry.Id);
            record.PackageDependencies = entry.DependentPackageIds.Prepend(entry.PackageId)
                .Concat(entry.RegistrationRequirement == "syncfusion-core" ? ["Syncfusion.Maui.Core"] : Array.Empty<string>()).ToList();
            record.CodeBlocks = manifest.GeneratedBlocks.Where(block => block.Marker == "sf-nav:" + entry.ControlName
                || entry.RegistrationRequirement == "syncfusion-core" && block.Marker.StartsWith("core-"))
                .Select(block => block.Path + "#" + block.Marker).ToList();
            record.NavigationEntries = HasWelcome(manifest) ? [WelcomeProjectGenerator.RegistryPath + "#" + entry.Id]
                : record.CodeBlocks.Where(block => block.Contains("#sf-nav:")).ToList();
            record.WelcomeEntry = HasWelcome(manifest) ? entry.Id : null;
        }
        // Persist only inside the successful operation's rollback boundary.
    }

    public static string HashContent(string content)
        => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(content))).ToLowerInvariant();
}
