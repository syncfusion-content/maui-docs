using System.Globalization;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>Owns only completed project-wizard rows, replacing them with the final review.</summary>
internal static class ProjectWizardOutput
{
    private static readonly AsyncLocal<Region?> Current = new();
    internal static bool HasCompletedValue(string label) => Current.Value?.Values.ContainsKey(label) == true;
    internal static bool IsCollecting => Current.Value is { Completed: false };

    public static IDisposable Begin(IAnsiConsole console, bool noColor = false)
    {
        var previous = Current.Value;
        if (previous?.Console == console) { return new Scope(() => { }); }
        Current.Value = new Region(console, ColorPolicy.AllowsLive(console, noColor));
        return new Scope(() => Current.Value = previous);
    }

    public static void WriteCompleted(IAnsiConsole console, string text)
        => WriteCompleted(console, text, text.Length, noColor: true);

    public static void WriteCompletedValue(IAnsiConsole console, string label, string value, bool noColor = false, bool alignValues = false)
    {
        if (Current.Value is { Completed: false } region && region.Console == console) region.Values[label] = value;
        if ((IsCollecting || alignValues) && ProjectFlowLayout.Contains(label))
        {
            foreach (var row in SummaryRows.FormatValues([(label, value)], console.Profile.Width, ProjectFlowLayout.ValueColumn))
                WriteCompleted(console, row.Text, row.ValueStart, noColor);
        }
        else WriteCompleted(console, $"{label} {value}", label.Length + 1, noColor);
    }

    private static void WriteCompleted(IAnsiConsole console, string text, int valueStart, bool noColor)
    {
        var offset = 0;
        void Write(string line)
        {
            var split = Math.Clamp(valueStart - offset, 0, line.Length);
            if (ColorPolicy.AllowsLive(console, noColor))
                console.MarkupLine(Markup.Escape(line[..split]) + $"[{PresentationStyles.Answer.ToMarkup()}]" + Markup.Escape(line[split..]) + "[/]");
            else console.WriteLine(line);
            offset += line.Length;
        }
        if (Current.Value is { Completed: false } region && region.Console == console)
        {
            foreach (var line in Wrap(text, Math.Max(2, console.Profile.Width)))
            {
                Write(line);
                region.Lines.Add(line);
            }
        }
        else
        {
            foreach (var line in Wrap(text, Math.Max(2, console.Profile.Width))) Write(line);
        }
    }

    public static void WriteAutomaticResult(string text)
    {
        if (Current.Value is { Completed: false } region) { WriteCompleted(region.Console, text); }
        else { System.Console.Out.WriteLine(text); }
    }

    public static void WriteAutomaticResult(string label, string value, bool noColor = false)
    {
        if (Current.Value is { Completed: false } region) WriteCompletedValue(region.Console, label, value, noColor);
        else new ConsolePresenter(noColor).WriteAnswerLine($"{label} {value}", label.Length + 1);
    }

    public static void WriteNotice(IAnsiConsole console, string text)
    {
        if (Current.Value is { Completed: false } region && region.Console == console)
        { region.Notices.Add(text); }
        WriteCompleted(console, text);
    }

    public static void ReuseCompletedSteps(ConsolePresenter presenter, IEnumerable<(string Label, string Value)> values)
    {
        var rows = values.ToArray();
        if (Current.Value is not { Completed: false } region)
        {
            SummaryRows.Write(presenter, rows, ProjectFlowLayout.ValueColumn);
            return;
        }
        SummaryRows.Write(presenter, rows.Where(row => !region.Values.ContainsKey(row.Label)), ProjectFlowLayout.ValueColumn);
        region.Completed = true;
    }

    public static void ReplaceCompletedSteps()
    {
        if (Current.Value is not { } region || region.Completed) { return; }
        region.Completed = true;
        var width = Math.Max(2, region.Console.Profile.Width);
        var rows = region.Lines.Sum(line => Math.Max(1, (new Segment(line).CellCount() + width - 1) / width));
        // The terminal clamps movement at the screen boundary; never clear scrollback.
        rows = Math.Min(rows, Math.Max(0, region.Console.Profile.Height - 1));
        if (rows == 0 || !region.Live) { return; }
        region.Console.Write(new ControlCode($"\u001b[{rows}F"));
        for (var index = 0; index < rows; index++)
        {
            region.Console.Write(new ControlCode("\u001b[2K\u001b[1E"));
        }
        region.Console.Write(new ControlCode($"\u001b[{rows}F"));
        region.Lines.Clear();
        foreach (var notice in region.Notices) { region.Console.WriteLine(notice); }
    }

    public static void WriteError(IAnsiConsole console, ConsolePresenter presenter, string error)
    {
        if (Current.Value is { Completed: false } region && region.Console == console)
        { WriteCompleted(console, error.StartsWith("Error:", StringComparison.OrdinalIgnoreCase) ? presenter.SafeText(error) : "Error: " + presenter.SafeText(error)); }
        else { presenter.WriteError(error); }
    }

    /// <summary>Wraps exact text at spaces/path separators, folding long segments without truncation.</summary>
    internal static IEnumerable<string> Wrap(string value, int width)
    {
        width = Math.Max(2, width);
        if (value.Length == 0) { yield return ""; yield break; }
        var start = 0;
        while (start < value.Length)
        {
            var end = start;
            var boundary = start;
            var cells = 0;
            var elements = StringInfo.GetTextElementEnumerator(value, start);
            while (elements.MoveNext())
            {
                var element = elements.GetTextElement();
                var size = new Segment(element).CellCount();
                if (cells + size > width && end > start) { break; }
                cells += size;
                end = start + elements.ElementIndex + element.Length;
                if (element is "/" or "\\" or "," or "." || element.All(char.IsWhiteSpace)) { boundary = end; }
            }
            if (end < value.Length && boundary > start) { end = boundary; }
            yield return value[start..end];
            start = end;
        }
    }

    private sealed class Region(IAnsiConsole console, bool live)
    {
        public IAnsiConsole Console { get; } = console;
        public bool Live { get; } = live;
        public List<string> Lines { get; } = [];
        public Dictionary<string, string> Values { get; } = [];
        public List<string> Notices { get; } = [];
        public bool Completed { get; set; }
    }

    private sealed class Scope(Action dispose) : IDisposable
    {
        public void Dispose() => dispose();
    }
}
