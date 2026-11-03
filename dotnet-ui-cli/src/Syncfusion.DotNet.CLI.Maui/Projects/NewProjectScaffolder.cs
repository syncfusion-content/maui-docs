using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui.Injection;
using Syncfusion.DotNet.Cli.Maui.Manifest;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>
/// The outcome of a <c>sfdotnet new maui</c> operation.
/// </summary>
public sealed class NewProjectResult
{
    public required int ExitCode { get; init; }
    public required string Message { get; init; }
    public ChangePlan? Plan { get; init; }
    public IReadOnlyList<string> Errors { get; init; } = [];
    /// <summary>Non-fatal warnings produced during project creation.</summary>
    public IReadOnlyList<string> Warnings { get; init; } = [];
    /// <summary>Files the operation created, relative to the new project root.</summary>
    public IReadOnlyList<string> CreatedFiles { get; init; } = [];
    /// <summary>Files the operation modified, relative to the new project root.</summary>
    public IReadOnlyList<string> ModifiedFiles { get; init; } = [];
    /// <summary>The absolute path of the created project root.</summary>
    public string? ProjectPath { get; init; }
    public bool GenerationSucceeded { get; init; }
    public bool? BuildSucceeded { get; init; }
    public bool RolledBack { get; init; }
    internal System.Exception? Exception { get; init; }
}

/// <summary>
/// Scaffolds a new MAUI project for <c>sfdotnet new maui</c>. Uses the official
/// <c>dotnet new</c> template, then layers the selected Syncfusion control,
/// MauiProgram registration, manifest, restore, and build on top.
/// Reuses <see cref="ControlInstaller"/> for the control portion so the new
/// flow and the add flow share the same idempotent, rollback-safe path.
/// </summary>
public sealed class NewProjectScaffolder
{
    private static readonly HashSet<string> CSharpKeywords = new(StringComparer.Ordinal)
    {
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
        "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
        "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
        "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock",
        "long", "namespace", "new", "null", "object", "operator", "out", "override", "params",
        "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short",
        "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true",
        "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual",
        "void", "volatile", "while",
    };

    private static readonly HashSet<string> ReservedDirectoryNames = new(StringComparer.OrdinalIgnoreCase)
    {
        "CON", "PRN", "AUX", "NUL", "CONIN$", "CONOUT$",
        "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9",
        "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9",
    };

    private readonly DotNetRunner _dotnet;
    private readonly NuGetRunner _nuget;

    public NewProjectScaffolder(DotNetRunner? dotnet = null, NuGetRunner? nuget = null)
    {
        _dotnet = dotnet ?? new DotNetRunner();
        _nuget = nuget ?? new NuGetRunner();
    }

    /// <summary>Returns an error when a project name cannot form a portable directory and C# namespace.</summary>
    public static string? ValidateProjectName(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "A project name is required.";
        }

        var value = name.Trim();
        if (ReservedDirectoryNames.Contains(value)
            || value.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0
            || value.IndexOfAny(['<', '>', ':', '"', '/', '\\', '|', '?', '*']) >= 0
            || value.Split('.').Any(segment => !IsValidNamespaceSegment(segment)))
        {
            return $"Project name '{value}' is invalid. Use dot-separated C# identifier names that are valid directory names.";
        }

