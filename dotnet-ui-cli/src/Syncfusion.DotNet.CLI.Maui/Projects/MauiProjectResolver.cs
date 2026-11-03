using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Resolves one valid MAUI project for an existing-project operation.</summary>
public static class MauiProjectResolver
{
    /// <summary>
    /// Resolves an explicit project file or a directory containing exactly
    /// one MAUI project. A selector may resolve multiple candidates in an
    /// interactive workflow; without one, ambiguity is reported.
    /// </summary>
    public static ProjectDetector.ProjectInfo Resolve(
        string? path,
        Func<IReadOnlyList<ProjectDetector.ProjectInfo>, ProjectDetector.ProjectInfo>? selector = null)
    {
        var target = string.IsNullOrWhiteSpace(path) ? Environment.CurrentDirectory : Path.GetFullPath(path);

        if (File.Exists(target))
        {
            if (!string.Equals(Path.GetExtension(target), ".csproj", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException($"'{target}' is a file, not a .csproj project file.");
            }

            return ValidateMauiProject(ProjectDetector.DetectSingle(target).Info!);
        }

        if (!Directory.Exists(target))
        {
            throw NoProject(target);
        }

        // Use the nearest project boundary; never guess among descendants or
        // climb past a different project into an unrelated parent project.
        var directory = new DirectoryInfo(target);
        while (!directory.EnumerateFiles("*.csproj", SearchOption.TopDirectoryOnly).Any())
        {
            if (directory.Parent is null || Directory.Exists(Path.Combine(directory.FullName, ".git")) || File.Exists(Path.Combine(directory.FullName, ".git")))
                throw NoProject(target);
            directory = directory.Parent;
        }
        target = directory.FullName;
        var projects = Directory
            .EnumerateFiles(target, "*.csproj", SearchOption.TopDirectoryOnly)
            .OrderBy(projectPath => projectPath, StringComparer.OrdinalIgnoreCase)
            .ThenBy(projectPath => projectPath, StringComparer.Ordinal)
            .Select(projectPath => ProjectDetector.DetectSingle(projectPath).Info!)
            .ToList();
        var candidates = projects.Where(ProjectDetector.IsMaui).ToList();

        if (candidates.Count == 0)
        {
            if (projects.Count == 1)
            {
                return ValidateMauiProject(projects[0]);
            }

            if (projects.Count > 1)
            {
                throw new InvalidOperationException(
                    $"Found {projects.Count} project files in '{target}', but none is a MAUI project. Pass -p with a MAUI .csproj path.");
            }

            throw NoProject(target);
        }

        if (candidates.Count == 1)
        {
            return candidates[0];
        }

        if (selector is not null)
        {
            var selected = selector(candidates.AsReadOnly());
            if (candidates.Any(candidate => string.Equals(candidate.CsprojPath, selected.CsprojPath, StringComparison.Ordinal)))
            {
                return selected;
            }

            throw new InvalidOperationException("The selected project is not one of the MAUI projects found in the target directory.");
        }

        throw new InvalidOperationException(
            $"Found {candidates.Count} MAUI projects in '{target}'. Pass -p with a specific .csproj path.");
    }

    /// <summary>Validates that a supplied project file is a MAUI project.</summary>
    public static ProjectDetector.ProjectInfo ValidateMauiProject(ProjectDetector.ProjectInfo info)
    {
        if (!ProjectDetector.IsMaui(info))
        {
            var sdk = string.IsNullOrWhiteSpace(info.Sdk) ? "(none)" : info.Sdk;
            throw new InvalidOperationException(
                $"The project '{Path.GetFileName(info.CsprojPath)}' is not a .NET MAUI project (SDK '{sdk}'). Pass -p with a MAUI .csproj path.");
        }

        return info;
    }

    /// <summary>
    /// Chooses a declared MAUI target for compile validation. On macOS Android
    /// is preferred so template validation does not depend on an Xcode version
    /// compatible with the installed Mac Catalyst workload. Package restore
    /// still evaluates every target framework in the project.
    /// </summary>
    public static string? SelectSupportedBuildTarget(ProjectDetector.ProjectInfo project)
        => SelectSupportedBuildTarget(project.TargetFrameworks);

    /// <summary>Selects the compile-validation target from evaluated project target frameworks.</summary>
    public static string? SelectSupportedBuildTarget(IReadOnlyList<string> targetFrameworks)
    {
        var platform = RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
            ? "android"
            : RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? "windows"
                : "android";
        return targetFrameworks.FirstOrDefault(framework =>
                framework.Contains($"-{platform}", StringComparison.OrdinalIgnoreCase))
            ?? targetFrameworks.FirstOrDefault(framework =>
                !framework.Contains('-', StringComparison.Ordinal));
    }

    private static DirectoryNotFoundException NoProject(string path)
        => new($"No MAUI .csproj project was found at '{path}'. Run the command in a MAUI project directory or pass -p <path-to-project.csproj>.");
}
