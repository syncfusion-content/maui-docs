namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>Content-sized columns, including missing aliases, with one header.</summary>
internal static class TableRows
{
    internal static IReadOnlyList<string> Format(string[] headers, IEnumerable<string[]> values)
    {
        var rows = values.Prepend(headers).ToArray();
        var widths = Enumerable.Range(0, headers.Length).Select(column => rows.Max(row => row[column].Length)).ToArray();
        return rows.Select(row => string.Join("  ", row.Select((value, column) => value.PadRight(widths[column]))).TrimEnd()).ToArray();
    }
}
