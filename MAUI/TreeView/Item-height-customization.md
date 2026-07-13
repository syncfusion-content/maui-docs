---
layout: post
title: Item Height Customization in .NET MAUI TreeView | Syncfusion®
description: Learn here all about Item Height Customization support in Syncfusion® .NET MAUI TreeView (SfTreeView) control.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Item Height Customization in .NET MAUI TreeView (SfTreeView)

The TreeView offers several options for customizing the height of items. The following sections describe each option.

## Customize item height

The TreeView allows to customize the item height by setting the [ItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemHeight) property. The default value is `48d`. You can also customize this property at runtime.

{% tabs %}
{% highlight xaml hl_lines="3" %}
<ContentPage>
    <syncfusion:SfTreeView x:Name="treeView"
                           ItemHeight="40"/>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="10" %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    SfTreeView treeView;
    public MainPage()
    {
        InitializeComponent();
        treeView = new SfTreeView();
        treeView.ItemHeight = 40;
        this.Content = treeView;
    }
}
{% endhighlight %}
{% endtabs %}

## Customize item height using the `QueryNodeSize` event

The TreeView allows to customize the height of items using the [QueryNodeSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_QueryNodeSize) event. This event fires whenever an item comes into view and provides the [QueryNodeSizeEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html).

The `SfTreeView.QueryNodeSize` event provides the following arguments:

 * [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html#Syncfusion_Maui_TreeView_QueryNodeSizeEventArgs_Node) : Contains the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) and its associated data
 * [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html#Syncfusion_Maui_TreeView_QueryNodeSizeEventArgs_Height) : Contains the default item height of the queried item, which you can set to the desired size
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html#Syncfusion_Maui_TreeView_QueryNodeSizeEventArgs_Handled) : Decides whether the specified or measured height is applied to the item. The default value is `false`. The decided height is applied only when you set this property to `true`
 * [GetActualNodeHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html#Syncfusion_Maui_TreeView_QueryNodeSizeEventArgs_GetActualNodeHeight) : Returns the measured height of the node item based on its loaded content

### Customize specific item height using custom value

The TreeView allows to customize the height of a specific item by setting a custom value to the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html#Syncfusion_Maui_TreeView_QueryNodeSizeEventArgs_Height) argument in [QueryNodeSizeEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7" %}
<ContentPage>
    <ContentPage.BindingContext>
        <local:FileManagerViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView"
                               QueryNodeSize="TreeView_QueryNodeSize"
                               ChildPropertyName="SubFiles"
                               ItemsSource="{Binding ImageNodeInfo}"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs"  hl_lines="8" %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.treeView.QueryNodeSize += TreeView_QueryNodeSize;
    }

    private void TreeView_QueryNodeSize(object sender, QueryNodeSizeEventArgs e)
    {
        if (e.Node.Level == 0)
        {
            //Returns the specified item height for the items.
            e.Height = 200;
            e.Handled = true;
        }
    }
}
{% endhighlight %}
{% endtabs %}

### Customize specific item height based on the content size

The TreeView allows to adjust the height of items based on the measured size of their content by setting the `Height` argument with the value returned from the [QueryNodeSizeEventArgs.GetActualNodeHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html#Syncfusion_Maui_TreeView_QueryNodeSizeEventArgs_GetActualNodeHeight) method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage>
    <ContentPage.BindingContext>
        <local:FileManagerViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView"
                               QueryNodeSize="TreeView_QueryNodeSize"
                               ChildPropertyName="SubFiles"
                               ItemsSource="{Binding ImageNodeInfo}"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.treeView.QueryNodeSize += TreeView_QueryNodeSize;
    }

    private void TreeView_QueryNodeSize(object sender, QueryNodeSizeEventArgs e)
    {
        if (e.Node.Level != 0)
        {
            // Returns item height based on the content loaded.
            e.Height = e.GetActualNodeHeight();
            e.Handled = true;
        }
    }
}
{% endhighlight %}
{% endtabs %}

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/item-height-customization-in-.net-maui-treeview).

![Syncfusion .NET MAUI TreeView Item Height Customization](Images/item-height-customization/maui-treeview-item-height.png)

## Autofit the node height to content

The TreeView allows dynamically adjust the node height based on the content loaded in the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplate) by setting the [NodeSizeMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeSizeMode) property to `Dynamic`. The default value is `None`.

The `NodeSizeMode` property supports the following values:

 * [Dynamic](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewNodeSizeMode.html#Syncfusion_Maui_TreeView_TreeViewNodeSizeMode_Dynamic): Automatically adjusts the node height to fit its content, and resizes the node if the content size changes at runtime
 * [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewNodeSizeMode.html#Syncfusion_Maui_TreeView_TreeViewNodeSizeMode_None): Uses [ItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemHeight) to layout the nodes

{% tabs %}
{% highlight xaml hl_lines="6" %}
<ContentPage>
    <ContentPage.BindingContext>
        <local:FileManagerViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView"
                               ChildPropertyName="SubFiles"
                               ItemsSource="{Binding ImageNodeInfo}"
                               NodeSizeMode="Dynamic"/>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="6" %}
using Syncfusion.Maui.TreeView;

public class MainPage : ContentPage
{
    SfTreeView treeView;
    public MainPage()
    {
        InitializeComponent();
        treeView = new SfTreeView();
        FileManagerViewModel viewModel = new FileManagerViewModel();
        treeView.ChildPropertyName = "SubFiles";
        treeView.ItemsSource = viewModel.ImageNodeInfo;
        treeView.NodeSizeMode = NodeSizeMode.Dynamic;
        this.Content = treeView;
    }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI TreeView Item Height Customization](Images/item-height-customization/maui-treeview-nodesizemode.png)

## Limitations

 * Define the size of the image when loading an image in the [SfTreeView.ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplate). Because it does not return the actual measured size when measuring before the item layout.

