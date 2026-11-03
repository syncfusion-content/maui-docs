using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Syncfusion.DotNet.Cli.Maui.Manifest;

namespace Syncfusion.DotNet.Cli.Maui.Injection;

/// <summary>Explicit, hash-protected ownership boundaries within user-authored files.</summary>
public static class GeneratedCodeBlocks
{
    private static readonly Regex Blocks = new(
        @"(?m)^[ \t]*(?://|<!--) <sf-cli:(?<id>[a-zA-Z0-9:_-]+)>(?: -->)?\r?\n.*?^[ \t]*(?://|<!--) </sf-cli:\k<id>>(?: -->)?[^\S\r\n]*(?:\r?\n|$)",
        RegexOptions.Singleline | RegexOptions.CultureInvariant);

    public static string Wrap(string marker, string content, bool xaml = false, string indent = "")
    {
        var start = xaml ? $"<!-- <sf-cli:{marker}> -->" : $"// <sf-cli:{marker}>";
        var end = xaml ? $"<!-- </sf-cli:{marker}> -->" : $"// </sf-cli:{marker}>";
        return $"{indent}{start}\n{content.TrimEnd('\r', '\n')}\n{indent}{end}\n";
    }

    public static IReadOnlyList<GeneratedBlockRecord> CaptureNew(string path, string before, string after)
    {
        var oldIds = Blocks.Matches(before).Select(match => match.Groups["id"].Value).ToHashSet(StringComparer.Ordinal);
        return Blocks.Matches(after).Where(match => !oldIds.Contains(match.Groups["id"].Value))
            .Select(match => new GeneratedBlockRecord { Path = path, Marker = match.Groups["id"].Value, Hash = Hash(match.Value) }).ToArray();
    }

    public static string? Conflict(string projectRoot, GeneratedBlockRecord record)
    {
        var path = TemplatePathResolver.ResolveDestination(projectRoot, record.Path);
        if (!File.Exists(path)) return $"Generated block '{record.Marker}' is missing from '{record.Path}'.";
        var text = File.ReadAllText(path);
        var matches = Blocks.Matches(text).Where(match => match.Groups["id"].Value == record.Marker).ToList();
        if (matches.Count > 0 && record.Marker.StartsWith("sf-nav:", StringComparison.Ordinal)
            && LegacyLines(text, record.Marker).Count > 0)
            return $"Navigation marker '{record.Marker}' in '{record.Path}' is duplicated outside its owned block. No changes made.";
        if (matches.Count == 0 && record.Marker.StartsWith("sf-nav:", StringComparison.Ordinal))
        {
            var legacy = LegacyLines(File.ReadAllText(path), record.Marker);
            if (legacy.Count == 1 && Hash(legacy[0].Value.Trim()) == record.Hash) return null;
        }
        return matches.Count == 1 && Hash(matches[0].Value) == record.Hash
            ? null : $"Generated block '{record.Marker}' in '{record.Path}' was edited or is missing. No changes made.";
    }

    public static string Remove(string text, string marker)
    {
        var updated = Blocks.Replace(text, match => match.Groups["id"].Value == marker ? string.Empty : match.Value);
        if (marker.StartsWith("sf-nav:", StringComparison.Ordinal))
            foreach (var line in LegacyLines(updated, marker).Cast<Match>().Reverse()) updated = updated.Remove(line.Index, line.Length);
        return updated;
    }

    public static GeneratedBlockRecord? ReconstructLegacyNavigation(string path, string text, string controlName, string expectedLine)
    {
        var marker = "sf-nav:" + controlName;
        var matches = LegacyLines(text, marker);
        if (matches.Count != 1 || matches[0].Value.Trim() != expectedLine.Trim()) return null;
        return new GeneratedBlockRecord { Path = path, Marker = marker, Hash = Hash(matches[0].Value.Trim()) };
    }

    private static MatchCollection LegacyLines(string text, string marker)
        => Regex.Matches(text, @"(?m)^[ \t]*[^\r\n]*?(?:<!-- " + Regex.Escape(marker)
            + @" -->|// " + Regex.Escape(marker) + @")[ \t]*(?:\r?\n|$)", RegexOptions.CultureInvariant);

    public static bool IsMissing(string root, GeneratedBlockRecord record)
    {
        var path = TemplatePathResolver.ResolveDestination(root, record.Path);
        return File.Exists(path) && !File.ReadAllText(path).Contains("sf-cli:" + record.Marker, StringComparison.Ordinal);
    }

    private static string Hash(string text)
        => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text.Replace("\r\n", "\n")))).ToLowerInvariant();
}
