using System.Xml.Linq;

namespace Syncfusion.DotNet.Cli.Core;

/// <summary>Apply generated dependencies without disabling inherited central package management.</summary>
internal static class DesktopPackageReferences
{
    internal static async Task AddAsync(string project, IReadOnlyDictionary<string, string> packages,
        ToolRunner tools, FileRollback rollback, CancellationToken token, bool explicitVersion = false)
    {
        var xml = XDocument.Load(project);
        var ns = xml.Root!.Name.Namespace;
        var root = Path.GetDirectoryName(project)!;
        string? centralPath = null;
        var hasPackageConfiguration = false;
        for (var directory = root; directory is not null; directory = Path.GetDirectoryName(directory))
        {
            hasPackageConfiguration |= File.Exists(Path.Combine(directory, "Directory.Build.props"));
            var candidate = Path.Combine(directory, "Directory.Packages.props");
            if (File.Exists(candidate) && centralPath is null) centralPath = candidate;
        }
        var central = false;
        if (hasPackageConfiguration || centralPath is not null)
        {
            var evaluation = await tools.RunAsync(["msbuild", project, "-nologo", "-getProperty:ManagePackageVersionsCentrally"], root, token).ConfigureAwait(false);
            DesktopProjectService.RequireSuccess(evaluation, "evaluating central package management");
            central = evaluation.Output.Trim().Equals("true", StringComparison.OrdinalIgnoreCase);
        }
        XDocument? centralXml = null;
        if (central)
        {
            centralPath ??= Path.Combine(root, "Directory.Packages.props");
            if (File.Exists(centralPath) && (File.GetAttributes(centralPath) & FileAttributes.ReparsePoint) != 0)
                throw new InvalidOperationException("Central package configuration is a symbolic link. No changes made.");
            rollback.TrackModified(centralPath);
            centralXml = File.Exists(centralPath) ? XDocument.Load(centralPath) : new XDocument(new XElement("Project"));
        }
        var group = new XElement(ns + "ItemGroup");
        foreach (var (id, version) in packages)
        {
            var currentReference = xml.Descendants().FirstOrDefault(element => element.Name.LocalName == "PackageReference" && string.Equals((string?)element.Attribute("Include"), id, StringComparison.OrdinalIgnoreCase));
            if (currentReference is not null)
            {
                if (central)
                {
                    var entry = centralXml!.Descendants().FirstOrDefault(element => element.Name.LocalName == "PackageVersion" && string.Equals((string?)element.Attribute("Include") ?? (string?)element.Attribute("Update"), id, StringComparison.OrdinalIgnoreCase));
                    if (entry is null) centralXml.Root!.Add(new XElement("ItemGroup", new XElement("PackageVersion", new XAttribute("Include", id), new XAttribute("Version", version))));
                    else if (explicitVersion && (string?)entry.Attribute("Version") != version) throw new InvalidOperationException($"Central version for {id} differs from requested version {version}.");
                    currentReference.Attribute("Version")?.Remove();
                    foreach (var child in currentReference.Elements().Where(element => element.Name.LocalName == "Version").ToArray()) child.Remove();
                }
                continue;
            }
            var reference = new XElement(ns + "PackageReference", new XAttribute("Include", id));
            if (!central) reference.SetAttributeValue("Version", version);
            else
            {
                var existingVersion = centralXml!.Descendants().FirstOrDefault(element => element.Name.LocalName == "PackageVersion"
                    && string.Equals((string?)element.Attribute("Include") ?? (string?)element.Attribute("Update"), id, StringComparison.OrdinalIgnoreCase));
                if (existingVersion is not null && (explicitVersion || id == "Microsoft.WindowsAppSDK") && (string?)existingVersion.Attribute("Version") != version)
                    throw new InvalidOperationException($"Central version for {id} differs from required version {version}. Update Directory.Packages.props explicitly; no version was substituted.");
                if (existingVersion is null) centralXml.Root!.Add(new XElement("ItemGroup", new XElement("PackageVersion", new XAttribute("Include", id), new XAttribute("Version", version))));
            }
            group.Add(reference);
        }
        xml.Root.Add(group);
        xml.Save(project);
        centralXml?.Save(centralPath!);
    }
    internal static string? InstalledVersion(string project, string id)
    {
        var xml = XDocument.Load(project);
        var reference = xml.Descendants().FirstOrDefault(e => e.Name.LocalName == "PackageReference" && string.Equals((string?)e.Attribute("Include"), id, StringComparison.OrdinalIgnoreCase));
        var direct = (string?)reference?.Attribute("VersionOverride") ?? (string?)reference?.Attribute("Version") ?? reference?.Elements().FirstOrDefault(e => e.Name.LocalName == "Version")?.Value;
        if (direct is not null) return direct;
        for (var directory = Path.GetDirectoryName(project); directory is not null; directory = Path.GetDirectoryName(directory))
        {
            var path = Path.Combine(directory, "Directory.Packages.props");
            if (!File.Exists(path)) continue;
            var version = XDocument.Load(path).Descendants().FirstOrDefault(e => e.Name.LocalName == "PackageVersion" && string.Equals((string?)e.Attribute("Include") ?? (string?)e.Attribute("Update"), id, StringComparison.OrdinalIgnoreCase));
            return (string?)version?.Attribute("Version");
        }
        return null;
    }

