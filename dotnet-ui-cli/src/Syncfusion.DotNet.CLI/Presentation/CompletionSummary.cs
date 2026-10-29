using System.Text.RegularExpressions;

namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>Formats existing result facts without changing the serialized Message.</summary>
internal static class CompletionSummary
{
    internal static void Write(ConsolePresenter presenter, string headline,
        IEnumerable<(string Label, string Value)> identity, string message, IEnumerable<string>? warnings = null, int? labelWidth = null)
    {
        var rows = identity.Select(row => (row.Label, Value: presenter.SafeText(row.Value))).ToList();
        var lines = presenter.SafeText(message).Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
        var notices = new List<string>();
        foreach (var line in lines)
        {
            if (line.StartsWith("Retained ", StringComparison.Ordinal) || line.StartsWith("Preserved ", StringComparison.Ordinal)
                || line.StartsWith("Automatic sample navigation", StringComparison.Ordinal) || line.StartsWith("File '", StringComparison.Ordinal))
            {
                notices.Add(line);
                continue;
            }
            var add = Regex.Match(line, @"^Packages: (.*?)\. Samples: (.*?)\. Build: (.*)$");
            var remove = Regex.Match(line, @"^Removed samples: (.*?)\. Deleted (\d+ generated file\(s\))\. Removed packages: (.*?)\. Build: (.*)$");
            if (add.Success)
            {
                rows.Add(("Packages:", add.Groups[1].Value));
                rows.Add(("Samples:", add.Groups[2].Value));
                rows.Add(("Build:", add.Groups[3].Value));
            }
            else if (remove.Success)
            {
                rows.Add(("Removed samples:", remove.Groups[1].Value));
                rows.Add(("Deleted files:", remove.Groups[2].Value));
                rows.Add(("Removed packages:", remove.Groups[3].Value));
                rows.Add(("Build:", remove.Groups[4].Value));
            }
            else
            {
                var package = Regex.Match(line, @"^Package (?:add|update|remove) succeeded: .*?\.(?: |$)(.*)$");
                if (!package.Success) rows.Add(("Result:", line));
                else if (package.Groups[1].Length > 0) rows.Add(("Samples:", package.Groups[1].Value));
            }
        }
        presenter.WriteSuccess(headline);
        rows = rows.Select(row => (row.Label, Value: !new[] { "Packages:", "Samples:", "Build:", "Result:", "Removed samples:", "Removed packages:" }.Contains(row.Label) || string.IsNullOrEmpty(row.Value) ? row.Value : char.ToUpperInvariant(row.Value[0]) + row.Value[1..])).ToList();
        foreach (var row in SummaryRows.Format(rows, labelWidth: labelWidth)) presenter.WriteInfo(row);
        foreach (var warning in notices.Concat(warnings ?? [])) presenter.WriteWarning(warning);
    }
}
