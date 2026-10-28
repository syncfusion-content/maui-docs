using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// One control-specific MAUI template.
/// </summary>
public sealed record ControlCatalogEntry
{
    /// <summary>The canonical, lowercase template ID.</summary>
    public required string Id { get; init; }

    /// <summary>The approved top-level template family.</summary>
    public required string Family { get; init; }

    /// <summary>The exact Syncfusion control type represented by this template.</summary>
    public required string ControlIdentity { get; init; }

    /// <summary>Whether all referenced embedded template resources are present.</summary>
    public required bool Available { get; init; }

    /// <summary>Whether the template metadata has been verified.</summary>
    public required bool Verified { get; init; }

    /// <summary>Whether the template can be selected for an operation.</summary>
    public required bool Operable { get; init; }

    /// <summary>Deprecated template IDs accepted for compatibility.</summary>
    public required IReadOnlyList<string> LegacyAliases { get; init; } = [];

    /// <summary>The embedded template resources used to materialize this template.</summary>
    public required IReadOnlyList<string> EmbeddedResources { get; init; } = [];

    /// <summary>The control-specific template display name.</summary>
    public required string DisplayName { get; init; }

    /// <summary>A short getting-started description.</summary>
    public required string Description { get; init; }

    /// <summary>The primary Syncfusion NuGet package id to add to the project.</summary>
    public required string PackageId { get; init; }

    /// <summary>
    /// Dependent packages the CLI must also reference. The primary package's
    /// own transitive dependencies are restored by NuGet and are NOT listed
    /// here; only packages that the getting-started docs require to be added
    /// explicitly to the project (currently none for the supported controls).
    /// </summary>
    public required IReadOnlyList<string> DependentPackageIds { get; init; } = [];

    /// <summary>The official getting-started documentation URL.</summary>
    public required string DocumentationUrl { get; init; }

    /// <summary>The XAML <c>xmlns:</c> clr-namespace;assembly declaration.</summary>
    public required string XamlNamespace { get; init; }

    /// <summary>The XAML prefix used for the control (e.g. <c>syncfusion</c>).</summary>
    public required string XamlPrefix { get; init; }

    /// <summary>The control's XAML element name (e.g. <c>SfDataGrid</c>).</summary>
    public required string ControlType { get; init; }

    /// <summary>Valid identifier segment used in generated namespaces.</summary>
    public required string ControlName { get; init; }

    /// <summary>The C# using namespace for the control (e.g. Syncfusion.Maui.DataGrid).</summary>
    public required string CSharpNamespace { get; init; }

    /// <summary>The <c>MauiProgram</c> registration using directive.</summary>
    public required string RegistrationUsing { get; init; }

    /// <summary>The <c>MauiProgram</c> registration call expression.</summary>
    public required string RegistrationCall { get; init; }

    /// <summary>The verified registration classification used by this template.</summary>
    public required string RegistrationRequirement { get; init; }

    /// <summary>Whether template-specific registration is verified.</summary>
    public required bool RegistrationVerified { get; init; }

    /// <summary>Evidence supporting the template-specific registration metadata.</summary>
    public required string RegistrationEvidence { get; init; }

    /// <summary>The MAUI project types this control supports.</summary>
    public required IReadOnlyList<MauiProjectType> SupportedProjectTypes { get; init; } = [];

    /// <summary>The runtime policy used to evaluate this template's package and target framework together.</summary>
    public required TemplateCompatibility Compatibility { get; init; }

    /// <summary>The embedded template folder path relative to the assembly.</summary>
    public required string TemplatePath { get; init; }

    /// <summary>The generated-file definitions keyed by destination path (relative).</summary>
    public required IReadOnlyList<GeneratedFile> GeneratedFiles { get; init; } = [];
}

/// <summary>
/// Describes how package-version, target-framework, and generated-API
/// compatibility is evaluated. This policy is deliberately runtime-based;
/// NuGet compatibility is not inferred from SDK installation or version order.
/// </summary>
public sealed record TemplateCompatibility
{
    /// <summary>The verification performed before a template is committed.</summary>
    public required string ValidationStrategy { get; init; }

    /// <summary>Source of the target frameworks used for compatibility evaluation.</summary>
    public required string TargetFrameworkSource { get; init; }

    /// <summary>How the package version is chosen before exact resolution.</summary>
    public required string PackageVersionPolicy { get; init; }
}

/// <summary>
/// A single file the CLI will generate from a template. The destination is
/// relative to the project root; the template resource is the embedded path.
/// </summary>
public sealed record GeneratedFile
{
    /// <summary>The relative destination path under the project root.</summary>
    public required string Destination { get; init; }

