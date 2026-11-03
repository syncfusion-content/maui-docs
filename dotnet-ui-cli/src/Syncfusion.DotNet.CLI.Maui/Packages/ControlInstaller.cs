using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Maui.Injection;
using Syncfusion.DotNet.Cli.Maui.Manifest;
using static Syncfusion.DotNet.Cli.Core.NuGetSources;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>
/// The result of planning or executing a control add/remove/update operation.
/// </summary>
public sealed class ControlOperationResult
{
    public required int ExitCode { get; init; }
    public required string Message { get; init; }
    public ChangePlan? Plan { get; init; }
    public IReadOnlyList<string> Errors { get; init; } = [];
    public bool? PackageChangesSucceeded { get; init; }
    public bool? SampleGenerationSucceeded { get; init; }
    public bool? BuildSucceeded { get; init; }
}

/// <summary>
/// Builds and executes the add/remove/update flow for a Syncfusion MAUI control.
/// This is the Phase 3 entry point that ties the catalog, embedded templates,
/// placeholder replacement, NuGet operations, the manifest, and rollback
/// together. The command handlers call <see cref="PlanAdd"/>/<see cref="PlanRemove"/>
/// to build a <see cref="ChangePlan"/> (for --dry-run or preview), and
/// <see cref="ExecuteAddAsync"/>/<see cref="ExecuteRemoveAsync"/> to apply it.
/// </summary>
public sealed class ControlInstaller
{
    private readonly NuGetRunner _nuget;
    private readonly DotNetRunner _dotnet;
    private readonly string _projectRoot;
    private readonly string _csprojPath;
    private readonly ProjectDetector.ProjectInfo _project;
    private IReadOnlyList<string> _targetFrameworks;
    private readonly List<GeneratedBlockRecord> _pendingBlocks = [];
    private readonly Dictionary<string, string> _pendingSharedFiles = [];
    private readonly HashSet<string> _pendingWelcomeFiles = [];

    /// <summary>Constructs an installer for a given project root or .csproj path.</summary>
    public ControlInstaller(string projectRootOrCsproj, NuGetRunner? nuget = null, DotNetRunner? dotnet = null)
        : this(MauiProjectResolver.Resolve(projectRootOrCsproj), nuget, dotnet)
    {
    }

    /// <summary>Constructs an installer using a project already resolved by the shared resolver.</summary>
    public ControlInstaller(ProjectDetector.ProjectInfo project, NuGetRunner? nuget = null, DotNetRunner? dotnet = null)
    {
        _nuget = nuget ?? new NuGetRunner();
        _dotnet = dotnet ?? new DotNetRunner();
        var info = MauiProjectResolver.ValidateMauiProject(project);
        _project = info;
        _projectRoot = Path.GetDirectoryName(info.CsprojPath)!;
        _csprojPath = info.CsprojPath;
        _targetFrameworks = info.TargetFrameworks;
    }

    /// <summary>The resolved project root directory.</summary>
    public string ProjectRoot => _projectRoot;

    /// <summary>The resolved .csproj path.</summary>
    public string CsprojPath => _csprojPath;

