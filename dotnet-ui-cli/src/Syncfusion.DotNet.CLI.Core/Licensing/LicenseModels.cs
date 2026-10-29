using System.Text.Json.Serialization;

namespace Syncfusion.DotNet.CLI.Core.Licensing;

public sealed record LicenseEntry(
    [property: JsonPropertyName("product")] string Product,
    [property: JsonPropertyName("version")] string? Version,
    [property: JsonPropertyName("type")] string? Type,
    [property: JsonPropertyName("licenseType")] string? LicenseType,
    [property: JsonPropertyName("status")] string Status,
    [property: JsonPropertyName("expiresAt")] string? ExpiresAt);

public sealed record LicenseMetadata(
    [property: JsonPropertyName("version")] int Version,
    [property: JsonPropertyName("generatedAt")] string GeneratedAt,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("platform")] string Platform,
    [property: JsonPropertyName("licenses")] IReadOnlyList<LicenseEntry> Licenses,
    [property: JsonPropertyName("checksum")] string Checksum);

/// <summary>A license as returned by the entitlement/trial service, including its secret key.</summary>
public sealed record Entitlement(string Product, string? Version, string Type, string? LicenseType, string Status, string? ExpiresAt, string? LicenseKey);

public static class LicenseSelection
{
    private static readonly string[] Unusable = ["expired", "suspended", "notavailable"];

    public static string Normalize(string value) => new(value.Where(char.IsLetterOrDigit).Select(char.ToLowerInvariant).ToArray());

    private static int Rank(string type) => type.ToLowerInvariant() switch { "paid" => 0, "trial" => 1, "essentialstudio" => 2, _ => 3 };

    /// <summary>At most one license per product: Paid &lt; Trial &lt; EssentialStudio, then highest version &lt;= project major, then greater key.</summary>
    public static Dictionary<string, Entitlement> Select(IEnumerable<Entitlement> entitlements, IEnumerable<string> products, int projectMajor)
    {
        var chosen = new Dictionary<string, Entitlement>(StringComparer.OrdinalIgnoreCase);
        var list = entitlements.ToList();
        foreach (var product in products)
        {
            var key = Normalize(product);
            var best = list
                .Where(e => Normalize(e.Product) == key && !Unusable.Contains(e.Status.ToLowerInvariant()))
                .OrderBy(e => Rank(e.Type))
                .ThenBy(e => VersionOf(e) is { } v && v <= projectMajor ? 0 : 1)
                .ThenByDescending(e => VersionOf(e) ?? 0)
                .ThenByDescending(e => e.LicenseKey ?? "", StringComparer.Ordinal)
                .FirstOrDefault();
            if (best is not null) chosen[product] = best;
        }

        return chosen;
    }

    private static int? VersionOf(Entitlement e) => int.TryParse(e.Version?.Split('.')[0], out var v) ? v : null;
}
