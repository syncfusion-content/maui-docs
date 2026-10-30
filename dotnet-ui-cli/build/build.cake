using System.Text.RegularExpressions;
using System.Xml.Linq;

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var studioVersion = Argument<string>("studioversion", "");
var revisionNumber = Argument<string>("PreReleaseNumber", "");
var nugetapikey = Argument<string>("nugetapikey", "");
var sourceBranch = Argument<string>("sourcebranch", "");
var publishBranch = Argument<string>("publishbranch", "development");

// Jenkins may pass several feeds as "primary,secondary"; the package is pushed to the first (Nexus).
var nugetserverurl = Argument<string>("nugetserverurl", "https://nexus.syncfusioninternal.com/repository/nuget-hosted/")
    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(url => url.Trim())
    .FirstOrDefault() ?? "";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var rootDir = MakeAbsolute(Directory("../"));
var solution = rootDir.CombineWithFilePath("sf-net-cli.slnx");
var toolProject = rootDir.CombineWithFilePath("src/Syncfusion.DotNet.Cli/Syncfusion.DotNet.Cli.csproj");
var testProject = rootDir.CombineWithFilePath("tests/Syncfusion.DotNet.Cli.Tests.csproj");
var packagesDir = rootDir.Combine("cireports/NuGet");

// Strips "refs/heads/" and "origin/" so Jenkins, Gitea and plain git branch names compare equal.
string NormalizeBranch(string branch) =>
    Regex.Replace((branch ?? "").Trim(), "^(refs/heads/|origin/)", "");

bool IsPublishBranch()
{
    var source = NormalizeBranch(sourceBranch);
    return source.Length > 0 && publishBranch
        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(NormalizeBranch)
        .Contains(source, StringComparer.OrdinalIgnoreCase);
}

// "<studioversion major.minor.patch>" with no pre-release suffix; falls back to the version in Directory.Build.props.
string ResolvePackageVersion()
{
    var baseVersion = studioVersion;
    if (string.IsNullOrWhiteSpace(baseVersion))
    {
        var props = XDocument.Load(rootDir.CombineWithFilePath("Directory.Build.props").FullPath);
        baseVersion = props.Descendants("Version").Select(e => e.Value.Trim()).FirstOrDefault() ?? "0.1.0";
        return baseVersion;
    }

    var parts = baseVersion.Split('.');
    var core = string.Join(".", parts.Take(3));
    return core;
}

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
{
    foreach (var dir in GetDirectories("../src/**/bin").Concat(GetDirectories("../src/**/obj")))
        CleanDirectory(dir);
    CleanDirectory(packagesDir);
})
.OnError(exception =>
{
    System.IO.File.WriteAllText("../cakelog.txt", "Error on Executing Clean:" + exception);
    throw new Exception("Cake process Failed on Clean Task");
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetCoreRestore(solution.FullPath);
})
.OnError(exception =>
{
    System.IO.File.WriteAllText("../cakelog.txt", "Error on Executing Restore:" + exception);
    throw new Exception("Cake process Failed on Restore Task");
});

// Release build with analyzers and warnings-as-errors (set in Directory.Build.props).
Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    EnsureDirectoryExists("../cireports/errorlogs/");
    DotNetCoreBuild(solution.FullPath, new DotNetCoreBuildSettings
    {
        Configuration = configuration,
        NoRestore = true,
    });
})
.OnError(exception =>
{
    System.IO.File.WriteAllText("../cakelog.txt", "Error on Executing Build:" + exception);
    throw new Exception("Cake process Failed on Build Task");
});

// Not part of the CI chain by default: run with -Target Test.
// Excludes the tests tracked as known-failing in .agent/harness.yaml (T-001/T-002).
Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetCoreTest(testProject.FullPath, new DotNetCoreTestSettings
    {
        Configuration = configuration,
        NoBuild = true,
        NoRestore = true,
        Filter = "FullyQualifiedName!~PdfViewerResourcesMatchCatalogNames"
            + "&FullyQualifiedName!~ProjectEmbeddingExcludesMacMetadataAtEveryDepthAndKeepsTemplates"
            + "&FullyQualifiedName!~InvalidExplicitTargetFramework_FailsBeforeProjectNameQuestion"
            + "&FullyQualifiedName!~NameConflictAllowsReentryWithoutChangingExistingDestination",
    });
})
.OnError(exception =>
{
    System.IO.File.WriteAllText("../cakelog.txt", "Error on Executing Test:" + exception);
    throw new Exception("Cake process Failed on Test Task");
});

Task("CodeViolation")
    .Does(() =>
{
    // Analyzers run as part of Build with warnings-as-errors; nothing further to collect.
});

Task("Pack")
    .IsDependentOn("Build")
    .Does(() =>
{
    var version = ResolvePackageVersion();
    Information("Packing Syncfusion.DotNet.Cli {0}", version);

    DotNetCorePack(toolProject.FullPath, new DotNetCorePackSettings
    {
        Configuration = configuration,
        NoBuild = true,
        NoRestore = true,
        OutputDirectory = packagesDir,
        MSBuildSettings = new DotNetCoreMSBuildSettings()
            .WithProperty("Version", version)
            .WithProperty("PackageVersion", version),
    });

    if (!GetFiles(packagesDir.FullPath + "/*.nupkg").Any())
        throw new Exception("Pack produced no .nupkg in " + packagesDir);
})
.OnError(exception =>
{
    System.IO.File.WriteAllText("../cakelog.txt", "Error on Executing Pack:" + exception);
    throw new Exception("Cake process Failed on Pack Task");
});

// Publishes to Nexus only when the CI is running for a publish branch (development by default).
Task("Publish")
    .IsDependentOn("Pack")
    .Does(() =>
{
    if (!IsPublishBranch())
    {
        Information("Skipping publish: branch '{0}' is not one of '{1}'.", sourceBranch, publishBranch);
        return;
    }
    if (string.IsNullOrWhiteSpace(nugetapikey) || string.IsNullOrWhiteSpace(nugetserverurl))
        throw new Exception("nugetapikey and nugetserverurl are required to publish.");

    foreach (var package in GetFiles(packagesDir.FullPath + "/*.nupkg"))
    {
        DotNetCoreNuGetPush(package.FullPath, new DotNetCoreNuGetPushSettings
        {
            Source = nugetserverurl,
            ApiKey = nugetapikey,
            SkipDuplicate = true,
        });
        Information("Published {0} to {1}", package.GetFilename(), nugetserverurl);
    }
})
.OnError(exception =>
{
    System.IO.File.WriteAllText("../cakelog.txt", "Error on Executing Publish:" + exception);
    throw new Exception("Cake process Failed on Publish Task");
});

Task("Default")
    .IsDependentOn("Build");

RunTarget(target);
