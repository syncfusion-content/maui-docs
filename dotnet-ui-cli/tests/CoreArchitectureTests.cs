using Syncfusion.DotNet.Cli.Core;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

/// <summary>Guards the platform-neutral boundary of the Core assembly.</summary>
public static class CoreArchitectureTests
{
    [Fact]
    public static void CoreAssemblyContainsNoPlatformSpecificTypesOrReferences()
    {
        var coreAssembly = typeof(Framework).Assembly;
        var platformSpecificTypes = coreAssembly.GetTypes()
            .Where(type => type.FullName?.Contains("Maui", StringComparison.OrdinalIgnoreCase) == true);
        var platformReferences = coreAssembly.GetReferencedAssemblies()
            .Where(assembly => assembly.Name?.EndsWith(".Maui", StringComparison.OrdinalIgnoreCase) == true);

        Assert.Empty(platformSpecificTypes);
        Assert.Empty(platformReferences);
    }
}
