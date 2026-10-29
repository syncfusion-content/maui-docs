using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WPF;

internal static class WPFControlCatalog
{
    internal static IReadOnlyList<DesktopControlTemplate> All { get; } =
    [
        new("ai-assist-view", "AIAssistView", "AIAssistView", "AIAssistViewPage", ["Syncfusion.SfChat.WPF"]),
        new("chart", "Chart", "Charts", "ChartPage", ["Syncfusion.SfChart.WPF", "Syncfusion.Shared.WPF"]),
        new("datagrid", "DataGrid", "DataGrid", "DataGridPage", ["Syncfusion.SfGrid.WPF", "Syncfusion.SfInput.WPF", "Syncfusion.Tools.WPF"]),
        new("diagram", "Diagram", "Diagrams", "DiagramsPage", ["Syncfusion.SfDiagram.WPF"]),
        new("docking-manager", "DockingManager", "DockingManager", "DockingManagerPage", ["Syncfusion.Tools.WPF", "Syncfusion.SfChart.WPF"]),
        new("gantt", "Gantt", "Gantt", "GanttPage", ["Syncfusion.Gantt.WPF"]),
        new("kanban", "Kanban", "Kanban", "KanbanPage", ["Syncfusion.SfKanban.WPF", "Syncfusion.Shared.WPF"]),
        new("navigation-drawer", "NavigationDrawer", "NavigationDrawer", "NavigationDrawerPage", ["Syncfusion.SfNavigationDrawer.WPF", "Syncfusion.Shared.WPF"]),
        new("ribbon", "Ribbon", "Ribbon", "RibbonPage", ["Syncfusion.Tools.WPF", "Microsoft.Xaml.Behaviors.Wpf"]),
        new("scheduler", "Scheduler", "Scheduler", "SchedulerPage", ["Syncfusion.SfScheduler.WPF"]),
        new("treegrid", "TreeGrid", "TreeGrid", "TreeGridPage", ["Syncfusion.SfGrid.WPF"]),
    ];
}
