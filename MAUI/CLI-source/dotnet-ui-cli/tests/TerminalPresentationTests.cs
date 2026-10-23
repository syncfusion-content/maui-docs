using System.Text;
using Spectre.Console;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class TerminalPresentationTests
{
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
