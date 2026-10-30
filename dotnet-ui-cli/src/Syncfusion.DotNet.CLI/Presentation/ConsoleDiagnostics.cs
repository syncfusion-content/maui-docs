using System.Text.RegularExpressions;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Console-only guidance; service results and JSON diagnostics remain untouched.</summary>
internal static class ConsoleDiagnostics
{
    internal static void Unexpected(ConsolePresenter presenter, Exception exception, IReadOnlyList<string> args)
    {
        for (var index = 0; index < args.Count; index++)
        {
            if (args[index] is "--source" or "--configfile" && index + 1 < args.Count)
                presenter.ProtectNuGetConfiguration(args[index + 1], null);
            else if (args[index].StartsWith("--source=", StringComparison.OrdinalIgnoreCase)
                || args[index].StartsWith("--configfile=", StringComparison.OrdinalIgnoreCase))
                presenter.ProtectNuGetConfiguration(args[index][(args[index].IndexOf('=') + 1)..], null);
        }
        presenter.WriteError("The operation failed. Review the project state before retrying; use --verbose for diagnostics.");
        presenter.WriteVerbose(exception.ToString());
    }

    internal static string Redact(string text, IEnumerable<string>? privateValues = null)
    {
        foreach (var value in privateValues ?? [])
            if (!string.IsNullOrWhiteSpace(value)) text = text.Replace(value, "<redacted>", StringComparison.OrdinalIgnoreCase);
        text = Regex.Replace(text, @"(--(?:source|configfile))(?:=|\s+)(""[^""]*""|'[^']*'|\S+)", "$1 <redacted>", RegexOptions.IgnoreCase);
        // Child tools can echo terminal control sequences even in redirected output.
        return Regex.Replace(text, @"\x1b(?:\[[0-?]*[ -/]*[@-~]|\][^\x07\x1b]*(?:\x07|\x1b\\))", "").Replace("\u001b", string.Empty, StringComparison.Ordinal);
    }

    internal static string VersionFailure(string version, bool invalidVersion) => invalidVersion
        ? $"'{version}' is not a valid NuGet version. No changes made. Use a value such as 32.1.29 with --version."
        : $"Could not validate package version '{version}'. No changes made. Check the .NET SDK installation, then retry with --verbose.";

    internal static string Cause(string diagnostic)
    {
        var destination = Regex.Match(diagnostic, @"^The (?:project destination|output location) '[^\r\n]*", RegexOptions.Multiline);
        if (destination.Success) return destination.Value;
        var framework = Regex.Match(diagnostic, @"Build framework '[^\r\n]+is not enabled[^\r\n]+");
        if (framework.Success) return framework.Value;
        if (diagnostic.Contains("NETSDK1147", StringComparison.OrdinalIgnoreCase))
            return "Required .NET workloads are missing (NETSDK1147). Run dotnet workload restore for the project, then retry.";
        if (diagnostic.Contains("NETSDK1045", StringComparison.OrdinalIgnoreCase))
            return "The installed SDK does not support the project's target framework (NETSDK1045). Install the required .NET SDK, then retry.";
        if (diagnostic.Contains("XA5300", StringComparison.OrdinalIgnoreCase))
            return "The Android SDK was not found (XA5300). Install/configure the Android SDK, then retry the displayed build command.";
        if (diagnostic.Contains("NU1301", StringComparison.OrdinalIgnoreCase))
            return "NuGet could not reach a configured feed (NU1301). Check connectivity and NuGet configuration, then retry.";
        if (diagnostic.Contains("Package not found", StringComparison.OrdinalIgnoreCase))
            return "Package not found. Check the package ID, version, and configured NuGet feeds, then retry.";
        var code = Regex.Match(diagnostic, @"\b(?:NU|NETSDK|MSB|CS|XA|XC|XFC)\d{3,5}\b");
        if (code.Success) return $"The .NET operation failed ({code.Value}). Fix the reported project or toolchain error; use --verbose for diagnostics, then retry.";
        return "The .NET operation failed. Check the SDK, workloads, platform tools, and NuGet configuration; retry with --verbose for diagnostics.";
    }

    internal static void Failure(ConsolePresenter presenter, string headline, string message,
        IEnumerable<string> diagnostics, bool rollbackAttempted)
    {
        presenter.WriteError(headline);
        // Ownership/preflight messages contain actionable project facts, not tool output.
        var preflight = !rollbackAttempted && !message.Contains('\n') && !message.Contains('\r')
            && (message.StartsWith("Cannot ", StringComparison.Ordinal) || message.StartsWith("The ", StringComparison.Ordinal)
                || message.StartsWith("File ", StringComparison.Ordinal) || message.StartsWith("Generated ", StringComparison.Ordinal)
                || message.StartsWith("Control registry ", StringComparison.Ordinal));
        presenter.WriteError(preflight ? message : Cause(string.Join(Environment.NewLine, diagnostics.Prepend(message))));
        presenter.WriteInfo(rollbackAttempted
            ? "Changes: rollback attempted; review recovery diagnostics with --verbose before retrying."
            : "Changes: no changes made. Resolve the issue and retry.");
        presenter.WriteVerbose(message);
        foreach (var diagnostic in diagnostics) presenter.WriteVerbose(diagnostic);
    }
}
