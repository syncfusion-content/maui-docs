using Syncfusion.DotNet.Cli.Commands.Desktop;
using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.Cli.Commands.Operations;
using Syncfusion.DotNet.Cli.Commands.Options;
using Syncfusion.DotNet.Cli.Commands.Parsing;
using Syncfusion.DotNet.Cli.Commands.Reporting;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Commands;

/// <summary>Defines the <c>sfdotnet remove</c> command.</summary>
public static class RemoveCommand
{
    internal const string PackageArg = "package";
    internal const string FrameworkArg = "framework";

    public static Command Create()
    {
        var packageArg = CommandOptions.OptionalArg(PackageArg, "The canonical package alias or package ID.");
        var frameworkArg = CommandOptions.OptionalArg(FrameworkArg, "The platform: maui, blazor, wpf, winforms or winui.");
        var command = new Command("remove", "Remove a Syncfusion package.");
        command.Add(packageArg);
        command.Add(frameworkArg);
        command.Add(CommandOptions.TemplateOption);
        command.Add(CommandOptions.ControlOption);
        command.Add(CommandOptions.PathOption);
        command.Add(CommandOptions.FrameworkOption);
        command.Add(CommandOptions.DryRunOption);
        command.Add(CommandOptions.ForceOption);
        command.Add(CommandOptions.SourceOption);
        command.Add(CommandOptions.ConfigFileOption);
        command.Add(CommandOptions.NoRestoreOption);
        command.Add(CommandOptions.BuildOption);
        command.Add(CommandOptions.BuildFrameworkOption);
        // Improvement: Remove package from existing project is temporarily disabled for all platforms.
        // command.SetAction(async (parseResult, cancellationToken) =>
        // {
        //     var presenter = GlobalsHelper.CreatePresenter(parseResult);
        //     var globals = GlobalsHelper.Bind(parseResult);
        //     if (DesktopCommands.Provider(parseResult, PackageArg, FrameworkArg) is { } desktop)
        //         return await DesktopCommands.PackageAsync(parseResult, "remove", globals, presenter, desktop, cancellationToken).ConfigureAwait(false);
        //     var isTemplate = parseResult.GetResult(CommandOptions.TemplateOption) is not null
        //         || parseResult.GetResult(CommandOptions.ControlOption) is not null;
        //     var first = parseResult.GetValue<string?>(PackageArg);
        //     var second = parseResult.GetValue<string?>(FrameworkArg);
        //     var primarySyntax = string.Equals(first, "maui", StringComparison.OrdinalIgnoreCase);
        //     var frameworkValue = primarySyntax || string.Equals(second, "maui", StringComparison.OrdinalIgnoreCase)
        //         ? "maui"
        //         : second;
        //     var frameworkError = FrameworkResolver.ValidateExplicit(
        //         frameworkValue,
        //         parseResult.GetValue(CommandOptions.FrameworkOption));
        //     if (frameworkError is not null)
        //     {
        //         return CommandOperations.WriteFailure(presenter, globals, frameworkError);
        //     }
        //
        //     var target = primarySyntax ? second : first;
        //     isTemplate |= !PackageCatalog.TryResolve(target, out _) && TemplateCatalog.TryResolveOperableTemplate(target, out _);
        //     var hasTarget = !string.IsNullOrWhiteSpace(primarySyntax ? second : first);
        //     string? selectedProjectPath = null;
        //     var suppliedPath = parseResult.GetValue(CommandOptions.PathOption);
        //     if (!hasTarget
        //         && !string.IsNullOrWhiteSpace(suppliedPath))
        //     {
        //         var (project, error) = CommandOperations.ResolveProjectForPrompt(
        //             PathNormalizer.Normalize(suppliedPath),
        //             globals,
        //             cancellationToken);
        //         if (project is null)
        //         {
        //             return CommandOperations.WriteFailure(presenter, globals, error!);
        //         }
        //
        //         selectedProjectPath = project.CsprojPath;
        //     }
        //
        //     if (!isTemplate && !hasTarget && InteractivePrompt.CanPrompt(globals))
        //     {
        //         globals.RequiresReview = true;
        //         isTemplate = InteractivePrompt.AskTemplateOperation("remove", cancellationToken);
        //     }
        //
        //     if (isTemplate)
        //     {
        //         var templateOutcome = BuildTemplate(parseResult, globals, selectedProjectPath, cancellationToken);
        //         if (!templateOutcome.IsSuccess)
        //         {
        //             return CommandOperations.WriteFailure(presenter, globals, templateOutcome.Error!, templateOutcome.ExitCode);
        //         }
        //
        //         return await CommandOperations.RemoveTemplateAsync(
        //             presenter,
        //             templateOutcome.Request!,
        //             globals,
        //             cancellationToken).ConfigureAwait(false);
        //     }
        //
        //     var packageOutcome = Build(parseResult, globals, selectedProjectPath, cancellationToken);
        //     if (!packageOutcome.IsSuccess)
        //     {
        //         return CommandOperations.WriteFailure(presenter, globals, packageOutcome.Error!, packageOutcome.ExitCode);
        //     }
        //
        //     return await CommandOperations.RemovePackageAsync(
        //         presenter,
        //         packageOutcome.Request!,
        //         globals,
        //         cancellationToken).ConfigureAwait(false);
        // });
        command.SetAction(_ =>
        {
            Console.Error.WriteLine("Package removal is temporarily unavailable while improvements are in progress.");
            return ExitCodes.Error;
        });
        return command;
    }

