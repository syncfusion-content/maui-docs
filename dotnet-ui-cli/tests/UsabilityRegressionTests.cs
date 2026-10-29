using System.Text.RegularExpressions;
using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class UsabilityRegressionTests
{
    [Theory]
    [InlineData(32, 24)]
    [InlineData(32, 31)]
    [InlineData(32, 90)]
    [InlineData(120, 24)]
    [InlineData(120, 31)]
    [InlineData(120, 90)]
    public void ExitSelectionKeepsFooterMutedAndClearsTemporaryMenu(int width, int height)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        console.Profile.Height = height;
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.UpArrow), Key(ConsoleKey.Enter)]);
        string? exitFrame = null;
        var input = new InteractiveConsoleInput(console, _ =>
        {
            if (keys.Count == 1) exitFrame = writer.ToString();
            return Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue());
        });
        var choices = MenuItems.Categories.SelectMany(category => new[] { MenuItems.CreateCategoryChoice(category) }
            .Concat(category.Operations)).Append(MenuItems.Operations[^1]).ToArray();
        Assert.Equal(MenuAction.Exit, input.SelectMenu(choices, default).Action);
        Assert.DoesNotContain(InteractiveMenu.MenuGuidance, InteractiveMenu.FormatChoice(MenuItems.Operations[^1], false));
        Assert.NotNull(exitFrame);
        var exitScreen = PromptRenderingTests.Screen(exitFrame, width);
        Assert.Contains("  >   Exit", exitScreen);
        Assert.All(MenuItems.Categories, category =>
            Assert.Contains(category.Name.ToUpperInvariant(), exitScreen));
        Assert.Matches("\\u001b\\[(?:1;7|7;1)m", exitFrame);
        Assert.Contains("38;2;139;148;158", exitFrame);
        foreach (Match styledText in Regex.Matches(exitFrame, "\\u001b\\[([0-9;]*)m([^\\u001b]*)"))
        {
            if (!styledText.Groups[2].Value.Contains("↑/↓", StringComparison.Ordinal)) continue;
            Assert.Contains("38;2;139;148;158", styledText.Groups[1].Value);
            Assert.DoesNotContain("7", styledText.Groups[1].Value.Split(';'));
        }
        var final = PromptRenderingTests.Screen(writer.ToString(), width);
        Assert.DoesNotContain("navigate", final);
        Assert.Contains("Exit", final);
    }

    [Theory]
    [InlineData("Project name:", 32)]
    [InlineData("Project location:", 120)]
    public void TextInputsShowPositionedCursorWhileEditingAndRestoreIt(string label, int width)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = ConsoleFor(writer, width);
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.Home), Key(ConsoleKey.Delete), Character('X'), Key(ConsoleKey.End), Character('Z'), Key(ConsoleKey.Enter)]);
        var cursorText = new Queue<string>(["[Default]@", "[Default]@efault", "[Default]@fault", "[Default]X@fault", "[Default]Xefault@", "[Default]XefaultZ@"]);
        var input = new InteractiveConsoleInput(console, _ =>
        {
            var output = writer.ToString();
            Assert.True(output.LastIndexOf("\u001b[?25h", StringComparison.Ordinal) > output.LastIndexOf("\u001b[?25l", StringComparison.Ordinal));
            Assert.Matches("\\u001b\\[[0-9]+G", output);
            // A character written now would land at the actual editing cursor.
            var screenAtCursor = Regex.Replace(PromptRenderingTests.Screen(output + "@", width), @"\s+", "");
            Assert.Contains(cursorText.Dequeue(), screenAtCursor);
            return Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue());
        });
        Assert.Equal("XefaultZ", input.ReadLine(label, "Default", compactDefault: true));
        Assert.EndsWith("\u001b[?25h", writer.ToString());
        var final = PromptRenderingTests.Screen(writer.ToString(), width);
        Assert.DoesNotContain("Default]", final);
        Assert.Contains("XefaultZ", final);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void TextInputCancellationClearsHintsAndRestoresVisibleCursor(bool controlC)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var input = new InteractiveConsoleInput(ConsoleFor(writer, 120), _ => Task.FromResult<ConsoleKeyInfo?>(
            controlC ? new ConsoleKeyInfo('\u0003', ConsoleKey.C, false, false, true) : Key(ConsoleKey.Escape)));
        if (controlC) Assert.Throws<OperationCanceledException>(() => input.ReadLine("Project name:", "Default"));
        else Assert.Null(input.ReadLine("Project name:", "Default"));
        Assert.EndsWith("\u001b[?25h", writer.ToString());
        Assert.DoesNotContain("Project name", PromptRenderingTests.Screen(writer.ToString(), 120));
    }

    [Fact]
    public void InputReadErrorsClearTemporaryContentAndRestoreCursor()
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var input = new InteractiveConsoleInput(ConsoleFor(writer, 120), _ => throw new IOException("terminal closed"));
        Assert.Throws<IOException>(() => input.ReadLine("Project location:", "Default"));
        Assert.EndsWith("\u001b[?25h", writer.ToString());
        Assert.DoesNotContain("Project location", PromptRenderingTests.Screen(writer.ToString(), 120));
    }

    [Fact]
    public void NonAnsiInputsShowReadableCaretAndRetainEditingBehavior()
    {
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.No,
            Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = 80;
        console.Profile.Height = 90;
        var keys = new Queue<ConsoleKeyInfo>([Character('A'), Key(ConsoleKey.LeftArrow), Character('B'), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()));
        Assert.Equal("BA", input.ReadLine("Project name:", null));
        Assert.Contains("|A", writer.ToString());
        Assert.True(!writer.ToString().Contains("\u001b"), System.Text.Json.JsonSerializer.Serialize(writer.ToString()));
    }

    [Fact]
    public void LocationGuidanceIsConciseAndTemporary()
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var input = new InteractiveConsoleInput(ConsoleFor(writer, 120), _ => Task.FromResult<ConsoleKeyInfo?>(Key(ConsoleKey.Enter)));
        var root = Path.Combine(Path.GetTempPath(), "sf-guidance-" + Guid.NewGuid().ToString("N"));
        try
        {
            Assert.Equal(root, InteractivePrompt.AskOutputPath(root, input));
            Assert.Contains("Project will be created in <location>/<name>.", writer.ToString());
            Assert.DoesNotContain("contains the new project folder", writer.ToString());
            Assert.DoesNotContain("Project will be created", PromptRenderingTests.Screen(writer.ToString(), 120));
        }
        finally { if (Directory.Exists(root)) Directory.Delete(root, true); }
    }

    [Fact]
    public void ShiftSelectionAndCtrlAReplaceSelectedText()
    {
        var editor = new TextInputBuffer();
        editor.Edit(Key(ConsoleKey.End), "Default");
        editor.Edit(new ConsoleKeyInfo('\0', ConsoleKey.LeftArrow, true, false, false), null);
        editor.Edit(Character('X'), null);
        Assert.Equal("DefaulX", editor.Value);
        editor.Edit(new ConsoleKeyInfo('\u0001', ConsoleKey.A, false, false, true), null);
        editor.Edit(Character('Y'), null);
        Assert.Equal("Y", editor.Value);
    }

    [Fact]
    public void InformationAndHelpFocusOnSupportedCommandsWithDiagnosticsOptIn()
    {
        using (var capture = new ConsoleCapture())
        {
            Assert.Equal(0, InfoCommand.Execute(new ConsolePresenter(true), new GlobalOptions()));
            Assert.Contains("Supported platforms:", capture.Out);
            Assert.Contains("Available commands:", capture.Out);
            Assert.DoesNotContain("Implemented platforms", capture.Out);
            Assert.DoesNotContain("catalog version", capture.Out);
            Assert.DoesNotContain("schema version", capture.Out);
            Assert.Empty(capture.Error);
        }
        using (var capture = new ConsoleCapture())
        {
            InfoCommand.Execute(new ConsolePresenter(true, verbose: true), new GlobalOptions { Verbose = true });
            Assert.Contains("catalog version", capture.Error);
            Assert.Contains("schema version", capture.Error);
        }
        using (var capture = new ConsoleCapture())
        {
            HelpCommand.Execute(new ConsolePresenter(true), null);
            Assert.Contains("Supported platforms: MAUI, WPF, WinForms, WinUI, Blazor", capture.Out);
            Assert.Contains("Options:", capture.Out);
            Assert.DoesNotContain("Implemented platforms", capture.Out);
        }
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);
    private static ConsoleKeyInfo Character(char character) => new(character, ConsoleKey.X, false, false, false);
    private static IAnsiConsole ConsoleFor(StringWriter writer, int width)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes,
            ColorSystem = ColorSystemSupport.TrueColor, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = width;
        console.Profile.Height = 90;
        return console;
    }
}
