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

/// <summary>Defines the <c>sfdotnet list</c> command.</summary>
public static class ListCommand
{
    internal static readonly Option<bool> DetailsOption = new("--details") { Description = "Show package descriptions, setup support, and verification evidence." };
    internal static readonly Option<string> SearchOption = new("--search") { Description = "Filter packages by alias, name, package ID, or description." };

    internal const string CategoryArg = "category";
    internal const string FrameworkArg = "framework";

    public static Command Create()
    {
        var categoryArg = CommandOptions.OptionalArg(CategoryArg, "The list category: packages or installed.");
        var frameworkArg = CommandOptions.OptionalArg(FrameworkArg, "The platform: maui, blazor, wpf, winforms or winui.");

        var command = new Command("list", "List available or installed Syncfusion packages.");
        command.Add(categoryArg);
        command.Add(frameworkArg);
        command.Add(CommandOptions.FrameworkOption);
        command.Add(CommandOptions.PathOption);
        command.Add(CommandOptions.TemplateOption);
        command.Add(CommandOptions.InstalledOption);
        command.Add(DetailsOption);
        command.Add(SearchOption);

        command.SetAction(async (parseResult, cancellationToken) =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parseResult);
            var globals = GlobalsHelper.Bind(parseResult);
            if (DesktopCommands.Provider(parseResult, CategoryArg, FrameworkArg) is { } desktop)
            {
                var first = parseResult.GetValue<string?>(CategoryArg);
                var target = DesktopProviders.Find(first) is not null ? parseResult.GetValue<string?>(FrameworkArg) : first;
                return DesktopCommands.Discover(parseResult, "list", globals, presenter, desktop, target, cancellationToken);
            }
            var outcome = Build(parseResult, globals, cancellationToken);
            if (!outcome.IsSuccess)
            {
                return CommandOperations.WriteFailure(presenter, globals, outcome.Error!, outcome.ExitCode);
            }

            var request = outcome.Request!;
            if (CommandReporting.IsPlanned(request.Framework))
            {
                return CommandReporting.ReportPlanned(presenter, request.Framework);
            }

            return await ExecuteListAsync(
                presenter,
                request,
                globals,
                PathNormalizer.Normalize(parseResult.GetValue(CommandOptions.PathOption)),
                cancellationToken,
                parseResult.GetValue(DetailsOption),
                parseResult.GetValue(SearchOption)).ConfigureAwait(false);
        });

        return command;
    }

    public static ParseOutcome<ListRequest> Build(
        ParseResult parseResult,
        GlobalOptions globals,
        CancellationToken cancellationToken = default)
    {
        var first = parseResult.GetValue<string?>(CategoryArg);
        var second = parseResult.GetValue<string?>(FrameworkArg);
        var primarySyntax = Frameworks.TryParse(first, out _);
        var categoryValue = primarySyntax ? second : first;
        var frameworkValue = primarySyntax ? first : second;
        var explicitFrameworkError = FrameworkResolver.ValidateExplicit(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption));
        if (explicitFrameworkError is not null)
        {
            return ParseOutcome<ListRequest>.Fail(explicitFrameworkError);
        }

        var templateOptionPresent = parseResult.GetResult(CommandOptions.TemplateOption) is not null;
        var installedTemplates = parseResult.GetValue(CommandOptions.InstalledOption);
        if (templateOptionPresent)
        {
            if (CommandOptions.GetTemplateValues(parseResult).Count > 0)
            {
                return ParseOutcome<ListRequest>.Fail("The generated-content listing option does not accept control IDs.");
            }

            categoryValue = installedTemplates ? "installed-templates" : "templates";
        }
        else if (installedTemplates)
        {
            return ParseOutcome<ListRequest>.Fail("The installed listing option is unavailable without a list category.");
        }
        if (string.IsNullOrWhiteSpace(categoryValue))
        {
            if (InteractivePrompt.CanPrompt(globals))
            {
                categoryValue = InteractivePrompt.AskListCategory(cancellationToken);
            }
            else
            {
                return ParseOutcome<ListRequest>.Fail("A category is required. Values: packages, installed.");
            }
        }

        var category = categoryValue.ToLowerInvariant() switch
        {
            "packages" => (ListCategory?)ListCategory.Packages,
            "installed" => ListCategory.Installed,
            "templates" => ListCategory.Templates,
            "installed-templates" => ListCategory.InstalledTemplates,
            _ => null,
        };

        if (category is null)
        {
            return ParseOutcome<ListRequest>.Fail(
                $"Unknown list category '{categoryValue}'. Supported values: packages, installed.");
        }

        var frameworkOutcome = FrameworkResolver.ResolveOrPrompt(
            frameworkValue,
            parseResult.GetValue(CommandOptions.FrameworkOption),
            globals,
            cancellationToken);
        if (!frameworkOutcome.IsSuccess)
        {
            return ParseOutcome<ListRequest>.Fail(frameworkOutcome.Error!, frameworkOutcome.ExitCode);
        }

        return ParseOutcome<ListRequest>.Ok(new ListRequest(category.Value, frameworkOutcome.Request!));
    }

    public static ParseOutcome<ListRequest> Parse(ParseResult parseResult)
        => Build(parseResult, _nonInteractiveGlobals);

    internal static Task<int> ExecuteListAsync(
        ConsolePresenter presenter,
        ListRequest request,
        GlobalOptions globals,
        string path,
        CancellationToken cancellationToken,
        bool details = false,
        string? search = null)
    {
        return Task.FromResult(request.Category switch
        {
            ListCategory.Packages => ListPackages(presenter, globals, details, search, cancellationToken),
            ListCategory.Installed => ListInstalled(presenter, globals, path, cancellationToken),
            ListCategory.Templates => ListTemplates(presenter, globals),
            ListCategory.InstalledTemplates => ListInstalledTemplates(
                presenter,
                globals,
                path,
                cancellationToken),
            _ => ExitCodes.Error,
        });
    }

    private static int ListPackages(
        ConsolePresenter presenter, GlobalOptions globals, bool details, string? search,
        CancellationToken cancellationToken)
    {
        // Listing visibility does not change catalog identity or package operations.
        var packages = (string.IsNullOrWhiteSpace(search)
            ? DiscoveryService.ListPackages()
            : DiscoveryService.SearchPackages(search))
            .Where(package => !package.PackageId.Equals("Syncfusion.Maui.MCP", StringComparison.OrdinalIgnoreCase)
                && !HiddenPackages.IsHidden(package.PackageId))
            .ToList();
        if (globals.Json)
        {
            presenter.WriteInfo(DiscoveryService.ToJson(packages));
            return ExitCodes.Success;
        }

        PackageListRenderer.Write(presenter, packages, globals, details, cancellationToken);
        return ExitCodes.Success;
    }

    private static int ListInstalled(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string path,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var (project, installed, error) = CommandOperations.GetInstalledPackages(path, globals, cancellationToken);
        if (project is null)
        {
            return CommandOperations.WriteFailure(presenter, globals, error!);
        }

        if (globals.Json)
        {
            presenter.WriteInfo(DiscoveryService.ToJson(installed));
            return ExitCodes.Success;
        }

        InstalledPackageRenderer.Write(presenter, "MAUI", installed.Select(package =>
            new InstalledPackageRenderer.Entry(package.Alias, package.PackageId, package.Version)).ToArray());

        return ExitCodes.Success;
    }

    private static int ListTemplates(ConsolePresenter presenter, GlobalOptions globals)
    {
        var templates = DiscoveryService.ListTemplates();
        if (globals.Json)
        {
            presenter.WriteInfo(DiscoveryService.ToJson(templates));
            return ExitCodes.Success;
        }

        presenter.WriteInfo("Available Syncfusion MAUI controls (control ID, display name, control family):");
        foreach (var template in templates)
        {
            presenter.WriteInfo(
                $"  {template.TemplateId,-20} {template.DisplayName,-24} {template.TemplateFamily,-18} {template.ControlIdentity}");
        }

        return ExitCodes.Success;
    }

    private static int ListInstalledTemplates(
        ConsolePresenter presenter,
        GlobalOptions globals,
        string path,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var (project, templates, error) = CommandOperations.GetInstalledTemplates(path, globals, cancellationToken);
        if (project is null)
        {
            return CommandOperations.WriteFailure(presenter, globals, error!);
        }

        var output = templates.Select(template => new
        {
            templateId = template.Id,
            templateFamily = template.Family,
            displayName = TemplateCatalog.TryResolveOperableTemplate(template.Id, out var entry)
                ? entry.DisplayName
                : LegacyUnsupportedTemplateCatalog.TryResolve(template.Id, out var legacyDisplayName)
                    ? legacyDisplayName
                    : template.Id,
            templateStatus = LegacyUnsupportedTemplateCatalog.Contains(template.Id)
                ? "unsupported legacy template"
                : "available",
            available = !LegacyUnsupportedTemplateCatalog.Contains(template.Id),
            controlIdentity = TemplateCatalog.TryResolveOperableTemplate(template.Id, out var control)
                ? control.ControlIdentity
                : template.Id,
            requiredPackageId = template.PackageId,
            generatedFiles = template.GeneratedFiles,
        }).ToList();
        if (globals.Json)
        {
            presenter.WriteInfo(DiscoveryService.ToJson(output));
            return ExitCodes.Success;
        }

        if (templates.Count == 0)
        {
            presenter.WriteInfo("No CLI-tracked controls are installed in the selected project.");
            return ExitCodes.Success;
        }

        presenter.WriteInfo("Installed Syncfusion MAUI controls:");
        var rows = templates.Select(template =>
        {
            var displayName = TemplateCatalog.TryResolveOperableTemplate(template.Id, out var entry)
                ? entry.DisplayName
                : LegacyUnsupportedTemplateCatalog.TryResolve(template.Id, out var legacyDisplayName)
                    ? $"{legacyDisplayName} (unsupported legacy control)"
                    : template.Id;
            return new[] { template.Id, displayName, template.Family, template.PackageId };
        });
        foreach (var row in TableRows.Format(["Control ID", "Name", "Family", "NuGet"], rows))
            presenter.WriteInfo("  " + row);

        return ExitCodes.Success;
    }

    private static readonly GlobalOptions _nonInteractiveGlobals = new() { NoInteractive = true };
}
