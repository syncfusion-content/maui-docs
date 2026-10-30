using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.Cli.Commands;
using Syncfusion.DotNet.Cli.Commands.Actions;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Maui.Discovery;
using Syncfusion.DotNet.Cli.Presentation;
using Syncfusion.DotNet.Cli.Wizard;

namespace Syncfusion.DotNet.Cli.Hosting;

/// <summary>
/// Composes the root command, registers global options and reserved
/// subcommands, and runs the resulting parser. Construction of the command
/// tree is separated from console presentation so the same configuration can
/// be reused and tested without a real terminal.
/// </summary>
public sealed class CliApp
{
    private readonly RootCommand _root;
    private readonly GlobalOptionsBinder _options;

    private CliApp(RootCommand root, GlobalOptionsBinder options)
    {
        _root = root;
        _options = options;
    }

    /// <summary>Builds the configured CLI application.</summary>
    public static CliApp Build()
    {
        var options = new GlobalOptionsBinder();
        var root = BuildRoot(options);
        return new CliApp(root, options);
    }

    /// <summary>Runs the configured CLI against the supplied arguments.</summary>
    public Task<int> RunAsync(string[] args)
    {
        return RunAsync(args, CancellationToken.None);
    }

    /// <summary>Runs the configured CLI against the supplied arguments with a cancellation token.</summary>
    public async Task<int> RunAsync(string[] args, CancellationToken cancellationToken)
    {
        var result = _root.Parse(args);
        var obsoleteThemeError = GetObsoleteThemeInputError(args, result);
        if (obsoleteThemeError is not null)
        {
            var json = args.Contains("--json", StringComparer.Ordinal);
            var noColor = args.Contains("--no-color", StringComparer.Ordinal);
            var verbose = args.Contains("--verbose", StringComparer.Ordinal);
            var presenter = new ConsolePresenter(noColor, verbose);
            if (json)
            {
                presenter.WriteInfo(DiscoveryService.ToJson(new
                {
                    success = false,
                    exitCode = ExitCodes.Error,
                    error = obsoleteThemeError,
                }));
            }
            else
            {
                presenter.WriteError(obsoleteThemeError);
            }

            return ExitCodes.Error;
        }

        // Keep the parser's failure exit code, but reserve raw stacks for verbose output.
        result.InvocationConfiguration.EnableDefaultExceptionHandler = false;
        int exit;
        try
        {
            exit = await result.InvokeAsync(result.InvocationConfiguration, cancellationToken).ConfigureAwait(false);
        }
        catch (InteractivePromptCancelledException)
        {
            if (!args.Contains("--json", StringComparer.Ordinal)) Console.Out.WriteLine("Cancelled. No changes made.");
            return ExitCodes.Cancelled;
        }
        catch (OperationCanceledException)
        {
            WriteCancellationMessage(args);
            return ExitCodes.Cancelled;
        }
        catch (Exception exception)
        {
            ConsoleDiagnostics.Unexpected(new ConsolePresenter(args.Contains("--no-color", StringComparer.Ordinal),
                args.Contains("--verbose", StringComparer.Ordinal), args.Contains("--json", StringComparer.Ordinal)), exception, args);
            return ExitCodes.Error;
        }

        // System.CommandLine swallows OperationCanceledException and returns a
        // generic error code; surface cancellation as the conventional 130 so
        // Ctrl+C exits safely and predictably regardless of the parser's choice.
        if (cancellationToken.IsCancellationRequested)
        {
            WriteCancellationMessage(args);
            return ExitCodes.Cancelled;
        }

        return exit;
    }

    private static void WriteCancellationMessage(IReadOnlyList<string> args)
    {
        if (!args.Contains("--json", StringComparer.Ordinal))
        {
            System.Console.Out.WriteLine("The operation was canceled.");
        }
    }