    /// <summary>The embedded template resource path (without leading slash).</summary>
    public required string TemplateResource { get; init; }
}

/// <summary>A curated Syncfusion MAUI NuGet package.</summary>
public sealed record MauiPackageDefinition
{
    public required string Alias { get; init; }
    public required string DisplayName { get; init; }
    public required string PackageId { get; init; }
    public string? Description { get; init; }
    public required string Category { get; init; }
    public required string ProductFamily { get; init; }
    public required string Classification { get; init; }
    public required string Status { get; init; }
    public required string RegistrationRequirement { get; init; }
    public required string RegistrationEvidence { get; init; }
    public required string VersionStrategy { get; init; }
    public required bool Recommended { get; init; }
    public string? DocumentationUrl { get; init; }
    public string? VerificationNotes { get; init; }
    public string? ReplacementPackageId { get; init; }
}

/// <summary>
/// The package catalog is independent of template metadata.
/// </summary>
public static class PackageCatalog
{
    private static readonly Lazy<IReadOnlyList<MauiPackageDefinition>> _catalog = new(CatalogLoader.LoadPackages);

    public static IReadOnlyList<MauiPackageDefinition> All
        => _catalog.Value;

    public static IReadOnlyList<MauiPackageDefinition> Recommended
        => All.Where(package => package.Recommended).ToList();

    public static bool TryResolve(string? value, out MauiPackageDefinition package)
    {
        package = null!;
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var key = value.Trim();
        var exact = All.Where(candidate =>
            string.Equals(candidate.Alias, key, StringComparison.OrdinalIgnoreCase)
            || string.Equals(candidate.PackageId, key, StringComparison.OrdinalIgnoreCase)).ToList();
        if (exact.Count == 1)
        {
            package = exact[0];
            return true;
        }

        if (exact.Count > 1)
        {
            return false;
        }

        var normalized = NormalizeDisplayName(key);
        var displayMatches = All.Where(candidate =>
            string.Equals(NormalizeDisplayName(candidate.DisplayName), normalized, StringComparison.OrdinalIgnoreCase)
            || (candidate.Alias == "expander" && normalized == NormalizeDisplayName("Syncfusion Accordion for .NET MAUI"))).ToList();
        if (displayMatches.Count != 1)
        {
            return false;
        }

        package = displayMatches[0];
        return true;
    }

    private static string NormalizeDisplayName(string value)
        => new(value.Where(char.IsLetterOrDigit).Select(char.ToLowerInvariant).ToArray());
}

/// <summary>The control-specific template catalog, independent of package operations.</summary>
public static class TemplateCatalog
{
    private static readonly Lazy<IReadOnlyList<ControlCatalogEntry>> _catalog = new(CatalogLoader.LoadTemplates);

    /// <summary>All template records, in canonical template-ID order.</summary>
    public static IReadOnlyList<ControlCatalogEntry> All
        => _catalog.Value.OrderBy(entry => entry.Id, StringComparer.OrdinalIgnoreCase).ToList();

    /// <summary>Verified, available templates that can be operated on.</summary>
    public static IReadOnlyList<ControlCatalogEntry> Operable
        => All.Where(entry => entry.Available && entry.Verified && entry.Operable).ToList();

    public static IReadOnlyList<ControlCatalogEntry> Additional
        => All.Where(entry => !entry.Operable).ToList();

    public static bool Contains(string templateId)
        => TryResolve(templateId, out _);

    public static bool TryResolve(string? templateId, out ControlCatalogEntry entry)
        => TryResolve(templateId, operableOnly: false, out entry);

    public static bool TryResolveOperableTemplate(string? templateId, out ControlCatalogEntry entry)
        => TryResolve(templateId, operableOnly: true, out entry);

    private static bool TryResolve(string? value, bool operableOnly, out ControlCatalogEntry entry)
    {
        entry = null!;
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var key = value.Trim();
        var matches = All.Where(candidate =>
                (!operableOnly || (candidate.Available && candidate.Verified && candidate.Operable))
                && (string.Equals(candidate.Id, key, StringComparison.OrdinalIgnoreCase)
                    || candidate.LegacyAliases.Any(alias => string.Equals(alias, key, StringComparison.OrdinalIgnoreCase)))
            )
            .ToList();
        if (matches.Count != 1)
        {
            return false;
        }

        entry = matches[0];
        return true;
    }
}

