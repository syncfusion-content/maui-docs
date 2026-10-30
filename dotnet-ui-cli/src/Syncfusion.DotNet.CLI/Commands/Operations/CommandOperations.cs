using System.IO;
using System.Text.Json;
using System.Xml;
using Syncfusion.DotNet.Cli.Commands.Reporting;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Maui.Injection;
using Syncfusion.DotNet.Cli.Maui.Manifest;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Commands.Operations;

/// <summary>
/// Runs the package and template workflows shared by direct commands and the
/// interactive menu. Command handlers collect input; this class validates and
/// executes the resulting requests, then reports their outcomes.
/// </summary>
internal static class CommandOperations
{
    internal const string AddControlsConfirmation = "Proceed to add control samples?";
    internal const string AddPackagesConfirmation = "Proceed to add packages?";
    internal const string ControlsReviewLabel = "Controls:";

    public static async Task<int?> ValidateExplicitPackageVersionAsync(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string? version,
        CancellationToken cancellationToken)
    {
        if (version is null)
        {
            return null;
        }

        var result = await new PackageOperationService()
            .ValidateExplicitVersionAsync(version, cancellationToken)
            .ConfigureAwait(false);
        if (result.Success)
        {
            return null;
        }

        var diagnostic = string.Join(
            Environment.NewLine,
            new[] { result.StandardError, result.StandardOutput }
                .Where(output => !string.IsNullOrWhiteSpace(output)))
            .Trim();
        var invalidVersion = diagnostic.Contains("not a valid version string", StringComparison.OrdinalIgnoreCase);
        var message = invalidVersion
            ? $"Package version '{version}' is invalid: {diagnostic}{Environment.NewLine}Use a valid NuGet version, for example '32.1.29', with --version."
            : $"Could not validate package version '{version}' with the .NET CLI: {diagnostic}{Environment.NewLine}Check the .NET SDK installation and retry.";
        if (globals.Json) return WriteFailure(presenter, globals, message);
        presenter.WriteVerbose(diagnostic);
        return WriteFailure(presenter, globals, ConsoleDiagnostics.VersionFailure(version, invalidVersion));
    }

    public static async Task<int> AddPackageAsync(
        ConsolePresenter presenter,
        AddPackageRequest request,
        GlobalOptions globals,
        CancellationToken cancellationToken, bool reviewedExternally = false)
    {
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        if (!PackageCatalog.TryResolve(request.PackageAliasOrId, out var package))
        {
            return Fail(presenter, globals, $"Package '{request.PackageAliasOrId}' was not found. Use 'sfdotnet list maui packages' to see canonical package aliases.");
        }

        if (!package.SupportsPackageReference)
        {
            return Fail(presenter, globals,
                $"Package '{package.PackageId}' is a development tool and cannot be added as an application package reference. Use 'sfdotnet mcp init maui' to configure the MCP server instead. No changes made.");
        }

        var (project, projectError) = ResolveProject(request.Path, globals, cancellationToken, retainSelection: false);
        if (project is null)
        {
            return Fail(presenter, globals, projectError!);
        }

        var reviewed = !reviewedExternally && InteractivePrompt.CanPrompt(globals) && globals.RequiresReview && !request.DryRun;
        if (reviewed)
        {
            ProjectWizardOutput.ReplaceCompletedSteps();
            SummaryRows.Write(presenter, PackageAddReviewValues(request, project, package), ProjectFlowLayout.ValueColumn);
            if (request.Source is not null) presenter.WriteInfo("An explicitly selected package source will be used.");
            if (!InteractivePrompt.Confirm(
                AddPackagesConfirmation,
                defaultValue: true,
                cancellationToken,
                noColor: presenter.NoColor, retainAnswer: true))
            {
                presenter.WriteInfo("Cancelled. No changes made.");
                return ExitCodes.Cancelled;
            }
        }

        var progress = new OperationProgress(presenter.NoColor, globals.Json, showPending: false);
        var result = await RunPackageAddWithProgressAsync(progress, new MauiPackageAddPresentationProvider(project), presenter.Verbose,
            stages => new PackageOperationService().ExecuteAsync(
            project,
            package,
            NuGetOperationKind.Add,
            request.Version,
            noRestore: !request.Restore,
            dryRun: request.DryRun,
            source: request.Source,
            configFile: request.ConfigFile,
            cancellationToken: cancellationToken, build: request.Build, buildFramework: request.BuildFramework, progress: stages)).ConfigureAwait(false);
        if (!globals.Json && result.ExitCode != ExitCodes.Success && !string.IsNullOrWhiteSpace(result.Error))
            presenter.WriteError(result.Error);
        return ReportPackageResult(presenter, globals, result, includeIdentity: !reviewed && !reviewedExternally, labelWidth: ProjectFlowLayout.ValueColumn,
            completionName: reviewedExternally ? InteractiveConsoleInput.FormatPackageChoice(new(package.Alias, package.DisplayName)) : null);
    }

