using System.Reflection;
using System.Text.Json;
using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>Loads the embedded package and template catalogs independently.</summary>
public static class CatalogLoader
{
    private const string PackageResourceSuffix = ".Catalog.package-catalog.json";
    private const string TemplateResourceSuffix = ".Catalog.template-catalog.json";

    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
    };

    /// <summary>Loads the control-specific templates.</summary>
    public static IReadOnlyList<ControlCatalogEntry> Load() => LoadTemplates();

    /// <summary>Loads a template catalog JSON stream for metadata tests.</summary>
    public static IReadOnlyList<ControlCatalogEntry> Parse(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        var json = JsonSerializer.Deserialize<TemplateCatalogJson>(stream, Options)
            ?? throw new InvalidOperationException("Template catalog is empty or malformed.");
        return MapTemplates(json);
    }

    internal static IReadOnlyList<MauiPackageDefinition> LoadPackages()
    {
        var (_, stream) = OpenCatalogStream(PackageResourceSuffix);
        using (stream)
        {
            return ParsePackages(stream);
        }
    }

    /// <summary>Parses and validates the independently versioned package catalog.</summary>
    public static IReadOnlyList<MauiPackageDefinition> ParsePackages(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        var json = JsonSerializer.Deserialize<PackageCatalogJson>(stream, Options)
            ?? throw new InvalidOperationException("MAUI package catalog is empty or malformed.");
        if (json.SchemaVersion != 1 || json.Packages is null || json.Packages.Count == 0)
        {
            throw new InvalidOperationException("The package catalog requires schemaVersion 1 and a nonempty packages array.");
        }
        if (json.Packages.Any(package => package is null))
        {
            throw new InvalidOperationException("The package catalog cannot contain null entries.");
        }
        var packages = MapPackages(json);
        var errors = PackageCatalogValidator.Validate(packages);
        if (errors.Count > 0)
        {
            throw new InvalidOperationException(
                $"The MAUI package catalog is invalid:{Environment.NewLine}{string.Join(Environment.NewLine, errors)}");
        }
        return packages.OrderBy(package => package.Alias, StringComparer.OrdinalIgnoreCase).ToList();
    }

    internal static IReadOnlyList<ControlCatalogEntry> LoadTemplates()
    {
        var (assembly, stream) = OpenCatalogStream(TemplateResourceSuffix);
        using (stream)
        {
            var json = JsonSerializer.Deserialize<TemplateCatalogJson>(stream, Options)
                ?? throw new InvalidOperationException("MAUI template catalog is empty or malformed.");
            var templates = MapTemplates(json);
            var errors = TemplateCatalogValidator.Validate(
                templates,
                PackageCatalog.All,
                assembly.GetManifestResourceNames());
            if (errors.Count > 0)
            {
                throw new InvalidOperationException(
                    $"The embedded MAUI template catalog is invalid:{Environment.NewLine}{string.Join(Environment.NewLine, errors)}");
            }

            return templates;
        }
    }

    private static IReadOnlyList<MauiPackageDefinition> MapPackages(PackageCatalogJson json)
        => json.Packages.Select(package => new MauiPackageDefinition
        {
            Alias = package.Alias,
            DisplayName = package.DisplayName,
            PackageId = package.PackageId,
            Description = package.Description,
            Category = package.Category,
            ProductFamily = package.ProductFamily,
            Classification = package.Classification,
            Status = package.Status,
            RegistrationRequirement = package.RegistrationRequirement,
            RegistrationEvidence = package.RegistrationEvidence,
            VersionStrategy = package.VersionStrategy,
            Recommended = package.Recommended,
            DocumentationUrl = package.DocumentationUrl,
            VerificationNotes = package.VerificationNotes,
            ReplacementPackageId = package.ReplacementPackageId,
        }).ToList();

    private static IReadOnlyList<ControlCatalogEntry> MapTemplates(TemplateCatalogJson json)
    {
        var entries = new List<ControlCatalogEntry>(json.Templates.Count);
        foreach (var template in json.Templates)
        {
            entries.Add(new ControlCatalogEntry
            {
                Id = template.Id,
                Family = template.Family,
                ControlIdentity = template.ControlIdentity,
                Available = template.Available,
                Verified = template.Verified,
                Operable = template.Operable,
                LegacyAliases = template.LegacyAliases,
                EmbeddedResources = template.EmbeddedResources,
                DisplayName = template.DisplayName,
                Description = template.Description,
                PackageId = template.PackageId,
                DependentPackageIds = template.DependentPackageIds,
                DocumentationUrl = template.DocumentationUrl,
                XamlNamespace = template.XamlNamespace,
                XamlPrefix = template.XamlPrefix,
                ControlType = template.ControlType,
                ControlName = template.ControlName,
                CSharpNamespace = template.CSharpNamespace,
                RegistrationUsing = template.RegistrationUsing,
                RegistrationCall = template.RegistrationCall,
                RegistrationRequirement = template.RegistrationRequirement,
                RegistrationVerified = template.RegistrationVerified,
                RegistrationEvidence = template.RegistrationEvidence,
                SupportedProjectTypes = template.SupportedProjectTypes.Select(ParseProjectType).ToList(),
                Compatibility = new TemplateCompatibility
                {
                    ValidationStrategy = template.Compatibility.ValidationStrategy,
                    TargetFrameworkSource = template.Compatibility.TargetFrameworkSource,
                    PackageVersionPolicy = template.Compatibility.PackageVersionPolicy,
                },
                TemplatePath = template.TemplatePath,
                GeneratedFiles = template.GeneratedFiles.Select(file => new GeneratedFile
                {
                    Destination = file.Destination,
                    TemplateResource = file.TemplateResource,
                }).ToList(),
            });
        }

        return entries;
    }

    private static (Assembly Assembly, Stream Stream) OpenCatalogStream(string resourceSuffix)
    {
        MauiAssemblyLoader.EnsureLoaded();
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies()
            .OrderBy(candidate => candidate.FullName, StringComparer.Ordinal))
        {
            try
            {
                foreach (var resourceName in assembly.GetManifestResourceNames()
                    .OrderBy(name => name, StringComparer.Ordinal))
                {
                    if (!resourceName.EndsWith(resourceSuffix, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    var stream = assembly.GetManifestResourceStream(resourceName);
                    if (stream is not null)
                    {
                        return (assembly, stream);
                    }
                }
            }
            catch (NotSupportedException)
            {
                // Dynamic assemblies do not always support resource enumeration.
            }
        }

        throw new InvalidOperationException($"No embedded catalog resource ending with '{resourceSuffix}' was found.");
    }

    private static MauiProjectType ParseProjectType(string value)
        => string.Equals(value, "blazor-hybrid", StringComparison.OrdinalIgnoreCase)
            ? MauiProjectType.BlazorHybrid
            : MauiProjectType.App;
}
