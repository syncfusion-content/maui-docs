---
layout: post
title: Expand and Collapse in .NET MAUI TreeView Control | Syncfusion
description: Learn here all about Expand and Collapse support in the Syncfusion .NET MAUI TreeView (SfTreeView) control and more.
platform: .NET MAUI
control: SfTreeView
documentation: ug
---

# Expand and Collapse in Xamarin TreeView (SfTreeView)

The TreeView allows you to expand and collapse the nodes either by user interaction on the nodes or by programmatically. 

##  Expand Action Target

 Expanding and Collapsing of nodes can be performed either by tapping the expander view or in both expander view and content view by setting the `ExpandActionTarget` property.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfTreeView x:Name="TreeView" ExpandActionTarget="Node"/>

{% endhighlight %}
{% highlight c# %}

// Expands by tapping both expander view and content view.
treeView.ExpandActionTarget = Syncfusion.Maui.TreeView.TreeViewExpandActionTarget.Node;

{% endhighlight %}
{% endtabs %}

## Auto Expand Mode

By default, the treeview items will be in collapsed state. You can define how the nodes to be expanded while loading the TreeView by using `AutoExpandMode` property.

The `AutoExpandMode` property is only applicable for bound mode. For Unbound mode you need to set `IsExpanded` property to `true` while creating the nodes, to be in expanded state while loading the TreeView.

* None : All items are collapsed when loaded.
* RootNodesExpanded : Expands only the root item when loaded.
* AllNodesExpanded : Expands all the items when loaded.

## Programmatic Expand and Collapse

TreeView allows programmatic expand and collapse based on the `TreeViewNode` and level by using following methods.

* `ExpandNode(TreeViewNode item)` - Method to expand the particular `TreeViewNode` passed to it.
* `CollapseNode(TreeViewNode item)` - Method to collapse the particular `TreeViewNode` passed to it.
* `ExpandNodes(int level)` - Method to expand the all items of level passed to it.
* `CollapseNodes(int level)` - Method to expand the all items of level passed to it.

{% tabs %}
{% highlight c# %}

// Expands all the nodes of root level '0'
treeView.ExpandNodes(0);

// Collapses all the nodes of root level '0'
treeView.CollapseNodes(0);

// Expand a particular node.
treeView.ExpandNode(node);

// Expand a particular node.
treeView.CollapseNode(node);

{% endhighlight %}
{% endtabs %}

### Expand and Collapse all the nodes

You can expand and collapse all the `TreeViewNode` programmatically at runtime by using the `SfTreeView.ExpandAll` method and `SfTreeView.CollapseAll` method.

{% tabs %}
{% highlight c# %}

//Expands all the nodes
treeView.ExpandAll();

//Collapses all the nodes
treeView.CollapseAll();

{% endhighlight %}
{% endtabs %}

## Expand and Collapse using Keyboard

TreeView allows to expand and collapse the nodes by using right and left arrows keys. To expand a node, press the right arrow key and to collapse a node, press the left arrow key on the focused item.

## Events

TreeView exposes following events to handle expanding and collapsing of items.

* `NodeCollapsing` - It occurs when a node is being collapsed.
* `NodeExpanding` - It occurs when a node is being expanded.
* `NodeCollapsed` - It occurs when a node is collapsed.
* `NodeExpanded`  - It occurs when a node is expanded.

The expanding and collapsing interactions can be handled with the help of `NodeCollapsing` and `NodeExpanding` events and expanded and collapsed interactions can be handled with help of `NodeCollapsed` and `NodeExpanded` events.

You can also achieve handle expand and collapse operation using `ExpandCommand` and `CollapseCommand`.