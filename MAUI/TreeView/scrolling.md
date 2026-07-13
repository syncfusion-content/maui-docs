---
layout: post
title: Scrolling in .NET MAUI TreeView Control | Syncfusion®
description: Learn here all about Scrolling support in Syncfusion® .NET MAUI TreeView (SfTreeView) Control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Scrolling in .NET MAUI TreeView (SfTreeView)

The `SfTreeView` provides various options to achieve programmatic scrolling. The following sections detail each option.

## Bring into view

The TreeView allows programmatic scrolling based on the data model and [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) using the [BringIntoView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_BringIntoView_Syncfusion_TreeView_Engine_TreeViewNode_System_Boolean_System_Boolean_Microsoft_Maui_Controls_ScrollToPosition_) method.
### Method signature

The following table summarizes the parameters of the `BringIntoView` method:

| Parameter | Type | Description | Default value |
|-----------|------|-------------|---------------|
| `data` (or `node`) | `object` / [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) | The data object or `TreeViewNode` to bring into view. | — |
| `disableAnimation` | `bool` | Disables the scrolling animation when set to `true`. | `false` |
| `canExpand` | `bool` | Expands the collapsed node when set to `true`. | `false` |
| `scrollToPosition` | [ScrollToPosition](https://help.syncfusion.com/cr/maui/Microsoft.Maui.Controls.ScrollToPosition.html) | Specifies the position of the item after scrolling. | `Start` |

If the specified data object or `TreeViewNode` is not found in the TreeView (for example, it is within a collapsed parent and `canExpand` is `false`), no scrolling occurs.

### Bring a data object into view

The following example scrolls a bound data object into view:

{% tabs %}
{% highlight c# hl_lines="5" %}
private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    treeView.BringIntoView(data);
}
{% endhighlight %}
{% endtabs %}

### Bring a TreeViewNode into view

The following example scrolls a `TreeViewNode` into view by passing the node directly:

{% tabs %}
{% highlight c# hl_lines="5" %}
private void BringNodeIntoView_Clicked(object sender, EventArgs e)
{
    var node = treeView.Nodes[0].Nodes[1];
    treeView.BringIntoView(node);
}
{% endhighlight %}
{% endtabs %}

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/how-to-bring-specific-node-into-view-programmatically-in-.net-maui-treeview).

### Optional parameters

The `BringIntoView` method comprises optional parameters to decide on the way in which the child item should come into view. The following subsections detail each parameter.

### Enable or disable scrolling animation

The `disableAnimation` parameter in the `BringIntoView` method determines whether the scrolling animation should be enabled or disabled when the child item comes into view. By default, scrolling is animated.

* If the parameter value is `true`, scrolling animation will be disabled.
* If the parameter value is `false`, scrolling animation will be enabled.

{% tabs %}
{% highlight c# hl_lines="6" %}
private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    // Passing true disables the scrolling animation.
    treeView.BringIntoView(data, true);
}
{% endhighlight %}
{% endtabs %}

The same GitHub sample covers the optional-parameter variants of `BringIntoView` and is available [here](https://github.com/SyncfusionExamples/how-to-bring-specific-node-into-view-programmatically-in-.net-maui-treeview).

### Scroll to the collapsed child item

The `canExpand` parameter in the `BringIntoView` method determines whether to expand and show the collapsed node when an item passed to the `BringIntoView` method is in a collapsed state. By default, the value of this parameter is `false`.

* If the parameter value is `true`, the TreeView expands the collapsed node and scrolls to the specified item.

* If the parameter value is `false`, the TreeView does not expand the collapsed node and only scrolls to items that are not in a collapsed state.

{% tabs %}
{% highlight c# hl_lines="5" %}
private void BringIntoView_Clicked(object sender, EventArgs e)
{
    var count = viewModel.ImageNodeInfo.Count;
    var data = viewModel.ImageNodeInfo[count-1];
    treeView.BringIntoView(data, false, true);
}
{% endhighlight %}
{% endtabs %}

### Scroll the item into a specified position

The `scrollToPosition` parameter in the `BringIntoView` method allows positioning the scrolled item within the view. The scrolled item can take any of the four positions explained below. The default position is `Start`.

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

The TreeView allows you to enable horizontal scrolling based on the content by setting the [EnableHorizontalScrolling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EnableHorizontalScrolling) property to `True`. By default, this property is set to `False`. Horizontal scrolling engages when the content width exceeds the visible viewport width.

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfTreeView x:Name="treeView" 
                       EnableHorizontalScrolling="True" />
{% endhighlight %}
{% highlight c# hl_lines="8" %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        SfTreeView treeView = new SfTreeView();
        treeView.EnableHorizontalScrolling = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Scrollbar visibility

The TreeView allows showing or hiding the scrollbars using the [VerticalScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_VerticalScrollBarVisibility) and [HorizontalScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_HorizontalScrollBarVisibility) properties. By default, both are set to `Default`. The `ScrollBarVisibility` enum resides in the `Microsoft.Maui.Controls` namespace and supports the following values:

* `Default` — The scrollbar is visible only when scrolling is possible.
* `Always` — The scrollbar is always visible.
* `Never` — The scrollbar is never visible.

{% tabs %}
{% highlight xaml hl_lines="2 3" %}
<syncfusion:SfTreeView x:Name="treeView" 
                       VerticalScrollBarVisibility="Always" 
                       HorizontalScrollBarVisibility="Always" />
{% endhighlight %}
{% highlight c# hl_lines="8 9" %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        SfTreeView treeView = new SfTreeView();
        treeView.VerticalScrollBarVisibility = ScrollBarVisibility.Always;
        treeView.HorizontalScrollBarVisibility = ScrollBarVisibility.Always;
    }
}
{% endhighlight %}
{% endtabs %}
