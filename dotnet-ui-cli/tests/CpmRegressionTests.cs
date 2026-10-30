using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

public sealed class CpmRegressionTests
{
    [Fact]
    public async Task AddUnderEvaluatedCpm_WritesOneVersionFreeReferenceAndExactCentralVersion()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-cpm-test-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var project = Path.Combine(root, "App");
            Directory.CreateDirectory(project);
            var csproj = Path.Combine(project, "App.csproj");
            File.WriteAllText(csproj, "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(project, "MauiProgram.cs"), "namespace App; public static class MauiProgram { public static void Create() { var builder = MauiApp.CreateBuilder(); } }");
            var props = Path.Combine(root, "Directory.Packages.props");
            File.WriteAllText(props, "<Project><PropertyGroup><ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(root, "Directory.Build.props"), "<Project><Import Project=\"$(MSBuildThisFileDirectory)Directory.Packages.props\" /></Project>");
            var nuget = new VersionWritingNuGetRunner(csproj);
            var dotnet = new FakeDotNetRunner(props);
            var installer = new ControlInstaller(project, nuget, dotnet);

            var result = await installer.ExecuteAddAsync("datagrid");

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            var xml = System.Xml.Linq.XDocument.Load(csproj);
            var references = xml.Descendants("PackageReference").Where(element => (string?)element.Attribute("Include") == "Syncfusion.Maui.DataGrid").ToList();
            Assert.Single(references);
            Assert.Null(references[0].Attribute("Version"));
            var versions = System.Xml.Linq.XDocument.Load(props).Descendants("PackageVersion").Where(element => (string?)element.Attribute("Include") == "Syncfusion.Maui.DataGrid").ToList();
            Assert.Single(versions);
            Assert.Equal("35.1.37", (string?)versions[0].Attribute("Version"));
            Assert.DoesNotContain("*", File.ReadAllText(props), StringComparison.Ordinal);
            var manifest = Syncfusion.DotNet.Cli.Maui.Manifest.SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(project, "Syncfusion", "syncfusion.json")));
            Assert.Equal("35.1.37", manifest.PackageVersions["Syncfusion.Maui.DataGrid"]);
            Assert.Equal("35.1.37", Assert.Single(manifest.InstalledTemplates).ResolvedVersion);
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public async Task AddWithCpm_ReusesMatchingCentralVersionWithoutAddingDuplicate()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-cpm-existing-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var project = Path.Combine(root, "App");
            Directory.CreateDirectory(project);
            var csproj = Path.Combine(project, "App.csproj");
            File.WriteAllText(csproj, "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(project, "MauiProgram.cs"), "namespace App; public static class MauiProgram { public static void Create() { var builder = MauiApp.CreateBuilder(); } }");
            var props = Path.Combine(root, "Directory.Packages.props");
            File.WriteAllText(props, "<Project><PropertyGroup><ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally></PropertyGroup><ItemGroup><PackageVersion Include=\"Syncfusion.Maui.DataGrid\" Version=\"35.1.37\" /></ItemGroup></Project>");
            File.WriteAllText(Path.Combine(root, "Directory.Build.props"), "<Project><Import Project=\"$(MSBuildThisFileDirectory)Directory.Packages.props\" /></Project>");

            var result = await new ControlInstaller(project, new VersionWritingNuGetRunner(csproj), new FakeDotNetRunner(props)).ExecuteAddAsync("datagrid");

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            var packageVersions = System.Xml.Linq.XDocument.Load(props).Descendants("PackageVersion")
                .Where(element => (string?)element.Attribute("Include") == "Syncfusion.Maui.DataGrid").ToList();
            Assert.Single(packageVersions);
            Assert.Equal("35.1.37", (string?)packageVersions[0].Attribute("Version"));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public async Task AddWithCpm_ConflictingCentralVersionFailsAndRollsBackProject()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-cpm-conflict-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var project = Path.Combine(root, "App");
            Directory.CreateDirectory(project);
            var csproj = Path.Combine(project, "App.csproj");
            const string originalProject = "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup></Project>";
            File.WriteAllText(csproj, originalProject);
            File.WriteAllText(Path.Combine(project, "MauiProgram.cs"), "namespace App; public static class MauiProgram { public static void Create() { var builder = MauiApp.CreateBuilder(); } }");
            var props = Path.Combine(root, "Directory.Packages.props");
            const string originalProps = "<Project><PropertyGroup><ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally></PropertyGroup><ItemGroup><PackageVersion Include=\"Syncfusion.Maui.DataGrid\" Version=\"34.1.1\" /></ItemGroup></Project>";
            File.WriteAllText(props, originalProps);
            File.WriteAllText(Path.Combine(root, "Directory.Build.props"), "<Project><Import Project=\"$(MSBuildThisFileDirectory)Directory.Packages.props\" /></Project>");

            var result = await new ControlInstaller(project, new VersionWritingNuGetRunner(csproj), new FakeDotNetRunner(props)).ExecuteAddAsync("datagrid");

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("conflicting version", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Equal(originalProject, File.ReadAllText(csproj));
            Assert.Equal(originalProps, File.ReadAllText(props));
            Assert.False(File.Exists(Path.Combine(project, "Syncfusion", "syncfusion.json")));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public async Task AddBatchWithCpm_UsesVersionFreeReferencesAndExactCentralVersions()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-cpm-batch-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var project = Path.Combine(root, "App");
            Directory.CreateDirectory(project);
            var csproj = Path.Combine(project, "App.csproj");
            File.WriteAllText(csproj, "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(project, "MauiProgram.cs"), "namespace App; public static class MauiProgram { public static void Create() { var builder = MauiApp.CreateBuilder(); } }");
            var props = Path.Combine(root, "Directory.Packages.props");
            File.WriteAllText(props, "<Project><PropertyGroup><ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(root, "Directory.Build.props"), "<Project><Import Project=\"$(MSBuildThisFileDirectory)Directory.Packages.props\" /></Project>");
            var installer = new ControlInstaller(project, new VersionWritingNuGetRunner(csproj), new FakeDotNetRunner(props));

            var result = await installer.ExecuteAddBatchAsync(["datagrid", "kanban"]);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            var references = System.Xml.Linq.XDocument.Load(csproj).Descendants("PackageReference").ToList();
            Assert.Equal(2, references.Count);
            Assert.All(references, reference => Assert.Null(reference.Attribute("Version")));
            var packageVersions = System.Xml.Linq.XDocument.Load(props).Descendants("PackageVersion").ToList();
            Assert.Equal(2, packageVersions.Count);
            Assert.All(packageVersions, packageVersion => Assert.Equal("35.1.37", (string?)packageVersion.Attribute("Version")));
            var manifest = Syncfusion.DotNet.Cli.Maui.Manifest.SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(project, "Syncfusion", "syncfusion.json")));
            Assert.All(manifest.PackageVersions.Values, resolvedVersion => Assert.Equal("35.1.37", resolvedVersion));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    private sealed class VersionWritingNuGetRunner(string projectPath) : NuGetRunner
    {
        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, System.Threading.CancellationToken cancellationToken = default)
        {
            var project = System.Xml.Linq.XDocument.Load(projectPath);
            project.Root!.Add(new System.Xml.Linq.XElement("ItemGroup",
                new System.Xml.Linq.XElement("PackageReference",
                    new System.Xml.Linq.XAttribute("Include", operation.PackageId),
                    new System.Xml.Linq.XAttribute("Version", operation.Version ?? "35.1.37"))));
            project.Save(projectPath);
            return Task.FromResult(new NuGetCommandResult { ExitCode = 0, StandardOutput = "version '35.1.37' added", StandardError = string.Empty });
        }
    }

    private sealed class FakeDotNetRunner(string propsPath) : DotNetRunner
    {
        public override Task<ProcessCommandResult> RunAsync(System.Collections.Generic.IReadOnlyList<string> args, string? workingDirectory, bool dryRun, System.Threading.CancellationToken cancellationToken = default)
        {
            var output = string.Empty;
            if (args.FirstOrDefault() == "msbuild")
            {
                if (args.Any(argument => argument.Contains("ManagePackageVersionsCentrally", StringComparison.Ordinal)))
                {
                    output = System.Text.Json.JsonSerializer.Serialize(new
                    {
                        Properties = new
                        {
                            ManagePackageVersionsCentrally = "true",
                            DirectoryPackagesPropsPath = propsPath,
                        },
                    });
                }
                else if (args.Any(argument => argument.Contains("TargetFramework", StringComparison.Ordinal)))
                {
                    output = "net10.0";
                }
            }
            else if (args.FirstOrDefault() == "package")
            {
                var packageId = args.Skip(2).FirstOrDefault() ?? string.Empty;
                output = System.Text.Json.JsonSerializer.Serialize(new
                {
                    searchResult = new[]
                    {
                        new { packages = new[] { new { id = packageId, version = "35.1.37" } } },
                    },
                });
            }

            return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = output, StandardError = string.Empty });
        }
    }
}