    public static ParseOutcome<RemovePackageRequest> Build(
        ParseResult parseResult,
        GlobalOptions globals,
        string? selectedProjectPath = null,
        CancellationToken cancellationToken = default)
    {
        var first = parseResult.GetValue<string?>(PackageArg);
        var second = parseResult.GetValue<string?>(FrameworkArg);
        var primarySyntax = string.Equals(first, "maui", StringComparison.OrdinalIgnoreCase);
        var frameworkValue = primarySyntax || string.Equals(second, "maui", StringComparison.OrdinalIgnoreCase)
            ? "maui"
            : second;
        var packageAlias = primarySyntax ? second : first;
        var path = selectedProjectPath ?? PathNormalizer.Normalize(parseResult.GetValue(CommandOptions.PathOption));

        var explicitFrameworkError = FrameworkResolver.ValidateExplicit(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption));
        if (explicitFrameworkError is not null)
        {
            return ParseOutcome<RemovePackageRequest>.Fail(explicitFrameworkError);
        }

        if (CommandOptions.GetTemplateValues(parseResult).Count > 0)
        {
            return ParseOutcome<RemovePackageRequest>.Fail(
                "A package target cannot be combined with a control selection.");
        }

        if (!string.IsNullOrWhiteSpace(packageAlias)
            && (string.IsNullOrWhiteSpace(frameworkValue)
                || string.Equals(frameworkValue, "maui", StringComparison.OrdinalIgnoreCase))
            && !PackageCatalog.TryResolve(packageAlias, out _)
            && !packageAlias.StartsWith("Syncfusion.Maui.", StringComparison.OrdinalIgnoreCase))
        {
            return ParseOutcome<RemovePackageRequest>.Fail(
                $"Package '{packageAlias}' was not found. Use 'sfdotnet list maui packages' to see canonical package aliases.");
        }

        if (string.IsNullOrWhiteSpace(packageAlias) && InteractivePrompt.CanPrompt(globals))
        {
            globals.RequiresReview = true;
            var (project, installedPackages, error) = CommandOperations.GetInstalledPackages(
                path,
                globals,
                cancellationToken);
            if (project is null)
            {
                return ParseOutcome<RemovePackageRequest>.Fail(error!);
            }

            if (installedPackages.Count == 0)
            {
                return ParseOutcome<RemovePackageRequest>.Fail("No installed packages are available to remove.");
            }

            packageAlias = InteractivePrompt.AskInstalledPackage(
                "Which installed packages would you like to remove?",
                installedPackages,
                cancellationToken);
            path = project.CsprojPath;
        }

