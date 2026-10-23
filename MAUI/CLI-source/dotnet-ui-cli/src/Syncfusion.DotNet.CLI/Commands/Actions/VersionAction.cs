using System.CommandLine;
using System.CommandLine.Invocation;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Presentation;

namespace Syncfusion.DotNet.CLI.Commands.Actions;

/// <summary>
/// A <see cref="SynchronousCommandLineAction"/> that prints the CLI version
/// from <see cref="CliMetadata"/>. Used to override the default
/// <c>--version</c> behavior so the reported version always reflects the CLI
/// assembly, not the host process (important for in-process tests and for
/// tools launched through a shim).
/// </summary>
internal sealed class VersionAction : SynchronousCommandLineAction
{
    public override int Invoke(ParseResult parseResult)
    {
        var noColor = parseResult.GetValue<bool>("--no-color");
        var verbose = parseResult.GetValue<bool>("--verbose");
        var presenter = new ConsolePresenter(noColor, verbose);
        if (parseResult.GetValue<bool>("--json"))
        {
            presenter.WriteInfo(DiscoveryService.ToJson(new
            {
                packageId = "Syncfusion.DotNet.CLI",
                toolCommand = "sf",
                cliVersion = CliMetadata.Version,
            }));
        }
        else
        {
            presenter.WriteVersion(CliMetadata.Version);
        }
        return ExitCodes.Success;
    }
}
