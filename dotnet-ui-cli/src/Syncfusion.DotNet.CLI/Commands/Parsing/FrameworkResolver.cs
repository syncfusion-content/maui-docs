using Syncfusion.DotNet.Cli.Core;

using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Commands.Parsing;

/// <summary>
/// Resolves the framework for a command from the positional argument and the
/// <c>-f/--framework</c> option. Enforces that only one form is supplied, and
/// optionally prompts for the framework when interactive completion is allowed.
/// </summary>
public static class FrameworkResolver
{
    /// <summary>Returns a validation error for invalid explicitly supplied framework values.</summary>
    public static string? ValidateExplicit(string? positional, string? option)
    {
        if (string.IsNullOrWhiteSpace(positional) && string.IsNullOrWhiteSpace(option))
        {
            return null;
        }

        return Resolve(positional, option).Error;
    }

    /// <summary>
    /// Pure resolve: no prompting. Used by tests and the non-interactive path.
    /// </summary>
    public static ParseOutcome<Framework> Resolve(string? positional, string? option)
    {
        var hasPositional = !string.IsNullOrWhiteSpace(positional);
        var hasOption = !string.IsNullOrWhiteSpace(option);

        if (hasPositional && hasOption)
        {
            return ParseOutcome<Framework>.Fail(
                "Specify the framework either as a positional argument or with -f/--framework, not both.");
        }

        var value = hasPositional ? positional : option;
        if (value is null)
        {
            return ParseOutcome<Framework>.Fail("A framework is required. Example: 'sfdotnet new maui'.");
        }

        return ToFramework(value);
    }

    /// <summary>
    /// Resolves the framework, prompting for it when missing and interactive
    /// completion is allowed. Returns a failure when missing and not interactive.
    /// </summary>
    public static ParseOutcome<Framework> ResolveOrPrompt(
        string? positional,
        string? option,
        GlobalOptions globals,
        CancellationToken cancellationToken = default)
    {
        var hasPositional = !string.IsNullOrWhiteSpace(positional);
        var hasOption = !string.IsNullOrWhiteSpace(option);

        if (hasPositional && hasOption)
        {
            return ParseOutcome<Framework>.Fail(
                "Specify the framework either as a positional argument or with -f/--framework, not both.");
        }

        var value = hasPositional ? positional : option;
        if (string.IsNullOrWhiteSpace(value))
        {
            if (InteractivePrompt.CanPrompt(globals))
            {
                globals.RequiresReview = true;
                value = InteractivePrompt.AskFramework(globals.NoColor, cancellationToken);
            }
            else
            {
                return ParseOutcome<Framework>.Fail("A framework is required. Example: 'sfdotnet new maui'.");
            }
        }

        return ToFramework(value);
    }

    private static ParseOutcome<Framework> ToFramework(string value)
    {
        if (!Frameworks.TryParse(value, out var framework))
        {
            return ParseOutcome<Framework>.Fail(
                $"Unknown framework '{value}'. Supported values: {string.Join(", ", Frameworks.All)}.");
        }

        return ParseOutcome<Framework>.Ok(framework);
    }
}
