---
layout: post
title: Freeze panes in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about how to freeze rows and columns in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui freeze panes, maui freeze panes
---

# Freeze panes in MAUI DataGrid (SfDataGrid)

## Overview

Freezing panes allows you to keep specific rows and columns visible while scrolling through large datasets, similar to Excel. This is useful when you have headers or identifier columns that should remain visible during navigation. The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) (SfDataGrid) control supports freezing rows and columns independently at the top/bottom and left/right edges of the grid.


## Freeze Panes Properties

You can freeze rows and columns by setting the following properties:

| Property name | Type | Default | Description |
|---------------|------|---------|-------------|
| [FrozenRowCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenRowCount) | int | 0 | Sets the number of rows to freeze at the top of the DataGrid |
| [FooterFrozenRowCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FooterFrozenRowCount) | int | 0 | Sets the number of rows to freeze at the bottom of the DataGrid |
| [FrozenColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenColumnCount) | int | 0 | Sets the number of columns to freeze at the left side of the DataGrid |
| [FooterFrozenColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FooterFrozenColumnCount) | int | 0 | Sets the number of columns to freeze at the right side of the DataGrid |

To get started quickly with freeze rows and columns in .NET MAUI DataGrid, watch this video tutorial (starts at the freeze panes section):

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src="https://www.youtube.com/embed/vtMmQIWyipU?start=550"></iframe>

## Freeze columns

You can freeze columns by setting the `FrozenColumnCount` property to a non-negative value. Frozen columns remain visible when scrolling horizontally and are useful for identifier columns that should always be visible.

> **Note:** `OrderInfoViewModel` is a sample ViewModel class that provides an `Orders` collection. Replace it with your own data source ViewModel.

The following example shows how to freeze columns in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}" 
                       FrozenColumnCount = "1" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.FrozenColumnCount = 1;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-panes-columns" src="Images\freeze-panes\maui-datagrid-freeze-columns.gif" width="404" Height = "396"/>

### Limitations
* The `FrozenColumnCount` value must be less than the total number of columns in the DataGrid
* Frozen columns cannot exceed the available grid width on the current platform

## Freeze footer columns

You can freeze footer (rightmost) columns by setting the `FooterFrozenColumnCount` property to a non‑negative value. Footer frozen columns remain visible when scrolling horizontally and are useful for summary or action columns.

The following example shows how to freeze footer columns in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}" 
                       FooterFrozenColumnCount = "1" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.FooterFrozenColumnCount = 1;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-footer-rows" src="Images\freeze-panes\maui-datagrid-freeze-footer-columns.gif" width="404" Height = "396"/>

## Freeze rows

You can freeze rows by setting the `FrozenRowCount` property to a non-negative value. Frozen rows remain visible when scrolling vertically and are useful for header rows that should always be visible.

The following example shows how to freeze rows in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>
<syncfusion:SfDataGrid x:Name = "dataGrid"
                        ItemsSource = "{Binding Orders}" 
                        FrozenRowCount = "1" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.FrozenRowCount = 1;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-panes-rows" src="Images\freeze-panes\maui-datagrid-freeze-rows.gif" width="404" Height = "396"/>

### Limitations
* The `FrozenRowCount` value must be less than the total number of rows in the DataGrid
* Frozen rows cannot exceed the available grid height on the current platform

## Freeze footer rows

You can freeze footer (bottom) rows by setting the `FooterFrozenRowCount` property to a non‑negative value. Footer frozen rows remain visible when scrolling vertically and are useful for summary or total rows.

The following example shows how to freeze footer rows in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}" 
                       FooterFrozenRowCount = "1" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.FooterFrozenRowCount = 1;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-footer-rows" src="Images\freeze-panes\maui-datagrid-freeze-footer-rows.gif" width="404" Height = "396"/>

## Appearance

You can customize the visual appearance of freeze panes using `DataGridStyle`. Apply this style through the `SfDataGrid.DefaultStyle` property.

### Freeze pane line color

Customize the color of the line that divides frozen and non-frozen regions using the [DataGridStyle.FreezePaneLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_FreezePaneLineColor) property.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}" 
                       FrozenColumnCount = "1" 
                       FrozenRowCount = "1">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle FreezePaneLineColor="Orange" />
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.FrozenColumnCount = 1;
dataGrid.FrozenRowCount = 1;
DataGridStyle dataGridStyle = new DataGridStyle();
dataGridStyle.FreezePaneLineColor = Colors.Orange;
dataGrid.DefaultStyle = dataGridStyle;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-panes-appearance" src="Images\freeze-panes\maui-datagrid-freeze-panes-appearance.png" width="404" Height = "396"/>

### Freeze pane line thickness

Customize the thickness of the freeze pane line using the [DataGridStyle.FreezePaneLineStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_FreezePaneLineStrokeThickness) property. This affects all frozen rows and columns in both body and footer regions.

**Default value:** 1.0

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel />
</ContentPage.BindingContext>
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}" 
                       FrozenColumnCount = "1" 
                       FrozenRowCount = "1">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle FreezePaneLineStrokeThickness="5" />
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.FrozenColumnCount = 1;
dataGrid.FrozenRowCount = 1;
DataGridStyle dataGridStyle = new DataGridStyle();
dataGridStyle.FreezePaneLineStrokeThickness = 5;
dataGrid.DefaultStyle = dataGridStyle;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-panes-strokethickness" src="Images\freeze-panes\maui-datagrid-freeze-panes-strokethickness.png" width="404" Height = "396"/>

## Platform Considerations

- **Responsive Design:** Frozen pane counts should be adjusted based on available screen space for different device sizes
- **Cross-platform Behavior:** Freeze pane functionality works consistently across Android, iOS, macOS, and Windows platforms

## Interaction with Other Features

- Frozen rows and columns work with sorting, filtering, and selection
- Frozen content scrolls independently from non-frozen content