using Spectre.Console;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Aligned, lossless label/value rows shared with the project review.</summary>
internal static class SummaryRows
{
    internal static IReadOnlyList<(string Label, string Value)> PackageReview(IReadOnlyList<(string Label, string Value)> rows, string? explicitVersion)
        => rows.Where(row => row.Label != "Version:" || explicitVersion is not null).ToArray();

    internal static IReadOnlyList<string> Format(IEnumerable<(string Label, string Value)> values, int? terminalWidth = null, int? labelWidth = null)
        => FormatValues(values, terminalWidth, labelWidth).Select(row => row.Text).ToArray();

    internal static void Write(ConsolePresenter presenter, IEnumerable<(string Label, string Value)> values, int? labelWidth = null)
    {
        foreach (var row in FormatValues(values, terminalWidth: null, labelWidth)) presenter.WriteAnswerLine(row.Text, row.ValueStart);
    }

    internal static IReadOnlyList<(string Text, int ValueStart)> FormatValues(IEnumerable<(string Label, string Value)> values, int? terminalWidth, int? fixedLabelWidth = null)
    {
        var rows = values.ToArray();
        if (rows.Length == 0) return [];
        var labelWidth = fixedLabelWidth ?? rows.Max(row => row.Label.Length) + 1;
        var width = Math.Max(2, terminalWidth ?? AnsiConsole.Profile.Width);
        if (fixedLabelWidth is null && width < 48)
            return rows.SelectMany(row => ProjectWizardOutput.Wrap(row.Label, width).Select(line => (line, line.Length))
                .Concat(ProjectWizardOutput.Wrap(row.Value, Math.Max(2, width - 2)).Select(line => ("  " + line, 2)))).ToArray();
        var indent = new string(' ', labelWidth);
        return rows.SelectMany(row => ProjectWizardOutput.Wrap(row.Value, Math.Max(2, width - labelWidth))
            .Select((line, index) => ((index == 0 ? row.Label.PadRight(labelWidth) : indent) + line, labelWidth))).ToArray();
    }
}
