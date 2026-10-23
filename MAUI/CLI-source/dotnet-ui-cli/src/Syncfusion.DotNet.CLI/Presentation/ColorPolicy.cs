using Spectre.Console;

namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>One policy for color and live terminal output; explicit plain modes always win.</summary>
internal static class ColorPolicy
{
    internal static IDisposable InitializeConsole(bool noColor, bool json, Action initialize)
    {
        // Unix runtimes and child SDK tools can emit keypad-mode ANSI through
        // the controlling terminal, outside redirected stdout/stderr. Keep their
        // terminal settings plain for this invocation, including child commands.
        var plain = !AllowsColor(noColor, json);
        var term = Environment.GetEnvironmentVariable("TERM");
        var environmentColor = Environment.GetEnvironmentVariable("NO_COLOR");
        IAnsiConsole? originalConsole = null;
        void Restore()
        {
            if (!plain) return;
            Environment.SetEnvironmentVariable("TERM", term);
            Environment.SetEnvironmentVariable("NO_COLOR", environmentColor);
            if (originalConsole is not null) AnsiConsole.Console = originalConsole;
        }
        try
        {
            if (plain)
            {
                if (!OperatingSystem.IsWindows()) Environment.SetEnvironmentVariable("TERM", "dumb");
                Environment.SetEnvironmentVariable("NO_COLOR", environmentColor ?? "1");
            }
            initialize();
            if (plain && !Console.IsOutputRedirected && !Console.IsInputRedirected)
            {
                // Input remains interactive; PlainPromptConsole filters all style
                // and cursor segments. TERM=dumb must not disable wizard input.
                originalConsole = AnsiConsole.Console;
                AnsiConsole.Console = AnsiConsole.Create(new AnsiConsoleSettings
                {
                    Ansi = AnsiSupport.Yes, ColorSystem = ColorSystemSupport.NoColors,
                    Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(Console.Out),
                });
            }
            return new ConsoleScope(Restore);
        }
        catch { Restore(); throw; }
    }

    private sealed class ConsoleScope(Action restore) : IDisposable
    {
        public void Dispose() => restore();
    }

    internal static bool AllowsColor(bool noColor, bool json = false, bool silent = false,
        bool? redirected = null, bool? noColorEnvironmentSet = null)
        => !noColor && !json && !silent
            && !(redirected ?? Console.IsOutputRedirected)
            && !(noColorEnvironmentSet ?? Environment.GetEnvironmentVariable("NO_COLOR") is not null);

    internal static bool AllowsLive(IAnsiConsole console, bool noColor)
        => TerminalPresentation.CanAnimate(console)
            && AllowsColor(noColor, redirected: ReferenceEquals(console, AnsiConsole.Console)
                ? Console.IsOutputRedirected : !console.Profile.Capabilities.Interactive);
}