/// <summary>Compatibility facade for clients that used the former template catalog name.</summary>
public static class ControlCatalog
{
    public static IReadOnlyList<ControlCatalogEntry> All => TemplateCatalog.All;
    public static IReadOnlyList<ControlCatalogEntry> Operable => TemplateCatalog.Operable;
    public static IReadOnlyList<ControlCatalogEntry> Primary => TemplateCatalog.Operable;
    public static IReadOnlyList<ControlCatalogEntry> Additional => TemplateCatalog.Additional;
    public static bool Contains(string templateId) => TemplateCatalog.Contains(templateId);
    public static bool TryResolve(string? templateId, out ControlCatalogEntry entry)
        => TemplateCatalog.TryResolve(templateId, out entry);
    public static bool TryResolveOperableTemplate(string? templateId, out ControlCatalogEntry entry)
        => TemplateCatalog.TryResolveOperableTemplate(templateId, out entry);
}

/// <summary>Normalizes and validates concrete template IDs before operations begin.</summary>
public static class TemplateSelection
{
    public static bool TryNormalize(
        IEnumerable<string>? values,
        bool allowEmpty,
        string syntax,
        out IReadOnlyList<string> templateIds,
        out string? error)
    {
        templateIds = [];
        error = null;
        var supplied = values?.Select(value => value.Trim()).ToList() ?? [];
        if (supplied.Count == 0)
        {
            if (allowEmpty)
            {
                return true;
            }

            error = "At least one control ID is required.";
            return false;
        }

        if (supplied.Any(value => value.Equals("empty", StringComparison.OrdinalIgnoreCase)))
        {
            if (!allowEmpty)
            {
                error = "Empty is available only when creating a new project and cannot be combined with controls.";
                return false;
            }

            if (supplied.Count != 1)
            {
                error = "Empty is available only when creating a new project and cannot be combined with controls.";
                return false;
            }

            return true;
        }

        var normalized = new List<string>(supplied.Count);
        foreach (var value in supplied)
        {
            if (value.Contains(',', StringComparison.Ordinal))
            {
                error = $"'{value}' is invalid because comma-separated control IDs are not supported. Use space-separated values.";
                return false;
            }

            if (!TemplateCatalog.TryResolveOperableTemplate(value, out var entry))
            {
                if (LegacyUnsupportedTemplateCatalog.Contains(value))
                {
                    error = NotAvailableMessage(value);
                    return false;
                }

                var cause = PackageCatalog.TryResolve(value, out _)
                    ? "it is a package alias or package ID, not a control ID"
                    : TemplateCatalog.TryResolve(value, out _)
                        ? "the control is not available because its resources or verification are incomplete"
                        : "it is unknown or unavailable";
                error = $"Control '{value}' is invalid because {cause}. Run 'sf help maui' for supported controls.";
                return false;
            }

            if (normalized.Contains(entry.Id, StringComparer.OrdinalIgnoreCase))
            {
                error = $"Control '{value}' duplicates canonical control '{entry.Id}'. Remove the duplicate.";
                return false;
            }

            normalized.Add(entry.Id);
        }

        templateIds = normalized;
        return true;
    }

    /// <summary>Normalizes supported IDs and recognized legacy IDs for removal only.</summary>
    public static bool TryNormalizeForRemoval(
        IEnumerable<string>? values,
        string syntax,
        out IReadOnlyList<string> templateIds,
        out string? error)
    {
        templateIds = [];
        error = null;
        var supplied = values?.Select(value => value.Trim()).ToList() ?? [];
        if (supplied.Count == 0)
        {
            error = "At least one installed control ID is required.";
            return false;
        }

        var normalized = new List<string>(supplied.Count);
        foreach (var value in supplied)
        {
            string canonicalId;
            if (TemplateCatalog.TryResolveOperableTemplate(value, out var template))
            {
                canonicalId = template.Id;
            }
            else if (LegacyUnsupportedTemplateCatalog.Contains(value))
            {
                canonicalId = value.ToLowerInvariant();
            }
            else
            {
                error = $"Control '{value}' is not available for removal.";
                return false;
            }

            if (normalized.Contains(canonicalId, StringComparer.OrdinalIgnoreCase))
            {
                error = $"Control '{value}' duplicates canonical control '{canonicalId}'. Remove the duplicate.";
                return false;
            }

            normalized.Add(canonicalId);
        }

        templateIds = normalized;
        return true;
    }

    /// <summary>Formats the rejection shown when an unavailable control ID is requested.</summary>
    public static string NotAvailableMessage(string templateId)
        => $"Control '{templateId}' is not available. Run 'sf help maui' for supported controls.";
}
