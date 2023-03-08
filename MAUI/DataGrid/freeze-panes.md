---
layout: post
title: Freeze panes in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about how to freeze rows and columns in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Freeze panes in MAUI DataGrid (SfDataGrid)

In the Syncfusion .NET MAUI DataGrid (SfDataGrid) control, you can freeze rows and columns in view, similar to Excel. You can freeze rows and columns by setting the following properties:

| Property name | Description |
|---------------|-------------|
| `FrozenRowCount` | Sets the number of rows to freeze at the top of the DataGrid |
| `FrozenColumnCount` | Sets the number of columns to freeze at the left side of the DataGrid |

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

### Limitations

* The `FrozenColumnCount` value should be less than the number of columns displayed in the view. For example, if you have 5 columns in the view, you can set the `FrozenColumnCount` value to a maximum of 4.

## Freeze rows

You can freeze rows in view, similar to Excel, by setting the `SfDataGrid.FrozenRowCount` property to a non-negative value.

The following code snippet shows how to freeze rows in the DataGrid:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="http://schemas.syncfusion.com/maui">
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}" FrozenRowCount="2" />
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Freeze rows .NET MAUI DataGrid](Images\freeze-panes\maui-datagrid-freeze-rows.gif)

### Limitations

* The `FrozenRowCount` value should be less than the number of rows displayed in the view. For example, if you have 10 rows in the view, you can set the `FrozenRowCount` value to a maximum of 9.

## Appearance

The DataGrid allows you to customize the color of the freeze pane line using the `DataGridStyle.FreezePaneLineColor` property.

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