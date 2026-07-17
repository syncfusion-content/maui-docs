---
layout: post
title: Events in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn about event support in the Syncfusion® .NET MAUI Tab View (SfTabView) control, its elements, and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Events in .NET MAUI Tab View

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.TabView`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/tabview/getting-started) documentation.

## Overview

This section provides information about the events available in the .NET MAUI Tab View control.

Use the following events to respond to tab interactions in the `SfTabView` control:

* `TabItemTapped` - Raised when a tab header is tapped, before the selection changes. Use this to handle the tap gesture or cancel the tap.
* `SelectionChanging` - Raised before the selected tab changes. Use this to inspect or cancel the upcoming selection.
* `SelectionChanged` - Raised after the selected tab changes (via tap, swipe, or programmatic update). Use this to react to the new selection.

## TabItemTapped event

The [`TabItemTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabItemTapped) event is triggered whenever a tab is tapped. The [`TabItemTappedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabItemTappedEventArgs.html) provides the following properties:

* [`TabItem`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabItemTappedEventArgs.html#Syncfusion_Maui_TabView_TabItemTappedEventArgs_TabItem) - Gets the tapped tab item of the Tab View control.
* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabItemTappedEventArgs.html#Syncfusion_Maui_TabView_TabItemTappedEventArgs_Cancel) - Gets or sets a value indicating whether the event should be canceled.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView x:Name="tabView" TabItemTapped="TabView_TabItemTapped">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    Items =
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};
tabView.TabItemTapped += TabView_TabItemTapped;
private void TabView_TabItemTapped(object sender, TabItemTappedEventArgs e)
{
   // Access the tapped tab item.
    var tappedItem = e.TabItem;

   // Cancel the event if needed.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## SelectionChanging event

The [`SelectionChanging`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectionChanging) event notifies before the selection changes, when the tab header is tapped, or when dynamically setting the [`SelectedIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) property of SfTabView. The [`SelectionChangingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SelectionChangingEventArgs.html) provides the following properties:

* [`Index`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SelectionChangingEventArgs.html#Syncfusion_Maui_TabView_SelectionChangingEventArgs_Index) - Gets the index value of the item that is about to be selected.
* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SelectionChangingEventArgs.html#Syncfusion_Maui_TabView_SelectionChangingEventArgs_Cancel) - Gets or sets a boolean value indicating whether the selection of the tab item should be canceled.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView x:Name="tabView" SelectionChanging="TabView_SelectionChanging">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>
	
{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    Items =
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

tabView.SelectionChanging += TabView_SelectionChanging;
private void TabView_SelectionChanging(object sender, Syncfusion.Maui.TabView.SelectionChangingEventArgs e)
{
    // Access the index value of the item that is being selected.
    var selectionChangingIndex = e.Index;

    // If we set Cancel to true, the tab item will not be selected.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## SelectionChanged event

The [`SelectionChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectionChanged) event is used to notify when the selection changes by swiping or dynamically setting the [`SelectedIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) property of SfTabView. The [`TabSelectionChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html) provides the following properties:

* [`NewIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html#Syncfusion_Maui_TabView_TabSelectionChangedEventArgs_NewIndex) - Gets the index of the currently selected tab item.
* [`OldIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html#Syncfusion_Maui_TabView_TabSelectionChangedEventArgs_OldIndex) - Gets the index of the previously selected tab item.
* [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html#Syncfusion_Maui_TabView_TabSelectionChangedEventArgs_Handled) - Gets or sets a value indicating whether the `SelectionChanged` event has been handled. Set this to `true` to stop further processing of the `SelectionChanged` notification.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView x:Name="tabView" SelectionChanged="TabView_SelectionChanged">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

	
{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    Items =
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};
tabView.SelectionChanged += TabView_SelectionChanged;
private void TabView_SelectionChanged(object sender, TabSelectionChangedEventArgs e)
{
    // Access the new and old index.
    int newIndex = e.NewIndex;
    int oldIndex = e.OldIndex;

    // If we set Handled to true, further handling of the SelectionChanged event is stopped.
    e.Handled = true;
}

{% endhighlight %}

{% endtabs %}

## Troubleshooting

* If your event handler is not invoked, verify that the method signature matches the event's delegate (for example, `TabItemTappedEventArgs` for `TabItemTapped`).
* Ensure that the `xmlns:tabView` namespace and the Syncfusion `SfTabView` handler are correctly registered in your MAUI project.
* When using the C# subscription form (`+=`), confirm that the event name matches the one shown in the XAML example; mismatches (for example, subscribing to `SelectionChanged` instead of `TabItemTapped`) will silently fail to compile or run.

## See also 

* [Getting Started with .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/getting-started)
* [Selection Indicator Customization in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/selection-indicator-customization)
* [Header Display Mode in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/header-display-mode)
* [Tab Item Customization in .NET MAUI Tab View](Thttps://help.syncfusion.com/maui/tabview/tab-item-customization)
* [Tab bar Customization in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/tab-bar-customization)
* [Populating ItemsSource in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/populating-itemssource)
* [How to convert events into commands in .NET MAUI Tab View?](https://support.syncfusion.com/kb/article/16790/how-to-convert-events-into-commands-in-net-maui-tabview)
