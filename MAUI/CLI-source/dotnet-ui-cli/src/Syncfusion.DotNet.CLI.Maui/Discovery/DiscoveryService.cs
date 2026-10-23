using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Maui.Discovery;

/// <summary>Provides package, template, and CLI discovery data.</summary>
public static class DiscoveryService
{
    public static readonly IReadOnlyList<string> SupportedTemplateIds =
        TemplateCatalog.Operable.Select(template => template.Id).ToList().AsReadOnly();

    /// <summary>A catalog package row.</summary>
    public sealed record PackageInfo(
        [property: JsonPropertyName("alias")] string Alias,
        [property: JsonPropertyName("displayName")] string DisplayName,
        [property: JsonPropertyName("packageId")] string PackageId,
        [property: JsonPropertyName("description")] string Description,
        [property: JsonPropertyName("category")] string Category,
        [property: JsonPropertyName("productFamily")] string ProductFamily,
        [property: JsonPropertyName("classification")] string Classification,
        [property: JsonPropertyName("status")] string Status,
        [property: JsonPropertyName("recommended")] bool Recommended,
        [property: JsonPropertyName("registrationRequirement")] string RegistrationRequirement,
        [property: JsonPropertyName("versionStrategy")] string VersionStrategy,
        [property: JsonPropertyName("verificationNotes")] string? VerificationNotes);

    /// <summary>A direct Syncfusion MAUI package reference in the project.</summary>
    public sealed record InstalledPackage(
        [property: JsonPropertyName("alias")] string? Alias,
        [property: JsonPropertyName("packageId")] string PackageId,
        [property: JsonPropertyName("version")] string? Version);

    /// <summary>A verified concrete control-specific template.</summary>
    public sealed record TemplateInfo(
        [property: JsonPropertyName("templateId")] string TemplateId,
        [property: JsonPropertyName("displayName")] string DisplayName,
        [property: JsonPropertyName("templateFamily")] string TemplateFamily,
        [property: JsonPropertyName("controlIdentity")] string ControlIdentity,
        [property: JsonPropertyName("requiredPackageId")] string RequiredPackageId,
        [property: JsonPropertyName("available")] bool Available,
        [property: JsonPropertyName("verified")] bool Verified,
        [property: JsonPropertyName("operable")] bool Operable,
        [property: JsonPropertyName("legacyAliases")] IReadOnlyList<string> LegacyAliases);

    public sealed record InfoPayload(
        [property: JsonPropertyName("packageId")] string PackageId,
        [property: JsonPropertyName("cliVersion")] string CliVersion,
        [property: JsonPropertyName("toolCommand")] string ToolCommand,
        [property: JsonPropertyName("supportedPlatforms")] IReadOnlyList<string> SupportedPlatforms,
        [property: JsonPropertyName("implementedPlatforms")] IReadOnlyList<string> ImplementedPlatforms,
        [property: JsonPropertyName("availableCommands")] IReadOnlyList<string> AvailableCommands,
        [property: JsonPropertyName("mauiCatalogVersion")] string MauiCatalogVersion,
        [property: JsonPropertyName("manifestSchemaVersion")] int ManifestSchemaVersion,
        [property: JsonPropertyName("documentationLocation")] string DocumentationLocation);

    public static IReadOnlyList<PackageInfo> ListPackages()
        => PackageCatalog.All.Select(ToPackageInfo).ToList();

    public static IReadOnlyList<PackageInfo> SearchPackages(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return [];
        }