    internal static IReadOnlyList<(string Label, string Value)> PackageAddReviewValues(
        AddPackageRequest request, ProjectDetector.ProjectInfo project, MauiPackageDefinition package)
    {
        var provider = new MauiPackageAddPresentationProvider(project);
        var version = request.Version ?? PackageOperationService.VersionSelectionLabel(package.VersionStrategy).Split(": ", 2)[1];
        return SummaryRows.PackageReview([("Action:", "Add a package to an existing project"), ("Platform:", provider.PlatformName),
            ("Project file:", Path.GetFullPath(project.CsprojPath)), ("Package:", $"{package.DisplayName} ({package.Alias})"),
            ("Version:", version), ("Post-add:", request.Restore ? request.Build ? "Restore and build" : "Restore only" : "No restore")], request.Version);
    }

    internal static Task<PackageOperationResult> RunPackageAddWithProgressAsync(OperationProgress output,
        IPackageAddPresentationProvider provider, bool verbose, Func<IProgress<string>, Task<PackageOperationResult>> operation)
        => output.RunAsync(async detailed =>
        {
            if (verbose) return await operation(detailed).ConfigureAwait(false);
            var grouped = new PackageAddProgress(output, provider);
            var result = await operation(grouped).ConfigureAwait(false);
            grouped.Finish(result.ExitCode == ExitCodes.Success);
            return result;
        });

    internal static async Task<int> AddInteractiveControlsAsync(ConsolePresenter presenter, ProjectDetector.ProjectInfo project,
        GlobalOptions globals, CancellationToken cancellationToken, string? version = null, bool restore = true,
        bool build = true, bool dryRun = false, bool force = false, string? source = null, string? configFile = null,
        string? buildFramework = null, bool promptPostAdd = true, InteractiveConsoleInput? input = null)
    {
        globals.RequiresReview = true;
        using var collecting = ProjectWizardOutput.Begin(Spectre.Console.AnsiConsole.Console, presenter.NoColor);
        input ??= new InteractiveConsoleInput(presenter.NoColor);
        if (!ProjectWizardOutput.HasCompletedValue("Action:")) input.WriteResult("Action", "Add a package to an existing project");
        if (!ProjectWizardOutput.HasCompletedValue("Platform:")) input.WriteResult("Platform", new MauiPackageAddPresentationProvider(project).PlatformName);
        if (!ProjectWizardOutput.HasCompletedValue("Project file:")) input.WriteResult("Project file", Path.GetFullPath(project.CsprojPath));
        var provider = new MauiControlSelectionProvider(project);
        if (provider.Controls.All(control => control.Added))
            presenter.WriteInfo("All available controls are already added to this project.");
        var selected = InteractivePrompt.AskAddControls(provider, presenter.NoColor, cancellationToken, input);
        if (selected.Contains(InteractivePrompt.OtherPackagesId))
        {
            var packages = InteractivePrompt.AskOtherPackages(provider, presenter.NoColor, cancellationToken);
            if (packages.Count == 0) return ExitCodes.Success;
            if (promptPostAdd && restore) build = InteractivePrompt.AskPostAdd(build, presenter.NoColor, cancellationToken);
            ProjectWizardOutput.ReplaceCompletedSteps();
            SummaryRows.Write(presenter, SummaryRows.PackageReview([("Action:", "Add packages to an existing project"),
                ("Platform:", new MauiPackageAddPresentationProvider(project).PlatformName),
                ("Project file:", Path.GetFullPath(project.CsprojPath)),
                ("Packages:", string.Join(", ", provider.Packages.Where(item => packages.Contains(item.Id)).Select(InteractiveConsoleInput.FormatPackageChoice))),
                ("Version:", version ?? "Latest stable"), ("Post-add:", build ? "Restore and build" : restore ? "Restore only" : "Skip restore")], version), ProjectFlowLayout.ValueColumn);
            if (!dryRun && !InteractivePrompt.Confirm(AddPackagesConfirmation, true, cancellationToken, presenter.NoColor, retainAnswer: true))
                return ExitCodes.Cancelled;
            return await RunPackageSelectionAsync(packages, (package, last) => AddPackageAsync(presenter,
                new AddPackageRequest(Framework.Maui, package, project.CsprojPath,
                    version, restore, dryRun, force, source, configFile, build && last, buildFramework),
                globals, cancellationToken, reviewedExternally: true)).ConfigureAwait(false);
        }
        if (!restore) return WriteFailure(presenter, globals, "Control samples require restore. Remove --no-restore.");
        _ = provider.ResolvePackages(selected); // Validate against the same provider catalog; batch installer deduplicates references.
        if (promptPostAdd) build = InteractivePrompt.AskPostAdd(build, presenter.NoColor, cancellationToken);
        return await AddTemplateAsync(presenter, new AddTemplateRequest(Framework.Maui, selected[0], project.CsprojPath,
            version, restore, dryRun, force, source, configFile, selected, build, buildFramework), globals, cancellationToken,
            packageFlow: true).ConfigureAwait(false);
    }

    internal static async Task<int> RunPackageSelectionAsync(IReadOnlyList<string> packages, Func<string, bool, Task<int>> execute)
    {
        var selected = packages.Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
        if (selected.Length == 0) throw new ArgumentException("Select at least one package.", nameof(packages));
        for (var index = 0; index < selected.Length; index++)
        {
            var result = await execute(selected[index], index == selected.Length - 1).ConfigureAwait(false);
            if (result != ExitCodes.Success) return result;
        }
        return ExitCodes.Success;
    }

