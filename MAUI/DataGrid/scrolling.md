---
layout: post
title: Scrolling in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Scrolling support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui scrolling, maui scrolling
---

# Scrolling in MAUI DataGrid (SfDataGrid)

## Programmatic scrolling

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) allows scrolling to a particular row and column index programmatically. It also enables and disables the scrolling animation when changing the view. By default, the scrolling will be animated.

You can set position of item in view while scrolling by passing [ScrollToPosition](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.scrolltoposition?view=net-maui-6.0) to [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_), [ScrollToColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ScrollToColumnIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) and [ScrollToRowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ScrollToRowColumnIndex_System_Int32_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) method. Below are four different types of positions:

* `MakeVisible`: Scrolls a specific item to make visible in the view. If the item is already in view, scrolling will not occur.
* `Start`: Scrolls a specific item to be positioned at the begin of the view.
* `End`: Scrolls a specific item to be positioned at the end of the view.
* `Center`: Scrolls a specific item to be positioned at the center of the view.

### Scrolling to the row and column index

You can scroll programmatically to a particular row and column using the `SfDataGrid.ScrollToRowColumnIndex` method by passing the row and column index.

{% tabs %}
{% highlight C# %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid = new SfDataGrid();

    public MainPage()
    {
        InitializeComponent();

        var grid = new Grid();
        grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
        grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });

        Button button = new Button();
        button.Text = "Scroll To RowColumnIndex";

        grid.Children.Add(dataGrid);
        grid.Children.Add(button);
        grid.SetRow(dataGrid, 0);
        grid.SetRow(button, 1);

        OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = orderInfoViewModel.Orders;

        button.Clicked += Button_Clicked;
        this.Content = grid;
    }

    private void Button_Clicked(object? sender, EventArgs e)
    {
        dataGrid.ScrollToRowColumnIndex(15, 4, ScrollToPosition.Start, ScrollToPosition.Start, true);
    }
}
{% endhighlight %}
{% endtabs %}

### Scrolling to the row index

You can scroll programmatically to a particular row using the `SfDataGrid.ScrollToRowIndex` method by passing the row index.

{% tabs %}
{% highlight xaml %}
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>

    <Button Text="Scroll To RowIndex"
            Grid.Row="0"
            Clicked="ScrollToRowIndex_Mothod"/>

    <syncfusion:SfDataGrid x:Name="dataGrid"
                            Grid.Row="1"
                            ItemsSource="{Binding Orders}"/>
</Grid>
{% endhighlight %}
{% highlight C# %}
private void ScrollToRowIndex_Mothod(object sender, EventArgs e)
{
    dataGrid.ScrollToRowIndex(30, ScrollToPosition.End, true);
}
{% endhighlight %}
{% endtabs %}

### Scrolling to the column index

You can scroll programmatically to a particular column using the `SfDataGrid.ScrollToColumnIndex` method by passing the column index.

{% tabs %}
{% highlight xaml %}
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>

    <Button Text="Scroll To ColumnIndex"
            Grid.Row="0"
            Clicked="ScrollToColumnIndex_Mothod"/>

    <syncfusion:SfDataGrid x:Name="dataGrid"
                            Grid.Row="1"
                            ItemsSource="{Binding Orders}"/>
</Grid>
{% endhighlight %}
{% highlight C# %}
private void ScrollToColumnIndex_Mothod(object sender, EventArgs e)
{
    dataGrid.ScrollToColumnIndex(4, ScrollToPosition.MakeVisible, true);
}
{% endhighlight %}
{% endtabs %}

## Scrolling mode

The `SfDataGrid` allows you to customize three different scrolling modes using the [SfDataGrid.ScrollingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ScrollingMode) property. By default, the control scrolls content based on pixel values. The `ScrollingMode` property supports both vertical and horizontal scrolling. The available scrolling modes are:

 - Pixel
 - Line
 - PixelLine

### Pixel
In the `DataGridScrollingMode.Pixel` mode, users can scroll through the data based on pixel values. The view updates with each change in the offset, and a row or column may appear cropped when the offset exceeds the origin of the row or column.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           ScrollingMode="Pixel">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.ScrollingMode = DataGridScrollingMode.Pixel;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="ScrollingMode-Pixel" src="Images\scrolling\maui-datagrid-ScrollingMode-Pixel.gif" width="404" />

### Line
The `DataGridScrollingMode.Line` mode allows users to scroll the DataGrid's contents by lines. The view updates only when the offset values reach the origin of a row or column in the bound collection.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           ScrollingMode="Line">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.ScrollingMode = DataGridScrollingMode.Line;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="ScrollingMode-Pixel" src="Images\scrolling\maui-datagrid-ScrollingMode-Line.gif" width="404"/>

### PixelLine
The `DataGridScrollingMode.PixelLine` mode allows users to scroll the contents like an Excel sheet. If a row or column is clipped at the top, it will automatically scroll to display the entire row or column.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           ScrollingMode="PixelLine">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.ScrollingMode = DataGridScrollingMode.PixelLine;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="ScrollingMode-Pixel" src="Images\scrolling\maui-datagrid-ScrollingMode-PixelLine.gif" width="404" />

### Limitations

The `ScrollingMode` has certain limitations that should be considered:

 - Switching between modes at runtime is not supported.
 - The `DataGridScrollingMode.Line` does not support master details view.
 - The `DataGridScrollingMode.Line` will not be worked as expected when row height is customized through [SfDataGrid.QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowHeight) event and width is customized through [SfDataGrid.ColumnWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnWidthMode) property.

## Diagonal scrolling

By default, the `SfDataGrid` allows both vertical and horizontal scrolling simultaneously (diagonal scrolling). By setting [SfDataGrid.AllowDiagonalScrolling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDiagonalScrolling) to false, you ensure that scrolling happens in only one direction at a time, either horizontally or vertically.

The following code snippets demonstrate how to disable diagonal scrolling:

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           AllowDiagonalScrolling="False">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}  
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowDiagonalScrolling = false;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

## Scrollbar Visibility

The visibility of the horizontal and vertical scrollbars can be customized using the [SfDataGrid.HorizontalScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HorizontalScrollBarVisibilityProperty) and [SfDataGrid.VerticalScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalScrollBarVisibilityProperty) properties. By default, the visibility of both the horizontal and vertical scrollbars is set to `ScrollBarVisibility.Default`.

The following code snippets demonstrate how to hide the vertical and horizontal scrollbars:

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           HorizontalScrollBarVisibility="Never"
                           VerticalScrollBarVisibility="Never">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}  
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.HorizontalScrollBarVisibility = ScrollBarVisibility.Never;
dataGrid.VerticalScrollBarVisibility = ScrollBarVisibility.Never;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

