using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.CLI.Commands.Operations;
using Syncfusion.DotNet.CLI.Commands.Options;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Presentation;

namespace Syncfusion.DotNet.CLI.Commands;

/// <summary>Defines the <c>sf info</c> command.</summary>
public static class InfoCommand
{
    public static Command Create()
    {
        var command = new Command("info", "Show Syncfusion CLI information.");

        command.SetAction(parseResult =>
        {
            var presenter = GlobalsHelper.CreatePresenter(parseResult);
            var globals = GlobalsHelper.Bind(parseResult);
            return Execute(presenter, globals);
        });

        return command;
    }

    internal static int Execute(ConsolePresenter presenter, GlobalOptions globals)
    {
        var info = DiscoveryService.GetInfo();
        if (globals.Json)
        {
            presenter.WriteInfo(DiscoveryService.ToJson(info));
            return ExitCodes.Success;
        }

        presenter.WriteInfo($"Syncfusion .NET CLI {info.CliVersion}");
        foreach (var row in SummaryRows.Format(new (string Label, string Value)[]
        {
            ("Package ID:", info.PackageId),
            ("Tool command:", info.ToolCommand),
            ("Supported platforms:", string.Join(", ", info.SupportedPlatforms)),
            ("Available commands:", string.Join(", ", info.AvailableCommands)),
            ("Documentation:", info.DocumentationLocation),
        })) presenter.WriteInfo(row);
        presenter.WriteVerbose($"MAUI catalog version: {info.MauiCatalogVersion}; Manifest schema version: {info.ManifestSchemaVersion}");
        return ExitCodes.Success;
    }
}
