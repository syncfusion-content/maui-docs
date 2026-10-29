using System.Text.Json;
using System.Text.Json.Nodes;
using Syncfusion.DotNet.CLI.Hosting;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class PackageListPresentationTests
{
    [Theory]
    [InlineData("--json")]
    [InlineData("--details")]
    [InlineData("--verbose")]
    public async Task ToolkitIsNotListedInAnyOutputFormat(string format)
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "maui", "packages", format, "--no-interactive"]));
        Assert.DoesNotContain("Syncfusion.Maui.Toolkit", capture.Out);
        Assert.DoesNotContain("toolkit", capture.Out, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task ScriptedList_ReturnsVisiblePackagesWithOneHeaderWithoutTitlesCountsEvidenceOrPrompts()
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "maui", "packages", "--no-interactive"]));
        Assert.StartsWith("Syncfusion .NET MAUI packages" + Environment.NewLine, capture.Out);
        var lines = capture.Out.Split(Environment.NewLine);
        Assert.Single(lines, line => line.StartsWith("Alias  ", StringComparison.Ordinal));
        Assert.Contains("Name", lines[1]);
        Assert.Contains("NuGet", lines[1]);
        Assert.DoesNotContain("NuGet package ID", capture.Out);
        Assert.DoesNotContain("Customer controls", capture.Out);
        Assert.DoesNotContain("Infrastructure dependencies", capture.Out);
        Assert.DoesNotContain("Development tools", capture.Out);
        Assert.DoesNotContain("packages (", capture.Out);
        Assert.All(PackageCatalog.All.Where(package => package.Alias != "mcp"), package => Assert.Contains(package.Alias, capture.Out));
        Assert.DoesNotContain("Syncfusion.Maui.MCP", capture.Out);
        Assert.DoesNotContain("Package not recommended", capture.Out);
        Assert.DoesNotContain("Verification", capture.Out);
        Assert.DoesNotContain("evidence", capture.Out);
        Assert.DoesNotContain("More packages?", capture.Out);
        Assert.Empty(capture.Error);
    }

    [Theory]
    [InlineData("--details")]
    [InlineData("--verbose")]
    public async Task EvidenceRequiresExplicitOption_AndSupportIsSeparateFromRelease(string option)
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "maui", "packages", "--search", "expander", option, "--no-interactive"]));
        var output = option == "--details" ? capture.Out : capture.Error;
        Assert.Contains("Release status: stable", output);
        Assert.Contains("CLI setup support:", output);
        Assert.Contains("independent of package availability", output);
        Assert.Contains("Verification notes:", output);
        Assert.Contains("Registration evidence:", output);
        Assert.DoesNotContain("Package not recommended", output);
        if (option == "--verbose") { Assert.DoesNotContain("evidence", capture.Out); }
    }

    [Theory]
    [InlineData("expander")]
    [InlineData("Accordion")]
    [InlineData("Syncfusion.Maui.Expander")]
    public async Task ListFilterReusesSearch_AndKeepsJsonContract(string query)
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "packages", "maui", "--search", query, "--json"]));
        var packages = JsonSerializer.Deserialize<List<DiscoveryService.PackageInfo>>(capture.Out)!;
        Assert.Equal(DiscoveryService.SearchPackages(query), packages);
        Assert.Equal("expander", Assert.Single(packages).Alias);
    }

    [Theory]
    [InlineData(32)]
    [InlineData(40)]
    [InlineData(60)]
    [InlineData(80)]
    [InlineData(120)]
    [InlineData(240)]
    public void ResponsiveLayout_PreservesEveryNameAndIdWithoutOverflow(int width)
    {
        var packages = DiscoveryService.ListPackages();
        var lines = PackageListRenderer.Format(packages, width);
        Assert.All(lines, line => Assert.True(line.Length <= width, $"{line.Length} > {width}: {line}"));
        var text = string.Join("\n", lines);
        Assert.All(packages, package =>
        {
            foreach (var segment in package.Alias.Split('-')) { Assert.Contains(segment, text); }
            foreach (var word in package.DisplayName.Split(' ')) { Assert.Contains(word, text); }
            // Punctuation boundaries can wrap identifiers, but no segment may be split.
            foreach (var segment in package.PackageId.Split('.')) { Assert.Contains(segment, text); }
        });
        Assert.Equal(lines, PackageListRenderer.Format(packages.Reverse().ToList(), width));
    }

    [Fact]
    public void UnknownCategoryRemainsVisibleWithoutCategoryTitles()
    {
        var packages = DiscoveryService.ListPackages();
        var unknown = packages.Single(package => package.Alias == "calendar") with { Category = "Unresolved" };
        var output = string.Join("\n", PackageListRenderer.Format([unknown], 120));
        Assert.DoesNotContain("Other", output);
        Assert.DoesNotContain("Unresolved", output);
        Assert.Contains(unknown.PackageId, output);
    }

    [Fact]
    public void WideLayout_IsContentSizedWithGlobalAlignmentAndOnlyOneBlankBetweenGroups()
    {
        var packages = DiscoveryService.ListPackages().Where(package => package.Alias != "mcp").ToList();
        var lines = PackageListRenderer.Format(packages, 240);
        Assert.Equal(lines, PackageListRenderer.Format(packages, 120));
        var header = lines[1];
        var nameStart = header.IndexOf("Name", StringComparison.Ordinal);
        var nugetStart = header.IndexOf("NuGet", StringComparison.Ordinal);
        Assert.Equal(packages.Max(package => package.Alias.Length) + 2, nameStart);
        Assert.Equal(nameStart + packages.Max(package => package.DisplayName.Length) + 2, nugetStart);
        Assert.Single(lines, line => line.Contains("NuGet", StringComparison.Ordinal));
        Assert.Equal("Syncfusion .NET MAUI packages", lines[0]);
        var rows = lines.Skip(2).Where(line => line.Length > 0).ToList();
        Assert.Equal(packages.Count, rows.Count);
        foreach (var package in packages)
        {
            var row = Assert.Single(rows, line => line.StartsWith(package.Alias + "  ", StringComparison.Ordinal));
            Assert.Equal(package.DisplayName, row[nameStart..nugetStart].Trim());
            Assert.Equal(package.PackageId, row[nugetStart..]);
        }
        Assert.DoesNotContain(lines.Zip(lines.Skip(1)), pair => pair.First.Length == 0 && pair.Second.Length == 0);
        Assert.False(string.IsNullOrEmpty(lines[^1]));
        var groups = string.Join("\n", lines.Skip(2)).Split("\n\n");
        var expectedGroups = packages.GroupBy(package => package.Classification switch
            {
                "dependency-only" or "shared-infrastructure" => 2,
                "development-tool" => 3,
                _ => 0,
            }).OrderBy(group => group.Key)
            .SelectMany(section => section.GroupBy(package => package.Category)
                .OrderBy(group => group.Key, StringComparer.OrdinalIgnoreCase))
            .Select(group => group.OrderBy(package => package.DisplayName, StringComparer.OrdinalIgnoreCase)
                .ThenBy(package => package.Alias, StringComparer.OrdinalIgnoreCase)
                .Select(package => package.Alias).ToList()).ToList();
        Assert.Equal(expectedGroups.Count, groups.Length);
        for (var index = 0; index < groups.Length; index++)
        {
            Assert.Equal(expectedGroups[index], groups[index].Split('\n').Select(line => line[..nameStart].Trim()));
        }
    }

    [Theory]
    [InlineData("--details")]
    [InlineData("--verbose")]
    [InlineData("--json")]
    public async Task ListingFilterExcludesMcpWithoutChangingCatalogSearchOrOperations(string option)
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "maui", "packages", "--search", "Syncfusion.Maui.MCP", option, "--no-interactive"]));
        Assert.DoesNotContain("MCP", capture.Out, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("MCP", capture.Error, StringComparison.OrdinalIgnoreCase);
        if (option == "--json") { Assert.Empty(JsonSerializer.Deserialize<List<DiscoveryService.PackageInfo>>(capture.Out)!); }
        Assert.Equal(51, PackageCatalog.All.Count);
        Assert.True(PackageCatalog.TryResolve("mcp", out var package));
        Assert.Equal("Syncfusion.Maui.MCP", package.PackageId);
        Assert.Equal(package.PackageId, Assert.Single(DiscoveryService.SearchPackages(package.PackageId)).PackageId);
    }

    [Fact]
    public async Task UnfilteredJsonListExcludesOnlyMcpAndKeepsEveryOtherRecordUnchanged()
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(0, await CliApp.Build().RunAsync(["list", "maui", "packages", "--json", "--no-interactive"]));
        var packages = JsonSerializer.Deserialize<List<DiscoveryService.PackageInfo>>(capture.Out)!;
        Assert.Equal(DiscoveryService.ListPackages().Where(package => package.PackageId != "Syncfusion.Maui.MCP"), packages);
    }

    [Fact]
    public void Pagination_ContinuesStopsAndCancels_WithoutLosingLines()
    {
        var lines = PackageListRenderer.Format(DiscoveryService.ListPackages(), 80);
        var written = new List<string>();
        var prompts = 0;
        PackageListRenderer.WritePages(lines, 10, written.Add, () => { prompts++; return true; });
        Assert.Equal(lines, written);
        Assert.Equal((lines.Count - 1) / 10, prompts);
        written.Clear();
        PackageListRenderer.WritePages(lines, 10, written.Add, () => false);
        Assert.Equal(lines.Take(10), written);
        using var cancellation = new CancellationTokenSource();
        Assert.Throws<OperationCanceledException>(() => PackageListRenderer.WritePages(lines, 10, _ => { }, () =>
        {
            cancellation.Cancel();
            return true;
        }, cancellation.Token));
        PackageListRenderer.WritePages(lines, int.MaxValue, _ => { }, () => throw new Exception("Scripts must never prompt."));
    }

    [Theory]
    [InlineData("schema")]
    [InlineData("missing-recommended")]
    [InlineData("missing-alias")]
    [InlineData("empty")]
    [InlineData("duplicate-alias")]
    [InlineData("duplicate-id")]
    [InlineData("invalid-status")]
    [InlineData("null-alias")]
    public void PackageJsonRejectsInvalidStructureAndMetadata(string corruption)
    {
        using var resource = typeof(PackageCatalog).Assembly.GetManifestResourceStream(
            "Syncfusion.DotNet.CLI.Maui.Catalog.package-catalog.json")!;
        var document = JsonNode.Parse(resource)!;
        var packages = document["packages"]!.AsArray();
        switch (corruption)
        {
            case "schema": document["schemaVersion"] = 2; break;
            case "missing-recommended": packages[0]!.AsObject().Remove("recommended"); break;
            case "missing-alias": packages[0]!.AsObject().Remove("alias"); break;
            case "empty": packages.Clear(); break;
            case "duplicate-alias": packages[1]!["alias"] = packages[0]!["alias"]!.GetValue<string>(); break;
            case "duplicate-id": packages[1]!["packageId"] = packages[0]!["packageId"]!.GetValue<string>(); break;
            case "invalid-status": packages[0]!["status"] = "awesome"; break;
            case "null-alias": packages[0]!["alias"] = null; break;
        }
        using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(document.ToJsonString()));
        var error = Record.Exception(() => CatalogLoader.ParsePackages(stream));
        Assert.NotNull(error);
        Assert.True(error is JsonException or InvalidOperationException, error.ToString());
    }
}
