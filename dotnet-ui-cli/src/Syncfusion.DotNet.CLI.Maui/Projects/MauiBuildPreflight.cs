using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>Checks the host build target before project generation changes the filesystem.</summary>
public sealed class MauiBuildPreflight(DotNetRunner? dotnet = null)
{
    private readonly DotNetRunner _dotnet = dotnet ?? new DotNetRunner();

    public static string TargetFor(string framework)
        => OperatingSystem.IsWindows() ? $"{framework}-windows10.0.19041.0" : $"{framework}-android";

    public async Task<IReadOnlyList<string>> CheckAsync(string framework, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var errors = new List<string>();
        var target = TargetFor(framework);
        try
        {
            var sdk = await _dotnet.RunAsync(["--version"], Environment.CurrentDirectory, false, cancellationToken).ConfigureAwait(false);
            var major = framework.StartsWith("net", StringComparison.Ordinal) && int.TryParse(framework[3..].Split('.')[0], out var value) ? value : 10;
            if (!sdk.Success || !Version.TryParse(sdk.StandardOutput.Trim().Split('-')[0], out var version) || version.Major < major)
            {
                errors.Add($"Install/select a .NET {major} or newer SDK compatible with global.json.");
            }
            var workloads = await _dotnet.RunAsync(["workload", "list"], Environment.CurrentDirectory, false, cancellationToken).ConfigureAwait(false);
            errors.AddRange(ValidateWorkloads(workloads.Success ? workloads.StandardOutput : string.Empty, OperatingSystem.IsWindows()));

            if (OperatingSystem.IsWindows())
            {
                var kits = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Windows Kits", "10", "bin");
                if (!Directory.Exists(kits) || !Directory.EnumerateFiles(kits, "MakeAppx.exe", SearchOption.AllDirectories).Any())
                { errors.Add("Install the Windows 10/11 SDK including packaging tools (MakeAppx.exe)."); }
            }
            else
            {
                var android = Environment.GetEnvironmentVariable("ANDROID_SDK_ROOT") ?? Environment.GetEnvironmentVariable("ANDROID_HOME");
                var api = major >= 10 ? "36" : "35";
                if (string.IsNullOrWhiteSpace(android) || !File.Exists(Path.Combine(android, "platforms", $"android-{api}", "android.jar")))
                { errors.Add($"Set ANDROID_HOME or ANDROID_SDK_ROOT to an Android SDK with platform android-{api}."); }
                if (string.IsNullOrWhiteSpace(android) || !Directory.Exists(Path.Combine(android, "build-tools"))
                    || !Directory.EnumerateFiles(Path.Combine(android, "build-tools"), "aapt2", SearchOption.AllDirectories).Any())
                { errors.Add("Install Android SDK build-tools (aapt2)."); }
                var javaHome = Environment.GetEnvironmentVariable("JAVA_HOME");
                var java = string.IsNullOrWhiteSpace(javaHome) ? "java" : Path.Combine(javaHome, "bin", "java");
                var javaResult = await new DotNetRunner(java).RunAsync(["-version"], null, false, cancellationToken).ConfigureAwait(false);
                var javaVersion = Regex.Match(javaResult.StandardError + javaResult.StandardOutput, "version \\\"(\\d+)", RegexOptions.CultureInvariant);
                var requiredJava = major >= 10 ? 21 : 17;
                if (!javaResult.Success || !javaVersion.Success || int.Parse(javaVersion.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture) < requiredJava)
                { errors.Add($"Install JDK {requiredJava} or newer and set JAVA_HOME."); }
                var javac = string.IsNullOrWhiteSpace(javaHome) ? "javac" : Path.Combine(javaHome, "bin", "javac");
                var compiler = await new DotNetRunner(javac).RunAsync(["-version"], null, false, cancellationToken).ConfigureAwait(false);
                if (!compiler.Success) { errors.Add("Install a full JDK including javac; a Java runtime alone cannot build Android projects."); }
            }
        }
        catch (Exception ex) when (ex is Win32Exception or IOException or UnauthorizedAccessException)
        { errors.Add($"Could not check build tools for {target}: {ex.Message}"); }
        return errors;
    }

    internal static IReadOnlyList<string> ValidateWorkloads(string output, bool windows)
    {
        var ids = Regex.Matches(output, @"(?m)^\s*(maui(?:-android|-windows)?)\s+")
            .Select(match => match.Groups[1].Value).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var required = windows ? "maui-windows" : "maui-android";
        return ids.Contains("maui") || ids.Contains(required) ? [] : [$"Install the MAUI workload for this host: dotnet workload install {required}."];
    }
}
