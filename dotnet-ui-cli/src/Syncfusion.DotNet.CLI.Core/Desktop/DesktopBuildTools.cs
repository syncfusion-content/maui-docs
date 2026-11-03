namespace Syncfusion.DotNet.Cli.Core;

public static class DesktopBuildTools
{
    /// <summary>Classic desktop targets are supplied by Visual Studio MSBuild, not dotnet new templates.</summary>
    public static async Task<string> LegacyMsBuildAsync(ToolRunner runner, CancellationToken token)
    {
        var paths = (Environment.GetEnvironmentVariable("PATH") ?? "").Split(Path.PathSeparator);
        var found = paths.Select(path => Path.Combine(path, "MSBuild.exe")).FirstOrDefault(File.Exists);
        if (found is not null) return found;
        var vswhere = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Microsoft Visual Studio", "Installer", "vswhere.exe");
        if (File.Exists(vswhere))
        {
            var result = await runner.RunAsync(["-latest", "-products", "*", "-requires", "Microsoft.Component.MSBuild", "-find", "MSBuild\\**\\Bin\\MSBuild.exe"], cancellationToken: token, executable: vswhere).ConfigureAwait(false);
            found = result.Output.Split('\n').Select(path => path.Trim()).FirstOrDefault(File.Exists);
            if (found is not null) return found;
        }
        throw new InvalidOperationException("Install Visual Studio Build Tools with the .NET desktop development workload for legacy .NET Framework restore/build. Exact reference assemblies are restored from Microsoft's ReferenceAssemblies package.");
    }
}
