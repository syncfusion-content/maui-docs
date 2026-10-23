namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>Validates package metadata without consulting template metadata or the network.</summary>
public static class PackageCatalogValidator
{
    private static readonly HashSet<string> Categories = new(StringComparer.OrdinalIgnoreCase)
    {
        "Buttons",
        "Calendars and Scheduling",
        "Conversational UI and AI",
        "Data Visualization",
        "Editors and Inputs",
        "Grids",
        "Infrastructure",
        "Layout",
        "Lists",
        "Maps",
        "Navigation",
        "Notifications",
        "Development tools",
        "Sliders",
        "Viewers and Editors",
        "Unresolved",
    };

    private static readonly HashSet<string> ProductFamilies = new(StringComparer.OrdinalIgnoreCase)
    {
        "essential-studio",
        "shared-infrastructure",
        "development-tools",
        "unresolved",
    };

    private static readonly HashSet<string> Classifications = new(StringComparer.OrdinalIgnoreCase)
    {
        "customer-facing",
        "shared-infrastructure",
        "dependency-only",
        "development-tool",
        "deprecated-or-replaced",
        "unresolved",
    };

    private static readonly HashSet<string> Statuses = new(StringComparer.OrdinalIgnoreCase)
    {
        "stable",
        "preview",
        "prerelease",
        "deprecated",
        "unsupported",
        "unresolved",
    };

    private static readonly HashSet<string> RegistrationRequirements = new(StringComparer.OrdinalIgnoreCase)
    {
        "none",
        "syncfusion-core",
        "package-specific",
        "unresolved",
    };

    private static readonly HashSet<string> VersionStrategies = new(StringComparer.OrdinalIgnoreCase)
    {
        "latest-stable-per-package",
        "explicit-version-only",
        "unresolved",
    };

