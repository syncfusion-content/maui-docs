using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Syncfusion.DotNet.Cli.Core.Licensing;

/// <summary>
/// Browser-based PKCE sign-in (the flow the Syncfusion identity client is registered for), silent refresh,
/// API-token minting and SSO sign-out. Mirrors ej2-ui-cli's auth-runtime.
/// </summary>
public sealed class AuthRuntime(AuthConfig config, SessionStore store, HttpClient http, Func<string, bool>? openBrowser = null)
{
    public static readonly TimeSpan CallbackTimeout = TimeSpan.FromMinutes(5);
    public static readonly TimeSpan LogoutTimeout = TimeSpan.FromMinutes(2);
    private static readonly TimeSpan NearExpiry = TimeSpan.FromSeconds(60);
    private static readonly string[] EmailClaims = ["email", "EmailId", "email_address"];
    private readonly Func<string, bool> _open = openBrowser ?? OpenBrowser;
    private (string Email, string Token, DateTimeOffset Expires)? _apiToken;

    public SessionStore Store => store;

    /// <summary>
    /// Optional wrapper the host uses to show a spinner while the CLI waits for the browser sign-in. When set it
    /// replaces the plain "Waiting for sign-in..." text.
    /// </summary>
    public Func<string, Func<Task<IReadOnlyDictionary<string, string>?>>, Task<IReadOnlyDictionary<string, string>?>>? WhileWaiting { get; init; }

    /// <summary>
    /// Called with the sign-in URL when no browser could be opened, so the host can show a short clickable link.
    /// When not set, the full URL is printed.
    /// </summary>
    public Action<string>? ShowSignInLink { get; init; }

    public async Task<Session> EnsureAuthenticatedAsync(bool interactive, CancellationToken ct)
    {
        var session = store.Load();
        if (session is not null && session.AccessToken.Length > 0 && session.ExpiresAt - DateTimeOffset.UtcNow > NearExpiry) return session;
        if (session?.RefreshToken is { Length: > 0 } refresh && !AuthConfig.IsMock)
        {
            try
            {
                var renewed = await TokenAsync(new()
                {
                    ["grant_type"] = "refresh_token", ["client_id"] = config.ClientId, ["refresh_token"] = refresh,
                }, session.Email, ct).ConfigureAwait(false);
                renewed = renewed with { Email = renewed.Email.Length > 0 ? renewed.Email : session.Email };
                store.Save(renewed);
                return renewed;
            }
            catch (Exception ex) when (ex is HttpRequestException or LicenseException or JsonException) { }
        }

        if (AuthConfig.IsMock)
        {
            var mock = new Session("admin@syncfusion.com", "mock-access-token", null, DateTimeOffset.UtcNow.AddHours(1));
            store.Save(mock);
            return mock;
        }

        if (!interactive) throw new LicenseException(LicenseExitCodes.SignInFailed, "Not signed in. Run: sfdotnet login");
        return await BrowserLoginAsync(ct).ConfigureAwait(false);
    }

