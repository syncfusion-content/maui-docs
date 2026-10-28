using Syncfusion.DotNet.CLI.Commands.Desktop;
using System.Threading;
using System.Threading.Tasks;
using Spectre.Console;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;

namespace Syncfusion.DotNet.CLI.Wizard;

/// <summary>The interactive menu shown when <c>sf</c> is run without a command.</summary>
public sealed class InteractiveMenu(ConsolePresenter _presenter)
{
    internal const int SectionHeadingIndent = 2;
    private const int SelectionMarkerWidth = 2;
    internal const int ActionLabelIndent = SectionHeadingIndent + SelectionMarkerWidth + 2;
    private const int CommandColumnGap = 4;
    private const int CommandContinuationIndent = 2;

    public Task<int> RunAsync(GlobalOptions options, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        if (options.Json)
        {
            _presenter.WriteInfo("{\"interactive\":false,\"hint\":\"Run 'sf --help' for command reference.\"}");
            return Task.FromResult(ExitCodes.Success);
        }

        // Emit the header before Spectre probes terminal capabilities (VT enablement,
        // legacy-console detection), which is the slowest step on Windows. The cheap
        // redirection checks below mirror CanPrompt so non-interactive runs stay unchanged.
        var headerWritten = false;
        if (options.IsInteractiveEffective && !System.Console.IsInputRedirected && !System.Console.IsOutputRedirected)
        {
            WriteHeader(options.NoColor);
            headerWritten = true;
        }

        if (!InteractivePrompt.CanPrompt(options))
        {
            _presenter.WriteInfo("No interactive terminal detected. Run 'sf help' to see available commands.");
            return Task.FromResult(ExitCodes.Success);
        }

        return RunMenuAsync(options, headerWritten, cancellationToken);
    }

    private async Task<int> RunMenuAsync(GlobalOptions options, bool headerWritten, CancellationToken cancellationToken)
    {
        var originalConsole = AnsiConsole.Console;
        if (options.NoColor)
        {
            AnsiConsole.Console = AnsiConsole.Create(new AnsiConsoleSettings
            {
                Ansi = AnsiSupport.Yes,
                ColorSystem = ColorSystemSupport.NoColors,
                Out = originalConsole.Profile.Out,
                Interactive = InteractionSupport.Yes,
            });
        }

        try
        {
            if (!headerWritten) WriteHeader(options.NoColor);
            while (true)
            {
                try
                {
                    using var wizardOutput = ProjectWizardOutput.Begin(AnsiConsole.Console, _presenter.NoColor);
                    var choice = PromptChoice(options.NoColor, cancellationToken);
                    if (choice.Action is null)
                    {
                        continue;
                    }

                    var exitCode = await HandleChoiceAsync(choice.Action.Value, options, cancellationToken).ConfigureAwait(false);
                    if (choice.Action == MenuAction.CreateProject && exitCode == ExitCodes.Cancelled)
                    {
                        continue;
                    }

                    return exitCode;
                }
                catch (InteractivePromptCancelledException)
                {
                    _presenter.WriteInfo("Cancelled. No changes made.");
                    continue;
                }
            }
        }
        finally
        {
            if (options.NoColor)
            {
                AnsiConsole.Console = originalConsole;
            }
        }
    }

    private void WriteHeader(bool noColor)
    {
        _ = noColor;
        _presenter.WriteInfo(CreateHeader());
        System.Console.Out.WriteLine();
    }

    internal static string CreateHeader()
        => $"{CliMetadata.ProductName} {CliMetadata.Version}";

    private static MenuChoice PromptChoice(bool noColor, CancellationToken cancellationToken)
    {
        var choices = MenuItems.Categories.SelectMany(category =>
            new[] { MenuItems.CreateCategoryChoice(category) }.Concat(category.Operations))
            .Append(MenuItems.Operations[^1]).ToArray();
        return new InteractiveConsoleInput(noColor).SelectMenu(choices, cancellationToken);
    }

    internal const string MenuQuestion = "What would you like to do?";
    internal const string MenuGuidance = "↑/↓: navigate | Enter: select | Esc: cancel | Ctrl+C: exit";

    internal static string FormatOperation(MenuChoice operation, int terminalWidth)
    {
        if (operation.Command is null)
        {
            return operation.Label;
        }

        var operationWidth = MenuItems.Operations.Max(item => item.Label.Length);
        var commandWidth = MenuItems.Operations.Max(item => item.Command!.Length);
        var commandColumn = operationWidth + CommandColumnGap;
        if (terminalWidth > ActionLabelIndent + commandColumn + commandWidth)
        {
            return operation.Label.PadRight(commandColumn)
                + operation.Command;
        }

        return operation.Label
            + Environment.NewLine
            + new string(' ', CommandContinuationIndent)
            + operation.Command;
    }

