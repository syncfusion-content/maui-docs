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

The [SfDataGrid.VerticalOverScrollMode]() property customizes the vertical scrolling behavior in the data grid, specifically controlling the bouncing effect when the user scrolls beyond the grid boundaries. This property helps to define whether users should experience a smooth, elastic pull effect or a strict stop when reaching the start or end of the scrollable content.

The `VerticalOverScrollMode` property is of type `DataGridVerticalScrollMode` and provides the following two modes:

## Bounce

In Bounce mode, the data grid exhibits a bouncing effect when scrolled past the content boundaries. This effect creates a spring-back animation, giving users feedback that they've reached the edge of the data grid.

* `Android`: The default value is None, meaning bounce is disabled unless explicitly set.

* `IOS`: The default value is Bounce, allowing a natural iOS-style bounce effect.

This behavior is useful for improving user experience by making interactions more dynamic and responsive.

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

## None
In None mode, the bouncing effect is completely disabled, and the data grid stops scrolling as soon as it reaches the content boundaries. This mode is useful when we want to provide a more rigid scrolling experience, especially in scenarios where bouncing might seem unnecessary or distracting.

To customize the bouncing effect in the data grid, follow the code example:
{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"                                       
                       ItemsSource="{Binding OrderInfoCollection}"         
                        VerticalOverScrollMode="None">   
    </sfgrid:SfDataGrid> 
{% endhighlight %}

{% highlight C# %}  
dataGrid.VerticalOverScrollMode = DataGridVerticalOverScrollMode.None;
{% endhighlight %}
{% endtabs %}

With this configuration, the grid halts scrolling precisely at the content edges, without any additional movement or visual feedback.

By configuring the `VerticalOverScrollMode`, we can tailor the scrolling behavior to match your application's design requirements, providing either a fluid, dynamic experience or a more rigid, controlled interaction. This flexibility ensures that your data grid feels natural and responsive, enhancing the overall user experience.

 <img alt="Vertical-OverScroll-Mode" src="Images\scrolling\Vertical-OverScroll-Mode.png" width="404" height="396"/>