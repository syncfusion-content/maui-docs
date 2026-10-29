using Spectre.Console;

namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>
/// Shown when the browser could not be opened automatically: a short clickable link where the terminal supports
/// hyperlinks, otherwise the full URL on its own line so it can still be copied.
/// </summary>
internal static class SignInLink
{
    internal const string LinkText = "Open Syncfusion sign-in";

    internal static void Show(string url, bool noColor, IAnsiConsole? console = null)
    {
        console ??= AnsiConsole.Console;
        console.WriteLine("Could not open the browser automatically.");
        if (!noColor && console.Profile.Capabilities.Ansi && console.Profile.Capabilities.Links && !Console.IsOutputRedirected)
            console.MarkupLine($"[link={Markup.Escape(url)}]{LinkText}[/]");
        else
        {
            console.WriteLine("Open this URL to sign in:");
            console.Profile.Out.Writer.WriteLine(url);
        }
        console.WriteLine();
    }
}
