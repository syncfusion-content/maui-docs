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

The DataGrid provides multiple optimization techniques to enhance performance for different scenarios:
- **LoadUIView**: Basic optimization for all data sizes; disables UI element wrapping to reduce overhead
- **Data Virtualization**: For large datasets (100+ records); creates records on-demand during scrolling
- **Incremental Loading**: For remote data sources; loads data in batches as users scroll to the end
- **Asynchronous Scrolling**: For smooth performance during rapid scrolling on Windows (available for all column types)

Choose based on your data source type (local vs. remote) and dataset size. You can combine techniques for optimal results.

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

**Note:** Download demo application from [GitHub](https://github.com/SyncfusionExamples/How-to-improve-scrolling-performance-in-.NET-MAUI-DataGrid).

### Limitations

* For Android platform, both implicit and explicit padding are not supported. However, left and right padding will be applied based on the padding, while the top and bottom positions will be adjusted based on the content.
* [DataGridColumn.LineBreakMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_LineBreakMode) is not supported for Android platform.
* Runtime theme changes will not be applied.
* The `LoadUIView` property is not applicable to [DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html) and [DataGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxColumn.html).

## Data virtualization

DataGrid provides support to handle large datasets through built-in virtualization. With data virtualization, record entries are created at runtime only upon scrolling to the vertical end, which significantly improves grid loading time.

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

The DataGrid supports loading data incrementally using the [ISupportIncrementalLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISupportIncrementalLoading.html) interface. This interface includes the `LoadMoreItemsAsync` method, which is called on-demand when the user scrolls within a threshold distance from the end of the grid. This is ideal for binding to remote data sources (APIs, databases) where you load data in batches.

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

The DataGrid provides support for asynchronous scrolling to enhance scrolling performance during rapid scroll gestures or large scroll jumps. This feature is most effective on the Windows platform.

When the `AllowAsyncScrolling` property is enabled, the DataGrid renders content asynchronously while scrolling rapidly. This approach:
- Reduces UI thread blocking during continuous scrolling
- Improves scrolling responsiveness and frame consistency
- Enables smoother rendering of complex cell templates

**Performance Impact:** Asynchronous scrolling may use additional memory during scroll operations but provides noticeable performance improvements on high-end devices with large datasets.

By default, the `AllowAsyncScrolling` property is set to `false`. To enable asynchronous scrolling, set this property to `true`.

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

**Note:**  Asynchronous scrolling is supported for all column types only on the Windows platform.