    /// <summary>
    /// Returns a clear failure result when <paramref name="entry"/> is a
    /// preview/coming-soon control whose metadata has not been verified.
    /// This blocks the installer from writing unverified package ids, XAML
    /// namespaces, or registration calls into a customer project.
    /// </summary>
    private static ControlOperationResult? VerifyEntry(ControlCatalogEntry entry)
    {
        if (!entry.Verified)
        {
            return Fail($"Control '{entry.Id}' is not verified and is not supported by this CLI release.");
        }

        if (!entry.RegistrationVerified
            || string.IsNullOrWhiteSpace(entry.RegistrationEvidence)
            || (entry.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)
                && (string.IsNullOrWhiteSpace(entry.RegistrationUsing) || string.IsNullOrWhiteSpace(entry.RegistrationCall)))
            || (!entry.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)
                && !entry.RegistrationRequirement.Equals("none", StringComparison.OrdinalIgnoreCase)))
        {
            return Fail($"Control '{entry.Id}' cannot be applied because its required registration metadata is unresolved or unsupported.");
        }

        return null;
    }

    private static bool IsTemplateInstalled(SyncfusionManifest? manifest, ControlCatalogEntry template)
        => manifest?.InstalledControls.Any(installedId =>
            TemplateCatalog.TryResolve(installedId, out var installedTemplate)
            && installedTemplate.Id.Equals(template.Id, StringComparison.OrdinalIgnoreCase)) == true;

    /// <summary>
    /// Builds a change plan for adding <paramref name="controlId"/> without
    /// touching the filesystem. Used for <c>--dry-run</c> and preview output.
    /// Returns a failure result when the control is not in the catalog.
    /// </summary>
    public ControlOperationResult PlanAdd(
        string controlId,
        string? version = null,
        bool noRestore = false,
        bool dryRun = false,
        string? source = null,
        string? configFile = null)
    {
        if (!TemplateCatalog.TryResolveOperableTemplate(controlId, out var entry))
        {
            return Fail($"Control '{controlId}' is not supported. Supported controls: {string.Join(", ", AllControlIds())}.");
        }

        if (ValidateLiteralTargetFrameworks() is { } frameworkError)
        {
            return Fail(frameworkError);
        }

        if (VerifyEntry(entry) is { } unverified)
        {
            return unverified;
        }

        var (manifest, readError) = TryReadManifest();
        if (readError is not null) return Fail(readError);
        if (ValidateGeneratedState(manifest, [entry]) is { } conflict) return Fail(conflict);
        if (IsTemplateInstalled(manifest, entry) && AllGeneratedFilesPresentAndUnmodified(entry, manifest!))
        {
            if (version is not null && manifest!.PackageVersions.GetValueOrDefault(entry.PackageId) != version)
                return Fail($"Control '{entry.Id}' is already installed with a different package version. Use the package update command.");
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success, Message = $"'{entry.Id}' is already installed. No changes made.",
                Plan = new ChangePlan { ControlId = entry.Id, IsDryRun = dryRun },
            };
        }

        if (noRestore && !dryRun)
        {
            return Fail($"Cannot establish package/control compatibility for '{entry.Id}' with --no-restore. Remove --no-restore and retry.");
        }

        var plan = BuildAddPlan(entry, version, noRestore, dryRun, source, configFile);
        return new ControlOperationResult
        {
            ExitCode = ExitCodes.Success,
            Message = dryRun
                ? $"Planned add of '{entry.Id}'. No changes made (--dry-run)."
                : $"Planned add of '{entry.Id}'.",
            Plan = plan,
        };
    }

    /// <summary>
    /// Builds a change plan for removing <paramref name="controlId"/> without
    /// touching the filesystem. Used for <c>--dry-run</c> and preview output.
    /// </summary>
    public ControlOperationResult PlanRemove(
        string controlId,
        bool dryRun = false,
        bool noRestore = false,
        string? source = null,
        string? configFile = null,
        bool force = false)
    {
        _ = force;
        return new ControlRemovalService(_project, _nuget).Plan([controlId], dryRun, noRestore, source, configFile);
    }

    /// <summary>
    /// Builds one removal plan for a batch, evaluating package and registration
    /// ownership against the templates that will remain after the whole batch.
    /// </summary>
    public ControlOperationResult PlanRemoveBatch(
        IReadOnlyList<string> templateIds,
        bool dryRun = false,
        bool noRestore = false,
        string? source = null,
        string? configFile = null,
        bool force = false)
    {
        _ = force;
        return new ControlRemovalService(_project, _nuget).Plan(templateIds, dryRun, noRestore, source, configFile);
    }

    /// <summary>
    /// Validates package and target-framework compatibility, adds the NuGet
    /// package, generates the template files, validates the generated build,
    /// and commits the manifest only after success. Restores tracked project
    /// state on failure.
    /// </summary>
    public async Task<ControlOperationResult> ExecuteAddAsync(
        string controlId,
        string? version = null,
        bool noRestore = false,
        bool dryRun = false,
        string? source = null,
        string? configFile = null,
        bool force = false,
        CancellationToken cancellationToken = default, IProgress<string>? progress = null)
    {
        if (noRestore && !dryRun)
            return Fail("Cannot establish package/control compatibility with --no-restore. Remove --no-restore and retry.");
        return await ExecuteAddBatchAsync([controlId], version, source, configFile, force, dryRun,
            cancellationToken: cancellationToken, progress: progress).ConfigureAwait(false);
    }

    public async Task<ControlOperationResult> ExecuteAddBatchAsync(
        IReadOnlyList<string> templateIds,
        string? version = null,
        string? source = null,
        string? configFile = null,
        bool force = false,
        bool dryRun = false,
        bool deferBuild = false,
        CancellationToken cancellationToken = default,
        string? buildFramework = null, IProgress<string>? progress = null)
    {
        ArgumentNullException.ThrowIfNull(templateIds);
        var entries = new List<ControlCatalogEntry>(templateIds.Count);
        foreach (var templateId in templateIds)
        {
            if (!TemplateCatalog.TryResolveOperableTemplate(templateId, out var entry))
            {
                return Fail($"Control '{templateId}' is not supported. Available controls: {string.Join(", ", AllVerifiedControlIds())}.");
            }

            if (VerifyEntry(entry) is { } verificationError)
            {
                return verificationError;
            }

            if (entries.Any(existing => existing.Id.Equals(entry.Id, StringComparison.OrdinalIgnoreCase)))
            {
                return Fail($"Control '{entry.Id}' was selected more than once. Remove duplicate control IDs and retry.");
            }

            entries.Add(entry);
        }

        if (entries.Count == 0)
        {
            return Fail("At least one control ID is required.");
        }

        var centralPackageMode = false;
        string? centralPropsPath = null;
        if (!dryRun)
        {
            var evaluationError = await ResolveTargetFrameworksAsync(cancellationToken).ConfigureAwait(false);
            if (evaluationError is not null)
            {
                return Fail(evaluationError);
            }

            var centralPackage = await ResolveCentralPackageModeAsync(cancellationToken).ConfigureAwait(false);
            if (centralPackage.Error is not null)
            {
                return Fail(centralPackage.Error);
            }

            centralPackageMode = centralPackage.Enabled;
            centralPropsPath = centralPackage.PropsPath;
        }

        if (ValidateTargetFrameworks() is { } frameworkError)
        {
            return Fail(frameworkError);
        }
        if (!deferBuild && !string.IsNullOrWhiteSpace(buildFramework)
            && !_targetFrameworks.Contains(buildFramework.Trim(), StringComparer.OrdinalIgnoreCase))
            return Fail($"Build framework '{buildFramework.Trim()}' is not enabled in '{_csprojPath}' on this OS. Configured targets: {string.Join(", ", _targetFrameworks)}. No changes made.");

        var combinedPlan = new ChangePlan
        {
            ControlId = string.Join(',', entries.Select(entry => entry.Id)),
            IsDryRun = dryRun,
        };
        foreach (var entry in entries)
        {
            var plan = BuildAddPlan(entry, version, noRestore: false, dryRun, source, configFile);
            AddDistinct(combinedPlan.PackagesToAdd, plan.PackagesToAdd);
            AddDistinct(combinedPlan.FilesToCreate, plan.FilesToCreate);
            AddDistinct(combinedPlan.FilesToModify, plan.FilesToModify);
            AddDistinct(combinedPlan.CommandsToExecute, plan.CommandsToExecute);
            AddDistinct(combinedPlan.Warnings, plan.Warnings);
        }

        if (dryRun)
        {
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Dry run: would apply {entries.Count} control(s).",
                Plan = combinedPlan,
            };
        }

        var (manifest, readError) = TryReadManifest();
        if (readError is not null)
        {
            return Fail(readError);
        }

        _pendingBlocks.Clear();
        _pendingSharedFiles.Clear();
        _pendingWelcomeFiles.Clear();
        if (ValidateGeneratedState(manifest, entries) is { } ownershipError) return Fail(ownershipError);
        foreach (var entry in entries.Where(entry => IsTemplateInstalled(manifest, entry)))
        {
            if (version is not null
                && (!manifest!.PackageVersions.TryGetValue(entry.PackageId, out var installedVersion)
                    || !installedVersion.Equals(version, StringComparison.OrdinalIgnoreCase)))
            {
                return Fail(
                    $"Template '{entry.Id}' is already installed with package version '{manifest!.PackageVersions.GetValueOrDefault(entry.PackageId, "unrecorded")}'. Template add does not change package versions; use the package update command to select '{version}'.");
            }
        }

        var entriesToApply = entries
            .Where(entry => !IsTemplateInstalled(manifest, entry)
                || !AllGeneratedFilesPresentAndUnmodified(entry, manifest!))
            .ToList();
        if (entriesToApply.Count == 0)
        {
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = "All selected controls are already installed. No changes made.",
                Plan = new ChangePlan { ControlId = combinedPlan.ControlId },
            };
        }

        var renderedFiles = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var renderedBinaryFiles = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase);
        var destinations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var projectName = Path.GetFileNameWithoutExtension(_csprojPath);
        var rootNamespace = PlaceholderReplacer.NormalizeRootNamespace(_project.RootNamespace ?? projectName);
        foreach (var entry in entriesToApply)
        {
            try
            {
                var generated = RenderTemplate(entry, projectName, rootNamespace);
                foreach (var file in entry.GeneratedFiles)
                {
                    if (!destinations.Add(file.Destination))
                    {
                        return Fail($"Selected controls map to the same generated file '{file.Destination}'.");
                    }

                    if (FindDestinationCaseConflict(file.Destination) is { } collision)
                    {
                        return Fail($"Cannot apply '{entry.Id}' because destination '{file.Destination}' collides by casing with existing path '{collision}'.");
                    }

                    var destination = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
                    var existingIsOwned = manifest?.GeneratedFiles.Contains(file.Destination, StringComparer.OrdinalIgnoreCase) == true;
                    if (File.Exists(destination) && !existingIsOwned)
                    {
                        return Fail($"Cannot apply '{entry.Id}' because '{file.Destination}' already exists and is not tracked as CLI-owned.");
                    }

                    if (generated.Binary.TryGetValue(file.Destination, out var binary))
                    {
                        renderedBinaryFiles.Add(file.Destination, binary);
                    }
                    else
                    {
                        renderedFiles.Add(file.Destination, generated.Text[file.Destination]);
                    }
                }
            }
            catch (Exception ex)
            {
                return Fail($"Cannot validate control '{entry.Id}': {ex.Message}");
            }
        }

        var packageWasReferenced = entriesToApply
            .SelectMany(entry => entry.DependentPackageIds.Prepend(entry.PackageId))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToDictionary(packageId => packageId, IsPackageReferenced, StringComparer.OrdinalIgnoreCase);

        var packageIds = entriesToApply
            .SelectMany(entry => entry.DependentPackageIds.Prepend(entry.PackageId))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
        if (version is not null)
        {
            foreach (var packageId in packageIds.Where(id => packageWasReferenced[id]))
            {
                var current = DiscoveryService.ListInstalledPackages(_csprojPath).FirstOrDefault(item => item.PackageId == packageId)?.Version;
                var recorded = manifest?.PackageVersions.GetValueOrDefault(packageId);
                if (current != version && !(current == "*" && recorded == version))
                    return Fail($"Package '{packageId}' is already referenced with version '{current}'. Use sfdotnet update to change its version before adding a sample.");
            }
        }
        var requestedVersions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var packageId in packageIds)
        {
            var existingVersion = packageWasReferenced[packageId]
                ? DiscoveryService.ListInstalledPackages(_csprojPath).FirstOrDefault(item => item.PackageId == packageId)?.Version : null;
            var exactVersion = existingVersion is not null && IsExactVersion(existingVersion)
                ? existingVersion
                : await ResolvePackageVersion(_csprojPath, packageId, null, version, source, configFile, cancellationToken).ConfigureAwait(false);
            if (exactVersion is null)
                return Fail($"Cannot apply the selected controls because an exact stable version for '{packageId}' could not be resolved before modifying the project.");
            requestedVersions.Add(packageId, exactVersion);
        }

        var packagesToPin = packageIds.Where(id => !packageWasReferenced[id]
            || !IsExactVersion(DiscoveryService.ListInstalledPackages(_csprojPath).FirstOrDefault(package => package.PackageId == id)?.Version ?? "")).ToHashSet(StringComparer.OrdinalIgnoreCase);

        using var rollback = new FileRollback();
        using var stages = new OperationStages(progress);
        try
        {
            TrackNuGetProjectState(rollback, centralPackageMode ? centralPropsPath : null);
            var packageResults = new Dictionary<string, NuGetCommandResult>(StringComparer.OrdinalIgnoreCase);
            var addingPackages = packagesToPin.Count > 0;
            var registering = entriesToApply.Any(entry => entry.RegistrationRequirement == "syncfusion-core")
                && MauiProgramPatcher.WouldModifyRegistration(_projectRoot);
            var navigating = ProjectControlState.HasWelcome(manifest) || ProjectControlState.HasLegacyNavigation(manifest)
                || HybridSampleNavigation.CanIntegrate(_projectRoot, rootNamespace, manifest);
            if (addingPackages) stages.Plan("Adding packages");
            stages.Plan("Restoring", "Generating files");
            if (registering) stages.Plan("Registering in MauiProgram.cs");
            if (navigating) stages.Plan("Updating navigation");
            stages.Plan("Writing control manifest");
            if (!deferBuild) stages.Plan("Building");
            if (addingPackages) stages.Start("Adding packages");
            var addedPackages = 0;
            var packagesToAdd = packagesToPin.Count;
            stages.Advance(0, packagesToAdd);
            foreach (var packageId in packageIds)
            {
                if (!packagesToPin.Contains(packageId)) continue;
                var packageResult = await _nuget.RunAsync(new NuGetOperation
                {
                    Kind = NuGetOperationKind.Add,
                    ProjectPath = _csprojPath,
                    PackageId = packageId,
                    Version = requestedVersions[packageId],
                    Source = source,
                    ConfigFile = configFile,
                    NoRestore = true,
                    WorkingDirectory = _projectRoot,
                }, cancellationToken).ConfigureAwait(false);
                if (!packageResult.Success)
                {
                    var errors = rollback.Rollback();
                    return new ControlOperationResult
                    {
                        ExitCode = ExitCodes.Error,
                        Message = $"Cannot apply the selected controls because package '{packageId}' could not be added.",
                        Plan = combinedPlan,
                        Errors = [packageResult.StandardError, .. errors],
                        PackageChangesSucceeded = false, SampleGenerationSucceeded = false,
                    };
                }

                packageResults.Add(packageId, packageResult);
                stages.Advance(++addedPackages, packagesToAdd);
            }

            try
            {
                if (centralPackageMode)
                {
                    if (string.IsNullOrWhiteSpace(centralPropsPath) || !File.Exists(centralPropsPath))
                    {
                        throw new InvalidOperationException("The evaluated central package file is missing or unavailable.");
                    }

                    var projectFile = XDocument.Load(_csprojPath);
                    foreach (var packageId in packageIds)
                    {
                        var references = projectFile.Descendants()
                            .Where(element => element.Name.LocalName.Equals("PackageReference", StringComparison.OrdinalIgnoreCase)
                                && string.Equals((string?)element.Attribute("Include"), packageId, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                        if (references.Count > 1)
                        {
                            throw new InvalidOperationException($"Project contains duplicate references for '{packageId}'. Resolve them before retrying.");
                        }

                        if (references.Count == 1)
                        {
                            references[0].Attribute("Version")?.Remove();
                        }
                    }

                    var packageDocument = XDocument.Load(centralPropsPath);
                    foreach (var packageId in packageIds)
                    {
                        AddCentralPackageVersion(packageDocument, packageId, requestedVersions[packageId]);
                    }

                    packageDocument.Save(centralPropsPath);
                    projectFile.Save(_csprojPath);
                }
            }
            catch (Exception ex) when (ex is IOException or InvalidOperationException or System.Xml.XmlException)
            {
                var errors = rollback.Rollback();
                return new ControlOperationResult
                {
                    ExitCode = ExitCodes.Error,
                    Message = $"Cannot apply the selected controls using Central Package Management: {ex.Message}",
                    Plan = combinedPlan,
                    Errors = errors,
                    PackageChangesSucceeded = false, SampleGenerationSucceeded = false,
                };
            }

            var restoreArgs = new List<string> { "restore", _csprojPath };
            AppendSourceAndConfigFile(restoreArgs, source, configFile);

            stages.Complete();
            stages.Start("Restoring");
            var restoreResult = await _dotnet.RunAsync(
                restoreArgs,
                _projectRoot,
                dryRun: false,
                cancellationToken).ConfigureAwait(false);
            if (!restoreResult.Success)
            {
                var errors = rollback.Rollback();
                return new ControlOperationResult
                {
                    ExitCode = ExitCodes.Error,
                    Message = $"Cannot establish package compatibility for the selected controls against target framework(s) {string.Join(", ", _targetFrameworks)}.",
                    Plan = combinedPlan,
                    Errors = [restoreResult.StandardError, restoreResult.StandardOutput, .. errors],
                    PackageChangesSucceeded = false, SampleGenerationSucceeded = false,
                };
            }

            var resolvedVersions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (!centralPackageMode)
            {
                foreach (var packageId in packageIds)
                {
                    var existingVersion = packageWasReferenced[packageId] ? ExtractRestoredPackageVersion(_projectRoot, packageId)
                        ?? DiscoveryService.ListInstalledPackages(_csprojPath).FirstOrDefault(item => item.PackageId == packageId)?.Version
                        ?? manifest?.PackageVersions.GetValueOrDefault(packageId) : null;
                    if (existingVersion == "*") existingVersion = manifest?.PackageVersions.GetValueOrDefault(packageId);
                    var resolvedVersion = existingVersion ?? await ResolvePackageVersion(
                        _csprojPath,
                        packageId,
                        packageResults.GetValueOrDefault(packageId),
                        version,
                        source,
                        configFile,
                        cancellationToken).ConfigureAwait(false)
                        ?? ExtractRestoredPackageVersion(_projectRoot, packageId);
                    if (resolvedVersion is null)
                    {
                        var errors = rollback.Rollback();
                        return new ControlOperationResult
                        {
                            ExitCode = ExitCodes.Error,
                            Message = $"Cannot apply the selected controls because NuGet did not report an exact resolved version for '{packageId}'.",
                            Plan = combinedPlan,
                            Errors = errors,
                            PackageChangesSucceeded = false, SampleGenerationSucceeded = false,
                        };
                    }

                    resolvedVersions.Add(packageId, resolvedVersion);
                }
            }

            if (centralPackageMode)
            {
                foreach (var packageId in packageIds)
                {
                    resolvedVersions.Add(packageId, requestedVersions[packageId]);
                }
            }

            if (centralPackageMode)
            {
                if (string.IsNullOrWhiteSpace(centralPropsPath) || !File.Exists(centralPropsPath))
                {
                    throw new InvalidOperationException("The evaluated central package file is missing or unavailable.");
                }

                var projectFile = XDocument.Load(_csprojPath);
                foreach (var packageId in packageIds)
                {
                    var references = projectFile.Descendants()
                        .Where(element => element.Name.LocalName.Equals("PackageReference", StringComparison.OrdinalIgnoreCase)
                            && string.Equals((string?)element.Attribute("Include"), packageId, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    if (references.Count > 1)
                    {
                        throw new InvalidOperationException($"Project contains duplicate references for '{packageId}'. Resolve them before retrying.");
                    }

                    if (references.Count == 1)
                    {
                        references[0].Attribute("Version")?.Remove();
                    }
                }

                var packageDocument = XDocument.Load(centralPropsPath);
                foreach (var packageId in packageIds)
                {
                    AddCentralPackageVersion(packageDocument, packageId, resolvedVersions[packageId]);
                }

                packageDocument.Save(centralPropsPath);
                projectFile.Save(_csprojPath);
            }

            stages.Complete();
            stages.Start("Generating files");
            var processedFiles = 0;
            var filesToProcess = entriesToApply.Sum(entry => entry.GeneratedFiles.Count);
            stages.Advance(0, filesToProcess);
            var writtenFiles = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
            foreach (var entry in entriesToApply)
            {
                var writtenForTemplate = new List<string>();
                foreach (var file in entry.GeneratedFiles)
                {
                    var destination = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
                    var directory = Path.GetDirectoryName(destination);
                    if (!string.IsNullOrEmpty(directory))
                    {
                        rollback.TrackCreatedDirectories(directory, _projectRoot);
                        Directory.CreateDirectory(directory);
                    }

                    var exists = File.Exists(destination);
                    var originalHash = manifest?.OriginalHashes?.GetValueOrDefault(file.Destination);
                    var modified = exists && originalHash is not null
                        && !string.Equals(FileRollback.ComputeHash(destination), originalHash, StringComparison.OrdinalIgnoreCase);
                    if (modified && !force)
                    {
                        combinedPlan.Warnings.Add($"Preserved modified file '{file.Destination}' (use --force to overwrite).");
                        stages.Advance(++processedFiles, filesToProcess);
                        continue;
                    }

                    if (exists)
                    {
                        rollback.TrackModified(destination);
                    }
                    else
                    {
                        rollback.TrackCreated(destination);
                    }

                    if (renderedBinaryFiles.TryGetValue(file.Destination, out var binary))
                    {
                        await File.WriteAllBytesAsync(destination, binary, cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        await File.WriteAllTextAsync(destination, renderedFiles[file.Destination], cancellationToken).ConfigureAwait(false);
                    }
                    writtenForTemplate.Add(file.Destination);
                    stages.Advance(++processedFiles, filesToProcess);
                }

                writtenFiles.Add(entry.Id, writtenForTemplate);
            }

            var programPath = MauiProgramPatcher.ResolveMauiProgramPath(_projectRoot);
            stages.Complete();
            if (File.Exists(programPath))
            {
                rollback.TrackModified(programPath);
            }

            if (registering) stages.Start("Registering in MauiProgram.cs");
            var registrationChanged = entriesToApply.Any(entry =>
                entry.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase))
                ? EnsureTrackedRegistration()
                : [];
            if (entriesToApply.Any(entry => entry.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase))
                && !MauiProgramPatcher.IsRegistered(_projectRoot))
            {
                var errors = rollback.Rollback();
                return new ControlOperationResult
                {
                    ExitCode = ExitCodes.Error,
                    Message = "Cannot apply the selected controls because verified registration could not be applied to MauiProgram.cs.",
                    Plan = combinedPlan,
                    Errors = errors,
                    PackageChangesSucceeded = false, SampleGenerationSucceeded = false,
                };
            }

            stages.Complete();
            if (navigating) stages.Start("Updating navigation", reportLegacy: false);
            AddMainPageNavigation(rollback, entriesToApply, rootNamespace);
            // Binary sample resources must ship embedded in the app: inject the
            // owned EmbeddedResource block into the .csproj and track its blocks.
            foreach (var entry in entriesToApply.Where(SampleResourceEmbedding.NeedsEmbedding))
            {
                var beforeCsproj = File.ReadAllText(_csprojPath);
                var embeddingManifest = ReadManifest() ?? new SyncfusionManifest
                {
                    CliVersion = CliMetadata.Version,
                    Framework = Frameworks.Name(Core.Framework.Maui),
                    ProjectType = "app",
                    TargetFramework = string.Join(';', _targetFrameworks),
                };
                SampleResourceEmbedding.Ensure(_projectRoot, _csprojPath, entry, rollback, embeddingManifest);
                _pendingBlocks.AddRange(GeneratedCodeBlocks.CaptureNew(Path.GetFileName(_csprojPath), beforeCsproj, File.ReadAllText(_csprojPath)));
            }
            if (!ProjectControlState.HasWelcome(manifest) && !ProjectControlState.HasLegacyNavigation(manifest)
                && !HybridSampleNavigation.CanIntegrate(_projectRoot, rootNamespace, manifest))
                combinedPlan.Warnings.Add("Automatic sample navigation is unavailable: this project's startup page is not verified CLI-generated scaffolding. The existing startup page and navigation were preserved.");
            stages.Complete();

            stages.Start("Writing control manifest", reportLegacy: false);
            var manifestPath = Path.Combine(_projectRoot, "Syncfusion", "syncfusion.json");
            rollback.TrackModified(manifestPath);
            rollback.TrackCreatedDirectories(Path.GetDirectoryName(manifestPath)!, _projectRoot);
            foreach (var entry in entriesToApply)
            {
                WriteManifest(
                    entry,
                    templateIds.First(id => TemplateCatalog.TryResolveOperableTemplate(id, out var requested) && requested.Id == entry.Id),
                    version,
                    resolvedVersions[entry.PackageId],
                    packageWasReferenced.GetValueOrDefault(entry.PackageId),
                    registrationChanged,
                    writtenFiles[entry.Id],
                    buildValidated: !deferBuild);
            }

            stages.Complete();

            if (!deferBuild)
            {
                stages.Start("Building");
                var buildResult = await new MauiPostCreationBuild(_dotnet).ExecuteAsync(
                    _csprojPath, buildFramework, cancellationToken).ConfigureAwait(false);
                if (!buildResult.Success)
                {
                    var errors = rollback.Rollback();
                    return new ControlOperationResult
                    {
                        ExitCode = ExitCodes.Error,
                        Message = "Generated control files failed to build. Package and sample changes were rolled back.",
                        Plan = combinedPlan,
                        Errors = [buildResult.StandardError, buildResult.StandardOutput, .. errors],
                        PackageChangesSucceeded = false, SampleGenerationSucceeded = false, BuildSucceeded = false,
                    };
                }
                stages.Complete();
            }

            rollback.Commit();
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Packages: restored required references. Samples: applied {entriesToApply.Count} control(s). Build: {(deferBuild ? "not requested; rebuild/run to see changes" : buildFramework is null ? "succeeded (all configured targets)" : $"succeeded ({buildFramework})")}.",
                PackageChangesSucceeded = true, SampleGenerationSucceeded = true, BuildSucceeded = deferBuild ? null : true,
                Plan = combinedPlan,
            };
        }
        catch (OperationCanceledException)
        {
            rollback.Rollback();
            throw;
        }
        catch (Exception ex)
        {
            var errors = rollback.Rollback();
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Error,
                Message = $"Failed to apply selected controls: {ex.Message}",
                Plan = combinedPlan,
                Errors = [ex.Message, .. errors],
                PackageChangesSucceeded = false, SampleGenerationSucceeded = false,
            };
        }
    }

    /// <summary>
    /// Executes the remove flow: deletes the generated files, removes the
    /// NuGet package only when no other installed control shares it, removes
    /// the MauiProgram registration only when no control remains, and updates
    /// the manifest. Honors <c>--dry-run</c> and cancellation.
    /// </summary>
    public async Task<ControlOperationResult> ExecuteRemoveAsync(
        string controlId,
        bool dryRun = false,
        CancellationToken cancellationToken = default,
        bool noRestore = false,
        string? source = null,
        string? configFile = null,
        bool force = false, IProgress<string>? progress = null)
    {
        _ = force;
        return await new ControlRemovalService(_project, _nuget).ExecuteAsync(
            [controlId], dryRun, noRestore, source, configFile, cancellationToken: cancellationToken, progress: progress).ConfigureAwait(false);
    }

    public Task<ControlOperationResult> ExecuteRemoveBatchAsync(IReadOnlyList<string> ids, bool noRestore = false,
        string? source = null, string? configFile = null, CancellationToken cancellationToken = default,
        bool build = false, string? buildFramework = null, IProgress<string>? progress = null)
        => new ControlRemovalService(_project, _nuget, _dotnet).ExecuteAsync(ids, noRestore: noRestore,
            source: source, configFile: configFile, cancellationToken: cancellationToken, build: build, buildFramework: buildFramework, progress: progress);

    /// <summary>
    /// Builds a change plan for updating <paramref name="controlId"/> without
    /// touching the filesystem. Used for <c>--dry-run</c> and preview output.
    /// </summary>
    public ControlOperationResult PlanUpdate(
        string controlId,
        string? version,
        bool noRestore,
        bool dryRun,
        bool force,
        string? source = null,
        string? configFile = null)
    {
        if (!TemplateCatalog.TryResolveOperableTemplate(controlId, out var entry))
        {
            return Fail($"Control '{controlId}' is not supported. Supported controls: {string.Join(", ", AllControlIds())}.");
        }

        if (VerifyEntry(entry) is { } unverified)
        {
            return unverified;
        }

        var (manifest, readError) = TryReadManifest();
        if (readError is not null)
        {
            return Fail(readError);
        }

        if (manifest is null || !IsTemplateInstalled(manifest, entry))
        {
            return Fail($"Control '{entry.Id}' is not installed. Use 'sfdotnet add {entry.Id} maui' first.");
        }

        var plan = new ChangePlan
        {
            ControlId = entry.Id,
            IsDryRun = dryRun,
        };

        plan.PackagesToAdd.Add(entry.PackageId);
        plan.CommandsToExecute.Add(
            NuGetArgumentBuilder.FormatCommandLine(
                NuGetArgumentBuilder.Build(new NuGetOperation
                {
                    Kind = NuGetOperationKind.Add,
                    ProjectPath = _csprojPath,
                    PackageId = entry.PackageId,
                    Version = version,
                    NoRestore = noRestore,
                    DryRun = dryRun,
                    Source = source,
                    ConfigFile = configFile,
                })));

        // Determine which generated files are drift-detected (modified vs the
        // manifest hash) so the update can decide to overwrite or preserve.
        manifest.OriginalHashes ??= [];
        foreach (var file in entry.GeneratedFiles)
        {
            var dest = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
            if (!File.Exists(dest))
            {
                plan.Warnings.Add($"File '{file.Destination}' is missing and will be regenerated.");
                plan.FilesToModify.Add(file.Destination);
                continue;
            }

            var currentHash = FileRollback.ComputeHash(dest);
            manifest.OriginalHashes.TryGetValue(file.Destination, out var originalHash);
            var isModified = !string.Equals(currentHash, originalHash, System.StringComparison.OrdinalIgnoreCase);
            if (isModified)
            {
                if (force)
                {
                    plan.FilesToModify.Add(file.Destination);
                    plan.Warnings.Add($"File '{file.Destination}' was modified; --force will overwrite it.");
                }
                else
                {
                    plan.Warnings.Add($"File '{file.Destination}' was modified; preserving. Use --force to overwrite.");
                }
            }
            else
            {
                plan.FilesToModify.Add(file.Destination);
            }
        }

        return new ControlOperationResult
        {
            ExitCode = ExitCodes.Success,
            Message = dryRun
                ? $"Planned update of '{entry.Id}'. No changes made (--dry-run)."
                : $"Planned update of '{entry.Id}'.",
            Plan = plan,
        };
    }

    /// <summary>
    /// Executes the update flow: updates the package to the requested version,
    /// regenerates unmodified CLI-owned files, preserves modified files unless
    /// <paramref name="force"/> is set, and updates the manifest only after
    /// success. Honors <c>--dry-run</c>, <c>--no-restore</c>, and cancellation.
    /// </summary>
    public async Task<ControlOperationResult> ExecuteUpdateAsync(
        string controlId,
        string? version = null,
        bool noRestore = false,
        bool dryRun = false,
        bool force = false,
        string? source = null,
        string? configFile = null,
        CancellationToken cancellationToken = default)
    {
        if (!TemplateCatalog.TryResolveOperableTemplate(controlId, out var entry))
        {
            return Fail($"Control '{controlId}' is not supported. Supported controls: {string.Join(", ", AllControlIds())}.");
        }

        var planResult = PlanUpdate(controlId, version, noRestore, dryRun, force, source, configFile);
        if (planResult.ExitCode != ExitCodes.Success)
        {
            return planResult;
        }

        var plan = planResult.Plan!;

        if (dryRun)
        {
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Dry run: would update '{entry.Id}' package to {version ?? "latest"}.",
                Plan = plan,
            };
        }

        using var rollback = new FileRollback();
        var projectName = Path.GetFileNameWithoutExtension(_csprojPath);
        var rootNamespace = PlaceholderReplacer.NormalizeRootNamespace(_project.RootNamespace ?? Path.GetFileNameWithoutExtension(_csprojPath));

        try
        {
            // Update the package version (re-adding with a version updates it).
            var op = new NuGetOperation
            {
                Kind = NuGetOperationKind.Add,
                ProjectPath = _csprojPath,
                PackageId = entry.PackageId,
                Version = version,
                Source = source,
                ConfigFile = configFile,
                NoRestore = noRestore,
                DryRun = false,
                WorkingDirectory = _projectRoot,
            };

            var result = await _nuget.RunAsync(op, cancellationToken).ConfigureAwait(false);
            if (!result.Success)
            {
                var errors = rollback.Rollback();
                return new ControlOperationResult
                {
                    ExitCode = ExitCodes.Error,
                    Message = $"Failed to update package '{entry.PackageId}' (exit {result.ExitCode}).",
                    Plan = plan,
                    Errors = [result.StandardError, .. errors],
                };
            }

            // Regenerate only unmodified (or --force) CLI-owned files.
            var manifest = ReadManifest();
            manifest!.OriginalHashes ??= [];
            var regenerated = new List<string>();
            foreach (var file in entry.GeneratedFiles)
            {
                var dest = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
                if (!File.Exists(dest))
                {
                    continue;
                }

                var currentHash = FileRollback.ComputeHash(dest);
                manifest.OriginalHashes.TryGetValue(file.Destination, out var originalHash);
                var isModified = !string.Equals(currentHash, originalHash, System.StringComparison.OrdinalIgnoreCase);
                if (isModified && !force)
                {
                    continue;
                }

                var resourceName = TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource);
                rollback.TrackModified(dest);
                if (EmbeddedResourceLoader.IsBinaryFile(file.Destination))
                {
                    // Binary resources are copied byte-for-byte (see RenderTemplate).
                    await File.WriteAllBytesAsync(dest, EmbeddedResourceLoader.ReadBytes(resourceName), cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var template = EmbeddedResourceLoader.ReadText(resourceName);
                    var values = PlaceholderReplacer.BuildValues(projectName, rootNamespace, entry.ControlName, MauiTemplateNames.ViewName(entry.ControlName));
                    var content = PlaceholderReplacer.Replace(template, values);
                    await File.WriteAllTextAsync(dest, content, cancellationToken).ConfigureAwait(false);
                }
                regenerated.Add(file.Destination);
            }

            // Update the manifest only after success.
            UpdateManifestForUpdate(entry, version, result, regenerated);

            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Updated '{entry.Id}': package '{entry.PackageId}' set to {version ?? "latest"}.",
                Plan = plan,
            };
        }
        catch (OperationCanceledException)
        {
            rollback.Rollback();
            throw;
        }
        catch (System.Exception ex)
        {
            var errors = rollback.Rollback();
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Error,
                Message = $"Failed to update '{entry.Id}': {ex.Message}",
                Plan = plan,
                Errors = [ex.Message, .. errors],
            };
        }
    }

    private ChangePlan BuildAddPlan(
        ControlCatalogEntry entry,
        string? version,
        bool noRestore,
        bool dryRun,
        string? source,
        string? configFile)
    {
        var plan = new ChangePlan
        {
            ControlId = entry.Id,
            IsDryRun = dryRun,
        };

        var packageIds = entry.DependentPackageIds.Prepend(entry.PackageId);
        foreach (var packageId in packageIds)
        {
            if (!IsPackageReferenced(packageId)) plan.PackagesToAdd.Add(packageId);
            else plan.Warnings.Add($"Retained existing package reference '{packageId}' while generating the sample.");
        }

        foreach (var file in entry.GeneratedFiles)
        {
            var dest = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
            if (File.Exists(dest))
            {
                plan.FilesToModify.Add(file.Destination);
                plan.Warnings.Add($"File '{file.Destination}' already exists and will be overwritten.");
            }
            else
            {
                plan.FilesToCreate.Add(file.Destination);
            }
        }

        if (File.Exists(TemplatePathResolver.ResolveDestination(_projectRoot, WelcomeProjectGenerator.RegistryPath)))
            plan.FilesToModify.Add(WelcomeProjectGenerator.RegistryPath);
        else plan.FilesToCreate.Add(WelcomeProjectGenerator.RegistryPath);
        if (entry.RegistrationRequirement == "syncfusion-core" && MauiProgramPatcher.WouldModifyRegistration(_projectRoot))
            plan.FilesToModify.Add("MauiProgram.cs");
        if (MainPageNavigationPatcher.CanPatch(_projectRoot)
            && ProjectControlState.HasLegacyNavigation(TryReadManifest().Manifest))
            plan.FilesToModify.AddRange(MainPageNavigationPatcher.Paths(_projectRoot).Select(path => Path.GetFileName(path)!));

        foreach (var packageId in plan.PackagesToAdd)
        {
            plan.CommandsToExecute.Add(
                NuGetArgumentBuilder.FormatCommandLine(
                    NuGetArgumentBuilder.Build(new NuGetOperation
                    {
                        Kind = NuGetOperationKind.Add,
                        ProjectPath = _csprojPath,
                        PackageId = packageId,
                        Version = version,
                        NoRestore = noRestore,
                        DryRun = dryRun,
                        Source = source,
                        ConfigFile = configFile,
                    })));
        }

        return plan;
    }

    private string? ValidateGeneratedState(SyncfusionManifest? manifest, IEnumerable<ControlCatalogEntry> entries)
    {
        try
        {
            if (WelcomeProjectGenerator.RegistryConflict(_projectRoot, manifest) is { } conflict) return conflict;
            if (manifest?.GeneratedBlocks.Any(block => block.Marker == "hybrid-binding") == true)
            {
                var viewModel = TemplatePathResolver.ResolveDestination(_projectRoot, HybridSampleNavigation.ViewModelPath);
                if (File.Exists(viewModel) && manifest.OriginalHashes.GetValueOrDefault(HybridSampleNavigation.ViewModelPath) != FileRollback.ComputeHash(viewModel))
                    return $"Conflict: '{HybridSampleNavigation.ViewModelPath}' was edited. No changes made.";
            }
            foreach (var file in entries.SelectMany(entry => entry.GeneratedFiles))
            {
                var path = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
                if (FindDestinationCaseConflict(file.Destination) is { } collision)
                    return $"Conflict: generated destination '{file.Destination}' collides with '{collision}'. No changes made.";
                if (!File.Exists(path) && manifest?.GeneratedFiles.Contains(file.Destination, StringComparer.OrdinalIgnoreCase) == true)
                {
                    var owner = entries.First(entry => entry.GeneratedFiles.Contains(file));
                    string expectedHash;
                    if (EmbeddedResourceLoader.IsBinaryFile(file.Destination))
                    {
                        var resourceName = TemplatePathResolver.ResolveResourceName(owner.TemplatePath, file.TemplateResource);
                        expectedHash = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(EmbeddedResourceLoader.ReadBytes(resourceName))).ToLowerInvariant();
                    }
                    else
                    {
                        var expected = ReadAndValidateTemplate(owner, Path.GetFileNameWithoutExtension(_csprojPath),
                            PlaceholderReplacer.NormalizeRootNamespace(_project.RootNamespace ?? Path.GetFileNameWithoutExtension(_csprojPath)))[file.Destination];
                        expectedHash = ProjectControlState.HashContent(expected);
                    }
                    if (manifest.OriginalHashes.GetValueOrDefault(file.Destination) != expectedHash)
                        return $"Conflict: missing file '{file.Destination}' cannot be reconstructed from verified ownership. No changes made.";
                }
                if (File.Exists(path) && manifest?.GeneratedFiles.Contains(file.Destination, StringComparer.OrdinalIgnoreCase) != true)
                    return $"Conflict: '{file.Destination}' already exists and is not tracked as CLI-owned. No changes made.";
                if (File.Exists(path) && manifest?.GeneratedFiles.Contains(file.Destination, StringComparer.OrdinalIgnoreCase) == true
                    && manifest.OriginalHashes.GetValueOrDefault(file.Destination) != FileRollback.ComputeHash(path))
                    return $"Conflict: generated file '{file.Destination}' was edited or its ownership hash is missing. No changes made.";
            }
            foreach (var block in manifest?.GeneratedBlocks ?? [])
                if (GeneratedCodeBlocks.Conflict(_projectRoot, block) is { } blockConflict && !CanRepairBlock(block, entries))
                    return "Conflict: " + blockConflict;
            return null;
        }
        catch (Exception exception) when (exception is IOException or InvalidOperationException or UnauthorizedAccessException)
        {
            return exception.Message;
        }
    }

    private IReadOnlyList<string> EnsureTrackedRegistration()
    {
        var path = MauiProgramPatcher.ResolveMauiProgramPath(_projectRoot);
        var before = File.Exists(path) ? File.ReadAllText(path) : string.Empty;
        var modified = MauiProgramPatcher.EnsureRegistered(_projectRoot);
        if (File.Exists(path)) _pendingBlocks.AddRange(GeneratedCodeBlocks.CaptureNew("MauiProgram.cs", before, File.ReadAllText(path)));
        return modified;
    }

    private bool CanRepairBlock(GeneratedBlockRecord block, IEnumerable<ControlCatalogEntry> entries)
    {
        if (!GeneratedCodeBlocks.IsMissing(_projectRoot, block)) return false;
        string? expected = block.Marker == "core-using"
            ? GeneratedCodeBlocks.Wrap("core-using", "using Syncfusion.Maui.Core.Hosting;") : null;
        if (block.Marker == "core-registration")
        {
            var program = File.ReadAllText(MauiProgramPatcher.ResolveMauiProgramPath(_projectRoot));
            var builder = program.Replace("\r\n", "\n").Split('\n').FirstOrDefault(line => line.Contains("MauiApp.CreateBuilder"));
            if (builder is not null)
            {
                var indent = new string(builder.TakeWhile(char.IsWhiteSpace).ToArray());
                expected = GeneratedCodeBlocks.Wrap(block.Marker, indent + "builder.ConfigureSyncfusionCore();", indent: indent);
            }
        }
        foreach (var entry in entries.Where(entry => block.Marker == "sf-nav:" + entry.ControlName))
        {
            var rootNamespace = PlaceholderReplacer.NormalizeRootNamespace(_project.RootNamespace ?? Path.GetFileNameWithoutExtension(_csprojPath));
            expected = MainPageNavigationPatcher.BlockContent(block.Path, rootNamespace, entry.ControlName, entry.DisplayName);
        }
        return expected is not null && GeneratedCodeBlocks.CaptureNew(block.Path, "", expected).Single().Hash == block.Hash;
    }

    private void AddMainPageNavigation(FileRollback rollback, IEnumerable<ControlCatalogEntry> entries, string rootNamespace)
    {
        var selected = entries.ToList();
        var manifest = ReadManifest() ?? new SyncfusionManifest();
        var installed = manifest.InstalledControls.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry) ? entry : null)
            .Where(entry => entry is not null).Cast<ControlCatalogEntry>();
        if (HybridSampleNavigation.CanIntegrate(_projectRoot, rootNamespace, manifest))
        {
            HybridSampleNavigation.Ensure(_projectRoot, rootNamespace, rollback, manifest, _project);
            _pendingBlocks.AddRange(manifest.GeneratedBlocks);
            _pendingSharedFiles[HybridSampleNavigation.ViewModelPath] = manifest.OriginalHashes[HybridSampleNavigation.ViewModelPath];
            _pendingWelcomeFiles.Add(HybridSampleNavigation.ViewModelPath);
            _pendingSharedFiles["Welcome/WelcomeModel.cs"] = manifest.OriginalHashes["Welcome/WelcomeModel.cs"];
            _pendingWelcomeFiles.Add("Welcome/WelcomeModel.cs");
        }
        WelcomeProjectGenerator.WriteRegistry(_projectRoot, rootNamespace, installed.Concat(selected), rollback, manifest);
        _pendingSharedFiles[WelcomeProjectGenerator.RegistryPath] = manifest.OriginalHashes[WelcomeProjectGenerator.RegistryPath];
        if (ProjectControlState.HasWelcome(manifest)) return;
        if (!ProjectControlState.HasLegacyNavigation(manifest) || !MainPageNavigationPatcher.CanPatch(_projectRoot)) return;
        var beforeFiles = MainPageNavigationPatcher.Paths(_projectRoot).ToDictionary(path => path, File.ReadAllText);
        foreach (var path in beforeFiles.Keys) rollback.TrackModified(path);
        foreach (var item in selected) MainPageNavigationPatcher.Add(_projectRoot, rootNamespace, item.ControlName, item.DisplayName);
        foreach (var (path, before) in beforeFiles)
            _pendingBlocks.AddRange(GeneratedCodeBlocks.CaptureNew(Path.GetFileName(path), before, File.ReadAllText(path)));
    }

    private SyncfusionManifest? ReadManifest()
    {
        var path = Path.Combine(_projectRoot, "Syncfusion", "syncfusion.json");
        if (!File.Exists(path))
        {
            return null;
        }

        try
        {
            return WelcomeProjectGenerator.ReadManifest(_projectRoot, _project);
        }
        catch (System.Exception ex)
        {
            throw new System.InvalidOperationException(
                $"The Syncfusion manifest at '{path}' is malformed and could not be read: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Reads the manifest, returning a clear error message (instead of throwing)
    /// when the manifest is malformed. Used at the entry of each operation so a
    /// corrupted manifest produces a clean failure result.
    /// </summary>
    private (SyncfusionManifest? Manifest, string? Error) TryReadManifest()
    {
        try
        {
            return (ReadManifest(), null);
        }
        catch (System.Exception ex)
        {
            return (null, ex.Message);
        }
    }

    private void WriteManifest(
        ControlCatalogEntry entry,
        string templateIdUsed,
        string? requestedVersion,
        string resolvedVersion,
        bool packageWasReferenced,
        IReadOnlyList<string> modifiedFiles,
        IReadOnlyList<string> writtenFiles,
        bool buildValidated = true)
    {
        var manifest = ReadManifest() ?? new SyncfusionManifest
        {
            CliVersion = CliMetadata.Version,
            Framework = Frameworks.Name(Core.Framework.Maui),
            ProjectType = "app",
            TargetFramework = string.Join(';', _targetFrameworks),
        };

        manifest.SchemaVersion = 2;
        manifest.ProjectFile = Path.GetFileName(_csprojPath);
        manifest.TargetFramework = string.Join(';', _targetFrameworks);
        foreach (var path in _pendingWelcomeFiles)
            if (!manifest.WelcomeFiles.Contains(path)) manifest.WelcomeFiles.Add(path);
        foreach (var (path, hash) in _pendingSharedFiles)
        {
            if (!manifest.GeneratedFiles.Contains(path, StringComparer.OrdinalIgnoreCase)) manifest.GeneratedFiles.Add(path);
            manifest.OriginalHashes[path] = hash;
        }
        foreach (var block in _pendingBlocks)
        {
            if (!manifest.GeneratedBlocks.Any(other => other.Path == block.Path && other.Marker == block.Marker)) manifest.GeneratedBlocks.Add(block);
            if (!manifest.ModifiedFiles.Contains(block.Path, StringComparer.OrdinalIgnoreCase)) manifest.ModifiedFiles.Add(block.Path);
        }

        if (!IsTemplateInstalled(manifest, entry))
        {
            manifest.InstalledControls.Add(entry.Id);
        }

        foreach (var packageId in entry.DependentPackageIds.Prepend(entry.PackageId))
        {
            if (!packageWasReferenced && !manifest.PackageIds.Contains(packageId))
            {
                manifest.PackageIds.Add(packageId);
            }
        }

        manifest.PackageVersions[entry.PackageId] = resolvedVersion;
        if (_pendingBlocks.Any(block => block.Marker == "core-registration"))
        {
            manifest.RegistrationOwned = true;
        }
        if (requestedVersion is null && !packageWasReferenced)
        {
            manifest.PackageRequestedVersions.Remove(entry.PackageId);
        }
        else if (requestedVersion is not null)
        {
            manifest.PackageRequestedVersions[entry.PackageId] = requestedVersion;
        }

        var priorTemplateRecord = manifest.InstalledTemplates.FirstOrDefault(template =>
            template.Id.Equals(entry.Id, StringComparison.OrdinalIgnoreCase));
        foreach (var file in entry.GeneratedFiles.Where(file => writtenFiles.Contains(file.Destination, StringComparer.OrdinalIgnoreCase)))
        {
            if (!manifest.GeneratedFiles.Contains(file.Destination))
            {
                manifest.GeneratedFiles.Add(file.Destination);
            }
        }

        manifest.OriginalHashes ??= [];
        foreach (var file in entry.GeneratedFiles.Where(file => writtenFiles.Contains(file.Destination, StringComparer.OrdinalIgnoreCase)))
        {
            var dest = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
            var hash = FileRollback.ComputeHash(dest);
            if (hash is not null)
            {
                manifest.OriginalHashes[file.Destination] = hash;
            }
        }

        manifest.InstalledTemplates.RemoveAll(template =>
            template.Id.Equals(entry.Id, StringComparison.OrdinalIgnoreCase));
        manifest.InstalledTemplates.Add(new InstalledTemplateRecord
        {
            Id = entry.Id,
            Family = entry.Family,
            LegacyAliasUsed = templateIdUsed.Equals(entry.Id, StringComparison.OrdinalIgnoreCase) ? null : templateIdUsed,
            PackageId = entry.PackageId,
            RequestedVersion = requestedVersion,
            ResolvedVersion = resolvedVersion,
            GeneratedFiles = entry.GeneratedFiles.Select(file => file.Destination).ToList(),
            RegistrationApplied = entry.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)
                && MauiProgramPatcher.IsRegistered(_projectRoot),
            PackageReferenceOwned = priorTemplateRecord?.PackageReferenceOwned ?? (manifest.PackageIds.Contains(entry.PackageId) || !packageWasReferenced),
            TargetFrameworks = _targetFrameworks.ToList(),
            CompatibilityDecision = buildValidated
                ? "compatible: restored for every enabled target framework and built with the configured build selection"
                : "restored for every declared target framework; build deferred to project creation",
            PackageDependencies = entry.DependentPackageIds.Prepend(entry.PackageId)
                .Concat(entry.RegistrationRequirement == "syncfusion-core" ? ["Syncfusion.Maui.Core"] : Array.Empty<string>()).Distinct(StringComparer.OrdinalIgnoreCase).ToList(),
            CodeBlocks = manifest.GeneratedBlocks.Where(block => block.Marker == "sf-nav:" + entry.ControlName
                || entry.RegistrationRequirement == "syncfusion-core" && block.Marker.StartsWith("core-", StringComparison.Ordinal))
                .Select(block => block.Path + "#" + block.Marker).ToList(),
            Resources = entry.GeneratedFiles.Select(file => file.Destination).Where(path => !path.EndsWith(".cs") && !path.EndsWith(".xaml") && !path.EndsWith(".md")).ToList(),
            NavigationEntries = ProjectControlState.HasWelcome(manifest) || manifest.GeneratedBlocks.Any(block => block.Marker == "hybrid-binding") ? [WelcomeProjectGenerator.RegistryPath + "#" + entry.Id]
                : manifest.GeneratedBlocks.Where(block => block.Marker == "sf-nav:" + entry.ControlName).Select(block => block.Path + "#" + block.Marker).ToList(),
            WelcomeEntry = ProjectControlState.HasWelcome(manifest) || manifest.GeneratedBlocks.Any(block => block.Marker == "hybrid-binding") ? entry.Id : null,
        });
        foreach (var modifiedFile in modifiedFiles)
        {
            if (!manifest.ModifiedFiles.Contains(modifiedFile, StringComparer.OrdinalIgnoreCase))
            {
                manifest.ModifiedFiles.Add(modifiedFile);
            }
        }

        var dir = Path.Combine(_projectRoot, "Syncfusion");
        Directory.CreateDirectory(dir);
        File.WriteAllText(Path.Combine(dir, "syncfusion.json"), manifest.ToJson());
    }

    private bool IsPackageReferenced(string packageId)
    {
        var project = XDocument.Load(_csprojPath);
        return project
            .Descendants()
            .Where(element => string.Equals(element.Name.LocalName, "PackageReference", System.StringComparison.OrdinalIgnoreCase))
            .Any(element =>
            {
                var include = (string?)element.Attribute("Include");
                var update = (string?)element.Attribute("Update");
                return string.Equals(include, packageId, System.StringComparison.OrdinalIgnoreCase)
                    || string.Equals(update, packageId, System.StringComparison.OrdinalIgnoreCase);
            });
    }

    private bool AllGeneratedFilesPresentAndUnmodified(ControlCatalogEntry entry, SyncfusionManifest manifest)
    {
        manifest.OriginalHashes ??= [];
        foreach (var file in entry.GeneratedFiles)
        {
            var dest = TemplatePathResolver.ResolveDestination(_projectRoot, file.Destination);
            if (!File.Exists(dest))
            {
                return false;
            }

            var currentHash = FileRollback.ComputeHash(dest);
            manifest.OriginalHashes.TryGetValue(file.Destination, out var originalHash);
            if (!string.Equals(currentHash, originalHash, System.StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
        }

        var rootNamespace = PlaceholderReplacer.NormalizeRootNamespace(_project.RootNamespace ?? Path.GetFileNameWithoutExtension(_csprojPath));
        var installed = manifest.InstalledControls.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var item) ? item : null)
            .Where(item => item is not null).Cast<ControlCatalogEntry>();
        var registry = TemplatePathResolver.ResolveDestination(_projectRoot, WelcomeProjectGenerator.RegistryPath);
        if (!File.Exists(registry) || File.ReadAllText(registry) != WelcomeProjectGenerator.RegistryContent(rootNamespace, installed)) return false;
        if (entry.DependentPackageIds.Prepend(entry.PackageId).Any(package => !IsPackageReferenced(package))) return false;
        if (entry.RegistrationRequirement == "syncfusion-core" && MauiProgramPatcher.WouldModifyRegistration(_projectRoot)) return false;
        if (manifest.ProjectType == "blazor-hybrid" && HybridSampleNavigation.CanIntegrate(_projectRoot, rootNamespace, manifest)
            && !manifest.GeneratedBlocks.Any(block => block.Marker == "hybrid-binding")) return false;
        if (ProjectControlState.HasLegacyNavigation(manifest) && MainPageNavigationPatcher.Paths(_projectRoot)
            .Any(path => !File.Exists(path) || !File.ReadAllText(path).Contains("sf-nav:" + entry.ControlName))) return false;
        return true;
    }

    private void UpdateManifestForUpdate(ControlCatalogEntry entry, string? version, NuGetCommandResult result, IReadOnlyList<string> regenerated)
    {
        var manifest = ReadManifest();
        if (manifest is null)
        {
            return;
        }

        var resolvedVersion = version ?? ExtractResolvedVersion(result) ?? manifest.PackageVersions.GetValueOrDefault(entry.PackageId);
        if (resolvedVersion is null)
        {
            throw new InvalidOperationException($"NuGet did not report an exact resolved version for '{entry.PackageId}'.");
        }

        manifest.PackageVersions[entry.PackageId] = resolvedVersion;

        manifest.OriginalHashes ??= [];
        foreach (var file in regenerated)
        {
            var dest = TemplatePathResolver.ResolveDestination(_projectRoot, file);
            var hash = FileRollback.ComputeHash(dest);
            if (hash is not null)
            {
                manifest.OriginalHashes[file] = hash;
            }
        }

        File.WriteAllText(Path.Combine(_projectRoot, "Syncfusion", "syncfusion.json"), manifest.ToJson());
    }

    private string? ValidateTargetFrameworks()
    {
        return ValidateTargetFrameworkList(_targetFrameworks);
    }

    private string? ValidateLiteralTargetFrameworks()
    {
        var literalFrameworks = _project.TargetFrameworks
            .Where(framework => !framework.Contains("$(", StringComparison.Ordinal))
            .ToList();
        if (literalFrameworks.Count == 0
            && _project.TargetFrameworks.Any(framework => framework.Contains("$(", StringComparison.Ordinal)))
        {
            return null;
        }

        return ValidateTargetFrameworkList(literalFrameworks);
    }

    private string? ValidateTargetFrameworkList(IReadOnlyList<string> targetFrameworks)
    {
        if (targetFrameworks.Count == 0)
        {
            return $"Cannot apply a control because '{Path.GetFileName(_csprojPath)}' does not declare a literal TargetFramework or TargetFrameworks value.";
        }

        var invalid = targetFrameworks
            .Where(framework => !Regex.IsMatch(
                framework,
                @"\Anet\d+\.\d+(?:-[A-Za-z][A-Za-z0-9.]*)?\z",
                RegexOptions.CultureInvariant))
            .ToList();
        return invalid.Count == 0
            ? null
            : $"Cannot establish template compatibility because the project declares invalid or unresolved target framework(s): {string.Join(", ", invalid)}.";
    }

    private async Task<(bool Enabled, string? PropsPath, string? Error)> ResolveCentralPackageModeAsync(CancellationToken cancellationToken)
    {
        var result = await _dotnet.RunAsync(
            ["msbuild", _csprojPath, "-getProperty:ManagePackageVersionsCentrally", "-getProperty:DirectoryPackagesPropsPath"],
            _projectRoot,
            dryRun: false,
            cancellationToken).ConfigureAwait(false);
        if (!result.Success)
        {
            return (false, null, $"Cannot evaluate Central Package Management settings from '{Path.GetFileName(_csprojPath)}'. {result.StandardError}");
        }

        string? enabledValue;
        string? evaluatedPropsPath;
        try
        {
            using var document = JsonDocument.Parse(result.StandardOutput);
            var properties = document.RootElement.GetProperty("Properties");
            enabledValue = properties.GetProperty("ManagePackageVersionsCentrally").GetString();
            evaluatedPropsPath = properties.GetProperty("DirectoryPackagesPropsPath").GetString();
        }
        catch (Exception ex) when (ex is JsonException or KeyNotFoundException or InvalidOperationException)
        {
            return (false, null, $"Cannot read Central Package Management settings evaluated by MSBuild: {ex.Message}");
        }

        if (string.IsNullOrWhiteSpace(enabledValue))
        {
            return (false, null, null);
        }

        if (!bool.TryParse(enabledValue, out var enabled))
        {
            return (false, null, $"MSBuild returned an invalid ManagePackageVersionsCentrally value: '{enabledValue}'.");
        }

        var propsPath = !string.IsNullOrWhiteSpace(evaluatedPropsPath)
            ? Path.GetFullPath(evaluatedPropsPath)
            : null;
        if (enabled && (propsPath is null || !File.Exists(propsPath)))
        {
            return (false, null, "Central Package Management is enabled, but its evaluated Directory.Packages.props file does not exist.");
        }

        return (enabled, propsPath, null);
    }

    private static string TryReadEvaluatedProperty(string output, string propertyName)
    {
        try
        {
            using var document = JsonDocument.Parse(output);
            if (document.RootElement.TryGetProperty("Properties", out var properties)
                && properties.TryGetProperty(propertyName, out var property)
                && property.ValueKind == JsonValueKind.String)
            {
                return property.GetString() ?? string.Empty;
            }
        }
        catch (JsonException)
        {
            // Older SDKs and test runners may emit a plain property value.
        }

        return output.Trim();
    }

    private async Task<string?> ResolveTargetFrameworksAsync(CancellationToken cancellationToken)
    {
        var result = await _dotnet.RunAsync(
            ["msbuild", _csprojPath, "-getProperty:TargetFrameworks"],
            _projectRoot,
            dryRun: false,
            cancellationToken).ConfigureAwait(false);
        if (!result.Success)
        {
            return $"Cannot evaluate target frameworks from '{Path.GetFileName(_csprojPath)}' using MSBuild (exit {result.ExitCode}). {result.StandardError}";
        }

        var frameworksOutput = result.StandardOutput.TrimStart().StartsWith("{", StringComparison.Ordinal)
            ? TryReadEvaluatedProperty(result.StandardOutput, "TargetFrameworks")
            : result.StandardOutput.Trim();
        var frameworks = frameworksOutput
            .Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
        if (frameworks.Count == 0)
        {
            result = await _dotnet.RunAsync(
                ["msbuild", _csprojPath, "-getProperty:TargetFramework"],
                _projectRoot,
                dryRun: false,
                cancellationToken).ConfigureAwait(false);
            if (!result.Success)
            {
                return $"Cannot evaluate target framework from '{Path.GetFileName(_csprojPath)}' using MSBuild (exit {result.ExitCode}). {result.StandardError}";
            }

            frameworks = (result.StandardOutput.TrimStart().StartsWith("{", StringComparison.Ordinal)
                    ? TryReadEvaluatedProperty(result.StandardOutput, "TargetFramework")
                    : result.StandardOutput.Trim())
                .Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();
        }

        if (frameworks.Count == 0)
        {
            return $"Cannot establish control compatibility because MSBuild evaluated no TargetFramework or TargetFrameworks value in '{Path.GetFileName(_csprojPath)}'.";
        }

        _targetFrameworks = frameworks;
        return null;
    }

    private Dictionary<string, string> ReadAndValidateTemplate(
        ControlCatalogEntry entry,
        string projectName,
        string rootNamespace)
    {
        return RenderTemplate(entry, projectName, rootNamespace).Text;
    }

    private (Dictionary<string, string> Text, Dictionary<string, byte[]> Binary) RenderTemplate(
        ControlCatalogEntry entry,
        string projectName,
        string rootNamespace)
    {
        var values = PlaceholderReplacer.BuildValues(projectName, rootNamespace, entry.ControlName, MauiTemplateNames.ViewName(entry.ControlName));
        var contentByDestination = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var binaryByDestination = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase);
        foreach (var file in entry.GeneratedFiles)
        {
            TemplatePathResolver.ValidateRelativePath(file.Destination);
            TemplatePathResolver.ValidateRelativePath(file.TemplateResource);
            var resourceName = TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource);
            if (EmbeddedResourceLoader.IsBinaryFile(file.Destination))
            {
                // Binary resources are copied byte-for-byte; no placeholder
                // substitution and no text round-trip that would corrupt them.
                if (!binaryByDestination.TryAdd(file.Destination, EmbeddedResourceLoader.ReadBytes(resourceName)))
                {
                    throw new InvalidOperationException($"Control '{entry.Id}' maps more than one resource to '{file.Destination}'.");
                }
                continue;
            }

            var template = EmbeddedResourceLoader.ReadText(resourceName);
            var content = PlaceholderReplacer.Replace(template, values);
            if (PlaceholderReplacer.Tokens.Any(content.Contains))
            {
                throw new InvalidOperationException($"Control resource '{resourceName}' contains an unresolved placeholder.");
            }

            if (!contentByDestination.TryAdd(file.Destination, content))
            {
                throw new InvalidOperationException($"Control '{entry.Id}' maps more than one resource to '{file.Destination}'.");
            }
        }

        if (contentByDestination.Count + binaryByDestination.Count != entry.GeneratedFiles.Count)
        {
            throw new InvalidOperationException($"Control '{entry.Id}' maps more than one resource to the same destination.");
        }

        foreach (var file in entry.GeneratedFiles.Where(file => file.Destination.EndsWith(".xaml", StringComparison.OrdinalIgnoreCase)))
        {
            var xaml = XDocument.Parse(contentByDestination[file.Destination]);
            var xClass = xaml.Root?.Attribute(XName.Get("Class", "http://schemas.microsoft.com/winfx/2009/xaml"))?.Value;
            var codeBehindPath = file.Destination + ".cs";
            if (xClass is null || !contentByDestination.TryGetValue(codeBehindPath, out var codeBehind))
            {
                throw new InvalidOperationException($"Control '{entry.Id}' has an incomplete XAML/code-behind mapping for '{file.Destination}'.");
            }

            var namespaceMatch = Regex.Match(codeBehind, @"\bnamespace\s+([\p{L}_][\p{L}\p{N}_.]*)", RegexOptions.CultureInvariant);
            var classMatch = Regex.Match(codeBehind, @"\bpartial\s+class\s+([\p{L}_][\p{L}\p{N}_]*)", RegexOptions.CultureInvariant);
            if (!namespaceMatch.Success
                || !classMatch.Success
                || !string.Equals(
                    xClass,
                    $"{namespaceMatch.Groups[1].Value}.{classMatch.Groups[1].Value}",
                    StringComparison.Ordinal))
            {
                throw new InvalidOperationException($"Control '{entry.Id}' has mismatched XAML x:Class and code-behind identity.");
            }
        }

        return (contentByDestination, binaryByDestination);
    }

    private static void AddCentralPackageVersion(XDocument document, string packageId, string version)
    {
        var matches = document.Descendants()
            .Where(element => element.Name.LocalName.Equals("PackageVersion", StringComparison.OrdinalIgnoreCase)
                && string.Equals((string?)element.Attribute("Include"), packageId, StringComparison.OrdinalIgnoreCase)
                && element.Parent?.Name.LocalName.Equals("ItemGroup", StringComparison.OrdinalIgnoreCase) == true)
            .ToList();
        if (matches.Count > 1)
        {
            throw new InvalidOperationException($"Central package file contains duplicate entries for '{packageId}'. Resolve them before retrying.");
        }

        if (matches.Count == 1)
        {
            var existingVersion = (string?)matches[0].Attribute("Version") ?? matches[0].Elements().FirstOrDefault(element => element.Name.LocalName.Equals("Version", StringComparison.OrdinalIgnoreCase))?.Value;
            if (!string.Equals(existingVersion, version, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException($"Central package file already defines '{packageId}' with conflicting version '{existingVersion}'. Resolve it before retrying.");
            }

            if (matches[0].Attribute("Version") is null && matches[0].Elements().FirstOrDefault(element => element.Name.LocalName.Equals("Version", StringComparison.OrdinalIgnoreCase)) is { } versionElement)
            {
                versionElement.Value = version;
            }

            return;
        }

        var project = document.Root;
        if (project is null || !project.Name.LocalName.Equals("Project", StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException("The evaluated central package file does not have a valid Project root element.");
        }

        var itemGroup = project.Elements().FirstOrDefault(element => element.Name.LocalName.Equals("ItemGroup", StringComparison.OrdinalIgnoreCase));
        if (itemGroup is null)
        {
            itemGroup = new XElement(project.Name.Namespace + "ItemGroup");
            project.Add(itemGroup);
        }

        itemGroup.Add(new XElement(project.Name.Namespace + "PackageVersion", new XAttribute("Include", packageId), new XAttribute("Version", version)));
    }

    private static IEnumerable<string> FindCentralPackageProps(string projectRoot)
    {
        var directory = new DirectoryInfo(projectRoot);
        while (directory is not null)
        {
            var candidate = Path.Combine(directory.FullName, "Directory.Packages.props");
            if (File.Exists(candidate))
            {
                yield return candidate;
                yield break;
            }

            directory = directory.Parent;
        }
    }

    private static void AddDistinct(ICollection<string> destination, IEnumerable<string> values)
    {
        foreach (var value in values)
        {
            if (!destination.Contains(value, StringComparer.OrdinalIgnoreCase))
            {
                destination.Add(value);
            }
        }
    }

    private void TrackNuGetProjectState(FileRollback rollback, string? evaluatedPropsPath = null)
    {
        rollback.TrackModified(_csprojPath);
        if (!string.IsNullOrWhiteSpace(evaluatedPropsPath))
        {
            rollback.TrackModified(evaluatedPropsPath);
        }

        foreach (var centralProps in FindCentralPackageProps(_projectRoot))
        {
            rollback.TrackModified(centralProps);
        }

        rollback.TrackModified(Path.Combine(_projectRoot, "packages.lock.json"));
        rollback.TrackModified(Path.Combine(_projectRoot, "obj", "project.assets.json"));
        rollback.TrackModified(Path.Combine(_projectRoot, "obj", "project.nuget.cache"));
    }

    private string? FindDestinationCaseConflict(string relativePath)
    {
        var currentPath = _projectRoot;
        foreach (var segment in relativePath.Replace('\\', '/').Split('/'))
        {
            if (!Directory.Exists(currentPath))
            {
                return null;
            }

            var matches = Directory.EnumerateFileSystemEntries(currentPath)
                .Select(Path.GetFileName)
                .Where(name => name is not null && name.Equals(segment, StringComparison.OrdinalIgnoreCase))
                .ToList();
            if (matches.Count == 0)
            {
                return null;
            }

            if (matches.Count > 1)
            {
                return Path.Combine(currentPath, segment);
            }

            var existingSegment = matches[0]!;
            if (!existingSegment.Equals(segment, StringComparison.Ordinal))
            {
                return Path.Combine(currentPath, existingSegment);
            }

            currentPath = Path.Combine(currentPath, segment);
        }

        return null;
    }

    private async Task<string?> ResolvePackageVersion(
        string projectPath,
        string packageId,
        NuGetCommandResult? result,
        string? requestedVersion,
        string? source,
        string? configFile,
        CancellationToken cancellationToken)
    {
        if (requestedVersion is not null)
        {
            return IsExactVersion(requestedVersion) ? requestedVersion : null;
        }

        if (result is not null)
        {
            var installed = DiscoveryService.ListInstalledPackages(projectPath)
                .FirstOrDefault(package => package.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase));
            var installedVersion = installed?.Version is { } candidate && IsStableExactVersion(candidate) ? candidate : null;
            var reportedVersion = ExtractResolvedVersion(result);
            if (installedVersion is not null || reportedVersion is not null)
            {
                return installedVersion ?? reportedVersion;
            }
        }

        var args = new List<string> { "package", "search", packageId, "--exact-match", "--format", "json" };
        AppendSourceAndConfigFile(args, source, configFile);

        var search = await _dotnet.RunAsync(args, _projectRoot, dryRun: false, cancellationToken).ConfigureAwait(false);
        if (!search.Success)
        {
            return null;
        }

        try
        {
            using var document = JsonDocument.Parse(search.StandardOutput);
            if (!document.RootElement.TryGetProperty("searchResult", out var searchResults)
                || searchResults.ValueKind != JsonValueKind.Array)
            {
                return null;
            }

            var versions = searchResults.EnumerateArray()
                .Where(resultItem => !resultItem.TryGetProperty("packages", out _) || resultItem.GetProperty("packages").ValueKind == JsonValueKind.Array)
                .SelectMany(resultItem => resultItem.TryGetProperty("packages", out var packages)
                    ? packages.EnumerateArray().ToArray()
                    : [])
                .Where(package => package.TryGetProperty("id", out var id)
                    && id.GetString()?.Equals(packageId, StringComparison.OrdinalIgnoreCase) == true
                    && package.TryGetProperty("version", out var packageVersion)
                    && packageVersion.ValueKind == JsonValueKind.String)
                .Select(package => package.GetProperty("version").GetString()!)
                .Where(candidate => IsStableExactVersion(candidate))
                .Select(candidate => System.Version.TryParse(candidate, out var parsed) ? parsed : null)
                .Where(candidate => candidate is not null)
                .OrderByDescending(candidate => candidate)
                .FirstOrDefault();
            return versions?.ToString();
        }
        catch (Exception) when (!cancellationToken.IsCancellationRequested)
        {
            return null;
        }
    }

    private static bool IsStableExactVersion(string version)
        => IsExactVersion(version)
            && !version.Contains('-', StringComparison.Ordinal)
            && System.Version.TryParse(version, out _);

    private static bool IsExactVersion(string version)
        => Regex.IsMatch(
            version,
            @"\A\d+(?:\.\d+){1,3}(?:-[0-9A-Za-z.-]+)?(?:\+[0-9A-Za-z.-]+)?\z",
            RegexOptions.CultureInvariant);

    private static string? ExtractResolvedVersion(NuGetCommandResult result)
    {
        // dotnet add package prints the resolved version in stdout, quoted
        // (e.g. "version '100.2.2032' added"); this is a best-effort parse
        // and falls back to null ("latest") if not found.
        var match = System.Text.RegularExpressions.Regex.Match(
            result.StandardOutput,
            @"version\s+'?(\d+(?:\.\d+){1,3})'?",
            System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        return match.Success ? match.Groups[1].Value : null;
    }

    private static string? ExtractRestoredPackageVersion(string projectRoot, string packageId)
    {
        var assetsPath = Path.Combine(projectRoot, "obj", "project.assets.json");
        if (!File.Exists(assetsPath))
        {
            return null;
        }

        using var document = JsonDocument.Parse(File.ReadAllText(assetsPath));
        if (!document.RootElement.TryGetProperty("libraries", out var libraries)
            || libraries.ValueKind != JsonValueKind.Object)
        {
            return null;
        }

        var versions = libraries.EnumerateObject()
            .Where(library => library.Value.TryGetProperty("type", out var type)
                && type.ValueKind == JsonValueKind.String
                && type.GetString()!.Equals("package", StringComparison.OrdinalIgnoreCase))
            .Select(library => library.Name)
            .Select(name =>
            {
                var separator = name.LastIndexOf('/');
                return separator > 0
                    && name[..separator].Equals(packageId, StringComparison.OrdinalIgnoreCase)
                    ? name[(separator + 1)..]
                    : null;
            })
            .Where(candidate => candidate is not null && IsExactVersion(candidate))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        return versions.Count == 1 ? versions[0] : null;
    }

    private static IReadOnlyList<string> AllControlIds()
        => TemplateCatalog.All.Select(c => c.Id).ToList();

    /// <summary>The ids of controls whose metadata is verified and operable.</summary>
    private static IReadOnlyList<string> AllVerifiedControlIds()
        => TemplateCatalog.Operable.Select(c => c.Id).ToList();

    private static ControlOperationResult Fail(string message)
        => new() { ExitCode = ExitCodes.Error, Message = message };
}
