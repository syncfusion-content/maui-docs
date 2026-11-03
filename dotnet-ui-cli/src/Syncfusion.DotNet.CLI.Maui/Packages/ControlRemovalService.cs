using System.Xml.Linq;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Maui.Injection;
using Syncfusion.DotNet.Cli.Maui.Manifest;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Preflights the entire removal and commits files, code, registry and references together.</summary>
public sealed class ControlRemovalService(ProjectDetector.ProjectInfo project, NuGetRunner? nuget = null, DotNetRunner? dotnet = null)
{
    private readonly NuGetRunner _nuget = nuget ?? new NuGetRunner();
    private readonly DotNetRunner _dotnet = dotnet ?? new DotNetRunner();
    private readonly string _root = Path.GetDirectoryName(MauiProjectResolver.ValidateMauiProject(project).CsprojPath)!;

    public ControlOperationResult Plan(IReadOnlyList<string> ids, bool dryRun = false, bool noRestore = false,
        string? source = null, string? configFile = null, string? packageId = null)
    {
        try
        {
            var prepared = Prepare(ids, dryRun, noRestore, source, configFile, packageId);
            return new ControlOperationResult { ExitCode = ExitCodes.Success, Message = "Removal validated. No changes made.", Plan = prepared.Plan };
        }
        catch (Exception ex) when (ex is IOException or InvalidOperationException or System.Text.Json.JsonException or UnauthorizedAccessException)
        {
            return Fail(ex.Message);
        }
    }

