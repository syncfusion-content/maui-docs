using Syncfusion.DotNet.CLI.Commands.Desktop;
using Syncfusion.DotNet.CLI.Blazor;
using System.CommandLine;
using System.Linq;
using Syncfusion.DotNet.CLI.Commands.Options;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;

namespace Syncfusion.DotNet.CLI.Commands;

/// <summary>Renders the concise implemented command map.</summary>
public static class HelpCommand
{
    // Improvement: Remove package from existing project is temporarily disabled for all platforms.
    // sf remove <platform> <package> -p <project>

    public static Command Create()
    {
        var topic = CommandOptions.OptionalArg("topic", "Help topic: maui, blazor, wpf, winforms or winui.");
        var command = new Command("help", "Show command help.");
        command.Add(topic);
        command.SetAction(parseResult =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parseResult);
            var value = parseResult.GetValue<string?>("topic");
            return Execute(presenter, value);
        });
        return command;
    }

    internal static int Execute(ConsolePresenter presenter, string? topic)
    {
        if (string.Equals(topic, "blazor", StringComparison.OrdinalIgnoreCase))
        {
            presenter.WriteInfo(BlazorHelp);
            return ExitCodes.Success;
        }
        if (DesktopProviders.Find(topic) is { } desktop)
        {
            var name = Frameworks.Name(desktop.Platform);
            presenter.WriteInfo($"{desktop.DisplayName} commands\n  sf new {name} -n MyApp --language C# --target-framework net10.0 --control chart datagrid\n  sf add {name} <package> -p <project>\n  sf update {name} <package> -p <project>\n  sf list {name} packages\n  sf list {name} installed -p <project>\n  sf search <query> --framework {name}\nThemes: {string.Join(", ", desktop.Themes.Select(theme => theme.Name))}\nLanguages: {string.Join(", ", desktop.Languages)}\nTarget frameworks: {string.Join(", ", desktop.TargetFrameworks)}\nUse --post-action generate --no-restore for file generation without Windows build prerequisites.\n\n{AliasSection(desktop.Packages.Select(package => package.Alias))}\n\n{HelpLayout.PackageOptions(HelpLayout.ConsoleWidth, includeForce: false)}");
            return ExitCodes.Success;
        }
        if (!string.IsNullOrWhiteSpace(topic)
            && !string.Equals(topic, "maui", StringComparison.OrdinalIgnoreCase))
        {
            presenter.WriteError($"Unknown help topic '{topic}'. Available topics: maui, blazor, wpf, winforms, winui.");
            return ExitCodes.Error;
        }

        presenter.WriteInfo(string.Equals(topic, "maui", StringComparison.OrdinalIgnoreCase)
            ? MauiHelp
            : RootHelp);
        return ExitCodes.Success;
    }

    internal const string RootHelp = """
        Syncfusion .NET CLI

        Usage: sf <action> <platform> <target> [options]

        Supported platforms: MAUI, WPF, WinForms, WinUI, Blazor

        Commands:
          sf help                             Show general help
          sf help maui                        Show the complete MAUI command map
          sf help blazor                      Show the complete Blazor command map
          sf new maui                         Create an empty MAUI project
          sf new blazor                       Create a Blazor project
          sf add maui <package>               Add a NuGet package
          sf update maui <package>            Update a NuGet package
          sf list maui <category>             List packages or installed packages
          sf search maui <text>                Search the MAUI package catalog
          sf info                              Show CLI information
          sf --version                         Show the CLI version

        Run 'sf help <platform>' for maui, blazor, wpf, winforms or winui command help.
        Options: --json, --verbose, --no-color, --interactive, --no-interactive.
        """;

    internal static string BlazorHelp => $$"""
        Blazor commands

        Project
          sf new blazor -n MyApp
          sf new blazor --app-type web-app --render-mode server --control grid
          sf new blazor --app-type webassembly-standalone --auth none --control grid charts

        Packages
          sf add blazor grid -p <project>
          sf update blazor grid -p <project>
          sf list blazor packages
          sf list blazor installed -p <project>
          sf search grid --framework blazor

        Application types: web-app, webassembly-standalone
        Render modes (web-app): server, webassembly, auto
        Themes: {{string.Join(", ", BlazorCatalog.Themes.Select(theme => theme.DisplayName))}}
        Target frameworks are read from the installed official Microsoft template.
        File Manager uses Syncfusion's hosted physical-file demo service; replace it with your own backend before production use.

        {{AliasSection(BlazorCatalog.Packages.Select(package => package.Alias))}}

        {{HelpLayout.PackageOptions(HelpLayout.ConsoleWidth, includeForce: false)}}
        """;

    internal static string MauiHelp => $$"""
        MAUI commands

        Project
          sf new maui -n MyApp
          sf new maui -n MyApp --control datagrid
          sf new maui -n MyApp --control datagrid listview
          sf new maui -n MyApp --control cartesian-chart circular-chart

        Packages
          sf add maui datagrid
          sf add maui inputs
          sf add maui Syncfusion.Maui.DataGrid -v <version>
          sf update maui datagrid

        {{AliasSection(PackageCatalog.All.Select(package => package.Alias))}}

        Package commands accept these aliases or exact Syncfusion.Maui.* package IDs.
        Package operations change NuGet package references only. Creating
        generated Syncfusion controls is separate from package add/update.

        Discovery and information
          sf list maui packages
          sf list maui packages --search grid
          sf list maui packages --details
          sf list maui installed
          sf search maui datagrid
          sf info
          sf --version

        {{HelpLayout.PackageOptions(HelpLayout.ConsoleWidth, includeForce: true)}}
        """;

    private static string AliasSection(IEnumerable<string> aliases)
        => "Available package aliases:\n" + string.Join('\n', HelpLayout.Aliases(aliases, HelpLayout.ConsoleWidth));
}
