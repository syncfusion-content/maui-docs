using System.Text.Json;

namespace Syncfusion.DotNet.Cli.Tests;

internal static class PackageSearchFixture
{
    internal static string Response(string packageId, string version = "35.1.37") => JsonSerializer.Serialize(new
    {
        searchResult = new[] { new { packages = new[] { new { id = packageId, version } } } }
    });
}
