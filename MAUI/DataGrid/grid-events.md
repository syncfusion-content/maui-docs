---
layout: post
title: Grid Events in MAUI DataGrid control | Syncfusion
description: Learn here all about Grid Events support in Syncfusion MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Grid Events in MAUI DataGrid (SfDataGrid)

## Cell Tap Events

The `Datagrid` provides the following Events to handle interactions to the cells.

* [CellTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTapped) : Called when a tap with a cell has occurred.
* [CellDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellDoubleTapped) : Called when the user has tapped a cell with a primary button at the same cell twice in quick succession.
* [CellLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellLongPress) : Called when a long-press gesture with a primary button has been recognized for a cell.
* [CellRightTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellRightTapped) : Called when a right-click mouse gesture has been recognized on a cell.

### CellTapped event
This event will be triggered while tapping a cell in the DataGrid. This event has the [DataGridCellTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html) as arguments.

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

This event will be triggered while double tapping a cell in the DataGrid. This event has the [DataGridCellDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellDoubleTappedEventArgs.html) as arguments. 

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

This event will be triggered while long pressing a cell in the DataGrid. This event has the [DataGridCellLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellLongPressEventArgs.html) as arguments. 

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

### CellRightTapped event
This event will be triggered when a right-click mouse gesture is recognized on a cell. This event has the [DataGridCellRightTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellRightTappedEventArgs.html) as arguments.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellRightTapped="SfDataGrid_CellRightTapped"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfDataGrid_CellRightTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellRightTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
    var pointerDeviceType = e.PointerDeviceType;
}
{% endhighlight %}
{% endtabs %}

N> The `CellRightTapped` event is only applicable for Windows and macOS.

## Cell Pointer Events

The `Datagrid` provides the following Events to handle mouse pointer interactions to the cells.

* [CellEntered]() : Called when the mouse pointer enters the cell.
* [CellHovered]() : Called when the mouse pointer is hovered over the cell.
* [CellExited]()  : Called when the mouse pointer exits the cell.

### CellEntered event
This event will be triggered when the mouse pointer enters a cell in the DataGrid. It uses [DataGridCellEnteredEventArgs]() as its argument.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellEntered="dataGrid_CellEntered"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void dataGrid_CellEntered(object sender, DataGridCellEnteredEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}

### CellHovered event
This event will be triggered when the mouse pointer hovers over a cell in the DataGrid. It uses [DataGridCellHoveredEventArgs]() as its argument.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellHovered="dataGrid_CellHovered"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void dataGrid_CellHovered(object sender, DataGridCellHoveredEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
    var point = e.Point;
}
{% endhighlight %}
{% endtabs %}

### CellExcited event
This event will be triggered when the mouse pointer exits a cell in the DataGrid. It uses [DataGridCellExitedEventArgs]() as its argument.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellExited="dataGrid_CellExited"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void dataGrid_CellExited(object sender, DataGridCellExitedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}

## CellValueChanged event

The [SfDataGrid.CellValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) event will be triggered whenever the current cell's value has been changed in the DataGridTextColumn, DataGridNumericColumn, DataGridDateColumn, DataGridComboBoxColumn or DataGridCheckBoxColumn. This event handler contains the parameter of type [DataGridCellValueChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellValueChangedEventArgs.html) that contains the following properties.

* [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellValueChangedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellValueChangedEventArgs_Column)        : Gets the current `DataGridColumn` that contains the grid cell for which value is edited or changed.
* [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellValueChangedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellValueChangedEventArgs_NewValue)      : The newly edited value to be committed.
* [RowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellValueChangedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellValueChangedEventArgs_RowColumnIndex)   : The current `RowColumnIndex` of the grid cell undergoing the value change.
* [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellValueChangedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellValueChangedEventArgs_RowData)       : The `RowData` of the row that contains the grid cell undergoing the value change.
* [CellValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellValueChangedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellValueChangedEventArgs_CellValue)       : The initial value when current cell entered edit mode.

{% tabs %}

{% highlight c# %}

        dataGrid.CellValueChanged += SfDataGrid_CellValueChanged;

        private void SfDataGrid_CellValueChanged(object sender, ValueChangedEventArgs e)
        {
            var column = e.Column;
            var newValue = e.NewValue;
            var rowColIndex = e.RowColIndex;
            var rowData = e.RowData;
        }

{% endhighlight %}

{% endtabs %}