    private static readonly IReadOnlyDictionary<string, string> ControlDerivedAliases =
        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["combobox"] = "inputs",
            ["cartesian-chart"] = "charts",
            ["sfdatagrid"] = "datagrid",
        };

    public static IReadOnlyList<string> Validate(IReadOnlyList<MauiPackageDefinition> packages)
    {
        ArgumentNullException.ThrowIfNull(packages);
        var errors = new SortedSet<string>(StringComparer.Ordinal);
        AddDuplicateErrors(packages, package => package.Alias, "canonical package alias", errors);
        AddDuplicateErrors(packages, package => package.PackageId, "canonical package ID", errors);

        foreach (var group in packages
            .Where(package => !string.IsNullOrWhiteSpace(package.DisplayName))
            .GroupBy(package => NormalizeDisplayName(package.DisplayName), StringComparer.OrdinalIgnoreCase)
            .Where(group => group.Count() > 1))
        {
            errors.Add($"Normalized package display name '{group.Key}' is ambiguous: {PackageNames(group)}.");
        }

        foreach (var package in packages)
        {
            if (new[]
                {
                    package.Alias, package.DisplayName, package.PackageId,
                    package.Category, package.ProductFamily, package.Classification, package.Status,
                    package.RegistrationRequirement, package.RegistrationEvidence, package.VersionStrategy,
                }.Any(string.IsNullOrWhiteSpace))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has an empty required value.");
                if (new[]
                    {
                        package.Alias, package.DisplayName, package.PackageId,
                        package.Category, package.ProductFamily, package.Classification, package.Status,
                        package.RegistrationRequirement, package.RegistrationEvidence, package.VersionStrategy,
                    }.Any(value => value is null)) { continue; }
            }

            if (!IsCanonicalAlias(package.Alias))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has an invalid canonical alias.");
            }

            if (ControlDerivedAliases.TryGetValue(package.Alias, out var canonicalAlias)
                && !package.Alias.Equals(canonicalAlias, StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Package '{PackageIdentity(package)}' uses control-derived alias '{package.Alias}' instead of canonical package alias '{canonicalAlias}'.");
            }

            if (!IsPackageId(package.PackageId))
            {
                errors.Add($"Package ID '{package.PackageId}' must begin with 'Syncfusion.Maui.' and contain a valid suffix.");
            }

            if (!Categories.Contains(package.Category))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has invalid category '{package.Category}'.");
            }

            if (!ProductFamilies.Contains(package.ProductFamily))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has invalid product family '{package.ProductFamily}'.");
            }
            else if (package.ProductFamily.Equals("unresolved", StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Package '{PackageIdentity(package)}' requires a resolved product family.");
            }

            if (!Classifications.Contains(package.Classification))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has invalid classification '{package.Classification}'.");
            }
            else if (package.Classification.Equals("unresolved", StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Package '{PackageIdentity(package)}' requires a resolved package classification.");
            }

            if (!Statuses.Contains(package.Status))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has invalid status '{package.Status}'.");
            }

            if (!RegistrationRequirements.Contains(package.RegistrationRequirement))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has invalid registration classification.");
            }
            if (!VersionStrategies.Contains(package.VersionStrategy)
                || package.VersionStrategy.Contains('*')
                || package.VersionStrategy.Contains("33.1.0", StringComparison.Ordinal)
                || package.VersionStrategy.Equals("unresolved", StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has invalid version strategy '{package.VersionStrategy}'.");
            }

            if (MustNotBeRecommended(package) && package.Recommended)
            {
                errors.Add($"Package '{PackageIdentity(package)}' cannot be recommended with status '{package.Status}' or classification '{package.Classification}'.");
            }

            if (package.Classification.Equals("deprecated-or-replaced", StringComparison.OrdinalIgnoreCase)
                && !package.Status.Equals("deprecated", StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Package '{PackageIdentity(package)}' is classified as deprecated or replaced but does not have deprecated status.");
            }

            if (package.Status.Equals("unresolved", StringComparison.OrdinalIgnoreCase)
                && string.IsNullOrWhiteSpace(package.VerificationNotes))
            {
                errors.Add($"Unresolved package '{PackageIdentity(package)}' requires verification notes.");
            }

            if (package.RegistrationRequirement.Equals("unresolved", StringComparison.OrdinalIgnoreCase)
                && !package.RegistrationEvidence.Contains("No package-specific registration evidence", StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Package '{PackageIdentity(package)}' requires a concise unresolved registration reason.");
            }

            if (package.ReplacementPackageId is not null
                && (!IsPackageId(package.ReplacementPackageId)
                    || !packages.Any(candidate => candidate.PackageId.Equals(
                        package.ReplacementPackageId,
                        StringComparison.OrdinalIgnoreCase))))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has unknown replacement package '{package.ReplacementPackageId}'.");
            }

            if (package.DocumentationUrl is not null
                && (!Uri.TryCreate(package.DocumentationUrl, UriKind.Absolute, out var uri)
                    || uri.Scheme is not ("http" or "https")))
            {
                errors.Add($"Package '{PackageIdentity(package)}' has invalid documentation URL.");
            }
        }

        return errors.ToList();
    }

    private static bool MustNotBeRecommended(MauiPackageDefinition package)
        => !package.Status.Equals("stable", StringComparison.OrdinalIgnoreCase)
            || package.ProductFamily.Equals("unresolved", StringComparison.OrdinalIgnoreCase)
            || package.Classification.Equals("dependency-only", StringComparison.OrdinalIgnoreCase)
            || package.Classification.Equals("shared-infrastructure", StringComparison.OrdinalIgnoreCase)
            || package.Classification.Equals("deprecated-or-replaced", StringComparison.OrdinalIgnoreCase)
            || package.Classification.Equals("unresolved", StringComparison.OrdinalIgnoreCase)
            || package.Classification.Equals("development-tool", StringComparison.OrdinalIgnoreCase);

    private static bool IsPackageId(string value)
        => value.StartsWith("Syncfusion.Maui.", StringComparison.Ordinal)
            && value.Length > "Syncfusion.Maui.".Length
            && value["Syncfusion.Maui.".Length..].All(character =>
                char.IsAsciiLetterOrDigit(character) || character is '.' or '-');

    private static bool IsCanonicalAlias(string value)
        => value.Length > 0
            && value.All(character => char.IsAsciiLetterOrDigit(character) || character == '-')
            && char.IsAsciiLetterOrDigit(value[0])
            && char.IsAsciiLetterOrDigit(value[^1]);

    private static string NormalizeDisplayName(string value)
        => new(value.Where(char.IsLetterOrDigit).Select(char.ToLowerInvariant).ToArray());

    private static string PackageIdentity(MauiPackageDefinition package)
        => string.IsNullOrWhiteSpace(package.Alias) ? package.PackageId : package.Alias;

    private static string PackageNames(IEnumerable<MauiPackageDefinition> packages)
        => string.Join(", ", packages.Select(PackageIdentity).Order(StringComparer.OrdinalIgnoreCase));

    private static void AddDuplicateErrors<T>(
        IEnumerable<T> entries,
        Func<T, string> getValue,
        string kind,
        ISet<string> errors)
    {
        foreach (var group in entries
            .GroupBy(getValue, StringComparer.OrdinalIgnoreCase)
            .Where(group => string.IsNullOrWhiteSpace(group.Key) || group.Count() > 1))
        {
            errors.Add($"Duplicate or empty {kind} '{group.Key}'.");
        }
    }
}

