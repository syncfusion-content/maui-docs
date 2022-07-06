---
layout: post
title: Selection in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Grid Events support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Grid Events in .NET MAUI DataGrid (SfDataGrid)

## Cell Tap Events

The datagrid provides the following Events to handle interactions to the cells,

* [CellTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTapped) : Called when a tap with a cell has occurred.
* [CellDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellDoubleTapped) : Called when user is tapped a cell with a primary button at the same cell twice in quick succession.
* [CellLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellLongPress) : Called when a long press gesture with a primary button has been recognized for a cell. 


### CellTapped event

This event will be triggered while tapping the SfDataGrid with [DataGridCellTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html) properties as follows:

 * [RowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellTappedEventArgs_RowColumnIndex): Gets Row and column index of the tapped column.
 * [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellTappedEventArgs_RowData): Gets row data of the tapped row.
 * [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellTappedEventArgs_Column) : Gets the Corresponding Column.

To hook the `CellTapped` event, and to get the tapped row and column details, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellTapped="dataGrid_CellTapped"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# %}
private void dataGrid_CellTapped(object sender,DataGridCellTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column.HeaderText;
}
{% endhighlight %}
{% endtabs %}

### CellDoubleTapped event

This event will be triggered while double tapping the SfDataGrid with [DataGridCellDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellDoubleTappedEventArgs.html) properties as follows:

 * [RowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellDoubleTappedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellDoubleTappedEventArgs_RowColumnIndex): Gets Row and column index of the tapped column.
 * [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellDoubleTappedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellDoubleTappedEventArgs_RowData): Gets row data of the tapped row.
 * [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellDoubleTappedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellDoubleTappedEventArgs_Column) : Gets the Corresponding Column.

To hook the `CellDoubleTapped` event, and to get the double tapped row and column details, follow the code example:  

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellDoubleTapped="dataGrid_CellDoubleTapped"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# %}
private void dataGrid_CellDoubleTapped(object sender, DataGridCellDoubleTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column.HeaderText;
}
{% endhighlight %}
{% endtabs %}

### CellLongPress event

This event will be triggered while long pressing the SfDataGrid with [DataGridCellLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellLongPressEventArgs.html) properties as follows:

 * [RowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellLongPressEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellLongPressEventArgs_RowColumnIndex): Gets Row and column index of the tapped column.
 * [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellLongPressEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellLongPressEventArgs_RowData): Gets row data of the tapped row.
 * [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellLongPressEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellLongPressEventArgs_Column) : Gets the Corresponding Column.

To hook the `CellLongPress` event, and to get the long pressed row and column details, follow the code example: 

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellDoubleTapped="dataGrid_CellDoubleTapped"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# %}
private void dataGrid_CellLongPress(object sender,DataGridCellLongPressEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column.HeaderText;
}
{% endhighlight %}
{% endtabs %}