using System.Text.Json;
using System.Xml.Linq;

namespace Syncfusion.DotNet.CLI.Core;

public sealed record DesktopResult(int ExitCode, string Message, string? ProjectPath = null,
    IReadOnlyList<string>? Files = null, IReadOnlyList<string>? Errors = null, bool RolledBack = false)
{
    public bool Success => ExitCode == 0;
    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<string>? NextCommands { get; init; }
}
public class DesktopManifest
{
    public int SchemaVersion { get; set; } = 1;
    public string Platform { get; set; } = "";
    public string ProjectFile { get; set; } = "";
    public string Theme { get; set; } = "";
    public List<string> Controls { get; set; } = [];
    public List<string> RequiredPackages { get; set; } = [];
    public Dictionary<string, string> OriginalHashes { get; set; } = [];
}

/// <summary>Transactional orchestration shared by desktop providers. Providers own every UI/API decision.</summary>
public sealed class DesktopProjectService(ToolRunner? runner = null)
{
    private readonly ToolRunner _runner = runner ?? new ToolRunner();
    public const string ManifestName = "Syncfusion/desktop.json";
    public async Task<DesktopResult> CreateAsync(IDesktopPlatformProvider provider, DesktopNewRequest request,
        IProgress<string>? progress = null, CancellationToken cancellationToken = default)
    {
        var validation = DesktopConfiguration.Validate(provider, request);
        if (validation is not null) return new(ExitCodes.Error, validation);
        var location = Path.GetFullPath(request.Location);
        var protection = ValidateLocation(location);
        if (protection is not null) return new(ExitCodes.Error, protection);
        var root = Path.Combine(location, request.Name);
        if (File.Exists(root) || Directory.Exists(root)) return new(ExitCodes.Error, $"'{request.Name}' already exists in project location '{location}'.");
        var files = provider.Generate(request);
        if (request.DryRun) return new(0, $"Planned {provider.DisplayName} project. No changes made (--dry-run).", root, files.Keys.ToArray());
        if (request.Build && !OperatingSystem.IsWindows() && provider.RequiresWindowsBuild(request))
            return new(ExitCodes.Error, $"Building {provider.DisplayName} requires Windows{(DesktopConfiguration.IsLegacy(request.TargetFramework) ? " and Visual Studio MSBuild with .NET Framework desktop tools" : " desktop build tools")}. Use --post-action generate --no-restore for portable generation.");
        if (DesktopConfiguration.IsLegacy(request.TargetFramework) && request.Restore && !OperatingSystem.IsWindows())
            return new(ExitCodes.Error, "Legacy .NET Framework restore requires Windows/Visual Studio MSBuild. Use --post-action generate --no-restore to generate files only.");
        using var rollback = new FileRollback();
        using var stages = new OperationStages(progress);
        try
        {
            var legacyBuildTool = DesktopConfiguration.IsLegacy(request.TargetFramework) && (request.Restore || request.Build)
                ? await DesktopBuildTools.LegacyMsBuildAsync(_runner, cancellationToken).ConfigureAwait(false) : null;
            var sdk = await _runner.RunAsync(["--list-sdks"], cancellationToken: cancellationToken).ConfigureAwait(false);
            RequireSuccess(sdk, "checking installed .NET SDKs");
            if (!DesktopConfiguration.IsLegacy(request.TargetFramework) && (provider.OfficialTemplate is not null || request.Restore || request.Build))
            {
                var required = int.Parse(request.TargetFramework[3..].Split('.')[0], System.Globalization.CultureInfo.InvariantCulture);
                if (!sdk.Output.Split('\n').Any(line => int.TryParse(line.Split('.')[0], out var major) && major >= required))
                    return new(ExitCodes.Error, $"Install .NET SDK {required} or newer before creating this target framework.");
            }
            stages.Start("Creating project");
            rollback.TrackCreatedDirectoryTree(root);
            Directory.CreateDirectory(location);
            if (!DesktopConfiguration.IsLegacy(request.TargetFramework) && provider.OfficialTemplate is not null)
            {
                var result = await _runner.RunAsync(["new", provider.OfficialTemplate, "-n", request.Name, "-o", root,
                    "--language", request.Language, "--framework", request.TargetFramework, "--no-restore"], location, cancellationToken).ConfigureAwait(false);
                RequireSuccess(result, "creating from the official desktop template");
                // The directory was created by this transaction; remove only SDK starter UI sources.
                foreach (var file in Directory.GetFiles(root, "*", SearchOption.TopDirectoryOnly).Where(file =>
                    file.EndsWith(".cs") || file.EndsWith(".vb") || file.EndsWith(".xaml") || file.EndsWith(".resx"))) File.Delete(file);
            }
            else Directory.CreateDirectory(root);
            stages.Complete();
            stages.Start("Setting up project files");
            foreach (var (relative, content) in files)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var path = Path.Combine(root, relative);
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllText(path, content);
            }
            var assets = provider.TemplateAssets(request);
            foreach (var (relative, content) in assets)
            {
                var path = Path.Combine(root, relative);
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllBytes(path, content);
            }
            var projectFile = request.Name + DesktopConfiguration.ProjectExtension(request.Language);
            var projectPath = Path.Combine(root, projectFile);
            var dependencies = new Dictionary<string, string>();
            foreach (var package in provider.RequiredPackages(request))
                dependencies[package] = package.StartsWith("Syncfusion.", StringComparison.OrdinalIgnoreCase)
                    ? await NuGetPackageVersions.ResolveAsync(package, request.Version, _runner, cancellationToken).ConfigureAwait(false)
                    : provider.PackageVersion(package, request.Version);
            if (DesktopConfiguration.IsLegacy(request.TargetFramework)) dependencies["Microsoft.NETFramework.ReferenceAssemblies"] = "1.0.3";
            await DesktopPackageReferences.AddAsync(projectPath, dependencies, _runner, rollback, cancellationToken, explicitVersion: request.Version is not null).ConfigureAwait(false);
            var manifest = new DesktopManifest
            {
                Platform = Frameworks.Name(provider.Platform),
                ProjectFile = projectFile,
                Theme = request.Theme,
                Controls = request.Controls.Distinct().Order().ToList(),
                RequiredPackages = provider.RequiredPackages(request).ToList(),
            };
            foreach (var file in files.Keys.Concat(assets.Keys)) manifest.OriginalHashes[file] = FileRollback.ComputeHash(Path.Combine(root, file))!;
            Directory.CreateDirectory(Path.Combine(root, "Syncfusion"));
            File.WriteAllText(Path.Combine(root, ManifestName), JsonSerializer.Serialize(manifest, new JsonSerializerOptions { WriteIndented = true }));
            stages.Complete();
            if (request.Restore || request.Build)
            {
                stages.Start("Restoring packages");
                var args = new List<string> { "restore", projectPath };
                NuGetSources.AppendSourceAndConfigFile(args, request.Source, null);
                if (request.ConfigFile is not null) args.AddRange(["--configfile", request.ConfigFile]);
                if (legacyBuildTool is not null)
                {
                    args = [projectPath, "/t:Restore"];
                    args.Add("/p:RestoreSources=" + NuGetSources.ResolveSource(request.Source));
                    if (request.ConfigFile is not null) args.Add("/p:RestoreConfigFile=" + request.ConfigFile);
                }
                RequireSuccess(await _runner.RunAsync(args, root, cancellationToken, executable: legacyBuildTool).ConfigureAwait(false), "restoring packages");
                stages.Complete();
            }
            if (request.Build)
            {
                stages.Start("Building project");
                RequireSuccess(await _runner.RunAsync(legacyBuildTool is null ? ["build", projectPath, "--no-restore"] : [projectPath, "/t:Build"], root, cancellationToken, executable: legacyBuildTool).ConfigureAwait(false), "building project");
                stages.Complete();
            }
            rollback.Commit();
            return new(0, $"Project created at {root}", root, files.Keys.ToArray());
        }
        catch (OperationCanceledException) { rollback.Rollback(); throw; }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or InvalidOperationException or System.ComponentModel.Win32Exception)
        {
            var errors = rollback.Rollback();
            return new(ExitCodes.Error, "Project creation failed; generated project was rolled back.", root, Errors: new[] { exception.Message }.Concat(errors).ToArray(), RolledBack: true);
        }
    }
    public static void RequireSuccess(ToolResult result, string step)
    {
        if (!result.Success) throw new InvalidOperationException($"Failed while {step}:\n{result.Error}\n{result.Output}");
    }
    public static string? ValidateLocation(string location)
    {
        var path = Path.GetFullPath(location).TrimEnd(Path.DirectorySeparatorChar);
        if (path.Length == 0 || path == Path.GetPathRoot(location)?.TrimEnd(Path.DirectorySeparatorChar)) return "Choose a writable project location outside the filesystem root.";
        var protectedPaths = OperatingSystem.IsWindows()
            ? new[] { Environment.GetFolderPath(Environment.SpecialFolder.Windows), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) }
            : ["/etc", "/usr", "/bin", "/sbin", "/var", "/proc", "/sys", "/dev", "/lib"];
        if (protectedPaths.Where(value => value.Length > 0).Any(value => path.Equals(value, StringComparison.OrdinalIgnoreCase) || path.StartsWith(value + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase)))
            return "Protected project location. Choose a folder you own.";
        for (var current = path; current is not null; current = Path.GetDirectoryName(current))
            if (Directory.Exists(current) && (File.GetAttributes(current) & FileAttributes.ReparsePoint) != 0) return "Project location contains a symbolic link; select its resolved folder.";
        return null;
    }
}
