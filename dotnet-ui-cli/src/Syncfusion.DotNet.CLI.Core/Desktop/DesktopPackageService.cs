using System.Text.Json;
using System.Xml.Linq;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>Transactional package operations and owned desktop sample lifecycle.</summary>
public sealed class DesktopPackageService(NuGetRunner? nuget = null, ToolRunner? tools = null)
{
    private readonly NuGetRunner _nuget = nuget ?? new NuGetRunner();
    private readonly ToolRunner _tools = tools ?? new ToolRunner();
    public async Task<DesktopResult> ExecuteAsync(IDesktopPlatformProvider provider, string action, string projectLocation,
        string packageName, string? version = null, bool restore = true, bool build = false, bool dryRun = false,
        string? source = null, string? configFile = null, CancellationToken cancellationToken = default, IProgress<string>? progress = null)
    {
        if (build && !restore) return new(ExitCodes.Error, "Build after package changes requires restore. Remove --no-restore.");
        if (version is not null && !System.Text.RegularExpressions.Regex.IsMatch(version, "^[0-9]+\\.[0-9]+\\.[0-9]+(?:[-+][A-Za-z0-9.-]+)?$"))
            return new(ExitCodes.Error, "Package version must be an explicit valid NuGet version.");
        using var stages = new OperationStages(progress);
        var project = DesktopProjectFiles.ResolveProject(projectLocation, provider.Platform);
        var root = Path.GetDirectoryName(project)!;
        if ((File.GetAttributes(project) & FileAttributes.ReparsePoint) != 0) return new(ExitCodes.Error, "Project file is a symbolic link. No changes made.");
        var legacy = XDocument.Load(project).Descendants().Any(e => e.Name.LocalName == "TargetFrameworkVersion");
        var package = provider.Packages.FirstOrDefault(item => item.Alias.Equals(packageName, StringComparison.OrdinalIgnoreCase)
            || item.Id.Equals(packageName, StringComparison.OrdinalIgnoreCase));
        if (package is null) return new(ExitCodes.Error, $"Unknown {provider.DisplayName} package '{packageName}'. Run sf list {Frameworks.Name(provider.Platform)} packages.");
        if (provider.SupportsControlTemplates && !provider.Packages.Any(item => item.Alias.Equals(packageName, StringComparison.OrdinalIgnoreCase))
            && provider.Packages.Count(item => item.Id.Equals(packageName, StringComparison.OrdinalIgnoreCase) && item.HasTemplate) > 1 && action != "update")
            return new(ExitCodes.Error, "This package supplies multiple control templates. Use a control alias to select the sample to add or remove. No changes made.");
        var xml = XDocument.Load(project);
        var existing = xml.Descendants().Any(element => element.Name.LocalName == "PackageReference" && string.Equals((string?)element.Attribute("Include"), package.Id, StringComparison.OrdinalIgnoreCase));
        if (action == "update" && !existing) return new(ExitCodes.Error, $"Package '{package.Id}' is not installed.");
        var manifestPath = Path.Combine(root, DesktopProjectService.ManifestName);
        DesktopManifest? manifest = null;
        DesktopControlLifecycle? lifecycle = null;
        if (File.Exists(manifestPath))
        {
            if ((File.GetAttributes(manifestPath) & FileAttributes.ReparsePoint) != 0)
                return new(ExitCodes.Error, "Desktop manifest is a symbolic link. No changes made.");
            manifest = JsonSerializer.Deserialize<DesktopManifest>(File.ReadAllText(manifestPath)) ?? throw new InvalidOperationException("Invalid desktop manifest.");
            if (manifest.SchemaVersion != 1 || manifest.ProjectFile != Path.GetFileName(project) || manifest.Platform != Frameworks.Name(provider.Platform)) return new(ExitCodes.Error, "Desktop manifest does not identify the selected project. No changes made.");
            var alreadyInstalled = manifest.Controls.Contains(package.Alias, StringComparer.OrdinalIgnoreCase);
            if (provider.SupportsControlTemplates && package.HasTemplate && action == "add" && alreadyInstalled && version is null)
                return new(0, $"Control '{package.Alias}' is already installed. No changes made.", project);
            if (provider.SupportsControlTemplates && package.HasTemplate && action == "add" && alreadyInstalled && version is not null) action = "update";
            if (provider.SupportsControlTemplates && package.HasTemplate && (action == "remove" || action == "add" && !alreadyInstalled))
            {
                try { lifecycle = new DesktopControlLifecycle(provider, project, manifest, action, package.Alias); }
                catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or InvalidOperationException)
                { return new(ExitCodes.Error, exception.Message, project); }
            }
            if (lifecycle is null && action == "remove" && manifest.RequiredPackages.Contains(package.Id, StringComparer.OrdinalIgnoreCase)) return new(ExitCodes.Error, $"Package '{package.Id}' is required by the generated controls or theme. Remove those dependencies manually before removing the package.");
        }
        var controlVersion = version;
        if (dryRun) return new(0, $"Planned {action} of {package.Id}. No changes made (--dry-run).", project);
        if (!OperatingSystem.IsWindows() && ((legacy && restore) || (provider.Platform == Framework.WinUI && build)))
            return new(ExitCodes.Error, "This restore/build requires Windows desktop build tools. Use --no-restore without --build for package-only changes.");
        using var rollback = new FileRollback();
        rollback.TrackModified(project);
        foreach (var relative in new[] { "packages.lock.json", "obj/project.assets.json", "obj/project.nuget.cache" })
            rollback.TrackModified(Path.Combine(root, relative));
        for (var current = root; current is not null; current = Path.GetDirectoryName(current))
        {
            var central = Path.Combine(current, "Directory.Packages.props");
            if (File.Exists(central))
            {
                if ((File.GetAttributes(central) & FileAttributes.ReparsePoint) != 0) return new(ExitCodes.Error, "Central package configuration is a symbolic link. No changes made.");
                rollback.TrackModified(central); break;
            }
        }
        try
        {
            if (action != "remove" && package.Id.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase))
                controlVersion = await NuGetPackageVersions.ResolveAsync(package.Id, version, _tools, cancellationToken).ConfigureAwait(false);
            var managedVersions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var dependencies = action == "add" ? lifecycle?.Dependencies
                : action == "update" && provider.SupportsControlTemplates && package.HasTemplate ? manifest?.RequiredPackages : null;
            foreach (var id in dependencies ?? [])
            {
                if (!id.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase))
                    managedVersions[id] = provider.PackageVersion(id, version);
                else if (id.Equals(package.Id, StringComparison.OrdinalIgnoreCase))
                    managedVersions[id] = controlVersion!;
                else
                    managedVersions[id] = await NuGetPackageVersions.ResolveAsync(id, version, _tools, cancellationToken).ConfigureAwait(false);
            }
            var legacyTool = legacy && restore ? await DesktopBuildTools.LegacyMsBuildAsync(_tools, cancellationToken).ConfigureAwait(false) : null;
            stages.Start(action == "add" ? "Adding package" : action == "remove" ? "Removing package" : "Updating package");
            var removeShared = action == "remove" && lifecycle?.Dependencies.Contains(package.Id, StringComparer.OrdinalIgnoreCase) == true;
            var result = removeShared ? new NuGetCommandResult { ExitCode = 0, StandardOutput = "", StandardError = "" } : await _nuget.RunAsync(new NuGetOperation
            {
                Kind = action == "remove" ? NuGetOperationKind.Remove : NuGetOperationKind.Add,
                ProjectPath = project,
                PackageId = package.Id,
                Version = action == "add" && lifecycle is not null ? provider.PackageVersion(package.Id, controlVersion) : controlVersion,
                NoRestore = true,
                Source = source,
                ConfigFile = configFile,
                WorkingDirectory = root,
            }, cancellationToken).ConfigureAwait(false);
            DesktopProjectService.RequireSuccess(new(result.ExitCode, result.StandardOutput, result.StandardError), $"{action} package");
            if (lifecycle is not null)
            {
                if (action == "add")
                    await DesktopPackageReferences.AddAsync(project, managedVersions, _tools, rollback, cancellationToken, explicitVersion: version is not null).ConfigureAwait(false);
                else
                {
                    var remaining = lifecycle.Dependencies;
                    var references = XDocument.Load(project);
                    foreach (var element in references.Descendants().Where(element => element.Name.LocalName == "PackageReference"
                        && manifest!.RequiredPackages.Contains((string?)element.Attribute("Include") ?? "", StringComparer.OrdinalIgnoreCase)
                        && !remaining.Contains((string?)element.Attribute("Include") ?? "", StringComparer.OrdinalIgnoreCase)).ToArray()) element.Remove();
                    references.Save(project);
                }
                if (action == "add")
                    await DesktopPackageReferences.AlignManagedVersionsAsync(project, managedVersions, rollback, _tools, cancellationToken).ConfigureAwait(false);
                lifecycle.Apply(rollback);
            }
            if (action == "update" && provider.SupportsControlTemplates && package.HasTemplate && manifest is not null)
            {
                var installed = controlVersion ?? DesktopPackageReferences.InstalledVersion(project, package.Id);
                if (installed is not null) await DesktopPackageReferences.AlignManagedVersionsAsync(project, managedVersions, rollback, _tools, cancellationToken).ConfigureAwait(false);
            }
            stages.Complete();
            if (restore || build)
            {
                stages.Start("Restoring packages");
                var args = new List<string> { "restore", project };
                NuGetSources.AppendSourceAndConfigFile(args, source, null);
                if (configFile is not null) args.AddRange(["--configfile", configFile]);
                if (legacyTool is not null) { args = [project, "/t:Restore"]; args.Add("/p:RestoreSources=" + NuGetSources.ResolveSource(source)); if (configFile is not null) args.Add("/p:RestoreConfigFile=" + configFile); }
                DesktopProjectService.RequireSuccess(await _tools.RunAsync(args, root, cancellationToken, executable: legacyTool).ConfigureAwait(false), "restoring packages");
                stages.Complete();
            }
            if (build)
            {
                stages.Start("Building project");
                DesktopProjectService.RequireSuccess(await _tools.RunAsync(legacyTool is null ? ["build", project, "--no-restore"] : [project, "/t:Build"], root, cancellationToken, executable: legacyTool).ConfigureAwait(false), "building project");
                stages.Complete();
            }
            if (manifest is not null && lifecycle is null)
            {
                rollback.TrackModified(manifestPath);
                manifest.OriginalHashes[Path.GetFileName(project)] = FileRollback.ComputeHash(project)!;
                File.WriteAllText(manifestPath, JsonSerializer.Serialize(manifest, new JsonSerializerOptions { WriteIndented = true }));
            }
            rollback.Commit();
            return new(0, $"Package {action} completed: {package.Id}", project);
        }
        catch (OperationCanceledException) { rollback.Rollback(); throw; }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or InvalidOperationException or System.ComponentModel.Win32Exception)
        {
            var errors = rollback.Rollback();
            return new(ExitCodes.Error, "Package operation failed; project changes rolled back.", project,
                Errors: new[] { exception.Message }.Concat(errors).ToArray(), RolledBack: true);
        }
    }
}
