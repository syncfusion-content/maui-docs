using System.Text;
using Spectre.Console;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;
using System.Text.RegularExpressions;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
public sealed class TerminalPresentationTests
{
    [Theory]
    [InlineData(true, true, false, 120, 90)]
    [InlineData(true, false, false, 120, 90)]
    [InlineData(false, true, false, 120, 90)]
    [InlineData(false, false, false, 120, 90)]
    [InlineData(true, true, true, 120, 90)]
    [InlineData(true, false, true, 120, 90)]
    [InlineData(true, true, false, 32, 90)]
    [InlineData(true, false, false, 32, 90)]
    [InlineData(true, true, false, 120, 24)]
    [InlineData(true, false, false, 120, 26)]
    [InlineData(false, false, false, 120, 24)]
    [InlineData(true, true, true, 120, 24)]
    [InlineData(true, true, false, 32, 24)]
    public void MenuHeadingsUseBoldCapsAndCapabilityAwareIcons(bool ansi, bool unicode, bool noColor, int width, int height)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = Create(writer, ansi, true, unicode);
        console.Profile.Width = width;
        console.Profile.Height = height;
        string? frame = null;
        var input = new InteractiveConsoleInput(console, _ =>
        {
            frame = writer.ToString();
            return Task.FromResult<ConsoleKeyInfo?>(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false));
        }, noColor);
        var choices = MenuItems.Categories.SelectMany(category =>
            new[] { MenuItems.CreateCategoryChoice(category) }.Concat(category.Operations))
            .Append(MenuItems.Operations[^1]).ToArray();

        Assert.Equal(MenuAction.CreateProject, input.SelectMenu(choices, default).Action);
        Assert.NotNull(frame);
        var plain = Regex.Replace(frame, "\u001b\\[[0-?]*[ -/]*[@-~]", "");
        var compact = Regex.Replace(plain, "\\s+", "");
        foreach (var operation in MenuItems.Operations)
        {
            Assert.Contains(Regex.Replace(operation.Label, "\\s+", ""), compact);
            Assert.Contains(Regex.Replace(operation.Command!, "\\s+", ""), compact);
        }
        var lines = plain.Split('\n').Select(line => line.TrimEnd()).ToArray();
        Assert.Contains(lines, line => line.StartsWith("  >   Create a new project", StringComparison.Ordinal));
        Assert.Contains("      Show help", lines.Select(line => line.Split("sfdotnet help")[0].TrimEnd()));
        if (width == 32) Assert.Contains("        sfdotnet new", lines);
        for (var index = 1; index < MenuItems.Categories.Count; index++)
        {
            var label = MenuItems.Categories[index].Name.ToUpperInvariant();
            var headingLine = Array.FindIndex(lines, line => line.Contains(label, StringComparison.Ordinal));
            Assert.True(headingLine >= 2);
            Assert.Empty(lines[headingLine - 1]);
            Assert.NotEmpty(lines[headingLine - 2]);
        }
        var icons = new[] { "📦", "🛠️", "🔎", "🤖", "🔑", "ℹ️" };
        for (var index = 0; index < MenuItems.Categories.Count; index++)
        {
            var label = MenuItems.Categories[index].Name.ToUpperInvariant();
            var separator = OperatingSystem.IsMacOS() && index is 1 or 5 ? "  " : " ";
            Assert.Contains(unicode ? $"{icons[index]}{separator}{label}" : label, frame);
            if (ansi && !noColor)
            {
                var heading = Assert.Single(Regex.Matches(frame, "\u001b\\[([0-9;]*)m([^\u001b]*)")
                    .Cast<Match>().Where(match => match.Groups[2].Value.Contains(label, StringComparison.Ordinal)));
                Assert.Contains("1", heading.Groups[1].Value.Split(';'));
                Assert.DoesNotContain("7", heading.Groups[1].Value.Split(';'));
            }
        }
        if (!ansi || noColor) Assert.DoesNotContain('\u001b', frame);
        if (!unicode) Assert.All(frame, character => Assert.True(character <= 127));
    }

    [Theory]
    [InlineData("📦", "Project creation", false, 1)]
    [InlineData("🛠️", "Package management", false, 1)]
    [InlineData("🔎", "Discovery", false, 1)]
    [InlineData("🤖", "AI & Skills", false, 1)]
    [InlineData("🔑", "License management", false, 1)]
    [InlineData("ℹ️", "Help and information", false, 1)]
    [InlineData("📦", "Project creation", true, 1)]
    [InlineData("🛠️", "Package management", true, 2)]
    [InlineData("🔎", "Discovery", true, 1)]
    [InlineData("🤖", "AI & Skills", true, 1)]
    [InlineData("🔑", "License management", true, 1)]
    [InlineData("ℹ️", "Help and information", true, 2)]
    public void MainMenu_IconSpacingCompensatesOnlyMacOsNarrowGlyphs(string icon, string label, bool isMacOS, int spaces)
    {
        var choice = new MenuChoice(label, null, null) { Icon = icon };
        Assert.Equal(icon + new string(' ', spaces) + label.ToUpperInvariant(),
            InteractiveMenu.FormatHeading(choice, isMacOS));
    }

    [Theory]
    [InlineData(true, "Apple_Terminal", true)]
    [InlineData(false, "Apple_Terminal", false)]
    [InlineData(true, "iTerm.app", true)]
    [InlineData(false, "iTerm.app", false)]
    [InlineData(true, "vscode", true)]
    [InlineData(false, "vscode", false)]
    [InlineData(true, "unknown", true)]
    [InlineData(false, "unknown", false)]
    [InlineData(true, null, true)]
    [InlineData(false, null, false)]
    public void MainMenu_MacOsIconSpacingIsIndependentOfTerminalProgram(bool isMacOS, string? terminalProgram, bool extraSpacing)
    {
        var previous = Environment.GetEnvironmentVariable("TERM_PROGRAM");
        try
        {
            Environment.SetEnvironmentVariable("TERM_PROGRAM", terminalProgram);
            foreach (var unicode in new[] { true, false })
            {
                var console = Create(new StringWriter(), true, true, unicode);
                foreach (var category in MenuItems.Categories)
                {
                    var choice = MenuItems.CreateCategoryChoice(category);
                    var label = choice.Label.ToUpperInvariant();
                    var separator = extraSpacing && choice.Icon is "🛠️" or "ℹ️" ? "  " : " ";
                    Assert.Equal(unicode ? $"{choice.Icon}{separator}{label}" : label,
                        InteractiveMenu.FormatChoice(choice, false, console, isMacOS));
                }
            }
        }
        finally
        {
            Environment.SetEnvironmentVariable("TERM_PROGRAM", previous);
        }
    }

    [Theory]
    [InlineData(true, true, true)]
    [InlineData(true, false, false)]
    [InlineData(false, true, false)]
    [InlineData(false, false, false)]
    public void AnimationRequiresCursorSupportAndInteractiveOutput(bool ansi, bool interactive, bool expected)
    {
        var console = Create(new StringWriter(), ansi, interactive, true);
        Assert.Equal(expected, TerminalPresentation.CanAnimate(console));
    }

    [Theory]
    [InlineData(true, "↑/↓: navigate | ✓ Done | ✗ Failed | … Working")]
    [InlineData(false, "Up/Down: navigate | [OK] Done | [FAIL] Failed | ... Working")]
    public void SymbolsFollowCapabilitiesRatherThanPlatform(bool unicode, string expected)
    {
        Assert.Equal(expected, TerminalPresentation.Symbols("↑/↓: navigate | ✓ Done | ✗ Failed | … Working",
            Create(new StringWriter(), true, true, unicode)));
    }

    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public async Task ProgressRetainsActualSuccessAndFailureWithAndWithoutUnicodeOrAnsi(bool ansi, bool unicode)
    {
        using var writer = new StringWriter();
        var console = Create(writer, ansi, true, unicode);
        writer.GetStringBuilder().Clear();
        using var capture = new ConsoleCapture();
        var progress = new OperationProgress(false, console: console, showPending: false);
        await progress.RunAsync(_ =>
        {
            progress.Started("Creating project");
            progress.Completed("Creating project");
            progress.Started("Building project");
            progress.Failed("Building project", "compiler error");
            return Task.FromResult(0);
        });
        var output = writer + capture.Out;
        Assert.Contains(unicode ? "✓ Creating project" : "[OK] Creating project", output);
        Assert.Contains(unicode ? "✗ Building project" : "[FAIL] Building project", output);
        Assert.DoesNotContain(unicode ? "✓ Building project" : "[OK] Building project", output);
        Assert.Contains("compiler error", output);
        if (!ansi) Assert.True(!output.Contains("\u001b"), System.Text.Json.JsonSerializer.Serialize(output));
    }

    [Fact]
    public async Task PlainProgressReportsCancellationWithoutSuccessOrEscapeCodes()
    {
        using var writer = new StringWriter();
        var console = Create(writer, true, true, false);
        using var capture = new ConsoleCapture();
        var progress = new OperationProgress(true, console: console, showPending: false);
        await Assert.ThrowsAsync<OperationCanceledException>(() => progress.RunAsync<int>(_ =>
        {
            progress.Started("Creating project");
            throw new OperationCanceledException();
        }));
        Assert.Contains("Creating project - cancelled", capture.Out);
        Assert.DoesNotContain("[OK]", capture.Out);
        Assert.DoesNotContain("[FAIL]", capture.Out);
        Assert.True(!capture.Out.Contains("\u001b"), System.Text.Json.JsonSerializer.Serialize(capture.Out));
    }

    [Fact]
    public void StartupUsesBomFreeUtf8BeforeCapabilityProbe()
    {
        var output = Console.OutputEncoding;
        var input = Console.InputEncoding;
        try
        {
            TerminalPresentation.InitializeEncoding();
            Assert.Equal(Encoding.UTF8.CodePage, Console.OutputEncoding.CodePage);
            Assert.Empty(Console.OutputEncoding.GetPreamble());
            if (!Console.IsInputRedirected) Assert.Equal(Encoding.UTF8.CodePage, Console.InputEncoding.CodePage);
        }
        finally { Console.OutputEncoding = output; Console.InputEncoding = input; }
    }

    private static IAnsiConsole Create(StringWriter writer, bool ansi, bool interactive, bool unicode)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = ansi ? AnsiSupport.Yes : AnsiSupport.No,
            Interactive = interactive ? InteractionSupport.Yes : InteractionSupport.No,
            Out = new AnsiConsoleOutput(writer),
        });
        console.Profile.Capabilities.Unicode = unicode;
        console.Profile.Width = 80;
        return console;
    }
}
