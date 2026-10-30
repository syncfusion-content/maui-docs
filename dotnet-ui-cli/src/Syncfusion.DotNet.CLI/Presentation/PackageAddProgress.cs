using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Displays package-add groups only when their underlying work starts.</summary>
internal sealed class PackageAddProgress(OperationProgress output, IPackageAddPresentationProvider provider) : IOperationStageProgress
{
    private string? _active;
    private string? _lastStage;
    private bool _failed;
    public void Plan(IEnumerable<string> labels) { }
    public void Report(string label) => Started(label);
    public void Started(string label)
    {
        _lastStage = label;
        var group = provider.Group(label);
        if (group == _active) return;
        if (_active is not null && !_failed) output.Completed(_active);
        _active = group;
        output.Started(group);
    }
    public void Completed(string label) { }
    public void Advanced(string label, int completed, int total) { }
    public void Failed(string label)
    {
        if (_failed) return;
        Started(label);
        _failed = true;
        output.Failed(_active!, $"failed while {provider.FailureDetail(label)}");
    }
    internal void Finish(bool success)
    {
        if (success && !_failed && _active is not null) output.Completed(_active);
        else if (!success && !_failed && _lastStage is not null) Failed(_lastStage);
    }
}
