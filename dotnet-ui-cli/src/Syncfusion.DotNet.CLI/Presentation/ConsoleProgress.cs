using System;
using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>
/// Writes <see cref="ProgressStep"/> values to <see cref="System.Console"/>
/// as plain text. When <c>--silent</c> is set, the reporter writes
/// nothing so the JSON output on stdout is not polluted with progress lines.
/// </summary>
public sealed class ConsoleProgress : IProgress<ProgressStep>
{
    private readonly bool _silent;
    private readonly IProgress<string> _stages;
    private readonly ConsolePresenter _presenter;
    private readonly Func<ProgressStep, bool>? _includeStep;
    private readonly object _gate = new();
    private int _lastReportedIndex = -1;

    public ConsoleProgress(bool noColor, bool silent, IProgress<string>? stages = null, Func<ProgressStep, bool>? includeStep = null)
    {
        _stages = stages ?? new OperationProgress(noColor, silent: silent);
        _presenter = new ConsolePresenter(noColor, silent: silent);
        _silent = silent;
        _includeStep = includeStep;
    }

    /// <summary>Reports a single step. Idempotent for the same step index.</summary>
    public void Report(ProgressStep step)
    {
        if (_silent || _includeStep?.Invoke(step) == false)
        {
            return;
        }

        lock (_gate)
        {
            if (step.Index == _lastReportedIndex)
            {
                return;
            }

            _lastReportedIndex = step.Index;
        }

        _stages.Report($"[{step.Index}/{step.Total}] {step.Label}");
    }

    /// <summary>Writes a final summary line under the progress list.</summary>
    public void Complete(string label)
    {
        if (_silent)
        {
            return;
        }

        _presenter.WriteSuccess($"Done: {label}");
    }

    /// <summary>Writes a single error line in the progress list. Always visible.</summary>
    public void Fail(string label)
    {
        _presenter.WriteError(label);
    }
}
