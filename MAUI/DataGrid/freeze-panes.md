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

In the [Syncfusion® .NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) (SfDataGrid) control, you can freeze rows and columns in view, similar to Excel. You can freeze rows and columns by setting the following properties:

| Property name | Description |
|---------------|-------------|
| [FrozenRowCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenRowCount) | Sets the number of rows to freeze at the top of the DataGrid |
| [FooterFrozenRowCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FooterFrozenRowCount) | Sets the number of rows to freeze at the bottom (footer) of the DataGrid |
| [FrozenColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenColumnCount) | Sets the number of columns to freeze at the left side of the DataGrid |
| [FooterFrozenColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FooterFrozenColumnCount) | Sets the number of columns to freeze at the right side of the DataGrid |

To get start quickly with freeze rows and columns in .NET MAUI DataGrid, you can check on this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src="https://www.youtube.com/embed/vtMmQIWyipU?start=550"></iframe>

## Freeze columns

You can freeze columns in view, similar to Excel, by setting the `SfDataGrid.FrozenColumnCount` property to a non-negative value.

The following code snippet shows how to freeze columns in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" FrozenColumnCount="1" />
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Freeze columns .NET MAUI DataGrid](Images\freeze-panes\maui-datagrid-freeze-columns.gif)

## Freeze footer columns

You can freeze footer columns in view, similar to Excel, by setting the `SfDataGrid.FooterFrozenColumnCount` property to a non‑negative value.

The following code snippet shows how to freeze footer columns in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" FooterFrozenColumnCount="1" />
</ContentPage>
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-footer-rows" src="Images\freeze-panes\maui-datagrid-freeze-footer-columns.gif" width="404" Height = "396"/>

### Limitations

* The `FrozenColumnCount` and `FooterFrozenColumnCount` value should be less than the number of columns displayed in the view. For example, if you have 5 columns in the view, you can set the `FrozenColumnCount` and `FooterFrozenColumnCount` value to a maximum of 4.

## Freeze rows

You can freeze rows in view, similar to Excel, by setting the `SfDataGrid.FrozenRowCount` property to a non-negative value.

The following code snippet shows how to freeze rows in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" FrozenRowCount="1" />
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Freeze rows .NET MAUI DataGrid](Images\freeze-panes\maui-datagrid-freeze-rows.gif)

## Freeze footer rows

You can freeze footer rows in view, similar to Excel, by setting the `SfDataGrid.FooterFrozenRowCount` property to a non‑negative value.

The following code snippet shows how to freeze footer rows in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" FooterFrozenRowCount="1" />
</ContentPage>
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-footer-rows" src="Images\freeze-panes\maui-datagrid-freeze-footer-rows.gif" width="404" Height = "396"/>

### Limitations

* The `FrozenRowCount` and `FooterFrozenRowCount` value should be less than the number of rows displayed in the view. For example, if you have 10 rows in the view, you can set the `FrozenRowCount` and `FooterFrozenRowCount` value to a maximum of 9.

## Appearance

### Freeze pane line color

The DataGrid allows you to customize the color of the freeze pane line using the [DataGridStyle.FreezePaneLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_FreezePaneLineColor) property.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" FrozenColumnCount="1" FrozenRowCount="1">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle FreezePaneLineColor="Orange" />
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
</ContentPage> 
{% endhighlight %}
{% endtabs %}

![Customize freeze panes appearance in .NET MAUI DataGrid](Images\freeze-panes\maui-datagrid-freeze-panes-appearance.png)

### Freeze pane line thickness

The DataGrid provides an option to customize the thickness of the freeze pane line using the [DataGridStyle.FreezePaneLineStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_DataGridStyle_FreezePaneLineStrokeThickness) property. This property defines the stroke width for all frozen rows and columns in both the body and footer regions

N> The default value of `FreezePaneLineStrokeThickness` is 1.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" FrozenColumnCount="1" FrozenRowCount="1">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle FreezePaneLineStrokeThickness="5" />
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
</ContentPage> 
{% endhighlight %}
{% endtabs %}

<img alt="maui-datagrid-freeze-panes-strokethickness" src="Images\freeze-panes\maui-datagrid-freeze-panes-strokethickness.png" width="404" Height = "396"/>