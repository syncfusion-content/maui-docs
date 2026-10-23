using System.Runtime.InteropServices;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>Finds the SDK host for child dotnet commands, including apphost-launched tools.</summary>
public static class DotNetHostResolver
{
    public static string Resolve()
        => Resolve(Environment.GetEnvironmentVariable("PATH"), RuntimeEnvironment.GetRuntimeDirectory());

    /// <summary>Preserves PATH selection, with the running runtime's installation as a fallback.</summary>
    public static string Resolve(string? searchPath, string runtimeDirectory)
    {
        var executable = OperatingSystem.IsWindows() ? "dotnet.exe" : "dotnet";
        foreach (var directory in (searchPath ?? "").Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries))
        {
            var candidate = Path.Combine(directory.Trim('"'), executable);
            if (File.Exists(candidate)) { return Path.GetFullPath(candidate); }
        }

        // RuntimeDirectory is <installation>/shared/Microsoft.NETCore.App/<version>/.
        // The host is at <installation>/dotnet, not beside the runtime assemblies.
        var runtimeHost = Path.GetFullPath(Path.Combine(runtimeDirectory, "..", "..", "..", executable));
        return File.Exists(runtimeHost) ? runtimeHost : "dotnet";
    }
}
