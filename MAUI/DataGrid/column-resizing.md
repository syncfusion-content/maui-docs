---
layout: post
title: Column Resizing in .NET MAUI DataGrid control | Syncfusion
description: Learn all about column resizing support in Syncfusion MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Columns Resizing in MAUI DataGrid (SfDataGrid)

The `SfDataGrid` allows you to resize the columns by tapping and dragging the right border of the column headers. Resizing can be enabled or disabled by setting the `SfDataGrid.AllowResizingColumns` property. A resizing indicator is displayed while resizing a column.

N> Resizing considers `DataGridColumn.MinimumWidth` and `DataGridColumn.MaximumWidth` of the column and will not exceed the minimum and maximum width constraints.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AllowResizingColumns="True"
                        ItemsSource="{Binding Orders}" />
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowResizingColumns = true;
{% endhighlight %}
{% endtabs %}

![DataGrid with column resizing](Images\column-resizing\maui-datagrid-column-resizing.gif)

To hide a column interactively, set the `DataGridColumn.MinimumWidth` property to zero. Then, resize the column to a width less than zero.

## Resizing events

Based on the requirements, resizing operations can be handled using the `SfDataGrid.ColumnResizing` event. The `SfDataGrid.ColumnResizing` event is triggered while resizing a column and will continue to be triggered until the resizing operation is complete.

By handling the `SfDataGrid.ColumnResizing` event, it is possible to cancel the resizing of a particular column.

The `SfDataGrid.ColumnResizing` event provides the following properties through `DataGridColumnResizingEventArgs`:

* `Index` - Returns the index of the column currently being resized.
* `NewValue` - Returns the current width of the column being resized.
* `ResizingState` - Returns the current state of the user interaction through a value from the `DataGridProgressState` enum.
* `Cancel` - A Boolean property to cancel the resizing operation.

## Cancel resizing for a column

To cancel resizing a specific column, use the `SfDataGrid.ColumnResizing` event. Based on the various arguments provided in the `DataGridColumnResizingEventArgs`, the resizing operation of a column can be canceled.

To prevent resizing a column using the `SfDataGrid.ColumnResizing` event and the `Index` value, refer to the following code example:

{% highlight c# %}
this.dataGrid.ColumnResizing += DataGrid_ColumnResizing;

private void DataGrid_ColumnResizing(object? sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
{
    //Code to end resizing if ColumnIndex is 2
    if (e.Index == 2)
        e.Cancel = true;
}
{% endhighlight %}

To cancel resizing a column using the `SfDataGrid.ColumnResizing` event and the `NewValue` value, refer to the following code example:

{% highlight c# %}
this.dataGrid.ColumnResizing += DataGrid_ColumnResizing;

private void DataGrid_ColumnResizing(object? sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
{
    //Code to end resizing if Column's Width is >= 100
    if (e.NewValue >= 100)
        e.Cancel = true;
}
{% endhighlight %}

To cancel resizing a column using the `SfDataGrid.ColumnResizing` event and the `DataGridProgressState` value, refer to the code example below:

{% highlight c# %}
this.dataGrid.ColumnResizing += DataGrid_ColumnResizing;

private void DataGrid_ColumnResizing(object? sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
{
    // Code to end resizing if interaction state is Progressing
    if (e.ResizingState == Syncfusion.Maui.DataGrid.DataGridProgressState.Progressing)
        e.Cancel = true;
}

{% endhighlight %}

## Customize the appearance

The SfDataGrid allows you to change the resizing indicator color using `SfDataGrid.DefaultStyle.ColumnResizingIndicatorColor`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AllowResizingColumns="True"
                        ItemsSource="{Binding Orders}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle ColumnResizingIndicatorColor="Blue"/>
            </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight c# %}
dataGrid.AllowResizingColumns = true;
dataGrid.DefaultStyle.ColumnResizingIndicatorColor = Colors.Blue;
{% endhighlight %}
{% endtabs %}

![DataGrid with column resizing indicator color](Images\column-resizing\maui-datagrid-column-resizing-indicator-color.gif)