---
layout: post
title: Paging in .NET MAUI Data Grid | Syncfusion®
description: Learn how to enable and customize paging in Syncfusion® .NET MAUI Data Grid to efficiently navigate and manage large datasets.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui data grid, maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui paging, maui paging
appliesto: UI Component Suite, Grid SDK
---

# Paging in .NET MAUI Data Grid

The data grid interactively supports data manipulation through the [SfDataPager]() control, providing built-in options to page data on demand when dealing with large volumes. The `SfDataPager` can be placed above or below as needed to easily manage data paging.

To use paging functionality into the data grid, include the following namespace in your project:
`Syncfusion.Maui.DataPager`

There are two different modes in paging:

 * NormalPaging: It loads the entire data collection to the `SfDataPager`.
 * OnDemandPaging: It loads data to the current page dynamically in `SfDataPager`.

## Normal paging

The data grid performs data paging using the `SfDataPager`. To enable normal paging, follow these steps:

 * Create a new instance of `SfDataPager`, and bind the data collection to the `SfDataPager.Source` property. This will internally create `SfDataPager.PagedSource`. 
 * Bind the `PagedSource` property to the `ItemsSource` of the data grid. 
 * Set the `SfDataPager.PageSize` property to determine the number of rows to be displayed on each page.
 * Set the `SfDataPager.NumericButtonCount` property to specify the number of buttons that should be displayed in view."

> **Note:** The [SfDataPager.PageSize]() property should not be assigned with value 0. Setting PageSize to 0 will throw an `ArgumentException`.

The following code example illustrates using `SfDataPager` with the data grid control:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DataGridUGDemo"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:pager="clr-namespace:Syncfusion.Maui.DataGrid.DataPager;assembly=Syncfusion.Maui.DataGrid"
             x:Class="DataGridUGDemo.MainPage">

    <ContentPage.BindingContext>
        <local:OrderInfoViewModel x:Name = "viewModel"/>
    </ContentPage.BindingContext>

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height = "*" />
            <RowDefinition Height = "Auto" />
        </Grid.RowDefinitions>
        <Border Grid.Row = "1" Padding = "5">
            <pager:SfDataPager x:Name = "dataPager"
                               PageSize = "15" 
                               NumericButtonCount = "10"
                               Source = "{Binding Orders}">
            </pager:SfDataPager>
        </Border>
        <syncfusion:SfDataGrid x:Name = "dataGrid"
                               Grid.Row = "0"
                               ItemsSource = "{Binding Source={x:Reference dataPager}, Path=PagedSource}">
        </syncfusion:SfDataGrid>
    </Grid>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.DataPager;

public partial class MainPage : ContentPage
{
    // Note: The XAML approach above is the recommended method. This C# example demonstrates
    // programmatic creation for scenarios where declarative XAML markup is not available.
    public NormalPage()
    {
        InitializeComponent();
        SfDataPager dataPager = new SfDataPager();
        OrderInfoViewModel viewModel = new OrderInfoViewModel();
        dataPager.PageSize = 15;
        dataPager.NumericButtonCount = 10;
        dataPager.Source = viewModel.Orders;
        
        SfDataGrid dataGrid = new SfDataGrid();
        dataGrid.ItemsSource = dataPager.PagedSource;
        
        Border border = new Border();
        border.Padding = new Thickness(5);
        border.Content = dataPager;
        
        Grid grid = new Grid();
        grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
        grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        grid.Children.Add(dataGrid);
        grid.Children.Add(border);
        grid.SetRow(dataGrid, 0);
        grid.SetRow(border, 1);
        this.Content = grid;
    }
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the result of running the above code:

<img alt="Normal paging .NET MAUI Data Grid." src="Images\paging\net-maui-datagrid-normal-paging.png" width="404" Height = "429"/>

## On-Demand Paging	

In normal Paging, data collection is entirely loaded initially into the `SfDataPager`. However, the control also allows for dynamically loading the data for the current page by setting [SfDataPager.UseOnDemandPaging]() to `true`.

To load the current page item dynamically, hook into the `OnDemandLoading` event. In the `OnDemandLoading` event, use the `LoadDynamicItems` method to load data for the corresponding page in the `SfDataPager`.

To load data for the DataPager control dynamically, follow the code example:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height = "*" />
        <RowDefinition Height = "Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row = "1" Padding = "5">
        <pager:SfDataPager x:Name = "dataPager"
                           PageSize = "15" 
                           NumericButtonCount = "10"
                           Source = "{Binding Orders}"
                           OnDemandLoading="dataPager_OnDemandLoading"
                           UseOnDemandPaging="True">
        </pager:SfDataPager>
    </Border>
    <syncfusion:SfDataGrid x:Name = "dataGrid"
                           Grid.Row = "0"
                           ItemsSource = "{Binding Source={x:Reference dataPager}, Path=PagedSource}">
    </syncfusion:SfDataGrid>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.NumericButtonCount = 10;
dataPager.Source = viewModel.Orders;
dataPager.UseOnDemandPaging = true;
dataPager.OnDemandLoading += dataPager_OnDemandLoading;

SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = dataPager.PagedSource;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(dataGrid);
grid.Children.Add(border);
grid.SetRow(dataGrid, 0);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void dataPager_OnDemandLoading(object sender, OnDemandLoadingEventArgs e)
{
    dataPager.LoadDynamicItems(e.StartIndex, viewModel.Orders.Skip(e.StartIndex).Take(e.PageSize));
}
{% endhighlight %}
{% endtabs %}

## Limitations

- UI Filtering is not supported. You can implement filtering at the application level.
- Data processing operations (Sorting, Grouping) are performed only on the current page data.
- Row deletion is not supported through the UI. You can implement deletion at the application level.
- Only navigated pages are exported when OnDemandPaging is enabled. If you call `ResetCache()` to clear a page's data, that page will not be included in exports.
