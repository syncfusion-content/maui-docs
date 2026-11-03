using System.Text;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>
/// Builds the equivalent direct command string for a parsed request, quoting
/// values that contain spaces. Used by interactive completion to show users
/// the command they are about to confirm.
/// </summary>
public static class CommandPreview
{
    /// <summary>Formats a <see cref="NewProjectRequest"/> as a direct command.</summary>
    public static string Format(NewProjectRequest r)
    {
        var sb = new StringBuilder("sfdotnet new ");
        sb.Append(Frameworks.Name(r.Framework));
        sb.Append(" -n ").Append(Quote(r.Name));
        sb.Append(" -p ").Append(PathNormalizer.ForDisplay(r.Path));
        if (!string.IsNullOrWhiteSpace(r.TargetFramework))
        {
            sb.Append(" -t ").Append(r.TargetFramework);
        }
        var templateIds = r.SelectedTemplateIds;
        if (templateIds.Count > 0)
        {
            sb.Append(" --control ").Append(string.Join(' ', templateIds));
        }
        else if (r.Template.Equals("empty", StringComparison.OrdinalIgnoreCase))
        {
            sb.Append(" --control empty");
        }
        sb.Append(" --project-type ").Append(r.ProjectType switch
        {
            MauiProjectType.App => "app",
            MauiProjectType.BlazorHybrid => "blazor-hybrid",
            _ => "app",
        });
        sb.Append(r.Restore ? " --restore" : " --no-restore");
        sb.Append(r.Build ? " --build" : " --no-build");
        if (r.DryRun)
        {
            sb.Append(" --dry-run");
        }
        if (r.Force)
        {
            sb.Append(" --force");
        }
        return sb.ToString();
    }

    /// <summary>Formats a package-add request as a direct command.</summary>
    public static string Format(AddPackageRequest r)
    {
        var sb = new StringBuilder("sfdotnet add ").Append(Frameworks.Name(r.Framework)).Append(' ');
        sb.Append(r.PackageAliasOrId);
        sb.Append(" -p ").Append(PathNormalizer.ForDisplay(r.Path));
        if (!string.IsNullOrWhiteSpace(r.Version))
        {
            sb.Append(" -v ").Append(r.Version);
        }
        sb.Append(r.Restore ? " --restore" : " --no-restore");
        if (r.DryRun)
        {
            sb.Append(" --dry-run");
        }
        if (r.Force)
        {
            sb.Append(" --force");
        }
        return sb.ToString();
    }

    /// <summary>Formats a template-add request as a direct command.</summary>
    public static string Format(AddTemplateRequest r)
    {
        var sb = new StringBuilder("sfdotnet add ")
            .Append(Frameworks.Name(r.Framework))
            .Append(" --template ")
            .Append(string.Join(' ', r.SelectedTemplateIds))
            .Append(" -p ")
            .Append(PathNormalizer.ForDisplay(r.Path));
        if (!string.IsNullOrWhiteSpace(r.Version))
        {
            sb.Append(" -v ").Append(r.Version);
        }
        sb.Append(r.Restore ? " --restore" : " --no-restore");
        if (r.DryRun)
        {
            sb.Append(" --dry-run");
        }
        if (r.Force)
        {
            sb.Append(" --force");
        }
        return sb.ToString();
    }

    /// <summary>Formats a package-remove request as a direct command.</summary>
    public static string Format(RemovePackageRequest r)
    {
        var sb = new StringBuilder("sfdotnet remove ").Append(Frameworks.Name(r.Framework)).Append(' ');
        sb.Append(r.PackageAliasOrId);
        sb.Append(" -p ").Append(PathNormalizer.ForDisplay(r.Path));
        if (r.DryRun)
        {
            sb.Append(" --dry-run");
        }
        if (r.Force)
        {
            sb.Append(" --force");
        }
        return sb.ToString();
    }

    /// <summary>Formats a template-remove request as a direct command.</summary>
    public static string Format(RemoveTemplateRequest r)
    {
        var sb = new StringBuilder("sfdotnet remove ")
            .Append(Frameworks.Name(r.Framework))
            .Append(" --template ")
            .Append(string.Join(' ', r.SelectedTemplateIds))
            .Append(" -p ")
            .Append(PathNormalizer.ForDisplay(r.Path));
        if (r.DryRun)
        {
            sb.Append(" --dry-run");
        }
        if (r.Force)
        {
            sb.Append(" --force");
        }
        return sb.ToString();
    }

    /// <summary>Formats a package-update request as a direct command.</summary>
    public static string Format(UpdatePackageRequest r)
    {
        var sb = new StringBuilder("sfdotnet update ")
            .Append(Frameworks.Name(r.Framework))
            .Append(' ')
            .Append(r.PackageAliasOrId);
        sb.Append(" -p ").Append(PathNormalizer.ForDisplay(r.Path));
        if (!string.IsNullOrWhiteSpace(r.Version))
        {
            sb.Append(" -v ").Append(r.Version);
        }
        sb.Append(r.Restore ? " --restore" : " --no-restore");
        if (r.DryRun)
        {
            sb.Append(" --dry-run");
        }
        if (r.Force)
        {
            sb.Append(" --force");
        }
        return sb.ToString();
    }

    /// <summary>Formats a <see cref="ListRequest"/> as a direct command.</summary>
    public static string Format(ListRequest r)
        => $"sfdotnet list {Frameworks.Name(r.Framework)} {CategoryName(r.Category)}";

    /// <summary>Formats a <see cref="SearchRequest"/> as a direct command.</summary>
    public static string Format(SearchRequest r)
        => $"sfdotnet search {Frameworks.Name(r.Framework)} {Quote(r.Text)}";

    /// <summary>Formats an <see cref="InfoRequest"/> as a direct command.</summary>
    public static string Format(InfoRequest r)
        => "sfdotnet info";

    /// <summary>Maps a list category to its command-line name.</summary>
    public static string CategoryName(ListCategory category)
        => category switch
        {
            ListCategory.Packages => "packages",
            ListCategory.Installed => "installed",
            ListCategory.Templates => "templates",
            _ => "packages",
        };

    private static string Quote(string value)
        => value.Contains(' ') ? "\"" + value + "\"" : value;
}
