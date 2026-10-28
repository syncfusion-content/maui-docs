using Spectre.Console;

namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>Single-choice data rendered by the shared wizard with a bottom help block.</summary>
internal sealed class WizardSelectionPrompt<T> where T : notnull
{
    public string? Title { get; set; }
    public int PageSize { get; set; } = 10;
    public bool WrapAround { get; set; }
    public Style? HighlightStyle { get; set; }
    public string? MoreChoicesText { get; set; }
    public Func<T>? CancelResult { get; set; }
    public Func<T, string>? Converter { get; set; }
    public T? DefaultValue { get; set; }
    public List<T> Choices { get; } = [];
    public void AddChoices(IEnumerable<T> choices) => Choices.AddRange(choices);
    public void AddChoices(params T[] choices) => Choices.AddRange(choices);
}
