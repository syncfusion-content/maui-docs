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

/// <summary>Defines the <c>sf update</c> package command.</summary>
public static class UpdateCommand
{
    internal const string PackageArg = "package";
    internal const string FrameworkArg = "framework";

    public static Command Create()
    {
        var packageArg = CommandOptions.OptionalArg(PackageArg, "The canonical package alias or package ID.");
        var frameworkArg = CommandOptions.OptionalArg(FrameworkArg, "The platform: maui, blazor, wpf, winforms or winui.");
        var command = new Command("update", "Update a Syncfusion package.");
        command.Add(packageArg);
        command.Add(frameworkArg);
        command.Add(CommandOptions.PathOption);
        command.Add(CommandOptions.VersionOption);
        command.Add(CommandOptions.FrameworkOption);
        command.Add(CommandOptions.SourceOption);
        command.Add(CommandOptions.ConfigFileOption);
        command.Add(CommandOptions.DryRunOption);
        command.Add(CommandOptions.ForceOption);
        command.Add(CommandOptions.NoRestoreOption);
        command.Add(CommandOptions.BuildOption);
        command.SetAction(async (parseResult, cancellationToken) =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parseResult);
            var globals = GlobalsHelper.Bind(parseResult);
            if (DesktopCommands.Provider(parseResult, PackageArg, FrameworkArg) is { } desktop)
                return await DesktopCommands.PackageAsync(parseResult, "update", globals, presenter, desktop, cancellationToken).ConfigureAwait(false);
            var versionValidationExit = await CommandOperations.ValidateExplicitPackageVersionAsync(
                presenter,
                globals,
                parseResult.GetValue(CommandOptions.VersionOption),
                cancellationToken).ConfigureAwait(false);
            if (versionValidationExit is { } versionExit)
            {
                return versionExit;
            }

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

            var packageAlias = primarySyntax ? second : first;
            var suppliedPath = parseResult.GetValue(CommandOptions.PathOption);
            string? selectedProjectPath = null;
            if (string.IsNullOrWhiteSpace(packageAlias) && !string.IsNullOrWhiteSpace(suppliedPath))
            {
                var (project, error) = CommandOperations.ResolveProjectForPrompt(
                    PathNormalizer.Normalize(suppliedPath),
                    globals,
                    cancellationToken);
                if (project is null)
                {
                    return CommandOperations.WriteFailure(presenter, globals, error!);
                }

                selectedProjectPath = project.CsprojPath;
            }

            var outcome = Build(parseResult, globals, selectedProjectPath, cancellationToken);
            if (!outcome.IsSuccess)
            {
                return CommandOperations.WriteFailure(presenter, globals, outcome.Error!, outcome.ExitCode);
            }

            return await CommandOperations.UpdatePackageAsync(
                presenter,
                outcome.Request!,
                globals,
                cancellationToken).ConfigureAwait(false);
        });
        return command;
    }

    public static ParseOutcome<UpdatePackageRequest> Build(
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
            return ParseOutcome<UpdatePackageRequest>.Fail(explicitFrameworkError);
        }

        if (!string.IsNullOrWhiteSpace(packageAlias)
            && (string.IsNullOrWhiteSpace(frameworkValue)
                || string.Equals(frameworkValue, "maui", StringComparison.OrdinalIgnoreCase))
            && !PackageCatalog.TryResolve(packageAlias, out _)
            && !packageAlias.StartsWith("Syncfusion.Maui.", StringComparison.OrdinalIgnoreCase))
        {
            return ParseOutcome<UpdatePackageRequest>.Fail(
                $"Package '{packageAlias}' was not found. Use 'sf list maui packages' to see canonical package aliases.");
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
                return ParseOutcome<UpdatePackageRequest>.Fail(error!);
            }

            if (installedPackages.Count == 0)
            {
                return ParseOutcome<UpdatePackageRequest>.Fail("No installed packages are available to update.");
            }

            packageAlias = InteractivePrompt.AskInstalledPackage(
                "Which installed packages would you like to update?",
                installedPackages,
                cancellationToken);
            path = project.CsprojPath;
        }

        if (string.IsNullOrWhiteSpace(packageAlias))
        {
            return ParseOutcome<UpdatePackageRequest>.Fail("A package is required. Example: 'sf update maui datagrid'.");
        }

        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption),
            globals,
            cancellationToken);
        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<UpdatePackageRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        if (frameworkOutcome.Request == Framework.Maui)
        {
            if (PackageCatalog.TryResolve(packageAlias, out var package))
            {
                packageAlias = package.Alias;
            }
            else if (!packageAlias.StartsWith("Syncfusion.Maui.", StringComparison.OrdinalIgnoreCase))
            {
                return ParseOutcome<UpdatePackageRequest>.Fail(
                    $"Package '{packageAlias}' was not found. Use 'sf list maui packages' to see canonical package aliases.");
            }
        }

        return ParseOutcome<UpdatePackageRequest>.Ok(new UpdatePackageRequest(
            frameworkOutcome.Request!,
            packageAlias,
            path,
            parseResult.GetValue(CommandOptions.VersionOption),
            Restore: !parseResult.GetValue(CommandOptions.NoRestoreOption),
            DryRun: parseResult.GetValue(CommandOptions.DryRunOption),
            Force: parseResult.GetValue(CommandOptions.ForceOption),
            Source: parseResult.GetValue(CommandOptions.SourceOption),
            ConfigFile: parseResult.GetValue(CommandOptions.ConfigFileOption)));
    }

    public static ParseOutcome<UpdatePackageRequest> Parse(ParseResult parseResult)
        => Build(parseResult, _nonInteractiveGlobals);

    private static readonly GlobalOptions _nonInteractiveGlobals = new() { NoInteractive = true };
}
