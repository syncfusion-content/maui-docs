using System.Collections.Generic;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// The result of running a <c>dotnet</c> template/restore/build command.
/// </summary>
public sealed class ProcessCommandResult
{
    public required int ExitCode { get; init; }
    public required string StandardOutput { get; init; }
    public required string StandardError { get; init; }
    public bool Success => ExitCode == 0;
}

/// <summary>
/// Runs an arbitrary <c>dotnet</c> command, capturing stdout, stderr, and the
/// exit code. The default implementation launches the real dotnet process;
/// tests inject a fake to verify the scaffolding flow without a real SDK.
/// </summary>
public partial class DotNetRunner
{
    private readonly string? _dotnetPath;

    public DotNetRunner() : this(null)
    {
    }

    public DotNetRunner(string? dotnetPath)
    {
        _dotnetPath = string.IsNullOrWhiteSpace(dotnetPath) ? null : dotnetPath;
    }

    /// <summary>
    /// Runs <c>dotnet</c> with the supplied arguments. When
    /// <paramref name="dryRun"/> is true, no process is launched and a
    /// synthetic success result is returned. Virtual so tests can inject a
    /// fake without launching a real process.
    /// </summary>
    public virtual Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
    {
        if (dryRun)
        {
            return Task.FromResult(new ProcessCommandResult
            {
                ExitCode = 0,
                StandardOutput = $"dotnet {string.Join(' ', args)}",
                StandardError = string.Empty,
            });
        }

        return RunProcessAsync(args, workingDirectory, cancellationToken);
    }
}
