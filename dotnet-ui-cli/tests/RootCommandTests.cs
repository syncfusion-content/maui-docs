using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.Cli.Hosting;
using Xunit;

namespace Syncfusion.DotNet.Cli.Tests;

[Collection("Console output")]
/// <summary>
/// Tests for the Phase 1 root command surface: bare invocation, help,
/// version, unknown commands, cancellation, and exit-code values.
/// </summary>
public static class RootCommandTests
{
    [Fact]
    public static async Task BareInvocation_WithoutInteractiveTerminal_ReturnsSuccessAndFallbackMessage()
    {
        using var capture = new ConsoleCapture();
        var app = CliApp.Build();
        var exit = await app.RunAsync([]);
        Assert.Equal(0, exit);
        Assert.Contains("sfdotnet help", capture.Out);
    }

    [Fact]
    public static async Task HelpOption_ReturnsSuccessAndShowsHelp()
    {
        using var capture = new ConsoleCapture();
        var app = CliApp.Build();
        var exit = await app.RunAsync(["--help"]);
        Assert.Equal(0, exit);
        Assert.Contains("Usage:", capture.Out);
        Assert.Contains("Commands:", capture.Out);
        Assert.Contains("Skills", capture.Out, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("MCP", capture.Out, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public static async Task ShortHelpOption_ReturnsSuccessAndShowsHelp()
    {
        using var capture = new ConsoleCapture();
        var app = CliApp.Build();
        var exit = await app.RunAsync(["-h"]);
        Assert.Equal(0, exit);
        Assert.Contains("Usage:", capture.Out);
    }

    [Fact]
    public static async Task NewCommandHelp_DoesNotShowSkillsOrMcpFeatures()
    {
        using var capture = new ConsoleCapture();
        var exit = await CliApp.Build().RunAsync(["new", "--help"]);

        Assert.Equal(0, exit);
        Assert.DoesNotContain("template", capture.Out, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("Skills", capture.Out, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("MCP", capture.Out, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public static async Task ActiveHelpUsesControlTerminologyAndKeepsPackageWorkflowsDistinct()
    {
        using var capture = new ConsoleCapture();
        var exit = await CliApp.Build().RunAsync(["help", "maui"]);

        Assert.Equal(0, exit);
        Assert.Contains("--control", capture.Out);
        Assert.Contains("sfdotnet add maui datagrid", capture.Out);
        Assert.Contains("NuGet package", capture.Out);
        Assert.DoesNotContain("template", capture.Out, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public static async Task VersionOption_ReturnsSuccessAndShowsVersion()
    {
        using var capture = new ConsoleCapture();
        var app = CliApp.Build();
        var exit = await app.RunAsync(["--version"]);
        Assert.Equal(0, exit);
        var version = Assert.IsType<AssemblyInformationalVersionAttribute>(
            typeof(CliApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>())
            .InformationalVersion.Split('+')[0];
        Assert.Equal($"Syncfusion .NET CLI {version}", capture.Out.Trim());
    }

    [Fact]
    public static async Task UnknownCommand_ReturnsErrorExitCode()
    {
        using var capture = new ConsoleCapture();
        var app = CliApp.Build();
        var exit = await app.RunAsync(["does-not-exist"]);
        Assert.Equal(1, exit);
    }

    [Fact]
    public static async Task InfoCommand_ReturnsSuccessAndShowsVersion()
    {
        using var capture = new ConsoleCapture();
        var app = CliApp.Build();
        var exit = await app.RunAsync(["info"]);
        Assert.Equal(0, exit);
        Assert.Contains("Syncfusion .NET CLI", capture.Out);
    }

    [Fact]
    public static async Task NoInteractiveFlag_BareInvocation_FallsBackToHelpHint()
    {
        using var capture = new ConsoleCapture();
        var app = CliApp.Build();
        var exit = await app.RunAsync(["--no-interactive"]);
        Assert.Equal(0, exit);
        Assert.Contains("sfdotnet help", capture.Out);
    }

    [Fact]
    public static async Task CancellationRequested_BareInvocation_ReturnsCancelledExitCode()
    {
        using var capture = new ConsoleCapture();
        using var cts = new CancellationTokenSource();
        cts.Cancel();
        var app = CliApp.Build();

        // The bare root handler observes the cancelled token; CliApp maps that
        // to the conventional 130 exit code regardless of the parser's own code.
        var exit = await app.RunAsync([], cts.Token);
        Assert.Equal(Core.ExitCodes.Cancelled, exit);
        Assert.Equal($"The operation was canceled.{System.Environment.NewLine}", capture.Out);
        Assert.Empty(capture.Error);
    }

    [Fact]
    public static async Task ExitCodes_AreStableContractValues()
    {
        // Document the well-known exit codes as a contract test, so accidental
        // changes to the values are caught.
        Assert.Equal(0, Core.ExitCodes.Success);
        Assert.Equal(1, Core.ExitCodes.Error);
        Assert.Equal(130, Core.ExitCodes.Cancelled);
        Assert.Equal(70, Core.ExitCodes.Unhandled);
    }
}