    internal static IReadOnlyList<(string Label, string Value)> ControlAddReviewValues(AddTemplateRequest request,
        ProjectDetector.ProjectInfo project, IReadOnlyList<ControlCatalogEntry> controls)
        => SummaryRows.PackageReview([("Action:", "Add a package to an existing project"), ("Platform:", new MauiPackageAddPresentationProvider(project).PlatformName),
            ("Project file:", Path.GetFullPath(project.CsprojPath)), ("Controls:", string.Join(", ", MauiControlSelectionProvider.OrderControls(controls).Select(control => control.DisplayName))),
            ("Version:", request.Version ?? "Latest stable"), ("Post-add:", request.Build ? "Restore and build" : "Restore only")], request.Version);

    public static async Task<int> AddTemplateAsync(
        ConsolePresenter presenter,
        AddTemplateRequest request,
        GlobalOptions globals,
        CancellationToken cancellationToken, bool packageFlow = false)
    {
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        var selectedTemplates = request.SelectedTemplateIds
            .Select(templateId => TemplateCatalog.TryResolveOperableTemplate(templateId, out var entry)
                ? entry
                : null)
            .ToList();
        if (selectedTemplates.Count == 0 || selectedTemplates.Any(template => template is null))
        {
            return Fail(presenter, globals, "One or more control IDs are not supported. Run 'sfdotnet help maui' for supported controls.");
        }
        var templates = selectedTemplates.Select(template => template!).ToList();

        var (project, projectError) = ResolveProject(request.Path, globals, cancellationToken, retainSelection: !packageFlow);
        if (project is null)
        {
            return Fail(presenter, globals, projectError!);
        }

        var installer = new ControlInstaller(project);
        var previews = templates.Select(template => installer.PlanAdd(
            template.Id,
            request.Version,
            noRestore: false,
            source: request.Source,
            configFile: request.ConfigFile)).ToList();
        var failedPreview = previews.FirstOrDefault(preview => preview.ExitCode != ExitCodes.Success || preview.Plan is null);
        if (failedPreview is not null)
        {
            return ReportTemplateBatchResult(
                presenter,
                globals,
                project.CsprojPath,
                "add-template",
                templates,
                failedPreview);
        }

        var combinedPlan = new ChangePlan
        {
            ControlId = string.Join(',', templates.Select(template => template.Id)),
            IsDryRun = request.DryRun,
        };
        foreach (var preview in previews.Select(item => item.Plan!))
        {
            AddDistinct(combinedPlan.PackagesToAdd, preview.PackagesToAdd);
            AddDistinct(combinedPlan.FilesToCreate, preview.FilesToCreate);
            AddDistinct(combinedPlan.FilesToModify, preview.FilesToModify);
            AddDistinct(combinedPlan.CommandsToExecute, preview.CommandsToExecute);
        }
        if (InteractivePrompt.CanPrompt(globals) && globals.RequiresReview && !request.DryRun)
        {
            if (packageFlow)
            {
                ProjectWizardOutput.ReplaceCompletedSteps();
                SummaryRows.Write(presenter, ControlAddReviewValues(request, project, templates), ProjectFlowLayout.ValueColumn);
            }
            else
            {
                presenter.WriteSelected($"Project: {project.CsprojPath}");
                presenter.WriteSelected($"{ControlsReviewLabel} {string.Join(", ", MauiControlSelectionProvider.OrderControls(templates).Select(template => template.DisplayName))}");
                presenter.WriteSelected($"Required packages: {string.Join(", ", templates.Select(template => template.PackageId).Distinct(StringComparer.OrdinalIgnoreCase))}");
                presenter.WriteSelected(request.Build ? request.BuildFramework is null
                    ? "Build: all configured targets" : $"Build target: {request.BuildFramework}" : "Build: not requested");
                presenter.WriteSelected(request.Version is null
                    ? "Syncfusion version: Latest compatible stable"
                    : $"Syncfusion version: {request.Version}");
                if (request.Source is not null)
                {
                    presenter.WriteInfo("An explicitly selected package source will be used.");
                }
                var projectRoot = Path.GetDirectoryName(project.CsprojPath)!;
                var registrationWillChange = templates.Any(template =>
                    template.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase))
                    && MauiProgramPatcher.WouldModifyRegistration(projectRoot);
                presenter.WriteSelected($"Registration changes: {registrationWillChange}");
                presenter.WriteSelected($"Generated files: {combinedPlan.FilesToCreate.Count}");

            }
            if (!InteractivePrompt.Confirm(
                packageFlow ? AddPackagesConfirmation : AddControlsConfirmation,
                defaultValue: !request.Force,
                cancellationToken,
                noColor: presenter.NoColor, retainAnswer: true))
            {
                presenter.WriteInfo("Cancelled. No changes made.");
                return ExitCodes.Cancelled;
            }
        }

        if (request.DryRun)
        {
            return ReportTemplateBatchResult(presenter, globals, project.CsprojPath, "add-template", templates,
                new ControlOperationResult
                {
                    ExitCode = ExitCodes.Success,
                    Message = $"Dry run: would apply {templates.Count} control(s).",
                    Plan = combinedPlan,
                });
        }

