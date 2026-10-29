using Syncfusion.DotNet.CLI.Core;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class NuGetPackageVersionTests
{
    [Fact]
    public async Task ResolvesHighestStableExactMatchOnlyFromOfficialFeed()
    {
        var runner = new SearchRunner("""
            {"searchResult":[{"packages":[
                {"id":"Syncfusion.Test","version":"35.9.9"},
                {"id":"Syncfusion.Test","version":"35.10.1"},
                {"id":"Syncfusion.Test","version":"36.0.0-preview"},
                {"id":"Syncfusion.Other","version":"999.0.0"}
            ]}]}
            """);
        Assert.Equal("35.10.1", await NuGetPackageVersions.ResolveAsync("Syncfusion.Test", null, runner));
        Assert.Contains("--exact-match", runner.Arguments!);
        Assert.Equal(NuGetSources.DefaultPublicFeed, runner.Arguments![runner.Arguments.ToList().IndexOf("--source") + 1]);
    }

    [Theory]
    [InlineData("*")]
    [InlineData("35.*")]
    [InlineData("[35.0.0,36.0.0)")]
    public async Task RejectsFloatingVersionsAndRanges(string version)
    {
        await Assert.ThrowsAsync<ArgumentException>(() => NuGetPackageVersions.ResolveAsync("Syncfusion.Test", version, new SearchRunner("")));
    }

    [Theory]
    [InlineData("invalid json")]
    [InlineData("{\"searchResult\":[]}")]
    [InlineData("{\"searchResult\":[{\"packages\":[{\"id\":\"Syncfusion.Test\",\"version\":\"36.0.0-preview\"}]}]}")]
    public async Task FailedLookupNeverFallsBackToFloatingOrLocalVersions(string json)
    {
        await Assert.ThrowsAsync<InvalidOperationException>(() => NuGetPackageVersions.ResolveAsync("Syncfusion.Test", null, new SearchRunner(json)));
    }

    [Fact]
    public async Task PreservesExplicitVersionWithoutSearching()
    {
        var runner = new SearchRunner("");
        Assert.Equal("35.1.39", await NuGetPackageVersions.ResolveAsync("Syncfusion.Test", "35.1.39", runner));
        Assert.Null(runner.Arguments);
    }

    [Theory]
    [InlineData("C:\\LocalPackages")]
    [InlineData("https://private.example/v3/index.json")]
    public void RejectsLocalAndCustomSources(string source)
        => Assert.Throws<ArgumentException>(() => NuGetSources.ResolveSource(source));

    private sealed class SearchRunner(string json) : ToolRunner
    {
        public IReadOnlyList<string>? Arguments { get; private set; }
        public override Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null,
            CancellationToken cancellationToken = default, string? executable = null)
        {
            Arguments = args;
            return Task.FromResult(new ToolResult(0, json, ""));
        }
    }
}
