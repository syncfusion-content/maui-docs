namespace Syncfusion.DotNet.CLI.Core;

/// <summary>
/// A parsed NuGet package-add request.
/// </summary>
public sealed record AddPackageRequest(
    Framework Framework,
    string PackageAliasOrId,
    string Path,
    string? Version,
    bool Restore,
    bool DryRun,
    bool Force,
    string? Source = null,
    string? ConfigFile = null,
    bool Build = true,
    string? BuildFramework = null);

/// <summary>
/// A parsed template-add request.
/// </summary>
public sealed record AddTemplateRequest(
    Framework Framework,
    string TemplateId,
    string Path,
    string? Version,
    bool Restore,
    bool DryRun,
    bool Force,
    string? Source = null,
    string? ConfigFile = null,
    IReadOnlyList<string>? TemplateIds = null,
    bool Build = true,
    string? BuildFramework = null)
{
    public IReadOnlyList<string> SelectedTemplateIds
        => TemplateIds ?? [TemplateId];
}

/// <summary>A parsed NuGet package-remove request.</summary>
public sealed record RemovePackageRequest(
    Framework Framework,
    string PackageAliasOrId,
    string Path,
    bool DryRun,
    bool Force,
    bool NoRestore = false,
    string? Source = null,
    string? ConfigFile = null,
    bool Build = false,
    string? BuildFramework = null);

/// <summary>
/// A parsed template-remove request.
/// </summary>
public sealed record RemoveTemplateRequest(
    Framework Framework,
    string TemplateId,
    string Path,
    bool DryRun,
    bool Force,
    bool NoRestore = false,
    string? Source = null,
    string? ConfigFile = null,
    IReadOnlyList<string>? TemplateIds = null,
    bool Build = false,
    string? BuildFramework = null)
{
    public IReadOnlyList<string> SelectedTemplateIds
        => TemplateIds ?? [TemplateId];
}

/// <summary>A parsed NuGet package-update request.</summary>
public sealed record UpdatePackageRequest(
    Framework Framework,
    string PackageAliasOrId,
    string Path,
    string? Version,
    bool Restore,
    bool DryRun,
    bool Force,
    string? Source = null,
    string? ConfigFile = null);

/// <summary>
/// A parsed <c>sf list</c> request.
/// </summary>
public sealed record ListRequest(
    ListCategory Category,
    Framework Framework);

/// <summary>
/// A parsed <c>sf search</c> request.
/// </summary>
public sealed record SearchRequest(
    string Text,
    Framework Framework);

/// <summary>
/// A parsed <c>sf info</c> request.
/// </summary>
public sealed record InfoRequest();
