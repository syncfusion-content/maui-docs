---
layout: post
title: Scrolling in .NET MAUI TreeView Control | Syncfusion
description: Learn here all about Scrolling support in Syncfusion .NET MAUI TreeView (SfTreeView) Control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Scrolling in .NET MAUI TreeView (SfTreeView)

The .NET MAUI TreeView provides various options to achieve programmatic scrolling. Please walkthrough the below section in detail to achieve the same.

## Bring Into View

The TreeView allows programmatic scrolling based on the data model and `TreeViewNode` by using the `BringIntoView` method.

{% highlight c# hl_line="5" %}
private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    TreeView.BringIntoView(data);
}
{% endhighlight %}
{% endtabs %}

Download the entire source code from GitHub here.

The `BringIntoView` method comprises of other optional parameters to decide on the way in which the child item should come into view.

### Scroll to the child item with animation

The second optional parameter `disableAnimation` in `BringIntoView` method decides whether the scrolling animation should be enabled or disabled when the child item comes into view. By default, the scrolling will be `animated`.

* If the parameter value is `true`, scrolling animation will be disabled.
* If the parameter value is `false`, scrolling animation will be enabled.


{% tabs %}
{% highlight c# hl_line="6" %}

private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    // Here, the second optional parameter has been passed as true hence it will disable the animation
    TreeView.BringIntoView(data, true);
}

{% endhighlight %}
{% endtabs %}

### Scroll to the collapsed child item

The third optional parameter `canExpand` in `BringIntoView` method decides whether we need to expand and show the collapsed node or not when item passed for `BringIntoView` method which is in collapsed state. By default, this parameter value will be `false`.

* If the parameter value is `true`, TreeView expands the collapsed node if it is collapsed and scroll to the specified item.

* If the parameter value is `false`, TreeView does not expand the collapsed node and only scroll for item which is not in collapsed state.

{% tabs %}
{% highlight c# hl_line="5" %}

private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    TreeView.BringIntoView(data, false, true);
}

{% endhighlight %}
{% endtabs %}

N> We need to set the `NodePopulationMode` API value as `PopulationMode.Instant` for scrolling to the collapsed item in addition to the additional parameter passed to the `BringIntoView` method.

### Scroll the item into specified position

The fourth optional parameter `scrollToPosition` in `BringIntoView` method allows to position the scrolled item in the view. The scrolled item can take either of the four positions as explained below. The default position is `Start`.

* `Start`: Scroll to make the node positioned at the start of the view.

* `MakeVisible`: Scroll to make a specified node visible in the view. If the specified node is already in view, scrolling will not occur.

* `Center`: Scroll to make the node positioned at the center of the view.

* `End`: Scroll to make the node positioned at the end of the view.

{% tabs %}
{% highlight c# hl_line="6"%}
private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    // Scrolls to the data item to make visible in the view.
    treeView.BringIntoView(data, false, false, ScrollToPosition.MakeVisible);
}
{% endhighlight %}
{% endtabs %}

## Scrollbar Visibility

The TreeView provides an option to enable or disable the `Scrollbar` visibility by using the `ScrollBarVisibility` property. By default, the value will be `Default`.

{% tabs %}
{% highlight xaml%}
<syncfusion:SfTreeView x:Name="treeView" ScrollBarVisibility="Always" />
{% endhighlight %}
{% highlight c# hl_line="2" %}
SfTreeView treeView = new SfTreeView();
treeView.ScrollBarVisibility = ScrollBarVisibility.Always;
{% endhighlight %}
{% endtabs %}