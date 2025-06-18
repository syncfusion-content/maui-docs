---
layout: post
title: Performance in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Scrolling performance in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui performance, maui performance
---

# Performance in MAUI DataGrid (SfDataGrid)

## LoadUIView

By default, the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) loads a `UIElement` into the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) to display the cell content. The [DataGridColumn.LoadUIView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_LoadUIView) property determines whether to load a `UIElement` or to draw the cell content directly within the `DataGridCell` to improve scrolling performance. This is applicable for the all platforms except Windows.

If `LoadUIView` is set to `false`, the cell content will be drawn directly in the grid cell to enhance performance. However, when `LoadUIView` is set to `true`, the cell content will be displayed through the `UIElement`.

The `LoadUIView` property also applies to the image column, allowing images to be drawn directly in the `DataGridCell` instead of loading them through the `Image` control. To draw images in the `DataGridCell`, the source must be loaded using the [ImageSource.FromResource()](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.imagesource.fromresource?view=net-maui-9.0) method.

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

* For Android platform, both implicit and explicit padding are not supported. However, left and right padding will be applied based on the padding, while the top and bottom positions will be adjusted based on the content.
* [DataGridColumn.LineBreakMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_LineBreakMode) is not supported for Android platform.
* Runtime theme changes will not be applied.
* This is not supported for [DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html) and [DataGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxColumn.html).

## Data virtualization

DataGrid provides support to handle the large amount of data through built-in virtualization feature. With Data virtualization, the record entries will be created in the runtime only upon scrolling to the vertical end which increases the performance of grid loading time.

To set [SfDataGrid.EnableDataVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EnableDataVirtualization) property to true, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding EmployeeDetails}"
                       EnableDataVirtualization="True"/>
{% endhighlight %}

{% highlight c# %}
dataGrid.EnableDataVirtualization = true;
{% endhighlight %}
{% endtabs %}

## Incremental loading

The DataGrid supports loading data incrementally using the [ISupportIncrementalLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISupportIncrementalLoading.html) interface. This interface includes the `LoadMoreItemsAsync` method, which helps to load data incrementally. The `LoadMoreItemsAsync` method is called on-demand while scrolling, based on the [HasMoreItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISupportIncrementalLoading.html#Syncfusion_Maui_Data_ISupportIncrementalLoading_HasMoreItems) property.

If `HasMoreItems` is false, SfDataGrid stops calling `LoadMoreItemsAsync`. SfDataGrid includes `IncrementalList`, which is derived from `ISupportIncrementalLoading`. You can use `IncrementalList` or create a collection derived from `ISupportIncrementalLoading` and bind it to [SfDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource).

Additionally, the [SfDataGrid.DataFetchSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DataFetchSize) property defines the count argument in the `LoadMoreItemsAsync` method, which determines the amount of data to be loaded into the items source when the user reaches the end of the `SfDataGrid`.

In the code below, `IncrementalList` is initialized by passing an Action to its constructor for loading items incrementally.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid DataFetchSize="20"
                       ItemsSource="{Binding IncrementalItemsSource}" />
{% endhighlight %}

{% highlight c# %}
public class ViewModel
{
    public ViewModel()
    {
        IncrementalItemsSource = new IncrementalList<OrderInfo>(LoadMoreItems) { MaxItemsCount = 200 };
    }
    private IncrementalList<OrderInfo> _incrementalItemsSource;

    public IncrementalList<OrderInfo> IncrementalItemsSource
    {
         get { return _incrementalItemsSource; }
         set { _incrementalItemsSource = value; }
    }

    async void LoadMoreItems(uint count, int baseIndex)
    {
   
             var _orders = this.GenerateOrders();
             var list = GenerateOrders().Skip(baseIndex).Take(5).ToList();
             IncrementalItemsSource.LoadItems(list);
    }
}
{% endhighlight %}
{% endtabs %}

## Asynchronous Scrolling

The DataGrid provides support for asynchronous scrolling to enhance scrolling performance during large scroll jumps, especially on the Windows platform.

When the `AllowAsyncScrolling` property is enabled, the DataGrid renders content asynchronously while scrolling rapidly. This approach improves the perceived performance by reducing UI thread blocking and delivering smoother scrolling behavior.

By default, the `AllowAsyncScrolling` property is set to `false`. To improve scrolling performance, set this property to `true`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding EmployeeDetails}"
                       AllowAsyncScrolling="True"/>
{% endhighlight %}

{% highlight c# %}
dataGrid.AllowAsyncScrolling = true;
{% endhighlight %}
{% endtabs %}

N> Asynchronous scrolling is supported for all column types only on the Windows platform.
