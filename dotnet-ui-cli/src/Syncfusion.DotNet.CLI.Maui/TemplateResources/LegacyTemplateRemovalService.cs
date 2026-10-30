using System.IO;
using System.Linq;
using System.Text.Json;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui.Manifest;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Removes legacy unsupported templates using manifest ownership metadata only.</summary>
public sealed class LegacyTemplateRemovalService
{
    private readonly string _projectRoot;
    private readonly string _projectFile;

    /// <summary>Creates a remover for a resolved MAUI project.</summary>
    public LegacyTemplateRemovalService(ProjectDetector.ProjectInfo project)
    {
        var validatedProject = MauiProjectResolver.ValidateMauiProject(project);
        _projectFile = Path.GetFileName(validatedProject.CsprojPath);
        _projectRoot = Path.GetDirectoryName(validatedProject.CsprojPath)
            ?? throw new InvalidOperationException($"Project path '{validatedProject.CsprojPath}' has no parent directory.");
    }

    /// <summary>Plans removal of one or more recognized legacy templates.</summary>
    public ControlOperationResult PlanRemove(IReadOnlyList<string> templateIds, bool dryRun = false)
    {
        var prepared = Prepare(templateIds, dryRun);
        return prepared.Error is not null
            ? Failure(prepared.Error)
            : new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Planned removal of {templateIds.Count} legacy unsupported control(s).",
                Plan = prepared.Plan,
            };
    }

    /// <summary>
    /// Removes only unchanged files whose per-template and manifest ownership
    /// metadata is complete. User-modified and shared files are preserved.
    /// </summary>
    public ControlOperationResult ExecuteRemove(IReadOnlyList<string> templateIds, bool dryRun = false, IProgress<string>? progress = null)
    {
        var prepared = Prepare(templateIds, dryRun);
        if (prepared.Error is not null)
        {
            return Failure(prepared.Error);
        }

        if (dryRun)
        {
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Dry run: would remove {templateIds.Count} legacy unsupported control(s).",
                Plan = prepared.Plan,
            };
        }

        var manifest = prepared.Manifest!;
        var plan = prepared.Plan!;
        var selectedIds = templateIds.ToHashSet(StringComparer.OrdinalIgnoreCase);
        var manifestPath = ManifestPath;
        var deletedFiles = new List<string>();
        using var rollback = new FileRollback();
        using var stages = new OperationStages(progress);
        try
        {
            rollback.TrackModified(manifestPath);
            if (plan.FilesToDelete.Count > 0)
            {
                stages.Plan("Removing files", "Writing control manifest");
                stages.Start("Removing files");
            }
            var filesToProcess = plan.FilesToDelete.ToList();
            var processedFiles = 0;
            stages.Advance(0, filesToProcess.Count);
            foreach (var relativePath in filesToProcess)
            {
                var destination = TemplatePathResolver.ResolveDestination(_projectRoot, relativePath);
                if (!File.Exists(destination))
                {
                    stages.Advance(++processedFiles, filesToProcess.Count);
                    continue;
                }

                var expectedHash = manifest.OriginalHashes[relativePath];
                if (!string.Equals(FileRollback.ComputeHash(destination), expectedHash, StringComparison.OrdinalIgnoreCase))
                {
                    plan.FilesToDelete.Remove(relativePath);
                    plan.Warnings.Add($"Preserved modified file '{relativePath}' because its contents no longer match the recorded ownership hash.");
                    stages.Advance(++processedFiles, filesToProcess.Count);
                    continue;
                }

                rollback.TrackModified(destination);
                File.Delete(destination);
                deletedFiles.Add(relativePath);
                stages.Advance(++processedFiles, filesToProcess.Count);
            }

            stages.Complete();
            stages.Start("Writing control manifest", reportLegacy: false);
            var removedRecords = manifest.InstalledTemplates
                .Where(record => selectedIds.Contains(record.Id))
                .ToList();
            manifest.InstalledTemplates.RemoveAll(record => selectedIds.Contains(record.Id));
            manifest.InstalledControls.RemoveAll(id => selectedIds.Contains(id));
            foreach (var file in removedRecords.SelectMany(record => record.GeneratedFiles).Distinct(StringComparer.OrdinalIgnoreCase))
            {
                var stillOwned = manifest.InstalledTemplates.Any(record =>
                    record.GeneratedFiles.Contains(file, StringComparer.OrdinalIgnoreCase));
                if (!stillOwned)
                {
                    manifest.GeneratedFiles.RemoveAll(path => path.Equals(file, StringComparison.OrdinalIgnoreCase));
                    manifest.OriginalHashes.Remove(file);
                    manifest.ModifiedFiles.RemoveAll(path => path.Equals(file, StringComparison.OrdinalIgnoreCase));
                }
            }

            Directory.CreateDirectory(Path.GetDirectoryName(manifestPath)!);
            File.WriteAllText(manifestPath, manifest.ToJson());
            rollback.Commit();
            stages.Complete();

            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Removed {templateIds.Count} legacy unsupported control(s); deleted {deletedFiles.Count} tracked file(s).",
                Plan = plan,
            };
        }
        catch (Exception exception) when (exception is IOException
            or UnauthorizedAccessException
            or InvalidOperationException
            or JsonException)
        {
            var rollbackErrors = rollback.Rollback();
            return new ControlOperationResult
            {
                ExitCode = ExitCodes.Error,
                Message = $"Could not safely remove the legacy unsupported control(s): {exception.Message}",
                Plan = plan,
                Errors = rollbackErrors,
            };
        }
    }

    private string ManifestPath
        => Path.Combine(_projectRoot, "Syncfusion", "syncfusion.json");

    private PreparedRemoval Prepare(IReadOnlyList<string> templateIds, bool dryRun)
    {
        if (templateIds.Count == 0)
        {
            return PreparedRemoval.Fail("At least one legacy control ID is required.");
        }

        var selectedIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var id in templateIds)
        {
            if (!LegacyUnsupportedTemplateCatalog.Contains(id))
            {
                return PreparedRemoval.Fail($"Control '{id}' is not a recognized legacy unsupported control.");
            }

            if (!selectedIds.Add(id))
            {
                return PreparedRemoval.Fail($"Control '{id}' is selected more than once.");
            }
        }

        SyncfusionManifest manifest;
        try
        {
            manifest = SyncfusionManifest.FromJson(File.ReadAllText(ManifestPath));
            if (manifest.ProjectFile.Length > 0 && !manifest.ProjectFile.Equals(_projectFile, StringComparison.OrdinalIgnoreCase))
                return PreparedRemoval.Fail("The generation manifest belongs to another project. No changes made.");
            if (manifest.ProjectFile.Length == 0 && Directory.EnumerateFiles(_projectRoot, "*.csproj").Skip(1).Any())
                return PreparedRemoval.Fail("Legacy generation metadata does not identify its owning project in this directory. No changes made.");
            manifest.InstalledTemplates ??= [];
            manifest.InstalledControls ??= [];
            manifest.GeneratedFiles ??= [];
            manifest.ModifiedFiles ??= [];
            manifest.OriginalHashes ??= [];
            manifest.PackageIds ??= [];
            manifest.PackageVersions ??= [];
            manifest.PackageRequestedVersions ??= [];
            foreach (var installedTemplate in manifest.InstalledTemplates)
            {
                installedTemplate.GeneratedFiles ??= [];
            }
        }
        catch (FileNotFoundException)
        {
            return PreparedRemoval.Fail("No Syncfusion manifest was found; no legacy control ownership can be verified.");
        }
        catch (Exception exception) when (exception is IOException
            or UnauthorizedAccessException
            or InvalidOperationException
            or JsonException)
        {
            return PreparedRemoval.Fail($"Could not read the Syncfusion manifest: {exception.Message}");
        }

        var records = new List<InstalledTemplateRecord>(selectedIds.Count);
        foreach (var id in selectedIds)
        {
            var matches = manifest.InstalledTemplates.Where(record =>
                string.Equals(record.Id, id, StringComparison.OrdinalIgnoreCase)).ToList();
            if (matches.Count == 0)
            {
                var hasLegacyMarker = manifest.InstalledControls.Any(installedId =>
                    installedId.Equals(id, StringComparison.OrdinalIgnoreCase));
                return PreparedRemoval.Fail(hasLegacyMarker
                    ? IncompleteOwnership(id, "the manifest has an installed-control ID but no per-control ownership record")
                    : $"Legacy unsupported control '{id}' is not installed.");
            }

            if (matches.Count != 1)
            {
                return PreparedRemoval.Fail(IncompleteOwnership(id, "the manifest contains duplicate ownership records"));
            }

            var record = matches[0];
            if (string.IsNullOrWhiteSpace(record.Family)
                || string.IsNullOrWhiteSpace(record.PackageId)
                || record.GeneratedFiles is null
                || record.GeneratedFiles.Count == 0)
            {
                return PreparedRemoval.Fail(IncompleteOwnership(id, "the per-control family, package, or generated-file list is missing"));
            }

            foreach (var path in record.GeneratedFiles)
            {
                try
                {
                    TemplatePathResolver.ValidateRelativePath(path);
                }
                catch (InvalidOperationException)
                {
                    return PreparedRemoval.Fail(IncompleteOwnership(id, $"'{path}' is not a safe relative file path"));
                }

                if (!manifest.GeneratedFiles.Contains(path, StringComparer.OrdinalIgnoreCase))
                {
                    return PreparedRemoval.Fail(IncompleteOwnership(id, $"'{path}' is not recorded in the manifest's CLI-owned file list"));
                }

                if (!manifest.OriginalHashes.TryGetValue(path, out var hash)
                    || hash.Length != 64
                    || !hash.All(Uri.IsHexDigit))
                {
                    return PreparedRemoval.Fail(IncompleteOwnership(id, $"'{path}' has no valid recorded ownership hash"));
                }
            }

            records.Add(record);
        }

        var plan = new ChangePlan
        {
            ControlId = string.Join(',', selectedIds),
            IsDryRun = dryRun,
        };
        foreach (var record in records)
        {
            foreach (var path in record.GeneratedFiles)
            {
                var shared = manifest.InstalledTemplates.Any(other =>
                    !selectedIds.Contains(other.Id)
                    && other.GeneratedFiles.Contains(path, StringComparer.OrdinalIgnoreCase));
                if (shared)
                {
                    plan.Warnings.Add($"Preserved shared file '{path}' because another installed control still owns it.");
                    continue;
                }

                var destination = TemplatePathResolver.ResolveDestination(_projectRoot, path);
                if (!File.Exists(destination))
                {
                    continue;
                }

                if (string.Equals(FileRollback.ComputeHash(destination), manifest.OriginalHashes[path], StringComparison.OrdinalIgnoreCase))
                {
                    if (!plan.FilesToDelete.Contains(path, StringComparer.OrdinalIgnoreCase))
                    {
                        plan.FilesToDelete.Add(path);
                    }
                }
                else
                {
                    plan.Warnings.Add($"Preserved modified file '{path}' because its contents no longer match the recorded ownership hash.");
                }
            }
        }

        plan.FilesToModify.Add("Syncfusion/syncfusion.json");
        return new PreparedRemoval(manifest, plan, null);
    }

    private static string IncompleteOwnership(string id, string limitation)
        => $"Cannot safely remove legacy control '{id}': ownership metadata is incomplete because {limitation}. "
            + "The manifest record was preserved. Next action: review the manifest and project files, then remove only files you can confirm are CLI-owned.";

    private static ControlOperationResult Failure(string message)
        => new()
        {
            ExitCode = ExitCodes.Error,
            Message = message,
        };

    private sealed record PreparedRemoval(
        SyncfusionManifest? Manifest,
        ChangePlan? Plan,
        string? Error)
    {
        public static PreparedRemoval Fail(string error) => new(null, null, error);
    }
}
