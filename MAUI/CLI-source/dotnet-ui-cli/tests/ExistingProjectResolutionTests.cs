using Syncfusion.DotNet.CLI.Maui;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class ExistingProjectResolutionTests : IDisposable
{
    private readonly string _root = Directory.CreateTempSubdirectory("sf-existing-resolution-").FullName;

    [Fact]
    public void RootSubdirectoryAndExplicitFile_ResolveSameProject()
    {
        var file = Create("App with spaces", "Demo");
        var subdirectory = Directory.CreateDirectory(Path.Combine(Path.GetDirectoryName(file)!, "Syncfusion", "Controls", "DataGrid")).FullName;
        Assert.Equal(file, MauiProjectResolver.Resolve(subdirectory).CsprojPath);
        Assert.Equal(file, MauiProjectResolver.Resolve(Path.GetDirectoryName(file)).CsprojPath);
        Assert.Equal(file, MauiProjectResolver.Resolve(file).CsprojPath);
    }

    [Fact]
    public void AmbiguityAtNearestBoundary_RetainsSelectorAndExplicitFileBehavior()
    {
        var first = Create("Multi", "First");
        var second = Create("Multi", "Second");
        var subdirectory = Directory.CreateDirectory(Path.Combine(_root, "Multi", "Views")).FullName;
        Assert.Contains("Found 2 MAUI projects", Assert.Throws<InvalidOperationException>(() => MauiProjectResolver.Resolve(subdirectory)).Message);
        Assert.Equal(second, MauiProjectResolver.Resolve(subdirectory, candidates => candidates.Single(candidate => candidate.CsprojPath == second)).CsprojPath);
        Assert.Equal(first, MauiProjectResolver.Resolve(first).CsprojPath);
    }

    [Fact]
    public void NearestNonMauiProject_StopsSearchBeforeOuterMauiProject()
    {
        Create("Outer", "Outer");
        var inner = Create("Outer/Inner", "Inner", maui: false);
        var subdirectory = Directory.CreateDirectory(Path.Combine(Path.GetDirectoryName(inner)!, "Views")).FullName;
        Assert.Contains("not a .NET MAUI project", Assert.Throws<InvalidOperationException>(() => MauiProjectResolver.Resolve(subdirectory)).Message);
    }

    [Fact]
    public void RepositoryBoundaryAndMissingExplicitPath_DoNotSelectUnrelatedProject()
    {
        Create("Outer", "Outer");
        var inner = Directory.CreateDirectory(Path.Combine(_root, "Outer", "Unrelated")).FullName;
        Directory.CreateDirectory(Path.Combine(inner, ".git"));
        var subdirectory = Directory.CreateDirectory(Path.Combine(inner, "Views")).FullName;
        Assert.Throws<DirectoryNotFoundException>(() => MauiProjectResolver.Resolve(subdirectory));
        Assert.Throws<DirectoryNotFoundException>(() => MauiProjectResolver.Resolve(Path.Combine(_root, "missing.csproj")));
    }

    private string Create(string folder, string name, bool maui = true)
    {
        var directory = Directory.CreateDirectory(Path.Combine(_root, folder)).FullName;
        var path = Path.Combine(directory, name + ".csproj");
        File.WriteAllText(path, $"<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0-android</TargetFramework><UseMaui>{maui.ToString().ToLowerInvariant()}</UseMaui></PropertyGroup></Project>");
        return path;
    }

    public void Dispose() => Directory.Delete(_root, true);
}