    internal static string FormatMenuGuidance(bool noColor)
    {
        _ = noColor;
        return TerminalPresentation.Symbols(MenuGuidance, AnsiConsole.Console);
    }

    internal static string FormatChoice(MenuChoice choice, bool noColor, IAnsiConsole? console = null)
    {
        _ = noColor;
        console ??= AnsiConsole.Console;
        if (choice.Action is null)
        {
            var label = choice.Label.ToUpperInvariant();
            return console.Profile.Capabilities.Unicode && choice.Icon is not null
                ? $"{choice.Icon} {label}"
                : label;
        }

        if (choice.Command is null)
        {
            return choice.Label;
        }

        var formatted = FormatOperation(choice, console.Profile.Width);

        return formatted;
    }

    private async Task<int> HandleChoiceAsync(MenuAction action, GlobalOptions options, CancellationToken cancellationToken)
    {
        switch (action)
        {
            case MenuAction.CreateProject:
                {
                    var selectedPlatform = InteractivePrompt.AskFramework(options.NoColor, cancellationToken);
                    if (Commands.Blazor.BlazorCommands.IsSelected(NewCommand.Create().Parse([selectedPlatform]), NewCommand.FrameworkArg))
                        return await Commands.Blazor.BlazorCommands.NewAsync(NewCommand.Create().Parse([selectedPlatform]), options, _presenter, cancellationToken, showAction: false).ConfigureAwait(false);
                    if (DesktopProviders.Find(selectedPlatform) is { } desktop)
                        return await DesktopCommands.NewAsync(NewCommand.Create().Parse([selectedPlatform]), options, _presenter, desktop, cancellationToken, showAction: false).ConfigureAwait(false);
                    Frameworks.TryParse(selectedPlatform, out var framework);
                    var request = NewCommand.BuildInteractive(
                        _presenter,
                        options,
                        cancellationToken,
                        out var plannedFramework, framework);
                    if (plannedFramework is not null)
                    {
                        return ExitCodes.Success;
                    }

                    return request is null
                        ? ExitCodes.Cancelled
                        : await NewCommand.ExecuteNew(_presenter, request, cancellationToken).ConfigureAwait(false);
                }
            case MenuAction.AddPackage:
                return await AddAsync(options, cancellationToken).ConfigureAwait(false);
            // Improvement: Remove package from existing project is temporarily disabled for all platforms.
            // case MenuAction.RemovePackage:
            //     return await RemoveAsync(options, cancellationToken).ConfigureAwait(false);
            case MenuAction.UpdatePackages:
                return await UpdateAsync(options, cancellationToken).ConfigureAwait(false);
            case MenuAction.ListAvailablePackages:
            case MenuAction.ListInstalledPackages:
                {
                    var platform = InteractivePrompt.AskFramework(options.NoColor, cancellationToken);
                    var category = action == MenuAction.ListInstalledPackages ? "installed" : "packages";
                    if (DesktopProviders.Find(platform) is { } desktop)
                    {
                        var args = new List<string> { platform, category };
                        if (category == "installed") args.AddRange(["--path", InteractivePrompt.AskString("Project file:", Directory.GetCurrentDirectory(), cancellationToken, options.NoColor)]);
                        return DesktopCommands.Discover(ListCommand.Create().Parse(args.ToArray()), "list", options, _presenter, desktop, category, cancellationToken);
                    }
                    return await ListCommand.ExecuteListAsync(_presenter, new ListRequest(category == "installed" ? ListCategory.Installed : ListCategory.Packages, Framework.Maui), options, PathNormalizer.Normalize(null), cancellationToken).ConfigureAwait(false);
                }
            case MenuAction.SearchPackages:
                {
                    var platform = InteractivePrompt.AskFramework(options.NoColor, cancellationToken);
                    var text = InteractivePrompt.AskString("What would you like to search for?", cancellationToken: cancellationToken, noColor: options.NoColor);
                    if (DesktopProviders.Find(platform) is { } desktop)
                        return DesktopCommands.Discover(SearchCommand.Create().Parse([text, "--framework", platform]), "search", options, _presenter, desktop, text, cancellationToken);
                    return SearchCommand.Execute(_presenter, options, new SearchRequest(text, Framework.Maui));
                }
            case MenuAction.ActivateLicense:
                return await Hosting.CliApp.Build().RunAsync(WithGlobals(["license", "activate"], options), cancellationToken).ConfigureAwait(false);
            case MenuAction.ViewLicenses:
                return await Hosting.CliApp.Build().RunAsync(WithGlobals(["license", "view"], options), cancellationToken).ConfigureAwait(false);
            case MenuAction.SignIn:
                return await Hosting.CliApp.Build().RunAsync(WithGlobals(["login"], options), cancellationToken).ConfigureAwait(false);
            case MenuAction.SignOut:
                return await Hosting.CliApp.Build().RunAsync(WithGlobals(["logout"], options), cancellationToken).ConfigureAwait(false);
            case MenuAction.Information:
                return InfoCommand.Execute(_presenter, options);
            case MenuAction.Help:
                return HelpCommand.Execute(_presenter, topic: null);
            case MenuAction.Exit:
                return ExitCodes.Success;
            default:
                _presenter.WriteError($"Unknown menu action: {action}");
                return ExitCodes.Error;
        }
    }

