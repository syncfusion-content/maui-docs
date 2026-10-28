using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Syncfusion.DotNet.CLI.Core.Licensing;

/// <summary>Writes the project-local license cache (<c>.syncfusion/license-meta.json</c> and <c>syncfusion-license.txt</c>).</summary>
public static class LicenseWriter
{
    public const string KeyFileName = "syncfusion-license.txt";
    public const string MetaDirectory = ".syncfusion";
    public const string MetaFileName = "license-meta.json";
    private static readonly JsonSerializerOptions Json = new() { WriteIndented = true };

    /// <summary>One key per license type, in first-appearance order.</summary>
    public static IReadOnlyList<string> DedupeKeys(IEnumerable<Entitlement> licenses)
    {
        var seen = new HashSet<string>(StringComparer.Ordinal);
        var keys = new List<string>();
        foreach (var l in licenses.Where(l => !string.IsNullOrWhiteSpace(l.LicenseKey)))
            if (seen.Add(string.IsNullOrWhiteSpace(l.LicenseType) ? "__untyped__" : l.LicenseType!)) keys.Add(l.LicenseKey!.Trim());
        return keys;
    }

    public static LicenseMetadata Build(string email, string platform, IReadOnlyList<string> requested, IReadOnlyDictionary<string, Entitlement> chosen, IReadOnlyList<string> keys)
    {
        var rows = requested.Select(p => chosen.TryGetValue(p, out var e)
            ? new LicenseEntry(p, e.Type.Equals("Trial", StringComparison.OrdinalIgnoreCase) ? "*" : e.Version, e.Type, e.LicenseType, e.Status, e.ExpiresAt)
            : new LicenseEntry(p, null, null, null, "NotAvailable", null)).ToList();
        var checksum = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(string.Join(';', keys)))).ToLowerInvariant();
        return new LicenseMetadata(1, DateTimeOffset.UtcNow.ToString("O"), email, platform, rows, checksum);
    }

    public static void Write(string root, LicenseMetadata meta, IReadOnlyList<string> keys)
    {
        var dir = Path.Combine(root, MetaDirectory);
        Directory.CreateDirectory(dir);
        using (AcquireLock(Path.Combine(dir, "license.lock")))
        {
            AtomicWrite(Path.Combine(dir, MetaFileName), JsonSerializer.Serialize(meta, Json));
            AtomicWrite(Path.Combine(root, KeyFileName), string.Join(';', keys));
            EnsureGitignore(root);
        }
    }

    public static LicenseMetadata? Read(string root, out bool corrupted)
    {
        corrupted = false;
        var path = Path.Combine(root, MetaDirectory, MetaFileName);
        if (!File.Exists(path)) return null;
        try { return JsonSerializer.Deserialize<LicenseMetadata>(File.ReadAllText(path)); }
        catch (JsonException) { corrupted = true; return null; }
    }

    public static IReadOnlyList<string> ReadKeys(string path)
        => File.ReadAllText(path).Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    private static void AtomicWrite(string path, string content)
    {
        var tmp = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        File.WriteAllText(tmp, content);
        File.Move(tmp, path, overwrite: true);
    }

    private static FileStream AcquireLock(string path)
    {
        var deadline = DateTime.UtcNow.AddSeconds(10);
        while (true)
        {
            try { return new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None, 1, FileOptions.DeleteOnClose); }
            catch (IOException) when (DateTime.UtcNow < deadline) { Thread.Sleep(100); }
            catch (IOException) { throw new LicenseException(LicenseExitCodes.ServiceUnavailable, "Timed out waiting for the license cache lock."); }
        }
    }

    private static void EnsureGitignore(string root)
    {
        var path = Path.Combine(root, ".gitignore");
        var existing = File.Exists(path) ? File.ReadAllText(path) : "";
        var lines = existing.Split('\n').Select(l => l.Trim()).ToHashSet();
        var add = new[] { MetaDirectory + "/", KeyFileName }.Where(e => !lines.Contains(e)).ToList();
        if (add.Count == 0) return;
        var prefix = existing.Length == 0 || existing.EndsWith('\n') ? "" : Environment.NewLine;
        File.AppendAllText(path, prefix + string.Join(Environment.NewLine, add) + Environment.NewLine);
    }
}
