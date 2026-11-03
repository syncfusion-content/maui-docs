using Syncfusion.DotNet.Cli.Core;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

public sealed class DotNetHostResolverTests
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void PrefersPathHost_ThenRuntimeInstallation_ThenNormalLookup(bool onPath, bool inRuntimeInstallation)
    {
        var root = Path.Combine(Path.GetTempPath(), "sf host spaces " + Guid.NewGuid().ToString("N"));
        var runtime = Path.Combine(root, "runtime-installation", "shared", "Microsoft.NETCore.App", "10.0.0");
        var pathDirectory = Path.Combine(root, "path-installation");
        var name = OperatingSystem.IsWindows() ? "dotnet.exe" : "dotnet";
        var runtimeHost = Path.Combine(root, "runtime-installation", name);
        var pathHost = Path.Combine(pathDirectory, name);
        Directory.CreateDirectory(runtime);
        Directory.CreateDirectory(pathDirectory);
        try
        {
            if (onPath) { File.WriteAllText(pathHost, "PATH host"); }
            if (inRuntimeInstallation) { File.WriteAllText(runtimeHost, "Runtime host"); }
            var expected = onPath ? pathHost : inRuntimeInstallation ? runtimeHost : "dotnet";
            Assert.Equal(expected, DotNetHostResolver.Resolve(pathDirectory, runtime + Path.DirectorySeparatorChar));
            Assert.Equal(inRuntimeInstallation ? runtimeHost : "dotnet", DotNetHostResolver.Resolve(null, runtime));
            Assert.Equal("custom host", new NuGetRunner("custom host").DotNetPath);
        }
        finally { Directory.Delete(root, true); }
    }
}