/// <summary>Validates concrete, embedded control templates independently of package recommendations.</summary>
public static class TemplateCatalogValidator
{
    private static readonly IReadOnlyDictionary<string, string> ApprovedTemplateFamilies =
        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["datagrid"] = "datagrid",
            ["listview"] = "listview",
            ["scheduler"] = "scheduler",
            ["cartesian-chart"] = "charts",
            ["circular-chart"] = "charts",
            ["assistview"] = "assistview",
            ["rich-text-editor"] = "rich-text-editor",
            ["diagram"] = "diagram",
            ["kanban"] = "kanban",
            ["pdf-viewer"] = "pdf-viewer",
        };

    private static readonly HashSet<string> ApprovedFamilies = new(ApprovedTemplateFamilies.Values, StringComparer.OrdinalIgnoreCase);

    private static readonly HashSet<string> TemplateRegistrationRequirements = new(StringComparer.OrdinalIgnoreCase)
    {
        "none",
        "syncfusion-core",
        "package-specific",
        "unresolved",
    };

    public static IReadOnlyList<string> Validate(
        IReadOnlyList<ControlCatalogEntry> templates,
        IReadOnlyList<MauiPackageDefinition> packages,
        IReadOnlyCollection<string> embeddedResourceNames)
    {
        ArgumentNullException.ThrowIfNull(templates);
        ArgumentNullException.ThrowIfNull(packages);
        ArgumentNullException.ThrowIfNull(embeddedResourceNames);

        var errors = new SortedSet<string>(StringComparer.Ordinal);
        AddDuplicateErrors(templates, template => template.Id, "template ID", errors);
        var aliases = templates.SelectMany(template => template.LegacyAliases.Select(alias => (Alias: alias, Template: template)));
        foreach (var group in aliases.GroupBy(entry => entry.Alias, StringComparer.OrdinalIgnoreCase)
            .Where(group => string.IsNullOrWhiteSpace(group.Key) || group.Select(entry => entry.Template.Id).Distinct(StringComparer.OrdinalIgnoreCase).Count() > 1))
        {
            errors.Add($"Duplicate or empty template legacy alias '{group.Key}'.");
        }

        var canonicalIds = templates.Select(template => template.Id).ToHashSet(StringComparer.OrdinalIgnoreCase);
        if (!canonicalIds.SetEquals(ApprovedTemplateFamilies.Keys))
        {
            var unexpectedIds = canonicalIds.Except(ApprovedTemplateFamilies.Keys, StringComparer.OrdinalIgnoreCase);
            var missingIds = ApprovedTemplateFamilies.Keys.Except(canonicalIds, StringComparer.OrdinalIgnoreCase);
            errors.Add(
                $"Template catalog must contain exactly the approved concrete template IDs. Unexpected: [{string.Join(", ", unexpectedIds.Order(StringComparer.OrdinalIgnoreCase))}]; missing: [{string.Join(", ", missingIds.Order(StringComparer.OrdinalIgnoreCase))}].");
        }

        foreach (var alias in aliases)
        {
            if (canonicalIds.Contains(alias.Alias)
                && !alias.Alias.Equals(alias.Template.Id, StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Template legacy alias '{alias.Alias}' conflicts with a canonical template ID.");
            }
        }

        var packageIds = packages.Select(package => package.PackageId).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var resourceSet = embeddedResourceNames.ToHashSet(StringComparer.Ordinal);
        var referencedResourceNames = templates
            .SelectMany(template => template.EmbeddedResources.Select(resource =>
                TemplatePathResolver.ResolveResourceName(template.TemplatePath, resource)))
            .ToHashSet(StringComparer.Ordinal);
        var templateResourcePrefix = $"{TemplatePathResolver.ResourcePrefix}Templates.Controls.";
        foreach (var resourceName in resourceSet
            .Where(name => name.StartsWith(templateResourcePrefix, StringComparison.Ordinal))
            .Except(referencedResourceNames, StringComparer.Ordinal)
            .Order(StringComparer.Ordinal))
        {
            errors.Add($"Embedded template resource '{resourceName}' is not referenced by the available template catalog.");
        }

        foreach (var template in templates)
        {
            if (LegacyUnsupportedTemplateCatalog.Contains(template.Id))
            {
                errors.Add($"Unsupported legacy template '{template.Id}' must not appear in the available template catalog.");
                if (template.Available || template.Operable)
                {
                    errors.Add($"Unsupported legacy template '{template.Id}' cannot be marked available or operable.");
                }
            }

            if (ApprovedTemplateFamilies.TryGetValue(template.Id, out var approvedFamily)
                && !template.Family.Equals(approvedFamily, StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Template '{template.Id}' must belong to approved family '{approvedFamily}'.");
            }

            if (new[]
                {
                    template.Id, template.DisplayName, template.Family, template.ControlIdentity,
                    template.PackageId, template.TemplatePath, template.RegistrationRequirement,
                    template.ControlName,
                }.Any(string.IsNullOrWhiteSpace))
            {
                errors.Add($"Template '{template.Id}' has an empty required value.");
            }

            if (!ApprovedFamilies.Contains(template.Family))
            {
                errors.Add($"Template '{template.Id}' belongs to unapproved family '{template.Family}'.");
            }

            if (!IsIdentifier(template.ControlName))
            {
                errors.Add($"Template '{template.Id}' has invalid generated namespace segment '{template.ControlName}'.");
            }

            if (!packageIds.Contains(template.PackageId))
            {
                errors.Add($"Template '{template.Id}' references unknown required package '{template.PackageId}'.");
            }

            if (template.Operable && (!template.Available || !template.Verified))
            {
                errors.Add($"Unavailable or unverified template '{template.Id}' cannot be operable.");
            }

            if (!TemplateRegistrationRequirements.Contains(template.RegistrationRequirement))
            {
                errors.Add($"Template '{template.Id}' has invalid registration classification '{template.RegistrationRequirement}'.");
            }

            if (template.RegistrationVerified && string.IsNullOrWhiteSpace(template.RegistrationEvidence))
            {
                errors.Add($"Template '{template.Id}' cannot have verified registration without evidence metadata.");
            }

            if (template.RegistrationRequirement.Equals("unresolved", StringComparison.OrdinalIgnoreCase)
                && template.RegistrationVerified)
            {
                errors.Add($"Template '{template.Id}' cannot verify an unresolved registration requirement.");
            }

            if (template.Operable
                && (!template.RegistrationVerified
                    || template.RegistrationRequirement.Equals("unresolved", StringComparison.OrdinalIgnoreCase)
                    || string.IsNullOrWhiteSpace(template.RegistrationEvidence)))
            {
                errors.Add($"Template '{template.Id}' cannot be operable without verified registration evidence.");
            }

            if (template.Operable
                && template.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)
                && (!template.RegistrationUsing.Equals("Syncfusion.Maui.Core.Hosting", StringComparison.Ordinal)
                    || !template.RegistrationCall.Equals("builder.ConfigureSyncfusionCore();", StringComparison.Ordinal)))
            {
                errors.Add($"Template '{template.Id}' declares a registration API that has not been implemented by the verified template installer.");
            }

            if (template.Operable
                && !template.RegistrationRequirement.Equals("syncfusion-core", StringComparison.OrdinalIgnoreCase)
                && !template.RegistrationRequirement.Equals("none", StringComparison.OrdinalIgnoreCase))
            {
                errors.Add($"Template '{template.Id}' requires a registration strategy unsupported by the current template installer.");
            }

            if (template.Operable
                && (!template.Compatibility.ValidationStrategy.Equals("restore-and-build-before-commit", StringComparison.OrdinalIgnoreCase)
                    || !template.Compatibility.TargetFrameworkSource.Equals("project-target-frameworks", StringComparison.OrdinalIgnoreCase)
                    || !template.Compatibility.PackageVersionPolicy.Equals("explicit-or-latest-stable", StringComparison.OrdinalIgnoreCase)))
            {
                errors.Add($"Operable template '{template.Id}' must declare runtime restore/build compatibility evaluation against the project's target frameworks and selected package version.");
            }

            if (template.EmbeddedResources.Count == 0)
            {
                errors.Add($"Template '{template.Id}' has no embedded resource references.");
            }

            try
            {
                TemplatePathResolver.ValidateRelativePath(template.TemplatePath);
            }
            catch (InvalidOperationException)
            {
                errors.Add($"Template '{template.Id}' has unsafe template resource root '{template.TemplatePath}'.");
            }

            var expectedResources = template.GeneratedFiles
                .Select(file => file.TemplateResource)
                .ToHashSet(StringComparer.Ordinal);
            if (!expectedResources.SetEquals(template.EmbeddedResources))
            {
                errors.Add($"Template '{template.Id}' has inconsistent embedded resource references.");
            }

            var normalizedDestinations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var file in template.GeneratedFiles)
            {
                try
                {
                    TemplatePathResolver.ValidateRelativePath(file.Destination);
                    if (!normalizedDestinations.Add(file.Destination.Replace('\\', '/')))
                    {
                        errors.Add($"Template '{template.Id}' has duplicate destination '{file.Destination}' after path normalization.");
                    }
                }
                catch (InvalidOperationException)
                {
                    errors.Add($"Template '{template.Id}' has unsafe destination path '{file.Destination}'.");
                }
            }

            var prefix = NormalizeResourcePath(template.TemplatePath) + ".";
            foreach (var resource in template.EmbeddedResources)
            {
                if (string.IsNullOrWhiteSpace(resource) || resource.Contains("..", StringComparison.Ordinal))
                {
                    errors.Add($"Template '{template.Id}' has invalid embedded resource reference '{resource}'.");
                    continue;
                }

                try
                {
                    TemplatePathResolver.ValidateRelativePath(resource);
                }
                catch (InvalidOperationException)
                {
                    errors.Add($"Template '{template.Id}' has unsafe embedded resource path '{resource}'.");
                    continue;
                }

                var expectedName = prefix + NormalizeResourcePath(resource);
                if (!resourceSet.Any(name => name.EndsWith(expectedName, StringComparison.Ordinal)))
                {
                    errors.Add($"Template '{template.Id}' references missing embedded resource '{expectedName}'.");
                }
            }
        }

        return errors.ToList();
    }

    private static string NormalizeResourcePath(string value)
        => value.Replace('\\', '.').Replace('/', '.');

    private static bool IsIdentifier(string value)
        => !string.IsNullOrEmpty(value)
            && (char.IsLetter(value[0]) || value[0] == '_')
            && value.Skip(1).All(character => char.IsLetterOrDigit(character) || character == '_');

    private static void AddDuplicateErrors<T>(
        IEnumerable<T> entries,
        Func<T, string> getValue,
        string kind,
        ISet<string> errors)
    {
        foreach (var group in entries
            .GroupBy(getValue, StringComparer.OrdinalIgnoreCase)
            .Where(group => string.IsNullOrWhiteSpace(group.Key) || group.Count() > 1))
        {
            errors.Add($"Duplicate or empty {kind} '{group.Key}'.");
        }
    }
}
