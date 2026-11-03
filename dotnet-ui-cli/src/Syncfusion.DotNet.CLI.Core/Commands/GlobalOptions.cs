namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// The values of the global options that apply to every command. Populated by
/// the command-line parser and threaded through to presenters and commands.
/// </summary>
public sealed class GlobalOptions
{
    /// <summary>Whether the command may show interactive prompts. Default is on when stdin is a TTY.</summary>
    public bool Interactive { get; set; } = true;

    /// <summary>Whether interactive prompts are explicitly disabled.</summary>
    public bool NoInteractive { get; set; }

    /// <summary>Emit machine-readable JSON instead of human-readable output.</summary>
    public bool Json { get; set; }

    /// <summary>Print detailed diagnostic output.</summary>
    public bool Verbose { get; set; }

    /// <summary>Disable colored output in the terminal.</summary>
    public bool NoColor { get; set; }

    /// <summary>Whether this interactive flow collected input and requires a review.</summary>
    public bool RequiresReview { get; set; }

    /// <summary>Resolves the effective interactivity setting, honoring <c>--no-interactive</c>.</summary>
    public bool IsInteractiveEffective
        => Interactive && !NoInteractive;
}
