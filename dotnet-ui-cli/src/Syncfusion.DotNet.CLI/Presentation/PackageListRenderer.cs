using System.Text.RegularExpressions;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Shared, plain-text package discovery presentation.</summary>
internal static class PackageListRenderer
{
    internal sealed record Entry(string Alias, string DisplayName, string PackageId,
        string Category, string Classification, IReadOnlyList<string> Details);

    private static Entry ToEntry(DiscoveryService.PackageInfo package)
        => new(package.Alias, package.DisplayName, package.PackageId, package.Category,
            package.Classification, Details(package).ToArray());

    internal static void Write(
        ConsolePresenter presenter,
        IReadOnlyList<DiscoveryService.PackageInfo> packages,
        GlobalOptions globals,
        bool details = false,
        CancellationToken cancellationToken = default)
    {
        Write(presenter, packages.Select(ToEntry).ToArray(), globals, ".NET MAUI", details, cancellationToken);
    }

    internal static void Write(ConsolePresenter presenter, IReadOnlyList<Entry> packages,
        GlobalOptions globals, string platformName, bool details = false, CancellationToken cancellationToken = default)
    {
        var interactive = InteractivePrompt.CanPrompt(globals) && !Console.IsOutputRedirected;
        var width = Console.IsOutputRedirected ? 120 : Math.Max(20, Console.WindowWidth);
        var pageSize = interactive ? Math.Max(5, Console.WindowHeight - 5) : int.MaxValue;
        var lines = Format(packages, width, platformName, details);
        WritePages(lines, pageSize, line => Console.Out.WriteLine(line), () =>
            InteractivePrompt.Confirm("More packages? (Enter = more)", true, cancellationToken, presenter.NoColor),
            cancellationToken);
        if (globals.Verbose && !details)
        {
            foreach (var package in packages)
            {
                foreach (var line in package.Details) { presenter.WriteVerbose(line); }
            }
        }
    }

    internal static void WritePages(
        IReadOnlyList<string> lines,
        int pageSize,
        Action<string> write,
        Func<bool> continuePage,
        CancellationToken cancellationToken = default)
    {
        for (var index = 0; index < lines.Count; index++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (index > 0 && index % pageSize == 0 && !continuePage()) { return; }
            cancellationToken.ThrowIfCancellationRequested();
            write(lines[index]);
        }
    }

    internal static IReadOnlyList<string> Format(
        IReadOnlyList<DiscoveryService.PackageInfo> packages, int width, bool details = false)
    {
        return Format(packages.Select(ToEntry).ToArray(), width, ".NET MAUI", details);
    }

