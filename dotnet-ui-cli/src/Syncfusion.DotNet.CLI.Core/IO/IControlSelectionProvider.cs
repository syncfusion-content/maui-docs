namespace Syncfusion.DotNet.Cli.Core;

public sealed record ControlSelectionItem(string Id, string DisplayName, bool Added = false, bool OtherPackages = false);
public sealed record PackageSelectionItem(string Id, string DisplayName, bool Added = false, string? PackageId = null);

/// <summary>Platform catalogs and project state for the shared control picker.</summary>
public interface IControlSelectionProvider
{
    IReadOnlyList<ControlSelectionItem> Controls { get; }
    IReadOnlyList<PackageSelectionItem> Packages { get; }
    IReadOnlyList<string> ResolvePackages(IEnumerable<string> controlIds);
}