        var progress = new OperationProgress(presenter.NoColor, globals.Json, showPending: !packageFlow);
        async Task<ControlOperationResult> Execute(IProgress<string> stages) => await installer.ExecuteAddBatchAsync(
            templates.Select(template => template.Id).ToList(),
            request.Version,
            request.Source,
            request.ConfigFile,
            request.Force,
            request.DryRun,
            deferBuild: !request.Build,
            cancellationToken: cancellationToken,
            buildFramework: request.BuildFramework, progress: stages).ConfigureAwait(false);
        var result = await progress.RunAsync(async stages =>
        {
            if (!packageFlow || presenter.Verbose) return await Execute(stages).ConfigureAwait(false);
            var grouped = new PackageAddProgress(progress, new MauiPackageAddPresentationProvider(project));
            var outcome = await Execute(grouped).ConfigureAwait(false);
            grouped.Finish(outcome.ExitCode == ExitCodes.Success);
            return outcome;
        }).ConfigureAwait(false);
        if (packageFlow && !globals.Json && result.ExitCode != ExitCodes.Success)
            foreach (var error in result.Errors.Where(error => !string.IsNullOrWhiteSpace(error))) presenter.WriteError(error);
        return ReportTemplateBatchResult(presenter, globals, project.CsprojPath, "add-template", templates, result, includeIdentity: !packageFlow);
    }

    public static async Task<int> RemovePackageAsync(
        ConsolePresenter presenter,
        RemovePackageRequest request,
        GlobalOptions globals,
        CancellationToken cancellationToken)
    {
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        var (project, installedPackages, installedError) = GetInstalledPackages(
            request.Path,
            globals,
            cancellationToken);
        if (project is null)
        {
            return Fail(presenter, globals, installedError!);
        }

        if (!TryResolveInstalledPackage(request.PackageAliasOrId, installedPackages, out var packageAlias, out var packageId))
        {
            if (PackageCatalog.TryResolve(request.PackageAliasOrId, out var absent))
                return ReportPackageResult(presenter, globals, new PackageOperationResult(project.CsprojPath,
                    absent.Alias, absent.PackageId, "remove", ExitCodes.Success,
                    $"Package '{absent.Alias}' is not installed. Nothing to remove. No changes made. No rebuild required.", string.Empty, string.Empty));
            return Fail(presenter, globals, $"Package '{request.PackageAliasOrId}' is not an installed direct Syncfusion MAUI package reference.");
        }

        var installedPackage = installedPackages.First(package =>
            package.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase));
        if (InteractivePrompt.CanPrompt(globals) && globals.RequiresReview && !request.DryRun)
        {
            presenter.WriteSelected($"Project: {project.CsprojPath}");
            presenter.WriteInfo($"Installed package: {packageAlias ?? packageId} ({installedPackage.Version ?? "version not specified"})");
            presenter.WriteSelected($"Restore after changes: {!request.NoRestore}");
            if (!InteractivePrompt.Confirm(
                "Proceed to remove packages?",
                defaultValue: false,
                cancellationToken,
                noColor: presenter.NoColor))
            {
                presenter.WriteInfo("Cancelled. No changes made.");
                return ExitCodes.Cancelled;
            }
        }

        var progress = new OperationProgress(presenter.NoColor, globals.Json);
        var result = await progress.RunAsync(stages => new PackageOperationService().ExecuteAsync(
            project,
            packageAlias,
            packageId,
            NuGetOperationKind.Remove,
            noRestore: request.NoRestore,
            dryRun: request.DryRun,
            source: request.Source,
            configFile: request.ConfigFile,
            cancellationToken: cancellationToken, buildRemoval: request.Build, buildFramework: request.BuildFramework, progress: stages)).ConfigureAwait(false);
        return ReportPackageResult(presenter, globals, result);
    }

    public static async Task<int> RemoveTemplateAsync(
        ConsolePresenter presenter,
        RemoveTemplateRequest request,
        GlobalOptions globals,
        CancellationToken cancellationToken)
    {
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        var legacyIds = request.SelectedTemplateIds
            .Where(LegacyUnsupportedTemplateCatalog.Contains)
            .ToList();
        if (legacyIds.Count > 0)
        {
            if (legacyIds.Count != request.SelectedTemplateIds.Count)
            {
                return Fail(
                    presenter,
                    globals,
                    "Remove legacy unsupported templates separately from available templates.");
            }

            var (legacyProject, legacyProjectError) = ResolveProject(request.Path, globals, cancellationToken);
            if (legacyProject is null)
            {
                return Fail(presenter, globals, legacyProjectError!);
            }

            var legacyRemover = new LegacyTemplateRemovalService(legacyProject);
            var plannedRemoval = legacyRemover.PlanRemove(legacyIds, request.DryRun);
            if (plannedRemoval.ExitCode != ExitCodes.Success || plannedRemoval.Plan is null)
            {
                return ReportLegacyTemplateRemovalResult(
                    presenter, globals, legacyProject.CsprojPath, legacyIds, plannedRemoval);
            }

            if (request.DryRun)
            {
                return ReportLegacyTemplateRemovalResult(
                    presenter,
                    globals,
                    legacyProject.CsprojPath,
                    legacyIds,
                    new ControlOperationResult
                    {
                        ExitCode = ExitCodes.Success,
                        Message = $"Dry run: would remove {legacyIds.Count} legacy unsupported control(s).",
                        Plan = plannedRemoval.Plan,
                    });
            }

            if (InteractivePrompt.CanPrompt(globals) && globals.RequiresReview)
            {
                presenter.WriteSelected($"Project: {legacyProject.CsprojPath}");
                presenter.WriteInfo($"Installed controls: {string.Join(", ", legacyIds)}");
                presenter.WriteInfo($"Owned files to remove: {plannedRemoval.Plan.FilesToDelete.Count}");
                presenter.WriteInfo("Packages and shared registration will be preserved.");
                if (!InteractivePrompt.Confirm(
                    "Proceed to remove control samples?",
                    defaultValue: false,
                    cancellationToken,
                    noColor: presenter.NoColor))
                {
                    presenter.WriteInfo("Cancelled. No changes made.");
                    return ExitCodes.Cancelled;
                }
            }

            cancellationToken.ThrowIfCancellationRequested();
            var legacyProgress = new OperationProgress(presenter.NoColor, globals.Json);
            var legacyResult = await legacyProgress.RunAsync(stages => Task.FromResult(legacyRemover.ExecuteRemove(legacyIds, progress: stages))).ConfigureAwait(false);
            return ReportLegacyTemplateRemovalResult(
                presenter, globals, legacyProject.CsprojPath, legacyIds, legacyResult);
        }

        var templates = request.SelectedTemplateIds
            .Select(templateId => TemplateCatalog.TryResolveOperableTemplate(templateId, out var entry)
                ? entry
                : null)
            .ToList();
        if (templates.Count == 0 || templates.Any(template => template is null))
        {
            return Fail(presenter, globals, "One or more control IDs are not supported. Run 'sfdotnet help maui' for supported controls.");
        }
        var selectedTemplates = templates.Select(template => template!).ToList();

        var (project, projectError) = ResolveProject(request.Path, globals, cancellationToken);
        if (project is null)
        {
            return Fail(presenter, globals, projectError!);
        }

        var installer = new ControlInstaller(project);
        var batchPlan = installer.PlanRemoveBatch(
            selectedTemplates.Select(template => template.Id).ToList(),
            dryRun: request.DryRun,
            noRestore: request.NoRestore,
            source: request.Source,
            configFile: request.ConfigFile,
            force: request.Force);

        if (batchPlan.ExitCode != ExitCodes.Success || batchPlan.Plan is null)
        {
            return ReportTemplateBatchResult(presenter, globals, project.CsprojPath, "remove-template", selectedTemplates, batchPlan);
        }
        var combinedPlan = batchPlan.Plan;

        if (request.DryRun)
        {
            return ReportTemplateBatchResult(presenter, globals, project.CsprojPath, "remove-template", selectedTemplates,
                new ControlOperationResult { ExitCode = ExitCodes.Success, Message = $"Dry run: would remove {selectedTemplates.Count} control(s).", Plan = combinedPlan });
        }

        if (InteractivePrompt.CanPrompt(globals) && globals.RequiresReview)
        {
            presenter.WriteSelected($"Project: {project.CsprojPath}");
            presenter.WriteInfo($"Installed controls: {string.Join(", ", selectedTemplates.Select(template => template.DisplayName))}");
            presenter.WriteInfo($"Owned files to remove: {combinedPlan.FilesToDelete.Count}");
            var retainedPackages = selectedTemplates
                .SelectMany(template => template.DependentPackageIds.Prepend(template.PackageId))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Except(combinedPlan.PackagesToRemove, StringComparer.OrdinalIgnoreCase)
                .ToList();
            if (retainedPackages.Count > 0)
            {
                presenter.WriteInfo($"Shared packages preserved: {string.Join(", ", retainedPackages)}");
            }

            presenter.WriteInfo(combinedPlan.FilesToModify.Contains("MauiProgram.cs", StringComparer.OrdinalIgnoreCase)
                ? "Registration will be updated."
                : "Shared registration will be preserved.");

            if (!InteractivePrompt.Confirm(
                "Proceed to remove control samples?",
                defaultValue: false,
                cancellationToken,
                noColor: presenter.NoColor))
            {
                presenter.WriteInfo("Cancelled. No changes made.");
                return ExitCodes.Cancelled;
            }
        }

        var progress = new OperationProgress(presenter.NoColor, globals.Json);
        var removal = await progress.RunAsync(stages => installer.ExecuteRemoveBatchAsync(
            selectedTemplates.Select(template => template.Id).ToList(), request.NoRestore,
            request.Source, request.ConfigFile, cancellationToken, request.Build, request.BuildFramework, stages)).ConfigureAwait(false);
        return ReportTemplateBatchResult(presenter, globals, project.CsprojPath, "remove-template", selectedTemplates, removal);
    }

    public static async Task<int> UpdatePackageAsync(
        ConsolePresenter presenter,
        UpdatePackageRequest request,
        GlobalOptions globals,
        CancellationToken cancellationToken)
    {
        presenter.ProtectNuGetConfiguration(request.Source, request.ConfigFile);
        var (project, installedPackages, installedError) = GetInstalledPackages(
            request.Path,
            globals,
            cancellationToken);
        if (project is null)
        {
            return Fail(presenter, globals, installedError!);
        }

        if (!TryResolveInstalledPackage(request.PackageAliasOrId, installedPackages, out var packageAlias, out var packageId))
        {
            return Fail(presenter, globals, $"Package '{request.PackageAliasOrId}' is not an installed direct Syncfusion MAUI package reference.");
        }

        var installedPackage = installedPackages.First(package =>
            package.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase));
        if (InteractivePrompt.CanPrompt(globals) && globals.RequiresReview && !request.DryRun)
        {
            presenter.WriteSelected($"Project: {project.CsprojPath}");
            presenter.WriteInfo($"Installed package: {packageAlias ?? packageId}");
            presenter.WriteInfo($"Current version: {installedPackage.Version ?? "not specified"}");
            if (request.Version is not null)
            {
                presenter.WriteSelected(PackageOperationService.RequestedVersionLabel(request.Version));
            }
            else if (PackageCatalog.TryResolve(packageId, out var package))
            {
                presenter.WriteInfo(PackageOperationService.VersionStrategyLabel(package.VersionStrategy));
            }
            else
            {
                presenter.WriteInfo("Version strategy: Latest stable release");
            }
            if (request.Source is not null)
            {
                presenter.WriteInfo("An explicitly selected package source will be used.");
            }
            presenter.WriteSelected($"Restore after changes: {request.Restore}");

            if (!InteractivePrompt.Confirm(
                "Proceed to update packages?",
                defaultValue: true,
                cancellationToken,
                noColor: presenter.NoColor))
            {
                presenter.WriteInfo("Cancelled. No changes made.");
                return ExitCodes.Cancelled;
            }
        }

        var progress = new OperationProgress(presenter.NoColor, globals.Json);
        var result = await progress.RunAsync(stages => new PackageOperationService().ExecuteAsync(
            project,
            packageAlias,
            packageId,
            NuGetOperationKind.Add,
            request.Version,
            noRestore: !request.Restore,
            dryRun: request.DryRun,
            source: request.Source,
            configFile: request.ConfigFile,
            cancellationToken: cancellationToken,
            update: true, progress: stages)).ConfigureAwait(false);
        return ReportPackageResult(presenter, globals, result);
    }

    public static int WriteFailure(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string message,
        int exitCode = ExitCodes.Error)
        => Fail(presenter, globals, message, exitCode);

    public static (ProjectDetector.ProjectInfo? Project, IReadOnlyList<DiscoveryService.InstalledPackage> Packages, string? Error)
        GetInstalledPackages(
            string path,
            GlobalOptions globals,
            CancellationToken cancellationToken = default)
    {
        var (project, projectError) = ResolveProject(path, globals, cancellationToken);
        if (project is null)
        {
            return (null, [], projectError);
        }

        try
        {
            return (project, DiscoveryService.ListInstalledPackages(project.CsprojPath), null);
        }
        catch (Exception exception) when (exception is IOException
            or UnauthorizedAccessException
            or InvalidOperationException
            or XmlException)
        {
            return (null, [], $"Could not read installed package references: {exception.Message}");
        }
    }

    public static (ProjectDetector.ProjectInfo? Project, IReadOnlyList<InstalledTemplateRecord> Templates, string? Error)
        GetInstalledTemplates(
            string path,
            GlobalOptions globals,
            CancellationToken cancellationToken = default)
    {
        var (project, projectError) = ResolveProject(path, globals, cancellationToken);
        if (project is null)
        {
            return (null, [], projectError);
        }

        var manifestPath = Path.Combine(
            Path.GetDirectoryName(project.CsprojPath)!,
            "Syncfusion",
            "syncfusion.json");
        if (!File.Exists(manifestPath))
        {
            return (project, [], null);
        }

        try
        {
            var manifest = WelcomeProjectGenerator.ReadManifest(Path.GetDirectoryName(project.CsprojPath)!, project);
            if (manifest is null) return (project, [], null);
            var templates = manifest.InstalledTemplates
                .Where(template => TemplateCatalog.TryResolveOperableTemplate(template.Id, out _)
                    || LegacyUnsupportedTemplateCatalog.Contains(template.Id))
                .GroupBy(template => template.Id, StringComparer.OrdinalIgnoreCase)
                .Select(group => group.First())
                .OrderBy(template => template.Id, StringComparer.OrdinalIgnoreCase)
                .ToList();
            return (project, templates, null);
        }
        catch (Exception exception) when (exception is IOException
            or UnauthorizedAccessException
            or InvalidOperationException
            or JsonException)
        {
            return (null, [], $"Could not read installed template records: {exception.Message}");
        }
    }

    public static int ReportPackageResult(
        ConsolePresenter presenter,
        GlobalOptions globals,
        PackageOperationResult result, bool includeIdentity = true, int? labelWidth = null, string? completionName = null)
    {
        if (globals.Json)
        {
            var payload = new Dictionary<string, object?>
            {
                ["projectPath"] = result.ProjectPath,
                ["packageAlias"] = result.Alias,
                ["packageId"] = result.PackageId,
                ["operation"] = result.Operation,
                ["success"] = result.ExitCode == ExitCodes.Success,
                ["exitCode"] = result.ExitCode,
                ["message"] = result.Message,
                ["error"] = result.Error,
                ["packageChangesSucceeded"] = result.PackageChangesSucceeded,
                ["sampleGenerationSucceeded"] = result.SampleGenerationSucceeded,
                ["buildSucceeded"] = result.BuildSucceeded,
            };
            if (result.ResolvedVersion is not null)
            {
                payload["resolvedVersion"] = result.ResolvedVersion;
            }

            presenter.WriteInfo(DiscoveryService.ToJson(payload));
        }
        else if (result.ExitCode == ExitCodes.Success)
        {
            var rows = new List<(string Label, string Value)>
            {
                ("Project:", result.ProjectPath),
                ("Package:", result.Alias is null ? result.PackageId : $"{result.Alias} ({result.PackageId})"),
            };
            if (!includeIdentity) rows.Clear();
            else if (result.ResolvedVersion is not null) rows.Add(("Resolved version:", result.ResolvedVersion));
            var completedOperation = result.Operation switch { "add" => "added", "update" => "updated", "remove" => "removed", _ => "operation completed" };
            CompletionSummary.Write(presenter, completionName is null ? $"Package {result.Operation} completed." : $"{completionName}: package {completedOperation}.", rows, result.Message,
                labelWidth: labelWidth ?? (includeIdentity ? null : ProjectFlowLayout.ValueColumn));
        }
        else
        {
            ConsoleDiagnostics.Failure(presenter, $"Package {result.Operation} failed.", result.Message,
                [result.Error], rollbackAttempted: result.PackageChangesSucceeded == false
                    || result.Message.StartsWith($"Package {result.Operation} failed for ", StringComparison.Ordinal));
        }

        presenter.WriteVerbose(result.Command);
        if ((globals.Json || result.ExitCode == ExitCodes.Success) && !string.IsNullOrWhiteSpace(result.Error))
        {
            presenter.WriteVerbose(result.Error);
        }

        return result.ExitCode;
    }

    private static void AddDistinct(ICollection<string> target, IEnumerable<string> values)
    {
        foreach (var value in values)
        {
            if (!target.Contains(value, StringComparer.OrdinalIgnoreCase))
            {
                target.Add(value);
            }
        }
    }

    private static int ReportTemplateBatchResult(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string projectPath,
        string operation,
        IReadOnlyList<ControlCatalogEntry> templates,
        ControlOperationResult result, bool includeIdentity = true)
    {
        if (globals.Json)
        {
            presenter.WriteInfo(JsonSerializer.Serialize(new
            {
                projectPath,
                operation,
                templateId = templates.Count == 1 ? templates[0].Id : null,
                requiredPackageId = templates.Count == 1 ? templates[0].PackageId : null,
                templates = templates.Select(template => new
                {
                    templateId = template.Id,
                    templateFamily = template.Family,
                    displayName = template.DisplayName,
                    controlIdentity = template.ControlIdentity,
                    requiredPackageId = template.PackageId,
                }),
                success = result.ExitCode == ExitCodes.Success,
                exitCode = result.ExitCode,
                message = result.Message,
                errors = result.Errors,
                packageChangesSucceeded = result.PackageChangesSucceeded,
                sampleGenerationSucceeded = result.SampleGenerationSucceeded,
                buildSucceeded = result.BuildSucceeded,
                plan = result.Plan is null ? null : new
                {
                    result.Plan.ControlId,
                    result.Plan.PackagesToAdd,
                    result.Plan.PackagesToRemove,
                    result.Plan.FilesToCreate,
                    result.Plan.FilesToModify,
                    result.Plan.FilesToDelete,
                    result.Plan.Warnings,
                    result.Plan.IsDryRun,
                    result.Plan.IsEmpty,
                },
            }));
        }
        else if (result.ExitCode == ExitCodes.Success)
        {
            CompletionSummary.Write(presenter, operation == "add-template" ? "Control add completed." : "Control remove completed.",
                includeIdentity ? [("Project:", projectPath), ("Controls:", string.Join(", ", MauiControlSelectionProvider.OrderControls(templates).Select(template => template.DisplayName)))] : [],
                result.Message, result.Plan?.Warnings, labelWidth: includeIdentity ? null : ProjectFlowLayout.ValueColumn);
        }
        else
        {
            ConsoleDiagnostics.Failure(presenter, operation == "add-template" ? "Control add failed." : "Control remove failed.",
                result.Message, result.Errors, rollbackAttempted: result.PackageChangesSucceeded == false);
        }

        if (globals.Json) foreach (var error in result.Errors) presenter.WriteVerbose(error);

        return result.ExitCode;
    }

    private static int ReportLegacyTemplateRemovalResult(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string projectPath,
        IReadOnlyList<string> templateIds,
        ControlOperationResult result, bool includeIdentity = true)
    {
        if (globals.Json)
        {
            presenter.WriteInfo(JsonSerializer.Serialize(new
            {
                projectPath,
                operation = "remove-template",
                templateIds,
                success = result.ExitCode == ExitCodes.Success,
                exitCode = result.ExitCode,
                message = result.Message,
                plan = result.Plan is null ? null : new
                {
                    result.Plan.ControlId,
                    result.Plan.PackagesToAdd,
                    result.Plan.PackagesToRemove,
                    result.Plan.FilesToCreate,
                    result.Plan.FilesToModify,
                    result.Plan.FilesToDelete,
                    result.Plan.Warnings,
                    result.Plan.IsDryRun,
                    result.Plan.IsEmpty,
                },
            }));
        }
        else if (result.ExitCode == ExitCodes.Success)
        {
            CompletionSummary.Write(presenter, "Control remove completed.", [("Project:", projectPath), ("Controls:", string.Join(", ", templateIds))], result.Message, result.Plan?.Warnings);
        }
        else
        {
            presenter.WriteError(result.Message);
        }

        return result.ExitCode;
    }

    private static int ReportTemplateResult(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string projectPath,
        string operation,
        ControlCatalogEntry template,
        ControlOperationResult result, bool includeIdentity = true)
    {
        if (globals.Json)
        {
            presenter.WriteInfo(JsonSerializer.Serialize(new
            {
                projectPath,
                templateId = template.Id,
                templateFamily = template.Family,
                controlIdentity = template.ControlIdentity,
                requiredPackageId = template.PackageId,
                operation,
                success = result.ExitCode == ExitCodes.Success,
                exitCode = result.ExitCode,
                message = result.Message,
                errorCount = result.Errors.Count,
                plan = result.Plan is null ? null : new
                {
                    result.Plan.ControlId,
                    result.Plan.PackagesToAdd,
                    result.Plan.PackagesToRemove,
                    result.Plan.FilesToCreate,
                    result.Plan.FilesToModify,
                    result.Plan.FilesToDelete,
                    result.Plan.Warnings,
                    result.Plan.IsDryRun,
                    result.Plan.IsEmpty,
                },
            }));
        }
        else if (result.ExitCode == ExitCodes.Success)
        {
            presenter.WriteInfo(result.Message);
        }
        else
        {
            presenter.WriteError(result.Message);
        }

        if (result.Plan is not null)
        {
            foreach (var command in result.Plan.CommandsToExecute)
            {
                if (globals.Json)
                {
                    continue;
                }

                if (result.Plan.IsDryRun)
                {
                    presenter.WriteInfo($"  package operation for {template.PackageId} (NuGet source/config values hidden)");
                }
                else
                {
                    presenter.WriteVerbose($"package operation for {template.PackageId} (NuGet source/config values hidden)");
                }
            }

            foreach (var file in result.Plan.FilesToCreate)
            {
                presenter.WriteVerbose($"created {file}");
            }

            foreach (var file in result.Plan.FilesToModify)
            {
                presenter.WriteVerbose($"modified {file}");
            }

            foreach (var warning in result.Plan.Warnings)
            {
                presenter.WriteWarning(warning);
            }
        }

        foreach (var error in result.Errors)
        {
            if (!string.IsNullOrWhiteSpace(error))
            {
                presenter.WriteVerbose(error);
            }
        }

        return result.ExitCode;
    }

    private static bool TryResolveInstalledPackage(
        string packageAliasOrId,
        IReadOnlyList<DiscoveryService.InstalledPackage> installedPackages,
        out string? alias,
        out string packageId)
    {
        alias = null;
        packageId = string.Empty;
        if (PackageCatalog.TryResolve(packageAliasOrId, out var catalogPackage))
        {
            var installed = installedPackages.FirstOrDefault(package =>
                package.PackageId.Equals(catalogPackage.PackageId, StringComparison.OrdinalIgnoreCase));
            if (installed is null)
            {
                return false;
            }

            alias = catalogPackage.Alias;
            packageId = catalogPackage.PackageId;
            return true;
        }

        var directPackage = installedPackages.FirstOrDefault(package =>
            package.PackageId.Equals(packageAliasOrId, StringComparison.OrdinalIgnoreCase));
        if (directPackage is null || !packageAliasOrId.StartsWith("Syncfusion.Maui.", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        alias = directPackage.Alias;
        packageId = directPackage.PackageId;
        return true;
    }

    private static (
        ProjectDetector.ProjectInfo? Project,
        string? Error) ResolveProject(
            string path,
            GlobalOptions globals,
            CancellationToken cancellationToken = default, bool retainSelection = true)
    {
        try
        {
            var project = MauiProjectResolver.Resolve(
                path,
                InteractivePrompt.CanPrompt(globals)
                    ? projects =>
                    {
                        globals.RequiresReview |= projects.Count > 1;
                        return InteractivePrompt.SelectMauiProject(projects, cancellationToken, retainSelection);
                    }
            : null);
            return (project, null);
        }

        catch (Exception exception) when (exception is IOException
            or InvalidOperationException
            or UnauthorizedAccessException)
        {
            return (null, exception.Message);
        }
    }

    public static (ProjectDetector.ProjectInfo? Project, string? Error) ResolveProjectForPrompt(
        string path,
        GlobalOptions globals,
        CancellationToken cancellationToken = default, bool retainSelection = true)
        => ResolveProject(path, globals, cancellationToken, retainSelection);

    private static int Fail(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string message,
        int exitCode = ExitCodes.Error)
    {
        if (globals.Json)
        {
            presenter.WriteInfo(DiscoveryService.ToJson(new
            {
                success = false,
                exitCode,
                error = message,
            }));
        }
        else
        {
            presenter.WriteError(message);
        }

        return exitCode;
    }
}
