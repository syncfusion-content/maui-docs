using System.Text;
using System.Text.Json;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui.Manifest;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>Native welcome UI and a compile-time registry containing exactly the installed sample pages.</summary>
public static class WelcomeProjectGenerator
{
    public const string RegistryPath = "Welcome/ControlRegistry.cs";
    public const string ManifestPath = "Syncfusion/syncfusion.json";
    public static IReadOnlyDictionary<string, string> TemplateFiles { get; } = new Dictionary<string, string>
    {
        ["Welcome/WelcomeView.xaml"] = "WelcomeView.xaml",
        ["Welcome/WelcomeView.xaml.cs"] = "WelcomeView.xaml.cs",
        ["Welcome/WelcomeModel.cs"] = "WelcomeModel.cs",
        ["Welcome/WelcomeViewModel.cs"] = "WelcomeViewModel.cs",
        ["Welcome/WelcomeResourceGrid.cs"] = "WelcomeResourceGrid.cs",
        ["Resources/Images/sf_welcome_demos.svg"] = "sf_welcome_demos.svg",
        ["Resources/Images/sf_welcome_docs.svg"] = "sf_welcome_docs.svg",
        ["Resources/Images/sf_welcome_ai.svg"] = "sf_welcome_ai.svg",
        ["Resources/Images/sf_welcome_controls.svg"] = "sf_welcome_controls.svg",
    };

