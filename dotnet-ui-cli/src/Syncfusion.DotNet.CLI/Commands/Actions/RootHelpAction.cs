using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Help;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Presentation;

namespace Syncfusion.DotNet.CLI.Commands.Actions;

/// <summary>Displays the root help text with the selected console options.</summary>
internal sealed class RootHelpAction : SynchronousCommandLineAction
{
    public override int Invoke(ParseResult parseResult)
    {
        if (parseResult.CommandResult.Command is not RootCommand)
            return new HelpAction().Invoke(parseResult);

        var presenter = new ConsolePresenter(
            parseResult.GetValue<bool>("--no-color"),
            parseResult.GetValue<bool>("--verbose"));
        presenter.WriteInfo(HelpCommand.RootHelp);
        return ExitCodes.Success;
    }
}
