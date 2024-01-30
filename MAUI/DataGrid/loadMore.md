---
layout: post
title: Load More in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Load More support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Load More in MAUI DataGrid (SfDataGrid)

TThe DataGrid enables the "Load More" option when the `SfDataGrid.AllowLoadMore` property is set to true. When the "Load More" feature is enabled, an interactive load more view will be displayed on the SfDataGrid only when the grid reaches the maximum scroll offset while scrolling down. It loads a subset of data into its data source at runtime when users tap the `DataGridLoadMoreView`.

## Load more command
The DataGrid loads a subset of data to its data source at runtime by triggering an ICommand bound to the `SfDataGrid.LoadMoreCommand` property. It will be executed when the user taps the load more view.

Set the `SfDataGrid.IsBusy` property to true before loading items to notify the grid that more items are about to be loaded. Set the property to false after successfully loading items into the grid. When loading items, customize the duration for displaying the activity indicator by introducing a delay based on specific requirements.

To enable and load items at runtime, follow the code example:

```C# 
//Enable load more in SfDataGrid
dataGrid.AllowLoadMore = true;
dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
 
private async void ExecuteLoadMoreCommand()
{
    this.dataGrid.IsBusy = true;
    await Task.Delay(new TimeSpan(0, 0, 5));
    viewModel.LoadMoreItems();
    this.dataGrid.IsBusy = false;
} 
```
<img alt="DataGridLoadMoreView" src="Images\loadmore\maui-datagrid-loadmoreview.gif" width="404"/>

## Customize DataGridLoadMoreView

### Customize load more view display text
Customize the text displayed in the LoadMoreView by setting the `SfDataGrid.LoadMoreText` property as follows:

```C#
//setting load more text in SfDataGrid
dataGrid.LoadMoreText = "LOAD MORE";
```

### Customize load more view position
The position of load more view can be customized by using the `SfDataGrid.LoadMorePosition` property. By default, the load more view is displayed in the bottom position.

```C#
//Enable load more in SfDataGrid
dataGrid.LoadMorePosition = DataGridLoadMorePosition.Top;
```
**Top**

<img alt="DataGridLoadMore with LoadMorePosition Top" src="Images\loadmore\maui-datagrid-loadmoreview-loadmoreposition-top.png" width="404"/>

### Appearance customization
The appearance of the built-in load more view can be personalized through the following properties:

<table>
<tr>
<th> Property</th>
<th> Description </th>
</tr>
<tr>
<td> {{'`LoadMoreBackground`'| markdownify }} </td>
<td> Sets the Background of the `DataGridLoadMoreView`.</td>
</tr>
<tr>
<td> {{'`LoadMoreButtonBackground`'| markdownify }} </td>
<td> Sets the Background of the `DataGridLoadMoreView` button.</td>
</tr>
<tr>
<td> {{'`LoadMoreButtonTextColor`'| markdownify }} </td>
<td> Sets the Text color of the `DataGridLoadMoreView` button.</td>
</tr>
<tr>
<td> {{'`LoadMoreIndicatorColor`'| markdownify }} </td>
<td>  Sets the Background of the `DataGridLoadMoreView` indicator.</td>
</tr>
</table>


<img alt="DataGridLoadMore with customized appearance" src="Images\loadmore\maui-datagrid-loadmoreview-loadmore-custom-appearance.png" width="404"/>


## Custom LoadMore View

The data grid offers built-in support for configuring a custom load more view to meet your specific requirements.

The following code snippets demonstrate how to enable a custom load more view in the data grid:

```C#
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
```

<img alt="DataGrid with CustomLoadMoreView" src="Images\loadmore\maui-datagrid-custom-loadmoreview.png" width="404"/>