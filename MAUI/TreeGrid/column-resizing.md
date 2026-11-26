---
layout: post
title: Column Resizing in .NET MAUI Tree Grid | Syncfusion®
description: Resize Tree Grid columns in .NET MAUI with resizing modes, width limits, events, and indicator customization.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid column resizing, maui treegrid column resizing, treegrid resize columns
---

# Column Resizing in .NET MAUI Tree Grid

The [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) allows you to resize columns by tapping and dragging the right border of the column headers. Column resizing can be enabled or disabled using the [AllowResizingColumns]() property. The default value is `false`. A resizing indicator is displayed while a column is being resized.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       AllowResizingColumns="True"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowResizingColumns = true; // Enable column resizing
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both; // Show grid lines for better visibility
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both; // Show grid lines in the header for better visibility
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="MAUI TreeGrid with ColumnResizing" src="Images\column-resizing\maui-treegrid-column-resizing.gif" width="404" Height = "396"/>

## Width Constraints

Resizing respects the [TreeGridColumn.MinimumWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_MinimumWidth) and [TreeGridColumn.MaximumWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_MaximumWidth) properties. A column cannot be resized beyond these constraints. By default, columns have no minimum or maximum width limits.

N> Resizing considers the `TreeGridColumn.MinimumWidth` and `TreeGridColumn.MaximumWidth` properties of a column and does not exceed the specified width constraints. A column's width cannot be resized below zero.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       AllowResizingColumns="True"
                       ColumnResizeMode="OnMoved"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="First Name"
                                       MappingName="FirstName"
                                       MinimumWidth="80"/>
        <syncfusion:TreeGridTextColumn HeaderText="Last Name"
                                       MappingName="LastName"
                                       MaximumWidth="150"/>
        <syncfusion:TreeGridTextColumn HeaderText="Employee ID"
                                       MappingName="EmployeeID"/>
        <syncfusion:TreeGridTextColumn HeaderText="Salary"
                                       MappingName="Salary"/>
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowResizingColumns = true;
treeGrid.ColumnResizeMode = TreeGridColumnResizeMode.OnMoved;
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "FirstName", HeaderText = "First Name", MinimumWidth = 80 });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "LastName", HeaderText = "Last Name", MaximumWidth = 150 });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "EmployeeID", HeaderText = "Employee ID" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "Salary", HeaderText = "Salary" });
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="MAUI TreeGrid ColumnResizing with Width Constraints" src="Images\column-resizing\columnresizing-with-widthconstraints.gif" width="404" Height = "396"/>

## Resizing the expander column

The expander column is resized in the same way as other columns. While resizing interactively, the width of the expander column is restricted to the minimum width required for the expander icon and the indentation area of the nodes, so the expander icon is never hidden during dragging. Assigning the column `Width` programmatically is not restricted by this minimum.

## Resizing Modes

The `SfTreeGrid` supports two column resizing modes through the [ColumnResizeMode]() property. The default value is `OnTouchUp`. The available resizing modes in the [TreeGridColumnResizeMode]() enum are as follows:

* **OnMoved**: The resizing indicator moves based on the touch point, and the column width is updated as the indicator moves. Use this mode to provide real-time visual feedback during resizing.

* **OnTouchUp**: The resizing indicator moves based on the touch point. However, the column width is updated only when the touch is released. Use this mode for better performance when resizing large datasets.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       AllowResizingColumns="True"
                       ColumnResizeMode="OnMoved"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowResizingColumns = true;
treeGrid.ColumnResizeMode = TreeGridColumnResizeMode.OnMoved; // ColumnResizeMode is set to OnMoved
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Resizing events

Based on the requirements, resizing operations can be handled using the [SfTreeGrid.ColumnResizing]() event. This event is raised when resizing starts, continues to be raised while the column is being resized, and is raised again when the resizing operation is completed. By handling this event, you can cancel the resizing of a particular column.

