---
layout: post
title: Load More in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Load More support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Load More in MAUI DataGrid (SfDataGrid)

The DataGrid enables the LoadMore option when the `SfDataGrid.AllowLoadMore` property is set to `true`, and also by setting the SfDataGrid.`LoadMoreCommand` property. When LoadMore is enabled, the control loads a subset of data to its data source at runtime using DataGridLoadMoreView.

When the grid reaches maximum offset while scrolling down, an interactive DataGridLoadMoreView is displayed. Tapping the load more view triggers a command to add more data to the data source of the grid at runtime.

## Load more command
The DataGrid loads records to its data source at runtime by triggering an ICommand bound to the `SfDataGrid.LoadMoreCommand` property. When the DataGridLoadMoreView is tapped, the CanExecute of the ICommand returns true, and this command is triggered to load the records at runtime.

Set the `SfDataGrid.IsBusy` property to true before loading items to notify the grid that more items are to be loaded. Set the property to false after loading items into the grid. When loading items, alter the time for the LoadMore animation from the sample by setting a delay based on the requirement.

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

//ViewModel.cs
public OrderInfoRepository()
{
    orderInfo = this.GenerateOrders(25);
}


//ItemsSource
private ObservableCollection<OrderInfo> orderInfo;
public ObservableCollection<OrderInfo> OrderInfoCollection
{
    get { return orderInfo; }
    set { this.orderInfo = value; }
}

//ItemsSource Generator
public ObservableCollection<OrderInfo> GenerateOrders(int count)
{
    ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();
    for (int i = 1000; i <= 1000 + count; i++)
    {
        var order = new OrderInfo(i, 
            CustomerID[random.Next(7)],
            Country[random.Next(7)], 
            Customer[random.Next(7)], 
            ShipCity[random.Next(7)]);
        orders.Add(order);
    }
    return orders;            
}

public void LoadMoreItems()
{
    for (int i = 0; i < 10; i++)
        this.OrderInfoCollection.Add(this.GenerateOrderInfo(OrderInfoCollection.Count));
}


public OrderInfo GenerateOrderInfo(int count)
{
    var order = new OrderInfo(
        count + 1000, CustomerID[random.Next(7)],
        Country[random.Next(7)],
        Customer[random.Next(7)],
        ShipCity[random.Next(7)]);

    return order;
}
```
![DataGridLoadMoreView](Images\loadmore\maui-datagrid-loadmoreview.gif)

## Customize DataGridLoadMoreView

### Customize DataLoadMoreView display text
Customize the text displayed in the `LoadMoreView` by setting the `SfDataGrid.LoadMoreText` property as follows:

```C#
//setting load more text in SfDataGrid
dataGrid.LoadMoreText = "Load More Items";
//We need to set the width of the button according to the LoadMoreText
dataGrid.LoadMoreView.Children.OfType<Button>().ToList()[0].WidthRequest = 150;
```
![DataGridLoadMore with LoadMoreText](Images\loadmore\maui-datagrid-loadmoreview-loadmoretext.png)

### Customize DataLoadMoreView position
Customize the displayed DataLoadMoreView to either top or bottom based on the requirement.

```C#
//Enable load more in SfDataGrid
dataGrid.LoadMorePosition = DataGridLoadMorePosition.Top;
```
**Top**

![DataGridLoadMore with LoadMorePosition Top](Images\loadmore\maui-datagrid-loadmoreview-loadmoreposition-top.png)


**Bottom**

![DataGridLoadMore with LoadMorePosition Bottom](Images\loadmore\maui-datagrid-loadmoreview-loadmoreposition-bottom.png)

### Customize DataLoadMoreView Appearance
We can customize the appearance of the DataGridLoadMoreView using the following properties.

* LoadMoreBackground
* LoadMoreButtonBackground
* LoadMoreButtonTextColor
* LoadMoreIndicatorColor

#### LoadMoreBackground
![DataGrid with LoadMoreView Background](Images\loadmore\maui-datagrid-loadmoreview-loadmoreview-background.png)


#### LoadMoreButtonBackground

![DataGrid with LoadMoreButton Background](Images\loadmore\maui-datagrid-loadmoreview-loadmore-button-background.png)
#### LoadMoreButtonTextColor

![DataGrid with LoadMoreButtonTextColor](Images\loadmore\maui-datagrid-loadmoreview-loadmoreview-button-textcolor.png)
#### LoadMoreIndicatorColor

![DataGrid with LoadMoreIndicatorColor](Images\loadmore\maui-datagrid-loadmoreview-loadmoreview-indicator-color.png)

### Customize DataGridLoadMoreView Size
The data grid allows you to customize the size of the DataGridLoadMoreView by setting the LoadMoreView. HeightRequest and LoadMoreView. WidthRequest properties. Refer to the below code example to customize the width and height of the LoadMoreView.

```C#
dataGrid.LoadMoreView.HeightRequest = 105;
// Below code changes the width of the LoadMoreView
// dataGrid.LoadMoreView.WidthRequest = 150;
```

## Custom LoadMore View
The data grid also customizes DataGridLoadMoreView based on the requirements. To do this, write a custom LoadMoreView class inheriting from DataGridLoadMoreView and perform the LoadMoreOperation.

To customize LoadMoreView, follow the code example:

```C#
public class CustomLoadMoreView : DataGridLoadMoreView
{
    private Label loadMoreView;
    private TapGestureRecognizer gestureRecognizer;

    protected override void SetLoadMoreViewStyle(DataGridStyle style)
    {
        this.Background = style.LoadMoreBackground;
    }
    public CustomLoadMoreView()
    {
        this.HeightRequest = 50;
        this.gestureRecognizer = new TapGestureRecognizer();
        loadMoreView = new Label() { HeightRequest = 25, WidthRequest = 150,HorizontalTextAlignment = TextAlignment.Center };
        loadMoreView.Text = "Load More Items";
        this.Children.Add(loadMoreView);
        gestureRecognizer.Tapped += loadMoreView_Tapped;
        loadMoreView.GestureRecognizers.Add(gestureRecognizer);
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
        (loadMoreView as IView).Measure(widthConstraint, heightConstraint);

        return new Size(widthConstraint, heightConstraint);
    }

    protected override Size ArrangeContent(Rect bounds)
    {
        (loadMoreView as IView).Arrange(bounds);
        return bounds.Size;
    }
}
```
![DataGrid with CustomLoadMoreView](Images\loadmore\maui-datagrid-custom-loadmoreview.png)
