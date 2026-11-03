using System.Globalization;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Character editing shared by project names, paths and confirmations.</summary>
internal sealed class TextInputBuffer
{
    internal string Value { get; private set; } = string.Empty;
    internal int Cursor { get; private set; }
    internal int Anchor { get; private set; }
    internal bool HasSelection => Cursor != Anchor;
    internal int SelectionStart => Math.Min(Cursor, Anchor);
    internal int SelectionEnd => Math.Max(Cursor, Anchor);

    internal void Edit(ConsoleKeyInfo key, string? defaultValue)
    {
        var control = key.Modifiers.HasFlag(ConsoleModifiers.Control);
        var shift = key.Modifiers.HasFlag(ConsoleModifiers.Shift);
        if (control && key.Key == ConsoleKey.A) { if (Value.Length == 0 && defaultValue is not null) Value = defaultValue; Anchor = 0; Cursor = Value.Length; return; }
        if (key.Key is ConsoleKey.LeftArrow or ConsoleKey.RightArrow or ConsoleKey.Home or ConsoleKey.End)
        {
            // Defaults remain hints until editing is requested; Enter still accepts them.
            if (Value.Length == 0 && defaultValue is not null) { Value = defaultValue; Cursor = Anchor = Value.Length; }
            var boundaries = StringInfo.ParseCombiningCharacters(Value).Append(Value.Length).ToArray();
            Cursor = key.Key switch
            {
                ConsoleKey.Home => 0,
                ConsoleKey.End => Value.Length,
                ConsoleKey.LeftArrow => !shift && HasSelection ? SelectionStart : boundaries.LastOrDefault(index => index < Cursor),
                _ => !shift && HasSelection ? SelectionEnd : boundaries.FirstOrDefault(index => index > Cursor, Value.Length),
            };
            if (!shift) Anchor = Cursor;
            return;
        }
        if (key.Key is ConsoleKey.Backspace or ConsoleKey.Delete)
        {
            if (!HasSelection)
            {
                var boundaries = StringInfo.ParseCombiningCharacters(Value).Append(Value.Length).ToArray();
                if (key.Key == ConsoleKey.Backspace) Anchor = boundaries.LastOrDefault(index => index < Cursor);
                else Anchor = boundaries.FirstOrDefault(index => index > Cursor, Value.Length);
            }
            ReplaceSelection(string.Empty);
        }
        else if (!control && !char.IsControl(key.KeyChar)) ReplaceSelection(key.KeyChar.ToString());
    }

    private void ReplaceSelection(string text)
    {
        var start = SelectionStart;
        Value = Value[..start] + text + Value[SelectionEnd..];
        Cursor = Anchor = start + text.Length;
    }
}
