---
layout: post
title: Working with TreeView in .NET MAUI TreeView Control | Syncfusion
description: Learn here about Working with TreeView support in Syncfusion .NET MAUI TreeView (SfTreeView) control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Working with TreeView in .NET MAUI TreeView (SfTreeView)

## Interacting with TreeView items

### Loaded event

The [Loaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Loaded) event is raised when the TreeView is loading in view for the first time.

{% tabs %}
{% highlight c# %}
treeView.Loaded += TreeView_Loaded;

private void TreeView_Loaded(object sender, TreeViewLoadedEventArgs e)
{
   DisplayAlert("Message", "TreeView is Loaded", "Done");
}
{% endhighlight %}
{% endtabs %}

The `Loaded` event is used for the following use case:

* To scroll the desired item by using the [BringIntoView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_BringIntoView_Syncfusion_TreeView_Engine_TreeViewNode_System_Boolean_System_Boolean_Microsoft_Maui_Controls_ScrollToPosition_).

### Tapped event

The [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTapped) event will be triggered whenever tapping the item. [ItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html) has the following members which provide the information for the `ItemTapped` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemTappedEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and data associated with the tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemTappedEventArgs_Position): Gets the touch position in the tapped item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemTappedEventArgs_Handled): Gets or sets whether the event is handled or not.

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

The [ItemDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemDoubleTapped) event will be triggered whenever double tapping the item. The [ItemDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html) has the following members providing information for the `ItemDoubleTapped` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemDoubleTappedEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and data associated with the double-tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemDoubleTappedEventArgs_Position): Gets the touch position in the double tapped item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemDoubleTappedEventArgs_Handled): Gets or sets whether the event is handled or not.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ItemDoubleTapped="TreeView_ItemDoubleTapped" />
{% endhighlight %}
{% highlight c# %}

treeView.ItemDoubleTapped += TreeView_ItemDoubleTapped;

private void TreeView_ItemDoubleTapped(object sender, ItemDoubleTappedEventArgs e)
{
    DisplayAlert("Item DoubleTapped", "TreeView item double tapped", "Close");
}

{% endhighlight %}
{% endtabs %}

### ItemRightTapped event

The [ItemRightTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemRightTapped) event will be triggered whenever the item is right tapped. The [ItemRightTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html) has the following members providing information for the `ItemRightTapped` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemRightTappedEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and data associated with the right-tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html#Syncfusion_Maui_TreeView_ItemRightTappedEventArgs_Position): Gets the touch position in the right-tapped item.

{% tabs %}
{% highlight xaml %}
      
    <syncfusion:SfTreeView x:Name = "treeView" ItemRightTapped = "TreeView_ItemRightTapped" />
{% endhighlight %}
{% highlight c# %}

    treeView.ItemRightTapped += TreeView_ItemRightTapped;

    private void TreeView_ItemRightTapped(object sender, ItemRightTappedEventArgs e)
    {
        DisplayAlert("Item RightTapped", "TreeView item right tapped", "Close");
    }

{% endhighlight %}
{% endtabs %}

### ItemLongPress event

The [ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemLongPress) event will be triggered whenever the item is long pressed.
 [ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html) has the following members which provides the information for the `ItemLongPress` event:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html#Syncfusion_Maui_TreeView_ItemLongPressEventArgs_Node): Gets the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and data associated with the hold item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html#Syncfusion_Maui_TreeView_ItemLongPressEventArgs_Position): Gets the touch position in the hold item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html#Syncfusion_Maui_TreeView_ItemLongPressEventArgs_Handled): Gets or sets whether the event is handled or not.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" ItemLongPress="TreeView_ItemLongPress" />
{% endhighlight %}
{% highlight c# %}

treeView.ItemLongPress += TreeView_ItemLongPress;
private void TreeView_ItemLongPress(object sender, ItemLongPressEventArgs e)
{
    DisplayAlert("Item LongPress", "TreeView item is Long Pressed","Close");   
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
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.KeyPressEventArgs.html#Syncfusion_Maui_TreeView_KeyPressEventArgs_Handled): Gets or sets whether the event is handled or not.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeView x:Name="treeView" KeyDown="OnTreeViewKeyDown "/>
{% endhighlight %}
{% highlight c# %}

private void OnTreeViewKeyDown(object? sender, KeyPressEventArgs e)
{

}

{% endhighlight %}
{% endtabs %}

## Update the runtime changes

The [PropertyChanged](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_PropertyChanged) event will be triggered whenever a property in the customized TreeViewNode is changed. You can get the name of the property that changed by using the `PropertyName` property of the `PropertyChangedEventArgs`.

{% tabs %}
{% highlight c# %}
treeviewnode.PropertyChanged += Treeviewnode_PropertyChanged;

private void Treeviewnode_PropertyChanged(object sender, PropertyChangedEventArgs e)
{
    if (e.PropertyName == "IsExpanded")
    {
        if (treeviewnode.IsExpanded)
            DisplayAlert("treeview", "nodeexpanded", "ok");
        else
            DisplayAlert("treeview", "nodecollapsed", "ok");
    }
}
{% endhighlight %}
{% endtabs %}

## Refresh layout

You can refresh the `TreeViewNode` from the root node and update all layout by using the [SetDirty](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_SetDirty) method that notifies the tree view layout mechanism to invalidate nodes.

{% tabs %}
{% highlight c# %}
node.SetDirty();
{% endhighlight %}
{% endtabs %}

