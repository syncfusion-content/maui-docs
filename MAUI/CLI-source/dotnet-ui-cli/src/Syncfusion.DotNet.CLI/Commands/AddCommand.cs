using Syncfusion.DotNet.CLI.Commands.Desktop;
using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Commands.Options;
using Syncfusion.DotNet.CLI.Commands.Parsing;
using Syncfusion.DotNet.CLI.Commands.Reporting;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Syncfusion.DotNet.CLI.Wizard;

namespace Syncfusion.DotNet.CLI.Commands;

/// <summary>Defines the <c>sf add</c> command.</summary>
public static class AddCommand
{
    internal const string PackageArg = "package";
    internal const string FrameworkArg = "framework";

    public static Command Create()
    {
        var packageArg = CommandOptions.OptionalArg(PackageArg, "The canonical package alias or package ID.");
        var frameworkArg = CommandOptions.OptionalArg(FrameworkArg, "The platform: maui, blazor, wpf, winforms or winui.");
        var command = new Command("add", "Add a Syncfusion package.");
        command.Add(packageArg);
        command.Add(frameworkArg);
        command.Add(CommandOptions.TemplateOption);
        command.Add(CommandOptions.ControlOption);
        command.Add(CommandOptions.PathOption);
        command.Add(CommandOptions.VersionOption);
        command.Add(CommandOptions.FrameworkOption);
        command.Add(CommandOptions.SourceOption);
        command.Add(CommandOptions.ConfigFileOption);
        command.Add(CommandOptions.DryRunOption);
        command.Add(CommandOptions.ForceOption);
        command.Add(CommandOptions.NoRestoreOption);
        command.Add(CommandOptions.BuildOption);
        command.Add(CommandOptions.NoBuildOption);
        command.Add(CommandOptions.BuildFrameworkOption);
        command.SetAction(async (parseResult, cancellationToken) =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parseResult);
            var globals = GlobalsHelper.Bind(parseResult);
            if (DesktopCommands.Provider(parseResult, PackageArg, FrameworkArg) is { } desktop)
                return await DesktopCommands.PackageAsync(parseResult, "add", globals, presenter, desktop, cancellationToken).ConfigureAwait(false);
            using var wizardOutput = InteractivePrompt.CanPrompt(globals)
                ? ProjectWizardOutput.Begin(Spectre.Console.AnsiConsole.Console, presenter.NoColor) : null;
            var versionValidationExit = await CommandOperations.ValidateExplicitPackageVersionAsync(
                presenter,
                globals,
                parseResult.GetValue(CommandOptions.VersionOption),
                cancellationToken).ConfigureAwait(false);
            if (versionValidationExit is { } versionExit)
            {
                return versionExit;
            }

            var templateValues = CommandOptions.GetTemplateValues(parseResult);
            var templateOptionPresent = parseResult.GetResult(CommandOptions.TemplateOption) is not null
                || parseResult.GetResult(CommandOptions.ControlOption) is not null;
            var first = parseResult.GetValue<string?>(PackageArg);
            var second = parseResult.GetValue<string?>(FrameworkArg);
            var primarySyntax = string.Equals(first, "maui", StringComparison.OrdinalIgnoreCase);
            var frameworkValue = primarySyntax || string.Equals(second, "maui", StringComparison.OrdinalIgnoreCase)
                ? "maui"
                : second;
            var frameworkError = FrameworkResolver.ValidateExplicit(
                frameworkValue,
                parseResult.GetValue(CommandOptions.FrameworkOption));
            if (frameworkError is not null)
            {
                return CommandOperations.WriteFailure(presenter, globals, frameworkError);
            }

            var hasTarget = !string.IsNullOrWhiteSpace(primarySyntax ? second : first);
            var interactiveAdd = !hasTarget
                && !templateOptionPresent
                && InteractivePrompt.CanPrompt(globals);
            ProjectDetector.ProjectInfo? selectedProject = null;
            var target = primarySyntax ? second : first;
            var isTemplate = templateOptionPresent || !PackageCatalog.TryResolve(target, out _)
                && TemplateCatalog.TryResolveOperableTemplate(target, out _);
            var needsProjectForCompletion = !hasTarget
                && (!templateOptionPresent || templateValues.Count == 0);
            var suppliedPath = parseResult.GetValue(CommandOptions.PathOption);
            if (needsProjectForCompletion && !string.IsNullOrWhiteSpace(suppliedPath))
            {
                var (project, error) = CommandOperations.ResolveProjectForPrompt(
                    PathNormalizer.Normalize(suppliedPath),
                    globals,
                    cancellationToken, retainSelection: false);
                if (project is null)
                {
                    return CommandOperations.WriteFailure(presenter, globals, error!);
                }

                selectedProject = project;
            }

            if (interactiveAdd)
            {
                globals.RequiresReview = true;
                if (selectedProject is null)
                {
                    var (project, error) = CommandOperations.ResolveProjectForPrompt(
                        PathNormalizer.Normalize(null),
                        globals,
                        cancellationToken, retainSelection: false);
                    if (project is null)
                    {
                        return CommandOperations.WriteFailure(presenter, globals, error!);
                    }

                    selectedProject = project;
                }

                return await CommandOperations.AddInteractiveControlsAsync(presenter, selectedProject, globals, cancellationToken,
                    version: parseResult.GetValue(CommandOptions.VersionOption),
                    restore: !parseResult.GetValue(CommandOptions.NoRestoreOption),
                    build: !parseResult.GetValue(CommandOptions.NoBuildOption),
                    dryRun: parseResult.GetValue(CommandOptions.DryRunOption),
                    force: parseResult.GetValue(CommandOptions.ForceOption),
                    source: parseResult.GetValue(CommandOptions.SourceOption),
                    configFile: parseResult.GetValue(CommandOptions.ConfigFileOption),
                    buildFramework: parseResult.GetValue(CommandOptions.BuildFrameworkOption), promptPostAdd: false).ConfigureAwait(false);
            }
            else if (templateOptionPresent
                && templateValues.Count == 0
                && !hasTarget
                && selectedProject is null
                && InteractivePrompt.CanPrompt(globals))
            {
                globals.RequiresReview = true;
                var (project, error) = CommandOperations.ResolveProjectForPrompt(
                    PathNormalizer.Normalize(parseResult.GetValue(CommandOptions.PathOption)),
                    globals,
                    cancellationToken, retainSelection: false);
                if (project is null)
                {
                    return CommandOperations.WriteFailure(presenter, globals, error!);
                }

                selectedProject = project;
            }

            if (isTemplate)
            {
                var templateOutcome = BuildTemplate(parseResult, globals, cancellationToken);
                if (!templateOutcome.IsSuccess)
                {
                    return CommandOperations.WriteFailure(presenter, globals, templateOutcome.Error!, templateOutcome.ExitCode);
                }

                var request = selectedProject is null
                    ? templateOutcome.Request!
                    : templateOutcome.Request! with { Path = selectedProject.CsprojPath };
                return await CommandOperations.AddTemplateAsync(
                    presenter,
                    request,
                    globals,
                    cancellationToken).ConfigureAwait(false);
            }

            var packageOutcome = Build(parseResult, globals, cancellationToken);
            if (!packageOutcome.IsSuccess)
            {
                return CommandOperations.WriteFailure(presenter, globals, packageOutcome.Error!, packageOutcome.ExitCode);
            }

            var packageRequest = selectedProject is null
                ? packageOutcome.Request!
                : packageOutcome.Request! with { Path = selectedProject.CsprojPath };
            return await CommandOperations.AddPackageAsync(
                presenter,
                packageRequest,
                globals,
                cancellationToken).ConfigureAwait(false);
        });
        return command;
    }

    public static ParseOutcome<AddPackageRequest> Build(
        ParseResult parseResult,
        GlobalOptions globals,
        CancellationToken cancellationToken = default)
    {
        var first = parseResult.GetValue<string?>(PackageArg);
        var second = parseResult.GetValue<string?>(FrameworkArg);
        var primarySyntax = string.Equals(first, "maui", StringComparison.OrdinalIgnoreCase);
        var legacySyntax = string.Equals(second, "maui", StringComparison.OrdinalIgnoreCase);
        var frameworkValue = primarySyntax || legacySyntax ? "maui" : second;
        var packageAlias = primarySyntax ? second : first;

        var explicitFrameworkError = FrameworkResolver.ValidateExplicit(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption));
        if (explicitFrameworkError is not null)
        {
            return ParseOutcome<AddPackageRequest>.Fail(explicitFrameworkError);
        }

        if (CommandOptions.GetTemplateValues(parseResult).Count > 0)
        {
            return ParseOutcome<AddPackageRequest>.Fail(
                "A package target cannot be combined with a control selection.");
        }

        if (!string.IsNullOrWhiteSpace(packageAlias)
            && (string.IsNullOrWhiteSpace(frameworkValue)
                || string.Equals(frameworkValue, "maui", StringComparison.OrdinalIgnoreCase)))
        {
            if (!PackageCatalog.TryResolve(packageAlias, out var package))
            {
                var guidance = packageAlias.Equals("combobox", StringComparison.OrdinalIgnoreCase)
                    ? " Add the containing NuGet package with the 'inputs' package alias."
                    : string.Empty;
                return ParseOutcome<AddPackageRequest>.Fail(
                    $"Package '{packageAlias}' was not found.{guidance} Use 'sf list maui packages' to see canonical package aliases.");
            }

            packageAlias = package.Alias;
        }

        if (string.IsNullOrWhiteSpace(packageAlias) && InteractivePrompt.CanPrompt(globals))
        {
            globals.RequiresReview = true;
            packageAlias = InteractivePrompt.AskPackage(PackageCatalog.Recommended, cancellationToken);
        }

        if (string.IsNullOrWhiteSpace(packageAlias))
        {
            return ParseOutcome<AddPackageRequest>.Fail("A package is required. Example: 'sf add maui inputs'.");
        }

        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption),
            globals,
            cancellationToken);
        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<AddPackageRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        return ParseOutcome<AddPackageRequest>.Ok(new AddPackageRequest(
            frameworkOutcome.Request!,
            packageAlias,
            PathNormalizer.Normalize(parseResult.GetValue(CommandOptions.PathOption)),
            parseResult.GetValue(CommandOptions.VersionOption),
            Restore: !parseResult.GetValue(CommandOptions.NoRestoreOption),
            DryRun: parseResult.GetValue(CommandOptions.DryRunOption),
            Force: parseResult.GetValue(CommandOptions.ForceOption),
            Source: parseResult.GetValue(CommandOptions.SourceOption),
            ConfigFile: parseResult.GetValue(CommandOptions.ConfigFileOption),
            Build: !parseResult.GetValue(CommandOptions.NoBuildOption),
            BuildFramework: parseResult.GetValue(CommandOptions.BuildFrameworkOption)));
    }

    public static ParseOutcome<AddTemplateRequest> BuildTemplate(
        ParseResult parseResult,
        GlobalOptions globals,
        CancellationToken cancellationToken = default)
    {
        var first = parseResult.GetValue<string?>(PackageArg);
        var second = parseResult.GetValue<string?>(FrameworkArg);
        var primarySyntax = string.Equals(first, "maui", StringComparison.OrdinalIgnoreCase);
        var frameworkValue = primarySyntax || string.Equals(second, "maui", StringComparison.OrdinalIgnoreCase)
            ? "maui"
            : second;
        var positionalTarget = primarySyntax ? second : first;
        var explicitFrameworkError = FrameworkResolver.ValidateExplicit(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption));
        if (explicitFrameworkError is not null)
        {
            return ParseOutcome<AddTemplateRequest>.Fail(explicitFrameworkError);
        }

        IReadOnlyList<string> templateIds = CommandOptions.GetTemplateValues(parseResult);
        if (parseResult.GetResult(CommandOptions.ControlOption) is not null && parseResult.GetResult(CommandOptions.TemplateOption) is not null)
            return ParseOutcome<AddTemplateRequest>.Fail("Use either --control or --template, not both.");
        if (!string.IsNullOrWhiteSpace(positionalTarget))
        {
            if (templateIds.Count == 0 && !PackageCatalog.TryResolve(positionalTarget, out _)
                && TemplateCatalog.TryResolveOperableTemplate(positionalTarget, out var control)) templateIds = [control.Id];
            else return ParseOutcome<AddTemplateRequest>.Fail("A package target cannot be combined with a control selection.");
        }
        if (templateIds.Count == 0 && InteractivePrompt.CanPrompt(globals))
        {
            globals.RequiresReview = true;
            templateIds = InteractivePrompt.AskTemplates(cancellationToken);
        }

        if (!TemplateSelection.TryNormalize(
            templateIds,
            allowEmpty: false,
            syntax: "sf add maui --template <template-id> [template-id ...]",
            out var canonicalIds,
            out var selectionError))
        {
            return ParseOutcome<AddTemplateRequest>.Fail(selectionError!);
        }

        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption),
            globals,
            cancellationToken);
        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<AddTemplateRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        return ParseOutcome<AddTemplateRequest>.Ok(new AddTemplateRequest(
            frameworkOutcome.Request!,
            canonicalIds[0],
            PathNormalizer.Normalize(parseResult.GetValue(CommandOptions.PathOption)),
            parseResult.GetValue(CommandOptions.VersionOption),
            Restore: !parseResult.GetValue(CommandOptions.NoRestoreOption),
            DryRun: parseResult.GetValue(CommandOptions.DryRunOption),
            Force: parseResult.GetValue(CommandOptions.ForceOption),
            Source: parseResult.GetValue(CommandOptions.SourceOption),
            ConfigFile: parseResult.GetValue(CommandOptions.ConfigFileOption),
            TemplateIds: canonicalIds,
            Build: !parseResult.GetValue(CommandOptions.NoBuildOption),
            BuildFramework: parseResult.GetValue(CommandOptions.BuildFrameworkOption)));
    }

    public static ParseOutcome<AddPackageRequest> Parse(ParseResult parseResult)
        => Build(parseResult, _nonInteractiveGlobals);

    private static readonly GlobalOptions _nonInteractiveGlobals = new() { NoInteractive = true };
}
