using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Syncfusion.DotNet.Cli.Core.Licensing;

/// <summary>
/// Calls the Syncfusion entitlement / generateTrial endpoints (same contract as ej2-ui-cli).
/// The API is authorised by a separate short-lived bearer from <c>mintToken</c>, not the OIDC access token.
/// </summary>
public sealed class EntitlementClient(
    AuthConfig config, HttpClient http, string email, Func<bool, CancellationToken, Task<string>> mintToken, Func<TimeSpan, Task>? delay = null)
{
    /// <summary>The API groups every package it does not model individually (all .NET NuGet packages) under this slug.</summary>
    public const string CatchAllPackage = "studioui";

    private static readonly TimeSpan[] Backoff = [TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(4)];
    private readonly Func<TimeSpan, Task> _delay = delay ?? (t => Task.Delay(t));

    public Task<IReadOnlyList<Entitlement>> FetchEntitlementsAsync(string platform, int major, IReadOnlyList<string> products, CancellationToken ct)
        => PostAsync(config.LicenseApiUrl, false, platform, major, products, ct);

    public Task<IReadOnlyList<Entitlement>> FetchTrialAsync(string platform, int major, IReadOnlyList<string> products, CancellationToken ct)
        => PostAsync(config.TrialApiUrl, true, platform, major, products, ct);

    private async Task<IReadOnlyList<Entitlement>> PostAsync(string url, bool trial, string platform, int major, IReadOnlyList<string> products, CancellationToken ct)
    {
        if (AuthConfig.IsMock) return products.Select(p => new Entitlement(p, "*", "Paid", "Community", "Active", "2099-12-31", "MOCK-LICENSE-KEY")).ToList();

        var body = new Dictionary<string, object>
        {
            ["email"] = email,
            ["platform"] = platform.ToLowerInvariant(),
            ["version"] = major,
            ["packages"] = new[] { CatchAllPackage },
        };
        if (trial) body["eula"] = true;

        var token = await mintToken(false, ct).ConfigureAwait(false);
        var refreshed = false;
        for (var attempt = 0; ;)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, url) { Content = JsonContent.Create(body) };
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            using var response = await http.SendAsync(request, ct).ConfigureAwait(false);
            if (response.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden)
            {
                if (refreshed) throw new LicenseException(LicenseExitCodes.SignInFailed, "License service rejected the session. Run: sfdotnet login");
                refreshed = true;
                token = await mintToken(true, ct).ConfigureAwait(false);
                continue;
            }

            if (response.StatusCode is HttpStatusCode.BadGateway or HttpStatusCode.ServiceUnavailable or HttpStatusCode.GatewayTimeout)
            {
                if (attempt >= Backoff.Length) throw new LicenseException(LicenseExitCodes.ServiceUnavailable, "License service unavailable. Please retry later.");
                await _delay(Backoff[attempt++]).ConfigureAwait(false);
                continue;
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new LicenseException(LicenseExitCodes.NoEntitlement, "No entitlement for the requested products.");
            if (!response.IsSuccessStatusCode)
                throw new LicenseException(LicenseExitCodes.ServiceUnavailable, "License service is currently unavailable. Please try again later.");
            return Expand(Parse(await response.Content.ReadFromJsonAsync<JsonElement>(ct).ConfigureAwait(false)), products);
        }
    }

    /// <summary>The catch-all license covers every requested package, so it is repeated once per package.</summary>
    internal static IReadOnlyList<Entitlement> Expand(IReadOnlyList<Entitlement> licenses, IReadOnlyList<string> products)
        => licenses.SelectMany(l => string.Equals(l.Product, CatchAllPackage, StringComparison.OrdinalIgnoreCase)
            ? products.Select(p => l with { Product = p })
            : [l]).ToList();

    internal static IReadOnlyList<Entitlement> Parse(JsonElement json)
    {
        var items = json.ValueKind == JsonValueKind.Array ? json : json.TryGetProperty("licenses", out var l) ? l : default;
        if (items.ValueKind != JsonValueKind.Array) return [];
        static string? S(JsonElement e, params string[] names)
            => names.Select(n => e.TryGetProperty(n, out var v)
                    ? v.ValueKind == JsonValueKind.String ? v.GetString() : v.ValueKind == JsonValueKind.Number ? v.GetRawText() : null
                    : null)
                .FirstOrDefault(v => !string.IsNullOrWhiteSpace(v));
        return items.EnumerateArray().Select(e => new Entitlement(
            S(e, "package", "product") ?? "", S(e, "version"), NormalizeType(S(e, "type")), S(e, "licenseType", "license_type"),
            S(e, "status")?.Trim() ?? "Active", S(e, "expiresAt"), DecodeKey(S(e, "licenseKey")))).Where(e => e.Product.Length > 0).ToList();
    }

    private static string NormalizeType(string? type) => type?.Trim().ToLowerInvariant() switch
    {
        "paid" => "Paid", "trial" => "Trial", "essentialstudio" or "essential studio" => "EssentialStudio", null or "" or "null" => "", _ => type!.Trim(),
    };

    /// <summary>The service returns the key base64-encoded; plain-text values (and non-base64 text) are kept as-is.</summary>
    internal static string? DecodeKey(string? raw)
    {
        if (string.IsNullOrEmpty(raw) || raw == "null") return null;
        if (raw.Length < 16 || raw.Length % 4 == 3 || !raw.All(c => char.IsAsciiLetterOrDigit(c) || c is '+' or '/' or '=')) return raw;
        try
        {
            var decoded = Encoding.UTF8.GetString(Convert.FromBase64String(raw.PadRight(raw.Length + (4 - raw.Length % 4) % 4, '=')));
            return decoded.Length == 0 || decoded.Any(char.IsControl) ? raw : decoded;
        }
        catch (FormatException) { return raw; }
    }
}
