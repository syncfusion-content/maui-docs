using System.Collections.Concurrent;
using System.Text.Json;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>Merges verified platform package metadata with existing control identities.</summary>
public static class DesktopPackageCatalog
{
    private static readonly ConcurrentDictionary<Type, IReadOnlyList<DesktopPackage>> Catalogs = new();

    public static IReadOnlyList<DesktopPackage> Combine(Type provider, IReadOnlyList<DesktopPackage> existing)
    {
        var catalog = Catalogs.GetOrAdd(provider, Load);
        var byId = catalog.ToDictionary(package => package.Id, StringComparer.OrdinalIgnoreCase);
        var result = existing.Select(package => byId.TryGetValue(package.Id, out var metadata)
            ? metadata with { Alias = package.Alias, DisplayName = package.DisplayName, HasTemplate = package.HasTemplate }
            : package).ToList();
        var existingIds = result.Select(package => package.Id).ToHashSet(StringComparer.OrdinalIgnoreCase);
        result.AddRange(catalog.Where(package => !existingIds.Contains(package.Id)));
        if (result.GroupBy(package => package.Alias, StringComparer.OrdinalIgnoreCase).Any(group => group.Count() > 1))
            throw new InvalidOperationException($"Duplicate package alias in {provider.Name}.");
        return result;
    }

    private static IReadOnlyList<DesktopPackage> Load(Type provider)
    {
        var resource = provider.Assembly.GetName().Name + ".Catalog.available-packages.json";
        using var stream = provider.Assembly.GetManifestResourceStream(resource)
            ?? throw new InvalidOperationException($"Missing package catalog '{resource}'.");
        using var document = JsonDocument.Parse(stream);
        if (document.RootElement.GetProperty("schemaVersion").GetInt32() != 1)
            throw new InvalidOperationException($"Unsupported package catalog schema in '{resource}'.");
        var packages = document.RootElement.GetProperty("packages").Deserialize<DesktopPackage[]>(
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
        if (packages.Length == 0 || packages.Any(package => string.IsNullOrWhiteSpace(package.Alias)
            || !package.Id.StartsWith("Syncfusion.", StringComparison.Ordinal) || package.HasTemplate)
            || packages.GroupBy(package => package.Id, StringComparer.OrdinalIgnoreCase).Any(group => group.Count() > 1))
            throw new InvalidOperationException($"Invalid package catalog '{resource}'.");
        return packages;
    }
}
