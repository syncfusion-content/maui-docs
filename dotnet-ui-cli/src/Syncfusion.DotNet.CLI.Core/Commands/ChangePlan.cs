namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// A simple, serializable change plan describing everything an operation will
/// do before it does it. Built up by the add/remove/update flow and either
/// executed or printed for <c>--dry-run</c>. Kept intentionally small: it lists
/// packages, files, commands, and warnings, with no execution semantics.
/// </summary>
public sealed class ChangePlan
{
    /// <summary>The control id the plan applies to (e.g. <c>datagrid</c>).</summary>
    public string ControlId { get; set; } = string.Empty;

    /// <summary>Syncfusion package ids to add to the project.</summary>
    public List<string> PackagesToAdd { get; set; } = [];

    /// <summary>Syncfusion package ids to remove from the project.</summary>
    public List<string> PackagesToRemove { get; set; } = [];

    /// <summary>Files the operation will create, relative to the project root.</summary>
    public List<string> FilesToCreate { get; set; } = [];

    /// <summary>Files the operation will modify, relative to the project root.</summary>
    public List<string> FilesToModify { get; set; } = [];

    /// <summary>Files the operation will delete, relative to the project root.</summary>
    public List<string> FilesToDelete { get; set; } = [];

    /// <summary>The dotnet package commands to execute (e.g. add package).</summary>
    public List<string> CommandsToExecute { get; set; } = [];

    /// <summary>Warnings the user should review before execution.</summary>
    public List<string> Warnings { get; set; } = [];

    /// <summary>True when the plan is a preview only and will not make changes.</summary>
    public bool IsDryRun { get; set; }

    /// <summary>True if the plan has no changes to apply.</summary>
    public bool IsEmpty
        => PackagesToAdd.Count == 0
            && PackagesToRemove.Count == 0
            && FilesToCreate.Count == 0
            && FilesToModify.Count == 0
            && FilesToDelete.Count == 0;
}
