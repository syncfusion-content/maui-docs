---
layout: post
title: Grid Events in MAUI DataGrid control | Syncfusion
description: Learn here all about data grid events that help identify interactions on the cell, and listen to cell value changes in the Syncfusion MAUI DataGrid (SfDataGrid) control, and learn more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Grid Events in MAUI DataGrid (SfDataGrid)

## Cell Tap Events

The `Datagrid` provides the following events for handling interactions with the cells.

* [CellTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTapped) : Called when a tap on a cell has occurred.
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
private void dataGrid_CellTapped(object sender, DataGridCellTappedEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}

## CellTappedCommand and Parameter
When we tapped the cell, the `CellTappedComamnd` binds to the command which you defined in your ViewModel. With this we can also use the `CellTappedCommandParameter` to be passed to the `Command` when it is executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellTapped="dataGrid_CellTapped"
                   CellTappedCommand="{Binding ButtonCommand}"
                   CellTappedCommandParameter="7"
                   ItemsSource="{Binding OrderInfoCollection}" />
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

## CellDoubleTappedCommand and Parameter
When we double tapped the cell, the `CellDoubleTappedCommand` binds to the command which you defined in your ViewModel. With this we can also use the `CellDoubleTappedCommandParameter` to be passed to the `Command` when it is executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellDoubleTapped="dataGrid_CellDoubleTapped"
                   CellDoubleTappedCommand="{Binding ButtonCommand}"
                   CellDoubleTappedCommandParameter="8"
                   ItemsSource="{Binding OrderInfoCollection}" />
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
private void dataGrid_CellLongPress(object sender, DataGridCellLongPressEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}

## CellLongPressedCommand and its Parameter
When we long presssed the cell, the `CellLongPressedCommand` binds to the command which you defined in your ViewModel. With this we can also use the `CellLongPressedCommandParameter` to be passed to the `Command` when it is executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellLongPressed="dataGrid_CellLongPressed"
                   CellLongPressedCommand="{Binding ButtonCommand}"
                   CellLongPressedCommandParameter="8"
                   ItemsSource="{Binding OrderInfoCollection}" />
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
private void SfDataGrid_CellRightTapped(object sender, DataGridCellRightTappedEventArgs e)
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

## CellRightTapped Command and its Parameter
When the cell is right tapped, the `CellRightTappedCommand` binds to the command which you defined in your ViewModel. With this we can also use the `CellRightTappedCommandParameter` to be passed to the `Command` when it is executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellRightTapped="dataGrid_CellRightTapped"
                   CellRightTappedCommand="{Binding ButtonCommand}"
                   CellRightTappedCommandParameter="8"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% endtabs %}

## Cell Pointer Events

The `Datagrid` provides the following events for handling mouse pointer interactions with the cells.

* [CellEntered](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellEntered) : Called when the mouse pointer enters the cell.
* [CellHovered](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellHovered) : Called when the mouse pointer hovers over the cell.
* [CellExited](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellExited)  : Called when the mouse pointer exits the cell.

### CellEntered event
This event will be triggered when the mouse pointer enters a cell in the DataGrid. It uses [DataGridCellEnteredEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellEnteredEventArgs.html) as its argument.

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

## CellEntered Command and Parameter
When the cell is entered into the grid, the `CellEnteredCommand` binds to the command which you defined in your ViewModel. With this we can also use the `CellEnteredCommandParameter` to be passed to the `Command` when it is executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellEntered="dataGrid_CellEntered"
                   CellEnteredCommand="{Binding ButtonCommand}"
                   CellEnteredCommandParameter="8"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% endtabs %}

### CellHovered event
This event will be triggered when the mouse pointer hovers over a cell in the DataGrid. It uses [DataGridCellHoveredEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellHoveredEventArgs.html) as its argument.

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

## CellHovered Command and Parameter
When the cell is hovered, the `CellHoveredCommand` binds to the command which you defined in your ViewModel. With this we can also use the `CellHoveredParameter` to be passed to the `Command` when it is executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellHovered="dataGrid_CellHovered"
                   CellHoveredCommand="{Binding ButtonCommand}"
                   CellHoveredCommandParameter="8"
                   ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% endtabs %}

### CellExited event
This event will be triggered when the mouse pointer exits a cell in the DataGrid. It uses [DataGridCellExitedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellExitedEventArgs.html) as its argument.

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

## CellExited Command and Parameter
When the cell is exited, the `CellExitedCommand` binds to the command which you defined in your ViewModel. With this we can also use the `CellExitedCommandParameter` to be passed to the `Command` when it is executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                   CellExited="dataGrid_CellExited"
                   CellExitedCommand="{Binding ButtonCommand}"
                   CellExitedCommandParameter="8"
                   ItemsSource="{Binding OrderInfoCollection}" />
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