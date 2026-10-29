using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// Detects the SDK and target framework of a .NET project from its .csproj
/// file. Used by the add/remove/update flow to validate the framework against
/// the catalog and to populate the manifest. Pure parsing; no SDK invocation.
/// </summary>
public static class ProjectDetector
{
    /// <summary>The result of detecting project metadata.</summary>
    public sealed class ProjectInfo
    {
        public required string CsprojPath { get; init; }
        public string? Sdk { get; init; }
        public string? TargetFramework { get; init; }
        /// <summary>
        /// All literal target frameworks declared by the project. Unresolved
        /// property expressions are retained so template compatibility checks
        /// can reject them instead of guessing from the installed SDK.
        /// </summary>
        public IReadOnlyList<string> TargetFrameworks { get; init; } = [];
        public string? OutputType { get; init; }
        /// <summary>The literal root namespace declared in the project, when present.</summary>
        public string? RootNamespace { get; init; }

        /// <summary>True when the project's &lt;UseMaui&gt; element is "true".</summary>
        public bool UseMaui { get; init; }
    }

    /// <summary>The outcome of detecting a single project in a directory.</summary>
    public enum DetectionStatus
    {
        /// <summary>Exactly one .csproj was found and parsed.</summary>
        Found,
        /// <summary>No .csproj was found in the supplied path.</summary>
        NotFound,
        /// <summary>Multiple .csproj files were found in the supplied directory.</summary>
        MultipleProjects,
    }

    /// <summary>
    /// The result of a single-project detection, distinguishing the
    /// "not found", "multiple found", and "found" cases so callers can give
    /// the user clear guidance. <see cref="Detect"/> remains a thin wrapper
    /// that returns null for any non-found case for read-only callers that
    /// treat ambiguity as "no project" (for example <c>sf list installed</c>).
    /// </summary>
    public sealed class DetectionResult
    {
        public required DetectionStatus Status { get; init; }
        public ProjectInfo? Info { get; init; }
        public int ProjectCount { get; init; }
    }

    /// <summary>
    /// Finds and parses the single .csproj in <paramref name="projectRoot"/>,
    /// or the csproj at <paramref name="projectRoot"/> itself if a file path
    /// was supplied. Returns null when no csproj is found. When the path is a
    /// directory that contains multiple .csproj files, only the first is
    /// returned; callers that must disambiguate should use
    /// <see cref="DetectSingle"/> instead.
    /// </summary>
    public static ProjectInfo? Detect(string projectRoot)
    {
        var result = DetectSingle(projectRoot);
        return result.Status == DetectionStatus.Found ? result.Info : null;
    }

    /// <summary>
    /// Detects a single .csproj and returns a <see cref="DetectionResult"/>
    /// that distinguishes "not found", "multiple found", and "found". When the
    /// path is a file matching a .csproj, the file is parsed directly. When the
    /// path is a directory, exactly one .csproj is required; multiple .csproj
    /// files in the same directory cause <see cref="DetectionStatus.MultipleProjects"/>.
    /// </summary>
    public static DetectionResult DetectSingle(string projectRoot)
    {
        if (string.IsNullOrWhiteSpace(projectRoot))
        {
            return new DetectionResult { Status = DetectionStatus.NotFound };
        }

        if (File.Exists(projectRoot) && projectRoot.EndsWith(".csproj", System.StringComparison.OrdinalIgnoreCase))
        {
            return new DetectionResult
            {
                Status = DetectionStatus.Found,
                Info = ParseProjectFile(projectRoot),
                ProjectCount = 1,
            };
        }

        if (!Directory.Exists(projectRoot))
        {
            return new DetectionResult { Status = DetectionStatus.NotFound };
        }

        var csprojs = Directory.GetFiles(projectRoot, "*.csproj", SearchOption.TopDirectoryOnly);
        if (csprojs.Length == 0)
        {
            return new DetectionResult { Status = DetectionStatus.NotFound };
        }

        if (csprojs.Length > 1)
        {
            return new DetectionResult
            {
                Status = DetectionStatus.MultipleProjects,
                ProjectCount = csprojs.Length,
            };
        }

        return new DetectionResult
        {
            Status = DetectionStatus.Found,
            Info = ParseProjectFile(csprojs[0]),
            ProjectCount = 1,
        };
    }

    private static ProjectInfo ParseProjectFile(string csproj)
    {
        var project = XDocument.Load(csproj);
        var targetFrameworks = project
            .Descendants()
            .Where(element => element.Name.LocalName is "TargetFramework" or "TargetFrameworks")
            .SelectMany(element => element.Value.Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
            .Distinct(System.StringComparer.OrdinalIgnoreCase)
            .ToList();
        return new ProjectInfo
        {
            CsprojPath = csproj,
            Sdk = (string?)project.Root?.Attribute("Sdk"),
            TargetFramework = targetFrameworks.FirstOrDefault(),
            TargetFrameworks = targetFrameworks,
            OutputType = project.Descendants().FirstOrDefault(element => element.Name.LocalName == "OutputType")?.Value.Trim(),
            RootNamespace = project.Descendants().FirstOrDefault(element => element.Name.LocalName == "RootNamespace")?.Value.Trim(),
            UseMaui = string.Equals(
                project.Descendants().FirstOrDefault(element => element.Name.LocalName == "UseMaui")?.Value.Trim(),
                "true",
                System.StringComparison.OrdinalIgnoreCase),
        };
    }

    /// <summary>
    /// True when the project is a .NET MAUI project. The current SDK template
    /// generates <c>Sdk="Microsoft.NET.Sdk"</c> with <c>&lt;UseMaui&gt;true&lt;/UseMaui&gt;</c>;
    /// the legacy <c>Microsoft.NET.Maui.Sdk</c> SDK name is also accepted for
    /// older projects.
    /// </summary>
    public static bool IsMaui(ProjectInfo info)
        => info.UseMaui || string.Equals(info.Sdk, "Microsoft.NET.Maui.Sdk", System.StringComparison.OrdinalIgnoreCase);

}
