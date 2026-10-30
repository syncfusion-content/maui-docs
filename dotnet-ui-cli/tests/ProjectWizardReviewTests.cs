using System.Text.RegularExpressions;
using Spectre.Console;
using Spectre.Console.Rendering;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class ProjectWizardReviewTests : IDisposable
{
    private readonly string? _previousNoColor = Environment.GetEnvironmentVariable("NO_COLOR");
    public ProjectWizardReviewTests() => Environment.SetEnvironmentVariable("NO_COLOR", null);
    public void Dispose() => Environment.SetEnvironmentVariable("NO_COLOR", _previousNoColor);

    [Theory]
    [InlineData(32, "default")]
    [InlineData(120, "default")]
    [InlineData(32, "explicit")]
    [InlineData(120, "explicit")]
    [InlineData(32, "generate")]
    [InlineData(120, "generate")]
    public void ReviewReplacesCompletedStepsAndKeepsOnlyActiveConfirmationHints(int width, string mode)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        console.WriteLine("Earlier build output");
        console.WriteLine("Syncfusion .NET CLI header");
        using var wizard = ProjectWizardOutput.Begin(console);
        ProjectWizardOutput.WriteCompleted(console, "Action: Create a new project");
        ProjectWizardOutput.WriteCompleted(console, "Platform: .NET MAUI");
        var keys = new Queue<ConsoleKeyInfo>(Enumerable.Repeat(Key(ConsoleKey.Enter), 4)
            .Concat(new[] { Key(ConsoleKey.Spacebar), Key(ConsoleKey.DownArrow), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter), Key(ConsoleKey.Enter) }));
        var awaitingConfirmation = false;
        var input = new InteractiveConsoleInput(console, _ =>
        {
            if (awaitingConfirmation)
            {
                var active = PromptRenderingTests.Screen(writer.ToString(), width);
                var normalized = Regex.Replace(active, @"\s+", " ");
                Assert.Contains(NewCommand.CreationConfirmation + " [Y/n]:", normalized);
                Assert.Contains("Esc: cancel", normalized);
                Assert.Single(Regex.Matches(active, "Platform:"));
                Assert.Single(Regex.Matches(active, "Controls:"));
                Assert.Single(Regex.Matches(active, "Setup:"));
                Assert.Single(Regex.Matches(active, "Project location:"));
                Assert.DoesNotContain("contains the new project folder", active);
            }
            return Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue());
        }, false);
        var prompt = new WizardSelectionPrompt<string> { Title = "Select a project template:" };
        prompt.AddChoices(".NET MAUI App", ".NET MAUI Blazor Hybrid");
        input.PromptSingle(prompt, default, "Template");
        input.ReadLine("Project name:", "App");
        input.ReadLine("Project location:", "/tmp/parent with spaces", guidance:
            "Project location contains the new project folder (<location>/<name>).");
        input.ReadLine("Setup:", "Include Syncfusion controls");
        input.SelectControls([("DataGrid", "datagrid"), ("ListView", "listview")], default);
        ProjectWizardOutput.WriteCompleted(console, "Post-create: Build project");
        var request = Request("/tmp/parent with spaces") with
        {
            Build = mode != "generate",
            BuildFramework = mode == "explicit" ? "net10.0-android" : null,
            TemplateIds = ["datagrid", "listview"]
        };
        ProjectWizardOutput.ReplaceCompletedSteps();
        foreach (var line in NewCommand.FormatNewProjectReview(request, width)) { console.WriteLine(line); }
        awaitingConfirmation = true;
        Assert.True(InteractivePrompt.Confirm(NewCommand.CreationConfirmation, true, input));
        console.WriteLine("Later output");
        var screen = PromptRenderingTests.Screen(writer.ToString(), width);
        Assert.Contains("Earlier build output", screen);
        Assert.Contains("Syncfusion .NET CLI header", screen);
        Assert.Contains("Later output", screen);
        Assert.Single(Regex.Matches(screen, "Post-create:"));
        Assert.Single(Regex.Matches(screen, "Controls:"));
        Assert.DoesNotContain("Controls (", screen);
        Assert.DoesNotContain("Enter: continue", screen);
        Assert.DoesNotContain("Ctrl+C", screen);
        Assert.DoesNotContain(NewCommand.CreationConfirmation, screen);
        Assert.DoesNotContain("Build target:", screen);
        if (mode == "explicit") Assert.Contains("Buildproject(net10.0-android)", Regex.Replace(screen, @"\s+", ""));
    }

    [Theory]
    [InlineData(32, false)]
    [InlineData(120, false)]
    [InlineData(32, true)]
    [InlineData(120, true)]
    public void CancellationClearsWrappedConfirmationHintsAndPreservesReview(int width, bool controlC)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        foreach (var line in NewCommand.FormatNewProjectReview(Request("/tmp"), width)) { console.WriteLine(line); }
        var before = PromptRenderingTests.Screen(writer.ToString(), width);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(controlC
            ? new ConsoleKeyInfo('\u0003', ConsoleKey.C, false, false, true) : Key(ConsoleKey.Escape)), false);
        if (controlC) { Assert.Throws<OperationCanceledException>(() => InteractivePrompt.Confirm(NewCommand.CreationConfirmation, true, input)); }
        else { Assert.Throws<InteractivePromptCancelledException>(() => InteractivePrompt.Confirm(NewCommand.CreationConfirmation, true, input)); }
        Assert.Equal(before, PromptRenderingTests.Screen(writer.ToString(), width));
    }

    [Theory]
    [InlineData(32)]
    [InlineData(60)]
    [InlineData(120)]
    public void LongDestinationsWrapWithoutChangingTheChosenPath(int width)
    {
        var parent = Path.GetFullPath(Path.Combine(Path.GetTempPath(), "App", "日本語 folder with spaces", new string('x', 75)));
        var request = Request(parent);
        var review = NewCommand.FormatNewProjectReview(request, width);
        Assert.All(review, line => Assert.True(new Segment(line).CellCount() <= width, line));
        var first = review.ToList().FindIndex(line => line.StartsWith("Project location:"));
        var lines = review.Skip(first).TakeWhile((line, index) => index == 0 || line.StartsWith(' ')).ToArray();
        var values = lines.Select(line => line[ProjectFlowLayout.ValueColumn..]);
        Assert.Equal(Path.GetFullPath(request.Path), string.Concat(values));
        Assert.All(review.Where(line => !line.StartsWith(' ')), line => Assert.True(line.IndexOf(':') < ProjectFlowLayout.ValueColumn));
    }

    [Fact]
    public void IdenticalParentAndProjectNamesNestAndMatchTheBuildPlan()
    {
        var parent = Path.Combine(Path.GetTempPath(), "App");
        var request = Request(parent);
        var result = new NewProjectScaffolder().Plan(request);
        Assert.Equal(Path.Combine(parent, "App"), result.ProjectPath);
        Assert.Contains(NewCommand.FormatNewProjectReview(request, 160), line => line == "Project location:".PadRight(ProjectFlowLayout.ValueColumn) + Path.GetFullPath(request.Path));
        Assert.Contains($"dotnet build \"{Path.Combine(parent, "App", "App.csproj")}\"", result.Plan!.CommandsToExecute);
        Assert.DoesNotContain(result.Plan.CommandsToExecute, command => command.Contains(" -f ") || command.Contains("TargetFramework="));
    }

    private static NewProjectRequest Request(string parent)
        => new(Framework.Maui, "App", parent, "net10.0", "empty", MauiProjectType.App, true, true, false, false);

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);

    private static IAnsiConsole ConsoleFor(StringWriter writer, int width)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.Yes, ColorSystem = ColorSystemSupport.NoColors,
            Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer)
        });
        console.Profile.Width = width;
        console.Profile.Height = 90;
        return console;
    }
}
