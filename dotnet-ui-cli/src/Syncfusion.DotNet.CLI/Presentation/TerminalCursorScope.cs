using Spectre.Console;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Restores cursor visibility even when a prompt or operation throws.</summary>
internal sealed class TerminalCursorScope : IDisposable
{
    private readonly IAnsiConsole _console;
    private readonly bool _enabled;
    private readonly bool _visible = true;

    internal TerminalCursorScope(IAnsiConsole console, bool enabled = true)
    {
        _console = console;
        _enabled = enabled && TerminalPresentation.CanAnimate(console);
        // Unix does not expose a safe, nonblocking visibility query. Its normal
        // shell state is visible; do not send a query that could consume input.
        if (_enabled && OperatingSystem.IsWindows() && ReferenceEquals(console, AnsiConsole.Console) && !Console.IsOutputRedirected)
        {
            try { _visible = Console.CursorVisible; }
            catch (IOException) { }
        }
    }

    public void Dispose() { if (_enabled) _console.Cursor.Show(_visible); }
}
