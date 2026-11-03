using System.CommandLine.Parsing;
using Syncfusion.DotNet.Cli.Commands.Parsing;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;

namespace Syncfusion.DotNet.Cli.Commands.Reporting;

/// <summary>
/// Shared reporting for parsed Phase 2 commands. Execution itself is a later
/// phase; this reports validation success, planned-framework status, and
/// request previews.
/// </summary>
internal static class CommandReporting
{
    /// <summary>True when the framework is valid but not yet implemented.</summary>
    public static bool IsPlanned(Framework framework)
        => Frameworks.IsPlanned(framework);

    /// <summary>Prints the planned-framework notice and returns success.</summary>
    public static int ReportPlanned(ConsolePresenter presenter, Framework framework)
    {
        presenter.WriteInfo($"The '{Frameworks.Name(framework)}' framework is planned but not implemented in this preview.");
        return ExitCodes.Success;
    }

    /// <summary>Prints the validation-success notice and optional preview, returns success.</summary>
    public static int ReportValid(ConsolePresenter presenter, string preview)
    {
        presenter.WriteInfo("The command is valid. Execution will be implemented in a later phase.");
        if (!string.IsNullOrEmpty(preview))
        {
            presenter.WriteInfo(preview);
        }
        return ExitCodes.Success;
    }

    /// <summary>
    /// Reports a request outcome: error to stderr, or planned/valid to stdout.
    /// Uses <paramref name="format"/> to render the equivalent command preview.
    /// </summary>
    public static int Report<T>(ConsolePresenter presenter, ParseOutcome<T> outcome, Func<T, string> format)
        where T : class
    {
        if (outcome.Error is not null)
        {
            presenter.WriteError(outcome.Error);
            return outcome.ExitCode;
        }

        var request = outcome.Request!;
        var framework = ExtractFramework(request);
        return IsPlanned(framework)
            ? ReportPlanned(presenter, framework)
            : ReportValid(presenter, format(request));
    }

    private static Framework ExtractFramework<T>(T request)
        => request switch
        {
            NewProjectRequest r => r.Framework,
            AddPackageRequest r => r.Framework,
            AddTemplateRequest r => r.Framework,
            RemovePackageRequest r => r.Framework,
            RemoveTemplateRequest r => r.Framework,
            UpdatePackageRequest r => r.Framework,
            ListRequest r => r.Framework,
            SearchRequest r => r.Framework,
            _ => Core.Framework.Maui,
        };
}
