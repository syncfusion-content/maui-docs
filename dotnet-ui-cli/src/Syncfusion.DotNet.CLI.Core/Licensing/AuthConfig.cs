namespace Syncfusion.DotNet.CLI.Core.Licensing;

/// <summary>
/// Identity and license-service endpoints. These are the same registrations the Syncfusion web CLI (ej2-ui-cli)
/// uses, currently the staging servers. Each value can be overridden with an <c>SF_*</c> environment variable.
/// </summary>
public sealed record AuthConfig(
    string ClientId,
    string AuthorizeUrl,
    string TokenUrl,
    string UserinfoUrl,
    string LogoutUrl,
    string PasswordTokenUrl,
    string LicenseApiUrl,
    string TrialApiUrl,
    string Scopes)
{
    public static readonly int[] LoginPorts = [7788, 7789, 7790];
    public static readonly int[] LogoutPorts = [7801, 7802, 7803];

    /// <summary>True when <c>SF_AUTH_MOCK=1</c>: a canned session and entitlement fixture replace the network.</summary>
    public static bool IsMock => Environment.GetEnvironmentVariable("SF_AUTH_MOCK") == "1";

    public static AuthConfig Load()
    {
        if (IsMock) return Mock;
        var identity = Env("SF_AUTH_AUTHORITY", "https://stagingidentity.syncfusion.com").TrimEnd('/');
        var api = Env("SF_LICENSE_API_BASE", "https://staging.syncfusion.com:8088").TrimEnd('/');
        return new AuthConfig(
            Env("SF_AUTH_CLIENT_ID", "8f3c8f25-5f6d-438b-a7c1-9d7f2f5a8c42"),
            identity + "/connect/authorize",
            identity + "/connect/token",
            identity + "/connect/userinfo",
            identity + "/logout",
            api + "/token/v10",
            Env("SF_LICENSE_API_URL", api + "/api/v1/licenses/entitlement"),
            Env("SF_TRIAL_API_URL", api + "/api/v1/licenses/generateTrial"),
            "openid profile email");
    }

    public static AuthConfig Mock { get; } = new("mock", "http://127.0.0.1:5599/connect/authorize", "http://127.0.0.1:5599/connect/token",
        "http://127.0.0.1:5599/connect/userinfo", "http://127.0.0.1:5599/logout", "http://127.0.0.1:5599/token/v10",
        "http://127.0.0.1:5599/api/v1/licenses/entitlement", "http://127.0.0.1:5599/api/v1/licenses/generateTrial", "openid profile email");

    private static string Env(string name, string fallback)
        => Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : fallback;
}
