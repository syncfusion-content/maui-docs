using System.Runtime.InteropServices;
using Syncfusion.DotNet.Cli.Blazor;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Copyable commands for the actual generated project, without executing them.</summary>
internal static class ProjectNextCommands
{
    internal enum Host { Windows, MacOS, Linux }
    internal static Host CurrentHost => OperatingSystem.IsWindows() ? Host.Windows : OperatingSystem.IsMacOS() ? Host.MacOS : Host.Linux;

    internal static IReadOnlyList<string> Maui(NewProjectRequest request, string directory, bool built, Host? host = null)
    {
        var shell = host ?? CurrentHost;
        var project = request.Name + ".csproj";
        var targets = File.Exists(Path.Combine(directory, project))
            ? ProjectDetector.Detect(directory)?.TargetFrameworks ?? [] : [];
        var preferred = shell == Host.Windows ? "windows" : shell == Host.MacOS ? "maccatalyst" : "android";
        var framework = (string.IsNullOrWhiteSpace(request.BuildFramework) ? null : request.BuildFramework.Trim())
            ?? targets.FirstOrDefault(target => target.Contains("-" + preferred, StringComparison.OrdinalIgnoreCase))
            ?? targets.FirstOrDefault(target => target.Contains("-android", StringComparison.OrdinalIgnoreCase))
            ?? targets.FirstOrDefault()
            ?? request.TargetFramework + "-" + (shell == Host.Windows ? "windows10.0.19041.0" : preferred);
        var target = " -f " + Quote(framework, shell);
        var commands = new List<string> { "cd " + Quote(directory, shell) };
        if (!built) commands.Add("dotnet build " + Quote(project, shell) + target);
        var run = "dotnet build " + Quote(project, shell) + " -t:Run" + target;
        if (framework.Contains("-ios", StringComparison.OrdinalIgnoreCase) && shell == Host.MacOS)
            run += " -p:RuntimeIdentifier=iossimulator-" + (RuntimeInformation.OSArchitecture == Architecture.Arm64 ? "arm64" : "x64");
        commands.Add(run);
        return commands;
    }

    internal static IReadOnlyList<string> Desktop(DesktopNewRequest request, string directory)
    {
        var legacy = DesktopConfiguration.IsLegacy(request.TargetFramework);
        var shell = Host.Windows;
        var project = Quote(request.Name + DesktopConfiguration.ProjectExtension(request.Language), shell);
        var commands = new List<string> { "cd " + Quote(directory, shell) };
        if (!request.Build)
            commands.Add(legacy ? "msbuild " + project + " /restore /t:Build /p:Configuration=Debug" : "dotnet build " + project);
        commands.Add(legacy ? "& " + Quote(".\\bin\\Debug\\" + request.Name + ".exe", shell)
            : "dotnet run --project " + project + " --no-build");
        return commands;
    }

    internal static IReadOnlyList<string> Blazor(BlazorNewRequest request, string directory)
    {
        // Hosted WebAssembly/Auto apps have both server and Client projects. Run the server.
        var project = File.Exists(Path.Combine(directory, request.Name + ".csproj"))
            ? request.Name + ".csproj"
            : request.AppType == BlazorAppType.WebApp && request.RenderMode != BlazorRenderMode.Server
                ? request.Name + "/" + request.Name + ".csproj" : request.Name + ".csproj";
        var commands = new List<string> { "cd " + Quote(directory, CurrentHost) };
        if (!request.Build) commands.Add("dotnet build " + Quote(project, CurrentHost));
        commands.Add("dotnet run --project " + Quote(project, CurrentHost) + " --no-build");
        return commands;
    }

    internal static void Write(ConsolePresenter presenter, IReadOnlyList<string> commands, bool powerShell = false)
    {
        presenter.WriteInfo("");
        presenter.WriteInfo(powerShell || CurrentHost == Host.Windows ? "Next commands (PowerShell):" : "Next commands:");
        foreach (var command in commands) presenter.WriteInfo("  " + command);
    }

    internal static string Quote(string value, Host host)
        => "'" + (host == Host.Windows ? value.Replace("'", "''", StringComparison.Ordinal)
            : value.Replace("'", "'\"'\"'", StringComparison.Ordinal)) + "'";
}
