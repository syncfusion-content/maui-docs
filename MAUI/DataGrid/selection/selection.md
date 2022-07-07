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
This event will be triggered while tapping a cell in DataGrid. This event has [DataGridCellTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html) as arguments.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellTapped="dataGrid_CellTapped"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void dataGrid_CellTapped(object sender,DataGridCellTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}

### CellDoubleTapped event

This event will be triggered while double tapping a cell in DataGrid. This event has [DataGridCellDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellDoubleTappedEventArgs.html) as arguments. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellDoubleTapped="dataGrid_CellDoubleTapped"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void dataGrid_CellDoubleTapped(object sender, DataGridCellDoubleTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}

### CellLongPress event

This event will be triggered while long pressing a cell in DataGrid. This event has [DataGridCellLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellLongPressEventArgs.html) as arguments. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellLongPress="dataGrid_CellLongPress"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void dataGrid_CellLongPress(object sender,DataGridCellLongPressEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}