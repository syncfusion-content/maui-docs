using System.Collections.Generic;

namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// The official feed used for CLI package lookups and restores. User NuGet
/// configuration files are preserved; their local feeds cannot override this source.
/// </summary>
public static class NuGetSources
{
    /// <summary>The canonical nuget.org v3 feed.</summary>
    public const string DefaultPublicFeed = "https://api.nuget.org/v3/index.json";

    /// <summary>
    /// Accepts only the official public feed and returns the
    /// canonical nuget.org v3 feed. Always non-null and non-whitespace.
    /// </summary>
    public static string ResolveSource(string? userSource)
    {
        if (!string.IsNullOrWhiteSpace(userSource)
            && !userSource.Trim().TrimEnd('/').Equals(DefaultPublicFeed, StringComparison.OrdinalIgnoreCase))
            throw new ArgumentException("Syncfusion packages are installed only from nuget.org. Remove --source or use " + DefaultPublicFeed + ".");
        return DefaultPublicFeed;
    }

    /// <summary>
    /// Appends <c>--source &lt;url&gt; [--configfile &lt;path&gt;]</c> to a manual
    /// argument vector (for example the args used by <c>dotnet restore</c> or
    /// <c>dotnet package search</c>). Used by callers that build a dotnet
    /// argument list themselves and want the same nuget.org-only
    /// behaviour as <see cref="NuGetArgumentBuilder"/>.
    /// </summary>
    public static void AppendSourceAndConfigFile(
        IList<string> args,
        string? userSource,
        string? userConfigFile)
    {
        args.Add("--source");
        args.Add(ResolveSource(userSource));
        if (!string.IsNullOrWhiteSpace(userConfigFile))
        {
            args.Add("--configfile");
            args.Add(userConfigFile);
        }
    }
}
