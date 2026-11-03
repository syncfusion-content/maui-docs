using Syncfusion.DotNet.Cli.Commands.Desktop;
using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.Cli.Commands.Operations;
using Syncfusion.DotNet.Cli.Commands.Options;
using Syncfusion.DotNet.Cli.Commands.Parsing;
using Syncfusion.DotNet.Cli.Commands.Reporting;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Commands;

/// <summary>Defines the <c>sfdotnet search</c> command.</summary>
public static class SearchCommand
{
    internal const string TextArg = "text";
    internal const string FrameworkArg = "framework";

    public static Command Create()
    {
        var textArg = CommandOptions.OptionalArg(TextArg, "The text to search for.");
        var frameworkArg = CommandOptions.OptionalArg(FrameworkArg, "The platform: maui, blazor, wpf, winforms or winui.");

        var command = new Command("search", "Search the selected platform package catalog.");
        command.Add(textArg);
        command.Add(frameworkArg);
        command.Add(CommandOptions.FrameworkOption);
        command.Add(ListCommand.DetailsOption);

        command.SetAction((parseResult, cancellationToken) =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parseResult);
            var globals = GlobalsHelper.Bind(parseResult);
            if (DesktopCommands.Provider(parseResult, TextArg, FrameworkArg) is { } desktop)
            {
                var first = parseResult.GetValue<string?>(TextArg);
                var target = DesktopProviders.Find(first) is not null ? parseResult.GetValue<string?>(FrameworkArg) : first;
                return Task.FromResult(DesktopCommands.Discover(parseResult, "search", globals, presenter, desktop, target, cancellationToken));
            }
            var outcome = Build(parseResult, globals, cancellationToken);
            if (!outcome.IsSuccess)
            {
                return Task.FromResult(
                    CommandOperations.WriteFailure(presenter, globals, outcome.Error!, outcome.ExitCode));
            }

            return Task.FromResult(Execute(presenter, globals, outcome.Request!, parseResult.GetValue(ListCommand.DetailsOption), cancellationToken));
        });

        return command;
    }

    public static ParseOutcome<SearchRequest> Build(
        ParseResult parseResult,
        GlobalOptions globals,
        CancellationToken cancellationToken = default)
    {
        var first = parseResult.GetValue<string?>(TextArg);
        var second = parseResult.GetValue<string?>(FrameworkArg);
        var primarySyntax = Frameworks.TryParse(first, out _);
        var text = primarySyntax ? second : first;
        var frameworkValue = primarySyntax ? first : second;
        var explicitFrameworkError = FrameworkResolver.ValidateExplicit(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption));
        if (explicitFrameworkError is not null)
        {
            return ParseOutcome<SearchRequest>.Fail(explicitFrameworkError);
        }

        if (string.IsNullOrWhiteSpace(text))
        {
            if (InteractivePrompt.CanPrompt(globals))
            {
                text = InteractivePrompt.AskString(
                    "What would you like to search for?",
                    cancellationToken: cancellationToken,
                    noColor: globals.NoColor);
            }
            else
            {
                return ParseOutcome<SearchRequest>.Fail("Package search text is required. Example: 'sfdotnet search maui grid'.");
            }
        }

        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption),
            globals,
            cancellationToken);
        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<SearchRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        return ParseOutcome<SearchRequest>.Ok(new SearchRequest(text!, frameworkOutcome.Request!));
    }

    public static ParseOutcome<SearchRequest> Parse(ParseResult parseResult)
        => Build(parseResult, _nonInteractiveGlobals);

    internal static int Execute(ConsolePresenter presenter, GlobalOptions globals, SearchRequest request, bool details = false, CancellationToken cancellationToken = default)
    {
        var packages = DiscoveryService.SearchPackages(request.Text);
        if (globals.Json)
        {
            presenter.WriteInfo(DiscoveryService.ToJson(packages));
            return ExitCodes.Success;
        }

        if (packages.Count == 0)
        {
            presenter.WriteInfo($"No packages matched '{request.Text}'.");
            return ExitCodes.Success;
        }

        PackageListRenderer.Write(presenter, packages, globals, details, cancellationToken);

        return ExitCodes.Success;
    }

    private static readonly GlobalOptions _nonInteractiveGlobals = new() { NoInteractive = true };
}
