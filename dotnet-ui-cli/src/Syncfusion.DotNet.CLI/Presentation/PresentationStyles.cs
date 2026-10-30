using Spectre.Console;

namespace Syncfusion.DotNet.Cli.Presentation;

internal static class PresentationStyles
{
    internal const string AnswerBlue = "#3675D5";
    internal static readonly Style Answer = new(Color.FromHex(AnswerBlue), decoration: Decoration.Bold);
    internal static readonly Style Selection = new(decoration: Decoration.Invert | Decoration.Bold);
}
