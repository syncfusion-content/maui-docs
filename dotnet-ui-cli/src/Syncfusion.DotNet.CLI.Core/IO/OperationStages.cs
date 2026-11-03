namespace Syncfusion.DotNet.Cli.Core;

/// <summary>Optional presentation lifecycle; existing string callbacks remain supported.</summary>
public interface IOperationStageProgress : IProgress<string>
{
    void Plan(IEnumerable<string> labels);
    void Started(string label);
    void Completed(string label);
    void Failed(string label);
    void Advanced(string label, int completed, int total);
}

/// <summary>Marks only explicitly completed work successful. Disposal fails unfinished work.</summary>
public sealed class OperationStages(IProgress<string>? progress) : IDisposable
{
    private string? _active;

    public void Plan(params string[] labels) => (progress as IOperationStageProgress)?.Plan(labels);

    public void Start(string label, bool reportLegacy = true)
    {
        Fail();
        _active = label;
        if (progress is IOperationStageProgress lifecycle) lifecycle.Started(label);
        else if (reportLegacy) progress?.Report(label);
    }

    public void Complete()
    {
        if (_active is { } label) (progress as IOperationStageProgress)?.Completed(label);
        _active = null;
    }

    public void Fail()
    {
        if (_active is { } label) (progress as IOperationStageProgress)?.Failed(label);
        _active = null;
    }

    public void Advance(int completed, int total)
    {
        if (_active is { } label) (progress as IOperationStageProgress)?.Advanced(label, completed, total);
    }

    public void Dispose() => Fail();
}
