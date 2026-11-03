using System.Collections.Generic;
using System.IO;

namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// The options for a NuGet package operation performed via the official
/// <c>dotnet</c> CLI. The CLI never invokes the NuGet APIs directly, never
/// modifies user/machine/repo NuGet configuration, and never stores
/// credentials; it only constructs the argument list and invokes
/// <c>dotnet add package</c>/<c>remove package</c>.
/// </summary>
public sealed class NuGetOperation
{
    /// <summary>The operation kind.</summary>
    public required NuGetOperationKind Kind { get; init; }

    /// <summary>The project (.csproj) path the package operation targets.</summary>
    public required string ProjectPath { get; init; }

    /// <summary>The package id to add or remove.</summary>
    public required string PackageId { get; init; }

    /// <summary>An explicit package version; null resolves the latest stable nuget.org release at execution.</summary>
    public string? Version { get; init; }

    /// <summary>An explicit NuGet configuration file (<c>--configfile</c>).</summary>
    public string? ConfigFile { get; init; }

    /// <summary>An explicit package source (<c>--source</c>).</summary>
    public string? Source { get; init; }

    /// <summary>True to skip restore (<c>--no-restore</c>).</summary>
    public bool NoRestore { get; init; }

    /// <summary>True to preview only (<c>--dry-run</c>); no command is executed.</summary>
    public bool DryRun { get; init; }

    /// <summary>Optional observer; never part of command arguments or serialized output.</summary>
    [System.Text.Json.Serialization.JsonIgnore]
    public IProgress<string>? StageProgress { get; init; }

    /// <summary>The working directory for the dotnet process.</summary>
    public string? WorkingDirectory { get; init; }
}

/// <summary>The kind of NuGet operation.</summary>
public enum NuGetOperationKind
{
    Add,
    Remove,
}

/// <summary>
/// Builds the <c>dotnet add|remove package</c> argument list for a
/// <see cref="NuGetOperation"/>. Pure: no process invocation, no filesystem
/// mutation. The actual invocation is performed by <see cref="NuGetRunner"/>,
/// which captures stdout/stderr/exit code and supports cancellation.
/// </summary>
public static class NuGetArgumentBuilder
{
    /// <summary>
    /// Builds the argument vector for <c>dotnet</c>. The first element is the
    /// subcommand (<c>add</c> or <c>remove</c>); callers prepend the dotnet
    /// executable path when invoking a process.
    /// </summary>
    public static IReadOnlyList<string> Build(NuGetOperation operation)
    {
        if (operation.Kind == NuGetOperationKind.Add && operation.Version is not null
            && operation.PackageId.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase)
            && !NuGetPackageVersions.IsExact(operation.Version))
            throw new ArgumentException("Syncfusion package versions must be exact; floating versions and ranges are not supported.");
        var args = new List<string>();

        if (operation.Kind == NuGetOperationKind.Add)
        {
            args.Add("add");
            args.Add(operation.ProjectPath);
            args.Add("package");
            args.Add(operation.PackageId);

            if (!string.IsNullOrWhiteSpace(operation.Version))
            {
                args.Add("--version");
                args.Add(operation.Version!);
            }
        }
        else
        {
            args.Add("remove");
            args.Add(operation.ProjectPath);
            args.Add("package");
            args.Add(operation.PackageId);
        }

        // When the user did not pass --source, default to nuget.org so the
        // operation succeeds on machines where no source is preconfigured.
        // Centralized in NuGetSources so tests and the redactor see the same value.
        // 'dotnet remove package' does not accept --source/--configfile/--dry-run.
        if (operation.Kind == NuGetOperationKind.Remove)
        {
            return args;
        }

        var effectiveSource = NuGetSources.ResolveSource(operation.Source);
        args.Add("--source");
        args.Add(effectiveSource);

        if (!string.IsNullOrWhiteSpace(operation.ConfigFile))
        {
            args.Add("--configfile");
            args.Add(operation.ConfigFile!);
        }

        if (operation.NoRestore && operation.Kind == NuGetOperationKind.Add)
        {
            args.Add("--no-restore");
        }

        if (operation.DryRun)
        {
            args.Add("--dry-run");
        }

        return args;
    }

    /// <summary>Renders the argument list as a single shell-style command line for preview output.</summary>
    public static string FormatCommandLine(IReadOnlyList<string> args)
    {
        var sb = new System.Text.StringBuilder("dotnet");
        foreach (var arg in args)
        {
            sb.Append(' ');
            sb.Append(Quote(arg));
        }

        return sb.ToString();
    }

    private static string Quote(string arg)
        => arg.Contains(' ') ? "\"" + arg + "\"" : arg;
}

/// <summary>The captured result of a dotnet package command.</summary>
public sealed class NuGetCommandResult
{
    public required int ExitCode { get; init; }
    public required string StandardOutput { get; init; }
    public required string StandardError { get; init; }
    public bool Success => ExitCode == 0;
}
