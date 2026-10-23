using Spectre.Console;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class PresentationPolishTests
{
    [Theory]
    [InlineData(false, false, false, false, false, true)]
    [InlineData(true, false, false, false, false, false)]
    [InlineData(false, true, false, false, false, false)]
    [InlineData(false, false, true, false, false, false)]
    [InlineData(false, false, false, true, false, false)]
    [InlineData(false, false, false, false, true, false)]
    public void ColorPolicy_PlainModesWin(bool noColor, bool json, bool silent, bool redirected, bool environmentSet, bool expected)
        => Assert.Equal(expected, ColorPolicy.AllowsColor(noColor, json, silent, redirected, environmentSet));

    [Theory]
    [InlineData(true, null, "single")]
    [InlineData(false, "1", "single")]
    [InlineData(true, null, "multiple")]
    [InlineData(false, "1", "multiple")]
    [InlineData(true, null, "text")]
    [InlineData(false, "1", "text")]
    [InlineData(true, null, "controls")]
    [InlineData(false, "1", "controls")]
    public void PlainPromptsPreserveInputAndNavigationWithoutAnsi(bool noColor, string? environment, string kind)
    {
        using var color = new NoColorScope(environment);
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.Yes, ColorSystem = ColorSystemSupport.Standard,
            Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer)
        });
        var keys = new Queue<ConsoleKeyInfo>(kind == "single"
            ? [Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter)]
            : kind == "text" ? [Key(ConsoleKey.Enter)]
            : [Key(ConsoleKey.Spacebar), Key(ConsoleKey.DownArrow), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), noColor);
        if (kind == "single")
        {
            var prompt = new WizardSelectionPrompt<string>(); prompt.AddChoices("DataGrid", "ListView");
            Assert.Equal("ListView", input.PromptSingle(prompt, default));
        }
        else if (kind == "multiple")
        {
            var prompt = new MultiSelectionPrompt<string>(); prompt.AddChoices("DataGrid", "ListView");
            Assert.Equal(["DataGrid", "ListView"], input.PromptMultiple(prompt, default));
        }
        else if (kind == "controls") Assert.Equal(["datagrid", "listview"], input.SelectControls([("DataGrid", "datagrid"), ("ListView", "listview")], default));
        else Assert.Equal("Demo", input.ReadLine("Name:", "Demo"));
        Assert.Contains("Enter: continue", writer.ToString());
        Assert.DoesNotContain("\u001b", writer.ToString(), StringComparison.Ordinal);
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public async Task OperationProgressPlainOrSuppressed(bool json, bool silent)
    {
        using var capture = new ConsoleCapture();
        var progress = new OperationProgress(true, json, silent);
        Assert.Equal(7, await progress.RunAsync(stages =>
        {
            stages.Report("Adding packages"); stages.Report("Restoring"); stages.Report("Restoring");
            return Task.FromResult(7);
        }));
        Assert.Equal(json || silent ? "" : "  Adding packages\n  Restoring\n", capture.Out.Replace("\r\n", "\n"));
        Assert.DoesNotContain("%", capture.Out);
        Assert.DoesNotContain("\u001b", capture.Out, StringComparison.Ordinal);
    }

    [Fact]
    public void CompletionSummaryRetainsRemovalFactsAndWarnsAboutPreservedPackages()
    {
        using var capture = new ConsoleCapture();
        CompletionSummary.Write(new ConsolePresenter(true), "Control remove completed.",
            [("Project:", "/tmp/App.csproj"), ("Controls:", "DataGrid")],
            "Removed samples: DataGrid. Deleted 3 generated file(s). Removed packages: none. Build: not requested. Rebuild the project to apply these changes.",
            ["Retained package 'Syncfusion.Maui.Core': required by another sample."]);
        Assert.Contains("✓ Control remove completed.", capture.Out);
        Assert.Contains("Removed samples:", capture.Out);
        Assert.Contains("3 generated file(s)", capture.Out);
        Assert.Contains("Removed packages:", capture.Out);
        Assert.Contains("Rebuild the project to apply these changes.", capture.Out);
        Assert.Contains("Warning: Retained package", capture.Error);
        Assert.DoesNotContain("Warning:", capture.Out);
    }

    [Fact]
    public void PackageConsoleSummaryDoesNotChangeJsonMessageOrFields()
    {
        const string message = "Package add succeeded: 'inputs' (Syncfusion.Maui.Inputs). No sample template is available for this package; no sample was generated.";
        var result = new Syncfusion.DotNet.CLI.Maui.PackageOperationResult("/tmp/App.csproj", "inputs", "Syncfusion.Maui.Inputs", "add", 0, message, "", "", "32.1.29");
        using (var capture = new ConsoleCapture())
        {
            Syncfusion.DotNet.CLI.Commands.Operations.CommandOperations.ReportPackageResult(new ConsolePresenter(true), new Syncfusion.DotNet.CLI.Core.GlobalOptions(), result);
            Assert.Contains("✓ Package add completed.", capture.Out);
            Assert.Contains("no sample was generated.", System.Text.RegularExpressions.Regex.Replace(capture.Out, @"\s+", " "));
            Assert.Contains("32.1.29", capture.Out);
        }
        using (var capture = new ConsoleCapture())
        {
            Syncfusion.DotNet.CLI.Commands.Operations.CommandOperations.ReportPackageResult(new ConsolePresenter(true), new Syncfusion.DotNet.CLI.Core.GlobalOptions { Json = true }, result);
            var expected = Syncfusion.DotNet.CLI.Maui.Discovery.DiscoveryService.ToJson(new Dictionary<string, object?>
            {
                ["projectPath"] = result.ProjectPath, ["packageAlias"] = result.Alias, ["packageId"] = result.PackageId,
                ["operation"] = result.Operation, ["success"] = true, ["exitCode"] = 0, ["message"] = message,
                ["error"] = "", ["packageChangesSucceeded"] = null, ["sampleGenerationSucceeded"] = null,
                ["buildSucceeded"] = null, ["resolvedVersion"] = "32.1.29"
            });
            Assert.Equal(expected + Environment.NewLine, capture.Out);
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void FriendlyFailureKeepsRawDiagnosticsVerboseAndRedactsNuGetValues(bool verbose)
    {
        using var capture = new ConsoleCapture();
        var presenter = new ConsolePresenter(true, verbose);
        presenter.ProtectNuGetConfiguration("https://private.example/feed?token=secret", "/private/nuget.config");
        const string raw = "RAW CHILD OUTPUT: error NU1301: https://private.example/feed?token=secret\n  at Private.Stack() --configfile /private/nuget.config";
        ConsoleDiagnostics.Failure(presenter, "Package remove failed.", "Removal failed; tracked changes were rolled back.", [raw], true);
        presenter.WriteVerbose("dotnet add package X --source \"https://unrecorded.example/feed value\" --configfile=/unrecorded/config");
        Assert.Contains("NuGet could not reach a configured feed (NU1301)", capture.Error);
        Assert.Contains("rollback attempted", capture.Out);
        Assert.Equal(verbose, capture.Error.Contains("RAW CHILD OUTPUT", StringComparison.Ordinal));
        Assert.Equal(verbose, capture.Error.Contains("at Private.Stack()", StringComparison.Ordinal));
        Assert.DoesNotContain("private.example", capture.Error);
        Assert.DoesNotContain("/private/nuget.config", capture.Error);
        Assert.DoesNotContain("unrecorded.example", capture.Error);
        Assert.DoesNotContain("/unrecorded/config", capture.Error);
        Assert.DoesNotContain("\u001b", capture.Out + capture.Error, StringComparison.Ordinal);
    }

    [Theory]
    [InlineData("1.x", true, "not a valid NuGet version")]
    [InlineData("32.1.29", false, "Check the .NET SDK installation")]
    public void VersionFailureGivesAOneLineCauseStateAndFix(string version, bool invalid, string expected)
    {
        var message = ConsoleDiagnostics.VersionFailure(version, invalid);
        Assert.Contains(expected, message);
        Assert.Contains("No changes made.", message);
        Assert.Contains(invalid ? "32.1.29 with --version" : "retry with --verbose", message);
        Assert.DoesNotContain("\n", message);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void UnexpectedErrorsKeepUnknownStateAndHideRawDetailsAndArgumentValues(bool verbose)
    {
        using var capture = new ConsoleCapture();
        ConsoleDiagnostics.Unexpected(new ConsolePresenter(true, verbose),
            new IOException("RAW EXCEPTION with private-source-token and /private/config"),
            ["add", "--source", "private-source-token", "--configfile=/private/config"]);
        Assert.Contains("Review the project state before retrying", capture.Error);
        Assert.Equal(verbose, capture.Error.Contains("RAW EXCEPTION", StringComparison.Ordinal));
        Assert.DoesNotContain("private-source-token", capture.Error);
        Assert.DoesNotContain("/private/config", capture.Error);
        Assert.DoesNotContain("No changes made", capture.Error);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void PlainTerminalInitializationRestoresChildEnvironmentEvenAfterFailure(bool failure)
    {
        using var color = new NoColorScope("1");
        var term = Environment.GetEnvironmentVariable("TERM");
        try
        {
            Environment.SetEnvironmentVariable("TERM", "xterm-256color");
            void Initialize()
            {
                Assert.Equal(OperatingSystem.IsWindows() ? "xterm-256color" : "dumb", Environment.GetEnvironmentVariable("TERM"));
                if (failure) throw new IOException("init failed");
            }
            if (failure) Assert.Throws<IOException>(() => ColorPolicy.InitializeConsole(false, false, Initialize));
            else
            {
                using (ColorPolicy.InitializeConsole(false, false, Initialize))
                    Assert.Equal(OperatingSystem.IsWindows() ? "xterm-256color" : "dumb", Environment.GetEnvironmentVariable("TERM"));
            }
            Assert.Equal("xterm-256color", Environment.GetEnvironmentVariable("TERM"));
        }
        finally { Environment.SetEnvironmentVariable("TERM", term); }
    }

    [Fact]
    public void PlannedCommandIsNotEvidenceOfMutationOrRollback()
    {
        using var capture = new ConsoleCapture();
        var result = new Syncfusion.DotNet.CLI.Maui.PackageOperationResult("/tmp/App.csproj", "datagrid", "Syncfusion.Maui.DataGrid", "add", 1,
            "Cannot apply the selected controls: the generated file was modified. No changes made.", "dotnet add package X", "");
        Syncfusion.DotNet.CLI.Commands.Operations.CommandOperations.ReportPackageResult(new ConsolePresenter(true), new Syncfusion.DotNet.CLI.Core.GlobalOptions(), result);
        Assert.Contains("generated file was modified", capture.Error);
        Assert.Contains("Changes: no changes made.", capture.Out);
        Assert.DoesNotContain("rollback", capture.Out, StringComparison.OrdinalIgnoreCase);
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);

    [Fact]
    public void DiagnosticsHaveOnePrefixAndUseStderr()
    {
        using var capture = new ConsoleCapture();
        var presenter = new ConsolePresenter(true);
        presenter.WriteWarning("A package was retained.");
        presenter.WriteWarning("Warning: Already labelled.");
        presenter.WriteError("The build failed.");
        presenter.WriteError("Error: Already labelled.");
        Assert.Empty(capture.Out);
        Assert.Equal("Warning: A package was retained.\nWarning: Already labelled.\nError: The build failed.\nError: Already labelled.\n", capture.Error.Replace("\r\n", "\n"));
        Assert.DoesNotContain("\u001b", capture.Error, StringComparison.Ordinal);
    }

    [Fact]
    public void NoColorEnvironmentSuppressesAllPresenterColor()
    {
        var previous = Environment.GetEnvironmentVariable("NO_COLOR");
        try
        {
            Environment.SetEnvironmentVariable("NO_COLOR", "1");
            using var capture = new ConsoleCapture();
            var presenter = new ConsolePresenter(false);
            Assert.True(presenter.NoColor);
            presenter.WriteSuccess("Project created.");
            presenter.WriteWarning("Rebuild required.");
            presenter.WriteError("Build failed.");
            Assert.Contains("✓ Project created.", capture.Out);
            Assert.DoesNotContain("\u001b", capture.Out + capture.Error, StringComparison.Ordinal);
        }
        finally { Environment.SetEnvironmentVariable("NO_COLOR", previous); }
    }
}

internal sealed class NoColorScope : IDisposable
{
    private readonly string? _previous = Environment.GetEnvironmentVariable("NO_COLOR");
    public NoColorScope(string? value) => Environment.SetEnvironmentVariable("NO_COLOR", value);
    public void Dispose() => Environment.SetEnvironmentVariable("NO_COLOR", _previous);
}
