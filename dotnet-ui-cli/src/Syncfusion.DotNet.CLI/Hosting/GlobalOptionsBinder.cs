using System.CommandLine;
using System.CommandLine.Parsing;
using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Hosting;

/// <summary>
/// Declares the global options that apply to every command and binds parsed
/// values into a <see cref="GlobalOptions"/> instance. The built-in
/// <c>--help</c>/<c>-h</c> and <c>--version</c> options are provided by
/// <see cref="RootCommand"/> automatically; only the Syncfusion-specific
/// global options are declared here.
/// </summary>
public sealed class GlobalOptionsBinder
{
    public Option<bool> InteractiveOption { get; } = Create("--interactive", "Allow interactive prompts (default when stdin is a terminal).");

    public Option<bool> NoInteractiveOption { get; } = Create("--no-interactive", "Disable interactive prompts; fail instead of prompting.");

    public Option<bool> JsonOption { get; } = Create("--json", "Emit machine-readable JSON output.");

    public Option<bool> VerboseOption { get; } = Create("--verbose", "Print detailed diagnostic output.");

    public Option<bool> NoColorOption { get; } = Create("--no-color", "Disable colored terminal output.");

    /// <summary>All option symbols, in a stable order for registration.</summary>
    public IEnumerable<Option<bool>> All()
    {
        yield return InteractiveOption;
        yield return NoInteractiveOption;
        yield return JsonOption;
        yield return VerboseOption;
        yield return NoColorOption;
    }

    /// <summary>Reads the parsed values into a <see cref="GlobalOptions"/> snapshot.</summary>
    public GlobalOptions Bind(ParseResult result)
    {
        var noInteractive = result.GetValue(NoInteractiveOption);
        var interactive = result.GetValue(InteractiveOption);
        return new GlobalOptions
        {
            // Interactive defaults to on unless --no-interactive is set.
            Interactive = interactive || !noInteractive,
            NoInteractive = noInteractive,
            Json = result.GetValue(JsonOption),
            Verbose = result.GetValue(VerboseOption),
            NoColor = result.GetValue(NoColorOption),
        };
    }

    private static Option<bool> Create(string name, string description)
    {
        var option = new Option<bool>(name);
        option.Description = description;
        return option;
    }
}