    private async Task<Session> BrowserLoginAsync(CancellationToken ct)
    {
        using var server = CallbackServer.TryStart(AuthConfig.LoginPorts, "/callback", "Signed in to Syncfusion")
            ?? throw new LicenseException(LicenseExitCodes.SignInFailed, "Authentication failed: unable to start local callback server (ports 7788-7790 are in use).");
        var verifier = Pkce.GenerateVerifier();
        var state = Pkce.RandomState();
        var redirect = $"http://localhost:{server.Port}/callback";
        var url = config.AuthorizeUrl + "?" + string.Join('&', new (string, string)[]
        {
            ("client_id", config.ClientId), ("response_type", "code"), ("redirect_uri", redirect), ("scope", config.Scopes),
            ("code_challenge", Pkce.ChallengeFromVerifier(verifier)), ("code_challenge_method", "S256"), ("state", state), ("nonce", state),
        }.Select(p => $"{Uri.EscapeDataString(p.Item1)}={Uri.EscapeDataString(p.Item2)}"));

        // The URL is only shown when no browser could be launched; otherwise a transient status line is
        // shown and erased once sign-in finishes, so a successful login leaves no clutter behind.
        var status = false;
        if (_open(url))
        {
            status = WhileWaiting is null && !Console.IsOutputRedirected;
            if (status) Console.Out.Write("Waiting for sign-in in the browser...");
        }
        else if (ShowSignInLink is not null) ShowSignInLink(url);
        else
        {
            Console.Out.WriteLine("Could not open a browser. Open this URL to sign in:");
            Console.Out.WriteLine(url);
        }

        IReadOnlyDictionary<string, string>? query;
        try
        {
            query = WhileWaiting is null
                ? await server.WaitAsync(CallbackTimeout, ct).ConfigureAwait(false)
                : await WhileWaiting("Waiting for sign-in in the browser...", () => server.WaitAsync(CallbackTimeout, ct)).ConfigureAwait(false);
        }
        finally { if (status) Console.Out.Write("\r\u001b[2K"); }
        if (query is null) throw new LicenseException(LicenseExitCodes.SignInFailed, "Authentication cancelled.");
        if (query.TryGetValue("error", out var error))
            throw new LicenseException(LicenseExitCodes.SignInFailed, $"Authentication failed: {error} {(query.TryGetValue("error_description", out var d) ? d : "")}".Trim());
        if (!query.TryGetValue("state", out var returned) || returned != state || !query.TryGetValue("code", out var code))
            throw new LicenseException(LicenseExitCodes.SignInFailed, "Authentication failed: no authorization code received.");

        var session = await TokenAsync(new()
        {
            ["grant_type"] = "authorization_code", ["client_id"] = config.ClientId, ["code"] = code,
            ["code_verifier"] = verifier, ["redirect_uri"] = redirect,
        }, null, ct).ConfigureAwait(false);

        if (session.Email.Length == 0 && await UserinfoEmailAsync(session.AccessToken, ct).ConfigureAwait(false) is { } email)
            session = session with { Email = email };
        store.Save(session);
        return session;
    }

    private async Task<Session> TokenAsync(Dictionary<string, string> form, string? knownEmail, CancellationToken ct)
    {
        using var response = await http.PostAsync(config.TokenUrl, new FormUrlEncodedContent(form), ct).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
            throw new LicenseException(LicenseExitCodes.SignInFailed, "Token exchange failed. Please try again later.");
        var json = await response.Content.ReadFromJsonAsync<JsonElement>(ct).ConfigureAwait(false);
        var access = json.GetProperty("access_token").GetString()!;
        var refresh = json.TryGetProperty("refresh_token", out var r) && r.ValueKind == JsonValueKind.String ? r.GetString() : null;
        var expires = json.TryGetProperty("expires_in", out var e) && e.TryGetInt32(out var s) ? s : 3600;
        var email = json.TryGetProperty("id_token", out var id) ? EmailFromIdToken(id.GetString()) : null;
        return new Session(email ?? knownEmail ?? "", access, string.IsNullOrEmpty(refresh) ? null : refresh, DateTimeOffset.UtcNow.AddSeconds(expires));
    }

    internal static string? EmailFromIdToken(string? idToken)
    {
        var parts = idToken?.Split('.');
        if (parts is null || parts.Length < 2) return null;
        try
        {
            var payload = parts[1].Replace('-', '+').Replace('_', '/');
            payload = payload.PadRight(payload.Length + (4 - payload.Length % 4) % 4, '=');
            using var doc = JsonDocument.Parse(Convert.FromBase64String(payload));
            return FirstEmail(doc.RootElement);
        }
        catch (Exception ex) when (ex is FormatException or JsonException) { return null; }
    }

    private static string? FirstEmail(JsonElement element)
        => element.ValueKind != JsonValueKind.Object ? null
            : EmailClaims.Select(c => element.TryGetProperty(c, out var v) && v.ValueKind == JsonValueKind.String ? v.GetString() : null)
                .FirstOrDefault(v => !string.IsNullOrEmpty(v));

