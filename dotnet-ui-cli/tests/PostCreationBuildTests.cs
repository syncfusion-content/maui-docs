using System.CommandLine;
using System.Text.Json;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

public sealed class PostCreationBuildTests
{
    private static NewProjectRequest Request(string path) => new(Framework.Maui, "App", path, "net10.0", "empty",
        MauiProjectType.App, Restore: true, Build: true, DryRun: false, Force: false);

    [Theory]
    [InlineData(null)]
    [InlineData("net10.0-android")]
    public async Task BuildsGeneratedProjectDirectly_AndPreservesConditionedConfiguration(string? framework)
    {
        var root = Path.Combine(Path.GetTempPath(), "sf build spaces " + Guid.NewGuid().ToString("N"));
        var runner = new BuildRunner();
        try
        {
            var request = Request(root) with { BuildFramework = framework };
            var result = await new NewProjectScaffolder(runner).ExecuteAsync(request);
            Assert.Equal(0, result.ExitCode);
            var file = Path.Combine(root, "App", "App.csproj");
            var expected = framework is null ? new[] { "build", file } : new[] { "build", file, "-f", framework };
            var build = Assert.Single(runner.Calls, call => call.Args[0] == "build");
            Assert.Equal(expected, build.Args);
            Assert.Equal(Path.GetDirectoryName(file), build.Directory);
            Assert.Equal(BuildRunner.Project, File.ReadAllText(file));
            Assert.DoesNotContain(runner.Calls, call => call.Args[0] is "restore" or "workload");
            Assert.Equal(framework is null ? 0 : 1, runner.Calls.Count(call => call.Args[0] == "msbuild"));
            Assert.True(result.GenerationSucceeded);
            Assert.True(result.BuildSucceeded);
            Assert.Contains(MauiPostCreationBuild.DisplayCommand(file, framework), result.Plan!.CommandsToExecute);
        }
        finally { if (Directory.Exists(root)) { Directory.Delete(root, true); } }
    }

    [Theory]
    [InlineData("net10.0-ios")]
    [InlineData("net10.0-windows10.0.19041.0")]
    [InlineData("net9.0-android")]
    public async Task ExplicitTargetMustBeEnabledByEvaluatedProject(string framework)
    {
        var runner = new BuildRunner();
        var result = await new MauiPostCreationBuild(runner).ExecuteAsync("/tmp/App.csproj", framework, default);
        Assert.False(result.Success);
        Assert.Contains("not enabled", result.StandardError);
        Assert.Contains("net10.0-android", result.StandardError);
        Assert.DoesNotContain(runner.Calls, call => call.Args[0] == "build");
        Assert.Equal(new[] { "msbuild", "/tmp/App.csproj", "-getProperty:TargetFrameworks,TargetFramework" }, runner.Calls.Single().Args);
    }

    [Fact]
    public async Task ExplicitTargetSupportsSingleFrameworkProjects()
    {
        var runner = new BuildRunner { Targets = "", SingleTarget = "net10.0-android" };
        var result = await new MauiPostCreationBuild(runner).ExecuteAsync("/tmp/App.csproj", "net10.0-android", default);
        Assert.True(result.Success);
        Assert.Equal(new[] { "build", "/tmp/App.csproj", "-f", "net10.0-android" }, runner.Calls.Last().Args);
    }

    [Theory]
    [InlineData("error NETSDK1147: To build this project, the following workloads must be installed: maui-ios")]
    [InlineData("error XA5300: The Android SDK directory could not be found")]
    public async Task MissingPrerequisitesRetainProjectAndDiagnostics(string error)
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-missing-tools-" + Guid.NewGuid().ToString("N"));
        try
        {
            var runner = new BuildRunner { BuildError = error };
            var result = await new NewProjectScaffolder(runner).ExecuteAsync(Request(root));
            Assert.NotEqual(0, result.ExitCode);
            Assert.True(result.GenerationSucceeded);
            Assert.False(result.BuildSucceeded);
            Assert.False(result.RolledBack);
            Assert.True(File.Exists(Path.Combine(root, "App", "App.csproj")));
            Assert.True(File.Exists(Path.Combine(root, "App", "Syncfusion", "syncfusion.json")));
            Assert.Contains(error, result.Errors);
            Assert.NotEmpty(result.CreatedFiles);
        }
        finally { if (Directory.Exists(root)) { Directory.Delete(root, true); } }
    }

    [Fact]
    public void FrameworkOptionsKeepTheirMeaningsAndExplicitTargetAppearsInReview()
    {
        var root = new RootCommand(); root.Add(NewCommand.Create());
        var parse = root.Parse(["new", "--framework", "maui", "-n", "App", "--target-framework", "net9.0",
            "--build-framework", "net9.0-android", "--post-action", "build", "--dry-run"]);
        Assert.Empty(parse.Errors);
        var outcome = NewCommand.Parse(parse);
        Assert.True(outcome.IsSuccess, outcome.Error);
        Assert.Equal(Framework.Maui, outcome.Request!.Framework);
        Assert.Equal("net9.0", outcome.Request.TargetFramework);
        Assert.Equal("net9.0-android", outcome.Request.BuildFramework);
        var review = NewCommand.FormatNewProjectReview(outcome.Request);
        Assert.Contains(review, line => line.StartsWith("Post-create:") && line.EndsWith("Build project (net9.0-android)"));
        Assert.DoesNotContain(review, line => line.Contains("all configured targets"));
        var defaultReview = NewCommand.FormatNewProjectReview(outcome.Request with { BuildFramework = null });
        Assert.Contains(defaultReview, line => line.StartsWith("Post-create:") && line.EndsWith("Build project (all configured targets)"));
        Assert.DoesNotContain(defaultReview, line => line.StartsWith("Build target:"));
    }

    [Theory]
    [InlineData("generate", "net10.0-android")]
    [InlineData("build", "")]
    public void ExplicitTargetRequiresBuildAndAValue(string action, string framework)
    {
        var root = new RootCommand(); root.Add(NewCommand.Create());
        var outcome = NewCommand.Parse(root.Parse(["new", "maui", "-n", "App", "--build-framework", framework, "--post-action", action]));
        Assert.False(outcome.IsSuccess);
        Assert.Contains("--build-framework requires", outcome.Error);
    }

    private sealed class BuildRunner : DotNetRunner
    {
        public const string Project = "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><UseMaui>true</UseMaui><TargetFrameworks>net10.0-android;net10.0-ios</TargetFrameworks><TargetFrameworks Condition=\"$([MSBuild]::IsOSPlatform('windows'))\">$(TargetFrameworks);net10.0-windows10.0.19041.0</TargetFrameworks></PropertyGroup></Project>";
        public string Targets { get; init; } = "net10.0-android";
        public string SingleTarget { get; init; } = "";
        public string? BuildError { get; init; }
        public List<(string[] Args, string? Directory)> Calls { get; } = [];
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2]), StandardError = "" });
            Calls.Add((args.ToArray(), workingDirectory));
            if (args[0] == "new")
            {
                var output = args[args.ToList().IndexOf("-o") + 1];
                Directory.CreateDirectory(output);
                File.WriteAllText(Path.Combine(output, "App.csproj"), Project);
            }
            return Task.FromResult(new ProcessCommandResult
            {
                ExitCode = args[0] == "build" && BuildError is not null ? 1 : 0,
                StandardError = args[0] == "build" ? BuildError ?? "" : "",
                StandardOutput = args[0] == "msbuild" ? JsonSerializer.Serialize(new { Properties = new { TargetFrameworks = Targets, TargetFramework = SingleTarget } }) : ""
            });
        }
    }
}
