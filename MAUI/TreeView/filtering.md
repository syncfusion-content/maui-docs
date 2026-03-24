---
layout: post
title: Filtering in .NET MAUI TreeView Control | Syncfusion
description: Learn here about Filtering support in Syncfusion .NET MAUI TreeView (SfTreeView) control, its elements, and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Filtering in .NET MAUI TreeView (SfTreeView)

This section explains how to implement filtering in the TreeView control and its related operations. The TreeView provides built-in text filtering with multiple matching modes and custom predicate-based filtering capabilities that allow you to quickly locate nodes in hierarchical data.

## Enabling filtering

The TreeView supports filtering nodes through the following approaches:

1. **Built-in text filtering** - Using `FilterText` with `FilterPath` or `FilterPaths` and predefined matching strategies (Contains, StartsWith, Equals)
2. **Custom predicate filtering** - Using `FilterPredicate` for custom filter logic with the help of `RefreshFilter()`
3. **Programmatic and data binding** - Full MVVM support with bindable properties and events

## FilterMode

The [FilterMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterMode) property allows you to select the type of filtering to apply on the TreeView. The available filter modes are:

 * [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewFilterMode.html#Syncfusion_Maui_TreeView_TreeViewFilterMode_None) : No filtering is applied. This is the default value.
 * [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewFilterMode.html#Syncfusion_Maui_TreeView_TreeViewFilterMode_Contains) : Filters nodes where the display text contains the filter text.
 * [StartsWith](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewFilterMode.html#Syncfusion_Maui_TreeView_TreeViewFilterMode_StartsWith) : Filters nodes where the display text starts with the filter text.
 * [Equals](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewFilterMode.html#Syncfusion_Maui_TreeView_TreeViewFilterMode_Equals) : Filters nodes where the display text exactly matches the filter text.
 * [Custom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewFilterMode.html#Syncfusion_Maui_TreeView_TreeViewFilterMode_Custom) : Uses a custom predicate function for filtering. Set `FilterPredicate` when using this mode.

When `FilterMode` is `None` or `FilterText` is null/empty, no filtering is applied, and all nodes are visible.

### Setting filter mode

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfTreeView x:Name="treeView"
                       FilterMode="Contains"/>
{% endhighlight %}
{% highlight c# hl_lines="1" %}
treeView.FilterMode = TreeViewFilterMode.Contains;
{% endhighlight %}
{% endtabs %}

## FilterText

The [FilterText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterText) property is a bindable string property that holds the text used for filtering nodes. When `FilterText` is set and `FilterMode` is not `None`, the TreeView automatically filters nodes based on the specified mode.

N> **Important**: `FilterPath` or `FilterPaths` must be specified to enable filtering. `FilterPath` specifies the single property name of the data model to use for filtering. If not set, filtering defaults to the display member used in the ItemTemplate.

N> When `FilterText` is `null` or empty, no filtering is applied, and all nodes become visible.

### Programmatic filtering

You can set the `FilterText` property programmatically to apply filtering:

{% tabs %}
{% highlight c#  hl_lines="1, 2"%}
treeView.FilterText = "Documents";
treeView.FilterMode = TreeViewFilterMode.StartsWith;
{% endhighlight %}
{% endtabs %}

### Data binding

You can bind the `FilterText` property to a property in your ViewModel for MVVM scenarios:

{% tabs %}
{% highlight xaml hl_lines="7, 8, 9"%}
<Entry Placeholder="Enter filter text"
       Text="{Binding FilterText, Mode=TwoWay}"/>

<syncfusion:SfTreeView x:Name="treeView" 
                       ItemsSource="{Binding Items}"
                       ChildPropertyName="SubItems"
                       FilterText="{Binding FilterText}"
                       FilterMode="Contains"
                       FilterPath="ItemName"/>
{% endhighlight %}
{% endtabs %}

![Filtering in .NET MAUI TreeView](Images/filtering//maui-treeview-filtering.gif)

## FilterPath and FilterPaths

### Single field filtering with FilterPath

The [FilterPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPath) property specifies a single property name of the data model to use for filtering. If `FilterPath` is not set, filtering is applied to the default display member used in the ItemTemplate or the ToString() method.

{% tabs %}
{% highlight xaml  hl_lines="4"%}
<syncfusion:SfTreeView x:Name="treeView"
                       ItemsSource="{Binding Items}"
                       FilterText="{Binding FilterText}"
                       FilterPath="Name"
                       FilterMode="Contains"/>
{% endhighlight %}
{% highlight c#  hl_lines="1"%}
treeView.FilterPath = "Name";
{% endhighlight %}
{% endtabs %}

### Multi-field filtering with FilterPaths

The [FilterPaths](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPaths) property allows filtering across multiple properties. When specified, the filter evaluates all properties and displays a node if any property matches the filter criteria.

{% tabs %}
{% highlight xaml  hl_lines="5"%}
<syncfusion:SfTreeView x:Name="treeView"
                       ItemsSource="{Binding Items}"
                       FilterText="{Binding FilterText}"
                       FilterMode="Contains">
    <syncfusion:SfTreeView.FilterPaths>
        <x:String>Name</x:String>
        <x:String>Code</x:String>
        <x:String>Description</x:String>
    </syncfusion:SfTreeView.FilterPaths>
</syncfusion:SfTreeView>
{% endhighlight %}
{% highlight c#  hl_lines="1"%}
treeView.FilterPaths = new List<string> { "Name", "Code", "Description" };
{% endhighlight %}
{% endtabs %}

## Custom Predicate Filtering

For advanced filtering scenarios, you can use `FilterMode.Custom` with the [FilterPredicate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPredicate) property. The predicate is a delegate that receives a data item and returns `true` if the item should be included in the filtered result, or `false` otherwise.

### Setting a filter predicate

{% tabs %}
{% highlight c#  hl_lines="2"%}
treeView.FilterMode = TreeViewFilterMode.Custom;
treeView.FilterPredicate = (item) =>
{
    ...
};
treeView.RefreshFilter();
{% endhighlight %}
{% endtabs %}

## AutoExpandOnFilter

The [AutoExpandOnFilter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandOnFilter) property automatically expands ancestor nodes of matched items when a filter is applied. This helps users discover matches quickly without manually expanding nodes.

### Using auto-expand

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfTreeView x:Name="treeView"
                       AutoExpandOnFilter="True"
                       FilterMode="Contains"
                       FilterText="Report"/>
{% endhighlight %}
{% highlight c# hl_lines="1"%}
treeView.AutoExpandOnFilter = true;
{% endhighlight %}
{% endtabs %}

## RefreshFilter

The [RefreshFilter()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RefreshFilter) method reapplies the current filter settings. This is useful when you have changed the filter criteria programmatically and need to update the filtered view.

{% tabs %}
{% highlight c#  hl_lines="2" %}
treeView.FilterMode = TreeViewFilterMode.Equals;
treeView.RefreshFilter();
{% endhighlight %}
{% endtabs %}

## FilteredItems

The [FilteredItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilteredItems) property returns a read-only snapshot of the currently filtered items. This is useful for diagnostics, UI logic, or displaying the count of filtered results.

## Filtering Events

### Filtering event

The [Filtering](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Filtering) event is raised before filtering is applied. You can use this to validate or modify filter criteria.

{% tabs %}
{% highlight c#  hl_lines="1" %}
treeView.Filtering += (sender, args) =>
{
    // Handle the filtering event action
};
{% endhighlight %}
{% endtabs %}

### Filtered event

The [Filtered](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Filtered) event is raised after filtering is applied. You can use this to update UI elements, such as displaying the count of filtered results.

{% tabs %}
{% highlight c#  hl_lines="1" %}
treeView.Filtered += (sender, args) =>
{
   // Handle the filtered event action
};
{% endhighlight %}
{% endtabs %}
