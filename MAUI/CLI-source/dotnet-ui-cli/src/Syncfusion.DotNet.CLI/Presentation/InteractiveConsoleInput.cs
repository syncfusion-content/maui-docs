using System.Text;
using System.Runtime.ExceptionServices;
using Spectre.Console;
using Spectre.Console.Rendering;
using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Presentation;

internal sealed class InteractiveConsoleInput
{
    // Muted hints share one style; active selections use the wizard accent.
    internal const string DimHex = "#8B949E";
    internal static readonly Style DimStyle = new(foreground: Color.FromHex(DimHex));

    private readonly IAnsiConsole _console;
    private readonly IAnsiConsole _answerConsole;
    private readonly Func<CancellationToken, Task<ConsoleKeyInfo?>> _readKeyAsync;
    private readonly bool _noColor;

    private int _inputCursorRow;
    private int _inputCursorColumn;
    private int _inputScreenHeight;

    internal bool LastUsedDefault { get; private set; }

    public InteractiveConsoleInput(IAnsiConsole console, bool noColor = false)
        : this(
            console,
            async token => await console.Input.ReadKeyAsync(intercept: true, token).ConfigureAwait(false),
            noColor)
    {
    }

    /// <summary>
    /// Convenience constructor that uses <see cref="AnsiConsole.Console"/> as
    /// the backing <see cref="IAnsiConsole"/>. The text-entry loop reads
    /// keystrokes from this console, and the selection-prompt helpers
    /// render to it.
    /// </summary>
    public InteractiveConsoleInput(bool noColor)
        : this(AnsiConsole.Console, noColor)
    {
    }

    /// <summary>
    /// Convenience constructor that uses <see cref="AnsiConsole.Console"/>
    /// with colour enabled. Equivalent to <c>new InteractiveConsoleInput(false)</c>.
    /// </summary>
    public InteractiveConsoleInput()
        : this(AnsiConsole.Console, noColor: false)
    {
    }

    internal InteractiveConsoleInput(
        IAnsiConsole console,
        Func<CancellationToken, Task<ConsoleKeyInfo?>> readKeyAsync,
        bool noColor = false)
    {
        _answerConsole = console;
        _noColor = !ColorPolicy.AllowsLive(console, noColor);
        _console = _noColor ? new PlainPromptConsole(console) : console;
        _readKeyAsync = readKeyAsync;
    }

    public string? ReadLine(
        string prompt,
        string? defaultValue,
        CancellationToken cancellationToken = default,
        string? dimSuffix = null,
        string? guidance = null,
        bool compactDefault = false,
        string? resultLabel = null,
        bool retainAnswer = true)
    {
        cancellationToken.ThrowIfCancellationRequested();
        using var cursorScope = new TerminalCursorScope(_answerConsole, !_noColor);
        _inputScreenHeight = 0;
        var value = new TextInputBuffer();
        string? result = null;
        var completed = false;
        // Clear active hints on completion, then retain exactly one answer line.
        var display = _console.Live(CreateScreen(prompt, dimSuffix, value, defaultValue, guidance, compactDefault))
            .AutoClear(!_noColor);

        display.Start(context =>
        {
            context.Refresh();
            while (!completed)
            {
                cancellationToken.ThrowIfCancellationRequested();
                ConsoleKeyInfo key;
                if (!_noColor)
                    _console.WriteAnsi(writer =>
                    {
                        if (_inputScreenHeight - 1 > _inputCursorRow) writer.CursorUp(_inputScreenHeight - 1 - _inputCursorRow);
                        writer.CursorHorizontalAbsolute(_inputCursorColumn + 1);
                        writer.ShowCursor();
                    });
                try
                {
                    key = _readKeyAsync(cancellationToken).GetAwaiter().GetResult()
                        ?? throw new IOException("Input ended while reading an interactive value.");
                }
                finally
                {
                    if (!_noColor) _console.WriteAnsi(writer =>
                    {
                        writer.HideCursor();
                        if (_inputScreenHeight - 1 > _inputCursorRow) writer.CursorDown(_inputScreenHeight - 1 - _inputCursorRow);
                        writer.CursorHorizontalAbsolute(1);
                    });
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    completed = true;
                    continue;
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    LastUsedDefault = value.Value.Length == 0;
                    result = value.Value.Length == 0 ? defaultValue ?? string.Empty : value.Value;
                    completed = true;
                    continue;
                }

                if (key.Key == ConsoleKey.C && key.Modifiers.HasFlag(ConsoleModifiers.Control))
                    throw new OperationCanceledException(cancellationToken);
                value.Edit(key, defaultValue);

                context.UpdateTarget(CreateScreen(prompt, dimSuffix, value, defaultValue, guidance, compactDefault));
                context.Refresh();
            }
        });

        if (result is not null && retainAnswer)
        {
            ProjectWizardOutput.WriteCompletedValue(_answerConsole, (resultLabel ?? prompt.TrimEnd(':', '?')) + ":", result, _noColor, alignValues: compactDefault);
        }
        return result;
    }

