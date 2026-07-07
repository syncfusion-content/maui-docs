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

To enable load more functionality in SfDataGrid, set the [SfDataGrid.AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowLoadMore) property to `true` and specify a [SfDataGrid.LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreOption). When enabled, an interactive load more button appears when the user scrolls to the end of the list. Users can tap this button (or the grid automatically loads more data, depending on the option) to load additional items from your data source.

## Load more command

The [SfDataGrid.LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreCommand) is an `ICommand` that executes when the user triggers a load more action. Use [SfDataGrid.LoadMoreCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreCommandParameter) to pass the DataGrid instance or other context to your command.

**Managing the loading state:**
Set the [SfDataGrid.IsBusy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IsBusy) property to `true` before loading items — this displays a loading indicator and prevents duplicate load requests. Set it to `false` after the load completes (success or failure). The loading indicator remains visible until `IsBusy` is set to `false`.


**Example: Basic load more with command:**

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
        try
        {
            await Task.Delay(new TimeSpan(0, 0, 5)); // Simulate network delay
            viewModel.LoadMoreItems();
        }
        catch (Exception ex)
        {
            // Handle errors (e.g., network failures, timeouts)
            await DisplayAlert("Error", "Failed to load more items: " + ex.Message, "OK");
        }
        finally
        {
            this.dataGrid.IsBusy = false;
        }
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid showing load more button at bottom with activity indicator" src="Images\loadmore\maui-datagrid-loadmoreview.gif" width="404"/>

You can download the complete project from [GitHub](https://github.com/SyncfusionExamples/Load-More-.net-maui-datagrid/tree/master).

## Load More Option

The `SfDataGrid.LoadMoreOption` property determines when the load more action is triggered. The default option is **Manual**.

| Option | Behavior |
|--------|----------|
| [Manual](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreOption.html#Syncfusion_Maui_DataGrid_DataGridLoadMoreOption_Manual) | Displays a "Load More" button at the end. User must tap to trigger `LoadMoreCommand`. |
| [Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreOption.html#Syncfusion_Maui_DataGrid_DataGridLoadMoreOption_Auto) | Automatically executes `LoadMoreCommand` when the list reaches the end (even before user interaction). |
| [AutoOnScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreOption.html#Syncfusion_Maui_DataGrid_DataGridLoadMoreOption_AutoOnScroll) | Executes `LoadMoreCommand` only when the user scrolls to the end (not on initial load). |

### Configure load more options

All three options use the same command pattern. Here are examples for each:

#### Auto (automatic loading at end)
{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowLoadMore="True"
                       LoadMoreOption="Auto"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGrid.AllowLoadMore = true;
DataGrid.LoadMoreOption = DataGridLoadMoreOption.Auto;
DataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);

private async void ExecuteLoadMoreCommand()
{
    DataGrid.IsBusy = true;
    try
    {
        await Task.Delay(1000); // Simulate network delay
        ViewModel.LoadMoreItems();
    }
    finally
    {
        DataGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% endtabs %}

#### Manual (button appears at end)
{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowLoadMore="True"
                       LoadMoreOption="Manual"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

#### AutoOnScroll (automatic when user scrolls to end)
{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowLoadMore="True"
                       LoadMoreOption="AutoOnScroll"
                       LoadMoreCommand="{Binding LoadMoreCommand}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

> **Note:** `LoadMoreCommand` is not executed on initial page load with `AutoOnScroll`. It only triggers after user scrolling.

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

<img alt="DataGrid with load more button positioned at top of list" src="Images\loadmore\maui-datagrid-loadmoreview-loadmoreposition-top.png" width="404"/>

### Appearance
Customize the load more view appearance using the following `DataGridStyle` properties:

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
                       LoadMoreOption="Manual">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle LoadMoreBackground="#FFF1F6"
                                  LoadMoreButtonBackground="#FFAFCC"
                                  LoadMoreButtonTextColor="#c1121f"
                                  LoadMoreIndicatorColor="#CDB4DB" />
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();

        viewModel = new OrderInfoViewModel();

        dataGrid = new SfDataGrid
        {
            ItemsSource = viewModel.Orders,
            AllowLoadMore = true,
            LoadMoreOption = DataGridLoadMoreOption.Manual,
            DefaultStyle = new DataGridStyle
            {
                LoadMoreBackground = Color.FromArgb("#FFF1F6"),
                LoadMoreButtonBackground = Color.FromArgb("#FFAFCC"),
                LoadMoreButtonTextColor = Color.FromArgb("#C1121F"),
                LoadMoreIndicatorColor = Color.FromArgb("#CDB4DB")
            }
        };

        this.Content = dataGrid;
    }
}

{% endhighlight %}
{% endtabs %}

<img alt="DataGrid load more button with custom pink and red color scheme" src="Images\loadmore\maui-datagrid-loadmoreview-loadmore-custom-appearance.png" width="404"/>

## Change load more view size

You can customize the load more view size by setting the `HeightRequest` and `WidthRequest` properties on the load more view and button. See the following example:

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

<img alt="DataGrid with resized load more button displaying custom text" src="Images\loadmore\maui-datagrid-loadmoreview-loadmore-custom-text-and-size.png" width="404"/>

## Custom load more view

You can replace the built-in load more view with a custom view to match your app's design. Create a class that inherits from `DataGridLoadMoreView` and override the required methods.

**When to use:** When the built-in load more button doesn't match your UI design or you need custom behavior (e.g., displaying a progress ring instead of a button).

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
        try
        {
            await Task.Delay(new TimeSpan(0, 0, 5));
            viewModel.LoadMoreItems();
        }
        finally
        {
            dataGrid.IsBusy = false;
        }
    }
}

// Custom load more view implementation
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

<img alt="DataGrid with custom load more view displaying custom label" src="Images\loadmore\maui-datagrid-custom-loadmoreview.png" width="404"/>