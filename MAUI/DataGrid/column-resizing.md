---
layout: post
title: Column Resizing in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about column resizing support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui column resizing, maui column resizing
---

# Columns Resizing in MAUI DataGrid (SfDataGrid)

The `SfDataGrid` allows you to resize the columns by tapping and dragging the right border of the column headers. Resizing can be enabled or disabled by setting the [SfDataGrid.AllowResizingColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowResizingColumns) property. A resizing indicator is displayed while resizing a column.

N> Resizing considers `DataGridColumn.MinimumWidth` and `DataGridColumn.MaximumWidth` of the column and will not exceed the minimum and maximum width constraints.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid  x:Name = "dataGrid"
                        AllowResizingColumns = "True"
                        ItemsSource = "{Binding Orders}" />
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowResizingColumns = true;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-column-resizing" src="Images\column-resizing\net-maui-datagrid-column-resizing.gif" width="404" Height = "396"/>

To hide a column interactively, set the `DataGridColumn.MinimumWidth` property to zero. Then, resize the column to a width less than zero.

## Resizing events

Based on the requirements, resizing operations can be handled using the [SfDataGrid.ColumnResizing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnResizing) event. The `SfDataGrid.ColumnResizing` event is triggered while resizing a column and will continue to be triggered until the resizing operation is complete.

By handling the `SfDataGrid.ColumnResizing` event, it is possible to cancel the resizing of a particular column.

The `SfDataGrid.ColumnResizing` event provides the following properties through [DataGridColumnResizingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs.html):

* `Index` - Returns the index of the column currently being resized.
* `NewValue` - Returns the current width of the column being resized.
* `ResizingState` - Returns the current state of the user interaction through a value from the `DataGridProgressState` enum.
* `Cancel` - A Boolean property to cancel the resizing operation.

## Cancel resizing for a column

To cancel resizing a specific column, use the `SfDataGrid.ColumnResizing` event. Based on the various arguments provided in the `DataGridColumnResizingEventArgs`, the resizing operation of a column can be canceled.

To prevent resizing a column using the `SfDataGrid.ColumnResizing` event and the `Index` value, refer to the following code example:

{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowResizingColumns = true;
dataGrid.ColumnResizing += DataGrid_ColumnResizing;
this.Content = dataGrid;

private void DataGrid_ColumnResizing(object? sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
{
    //Code to end resizing if ColumnIndex is 2
    if (e.Index == 2)
        e.Cancel = true;
}
{% endhighlight %}

To cancel resizing a column using the `SfDataGrid.ColumnResizing` event and the `NewValue` value, refer to the following code example:

{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowResizingColumns = true;
dataGrid.ColumnResizing += DataGrid_ColumnResizing;
this.Content = dataGrid;

private void DataGrid_ColumnResizing(object? sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
{
    //Code to end resizing if Column's Width is >= 100
    if (e.NewValue >= 100)
        e.Cancel = true;
}
{% endhighlight %}

To cancel resizing a column using the `SfDataGrid.ColumnResizing` event and the [DataGridProgressState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridProgressState.html) value, refer to the code example below:

{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowResizingColumns = true;
dataGrid.ColumnResizing += DataGrid_ColumnResizing;
this.Content = dataGrid;

private void DataGrid_ColumnResizing(object? sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
{
    // Code to end resizing if interaction state is Progressing
    if (e.ResizingState == Syncfusion.Maui.DataGrid.DataGridProgressState.Progressing)
        e.Cancel = true;
}

{% endhighlight %}

## Customize the appearance

The SfDataGrid allows you to change the resizing indicator color using [SfDataGrid.DefaultStyle.ColumnResizingIndicatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ColumnResizingIndicatorColor).

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid  x:Name = "dataGrid"
                        AllowResizingColumns = "True"
                        ItemsSource = "{Binding Orders}">
            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle ColumnResizingIndicatorColor = "Blue"/>
            </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowResizingColumns = true;
DataGridStyle dataGridStyle = new DataGridStyle();
dataGridStyle.ColumnResizingIndicatorColor = Colors.Blue;
dataGrid.DefaultStyle = dataGridStyle;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-column-resizing-indicator-color" src="Images\column-resizing\net-maui-datagrid-column-resizing-indicator-color.gif" width="404" Height = "396"/>