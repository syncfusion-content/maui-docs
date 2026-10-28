using Spectre.Console;
using Spectre.Console.Rendering;
using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Presentation;

/// <summary>Persistent actual-work stages in live terminals; append-only transitions otherwise.</summary>
internal sealed class OperationProgress(bool noColor, bool json = false, bool silent = false,
    IAnsiConsole? console = null, bool showPending = true) : IOperationStageProgress
{
    private enum State { Pending, Active, Completed, Failed, Skipped, Cancelled }
    private sealed record Stage(string Label, State State, string? Reason = null, int Completed = 0, int Total = 0);
    private readonly List<Stage> _steps = [];
    private readonly Dictionary<string, (string Active, string Completed, string Failed)> _displayLabels = [];
    private readonly HashSet<string> _reportedFailures = [];
    private readonly object _gate = new();
    private readonly IAnsiConsole _console = console ?? AnsiConsole.Console;
    private bool _live;
    private int _frame;
    private string? _lastStage;
    private bool Suppressed => json || silent;

    internal async Task<T> RunAsync<T>(Func<IProgress<string>, Task<T>> operation)
    {
        using var cursorScope = new TerminalCursorScope(_console, !Suppressed && ColorPolicy.AllowsLive(_console, noColor));
        _live = !Suppressed && ColorPolicy.AllowsLive(_console, noColor);
        async Task<T> Execute()
        {
            try { return await operation(this).ConfigureAwait(false); }
            catch (OperationCanceledException) { Finish(cancelled: true); throw; }
            finally { Finish(); }
        }
        if (!_live) return await Execute().ConfigureAwait(false);
        return await _console.Live(Render()).AutoClear(false).StartAsync(async context =>
        {
            var task = Execute();
            try
            {
                while (!task.IsCompleted)
                {
                    context.UpdateTarget(Render());
                    context.Refresh();
                    await Task.WhenAny(task, Task.Delay(90)).ConfigureAwait(false);
                    _frame++;
                }
                return await task.ConfigureAwait(false);
            }
            finally { context.UpdateTarget(Render()); context.Refresh(); }
        }).ConfigureAwait(false);
    }

    public void Report(string stage)
    {
        if (Suppressed || string.IsNullOrWhiteSpace(stage) || stage == _lastStage) return;
        _lastStage = stage;
        if (_live) Started(stage);
        else Console.Out.WriteLine("  " + stage);
    }

    public void Plan(IEnumerable<string> labels)
    {
        if (Suppressed) return;
        lock (_gate)
            foreach (var label in labels.Where(label => !string.IsNullOrWhiteSpace(label)))
                if (_steps.All(step => step.Label != label)) _steps.Add(new Stage(label, State.Pending));
    }

    internal void SetDisplayLabels(string label, string active, string completed, string failed)
    {
        lock (_gate) _displayLabels[label] = (active, completed, failed);
    }

    public void Started(string label) => Set(label, State.Active);
    public void Completed(string label) => Set(label, State.Completed);
    public void Failed(string label) => Set(label, State.Failed);
    internal void Failed(string label, string reason) => Set(label, State.Failed, reason);

    public void Advanced(string label, int completed, int total)
    {
        if (Suppressed || total <= 0 || completed < 0 || completed > total) return;
        lock (_gate)
        {
            var index = _steps.FindIndex(step => step.Label == label && step.State == State.Active);
            if (index >= 0) _steps[index] = _steps[index] with { Completed = completed, Total = total };
        }
    }

    private void Set(string label, State state, string? reason = null)
    {
        if (Suppressed) return;
        lock (_gate)
        {
            var index = _steps.FindIndex(step => step.Label == label);
            if (index >= 0 && _steps[index].State == state) return;
            var step = new Stage(label, state, reason);
            if (index < 0) _steps.Add(step); else _steps[index] = step;
            // Delay a plain failure until RunAsync can distinguish cancellation.
            if (!_live && state != State.Failed) WriteTransition(step);
        }
    }

    private void Finish(bool cancelled = false)
    {
        if (Suppressed) return;
        lock (_gate)
        {
            foreach (var step in _steps.ToArray())
            {
                if (cancelled && step.State is State.Active or State.Failed) Set(step.Label, State.Cancelled);
                else if (step.State == State.Active) Set(step.Label, State.Failed);
            }
            if (!_live)
                foreach (var step in _steps.Where(step => step.State == State.Failed))
                    if (_reportedFailures.Add(step.Label)) WriteTransition(step);
            foreach (var step in _steps.Where(step => step.State == State.Pending).ToArray())
                Set(step.Label, State.Skipped, cancelled ? "cancelled" : "not run");
        }
    }

    private void WriteTransition(Stage step)
    {
        var text = TerminalPresentation.Symbols(Describe(step, animated: false), _console);
        var style = step.State switch
        {
            State.Completed => new Style(Color.Green),
            State.Failed => new Style(Color.Red),
            State.Active => new Style(Color.Cyan),
            _ => Style.Plain,
        };
        if (ColorPolicy.AllowsColor(noColor) && _console.Profile.Capabilities.Ansi)
            _console.Write(new Text("  " + text + Environment.NewLine, style));
        else Console.Out.WriteLine("  " + text);
    }

    private IRenderable Render()
    {
        lock (_gate)
        {
            var visible = _steps.Where(step => showPending || step.State != State.Pending).ToList();
            var active = visible.FindLastIndex(step => step.State == State.Active);
            return new Rows(visible.Select((step, index) => (IRenderable)new Text(TerminalPresentation.Symbols(Describe(step, animated: index == active), _console), !ColorPolicy.AllowsColor(noColor) ? Style.Plain : step.State switch
            {
                State.Completed => new Style(Color.Green),
                State.Active => new Style(Color.Cyan),
                State.Failed => new Style(Color.Red),
                State.Cancelled => new Style(Color.Yellow),
                _ => InteractiveConsoleInput.DimStyle,
            })).ToArray());
        }
    }

    private string Describe(Stage step, bool animated)
    {
        if (_displayLabels.TryGetValue(step.Label, out var labels))
        {
            if (step.State == State.Completed) return labels.Completed;
            if (step.State == State.Failed) return labels.Failed;
            if (step.State == State.Active) step = step with { Label = labels.Active };
        }
        return step.State switch
        {
            State.Completed => $"✓ {step.Label}",
            State.Active when step.Total > 0 => $"… {step.Label} {Bar(step)} {step.Completed}/{step.Total}",
            State.Active => $"{(animated ? (_console.Profile.Capabilities.Unicode ? "⠋⠙⠹⠸⠼⠴⠦⠧⠇⠏"[_frame % 10].ToString() : "|/-\\"[_frame % 4].ToString()) : "…")} {step.Label}",
            State.Failed when step.Reason is not null => $"✗ {step.Label}: {step.Reason}",
            State.Failed => $"✗ {step.Label} — failed",
            State.Cancelled => $"! {step.Label} — cancelled",
            State.Skipped => $"- {step.Label} — skipped ({step.Reason})",
            _ => $"· {step.Label} — pending",
        };
    }

    private string Bar(Stage step)
    {
        var width = Math.Clamp(_console.Profile.Width / 8, 4, 12);
        var filled = (int)((long)step.Completed * width / step.Total);
        return "[" + new string('#', filled) + new string('-', width - filled) + "]";
    }
}
