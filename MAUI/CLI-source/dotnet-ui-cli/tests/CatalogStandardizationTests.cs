using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>Checks package and template catalog metadata and validation rules.</summary>
public sealed class CatalogStandardizationTests
{
    [Fact]
    public void PackageCatalog_ContainsCompleteOfficialPrefixCatalogIndependentOfTemplates()
    {
        var packages = PackageCatalog.All;

        Assert.Equal(51, packages.Count);
        Assert.Equal(packages.Count, packages.Select(package => package.PackageId).Distinct(StringComparer.OrdinalIgnoreCase).Count());
        Assert.Equal(packages.Count, packages.Select(package => package.Alias).Distinct(StringComparer.OrdinalIgnoreCase).Count());
        Assert.All(packages, package =>
        {
            Assert.StartsWith("Syncfusion.Maui.", package.PackageId, StringComparison.Ordinal);
            Assert.False(string.IsNullOrWhiteSpace(package.Alias));
            Assert.False(string.IsNullOrWhiteSpace(package.DisplayName));
            Assert.False(string.IsNullOrWhiteSpace(package.Category));
            Assert.False(string.IsNullOrWhiteSpace(package.ProductFamily));
            Assert.False(string.IsNullOrWhiteSpace(package.Classification));
            Assert.False(string.IsNullOrWhiteSpace(package.Status));
            Assert.False(string.IsNullOrWhiteSpace(package.RegistrationRequirement));
            Assert.False(string.IsNullOrWhiteSpace(package.RegistrationEvidence));
            Assert.False(string.IsNullOrWhiteSpace(package.VersionStrategy));
        });

        Assert.Empty(PackageCatalogValidator.Validate(packages));
        Assert.Contains(PackageCatalog.All, package => package.Alias == "smart-pdf-viewer");
        Assert.Contains(TemplateCatalog.Operable, template => template.PackageId == "Syncfusion.Maui.DataGrid");
        Assert.DoesNotContain(PackageCatalog.All, package => package.PackageId == "Syncfusion.Maui.DataGrid" && package.Alias == "cartesian-chart");
        Assert.DoesNotContain(packages, package =>
            package.ProductFamily == "unresolved"
            || package.Classification == "unresolved"
            || package.Status is "preview" or "prerelease" or "deprecated" or "unsupported" or "unresolved"
            || package.VersionStrategy == "unresolved");
        Assert.Equal(9, packages.Count(package => package.RegistrationRequirement == "unresolved"));
        Assert.All(packages.Where(package => package.RegistrationRequirement == "unresolved"), package =>
            Assert.Contains("No package-specific registration evidence", package.RegistrationEvidence));
        Assert.All(packages.Where(package => package.RegistrationRequirement != "unresolved"), package =>
            Assert.False(string.IsNullOrWhiteSpace(package.RegistrationEvidence)));
        Assert.All(packages.Where(package => package.Category == "Unresolved"), package =>
        {
            Assert.False(package.Recommended);
            Assert.False(string.IsNullOrWhiteSpace(package.VerificationNotes));
        });
        Assert.Contains(packages, package => package.Status == "stable" && !package.Recommended);
        Assert.All(PackageCatalog.Recommended, package =>
        {
            Assert.Equal("stable", package.Status);
            Assert.NotEqual("unresolved", package.ProductFamily);
            Assert.Equal("customer-facing", package.Classification);
        });
    }

