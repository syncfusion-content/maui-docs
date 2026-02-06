---
layout: post
title: Working with ListView in .NET MAUI ListView control | Syncfusion
description: Learn here all about Working with ListView support in Syncfusion .NET MAUI ListView control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Working with ListView in .NET MAUI ListView (SfListView)

## Interacting with ListView Items

### Loaded event

The [Loaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded) event is triggered when the `SfListView` is loading in view for the first time.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

listView.Loaded += ListView_Loaded;

private void ListView_Loaded(object sender, Syncfusion.Maui.ListView.ListViewLoadedEventArgs e)
{
   listView.SelectedItems.Add(viewModel.Customers[2]);
}

{% endhighlight %}
{% endtabs %}

The `Loaded` event is used for the following use cases:

* To scroll the desired position or index, use the [ScrollTo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_) or [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html#Syncfusion_Maui_ListView_ListViewLayout_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_).
* To collapse all the groups.
* To find the sorted or grouped [DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_DisplayItems) of the underlying bound data  to `SfListView`.

### Tapped event

The [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event will be triggered whenever tapping the item. Here, [TapCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommandParameter) property sets the parameter for [SfListView.TapCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommand) and its default value is [ItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html). `ItemTappedEventArgs` has the following members,which provides information for `ItemTapped` event:

 * [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html#Syncfusion_Maui_ListView_ItemTappedEventArgs_ItemType): It gets the type of the tapped item.
 * [DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html#Syncfusion_Maui_ListView_ItemTappedEventArgs_DataItem): The underlying data associated with the tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html#Syncfusion_Maui_ListView_ItemTappedEventArgs_Position): Gets the touch position in the tapped item.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

listView.ItemTapped += ListView_ItemTapped;

private void ListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
{
    if (e.DataItem == viewModel.InboxInfo[0])
      viewModel.InboxInfo.Remove(e.DataItem as ListViewInboxInfo);  
}

{% endhighlight %}
{% endtabs %}

The [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event is used for the following use cases:

* To show the context menu.
* To navigate to another page.
* To delete the item in the list view at runtime.
* To display the item details into another view.
* To expand the view like, accordion.
* To change the underlying bound data.
* To skip other events like selection events if the Handled property set to `true`.

### ItemDoubleTapped event

The [ItemDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped) has the following members which provides information for the `ItemDoubleTapped` event:

 * [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_ListView_ItemDoubleTappedEventArgs_ItemType): It gets the type of double tapped item.
 * [DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_ListView_ItemDoubleTappedEventArgs_DataItem): The underlying data associated with the double tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_ListView_ItemDoubleTappedEventArgs_Position): Gets the touch position in the double tapped item.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

listView.ItemDoubleTapped += ListView_ItemDoubleTapped;

private void ListView_ItemDoubleTapped(object sender, Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs e)
{
    var listViewInboxInfo = new ListViewInboxInfo();
    listViewInboxInfo.Title = "Bryce Thomas";
    listViewInboxInfo.Subject = "Congratulations on the move!";
    viewModel.InboxInfo.Add(listViewInboxInfo);
}

{% endhighlight %}
{% endtabs %}

The [ItemDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped) event is used for the following use cases:

* To show the context menu.
* To delete the item in the list view at runtime.
* To change the underlying bound data.

### ItemRightTapped event

The [ItemRightTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemRightTapped) event will be triggered whenever the item is right tapped. The [ItemRightTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html) has the following members providing information for the `ItemRightTapped` event:

 * [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html#Syncfusion_Maui_ListView_ItemRightTappedEventArgs_ItemType): Gets the type of right tapped item.
 * [DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html#Syncfusion_Maui_ListView_ItemRightTappedEventArgs_DataItem): The underlying data is associated with the right tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html#Syncfusion_Maui_ListView_ItemRightTappedEventArgs_Position): Gets the touch position in the right tapped item.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    listView.ItemRightTapped += ListView_ItemRightTapped;

    private void ListView_ItemRightTapped(object sender, Syncfusion.Maui.ListView.ItemRightTappedEventArgs e)
    {
        DisplayAlert("Item RightTapped", "ListView item right tapped", "Close");
    }

{% endhighlight %}
{% endtabs %}

### ItemLongPress event

The [ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress) event will be triggered whenever long pressing the item. Here, [LongPressCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommandParameter) sets the parameter for [SfListView.LongPressCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommand) and its default value is [ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html). `ItemLongPressEventArgs` has the following members, which provides information for `ItemLongPress` event:

 * [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html#Syncfusion_Maui_ListView_ItemLongPressEventArgs_ItemType): It gets the type of the long pressed item.
 * [DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html#Syncfusion_Maui_ListView_ItemLongPressEventArgs_DataItem): The underlying data associated with the holding item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html#Syncfusion_Maui_ListView_ItemLongPressEventArgs_Position): Gets the touch position in the holding item.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

listView.ItemLongPress += ListView_ItemLongPress;

private void ListView_ItemLongPress(object sender, Syncfusion.Maui.ListView.ItemLongPressEventArgs e)
{
   if (e.DataItem == viewModel.InboxInfo[3])
      viewModel.InboxInfo.Remove(e.DataItem as ListViewInboxInfo);         
}

{% endhighlight %}
{% endtabs%}

The [ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress) event is used for the following use cases:

* To show the context menu.

N>
* Interaction events of the `SfListView` will be triggered for all the `ListViewItems` like `HeaderItem`, `FooterItem`, `GroupHeaderItem`, `LoadMoreItem`, and `RecordItem`. Handle the interaction actions based on the `ItemType` of the event args. 
* The `LongPress` interaction with the mouse is not supported in the `WinUI` platform. For more details about this, refer to this [link](https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.uielement.holding?view=winrt-22621#remarks).

### ItemAppearing

The [ItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing) triggered when items appear in the view while scrolling, loading, or navigating from one page to another. The [ItemAppearingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html)  has the following member, which provides information of appearing Items.

* [DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html#Syncfusion_Maui_ListView_ItemAppearingEventArgs_DataItem): The underlying data associated with the appearing item.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

listView.ItemAppearing += listView_ItemAppearing;

private void listView_ItemAppearing(object sender,  Syncfusion.Maui.ListView.ItemAppearingEventArgs e)
{
    if (e.DataItem == viewModel.BookInfo[0])
        Debug.WriteLine((e.DataItem as BookInfo).BookName);

    // If the DataItem value is "Header", then it's a header item.
    if (e.DataItem == "Header")
        Debug.WriteLine("Header is Appeared");
}

{% endhighlight %}
{% endtabs %}

The [ItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing) event is used for the following use cases:

* To find the item appears in the view.
* To change the background color of the appearing item, use the converter.

### ItemDisappearing

The [ItemDisappearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing) event is triggered when the items disappearing in the view while scrolling, disposing, or navigating from one page to another. The [ItemDisappearingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html) has the following member, which provides information about disappearing Items:

* [DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html#Syncfusion_Maui_ListView_ItemDisappearingEventArgs_DataItem): The underlying data associated with the disappearing item.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

listView.ItemDisappearing += listView_ItemDisappearing;

private void listView_ItemDisappearing(object sender, Syncfusion.Maui.ListView.ItemDisappearingEventArgs e)
{
    if (e.DataItem == viewModel.BookInfo[0])
        Debug.WriteLine((e.DataItem as BookInfo).BookName);

    // If the DataItem value is "Footer" then it's a Footer item.
    if (e.DataItem == "Footer")
        Debug.WriteLine("Footer is Disappeared");
}

{% endhighlight %}
{% endtabs %}

The [ItemDisappearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing) event is used for the following use cases:

* To find the item disappears in the view.

## Improving ListView performance

The .NET MAUI ListView (SfListView) has been built from the ground up with an optimized view reuse strategy to provide best possible performance on the .NET MAUI platform, even when loading large data sets. The following techniques are used to improve performance of the `SfListView`:

 * Bind the `ItemsSource` property to an IList<T> collection instead of an IEnumerable<T> collection because IEnumerable<T> collection do not support random access.
 * The `SfListView` gets refreshed each and every time when a new item is added into the underlying collection. Because, when adding items at runtime, the `DataSource` gets refreshed. To avoid this behavior, use [BeginInit()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_BeginInit) to stop the `RefreshView()` calling in each time, and use [EndInit()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_EndInit) to start the `RefreshView()` calling when adding number of finished items.
 * Avoid loading complex layout in template of listview. For example, loading large-size images or nested containers degrades the scrolling performance. This practice commonly degrades performance in all platforms, and particularly more in Android version API level 19. So, use fewer elements and images with small size and resolution to achieve the maximum performance.
 * Avoid placing the `SfListView` inside `ScrollView` for the following reasons:
    * The `SfListView` implement its own scrolling.
    * The `SfListView` will not receive any gestures as it will be handled by the parent `ScrollView`.
    * If the `SfListView` loads inside the `ScrollView`, the size should be defined.
 * Avoid changing the cell layout based on the `BindingContext`. This incurs large layout and initialization costs.
 * Implement a model class inherited with `INotifyPropertyChanged` interface to notify the property changes at runtime.
 
## Scrolling ListView without virtualization

The `SfListView` allows you to scroll by loading the entire collection of items inside the ScrollView and defining the total extend of its container to `HeightRequest` in the[Loaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded) event.

{% tabs %}
{% highlight xaml %}
<ScrollView>
   <sync:SfListView x:Name="listView" ItemsSource="{Binding BookInfo}" Loaded="listView_Loaded"/>
</ScrollView>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.ListView.Control.Helpers;
public partial class MainPage : ContentPage
{ 
	public MainPage()
	{
		InitializeComponent();
	}
 
	private void listView_Loaded(object sender,  e)
	{
		var container = listView.GetVisualContainer();
		var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(container);
		listView.HeightRequest = extent;
	}
}
{% endhighlight %}
{% endtabs %}


When `SfListView` is in [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode) as `Height`, the extend of the ListView will be updated only while scrolling. So you can resize the ListView in [VisualContainer]((https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.VisualContainer.html)) `PropertyChanged` method  as shown in the following code sample.

{% tabs %}
{% highlight xaml %}
<ScrollView>
   <sync:SfListView x:Name="listView" AutoFitMode="Height" ItemsSource="{Binding BookInfo}" Loaded="listView_Loaded"/>
</ScrollView>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.ListView.Control.Helpers;
public partial class MainPage : ContentPage
{
    VisualContainer visualContainer;
    bool loaded;

    public MainPage()
    {
        InitializeComponent();
        visualContainer = listView.GetVisualContainer();
        visualContainer.PropertyChanged += VisualContainer_PropertyChanged;
    }

    private void VisualContainer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Height" && listView.HeightRequest != visualContainer.Height && loaded)
            listView.HeightRequest = visualContainer.Height;
    }

    private void listView_Loaded(object sender, ListViewLoadedEventArgs e)
    {
        var extent = (double)visualContainer.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(visualContainer);
        listView.HeightRequest = extent;
        loaded = true;
    }
}
{% endhighlight %}
{% endtabs %}


N> To avoid extra space below the list, make sure the [ItemSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSize)  property value is not specified while loading in `AutoFitMode`. After `ListView` has been loaded, update the size of the container to render all the list items in the view.

The following limitations should be noted when using the previous approaches:

* As the entire list items are loaded inside the parent `ScrollView` element, the [ItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing) and [ItemDisappearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing) events will not be triggered when scrolling.
* When performing keyboard navigation, the view cannot be scrolled automatically while navigating out of view.
* Touch action scrolling will be handled in all platforms, and `SfListView` scrolling will be handled by the parent `ScrollView`.

## Rendering ListView when loading in different layouts

The options are as follows:

* Creates the measurement and layout similar to .NET MAUI ListView, when the ListView is loaded inside the layouts such as `StackLayout`, `ScrollView`, and `Grid`, in which the `RowDefinition` or `ColumnDefinition` is set to `Auto`. In all other layouts, the ListView size will be allocated from the framework.
* Sets the value of total extend to the `HeightRequest` of ListView, because the scrolling will be handled by the parent `ScrollView`, when ListView is loaded inside the `StackLayout` with base parent as `ScrollView` and multiple elements inside the `StackLayout`.

## Refresh view

You can refresh the view by using the [RefreshView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshView) method. It will be used to refresh the items in the listview at runtime while updating the view.

{% tabs %}
{% highlight c# %} 
   listview.RefreshView();   
{% endhighlight %}
{% endtabs %}

## How to

### Filter listview items based on another listview selection

To filter the listview items based on the item selection in another listview, use the [SfListView.DataSource.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_Filter) property.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6" %}
private void ItemTapped(Syncfusion.Maui.ListView.ItemTappedEventArgs e)
{
    tappedPinedInfo = e.DataItem as PinnedInfo;
    if (tappedPinedInfo.IsFavorite)
    {
        secondLV.DataSource.Filter = FilterDepartures;
        tappedPinedInfo.IsFavorite = false;
    }
    else
    {
        secondLV.DataSource.Filter = null;
        tappedPinedInfo.IsFavorite = true;
    }
    secondLV.DataSource.RefreshFilter();
}

private bool FilterDepartures(object obj)
{
    var departureInfo = obj as DepartureInfo;
    if (tappedPinedInfo == null)
        return true;

    if (departureInfo.Name.ToLower().Contains(tappedPinedInfo.Name.ToLower())
            || departureInfo.RouteName.ToLower().Contains(tappedPinedInfo.RouteName.ToLower()))
        return true;
    else
        return false;
}
{% endhighlight %}
{% endtabs %}

## See also

[How to set the font size for .NET MAUI ListView (SfListView)](https://support.syncfusion.com/kb/article/11569/how-to-set-the-font-size-for-net-maui-listview-sflistview)