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
this.dataGrid.ScrollToRowColumnIndex(15, 4, ScrollToPosition.Start, ScrollToPosition.Start, true);
{% endhighlight %}
{% endtabs %}

### Scrolling to the row index

You can scroll programmatically to a particular row using the `SfDataGrid.ScrollToRowIndex` method by passing the row index.

{% tabs %}
{% highlight C# %}
this.dataGrid.ScrollToRowIndex(30, ScrollToPosition.End, true);
{% endhighlight %}
{% endtabs %}

### Scrolling to the column index

You can scroll programmatically to a particular column using the `SfDataGrid.ScrollToColumnIndex` method by passing the column index.

{% tabs %}
{% highlight C# %}
this.dataGrid.ScrollToColumnIndex(4, ScrollToPosition.MakeVisible, true);
{% endhighlight %}
{% endtabs %}

## Scrolling mode

The `SfDataGrid` allows you to customize three different scrolling modes using the [SfDataGrid.ScrollingMode]() property. By default, the control scrolls content based on pixel values. The `ScrollingMode` property supports both vertical and horizontal scrolling. The available scrolling modes are:

 - Pixel
 - Line
 - PixelLine

### Pixel
In the `DataGridScrollingMode.Pixel` mode, users can scroll through the data based on pixel values. The view updates with each change in the offset, and a row or column may appear cropped when the offset exceeds the origin of the row or column.

{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"                                       
                       ItemsSource="{Binding OrderInfoCollection}"         
                       ScrollingMode = "Pixel">   
    </sfgrid:SfDataGrid> 
{% endhighlight %}

{% highlight C# %}
this.dataGrid.ScrollingMode = DataGridScrollingMode.Pixel;
{% endhighlight %}
{% endtabs %}

<img alt="ScrollingMode-Pixel" src="Images\scrolling\maui-datagrid-ScrollingMode-Pixel.gif" width="404" />

### Line
The `DataGridScrollingMode.Line` mode allows users to scroll the DataGrid's contents by lines. The view updates only when the offset values reach the origin of a row or column in the bound collection.

{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"                                       
                       ItemsSource="{Binding OrderInfoCollection}"         
                       ScrollingMode = "Line">   
    </sfgrid:SfDataGrid> 
{% endhighlight %}

{% highlight C# %}
this.dataGrid.ScrollingMode = DataGridScrollingMode.Line;
{% endhighlight %}
{% endtabs %}

<img alt="ScrollingMode-Pixel" src="Images\scrolling\maui-datagrid-ScrollingMode-Line.gif" width="404"/>

### PixelLine
The `DataGridScrollingMode.PixelLine` mode allows users to scroll the contents like an Excel sheet. If a row or column is clipped at the top, it will automatically scroll to display the entire row or column.

{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"                                       
                       ItemsSource="{Binding OrderInfoCollection}"         
                       ScrollingMode = "PixelLine">   
    </sfgrid:SfDataGrid> 
{% endhighlight %}

{% highlight C# %}
this.dataGrid.ScrollingMode = DataGridScrollingMode.PixelLine;
{% endhighlight %}
{% endtabs %}

<img alt="ScrollingMode-Pixel" src="Images\scrolling\maui-datagrid-ScrollingMode-PixelLine.gif" width="404" />

### Limitations

The `ScrollingMode` has certain limitations that should be considered:

 - Switching between modes at runtime is not supported.
 - The `DataGridScrollingMode.Line` does not support master details view.
 - The `DataGridScrollingMode.Line` will not be worked as expected when row height is customized through [SfDatagrid.QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowHeight) event.

## Diagonal scrolling

By default, the `SfDataGrid` allows both vertical and horizontal scrolling simultaneously (diagonal scrolling). By setting [SfDataGrid.AllowDiagonalScrolling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDiagonalScrolling) to false, you ensure that scrolling happens in only one direction at a time, either horizontally or vertically.

The following code snippets demonstrate how to disable diagonal scrolling:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AllowDiagonalScrolling="False">
  </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight C# %}  
this.dataGrid.AllowDiagonalScrolling = false;
{% endhighlight %}
{% endtabs %}

## Scrollbar Visibility

The visibility of the horizontal and vertical scrollbars can be customized using the [SfDataGrid.HorizontalScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HorizontalScrollBarVisibilityProperty) and [SfDataGrid.VerticalScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalScrollBarVisibilityProperty) properties. By default, the visibility of both the horizontal and vertical scrollbars is set to `ScrollBarVisibility.Default`.

The following code snippets demonstrate how to hide the vertical and horizontal scrollbars:

{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"                                       
                       ItemsSource="{Binding OrderInfoCollection}"         
                       HorizontalScrollBarVisibility="Never"
                       VerticalScrollBarVisibility="Never">   
    </sfgrid:SfDataGrid> 
{% endhighlight %}

{% highlight C# %}  
namespace DataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ViewModel viewModel = new ViewModel();
            SfDataGrid dataGrid = new SfDataGrid();
            dataGrid.ItemsSource = viewModel.OrdersInfo;   
            dataGrid.HorizontalScrollBarVisibility = ScrollBarVisibility.Never;
            dataGrid.VerticalScrollBarVisibility = ScrollBarVisibility.Never;
            this.Content = dataGrid;
        }
    }
}
{% endhighlight %}
{% endtabs %}

N> These properties do not have any effect when the datagrid has no scrollable content in its respective direction. In such cases, the scroll bar will not be displayed.

## Vertical Over Scroll Mode

The [SfDataGrid.VerticalOverScrollMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalOverScrollMode) property customizes the vertical scrolling behavior in the data grid by controlling the bouncing effect when the user scrolls beyond the grid's boundaries. This property defines whether users experience a smooth, elastic pull effect or a strict stop when reaching the start or end of the scrollable content.

The [VerticalOverScrollMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalOverScrollMode) property is of the type `DataGridVerticalScrollMode` and offers the following two modes:

- **Bounce**: This mode enables the grid to apply a bounce effect when the user scrolls beyond the boundaries. It is the default value for the iOS platform.
- **None**: This mode prevents the grid from applying the bounce effect. It is the default value for the Android platform.

To customize the bouncing effect in the data grid, follow the code example:
{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"                                       
                       ItemsSource="{Binding OrderInfoCollection}"         
                       VerticalOverScrollMode="Bounce">   
    </sfgrid:SfDataGrid> 
{% endhighlight %}

{% highlight C# %}  
dataGrid.VerticalOverScrollMode = DataGridVerticalOverScrollMode.Bounce;
{% endhighlight %}
{% endtabs %}

 <img alt="Vertical-OverScroll-Mode" src="Images\scrolling\maui-datagrid-verticaloverscrollMode.gif" width="404" height="396"/>
