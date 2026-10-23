using Syncfusion.DotNet.CLI.Commands.Desktop;
using Syncfusion.DotNet.CLI.Commands.Blazor;
using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Commands.Options;
using Syncfusion.DotNet.CLI.Commands.Parsing;
using Syncfusion.DotNet.CLI.Commands.Reporting;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;

namespace Syncfusion.DotNet.CLI.Commands;

/// <summary>
/// Defines the <c>sf new</c> command. Arguments are optional so bare
/// <c>sf new</c> can drive interactive completion; missing required values are
/// prompted for when interactive, or reported as errors otherwise.
/// </summary>
public static class NewCommand
{
    internal const string FrameworkArg = "framework";
    internal const string ProjectControlReviewLabel = "Control:";

    public static Command Create()
    {
        var frameworkArg = CommandOptions.OptionalArg(FrameworkArg, "The platform: maui, blazor, wpf, winforms or winui.");

        var command = new Command("new", "Create a new project.");
        command.Add(frameworkArg);
        command.Add(CommandOptions.NameOption);
        command.Add(CommandOptions.LanguageOption);
        command.Add(CommandOptions.ThemeOption);
        command.Add(CommandOptions.PathOption);
        command.Add(CommandOptions.TargetFrameworkOption);
        command.Add(CommandOptions.BuildFrameworkOption);
        command.Add(CommandOptions.FrameworkOption);
        command.Add(CommandOptions.ControlOption);
        command.Add(CommandOptions.TemplateOption);
        command.Add(CommandOptions.ProjectTypeOption);
        command.Add(CommandOptions.AppTypeOption);
        command.Add(CommandOptions.RenderModeOption);
        command.Add(CommandOptions.InteractivityOption);
        command.Add(CommandOptions.AuthOption);
        command.Add(CommandOptions.HttpsOption);
        command.Add(CommandOptions.VersionOption);
        command.Add(CommandOptions.SourceOption);
        command.Add(CommandOptions.ConfigFileOption);
        command.Add(CommandOptions.DryRunOption);
        command.Add(CommandOptions.ForceOption);
        command.Add(CommandOptions.NoRestoreOption);
        command.Add(CommandOptions.NoBuildOption);
        command.Add(CommandOptions.PostActionOption);

        command.SetAction(async (parseResult, cancellationToken) =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parseResult);
            var globals = GlobalsHelper.Bind(parseResult);
            using var wizardOutput = InteractivePrompt.CanPrompt(globals)
                ? ProjectWizardOutput.Begin(Spectre.Console.AnsiConsole.Console, presenter.NoColor) : null;

            if (string.IsNullOrWhiteSpace(parseResult.GetValue<string?>(FrameworkArg)) && string.IsNullOrWhiteSpace(parseResult.GetValue(CommandOptions.FrameworkOption)) && InteractivePrompt.CanPrompt(globals))
            {
                ProjectWizardOutput.WriteCompletedValue(Spectre.Console.AnsiConsole.Console, "Action:", "Create a new project", presenter.NoColor);
                var selected = InteractivePrompt.AskFramework(globals.NoColor, cancellationToken);
                var tokens = parseResult.Tokens.Select(token => token.Value).ToList();
                if (tokens.Count > 0 && tokens[0] == "new") tokens.RemoveAt(0);
                tokens.AddRange(["--framework", selected]);
                parseResult = parseResult.CommandResult.Command.Parse(tokens.ToArray());
            }
            if (BlazorCommands.IsSelected(parseResult, FrameworkArg))
                return await BlazorCommands.NewAsync(parseResult, globals, presenter, cancellationToken).ConfigureAwait(false);
            if (DesktopCommands.Provider(parseResult, FrameworkArg) is { } desktop)
                return await DesktopCommands.NewAsync(parseResult, globals, presenter, desktop, cancellationToken).ConfigureAwait(false);

            var versionValidationExit = await CommandOperations.ValidateExplicitPackageVersionAsync(
                presenter,
                globals,
                parseResult.GetValue(CommandOptions.VersionOption),
                cancellationToken).ConfigureAwait(false);
            if (versionValidationExit is { } versionExit)
            {
                return versionExit;
            }

            var targetFramework = parseResult.GetValue(CommandOptions.TargetFrameworkOption);
            if (!string.IsNullOrWhiteSpace(targetFramework))
            {
                var validation = await new NewProjectScaffolder()
                    .ValidateTargetFrameworkAsync(targetFramework, cancellationToken)
                    .ConfigureAwait(false);
                if (!validation.Success)
                {
                    var diagnostic = string.Join(
                        Environment.NewLine,
                        new[] { validation.StandardError, validation.StandardOutput }
                            .Where(output => !string.IsNullOrWhiteSpace(output)))
                        .Trim();
                    if (string.IsNullOrWhiteSpace(diagnostic))
                    {
                        diagnostic = "The installed MAUI template rejected the target framework.";
                    }

                    var invalidValue = diagnostic.Contains(
                        "is not a valid value for --framework",
                        StringComparison.OrdinalIgnoreCase);
                    var message = invalidValue
                        ? $"Target framework '{targetFramework}' is invalid for the installed MAUI template: {diagnostic}{Environment.NewLine}Omit --target-framework to use the default net10.0 target."
                        : $"Could not validate target framework '{targetFramework}' with the installed MAUI template: {diagnostic}{Environment.NewLine}Run 'dotnet new maui --help' and retry with a supported target framework.";
                    if (globals.Json) return CommandOperations.WriteFailure(presenter, globals, message);
                    presenter.WriteVerbose(diagnostic);
                    return CommandOperations.WriteFailure(presenter, globals, invalidValue
                        ? $"Target framework '{targetFramework}' is not a valid value for --framework in the installed MAUI template. No changes made. Omit --target-framework to use the default net10.0 target."
                        : $"Could not validate target framework '{targetFramework}'. No changes made. Run 'dotnet new maui --help' and retry with a supported target framework; use --verbose for diagnostics.");
                }
            }

            ParseOutcome<NewProjectRequest> outcome;
            try
            {
                outcome = Build(parseResult, globals, cancellationToken, presenter);
            }
            catch (InteractivePromptCancelledException)
            {
                if (!globals.Json) presenter.WriteInfo("Cancelled. No changes made.");
                return ExitCodes.Cancelled;
            }

            if (!outcome.IsSuccess)
            {
                return CommandOperations.WriteFailure(presenter, globals, outcome.Error!, outcome.ExitCode);
            }

            var request = outcome.Request!;
            if (CommandReporting.IsPlanned(request.Framework))
            {
                return CommandReporting.ReportPlanned(presenter, request.Framework);
            }

            try
            {
                if (InteractivePrompt.CanPrompt(globals) && globals.RequiresReview && !request.DryRun
                    && !ReviewNewProject(presenter, request, cancellationToken))
                {
                    return ExitCodes.Cancelled;
                }
            }
            catch (InteractivePromptCancelledException)
            {
                if (!globals.Json) presenter.WriteInfo("Cancelled. No changes made.");
                return ExitCodes.Cancelled;
            }

            return globals.Json
                ? await ExecuteNewJsonAsync(presenter, request, cancellationToken).ConfigureAwait(false)
                : await ExecuteNew(presenter, request, cancellationToken).ConfigureAwait(false);
        });

        return command;
    }

    /// <summary>
    /// Builds the request, prompting for missing required values when
    /// interactive completion is allowed.
    /// </summary>
    public static ParseOutcome<NewProjectRequest> Build(
        ParseResult parseResult,
        GlobalOptions globals,
        CancellationToken cancellationToken = default,
        ConsolePresenter? presenter = null,
        bool showHeader = true)
    {
        var language = parseResult.GetValue(CommandOptions.LanguageOption);
        if (language is not null && DesktopConfiguration.CanonicalLanguage(language) != "C#")
            return ParseOutcome<NewProjectRequest>.Fail("MAUI supports C# only.");
        var postAction = parseResult.GetValue(CommandOptions.PostActionOption)?.Trim().ToLowerInvariant();
        if (parseResult.GetResult(CommandOptions.PostActionOption) is not null
            && postAction is not ("generate" or "build"))
        {
            return ParseOutcome<NewProjectRequest>.Fail("Unknown --post-action. Supported values: generate, build.");
        }
        if (postAction == "build" && parseResult.GetValue(CommandOptions.NoBuildOption))
        {
            return ParseOutcome<NewProjectRequest>.Fail("--post-action build conflicts with --no-build.");
        }

        var controlOptionPresent = parseResult.GetResult(CommandOptions.ControlOption) is not null;
        var templateOptionPresent = parseResult.GetResult(CommandOptions.TemplateOption) is not null;
        if (controlOptionPresent && templateOptionPresent)
        {
            return ParseOutcome<NewProjectRequest>.Fail(
                "Specify a control selection only once.");
        }

        var selectionOptionPresent = controlOptionPresent || templateOptionPresent;
        var requestedTemplates = controlOptionPresent
            ? parseResult.GetValue(CommandOptions.ControlOption) ?? []
            : CommandOptions.GetTemplateValues(parseResult);
        var unavailableTemplate = requestedTemplates.FirstOrDefault(LegacyUnsupportedTemplateCatalog.Contains);
        if (unavailableTemplate is not null)
        {
            return ParseOutcome<NewProjectRequest>.Fail(TemplateSelection.NotAvailableMessage(unavailableTemplate));
        }

        if (requestedTemplates.Count > 0
            && !TemplateSelection.TryNormalize(
                requestedTemplates,
                allowEmpty: true,
                syntax: "sf new maui -n <name> --control <empty|control-id> [control-id ...]",
                out _,
                out var templateError))
        {
            return ParseOutcome<NewProjectRequest>.Fail(templateError!);
        }

        var pathOptionWasSupplied = parseResult.GetResult(CommandOptions.PathOption) is not null;
        var pathValue = parseResult.GetValue(CommandOptions.PathOption);
        if (pathOptionWasSupplied && string.IsNullOrWhiteSpace(pathValue))
        {
            return ParseOutcome<NewProjectRequest>.Fail("Project location cannot be empty.");
        }

        string path;
        try
        {
            path = PathNormalizer.Normalize(pathValue);
        }
        catch (Exception ex) when (ex is ArgumentException or NotSupportedException or PathTooLongException)
        {
            return ParseOutcome<NewProjectRequest>.Fail("Project location is invalid. Provide a valid relative or absolute --path.");
        }

        if (showHeader && InteractivePrompt.CanPrompt(globals)
            && string.IsNullOrWhiteSpace(parseResult.GetValue(CommandOptions.NameOption)))
        {
            (presenter ?? new ConsolePresenter(globals.NoColor)).WriteInfo(InteractiveMenu.CreateHeader());
            System.Console.Out.WriteLine();
        }

        var frameworkArgument = parseResult.GetValue<string?>(FrameworkArg);
        var frameworkOption = parseResult.GetValue(CommandOptions.FrameworkOption);
        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkArgument, frameworkOption, globals, cancellationToken);

        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<NewProjectRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        var nameWasSupplied = parseResult.GetResult(CommandOptions.NameOption) is not null;
        var name = parseResult.GetValue(CommandOptions.NameOption);
        var promptedForName = string.IsNullOrWhiteSpace(name);
        if (promptedForName && nameWasSupplied)
        {
            return ParseOutcome<NewProjectRequest>.Fail("A project name is required. Use -n/--name.");
        }

        if (promptedForName && !InteractivePrompt.CanPrompt(globals))
        {
            return ParseOutcome<NewProjectRequest>.Fail("A project name is required. Use -n/--name.");
        }

        if (!promptedForName)
        {
            name = name!.Trim();
            var nameError = NewProjectScaffolder.ValidateProjectName(name);
            if (nameError is not null)
            {
                return ParseOutcome<NewProjectRequest>.Fail(nameError);
            }
        }

        var projectTypeValue = parseResult.GetValue(CommandOptions.ProjectTypeOption);
        var projectTypeWasSupplied = parseResult.GetResult(CommandOptions.ProjectTypeOption) is not null;
        if (projectTypeWasSupplied && string.IsNullOrWhiteSpace(projectTypeValue))
        {
            return ParseOutcome<NewProjectRequest>.Fail("A project type is required. Supported values: app.");
        }

        var projectType = ParseProjectType(projectTypeValue, out var projectTypeError);
        if (projectTypeError is not null)
        {
            return ParseOutcome<NewProjectRequest>.Fail(projectTypeError);
        }

        if (promptedForName
            && !projectTypeWasSupplied
            && InteractivePrompt.CanPrompt(globals))
        {
            // Improvement: .NET MAUI Blazor Hybrid project creation is temporarily disabled.
            // projectType = InteractivePrompt.AskProjectType(globals.NoColor, cancellationToken) == ".NET MAUI Blazor Hybrid"
            //     ? MauiProjectType.BlazorHybrid
            //     : MauiProjectType.App;
            InteractivePrompt.AskProjectType(globals.NoColor, cancellationToken);
            projectType = MauiProjectType.App;
            globals.RequiresReview = true;
        }

        var targetFramework = string.IsNullOrWhiteSpace(parseResult.GetValue(CommandOptions.TargetFrameworkOption))
            ? "net10.0"
            : parseResult.GetValue(CommandOptions.TargetFrameworkOption)!;
        if (promptedForName && InteractivePrompt.CanPrompt(globals))
        {
            globals.RequiresReview = true;
            if (parseResult.GetResult(CommandOptions.TargetFrameworkOption) is null)
            {
                targetFramework = InteractivePrompt.AskTargetFramework(
                    InteractivePrompt.SupportedTargetFrameworks, globals.NoColor, cancellationToken);
            }
            var input = new InteractiveConsoleInput(globals.NoColor);
            var location = AskProjectLocationAndName(frameworkOutcome.Request!, pathOptionWasSupplied ? path : null,
                presenter ?? new ConsolePresenter(globals.NoColor), input, cancellationToken);
            path = location.Parent;
            name = location.Name;
        }

        if (selectionOptionPresent && requestedTemplates.Count == 0)
        {
            if (InteractivePrompt.CanPrompt(globals))
            {
                globals.RequiresReview = true;
                requestedTemplates = InteractivePrompt.AskTemplates(cancellationToken, globals.NoColor);
            }
            else
            {
                return ParseOutcome<NewProjectRequest>.Fail(
                    "At least one control ID is required after --control. Syntax: sf new maui -n <name> --control <control-id> [control-id ...].");
            }
        }

        if (!selectionOptionPresent && promptedForName && InteractivePrompt.CanPrompt(globals))
        {
            globals.RequiresReview = true;
            requestedTemplates = InteractivePrompt.AskNewProjectTemplates(
                projectType,
                globals.NoColor,
                cancellationToken);
            selectionOptionPresent = true;
        }

        IReadOnlyList<string> templateIds;
        if (selectionOptionPresent)
        {
            if (!TemplateSelection.TryNormalize(
                requestedTemplates,
                allowEmpty: true,
                syntax: "sf new maui -n <name> --control <empty|control-id> [control-id ...]",
                out templateIds,
                out var selectionError))
            {
                return ParseOutcome<NewProjectRequest>.Fail(selectionError!);
            }

            if (templateIds.Count > 0
                && (parseResult.GetValue(CommandOptions.NoRestoreOption)
                || parseResult.GetValue(CommandOptions.NoBuildOption))
               )
            {
                return ParseOutcome<NewProjectRequest>.Fail(
                    "Selected controls require restore and build validation. Remove --no-restore and --no-build.");
            }
        }
        else
        {
            templateIds = [];
        }

        if (!parseResult.GetValue(CommandOptions.DryRunOption) && ConflictsAtDestination(name!, path))
        {
            return ParseOutcome<NewProjectRequest>.Fail($"Project location '{Path.Combine(path, name!)}' already exists. Choose a different project name or --path; existing files were not changed.");
        }

        var build = !parseResult.GetValue(CommandOptions.NoBuildOption) && postAction != "generate";
        var restore = postAction == "generate" ? templateIds.Count > 0 : !parseResult.GetValue(CommandOptions.NoRestoreOption);
        if (promptedForName && InteractivePrompt.CanPrompt(globals)
            && postAction is null && parseResult.GetResult(CommandOptions.NoBuildOption)?.Implicit != false)
        {
            build = InteractivePrompt.AskPostCreationAction(false, globals.NoColor, cancellationToken, generateRequiresRestore: templateIds.Count > 0 || projectType == MauiProjectType.BlazorHybrid, buildSummary: parseResult.GetValue(CommandOptions.BuildFrameworkOption) ?? "all configured targets")
                == InteractivePrompt.PostCreationAction.Build;
            restore = build || templateIds.Count > 0;
        }
        if (parseResult.GetResult(CommandOptions.BuildFrameworkOption) is not null
            && (!build || string.IsNullOrWhiteSpace(parseResult.GetValue(CommandOptions.BuildFrameworkOption))))
        {
            return ParseOutcome<NewProjectRequest>.Fail("--build-framework requires a nonempty target and the Build project action (--post-action build).");
        }
        return ParseOutcome<NewProjectRequest>.Ok(CreateNewProjectRequest(
            frameworkOutcome.Request!,
            name!,
            path,
            targetFramework,
            projectType,
            templateIds,
            restore: restore,
            build: build,
            dryRun: parseResult.GetValue(CommandOptions.DryRunOption),
            force: parseResult.GetValue(CommandOptions.ForceOption),
            version: parseResult.GetValue(CommandOptions.VersionOption),
            source: parseResult.GetValue(CommandOptions.SourceOption),
            configFile: parseResult.GetValue(CommandOptions.ConfigFileOption),
            buildFramework: parseResult.GetValue(CommandOptions.BuildFrameworkOption)));
    }

    /// <summary>Pure parse used by tests: no prompting, validation errors only.</summary>
    public static ParseOutcome<NewProjectRequest> Parse(ParseResult parseResult)
        => Build(parseResult, _nonInteractiveGlobals);

    internal static NewProjectRequest CreateNewProjectRequest(
        Framework framework,
        string name,
        string path,
        string targetFramework,
        MauiProjectType projectType,
        IReadOnlyList<string> selectedControls,
        bool restore,
        bool build,
        bool dryRun,
        bool force,
        string? version = null,
        string? source = null,
        string? configFile = null,
        string? buildFramework = null)
    {
        var controlIds = selectedControls
            .Where(controlId => !controlId.Equals("empty", StringComparison.OrdinalIgnoreCase))
            .ToList();
        var control = controlIds.FirstOrDefault() ?? "empty";

        return new NewProjectRequest(
            framework,
            name,
            path,
            targetFramework,
            control,
            projectType,
            restore,
            build,
            dryRun,
            force,
            version,
            source,
            configFile,
            TemplateIds: controlIds,
            BuildFramework: buildFramework?.Trim());
    }

    /// <summary>
    /// Executes a parsed <c>sf new</c> request against the MAUI scaffolder
    /// and reports the outcome. Shared by the direct command path and the
    /// interactive menu so both produce the same files and exit codes.
    /// </summary>
    internal static Task<int> ExecuteNew(
        ConsolePresenter presenter,
        NewProjectRequest request,
        CancellationToken cancellationToken)
    {
        return ExecuteNewCoreAsync(presenter, request, cancellationToken);
    }

    private static async Task<int> ExecuteNewCoreAsync(
        ConsolePresenter presenter,
        NewProjectRequest request,
        CancellationToken cancellationToken)
    {
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        if (!request.Build && (request.SelectedTemplateIds.Count > 0 || request.ProjectType == MauiProjectType.BlazorHybrid))
            presenter.WriteInfo("Generate only: the selected MAUI setup requires package restore for template/compatibility validation; no build will run.");
        var scaffolder = new NewProjectScaffolder();

        cancellationToken.ThrowIfCancellationRequested();
        if (request.DryRun)
        {
            var planned = scaffolder.Plan(request);
            presenter.WriteInfo(planned.Message);
            if (planned.Plan is not null)
            {
                foreach (var cmd in planned.Plan.CommandsToExecute)
                {
                    presenter.WriteInfo($"  {presenter.SafeText(cmd)}");
                }

                foreach (var file in planned.Plan.FilesToCreate)
                {
                    presenter.WriteInfo($"  + {file}");
                }

                foreach (var file in planned.Plan.FilesToModify)
                {
                    presenter.WriteInfo($"  ~ {file}");
                }

                foreach (var warning in planned.Plan.Warnings)
                {
                    presenter.WriteWarning(warning);
                }
            }

            return planned.ExitCode;
        }

        var progress = new OperationProgress(presenter.NoColor);
        var result = await RunCreationWithProgressAsync(progress, request, presenter.Verbose,
            stages => scaffolder.ExecuteAsync(request, progress: null, cancellationToken, stages)).ConfigureAwait(false);
        ReportNewProjectResult(presenter, request, result);

        return result.ExitCode;
    }

    internal static Task<NewProjectResult> RunCreationWithProgressAsync(
        OperationProgress output, NewProjectRequest request, bool verbose,
        Func<IProgress<string>, Task<NewProjectResult>> operation)
        => output.RunAsync(async detailed =>
        {
            if (verbose)
            {
                output.SetDisplayLabels("Building", "Building project", "✓ Built project", "✗ Build failed.");
                return await operation(detailed).ConfigureAwait(false);
            }
            var grouped = new ProjectCreationProgress(output, request);
            grouped.Initialize();
            var result = await operation(grouped).ConfigureAwait(false);
            grouped.Finish(result.ExitCode == ExitCodes.Success);
            return result;
        });

    // Retain the public seven-step callback contract while hiding steps with no work.
    internal static bool ShouldDisplayProgress(NewProjectRequest request, ProgressStep step) => step.Index switch
    {
        3 or 4 => request.SelectedTemplateIds.Count > 0,
        5 => request.SelectedTemplateIds.Any(id => TemplateCatalog.TryResolveOperableTemplate(id, out var template)
            && template.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)),
        6 => request.Restore && !request.Build && request.SelectedTemplateIds.Count == 0,
        7 => request.Build,
        _ => true,
    };

    private static async Task<int> ExecuteNewJsonAsync(
        ConsolePresenter presenter,
        NewProjectRequest request,
        CancellationToken cancellationToken)
    {
        var scaffolder = new NewProjectScaffolder();
        var result = request.DryRun
            ? scaffolder.Plan(request)
            : await scaffolder.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
        presenter.WriteInfo(DiscoveryService.ToJson(new
        {
            operation = "new",
            projectPath = result.ProjectPath,
            success = result.ExitCode == ExitCodes.Success,
            exitCode = result.ExitCode,
            message = result.Message,
            generationSucceeded = result.GenerationSucceeded,
            buildSucceeded = result.BuildSucceeded,
            rolledBack = result.RolledBack,
            createdFiles = result.CreatedFiles,
            modifiedFiles = result.ModifiedFiles,
            warnings = result.Warnings,
            errorCount = result.Errors.Count,
            errors = result.Errors.Where(error => !string.IsNullOrWhiteSpace(error)).ToArray(),
            buildFramework = request.BuildFramework,
            nextCommands = !request.DryRun && result.GenerationSucceeded && result.ProjectPath is not null
                ? result.ExitCode == ExitCodes.Success
                    ? ProjectNextCommands.Maui(request, result.ProjectPath, result.BuildSucceeded == true)
                    : new[] { MauiPostCreationBuild.DisplayCommand(Path.Combine(result.ProjectPath, $"{request.Name}.csproj"), request.BuildFramework) }
                : Array.Empty<string>(),
            plan = result.Plan is null ? null : new
            {
                result.Plan.FilesToCreate,
                result.Plan.FilesToModify,
                result.Plan.Warnings,
                result.Plan.IsDryRun,
                result.Plan.IsEmpty,
            },
        }));
        if (result.ExitCode != ExitCodes.Success && result.Errors.Count > 0)
        {
            presenter.WriteError(result.GenerationSucceeded ? "Project created successfully, but the build failed. See JSON diagnostics and nextCommands." : "Project creation failed. See JSON diagnostics.");
        }

        return result.ExitCode;
    }

    /// <summary>
    /// Builds a <c>sf new</c> request from the menu's project-creation flow
    /// and confirms it before returning. Returns null when creation is
    /// declined. When the user picks a planned (not yet implemented)
    /// platform, the planned-framework notice is written and
    /// <paramref name="plannedFramework"/> is set; the caller should exit
    /// with the planned notice's exit code (success).
    /// </summary>
    internal static NewProjectRequest? BuildInteractive(
        ConsolePresenter presenter,
        GlobalOptions globals,
        CancellationToken cancellationToken,
        out Framework? plannedFramework, Framework? selectedFramework = null)
    {
        plannedFramework = null;
        using var wizardOutput = ProjectWizardOutput.Begin(Spectre.Console.AnsiConsole.Console, presenter.NoColor);
        var outcome = Build(Create().Parse(selectedFramework is null ? [] : [Frameworks.Name(selectedFramework.Value)]), globals, cancellationToken, presenter, showHeader: false);
        if (!outcome.IsSuccess)
        {
            presenter.WriteError(outcome.Error!);
            return null;
        }
        var request = outcome.Request!;
        if (Frameworks.IsPlanned(request.Framework))
        {
            plannedFramework = request.Framework;
            CommandReporting.ReportPlanned(presenter, request.Framework);
            return null;
        }
        return ReviewNewProject(presenter, request, cancellationToken) ? request : null;
    }

    internal static (string Parent, string Name) AskProjectLocationAndName(
        Framework framework, string? suppliedParent, ConsolePresenter presenter, InteractiveConsoleInput input,
        CancellationToken cancellationToken = default, Func<string, string?>? additionalNameValidation = null)
    {
        var parent = suppliedParent is null
            ? InteractivePrompt.AskOutputPath(Core.Naming.ProjectDefaults.Location(), input, cancellationToken)
            : InteractivePrompt.AskOutputPath(suppliedParent, input, cancellationToken, useSuppliedParent: true);
        var defaultName = Core.Naming.ProjectDefaults.Name(framework, parent);
        var selection = InteractivePrompt.AskProjectNameSelection(presenter, defaultName, input, cancellationToken,
            validateDestination: candidate => additionalNameValidation?.Invoke(candidate) ?? ResolveWizardName(candidate, parent).Error);
        return (parent, selection.Name);
    }

    internal static (string Name, string? Error) ResolveWizardName(string name, string parent)
        => (name, ConflictsAtDestination(name, parent)
            ? $"'{name}' already exists in Project location '{parent}'. Enter a different name:" : null);

    /// <summary>True when a directory or file already exists at <c>&lt;parent&gt;/&lt;name&gt;</c>.</summary>
    private static bool ConflictsAtDestination(string name, string parent)
    {
        var destination = Path.Combine(parent, name);
        return Directory.Exists(destination) || File.Exists(destination);
    }

    private static bool ReviewNewProject(
        ConsolePresenter presenter,
        NewProjectRequest request,
        CancellationToken cancellationToken)
    {
        ProjectWizardOutput.ReuseCompletedSteps(presenter, NewProjectReviewValues(request));

        if (InteractivePrompt.Confirm(
            CreationConfirmation,
            defaultValue: true,
            cancellationToken,
            noColor: presenter.NoColor))
        {
            return true;
        }

        presenter.WriteInfo("Cancelled. No changes made.");
        return false;
    }

    internal const string CreationConfirmation = "Proceed with project creation?";

    internal static IReadOnlyList<string> FormatNewProjectReview(NewProjectRequest request, int? terminalWidth = null)
        => SummaryRows.Format(NewProjectReviewValues(request), terminalWidth, ProjectFlowLayout.ValueColumn);

    private static IReadOnlyList<(string Label, string Value)> NewProjectReviewValues(NewProjectRequest request)
    {
        var projectType = request.ProjectType == MauiProjectType.BlazorHybrid ? ".NET MAUI Blazor Hybrid" : ".NET MAUI App";
        var location = Path.GetFullPath(request.Path);
        var review = new List<(string Label, string Value)>
        {
            ("Action:", "Create a new project"),
            ("Platform:", ".NET MAUI"),
            ("Template:", projectType),
            ("Framework:", InteractivePrompt.FrameworkLabel(request.TargetFramework)),
            ("Project location:", location),
            ("Project name:", request.Name),
        };
        var controls = string.Join(", ", MauiControlSelectionProvider.OrderControls(request.SelectedTemplateIds
            .Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var template)
                ? template
                : throw new InvalidOperationException($"Control '{id}' is not available."))).Select(template => template.DisplayName));
        review.Add(("Setup:", controls.Length == 0 ? "Blank app" : "Include Syncfusion controls"));
        if (controls.Length > 0) review.Add(("Controls:", controls));
        review.Add(("Post-create:", request.Build ? "Build project (all configured targets)" : request.SelectedTemplateIds.Count > 0 || request.ProjectType == MauiProjectType.BlazorHybrid ? "Generate only (restore required for selected setup)" : "Generate only"));
        if (request.Build && !string.IsNullOrWhiteSpace(request.BuildFramework))
        {
            review[^1] = ("Post-create:", $"Build project ({request.BuildFramework})");
        }
        return review;
    }

    internal static void ReportNewProjectResult(ConsolePresenter presenter, NewProjectRequest request, NewProjectResult result)
    {
        foreach (var warning in result.Warnings) presenter.WriteWarning(warning);
        if (result.ExitCode != ExitCodes.Success)
        {
            if (result.GenerationSucceeded)
            {
                presenter.WriteError(result.BuildSucceeded == false ? "Project created, but the build failed." : "Project created, but post-creation validation failed.");
                presenter.WriteInfo($"Project location: {result.ProjectPath}");
                presenter.WriteInfo("The generated project is available for fixing and rebuilding.");
            }
            if (!result.GenerationSucceeded)
            {
                presenter.WriteError("Project creation failed.");
                presenter.WriteInfo(result.RolledBack ? "Changes: tracked changes were rolled back." : "No generated project was committed; review recovery diagnostics with --verbose.");
            }
            presenter.WriteError(ConsoleDiagnostics.Cause(string.Join(Environment.NewLine, result.Errors.Prepend(result.Message))));
            presenter.WriteVerbose(result.Message);
            foreach (var error in result.Errors.Where(error => !string.IsNullOrWhiteSpace(error)).Distinct())
                presenter.WriteError(error);
            if (result.BuildSucceeded == false)
            {
                WriteNextCommands(presenter, request, result, buildInProjectFolder: true);
            }
            return;
        }
        presenter.WriteSuccess($"Project created at {result.ProjectPath}");
        if (request.Build) { presenter.WriteSuccess($"Build succeeded: {request.BuildFramework ?? "all configured targets"}."); }
        else { presenter.WriteInfo("Build: skipped (Generate only)."); }
        if (!request.DryRun && result.ProjectPath is not null)
            ProjectNextCommands.Write(presenter, ProjectNextCommands.Maui(request, result.ProjectPath, result.BuildSucceeded == true));
    }

    private static void WriteNextCommands(ConsolePresenter presenter, NewProjectRequest request, NewProjectResult result,
        bool buildInProjectFolder = false)
    {
        presenter.WriteInfo("Next commands:");
        presenter.WriteInfo($"  cd \"{result.ProjectPath}\"");
        var projectFile = Path.Combine(result.ProjectPath!, $"{request.Name}.csproj");
        if (result.BuildSucceeded != true)
        {
            var command = buildInProjectFolder
                ? "dotnet build" + (string.IsNullOrWhiteSpace(request.BuildFramework) ? "" : $" -f {PathNormalizer.ForDisplay(request.BuildFramework)}")
                : MauiPostCreationBuild.DisplayCommand(projectFile, request.BuildFramework);
            presenter.WriteInfo($"  {command}");
        }
        if (request.SelectedTemplateIds.Count > 0) { presenter.WriteInfo("  sf list maui installed"); }
    }

    private static readonly GlobalOptions _nonInteractiveGlobals = new() { NoInteractive = true };

    private static MauiProjectType ParseProjectType(string? value, out string? error)
    {
        if (string.IsNullOrWhiteSpace(value)) { error = null; return MauiProjectType.App; }
        if (string.Equals(value, "app", StringComparison.OrdinalIgnoreCase)) { error = null; return MauiProjectType.App; }
        // Improvement: .NET MAUI Blazor Hybrid project creation is temporarily disabled.
        // if (string.Equals(value, "blazor-hybrid", StringComparison.OrdinalIgnoreCase)) { error = null; return MauiProjectType.BlazorHybrid; }
        if (string.Equals(value, "blazor-hybrid", StringComparison.OrdinalIgnoreCase))
        {
            error = ".NET MAUI Blazor Hybrid project creation is temporarily disabled. Supported values: app.";
            return default;
        }
        error = $"Unknown project type '{value}'. Supported values: app.";
        return default;
    }
}
