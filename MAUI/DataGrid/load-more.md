---
layout: post
title: Load More in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Load More support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui load more, maui load more
---

# Load More in MAUI DataGrid (SfDataGrid)

The SfDataGrid enables the load more option when the [SfDataGrid.AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowLoadMore) property is set to true and [SfDataGrid.LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreOption) property is set. When the load more feature is enabled, an interactive load more view will be displayed on the datagrid only when the datagrid reaches the maximum scroll offset while scrolling down. It loads a subset of data into its data source at runtime when users tap the [DataGridLoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreView.html).

## Load more command
The datagrid loads a subset of data to its data source at runtime by triggering an ICommand bound to the [SfDataGrid.LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreCommand) property and [SfDataGrid.LoadMoreCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreCommandParameter) property. It will be executed when the user taps the load more view manually or when the user reaches the end.

Set the [SfDataGrid.IsBusy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IsBusy ) property to true before loading items to notify the datagrid that more items are about to be loaded. Set the property to false after successfully loading items into the datagrid. When loading items, customize the duration for displaying the activity indicator by introducing a delay based on specific requirements.

To enable and load items at runtime, follow the code example:

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowLoadMore = true;
        dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        this.Content = dataGrid;
    }

    private async void ExecuteLoadMoreCommand()
    {
        this.dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.LoadMoreItems();
        this.dataGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGridLoadMoreView" src="Images\loadmore\maui-datagrid-loadmoreview.gif" width="404"/>

You can download the complete project from [GitHub](https://github.com/SyncfusionExamples/Load-More-.net-maui-datagrid/tree/master).

## Load More Option

The `SfDataGrid.LoadMoreOption` property contains the following three different modes of operations:

 * [Manual](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreOption.html#Syncfusion_Maui_DataGrid_DataGridLoadMoreOption_Manual): Displays the load more button when reaching the end of the list and execute `SfDataGrid.LoadMoreCommand` when tapping the button.
 * [Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreOption.html#Syncfusion_Maui_DataGrid_DataGridLoadMoreOption_Auto): Automatically execute the `SfDataGrid.LoadMoreCommand` when reaching end of the list.
 * [AutoOnScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreOption.html#Syncfusion_Maui_DataGrid_DataGridLoadMoreOption_AutoOnScroll): Executes `SfDataGrid.LoadMoreCommand` when users interact with the datagrid and reach the end of list.

### Load more automatically

Set the [SfDataGrid.LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreOption) property as `Auto` to automatically load more items using the [SfDataGrid.LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreCommand) and [SfDataGrid.LoadMoreCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreCommandParameter) when reaching end of the list.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowLoadMore="True"
                       LoadMoreOption="Auto"
                       LoadMoreCommandParameter="{Reference DataGrid}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);

private async void ExecuteLoadMoreCommand()
{
    DataGrid.IsBusy = true;
    await Task.Delay(new TimeSpan(0, 0, 5));
    ViewModel.LoadMoreItems();
    DataGrid.IsBusy = false;
}
{% endhighlight %}
{% endtabs %}

### Load more manually

Set the `SfDataGrid.LoadMoreOption` property as `Manual` to load more items manually using the `SfDataGrid.LoadMoreCommand` and `SfDataGrid.LoadMoreCommandParameter` when tapping the load more button at end of the list.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowLoadMore="True"
                       LoadMoreOption="Manual"
                       LoadMoreCommandParameter="{Reference DataGrid}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);

private async void ExecuteLoadMoreCommand()
{
    DataGrid.IsBusy = true;
    await Task.Delay(new TimeSpan(0, 0, 5));
    ViewModel.LoadMoreItems();
    DataGrid.IsBusy = false;
}
{% endhighlight %}
{% endtabs %}

### Load more when user interacts

To load more items only when users interact with the datagrid and reach to the end of list using `SfDataGrid.LoadMoreCommand` and `SfDataGrid.LoadMoreCommandParameter`, set the `SfDataGrid.LoadMoreOption` property to [AutoOnScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreOption.html#Syncfusion_Maui_DataGrid_DataGridLoadMoreOption_AutoOnScroll).

The `SfDataGrid.LoadMoreCommand` will not execute when the datagrid is initially loaded. The `SfDataGrid.LoadMoreCommand` will execute only when users interact and reach to the end of list.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowLoadMore="True"
                       LoadMoreOption="AutoOnScroll"
                       LoadMoreCommandParameter="{Reference DataGrid}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);

private async void ExecuteLoadMoreCommand()
{
    DataGrid.IsBusy = true;
    await Task.Delay(new TimeSpan(0, 0, 5));
    ViewModel.LoadMoreItems();
    DataGrid.IsBusy = false;
}
{% endhighlight %}
{% endtabs %}

## Customization

### Display text
Customize the text displayed in the load more view by setting the [SfDataGrid.LoadMoreText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreText) property as follows:

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowLoadMore = true;
        dataGrid.LoadMoreText = "LOAD MORE";
        dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        this.Content = dataGrid;
    }

    private async void ExecuteLoadMoreCommand()
    {
        this.dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.LoadMoreItems();
        this.dataGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% endtabs %}

### Position
The position of load more view can be customized by using the [SfDataGrid.LoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMorePosition) property. By default, the load more view is displayed in the bottom position.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowLoadMore = true;
        dataGrid.LoadMorePosition = DataGridLoadMorePosition.Top;
        dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        this.Content = dataGrid;
    }

    private async void ExecuteLoadMoreCommand()
    {
        this.dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.LoadMoreItems();
        this.dataGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGridLoadMore with top position" src="Images\loadmore\maui-datagrid-loadmoreview-loadmoreposition-top.png" width="404"/>

### Appearance
The appearance of the built-in load more view can be personalized through the following properties:

<table>
<tr>
<th> Property</th>
<th> Description </th>
</tr>
<tr>
<td> {{'[LoadMoreBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreBackground)'| markdownify }} </td>
<td> Sets the background of the load more view.</td>
</tr>
<tr>
<td> {{'[LoadMoreButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreButtonBackground)'| markdownify }} </td>
<td> Sets the background of the load more view button.</td>
</tr>
<tr>
<td> {{'[LoadMoreButtonTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreButtonTextColor)'| markdownify }} </td>
<td> Sets the text color of the load more view button.</td>
</tr>
<tr>
<td> {{'[LoadMoreIndicatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreIndicatorColor)'| markdownify }} </td>
<td>  Sets the background of the load more view indicator.</td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowLoadMore="True"
                       LoadMoreOption="Manual"
                       LoadMoreCommandParameter="{Reference DataGrid}">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle LoadMoreBackground="#FFF1F6"
                                  LoadMoreButtonBackground="#FFAFCC"
                                  LoadMoreButtonTextColor="#c1121f"
                                  LoadMoreIndicatorColor="#CDB4DB" />
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);

private async void ExecuteLoadMoreCommand()
{
    DataGrid.IsBusy = true;
    await Task.Delay(new TimeSpan(0, 0, 5));
    ViewModel.LoadMoreItems();
    DataGrid.IsBusy = false;
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGridLoadMore with customized appearance" src="Images\loadmore\maui-datagrid-loadmoreview-loadmore-custom-appearance.png" width="404"/>

## Change load more view size

The data grid allows to customize the size of the load more view by setting the `HeightRequest` and `WidthRequest` properties. Refer the below code example to customize the width and height of the load more view and its button.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowLoadMore = true;
        dataGrid.LoadMoreText = "Load More Items";
        dataGrid.LoadMoreView.HeightRequest = 50;
        dataGrid.LoadMoreView.Children.OfType<Button>().First().WidthRequest = 150;
        dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        this.Content = dataGrid;
    }

    private async void ExecuteLoadMoreCommand()
    {
        dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.LoadMoreItems();
        dataGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGridLoadMore with customized text and size" src="Images\loadmore\maui-datagrid-loadmoreview-loadmore-custom-text-and-size.png" width="404"/>

## Custom load more view

The datagrid offers built-in support for configuring a custom load more view to meet your specific requirements.

The following code snippets demonstrate how to enable a custom load more view in the datagrid:

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowLoadMore = true;
        dataGrid.LoadMoreView = new CustomLoadMoreView();
        dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        this.Content = dataGrid;
    }

    private async void ExecuteLoadMoreCommand()
    {
        dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.LoadMoreItems();
        dataGrid.IsBusy = false;
    }
}

public class CustomLoadMoreView : DataGridLoadMoreView
{
    private Label? loadMoreView;

    protected override void SetLoadMoreViewStyle(DataGridStyle style)
    {
        this.Background = style.LoadMoreBackground;
    }

    protected override void InitLoadMoreView()
    {
        this.HeightRequest = 50;
        var gestureRecognizer = new TapGestureRecognizer();
        loadMoreView = new Label() { HeightRequest = 25, WidthRequest = 150, HorizontalTextAlignment = TextAlignment.Center };
        loadMoreView.Text = "Load More Items";
        loadMoreView.GestureRecognizers.Add(gestureRecognizer);
        this.Children.Add(loadMoreView);
        gestureRecognizer.Tapped += loadMoreView_Tapped;
    }
    
    void loadMoreView_Tapped(object? sender, EventArgs e)
    {
        if (this.LoadMoreCommand != null)
        {
            this.LoadMoreCommand.Execute(null);
        }
    }

    protected override Size MeasureContent(double widthConstraint, double heightConstraint)
    {
        (loadMoreView as IView)!.Measure(widthConstraint, heightConstraint);
        return new Size(widthConstraint, heightConstraint);
    }

    protected override Size ArrangeContent(Rect bounds)
    {
        (loadMoreView as IView)!.Arrange(bounds);
        return bounds.Size;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with custom load more view" src="Images\loadmore\maui-datagrid-custom-loadmoreview.png" width="404"/>