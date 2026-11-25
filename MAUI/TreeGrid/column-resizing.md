---
layout: post
title: Column Resizing in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to resize columns in Syncfusion® .NET MAUI Tree Grid, including resizing modes, width constraints, the ColumnResizing event and indicator customization.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid column resizing, maui treegrid column resizing, treegrid resize columns
---

# Column Resizing in .NET MAUI Tree Grid

The [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) allows you to resize the columns by tapping and dragging the right border of the column headers. Resizing can be enabled or disabled by setting the [AllowResizingColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowResizingColumns) property. The default value is `false`. A resizing indicator is displayed while resizing a column.

N> The `syncfusion` prefix used in the XAML samples refers to `xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"`.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       AllowResizingColumns="True"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople" />
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportingPeople";
treeGrid.AllowResizingColumns = true;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Width Constraints

Resizing respects the [TreeGridColumn.MinimumWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_MinimumWidth) and [TreeGridColumn.MaximumWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_MaximumWidth) properties. The column will not resize beyond these constraints. By default, both properties are `double.NaN`, which means that the columns have no minimum or maximum width limits.

N> Resizing considers `TreeGridColumn.MinimumWidth` and `TreeGridColumn.MaximumWidth` of the column, and will not exceed the minimum and maximum width constraints. The width of a column cannot be resized below zero.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       AllowResizingColumns="True"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="Name"
                                       MinimumWidth="80"
                                       MaximumWidth="300" />
        <syncfusion:TreeGridTextColumn MappingName="Title"
                                       MinimumWidth="60" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.AllowResizingColumns = true;
treeGrid.Columns[0].MinimumWidth = 80;
treeGrid.Columns[0].MaximumWidth = 300;
treeGrid.Columns[1].MinimumWidth = 60;
{% endhighlight %}
{% endtabs %}

## Resizing the expander column

The expander column is resized in the same way as the other columns. While resizing interactively, the width of the expander column is restricted to the minimum width that is required for the expander icon and the indentation area of the nodes, so the expander icon is never hidden by a drag. Assigning the `Width` of the column programmatically is not restricted by this minimum.

## Resizing Modes

The `SfTreeGrid` allows two modes of resizing by setting the [ColumnResizeMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_ColumnResizeMode) property. The default value is `OnTouchUp`. The resizing modes of the [TreeGridColumnResizeMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumnResizeMode.html) enum are as follows:

* **OnMoved**: The resizing indicator is moved based on the touch point. The width of the column is updated as the resizing indicator moves. Use this mode for real-time visual feedback during resizing.
* **OnTouchUp**: The resizing indicator is moved based on the touch point. However, the width of the column is updated only on a touch up operation. Use this mode for better performance when resizing large datasets.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       AllowResizingColumns="True"
                       ColumnResizeMode="OnMoved"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople" />
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportingPeople";
treeGrid.AllowResizingColumns = true;
treeGrid.ColumnResizeMode = TreeGridColumnResizeMode.OnMoved;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

N> The bindable property identifier of `ColumnResizeMode` is `ColumnResizingModeProperty`.

## Resizing events

Based on the requirements, resizing operations can be handled using the [ColumnResizing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_ColumnResizing) event. The `ColumnResizing` event is an `EventHandler<TreeGridColumnResizingEventArgs>`. It is raised when the resizing starts, continues to be raised while the column is resized, and is raised once more when the resizing completes. By handling this event, it is possible to cancel the resizing of a particular column.

The `ColumnResizing` event provides the following properties through [TreeGridColumnResizingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumnResizingEventArgs.html), which derives from `System.ComponentModel.CancelEventArgs`:

| Property | Type | Access | Description |
|---|---|---|---|
| `Index` | `int` | Get | The index of the column that is being resized, in the `SfTreeGrid.Columns` collection. |
| `NewValue` | `double` | Get | The width of the column that is being resized. |
| `ResizingState` | [TreeGridProgressState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridProgressState.html) | Get | The current state of the resizing operation. |
| `Cancel` | `bool` | Get/Set | Set to `true` to cancel the resizing operation. |

