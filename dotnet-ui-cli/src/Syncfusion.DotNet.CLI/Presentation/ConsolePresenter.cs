using Spectre.Console;
using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>
/// A small wrapper over <see cref="System.Console"/> that centralizes plain
/// text output and respects <c>--no-color</c>. Interactive prompts stay in
/// the wizard so command handlers remain free of console UI details.
/// Presenters never throw.
/// </summary>
public sealed class ConsolePresenter(bool noColor, bool verbose = false, bool json = false, bool silent = false)
{
    private readonly List<string> _privateNuGetValues = [];

    internal void ProtectNuGetConfiguration(string? source, string? configFile)
    {
        foreach (var value in new[] { source, configFile })
            if (!string.IsNullOrWhiteSpace(value)) _privateNuGetValues.Add(value);
    }

    internal string SafeText(string text) => ConsoleDiagnostics.Redact(text, _privateNuGetValues);

    /// <summary>True when color output should be suppressed.</summary>
    public bool NoColor => !ColorPolicy.AllowsColor(noColor, json, silent);

    /// <summary>True when diagnostic (verbose) output should be written.</summary>
    public bool Verbose => verbose;

    public void WriteInfo(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            System.Console.Out.WriteLine(message);
        }
    }

    internal void WriteAnswerLine(string text, int valueStart)
    {
        if (NoColor) { WriteInfo(text); return; }
        var split = Math.Clamp(valueStart, 0, text.Length);
        AnsiConsole.MarkupLine(Markup.Escape(text[..split]) + $"[{PresentationStyles.Answer.ToMarkup()}]" + Markup.Escape(text[split..]) + "[/]");
    }

    internal void WriteSelected(string text)
    {
        var colon = text.IndexOf(':');
        WriteAnswerLine(text, colon < 0 ? 0 : Math.Min(text.Length, colon + 2));
    }

    /// <summary>
    /// Writes a diagnostic message to stderr only when <c>--verbose</c> is
    /// active. Used by command handlers to surface the dotnet/dotnet add
    /// package commands they run and the exit codes they observe, without
    /// polluting normal stdout.
    /// </summary>
    public void WriteVerbose(string message)
    {
        if (verbose && !string.IsNullOrEmpty(message))
        {
            System.Console.Error.WriteLine($"verbose: {SafeText(message)}");
        }
    }

    public void WriteVersion(string version)
    {
        System.Console.Out.WriteLine($"{CliMetadata.ProductName} {version}");
    }

    public void WriteSuccess(string message)
    {
        if (string.IsNullOrEmpty(message)) return;
        var text = message.StartsWith("✓", StringComparison.Ordinal) ? message : "✓ " + message;
        text = TerminalPresentation.Symbols(text, AnsiConsole.Console);
        if (NoColor) WriteInfo(text);
        else Spectre.Console.AnsiConsole.MarkupLine($"[green]{Spectre.Console.Markup.Escape(text)}[/]");
    }

    public void WriteWarning(string message) => WriteDiagnostic("Warning:", message, "yellow");

    public void WriteError(string message) => WriteDiagnostic("Error:", message, "red");

    private void WriteDiagnostic(string prefix, string message, string color)
    {
        if (string.IsNullOrWhiteSpace(message)) return;
        var text = SafeText(message).TrimStart();
        if (!text.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) text = prefix + " " + text;
        if (!ColorPolicy.AllowsColor(noColor, json, silent,
                redirected: Console.IsOutputRedirected || Console.IsErrorRedirected))
        {
            Console.Error.WriteLine(text);
            return;
        }
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings
        {
            Ansi = Spectre.Console.AnsiSupport.Yes,
            Out = new Spectre.Console.AnsiConsoleOutput(Console.Error)
        });
        console.MarkupLine($"[{color}]{Spectre.Console.Markup.Escape(text)}[/]");
    }
}
