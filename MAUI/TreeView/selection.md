---
layout: post
title: Selection in .NET MAUI TreeView control | Syncfusion
description: Learn here all about Selection support in Syncfusion .NET MAUI TreeView (SfTreeView) control and more.
platform: .NET MAUI
control: SfTreeView
documentation: ug
---

# Selection in .NET MAUI TreeView (SfTreeView)

This section explains how to perform selection and its related operations in the TreeView.

## UI Selection
The TreeView allows selecting the items either programmatically or touch interactions by setting the `SelectionMode` property value to other than `None`. The control has different selection modes to perform selection operations as listed as follows.

* `None`: Allows disabling the selection.
* `Single`: Allows selecting the single item only. When clicking on the selected item, selection not will not be cleared. This is the default value for `SelectionMode`.
* `SingleDeselect`: Allows selecting the single item only. When clicking on the selected item, selection gets cleared.
* `Multiple`: Allows selecting more than one item. Selection is not cleared when selecting more than one items. When clicking on the selected item, selection gets cleared.
* `Extended`: Allows to select the multiple items using the common key modifiers.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="TreeView" SelectionMode="Multiple"/>
{% endhighlight %}
{% highlight c# %}
TreeView.SelectionMode = SelectionMode.Multiple;
{% endhighlight %}
{% endtabs %}

![.NET MAUI TreeView with Selection](Images/selection/MultipleSelection.png)

## Programmatic Selection

When the `SelectionMode` is other than `None`, the item or items in the TreeView can be selected from the code by setting the `SelectedItem`, or adding items to the `SelectedItems` property based on the `SelectionMode`.

When the selection mode is `Single` or `SingleDeselect`, programmatically select an item by setting the underlying object to the `SelectedItem` property.

{% tabs %}
{% highlight c# %}

treeView.SelectedItem = viewModel.CountriesInfo[2];

{% endhighlight %}
{% endtabs %}

When the selection mode is `Multiple`, programmatically select more than one item by adding the underlying object to the `SelectedItems` property.

{% tabs %}
{% highlight c# %}

treeView.SelectedItems.Add(viewModel.CountriesInfo[2]);
treeView.SelectedItems.Add(viewModel.CountriesInfo[3]);

{% endhighlight %}
{% endtabs %}

W> If an item is selected programmatically when `SelectionMode` is `None` and if multiple items are programmatically selected when `SelectionMode` is `Single` or `SingleDeselect`, then exception will be thrown internally.

## Selected items 

### Gets selected Items
The TreeView gets all the selected items through the `SelectedItems` property and gets the single item by using the `SelectedItem` property.

### Clear selected items
The selected items can be cleared by calling the `SelectedItems.Clear()` method.

{% tabs %}
{% highlight c# %}
treeView.SelectedItems.Clear();
{% endhighlight %}
{% endtabs %}
 
### CurrentItem vs SelectedItem

The TreeView gets the selected item by using the `SelectedItem` properties. Both `SelectedItem` and `CurrentItem` returns the same data object when selecting single item. When selecting more than one item, the `SelectedItem` property returns the first selected item, and the `CurrentItem` property returns the last selected item.

## Select an entire row

By default, the selection starts from the indent level only. You can select the full row by enabling the `FullRowSelect` property. By setting the `FullRowSelect` to `true` the selection spans the width of tree view control.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="TreeView" FullRowSelect="True" />
{% endhighlight %}
{% highlight c# %}
TreeView.FullRowSelect = true;
{% endhighlight %}
{% endtabs %}

![.NET MAUI TreeView with FullRowSelect](Images/selection/FullRowSelect.png)

## Selected item style

### Selection background

The TreeView allows changing the selection background color for the selected items by using the `SelectionBackgroundColor` property. You can also change the selection background color at runtime.

### Selection foreground

The TreeView allows changing the selection foreground color for the selected items by using the `SelectionForegroundColor` property. You can also change the selection foreground color at runtime.

N> `SelectionForegroundColor` is applicable only for unbound mode.

## Events

### SelectionChanging Event

The `SelectionChanging` event is raised while selecting an item at the execution time. The `ItemSelectionChangingEventArgs` has the following members which provides the information for `SelectionChanging` event:

* `AddedItems`: Gets collection of the underlying data objects where the selection is going to process.
* `RemovedItems`: Gets collection of the underlying data objects where the selection is going to remove.

You can cancel the selection process within this event by setting the `ItemSelectionChangingEventArgs.Cancel` property to true.

{% tabs %}
{% highlight c# %}
treeView.SelectionChanging += TreeView_SelectionChanging;  

private void TreeView_SelectionChanging(object sender, ItemSelectionChangingEventArgs e)
{
   if (e.AddedItems.Count > 0 && e.AddedItems[0] == ViewModel.Items[0])
       e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### SelectionChanged event

The `SelectionChanged` event will occur once selection process has been completed for the selected item in the TreeView. The `ItemSelectionChangedEventArgs` has the following members which provides information for `SelectionChanged` event:

* `AddedItems`: Gets collection of the underlying data objects where the selection has been processed.
* `RemovedItems`: Gets collection of the underlying data objects where the selection has been removed.

{% tabs %}
{% highlight c# %}
treeView.SelectionChanged += TreeView_SelectionChanged;  

private void TreeView_SelectionChanged(object sender, ItemSelectionChangedEventArgs e)
{
   treeView.SelectedItems.Clear();
}
{% endhighlight %}
{% endtabs %}

N> `SelectionChanging` and `SelectionChanged` events will be triggered only on UI interactions.

## Key Navigation

The TreeView allows to select the items through keyboard interactions. Behavior of key navigation is explained as follows:

* When the `SelectionMode` is `Single` or `SingleDeselect`, the selected item is highlighted with `FocusBorderColor` around the item while key navigation.

* When the `SelectionMode` is `Multiple` or `Extended`, the `FocusBorderColor` will set to the `CurrentItem`.

## FocusBorderColor

The `FocusBorderColor` property is used to set the border color for the current focused item.The default color is `Color.FromArgb("#000000")`.

## FocusBorderThickness
The `FocusBorderThickness` property is used to set the border thickness for the current focused item. The default thickness is `1.2f`.

## Limitation

* When a grid is loaded inside the `ItemTemplate` with background color, the `SelectionBackgroundColor` will not display. Because, it overlaps the `SelectionBackgroundColor`. In this case, set the background color for the TreeView instead of grid in the  `ItemTemplate`.
* When the `TreeView` contains duplicated items in the collection, only the first item whose instance was created initially will be selected or deselected.