    private async Task<string?> UserinfoEmailAsync(string accessToken, CancellationToken ct)
    {
        try
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, config.UserinfoUrl);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            using var response = await http.SendAsync(request, ct).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode) return null;
            return FirstEmail(await response.Content.ReadFromJsonAsync<JsonElement>(ct).ConfigureAwait(false));
        }
        catch (Exception ex) when (ex is HttpRequestException or JsonException) { return null; }
    }

    /// <summary>
    /// Mints the short-lived bearer the license API requires (the OIDC access token is not accepted there).
    /// Cached for the life of this runtime; <paramref name="force"/> discards the cached value.
    /// </summary>
    public async Task<string> MintApiTokenAsync(string email, bool force, CancellationToken ct)
    {
        if (AuthConfig.IsMock) return "mock.api.access.token";
        if (!force && _apiToken is { } c && c.Email == email && c.Expires - DateTimeOffset.UtcNow > NearExpiry) return c.Token;
        using var response = await http.PostAsync(config.PasswordTokenUrl,
            new FormUrlEncodedContent(new Dictionary<string, string> { ["grant_type"] = "password", ["username"] = email }), ct).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
            throw new LicenseException(LicenseExitCodes.SignInFailed, "License service is currently unavailable. Please try again later.");
        var json = await response.Content.ReadFromJsonAsync<JsonElement>(ct).ConfigureAwait(false);
        if (!json.TryGetProperty("access_token", out var t) || t.GetString() is not { Length: > 0 } token)
            throw new LicenseException(LicenseExitCodes.SignInFailed, "License token endpoint response missing access_token.");
        var seconds = json.TryGetProperty("expires_in", out var e) && e.TryGetInt32(out var s) ? s : 3600;
        _apiToken = (email, token, DateTimeOffset.UtcNow.AddSeconds(seconds));
        return token;
    }

    /// <summary>Clears the local session, then completes the SSO sign-out in the browser (always attempted).</summary>
    public async Task LogoutAsync(CancellationToken ct)
    {
        store.Clear();
        if (AuthConfig.IsMock) return;
        using var server = CallbackServer.TryStart(AuthConfig.LogoutPorts, "/logout", "Signed out of Syncfusion");
        if (server is null) return;
        var url = config.LogoutUrl + "?returnUrl=" + Uri.EscapeDataString($"http://localhost:{server.Port}/logout");
        if (!_open(url)) return;
        await server.WaitAsync(LogoutTimeout, ct).ConfigureAwait(false);
    }

    /// <summary>Opens the URL with the OS handler, detached: rundll32 (Windows, cmd fallback), open (macOS), xdg-open (Linux).</summary>
    public static bool OpenBrowser(string url)
    {
        try
        {
            if (OperatingSystem.IsWindows())
            {
                try { Launch("rundll32", ["url.dll,FileProtocolHandler", url]); return true; }
                catch (Exception ex) when (ex is System.ComponentModel.Win32Exception or InvalidOperationException) { Launch("cmd", ["/c", "start", "", url]); return true; }
            }

            Launch(OperatingSystem.IsMacOS() ? "open" : "xdg-open", [url]);
            return true;
        }
        catch (Exception ex) when (ex is System.ComponentModel.Win32Exception or InvalidOperationException) { return false; }
    }

    private static void Launch(string file, string[] args)
    {
        var info = new ProcessStartInfo(file) { UseShellExecute = false, CreateNoWindow = true, RedirectStandardOutput = true, RedirectStandardError = true, RedirectStandardInput = true };
        foreach (var a in args) info.ArgumentList.Add(a);
        using var process = Process.Start(info) ?? throw new InvalidOperationException($"Could not start {file}.");
        // Launchers return quickly. One that fails (for example xdg-open with no browser installed) exits non-zero,
        // which means nothing was opened. One that is still running after the wait is treated as having worked.
        if (process.WaitForExit(2000) && process.ExitCode != 0) throw new InvalidOperationException($"{file} exited with code {process.ExitCode}.");
    }
}
