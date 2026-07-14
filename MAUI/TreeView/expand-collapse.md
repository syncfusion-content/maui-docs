---
layout: post
title: Expand and Collapse in .NET MAUI TreeView Control | Syncfusion®
description: Learn here all about Expand and Collapse support in the Syncfusion® .NET MAUI TreeView (SfTreeView) control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Expand and collapse in .NET MAUI TreeView (SfTreeView)

The TreeView allows you to expand and collapse nodes through user interaction or programmatically.

## Expand action target

Nodes can be expanded and collapsed by tapping the expander view or by setting the [ExpandActionTarget](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandActionTarget) property to control where taps trigger the expand or collapse action.

The `ExpandActionTarget` property accepts the following values of the `TreeViewExpandActionTarget` enum:

* `Expander` : Expand or collapse actions occur only when the expander view is tapped. This is the default.
* `Node` : Expand or collapse actions occur when the node content is tapped. The expander view continues to respond to taps as well.

When `ExpandActionTarget` is set to `Node`, tap input on either the content area or the expander view expands or collapses the node. The default value is `Expander`, which restricts the action to the expander view only.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfTreeView x:Name="treeView" ExpandActionTarget="Node"/>

{% endhighlight %}
{% highlight c# %}

// Expands or collapses when the content view or expander is tapped.
treeView.ExpandActionTarget = TreeViewExpandActionTarget.Node;

{% endhighlight %}
{% endtabs %}

## Expand and collapse using keyboard

The TreeView supports expanding and collapsing nodes with the right and left arrow keys. Press the right arrow key to expand a node; press the left arrow key to collapse the focused node.

To use these keyboard shortcuts, first move keyboard focus to the desired node using the Tab key or by tapping it. Arrow-key expansion is supported on platforms that provide a hardware or software keyboard (Windows, macOS, and iPad with an attached keyboard). On iOS and Android without an attached keyboard, use tap gestures on the expander view or node content instead.

## Auto expand mode

By default, the items in the TreeView load in a collapsed state. You can control how nodes expand when the TreeView loads by using the [AutoExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandMode) property.

The `AutoExpandMode` property applies only in bound mode. In unbound mode, set the `IsExpanded` property to `true` on each node to load it in the expanded state.

* `None` : All items are collapsed when loaded. This is the default.
* `RootNodesExpanded` : Expands only the root-level items when loaded.
* `AllNodesExpanded` : Expands all items when loaded.

## Programmatic expand and collapse

The TreeView supports programmatic expansion and collapse based on a [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) or a level using the following methods.

* [ExpandNode(TreeViewNode item)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNode_Syncfusion_TreeView_Engine_TreeViewNode_) - Expands the specified `TreeViewNode`.
* [CollapseNode(TreeViewNode item)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNode_Syncfusion_TreeView_Engine_TreeViewNode_) - Collapses the specified `TreeViewNode`.
* [ExpandNodes(int level)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNodes_System_Int32_) - Expands all items at the specified level.
* [CollapseNodes(int level)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNodes_System_Int32_) - Collapses all items at the specified level.

{% tabs %}
{% highlight c# %}

// Expands all nodes at root level '0'.
treeView.ExpandNodes(0);

// Collapses all nodes at root level '0'.
treeView.CollapseNodes(0);

// Expands a particular node.
treeView.ExpandNode(node);

// Collapses a particular node.
treeView.CollapseNode(node);

{% endhighlight %}
{% endtabs %}

To use the `ExpandNode` and `CollapseNode` methods, pass the corresponding `TreeViewNode` instance. You can obtain a node from the `TreeView.Nodes` collection, the bound data source, or from the event arguments of the `NodeExpanding` or `NodeCollapsing` events.

{% tabs %}
{% highlight c# %}

// Obtain the first root node and expand it.
var node = treeView.Nodes[0];
treeView.ExpandNode(node);

{% endhighlight %}
{% endtabs %}

### Expand and collapse all nodes

Use the [SfTreeView.ExpandAll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandAll) and [SfTreeView.CollapseAll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseAll) methods to expand or collapse every [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) at runtime.

{% tabs %}
{% highlight c# %}

// Expands all nodes.
treeView.ExpandAll();

// Collapses all nodes.
treeView.CollapseAll();

{% endhighlight %}
{% endtabs %}

## Bind the IsExpanded property in unbound mode

In unbound mode, the `TreeView` supports binding the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsExpanded) property on each `TreeViewNode`.

To use `INotifyPropertyChanged` in the ViewModel, include the `System.ComponentModel` namespace.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="16 19" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:treeviewengine="clr-namespace:Syncfusion.TreeView.Engine;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:IsExpanded"
             x:Class="IsExpanded.MainPage">

    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewmodel"/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeview">
            <syncfusion:SfTreeView.Nodes>
                <treeviewengine:TreeViewNode Content="United States of America"
                                             IsExpanded="{Binding Path=IsExpanded,Source={x:Reference viewmodel}}">
                    <treeviewengine:TreeViewNode.ChildNodes>
                        <treeviewengine:TreeViewNode Content="New York"
                                                     IsExpanded="{Binding Path=IsExpanded,Source={x:Reference viewmodel}}"/>
                    </treeviewengine:TreeViewNode.ChildNodes>
                </treeviewengine:TreeViewNode>
            </syncfusion:SfTreeView.Nodes>
        </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}
using System.ComponentModel;

public class ViewModel : INotifyPropertyChanged
{
    private bool isExpanded;

    // Implementation of the IsExpanded property.
    public bool IsExpanded
    {
        get { return isExpanded; }
        set
        {
            isExpanded = value;
            OnPropertyChanged("IsExpanded");
        }
    }

    public ViewModel()
    {
        IsExpanded = true;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    // Triggers property change notifications so bound UI updates automatically.
    protected void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Events

The TreeView exposes the following events to handle the expanding and collapsing of items.

* [NodeCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsing) - Occurs when a node is about to be collapsed. Cancelable.
* [NodeExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanding) - Occurs when a node is about to be expanded. Cancelable.
* [NodeCollapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsed) - Occurs after a node has been collapsed.
* [NodeExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanded) - Occurs after a node has been expanded.

Use `NodeCollapsing` and `NodeExpanding` to handle or cancel an action in progress, and `NodeCollapsed` and `NodeExpanded` to respond after the action completes.

{% tabs %}
{% highlight c# %}

using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Subscribe to events
        treeView.NodeExpanding += TreeView_NodeExpanding;
        treeView.NodeExpanded += TreeView_NodeExpanded;
        treeView.NodeCollapsing += TreeView_NodeCollapsing;
        treeView.NodeCollapsed += TreeView_NodeCollapsed;
    }

    private void TreeView_NodeExpanding(object sender, NodeExpandingEventArgs e)
    {
        // Handle or cancel the expanding action.
        // e.Node represents the node being expanded.

        // Example:
        // e.Cancel = true;
    }

    private void TreeView_NodeExpanded(object sender, NodeExpandedEventArgs e)
    {
        // Handle the expanded event.
        // e.Node represents the expanded node.
    }

    private void TreeView_NodeCollapsing(object sender, NodeCollapsingEventArgs e)
    {
        // Handle or cancel the collapsing action.
        // e.Node represents the node being collapsed.

        // Example:
        // e.Cancel = true;
    }

    private void TreeView_NodeCollapsed(object sender, NodeCollapsedEventArgs e)
    {
        // Handle the collapsed event.
        // e.Node represents the collapsed node.
    }
}

{% endhighlight %}
{% endtabs %}

You can also handle expand and collapse operations through commands using the [ExpandCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandCommand) and [CollapseCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseCommand) properties.

{% tabs %}
{% highlight c# %}

// Bind commands to ViewModel.
treeView.ExpandCommand = new Command<TreeViewNode>(node =>
{
    // Executed when a node expands.
});

treeView.CollapseCommand = new Command<TreeViewNode>(node =>
{
    // Executed when a node collapses.
});

{% endhighlight %}
{% endtabs %}
