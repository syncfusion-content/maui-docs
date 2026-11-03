using System.Text.RegularExpressions;
using Spectre.Console;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class PresentationRefinementTests
{
    [Fact]
    public void MissingPlatformToolsShowActionableCauseWithoutChangingDiagnostics()
    {
        const string raw = "RAW SDK OUTPUT: error XA5300: The Android SDK directory could not be found.\n at SDK.Build()";
        var request = new NewProjectRequest(Framework.Maui, "App", "/parent with spaces", "net10.0", "empty", MauiProjectType.App, true, true, false, false);
        var result = new NewProjectResult { ExitCode = 1, ProjectPath = request.ProjectDirectory, GenerationSucceeded = true, BuildSucceeded = false, Message = "Project created, but the build failed.", Errors = [raw] };
        using var capture = new ConsoleCapture();
        NewCommand.ReportNewProjectResult(new ConsolePresenter(true), request, result);
        Assert.Contains("The Android SDK was not found (XA5300)", capture.Error);
        Assert.Contains("Install/configure the Android SDK", capture.Error);
        Assert.Contains("  dotnet build\n", capture.Out.Replace("\r\n", "\n"));
        Assert.Contains("RAW SDK OUTPUT", capture.Error);
        Assert.Equal(raw, Assert.Single(result.Errors));
    }

    [Theory]
    [InlineData(false, null, null)]
    [InlineData(true, true, null)]
    [InlineData(true, false, null)]
    [InlineData(true, true, "net10.0-android")]
    [InlineData(true, false, "net10.0-android")]
    public void NextCommandsMatchActualBuildOutcome(bool build, bool? succeeded, string? framework)
    {
        using var capture = new ConsoleCapture();
        var request = new NewProjectRequest(Framework.Maui, "App", "/parent with spaces", "net10.0", "datagrid",
            MauiProjectType.App, true, build, false, false) with { BuildFramework = framework };
        var path = request.ProjectDirectory;
        var result = new NewProjectResult
        {
            ExitCode = succeeded == false ? ExitCodes.Error : ExitCodes.Success,
            ProjectPath = path, GenerationSucceeded = true, BuildSucceeded = succeeded,
            Message = succeeded == false ? "error NETSDK1147: required workload missing" : "created",
        };
        NewCommand.ReportNewProjectResult(new ConsolePresenter(true), request, result);
        if (succeeded == false)
        {
            var command = "dotnet build" + (framework is null ? "" : $" -f {framework}");
            Assert.Contains(command, capture.Out);
            Assert.Contains($"cd \"{path}\"", capture.Out);
            Assert.Contains("sfdotnet list maui installed", capture.Out);
            Assert.DoesNotContain("-t:Run", capture.Out);
        }
        else
        {
            foreach (var command in ProjectNextCommands.Maui(request, path, succeeded == true))
                Assert.Contains(command, capture.Out);
        }
        Assert.Contains(succeeded == false ? $"Project location: {path}" : $"Project created at {path}", capture.Out);
        if (succeeded == false)
        {
            Assert.Contains("Project created, but the build failed.", capture.Error);
            Assert.Contains("available for fixing and rebuilding", capture.Out);
            Assert.DoesNotContain("Build succeeded", capture.Out);
        }
    }

    [Theory]
    [InlineData(32, "single")]
    [InlineData(120, "single")]
    [InlineData(32, "multiple")]
    [InlineData(120, "text")]
    [InlineData(32, "controls")]
    [InlineData(120, "automatic")]
    public void AllCommittedAnswersShareBlueAndRemainReplaceable(int width, string kind)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        console.WriteLine("Existing terminal output");
        using var region = ProjectWizardOutput.Begin(console);
        var keys = new Queue<ConsoleKeyInfo>(kind is "multiple" or "controls"
            ? [Key(ConsoleKey.Spacebar), Key(ConsoleKey.DownArrow), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)]
            : [Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()));
        switch (kind)
        {
            case "single":
                var single = new WizardSelectionPrompt<string> { Title = "Select a template:" };
                single.AddChoices("App", "Other");
                Assert.Equal("App", input.PromptSingle(single, default, "Template"));
                break;
            case "multiple":
                var multiple = new MultiSelectionPrompt<string> { Title = "Select controls:" };
                multiple.AddChoices("DataGrid", "ListView");
                Assert.Equal(["DataGrid", "ListView"], input.PromptMultiple(multiple, default));
                break;
            case "controls":
                Assert.Equal(["datagrid", "listview"], input.SelectControls([("DataGrid", "datagrid"), ("ListView", "listview")], default));
                break;
            case "text": Assert.Equal("App", input.ReadLine("Name:", "App")); break;
            default: InteractivePrompt.WriteCompletedSelection("Platform:", ".NET MAUI"); break;
        }
        Assert.Contains("38;2;54;117;213", writer.ToString());
        var completed = PromptRenderingTests.Screen(writer.ToString(), width);
        Assert.DoesNotContain("Ctrl+C", completed);
        Assert.DoesNotContain("navigate", completed);
        ProjectWizardOutput.ReplaceCompletedSteps();
        Assert.Equal("Existing terminal output", PromptRenderingTests.Screen(writer.ToString(), width).Trim());
        Assert.Equal(Decoration.Invert | Decoration.Bold, InteractivePrompt.SelectionStyle.Decoration);
    }

    [Theory]
    [InlineData(32, false)]
    [InlineData(120, false)]
    [InlineData(32, true)]
    [InlineData(120, true)]
    public async Task LiveProgressRetainsCompletedPendingAndFailedSteps(int width, bool fail)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        console.WriteLine("Outside operation");
        var progress = new OperationProgress(false, console: console);
        await progress.RunAsync(async callback =>
        {
            using var stages = new OperationStages(callback);
            stages.Plan("Preparing", "Generating files", "Building");
            stages.Start("Preparing"); stages.Complete();
            stages.Start("Generating files"); stages.Advance(2, 4);
            await Task.Delay(190);
            var active = Regex.Replace(PromptRenderingTests.Screen(writer.ToString(), width), @"\s+", " ");
            Assert.Contains("✓ Preparing", active);
            Assert.Contains("2/4", active);
            Assert.Contains("Building — pending", active);
            Assert.DoesNotContain("%", active);
            if (fail) return 1;
            stages.Complete(); stages.Start("Building"); stages.Complete();
            return 0;
        });
        var screen = Regex.Replace(PromptRenderingTests.Screen(writer.ToString(), width), @"\s+", " ");
        Assert.Contains("Outside operation", screen);
        Assert.Contains("✓ Preparing", screen);
        Assert.Single(Regex.Matches(screen, "Preparing"));
        Assert.Equal(fail, screen.Contains("Generating files — failed", StringComparison.Ordinal));
        Assert.Equal(fail, screen.Contains("Building — skipped", StringComparison.Ordinal));
        Assert.Equal(!fail, screen.Contains("✓ Building", StringComparison.Ordinal));
        Assert.DoesNotContain("pending", screen);
    }

    [Fact]
    public async Task CancellationDoesNotMarkUnfinishedStagesCompleted()
    {
        using var capture = new ConsoleCapture();
        var progress = new OperationProgress(true);
        await Assert.ThrowsAsync<OperationCanceledException>(() => progress.RunAsync<int>(callback =>
        {
            using var stages = new OperationStages(callback);
            stages.Plan("Adding packages", "Generating files", "Building");
            stages.Start("Adding packages"); stages.Complete();
            stages.Start("Generating files");
            throw new OperationCanceledException();
        }));
        Assert.Contains("✓ Adding packages", capture.Out);
        Assert.Contains("Generating files — cancelled", capture.Out);
        Assert.Contains("Building — skipped (cancelled)", capture.Out);
        Assert.DoesNotContain("✓ Generating files", capture.Out);
        Assert.DoesNotContain("— failed", capture.Out);
        Assert.True(!capture.Out.Contains('\u001b'), System.Text.Json.JsonSerializer.Serialize(capture.Out));
    }

    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public async Task LifecycleOutputRemainsSuppressedForJsonAndSilent(bool json, bool silent)
    {
        using var capture = new ConsoleCapture();
        await new OperationProgress(true, json, silent).RunAsync(callback =>
        {
            using var stages = new OperationStages(callback);
            stages.Plan("Adding packages", "Building");
            stages.Start("Adding packages"); stages.Advance(1, 2); stages.Complete();
            stages.Start("Building");
            return Task.FromResult(1);
        });
        Assert.Empty(capture.Out);
        Assert.Empty(capture.Error);
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);
    private static IAnsiConsole ConsoleFor(StringWriter writer, int width)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.Yes, ColorSystem = ColorSystemSupport.TrueColor,
            Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer)
        });
        console.Profile.Width = width;
        console.Profile.Height = 90;
        return console;
    }
}

internal sealed class RecordingOperationStages : IOperationStageProgress
{
    public List<string> Planned { get; } = [];
    public List<(string Label, string State)> Events { get; } = [];
    public List<(string Label, int Completed, int Total)> Measurements { get; } = [];
    public void Plan(IEnumerable<string> labels) => Planned.AddRange(labels);
    public void Started(string label) => Events.Add((label, "started"));
    public void Completed(string label) => Events.Add((label, "completed"));
    public void Failed(string label) => Events.Add((label, "failed"));
    public void Advanced(string label, int completed, int total) => Measurements.Add((label, completed, total));
    public void Report(string label) => Events.Add((label, "reported"));
}