    private static string[] WithGlobals(string[] args, GlobalOptions options)
        => options.Verbose ? [.. args, "--verbose"] : args;

    private async Task<int> AddAsync(
        GlobalOptions options,
        CancellationToken cancellationToken)
    {
        var platform = InteractivePrompt.AskFramework(options.NoColor, cancellationToken);
        if (DesktopProviders.Find(platform) is { } desktop)
            return await DesktopCommands.PackageAsync(AddCommand.Create().Parse([platform]), "add", options, _presenter, desktop, cancellationToken).ConfigureAwait(false);

        options.RequiresReview = true;
        var (project, projectError) = CommandOperations.ResolveProjectForPrompt(
            PathNormalizer.Normalize(null),
            options,
            cancellationToken, retainSelection: false);
        if (project is null)
        {
            return CommandOperations.WriteFailure(_presenter, options, projectError!);
        }

        return await CommandOperations.AddInteractiveControlsAsync(_presenter, project, options, cancellationToken).ConfigureAwait(false);
    }

    // Improvement: Remove package from existing project is temporarily disabled for all platforms.
    // private async Task<int> RemoveAsync(
    //     GlobalOptions options,
    //     CancellationToken cancellationToken)
    // {
    //     var platform = InteractivePrompt.AskFramework(options.NoColor, cancellationToken);
    //     if (DesktopProviders.Find(platform) is { } desktop)
    //         return await DesktopCommands.PackageAsync(RemoveCommand.Create().Parse([platform]), "remove", options, _presenter, desktop, cancellationToken).ConfigureAwait(false);
    //
    //     options.RequiresReview = true;
    //     var (packageProject, packages, packageError) = CommandOperations.GetInstalledPackages(
    //         PathNormalizer.Normalize(null),
    //         options,
    //         cancellationToken);
    //     if (packageProject is null)
    //     {
    //         return CommandOperations.WriteFailure(_presenter, options, packageError!);
    //     }
    //     if (packages.Count == 0)
    //     {
    //         _presenter.WriteInfo("No installed packages are available to remove.");
    //         return ExitCodes.Success;
    //     }
    //
    //     var packageAlias = InteractivePrompt.AskInstalledPackage(
    //         "Which installed packages would you like to remove?",
    //         packages,
    //         cancellationToken);
    //     var packageRequest = new RemovePackageRequest(
    //         Framework.Maui,
    //         packageAlias,
    //         packageProject.CsprojPath,
    //         DryRun: false,
    //         Force: false);
    //     return await CommandOperations.RemovePackageAsync(
    //         _presenter,
    //         packageRequest,
    //         options,
    //         cancellationToken).ConfigureAwait(false);
    // }
    //
    private async Task<int> UpdateAsync(GlobalOptions options, CancellationToken cancellationToken)
    {
        var platform = InteractivePrompt.AskFramework(options.NoColor, cancellationToken);
        if (DesktopProviders.Find(platform) is { } desktop)
            return await DesktopCommands.PackageAsync(UpdateCommand.Create().Parse([platform]), "update", options, _presenter, desktop, cancellationToken).ConfigureAwait(false);

        options.RequiresReview = true;
        var (project, installed, error) = CommandOperations.GetInstalledPackages(
            PathNormalizer.Normalize(null),
            options,
            cancellationToken);
        if (project is null)
        {
            return CommandOperations.WriteFailure(_presenter, options, error!);
        }
        if (installed.Count == 0)
        {
            _presenter.WriteInfo("No installed packages are available to update.");
            return ExitCodes.Success;
        }

        var packageAlias = InteractivePrompt.AskInstalledPackage(
            "Which installed packages would you like to update?",
            installed,
            cancellationToken);
        var request = new UpdatePackageRequest(
            Framework.Maui,
            packageAlias,
            project.CsprojPath,
            Version: null,
            Restore: true,
            DryRun: false,
            Force: false);
        return await CommandOperations.UpdatePackageAsync(
            _presenter,
            request,
            options,
            cancellationToken).ConfigureAwait(false);
    }
}
