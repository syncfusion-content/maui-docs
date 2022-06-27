---
layout: post
title: Selection in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Grid Events support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Grid Events in .NET MAUI DataGrid (SfDataGrid)

## Cell Tap callbacks

The datagrid provides the following callbacks to handle interactions to the cells,

* `CellTapped` : Called when a tap with a cell has occurred.
* `CellDoubleTapped` : Called when user is tapped a cell with a primary button at the same cell twice in quick succession.
* `CellLongPress` : Called when a long press gesture with a primary button has been recognized for a cell. 


### CellTapped event

This event will be triggered while tapping the SfDataGrid with `DataGridCellTappedEventArgs` properties as follows:

 * `RowIndex`: Gets row index of the tapped row.
 * `ColumnIndex`: Gets column index of the tapped column.
 * `RowData`: Gets row data of the tapped row.
 * `Column` : Gets the Corresponding Column.

To hook the `CellTapped` event, and to get the tapped row and column details, follow the code example:

{% tabs %}
{% highlight xaml %}
<sfgrid:SfDataGrid x:Name="dataGrid"
                   AutoGenerateColumns="True"
                   CellTapped="dataGrid_CellTapped"
                   ItemsSource="{Binding OrdersInfo}" />
{% endhighlight %}
{% highlight c# %}
private void DataGrid_CellTapped(object sender, DataGridCellTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column.HeaderText;
}
{% endhighlight %}
{% endtabs %}

### CellDoubleTapped event

This event will be triggered while double tapping the SfDataGrid with `DataGridCellDoubleTappedEventArgs` properties as follows:

 * `RowIndex`: Gets row index of the tapped row.
 * `ColumnIndex`: Gets column index of the tapped column.
 * `RowData`: Gets row data of the tapped row.
 * `Column` : Gets the Corresponding Column.

To hook the `CellDoubleTapped` event, and to get the double tapped row and column details, follow the code example:  

{% tabs %}
{% highlight xaml %}
<sfgrid:SfDataGrid x:Name="dataGrid"
                   AutoGenerateColumns="True"
                   CellDoubleTapped="DataGrid_CellDoubleTapped"
                   ItemsSource="{Binding OrdersInfo}" />
{% endhighlight %}
{% highlight c# %}
private void DataGrid_CellDoubleTapped(object sender, DataGridCellDoubleTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column.HeaderText;
}
{% endhighlight %}
{% endtabs %}

### CellLongPress event

This event will be triggered while long pressing the SfDataGrid with `DataGridCellLongPressEventArgs` properties as follows:

 * `RowIndex`: Gets row index of the tapped row.
 * `ColumnIndex`: Gets column index of the tapped column.
 * `RowData`: Gets row data of the tapped row.
 * `Column` : Gets the Corresponding Column.

To hook the `CellLongPress` event, and to get the long pressed row and column details, follow the code example: 

{% tabs %}
{% highlight xaml %}
<sfgrid:SfDataGrid x:Name="dataGrid"
                   AutoGenerateColumns="True"
                   CellLongPress="DataGrid_CellLongPress"
                   ItemsSource="{Binding OrdersInfo}" />
{% endhighlight %}
{% highlight c# %}
private void DataGrid_CellLongPress(object sender, DataGridCellLongPressEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column.HeaderText;
}
{% endhighlight %}
{% endtabs %}
