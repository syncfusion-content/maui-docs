using System.Text.RegularExpressions;
using Syncfusion.DotNet.CLI.Commands.Desktop;
using Syncfusion.DotNet.CLI.Hosting;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class HelpPresentationTests
{
    [Theory]
    [InlineData("maui")]
    [InlineData("wpf")]
    [InlineData("winforms")]
    [InlineData("winui")]
    [InlineData("blazor")]
    public async Task PlatformHelpUsesAvailableAliasesAndSeparateOptionLines(string platform)
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["help", platform]));
        Assert.Contains("Available package aliases:", capture.Out);
        Assert.DoesNotContain("Canonical package aliases", capture.Out);
        Assert.DoesNotContain(Environment.NewLine + "Controls" + Environment.NewLine, capture.Out);
        var lines = capture.Out.Split(Environment.NewLine);
        foreach (var flag in new[] { "-p, --path", "--dry-run", "--json", "-v, --version", "--source", "--configfile", "--no-restore", "-t, --target-framework" })
            Assert.Single(lines, line => line.TrimStart().StartsWith(flag, StringComparison.Ordinal));
        Assert.Equal(platform == "maui", lines.Any(line => line.TrimStart().StartsWith("--force", StringComparison.Ordinal)));
        Assert.Empty(capture.Error);
    }

    [Theory]
    [InlineData(32)]
    [InlineData(40)]
    [InlineData(80)]
    [InlineData(120)]
    [InlineData(180)]
    public void AliasColumnsPreserveAllAliasesWithoutOverflow(int width)
    {
        foreach (var platform in new[] { "maui", "wpf", "winforms", "winui", "blazor" })
        {
            var aliases = (platform == "maui" ? PackageCatalog.All.Select(package => package.Alias)
                : DesktopProviders.Find(platform)!.Packages.Select(package => package.Alias)).Order(StringComparer.OrdinalIgnoreCase).ToArray();
            var lines = HelpLayout.Aliases(aliases, width);
            Assert.All(lines, line => Assert.True(line.Length <= width, $"{platform}: {line}"));
            if (width >= 40)
                Assert.Equal(aliases, lines.SelectMany(line => Regex.Split(line.Trim(), @"\s+")).ToArray());
            else
                foreach (var alias in aliases) Assert.Contains(alias, string.Concat(lines.Select(line => line.Trim())));
            if (width >= 80) Assert.True(lines.Count < aliases.Length);
        }
    }

    [Fact]
    public void NarrowOptionFooterWrapsDescriptionsAndKeepsFlagsOnSeparateLines()
    {
        var lines = HelpLayout.PackageOptions(32, includeForce: true).Split('\n');
        Assert.All(lines, line => Assert.True(line.Length <= 32, line));
        Assert.Single(lines, line => line.Trim() == "--configfile <file>");
        Assert.Single(lines, line => line.Trim() == "--force");
        Assert.Contains("    Use a NuGet configuration", lines);
    }
}