        if (string.IsNullOrWhiteSpace(packageAlias))
        {
            return ParseOutcome<RemovePackageRequest>.Fail("A package is required. Example: 'sfdotnet remove maui datagrid'.");
        }

        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption),
            globals,
            cancellationToken);
        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<RemovePackageRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        if (frameworkOutcome.Request == Framework.Maui)
        {
            if (PackageCatalog.TryResolve(packageAlias, out var package))
            {
                packageAlias = package.Alias;
            }
            else if (!packageAlias.StartsWith("Syncfusion.Maui.", StringComparison.OrdinalIgnoreCase))
            {
                return ParseOutcome<RemovePackageRequest>.Fail(
                    $"Package '{packageAlias}' was not found. Use 'sfdotnet list maui packages' to see canonical package aliases.");
            }
        }

        return ParseOutcome<RemovePackageRequest>.Ok(new RemovePackageRequest(
            frameworkOutcome.Request!,
            packageAlias,
            path,
            DryRun: parseResult.GetValue(CommandOptions.DryRunOption),
            Force: parseResult.GetValue(CommandOptions.ForceOption),
            NoRestore: parseResult.GetValue(CommandOptions.NoRestoreOption),
            Source: parseResult.GetValue(CommandOptions.SourceOption),
            ConfigFile: parseResult.GetValue(CommandOptions.ConfigFileOption),
            Build: parseResult.GetValue(CommandOptions.BuildOption) || parseResult.GetResult(CommandOptions.BuildFrameworkOption) is not null,
            BuildFramework: parseResult.GetValue(CommandOptions.BuildFrameworkOption)));
    }

    public static ParseOutcome<RemoveTemplateRequest> BuildTemplate(
        ParseResult parseResult,
        GlobalOptions globals,
        string? selectedProjectPath = null,
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
            return ParseOutcome<RemoveTemplateRequest>.Fail(explicitFrameworkError);
        }

        IReadOnlyList<string> templateIds = CommandOptions.GetTemplateValues(parseResult);
        if (parseResult.GetResult(CommandOptions.ControlOption) is not null && parseResult.GetResult(CommandOptions.TemplateOption) is not null)
            return ParseOutcome<RemoveTemplateRequest>.Fail("Use either --control or --template, not both.");
        if (!string.IsNullOrWhiteSpace(positionalTarget))
        {
            if (templateIds.Count == 0 && !PackageCatalog.TryResolve(positionalTarget, out _)
                && TemplateCatalog.TryResolveOperableTemplate(positionalTarget, out var control)) templateIds = [control.Id];
            else return ParseOutcome<RemoveTemplateRequest>.Fail("A package target cannot be combined with a control selection.");
        }
        var path = selectedProjectPath ?? PathNormalizer.Normalize(parseResult.GetValue(CommandOptions.PathOption));
        if (templateIds.Count == 0 && InteractivePrompt.CanPrompt(globals))
        {
            globals.RequiresReview = true;
            var (project, installed, error) = CommandOperations.GetInstalledTemplates(
                path,
                globals,
                cancellationToken);
            if (project is null)
            {
                return ParseOutcome<RemoveTemplateRequest>.Fail(error!);
            }

            if (installed.Count == 0)
            {
                return ParseOutcome<RemoveTemplateRequest>.Fail("No installed controls are available to remove.");
            }

            path = project.CsprojPath;
            templateIds = InteractivePrompt.AskInstalledTemplates(installed, cancellationToken);
        }

        if (!TemplateSelection.TryNormalizeForRemoval(
            templateIds,
            syntax: "sfdotnet remove maui --template <template-id> [template-id ...]",
            out var canonicalIds,
            out var selectionError))
        {
            return ParseOutcome<RemoveTemplateRequest>.Fail(selectionError!);
        }

        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption),
            globals,
            cancellationToken);
        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<RemoveTemplateRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        return ParseOutcome<RemoveTemplateRequest>.Ok(new RemoveTemplateRequest(
            frameworkOutcome.Request!,
            canonicalIds[0],
            path,
            DryRun: parseResult.GetValue(CommandOptions.DryRunOption),
            Force: parseResult.GetValue(CommandOptions.ForceOption),
            NoRestore: parseResult.GetValue(CommandOptions.NoRestoreOption),
            Source: parseResult.GetValue(CommandOptions.SourceOption),
            ConfigFile: parseResult.GetValue(CommandOptions.ConfigFileOption),
            TemplateIds: canonicalIds,
            Build: parseResult.GetValue(CommandOptions.BuildOption) || parseResult.GetResult(CommandOptions.BuildFrameworkOption) is not null,
            BuildFramework: parseResult.GetValue(CommandOptions.BuildFrameworkOption)));
    }

    public static ParseOutcome<RemovePackageRequest> Parse(ParseResult parseResult)
        => Build(parseResult, _nonInteractiveGlobals);

    private static readonly GlobalOptions _nonInteractiveGlobals = new() { NoInteractive = true };
}