        return null;
    }

    /// <summary>
    /// Returns the next available default project name under <paramref name="parentDirectory"/>.
    /// If <paramref name="baseName"/> does not exist on disk it is returned unchanged; otherwise
    /// the first non-conflicting <c>{baseName}{N}</c> numeric suffix is returned. Conflicts on the
    /// explicit name are never auto-renamed; the caller is expected to ask the user for a new name.
    /// </summary>
    public static string ResolveDefaultName(string baseName, string parentDirectory)
    {
        if (string.IsNullOrWhiteSpace(baseName))
        {
            throw new ArgumentException("Default project name cannot be empty.", nameof(baseName));
        }

        var trimmedBase = baseName.Trim();
        var validation = ValidateProjectName(trimmedBase);
        if (validation is not null)
        {
            throw new ArgumentException(validation, nameof(baseName));
        }

        var parent = string.IsNullOrWhiteSpace(parentDirectory)
            ? Environment.CurrentDirectory
            : PathNormalizer.Normalize(parentDirectory);

        return Syncfusion.DotNet.Cli.Core.Naming.ProjectNaming.ResolveAvailableName(trimmedBase, parent);
    }

    private static bool IsValidNamespaceSegment(string segment)
    {
        if (segment.Length == 0 || CSharpKeywords.Contains(segment))
        {
            return false;
        }

        var isFirstRune = true;
        foreach (var rune in segment.EnumerateRunes())
        {
            var category = Rune.GetUnicodeCategory(rune);
            var validStart = rune.Value == '_'
                || category is UnicodeCategory.UppercaseLetter
                    or UnicodeCategory.LowercaseLetter
                    or UnicodeCategory.TitlecaseLetter
                    or UnicodeCategory.ModifierLetter
                    or UnicodeCategory.OtherLetter
                    or UnicodeCategory.LetterNumber;
            var validPart = validStart
                || category is UnicodeCategory.NonSpacingMark
                    or UnicodeCategory.SpacingCombiningMark
                    or UnicodeCategory.DecimalDigitNumber
                    or UnicodeCategory.ConnectorPunctuation
                    or UnicodeCategory.Format;
            if (isFirstRune ? !validStart : !validPart)
            {
                return false;
            }

            isFirstRune = false;
        }

        return !isFirstRune;
    }

    /// <summary>Validates a target framework with the installed MAUI template without creating a project.</summary>
    public Task<ProcessCommandResult> ValidateTargetFrameworkAsync(
        string targetFramework,
        CancellationToken cancellationToken = default)
        => _dotnet.RunAsync(
            [
                "new",
                "maui",
                "--name",
                "SfTargetFrameworkValidation",
                "--framework",
                targetFramework,
                "--dry-run",
                "--no-update-check",
            ],
            Path.GetTempPath(),
            dryRun: false,
            cancellationToken);

    /// <summary>
    /// Builds a change plan for the new-project flow without touching the
    /// filesystem. Used for <c>--dry-run</c> and preview output.
    /// </summary>
    public NewProjectResult Plan(NewProjectRequest request)
    {
        var (projectRoot, plan) = BuildBasePlan(request);
        return new NewProjectResult
        {
            ExitCode = ExitCodes.Success,
            Message = request.DryRun
                ? $"Planned new MAUI project '{request.Name}'. No changes made (--dry-run)."
                : $"Planned new MAUI project '{request.Name}'.",
            Plan = plan,
            ProjectPath = projectRoot,
        };
    }

    /// <summary>Executes the full <c>sfdotnet new maui</c> flow.</summary>
    public Task<NewProjectResult> ExecuteAsync(NewProjectRequest request, CancellationToken cancellationToken = default)
        => ExecuteAsync(request, progress: null, cancellationToken);

    /// <summary>Executes the full <c>sfdotnet new maui</c> flow with optional progress reporting.</summary>
    public Task<NewProjectResult> ExecuteAsync(
        NewProjectRequest request,
        IProgress<ProgressStep>? progress,
        CancellationToken cancellationToken = default)
        => ExecuteAsync(request, progress, cancellationToken, stages: null);

    public async Task<NewProjectResult> ExecuteAsync(
        NewProjectRequest request,
        IProgress<ProgressStep>? progress,
        CancellationToken cancellationToken,
        IProgress<string>? stages)
    {
        var nameError = ValidateProjectName(request.Name);
        if (nameError is not null)
        {
            return Fail(nameError, new ChangePlan(), [nameError], null);
        }

        var projectName = request.Name.Trim();
        string outputPath;
        try
        {
            outputPath = Path.GetFullPath(request.Path);
        }
        catch (Exception ex) when (ex is ArgumentException or NotSupportedException or PathTooLongException)
        {
            const string message = "Project location is invalid. Provide a valid relative or absolute --path.";
            return Fail(message, new ChangePlan(), [message], null);
        }

        request = request with { Name = projectName, Path = outputPath };
        if (request.DryRun)
        {
            return Plan(request);
        }

        var (projectRoot, plan) = BuildBasePlan(request);
        var steps = NewProjectProgress.DefaultSteps;
        var totalSteps = steps.Count;
        var currentStep = 0;
        void Report(string label)
        {
            currentStep++;
            progress?.Report(new ProgressStep(currentStep, totalSteps, label));
        }

        using var rollback = new FileRollback();
        using var stageProgress = new OperationStages(stages);
        var failureStage = "preparing the project location";
        var generationSucceeded = false;

        try
        {
            if (Directory.Exists(projectRoot) || File.Exists(projectRoot))
            {
                return Fail(
                    $"Project location '{projectRoot}' already exists. Choose a different project name or --path; existing files were not changed.",
                    plan,
                    [],
                    projectRoot);
            }

            if (File.Exists(request.Path))
            {
                return Fail(
                    $"Project location '{request.Path}' is a file. Choose a project location with --path.",
                    plan,
                    [],
                    projectRoot);
            }

            Report(steps[0]);
            stageProgress.Plan("Preparing destination", steps[1], request.ProjectType == MauiProjectType.App
                ? "Installing welcome screen" : "Preparing sample navigation");
            if (request.SelectedTemplateIds.Count > 0)
            {
                stageProgress.Plan("Adding packages", "Restoring", "Generating files");
                if (request.SelectedTemplateIds.Any(id => ControlCatalog.TryResolveOperableTemplate(id, out var entry)
                    && entry.RegistrationRequirement == "syncfusion-core")) stageProgress.Plan("Registering in MauiProgram.cs");
                stageProgress.Plan("Updating navigation", "Writing control manifest");
            }
            if (request.SelectedTemplateIds.Count > 0 || request.ProjectType == MauiProjectType.App) stageProgress.Plan("Writing project manifest");
            if (request.Restore && !request.Build && request.SelectedTemplateIds.Count == 0) stageProgress.Plan("Restoring");
            if (request.Build) stageProgress.Plan("Building");
            stageProgress.Start("Preparing destination");

            var existingParent = FindExistingDirectory(request.Path);
            rollback.TrackCreatedDirectories(request.Path, existingParent);
            try
            {
                Directory.CreateDirectory(request.Path);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                var errors = rollback.Rollback();
                return Fail(
                    $"Project location '{request.Path}' cannot be created. Check that it is writable and not blocked by a file.",
                    plan,
                    [ex.Message, .. errors],
                    projectRoot);
            }

            rollback.TrackCreatedDirectoryTree(projectRoot);

            // Step 3 & 5: dotnet new maui/blazor (native MAUI template).
            var templateShortName = request.ProjectType == MauiProjectType.BlazorHybrid ? "maui-blazor" : "maui";
            var newArgs = new List<string> { "new", templateShortName, "-n", request.Name, "-o", projectRoot };
            // maui-blazor does not define --no-restore (and performs no post-action restore).
            if (request.ProjectType == MauiProjectType.App) newArgs.Add("--no-restore");
            if (!string.IsNullOrWhiteSpace(request.TargetFramework))
            {
                newArgs.Add("-f");
                newArgs.Add(request.TargetFramework);
            }

            Report(steps[1]);
            stageProgress.Complete();
            stageProgress.Start(steps[1]);

            failureStage = $"running dotnet new {templateShortName}";
            var newResult = await _dotnet.RunAsync(newArgs, request.Path, dryRun: false, cancellationToken).ConfigureAwait(false);
            if (!newResult.Success)
            {
                var errors = rollback.Rollback();
                return Fail(
                    $"Could not create the MAUI project (dotnet new {templateShortName}, exit {newResult.ExitCode}). Check the template diagnostics below.",
                    plan,
                    [newResult.StandardError, newResult.StandardOutput, .. errors],
                    projectRoot);
            }

            // Apply the complete template selection as one restore/build unit.
            stageProgress.Complete();
            stageProgress.Start(request.ProjectType == MauiProjectType.App ? "Installing welcome screen" : "Preparing sample navigation");
            var createdFiles = new List<string>();
            var modifiedFiles = new List<string>();
            if (request.ProjectType == MauiProjectType.App)
            {
                failureStage = "installing the native welcome screen";
                var project = MauiProjectResolver.Resolve(projectRoot);
                var rootNamespace = PlaceholderReplacer.NormalizeRootNamespace(project.RootNamespace ?? request.Name);
                WelcomeProjectGenerator.Install(projectRoot, rootNamespace, rollback);
                createdFiles.AddRange(WelcomeProjectGenerator.TemplateFiles.Keys.Append(WelcomeProjectGenerator.RegistryPath));
            }
            else
            {
                var project = MauiProjectResolver.Resolve(projectRoot);
                var rootNamespace = PlaceholderReplacer.NormalizeRootNamespace(project.RootNamespace ?? request.Name);
                var manifest = new SyncfusionManifest { CliVersion = CliMetadata.Version, Framework = "maui", ProjectType = "blazor-hybrid", ProjectFile = Path.GetFileName(project.CsprojPath) };
                HybridSampleNavigation.Ensure(projectRoot, rootNamespace, rollback, manifest, project);
                WelcomeProjectGenerator.WriteRegistry(projectRoot, rootNamespace, [], rollback, manifest);
                WelcomeProjectGenerator.SaveManifest(projectRoot, manifest, rollback);
                createdFiles.AddRange(manifest.GeneratedFiles);
                modifiedFiles.AddRange(manifest.ModifiedFiles);
            }
            stageProgress.Complete();
            var selectedTemplates = request.SelectedTemplateIds
                .Select(templateId => ControlCatalog.TryResolveOperableTemplate(templateId, out var entry)
                    ? entry
                    : throw new InvalidOperationException($"Control '{templateId}' is not available."))
                .ToList();

            foreach (var entry in selectedTemplates)
            {
                if (!entry.SupportedProjectTypes.Contains(request.ProjectType))
                {
                    var errors = rollback.Rollback();
                    return Fail(
                        $"Control '{entry.Id}' does not support the '{request.ProjectType}' project type.",
                        plan, errors, projectRoot);
                }
            }

            if (selectedTemplates.Count > 0)
            {
                failureStage = "applying the selected control samples";
                Report(steps[2]);
                var installer = new ControlInstaller(projectRoot, _nuget, _dotnet);
                var addResult = await installer.ExecuteAddBatchAsync(
                    selectedTemplates.Select(template => template.Id).ToList(),
                    request.Version,
                    request.Source,
                    request.ConfigFile,
                    force: false,
                    deferBuild: true,
                    cancellationToken: cancellationToken, progress: stages).ConfigureAwait(false);
                if (addResult.ExitCode != ExitCodes.Success)
                {
                    var errors = rollback.Rollback();
                    var message = string.IsNullOrWhiteSpace(addResult.Message)
                        ? "Could not apply the selected controls. Check package-source connectivity and retry."
                        : addResult.Message;
                    return new NewProjectResult
                    {
                        ExitCode = addResult.ExitCode,
                        Message = message,
                        Plan = plan,
                        Errors = [.. addResult.Errors, .. errors],
                        ProjectPath = projectRoot,
                    };
                }

                createdFiles.AddRange(selectedTemplates.SelectMany(template =>
                    template.GeneratedFiles.Select(file => file.Destination)));
                if (selectedTemplates.Any(template =>
                    template.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)))
                {
                    modifiedFiles.Add("MauiProgram.cs");
                }
            }
            else
            {
                Report(steps[2]);
            }

            if (selectedTemplates.Any(template => template.Id == "assistview"))
            {
                AssistViewPlatformConfiguration.Apply(projectRoot);
                modifiedFiles.AddRange(AssistViewPlatformConfiguration.Files);
            }

            Report(steps[3]);
            Report(steps[4]);

            var warnings = new List<string>();

            if (selectedTemplates.Count > 0 || request.ProjectType == MauiProjectType.App)
            {
                failureStage = "writing the project manifest";
                stageProgress.Start("Writing project manifest");
                WriteProjectManifest(projectRoot, request, createdFiles, modifiedFiles);
                stageProgress.Complete();
            }

            var hasControlTemplate = selectedTemplates.Count > 0;

            // Template application already restored all project target frameworks before generation.
            if (request.Restore && !request.Build && !hasControlTemplate)
            {
                failureStage = "restoring the generated project";
                Report(steps[5]);
                stageProgress.Start("Restoring");
                var restoreResult = await _dotnet.RunAsync(
                    ["restore"],
                    projectRoot,
                    dryRun: false,
                    cancellationToken).ConfigureAwait(false);
                if (!restoreResult.Success)
                {
                    var errors = rollback.Rollback();
                    return Fail(
                        "Project restore failed. Check package-source connectivity and retry.",
                        plan,
                        [restoreResult.StandardError, restoreResult.StandardOutput, .. errors],
                        projectRoot);
                }
                stageProgress.Complete();
            }
            else
            {
                Report(steps[5]);
            }

            // Creation is complete. A post-creation build failure must retain the project.
            rollback.Commit();
            generationSucceeded = true;
            // Step 14: build unless suppressed. Build performs its own restore for all enabled targets.
            if (request.Build)
            {
                failureStage = "building the generated project";
                Report(steps[6]);
                stageProgress.Start("Building");
                var projectFile = MauiProjectResolver.Resolve(projectRoot).CsprojPath;
                var buildResult = await new MauiPostCreationBuild(_dotnet)
                    .ExecuteAsync(projectFile, request.BuildFramework, cancellationToken).ConfigureAwait(false);
                if (!buildResult.Success)
                {
                    return new NewProjectResult
                    {
                        ExitCode = ExitCodes.Error,
                        Message = "Project created successfully, but the build failed. The generated project has been retained. Check the reported SDK, workload, or platform-tool requirements, then retry the build.",
                        Plan = plan,
                        Errors = [buildResult.StandardError, buildResult.StandardOutput],
                        CreatedFiles = createdFiles,
                        ModifiedFiles = modifiedFiles,
                        ProjectPath = projectRoot,
                        GenerationSucceeded = true,
                        BuildSucceeded = false,
                    };
                }
                stageProgress.Complete();
            }
            else
            {
                Report($"{steps[6]} (skipped)");
            }

            rollback.Commit();
            return new NewProjectResult
            {
                ExitCode = ExitCodes.Success,
                Message = $"Created MAUI project '{request.Name}' at '{projectRoot}'.",
                Plan = plan,
                CreatedFiles = createdFiles,
                ModifiedFiles = modifiedFiles,
                Warnings = warnings,
                ProjectPath = projectRoot,
                GenerationSucceeded = true,
                BuildSucceeded = request.Build ? true : null,
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
            if (generationSucceeded)
            {
                return new NewProjectResult
                {
                    ExitCode = ExitCodes.Error,
                    Message = $"Project created successfully, but post-creation processing failed while {failureStage}. The generated project has been retained.",
                    Plan = plan,
                    Errors = [ex.Message, .. errors],
                    ProjectPath = projectRoot,
                    GenerationSucceeded = true,
                    BuildSucceeded = request.Build ? false : null,
                    Exception = ex,
                };
            }
            return Fail(
                $"Project creation failed while {failureStage}. See the diagnostic below.",
                plan,
                [ex.Message, .. errors],
                projectRoot,
                ex);
        }
    }

    private (string ProjectRoot, ChangePlan Plan) BuildBasePlan(NewProjectRequest request)
    {
        var projectRoot = ResolveProjectRoot(request);
        var templateIds = request.SelectedTemplateIds;
        var plan = new ChangePlan
        {
            ControlId = templateIds.Count == 0 ? "empty" : string.Join(',', templateIds),
            IsDryRun = request.DryRun,
        };

        plan.CommandsToExecute.Add($"dotnet new {(request.ProjectType == MauiProjectType.BlazorHybrid ? "maui-blazor" : "maui")} -n {request.Name} -o {PathNormalizer.ForDisplay(projectRoot)}");

        var entries = templateIds
            .Select(templateId => ControlCatalog.TryResolveOperableTemplate(templateId, out var entry)
                ? entry
                : throw new InvalidOperationException($"Control '{templateId}' is not available."))
            .ToList();
        foreach (var entry in entries)
        {
            foreach (var file in entry.GeneratedFiles)
            {
                plan.FilesToCreate.Add(file.Destination);
            }

            if (!plan.PackagesToAdd.Contains(entry.PackageId, StringComparer.OrdinalIgnoreCase))
            {
                plan.PackagesToAdd.Add(entry.PackageId);
            }
        }

        if (request.ProjectType == MauiProjectType.App)
        {
            plan.FilesToCreate.AddRange(WelcomeProjectGenerator.TemplateFiles.Keys.Append(WelcomeProjectGenerator.RegistryPath));
            plan.FilesToModify.Add("AppShell.xaml");
        }
        else
        {
            plan.FilesToCreate.AddRange([HybridSampleNavigation.ViewModelPath, "Welcome/WelcomeModel.cs", WelcomeProjectGenerator.RegistryPath]);
            plan.FilesToModify.AddRange(["MainPage.xaml", "MainPage.xaml.cs"]);
        }

        if (entries.Any(entry => entry.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)))
        {
            plan.FilesToModify.Add("MauiProgram.cs");
        }

        if (entries.Any(entry => entry.Id == "assistview"))
        {
            plan.FilesToModify.AddRange(AssistViewPlatformConfiguration.Files);
        }

        if (request.Restore)
        {
            if (!request.Build) { plan.CommandsToExecute.Add("dotnet restore"); }
        }

        if (request.Build)
        {
            plan.CommandsToExecute.Add(MauiPostCreationBuild.DisplayCommand(Path.Combine(projectRoot, $"{request.Name}.csproj"), request.BuildFramework));
        }

        return (projectRoot, plan);
    }

    private static string ResolveProjectRoot(NewProjectRequest request)
        => request.ProjectDirectory;

    private static string FindExistingDirectory(string path)
    {
        var current = path;
        while (!Directory.Exists(current))
        {
            current = Path.GetDirectoryName(current)
                ?? throw new IOException("Project location has no existing directory ancestor.");
        }

        return current;
    }

    private static void WriteProjectManifest(string projectRoot, NewProjectRequest request, IReadOnlyList<string> createdFiles, IReadOnlyList<string> modifiedFiles)
    {
        var manifest = new SyncfusionManifest
        {
            CliVersion = CliMetadata.Version,
            Framework = Frameworks.Name(Core.Framework.Maui),
            ProjectType = request.ProjectType == MauiProjectType.BlazorHybrid ? "blazor-hybrid" : "app",
            ProjectFile = request.Name + ".csproj",
            TargetFramework = string.Join(';', ProjectDetector.Detect(projectRoot)?.TargetFrameworks ?? [request.TargetFramework]),
        };

        // Merge with any manifest the control installer already wrote.
        var existingPath = Path.Combine(projectRoot, "Syncfusion", "syncfusion.json");
        if (File.Exists(existingPath))
        {
            try
            {
                var existing = SyncfusionManifest.FromJson(File.ReadAllText(existingPath));
                manifest.InstalledControls = existing.InstalledControls;
                manifest.PackageIds = existing.PackageIds;
                manifest.PackageVersions = existing.PackageVersions;
                manifest.PackageRequestedVersions = existing.PackageRequestedVersions;
                manifest.InstalledTemplates = existing.InstalledTemplates;
                manifest.RegistrationOwned = existing.RegistrationOwned;
                manifest.TargetFramework = existing.TargetFramework;
                manifest.GeneratedFiles = existing.GeneratedFiles;
                manifest.ModifiedFiles = existing.ModifiedFiles;
                manifest.OriginalHashes = existing.OriginalHashes;
                manifest.SchemaVersion = existing.SchemaVersion;
                manifest.GeneratedBlocks = existing.GeneratedBlocks;
                manifest.WelcomeFiles = existing.WelcomeFiles;
            }
            catch (System.Exception ex)
            {
                // The existing manifest is missing or corrupt; merging installed
                // controls is best-effort, so continue with a fresh manifest rather
                // than failing project creation.
                _ = ex;
            }
        }

        foreach (var f in createdFiles)
        {
            if (!manifest.GeneratedFiles.Contains(f))
            {
                manifest.GeneratedFiles.Add(f);
            }
        }

        foreach (var f in modifiedFiles)
        {
            if (!manifest.ModifiedFiles.Contains(f))
            {
                manifest.ModifiedFiles.Add(f);
            }
        }

        manifest.OriginalHashes ??= [];
        foreach (var f in createdFiles.Concat(modifiedFiles))
        {
            var full = TemplatePathResolver.ResolveDestination(projectRoot, f);
            var hash = FileRollback.ComputeHash(full);
            if (hash is not null)
            {
                manifest.OriginalHashes[f] = hash;
            }
        }

        var dir = Path.Combine(projectRoot, "Syncfusion");
        Directory.CreateDirectory(dir);
        File.WriteAllText(Path.Combine(dir, "syncfusion.json"), manifest.ToJson());
    }

    private static NewProjectResult Fail(
        string message,
        ChangePlan plan,
        IReadOnlyList<string> errors,
        string? projectRoot,
        System.Exception? exception = null)
        => new()
        {
            ExitCode = ExitCodes.Error,
            Message = message,
            Plan = plan,
            Errors = errors,
            ProjectPath = projectRoot,
            Exception = exception,
        };
}
