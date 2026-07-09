---
layout: post
title: Working with TreeView in .NET MAUI TreeView Control | Syncfusion®
description: Learn here about Working with TreeView support in Syncfusion® .NET MAUI TreeView (SfTreeView) control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Working with TreeView in .NET MAUI TreeView (SfTreeView)

## Interacting with TreeView items

### Loaded event

The [Loaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Loaded) event is raised when the TreeView is loaded into the view for the first time.

The `Loaded` event is commonly used to scroll a desired item into view by using the [BringIntoView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_BringIntoView_Syncfusion_TreeView_Engine_TreeViewNode_System_Boolean_System_Boolean_Microsoft_Maui_Controls_ScrollToPosition_) method. The `BringIntoView` method accepts the following parameters:

  * `node`: The [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) that should be scrolled into view.
  * `disableAnimation`: `true` to disable the scroll animation; `false` to animate the scroll.
  * `scrollIfNotVisible`: `true` to scroll the node only if it is not currently visible; `false` to always scroll.
  * `scrollToPosition`: A [ScrollToPosition](https://help.syncfusion.com/cr/maui/Microsoft_Maui_Controls_ScrollToPosition.html) value (`MakeVisible`, `Start`, `Center`, or `End`) that determines the final position of the node within the viewport.

The following example shows how to handle the `Loaded` event and bring the first node into view:

{% tabs %}
{% highlight c# %}
treeView.Loaded += TreeView_Loaded;

private void TreeView_Loaded(object sender, TreeViewLoadedEventArgs e)
{
    // Bring the first node into view when the TreeView is loaded.
    if (treeView.Nodes.Count > 0)
    {
        var node = treeView.Nodes[0];
        treeView.BringIntoView(node, true, true, ScrollToPosition.MakeVisible);
    }
}
{% endhighlight %}
{% endtabs %}

### ItemTapped event

The [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTapped) event is triggered whenever an item is tapped. [ItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html) has the following members that provide information for the `ItemTapped` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemTappedEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and its associated data for the tapped item.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemTappedEventArgs_Position): Gets the touch position within the tapped item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemTappedEventArgs_Handled): Gets or sets whether the event is handled.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ItemTapped="TreeView_ItemTapped" />
{% endhighlight %}
{% highlight c# %}

treeView.ItemTapped += TreeView_ItemTapped;

private void TreeView_ItemTapped(object sender, ItemTappedEventArgs e)
{
    DisplayAlert("Item Tapped", "TreeView item tapped", "Close");
}

{% endhighlight %}
{% endtabs %}

### ItemDoubleTapped event

The [ItemDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemDoubleTapped) event is triggered whenever an item is double-tapped. [ItemDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html) has the following members that provide information for the `ItemDoubleTapped` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemDoubleTappedEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and its associated data for the double-tapped item.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemDoubleTappedEventArgs_Position): Gets the touch position within the double-tapped item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemDoubleTappedEventArgs_Handled): Gets or sets whether the event is handled.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ItemDoubleTapped="TreeView_ItemDoubleTapped" />
{% endhighlight %}
{% highlight c# %}

treeView.ItemDoubleTapped += TreeView_ItemDoubleTapped;

private void TreeView_ItemDoubleTapped(object sender, ItemDoubleTappedEventArgs e)
{
    DisplayAlert("Item DoubleTapped", "TreeView item double-tapped", "Close");
}

{% endhighlight %}
{% endtabs %}

### ItemRightTapped event

The [ItemRightTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemRightTapped) event is triggered whenever an item is right-tapped. [ItemRightTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html) has the following members that provide information for the `ItemRightTapped` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemRightTappedEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and its associated data for the right-tapped item.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemRightTappedEventArgs_Position): Gets the touch position within the right-tapped item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemRightTappedEventArgs_Handled): Gets or sets whether the event is handled.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ItemRightTapped="TreeView_ItemRightTapped" />
{% endhighlight %}
{% highlight c# %}

treeView.ItemRightTapped += TreeView_ItemRightTapped;

private void TreeView_ItemRightTapped(object sender, ItemRightTappedEventArgs e)
{
    DisplayAlert("Item RightTapped", "TreeView item right-tapped", "Close");
}

{% endhighlight %}
{% endtabs %}

### ItemLongPress event

The [ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemLongPress) event is triggered whenever an item is long-pressed.
[ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html) has the following members that provide information for the `ItemLongPress` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html#Syncfusion_Maui_TreeView_ItemLongPressEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and its associated data for the long-pressed item.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html#Syncfusion_Maui_TreeView_ItemLongPressEventArgs_Position): Gets the touch position within the long-pressed item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html#Syncfusion_Maui_TreeView_ItemLongPressEventArgs_Handled): Gets or sets whether the event is handled.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ItemLongPress="TreeView_ItemLongPress" />
{% endhighlight %}
{% highlight c# %}

treeView.ItemLongPress += TreeView_ItemLongPress;

private void TreeView_ItemLongPress(object sender, ItemLongPressEventArgs e)
{
    DisplayAlert("Item LongPress", "TreeView item is long-pressed", "Close");
}

{% endhighlight %}
{% endtabs %}

### KeyDown event

The [KeyDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_KeyDown) event is triggered when a key is pressed while the [SfTreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.html) is in focus. The [KeyPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html) has the following members that provide information for the `KeyDown` event:

 * [Key](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html#Syncfusion_Maui_TreeView_KeyPressEventArgs_Key): Returns the currently pressed key.
 * [IsShiftKeyPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html#Syncfusion_Maui_TreeView_KeyPressEventArgs_IsShiftKeyPressed): Indicates whether the Shift key is in pressed state.
 * [IsCtrlKeyPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html#Syncfusion_Maui_TreeView_KeyPressEventArgs_IsCtrlKeyPressed): Indicates whether the Control key is in pressed state.
 * [IsAltKeyPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html#Syncfusion_Maui_TreeView_KeyPressEventArgs_IsAltKeyPressed): Indicates whether the Alt key is in pressed state.
 * [IsCommandKeyPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html#Syncfusion_Maui_TreeView_KeyPressEventArgs_IsCommandKeyPressed): Indicates whether the Command key is in pressed state.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html#Syncfusion_Maui_TreeView_KeyPressEventArgs_Handled): Gets or sets whether the event is handled.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" KeyDown="OnTreeViewKeyDown"/>
{% endhighlight %}
{% highlight c# %}

treeView.KeyDown += OnTreeViewKeyDown;

private void OnTreeViewKeyDown(object sender, KeyPressEventArgs e)
{
    // Example: handle the Enter key.
    if (e.Key == Key.Enter)
    {
        // Perform the required action when Enter is pressed.
        e.Handled = true;
    }
}

{% endhighlight %}
{% endtabs %}

> **NOTE**: The `KeyDown` event is raised only when the [SfTreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.html) has focus. Set focus to the control by calling `treeView.Focus()` or by tapping it before expecting key events.

## Track node property changes

The [PropertyChanged](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_PropertyChanged) event is triggered whenever a property in the customized TreeViewNode is changed. You can get the name of the property that changed by using the `PropertyName` property of the `PropertyChangedEventArgs`.

To track changes, first obtain a `TreeViewNode` instance from the [Nodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes) collection of the `SfTreeView` (or a child node's `ChildNodes` collection), then hook the `PropertyChanged` event on that node.

{% tabs %}
{% highlight c# %}
// Retrieve a node from the TreeView (for example, the first root node).
if (treeView.Nodes.Count > 0)
{
    var treeViewNode = treeView.Nodes[0];
    treeViewNode.PropertyChanged += TreeViewNode_PropertyChanged;
}

private void TreeViewNode_PropertyChanged(object sender, PropertyChangedEventArgs e)
{
    var treeViewNode = sender as TreeViewNode;
    if (e.PropertyName == "IsExpanded")
    {
        if (treeViewNode.IsExpanded)
            DisplayAlert("treeview", "nodeexpanded", "ok");
        else
            DisplayAlert("treeview", "nodecollapsed", "ok");
    }
}
{% endhighlight %}
{% endtabs %}

## Refresh layout

You can refresh a `TreeViewNode` from the root node and update the entire layout by using the [SetDirty](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_SetDirty) method that notifies the tree view layout mechanism to invalidate nodes. Call this method whenever you modify properties of a `TreeViewNode` (such as its content, child collection, or expansion state) at runtime so that the control recalculates the layout and re-renders the affected node and its descendants.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        node.SetDirty();
    }
}
{% endhighlight %}
{% endtabs %}

## Reset TreeView items

You can reset the visible TreeView items by using the [ResetTreeViewItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ResetTreeViewItems_System_Object_) method. If the parameter is null, all the visible TreeView items will reset. If you are passing the data object as a parameter, a particular TreeView item will reset.
 
**Reset all visible items:**

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        treeView.ResetTreeViewItems();
    }
}
{% endhighlight %}
{% endtabs %}

**Reset a particular item by passing its data object:**

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // `dataObject` is the underlying data bound to the TreeViewNode you want to reset.
        treeView.ResetTreeViewItems(dataObject);
    }
}
{% endhighlight %}
{% endtabs %}

## Refresh view

You can refresh the view by using the [RefreshView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RefreshView_System_Boolean_) method. It is used to refresh the items in the TreeView at runtime while updating the view.

The `RefreshView` method accepts a `bool` parameter:
 * `true`: Recreates and refreshes all the visible items, including their templates and bindings. Use this when underlying data or templates have changed and a full refresh is required.
 * `false`: Increments the view by refreshing only the differences (added, removed, or changed items) without recreating existing item templates.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Full refresh — recreates all visible items.
        treeView.RefreshView(true);
    }
}
{% endhighlight %}
{% endtabs %}
