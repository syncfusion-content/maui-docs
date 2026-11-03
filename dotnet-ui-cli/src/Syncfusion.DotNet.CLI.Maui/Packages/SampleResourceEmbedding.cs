using System.Xml.Linq;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui.Injection;
using Syncfusion.DotNet.Cli.Maui.Manifest;

namespace Syncfusion.DotNet.Cli.Maui;
/// <summary>
/// Keeps binary sample resources (the PDF Viewer's shipped document) embedded
/// in the generated application: adds an <c>EmbeddedResource</c> item for each
/// binary generated file to the app .csproj on add, and removes the owned
/// block on remove. The manifest logical name mirrors the generated folder so
/// the sample's manifest-resource lookup resolves without project-specific
/// placeholders inside the item.
/// </summary>
public static class SampleResourceEmbedding
{
    public static bool NeedsEmbedding(ControlCatalogEntry entry)
        => entry.GeneratedFiles.Any(file => EmbeddedResourceLoader.IsBinaryFile(file.Destination));

    /// <summary>Inserts the owned embedding block for every binary generated file. Idempotent.</summary>
    public static void Ensure(string projectRoot, string csprojPath, ControlCatalogEntry entry,
        FileRollback rollback, SyncfusionManifest manifest)
    {
        var binaries = entry.GeneratedFiles
            .Where(file => EmbeddedResourceLoader.IsBinaryFile(file.Destination))
            .Select(file => (file.Destination, LogicalName: ResourceName(file.Destination)))
            .ToArray();
        if (binaries.Length == 0) return;

        var before = File.ReadAllText(csprojPath);
        if (before.Contains("sf-cli:" + EmbeddedResourceLoader.CsprojBlockMarker, StringComparison.Ordinal)) return;
        var project = XDocument.Parse(before);

        var items = string.Join("\n", binaries.Select(binary =>
            $"    <EmbeddedResource Include=\"{System.Security.SecurityElement.Escape(binary.Destination)}\" LogicalName=\"{binary.LogicalName}\" />"));
        var block = GeneratedCodeBlocks.Wrap(EmbeddedResourceLoader.CsprojBlockMarker, $"  <ItemGroup>\n{items}\n  </ItemGroup>", xaml: true, indent: "  ");
        var after = before.Replace("</Project>", block + "</Project>", StringComparison.Ordinal);
        _ = XDocument.Parse(after); // must stay well-formed XML before it is written

        rollback.TrackModified(csprojPath);
        File.WriteAllText(csprojPath, after);
        manifest.GeneratedBlocks.AddRange(GeneratedCodeBlocks.CaptureNew(Path.GetFileName(csprojPath), before, after));
        if (!manifest.ModifiedFiles.Contains(Path.GetFileName(csprojPath), StringComparer.OrdinalIgnoreCase))
            manifest.ModifiedFiles.Add(Path.GetFileName(csprojPath));
    }

    /// <summary>Removes the owned embedding block when the control that owns it is removed.</summary>
    public static void Remove(string csprojPath, FileRollback rollback, SyncfusionManifest manifest)
    {
        if (!File.Exists(csprojPath)) return;
        var before = File.ReadAllText(csprojPath);
        var after = GeneratedCodeBlocks.Remove(before, EmbeddedResourceLoader.CsprojBlockMarker);
        if (after == before) return;
        _ = XDocument.Parse(after);
        rollback.TrackModified(csprojPath);
        File.WriteAllText(csprojPath, after);
        if (manifest.GeneratedBlocks.RemoveAll(block => block.Path.Equals(Path.GetFileName(csprojPath), StringComparison.OrdinalIgnoreCase)
            && block.Marker == EmbeddedResourceLoader.CsprojBlockMarker) > 0
            && !manifest.ModifiedFiles.Contains(Path.GetFileName(csprojPath), StringComparer.OrdinalIgnoreCase))
            manifest.ModifiedFiles.Add(Path.GetFileName(csprojPath));
    }

    /// <summary>The manifest resource name the generated sample resolves: the destination path with dots.</summary>
    public static string ResourceName(string destination)
        => string.Join('.', destination.Replace('\\', '/').Split('/'));
}
