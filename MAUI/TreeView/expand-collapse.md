---
layout: post
title: Expand and Collapse in .NET MAUI TreeView Control | Syncfusion
description: Learn here all about Expand and Collapse support in the Syncfusion .NET MAUI TreeView (SfTreeView) control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Expand and Collapse in .NET MAUI TreeView (SfTreeView)

The TreeView allows you to expand and collapse the nodes through user interaction or programmatically. 

##  Expand action target

Expanding and collapsing of nodes can be performed by tapping the expander view or by setting the [ExpandActionTarget](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandActionTarget) property in both the expander view and content view.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfTreeView x:Name="treeView" ExpandActionTarget="Node"/>

{% endhighlight %}
{% highlight c# %}

// Extends by tapping both the expander and content views.
treeView.ExpandActionTarget = TreeViewExpandActionTarget.Node;

{% endhighlight %}
{% endtabs %}

## Auto expand mode

By default, the items in the treeview will be in a collapsed state. You can define how the nodes should be expanded when loading the TreeView by using the [AutoExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewAutoExpandMode.html) property.

The `AutoExpandMode` property is only applicable in bound mode. In the unbound mode, you need to set the `IsExpanded` property to `true` when creating the nodes in order for them to be in the expanded state when the TreeView is loaded.

* `None` : All items are collapsed when loaded.
* `RootNodesExpanded` : Expands only the root item when loaded.
* `AllNodesExpanded` : Expands all the items when loaded.

## Programmatic expand and collapse

TreeView allows programmatic expansion and collapse based on the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and level using the following methods.

* [ExpandNode(TreeViewNode item)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNode_Syncfusion_TreeView_Engine_TreeViewNode_) - Method to expand the particular `TreeViewNode` passed to it.
* [CollapseNode(TreeViewNode item)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNode_Syncfusion_TreeView_Engine_TreeViewNode_) - Method to collapse the particular `TreeViewNode` passed to it.
* [ExpandNodes(int level)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNodes_System_Int32_) - Method to expand the all items of level passed to it.
* [CollapseNodes(int level)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNodes_System_Int32_) - Method to expand the all items of level passed to it.

{% tabs %}
{% highlight c# %}

// Expands all the nodes at root level '0'.
treeView.ExpandNodes(0);

// Collapses all the nodes at root level '0'.
treeView.CollapseNodes(0);

// Expand a particular node.
treeView.ExpandNode(node);

// Expand a particular node.
treeView.CollapseNode(node);

{% endhighlight %}
{% endtabs %}

### Expand and collapse all the nodes

Programmatically expand and collapse all the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) at runtime using the [SfTreeView.ExpandAll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandAll) and [SfTreeView.CollapseAll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseAll) methods.

{% tabs %}
{% highlight c# %}

//Expands all the nodes.
treeView.ExpandAll();

//Collapses all the nodes.
treeView.CollapseAll();

{% endhighlight %}
{% endtabs %}

## Expand and collapse using keyboard

TreeView allows the expansion and collapse of the nodes using the right and left arrow keys. To expand a node, press the right arrow key; to collapse a node, press the left arrow key on the focused item.

## Binding IsExpanded property in unbound mode

In unbound mode, the `TreeView` enables the binding of the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsExpanded) property to `TreeViewNode`.

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
public class ViewModel : INotifyPropertyChanged
{  
    private bool isExpanded;

    //Implementation of IsExpanded property 
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

    //Provide mechanisms for automatic updates when a property changes
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

TreeView exposes the following events to handle the expanding and collapsing of items.

* [NodeCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsing) - It occurs when a node is being collapsed.
* [NodeExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanding) - It occurs when a node is being expanded.
* [NodeCollapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsed) - It occurs when a node is collapsed.
* [NodeExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanded)  - It occurs when a node is expanded.

The expanding and collapsing interactions can be handled with the help of the `NodeCollapsing` and `NodeExpanding` events, and the expanded and collapsed interactions can be handled with the help of the `NodeCollapsed` and `NodeExpanded` events.

You can also achieve handling of expand and collapse operations using the [ExpandCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandCommand) and [CollapseCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseCommand).
