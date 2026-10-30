using Syncfusion.DotNet.Cli.Core;

namespace Syncfusion.DotNet.Cli.WinUI;

internal static class WinUIControlCatalog
{
    internal static IReadOnlyList<DesktopControlTemplate> All { get; } =
    [
        new("ai-assist-view", "AIAssistView", "AIAssistView", "AIAssistViewPage", ["Syncfusion.Chat.WinUI"]),
        new("cartesian-chart", "CartesianChart", "CartesianChart", "CartesianChartPage", ["Syncfusion.Chart.WinUI"]),
        new("circular-chart", "CircularChart", "CircularChart", "CircularChartPage", ["Syncfusion.Chart.WinUI"]),
        new("datagrid", "DataGrid", "DataGrid", "DataGridPage", ["Syncfusion.Grid.WinUI"]),
        new("docking-manager", "DockingManager", "DockingManager", "DockingManagerPage", ["Syncfusion.DockingManager.WinUI"]),
        new("kanban", "Kanban", "Kanban", "KanbanPage", ["Syncfusion.Kanban.WinUI"]),
        new("markdown-viewer", "MarkdownViewer", "MarkdownViewer", "MarkdownViewerPage", ["Syncfusion.MarkdownViewer.WinUI"]),
        new("ribbon", "Ribbon", "Ribbon", "RibbonPage", ["Syncfusion.Ribbon.WinUI"]),
        new("scheduler", "Scheduler", "Scheduler", "SchedulerPage", ["Syncfusion.Scheduler.WinUI"]),
        new("treegrid", "TreeGrid", "TreeGrid", "TreeGridPage", ["Syncfusion.Grid.WinUI"]),
        new("treeview", "TreeView", "TreeView", "TreeViewPage", ["Syncfusion.TreeView.WinUI"]),
    ];
}
