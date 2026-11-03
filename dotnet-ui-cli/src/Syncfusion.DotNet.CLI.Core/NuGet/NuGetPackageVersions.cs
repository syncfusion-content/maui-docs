using System.Text.Json;
using System.Text.RegularExpressions;

namespace Syncfusion.DotNet.Cli.Core;

/// <summary>Resolve concrete stable package versions from the official public feed.</summary>
public static class NuGetPackageVersions
{
    public static bool IsExact(string version) => Regex.IsMatch(version,
        @"\A\d+\.\d+\.\d+(?:\.\d+)?(?:-[0-9A-Za-z.-]+)?(?:\+[0-9A-Za-z.-]+)?\z", RegexOptions.CultureInvariant);

    public static async Task<string> ResolveAsync(string packageId, string? requestedVersion,
        ToolRunner runner, CancellationToken token = default, string? executable = null)
    {
        if (requestedVersion is not null)
        {
            if (!IsExact(requestedVersion)) throw new ArgumentException("Package version must be an exact NuGet version; floating versions and ranges are not supported.");
            return requestedVersion;
        }
        var result = await runner.RunAsync(["package", "search", packageId, "--exact-match", "--format", "json", "--source", NuGetSources.DefaultPublicFeed],
            cancellationToken: token, executable: executable).ConfigureAwait(false);
        if (!result.Success) throw new InvalidOperationException($"Could not resolve the latest stable version of '{packageId}' from nuget.org. No floating version was used.");
        try
        {
            using var json = JsonDocument.Parse(result.Output);
            var versions = json.RootElement.GetProperty("searchResult").EnumerateArray()
                .SelectMany(source => source.GetProperty("packages").EnumerateArray())
                .Where(package => string.Equals(package.GetProperty("id").GetString(), packageId, StringComparison.OrdinalIgnoreCase))
                .Select(package => package.GetProperty("version").GetString()!)
                .Where(version => IsExact(version) && !version.Contains('-'))
                .OrderByDescending(version => Version.Parse(version.Split('+')[0])).ToArray();
            if (versions.Length > 0) return versions[0];
        }
        catch (Exception exception) when (exception is JsonException or KeyNotFoundException or InvalidOperationException or FormatException) { }
        throw new InvalidOperationException($"No stable version of '{packageId}' could be resolved from nuget.org. No floating version was used.");
    }
}