        var needle = text.Trim();
        return PackageCatalog.All
            .Where(package => ContainsAny(
                needle,
                package.Alias,
                package.PackageId,
                package.DisplayName,
                package.Description))
            .Select(ToPackageInfo)
            .ToList();
    }

    /// <summary>
    /// Returns direct Syncfusion MAUI package references. Central package versions
    /// are read from the nearest standard Directory.Packages.props file.
    /// </summary>
    public static IReadOnlyList<InstalledPackage> ListInstalledPackages(string? projectRootOrCsproj)
    {
        if (string.IsNullOrWhiteSpace(projectRootOrCsproj))
        {
            return [];
        }

        var project = ProjectDetector.Detect(projectRootOrCsproj);
        if (project is null)
        {
            return [];
        }

        var projectDocument = XDocument.Load(project.CsprojPath);
        var projectRoot = Path.GetDirectoryName(project.CsprojPath)
            ?? throw new InvalidOperationException($"Project path '{project.CsprojPath}' has no parent directory.");
        var centralVersions = LoadCentralPackageVersions(projectRoot);

        return projectDocument
            .Descendants()
            .Where(element => element.Name.LocalName.Equals("PackageReference", StringComparison.OrdinalIgnoreCase))
            .Select(element => CreateInstalledPackage(element, centralVersions))
            .Where(package => package is not null)
            .Cast<InstalledPackage>()
            .GroupBy(package => package.PackageId, StringComparer.OrdinalIgnoreCase)
            .Select(group =>
            {
                var versions = group.Select(package => package.Version).Distinct(StringComparer.Ordinal).ToList();
                if (versions.Count > 1)
                {
                    throw new InvalidOperationException($"Project has conflicting direct versions for package '{group.Key}'.");
                }

                return group.First();
            })
            .OrderBy(package => package.PackageId, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    public static IReadOnlyList<TemplateInfo> ListTemplates()
        => TemplateCatalog.Operable
            .OrderBy(template => template.Family, StringComparer.OrdinalIgnoreCase)
            .ThenBy(template => template.DisplayName, StringComparer.OrdinalIgnoreCase)
            .Select(template => new TemplateInfo(
                template.Id,
                template.DisplayName,
                template.Family,
                template.ControlIdentity,
                template.PackageId,
                template.Available,
                template.Verified,
                template.Operable,
                template.LegacyAliases))
            .ToList();

    public static InfoPayload GetInfo()
        => new(
            PackageId: "Syncfusion.DotNet.CLI",
            CliVersion: CliMetadata.Version,
            ToolCommand: "sf",
            SupportedPlatforms: Frameworks.All.ToList(),
            ImplementedPlatforms: Frameworks.Implemented.ToList(),
            // Improvement: package removal is temporarily disabled, including discovery advertising.
            AvailableCommands: ["new", "add", "update", "list", "search", "help", "info"],
            MauiCatalogVersion: "3",
            ManifestSchemaVersion: 1,
            DocumentationLocation: "docs/command-reference.md");

    private static PackageInfo ToPackageInfo(MauiPackageDefinition package)
        => new(
            package.Alias,
            package.DisplayName,
            package.PackageId,
            package.Description ?? string.Empty,
            package.Category,
            package.ProductFamily,
            package.Classification,
            package.Status,
            package.Recommended,
            package.RegistrationRequirement,
            package.VersionStrategy,
            package.VerificationNotes);

    private static InstalledPackage? CreateInstalledPackage(
        XElement reference,
        IReadOnlyDictionary<string, string> centralVersions)
    {
        var packageId = (string?)reference.Attribute("Include");
        if (string.IsNullOrWhiteSpace(packageId)
            || !packageId.StartsWith("Syncfusion.Maui.", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        var version = (string?)reference.Attribute("VersionOverride")
            ?? (string?)reference.Attribute("Version")
            ?? reference.Elements().FirstOrDefault(element =>
                element.Name.LocalName.Equals("Version", StringComparison.OrdinalIgnoreCase))?.Value;
        if (string.IsNullOrWhiteSpace(version) && centralVersions.TryGetValue(packageId, out var centralVersion))
        {
            version = centralVersion;
        }

        PackageCatalog.TryResolve(packageId, out var package);
        return new InstalledPackage(package?.Alias, packageId, string.IsNullOrWhiteSpace(version) ? null : version.Trim());
    }

    private static IReadOnlyDictionary<string, string> LoadCentralPackageVersions(string projectDirectory)
    {
        var current = new DirectoryInfo(projectDirectory);
        while (current is not null)
        {
            var files = Directory.EnumerateFiles(current.FullName)
                .Where(path => Path.GetFileName(path).Equals("Directory.Packages.props", StringComparison.OrdinalIgnoreCase))
                .OrderBy(path => path, StringComparer.Ordinal)
                .ToList();
            if (files.Count > 1)
            {
                throw new InvalidOperationException($"Multiple Directory.Packages.props files with case-insensitive matching exist in '{current.FullName}'.");
            }

            if (files.Count == 1)
            {
                var document = XDocument.Load(files[0]);
                return document.Descendants()
                    .Where(element => element.Name.LocalName.Equals("PackageVersion", StringComparison.OrdinalIgnoreCase))
                    .Select(element => new
                    {
                        PackageId = (string?)element.Attribute("Include"),
                        Version = (string?)element.Attribute("Version")
                            ?? element.Elements().FirstOrDefault(child =>
                                child.Name.LocalName.Equals("Version", StringComparison.OrdinalIgnoreCase))?.Value,
                    })
                    .Where(item => !string.IsNullOrWhiteSpace(item.PackageId)
                        && !string.IsNullOrWhiteSpace(item.Version))
                    .ToDictionary(item => item.PackageId!, item => item.Version!, StringComparer.OrdinalIgnoreCase);
            }

            current = current.Parent;
        }

        return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    }

    private static bool ContainsAny(string needle, params string?[] values)
        => values.Any(value => value is not null && value.Contains(needle, StringComparison.OrdinalIgnoreCase));

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = null,
        DefaultIgnoreCondition = JsonIgnoreCondition.Never,
    };

    public static string ToJson<T>(T value) => JsonSerializer.Serialize(value, JsonOptions);
}
