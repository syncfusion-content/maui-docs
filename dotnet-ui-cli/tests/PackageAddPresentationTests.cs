using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class PackageAddPresentationTests
{
    private static ProjectDetector.ProjectInfo Project => new()
    { CsprojPath = Path.Combine(Path.GetTempPath(), "App.csproj"), UseMaui = true };

    [Theory]
    [InlineData(false, false)]
    [InlineData(false, true)]
    [InlineData(true, false)]
    [InlineData(true, true)]
    public async Task GroupedAndVerboseProgressPreserveExecutionAndNeverPrintPending(bool verbose, bool build)
    {
        using var capture = new ConsoleCapture();
        var executed = new List<string>();
        var result = await CommandOperations.RunPackageAddWithProgressAsync(new OperationProgress(true, showPending: false),
            new MauiPackageAddPresentationProvider(Project), verbose, progress =>
            {
                using var stages = new OperationStages(progress);
                var labels = new List<string> { "Adding packages", "Restoring", "Generating files", "Registering in MauiProgram.cs", "Updating navigation", "Writing control manifest" };
                if (build) labels.Add("Building");
                stages.Plan(labels.ToArray());
                foreach (var label in labels) { executed.Add(label); stages.Start(label); stages.Complete(); }
                return Task.FromResult(Result(0));
            });
        Assert.Equal(0, result.ExitCode);
        Assert.True(executed.IndexOf("Writing control manifest") < (build ? executed.IndexOf("Building") : executed.Count));
        Assert.DoesNotContain("pending", capture.Out);
        if (verbose)
        {
            foreach (var label in executed) Assert.Contains("✓ " + label, capture.Out);
        }
        else
        {
            var expected = new List<string> { "✓ Adding package", "✓ Restoring packages", "✓ Updating project files" };
            if (build) expected.Add("✓ Building project");
            Assert.Equal(expected, capture.Out.Split('\n').Select(line => line.Trim()).Where(line => line.StartsWith("✓ ")));
            Assert.DoesNotContain("MauiProgram.cs", capture.Out);
            Assert.DoesNotContain("Writing control manifest", capture.Out);
        }
    }

    [Theory]
    [InlineData("Adding packages", "Adding package")]
    [InlineData("Restoring", "Restoring packages")]
    [InlineData("Generating files", "Updating project files")]
    [InlineData("Registering in MauiProgram.cs", "Updating project files")]
    [InlineData("Updating navigation", "Updating project files")]
    [InlineData("Writing control manifest", "Updating project files")]
    [InlineData("Building", "Building project")]
    public async Task FailedGroupNamesSpecificSubstep(string label, string group)
    {
        using var capture = new ConsoleCapture();
        await CommandOperations.RunPackageAddWithProgressAsync(new OperationProgress(true, showPending: false),
            new MauiPackageAddPresentationProvider(Project), false, progress =>
            {
                using var stages = new OperationStages(progress);
                stages.Start(label);
                return Task.FromResult(Result(1));
            });
        Assert.Contains($"✗ {group}: failed while {char.ToLowerInvariant(label[0])}{label[1..]}", capture.Out);
        Assert.DoesNotContain("✓ " + group, capture.Out);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void OrderedReviewUsesSharedColumnAndTextPostAddValues(bool build)
    {
        Assert.True(PackageCatalog.TryResolve("datagrid", out var package));
        var request = new AddPackageRequest(Framework.Maui, package.Alias, Project.CsprojPath, null, true, false, false, Build: build);
        var rows = CommandOperations.PackageAddReviewValues(request, Project, package);
        Assert.Equal(new[] { "Action:", "Platform:", "Project file:", "Package:", "Post-add:" }, rows.Select(row => row.Label));
        Assert.Equal(".NET MAUI", rows[1].Value);
        Assert.Equal(Project.CsprojPath, rows[2].Value);
        Assert.DoesNotContain(rows, row => row.Label == "Version:");
        Assert.Equal(build ? "Restore and build" : "Restore only", rows[4].Value);
        var formatted = SummaryRows.Format(rows, 160, ProjectFlowLayout.ValueColumn);
        foreach (var row in formatted)
            Assert.Equal(ProjectFlowLayout.ValueColumn, row.IndexOf(row[(row.IndexOf(':') + 1)..].TrimStart(), StringComparison.Ordinal));
        Assert.Single(rows, row => row.Label == "Package:");
        Assert.DoesNotContain(formatted, row => row.Contains("True") || row.Contains("False"));
        using var capture = new ConsoleCapture();
        CommandOperations.ReportPackageResult(new ConsolePresenter(true), new GlobalOptions(), Result(0), includeIdentity: false);
        Assert.DoesNotContain("Package:", capture.Out);
    }

    [Fact]
    public void ConfirmationUsesQuestionAndDoesNotRetainBooleanAnswerRow()
    {
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = 120;
        console.Profile.Height = 40;
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false)), true);
        Assert.True(InteractivePrompt.Confirm("Apply these changes?", true, input, retainAnswer: false));
        Assert.Contains("Apply these changes? [Y/n]:", writer.ToString());
        Assert.DoesNotContain("Apply these changes: y", writer.ToString());
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task LiveProgressNeverDisplaysPendingStages(bool verbose)
    {
        using var color = new NoColorScope(null);
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = 120;
        console.Profile.Height = 40;
        await CommandOperations.RunPackageAddWithProgressAsync(new OperationProgress(false, console: console, showPending: false),
            new MauiPackageAddPresentationProvider(Project), verbose, async progress =>
            {
                using var stages = new OperationStages(progress);
                stages.Plan("Adding package", "Restoring", "Generating files", "Building");
                stages.Start("Adding package");
                await Task.Delay(150);
                var active = PromptRenderingTests.Screen(writer.ToString(), 120);
                Assert.Contains("Adding package", active);
                Assert.DoesNotContain("pending", active);
                stages.Complete();
                return Result(0);
            });
        Assert.DoesNotContain("pending", PromptRenderingTests.Screen(writer.ToString(), 120));
    }

    [Fact]
    public async Task NestedRestoreFailureRetainsTheSpecificFailureInsteadOfFailingAddingAgain()
    {
        using var capture = new ConsoleCapture();
        await CommandOperations.RunPackageAddWithProgressAsync(new OperationProgress(true, showPending: false),
            new MauiPackageAddPresentationProvider(Project), false, progress =>
            {
                using var adding = new OperationStages(progress);
                adding.Start("Adding package");
                using var restoring = new OperationStages(progress);
                restoring.Start("Restoring");
                return Task.FromResult(Result(1));
            });
        Assert.Contains("✗ Restoring packages: failed while restoring", capture.Out);
        Assert.DoesNotContain("✗ Adding package", capture.Out);
    }

    [Fact]
    public void BatchResultNamesThePackageAndItsSampleOutcome()
    {
        using var capture = new ConsoleCapture();
        var result = new PackageOperationResult(Project.CsprojPath, "treeview", "Syncfusion.Maui.TreeView", "add", 0,
            "Package add succeeded: 'treeview' (Syncfusion.Maui.TreeView). No sample added: this package has no sample template.", "", "");
        CommandOperations.ReportPackageResult(new ConsolePresenter(true), new GlobalOptions(), result,
            includeIdentity: false, completionName: "TreeView");
        Assert.Contains("TreeView: package added.", capture.Out);
        Assert.Contains("No sample added: this package has no sample template.", System.Text.RegularExpressions.Regex.Replace(capture.Out, @"\s+", " "));
    }

    [Fact]
    public void ExplicitPackageVersionRemainsVisibleInReview()
    {
        Assert.True(PackageCatalog.TryResolve("datagrid", out var package));
        var request = new AddPackageRequest(Framework.Maui, package.Alias, Project.CsprojPath, "35.1.41", true, false, false);
        Assert.Contains(("Version:", "35.1.41"), CommandOperations.PackageAddReviewValues(request, Project, package));
    }

    [Fact]
    public void CompletionFactsStartWithCapitalLetters()
    {
        using var capture = new ConsoleCapture();
        CompletionSummary.Write(new ConsolePresenter(true), "Control add completed.", [],
            "Packages: restored required references. Samples: applied 2 control(s). Build: not requested.");
        var rows = capture.Out.Split('\n').Select(line => line.Trim()).ToArray();
        Assert.Contains(rows, row => row.StartsWith("Packages:") && row.EndsWith("Restored required references"));
        Assert.Contains(rows, row => row.StartsWith("Samples:") && row.EndsWith("Applied 2 control(s)"));
        Assert.Contains(rows, row => row.StartsWith("Build:") && row.EndsWith("Not requested."));
    }

    private static PackageOperationResult Result(int exitCode)
        => new(Project.CsprojPath, "datagrid", "Syncfusion.Maui.DataGrid", "add", exitCode,
            exitCode == 0 ? "Added" : "Failed", "", exitCode == 0 ? "" : "Specific diagnostic");
}
