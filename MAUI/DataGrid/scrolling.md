---
layout: post
title: Scrolling in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Scrolling support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
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
this.dataGrid.ScrollToRowColumnIndex(15, 4, true, ScrollToPosition.Start);
{% endhighlight %}
{% endtabs %}

### Scrolling to the row index

You can scroll programmatically to a particular row using the `SfDataGrid.ScrollToRowIndex` method by passing the row index.

{% tabs %}
{% highlight C# %}
this.dataGrid.ScrollToRowIndex(30, true, ScrollToPosition.End);
{% endhighlight %}
{% endtabs %}

### Scrolling to the column index

You can scroll programmatically to a particular column using the `SfDataGrid.ScrollToColumnIndex` method by passing the column index.

{% tabs %}
{% highlight C# %}
this.dataGrid.ScrollToColumnIndex(4, true, ScrollToPosition.MakeVisible);
{% endhighlight %}
{% endtabs %}

## Scrollbar Visibility

You can change the visibility of the horizontal and vertical scrollbar using the [SfDataGrid.HorizontalScrollBarVisibility]() and [SfDataGrid.VerticalScrollBarVisibility]() properties respectively. By default, the visibility of both the horizontal and vertical scrollbars is set to `Default`.

{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"                                       
                       ItemsSource="{Binding OrdersInfo}"         
                       HorizontalScrollBarVisibility="Never"
                       VerticalScrollBarVisibility="Never">   
    </sfgrid:SfDataGrid> 
{% endhighlight %}

{% highlight C# %}
namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        ViewModel viewModel;
        SfDataGrid dataGrid;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            dataGrid = new SfDataGrid();
            dataGrid.ItemsSource = viewModel.OrdersInfo;   
            dataGrid.HorizontalScrollBarVisibility = ScrollBarVisibility.Never;
            dataGrid.VerticalScrollBarVisibility = ScrollBarVisibility.Never;
            this.Content = dataGrid;
        }
    }
}
{% endhighlight %}
{% endtabs %}

N> These properties does not have any effect when the datagrid has no scrollable content in its respective direction. In such cases scroll bar will not be displayed