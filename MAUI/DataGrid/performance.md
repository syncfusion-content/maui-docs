---
layout: post
title: Performance in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Scrolling performance in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Performance in MAUI DataGrid (SfDataGrid)

## LoadUIView

By default, the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) loads a `UIElement` into the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) to display the cell content. The `DataGridColumn.LoadUIView` property determines whether to load a `UIElement` or to draw the cell content directly within the `DataGridCell` on the Android platform to improve scrolling performance. This is applicable only for the android platform as of now.

If `LoadUIView` is set to `false`, the cell content will be drawn directly in the grid cell to enhance performance. However, when `LoadUIView` is set to `true`, the cell content will be displayed through the `UIElement`.

The default value of this property is `true`. If you want to improve loading and scrolling performance, you can simply set the `LoadUIView` property to `false`.

{% tabs %}
{% highlight xaml %}
<sfgrid:SfDataGrid ItemsSource="{Binding OrdersInfo}">
    <sfgrid:SfDataGrid.Columns>
        <sfgrid:DataGridNumericColumn MappingName="OrderID" HeaderText="Order ID" LoadUIView="False"/>
        <sfgrid:DataGridTextColumn MappingName="CustomerID" HeaderText="Customer ID" LoadUIView="False"/>
    </sfgrid:SfDataGrid.Columns>
</sfgrid:SfDataGrid>
{% endhighlight %}
{% endtabs %}

N> Download demo application from [GitHub](https://github.com/SyncfusionExamples/How-to-improve-scrolling-performance-in-.NET-MAUI-DataGrid).

### Limitations

* Both implicit and explicit padding are not supported. However, left and right padding will be applied based on the padding, while the top and bottom positions will be adjusted based on the content.

* `DataGridColumn.LineBreakMode` is not supported.

* Runtime theme changes will not be applied.

* This is not supported for [DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html), [DataGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxColumn.html) and [DataGridImageColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html).