    /// <summary>Keeps the title, guidance, and options inside Spectre's temporary prompt region.</summary>
    public T PromptSingle<T>(WizardSelectionPrompt<T> prompt, CancellationToken cancellationToken,
        string resultLabel = "Selection", bool showGuidance = true, Func<T, string>? resultFormatter = null, bool retainAnswer = true, Func<T, bool>? retainAnswerWhen = null)
        where T : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();
        if (prompt.Choices.Count == 0) throw new InvalidOperationException("No choices are available.");
        using var cursorScope = new TerminalCursorScope(_answerConsole, !_noColor);
        var focus = Math.Max(0, prompt.Choices.FindIndex(item => EqualityComparer<T>.Default.Equals(item, prompt.DefaultValue)));
        var pageSize = Math.Max(1, Math.Min(prompt.PageSize, _console.Profile.Height - 7));
        IRenderable Render()
        {
            var start = Math.Clamp(focus - pageSize + 1, 0, Math.Max(0, prompt.Choices.Count - pageSize));
            var rows = new List<IRenderable>();
            if (prompt.Title is not null) rows.Add(new Text(Markup.Remove(prompt.Title)));
            rows.Add(new Text(""));
            rows.AddRange(prompt.Choices.Skip(start).Take(pageSize).Select((item, index) =>
                (IRenderable)new Text((start + index == focus ? "> " : "  ")
                    + Markup.Remove(prompt.Converter?.Invoke(item) ?? item.ToString() ?? string.Empty),
                    start + index == focus && !_noColor ? Wizard.InteractivePrompt.SelectionStyle : Style.Plain)));
            if (showGuidance)
            {
                rows.Add(new Text(""));
                rows.Add(new Text(TerminalPresentation.Symbols(Wizard.InteractivePrompt.SingleSelectionGuidance, _console),
                    _noColor ? Style.Plain : DimStyle));
            }
            return new Rows(rows);
        }
        _console.Live(Render()).AutoClear(!_noColor).Start(context =>
        {
            while (true)
            {
                context.Refresh();
                cancellationToken.ThrowIfCancellationRequested();
                var key = _readKeyAsync(cancellationToken).GetAwaiter().GetResult()
                    ?? throw new IOException("Input ended while awaiting a selection.");
                if (key.Key == ConsoleKey.Escape) throw new Wizard.InteractivePromptCancelledException();
                if (key.Key == ConsoleKey.C && key.Modifiers.HasFlag(ConsoleModifiers.Control))
                    throw new OperationCanceledException(cancellationToken);
                if (key.Key is ConsoleKey.Enter or ConsoleKey.Spacebar) break;
                var next = key.Key switch
                {
                    ConsoleKey.UpArrow => focus - 1,
                    ConsoleKey.DownArrow => focus + 1,
                    ConsoleKey.Home => 0,
                    ConsoleKey.End => prompt.Choices.Count - 1,
                    ConsoleKey.PageUp => Math.Max(0, focus - pageSize),
                    ConsoleKey.PageDown => Math.Min(prompt.Choices.Count - 1, focus + pageSize),
                    _ => focus,
                };
                focus = prompt.WrapAround ? (next + prompt.Choices.Count) % prompt.Choices.Count
                    : Math.Clamp(next, 0, prompt.Choices.Count - 1);
                context.UpdateTarget(Render());
            }
        });
        var choice = prompt.Choices[focus];
        var display = resultFormatter?.Invoke(choice)
            ?? Markup.Remove(prompt.Converter?.Invoke(choice) ?? choice.ToString() ?? string.Empty);
        if (retainAnswer && (retainAnswerWhen?.Invoke(choice) ?? true)) WriteResult(resultLabel, display);
        return choice;
    }

    /// <summary>Clears a completed multi-select and retains one result containing its selected labels.</summary>
    public List<T> PromptMultiple<T>(MultiSelectionPrompt<T> prompt, CancellationToken cancellationToken,
        string resultLabel = "Controls") where T : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();
        prompt.HighlightStyle = _noColor ? new Style(decoration: Decoration.Bold) : Wizard.InteractivePrompt.SelectionStyle;
        var instructions = prompt.InstructionsText;
        var moreChoices = prompt.MoreChoicesText;
        var cancel = prompt.CancelResult;
        try
        {
            prompt.CancelResult ??= () => throw new Wizard.InteractivePromptCancelledException();
            prompt.InstructionsText = HintMarkup(Wizard.InteractivePrompt.MultiSelectionGuidance);
            prompt.MoreChoicesText = string.Empty;
            var choices = RunSelection(prompt, cancellationToken);
            WriteResult(resultLabel, string.Join(", ", choices.Select(choice =>
                prompt.Converter is not null ? Markup.Remove(prompt.Converter(choice)) : choice.ToString() ?? string.Empty)));
            return choices;
        }
        finally
        {
            prompt.InstructionsText = instructions;
            prompt.MoreChoicesText = moreChoices;
            prompt.CancelResult = cancel;
        }
    }

    internal void WriteResult(string label, string value, bool alignValues = false) => ProjectWizardOutput.WriteCompletedValue(_answerConsole, label + ":", value, _noColor, alignValues);

    private string HintMarkup(string hint)
        => _noColor ? Markup.Escape(TerminalPresentation.Symbols(hint, _console)) : $"[{DimHex}]{Markup.Escape(TerminalPresentation.Symbols(hint, _console))}[/]";

    private T RunSelection<T>(IPrompt<T> prompt, CancellationToken cancellationToken)
    {
        using var cursorScope = new TerminalCursorScope(_answerConsole, !_noColor);
        // Spectre clears its region after Escape, but not if ReadKeyAsync throws.
        // Defer input cancellation/errors until that normal cleanup has completed.
        var input = new CompletingPromptInput(_readKeyAsync, cancellationToken);
        try
        {
            return prompt.ShowAsync(new PromptConsole(_console, input), CancellationToken.None).GetAwaiter().GetResult();
        }
        finally
        {
            input.Failure?.Throw();
        }
    }

    private sealed class CompletingPromptInput(
        Func<CancellationToken, Task<ConsoleKeyInfo?>> readKey, CancellationToken cancellationToken) : IAnsiConsoleInput
    {
        public ExceptionDispatchInfo? Failure { get; private set; }
        public bool IsKeyAvailable() => true;
        public ConsoleKeyInfo? ReadKey(bool intercept) => ReadKeyAsync(intercept).GetAwaiter().GetResult();
        public async Task<ConsoleKeyInfo?> ReadKeyAsync(bool intercept, CancellationToken ignored = default)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                var key = await readKey(cancellationToken).ConfigureAwait(false)
                    ?? throw new IOException("Input ended while awaiting a selection.");
                if (key.Key == ConsoleKey.C && key.Modifiers.HasFlag(ConsoleModifiers.Control))
                {
                    throw new OperationCanceledException(cancellationToken);
                }
                return key;
            }
            catch (Exception exception) when (exception is OperationCanceledException or IOException)
            {
                Failure = ExceptionDispatchInfo.Capture(exception);
                return new ConsoleKeyInfo('\0', ConsoleKey.Escape, false, false, false);
            }
        }
    }

    private sealed class PromptConsole(IAnsiConsole console, IAnsiConsoleInput input) : IAnsiConsole
    {
        public Profile Profile => console.Profile;
        public IAnsiConsoleCursor Cursor => console.Cursor;
        public IAnsiConsoleInput Input => input;
        public IExclusivityMode ExclusivityMode => console.ExclusivityMode;
        public RenderPipeline Pipeline => console.Pipeline;
        public void Clear(bool home) => console.Clear(home);
        public void Write(IRenderable renderable) => console.Write(renderable);
        public void WriteAnsi(Action<AnsiWriter> action) => console.WriteAnsi(action);
    }

    private IRenderable CreateScreen(
        string prompt,
        string? dimSuffix,
        TextInputBuffer value,
        string? defaultValue,
        string? guidance,
        bool compactDefault)
    {
        var confirmation = dimSuffix?.Contains("[Y/n]", StringComparison.OrdinalIgnoreCase) == true;
        var hint = !confirmation && defaultValue is not null ? $" [default: {defaultValue}]" : string.Empty;
        var align = !confirmation && ProjectFlowLayout.Contains(prompt) && (compactDefault || ProjectWizardOutput.IsCollecting);
        if (compactDefault && defaultValue is not null) hint = $"[{defaultValue}]";
        var prefix = (dimSuffix ?? string.Empty) + hint + " ";
        var content = prefix + value.Value + " "; // Room for the cursor at the end of a wrapped value.
        var width = Math.Max(2, _console.Profile.Width);
        var rows = new List<IRenderable>();
        var lines = align
            ? SummaryRows.FormatValues([(prompt, content)], width, ProjectFlowLayout.ValueColumn)
            : _noColor ? [(Text: prompt + content, ValueStart: 0)]
            : ProjectWizardOutput.Wrap(prompt + content, width).Select(line => (Text: line, ValueStart: 0)).ToArray();
        var cursor = prefix.Length + value.Cursor + (align ? 0 : prompt.Length);
        var selectionStart = prefix.Length + value.SelectionStart + (align ? 0 : prompt.Length);
        var selectionEnd = prefix.Length + value.SelectionEnd + (align ? 0 : prompt.Length);
        var hintEnd = (dimSuffix ?? string.Empty).Length + hint.Length + (align ? 0 : prompt.Length);
        var offset = 0;
        foreach (var row in lines)
        {
            var length = row.Text.Length - row.ValueStart;
            var hasCursor = cursor >= offset && cursor < offset + length;
            if (hasCursor)
            {
                _inputCursorRow = rows.Count;
                _inputCursorColumn = new Segment(row.Text[..(row.ValueStart + cursor - offset)]).CellCount();
            }
            var markup = new StringBuilder(Markup.Escape(row.Text[..row.ValueStart]));
            var boundaries = System.Globalization.StringInfo.ParseCombiningCharacters(row.Text).Append(row.Text.Length).ToArray();
            for (var element = 0; element < boundaries.Length - 1; element++)
            {
                var index = boundaries[element];
                if (index < row.ValueStart) continue;
                var position = offset + index - row.ValueStart;
                var character = Markup.Escape(row.Text[index..boundaries[element + 1]]);
                if (_noColor && position == cursor) markup.Append('|');
                if (!_noColor && position >= selectionStart && position < selectionEnd)
                    markup.Append("[invert]").Append(character).Append("[/]");
                else if (!_noColor && position < hintEnd && (align || position >= prompt.Length))
                    markup.Append('[').Append(DimHex).Append(']').Append(character).Append("[/]");
                else markup.Append(character);
            }
            rows.Add(_noColor ? new Text(Markup.Remove(markup.ToString())) : new Markup(markup.ToString()));
            offset += length;
        }
        if (guidance is not null)
        {
            if (_noColor) rows.Add(new Text(guidance));
            else rows.AddRange(ProjectWizardOutput.Wrap(guidance, width).Select(line => (IRenderable)new Text(line, DimStyle)));
        }
        rows.Add(new Text(""));
        rows.AddRange(ProjectWizardOutput.Wrap(Wizard.InteractivePrompt.TextEntryGuidance, width)
            .Select(line => (IRenderable)new Text(line, _noColor ? Style.Plain : DimStyle)));
        // Spectre retains the largest live-region height when the value shrinks.
        _inputScreenHeight = Math.Max(_inputScreenHeight, rows.Count);
        return new Rows(rows);
    }

    internal Wizard.MenuChoice SelectMenu(IReadOnlyList<Wizard.MenuChoice> choices, CancellationToken cancellationToken)
    {
        using var cursorScope = new TerminalCursorScope(_answerConsole, !_noColor);
        var focus = choices.ToList().FindIndex(choice => choice.Action is not null);
        var pageSize = Wizard.InteractiveMenu.CalculatePageSize(_console.Profile.Height);
        IRenderable Render()
        {
            var start = Math.Clamp(focus - pageSize + 1, 0, Math.Max(0, choices.Count - pageSize));
            var rows = new List<IRenderable> { new Text(Wizard.InteractiveMenu.MenuQuestion), new Text("") };
            rows.AddRange(choices.Skip(start).Take(pageSize).Select((choice, offset) =>
                (IRenderable)new Text((choice.Action is null ? "  " : start + offset == focus ? "  > " : "    ")
                    + Wizard.InteractiveMenu.FormatChoice(choice, _noColor),
                    choice.Action is null && !_noColor ? DimStyle : start + offset == focus && !_noColor ? Wizard.InteractivePrompt.SelectionStyle : Style.Plain)));
            rows.Add(new Text(""));
            rows.Add(new Text(TerminalPresentation.Symbols(Wizard.InteractiveMenu.MenuGuidance, _console),
                _noColor ? Style.Plain : DimStyle));
            return new Rows(rows);
        }
        _console.Live(Render()).AutoClear(!_noColor).Start(context =>
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                context.Refresh();
                var key = _readKeyAsync(cancellationToken).GetAwaiter().GetResult()
                    ?? throw new IOException("Input ended while awaiting a selection.");
                if (key.Key == ConsoleKey.Escape) throw new Wizard.InteractivePromptCancelledException();
                if (key.Key == ConsoleKey.C && key.Modifiers.HasFlag(ConsoleModifiers.Control))
                    throw new OperationCanceledException(cancellationToken);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key is ConsoleKey.UpArrow or ConsoleKey.DownArrow)
                {
                    var direction = key.Key == ConsoleKey.UpArrow ? -1 : 1;
                    do { focus = (focus + direction + choices.Count) % choices.Count; }
                    while (choices[focus].Action is null);
                    context.UpdateTarget(Render());
                }
            }
        });
        var selected = choices[focus];
        WriteResult("Action", selected.Label);
        return selected;
    }

    internal IReadOnlyList<string> SelectPackages(IReadOnlyList<PackageSelectionItem> packages, CancellationToken cancellationToken)
        => SelectControls(packages.Select(package => new ControlSelectionItem(package.Id, FormatPackageChoice(package), package.Added)).ToArray(),
            cancellationToken, "Which packages would you like to add?", Wizard.InteractivePrompt.AddControlSelectionGuidance,
            allowEmpty: packages.All(package => package.Added), resultLabel: "Packages");

    internal string SelectPackage(IReadOnlyList<PackageSelectionItem> packages, CancellationToken cancellationToken,
        string title = "Which package would you like to add?", bool retainAnswer = false)
    {
        if (packages.Count == 0) throw new InvalidOperationException("No packages are available.");
        var prompt = new WizardSelectionPrompt<PackageSelectionItem>
        {
            Title = title,
            PageSize = Math.Min(packages.Count, 12),
            WrapAround = true,
            Converter = package => Markup.Escape(FormatPackageChoice(package)),
        };
        prompt.AddChoices(packages);
        return PromptSingle(prompt, cancellationToken, "Package", resultFormatter: FormatPackageChoice,
            retainAnswer: retainAnswer).Id;
    }

    internal static string FormatPackageChoice(PackageSelectionItem package)
    {
        var name = package.DisplayName;
        foreach (var prefix in new[] { "Syncfusion® ", "Syncfusion " })
            if (name.StartsWith(prefix, StringComparison.Ordinal)) { name = name[prefix.Length..]; break; }
        foreach (var suffix in new[] { " for .NET MAUI", " for Blazor", " for WPF", " for WinForms", " for WinUI" })
            if (name.EndsWith(suffix, StringComparison.Ordinal)) { name = name[..^suffix.Length]; break; }
        return name;
    }

    internal IReadOnlyList<string> SelectControls(
        IReadOnlyList<(string Label, string Id)> options, CancellationToken cancellationToken,
        string title = "Select Syncfusion controls:")
        => SelectControls(options.Select(option => new ControlSelectionItem(option.Id, option.Label)).ToArray(), cancellationToken, title);

    internal IReadOnlyList<string> SelectControls(
        IReadOnlyList<ControlSelectionItem> options, CancellationToken cancellationToken,
        string title = "Select Syncfusion controls:", string? footer = null, bool retainAnswer = true, bool allowEmpty = false,
        IReadOnlyCollection<string>? initiallySelected = null, string resultLabel = "Controls")
    {
        cancellationToken.ThrowIfCancellationRequested();
        using var cursorScope = new TerminalCursorScope(_answerConsole, !_noColor);
        if (options.Count == 0) { throw new InvalidOperationException("No controls are available."); }
        var selected = new HashSet<int>(options.Select((option, index) => (option, index))
            .Where(pair => initiallySelected?.Contains(pair.option.Id, StringComparer.OrdinalIgnoreCase) == true)
            .Select(pair => pair.index));
        var focus = Math.Max(0, options.ToList().FindIndex(option => !option.Added));
        string? action = null;
        var pageSize = Math.Max(1, _console.Profile.Height - 8);
        IRenderable Render()
        {
            var start = Math.Clamp(focus - pageSize + 1, 0, Math.Max(0, options.Count - pageSize));
            return new Rows(new[] { (IRenderable)new Text(title) }.Concat(options.Skip(start).Take(pageSize).Select((option, offset) =>
            {
                var index = start + offset;
                return (IRenderable)new Text($"{(index == focus ? ">" : " ")} [{(option.Added ? "Added" : selected.Contains(index) ? "x" : " ")}] {option.DisplayName}",
                    index == focus && !_noColor ? Wizard.InteractivePrompt.SelectionStyle : Style.Plain);
            }))
                .Append(new Text($"Selected: {selected.Count}"))
                .Append(new Text(""))
                .Append(new Text(TerminalPresentation.Symbols(footer ?? Wizard.InteractivePrompt.MultiSelectionGuidance, _console), _noColor ? Style.Plain : DimStyle)));
        }
        _console.Live(Render()).AutoClear(!_noColor).Start(context =>
        {
            context.Refresh();
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var key = _readKeyAsync(cancellationToken).GetAwaiter().GetResult()
                    ?? throw new IOException("Input ended while selecting controls.");
                if (key.Key == ConsoleKey.Escape) { throw new Wizard.InteractivePromptCancelledException(); }
                if (key.Key == ConsoleKey.C && key.Modifiers.HasFlag(ConsoleModifiers.Control))
                { throw new OperationCanceledException(cancellationToken); }
                if (options[focus].OtherPackages && key.Key is ConsoleKey.Spacebar or ConsoleKey.Enter)
                { action = options[focus].Id; break; }
                if (key.Key == ConsoleKey.Enter && (selected.Count > 0 || allowEmpty)) { break; }
                if (key.Key == ConsoleKey.UpArrow || (key.Key == ConsoleKey.Tab && key.Modifiers.HasFlag(ConsoleModifiers.Shift))) { focus = (focus + options.Count - 1) % options.Count; }
                else if (key.Key is ConsoleKey.DownArrow or ConsoleKey.Tab) { focus = (focus + 1) % options.Count; }
                if (key.Key == ConsoleKey.Spacebar && !options[focus].Added && !selected.Add(focus)) { selected.Remove(focus); }
                context.UpdateTarget(Render());
                context.Refresh();
            }
        });
        if (action is not null) return [action];
        var choices = options.Where((_, index) => selected.Contains(index)).ToList();
        if (retainAnswer) WriteResult(resultLabel, choices.Count == 0 ? options.All(option => option.Added) ? "All already added" : "None" : string.Join(", ", choices.Select(choice => choice.DisplayName)));
        return choices.Select(choice => choice.Id).ToArray();
    }
}
