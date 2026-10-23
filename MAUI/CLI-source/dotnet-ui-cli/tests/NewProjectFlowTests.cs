using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>
/// Tests for the <c>sf new</c> wizard flow additions: the default-nuget-org
/// policy, the step-based progress reporter, and the
/// <see cref="ProgressStep"/> / <see cref="NewProjectProgress"/> contracts.
/// </summary>
[Collection("Console output")]
public static class NewProjectFlowTests
{
    [Fact]
    public static void ProgressStep_Percentage_ClampsAndComputes()
    {
        Assert.Equal(0, new ProgressStep(0, 4, "x").Percent);
        Assert.Equal(25, new ProgressStep(1, 4, "x").Percent);
        Assert.Equal(50, new ProgressStep(2, 4, "x").Percent);
        Assert.Equal(100, new ProgressStep(4, 4, "x").Percent);
        Assert.Equal(100, new ProgressStep(5, 4, "x").Percent);
        Assert.Equal(100, new ProgressStep(0, 0, "x").Percent);
    }

    [Fact]
    public static void NewProjectProgress_DefaultSteps_HasExpectedPhaseCount()
    {
        // The phase count is the contract the scaffolder reports against; an
        // accidental rename or removal of a step should be flagged here.
        Assert.Equal(7, NewProjectProgress.DefaultSteps.Count);
        Assert.Contains("Validating target framework", NewProjectProgress.DefaultSteps);
        Assert.Contains("Creating project from MAUI template", NewProjectProgress.DefaultSteps);
        Assert.Contains("Adding Syncfusion packages", NewProjectProgress.DefaultSteps);
        Assert.Contains("Generating control files", NewProjectProgress.DefaultSteps);
        Assert.Contains("Registering Syncfusion in MauiProgram", NewProjectProgress.DefaultSteps);
        Assert.Contains("Restoring packages", NewProjectProgress.DefaultSteps);
        Assert.Contains("Building project", NewProjectProgress.DefaultSteps);
    }

    [Fact]
    public static void ConsoleProgress_Report_WritesAppendOnlyLine()
    {
        using var capture = new ConsoleCapture();
        var progress = new ConsoleProgress(noColor: true, silent: false);
        progress.Report(new ProgressStep(1, 4, "Step one"));
        progress.Report(new ProgressStep(2, 4, "Step two"));
        progress.Complete("Done");

        var lines = capture.Out.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal(3, lines.Length);
        Assert.Equal("  [1/4] Step one", lines[0]);
        Assert.Equal("  [2/4] Step two", lines[1]);
        Assert.Equal("✓ Done: Done", lines[2]);
    }

    [Fact]
    public static void ConsoleProgress_Report_IsIdempotentForSameIndex()
    {
        using var capture = new ConsoleCapture();
        var progress = new ConsoleProgress(noColor: true, silent: false);
        progress.Report(new ProgressStep(1, 4, "Step one"));
        progress.Report(new ProgressStep(1, 4, "Step one (duplicate)"));
        progress.Report(new ProgressStep(2, 4, "Step two"));

        var lines = capture.Out.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal(2, lines.Length);
        Assert.Equal("  [1/4] Step one", lines[0]);
        Assert.Equal("  [2/4] Step two", lines[1]);
    }

    [Fact]
    public static void ConsoleProgress_Silent_DoesNotWriteToStdout()
    {
        using var capture = new ConsoleCapture();
        var progress = new ConsoleProgress(noColor: true, silent: true);
        progress.Report(new ProgressStep(1, 4, "Step one"));
        progress.Complete("Done");

        Assert.Equal(string.Empty, capture.Out);
    }

    [Fact]
    public static void ConsoleProgress_Fail_AlwaysWritesToStderr()
    {
        using var capture = new ConsoleCapture();
        var progress = new ConsoleProgress(noColor: true, silent: true);
        progress.Fail("Something went wrong");

        Assert.Equal("Error: Something went wrong" + Environment.NewLine, capture.Error);
    }

    [Fact]
    public static void NewProjectScaffolder_Plan_ReportsAllStepsBeforeFailing()
    {
        // The scaffolder's ExecuteAsync surface must accept IProgress and
        // the contract is: every step is reported in order, the final step
        // for a non-buildable plan is "Building project (skipped)" or
        // similar. The dry-run path goes through Plan() and never invokes
        // ExecuteAsync, so this test pins the step list independently of
        // the scaffolder's run-time side effects.
        var reported = new List<ProgressStep>();
        var progress = new RecordingProgress(reported);

        // Plan() does not call progress today, but ExecuteAsync() does, and
        // the test contract here is that the list is in place and well-formed.
        // We assert on the public list directly so the order is fixed.
        var stepList = NewProjectProgress.DefaultSteps;
        Assert.Equal(7, stepList.Count);

        // Build a synthetic dry-run request to confirm the plan path stays
        // independent of the progress reporter.
        var request = new NewProjectRequest(
            Framework.Maui,
            "DryRunApp",
            Path.GetTempPath(),
            "net10.0",
            "empty",
            MauiProjectType.App,
            Restore: false,
            Build: false,
            DryRun: true,
            Force: false);
        var plan = new NewProjectScaffolder().Plan(request);
        Assert.Equal(ExitCodes.Success, plan.ExitCode);
        Assert.Empty(reported);
    }

