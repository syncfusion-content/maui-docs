using System.Text.Json;
using System.Xml.Linq;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>Changes owned samples and navigation while preserving unrelated and edited files.</summary>
internal sealed class DesktopControlLifecycle
{
    private readonly string _root;
    private readonly string _project;
    private readonly string _manifestPath;
    private readonly DesktopManifest _manifest;
    private readonly DesktopNewRequest _request;
    private readonly IDesktopPlatformProvider _provider;
    private readonly Dictionary<string, byte[]?> _changes = [];
    private readonly IReadOnlyDictionary<string, string> _sources;
    private readonly IReadOnlyDictionary<string, byte[]> _assets;

    internal DesktopControlLifecycle(IDesktopPlatformProvider provider, string project, DesktopManifest manifest, string action, string alias)
    {
        _provider = provider;
        _project = project;
        _root = Path.GetDirectoryName(project)!;
        _manifestPath = Path.Combine(_root, DesktopProjectService.ManifestName);
        _manifest = manifest;
        var xml = XDocument.Load(project);
        string? Value(string name) => xml.Descendants().FirstOrDefault(e => e.Name.LocalName == name)?.Value;
        var name = Value("RootNamespace");
        if (string.IsNullOrWhiteSpace(name)) name = Path.GetFileNameWithoutExtension(project);
        var framework = Value("TargetFramework")?.Split('-')[0] ?? "net" + Value("TargetFrameworkVersion")?.TrimStart('v').Replace(".", "", StringComparison.Ordinal);
        var oldRequest = new DesktopNewRequest(provider.Platform, name, Path.GetDirectoryName(_root)!, project.EndsWith(".vbproj", StringComparison.OrdinalIgnoreCase) ? "VB" : "C#", framework,
            manifest.Theme, manifest.Controls, false, false);
        if (manifest.RequiredPackages.Any(id => !provider.RequiredPackages(oldRequest).Contains(id, StringComparer.OrdinalIgnoreCase)))
            throw new InvalidOperationException("Desktop manifest dependencies do not match its controls/theme. No changes made.");
        var controls = manifest.Controls.ToHashSet(StringComparer.OrdinalIgnoreCase);
        if (action == "add") controls.Add(alias);
        else if (action == "remove") controls.Remove(alias);
        _request = oldRequest with { Controls = controls.Order().ToArray() };
        var oldSources = provider.Generate(oldRequest);
        var oldAssets = provider.TemplateAssets(oldRequest);
        _sources = provider.Generate(_request);
        _assets = provider.TemplateAssets(_request);
        var oldFiles = oldSources.Where(pair => !pair.Key.EndsWith("proj", StringComparison.Ordinal)).ToDictionary(pair => pair.Key, pair => System.Text.Encoding.UTF8.GetBytes(pair.Value));
        foreach (var pair in oldAssets) oldFiles[pair.Key] = pair.Value;
        var newFiles = _sources.Where(pair => !pair.Key.EndsWith("proj", StringComparison.Ordinal)).ToDictionary(pair => pair.Key, pair => System.Text.Encoding.UTF8.GetBytes(pair.Value));
        foreach (var pair in _assets) newFiles[pair.Key] = pair.Value;
        if (action == "remove")
        {
            var removedFolders = oldFiles.Keys.Except(newFiles.Keys).Where(file => file.Contains('/')).Select(file => file.Split('/')[0]).Distinct();
            foreach (var folder in removedFolders)
            {
                var directory = SafePath(folder);
                if (!Directory.Exists(directory)) continue;
                foreach (var file in Directory.GetFiles(directory, "*", new EnumerationOptions { RecurseSubdirectories = true, AttributesToSkip = FileAttributes.ReparsePoint }).Where(file => Path.GetExtension(file) is ".cs" or ".vb" or ".xaml" or ".resx"))
                {
                    var relative = Path.GetRelativePath(_root, file).Replace('\\', '/');
                    if (!manifest.OriginalHashes.ContainsKey(relative))
                        throw new InvalidOperationException($"Control folder '{folder}' contains user-owned source '{relative}'. No changes made.");
                }
            }
        }
        foreach (var file in oldFiles.Keys.Union(newFiles.Keys))
        {
            var path = SafePath(file);
            oldFiles.TryGetValue(file, out var oldContent);
            newFiles.TryGetValue(file, out var content);
            if (content is not null && oldContent is not null && content.SequenceEqual(oldContent) && File.Exists(path))
            {
                var sharedHost = !file.Contains('/') || file.StartsWith("Welcome/", StringComparison.Ordinal);
                var desiredHash = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(content));
                if (!sharedHost || !manifest.OriginalHashes.TryGetValue(file, out var original) || original.Equals(desiredHash, StringComparison.OrdinalIgnoreCase)) continue;
                // Upgrade an untouched earlier CLI host when control registration changes.
                if (FileRollback.ComputeHash(path) != original)
                    throw new InvalidOperationException($"Generated host '{file}' has been edited. No changes made.");
            }
            if (content is null && !File.Exists(path)) continue;
            if (File.Exists(path))
            {
                if (!manifest.OriginalHashes.TryGetValue(file, out var hash) || FileRollback.ComputeHash(path) != hash)
                    throw new InvalidOperationException($"Generated file '{file}' has been edited or is not owned by sf. No changes made.");
            }
            else if (manifest.OriginalHashes.ContainsKey(file) && content is not null && oldContent is not null && !content.SequenceEqual(oldContent))
                throw new InvalidOperationException($"Generated file '{file}' is missing. Restore it before changing controls. No changes made.");
            _changes[file] = content;
        }
    }

    internal IReadOnlyList<string> Dependencies => _provider.RequiredPackages(_request);

    internal void Apply(FileRollback rollback)
    {
        rollback.TrackModified(_manifestPath);
        foreach (var (relative, content) in _changes)
        {
            var path = SafePath(relative);
            if (File.Exists(path)) rollback.TrackModified(path); else rollback.TrackCreated(path);
            if (content is null) File.Delete(path);
            else
            {
                rollback.TrackCreatedDirectories(Path.GetDirectoryName(path)!, _root);
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllBytes(path, content);
            }
            if (content is null) _manifest.OriginalHashes.Remove(relative);
            else _manifest.OriginalHashes[relative] = FileRollback.ComputeHash(path)!;
        }
        // Keep the existing project and its user/package settings; change only managed items.
        var xml = XDocument.Load(_project);
        var ns = xml.Root!.Name.Namespace;
        var legacy = xml.Descendants().Any(e => e.Name.LocalName == "TargetFrameworkVersion");
        var generated = XDocument.Parse(_sources.Values.First(value => value.TrimStart().StartsWith("<Project", StringComparison.Ordinal)));
        foreach (var relative in _changes.Keys)
        {
            var itemNames = new[] { "Page", "Compile", "Content", "Resource" };
            var items = xml.Descendants().Where(e => itemNames.Contains(e.Name.LocalName) && ((string?)e.Attribute("Include") ?? (string?)e.Attribute("Update")) == relative).ToArray();
            if (_changes[relative] is null) { foreach (var item in items) item.Remove(); continue; }
            if (items.Length != 0) continue;
            var itemTemplate = generated.Descendants().FirstOrDefault(e => itemNames.Contains(e.Name.LocalName) && ((string?)e.Attribute("Include") ?? (string?)e.Attribute("Update")) == relative);
            if (itemTemplate is not null)
            {
                var item = new XElement(itemTemplate);
                foreach (var element in item.DescendantsAndSelf()) element.Name = ns + element.Name.LocalName;
                xml.Root.Add(new XElement(ns + "ItemGroup", item));
            }
            else if (legacy)
                xml.Root.Add(new XElement(ns + "ItemGroup", new XElement(ns + (relative.EndsWith(".xaml", StringComparison.Ordinal) ? "Page" : "Compile"), new XAttribute("Include", relative))));
        }
        xml.Save(_project);
        _manifest.Controls = _request.Controls.ToList();
        _manifest.RequiredPackages = Dependencies.ToList();
        _manifest.OriginalHashes[Path.GetFileName(_project)] = FileRollback.ComputeHash(_project)!;
        File.WriteAllText(_manifestPath, JsonSerializer.Serialize(_manifest, new JsonSerializerOptions { WriteIndented = true }));
    }

    private string SafePath(string relative)
    {
        if (Path.IsPathRooted(relative) || relative.Split('/', '\\').Any(part => part is ".." or ".")) throw new InvalidOperationException("Invalid managed template path.");
        var path = Path.Combine(_root, relative);
        for (var current = path; current != _root; current = Path.GetDirectoryName(current)!)
            if ((File.Exists(current) || Directory.Exists(current)) && (File.GetAttributes(current) & FileAttributes.ReparsePoint) != 0)
                throw new InvalidOperationException($"Managed template path '{relative}' contains a symbolic link. No changes made.");
        return path;
    }
}
