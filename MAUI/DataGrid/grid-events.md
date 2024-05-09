---
layout: post
title: Grid Events in MAUI DataGrid control | Syncfusion
description: Learn here about data grid events and listen to cell value changes in the Syncfusion MAUI DataGrid (SfDataGrid) control, and learn more about it.
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

### CellTappedCommand
The `CellTappedCommand` will be invoked while tapping a cell in the SfDataGrid. The instance of `DataGridCellTappedEventArgs` will be passed as the default value of the command's parameter. It can be customized by setting the [CellTappedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTappedCommandParameter) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid CellTappedCommand="{Binding TapCommand}"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Command TapCommand = new Command(ListenTap);

private static void ListenTap(object obj)
{
    var args = obj as DataGridCellTappedEventArgs;
    if (args != null)
    {
        var rowIndex = e.RowColumnIndex.RowIndex;
        var rowData = e.RowData;
        var columnIndex = e.RowColumnIndex.ColumnIndex;
        var column = e.Column;
    }
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

### CellDoubleTappedCommand
The `CellDoubleTappedCommand` will be invoked while double tapping a cell in the SfDataGrid. The instance of `DataGridCellDoubleTappedEventArgs` will be passed as the default value of the command's parameter. It can be customized by setting the [CellDoubleTappedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellDoubleTappedCommandParameter) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid CellDoubleTappedCommand="{Binding DoubleTapCommand}"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Command DoubleTapCommand = new Command(ListenTap);

private static void ListenTap(object obj)
{
    var args = obj as DataGridCellDoubleTappedEventArgs;
    if (args != null)
    {
        var rowIndex = e.RowColumnIndex.RowIndex;
        var rowData = e.RowData;
        var columnIndex = e.RowColumnIndex.ColumnIndex;
        var column = e.Column;
    }
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
private void dataGrid_CellLongPress(object sender, DataGridCellLongPressEventArgs e)
{
    var rowIndex = e.RowColumnIndex.RowIndex;
    var rowData = e.RowData;
    var columnIndex = e.RowColumnIndex.ColumnIndex;
    var column = e.Column;
}
{% endhighlight %}
{% endtabs %}

### CellLongPressedCommand
The `CellLongPressedCommand` will be invoked while long-pressing a cell in the SfDataGrid. The instance of `DataGridCellLongPressEventArgs` will be passed as the default value of the command's parameter. It can be customized by setting the [CellLongPressedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellLongPressCommandParameter) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid CellLongPressedCommand="{Binding LongPressCommand}"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Command LongPressCommand = new Command(ListenTap);

private static void ListenTap(object obj)
{
    var args = obj as DataGridCellLongPressedEventArgs;
    if (args != null)
    {
        var rowIndex = e.RowColumnIndex.RowIndex;
        var rowData = e.RowData;
        var columnIndex = e.RowColumnIndex.ColumnIndex;
        var column = e.Column;
    }
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

### CellRightTappedCommand
The [CellRightTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellRightTappedCommand) will be invoked when a right-click mouse gesture is recognized on a cell in the SfDataGrid. The instance of `DataGridCellRightTappedEventArgs` will be passed as the default value of the command's parameter. It can be customized by setting the [CellRightTappedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellRightTappedCommandParameter) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid CellRightTappedCommand="{Binding RightTapCommand}"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Command RightTapCommand = new Command(ListenTap);

private static void ListenTap(object obj)
{
    var args = obj as DataGridCellRightTappedEventArgs;
    if (args != null)
    {
        var rowIndex = e.RowColumnIndex.RowIndex;
        var rowData = e.RowData;
        var columnIndex = e.RowColumnIndex.ColumnIndex;
        var column = e.Column;
    }
}
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

### CellEnteredCommand
The [CellEnteredCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellEnteredCommand) will be invoked when the mouse pointer enters a cell in the SfDataGrid. The instance of `DataGridCellEnteredEventArgs` will be passed as the default value of the command's parameter. It can be customized by setting the [CellEnteredCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellEnteredCommandParameter) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid CellEnteredCommand="{Binding EnteredCommand}"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Command EnteredCommand = new Command(ListenTap);

private static void ListenTap(object obj)
{
    var args = obj as DataGridCellEnteredEventArgs;
    if (args != null)
    {
        var rowIndex = e.RowColumnIndex.RowIndex;
        var rowData = e.RowData;
        var columnIndex = e.RowColumnIndex.ColumnIndex;
        var column = e.Column;
    }
}
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

### CellHoveredCommand
The [CellHoveredCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellHoveredCommand) will be invoked when the mouse pointer hovers over a cell in the SfDataGrid. The instance of `DataGridCellHoveredEventArgs` will be passed as the default value of the command's parameter. It can be customized by setting the [CellHoveredCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellHoveredCommandParameter) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid CellHoveredCommand="{Binding HoveredCommand}"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Command HoveredCommand = new Command(ListenTap);

private static void ListenTap(object obj)
{
    var args = obj as DataGridCellHoveredEventArgs;
    if (args != null)
    {
        var rowIndex = e.RowColumnIndex.RowIndex;
        var rowData = e.RowData;
        var columnIndex = e.RowColumnIndex.ColumnIndex;
        var column = e.Column;
    }
}
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

### CellExitedCommand
The [CellExitedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellExitedCommand) will be invoked when the mouse pointer exits a cell in the SfDataGrid. The instance of `DataGridCellExitedEventArgs` will be passed as the default value of the command's parameter. It can be customized by setting the [CellExitedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellExitedCommandParameter) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid CellExitedCommand="{Binding ExitedCommand}"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Command ExitedCommand = new Command(ListenTap);

private static void ListenTap(object obj)
{
    var args = obj as DataGridCellExitedEventArgs;
    if (args != null)
    {
        var rowIndex = e.RowColumnIndex.RowIndex;
        var rowData = e.RowData;
        var columnIndex = e.RowColumnIndex.ColumnIndex;
        var column = e.Column;
    }
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
## DataGridLoaded

This event will be triggered once components in the `SfDataGrid` initialized and rendered.

{% tabs %}

{% highlight c# %}

dataGrid.DataGridLoaded += DataGrid_GridLoaded;

private void DataGrid_GridLoaded(object? sender, EventArgs e)
{

}           
 
{% endhighlight %}

{% endtabs %}

## ViewCreated

This event will be triggered once the `SfDataGrid.View` is created.

{% tabs %}

{% highlight c# %}

dataGrid.ViewCreated += DataGrid_viewCreated;     
 
private void DataGrid_viewCreated(object? sender, EventArgs e)
{
           
}
{% endhighlight %}

{% endtabs %}

## ItemsSourceChanged

This event will be triggered once the source is changed in SfDataGrid

{% tabs %}

{% highlight c# %}

dataGrid.ItemsSourceChanged += DataGrid_DataGridItemsSourceChanged;

private void DataGrid_DataGridItemsSourceChanged(object? sender, DataGridItemsSourceChangedEventArgs e)
{
    var newItemSource = e.NewItemSource;
    var oldItemSource = e.OldItemSource;
    var newView = e.NewView;
    var oldView = e.OldView;
}

{% endhighlight %}

{% endtabs %}