    /// <summary>Called only for a freshly created native MAUI app, never for an existing user page.</summary>
    public static void Install(string root, string rootNamespace, FileRollback rollback)
    {
        var manifest = ReadManifest(root) ?? new SyncfusionManifest { CliVersion = CliMetadata.Version, Framework = "maui", ProjectType = "app" };
        manifest.SchemaVersion = 2;
        var project = MauiProjectResolver.Resolve(root);
        manifest.ProjectFile = Path.GetFileName(project.CsprojPath);
        manifest.TargetFramework = string.Join(';', project.TargetFrameworks);
        foreach (var (destination, template) in TemplateFiles)
        {
            var resource = TemplatePathResolver.ResourcePrefix + "Templates.Welcome." + template;
            var content = EmbeddedResourceLoader.ReadText(resource).Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal);
            if (destination == "Welcome/WelcomeView.xaml" && manifest.TargetFramework.Split(';').Any(target => target.StartsWith("net9.0", StringComparison.OrdinalIgnoreCase)))
                content = content.Replace("SafeAreaEdges=\"All\"",
                    "xmlns:ios=\"clr-namespace:Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;assembly=Microsoft.Maui.Controls\" ios:Page.UseSafeArea=\"True\"",
                    StringComparison.Ordinal);
            WriteTracked(root, destination, content, rollback, manifest);
            manifest.WelcomeFiles.Add(destination);
        }
        // Replace the SDK starter page reference with the named Welcome template.
        var shellPath = TemplatePathResolver.ResolveDestination(root, "AppShell.xaml");
        if (File.Exists(shellPath))
        {
            var shell = File.ReadAllText(shellPath).Replace("local:MainPage", "welcome:WelcomeView", StringComparison.Ordinal)
                .Replace("xmlns:local=", $"xmlns:welcome=\"clr-namespace:{rootNamespace}.Welcome\"\n    xmlns:local=", StringComparison.Ordinal);
            WriteTracked(root, "AppShell.xaml", shell, rollback, manifest);
            manifest.ModifiedFiles.Add("AppShell.xaml");
        }
        foreach (var starter in new[] { "MainPage.xaml", "MainPage.xaml.cs" })
        {
            var path = TemplatePathResolver.ResolveDestination(root, starter);
            rollback.TrackModified(path);
            if (File.Exists(path)) File.Delete(path);
        }
        WriteRegistry(root, rootNamespace, [], rollback, manifest);
        manifest.WelcomeFiles.Add(RegistryPath);
        SaveManifest(root, manifest, rollback);
    }

    public static SyncfusionManifest? ReadManifest(string root, ProjectDetector.ProjectInfo? project = null)
    {
        var path = TemplatePathResolver.ResolveDestination(root, ManifestPath);
        var manifest = File.Exists(path) ? SyncfusionManifest.FromJson(File.ReadAllText(path)) : null;
        if (project is not null && !string.IsNullOrWhiteSpace(manifest?.ProjectFile)
            && !manifest.ProjectFile.Equals(Path.GetFileName(project.CsprojPath), StringComparison.OrdinalIgnoreCase)) return null;
        if (project is not null && manifest is not null && manifest.ProjectFile.Length == 0
            && Directory.EnumerateFiles(root, "*.csproj", SearchOption.TopDirectoryOnly).Skip(1).Any())
            return null; // Older directory-wide metadata cannot prove which project owns the scaffolding.
        if (manifest is not null) ProjectControlState.Reconstruct(root, manifest, project);
        return manifest;
    }

    public static string? RegistryConflict(string root, SyncfusionManifest? manifest)
    {
        var path = TemplatePathResolver.ResolveDestination(root, RegistryPath);
        if (!File.Exists(path)) return null; // Recreated from verified manifest records.
        return manifest?.GeneratedFiles.Contains(RegistryPath, StringComparer.OrdinalIgnoreCase) == true
            && manifest.OriginalHashes.GetValueOrDefault(RegistryPath) == FileRollback.ComputeHash(path)
                ? null : $"Control registry '{RegistryPath}' is untracked or has been edited. No changes made.";
    }

    public static void WriteRegistry(string root, string rootNamespace, IEnumerable<ControlCatalogEntry> entries,
        FileRollback rollback, SyncfusionManifest manifest)
    {
        if (RegistryConflict(root, manifest) is { } conflict) throw new InvalidOperationException(conflict);
        WriteTracked(root, RegistryPath, RegistryContent(rootNamespace, entries), rollback, manifest);
    }

    public static string RegistryContent(string rootNamespace, IEnumerable<ControlCatalogEntry> entries)
    {
        var text = new StringBuilder($"// Generated by sf. Control changes are managed through sf add/remove.\nnamespace {rootNamespace}.Welcome;\n\npublic sealed record ControlSample(string Id, string Name, Func<ContentPage> CreatePage);\n\npublic static class ControlRegistry\n{{\n    public static IReadOnlyList<ControlSample> All {{ get; }} =\n    [\n");
        foreach (var entry in MauiControlSelectionProvider.OrderControls(entries.DistinctBy(entry => entry.Id)))
        {
            text.AppendLine($"        new({JsonSerializer.Serialize(entry.Id)}, {JsonSerializer.Serialize(entry.DisplayName)}, () => new global::{rootNamespace}.{entry.ControlName}.{MauiTemplateNames.ViewName(entry.ControlName)}()),");
        }
        text.Append("    ];\n}\n");
        return text.ToString();
    }

    public static void SaveManifest(string root, SyncfusionManifest manifest, FileRollback rollback)
    {
        manifest.SchemaVersion = 2;
        var path = TemplatePathResolver.ResolveDestination(root, ManifestPath);
        rollback.TrackModified(path);
        rollback.TrackCreatedDirectories(Path.GetDirectoryName(path)!, root);
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        File.WriteAllText(path, manifest.ToJson());
    }

    private static void WriteTracked(string root, string destination, string content, FileRollback rollback, SyncfusionManifest manifest)
    {
        var path = TemplatePathResolver.ResolveDestination(root, destination);
        rollback.TrackModified(path);
        rollback.TrackCreatedDirectories(Path.GetDirectoryName(path)!, root);
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        File.WriteAllText(path, content);
        if (!manifest.GeneratedFiles.Contains(destination, StringComparer.OrdinalIgnoreCase)) manifest.GeneratedFiles.Add(destination);
        manifest.OriginalHashes[destination] = FileRollback.ComputeHash(path)!;
    }
}