    internal static async Task AlignManagedVersionsAsync(string project, IReadOnlyDictionary<string, string> versions, FileRollback rollback, ToolRunner tools, CancellationToken token)
    {
        var dependencies = versions.Keys.ToArray();
        var xml = XDocument.Load(project);
        var centralIds = new List<string>();
        var evaluation = await tools.RunAsync(["msbuild", project, "-nologo", "-getProperty:ManagePackageVersionsCentrally"], Path.GetDirectoryName(project), token).ConfigureAwait(false);
        DesktopProjectService.RequireSuccess(evaluation, "evaluating package version management");
        var isCentral = evaluation.Output.Trim().Equals("true", StringComparison.OrdinalIgnoreCase);
        foreach (var reference in xml.Descendants().Where(e => e.Name.LocalName == "PackageReference" && dependencies.Contains((string?)e.Attribute("Include") ?? "", StringComparer.OrdinalIgnoreCase)))
        {
            var id = (string)reference.Attribute("Include")!;
            var version = versions[id];
            if (!id.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase)) continue;
            if (reference.Attribute("VersionOverride") is not null) reference.SetAttributeValue("VersionOverride", version);
            else if (isCentral)
            {
                reference.Attribute("Version")?.Remove();
                foreach (var child in reference.Elements().Where(element => element.Name.LocalName == "Version").ToArray()) child.Remove();
                centralIds.Add(id);
            }
            else if (reference.Attribute("Version") is not null) reference.SetAttributeValue("Version", version);
            else if (reference.Elements().FirstOrDefault(e => e.Name.LocalName == "Version") is { } element) element.Value = version;
            else centralIds.Add(id);
        }
        if (centralIds.Count > 0)
        {
            string? centralPath = null;
            for (var directory = Path.GetDirectoryName(project); directory is not null; directory = Path.GetDirectoryName(directory))
            {
                var path = Path.Combine(directory, "Directory.Packages.props");
                if (File.Exists(path)) { centralPath = path; break; }
            }
            if (centralPath is null) throw new InvalidOperationException("Managed package versions could not be found. No changes made.");
            if ((File.GetAttributes(centralPath) & FileAttributes.ReparsePoint) != 0) throw new InvalidOperationException("Central package configuration is a symbolic link. No changes made.");
            rollback.TrackModified(centralPath);
            var central = XDocument.Load(centralPath);
            foreach (var id in centralIds)
            {
                var entry = central.Descendants().FirstOrDefault(e => e.Name.LocalName == "PackageVersion" && string.Equals((string?)e.Attribute("Include") ?? (string?)e.Attribute("Update"), id, StringComparison.OrdinalIgnoreCase))
                    ?? throw new InvalidOperationException($"Managed central version for {id} was not found.");
                entry.SetAttributeValue("Version", versions[id]);
            }
            central.Save(centralPath);
        }
        xml.Save(project);
    }

}
