---
layout: post
title: Performance in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Scrolling performance in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui performance, maui performance
---

# Performance in MAUI DataGrid (SfDataGrid)

## LoadUIView

By default, the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) loads a `UIElement` into the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) to display the cell content. The [DataGridColumn.LoadUIView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_LoadUIView) property determines whether to load a `UIElement` or to draw the cell content directly within the `DataGridCell` on the Android platform to improve scrolling performance. This is applicable only for the android platform as of now.

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
* [DataGridColumn.LineBreakMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_LineBreakMode) is not supported.
* Runtime theme changes will not be applied.
* This is not supported for [DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html), [DataGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxColumn.html) and [DataGridImageColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html).

# Incremental loading

DataGrid supports to load the data incrementally using `ISupportIncrementalLoading` interface. `ISupportIncrementalLoading` interface has `LoadMoreItemsAsync` method which helps to load the data incrementally. `LoadMoreItemsAsync` called in on-demand while scrolling based on `HasMoreItems` property.

If `HasMoreItems` is false, SfDataGrid stops calling `LoadMoreItemsAsync`. SfDataGrid have `IncrementalList` which is derived from `ISupportIncrementalLoading`. You can use IncrementalList or create collection derived from `ISupportIncrementalLoading` and bind it `SfDataGrid.ItemsSource`.

Additionally it supports `DataFetchSize` , by which when the user reaches the end of the collection in the `dataGrid`, the data will be fetched automatically. The user can customize the size of the data to be fetched by setting the `DataFetchSize`.

In the below code, `IncrementalList` is initialized by passing Action to its constructor for loading items incrementally.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid 
                x:Name="dataGrid" 
                DataFetchSize="20"
                ItemsSource="{Binding IncrementalItemsSource}" />
{% endhighlight %}

{% highlight c# %}
public class viewModel
{
    private ObservableCollection<OrderInfo> _orders;
    public ObservableCollection<OrderInfo> Orders
    {
        get { return _orders; }
        set { _orders = value; }
    }

    public viewModel()
    {
        _orders = new ObservableCollection<OrderInfo>();
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
    private IEnumerable<OrderInfo> GenerateOrders()
    {
         _orders.Add(new OrderInfo("1001", "Maria Anders", "Germany", "ALFKI", "Berlin"));
         _orders.Add(new OrderInfo("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
         _orders.Add(new OrderInfo("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
         _orders.Add(new OrderInfo("1004", "Thomas Hardy", "UK", "AROUT", "London"));
         _orders.Add(new OrderInfo("1005", "Tim Adams", "Sweden", "BERGS", "London"));
         _orders.Add(new OrderInfo("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
         _orders.Add(new OrderInfo("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
         _orders.Add(new OrderInfo("1008", "Martin King", "Spain", "BOLID", "Madrid"));
         _orders.Add(new OrderInfo("1009", "Lenny Lin", "France", "BONAP", "Marsiella"));
         _orders.Add(new OrderInfo("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin"));
         _orders.Add(new OrderInfo("1011", "Laura King", "UK", "AROUT", "London"));
         _orders.Add(new OrderInfo("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
         _orders.Add(new OrderInfo("1013", "Martin King", "France", "BLONP", "Strasbourg"));
         _orders.Add(new OrderInfo("1014", "Gina Irene", "UK", "AROUT", "London"));
         return _orders;
    }
}
{% endhighlight %}
{% endtabs %}

## Data fetch size

Supports Incremental loading, by which when the user reaches the end of the collection in the `dataGrid`, the data will be fetched automatically. The user can customize the size of the data to be fetched by setting the `DataFetchSize`.

