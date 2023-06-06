---
layout: post
title: Scrolling in .NET MAUI ListView control | Syncfusion
description: Learn here all about Scrolling support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Scrolling in .NET MAUI ListView (SfListView)

This section explains how to perform scrolling and its related operations in the `.NET MAUI ListView` (SfListView).

## Programmatic scrolling

### Scrolling to row index

The `SfListView` allows programmatically scrolling based on the index by using the [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html#Syncfusion_Maui_ListView_ListViewLayout_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) method for both linear and grid layouts. It also enables and disables the scrolling animation when changing the view. By default, the scrolling will be animated.

You can set position of an item in view while scrolling by passing `ScrollToPosition` to `ScrollToRowIndex` method. The following are four different types of positions:

* `MakeVisible`: Scrolls a specific item to make visible in the view. If the item is already in view, scrolling will not occur.
* `Start`: Scrolls a specific item to be positioned at the begin of the view.
* `End`: Scrolls a specific item to be positioned at the end of the view.
* `Center`: Scrolls a specific item to be positioned at the center of the view.

You can also scroll to specified data in `SfListView` using the [ScrollTo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_) method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

int index = listView.DataSource.DisplayItems.IndexOf(viewModel.BookInfo[2]); 
// Programmatic scrolling based on the item index.
listView.ItemsLayout.ScrollToRowIndex(index, Microsoft.Maui.Controls.ScrollToPosition.Center, true); 
// Programmatic scrolling based on the item data.
listView.ScrollTo(ViewModel.BookInfo[index], Microsoft.Maui.Controls.ScrollToPosition.Center, true);

{% endhighlight %}
{% endtabs %}

N> If grouping is enabled, get the desired row index by passing the underlying data in the [DisplayItems.IndexOf](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DisplayItems.html#Syncfusion_DataSource_DisplayItems_IndexOf_System_Object_) method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

int index = listView.DataSource.DisplayItems.IndexOf(viewModel.BookInfo[2]); 
listView.ItemsLayout.ScrollToRowIndex(index, true); 

{% endhighlight %}
{% endtabs %}

### Limitations

 * When [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode) is `Height` or grouping is enabled, the scroll animation will be disabled by default in Android and iOS platforms. 
 * If the [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html#Syncfusion_Maui_ListView_ListViewLayout_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) method is called on loading the `SfListView`, set `disableAnimation` to `true` to scroll to the appropriate row index, or else the view does not scroll in Android.
 * If the `ScrollToRowIndex` method is applied to a particular item index while the item is in Grouping or `AutoFitMode`, the particular item will get displayed in view but not in the exact position when the `ScrollToPosition` property is set as `MakeVisible` or `Center` for first time.
* The programmatic scrolling is not supported when the `QueryItemSize` event is handled.

## Scrollbar visibility

The `SfListView` provides an option to enable or disable the `Scrollbar` visibilty by using the [ScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollBarVisibility) property. By default, the value will be `Default`

N> This API is only available for the `WinUI` platform.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfListView x:Name="listView" 
                       ScrollBarVisibility="Always" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.ScrollBarVisibility = ScrollBarVisibility.Always; 
{% endhighlight %}
{% endtabs %}

## ListView with full height

The `SfListView` will load all of its items by setting the [IsScrollingEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsScrollingEnabled) property to `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfListView x:Name="listView" 
			IsScrollingEnabled="False" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.IsScrollingEnabled = false; 
{% endhighlight %}
{% endtabs %}

N> ListView's scrolling will not be enabled when `IsScrollingEnabled` is `false`. To enable scrolling, load ListView inside `ScrollView`.

## Identifying scroll state changes

The `SfListView` will notify the scrolling state changes by using the [ScrollStateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollStateChanged) event.

The following states will be notified using the [ListViewScrollState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewScrollState.html) property in the event argument.

 * [Dragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewScrollState.html#Syncfusion_Maui_ListView_ListViewScrollState_Dragging): Specifies that `SfListView` is currently being dragged in the view.
 * [Fling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewScrollState.html#Syncfusion_Maui_ListView_ListViewScrollState_Fling): Specifies that fling action is performed on the `SfListView`.
 * [Idle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewScrollState.html#Syncfusion_Maui_ListView_ListViewScrollState_Idle): Specifies that `SfListView` is not currently scrolling.
 * [Programmatic](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewScrollState.html#Syncfusion_Maui_ListView_ListViewScrollState_Programmatic): Specifies that scrolling is performed by using [ScrollTo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_) or [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html#Syncfusion_Maui_ListView_ListViewLayout_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

listView.ScrollStateChanged += ListView_ScrollStateChanged;
private void ListView_ScrollStateChanged(object sender, ScrollStateChangedEventArgs e)
{
   if (e.ScrollState == ListViewScrollState.Idle)
   {
      DisplayAlert("ScrollState", "Scrolling has stopped", "OK");
   }
}

{% endhighlight %}
{% endtabs %}

## Identify when end of the list is reached on scrolling

The `SfListView` can be notified when scrolling using the [Changed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.ScrollAxisBase.html#Syncfusion_Maui_GridCommon_ScrollAxis_ScrollAxisBase_Changed) event of [ScrollAxisBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.ScrollAxisBase.html) in [VisualContainer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.VisualContainer.html) of the `SfListView`. By using this event, you can find whether you have reached the last item in the list in the `SfListView` based on the [LastBodyVisibleLineIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.ScrollAxisBase.html#Syncfusion_Maui_GridCommon_ScrollAxis_ScrollAxisBase_LastBodyVisibleLineIndex) property and underlying collection count.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="19" %}
using Syncfusion.Maui.ListView.Helpers;
public partial class MainPage : ContentPage
{
    VisualContainer visualContainer;
    bool isAlertShown = false;

    public MainPage()
    {
        InitializeComponent();
        visualContainer = listView.GetVisualContainer();
        visualContainer.ScrollRows.Changed += ScrollRows_Changed;
    }

    ///<summary>
    ///To notify when end reached
    ///</summary>
    private void ScrollRows_Changed(object sender, ScrollChangedEventArgs e)
    {
        var lastIndex = visualContainer.ScrollRows.LastBodyVisibleLineIndex;

        //To include header if used
        var header = (listView.HeaderTemplate != null && !listView.IsStickyHeader) ? 1 : 0;

        //To include footer if used
        var footer = (listView.FooterTemplate != null && !listView.IsStickyFooter) ? 1 : 0;
        var totalItems = listView.DataSource.DisplayItems.Count + header + footer;

        if ((lastIndex == totalItems - 1))
        {
            if (!isAlertShown)
            {
                DisplayAlert("Alert", "End of list reached...", "Ok");
                isAlertShown = true;
            }
        }
        else
            isAlertShown = false;
    }
}

{% endhighlight %}
{% endtabs %}

You can get the item elements to hold by a scrollable visual container using the [GetVisualContainer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.Helpers.SfListViewHelper.html#Syncfusion_Maui_ListView_Helpers_SfListViewHelper_GetVisualContainer_Syncfusion_Maui_ListView_SfListView_) method. It is a helper method of `SfListView` control.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
using Syncfusion.Maui.ListView.Helpers;
public partial class MainPage : ContentPage
{
    VisualContainer visualContainer;
	
    public MainPage()
    {
        InitializeComponent();
        visualContainer = listView.GetVisualContainer();
    }
}
{% endhighlight %}
{% endtabs %}

## Maintain the scroll position while updating ItemsSource at runtime

The `SfListView` has scrolled to the top automatically when changing the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource) at runtime. However, you can maintain the same scrolled position using the [CanMaintainScrollPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CanMaintainScrollPosition) property. If you set `CanMaintainScrollPosition` to true, then on changing ItemsSource, the newly added ItemsSource will be loaded with the previous ItemsSource’s ScrollOffset.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfListView x:Name="listView" 
                       CanMaintainScrollPosition="True"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.CanMaintainScrollPosition = true; 
{% endhighlight %}
{% endtabs %}

## How to handle the recycle of the ListView Items

By default, the `SfListview` reuses items on scrolling and changing the source collection. You can skip the reusing while scrolling by setting the [CachingStrategy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.CachingStrategy.html) property to [CreateNewTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.CachingStrategy.html#Syncfusion_Maui_ListView_CachingStrategy_CreateNewTemplate) for the ListView. It creates a new element for every data in the ItemsSource. The default value is [RecycleTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.CachingStrategy.html#Syncfusion_Maui_ListView_CachingStrategy_RecycleTemplate) where the data template gets reused while the data object associated with the listview item gets changed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfListView x:Name="listView" 
                      	CachingStrategy="CreateNewTemplate" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.CachingStrategy = CachingStrategy.CreateNewTemplate; 
{% endhighlight %}
{% endtabs %}

You can skip the reusing of list items on the `ItemsSourcePropertyChanged` by setting the [ItemsSourceChangeCachingStrategy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemsSourceChangeCachingStrategy.html) property to [ClearItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemsSourceChangeCachingStrategy.html#Syncfusion_Maui_ListView_ItemsSourceChangeCachingStrategy_ClearItems) for the ListView. Here, the existing ListView items will be cleared and create a new list of items when the `ItemsSource` is changed. The default value is [RecycleItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemsSourceChangeCachingStrategy.html#Syncfusion_Maui_ListView_ItemsSourceChangeCachingStrategy_RecycleItems) where the listView items will be recycled in the `ItemsSource` changes.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfListView x:Name="listView" 
			ItemsSourceChangeCachingStrategy="ClearItems" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.ItemsSourceChangeCachingStrategy = ItemsSourceChangeCachingStrategy.ClearItems;
{% endhighlight %}
{% endtabs %}

