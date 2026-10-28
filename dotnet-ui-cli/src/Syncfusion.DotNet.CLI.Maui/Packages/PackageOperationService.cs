using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Maui.Manifest;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>Preserves package adds/updates and cleans tracked samples during package removal.</summary>
public sealed class PackageOperationService(NuGetRunner? nuget = null, DotNetRunner? dotnet = null)
{
    private readonly NuGetRunner _nuget = nuget ?? new NuGetRunner();
    private readonly DotNetRunner _dotnet = dotnet ?? new DotNetRunner();

    public static string VersionSelectionLabel(string versionStrategy)
        => versionStrategy.Equals("latest-stable-per-package", StringComparison.OrdinalIgnoreCase)
            ? "Version selection: Latest stable"
            : $"Version selection: {versionStrategy}";

    public static string VersionStrategyLabel(string versionStrategy)
        => versionStrategy switch
        {
            "latest-stable-per-package" => "Version strategy: Latest stable release",
            _ => $"Version strategy: {versionStrategy}",
        };

    public static string RequestedVersionLabel(string version)
        => $"Requested version: {version}";

    public static string? ResolvedVersionLabel(string? resolvedVersion)
        => resolvedVersion is null ? null : $"Resolved version: {resolvedVersion}";

    /// <summary>Uses the .NET CLI's NuGet validator without restoring or touching a user project.</summary>
    public async Task<NuGetCommandResult> ValidateExplicitVersionAsync(
        string version,
        CancellationToken cancellationToken = default)
    {
        var validationDirectory = Directory.CreateTempSubdirectory("sf-version-validation-");
        try
        {
            var projectPath = Path.Combine(validationDirectory.FullName, "VersionValidation.csproj");
            await File.WriteAllTextAsync(
                projectPath,
                "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>",
                cancellationToken).ConfigureAwait(false);

            return await _nuget.RunAsync(
                new NuGetOperation
                {
                    Kind = NuGetOperationKind.Add,
                    ProjectPath = projectPath,
                    PackageId = "VersionValidationProbe",
                    Version = version,
                    NoRestore = true,
                    WorkingDirectory = validationDirectory.FullName,
                },
                cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            validationDirectory.Delete(recursive: true);
        }
    }

    /// <summary>Runs a package add, remove, or version update.</summary>
    public async Task<PackageOperationResult> ExecuteAsync(
        ProjectDetector.ProjectInfo project,
        MauiPackageDefinition package,
        NuGetOperationKind kind,
        string? version = null,
        bool noRestore = false,
        bool dryRun = false,
        string? source = null,
        string? configFile = null,
        CancellationToken cancellationToken = default,
        bool update = false,
        bool build = true,
        string? buildFramework = null,
        bool buildRemoval = false,
        IProgress<string>? progress = null)
        => await ExecuteAsync(
            project,
            package.Alias,
            package.PackageId,
            kind,
            version,
            noRestore,
            dryRun,
            source,
            configFile,
            cancellationToken,
            update, build, buildFramework, buildRemoval, progress).ConfigureAwait(false);

    public async Task<PackageOperationResult> ExecuteAsync(
        ProjectDetector.ProjectInfo project,
        string? packageAlias,
        string packageId,
        NuGetOperationKind kind,
        string? version = null,
        bool noRestore = false,
        bool dryRun = false,
        string? source = null,
        string? configFile = null,
        CancellationToken cancellationToken = default,
        bool update = false,
        bool build = true,
        string? buildFramework = null,
        bool buildRemoval = false,
        IProgress<string>? progress = null)
    {
        project = MauiProjectResolver.ValidateMauiProject(project);
        var projectRoot = System.IO.Path.GetDirectoryName(project.CsprojPath)!;
        var operation = new NuGetOperation
        {
            Kind = kind,
            ProjectPath = project.CsprojPath,
            PackageId = packageId,
            Version = version,
            NoRestore = noRestore,
            DryRun = dryRun,
            Source = source,
            ConfigFile = configFile,
            WorkingDirectory = projectRoot,
            StageProgress = progress,
        };
        var args = NuGetArgumentBuilder.Build(operation);
        SyncfusionManifest? manifest;
        try { manifest = WelcomeProjectGenerator.ReadManifest(projectRoot, project); }
        catch (Exception ex) when (ex is IOException or InvalidOperationException or System.Text.Json.JsonException or UnauthorizedAccessException)
        {
            return new PackageOperationResult(project.CsprojPath, packageAlias, packageId, update ? "update" : kind == NuGetOperationKind.Remove ? "remove" : "add",
                ExitCodes.Error, $"Cannot read project ownership metadata. No changes made. {ex.Message}", "", ex.Message);
        }
        if (kind == NuGetOperationKind.Add && !update && !noRestore)
        {
            var samples = TemplateCatalog.Operable.Where(entry => entry.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase)).ToList();
            var sample = TemplateCatalog.TryResolveOperableTemplate(packageAlias, out var exact) && samples.Contains(exact)
                ? exact : samples.Count == 1 ? samples[0] : null;
            if (ProjectControlState.IsManaged(manifest) && sample is not null)
            {
                var installer = new ControlInstaller(project, _nuget, _dotnet);
                var preview = installer.PlanAdd(sample.Id, version, dryRun: dryRun, source: source, configFile: configFile);
                var generated = preview.ExitCode != ExitCodes.Success || dryRun ? preview
                    : await installer.ExecuteAddBatchAsync([sample.Id], version, source, configFile,
                        deferBuild: !build, cancellationToken: cancellationToken, buildFramework: buildFramework, progress: progress).ConfigureAwait(false);
                return new PackageOperationResult(project.CsprojPath, packageAlias, packageId, "add", generated.ExitCode,
                    string.Join(Environment.NewLine, new[] { Regex.Replace(generated.Message, @"(?<=Samples: )applied \d+ control\(s\)", _ => $"added {sample.DisplayName}") }.Concat(generated.Plan?.Warnings ?? [])),
                    NuGetArgumentBuilder.FormatCommandLine(args), string.Join(Environment.NewLine, generated.Errors),
                    SampleGenerationSucceeded: generated.SampleGenerationSucceeded, BuildSucceeded: generated.BuildSucceeded,
                    PackageChangesSucceeded: generated.PackageChangesSucceeded);
            }
        }
        if (kind == NuGetOperationKind.Remove)
        {
            var removal = await new ControlRemovalService(project, _nuget, _dotnet).ExecuteAsync([], dryRun, noRestore,
                source, configFile, packageId, cancellationToken, buildRemoval, buildFramework, progress).ConfigureAwait(false);
            var warnings = removal.Plan?.Warnings ?? [];
            return new PackageOperationResult(project.CsprojPath, packageAlias, packageId, "remove", removal.ExitCode,
                string.Join(Environment.NewLine, new[] { removal.Message }.Concat(warnings)),
                NuGetArgumentBuilder.FormatCommandLine(args), string.Join(Environment.NewLine, removal.Errors),
                SampleGenerationSucceeded: removal.SampleGenerationSucceeded, BuildSucceeded: removal.BuildSucceeded,
                PackageChangesSucceeded: removal.PackageChangesSucceeded);
        }
        using var rollback = new FileRollback();
        if (!dryRun)
        {
            rollback.TrackModified(project.CsprojPath);
            foreach (var relative in new[] { "packages.lock.json", "obj/project.assets.json", "obj/project.nuget.cache" })
                rollback.TrackModified(TemplatePathResolver.ResolveDestination(projectRoot, relative));
            for (var directory = projectRoot; directory is not null; directory = Path.GetDirectoryName(directory))
            {
                var props = Path.Combine(directory, "Directory.Packages.props");
                if (File.Exists(props)) rollback.TrackModified(props);
            }
        }
        NuGetCommandResult result;
        using var stages = new OperationStages(progress);
        try
        {
            if (!dryRun)
            {
                stages.Plan(update ? "Updating package" : "Adding package");
                if (!noRestore) stages.Plan("Restoring");
                stages.Start(update ? "Updating package" : "Adding package");
            }
            result = await _nuget.RunAsync(operation, cancellationToken).ConfigureAwait(false);
        }
        catch
        {
            rollback.Rollback();
            throw;
        }
        var succeeded = result.Success;
        var error = succeeded
            ? string.Empty
            : GetSafeDiagnostic(result, source, configFile);
        var verb = kind == NuGetOperationKind.Remove ? "remove" : update ? "update" : "add";
        var resolvedVersion = succeeded && kind == NuGetOperationKind.Add
            ? FindResolvedPackageVersion(project.CsprojPath, packageId)
            : null;
        try
        {
            if (succeeded && update && !dryRun && manifest is not null && resolvedVersion is not null
                && manifest.InstalledTemplates.Any(record => record.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase)))
            {
                manifest.PackageVersions[packageId] = resolvedVersion;
                if (version is null) manifest.PackageRequestedVersions.Remove(packageId);
                else manifest.PackageRequestedVersions[packageId] = version;
                foreach (var record in manifest.InstalledTemplates.Where(record => record.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase)))
                { record.ResolvedVersion = resolvedVersion; record.RequestedVersion = version; }
                WelcomeProjectGenerator.SaveManifest(projectRoot, manifest, rollback);
            }
            if (succeeded) rollback.Commit(); else rollback.Rollback();
            if (succeeded) stages.Complete();
        }
        catch
        {
            rollback.Rollback();
            throw;
        }
        var packageLabel = packageAlias is null
            ? $"'{packageId}'"
            : $"'{packageAlias}' ({packageId})";
        var message = dryRun
            ? $"Planned package {verb}: {packageLabel}."
            : succeeded
                ? $"Package {verb} succeeded: {packageLabel}."
                : $"Package {verb} failed for {packageLabel} with exit code {result.ExitCode}.";

        if (succeeded && !dryRun && !update)
        {
            var samples = TemplateCatalog.Operable.Where(template => template.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase)).ToList();
            message += samples.Count == 0
                ? " No sample added: this package has no sample template."
                : !ProjectControlState.IsManaged(manifest)
                    ? $" No sample added: sample navigation is not configured for this project. Add a standalone sample with 'sf add maui --control {samples[0].Id}'."
                    : $" No sample added: {(noRestore ? "package restore was skipped" : "select a specific control sample")}. Add a sample with 'sf add maui --control {samples[0].Id}'.";
        }

        var safeArgs = args.ToArray();
        for (var index = 0; index < safeArgs.Length - 1; index++)
        {
            if (safeArgs[index] is "--source" or "--configfile")
            {
                // The default nuget.org feed is not a secret; keep it visible.
                // User-supplied values are redacted to avoid leaking
                // private/internal feeds or auth-bearing URLs.
                var value = safeArgs[index + 1];
                safeArgs[index + 1] = string.Equals(value, NuGetSources.DefaultPublicFeed, StringComparison.Ordinal)
                    ? value
                    : "<redacted>";
            }
        }

        return new PackageOperationResult(
            project.CsprojPath,
            packageAlias,
            packageId,
            verb,
            succeeded ? ExitCodes.Success : ExitCodes.Error,
            message,
            NuGetArgumentBuilder.FormatCommandLine(safeArgs),
            error,
            resolvedVersion);
    }

    private static string GetSafeDiagnostic(NuGetCommandResult result, string? source, string? configFile)
    {
        var diagnostic = string.Join(
            Environment.NewLine,
            new[] { result.StandardError, result.StandardOutput }
                .Where(output => !string.IsNullOrWhiteSpace(output)));

        foreach (var sensitiveValue in new[] { source, configFile })
        {
            if (!string.IsNullOrWhiteSpace(sensitiveValue))
            {
                diagnostic = diagnostic.Replace(sensitiveValue, "<redacted>", StringComparison.OrdinalIgnoreCase);
            }
        }

        return diagnostic;
    }

    private static string? FindResolvedPackageVersion(string projectPath, string packageId)
    {
        var package = DiscoveryService.ListInstalledPackages(projectPath)
            .FirstOrDefault(installed => installed.PackageId.Equals(packageId, StringComparison.OrdinalIgnoreCase));
        return package?.Version is { } version && IsExactVersion(version)
            ? version
            : null;
    }

    private static bool IsExactVersion(string version)
        => Regex.IsMatch(
            version,
            @"\A\d+(?:\.\d+){1,3}(?:-[0-9A-Za-z.-]+)?(?:\+[0-9A-Za-z.-]+)?\z",
            RegexOptions.CultureInvariant);
}

/// <summary>The structured result of a package-only operation.</summary>
public sealed record PackageOperationResult(
    string ProjectPath,
    string? Alias,
    string PackageId,
    string Operation,
    int ExitCode,
    string Message,
    string Command,
    string Error,
    string? ResolvedVersion = null,
    bool? SampleGenerationSucceeded = null,
    bool? BuildSucceeded = null,
    bool? PackageChangesSucceeded = null);
