---
layout: post
title: Scrolling in .NET MAUI TreeView Control | Syncfusion
description: Learn here all about Scrolling support in Syncfusion .NET MAUI TreeView (SfTreeView) Control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Scrolling in .NET MAUI TreeView (SfTreeView)

The `SfTreeView` provides various options to achieve programmatic scrolling. Please walk through the following section in detail to achieve the same.

## Bring into view

The TreeView allows programmatic scrolling based on the data model and [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) using the [BringIntoView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_BringIntoView_Syncfusion_TreeView_Engine_TreeViewNode_System_Boolean_System_Boolean_Microsoft_Maui_Controls_ScrollToPosition_) method.

{% tabs %}
{% highlight c# hl_lines="5" %}
private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    TreeView.BringIntoView(data);
}
{% endhighlight %}
{% endtabs %}

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/how-to-bring-specific-node-into-view-programmatically-in-.net-maui-treeview).

The `BringIntoView` method comprises other optional parameters to decide on the way in which the child item should come into view.

### Scroll to the child item with animation

The second optional parameter, `disableAnimation`, in the `BringIntoView` method determines whether the scrolling animation should be enabled or disabled when the child item comes into view. By default, the scrolling will be `animated`.

* If the parameter value is `true`, scrolling animation will be disabled.
* If the parameter value is `false`, scrolling animation will be enabled.

{% tabs %}
{% highlight c# hl_lines="6" %}

private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    // Here, the second optional parameter has been passed as true; hence, it will disable the animation.
    TreeView.BringIntoView(data, true);
}

{% endhighlight %}
{% endtabs %}

### Scroll to the collapsed child item

The third optional parameter `canExpand` in the `BringIntoView` method, determines whether we need to expand and show the collapsed node when an item is passed for the `BringIntoView` method, which is in a collapsed state. By default, the value of this parameter will be `false`.

* If the parameter value is `true`, TreeView expands the collapsed node if it is collapsed and scroll to the specified item.

* If the parameter value is `false`, TreeView does not expand the collapsed node and only scroll for item which is not in collapsed state.

{% tabs %}
{% highlight c# hl_lines="5" %}

private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    TreeView.BringIntoView(data, false, true);
}

{% endhighlight %}
{% endtabs %}

N> We need to set the `NodePopulationMode` API value as a `TreeNodePopulationMode.Instant` for scrolling the collapsed item in addition to the additional parameter passed to the `BringIntoView` method.

### Scroll the item into specified position

The fourth optional parameter `scrollToPosition` in the `BringIntoView` method allows the positioning of the scrolled item in the view. The scrolled item can take either of the four positions as explained in the following. The default position is `Start`.

* `Start`: Scroll to make the node positioned at the start of the view.

* `MakeVisible`: Scroll to make a specified node visible in the view. If the specified node is already in view, scrolling will not occur.

* `Center`: Scroll to make the node positioned at the center of the view.

* `End`: Scroll to make the node positioned at the end of the view.

{% tabs %}
{% highlight c# hl_lines="6" %}
private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    // Scrolls to the data item to make it visible in the view.
    treeView.BringIntoView(data, false, false, ScrollToPosition.MakeVisible);
}
{% endhighlight %}
{% endtabs %}

## Horizontal scrolling 

The TreeView allows you to enable horizontal scrolling based on the content by setting the [EnableHorizontalScrolling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EnableHorizontalScrolling) property to `True`. By default, this property is set to `False`.

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfTreeView x:Name="treeView" 
                       EnableHorizontalScrolling="True" />
{% endhighlight %}
{% endtabs %}

## Scrollbar visibility

The TreeView allows showing or hiding the scrollbars using the `VerticalScrollBarVisibility` and `HorizontalScrollBarVisibility` properties. By default, both are set to `Default`.

{% tabs %}
{% highlight xaml hl_lines="2 3" %}

<syncfusion:SfTreeView x:Name="treeView" 
                       VerticalScrollBarVisibility="Always" 
                       HorizontalScrollBarVisibility="Always" />

{% endhighlight %}
{% highlight c# hl_lines="2 3" %}

SfTreeView treeView = new SfTreeView();
treeView.VerticalScrollBarVisibility = ScrollBarVisibility.Always;
treeView.HorizontalScrollBarVisibility = ScrollBarVisibility.Always;

{% endhighlight %}
{% endtabs %}