    [Fact]
    public async Task PackageCatalogValidator_DetailedDescriptionIsOptionalForPackageOperations()
    {
        var packages = PackageCatalog.All
            .Select(package => package.Alias == "smart-pdf-viewer"
                ? package with { Description = null }
                : package)
            .ToList();

        Assert.Empty(PackageCatalogValidator.Validate(packages));
        var package = Assert.Single(packages, candidate => candidate.Alias == "smart-pdf-viewer");
        var root = Path.Combine(Path.GetTempPath(), "sf-package-description-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var projectPath = Path.Combine(root, "App.csproj");
            File.WriteAllText(projectPath,
                "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup></Project>");
            var project = MauiProjectResolver.Resolve(projectPath);
            var registrationSource = Path.Combine(root, "MauiProgram.cs");
            const string registrationContents = "namespace TestApp; public static class MauiProgram { }";
            File.WriteAllText(registrationSource, registrationContents);
            var result = await new PackageOperationService(new SuccessfulNuGetRunner()).ExecuteAsync(
                project,
                package,
                NuGetOperationKind.Add,
                noRestore: true);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.Equal("smart-pdf-viewer", result.Alias);
            Assert.Equal("Syncfusion.Maui.SmartPdfViewer", result.PackageId);
            Assert.Null(result.ResolvedVersion);
            Assert.Equal(registrationContents, File.ReadAllText(registrationSource));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Theory]
    [InlineData("INPUTS", "inputs")]
    [InlineData("Syncfusion.Maui.INPUTS", "inputs")]
    [InlineData("Syncfusion DataGrid for .NET MAUI", "datagrid")]
    [InlineData("Charts", "charts")]
    [InlineData("Syncfusion Accordion for .NET MAUI", "expander")]
    [InlineData("Syncfusion Expander and Accordion for .NET MAUI", "expander")]
    public void PackageResolution_AcceptsOnlyCanonicalAliasIdOrUnambiguousPackageName(
        string value,
        string expectedAlias)
    {
        Assert.True(PackageCatalog.TryResolve(value, out var package));
        Assert.Equal(expectedAlias, package.Alias);
    }

    [Theory]
    [InlineData("combobox")]
    [InlineData("sfdatagrid")]
    [InlineData("badgeview")]
    [InlineData("toolkit-tab-view")]
    public void PackageResolution_DoesNotAcceptTemplateOrControlNames(string value)
        => Assert.False(PackageCatalog.TryResolve(value, out _));

    [Fact]
    public void PackageResolution_IsCaseInsensitiveAndIndependentOfCatalogOrder()
    {
        var forward = PackageCatalog.All;
        var reversed = forward.Reverse().ToList();
        foreach (var value in new[] { "inputs", "Syncfusion.Maui.DataGrid", "charts" })
        {
            var first = ResolveFrom(value, forward);
            var second = ResolveFrom(value, reversed);
            Assert.Equal(first, second);
        }
    }

    [Fact]
    public void PackageCatalogValidator_RejectsDuplicateIdsAliasesDisplayNamesAndInvalidMetadataDeterministically()
    {
        var packages = PackageCatalog.All.Select(package => package.Alias switch
        {
            "datagrid" => package with
            {
                Alias = "inputs",
                Category = "Unknown",
                RegistrationRequirement = "",
                PackageId = "Syncfusion.Maui.Inputs",
            },
            "inputs" => package with
            {
                Alias = "combobox",
                DisplayName = "Syncfusion DataGrid for .NET MAUI",
            },
            "a2-ui" => package with { ProductFamily = "unresolved" },
            "backdrop" => package with
            {
                Recommended = true,
                Classification = "unresolved",
                RegistrationRequirement = "unresolved",
                RegistrationEvidence = "Missing evidence reason.",
            },
            "barcode" => package with { RegistrationRequirement = "unverified" },
            "calendar" => package with { VersionStrategy = "unresolved" },
            "sliders" => package with { VersionStrategy = "floating-*", Recommended = false, PackageId = "Syncfusion.Not.Maui" },
            _ => package,
        }).ToList();

        var errors = PackageCatalogValidator.Validate(packages);
        var reversedErrors = PackageCatalogValidator.Validate(packages.AsEnumerable().Reverse().ToList());

        Assert.Equal(errors, reversedErrors);
        Assert.Contains(errors, error => error.Contains("canonical package alias", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("control-derived alias", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("canonical package ID", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("Normalized package display name", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("must begin with 'Syncfusion.Maui.'", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("invalid category", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("registration classification", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("requires a concise unresolved registration reason", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("requires a resolved product family", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("requires a resolved package classification", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("invalid registration classification", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("invalid version strategy", StringComparison.Ordinal));
        Assert.Contains(errors, error => error.Contains("cannot be recommended", StringComparison.Ordinal));
    }

    [Fact]
    public void ToolkitIsExcludedAndDependencyMetadataRemainsDistinct()
    {
        Assert.DoesNotContain(PackageCatalog.All, package => package.PackageId == "Syncfusion.Maui.Toolkit" || package.Alias == "toolkit");
        foreach (var key in new[] { "toolkit", "Syncfusion.Maui.Toolkit", "Syncfusion Toolkit for .NET MAUI" })
            Assert.False(PackageCatalog.TryResolve(key, out _));
        Assert.DoesNotContain(new MauiControlSelectionProvider(MauiProjectType.App).Packages, package => package.Id == "toolkit");

        var core = Assert.Single(PackageCatalog.All, package => package.PackageId == "Syncfusion.Maui.Core");
        Assert.Equal("dependency-only", core.Classification);
        Assert.False(core.Recommended);
        Assert.DoesNotContain(PackageCatalog.Recommended, package => package.Classification == "dependency-only");
    }

    [Fact]
    public void PackageListAndSearch_ReturnPackageRecordsOnlyInHumanAndJsonData()
    {
        var listed = DiscoveryService.ListPackages();
        Assert.Equal(PackageCatalog.All.Count, listed.Count);
        Assert.Contains(listed, package => package.Alias == "inputs" && package.PackageId == "Syncfusion.Maui.Inputs");
        Assert.DoesNotContain(listed, package => package.Alias == "combobox");
        Assert.DoesNotContain(listed, package => package.PackageId == "cartesian-chart");

        var serializedPackages = JsonSerializer.Deserialize<List<DiscoveryService.PackageInfo>>(
            DiscoveryService.ToJson(listed))!;
        Assert.Equal(listed.Select(package => package.Alias), serializedPackages.Select(package => package.Alias));
        Assert.DoesNotContain("includedControl", DiscoveryService.ToJson(listed), StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("templateId", DiscoveryService.ToJson(listed), StringComparison.OrdinalIgnoreCase);

        var searches = DiscoveryService.SearchPackages("Syncfusion.Maui.Inputs");
        Assert.Contains(searches, package => package.Alias == "inputs" && package.PackageId == "Syncfusion.Maui.Inputs");
        Assert.Empty(DiscoveryService.SearchPackages("ComboBox"));
        Assert.All(DiscoveryService.SearchPackages("Syncfusion"), package => Assert.StartsWith("Syncfusion.Maui.", package.PackageId));
        Assert.Equal(
            searches.Select(package => package.Alias),
            JsonSerializer.Deserialize<List<DiscoveryService.PackageInfo>>(DiscoveryService.ToJson(searches))!
                .Select(package => package.Alias));
    }

    [Fact]
    public void InstalledPackageDiscovery_ReturnsOnlyDirectPackageReferencesIncludingPackagesWithoutTemplates()
    {
        var directory = Path.Combine(Path.GetTempPath(), "sf-installed-packages-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);
        try
        {
            var project = Path.Combine(directory, "App.csproj");
            File.WriteAllText(project, """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup>
                  <ItemGroup>
                    <PackageReference Include="Syncfusion.Maui.SmartPdfViewer" Version="1.2.3" />
                    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
                  </ItemGroup>
                </Project>
                """);

            var installed = DiscoveryService.ListInstalledPackages(project);

            var package = Assert.Single(installed);
            Assert.Equal("Syncfusion.Maui.SmartPdfViewer", package.PackageId);
            Assert.Equal("smart-pdf-viewer", package.Alias);
            Assert.Equal("1.2.3", package.Version);
            Assert.Equal("unresolved", Assert.Single(PackageCatalog.All, item => item.PackageId == package.PackageId).RegistrationRequirement);
            Assert.DoesNotContain("control", JsonSerializer.Serialize(installed), StringComparison.OrdinalIgnoreCase);
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [Fact]
    public void TemplateCatalog_ContainsOnlyOperableApprovedConcreteTemplates()
    {
        var approvedFamilies = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "datagrid", "listview", "scheduler", "charts", "assistview",
            "rich-text-editor", "diagram", "kanban", "pdf-viewer",
        };
        var templates = TemplateCatalog.Operable;

        Assert.Equal(10, templates.Count);
        Assert.Equal(
            approvedFamilies.Order(StringComparer.OrdinalIgnoreCase),
            templates.Select(template => template.Family).Distinct(StringComparer.OrdinalIgnoreCase).Order(StringComparer.OrdinalIgnoreCase));
        Assert.All(templates, template =>
        {
            Assert.Contains(template.Family, approvedFamilies);
            Assert.True(template.Available);
            Assert.True(template.Verified);
            Assert.True(template.Operable);
            Assert.Contains(PackageCatalog.All, package => package.PackageId == template.PackageId);
            Assert.NotEmpty(template.EmbeddedResources);
        });

        Assert.Contains(templates, template => template.Id == "cartesian-chart" && template.Family == "charts");
        Assert.DoesNotContain(templates, template => template.Id is "charts" or "radar-chart");
        Assert.Contains(templates, template => template.Id == "circular-chart" && template.Family == "charts");
        Assert.Equal(
            new[] { "cartesian-chart", "circular-chart" }.Order(StringComparer.Ordinal),
            templates.Where(template => template.Family == "charts").Select(template => template.Id).Order(StringComparer.Ordinal));
        Assert.True(TemplateCatalog.TryResolveOperableTemplate("charts", out var legacyCharts));
        Assert.Equal("cartesian-chart", legacyCharts.Id);
        Assert.Equal(templates.Count, DiscoveryService.ListTemplates().Count);
    }

    [Fact]
    public void TemplateCatalogValidator_ValidatesResourcesAndAliasesWithoutCatalogOrderDependence()
    {
        var assembly = typeof(ControlInstaller).Assembly;
        var resources = assembly.GetManifestResourceNames();
        var errors = TemplateCatalogValidator.Validate(TemplateCatalog.All, PackageCatalog.All, resources);
        var reversedErrors = TemplateCatalogValidator.Validate(
            TemplateCatalog.All.Reverse().ToList(),
            PackageCatalog.All.Reverse().ToList(),
            resources.Reverse().ToArray());

        Assert.Empty(errors);
        Assert.Equal(errors, reversedErrors);

        var invalidTemplates = TemplateCatalog.All
            .Select(template => template.Id == "cartesian-chart"
                ? template with
                {
                    LegacyAliases = template.LegacyAliases.Append("missing-resource").ToList(),
                    EmbeddedResources = ["Views/Unavailable.xaml"],
                }
                : template)
            .ToList();
        var invalidErrors = TemplateCatalogValidator.Validate(invalidTemplates, PackageCatalog.All, resources);
        Assert.Contains(invalidErrors, error => error.Contains("missing embedded resource", StringComparison.Ordinal));

        var unresolvedRegistrationTemplates = TemplateCatalog.All
            .Select(template => template.Id == "datagrid"
                ? template with
                {
                    RegistrationRequirement = "unresolved",
                    RegistrationVerified = false,
                    RegistrationEvidence = "No verified registration evidence.",
                }
                : template)
            .ToList();
        var registrationErrors = TemplateCatalogValidator.Validate(
            unresolvedRegistrationTemplates,
            PackageCatalog.All,
            resources);
        Assert.Contains(registrationErrors, error => error.Contains("cannot be operable without verified registration evidence", StringComparison.Ordinal));

        var missingRegistrationEvidence = TemplateCatalog.All
            .Select(template => template.Id == "datagrid"
                ? template with { RegistrationEvidence = string.Empty }
                : template)
            .ToList();
        var missingEvidenceErrors = TemplateCatalogValidator.Validate(
            missingRegistrationEvidence,
            PackageCatalog.All,
            resources);
        Assert.Contains(missingEvidenceErrors, error => error.Contains("cannot have verified registration without evidence metadata", StringComparison.Ordinal));
    }

    [Fact]
    public async Task PackageOperationsWithUnresolvedRegistrationLeaveMauiProgramUnchanged()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-package-registration-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var projectPath = Path.Combine(root, "App.csproj");
            File.WriteAllText(projectPath,
                "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup></Project>");
            var registrationPath = Path.Combine(root, "MauiProgram.cs");
            const string registration = "namespace TestApp; public static class MauiProgram { static void Configure() { } }";
            File.WriteAllText(registrationPath, registration);
            var project = MauiProjectResolver.Resolve(projectPath);
            var package = Assert.Single(PackageCatalog.All, candidate => candidate.Alias == "smart-pdf-viewer");
            Assert.Equal("unresolved", package.RegistrationRequirement);
            var service = new PackageOperationService(new SuccessfulNuGetRunner());

            var add = await service.ExecuteAsync(project, package, NuGetOperationKind.Add, noRestore: true);
            var remove = await service.ExecuteAsync(project, package.Alias, package.PackageId, NuGetOperationKind.Remove, noRestore: true);
            var update = await service.ExecuteAsync(project, package.Alias, package.PackageId, NuGetOperationKind.Add, noRestore: true, update: true);

            Assert.All(new[] { add, remove, update }, result => Assert.Equal(ExitCodes.Success, result.ExitCode));
            Assert.Equal(registration, File.ReadAllText(registrationPath));
            Assert.Contains(DiscoveryService.ListPackages(), listed => listed.Alias == package.Alias);
            Assert.Contains(DiscoveryService.SearchPackages(package.Alias), listed => listed.Alias == package.Alias);
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public async Task PackageResultReportsResolvedVersionOnlyWhenDirectReferenceHasExactVersion()
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-resolved-package-version-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var projectPath = Path.Combine(root, "App.csproj");
            File.WriteAllText(projectPath,
                "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup></Project>");
            var project = MauiProjectResolver.Resolve(projectPath);
            var package = Assert.Single(PackageCatalog.All, candidate => candidate.Alias == "smart-pdf-viewer");
            var result = await new PackageOperationService(new VersionWritingNuGetRunner("1.2.3")).ExecuteAsync(
                project,
                package,
                NuGetOperationKind.Add,
                noRestore: true);

            Assert.Equal("1.2.3", result.ResolvedVersion);
            Assert.Equal("Version selection: Latest stable", PackageOperationService.VersionSelectionLabel(package.VersionStrategy));
            Assert.Equal("Version strategy: Latest stable release", PackageOperationService.VersionStrategyLabel(package.VersionStrategy));
            Assert.Equal("Requested version: 4.5.6", PackageOperationService.RequestedVersionLabel("4.5.6"));
            Assert.Null(PackageOperationService.ResolvedVersionLabel(null));
            Assert.Equal("Resolved version: 1.2.3", PackageOperationService.ResolvedVersionLabel(result.ResolvedVersion));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    private static string? ResolveFrom(string value, IReadOnlyList<MauiPackageDefinition> packages)
    {
        var exact = packages.Where(package =>
            package.Alias.Equals(value, StringComparison.OrdinalIgnoreCase)
            || package.PackageId.Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
        return exact.Count == 1 ? exact[0].Alias : null;
    }

    private sealed class SuccessfulNuGetRunner : NuGetRunner
    {
        public override Task<NuGetCommandResult> RunAsync(
            NuGetOperation operation,
            CancellationToken cancellationToken = default)
            => Task.FromResult(new NuGetCommandResult
            {
                ExitCode = 0,
                StandardOutput = string.Empty,
                StandardError = string.Empty,
            });
    }

    private sealed class VersionWritingNuGetRunner(string version) : NuGetRunner
    {
        public override Task<NuGetCommandResult> RunAsync(
            NuGetOperation operation,
            CancellationToken cancellationToken = default)
        {
            File.WriteAllText(
                operation.ProjectPath,
                $"<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><UseMaui>true</UseMaui></PropertyGroup><ItemGroup><PackageReference Include=\"{operation.PackageId}\" Version=\"{version}\" /></ItemGroup></Project>");
            return Task.FromResult(new NuGetCommandResult
            {
                ExitCode = 0,
                StandardOutput = string.Empty,
                StandardError = string.Empty,
            });
        }
    }
}
