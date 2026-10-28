namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>Shared installed-package headings and content-sized Alias/NuGet/Version columns.</summary>
internal static class InstalledPackageRenderer
{
    internal sealed record Entry(string? Alias, string PackageId, string? Version);

    internal static void Write(ConsolePresenter presenter, string platformName, IReadOnlyList<Entry> packages)
    {
        if (packages.Count == 0)
        {
            presenter.WriteInfo($"No direct Syncfusion {platformName} packages are installed in the selected project.");
            return;
        }
        presenter.WriteInfo($"Installed Syncfusion {platformName} packages:");
        foreach (var row in TableRows.Format(["Alias", "NuGet", "Version"], packages.Select(package =>
            new[] { package.Alias ?? string.Empty, package.PackageId, package.Version ?? "not specified" })))
            presenter.WriteInfo("  " + row);
    }
}
