using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// Invokes the official <c>dotnet</c> CLI for package add/remove operations.
/// Captures stdout, stderr, and the exit code, and supports cancellation.
/// The CLI never modifies NuGet configuration or stores credentials; it only
/// uses nuget.org explicitly and preserves other user-supplied configuration settings.
/// </summary>
public class NuGetRunner
{
    /// <summary>Default constructor uses the system dotnet executable.</summary>
    public NuGetRunner()
        : this(null)
    {
    }

    /// <summary>Constructor that lets tests inject a custom dotnet executable path.</summary>
    public NuGetRunner(string? dotnetPath)
    {
        DotNetPath = string.IsNullOrWhiteSpace(dotnetPath) ? DotNetHostResolver.Resolve() : dotnetPath!;
    }

    /// <summary>The resolved dotnet executable path.</summary>
    public string DotNetPath { get; }

    /// <summary>
    /// Runs a NuGet package operation. Returns the captured result. When
    /// <see cref="NuGetOperation.DryRun"/> is set, no process is started and a
    /// synthetic result is returned with the command line in stdout.
    /// Virtual so tests can inject a fake without launching a real process.
    /// </summary>
    public virtual async Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
    {
        if (operation.Kind == NuGetOperationKind.Add && operation.PackageId.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase) && !operation.DryRun)
        {
            NuGetSources.ResolveSource(operation.Source);
            var version = await NuGetPackageVersions.ResolveAsync(operation.PackageId, operation.Version,
                new ToolRunner(), cancellationToken, DotNetPath).ConfigureAwait(false);
            operation = new NuGetOperation
            {
                Kind = operation.Kind, ProjectPath = operation.ProjectPath, PackageId = operation.PackageId,
                Version = version, Source = NuGetSources.DefaultPublicFeed, ConfigFile = operation.ConfigFile,
                NoRestore = operation.NoRestore, DryRun = operation.DryRun, WorkingDirectory = operation.WorkingDirectory,
                StageProgress = operation.StageProgress,
            };
        }
        var args = NuGetArgumentBuilder.Build(operation);
        if (operation.DryRun)
        {
            return new NuGetCommandResult
            {
                ExitCode = 0,
                StandardOutput = NuGetArgumentBuilder.FormatCommandLine(args),
                StandardError = string.Empty,
            };
        }

        return await RunProcessAsync(args, operation.WorkingDirectory, cancellationToken, operation.StageProgress);
    }

    private async Task<NuGetCommandResult> RunProcessAsync(IReadOnlyList<string> args, string? workingDirectory, CancellationToken cancellationToken, IProgress<string>? progress)
    {
        var psi = new ProcessStartInfo
        {
            FileName = DotNetPath,
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

        var stdout = string.Empty;
        var stderr = string.Empty;

        process.Start();
        using var restoring = new OperationStages(progress);
        var stdoutTask = CaptureOutputAsync(process.StandardOutput, progress is null ? null : () =>
        {
            if (!cancellationToken.IsCancellationRequested) restoring.Start("Restoring");
        });
        var stderrTask = process.StandardError.ReadToEndAsync();

        using var registration = cancellationToken.Register(() =>
        {
            try { if (!process.HasExited) { process.Kill(entireProcessTree: true); } }
            catch { /* best-effort cleanup on cancellation */ }
        });

        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);
        stdout = await stdoutTask.ConfigureAwait(false);
        stderr = await stderrTask.ConfigureAwait(false);
        if (process.ExitCode == 0) restoring.Complete();

        return new NuGetCommandResult
        {
            ExitCode = process.ExitCode,
            StandardOutput = stdout,
            StandardError = stderr,
        };
    }

    private static async Task<string> CaptureOutputAsync(StreamReader reader, Action? reportRestore)
    {
        if (reportRestore is null) return await reader.ReadToEndAsync().ConfigureAwait(false);
        var output = new System.Text.StringBuilder();
        var buffer = new char[4096];
        var restoring = false;
        int count;
        while ((count = await reader.ReadAsync(buffer.AsMemory()).ConfigureAwait(false)) > 0)
        {
            output.Append(buffer, 0, count); // Preserve the original captured bytes/newlines as text.
            if (!restoring)
            {
                var start = Math.Max(0, output.Length - count - 256);
                var chunk = output.ToString(start, output.Length - start);
                if (chunk.Contains("Determining projects to restore", StringComparison.OrdinalIgnoreCase)
                    || chunk.Contains("Restoring packages for", StringComparison.OrdinalIgnoreCase))
                {
                    restoring = true;
                    reportRestore();
                }
            }
        }
        return output.ToString();
    }
}