    private static string? GetObsoleteThemeInputError(IReadOnlyList<string> args, ParseResult parseResult)
    {
        var commandIndex = 0;
        while (commandIndex < args.Count
            && args[commandIndex].StartsWith("-", StringComparison.Ordinal))
        {
            commandIndex++;
        }

        if (commandIndex == args.Count
            || !args[commandIndex].Equals("new", StringComparison.OrdinalIgnoreCase)
            || !args.Any(argument => argument.Equals("--theme", StringComparison.Ordinal)
                || argument.StartsWith("--theme=", StringComparison.Ordinal)))
        {
            return null;
        }

        if (Commands.Desktop.DesktopCommands.Provider(parseResult, NewCommand.FrameworkArg) is not null) return null;
        return "The --theme option is no longer supported."
            + $"{Environment.NewLine}{Environment.NewLine}Create a project with the native MAUI appearance:"
            + $"{Environment.NewLine}  sfdotnet new maui -n MyApp"
            + $"{Environment.NewLine}{Environment.NewLine}Customize the project after creation using .NET MAUI resources.";
    }

    private static RootCommand BuildRoot(GlobalOptionsBinder options)
    {
        var root = new RootCommand("Syncfusion .NET CLI - create and manage MAUI and Windows desktop projects.");

        // Replace the auto-added --version action so the version always comes
        // from CliMetadata (the CLI assembly), not the host process. This keeps
        // `sfdotnet --version` correct when run as a tool and during in-process tests.
        OverrideVersionAction(root);

        foreach (var option in options.All())
        {
            root.Add(option);
        }

        // Register the Phase 2 commands. Each parses arguments, validates
        // input, builds a request, and reports the result (execution is a
        // later phase). Global options are added to each subcommand so they
        // are recognized everywhere (System.CommandLine 2.0 does not inherit
        // root options into subcommands).
        Command[] subcommands =
        [
            NewCommand.Create(),
            AddCommand.Create(),
            // Improvement: Remove package from existing project is temporarily disabled for all platforms.
            // RemoveCommand.Create(),
            UpdateCommand.Create(),
            ListCommand.Create(),
            SearchCommand.Create(),
            AiCommands.CreateMcp(),
            AiCommands.CreateSkills(),
            InfoCommand.Create(),
            HelpCommand.Create(),
            .. Commands.License.LicenseCommands.Create(),
        ];

        foreach (var subcommand in subcommands)
        {
            foreach (var option in options.All())
            {
                subcommand.Add(option);
            }

            foreach (var nested in subcommand.Subcommands)
            {
                foreach (var option in options.All())
                {
                    nested.Add(option);
                }
            }

            root.Add(subcommand);
        }

        root.SetAction(async (parseResult, cancellationToken) =>
        {
            // Built-in --help/--version are handled before this action runs.
            var parsed = options.Bind(parseResult);
            var presenter = new ConsolePresenter(parsed.NoColor, parsed.Verbose);

            // Bare `sfdotnet` with no subcommand: show the interactive menu or help.
            if (parsed.IsInteractiveEffective)
            {
                var menu = new InteractiveMenu(presenter);
                return await menu.RunAsync(parsed, cancellationToken).ConfigureAwait(false);
            }

            if (parsed.Json)
            {
                presenter.WriteInfo(DiscoveryService.ToJson(new
                {
                    interactive = false,
                    hint = "Run 'sfdotnet help' for command reference.",
                }));
            }
            else
            {
                presenter.WriteInfo("Run 'sfdotnet help' to see available commands, or run 'sfdotnet' without arguments for interactive mode.");
            }
            return ExitCodes.Success;
        });

        return root;
    }

    private static void OverrideVersionAction(RootCommand root)
    {
        foreach (var option in root.Options.OfType<Option>())
        {
            if (option.Name == "--version")
            {
                option.Action = new VersionAction();
            }
            else if (option.Name == "--help")
            {
                option.Action = new RootHelpAction();
            }
        }
    }

    // Exposed for tests.
    internal RootCommand Root => _root;
    internal GlobalOptionsBinder Options => _options;
}
