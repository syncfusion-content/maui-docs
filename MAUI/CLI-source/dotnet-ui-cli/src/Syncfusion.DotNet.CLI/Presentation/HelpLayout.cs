namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>Plain-text, content-sized columns for platform help.</summary>
internal static class HelpLayout
{
    internal static int ConsoleWidth => Console.IsOutputRedirected || Console.WindowWidth <= 0 ? 120 : Console.WindowWidth;

    internal static IReadOnlyList<string> Aliases(IEnumerable<string> values, int width)
    {
        var aliases = values.Distinct(StringComparer.OrdinalIgnoreCase).Order(StringComparer.OrdinalIgnoreCase).ToArray();
        if (aliases.Length == 0) return [];
        var available = Math.Max(1, width - 2);
        for (var columns = aliases.Length; columns > 1; columns--)
        {
            var widths = Enumerable.Range(0, columns).Select(column => aliases
                .Where((_, index) => index % columns == column).Max(alias => alias.Length)).ToArray();
            if (widths.Sum() + (columns - 1) * 2 > available) continue;
            return aliases.Chunk(columns).Select(row => "  " + string.Join("  ", row.Select((alias, column) =>
                column == row.Length - 1 ? alias : alias.PadRight(widths[column])))).ToArray();
        }
        return aliases.SelectMany(alias => PackageListRenderer.Wrap(alias, available).Select(line => "  " + line)).ToArray();
    }

    internal static string PackageOptions(int width, bool includeForce)
    {
        var sections = PackageListRenderer.Wrap("Existing-project package options:", width).ToList();
        sections.AddRange(Options([
            ("-p, --path <project>", "Project file or directory."),
            ("--dry-run", "Preview changes without writing files."),
            ("--json", "Write JSON output."),
        ], width));
        sections.Add("");
        sections.AddRange(PackageListRenderer.Wrap("Package operation options (where applicable):", width));
        var options = new List<(string, string)>
        {
            ("-v, --version <version>", "Install an explicit package version."),
            ("--source <url>", "Syncfusion packages use nuget.org."),
            ("--configfile <file>", "Use a NuGet configuration file."),
            ("--no-restore", "Skip package restore."),
        };
        if (includeForce) options.Add(("--force", "Allow supported overwrites; edited samples stay protected."));
        sections.AddRange(Options(options, width));
        sections.Add("");
        sections.Add("Project target framework:");
        sections.AddRange(Options([("-t, --target-framework <tfm>", "Use -t only for the .NET target framework.")], width));
        return string.Join('\n', sections);
    }

    private static IEnumerable<string> Options(IReadOnlyList<(string Flag, string Description)> options, int width)
    {
        var flagWidth = options.Max(option => option.Flag.Length);
        var descriptionWidth = width - flagWidth - 4;
        foreach (var (flag, description) in options)
        {
            if (descriptionWidth < 24)
            {
                yield return "  " + flag;
                foreach (var line in PackageListRenderer.Wrap(description, Math.Max(1, width - 4))) yield return "    " + line;
                continue;
            }
            var first = true;
            foreach (var line in PackageListRenderer.Wrap(description, descriptionWidth))
            {
                yield return "  " + (first ? flag : "").PadRight(flagWidth) + "  " + line;
                first = false;
            }
        }
    }
}
