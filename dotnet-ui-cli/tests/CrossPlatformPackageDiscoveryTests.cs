using System.Text.Json;
using Syncfusion.DotNet.Cli.Commands.Desktop;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Hosting;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Presentation;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class CrossPlatformPackageDiscoveryTests
{
    [Theory]
    [InlineData("wpf", 106, 11)]
    [InlineData("winforms", 50, 10)]
    [InlineData("winui", 18, 11)]
    [InlineData("blazor", 59, 15)]
    public async Task FullPackageCatalogPreservesControlChoicesAndProvidesMauiStyleOutput(string platform, int packageCount, int controlCount)
    {
        var provider = DesktopProviders.Find(platform)!;
        Assert.Equal(packageCount, provider.Packages.Select(package => package.Id).Distinct(StringComparer.OrdinalIgnoreCase).Count());
        Assert.Equal(controlCount, provider.Controls.Count);
        Assert.Equal(provider.Packages.Count, provider.Packages.Select(package => package.DisplayName).Distinct(StringComparer.Ordinal).Count());
        Assert.Equal(provider.Packages.Count, provider.Packages.Select(package => package.Alias).Distinct(StringComparer.OrdinalIgnoreCase).Count());
        Assert.All(provider.Packages, package => Assert.False(string.IsNullOrWhiteSpace(package.Description)));
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", platform, "packages", "--no-interactive"]));
        var lines = capture.Out.Split(Environment.NewLine);
        Assert.Equal($"Syncfusion {provider.DisplayName} packages", lines[0]);
        Assert.StartsWith("Alias  ", lines[1]);
        Assert.Contains("Name", lines[1]);
        Assert.Contains("NuGet", lines[1]);
        Assert.Single(lines, line => line.StartsWith("Alias  ", StringComparison.Ordinal));
        Assert.DoesNotContain("More packages?", capture.Out);
        Assert.Empty(capture.Error);
        foreach (var package in provider.Packages.Where(package => !HiddenPackages.IsHidden(package.Id)))
            foreach (var segment in package.Id.Split('.')) Assert.Contains(segment, capture.Out);
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    [InlineData("blazor")]
    public async Task FilteringSearchAndLegacySyntaxKeepJsonContractAndPackageOnlyRows(string platform)
    {
        var provider = DesktopProviders.Find(platform)!;
        var package = provider.Packages.First(item => !item.HasTemplate && item.Description.Length > 0);
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "packages", platform, "--search", package.Alias, "--json", "--no-interactive"]));
        using var json = JsonDocument.Parse(capture.Out);
        Assert.Contains(json.RootElement.EnumerateArray(), row => row.GetProperty("Alias").GetString() == package.Alias);
        Assert.All(json.RootElement.EnumerateArray(), row => Assert.Equal(new[] { "Alias", "DisplayName", "Id", "HasTemplate" }, row.EnumerateObject().Select(property => property.Name)));
        capture.Reset();
        Assert.Equal(0, await CliApp.Build().RunAsync(["search", platform, package.Id, "--details", "--no-interactive"]));
        Assert.Contains(package.Alias, capture.Out);
        Assert.Contains("Release status: stable", capture.Out);
        Assert.Contains("no generated control sample", capture.Out);
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    [InlineData("blazor")]
    public async Task DescriptionOnlySearchAndVerboseOutputMatchMauiBehavior(string platform)
    {
        var provider = DesktopProviders.Find(platform)!;
        var candidate = provider.Packages.SelectMany(package => package.Description.Split(' ')
                .Select(word => (Package: package, Word: word.Trim('.', ',', ':', ';'))))
            .First(item => item.Word.Length >= 8 && item.Word.All(char.IsLetter)
                && !item.Package.Id.Contains(item.Word, StringComparison.OrdinalIgnoreCase)
                && !item.Package.DisplayName.Contains(item.Word, StringComparison.OrdinalIgnoreCase)
                && !item.Package.Alias.Contains(item.Word, StringComparison.OrdinalIgnoreCase));
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", platform, "packages", "--search", candidate.Word, "--json", "--no-interactive"]));
        using var json = JsonDocument.Parse(capture.Out);
        Assert.Contains(json.RootElement.EnumerateArray(), row => row.GetProperty("Id").GetString() == candidate.Package.Id);
        capture.Reset();
        Assert.Equal(0, await CliApp.Build().RunAsync(["search", platform, candidate.Package.Id, "--verbose", "--no-interactive"]));
        Assert.Contains("Release status: stable", capture.Error);
        Assert.DoesNotContain("Release status:", capture.Out);
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    [InlineData("blazor")]
    public async Task InstalledPackagesUseAlignedAliasNugetVersionColumnsAndResolveCentralVersions(string platform)
    {
        var provider = DesktopProviders.Find(platform)!;
        var known = provider.Packages.First();
        using var temp = new Temp();
        File.WriteAllText(Path.Combine(temp.Root, "Directory.Packages.props"),
            $"<Project><ItemGroup><PackageVersion Include=\"{known.Id}\" Version=\"35.1.40\" /></ItemGroup></Project>");
        var project = WriteProject(temp.Root, platform,
            $"<PackageReference Include=\"{known.Id}\" /><PackageReference Include=\"Syncfusion.Unknown.Library\"><Version>2.3.4</Version></PackageReference><PackageReference Include=\"Microsoft.Extensions.Logging\" Version=\"10.0.0\" />");
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", platform, "installed", "--path", project, "--no-interactive"]));
        Assert.StartsWith($"Installed Syncfusion {provider.DisplayName} packages:" + Environment.NewLine, capture.Out);
        var rows = capture.Out.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal(4, rows.Length);
        var idStart = rows[1].IndexOf("NuGet", StringComparison.Ordinal);
        var versionStart = rows[1].IndexOf("Version", StringComparison.Ordinal);
        var knownRow = Assert.Single(rows, line => line.Contains(known.Id, StringComparison.Ordinal));
        Assert.Equal(known.Id, knownRow[idStart..versionStart].Trim());
        Assert.Equal("35.1.40", knownRow[versionStart..]);
        var unknownRow = Assert.Single(rows, line => line.Contains("Syncfusion.Unknown.Library", StringComparison.Ordinal));
        Assert.True(string.IsNullOrWhiteSpace(unknownRow[..idStart]));
        Assert.Equal("2.3.4", unknownRow[versionStart..]);
        Assert.DoesNotContain("Microsoft.Extensions.Logging", capture.Out);
        capture.Reset();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "installed", platform, "--path", project, "--json", "--no-interactive"]));
        using var json = JsonDocument.Parse(capture.Out);
        Assert.Equal(2, json.RootElement.GetArrayLength());
        Assert.All(json.RootElement.EnumerateArray(), row => Assert.Equal(new[] { "Id", "Version" }, row.EnumerateObject().Select(property => property.Name)));
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    [InlineData("blazor")]
    public async Task InstalledVersionOverrideAndChildVersionTakePrecedenceOverCentralValues(string platform)
    {
        using var temp = new Temp();
        var id = DesktopProviders.Find(platform)!.Packages.First().Id;
        File.WriteAllText(Path.Combine(temp.Root, "Directory.Packages.props"), $"<Project><ItemGroup><PackageVersion Include=\"{id}\" Version=\"1.0.0\" /></ItemGroup></Project>");
        foreach (var (metadata, expected) in new[] { ("Version=\"2.0.0\"", "2.0.0"), ("Version=\"2.0.0\" VersionOverride=\"3.0.0\"", "3.0.0"), ("", "4.0.0") })
        {
            var project = WriteProject(temp.Root, platform, $"<PackageReference Include=\"{id}\" {metadata}>{(metadata.Length == 0 ? "<Version>4.0.0</Version>" : "")}</PackageReference>");
            using var capture = new ConsoleCapture();
            Assert.Equal(0, await CliApp.Build().RunAsync(["list", platform, "installed", "--path", project, "--json", "--no-interactive"]));
            using var json = JsonDocument.Parse(capture.Out);
            Assert.Equal(expected, json.RootElement[0].GetProperty("Version").GetString());
        }
    }

    [Theory]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    [InlineData("blazor")]
    public async Task EmptyInstalledListHasClearPlatformHeading(string platform)
    {
        using var temp = new Temp();
        using var capture = new ConsoleCapture();
        var project = WriteProject(temp.Root, platform, "");
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", platform, "installed", "--path", project, "--no-interactive"]));
        Assert.Equal($"No direct Syncfusion {DesktopProviders.Find(platform)!.DisplayName} packages are installed in the selected project." + Environment.NewLine, capture.Out);
    }

    [Theory]
    [InlineData(32)]
    [InlineData(40)]
    [InlineData(80)]
    [InlineData(120)]
    [InlineData(240)]
    public void AllPlatformCatalogsUseResponsiveLosslessLayouts(int width)
    {
        foreach (var provider in new[] { "wpf", "winforms", "winui", "blazor" }.Select(name => DesktopProviders.Find(name)!))
        {
            var entries = provider.Packages.Select(package => new PackageListRenderer.Entry(package.Alias, package.DisplayName, package.Id, package.Category, package.Classification, [])).ToArray();
            var lines = PackageListRenderer.Format(entries, width, provider.DisplayName);
            Assert.All(lines, line => Assert.True(line.Length <= width, $"{provider.DisplayName}: {line}"));
            var output = string.Join("\n", lines);
            foreach (var package in provider.Packages)
                foreach (var segment in package.Id.Split('.')) Assert.Contains(segment, output);
            Assert.Equal(lines, PackageListRenderer.Format(entries.Reverse().ToArray(), width, provider.DisplayName));
        }
    }

    [Fact]
    public async Task InfoAdvertisesOnlyEnabledCommandsInBothTextAndJson()
    {
        Assert.Equal(new[] { "new", "add", "update", "list", "search", "mcp", "skills", "help", "info" }, DiscoveryService.GetInfo().AvailableCommands);
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["info"]));
        Assert.Contains("Available commands:", capture.Out);
        Assert.DoesNotContain("remove", capture.Out);
        capture.Reset();
        Assert.Equal(0, await CliApp.Build().RunAsync(["info", "--json"]));
        using var json = JsonDocument.Parse(capture.Out);
        Assert.DoesNotContain(json.RootElement.GetProperty("availableCommands").EnumerateArray(), command => command.GetString() == "remove");
    }

    private static string WriteProject(string root, string platform, string references)
    {
        var flag = platform switch { "wpf" => "<UseWPF>true</UseWPF>", "winforms" => "<UseWindowsForms>true</UseWindowsForms>", "winui" => "<UseWinUI>true</UseWinUI>", _ => "" };
        var path = Path.Combine(root, "App.csproj");
        File.WriteAllText(path, $"<Project Sdk=\"{(platform == "blazor" ? "Microsoft.NET.Sdk.Web" : "Microsoft.NET.Sdk")}\"><PropertyGroup>{flag}<TargetFramework>net10.0</TargetFramework></PropertyGroup><ItemGroup>{references}</ItemGroup></Project>");
        return path;
    }

    private sealed class Temp : IDisposable
    {
        public string Root { get; } = Path.Combine(Path.GetTempPath(), "sf-package-discovery-" + Guid.NewGuid().ToString("N"));
        public Temp() => Directory.CreateDirectory(Root);
        public void Dispose() => Directory.Delete(Root, true);
    }
}
