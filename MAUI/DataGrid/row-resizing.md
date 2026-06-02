---
layout: post
title: Row Resizing in .NET MAUI DataGrid control | Syncfusion®
description: Learn about interactive row resizing support in Syncfusion® MAUI DataGrid (SfDataGrid) control and how to use the new API.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, row resizing, datagrid row height, maui datagrid row, sfdatagrid row resize
---

# Row Resizing in MAUI DataGrid (SfDataGrid)

The `SfDataGrid` supports interactive row resizing. When enabled, users can long-press the bottom edge of a row header to change that row's height. Resized heights are cached and preserved during scrolling.

N> Row resizing requires `ShowRowHeader = true` and is false by default.

## Enable row resizing

Set the `SfDataGrid.AllowResizingRows` property to `true` to enable interactive resizing.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       ShowRowHeader="True"
                       AllowResizingRows="True" />
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.ShowRowHeader = true;
dataGrid.AllowResizingRows = true;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-row-resizing" src="Images\row-resizing\net-maui-datagrid-row-resizing.gif" width="404" />

## Row resize mode

The `RowResizeMode` (type: `DataGridRowResizeMode`) determines when the requested height is applied during an interactive resize:

- `OnTouchUp` — the new height is applied when the user releases the pointer (touch-up or mouse-up).
- `OnMoved` — the new height is applied continuously as the resize indicator moves (live update).

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       ShowRowHeader="True"
                       AllowResizingRows="True"
                       RowResizeMode="OnMoved" />
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.ShowRowHeader = true;
dataGrid.AllowResizingRows = true;
dataGrid.RowResizeMode = DataGridRowResizeMode.OnMoved;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-row-resizing-mode" src="Images\row-resizing\net-maui-datagrid-row-resizing-onMoved.gif" width="404" />

## RowResizing event

Use `SfDataGrid.RowResizing` to validate or cancel resizes. The event provides `DataGridRowResizingEventArgs` with these properties:

- `RowIndex` — index of the row being resized
- `RowIndex` — index of the row being resized
- `RowData` — the underlying data item for the row
- `NewValue` — requested row height (device-independent pixels)
- `Cancel` — set to `true` to cancel the operation

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       ShowRowHeader="True"
                       AllowResizingRows="True"
                       RowResizing="DataGrid_RowResizing" />
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.ShowRowHeader = true;
dataGrid.AllowResizingRows = true;
this.Content = dataGrid;

public MainPage()
{
    InitializeComponent();
    SfDataGrid dataGrid = new SfDataGrid();
    OrderInfoViewModel viewModel = new OrderInfoViewModel();
    dataGrid.ItemsSource = viewModel.Orders;
    dataGrid.ShowRowHeader = true;
    dataGrid.AllowResizingRows = true;
    dataGrid.RowResizing += DataGrid_RowResizing;
    this.Content = dataGrid;
}

private void DataGrid_RowResizing(object? sender, DataGridRowResizingEventArgs e)
{
    if (e.NewValue < 20 || e.NewValue > 400)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Customize appearance

Change the indicator color with `DataGridStyle.RowResizingIndicatorColor`.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       ShowRowHeader="True"
                       AllowResizingRows="True">

  <syncfusion:SfDataGrid.DefaultStyle>
    <syncfusion:DataGridStyle RowResizingIndicatorColor="Red"/>
  </syncfusion:SfDataGrid.DefaultStyle>
        
</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.ShowRowHeader = true;
dataGrid.AllowResizingRows = true;
dataGrid.DefaultStyle = new DataGridStyle { RowResizingIndicatorColor = Colors.Red };
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-row-resizing-indicator-color" src="Images\row-resizing\net-maui-datagrid-row-resizing-style.gif" width="404" />
