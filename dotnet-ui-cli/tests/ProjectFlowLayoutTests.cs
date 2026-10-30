using Spectre.Console;
using Spectre.Console.Rendering;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class ProjectFlowLayoutTests
{
    [Fact]
    public void LabelListDeterminesOneValueColumnForAllRows()
    {
        Assert.Equal("Project location:".Length + 2, ProjectFlowLayout.ValueColumn);
        Assert.Equal(ProjectFlowLayout.Labels.Max(label => label.Length) + 2, ProjectFlowLayout.ValueColumn);
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 120);
        using var flow = ProjectWizardOutput.Begin(console, true);
        foreach (var label in ProjectFlowLayout.Labels)
            ProjectWizardOutput.WriteCompletedValue(console, label, "Value", true);
        foreach (var line in writer.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries))
            Assert.Equal(ProjectFlowLayout.ValueColumn, line.IndexOf("Value", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData(32, true)]
    [InlineData(120, true)]
    [InlineData(32, false)]
    [InlineData(120, false)]
    public void ProjectNameDefaultAndAcceptedValueShareColumnWithoutPaddingFooter(int width, bool noColor)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        using var flow = ProjectWizardOutput.Begin(console, noColor);
        var input = new InteractiveConsoleInput(console, _ =>
        {
            var screen = PromptRenderingTests.Screen(writer.ToString(), width);
            Assert.Contains("Project name:".PadRight(ProjectFlowLayout.ValueColumn) + "[App]", screen);
            Assert.Contains("Enter: continue", screen);
            Assert.DoesNotContain(new string(' ', ProjectFlowLayout.ValueColumn) + "Enter:", screen);
            return Task.FromResult<ConsoleKeyInfo?>(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false));
        }, noColor);
        Assert.Equal("App", input.ReadLine("Project name:", "App", compactDefault: true));
        var completed = PromptRenderingTests.Screen(writer.ToString(), width);
        Assert.Contains("Project name:".PadRight(ProjectFlowLayout.ValueColumn) + "App", completed);
        if (!noColor) Assert.DoesNotContain("[App]", completed);
    }

    [Theory]
    [InlineData(32)]
    [InlineData(60)]
    [InlineData(120)]
    public void PromptAnswersAndSummaryWrapPathsAtTheSameColumn(int width)
    {
        var path = Path.Combine(Path.GetTempPath(), "日本語 folder", new string('x', 80));
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        using var flow = ProjectWizardOutput.Begin(console, true);
        ProjectWizardOutput.WriteCompletedValue(console, "Project location:", path, true);
        var answer = writer.ToString().Replace("\r\n", "\n").Split('\n', StringSplitOptions.RemoveEmptyEntries);
        Assert.All(answer, line => Assert.True(new Segment(line).CellCount() <= width));
        Assert.Equal(path, string.Concat(answer.Select(line => line[ProjectFlowLayout.ValueColumn..])));
        Assert.All(answer.Skip(1), line => Assert.StartsWith(new string(' ', ProjectFlowLayout.ValueColumn), line));
        var request = new NewProjectRequest(Framework.Maui, "App", path, "net10.0", "empty", MauiProjectType.App, false, false, false, false);
        var summary = NewCommand.FormatNewProjectReview(request, width);
        Assert.All(summary, line => Assert.True(new Segment(line).CellCount() <= width));
        var first = summary.ToList().FindIndex(line => line.StartsWith("Project location:", StringComparison.Ordinal));
        var destination = summary.Skip(first).TakeWhile((line, index) => index == 0 || line.StartsWith(' '));
        Assert.Equal(Path.GetFullPath(request.Path), string.Concat(destination.Select(line => line[ProjectFlowLayout.ValueColumn..])));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void ReviewUsesPromptOrderAndChosenLocationWhileSuccessShowsFullPath(bool controls)
    {
        var parent = Path.Combine(Path.GetTempPath(), "ChosenFolder");
        var request = new NewProjectRequest(Framework.Maui, "MyApp", parent, "net10.0", controls ? "datagrid" : "empty",
            MauiProjectType.App, false, false, false, false);
        var review = NewCommand.FormatNewProjectReview(request, 160);
        var expected = new List<string> { "Action:", "Platform:", "Template:", "Framework:", "Project location:", "Project name:", "Setup:" };
        if (controls) expected.Add("Controls:");
        expected.Add("Post-create:");
        Assert.Equal(expected, review.Select(row => row[..(row.IndexOf(':') + 1)]));
        Assert.Contains("Project location:".PadRight(ProjectFlowLayout.ValueColumn) + parent, review);
        Assert.DoesNotContain(review, row => row.StartsWith("Location:", StringComparison.Ordinal) || row.StartsWith("Destination:", StringComparison.Ordinal));
        using var capture = new ConsoleCapture();
        NewCommand.ReportNewProjectResult(new ConsolePresenter(true), request,
            new NewProjectResult { ExitCode = ExitCodes.Success, Message = "Created", ProjectPath = request.ProjectDirectory, GenerationSucceeded = true });
        Assert.Contains($"Project created at {Path.Combine(parent, "MyApp")}", capture.Out);
    }

    private static IAnsiConsole ConsoleFor(StringWriter writer, int width)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes,
            Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = width;
        console.Profile.Height = 40;
        return console;
    }
}
