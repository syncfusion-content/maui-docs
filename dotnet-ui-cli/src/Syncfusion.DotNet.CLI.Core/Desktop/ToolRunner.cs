using System.Diagnostics;

namespace Syncfusion.DotNet.CLI.Core;

public sealed record ToolResult(int ExitCode, string Output, string Error)
{
    public bool Success => ExitCode == 0;
}

/// <summary>Argument-vector process execution with output capture and cancellation.</summary>
public class ToolRunner
{
    public virtual Task<ToolResult> RunAsync(IReadOnlyList<string> args, string? directory = null,
        CancellationToken cancellationToken = default, string? executable = null)
        => RunProcessAsync(args, directory, cancellationToken, executable);

    public virtual async Task<ToolResult> RunProcessAsync(IReadOnlyList<string> args, string? directory = null,
        CancellationToken cancellationToken = default, string? executable = null, bool inheritConsole = false,
        IReadOnlyDictionary<string, string>? environment = null)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var start = new ProcessStartInfo(executable ?? DotNetHostResolver.Resolve())
        {
            UseShellExecute = false, RedirectStandardOutput = !inheritConsole, RedirectStandardError = !inheritConsole,
        };
        if (directory is not null) start.WorkingDirectory = directory;
        foreach (var arg in args) start.ArgumentList.Add(arg);
        if (environment is not null)
            foreach (var (name, value) in environment) start.Environment[name] = value;
        using var process = Process.Start(start) ?? throw new InvalidOperationException("Could not start the required build tool.");
        var output = inheritConsole ? Task.FromResult("") : process.StandardOutput.ReadToEndAsync(cancellationToken);
        var error = inheritConsole ? Task.FromResult("") : process.StandardError.ReadToEndAsync(cancellationToken);
        using var registration = cancellationToken.Register(() =>
        {
            try { if (!process.HasExited) process.Kill(entireProcessTree: true); }
            catch (InvalidOperationException) { }
        });
        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);
        return new ToolResult(process.ExitCode, await output.ConfigureAwait(false), await error.ConfigureAwait(false));
    }
}
