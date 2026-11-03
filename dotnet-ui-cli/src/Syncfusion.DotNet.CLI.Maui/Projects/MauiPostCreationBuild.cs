using System.ComponentModel;
using System.Text.Json;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Builds a generated project without overriding its configured targets.</summary>
public sealed class MauiPostCreationBuild(DotNetRunner dotnet)
{
    public static IReadOnlyList<string> Arguments(string projectFile, string? framework = null)
        => string.IsNullOrWhiteSpace(framework)
            ? ["build", projectFile]
            : ["build", projectFile, "-f", framework.Trim()];

    public static string DisplayCommand(string projectFile, string? framework = null)
        => $"dotnet build \"{projectFile}\"" + (string.IsNullOrWhiteSpace(framework) ? "" : $" -f \"{framework.Trim()}\"");

    public async Task<ProcessCommandResult> ExecuteAsync(string projectFile, string? framework, CancellationToken cancellationToken)
    {
        var directory = Path.GetDirectoryName(projectFile)!;
        try
        {
            if (!string.IsNullOrWhiteSpace(framework))
            {
                // Evaluate imports and OS conditions without forcing TargetFramework.
                var evaluation = await dotnet.RunAsync(
                    ["msbuild", projectFile, "-getProperty:TargetFrameworks,TargetFramework"],
                    directory, false, cancellationToken).ConfigureAwait(false);
                if (!evaluation.Success) { return evaluation; }
                using var json = JsonDocument.Parse(evaluation.StandardOutput);
                var properties = json.RootElement.GetProperty("Properties");
                var targets = properties.GetProperty("TargetFrameworks").GetString();
                if (string.IsNullOrWhiteSpace(targets)) { targets = properties.GetProperty("TargetFramework").GetString(); }
                var configured = (targets ?? "").Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (!configured.Contains(framework.Trim(), StringComparer.OrdinalIgnoreCase))
                {
                    return Failure($"Build framework '{framework.Trim()}' is not enabled in '{projectFile}' on this OS. Configured targets: {string.Join(", ", configured)}. Omit --build-framework to build all configured targets or select one of these targets.");
                }
            }
            return await dotnet.RunAsync(Arguments(projectFile, framework), directory, false, cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex) when (ex is Win32Exception or IOException or UnauthorizedAccessException or JsonException or KeyNotFoundException)
        {
            return Failure($"Could not build the generated project: {ex.Message}");
        }
    }

    private static ProcessCommandResult Failure(string error)
        => new() { ExitCode = 1, StandardOutput = "", StandardError = error };
}
