using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Syncfusion.DotNet.Cli.Core.Licensing;

public sealed record Session(string Email, string AccessToken, string? RefreshToken, DateTimeOffset ExpiresAt);

/// <summary>
/// Persists the sign-in session encrypted at rest (AES-256-GCM, key derived per OS user) in
/// <c>%APPDATA%\Syncfusion</c>, <c>~/Library/Application Support/Syncfusion</c> or <c>~/.config/Syncfusion</c>.
/// </summary>
public sealed class SessionStore
{
    private const int SchemaVersion = 1;
    private readonly string _path;

    public SessionStore(string? pathOverride = null)
    {
        _path = pathOverride
            ?? (Environment.GetEnvironmentVariable("SF_SESSION_PATH_OVERRIDE") is { Length: > 0 } env ? env : DefaultPath());
    }

    public string Path => _path;

    public static string DefaultPath()
    {
        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var root = OperatingSystem.IsWindows()
            ? Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            : OperatingSystem.IsMacOS() ? System.IO.Path.Combine(home, "Library", "Application Support") : System.IO.Path.Combine(home, ".config");
        return System.IO.Path.Combine(root, "Syncfusion", "session.json");
    }

    public void Save(Session session)
    {
        var dto = new Dictionary<string, object?>
        {
            ["email"] = session.Email,
            ["accessToken"] = session.AccessToken,
            ["expiresAt"] = session.ExpiresAt,
        };
        if (!string.IsNullOrEmpty(session.RefreshToken)) dto["refreshToken"] = session.RefreshToken;
        var plain = JsonSerializer.SerializeToUtf8Bytes(dto);
        var nonce = RandomNumberGenerator.GetBytes(12);
        var cipher = new byte[plain.Length];
        var tag = new byte[16];
        using (var aes = new AesGcm(Key(), 16)) aes.Encrypt(nonce, plain, cipher, tag);
        var envelope = JsonSerializer.Serialize(new { schemaVersion = SchemaVersion, nonce = Convert.ToBase64String(nonce), tag = Convert.ToBase64String(tag), data = Convert.ToBase64String(cipher) });
        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(_path)!);
        var tmp = _path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        File.WriteAllText(tmp, envelope);
        if (!OperatingSystem.IsWindows()) File.SetUnixFileMode(tmp, UnixFileMode.UserRead | UnixFileMode.UserWrite);
        File.Move(tmp, _path, overwrite: true);
    }

    public Session? Load()
    {
        try
        {
            if (!File.Exists(_path)) return null;
            using var doc = JsonDocument.Parse(File.ReadAllText(_path));
            var root = doc.RootElement;
            var nonce = Convert.FromBase64String(root.GetProperty("nonce").GetString()!);
            var tag = Convert.FromBase64String(root.GetProperty("tag").GetString()!);
            var cipher = Convert.FromBase64String(root.GetProperty("data").GetString()!);
            var plain = new byte[cipher.Length];
            using (var aes = new AesGcm(Key(), 16)) aes.Decrypt(nonce, cipher, tag, plain);
            using var inner = JsonDocument.Parse(plain);
            var r = inner.RootElement;
            return new Session(
                r.GetProperty("email").GetString() ?? "",
                r.GetProperty("accessToken").GetString()!,
                r.TryGetProperty("refreshToken", out var rt) ? rt.GetString() : null,
                r.GetProperty("expiresAt").GetDateTimeOffset());
        }
        catch (Exception ex) when (ex is IOException or JsonException or CryptographicException or FormatException or KeyNotFoundException or InvalidOperationException)
        {
            return null;
        }
    }

    public void Clear()
    {
        try { if (File.Exists(_path)) File.Delete(_path); }
        catch (IOException) { }
        catch (UnauthorizedAccessException) { }
    }

    private static byte[] Key()
        => Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(Environment.UserName + "::sf-cli-session"),
            Encoding.UTF8.GetBytes("sf-cli-v1::session::do-not-rotate"), 100_000, HashAlgorithmName.SHA256, 32);
}
