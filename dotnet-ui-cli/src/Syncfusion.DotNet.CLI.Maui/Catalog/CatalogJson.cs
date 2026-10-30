using System.Text.Json;
using System.Text.Json.Serialization;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>
/// The independently versioned package-catalog JSON shape.
/// </summary>
internal sealed class PackageCatalogJson
{
    [JsonRequired]
    [JsonPropertyName("schemaVersion")]
    public int SchemaVersion { get; set; }

    [JsonRequired]
    [JsonPropertyName("packages")]
    public List<PackageEntryJson> Packages { get; set; } = [];
}

/// <summary>The independently versioned control-template catalog JSON shape.</summary>
internal sealed class TemplateCatalogJson
{
    [JsonPropertyName("schemaVersion")]
    public int SchemaVersion { get; set; }

    [JsonPropertyName("templates")]
    public List<TemplateEntryJson> Templates { get; set; } = [];
}

internal sealed class PackageEntryJson
{
    [JsonRequired]
    [JsonPropertyName("alias")]
    public string Alias { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("packageId")]
    public string PackageId { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonRequired]
    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("productFamily")]
    public string ProductFamily { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("classification")]
    public string Classification { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("registrationRequirement")]
    public string RegistrationRequirement { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("registrationEvidence")]
    public string RegistrationEvidence { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("versionStrategy")]
    public string VersionStrategy { get; set; } = string.Empty;

    [JsonRequired]
    [JsonPropertyName("recommended")]
    public bool Recommended { get; set; }

    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }

    [JsonPropertyName("verificationNotes")]
    public string? VerificationNotes { get; set; }

    [JsonPropertyName("replacementPackageId")]
    public string? ReplacementPackageId { get; set; }
}

internal sealed class TemplateEntryJson
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("family")]
    public string Family { get; set; } = string.Empty;

    [JsonPropertyName("controlIdentity")]
    public string ControlIdentity { get; set; } = string.Empty;

    [JsonPropertyName("available")]
    public bool Available { get; set; }

    [JsonPropertyName("operable")]
    public bool Operable { get; set; }

    /// <summary>
    /// The template metadata verification state.
    /// </summary>
    /// <summary>
    /// True when the template metadata is verified. An unverified template
    /// must never be made operable.
    /// </summary>
    [JsonPropertyName("verified")]
    public bool Verified { get; set; } = true;

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("legacyAliases")]
    public List<string> LegacyAliases { get; set; } = [];

    [JsonPropertyName("embeddedResources")]
    public List<string> EmbeddedResources { get; set; } = [];

    [JsonPropertyName("packageId")]
    public string PackageId { get; set; } = string.Empty;

    [JsonPropertyName("dependentPackageIds")]
    public List<string> DependentPackageIds { get; set; } = [];

    [JsonPropertyName("documentationUrl")]
    public string DocumentationUrl { get; set; } = string.Empty;

    [JsonPropertyName("xamlNamespace")]
    public string XamlNamespace { get; set; } = string.Empty;

    [JsonPropertyName("xamlPrefix")]
    public string XamlPrefix { get; set; } = string.Empty;

    [JsonPropertyName("controlType")]
    public string ControlType { get; set; } = string.Empty;

    [JsonPropertyName("controlName")]
    public string ControlName { get; set; } = string.Empty;

    [JsonPropertyName("csharpNamespace")]
    public string CSharpNamespace { get; set; } = string.Empty;

    [JsonPropertyName("registrationUsing")]
    public string RegistrationUsing { get; set; } = string.Empty;

    [JsonPropertyName("registrationCall")]
    public string RegistrationCall { get; set; } = string.Empty;

    [JsonPropertyName("registrationRequirement")]
    public string RegistrationRequirement { get; set; } = string.Empty;

    [JsonPropertyName("registrationVerified")]
    public bool RegistrationVerified { get; set; }

    [JsonPropertyName("registrationEvidence")]
    public string RegistrationEvidence { get; set; } = string.Empty;

    [JsonPropertyName("supportedProjectTypes")]
    public List<string> SupportedProjectTypes { get; set; } = [];

    [JsonPropertyName("compatibility")]
    public TemplateCompatibilityJson Compatibility { get; set; } = new();

    [JsonPropertyName("templatePath")]
    public string TemplatePath { get; set; } = string.Empty;

    [JsonPropertyName("generatedFiles")]
    public List<GeneratedFileJson> GeneratedFiles { get; set; } = [];
}

internal sealed class TemplateCompatibilityJson
{
    [JsonPropertyName("validationStrategy")]
    public string ValidationStrategy { get; set; } = string.Empty;

    [JsonPropertyName("targetFrameworkSource")]
    public string TargetFrameworkSource { get; set; } = string.Empty;

    [JsonPropertyName("packageVersionPolicy")]
    public string PackageVersionPolicy { get; set; } = string.Empty;
}

internal sealed class GeneratedFileJson
{
    [JsonPropertyName("destination")]
    public string Destination { get; set; } = string.Empty;

    [JsonPropertyName("templateResource")]
    public string TemplateResource { get; set; } = string.Empty;
}
