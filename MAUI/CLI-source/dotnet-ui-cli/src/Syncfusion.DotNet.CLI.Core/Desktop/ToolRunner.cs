using System.Diagnostics;

namespace Syncfusion.DotNet.CLI.Core;

public sealed record ToolResult(int ExitCode, string Output, string Error)
{
    public bool Success => ExitCode == 0;
}

/// <summary>Argument-vector process execution with output capture and cancellation.</summary>
public class ToolRunner
{
    public virtual async Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null,
        CancellationToken cancellationToken = default, string? executable = null)
    {
        var start = new ProcessStartInfo(executable ?? DotNetHostResolver.Resolve())
        {
            UseShellExecute = false, RedirectStandardOutput = true, RedirectStandardError = true,
        };
        if (directory is not null) start.WorkingDirectory = directory;
        foreach (var arg in args) start.ArgumentList.Add(arg);
        using var process = Process.Start(start) ?? throw new InvalidOperationException("Could not start the required build tool.");
        var output = process.StandardOutput.ReadToEndAsync(cancellationToken);
        var error = process.StandardError.ReadToEndAsync(cancellationToken);
        using var registration = cancellationToken.Register(() =>
        {
            try { if (!process.HasExited) process.Kill(entireProcessTree: true); }
            catch (InvalidOperationException) { }
        });
        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);
        return new ToolResult(process.ExitCode, await output.ConfigureAwait(false), await error.ConfigureAwait(false));
    }
}
