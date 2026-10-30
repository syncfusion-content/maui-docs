using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Syncfusion.DotNet.Cli.Maui.Manifest;

/// <summary>
/// The serialized form of <c>Syncfusion/syncfusion.json</c> — the manifest the
/// CLI writes next to the project it modifies, so it can remember which
/// controls, packages, and files it owns and support rollback and update.
/// </summary>
public sealed class SyncfusionManifest
{
    /// <summary>
    /// The highest manifest schema version this CLI release can read and write
    /// safely. A manifest whose <see cref="SchemaVersion"/> is higher than
    /// this value is refused (rather than silently downgraded) so a newer
    /// CLI's manifest is never overwritten by an older one.
    /// </summary>
    public const int MaxSupportedSchemaVersion = 2;

    [JsonPropertyName("schemaVersion")]
    public int SchemaVersion { get; set; } = 1;

    [JsonPropertyName("cliVersion")]
    public string CliVersion { get; set; } = string.Empty;

    [JsonPropertyName("framework")]
    public string Framework { get; set; } = string.Empty;

    [JsonPropertyName("projectType")]
    public string ProjectType { get; set; } = string.Empty;

    /// <summary>Project filename owning this scaffolding when several projects share a directory.</summary>
    [JsonPropertyName("projectFile")]
    public string ProjectFile { get; set; } = string.Empty;

    [JsonPropertyName("targetFramework")]
    public string TargetFramework { get; set; } = string.Empty;

    [JsonPropertyName("installedControls")]
    public List<string> InstalledControls { get; set; } = [];

    [JsonPropertyName("packageIds")]
    public List<string> PackageIds { get; set; } = [];

    [JsonPropertyName("packageVersions")]
    public Dictionary<string, string> PackageVersions { get; set; } = [];

    /// <summary>Exact user-requested package versions, when supplied.</summary>
    [JsonPropertyName("packageRequestedVersions")]
    public Dictionary<string, string> PackageRequestedVersions { get; set; } = [];

    /// <summary>Canonical per-template ownership and compatibility records.</summary>
    [JsonPropertyName("installedTemplates")]
    public List<InstalledTemplateRecord> InstalledTemplates { get; set; } = [];

    /// <summary>Whether the CLI inserted the shared registration into MauiProgram.cs.</summary>
    [JsonPropertyName("registrationOwned")]
    public bool RegistrationOwned { get; set; }

    [JsonPropertyName("generatedFiles")]
    public List<string> GeneratedFiles { get; set; } = [];

    [JsonPropertyName("modifiedFiles")]
    public List<string> ModifiedFiles { get; set; } = [];

    /// <summary>
    /// SHA-256 hashes of CLI-owned generated files at the time they were
    /// written. Used to detect external edits before rollback/overwrite.
    /// </summary>
    [JsonPropertyName("originalHashes")]
    public Dictionary<string, string> OriginalHashes { get; set; } = [];

    /// <summary>Hash-protected inserted blocks; edits outside these blocks remain user-owned.</summary>
    [JsonPropertyName("generatedBlocks")]
    public List<GeneratedBlockRecord> GeneratedBlocks { get; set; } = [];

    [JsonPropertyName("welcomeFiles")]
    public List<string> WelcomeFiles { get; set; } = [];

