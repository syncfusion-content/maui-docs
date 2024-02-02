---
layout: post
title: Load More in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Load More support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Load More in MAUI DataGrid (SfDataGrid)

The SfDataGrid enables the load more option when the [SfDataGrid.AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowLoadMore) property is set to true. When the load more feature is enabled, an interactive load more view will be displayed on the datagrid only when the datagrid reaches the maximum scroll offset while scrolling down. It loads a subset of data into its data source at runtime when users tap the [DataGridLoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMoreView.html).

## Load more command
The datagrid loads a subset of data to its data source at runtime by triggering an ICommand bound to the [SfDataGrid.LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreCommand) property. It will be executed when the user taps the load more view.

Set the [SfDataGrid.IsBusy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IsBusy ) property to true before loading items to notify the datagrid that more items are about to be loaded. Set the property to false after successfully loading items into the datagrid. When loading items, customize the duration for displaying the activity indicator by introducing a delay based on specific requirements.

To enable and load items at runtime, follow the code example:

{% tabs %}
{% highlight c# %}

dataGrid.AllowLoadMore = true;
dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
 
private async void ExecuteLoadMoreCommand()
{
    this.dataGrid.IsBusy = true;
    await Task.Delay(new TimeSpan(0, 0, 5));
    viewModel.LoadMoreItems();
    this.dataGrid.IsBusy = false;
} 

{% endhighlight %}
{% endtabs %}

<img alt="DataGridLoadMoreView" src="Images\loadmore\maui-datagrid-loadmoreview.gif" width="404"/>

You can download the complete project of this demo from [GitHub](https://github.com/SyncfusionExamples/Load-More-.net-maui-datagrid/tree/master).

## Customization

### Display text
Customize the text displayed in the load more view by setting the [SfDataGrid.LoadMoreText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMoreText) property as follows:

{% tabs %}
{% highlight c# %}

dataGrid.LoadMoreText = "LOAD MORE";

{% endhighlight %}
{% endtabs %}

### Position
The position of load more view can be customized by using the [SfDataGrid.LoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMorePosition) property. By default, the load more view is displayed in the bottom position.

{% tabs %}
{% highlight c# %}

dataGrid.LoadMorePosition = DataGridLoadMorePosition.Top;

{% endhighlight %}
{% endtabs %}

<img alt="DataGridLoadMore with LoadMorePosition Top" src="Images\loadmore\maui-datagrid-loadmoreview-loadmoreposition-top.png" width="404"/>

### Appearance
The appearance of the built-in load more view can be personalized through the following properties:

<table>
<tr>
<th> Property</th>
<th> Description </th>
</tr>
<tr>
<td> {{'[LoadMoreBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreBackground)'| markdownify }} </td>
<td> Sets the Background of the load more view.</td>
</tr>
<tr>
<td> {{'[LoadMoreButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreButtonBackground)'| markdownify }} </td>
<td> Sets the Background of the load more view button.</td>
</tr>
<tr>
<td> {{'[LoadMoreButtonTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreButtonTextColor)'| markdownify }} </td>
<td> Sets the Text color of the load more view button.</td>
</tr>
<tr>
<td> {{'[LoadMoreIndicatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_LoadMoreIndicatorColor)'| markdownify }} </td>
<td>  Sets the Background of the load more view indicator.</td>
</tr>
</table>


<img alt="DataGridLoadMore with customized appearance" src="Images\loadmore\maui-datagrid-loadmoreview-loadmore-custom-appearance.png" width="404"/>

## Change load more view Size

The data grid allows to customize the size of the load more view by setting the `HeightRequest` and `WidthRequest` properties. Refer the below code example to customize the width and height of the load more view.

{% tabs %}
{% highlight c# %}

dataGrid.LoadMoreText = "Load More Items";
dataGrid.LoadMoreView.HeightRequest = 50;
dataGrid.LoadMoreView.Children.OfType<Button>().First().WidthRequest = 150;

{% endhighlight %}
{% endtabs %}

<img alt="DataGridLoadMore with customized text and size" src="Images\loadmore\maui-datagrid-loadmoreview-loadmore-custom-text-and-size.png" width="404"/>

## Custom load more View

The datagrid offers built-in support for configuring a custom load more view to meet your specific requirements.

The following code snippets demonstrate how to enable a custom load more view in the datagrid:

{% tabs %}
{% highlight c# %}

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

<img alt="DataGrid with CustomLoadMoreView" src="Images\loadmore\maui-datagrid-custom-loadmoreview.png" width="404"/>