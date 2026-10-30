namespace Syncfusion.DotNet.Cli.Core;

/// <summary>Catalog entries that stay in the catalog files but are not offered in package lists or pickers.</summary>
public static class HiddenPackages
{
    public static bool IsHidden(string packageId)
        => packageId.EndsWith(".A2UI", StringComparison.OrdinalIgnoreCase);
}