    public async Task<ControlOperationResult> ExecuteAsync(IReadOnlyList<string> ids, bool dryRun = false,
        bool noRestore = false, string? source = null, string? configFile = null, string? packageId = null,
        CancellationToken cancellationToken = default, bool build = false, string? buildFramework = null, IProgress<string>? progress = null)
    {
        Prepared prepared;
        try { prepared = Prepare(ids, dryRun, noRestore, source, configFile, packageId); }
        catch (Exception ex) when (ex is IOException or InvalidOperationException or System.Text.Json.JsonException or UnauthorizedAccessException)
        { return Fail(ex.Message); }
        var plan = prepared.Plan;
        if (dryRun) return new ControlOperationResult { ExitCode = ExitCodes.Success, Message = "Dry run: removal validated. No changes made.", Plan = plan };
        if (prepared.Entries.Count == 0 && plan.PackagesToRemove.Count == 0)
            return new ControlOperationResult { ExitCode = ExitCodes.Success, Message = "Nothing to remove. No changes made. No rebuild required.", Plan = plan };

        using var rollback = new FileRollback();
        using var stages = new OperationStages(progress);
        bool? buildSucceeded = null;
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            // Re-read and revalidate immediately before the first mutation.
            prepared = Prepare(ids, false, noRestore, source, configFile, packageId);
            plan = prepared.Plan;
            TrackProjectState(rollback);
            if (plan.FilesToDelete.Count > 0) stages.Plan("Removing files");
            var updating = prepared.BlocksToRemove.Count > 0 ? "Updating registration" : "Updating navigation";
            if (prepared.Entries.Count > 0 || prepared.BlocksToRemove.Count > 0) stages.Plan(updating);
            if (plan.PackagesToRemove.Count > 0) stages.Plan("Removing packages");
            if (prepared.Manifest is not null) stages.Plan("Writing control manifest");
            if (build) stages.Plan("Building");
            if (plan.FilesToDelete.Count > 0) stages.Start("Removing files");
            var deletedFiles = 0;
            stages.Advance(0, plan.FilesToDelete.Count);
            foreach (var file in plan.FilesToDelete)
            {
                var path = TemplatePathResolver.ResolveDestination(_root, file);
                rollback.TrackModified(path);
                File.Delete(path);
                stages.Advance(++deletedFiles, plan.FilesToDelete.Count);
            }
            foreach (var path in plan.FilesToModify)
                rollback.TrackModified(TemplatePathResolver.ResolveDestination(_root, path));

            stages.Complete();
            if (prepared.Entries.Count > 0 || prepared.BlocksToRemove.Count > 0) stages.Start(updating);
            var manifest = prepared.Manifest;
            if (manifest is not null)
            {
                var selected = prepared.Entries.Select(entry => entry.Id).ToHashSet(StringComparer.OrdinalIgnoreCase);
                foreach (var block in manifest.GeneratedBlocks.Where(block => prepared.BlocksToRemove.Contains(block.Marker)).ToList())
                {
                    var path = TemplatePathResolver.ResolveDestination(_root, block.Path);
                    File.WriteAllText(path, GeneratedCodeBlocks.Remove(File.ReadAllText(path), block.Marker));
                    manifest.GeneratedBlocks.Remove(block);
                }
                manifest.InstalledControls.RemoveAll(id => TemplateCatalog.TryResolve(id, out var entry) && selected.Contains(entry.Id));
                manifest.InstalledTemplates.RemoveAll(record => selected.Contains(record.Id));
                foreach (var file in plan.FilesToDelete)
                {
                    manifest.GeneratedFiles.RemoveAll(path => path.Equals(file, StringComparison.OrdinalIgnoreCase));
                    manifest.OriginalHashes.Remove(file);
                }
                if (prepared.Entries.Count > 0 && manifest.GeneratedFiles.Contains(WelcomeProjectGenerator.RegistryPath, StringComparer.OrdinalIgnoreCase))
                {
                    var remaining = manifest.InstalledControls.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry) ? entry : null)
                        .Where(entry => entry is not null).Cast<ControlCatalogEntry>();
                    WelcomeProjectGenerator.WriteRegistry(_root, RootNamespace, remaining, rollback, manifest);
                }
                if (prepared.BlocksToRemove.Contains("core-registration")) manifest.RegistrationOwned = false;
                if (prepared.Entries.Any(SampleResourceEmbedding.NeedsEmbedding))
                    SampleResourceEmbedding.Remove(project.CsprojPath, rollback, manifest);
            }

            stages.Complete();
            if (plan.PackagesToRemove.Count > 0) stages.Start("Removing packages");
            var removedPackages = 0;
            stages.Advance(0, plan.PackagesToRemove.Count);
            foreach (var removedPackage in plan.PackagesToRemove)
            {
                var result = await _nuget.RunAsync(new NuGetOperation
                {
                    Kind = NuGetOperationKind.Remove, ProjectPath = project.CsprojPath, PackageId = removedPackage,
                    WorkingDirectory = _root, NoRestore = noRestore, Source = source, ConfigFile = configFile,
                }, cancellationToken).ConfigureAwait(false);
                if (!result.Success) throw new InvalidOperationException($"Package removal failed for '{removedPackage}' (exit {result.ExitCode}). {result.StandardError}");
                manifest?.PackageIds.RemoveAll(id => id.Equals(removedPackage, StringComparison.OrdinalIgnoreCase));
                manifest?.PackageVersions.Remove(removedPackage);
                manifest?.PackageRequestedVersions.Remove(removedPackage);
                stages.Advance(++removedPackages, plan.PackagesToRemove.Count);
            }
            _ = XDocument.Load(project.CsprojPath);
            stages.Complete();
            if (manifest is not null)
            {
                stages.Start("Writing control manifest", reportLegacy: false);
                WelcomeProjectGenerator.SaveManifest(_root, manifest, rollback);
                stages.Complete();
            }
            if (build)
            {
                stages.Start("Building");
                var built = await new MauiPostCreationBuild(_dotnet).ExecuteAsync(project.CsprojPath, buildFramework, cancellationToken).ConfigureAwait(false);
                buildSucceeded = built.Success;
                if (!built.Success) throw new InvalidOperationException($"Build failed. {built.StandardError}{built.StandardOutput}");
                stages.Complete();
            }
            rollback.Commit();
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success, Plan = plan,
                Message = $"Removed samples: {(prepared.Entries.Count == 0 ? "none" : string.Join(", ", prepared.Entries.Select(entry => entry.DisplayName)))}. Deleted {plan.FilesToDelete.Count} generated file(s). Removed packages: {(plan.PackagesToRemove.Count == 0 ? "none" : string.Join(", ", plan.PackagesToRemove))}. Build: {(build ? "succeeded; run the project to see changes" : "not requested. Rebuild the project to apply these changes")}.",
                PackageChangesSucceeded = true, SampleGenerationSucceeded = true, BuildSucceeded = build ? true : null,
            };
        }
        catch (OperationCanceledException) { rollback.Rollback(); throw; }
        catch (Exception ex)
        {
            var errors = rollback.Rollback();
            return new ControlOperationResult { ExitCode = ExitCodes.Error, Message = $"Removal failed; tracked changes were rolled back. {ex.Message}", Errors = errors, Plan = plan,
                PackageChangesSucceeded = false, SampleGenerationSucceeded = false, BuildSucceeded = buildSucceeded };
        }
    }

    private string RootNamespace => PlaceholderReplacer.NormalizeRootNamespace(project.RootNamespace ?? Path.GetFileNameWithoutExtension(project.CsprojPath));

    private Prepared Prepare(IReadOnlyList<string> ids, bool dryRun, bool noRestore, string? source, string? configFile, string? requestedPackage)
    {
        var manifest = WelcomeProjectGenerator.ReadManifest(_root, project);
        var candidates = ids.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry)
            ? entry : throw new InvalidOperationException($"Control '{id}' is not supported.")).DistinctBy(entry => entry.Id).ToList();
        var installed = manifest?.InstalledControls.Select(id => TemplateCatalog.TryResolveOperableTemplate(id, out var entry) ? entry : null)
            .Where(entry => entry is not null).Cast<ControlCatalogEntry>().ToList() ?? [];
        if (requestedPackage is not null)
            candidates = installed.Where(entry => Dependencies(entry, manifest).Contains(requestedPackage, StringComparer.OrdinalIgnoreCase)).ToList();
        var entries = candidates.Where(entry => installed.Any(other => other.Id == entry.Id)).ToList();
        var selected = entries.Select(entry => entry.Id).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var remaining = installed.Where(entry => !selected.Contains(entry.Id)).ToList();
        var plan = new ChangePlan { ControlId = string.Join(',', entries.Select(entry => entry.Id)), IsDryRun = dryRun };
        var blocksToRemove = entries.Select(entry => "sf-nav:" + entry.ControlName).ToHashSet(StringComparer.Ordinal);
        var excluded = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { WelcomeProjectGenerator.RegistryPath };

        if (entries.Count > 0 && WelcomeProjectGenerator.RegistryConflict(_root, manifest) is { } registryConflict)
            throw new InvalidOperationException(registryConflict);
        var requiresCoreValidation = entries.Any(entry => entry.RegistrationRequirement == "syncfusion-core")
            || requestedPackage is not null && (requestedPackage.Equals("Syncfusion.Maui.Core", StringComparison.OrdinalIgnoreCase)
                || PackageCatalog.TryResolve(requestedPackage, out var requestedDefinition) && requestedDefinition.RegistrationRequirement == "syncfusion-core");
        foreach (var block in manifest?.GeneratedBlocks.Where(block => blocksToRemove.Contains(block.Marker)
            || block.Marker.StartsWith("core-", StringComparison.Ordinal) && requiresCoreValidation) ?? [])
            if (GeneratedCodeBlocks.Conflict(_root, block) is { } conflict) throw new InvalidOperationException("Conflict: " + conflict);
        foreach (var entry in entries)
        {
            var record = manifest!.InstalledTemplates.FirstOrDefault(record => record.Id.Equals(entry.Id, StringComparison.OrdinalIgnoreCase));
            var files = record?.GeneratedFiles ?? entry.GeneratedFiles.Select(file => file.Destination).ToList();
            foreach (var file in files)
            {
                var path = TemplatePathResolver.ResolveDestination(_root, file);
                if (!manifest.GeneratedFiles.Contains(file, StringComparer.OrdinalIgnoreCase))
                { plan.Warnings.Add($"Retained untracked file '{file}'."); continue; }
                if (manifest.InstalledTemplates.Any(other => !selected.Contains(other.Id) && other.GeneratedFiles.Contains(file, StringComparer.OrdinalIgnoreCase)))
                { plan.Warnings.Add($"Retained shared generated file '{file}'."); continue; }
                if (File.Exists(path) && (manifest.OriginalHashes.GetValueOrDefault(file) is not { } hash || hash != FileRollback.ComputeHash(path)))
                    throw new InvalidOperationException($"Conflict: generated file '{file}' was edited or its ownership hash is missing. Control '{entry.Id}' retained. No changes made.");
                excluded.Add(file);
                plan.FilesToDelete.Add(file);
            }
        }
        foreach (var entry in entries)
            if (CustomDependencyInspector.FindSampleUse(_root, entry, manifest!, excluded) is { } customFile)
                throw new InvalidOperationException($"Conflict: custom code in '{customFile}' references sample '{entry.Id}'. The sample and its dependencies were retained. No changes made.");

        var direct = DiscoveryService.ListInstalledPackages(project.CsprojPath);
        var packageCandidates = entries.SelectMany(entry => entry.DependentPackageIds.Prepend(entry.PackageId))
            .Concat(requestedPackage is null ? [] : new[] { requestedPackage }).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        var customCoreUse = CustomDependencyInspector.FindPackageUse(_root, "Syncfusion.Maui.Core", manifest, excluded);
        // Keep one existing Core provider for custom code, rather than retaining every unrelated control package.
        var coreProvider = customCoreUse is null ? null : direct
            .Where(item => item.PackageId.Equals("Syncfusion.Maui.Core", StringComparison.OrdinalIgnoreCase)
                || PackageCatalog.TryResolve(item.PackageId, out var definition) && definition.RegistrationRequirement == "syncfusion-core")
            .OrderByDescending(item => item.PackageId.Equals("Syncfusion.Maui.Core", StringComparison.OrdinalIgnoreCase))
            .ThenByDescending(item => CustomDependencyInspector.FindPackageUse(_root, item.PackageId, manifest, excluded) is not null)
            .ThenByDescending(item => !packageCandidates.Contains(item.PackageId, StringComparer.OrdinalIgnoreCase))
            .ThenBy(item => item.PackageId, StringComparer.OrdinalIgnoreCase).FirstOrDefault()?.PackageId;
        foreach (var package in packageCandidates)
        {
            if (!direct.Any(item => item.PackageId.Equals(package, StringComparison.OrdinalIgnoreCase))) continue;
            if (remaining.Any(entry => Dependencies(entry, manifest).Contains(package, StringComparer.OrdinalIgnoreCase))
                || manifest?.InstalledTemplates.Any(record => !selected.Contains(record.Id)
                    && record.PackageDependencies.Append(record.PackageId).Contains(package, StringComparer.OrdinalIgnoreCase)) == true)
            { plan.Warnings.Add($"Retained package '{package}': required by another sample."); continue; }
            if (CustomDependencyInspector.FindPackageUse(_root, package, manifest, excluded) is { } customFile)
            { plan.Warnings.Add($"Retained package '{package}': referenced by custom code in '{customFile}'."); continue; }
            if (package.Equals(coreProvider, StringComparison.OrdinalIgnoreCase))
            { plan.Warnings.Add($"Retained package '{package}': provides dependencies for custom Syncfusion code in '{customCoreUse}'."); continue; }
            if (!package.Equals(requestedPackage, StringComparison.OrdinalIgnoreCase))
            {
                var expected = manifest?.PackageVersions.GetValueOrDefault(package);
                var current = direct.First(item => item.PackageId.Equals(package, StringComparison.OrdinalIgnoreCase)).Version;
                if (manifest?.PackageIds.Contains(package, StringComparer.OrdinalIgnoreCase) != true
                    || expected is not null && current != expected && current != "*")
                { plan.Warnings.Add($"Retained package '{package}': its reference is user-owned or its version no longer matches the recorded version."); continue; }
            }
            plan.PackagesToRemove.Add(package);
        }

        if ((entries.Count > 0 || plan.PackagesToRemove.Count > 0) && manifest is not null
            && (manifest.RegistrationOwned || manifest.GeneratedBlocks.Any(block => block.Marker is "core-using" or "core-registration"))
            && remaining.All(entry => entry.RegistrationRequirement != "syncfusion-core"))
        {
            var packagesNeedingRegistration = direct.Where(item => !plan.PackagesToRemove.Contains(item.PackageId, StringComparer.OrdinalIgnoreCase))
                .Any(item => PackageCatalog.TryResolve(item.PackageId, out var package) && package.RegistrationRequirement != "none");
            var customUse = CustomDependencyInspector.FindPackageUse(_root, "Syncfusion.Maui.Core", manifest, excluded);
            if (packagesNeedingRegistration || customUse is not null
                || manifest.InstalledControls.Any(id => !selected.Contains(id) && !TemplateCatalog.TryResolveOperableTemplate(id, out _)))
                plan.Warnings.Add("Retained shared Syncfusion registration: required by remaining packages or custom code.");
            else
            {
                blocksToRemove.Add("core-registration");
                blocksToRemove.Add("core-using");
                if (!manifest.GeneratedBlocks.Any(block => block.Marker == "core-registration"))
                    plan.Warnings.Add("Retained legacy registration: inserted-code ownership cannot be verified.");
            }
        }
        foreach (var block in manifest?.GeneratedBlocks.Where(block => blocksToRemove.Contains(block.Marker)) ?? [])
        {
            if (GeneratedCodeBlocks.Conflict(_root, block) is { } conflict) throw new InvalidOperationException("Conflict: " + conflict);
            if (!plan.FilesToModify.Contains(block.Path)) plan.FilesToModify.Add(block.Path);
        }
        if (entries.Count > 0 || manifest is not null && plan.PackagesToRemove.Count > 0)
        {
            plan.FilesToModify.Add(WelcomeProjectGenerator.ManifestPath);
            if (entries.Count > 0 && manifest!.GeneratedFiles.Contains(WelcomeProjectGenerator.RegistryPath, StringComparer.OrdinalIgnoreCase)) plan.FilesToModify.Add(WelcomeProjectGenerator.RegistryPath);
        }
        foreach (var package in plan.PackagesToRemove)
            plan.CommandsToExecute.Add(NuGetArgumentBuilder.FormatCommandLine(NuGetArgumentBuilder.Build(new NuGetOperation
            { Kind = NuGetOperationKind.Remove, ProjectPath = project.CsprojPath, PackageId = package, NoRestore = noRestore, Source = source, ConfigFile = configFile })));
        return new Prepared(manifest, entries, plan, blocksToRemove);
    }

    private void TrackProjectState(FileRollback rollback)
    {
        rollback.TrackModified(project.CsprojPath);
        foreach (var relative in new[] { WelcomeProjectGenerator.ManifestPath, "packages.lock.json", "obj/project.assets.json", "obj/project.nuget.cache" })
            rollback.TrackModified(TemplatePathResolver.ResolveDestination(_root, relative));
        for (var directory = _root; directory is not null; directory = Path.GetDirectoryName(directory))
        {
            var props = Path.Combine(directory, "Directory.Packages.props");
            if (File.Exists(props)) rollback.TrackModified(props);
        }
    }
    private static IEnumerable<string> Dependencies(ControlCatalogEntry entry, SyncfusionManifest? manifest)
        => manifest?.InstalledTemplates.FirstOrDefault(record => record.Id == entry.Id)?.PackageDependencies
            .Concat(entry.DependentPackageIds).Append(entry.PackageId)
            ?? entry.DependentPackageIds.Prepend(entry.PackageId);
    private static ControlOperationResult Fail(string error)
        => new() { ExitCode = ExitCodes.Error, Message = error };
    private sealed record Prepared(SyncfusionManifest? Manifest, List<ControlCatalogEntry> Entries, ChangePlan Plan, HashSet<string> BlocksToRemove);
}
