---
layout: post
title: Events in .NET MAUI TreeMap Control | Syncfusion
description: Learn here all about the Events support in the Syncfusion .NET MAUI TreeMap control and more.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Events in the .NET MAUI TreeMap (SfTreeMap)

## SelectionChanged

A `SelectionChanged` event occurs, when the treemap item is selected.
Below is a list of the arguments:

* `Sender`: This contains the `SfTreeMap` object.

* `SelectionChanged`: The selection is changed when the selection-changed action is performed on the element available in the `TreeMapSelectionChangedEventArgs`.

    * `OldItems`: Returns the previously selected item.
    * `NewItems`: Returns the newly selected item.
    * `Category`: Returns the hierarchical path of the selected item within its groups.
    * `IsSelected`: Returns the items are selected or deselected.
    * `GroupLevel`: Returns the level of grouping for the selected items.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<scheduler:SfScheduler x:Name="treeMap" 
                       SelectionChanged="OnTreeMapSelectionChanged" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.treeMap.SelectionChanged += this.OnTreeMapSelectionChanged;

private void OnTreeMapSelectionChanged(object sender, TreeMapSelectionChangedEventArgs e)
{
    var oldItems = e.OldItems;
    var newItems = e.NewItems;
    string groupName = e.Category;
    int groupLevel = e.GroupLevel;
    bool isSelected = e.IsSelected;
}

{% endhighlight %}
{% endtabs %}