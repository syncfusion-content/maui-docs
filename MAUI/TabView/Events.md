---
layout: post
title: Events in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn about event support in the Syncfusion® .NET MAUI Tab View (SfTabView) control, its elements, and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Events in .NET MAUI Tab View

This section provides information about the events available in the .NET MAUI Tab View control.

## TabItemTapped event

The [`TabItemTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabItemTapped) event is triggered whenever a tab is tapped.The [`TabItemTappedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabItemTappedEventArgs.html) provides the following properties:

* [`TabItem`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabItemTappedEventArgs.html#Syncfusion_Maui_TabView_TabItemTappedEventArgs_TabItem) : Gets the selected tab item of Tab View control.
* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabItemTappedEventArgs.html#Syncfusion_Maui_TabView_TabItemTappedEventArgs_Cancel) : Gets or sets a value indicating whether the event should be canceled.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView x:Name="tabView" TabItemTapped="TabView_TabItemTapped" />

{% endhighlight %}

{% highlight C# %}

tabView.SelectionChanged += TabView_TabItemTapped;
private void TabView_TabItemTapped(object sender, TabItemTappedEventArgs e)
{
   // Acces the Selected Tab Item Property
    e.TabItem.FontSize = 26;

   // Cancel the event if needed
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## SelectionChanging event

The [`SelectionChanging`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectionChanging) event notifies before the selection changes, when the tab header is tapped, or when dynamically setting the [`SelectedIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) property of SfTabView. The [`SelectionChangingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SelectionChangingEventArgs.html) provides the following properties:

* [`Index`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SelectionChangingEventArgs.html#Syncfusion_Maui_TabView_SelectionChangingEventArgs_Index) - Gets the index value of the item that is about to be selected. 

* `Cancel` - Gets or sets a boolean value indicating whether the selection of the tab item should be canceled.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView x:Name="tabView" SelectionChanging="TabView_SelectionChanging" />
	
{% endhighlight %}

{% highlight C# %}

tabView.SelectionChanging += TabView_SelectionChanging;
private void TabView_SelectionChanging(object sender, SelectionChangingEventArgs e)
{
    // Access the index value of the item that is being selected.
    var selectionChangingIndex =  e.Index;

    // if we set Cancel as true then the tabbed item could not selected.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## SelectionChanged event

The [`SelectionChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectionChanged) event is used to notify when the selection changes by swiping or dynamically setting the [`SelectedIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) property of SfTabView. The [`TabSelectionChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html) provides the following properties:

* [`NewValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html#Syncfusion_Maui_TabView_TabSelectionChangedEventArgs_NewIndex) : Gets the index of the currently selected tab item.
* [`OldValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html#Syncfusion_Maui_TabView_TabSelectionChangedEventArgs_OldIndex) : Gets the index of the previously selected tab item.
* [`Handled `](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html#Syncfusion_Maui_TabView_TabSelectionChangedEventArgs_Handled) : Gets or sets a value indicating whether the `SelectionChanged` event is handled.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView x:Name="tabView" SelectionChanged="TabView_SelectionChanged" />
	
{% endhighlight %}

{% highlight C# %}

tabView.SelectionChanged += TabView_SelectionChanged;
private void TabView_SelectionChanged(object sender, TabSelectionChangedEventArgs e)
{
    // Access the new and old Index
    double newValue = e.NewIndex;
    double oldValue = e.OldIndex;

    // if we set handled true other SelectionChanged event can't trigger
    e.Handled = true;
}

{% endhighlight %}

{% endtabs %}

## See also 

[How to convert events into commands in .NET MAUI Tab View?](https://support.syncfusion.com/kb/article/16790/how-to-convert-events-into-commands-in-net-maui-tabview)