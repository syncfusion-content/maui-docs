namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// Well-known process exit codes used throughout the CLI. Keeping them in one
/// place keeps behavior consistent between interactive and non-interactive
/// paths and makes them easy to assert in tests.
/// </summary>
public static class ExitCodes
{
    /// <summary>The command completed successfully.</summary>
    public const int Success = 0;

    /// <summary>General usage or runtime error.</summary>
    public const int Error = 1;

    /// <summary>The user cancelled the operation (Ctrl+C, Escape in a menu, or SIGINT).</summary>
    public const int Cancelled = 130;

    /// <summary>An internal, unhandled exception occurred.</summary>
    public const int Unhandled = 70;
}
