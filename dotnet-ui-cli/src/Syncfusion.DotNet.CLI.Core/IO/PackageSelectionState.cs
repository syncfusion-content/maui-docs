using System.Xml.Linq;

namespace Syncfusion.DotNet.Cli.Core;

public static class PackageSelectionState
{
    public static IReadOnlyList<PackageSelectionItem> MarkInstalled(IReadOnlyList<PackageSelectionItem> packages, string? projectPath)
    {
        if (projectPath is null) return packages;
        var installed = XDocument.Load(projectPath).Descendants()
            .Where(item => item.Name.LocalName == "PackageReference")
            .Select(item => (string?)item.Attribute("Include") ?? (string?)item.Attribute("Update"))
            .Where(id => id is not null).ToHashSet(StringComparer.OrdinalIgnoreCase);
        return packages.Select(package => package with { Added = package.Added || installed.Contains(package.PackageId ?? package.Id) }).ToArray();
    }
}
