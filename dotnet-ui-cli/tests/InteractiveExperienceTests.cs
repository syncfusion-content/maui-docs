using System.IO;
using System.Text.Json;
using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Hosting;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>Checks menu contents, prompts, and interactive command behavior.</summary>
[Collection("Console output")]
public static class InteractiveExperienceTests
{
    [Fact]
    public static async Task PromptCancellation_CancelsAndFinishesPromptBeforeReturning()
    {
        using var cancellation = new CancellationTokenSource();
        var promptStarted = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        var promptCompletion = new TaskCompletionSource<int>(TaskCreationOptions.RunContinuationsAsynchronously);
        var promptTask = Task.Run(() => InteractivePrompt.RunPrompt(
            async cancellationToken =>
            {
                promptStarted.TrySetResult();
                using var registration = cancellationToken.Register(
                    () => promptCompletion.TrySetCanceled(cancellationToken));
                return await promptCompletion.Task.ConfigureAwait(false);
            },
            cancellation.Token));

        await promptStarted.Task;
        cancellation.Cancel();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => promptTask);
        Assert.True(promptCompletion.Task.IsCanceled);
    }

    [Fact]
    public static void MainMenu_HasRequiredCategoriesAndTypedOperationsInOrder()
    {
        Assert.Equal(
        [
            "Project creation",
            "Package management",
            "Discovery",
            "License management",
            "Help and information",
        ], MenuItems.Categories.Select(category => category.Name));

        Assert.Equal(
        [
            "Create a new project",
            "Add a package to an existing project",
            "Update a package in an existing project",
            "List available packages",
            "List installed packages in an existing project",
            "Search for packages",
            "Activate license",
            "View installed licenses",
            "Sign in to Syncfusion",
            "Sign out",
            "View CLI information",
            "Show help",
            "Exit",
        ], MenuItems.Operations.Select(operation => operation.Label));

        Assert.Equal(
        [
            "sf new",
            "sf add",
            "sf update",
            "sf list <platform> packages",
            "sf list <platform> installed",
            "sf search",
            "sf license activate",
            "sf license view",
            "sf login",
            "sf logout",
            "sf info",
            "sf help",
            "Ctrl+C",
        ], MenuItems.Operations.Select(operation => operation.Command));

        Assert.All(MenuItems.Operations, operation => Assert.NotNull(operation.Action));
        Assert.Equal(MenuAction.Information, MenuItems.Operations.Single(operation => operation.Label == "View CLI information").Action);
        Assert.Equal(MenuAction.Help, MenuItems.Operations.Single(operation => operation.Label == "Show help").Action);
        Assert.Equal(MenuAction.Help, MenuItems.Operations[^2].Action);
        Assert.Equal("Show help", MenuItems.Categories[^1].Operations[^1].Label);
        Assert.Equal("What would you like to do?", InteractiveMenu.MenuQuestion);
        Assert.DoesNotContain("Operation", InteractiveMenu.MenuQuestion);
        Assert.DoesNotContain("Command", InteractiveMenu.MenuQuestion);
        Assert.DoesNotContain(MenuItems.Operations, operation =>
            operation.Label.Contains("template", StringComparison.OrdinalIgnoreCase)
            || operation.Label.Contains("control", StringComparison.OrdinalIgnoreCase)
            || operation.Label.Contains("theme", StringComparison.OrdinalIgnoreCase)
            || operation.Label.Contains("skills", StringComparison.OrdinalIgnoreCase)
            || operation.Label.Contains("mcp", StringComparison.OrdinalIgnoreCase)
            || operation.Label.Contains("android", StringComparison.OrdinalIgnoreCase)
            || operation.Label.Contains("blazor", StringComparison.OrdinalIgnoreCase));
        Assert.DoesNotContain(MenuItems.Categories.SelectMany(category => category.Operations), operation =>
            (operation.Label + operation.Command).Contains("theme", StringComparison.OrdinalIgnoreCase)
            || (operation.Label + operation.Command).Contains("future", StringComparison.OrdinalIgnoreCase));
        Assert.Equal(MenuAction.Exit, MenuItems.Operations[^1].Action);
    }

    [Fact]
    public static void SoleMauiTemplateIsRecordedWithoutShowingASelectionPrompt()
    {
        using var capture = new ConsoleCapture();
        Assert.Equal(".NET MAUI App", InteractivePrompt.AskProjectType(noColor: true));
        Assert.Equal($"Template: .NET MAUI App{Environment.NewLine}", capture.Out);
        Assert.DoesNotContain("Select a project template", capture.Out);
    }

    [Fact]
    public static void ProjectCreationChoices_ContainOnlyImplementedPlatformsTypesAndOperableControls()
    {
        Assert.Equal(["maui", "wpf", "winforms", "winui", "blazor"], Frameworks.Implemented);
        Assert.Equal([".NET MAUI App"], InteractivePrompt.ProjectTypeChoices);
        using (var capture = new ConsoleCapture())
        {
            InteractivePrompt.WriteCompletedSelection("Platform:", "MAUI", noColor: true);
            Assert.Equal($"Platform: MAUI{Environment.NewLine}", capture.Out);
        }

        using (var capture = new ConsoleCapture())
        {
            InteractivePrompt.WriteQuestion("Which platform would you like to use?", noColor: true);
            Assert.Equal($"Which platform would you like to use?{Environment.NewLine}", capture.Out);
            AssertNoAnsiColors(capture.Out);
        }

        using (var capture = new ConsoleCapture())
        {
            InteractivePrompt.WriteQuestion(string.Empty, noColor: true);
            Assert.Equal(string.Empty, capture.Out);
        }

        using (var capture = new ConsoleCapture())
        {
            InteractivePrompt.WriteAnswer("None", noColor: true);
            Assert.Equal($"  None{Environment.NewLine}", capture.Out);
            AssertNoAnsiColors(capture.Out);
        }

        using (var capture = new ConsoleCapture())
        {
            InteractivePrompt.WriteAnswer("Build", noColor: true);
            Assert.Equal($"  Build{Environment.NewLine}", capture.Out);
        }

        // The dim gray color is the only color used in the interactive
        // UI; it is applied to optional/replaceable parts of prompts
        // (the "(optional)" hint, the default placeholder, and the
        // confirmation choice hint). Plain `noColor: true` writes skip
        // the color, but the dim color is referenced via the constant
        // below so callers can rely on it.
        Assert.Equal("#8B949E", Syncfusion.DotNet.CLI.Presentation.InteractiveConsoleInput.DimHex);
    }

    [Fact]
    public static void TextEntry_DimSuffixAndPlaceholderAreColored()
    {
        using var color = new NoColorScope(null);
        // The dim color is applied to the optional/replaceable parts
        // of a prompt: the optional hint and the default placeholder.
        // The plain text remains plain. We capture the rendered output
        // through a Spectre.Console writer so the ANSI escape codes
        // are visible.
        var writer = new StringWriter();
        var console = AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.Yes,
            ColorSystem = ColorSystemSupport.Standard,
            Out = new AnsiConsoleOutput(writer),
            Interactive = InteractionSupport.Yes,
        });
        var input = new Syncfusion.DotNet.CLI.Presentation.InteractiveConsoleInput(
            console,
            ReadKeys(Key(ConsoleKey.Enter)));

        _ = input.ReadLine("Project name", "SyncfusionMauiApp", CancellationToken.None, " (optional):");

        var rendered = writer.ToString();
        // The dim hex code should appear in the rendered output (via
        // Spectre's RGB hex -> ANSI escape translation).
        Assert.Contains("Project name", rendered, StringComparison.Ordinal);
        Assert.Contains("(optional)", rendered, StringComparison.Ordinal);
        Assert.Contains("SyncfusionMauiApp", rendered, StringComparison.Ordinal);
        Assert.Matches("\u001b\\[", rendered);

        Assert.NotEmpty(TemplateCatalog.Operable);
        Assert.All(TemplateCatalog.Operable, template =>
        {
            Assert.True(template.Available);
            Assert.True(template.Verified);
            Assert.True(template.Operable);
            Assert.Contains(MauiProjectType.App, template.SupportedProjectTypes);
            Assert.Contains(MauiProjectType.BlazorHybrid, template.SupportedProjectTypes);
        });
    }

    [Fact]
    public static void MainMenu_HeaderUsesProductNameAndAssemblyVersion()
    {
        var header = InteractiveMenu.CreateHeader();
        Assert.Equal($"{CliMetadata.ProductName} {CliMetadata.Version}", header);
        Assert.DoesNotContain(Environment.NewLine, header);
        Assert.DoesNotContain('\u001b', header);
    }

    [Fact]
    public static void MainMenu_FormatsAlignedColumnsAndKeepsNarrowFallbackReadable()
    {
        var renderedRowCount =
            InteractiveMenu.CreateHeader().Split(Environment.NewLine).Length
            + 1 // Blank line after the header.
            + 1 // Menu question.
            + 1 // Blank line after the question.
            + MenuItems.Categories.Count
            + MenuItems.Categories.Count - 1 // Blank rows between categories.
            + MenuItems.Operations.Count
            + 1 // Blank line before keyboard guidance.
            + InteractiveMenu.MenuGuidance.Split(Environment.NewLine).Length;
        Assert.Equal(28, renderedRowCount);

        var sectionHeadings = MenuItems.Categories
            .Select(category =>
            {
                var heading = MenuItems.CreateCategoryChoice(category);
                return (heading.Label, Rendered: InteractiveMenu.FormatChoice(heading, noColor: true));
            })
            .ToArray();
        Assert.All(sectionHeadings, heading =>
            Assert.EndsWith(heading.Label.ToUpperInvariant(), heading.Rendered));

        var normalRows = MenuItems.Operations
            .Select(operation => InteractiveMenu.FormatOperation(operation, terminalWidth: 100))
            .ToArray();
        Assert.All(normalRows, row => Assert.DoesNotContain(Environment.NewLine, row));
        Assert.All(normalRows, row => Assert.False(char.IsWhiteSpace(row[^1])));
        Assert.All(MenuItems.Operations.Select((operation, index) =>
                normalRows[index].IndexOf(operation.Label, StringComparison.Ordinal)),
            column => Assert.Equal(0, column));
        Assert.Single(normalRows.Select((row, index) =>
            row.IndexOf(MenuItems.Operations[index].Command!, StringComparison.Ordinal)).Distinct());
        var expectedCommandColumn = MenuItems.Operations.Max(operation => operation.Label.Length) + 4;
        for (var index = 0; index < normalRows.Length; index++)
        {
            Assert.Equal(
                expectedCommandColumn,
                normalRows[index].IndexOf(MenuItems.Operations[index].Command!, StringComparison.Ordinal));
        }

        var narrowRows = MenuItems.Operations
            .Select(operation => InteractiveMenu.FormatOperation(operation, terminalWidth: 70))
            .ToArray();
        for (var index = 0; index < narrowRows.Length; index++)
        {
            var lines = narrowRows[index].Split(Environment.NewLine);
            Assert.Equal(2, lines.Length);
            Assert.Equal(MenuItems.Operations[index].Label, lines[0]);
            Assert.EndsWith(MenuItems.Operations[index].Command!, lines[1]);
            Assert.Equal(2, lines[1].TakeWhile(char.IsWhiteSpace).Count());
            Assert.All(lines, line => Assert.True(line.Length <= 70));
            Assert.False(char.IsWhiteSpace(lines[0][^1]));
            Assert.False(char.IsWhiteSpace(lines[1][^1]));
        }
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public static void MainMenu_GuidanceHasOneRowAndNoHeading(bool unicode)
    {
        Assert.Equal("↑/↓: navigate | Enter: select | Esc: cancel | Ctrl+C: exit", InteractiveMenu.MenuGuidance);
        Assert.DoesNotContain(Environment.NewLine, InteractiveMenu.MenuGuidance);
        Assert.DoesNotContain("Keyboard guidance", InteractiveMenu.MenuGuidance);

        var capabilities = AnsiConsole.Profile.Capabilities;
        var originalUnicode = capabilities.Unicode;
        try
        {
            capabilities.Unicode = unicode;
            var expected = unicode ? InteractiveMenu.MenuGuidance
                : InteractiveMenu.MenuGuidance.Replace("↑/↓", "Up/Down", StringComparison.Ordinal);
            var colored = InteractiveMenu.FormatMenuGuidance(noColor: false);
            Assert.Equal(expected, colored);
            Assert.DoesNotContain("bold", colored, StringComparison.OrdinalIgnoreCase);
            Assert.DoesNotContain("Keyboard guidance", colored);
            Assert.Equal(expected, InteractiveMenu.FormatMenuGuidance(noColor: true));
        }
        finally
        {
            capabilities.Unicode = originalUnicode;
        }
    }

    [Fact]
    public static void InteractiveSelectionGuidance_IsVerticalAndSpecificToSelectionMode()
    {
        Assert.Contains("↑/↓: navigate", InteractivePrompt.SingleSelectionGuidance);
        Assert.Contains("Enter: continue", InteractivePrompt.SingleSelectionGuidance);
        Assert.Contains("Esc: cancel", InteractivePrompt.SingleSelectionGuidance);
        Assert.Contains("Ctrl+C: exit", InteractivePrompt.SingleSelectionGuidance);
        Assert.DoesNotContain("Space", InteractivePrompt.SingleSelectionGuidance);
        Assert.Contains("Space: toggle | Enter: continue", InteractivePrompt.MultiSelectionGuidance);
    }

    [Fact]
    public static void SelectionPrompts_KeepGuidanceInPromptAndEscapeCancelsWithoutEmptySelection()
    {
        var single = new WizardSelectionPrompt<string>();
        InteractivePrompt.ConfigureSelectionPrompt(single, choiceCount: 3);
        Assert.Equal(3, single.PageSize);
        Assert.Equal(InteractivePrompt.SingleSelectionGuidance, single.MoreChoicesText);
        Assert.Throws<InteractivePromptCancelledException>(() => single.CancelResult!());

        var singleWithCallerSize = new WizardSelectionPrompt<string> { PageSize = 5 };
        InteractivePrompt.ConfigureSelectionPrompt(singleWithCallerSize, choiceCount: 12);
        Assert.Equal(5, singleWithCallerSize.PageSize);

        var singleOversized = new WizardSelectionPrompt<string> { PageSize = 25 };
        InteractivePrompt.ConfigureSelectionPrompt(singleOversized, choiceCount: 4);
        Assert.Equal(4, singleOversized.PageSize);

        var multiple = new MultiSelectionPrompt<string>();
        InteractivePrompt.ConfigureMultiSelectionPrompt(multiple);
        Assert.Equal(InteractivePrompt.MultiSelectionGuidance, multiple.InstructionsText);
        Assert.Throws<InteractivePromptCancelledException>(() => multiple.CancelResult!());
    }

    [Fact]
    public static void ControlMultiSelectPrompt_ShowsEveryOperableControlByDefault()
    {
        // The control picker is the only interactive place where the
        // user can multi-select Syncfusion controls. The PageSize must
        // match the option count so every control is visible without
        // scrolling; otherwise the user has to press ↓/↑ to discover
        // choices that are not in the first screen.
        var prompt = new MultiSelectionPrompt<string>
        {
            PageSize = TemplateCatalog.Operable.Count,
        };
        Assert.Equal(TemplateCatalog.Operable.Count, prompt.PageSize);
        Assert.True(prompt.PageSize > 0);
    }

    [Fact]
    public static void MultiSelectionHighlightStyle_HasNonEmptyForegroundColor()
    {
        // Spectre's MultiSelectionPrompt renders the selected
        // checkbox via GetSelectedCheckbox, which calls
        // style.Value.ToMarkup() to build a Spectre markup tag. When
        // the style has no foreground color (e.g. Style.Plain),
        // ToMarkup() returns an empty string and the resulting
        // markup throws "Could not find color or style ''" the first
        // time the user navigates the list and a redraw is triggered.
        //
        // The CLI uses a dim gray foreground as the single approved
        // color, so the multi-selection HighlightStyle must have a
        // non-empty foreground. This test pins that contract so a
        // future refactor cannot regress to Style.Plain.
        var dim = Syncfusion.DotNet.CLI.Presentation.InteractiveConsoleInput.DimStyle;
        Assert.False(string.IsNullOrEmpty(dim.Foreground.ToString()));
    }

    [Fact]
    public static void TextEntry_EscapeCancelsRequiredAndOptionalValues()
    {
        var console = CreatePromptConsole();
        var required = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.Escape)));
        var optional = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.Escape)));

        Assert.Throws<InteractivePromptCancelledException>(
            () => InteractivePrompt.AskString("Required value", null, required));
        Assert.Throws<InteractivePromptCancelledException>(
            () => InteractivePrompt.AskString("Optional value", "default", optional));
    }

    [Fact]
    public static void TextEntry_EnterDoesNotSubmitEmptyRequiredText()
    {
        var console = CreatePromptConsole();
        var input = new InteractiveConsoleInput(
            console,
            ReadKeys(Key(ConsoleKey.Enter), Key('n'), Key(ConsoleKey.Enter)));

        Assert.Equal("n", InteractivePrompt.AskString("Project name", null, input));
    }

    [Fact]
    public static void ProjectNameEntry_RetriesEmptyAndInvalidValuesWithoutRewritingThem()
    {
        using var capture = new ConsoleCapture();
        var console = CreatePromptConsole();
        var input = new InteractiveConsoleInput(
            console,
            ReadKeys(
                Key(ConsoleKey.Enter),
                Key('b'), Key('a'), Key('d'), Key('-'), Key('n'), Key('a'), Key('m'), Key('e'), Key(ConsoleKey.Enter),
                Key('M'), Key('y'), Key('A'), Key('p'), Key(ConsoleKey.Enter)),
            noColor: true);

        var name = InteractivePrompt.AskProjectName(new ConsolePresenter(noColor: true), input);

        Assert.Equal("MyAp", name);
        Assert.Contains("A project name is required.", capture.Error);
        Assert.Contains("Project name 'bad-name' is invalid.", capture.Error);
        AssertNoAnsiColors(capture.Out + capture.Error);
    }

    [Fact]
    public static void ProjectNameEntry_EscapeCancelsWithoutAcceptingAnEmptyValue()
    {
        var input = new InteractiveConsoleInput(
            CreatePromptConsole(),
            ReadKeys(Key(ConsoleKey.Escape)),
            noColor: true);

        Assert.Throws<InteractivePromptCancelledException>(
            () => InteractivePrompt.AskProjectName(new ConsolePresenter(noColor: true), input));
    }

    [Theory]
    [InlineData("Project name")]
    [InlineData("Search text")]
    public static void SharedTextEntry_EscapeCancelsNameAndSearchPrompts(string label)
    {
        var console = CreatePromptConsole();
        var input = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.Escape)));

        Assert.Throws<InteractivePromptCancelledException>(
            () => InteractivePrompt.AskString(label, null, input));
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public static void Confirmation_EscapeDoesNotAcceptEitherDefault(bool defaultValue)
    {
        var console = CreatePromptConsole();
        var input = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.Escape)));

        Assert.Throws<InteractivePromptCancelledException>(
            () => InteractivePrompt.Confirm("Continue?", defaultValue, input));
    }

    [Fact]
    public static void Confirmation_EnterAcceptsItsDefaultOnlyWhenNotCancelled()
    {
        var console = CreatePromptConsole();
        var yesInput = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.Enter)));
        var noInput = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.Enter)));

        Assert.True(InteractivePrompt.Confirm("Continue?", true, yesInput));
        Assert.False(InteractivePrompt.Confirm("Continue?", false, noInput));
    }

    [Fact]
    public static void CtrlCInLineEntryRemainsOperationCancellation()
    {
        var console = CreatePromptConsole();
        var input = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.C, control: true)));

        Assert.Throws<OperationCanceledException>(
            () => InteractivePrompt.AskString("Project name", null, input));
    }

    [Fact]
    public static void CtrlCInConfirmationRemainsOperationCancellation()
    {
        var console = CreatePromptConsole();
        var input = new InteractiveConsoleInput(console, ReadKeys(Key(ConsoleKey.C, control: true)));

        Assert.Throws<OperationCanceledException>(
            () => InteractivePrompt.Confirm("Continue?", true, input));
    }

    [Fact]
    public static void TextEntryGuidance_ContainsOnlyApplicableKeys()
    {
        Assert.Contains("Enter: continue", InteractivePrompt.TextEntryGuidance);
        Assert.Contains("Esc: cancel", InteractivePrompt.TextEntryGuidance);
        Assert.Contains("Ctrl+C: exit", InteractivePrompt.TextEntryGuidance);
        Assert.Contains("Space: toggle | Enter: continue", InteractivePrompt.MultiSelectionGuidance);
        Assert.Equal(InteractivePrompt.TextEntryGuidance, InteractivePrompt.ProjectNameGuidance);
    }

    [Fact]
    public static void MainMenu_GroupChoicesContainOnlyOperationsAndCategoryHeadings()
    {
        Assert.All(MenuItems.Categories, category =>
        {
            Assert.NotEmpty(category.Operations);
            Assert.Null(MenuItems.CreateCategoryChoice(category).Action);
        });
        Assert.Equal(
            MenuItems.Operations.Count - 1,
            MenuItems.Categories.Sum(category => category.Operations.Count));
        Assert.DoesNotContain(MenuItems.Categories.SelectMany(category => category.Operations), item =>
            item.Label.StartsWith("[ ]", StringComparison.Ordinal)
            || item.Label.StartsWith("[x]", StringComparison.Ordinal));
    }

    [Fact]
    public static async Task BareRedirectedInvocation_DoesNotShowInteractiveMenu()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync([]);

        Assert.Equal(ExitCodes.Success, exitCode);
        Assert.DoesNotContain(InteractiveMenu.MenuQuestion, capture.Out);
        Assert.DoesNotContain("Keyboard guidance", capture.Out);
    }

    [Fact]
    public static void ActiveGeneratedContentQuestionsAndReviewsUseControlTerminology()
    {
        var text = new[]
        {
            InteractivePrompt.NewProjectControlChoiceTitle,
            InteractivePrompt.ControlFamilyQuestion,
            InteractivePrompt.ChartControlQuestion,
            CommandOperations.AddControlsConfirmation,
            CommandOperations.ControlsReviewLabel,
            NewCommand.ProjectControlReviewLabel,
        };

        Assert.Contains("Select project setup:", text);
        Assert.Contains("Which control families would you like to use?", text);
        Assert.Contains("Which chart controls would you like to add?", text);
        Assert.Contains("Proceed to add control samples?", text);
        Assert.DoesNotContain(text, item => item.Contains("template", StringComparison.OrdinalIgnoreCase));
    }

    [Fact]
    public static async Task BareJsonInvocation_WritesExactlyOneJsonDocument()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(["--json"]);

        Assert.Equal(0, exitCode);
        using var document = JsonDocument.Parse(capture.Out);
        Assert.False(document.RootElement.GetProperty("interactive").GetBoolean());
        Assert.Empty(capture.Error);
    }

    [Fact]
    public static async Task IncompleteJsonCommand_DoesNotPrompt_AndWritesOneJsonDocument()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(["add", "maui", "--json"]);

        Assert.NotEqual(0, exitCode);
        using var document = JsonDocument.Parse(capture.Out);
        Assert.False(document.RootElement.GetProperty("success").GetBoolean());
        Assert.Contains("package is required", document.RootElement.GetProperty("error").GetString(), StringComparison.OrdinalIgnoreCase);
        Assert.Empty(capture.Error);
        Assert.DoesNotContain("Navigate", capture.Out);
    }

    [Fact]
    public static async Task NewWithCompleteDirectValues_DoesNotPromptOrOpenTheMenu()
    {
        using var capture = new ConsoleCapture();

        var exitCode = await CliApp.Build().RunAsync(
            ["new", "maui", "-n", "DirectApp", "--dry-run", "--no-color"]);

        Assert.Equal(ExitCodes.Success, exitCode);
        Assert.Contains("Planned new MAUI project 'DirectApp'.", capture.Out);
        Assert.DoesNotContain("What would you like", capture.Out);
        Assert.DoesNotContain("Which", capture.Out);
        Assert.DoesNotContain(InteractiveMenu.MenuQuestion, capture.Out);
        AssertNoAnsiColors(capture.Out + capture.Error);
    }

    [Fact]
    public static void NewProjectReview_ContainsOnlyApplicableUserFacingValues()
    {
        var request = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "ReviewApp",
            Environment.CurrentDirectory,
            "net10.0",
            MauiProjectType.BlazorHybrid,
            ["datagrid"],
            restore: true,
            build: true,
            dryRun: false,
            force: false);

        var review = NewCommand.FormatNewProjectReview(request, terminalWidth: 120);
        var text = string.Join(Environment.NewLine, review);

        Assert.Equal(9, review.Count);
        Assert.Contains($"Project name:      ReviewApp", review);
        Assert.Contains("Platform:          .NET MAUI", review);
        Assert.Contains("Template:          .NET MAUI Blazor Hybrid", review);
        Assert.Contains("Framework:         .NET 10 (net10.0)", review);
        Assert.Contains($"Project location:  {Path.GetFullPath(request.Path)}", review);
        Assert.Contains("Controls:          DataGrid", review);
        Assert.Contains(review, line => line.Trim() == "Post-create:       Build project (all configured targets)");
        Assert.DoesNotContain("(datagrid)", text, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("package", text, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public static void NewProjectReview_EmptyControlsShowsEmptyProjectLabel()
    {
        var request = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "EmptyApp",
            Environment.CurrentDirectory,
            "net10.0",
            MauiProjectType.App,
            [],
            restore: true,
            build: false,
            dryRun: false,
            force: false);

        var review = NewCommand.FormatNewProjectReview(request, terminalWidth: 120);

        Assert.Contains("Setup:             Blank app", review);
        Assert.DoesNotContain(review, line => line.StartsWith("Controls:", StringComparison.Ordinal));
        Assert.Contains(review, line => line.Contains("Post-create:") && line.EndsWith("Generate only"));
    }

    [Fact]
    public static void ProjectNameDefault_ForMaui_IsTheApprovedName()
    {
        Assert.Equal("SyncfusionMauiApp", Core.Naming.ProjectDefaults.BaseName(Framework.Maui));
    }

    [Fact]
    public static void ResolveDefaultName_ReturnsBaseNameWhenDestinationIsFree()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-default-" + Guid.NewGuid().ToString("N"));
        try
        {
            Directory.CreateDirectory(root);
            var resolved = NewProjectScaffolder.ResolveDefaultName("SyncfusionMauiApp", root);
            Assert.Equal("SyncfusionMauiApp", resolved);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void ResolveDefaultName_AppendsDeterministicNumericSuffixOnConflict()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-default-" + Guid.NewGuid().ToString("N"));
        try
        {
            Directory.CreateDirectory(root);
            Directory.CreateDirectory(Path.Combine(root, "SyncfusionMauiApp"));
            Directory.CreateDirectory(Path.Combine(root, "SyncfusionMauiApp1"));
            var resolved = NewProjectScaffolder.ResolveDefaultName("SyncfusionMauiApp", root);
            Assert.Equal("SyncfusionMauiApp2", resolved);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void ResolveDefaultName_NeverAutoRenamesExplicitNameConflicts()
    {
        // The interactive flow does not invoke this resolver for explicit names.
        // The helper only ever runs against the platform default, so an explicit
        // conflicting name is not silently renamed — it is reported to the user.
        var root = Path.Combine(Path.GetTempPath(), "sf-default-" + Guid.NewGuid().ToString("N"));
        try
        {
            Directory.CreateDirectory(root);
            Directory.CreateDirectory(Path.Combine(root, "SyncfusionMauiApp"));
            // Calling against a different base name does not collide.
            var resolved = NewProjectScaffolder.ResolveDefaultName("OtherApp", root);
            Assert.Equal("OtherApp", resolved);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void PostCreationActionPrompt_OmitsRunWhenNotSupported()
    {
        var withoutRun = InteractivePrompt.PostCreationActionOptions(runSupported: false);
        var withRun = InteractivePrompt.PostCreationActionOptions(runSupported: true);
        Assert.Equal(2, withoutRun.Count);
        Assert.DoesNotContain("Run", withoutRun);
        Assert.Equal(3, withRun.Count);
        Assert.Contains("Run", withRun);
        Assert.Contains("Generate only", withoutRun);
        Assert.Contains("Generate only", withRun);
    }

    [Fact]
    public static void TargetFrameworkPrompt_ResolvesSingleFrameworkWithoutPrompting()
    {
        Assert.Equal("net10.0", InteractivePrompt.AskTargetFramework(["net10.0"]));
    }

    [Fact]
    public static void TargetFrameworkPrompt_ExposesTheApprovedFrameworkList()
    {
        Assert.Contains("net9.0", InteractivePrompt.SupportedTargetFrameworks);
        Assert.Contains("net10.0", InteractivePrompt.SupportedTargetFrameworks);
    }

    [Fact]
    public static void NewCommand_Request_HonorsPostCreationActionBuild()
    {
        var request = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "MyApp",
            Environment.CurrentDirectory,
            "net10.0",
            MauiProjectType.App,
            ["datagrid"],
            restore: true,
            build: true,
            dryRun: false,
            force: false);

        Assert.True(request.Build);
        Assert.True(request.Restore);
    }

    [Fact]
    public static void NewCommand_Request_HonorsPostCreationActionCreateOnly()
    {
        var request = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "MyApp",
            Environment.CurrentDirectory,
            "net10.0",
            MauiProjectType.App,
            [],
            restore: false,
            build: false,
            dryRun: false,
            force: false);

        Assert.False(request.Build);
        Assert.False(request.Restore);
    }

    [Fact]
    public static void NewCommand_Request_EmptyControlsProducesEmptyTemplateId()
    {
        var request = NewCommand.CreateNewProjectRequest(
            Framework.Maui,
            "MyApp",
            Environment.CurrentDirectory,
            "net10.0",
            MauiProjectType.App,
            [],
            restore: true,
            build: false,
            dryRun: false,
            force: false);

        Assert.Equal("empty", request.Template);
        Assert.Empty(request.SelectedTemplateIds);
    }

    [Fact]
    public static async Task NoInteractiveIncompleteCommand_DoesNotPrompt()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(["add", "maui", "--no-interactive"]);

        Assert.NotEqual(0, exitCode);
        Assert.Contains("A package is required", capture.Error);
        Assert.DoesNotContain("What would you like", capture.Out);
        Assert.DoesNotContain("Navigate", capture.Out);
    }

    [Fact]
    public static async Task IncompleteCommand_ReportsAnExplicitInvalidProjectPathFirst()
    {
        var invalidPath = Path.Combine(Path.GetTempPath(), "sf-missing-project-" + Guid.NewGuid().ToString("N"));
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(
            ["add", "maui", "--no-interactive", "--path", invalidPath]);

        Assert.NotEqual(0, exitCode);
        Assert.Contains("No MAUI .csproj project was found", capture.Error);
        Assert.DoesNotContain("A package is required", capture.Error);
        Assert.DoesNotContain("What would you like", capture.Out);
    }

    [Fact]
    public static async Task InvalidExplicitFramework_FailsBeforeInteractiveReplacement()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(["add", "--framework", "android"]);

        Assert.NotEqual(0, exitCode);
        Assert.Contains("Unknown framework 'android'", capture.Error);
        Assert.DoesNotContain("What would you like", capture.Out);
        Assert.DoesNotContain("Navigate", capture.Out);
    }

    [Fact]
    public static async Task InvalidExplicitPackageVersion_FailsBeforeProjectOrPackageQuestions()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(["add", "maui", "--version", "not-a-version"]);

        Assert.NotEqual(0, exitCode);
        Assert.Contains("not-a-version", capture.Error);
        Assert.Contains("not a valid NuGet version", capture.Error, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("not a valid version string", capture.Error, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("32.1.29", capture.Error);
        Assert.DoesNotContain("No MAUI .csproj project was found", capture.Error);
        Assert.DoesNotContain("A package is required", capture.Error);
        Assert.DoesNotContain("Navigate", capture.Out);
    }

    [Fact]
    public static async Task InvalidExplicitTargetFramework_FailsBeforeProjectNameQuestion()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(
            ["new", "maui", "--target-framework", "not-a-target-framework"]);

        Assert.NotEqual(0, exitCode);
        Assert.Contains("not-a-target-framework", capture.Error);
        Assert.Contains("is not a valid value for --framework", capture.Error, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("Omit --target-framework", capture.Error);
        Assert.DoesNotContain("A project name is required", capture.Error);
        Assert.DoesNotContain("What would you like to name the project?", capture.Out);
    }

    [Fact]
    public static async Task InvalidExplicitTemplate_FailsBeforeRequestingProjectName()
    {
        using var capture = new ConsoleCapture();
        var exitCode = await CliApp.Build().RunAsync(
            ["new", "maui", "--template", "not-a-template", "--no-interactive"]);

        Assert.NotEqual(0, exitCode);
        Assert.Contains("not-a-template", capture.Error);
        Assert.DoesNotContain("A project name is required", capture.Error);
    }

    private static IAnsiConsole CreatePromptConsole()
        => AnsiConsole.Create(new AnsiConsoleSettings
        {
            Ansi = AnsiSupport.No,
            ColorSystem = ColorSystemSupport.NoColors,
            Out = new AnsiConsoleOutput(TextWriter.Null),
            Interactive = InteractionSupport.Yes,
        });

    private static void AssertNoAnsiColors(string value)
        => Assert.DoesNotMatch("\u001b\\[[0-9;]*m", value);

    private static Func<CancellationToken, Task<ConsoleKeyInfo?>> ReadKeys(params ConsoleKeyInfo[] keys)
    {
        var remaining = new Queue<ConsoleKeyInfo>(keys);
        return _ => Task.FromResult<ConsoleKeyInfo?>(remaining.Dequeue());
    }

    private static ConsoleKeyInfo Key(ConsoleKey key, bool control = false)
        => new('\0', key, shift: false, alt: false, control: control);

    private static ConsoleKeyInfo Key(char character)
        => new(character, ConsoleKey.N, shift: false, alt: false, control: false);
}
