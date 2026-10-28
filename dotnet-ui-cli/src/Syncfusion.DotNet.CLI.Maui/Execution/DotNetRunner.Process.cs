using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// Process-launch half of <see cref="DotNetRunner"/>. Kept in a partial to
/// mirror the <c>NuGetRunner</c> implementation while staying unit-testable
/// through the injectable constructor.
/// </summary>
public partial class DotNetRunner
{
    private async Task<ProcessCommandResult> RunProcessAsync(IReadOnlyList<string> args, string? workingDirectory, CancellationToken cancellationToken)
    {
        var psi = new ProcessStartInfo
        {
            FileName = string.IsNullOrWhiteSpace(_dotnetPath) ? DotNetHostResolver.Resolve() : _dotnetPath!,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true,
        };

        if (!string.IsNullOrWhiteSpace(workingDirectory))
        {
            psi.WorkingDirectory = workingDirectory;
        }

        foreach (var arg in args)
        {
            psi.ArgumentList.Add(arg);
        }

        using var process = new Process { StartInfo = psi };

        process.Start();
        var stdoutTask = process.StandardOutput.ReadToEndAsync();
        var stderrTask = process.StandardError.ReadToEndAsync();

        using var registration = cancellationToken.Register(() =>
        {
            try { if (!process.HasExited) { process.Kill(entireProcessTree: true); } }
            catch { /* best-effort cleanup on cancellation */ }
        });

        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);
        var stdout = await stdoutTask.ConfigureAwait(false);
        var stderr = await stderrTask.ConfigureAwait(false);

        return new ProcessCommandResult
        {
            ExitCode = process.ExitCode,
            StandardOutput = stdout,
            StandardError = stderr,
        };
    }

}
