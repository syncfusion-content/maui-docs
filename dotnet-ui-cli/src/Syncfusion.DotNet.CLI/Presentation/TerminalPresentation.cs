using System.Text;
using Spectre.Console;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Encoding and capability policy shared by every command and platform.</summary>
internal static class TerminalPresentation
{
    // Initialize before Spectre probes the console. In particular, Windows' legacy
    // code page otherwise turns arrows/checkmarks into replacement characters and
    // makes Spectre select its non-Unicode profile even in modern terminals.
    internal static void InitializeEncoding()
    {
        Console.OutputEncoding = new UTF8Encoding(false);
        if (!Console.IsInputRedirected) Console.InputEncoding = new UTF8Encoding(false);
    }

    internal static bool CanAnimate(IAnsiConsole console)
        => console.Profile.Capabilities.Ansi && console.Profile.Capabilities.Interactive
            && (!ReferenceEquals(console, AnsiConsole.Console) || !Console.IsOutputRedirected);

    internal static string Symbols(string text, IAnsiConsole console)
        => console.Profile.Capabilities.Unicode ? text : text
            .Replace("↑/↓", "Up/Down", StringComparison.Ordinal)
            .Replace("✓", "[OK]", StringComparison.Ordinal)
            .Replace("✗", "[FAIL]", StringComparison.Ordinal)
            .Replace("…", "...", StringComparison.Ordinal)
            .Replace("—", "-", StringComparison.Ordinal)
            .Replace("·", "-", StringComparison.Ordinal);
}