N> These properties do not have any effect when the datagrid has no scrollable content in its respective direction. In such cases, the scroll bar will not be displayed.


## Over Scroll Mode
The `SfDataGrid` supports over-scroll behavior that controls the bounce effect when the user scrolls past the edges of its content. Use the `VerticalOverScrollMode` and `HorizontalOverScrollMode` properties to enable or disable bounce effects independently for each axis.

### Vertical Over Scroll Mode

The [SfDataGrid.VerticalOverScrollMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalOverScrollMode) property customizes the vertical scrolling behavior in the data grid by controlling the bouncing effect when the user scrolls beyond the grid's boundaries. This property defines whether users experience a smooth, elastic pull effect or a strict stop when reaching the start or end of the scrollable content.

The [VerticalOverScrollMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalOverScrollMode) property is of the type `DataGridVerticalScrollMode` and offers the following two modes:

- **Bounce**: This mode enables the grid to apply a bounce effect when the user scrolls beyond the boundaries. It is the default value for the iOS platform.
- **None**: This mode prevents the grid from applying the bounce effect. It is the default value for the Android platform.

To customize the bouncing effect in the data grid, follow the code example:
{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           VerticalOverScrollMode="Bounce">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}  
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.VerticalOverScrollMode = DataGridVerticalOverScrollMode.Bounce;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

 <img alt="Vertical-OverScroll-Mode" src="Images\scrolling\maui-datagrid-verticaloverscrollMode.gif" width="404" height="396"/>

### Horizontal Over Scroll Mode

The [SfDataGrid.HorizontalOverScrollMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HorizontalOverScrollMode) property customizes the horizontal scrolling behavior of the data grid by controlling the bounce effect when users scroll past the left or right edges of the grid. This setting determines whether the grid provides an elastic over‑scroll experience or stops strictly at the content boundary.

The [HorizontalOverScrollMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HorizontalOverScrollMode) property is of type `DataGridHorizontalScrollMode` and includes the following modes:

 - **Bounce**: Enables a bounce‑back animation when the user scrolls beyond the horizontal limits of the grid. This is the default mode on the iOS platform.
 - **None**: Disables the bounce effect, causing scrolling to stop immediately at the content edges. This is the default mode on the Android platform.

To customize the bouncing effect in the data grid, follow the code example:
{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           HorizontalOverScrollMode="Bounce">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}  
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.HorizontalOverScrollMode = DataGridHorizontalOverScrollMode.Bounce;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

 <img alt="Horizontal-OverScroll-Mode" src="Images\scrolling\maui-datagrid-Horizontal-overscroll-Mode.gif" width="404" height="396"/>

## Identifying scroll state changes

The `SfDataGrid` raises the [ScrollStateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_ScrollStateChanged) event whenever its scrolling state is changed.

The following current states are indicated by the [ScrollState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridScrollStateChangedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridScrollStateChangedEventArgs_ScrollState) property in the event argument.

- Dragging: Indicates that DataGrid is being dragged in the view right now.
- Fling: Indicates that fling action is performed on the DataGrid.
- Idle: Indicates that DataGrid is not currently scrolling.
- Programmatic: Indicates that the [ScrollToColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ScrollToColumnIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) or [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) methods are used for scrolling.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding Orders}"
                           ScrollStateChanged="dataGrid_ScrollStateChanged">
    </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight C# %}  
private void dataGrid_ScrollStateChanged(object sender, DataGridScrollStateChangedEventArgs e)
{
    if (e.ScrollState == DataGridScrollState.Idle)
    {
        DisplayAlert("ScrollState", "Scrolling has stopped", "OK");
    }
}
{% endhighlight %}
{% endtabs %}
