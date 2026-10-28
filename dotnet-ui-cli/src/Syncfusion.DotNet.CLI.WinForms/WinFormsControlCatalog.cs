using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WinForms;

internal static class WinFormsControlCatalog
{
    internal static IReadOnlyList<DesktopControlTemplate> All { get; } =
    [
        new("ai-assist-view", "AIAssistView", "AIAssistView", "AIAssistViewPage", ["Syncfusion.SfAIAssistView.WinForms"]),
        new("chart", "Chart", "Chart", "ChartPage", ["Syncfusion.Chart.Windows"]),
        new("datagrid", "DataGrid", "DataGrid", "DataGridPage", ["Syncfusion.SfDataGrid.WinForms"]),
        new("diagram", "Diagram", "Diagram", "DiagramPage", ["Syncfusion.Diagram.Windows", "Syncfusion.Tools.Windows"]),
        new("docking-manager", "DockingManager", "DockingManager", "DockingManagerPage", ["Syncfusion.Tools.Windows"]),
        new("edit-control", "EditControl", "EditControl", "EditControlPage", ["Syncfusion.Edit.Windows"]),
        new("navigation-drawer", "NavigationDrawer", "NavigationDrawer", "NavigationDrawerPage", ["Syncfusion.Tools.Windows", "Syncfusion.SfListView.WinForms"]),
        new("ribbon", "Ribbon", "Ribbon", "RibbonPage", ["Syncfusion.Tools.Windows"]),
        new("tab-control-adv", "TabControlAdv", "TabControlAdv", "TabControlAdvPage", ["Syncfusion.Tools.Windows"]),
        new("scheduler", "Scheduler", "Scheduler", "SchedulerPage", ["Syncfusion.Schedule.Windows"]),
    ];
}