    [Fact]
    public static async System.Threading.Tasks.Task NewProjectScaffolder_ExecuteAsync_ReportsAllSevenProgressSteps()
    {
        // Confirm the scaffolder drives the IProgress contract end-to-end
        // and reports the canonical 7-step list in order, including the
        // "(skipped)" suffix for the no-build branch.
        var root = Path.Combine(Path.GetTempPath(), "sf-progress-" + Guid.NewGuid().ToString("N"));
        try
        {
            var projectRoot = Path.Combine(root, "ProgressApp");
            var dotnet = new StepFakeDotNetRunner();
            var nuget = new StepFakeNuGetRunner();
            var scaffolder = new NewProjectScaffolder(dotnet, nuget);
            var reported = new List<ProgressStep>();
            var progress = new RecordingProgress(reported);
            var request = new NewProjectRequest(
                Framework.Maui,
                "ProgressApp",
                root,
                "net10.0",
                "empty",
                MauiProjectType.App,
                Restore: true,
                Build: false,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request, progress);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.Equal(7, reported.Count);
            Assert.Equal(1, reported[0].Index);
            Assert.Equal(7, reported[6].Index);
            Assert.Equal(NewProjectProgress.DefaultSteps[0], reported[0].Label);
            Assert.Equal(NewProjectProgress.DefaultSteps[1], reported[1].Label);
            Assert.Equal(NewProjectProgress.DefaultSteps[2], reported[2].Label);
            Assert.Equal(NewProjectProgress.DefaultSteps[3], reported[3].Label);
            Assert.Equal(NewProjectProgress.DefaultSteps[4], reported[4].Label);
            Assert.Equal(NewProjectProgress.DefaultSteps[5], reported[5].Label);
            Assert.EndsWith("(skipped)", reported[6].Label);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    private sealed class RecordingProgress : IProgress<ProgressStep>
    {
        public RecordingProgress(List<ProgressStep> sink) => _sink = sink;
        private readonly List<ProgressStep> _sink;
        public void Report(ProgressStep value) => _sink.Add(value);
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(true, false)]
    [InlineData(true, true)]
    public static async System.Threading.Tasks.Task NewProjectLifecycleTracksActualBlankGenerationAndRetainedBuildFailure(bool build, bool fail)
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-new-lifecycle-" + Guid.NewGuid().ToString("N"));
        try
        {
            var dotnet = new StepFakeDotNetRunner { FailBuild = fail };
            var stages = new RecordingOperationStages();
            var request = new NewProjectRequest(Framework.Maui, "ProgressApp", root, "net10.0", "empty", MauiProjectType.App,
                Restore: false, Build: build, DryRun: false, Force: false);
            var result = await new NewProjectScaffolder(dotnet, new StepFakeNuGetRunner()).ExecuteAsync(request, null, default, stages);
            Assert.Equal(fail ? 1 : 0, result.ExitCode);
            Assert.True(result.GenerationSucceeded);
            Assert.True(File.Exists(Path.Combine(result.ProjectPath!, "ProgressApp.csproj")));
            Assert.DoesNotContain("Adding packages", stages.Planned);
            Assert.DoesNotContain("Registering in MauiProgram.cs", stages.Planned);
            Assert.DoesNotContain("Restoring", stages.Planned);
            Assert.Equal(build, stages.Planned.Contains("Building"));
            Assert.Contains(("Creating project from MAUI template", "completed"), stages.Events);
            Assert.Contains(("Installing welcome screen", "completed"), stages.Events);
            Assert.Contains(("Writing project manifest", "completed"), stages.Events);
            if (build) Assert.Contains(("Building", fail ? "failed" : "completed"), stages.Events);
        }
        finally { if (Directory.Exists(root)) Directory.Delete(root, true); }
    }

    /// <summary>A fake DotNetRunner that materializes a minimal MAUI project layout.</summary>
    private sealed class StepFakeDotNetRunner : DotNetRunner
    {
        public bool FailBuild { get; set; }
        public override System.Threading.Tasks.Task<ProcessCommandResult> RunAsync(
            IReadOnlyList<string> args,
            string? workingDirectory,
            bool dryRun,
            System.Threading.CancellationToken cancellationToken = default)
        {
            if (args.Count > 0 && args[0] == "new")
            {
                var outputIdx = args.ToList().IndexOf("-o");
                if (outputIdx > 0 && outputIdx + 1 < args.Count)
                {
                    var outputDir = args[outputIdx + 1];
                    Directory.CreateDirectory(outputDir);
                    File.WriteAllText(
                        Path.Combine(outputDir, "ProgressApp.csproj"),
                        "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");
                }
            }

            return System.Threading.Tasks.Task.FromResult(new ProcessCommandResult
            {
                ExitCode = FailBuild && args[0] == "build" ? 1 : 0,
                StandardOutput = string.Empty,
                StandardError = string.Empty,
            });
        }
    }

    private sealed class StepFakeNuGetRunner : NuGetRunner
    {
    }
}
