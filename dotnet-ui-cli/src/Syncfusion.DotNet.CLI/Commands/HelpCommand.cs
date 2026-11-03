using Syncfusion.DotNet.Cli.Commands.Desktop;
using Syncfusion.DotNet.Cli.Blazor;
using System.CommandLine;
using System.Linq;
using Syncfusion.DotNet.Cli.Commands.Options;
using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;
using Syncfusion.DotNet.Cli.Presentation;

namespace Syncfusion.DotNet.Cli.Commands;

/// <summary>Renders the concise implemented command map.</summary>
public static class HelpCommand
{
    // Improvement: Remove package from existing project is temporarily disabled for all platforms.
    // sfdotnet remove <platform> <package> -p <project>

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
            presenter.WriteInfo($"{desktop.DisplayName} commands\n  sfdotnet new {name} -n MyApp --language C# --target-framework net10.0 --control chart datagrid\n  sfdotnet add {name} <package> -p <project>\n  sfdotnet update {name} <package> -p <project>\n  sfdotnet list {name} packages\n  sfdotnet list {name} installed -p <project>\n  sfdotnet search <query> --framework {name}\nThemes: {string.Join(", ", desktop.Themes.Select(theme => theme.Name))}\nLanguages: {string.Join(", ", desktop.Languages)}\nTarget frameworks: {string.Join(", ", desktop.TargetFrameworks)}\nUse --post-action generate --no-restore for file generation without Windows build prerequisites.\n\n{AliasSection(desktop.Packages.Select(package => package.Alias))}\n\n{HelpLayout.PackageOptions(HelpLayout.ConsoleWidth, includeForce: false)}");
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

        Usage: sfdotnet <action> <platform> <target> [options]

        Supported platforms: MAUI, WPF, WinForms, WinUI, Blazor

        Commands:
          sfdotnet help                             Show general help
          sfdotnet help maui                        Show the complete MAUI command map
          sfdotnet help blazor                      Show the complete Blazor command map
          sfdotnet new maui                         Create an empty MAUI project
          sfdotnet new blazor                       Create a Blazor project
          sfdotnet add maui <package>               Add a NuGet package
          sfdotnet update maui <package>            Update a NuGet package
          sfdotnet list maui <category>             List packages or installed packages
          sfdotnet search maui <text>                Search the MAUI package catalog
          sfdotnet mcp init <platform>              Configure an MCP client
          sfdotnet skills install <platform>        Install component skills for AI agents
          sfdotnet info                              Show CLI information
          sfdotnet --version                         Show the CLI version

        Run 'sfdotnet help <platform>' for maui, blazor, wpf, winforms or winui command help.
        AI setup: 'sfdotnet mcp init --help' and 'sfdotnet skills install --help'.
        Options: --json, --verbose, --no-color, --interactive, --no-interactive.
        """;

    internal static string BlazorHelp => $$"""
        Blazor commands

        Project
          sfdotnet new blazor -n MyApp
          sfdotnet new blazor --app-type web-app --render-mode server --control grid
          sfdotnet new blazor --app-type webassembly-standalone --auth none --control grid charts

        Packages
          sfdotnet add blazor grid -p <project>
          sfdotnet update blazor grid -p <project>
          sfdotnet list blazor packages
          sfdotnet list blazor installed -p <project>
          sfdotnet search grid --framework blazor

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
          sfdotnet new maui -n MyApp
          sfdotnet new maui -n MyApp --control datagrid
          sfdotnet new maui -n MyApp --control datagrid listview
          sfdotnet new maui -n MyApp --control cartesian-chart circular-chart

        Packages
          sfdotnet add maui datagrid
          sfdotnet add maui inputs
          sfdotnet add maui Syncfusion.Maui.DataGrid -v <version>
          sfdotnet update maui datagrid

        {{AliasSection(PackageCatalog.All.Where(package => package.SupportsPackageReference).Select(package => package.Alias))}}

        Package commands accept these aliases or exact Syncfusion.Maui.* package IDs.
        Package operations change NuGet package references only. Creating
        generated Syncfusion controls is separate from package add/update.

        Discovery and information
          sfdotnet list maui packages
          sfdotnet list maui packages --search grid
          sfdotnet list maui packages --details
          sfdotnet list maui installed
          sfdotnet search maui datagrid
          sfdotnet info
          sfdotnet --version

        {{HelpLayout.PackageOptions(HelpLayout.ConsoleWidth, includeForce: true)}}
        """;

    private static string AliasSection(IEnumerable<string> aliases)
        => "Available package aliases:\n" + string.Join('\n', HelpLayout.Aliases(aliases, HelpLayout.ConsoleWidth));
}
