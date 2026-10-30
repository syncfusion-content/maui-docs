using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.Maui;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Groups presentation events without changing the underlying creation stages.</summary>
internal sealed class ProjectCreationProgress(OperationProgress output, NewProjectRequest request) : IOperationStageProgress
{
    private readonly HashSet<string> _started = [];
    private readonly HashSet<string> _completed = [];
    private readonly List<string> _order = [];
    private bool _failed;
    private string ConfigurationGroup => request.SelectedTemplateIds.Count > 0 ? "Finalizing project" : "Setting up project files";

    internal void Initialize()
    {
        var groups = new List<string> { "Creating project" };
        if (request.SelectedTemplateIds.Count > 0) groups.Add("Adding Syncfusion controls");
        groups.Add(ConfigurationGroup);
        if (request.Build)
        {
            groups.Add("Building project");
            output.SetDisplayLabels("Building project", "Building project", "✓ Built project", "✗ Build failed.");
        }
        _order.AddRange(groups);
        output.Plan(groups);
    }

    private string Group(string label) => label switch
    {
        "Preparing destination" or "Creating project from MAUI template" => "Creating project",
        "Adding packages" or "Restoring" when request.SelectedTemplateIds.Count > 0 => "Adding Syncfusion controls",
        "Building" => "Building project",
        _ => ConfigurationGroup,
    };

    private void StartGroup(string group)
    {
        if (_started.Add(group)) output.Started(group);
    }

    public void Plan(IEnumerable<string> labels) { }
    public void Report(string label) => Started(label);

    public void Started(string label)
    {
        var group = Group(label);
        // Welcome installation precedes package work internally. Keep the displayed
        // configuration group pending until package work finishes, without moving work.
        if (group == ConfigurationGroup && request.SelectedTemplateIds.Count > 0
            && !_completed.Contains("Adding Syncfusion controls")) return;
        if (group == "Building project") CompleteGroup(ConfigurationGroup);
        StartGroup(group);
    }

    public void Completed(string label)
    {
        if (label == "Creating project from MAUI template") CompleteGroup("Creating project");
        else if (label == "Restoring" && request.SelectedTemplateIds.Count > 0) CompleteGroup("Adding Syncfusion controls");
        else if (label == "Building") CompleteGroup("Building project");
    }

    private void CompleteGroup(string group)
    {
        if (_failed || !_completed.Add(group)) return;
        StartGroup(group);
        output.Completed(group);
        StartNextAfter(group);
    }

    // Show the following stage as active the moment this one completes, so the display never sits with
    // every stage done or pending while the next step does work that reports no stage of its own.
    private void StartNextAfter(string group)
    {
        var index = _order.IndexOf(group);
        if (index < 0 || index + 1 >= _order.Count) return;
        var next = _order[index + 1];
        // Building only starts when a build really runs; it is reported explicitly.
        if (next == "Building project" || _completed.Contains(next)) return;
        StartGroup(next);
    }

    public void Failed(string label)
    {
        _failed = true;
        var group = Group(label);
        StartGroup(group);
        var detail = label == "Preparing destination" ? "preparing project location" : $"{char.ToLowerInvariant(label[0])}{label[1..]}";
        output.Failed(group, $"failed while {detail}");
    }

    public void Advanced(string label, int completed, int total) { }

    internal void Finish(bool success)
    {
        if (success) CompleteGroup(ConfigurationGroup);
    }
}
