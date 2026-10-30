using System.Text.RegularExpressions;
using Spectre.Console;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class PromptRenderingTests : IDisposable
{
    private readonly string? _previousNoColor = Environment.GetEnvironmentVariable("NO_COLOR");
    public PromptRenderingTests() => Environment.SetEnvironmentVariable("NO_COLOR", null);
    public void Dispose() => Environment.SetEnvironmentVariable("NO_COLOR", _previousNoColor);

    [Theory]
    [InlineData(32, "single")]
    [InlineData(120, "single")]
    [InlineData(32, "multiple")]
    [InlineData(120, "multiple")]
    [InlineData(32, "text")]
    [InlineData(120, "text")]
    [InlineData(32, "controls")]
    [InlineData(120, "controls")]
    public void CompletedPromptClearsItsEntireRegionAndPreservesEarlierResults(int width, string kind)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        console.WriteLine("Platform: .NET MAUI");
        var keys = kind is "multiple" or "controls"
            ? new[] { Key(ConsoleKey.Spacebar), Key(ConsoleKey.DownArrow), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter) }
            : new[] { Key(ConsoleKey.DownArrow), Key(ConsoleKey.UpArrow), Key(ConsoleKey.Enter) };
        if (kind == "text") { keys = [Key(ConsoleKey.Enter)]; }
        var queue = new Queue<ConsoleKeyInfo>(keys);
        var input = new InteractiveConsoleInput(console, _ =>
        {
            var active = Screen(writer.ToString(), width);
            Assert.Contains("Platform: .NET MAUI", active);
            Assert.Contains("Enter: continue", active);
            return Task.FromResult<ConsoleKeyInfo?>(queue.Dequeue());
        }, noColor: false);
        Run(kind, input);
        var completed = Screen(writer.ToString(), width);
        Assert.Contains("Platform: .NET MAUI", completed);
        Assert.DoesNotContain("navigate", completed);
        Assert.DoesNotContain("continue", completed);
        Assert.DoesNotContain("cancel", completed);
        Assert.DoesNotContain("Ctrl+C", completed);
        Assert.DoesNotContain("Select", completed);
        Assert.DoesNotContain("Unselected option", completed);
        Assert.DoesNotContain("[ ]", completed);
        Assert.DoesNotContain("[x]", completed);
        Assert.Contains(kind == "text" ? "Name: Demo" : kind == "single" ? "Template: App" : "DataGrid, ListView",
            Regex.Replace(completed, @"\s+", " "));
        Assert.Single(completed.Split('\n'), line => line.StartsWith(kind == "text" ? "Name:" : kind == "single" ? "Template:" : "Controls", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("single", false)]
    [InlineData("single", true)]
    [InlineData("multiple", false)]
    [InlineData("multiple", true)]
    [InlineData("text", false)]
    [InlineData("text", true)]
    [InlineData("controls", false)]
    [InlineData("controls", true)]
    public void EscapeAndCtrlCClearTemporaryContentWithoutRecordingASelection(string kind, bool controlC)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 32);
        console.WriteLine("Platform: .NET MAUI");
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(
            controlC ? new ConsoleKeyInfo('\u0003', ConsoleKey.C, false, false, true) : Key(ConsoleKey.Escape)), false);
        if (controlC) { Assert.Throws<OperationCanceledException>(() => Run(kind, input)); }
        else if (kind == "text") { Assert.Null(input.ReadLine("Name:", "Demo")); }
        else { Assert.Throws<InteractivePromptCancelledException>(() => Run(kind, input)); }
        Assert.Equal("Platform: .NET MAUI", Screen(writer.ToString(), 32).Trim());
    }

    [Theory]
    [InlineData("single")]
    [InlineData("multiple")]
    public void TokenCancellationClearsSpectrePromptBeforePropagating(string kind)
    {
        using var writer = new StringWriter();
        using var cancellation = new CancellationTokenSource();
        var console = ConsoleFor(writer, 32);
        console.WriteLine("Previous result");
        var input = new InteractiveConsoleInput(console, token =>
        {
            cancellation.Cancel();
            return Task.FromCanceled<ConsoleKeyInfo?>(token);
        }, false);
        Assert.ThrowsAny<OperationCanceledException>(() => Run(kind, input, cancellation.Token));
        Assert.Equal("Previous result", Screen(writer.ToString(), 32).Trim());
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void InputFailureClearsThePromptBeforePreservingTheOriginalException(bool multiple)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 32);
        console.WriteLine("Previous result");
        var failure = new IOException("Input ended");
        var input = new InteractiveConsoleInput(console, _ => Task.FromException<ConsoleKeyInfo?>(failure), false);
        if (multiple)
        {
            var prompt = new MultiSelectionPrompt<string> { Title = "Select controls:" };
            prompt.AddChoices("DataGrid", "ListView");
            Assert.Same(failure, Assert.Throws<IOException>(() => input.PromptMultiple(prompt, CancellationToken.None)));
        }
        else
        {
            var prompt = new WizardSelectionPrompt<string> { Title = "Select a template:" };
            prompt.AddChoices("App", "Other");
            Assert.Same(failure, Assert.Throws<IOException>(() => input.PromptSingle(prompt, CancellationToken.None)));
        }
        Assert.Equal("Previous result", Screen(writer.ToString(), 32).Trim());
    }

    [Theory]
    [InlineData(32, false)]
    [InlineData(120, false)]
    [InlineData(32, true)]
    [InlineData(120, true)]
    public void ConfirmationReusesRetainedAnswersWithoutCursorErasure(int width, bool noColor)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        var original = AnsiConsole.Console;
        try
        {
            using var region = ProjectWizardOutput.Begin(console, noColor);
            var input = new InteractiveConsoleInput(console,
                _ => Task.FromResult<ConsoleKeyInfo?>(Key(ConsoleKey.Enter)), noColor);
            var prompt = new WizardSelectionPrompt<string> { Title = "Language:" };
            prompt.AddChoices("C#", "VB");
            input.PromptSingle(prompt, default, "Language");
            ProjectWizardOutput.WriteCompletedValue(console, "Project location:", "/Users/developer/Projects/a/long/location", noColor);
            var before = writer.ToString();
            ProjectWizardOutput.ReuseCompletedSteps(new ConsolePresenter(noColor),
                [("Language:", "C#"), ("Project location:", "/Users/developer/Projects/a/long/location")]);
            Assert.Equal(before, writer.ToString());
            var screen = Screen(writer.ToString(), width);
            Assert.DoesNotContain("[Language:", screen);
            Assert.Single(Regex.Matches(screen, "(?m)^Language: +C# *$"));
            Assert.Single(Regex.Matches(screen, "Project location:"));
        }
        finally { AnsiConsole.Console = original; }
    }

    [Fact]
    public void AutomaticallyResolvedValuesEmitResultsWithoutQuestionsOrHints()
    {
        using var capture = new ConsoleCapture();
        Assert.Equal("net10.0", InteractivePrompt.AskTargetFramework(["net10.0"], noColor: false));
        Assert.Equal($"Framework: .NET 10 (net10.0){Environment.NewLine}", capture.Out);
    }

    [Fact]
    public void ConsecutivePromptsRetainOnlyTheirResultsAndTheCurrentPromptsHints()
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 32);
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.Enter), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ =>
        {
            var active = Screen(writer.ToString(), 32);
            Assert.Single(Regex.Matches(active, "Enter: continue"));
            return Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue());
        }, false);
        Run("single", input);
        var multiple = new MultiSelectionPrompt<string> { Title = "Select controls:" };
        multiple.AddChoices("DataGrid", "ListView");
        InteractivePrompt.ConfigureMultiSelectionPrompt(multiple);
        input.PromptMultiple(multiple, CancellationToken.None);
        Run("text", input);
        Assert.Equal("Template: App\nControls: DataGrid\nName: Demo", Screen(writer.ToString(), 32).Trim());
    }

    [Theory]
    [InlineData("single")]
    [InlineData("multiple")]
    [InlineData("text")]
    [InlineData("controls")]
    public void ActiveHelpOccursOnceAtBottomWithOneEmptyLine(string kind)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 120);
        // Multi-select needs one toggle followed by submission.
        var calls = 0;
        var input = new InteractiveConsoleInput(console, _ =>
        {
            var lines = Screen(writer.ToString(), 120).Split('\n');
            var helper = Assert.Single(lines.Select((text, index) => (text, index)),
                row => row.text.Contains("Enter: continue"));
            Assert.Equal(lines.Length - 1, helper.index);
            Assert.Equal("", lines[helper.index - 1]);
            Assert.NotEqual("", lines[helper.index - 2]);
            return Task.FromResult<ConsoleKeyInfo?>(Key(calls++ == 0 && kind is "multiple" or "controls"
                ? ConsoleKey.Spacebar : ConsoleKey.Enter));
        }, false);
        Run(kind, input);
        Assert.DoesNotContain("Enter: continue", Screen(writer.ToString(), 120));
    }

    [Fact]
    public void LocationNoticeIsBelowTheInputAndClearsBeforeProgress()
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 120);
        var keys = new Queue<ConsoleKeyInfo>([new('x', ConsoleKey.X, false, false, false), Key(ConsoleKey.Backspace), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ =>
        {
            var active = Screen(writer.ToString(), 120);
            Assert.True(active.IndexOf("Project location:", StringComparison.Ordinal) < active.IndexOf("Project will be created", StringComparison.Ordinal));
            Assert.Single(Regex.Matches(active, "Enter: continue"));
            return Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue());
        }, false);
        input.ReadLine("Project location:", "/tmp", guidance: "Project will be created in <location>/<name>.");
        console.WriteLine("Creating project");
        var completed = Screen(writer.ToString(), 120);
        Assert.Equal("Project location: /tmp\nCreating project", completed.Trim());
        Assert.DoesNotContain("\u001b[s", writer.ToString());
        Assert.DoesNotContain("\u001b[u", writer.ToString());
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void LongChoiceListsKeepHelpVisibleInShortTerminals(bool controls)
    {
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, 120);
        console.Profile.Height = 12;
        var keys = new Queue<ConsoleKeyInfo>(Enumerable.Repeat(Key(ConsoleKey.DownArrow), 19)
            .Concat(controls ? [Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)] : [Key(ConsoleKey.Enter)]));
        var input = new InteractiveConsoleInput(console, _ =>
        {
            var active = Screen(writer.ToString(), 120).TrimEnd().Split('\n');
            Assert.True(active.Length <= 12);
            Assert.Contains("Ctrl+C: exit", active[^1]);
            Assert.Equal("", active[^2]);
            return Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue());
        }, false);
        var choices = Enumerable.Range(1, 20).Select(number => $"Choice {number}").ToArray();
        if (controls)
            Assert.Equal(["Choice 20"], input.SelectControls(choices.Select(label => (label, label)).ToArray(), default));
        else
        {
            var prompt = new WizardSelectionPrompt<string> { Title = "Choose:", PageSize = 20 };
            prompt.AddChoices(choices);
            Assert.Equal("Choice 20", input.PromptSingle(prompt, default));
        }
    }

    private static void Run(string kind, InteractiveConsoleInput input, CancellationToken token = default)
    {
        if (kind == "text") { input.ReadLine("Name:", "Demo", token); return; }
        if (kind == "controls") { input.SelectControls([("DataGrid", "datagrid"), ("ListView", "listview")], token); return; }
        if (kind == "single")
        {
            var prompt = new WizardSelectionPrompt<string> { Title = "Select a template:" };
            prompt.AddChoices("App", "Unselected option");
            InteractivePrompt.ConfigureSelectionPrompt(prompt, 2);
            input.PromptSingle(prompt, token, "Template");
        }
        else
        {
            var prompt = new MultiSelectionPrompt<string> { Title = "Select controls:" };
            prompt.AddChoices("DataGrid", "ListView", "Unselected option");
            InteractivePrompt.ConfigureMultiSelectionPrompt(prompt);
            input.PromptMultiple(prompt, token);
        }
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);

    private static IAnsiConsole ConsoleFor(StringWriter writer, int width)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.Yes, ColorSystem = ColorSystemSupport.NoColors,
            Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer),
        });
        console.Profile.Width = width;
        console.Profile.Height = 60;
        return console;
    }

    // Project VT output onto a terminal grid: stripping ANSI would retain erased hints.
    internal static string Screen(string output, int width)
    {
        var rows = Enumerable.Range(0, 100).Select(_ => Enumerable.Repeat(' ', width).ToArray()).ToArray();
        var x = 0;
        var y = 0;
        var saved = (X: 0, Y: 0);
        for (var index = 0; index < output.Length; index++)
        {
            var character = output[index];
            if (character == '\u001b')
            {
                var match = Regex.Match(output[index..], @"^\x1b\[([0-9;?]*)([A-Za-z])");
                if (!match.Success) { index++; continue; }
                index += match.Length - 1;
                var command = match.Groups[2].Value;
                var arguments = match.Groups[1].Value.Split(';').Select(value => int.TryParse(value, out var number) ? number : 0).ToArray();
                var count = Math.Max(1, arguments[0]);
                switch (command)
                {
                    case "A": y = Math.Max(0, y - count); break;
                    case "B": y += count; break;
                    case "C": x += count; break;
                    case "D": x = Math.Max(0, x - count); break;
                    case "E": y += count; x = 0; break;
                    case "F": y = Math.Max(0, y - count); x = 0; break;
                    case "G": x = count - 1; break;
                    case "H": case "f": y = count - 1; x = arguments.Length > 1 ? Math.Max(0, arguments[1] - 1) : 0; break;
                    case "K": Array.Fill(rows[y], ' ', arguments[0] == 2 ? 0 : x, arguments[0] == 2 ? width : width - x); break;
                    case "J":
                        Array.Fill(rows[y], ' ', x, width - x);
                        for (var row = y + 1; row < rows.Length; row++) { Array.Fill(rows[row], ' '); }
                        break;
                    case "s": saved = (x, y); break;
                    case "u": (x, y) = saved; break;
                }
                continue;
            }
            if (character == '\r') { x = 0; continue; }
            if (character == '\n') { y++; x = 0; continue; }
            if (char.IsControl(character)) { continue; }
            if (x == width) { x = 0; y++; }
            rows[y][x++] = character;
        }
        return string.Join('\n', rows.Select(row => new string(row).TrimEnd())).TrimEnd();
    }
}