The `TreeGridProgressState` enum has the following values:

| Value | Description | Effect of setting `Cancel` to `true` |
|---|---|---|
| `Starting` | The resizing operation is about to start. | The resizing does not start, and the resizing indicator is not displayed. |
| `Progressing` | The column is being resized. | The width change of the current movement is not applied, and the column keeps its previous width. |
| `Completed` | The resizing is completed. | The `Cancel` value is not used. |

## Cancel resizing for a column

To prevent resizing a specific column, use the `ColumnResizing` event and set the `Cancel` property to `true` in the `Starting` state:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       AllowResizingColumns="True"
                       ColumnResizing="TreeGrid_ColumnResizing"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople" />
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportingPeople";
treeGrid.AllowResizingColumns = true;
treeGrid.ColumnResizing += TreeGrid_ColumnResizing;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void TreeGrid_ColumnResizing(object? sender, TreeGridColumnResizingEventArgs e)
{
    // Cancel resizing of the column at index 2.
    if (e.ResizingState == TreeGridProgressState.Starting && e.Index == 2)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Restrict the width while resizing

The `Progressing` state can be used to limit the width of a column based on your own logic. When `Cancel` is set in this state, the resize movement is not applied.

{% tabs %}
{% highlight c# %}
private void TreeGrid_ColumnResizing(object? sender, TreeGridColumnResizingEventArgs e)
{
    // Do not allow the column at index 1 to grow wider than 250.
    if (e.ResizingState == TreeGridProgressState.Progressing
        && e.Index == 1
        && e.NewValue > 250)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

N> For fixed limits, use the `MinimumWidth` and `MaximumWidth` properties of the column. They are applied to the resizing without writing event handler code.

## Read the final width of a column

The `Completed` state is raised when the resizing ends. Use it to read the new width, for example to persist the layout of the columns.

{% tabs %}
{% highlight c# %}
private void TreeGrid_ColumnResizing(object? sender, TreeGridColumnResizingEventArgs e)
{
    if (e.ResizingState == TreeGridProgressState.Completed)
    {
        var column = treeGrid.Columns[e.Index];
        Debug.WriteLine($"{column.MappingName} was resized to {e.NewValue}.");
    }
}
{% endhighlight %}
{% endtabs %}

N> With `OnTouchUp`, the width is applied to the column after the `Completed` state is raised. Read `e.NewValue` instead of `column.Width` in the `Completed` state.

## Customize the appearance

The SfTreeGrid allows you to change the resizing indicator color using the [TreeGridStyle.ColumnResizingIndicatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_ColumnResizingIndicatorColor) property of the `SfTreeGrid.DefaultStyle`. The default value is `#6454A2`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       AllowResizingColumns="True"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle ColumnResizingIndicatorColor="Blue" />
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportingPeople";
treeGrid.AllowResizingColumns = true;
treeGrid.DefaultStyle.ColumnResizingIndicatorColor = Colors.Blue;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## API reference

| Member | Type | Default | Description |
|---|---|---|---|
| [SfTreeGrid.AllowResizingColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowResizingColumns) | `bool` | `false` | Enables the resizing of columns by dragging the column header edge. |
| [SfTreeGrid.ColumnResizeMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_ColumnResizeMode) | `TreeGridColumnResizeMode` | `OnTouchUp` | When the column width is updated. |
| [SfTreeGrid.ColumnResizing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_ColumnResizing) | `EventHandler<TreeGridColumnResizingEventArgs>` | - | Raised while a column is resized. |
| `TreeGridColumn.MinimumWidth` | `double` | `NaN` | The minimum width of a column. |
| `TreeGridColumn.MaximumWidth` | `double` | `NaN` | The maximum width of a column. |
| `TreeGridStyle.ColumnResizingIndicatorColor` | `Color` | `#6454A2` | The color of the resizing indicator. |
| `TreeGridColumnResizingEventArgs` | class | - | Event arguments with `Index`, `NewValue`, `ResizingState`, and `Cancel`. |
| `TreeGridColumnResizeMode` | enum | - | `OnTouchUp` and `OnMoved`. |
| `TreeGridProgressState` | enum | - | `Starting`, `Progressing`, and `Completed`. |

`AllowResizingColumnsProperty` and `ColumnResizingModeProperty` are the bindable property identifiers for `AllowResizingColumns` and `ColumnResizeMode`.

## Complete example

The following example enables resizing with the `OnMoved` mode, applies width limits to the columns, locks the first column, and customizes the indicator color.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TreeGridResizing"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"
             x:Class="TreeGridResizing.MainPage">

    <ContentPage.BindingContext>
        <local:EmployeeViewModel />
    </ContentPage.BindingContext>

    <syncfusion:SfTreeGrid x:Name="treeGrid"
                           ItemsSource="{Binding Employees}"
                           ChildPropertyName="ReportingPeople"
                           AutoGenerateColumnsMode="None"
                           ExpanderColumn="Name"
                           AllowResizingColumns="True"
                           ColumnResizeMode="OnMoved"
                           ColumnResizing="TreeGrid_ColumnResizing">
        <syncfusion:SfTreeGrid.DefaultStyle>
            <syncfusion:TreeGridStyle ColumnResizingIndicatorColor="Blue" />
        </syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:SfTreeGrid.Columns>
            <syncfusion:TreeGridTextColumn MappingName="Name" HeaderText="Name"
                                           MinimumWidth="120" MaximumWidth="320" />
            <syncfusion:TreeGridTextColumn MappingName="Title" HeaderText="Title"
                                           MinimumWidth="80" />
        </syncfusion:SfTreeGrid.Columns>
    </syncfusion:SfTreeGrid>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.TreeGrid;

namespace TreeGridResizing;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void TreeGrid_ColumnResizing(object? sender, TreeGridColumnResizingEventArgs e)
    {
        // The Title column cannot be resized.
        if (e.ResizingState == TreeGridProgressState.Starting
            && treeGrid.Columns[e.Index].MappingName == "Title")
        {
            e.Cancel = true;
        }
    }
}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeInfo.cs" %}
using System.Collections.ObjectModel;

namespace TreeGridResizing;

public class EmployeeInfo
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public ObservableCollection<EmployeeInfo> ReportingPeople { get; set; } = new();
}

public class EmployeeViewModel
{
    public ObservableCollection<EmployeeInfo> Employees { get; set; }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<EmployeeInfo>
        {
            new EmployeeInfo
            {
                Name = "Anna", Title = "CEO",
                ReportingPeople =
                {
                    new EmployeeInfo { Name = "Ravi", Title = "Manager" }
                }
            }
        };
    }
}
{% endhighlight %}
{% endtabs %}

## Supported combinations

### Works with

* **Expander column**: The expander column can be resized, with a minimum width for the interactive resizing.
* **Column width settings**: `MinimumWidth` and `MaximumWidth`.
* **Right-to-left flow direction**: The resizing position and the indicator position are mirrored.
* **Horizontal scrolling**: The horizontal scroll bar is refreshed after the resizing on Android.
* **Column drag and drop**: A column drag does not start while a column is being resized. Refer to [Column drag and drop](https://help.syncfusion.com/maui/treegrid/column-drag-and-drop).

### Known limitations

* The resizing starts from the header row only.
* Verification Required – Combination support not verified: column resizing with frozen columns (`FrozenColumnCount`, `FooterFrozenColumnCount`) and stacked headers. The TreeGrid resizing controller states that resizing is allowed everywhere in the header row, but the interaction with stacked headers is not verified.

## Platform-specific considerations

| Platform | Behavior |
|---|---|
| Android and iOS | The resizing starts by pressing near the right border of the header cell and dragging. The touch area is 25 units wide. |
| Windows and macOS | The resizing starts by pressing near the right border of the header cell and dragging. The touch area is 10 units wide. On Windows, the pointer changes to a horizontal resize cursor over the resizable border. |

## See also

* [Column sizing in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/column-sizing)
* [Columns in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/columns)
* [Freeze panes in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/freeze-panes)
