using System.Text.RegularExpressions;
using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Blazor;

public sealed class BlazorTemplateCapabilities(ToolRunner? runner = null)
{
    private readonly ToolRunner _runner = runner ?? new ToolRunner();

    public async Task<IReadOnlyList<string>> FrameworksAsync(BlazorAppType appType, CancellationToken cancellationToken = default)
    {
        var result = await _runner.RunAsync(["new", BlazorConfiguration.Template(appType), "--help"], cancellationToken: cancellationToken).ConfigureAwait(false);
        if (!result.Success) throw new InvalidOperationException($"The official {BlazorConfiguration.Template(appType)} template is unavailable. Install the ASP.NET Core templates for a supported .NET SDK.\n{result.Error}");
        var available = Regex.Matches(result.Output + result.Error, @"\bnet(?:8|9|10|11)\.0\b")
            .Select(match => match.Value).ToHashSet(StringComparer.Ordinal);
        return new[] { "net10.0", "net9.0", "net8.0", "net11.0" }.Where(available.Contains).ToArray();
    }
}