The `ColumnResizing` event provides the following properties through [TreeGridColumnResizingEventArgs](), which derives from `System.ComponentModel.CancelEventArgs`:

| Property | Type | Access | Description |
|---|---|---|---|
| `Index` | `int` | Get | Gets the index of the column being resized in the `SfTreeGrid.Columns` collection. |
| `NewValue` | `double` | Get | Gets the width of the column being resized. |
| `ResizingState` | [TreeGridProgressState]() | Get | Gets the current state of the resizing operation. |
| `Cancel` | `bool` | Get/Set | Set to `true` to cancel the resizing operation. |

The `TreeGridProgressState` enum contains the following values:

| Value | Description | Effect of setting `Cancel` to `true` |
|---|---|---|
| `Starting` | The resizing operation is about to start. | The resizing operation is canceled, and the resizing indicator is not displayed. |
| `Progressing` | The column is being resized. | The width change for the current resize operation is not applied, and the column retains its previous width. |
| `Completed` | The resizing operation has completed. | The `Cancel` property is ignored. |

## Cancel resizing for a column

To prevent a specific column from being resized, handle the `SfTreeGrid.ColumnResizing` event and set the `Cancel` property to `true` based on your requirements:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       AllowResizingColumns="True"
                       ColumnResizing="treeGrid_ColumnResizing"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowResizingColumns = true;
treeGrid.ColumnResizing += treeGrid_ColumnResizing;
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void treeGrid_ColumnResizing(object sender, TreeGridColumnResizingEventArgs e)
{
    // Cancel resizing of the column at index 2.
    if (e.ResizingState == TreeGridProgressState.Starting && e.Index == 2)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Disable Resizing for a Specific Column" src="Images\column-resizing\disable-columnresizing-for-a-column.gif" width="404" Height = "396"/>

## Restrict column width during resizing

You can use the `Progressing` state to restrict the width of a column based on custom logic. When the `Cancel` property is set to `true` in this state, the current resize action is not applied.

{% tabs %}
{% highlight c# %}
private void treeGrid_ColumnResizing(object sender, TreeGridColumnResizingEventArgs e)
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

N> For fixed width limits, use the `MinimumWidth` and `MaximumWidth` properties of the column. These constraints are applied automatically during resizing and do not require event-handling code.

## Read the final width of a resized column

The `Completed` state is raised when a resizing operation finishes. You can use this state to retrieve the final width of the resized column, for example, to persist the column layout.

{% tabs %}
{% highlight c# %}
private void treeGrid_ColumnResizing(object sender, TreeGridColumnResizingEventArgs e)
{
    if (e.ResizingState == TreeGridProgressState.Completed)
    {
        var column = treeGrid.Columns[e.Index];
        System.Diagnostics.Debug.WriteLine($"{column.MappingName} was resized to {e.NewValue}.");
    }
}
{% endhighlight %}
{% endtabs %}

N> When `ColumnResizeMode` is set to `OnTouchUp`, the new width is applied to the column after the `Completed` state is raised. Therefore, use `e.NewValue` instead of `column.Width` within the Completed state to obtain the final width.

## Customize the appearance

The `SfTreeGrid` allows you to customize the color of the resizing indicator using the [TreeGridStyle.ColumnResizingIndicatorColor]() property of [SfTreeGrid.DefaultStyle](). The default value is `#6454A2`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       AllowResizingColumns="True"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle ColumnResizingIndicatorColor="Blue"/>
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowResizingColumns = true;
treeGrid.DefaultStyle.ColumnResizingIndicatorColor = Colors.Blue; // Set the color of the column resizing indicator to blue
treeGrid.GridLinesVisibility = TreeGridLinesVisibility.Both;
treeGrid.HeaderGridLinesVisibility = TreeGridLinesVisibility.Both;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Customize Column Resizing Indicator Appearance" src="Images\column-resizing\columnresizing-indicator-customization.gif" width="404" Height = "396"/>
 