    private static readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = null,
        DefaultIgnoreCondition = JsonIgnoreCondition.Never,
    };

    /// <summary>Serializes the manifest to a UTF-8 JSON string.</summary>
    public string ToJson()
        => JsonSerializer.Serialize(this, _options);

    /// <summary>Deserializes a manifest from a UTF-8 JSON string.</summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the JSON is empty/malformed, or when the manifest's
    /// <see cref="SchemaVersion"/> is higher than
    /// <see cref="MaxSupportedSchemaVersion"/> (so an older CLI never silently
    /// overwrites a manifest written by a newer CLI).
    /// </exception>
    public static SyncfusionManifest FromJson(string json)
    {
        var manifest = JsonSerializer.Deserialize<SyncfusionManifest>(json, _options)
            ?? throw new System.InvalidOperationException("syncfusion.json is empty or malformed.");

        if (manifest.SchemaVersion > MaxSupportedSchemaVersion)
        {
            throw new System.InvalidOperationException(
                $"The Syncfusion manifest uses schema version {manifest.SchemaVersion}, which is newer than the maximum version {MaxSupportedSchemaVersion} supported by this CLI. " +
                "Upgrade the Syncfusion .NET CLI to a newer release before modifying this project.");
        }

        if (manifest.SchemaVersion < 1 || manifest.InstalledControls is null || manifest.InstalledTemplates is null
            || manifest.PackageIds is null || manifest.PackageVersions is null || manifest.PackageRequestedVersions is null
            || manifest.GeneratedFiles is null || manifest.ModifiedFiles is null || manifest.OriginalHashes is null
            || manifest.GeneratedBlocks is null || manifest.WelcomeFiles is null)
            throw new InvalidOperationException("The Syncfusion manifest has invalid or null ownership metadata. No changes can be made safely.");
        if (manifest.ProjectFile is null || manifest.ProjectFile.Length > 0
            && (Path.GetFileName(manifest.ProjectFile) != manifest.ProjectFile || !manifest.ProjectFile.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("The Syncfusion manifest contains an invalid project filename.");
        if (manifest.InstalledTemplates.Any(record => record is null)
            || manifest.GeneratedBlocks.Any(block => block is null || string.IsNullOrWhiteSpace(block.Marker)
                || string.IsNullOrWhiteSpace(block.Path) || string.IsNullOrWhiteSpace(block.Hash)))
            throw new InvalidOperationException("The Syncfusion manifest contains invalid ownership records.");
        foreach (var path in manifest.GeneratedFiles.Concat(manifest.ModifiedFiles).Concat(manifest.WelcomeFiles)
            .Concat(manifest.OriginalHashes.Keys).Concat(manifest.GeneratedBlocks.Select(block => block.Path)))
            TemplatePathResolver.ValidateRelativePath(path);
        if (manifest.InstalledControls.Distinct(StringComparer.OrdinalIgnoreCase).Count() != manifest.InstalledControls.Count
            || manifest.InstalledTemplates.Select(record => record.Id).Distinct(StringComparer.OrdinalIgnoreCase).Count() != manifest.InstalledTemplates.Count
            || manifest.GeneratedBlocks.Select(block => block.Path + "#" + block.Marker).Distinct().Count() != manifest.GeneratedBlocks.Count)
            throw new InvalidOperationException("The Syncfusion manifest contains duplicate ownership records.");
        foreach (var record in manifest.InstalledTemplates)
        {
            if (string.IsNullOrWhiteSpace(record.Id) || record.GeneratedFiles is null || record.PackageDependencies is null
                || record.CodeBlocks is null || record.Resources is null || record.NavigationEntries is null)
                throw new InvalidOperationException("The Syncfusion manifest contains invalid control ownership metadata.");
            foreach (var path in record.GeneratedFiles.Concat(record.Resources)) TemplatePathResolver.ValidateRelativePath(path);
            if (manifest.SchemaVersion >= 2 && !manifest.InstalledControls.Contains(record.Id, StringComparer.OrdinalIgnoreCase))
                throw new InvalidOperationException($"The control record '{record.Id}' is missing from the installed control registry.");
        }

        return manifest;
    }
}

/// <summary>Tracks one CLI-owned concrete control template installation.</summary>
public sealed class InstalledTemplateRecord
{
    /// <summary>The canonical concrete template ID.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>The template family used for grouping in interactive flows.</summary>
    [JsonPropertyName("family")]
    public string Family { get; set; } = string.Empty;

    /// <summary>The legacy alias entered by the user, if one was used.</summary>
    [JsonPropertyName("legacyAliasUsed")]
    public string? LegacyAliasUsed { get; set; }

    /// <summary>The primary Syncfusion package ID.</summary>
    [JsonPropertyName("packageId")]
    public string PackageId { get; set; } = string.Empty;

    /// <summary>The exact requested package version, or null for latest stable.</summary>
    [JsonPropertyName("requestedVersion")]
    public string? RequestedVersion { get; set; }

    /// <summary>The exact package version resolved by NuGet.</summary>
    [JsonPropertyName("resolvedVersion")]
    public string ResolvedVersion { get; set; } = string.Empty;

    /// <summary>Generated paths owned by the CLI for this template.</summary>
    [JsonPropertyName("generatedFiles")]
    public List<string> GeneratedFiles { get; set; } = [];

    /// <summary>Whether verified template registration was applied.</summary>
    [JsonPropertyName("registrationApplied")]
    public bool RegistrationApplied { get; set; }

    /// <summary>True when the CLI introduced the required PackageReference.</summary>
    [JsonPropertyName("packageReferenceOwned")]
    public bool PackageReferenceOwned { get; set; }

    /// <summary>All project target frameworks included in the compatibility restore.</summary>
    [JsonPropertyName("targetFrameworks")]
    public List<string> TargetFrameworks { get; set; } = [];

    /// <summary>Result of the restore compatibility evaluation.</summary>
    [JsonPropertyName("compatibilityDecision")]
    public string CompatibilityDecision { get; set; } = string.Empty;

    [JsonPropertyName("packageDependencies")]
    public List<string> PackageDependencies { get; set; } = [];

    [JsonPropertyName("codeBlocks")]
    public List<string> CodeBlocks { get; set; } = [];

    [JsonPropertyName("resources")]
    public List<string> Resources { get; set; } = [];

    [JsonPropertyName("navigationEntries")]
    public List<string> NavigationEntries { get; set; } = [];

    [JsonPropertyName("welcomeEntry")]
    public string? WelcomeEntry { get; set; }
}

public sealed class GeneratedBlockRecord
{
    [JsonPropertyName("path")]
    public string Path { get; set; } = string.Empty;
    [JsonPropertyName("marker")]
    public string Marker { get; set; } = string.Empty;
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = string.Empty;
}