    internal static IReadOnlyList<string> Format(IReadOnlyList<Entry> packages, int width, string platformName, bool details = false)
    {
        var lines = new List<string>();
        lines.AddRange(Wrap($"Syncfusion {platformName} packages", width));
        var headers = new[] { "Alias", "Name", "NuGet" };
        var values = packages.Select(package => new[] { package.Alias, package.DisplayName, package.PackageId }).ToList();
        var widths = Enumerable.Range(0, headers.Length)
            .Select(column => Math.Max(headers[column].Length, values.Select(row => row[column].Length).DefaultIfEmpty(0).Max()))
            .ToArray();
        var minimums = Enumerable.Range(0, headers.Length)
            .Select(column => Math.Max(headers[column].Length, values.SelectMany(row =>
                Regex.Split(row[column], @"\s+|(?<=[.\-/])")).Select(word => word.Length).DefaultIfEmpty(0).Max()))
            .ToArray();
        var table = minimums.Sum() + 4 <= width;
        if (table)
        {
            // Shrink only when content needs more room than the terminal provides; never stretch.
            while (widths.Sum() + 4 > width)
            {
                var column = Enumerable.Range(0, widths.Length).MaxBy(index => widths[index] - minimums[index]);
                widths[column]--;
            }
            AddRow(lines, headers, widths);
        }
        else
        {
            lines.Add(string.Join("  ", headers));
        }

        var firstGroup = true;
        foreach (var section in packages.GroupBy(SectionOrder).OrderBy(group => group.Key))
        {
            foreach (var category in section.GroupBy(package =>
                         package.Category.Equals("Unresolved", StringComparison.OrdinalIgnoreCase) ? "Other" : package.Category)
                         .OrderBy(group => group.Key, StringComparer.OrdinalIgnoreCase))
            {
                if (!firstGroup) { lines.Add(string.Empty); }
                firstGroup = false;
                foreach (var package in category.OrderBy(package => package.DisplayName, StringComparer.OrdinalIgnoreCase)
                             .ThenBy(package => package.Alias, StringComparer.OrdinalIgnoreCase))
                {
                    if (table)
                    {
                        AddRow(lines, [package.Alias, package.DisplayName, package.PackageId], widths);
                    }
                    else
                    {
                        // Alias starts each record; name and NuGet ID use consistent indentation.
                        lines.AddRange(Wrap(package.Alias, width));
                        lines.AddRange(Wrap(package.DisplayName, width - 2).Select(line => "  " + line));
                        lines.AddRange(Wrap(package.PackageId, width - 4).Select(line => "    " + line));
                    }
                    if (details)
                    {
                        foreach (var line in package.Details) { lines.AddRange(Wrap(line, width)); }
                    }
                }
            }
        }
        return lines;
    }

    private static int SectionOrder(Entry package)
        => package.Classification switch
        {
            "dependency-only" or "shared-infrastructure" => 2,
            "development-tool" => 3,
            _ => 0,
        };

    private static IEnumerable<string> Details(DiscoveryService.PackageInfo package)
    {
        yield return $"{package.Alias}: {package.Description}";
        yield return $"Release status: {package.Status}";
        yield return $"CLI setup support: {(package.Recommended ? "included in the interactive package picker" : "explicit package arguments; absent from the interactive picker")}";
        yield return "CLI setup support is independent of package availability and release status.";
        yield return $"Classification: {package.Classification}; family: {package.ProductFamily}";
        yield return $"Registration: {package.RegistrationRequirement}";
        yield return PackageOperationService.VersionStrategyLabel(package.VersionStrategy);
        if (PackageCatalog.TryResolve(package.Alias, out var definition))
        {
            yield return $"Documentation: {definition.DocumentationUrl ?? "not verified"}";
            yield return $"Registration evidence: {definition.RegistrationEvidence}";
        }
        if (!string.IsNullOrWhiteSpace(package.VerificationNotes))
        {
            yield return $"Verification notes: {package.VerificationNotes}";
        }
    }

    private static void AddRow(List<string> lines, string[] values, int[] widths)
    {
        var cells = values.Select((value, index) => Wrap(value, widths[index]).ToList()).ToList();
        for (var row = 0; row < cells.Max(cell => cell.Count); row++)
        {
            lines.Add(string.Join("  ", cells.Select((cell, column) =>
                (row < cell.Count ? cell[row] : string.Empty).PadRight(widths[column]))).TrimEnd());
        }
    }

    internal static IEnumerable<string> Wrap(string value, int width)
    {
        // Whitespace is preferred. IDs/URLs can also wrap after punctuation, preserving whole words.
        var line = string.Empty;
        foreach (var word in value.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries))
        {
            var pieces = word.Length <= width ? [word] : Regex.Split(word, @"(?<=[.\-/])");
            var firstPiece = true;
            foreach (var piece in pieces.Where(piece => piece.Length > 0))
            {
                var separator = line.Length > 0 && firstPiece ? " " : "";
                if (line.Length + separator.Length + piece.Length > width && line.Length > 0)
                {
                    yield return line;
                    line = string.Empty;
                    separator = string.Empty;
                }
                line += separator + piece;
                firstPiece = false;
            }
        }
        if (line.Length > 0) { yield return line; }
    }
}
