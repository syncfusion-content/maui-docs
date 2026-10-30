using Spectre.Console;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>
/// Shows a transient spinner while a slow step (network call, waiting for the browser) runs. The spinner is
/// only drawn in a live terminal; with --json, --no-color, redirected output or CI the work simply runs.
/// It is erased when the step finishes, so it never leaves anything behind.
/// </summary>
internal static class BusyIndicator
{
    internal static bool Enabled(bool json, bool noColor)
        => !json && ColorPolicy.AllowsLive(AnsiConsole.Console, noColor);

    internal static async Task<T> RunAsync<T>(bool enabled, string label, Func<Task<T>> work)
    {
        if (!enabled) return await work().ConfigureAwait(false);
        using var cursor = new TerminalCursorScope(AnsiConsole.Console);
        return await AnsiConsole.Status()
            .Spinner(Spinner.Known.Dots)
            .SpinnerStyle(Style.Parse("cyan"))
            .StartAsync(label, _ => work()).ConfigureAwait(false);
    }
}
