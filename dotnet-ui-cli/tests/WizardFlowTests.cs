using System.CommandLine;
using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Hosting;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class WizardFlowTests
{
    private static ParseResult ParseRoot(string[] args)
    {
        var root = new RootCommand();
        var command = NewCommand.Create();
        foreach (var option in new GlobalOptionsBinder().All()) { command.Add(option); }
        root.Add(command);
        return root.Parse(args);
    }

    private static IAnsiConsole ConsoleFor(StringWriter writer)
    {
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.No,
            ColorSystem = ColorSystemSupport.NoColors,
            Interactive = InteractionSupport.Yes,
            Out = new AnsiConsoleOutput(writer),
        });
        console.Profile.Width = 120;
        console.Profile.Height = 40;
        return console;
    }

    private static InteractiveConsoleInput Input(StringWriter writer, params ConsoleKeyInfo[] keys)
    {
        var queue = new Queue<ConsoleKeyInfo>(keys);
        return new InteractiveConsoleInput(ConsoleFor(writer), _ => Task.FromResult<ConsoleKeyInfo?>(queue.Dequeue()), noColor: true);
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);

    [Fact]
    public void EnterAcceptsExplicitDefaultAndRecordsItsProvenance()
    {
        using var writer = new StringWriter();
        var selection = InteractivePrompt.AskProjectNameSelection(new ConsolePresenter(true), "App", Input(writer, Key(ConsoleKey.Enter)));
        Assert.Equal("App", selection.Name);
        Assert.True(selection.UsedDefault);
        Assert.Contains("Project name:      [App]", writer.ToString());
        Assert.Contains("Enter: continue | Esc: cancel | Ctrl+C: exit", writer.ToString());
        Assert.DoesNotContain("Enter accepts the default", writer.ToString());
        Assert.DoesNotContain("default:", writer.ToString());
        Assert.DoesNotContain('\u001b', writer.ToString());
    }

    [Fact]
    public void TypedDefaultNameRemainsExplicit()
    {
        using var writer = new StringWriter();
        var keys = new[] { new ConsoleKeyInfo('A', ConsoleKey.A, false, false, false), Key(ConsoleKey.Enter) };
        var selection = InteractivePrompt.AskProjectNameSelection(new ConsolePresenter(true), "A", Input(writer, keys));
        Assert.Equal("A", selection.Name);
        Assert.False(selection.UsedDefault);
    }

    [Fact]
    public void ControlPickerTogglesCheckboxesAndReturnsIdentifiersWithoutRenderingThem()
    {
        using var writer = new StringWriter();
        var input = Input(writer, Key(ConsoleKey.Enter), Key(ConsoleKey.Spacebar), Key(ConsoleKey.DownArrow),
            Key(ConsoleKey.Spacebar), Key(ConsoleKey.UpArrow), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter));
        var result = input.SelectControls([("DataGrid", "datagrid"), ("ListView", "listview")], CancellationToken.None);
        Assert.Equal(new[] { "datagrid", "listview" }, result);
        var text = writer.ToString();
        Assert.Contains("[x] DataGrid", text);
        Assert.Contains("Selected: 2", text);
        Assert.Contains("Controls: DataGrid, ListView", text);
        Assert.Contains("Space: toggle | Enter: continue", text);
        Assert.DoesNotContain("datagrid", text, StringComparison.Ordinal);
        Assert.DoesNotContain('\u001b', text);
    }

    [Fact]
    public void BlazorPickerStartsEmptyAndReturnsOnlyTheUsersSelection()
    {
        using var writer = new StringWriter();
        var input = Input(writer, Key(ConsoleKey.Enter), Key(ConsoleKey.DownArrow),
            Key(ConsoleKey.Spacebar), Key(ConsoleKey.Enter));
        var options = Syncfusion.DotNet.CLI.Blazor.BlazorCatalog.Packages
            .Where(package => package.HasTemplate)
            .Select(package => new ControlSelectionItem(package.Alias, package.DisplayName)).ToArray();
        var result = input.SelectControls(options, CancellationToken.None, initiallySelected: []);
        Assert.Equal(new[] { "block-editor" }, result);
        Assert.Contains("Selected: 0", writer.ToString());
        Assert.DoesNotContain("grid", result);
    }

    [Theory]
    [InlineData(ConsoleKey.Escape)]
    [InlineData(ConsoleKey.C)]
    public void ControlPickerCancelsWithoutReturningSelections(ConsoleKey key)
    {
        using var writer = new StringWriter();
        var cancel = new ConsoleKeyInfo('\0', key, false, false, key == ConsoleKey.C);
        var input = Input(writer, Key(ConsoleKey.Spacebar), cancel);
        if (key == ConsoleKey.Escape)
        { Assert.Throws<InteractivePromptCancelledException>(() => input.SelectControls([("DataGrid", "datagrid")], CancellationToken.None)); }
        else
        { Assert.Throws<OperationCanceledException>(() => input.SelectControls([("DataGrid", "datagrid")], CancellationToken.None)); }
        Assert.DoesNotContain("Controls (1):", writer.ToString());
    }

    [Theory]
    [InlineData(ConsoleKey.Enter, true)]
    [InlineData(ConsoleKey.N, false)]
    public void CompactConfirmationAcceptsDefaultOrDecline(ConsoleKey key, bool expected)
    {
        using var writer = new StringWriter();
        var keys = key == ConsoleKey.Enter ? new[] { Key(key) } : new[] { new ConsoleKeyInfo('n', key, false, false, false), Key(ConsoleKey.Enter) };
        Assert.Equal(expected, InteractivePrompt.Confirm(NewCommand.CreationConfirmation, true, Input(writer, keys)));
        Assert.Contains(NewCommand.CreationConfirmation + " [Y/n]:", writer.ToString());
    }

    [Fact]
    public void DefaultNamesAreSuggestedBeforeInputAndCollisionsAreNeverRenamed()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-wizard-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(Path.Combine(root, "App"));
        File.WriteAllText(Path.Combine(root, "App1"), "user file");
        try
        {
            Assert.Equal("App2", NewProjectScaffolder.ResolveDefaultName("App", root));
            var suggested = NewCommand.ResolveWizardName("App", root);
            Assert.Equal("App", suggested.Name);
            Assert.Equal($"'App' already exists in Project location '{root}'. Enter a different name:", suggested.Error);
            var explicitName = NewCommand.ResolveWizardName("App", root);
            Assert.Equal("App", explicitName.Name);
            Assert.Contains("already exists", explicitName.Error);
            Assert.Equal("user file", File.ReadAllText(Path.Combine(root, "App1")));
        }
        finally { Directory.Delete(root, true); }
    }

    private static ConsoleKeyInfo[] TypeLine(string text)
        => text.Select(character => new ConsoleKeyInfo(character, ConsoleKey.A, false, false, false))
            .Append(Key(ConsoleKey.Enter)).ToArray();

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void DefaultParentUsesProfileAndPlatformConvention(bool windows)
    {
        var profile = Path.Combine(Path.GetTempPath(), "test-profile");
        Assert.Equal(windows ? Path.Combine(profile, "source", "repos") : Path.Combine(profile, "Projects"),
            ProjectCreationDirectory.DefaultParent(profile, windows));
        var actualProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        Assert.Equal(ProjectCreationDirectory.DefaultParent(actualProfile, OperatingSystem.IsWindows()),
            ProjectCreationDirectory.DefaultParent());
    }

    [Fact]
    public void ParentIsAskedFirstAndDefaultNameIsUniqueInChosenDirectory()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-parent-first-" + Guid.NewGuid().ToString("N"));
        var baseName = Syncfusion.DotNet.CLI.Core.Naming.ProjectDefaults.BaseName(Framework.Maui);
        Directory.CreateDirectory(Path.Combine(root, baseName));
        File.WriteAllText(Path.Combine(root, baseName + "1"), "keep");
        try
        {
            using var writer = new StringWriter();
            var input = Input(writer, TypeLine(root).Append(Key(ConsoleKey.Enter)).ToArray());
            var result = NewCommand.AskProjectLocationAndName(Framework.Maui, null, new ConsolePresenter(true), input);
            Assert.Equal((root, baseName + "2"), result);
            var rendered = writer.ToString();
            Assert.True(rendered.IndexOf("Project location:  [", StringComparison.Ordinal)
                < rendered.IndexOf("Project name:      [" + baseName + "2]", StringComparison.Ordinal));
            Assert.DoesNotContain("Enter accepts the default", rendered);
            Assert.DoesNotContain("default:", rendered);
            Assert.Equal("keep", File.ReadAllText(Path.Combine(root, baseName + "1")));
        }
        finally { Directory.Delete(root, true); }
    }

    [Fact]
    public void DefaultParentIsCreatedWhenAccepted()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-parent-create-" + Guid.NewGuid().ToString("N"));
        try
        {
            using var writer = new StringWriter();
            Assert.Equal(root, InteractivePrompt.AskOutputPath(root, Input(writer, Key(ConsoleKey.Enter))));
            Assert.True(Directory.Exists(root));
            Assert.Contains($"Project location:  [{root}]", writer.ToString());
        }
        finally { if (Directory.Exists(root)) Directory.Delete(root, true); }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void TypedCollisionRepromptsImmediatelyWithoutDuplicateError(bool file)
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-name-collision-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        if (file) File.WriteAllText(Path.Combine(root, "Busy"), "keep");
        else Directory.CreateDirectory(Path.Combine(root, "Busy"));
        try
        {
            using var capture = new ConsoleCapture();
            using var writer = new StringWriter();
            var input = Input(writer, TypeLine("Busy").Concat(TypeLine("Fresh")).ToArray());
            var result = NewCommand.AskProjectLocationAndName(Framework.Maui, root, new ConsolePresenter(true), input);
            Assert.Equal((root, "Fresh"), result);
            Assert.Contains($"'Busy' already exists in Project location '{root}'. Enter a different name:",
                System.Text.RegularExpressions.Regex.Replace(writer.ToString(), @"\s+", " "));
            Assert.DoesNotContain("already exists", capture.Error);
            Assert.DoesNotContain("Suggested project name", writer.ToString());
            Assert.False(Directory.Exists(Path.Combine(root, "Fresh")));
        }
        finally { Directory.Delete(root, true); }
    }

    [Fact]
    public void ProtectedDirectoryWarnsAndRepromptsWithoutCreatingAnything()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-protected-retry-" + Guid.NewGuid().ToString("N"));
        var protectedParent = OperatingSystem.IsWindows()
            ? Path.Combine(Path.GetPathRoot(root)!, "Windows", "System32") : "/usr";
        try
        {
            using var capture = new ConsoleCapture();
            using var writer = new StringWriter();
            var result = InteractivePrompt.AskOutputPath(root,
                Input(writer, TypeLine(protectedParent).Concat(TypeLine(root)).ToArray()));
            Assert.Equal(root, result);
            Assert.Contains("protected system directory", capture.Out);
            Assert.True(Directory.Exists(root));
        }
        finally { if (Directory.Exists(root)) Directory.Delete(root, true); }
    }

    [Fact]
    public void ProtectedLocationsIncludeDescendantsButNotSimilarPrefixesOrLinks()
    {
        var root = Path.GetPathRoot(Path.GetTempPath())!;
        var system = OperatingSystem.IsWindows() ? Path.Combine(root, "Windows") : "/usr";
        Assert.True(ProjectCreationDirectory.IsProtected(system));
        Assert.True(ProjectCreationDirectory.IsProtected(Path.Combine(system, "nested")));
        Assert.False(ProjectCreationDirectory.IsProtected(system + "-projects"));
        Assert.True(ProjectCreationDirectory.IsProtected(root));
        Assert.True(ProjectCreationDirectory.IsWithin(system.ToUpperInvariant(), system, windows: true));
        if (OperatingSystem.IsWindows()) return;
        var link = Path.Combine(Path.GetTempPath(), "sf-protected-link-" + Guid.NewGuid().ToString("N"));
        Directory.CreateSymbolicLink(link, system);
        try { Assert.True(ProjectCreationDirectory.IsProtected(Path.Combine(link, "nested"))); }
        finally { Directory.Delete(link); }
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(false, true)]
    [InlineData(true, false)]
    [InlineData(true, true)]
    public void PostCreateOptionsHaveAlignedHintsAndRetainCurrentDefault(bool noColor, bool chooseBuild)
    {
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.Yes,
            Interactive = InteractionSupport.Yes,
            Out = new AnsiConsoleOutput(writer),
        });
        console.Profile.Width = 120;
        console.Profile.Height = 40;
        var keys = new Queue<ConsoleKeyInfo>(chooseBuild
            ? [Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter)] : [Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), noColor);
        Assert.Equal(chooseBuild ? InteractivePrompt.PostCreationAction.Build : InteractivePrompt.PostCreationAction.None,
            InteractivePrompt.AskPostCreationAction(false, input));
        var rendered = System.Text.RegularExpressions.Regex.Replace(writer.ToString(), @"\x1B\[[0-?]*[ -/]*[@-~]", "");
        Assert.Contains("Post-create:", rendered);
        Assert.Contains("Generate only   (create files, skip build)", rendered);
        Assert.Contains("Build project   (create files, then restore and build)", rendered);
        Assert.DoesNotContain("After creation", rendered);
        Assert.EndsWith($"Post-create: {(chooseBuild ? "Build project" : "Generate only")}\n", rendered.Replace("\r\n", "\n"));
    }

    [Theory]
    [InlineData("all configured targets")]
    [InlineData("net10.0-android")]
    public void RetainedMauiBuildActionKeepsItsTargetDetail(string description)
    {
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = 120;
        var keys = new Queue<ConsoleKeyInfo>([Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter)]);
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(keys.Dequeue()), true);
        Assert.Equal(InteractivePrompt.PostCreationAction.Build, InteractivePrompt.AskPostCreationAction(false, input, buildSummary: description));
        Assert.EndsWith($"Post-create: Build project ({description})\n", writer.ToString().Replace("\r\n", "\n"));
    }

    [Fact]
    public void GenerateOnlyMauiControlsDiscloseRequiredRestoreWithoutBuild()
    {
        var outcome = NewCommand.Parse(ParseRoot(["new", "maui", "--name", "App", "--control", "datagrid", "--post-action", "generate", "--dry-run"]));
        Assert.True(outcome.IsSuccess);
        Assert.True(outcome.Request!.Restore);
        Assert.False(outcome.Request.Build);
        Assert.Contains(NewCommand.FormatNewProjectReview(outcome.Request, 120), row => row.Contains("Generate only (restore required for selected setup)"));
        using var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings { Ansi = AnsiSupport.Yes, Interactive = InteractionSupport.Yes, Out = new AnsiConsoleOutput(writer) });
        console.Profile.Width = 120;
        var input = new InteractiveConsoleInput(console, _ => Task.FromResult<ConsoleKeyInfo?>(Key(ConsoleKey.Enter)), true);
        Assert.Equal(InteractivePrompt.PostCreationAction.None, InteractivePrompt.AskPostCreationAction(false, input, generateRequiresRestore: true));
        Assert.Contains("create files, restore required packages, skip build", writer.ToString());
        Assert.Contains("Generate only (restore required for selected setup)", writer.ToString());
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void PostCreateSummaryAlignsWithOtherRowsAndOmitsSelectionHints(bool build)
    {
        var request = new NewProjectRequest(Framework.Maui, "App", Path.GetTempPath(), "net10.0", "empty",
            MauiProjectType.App, true, build, false, false);
        var rows = NewCommand.FormatNewProjectReview(request, terminalWidth: 120);
        var labels = new[] { "Action:", "Platform:", "Template:", "Framework:", "Project location:", "Project name:", "Setup:", "Post-create:" };
        foreach (var label in labels)
        {
            var row = Assert.Single(rows, line => line.StartsWith(label, StringComparison.Ordinal));
            Assert.Equal(ProjectFlowLayout.ValueColumn, row.IndexOf(row[label.Length..].TrimStart(), label.Length, StringComparison.Ordinal));
        }
        Assert.Contains(build ? "Post-create:       Build project (all configured targets)" : "Post-create:       Generate only", rows);
        Assert.DoesNotContain(rows, row => row.Contains("create files", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("generate", false)]
    [InlineData("build", true)]
    public void ScriptArgumentsCoverWizardInputsAndControlSelection(string action, bool build)
    {
        var parse = ParseRoot(["new", "maui", "--name", "App", "--path", Path.GetTempPath(),
            "--project-type", "app", "--target-framework", "net10.0", "--control", "datagrid", "listview",
            "--post-action", action, "--no-interactive", "--dry-run"]);
        Assert.Empty(parse.Errors);
        var outcome = NewCommand.Parse(parse);
        Assert.True(outcome.IsSuccess, outcome.Error);
        Assert.Equal(build, outcome.Request!.Build);
        Assert.Equal(MauiProjectType.App, outcome.Request.ProjectType);
        Assert.Equal(new[] { "datagrid", "listview" }, outcome.Request.SelectedTemplateIds);
    }

    [Theory]
    [InlineData("blazor-hybrid")]
    [InlineData("BLAZOR-HYBRID")]
    [InlineData("Blazor-Hybrid")]
    public void HybridProjectCreationIsRejectedBeforeGeneration(string projectType)
    {
        var parse = ParseRoot(["new", "maui", "--name", "App", "--path", Path.GetTempPath(),
            "--project-type", projectType, "--no-interactive"]);
        Assert.Empty(parse.Errors);
        var outcome = NewCommand.Parse(parse);
        Assert.False(outcome.IsSuccess);
        Assert.Contains("temporarily disabled", outcome.Error);
    }

    [Fact]
    public void GenerateOnlyBlankAppDoesNotRestoreOrBuild()
    {
        var outcome = NewCommand.Parse(ParseRoot(["new", "maui", "-n", "App", "--post-action", "generate", "--dry-run"]));
        Assert.True(outcome.IsSuccess);
        Assert.False(outcome.Request!.Restore);
        Assert.False(outcome.Request.Build);
    }

    [Theory]
    [InlineData("run")]
    [InlineData("")]
    public void InvalidPostActionsReportTheSupportedArguments(string action)
    {
        var outcome = NewCommand.Parse(ParseRoot(["new", "maui", "-n", "App", "--post-action", action]));
        Assert.False(outcome.IsSuccess);
        Assert.Contains("generate, build", outcome.Error);
    }

    [Fact]
    public void BuildActionConflictsWithLegacyNoBuildFlag()
    {
        var outcome = NewCommand.Parse(ParseRoot(["new", "maui", "-n", "App", "--post-action", "build", "--no-build"]));
        Assert.False(outcome.IsSuccess);
        Assert.Contains("conflicts", outcome.Error);
    }

    [Fact]
    public async Task MissingNameInScriptIsReportedWithoutPrompting()
    {
        using var capture = new ConsoleCapture();
        var exit = await CliApp.Build().RunAsync(["new", "maui", "--no-interactive"]);
        Assert.Equal(ExitCodes.Error, exit);
        Assert.Contains("-n/--name", capture.Error);
        Assert.DoesNotContain("Select a", capture.Out);
    }

    [Fact]
    public async Task BuildPreflightReportsSdkAndWorkloadRequirements()
    {
        var runner = new PrerequisiteRunner();
        var errors = await new MauiBuildPreflight(runner).CheckAsync("net10.0");
        Assert.Contains(errors, error => error.Contains(".NET 10", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("dotnet workload install", StringComparison.Ordinal));
        Assert.Equal(new[] { "--version", "workload list" }, runner.Commands);
    }

    [Fact]
    public async Task BuildPreflightHonorsCancellationBeforeStartingTools()
    {
        var runner = new PrerequisiteRunner();
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();
        await Assert.ThrowsAsync<OperationCanceledException>(() => new MauiBuildPreflight(runner).CheckAsync("net10.0", cancellation.Token));
        Assert.Empty(runner.Commands);
    }

    private sealed class PrerequisiteRunner : DotNetRunner
    {
        public List<string> Commands { get; } = [];
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2]), StandardError = "" });
            Commands.Add(string.Join(' ', args));
            return Task.FromResult(new ProcessCommandResult
            {
                ExitCode = 0,
                StandardOutput = args[0] == "--version" ? "8.0.100" : "Installed Workload Id\n",
                StandardError = string.Empty
            });
        }
    }

    [Fact]
    public async Task BuildFailureReportsCreationAndRetainsTheProject()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-buildfailure-" + Guid.NewGuid().ToString("N"));
        var runner = new BuildFailureRunner();
        var request = new NewProjectRequest(Framework.Maui, "App", root, "net10.0", "empty", MauiProjectType.App,
            Restore: false, Build: true, DryRun: false, Force: false);
        try
        {
            var result = await new NewProjectScaffolder(runner).ExecuteAsync(request);
            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.True(result.GenerationSucceeded);
            Assert.False(result.BuildSucceeded);
            Assert.False(result.RolledBack);
            Assert.True(File.Exists(Path.Combine(root, "App", "App.csproj")));
            Assert.Contains(runner.Commands, args => args[0] == "new" && args.Contains("--no-restore"));
            Assert.Contains(runner.Commands, args => args.SequenceEqual(new[] { "build", Path.Combine(root, "App", "App.csproj") }));
            using var capture = new ConsoleCapture();
            NewCommand.ReportNewProjectResult(new ConsolePresenter(true), request, result);
            Assert.DoesNotContain("Project created successfully", capture.Out);
            Assert.Contains("Project created, but the build failed.", capture.Error);
            Assert.Contains("available for fixing and rebuilding", capture.Out);
            Assert.Contains("Project location:", capture.Out);
            Assert.DoesNotContain("Location:", capture.Out);
            Assert.Contains("dotnet build", capture.Out);
            Assert.Contains("build failed", capture.Error);
            Assert.Contains("simulated compiler error", capture.Error);
            using var verboseCapture = new ConsoleCapture();
            NewCommand.ReportNewProjectResult(new ConsolePresenter(true, verbose: true), request, result);
            Assert.Contains("simulated compiler error", verboseCapture.Error);
            Assert.DoesNotContain("Build succeeded", capture.Out);
        }
        finally { if (Directory.Exists(root)) { Directory.Delete(root, true); } }
    }

    private sealed class BuildFailureRunner : DotNetRunner
    {
        public List<IReadOnlyList<string>> Commands { get; } = [];
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2]), StandardError = "" });
            Commands.Add(args.ToArray());
            if (args[0] == "new")
            {
                var output = args[args.ToList().IndexOf("-o") + 1];
                Directory.CreateDirectory(output);
                File.WriteAllText(Path.Combine(output, "App.csproj"), "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><UseMaui>true</UseMaui><TargetFramework>net10.0-android</TargetFramework></PropertyGroup></Project>");
            }
            return Task.FromResult(new ProcessCommandResult
            {
                ExitCode = args[0] == "build" ? 1 : 0,
                StandardError = args[0] == "build" ? "simulated compiler error" : string.Empty,
                StandardOutput = string.Empty
            });
        }
    }
}
