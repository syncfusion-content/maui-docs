using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Hosting;
using Syncfusion.DotNet.Cli.Presentation;

namespace Syncfusion.DotNet.Cli;

/// <summary>
/// Program entry point. Kept intentionally small: it builds the command line,
/// wires Ctrl+C to a cancellation token, handles top-level exceptions, and
/// returns the exit code to the operating system.
/// </summary>
public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        TerminalPresentation.InitializeEncoding();
        using var cts = new CancellationTokenSource();
        using var consoleScope = ColorPolicy.InitializeConsole(args.Contains("--no-color", StringComparer.Ordinal),
            args.Contains("--json", StringComparer.Ordinal), () => System.Console.CancelKeyPress += (_, e) =>
        {
            // Cancel gracefully and prevent the hard process kill so the CLI
            // can return the conventional 130 exit code.
            e.Cancel = true;
            cts.Cancel();
        });

        try
        {
            var cli = CliApp.Build();
            return await cli.RunAsync(args, cts.Token).ConfigureAwait(false);
        }
        catch (OperationCanceledException)
        {
            return ExitCodes.Cancelled;
        }
#pragma warning disable CA1031 // Top-level catch-all keeps the tool from crashing into a stack trace.
        catch (Exception ex)
#pragma warning restore CA1031
        {
            ConsoleDiagnostics.Unexpected(new ConsolePresenter(args.Contains("--no-color", StringComparer.Ordinal),
                args.Contains("--verbose", StringComparer.Ordinal), args.Contains("--json", StringComparer.Ordinal)), ex, args);
            return ExitCodes.Unhandled;
        }
    }
}
