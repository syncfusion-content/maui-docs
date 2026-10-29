using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class ProjectCreationProgressTests
{
    private static NewProjectRequest Request(bool controls, bool build)
        => new(Framework.Maui, "App", Path.GetTempPath(), "net10.0", controls ? "datagrid" : "empty",
            MauiProjectType.App, true, build, false, false);

    private static readonly string[] Configuration = ["Generating files", "Registering in MauiProgram.cs", "Updating navigation", "Writing control manifest", "Writing project manifest"];

    [Theory]
    [InlineData(false, false, false)]
    [InlineData(false, true, false)]
    [InlineData(true, false, false)]
    [InlineData(true, true, false)]
    [InlineData(false, true, true)]
    [InlineData(true, true, true)]
    public async Task GroupsHideDetailsWithoutChangingExecutedStages(bool controls, bool build, bool verbose)
    {
        using var capture = new ConsoleCapture();
        var executed = new List<string>();
        await NewCommand.RunCreationWithProgressAsync(new OperationProgress(true), Request(controls, build), verbose, progress =>
        {
            using var stages = new OperationStages(progress);
            void Run(string label) { executed.Add(label); stages.Plan(label); stages.Start(label); stages.Complete(); }
            Run("Preparing destination");
            Run("Creating project from MAUI template");
            Run("Installing welcome screen");
            if (controls)
            {
                Run("Adding packages"); Run("Restoring");
                foreach (var label in Configuration[..^1]) Run(label);
            }
            Run("Writing project manifest");
            if (build) Run("Building");
            return Task.FromResult(new NewProjectResult { ExitCode = ExitCodes.Success, Message = "Created" });
        });
        Assert.Contains("Installing welcome screen", executed);
        Assert.Contains("Writing project manifest", executed);
        Assert.Equal(controls, executed.Contains("Adding packages"));
        Assert.Equal(build, executed.Contains("Building"));
        if (verbose)
        {
            foreach (var stage in executed) Assert.Contains(stage == "Building" ? "✓ Built project" : "✓ " + stage, capture.Out);
            return;
        }
        var expected = new List<string> { "✓ Creating project" };
        if (controls) expected.Add("✓ Adding Syncfusion controls");
        expected.Add(controls ? "✓ Finalizing project" : "✓ Setting up project files");
        if (build) expected.Add("✓ Built project");
        var completed = capture.Out.Split('\n').Select(line => line.Trim()).Where(line => line.StartsWith("✓ ")).ToArray();
        Assert.Equal(expected, completed);
        Assert.DoesNotContain("Installing welcome screen", capture.Out);
        Assert.DoesNotContain("Adding packages", capture.Out);
        Assert.DoesNotContain("Writing project manifest", capture.Out);
        Assert.DoesNotContain("Restoring", capture.Out);
        Assert.Equal(controls, capture.Out.Contains("Adding Syncfusion controls", StringComparison.Ordinal));
        Assert.Equal(build, capture.Out.Contains("Building", StringComparison.Ordinal));
    }

    [Fact]
    public async Task NextStageIsActiveAsSoonAsCreatingProjectCompletes()
    {
        using var capture = new ConsoleCapture();
        string snapshot = "";
        await NewCommand.RunCreationWithProgressAsync(new OperationProgress(true), Request(controls: true, build: false), verbose: false, progress =>
        {
            using var stages = new OperationStages(progress);
            void Run(string label) { stages.Plan(label); stages.Start(label); stages.Complete(); }
            Run("Preparing destination");
            Run("Creating project from MAUI template");
            // The template is created; the next step (welcome screen) reports no stage the user can see.
            snapshot = capture.Out;
            Run("Adding packages"); Run("Restoring");
            return Task.FromResult(new NewProjectResult { ExitCode = ExitCodes.Success, Message = "Created" });
        });
        var lines = snapshot.Split('\n').Select(line => line.Trim()).ToArray();
        var done = Array.FindIndex(lines, line => line == "✓ Creating project");
        Assert.True(done >= 0);
        Assert.Contains(lines[(done + 1)..], line => line.EndsWith("Adding Syncfusion controls", StringComparison.Ordinal) && !line.Contains("pending"));
    }

    [Theory]
    [InlineData("Preparing destination", "Creating project", false)]
    [InlineData("Creating project from MAUI template", "Creating project", false)]
    [InlineData("Installing welcome screen", "Finalizing project", true)]
    [InlineData("Adding packages", "Adding Syncfusion controls", true)]
    [InlineData("Restoring", "Adding Syncfusion controls", true)]
    [InlineData("Writing project manifest", "Setting up project files", false)]
    [InlineData("Generating files", "Finalizing project", true)]
    [InlineData("Registering in MauiProgram.cs", "Finalizing project", true)]
    [InlineData("Updating navigation", "Finalizing project", true)]
    [InlineData("Writing control manifest", "Finalizing project", true)]
    [InlineData("Writing project manifest", "Finalizing project", true)]
    [InlineData("Building", "Building project", false)]
    public async Task FailureIdentifiesGroupAndSpecificSubstep(string label, string group, bool controls)
    {
        using var capture = new ConsoleCapture();
        var request = Request(controls, true);
        var result = await NewCommand.RunCreationWithProgressAsync(new OperationProgress(true), request, false, progress =>
        {
            using var stages = new OperationStages(progress);
            stages.Start(label);
            return Task.FromResult(new NewProjectResult { ExitCode = ExitCodes.Error, Message = "Creation failed", Errors = ["Disk is full"] });
        });
        NewCommand.ReportNewProjectResult(new ConsolePresenter(true), request, result);
        Assert.Contains(label == "Preparing destination" ? "✗ Creating project: failed while preparing project location"
            : label == "Building" ? "✗ Build failed."
            : $"✗ {group}: failed while {char.ToLowerInvariant(label[0])}{label[1..]}", capture.Out);
        Assert.DoesNotContain($"✓ {group}", capture.Out);
        Assert.Contains("Disk is full", capture.Error);
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(false, true)]
    [InlineData(true, false)]
    [InlineData(true, true)]
    public async Task BuildProgressUsesPlainOutcomeTextAndFolderRetryCommand(bool verbose, bool success)
    {
        using var capture = new ConsoleCapture();
        var request = Request(false, true);
        var result = await NewCommand.RunCreationWithProgressAsync(new OperationProgress(true), request, verbose, progress =>
        {
            using var stages = new OperationStages(progress);
            stages.Start("Building");
            if (success) stages.Complete();
            return Task.FromResult(new NewProjectResult
            {
                ExitCode = success ? ExitCodes.Success : ExitCodes.Error, Message = "Build outcome",
                GenerationSucceeded = true, BuildSucceeded = success, ProjectPath = request.ProjectDirectory,
                Errors = success ? [] : ["Compiler diagnostic"],
            });
        });
        NewCommand.ReportNewProjectResult(new ConsolePresenter(true), request, result);
        Assert.Contains("… Building project", capture.Out);
        Assert.Contains(success ? "✓ Built project" : "✗ Build failed.", capture.Out);
        Assert.DoesNotContain("✓ Building", capture.Out);
        if (!success)
        {
            Assert.Contains("Compiler diagnostic", capture.Error);
            Assert.Contains($"  cd \"{request.ProjectDirectory}\"", capture.Out);
            Assert.Contains("  dotnet build\n", capture.Out.Replace("\r\n", "\n"));
        }
        else Assert.Contains("Project created at ", capture.Out);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task LiveBuildShowsSpinnerAndExactOutcome(bool success)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = Spectre.Console.AnsiConsole.Create(new Spectre.Console.AnsiConsoleSettings
        {
            Ansi = Spectre.Console.AnsiSupport.Yes,
            Interactive = Spectre.Console.InteractionSupport.Yes,
            Out = new Spectre.Console.AnsiConsoleOutput(writer),
        });
        console.Profile.Width = 120;
        console.Profile.Height = 40;
        await NewCommand.RunCreationWithProgressAsync(new OperationProgress(false, console: console), Request(false, true), false,
            async progress =>
            {
                using var stages = new OperationStages(progress);
                stages.Start("Building");
                await Task.Delay(150);
                if (success) stages.Complete();
                return new NewProjectResult { ExitCode = success ? ExitCodes.Success : ExitCodes.Error, Message = "Build outcome" };
            });
        var rendered = System.Text.RegularExpressions.Regex.Replace(writer.ToString(), @"\x1B\[[0-?]*[ -/]*[@-~]", "");
        Assert.Matches("[⠋⠙⠹⠸⠼⠴⠦⠧⠇⠏] Building project", rendered);
        var screen = PromptRenderingTests.Screen(writer.ToString(), 120);
        Assert.Contains(success ? "✓ Built project" : "✗ Build failed.", screen);
        Assert.DoesNotContain("✓ Building project", screen);
    }

    [Fact]
    public async Task CancellationDoesNotMarkTheActiveGroupSuccessfulOrFailed()
    {
        using var capture = new ConsoleCapture();
        await Assert.ThrowsAsync<OperationCanceledException>(() => NewCommand.RunCreationWithProgressAsync(
            new OperationProgress(true), Request(false, true), false, progress =>
            {
                using var stages = new OperationStages(progress);
                stages.Start("Creating project from MAUI template");
                throw new OperationCanceledException();
            }));
        Assert.Contains("! Creating project — cancelled", capture.Out);
        Assert.DoesNotContain("✗ Creating project", capture.Out);
        Assert.DoesNotContain("✓ Creating project", capture.Out);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void SummarySeparatesSetupAndSelectedControls(bool controls)
    {
        var rows = NewCommand.FormatNewProjectReview(Request(controls, false), 120);
        Assert.Contains(controls ? "Setup:             Include Syncfusion controls" : "Setup:             Blank app", rows);
        Assert.Equal(controls, rows.Any(row => row.StartsWith("Controls:", StringComparison.Ordinal)));
        if (controls) Assert.Contains("Controls:          DataGrid", rows);
        Assert.DoesNotContain(rows, row => row.Contains("Controls:          Blank app", StringComparison.Ordinal));
    }
}
