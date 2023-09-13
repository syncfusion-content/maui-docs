---
layout: post
title: Item Height Customization in .NET MAUI TreeView | Syncfusion
description: Learn here all about Item Height Customization support in Syncfusion .NET MAUI TreeView (SfTreeView) control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Item Height Customization in .NET MAUI TreeView (SfTreeView)

The TreeView offers several options for customizing the height of items. To achieve this customization, please follow the steps outlined in the sections below.

## Customize Item Height

The TreeView allows for customization of item height by setting the `ItemHeight` property. The default value of this property is `48d`. This property can be customized at runtime.

{% tabs %}
{% highlight xaml hl_lines="24" %}
<syncfusion:SfTreeView x:Name="treeView" ItemHeight="40">
{% endhighlight %}
{% highlight c# %}
SfTreeView treeView = new SfTreeView();
treeView.ItemHeight = 40; 
{% endhighlight %}
{% endtabs %}

## Customize Item height using `QueryNodeSize` event
The TreeView allows customization of the height of the items using the `QueryNodeSize` event. This event is raised whenever the item comes into view and is triggered with `QueryNodeSizeEventArgs`.

The `SfTreeView.QueryNodeSize` event provides the following arguments:
 
 * `Node` : This argument contains the `TreeViewNode` and data associated with it.
 * `Height` : This argument contains the default item height of the queried item and can be set with desired size.
 * `Handled` : Decides whether the specified or measured height can be set to the item or not. The default value is `false`. When this property is not set, the decided height will not set to the item.
 * `GetActualNodeHeight` : This method will return the measured height of the node item based on the content loaded in it.

### Customize specific item height using custom value

The TreeView allows customization of the height of a specific item by directly setting the custom value to the `Height` argument, which is available in `QueryNodeSizeEventArgs`.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
       <local:FileManagerViewModel x:Name="viewModel"></local:FileManagerViewModel>
    </ContentPage.BindingContext>
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView"
                              QueryNodeSize="TreeView_QueryNodeSize"
                              ChildPropertyName="SubFiles"
                              ItemsSource="{Binding ImageNodeInfo}"/>
       </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
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
            //Returns speified item height for items.
            e.Height = 200;
            e.Handled = true;
        }
    }
}
{% endhighlight %}
{% endtabs %}

### Customize specific item height based on the content size

The TreeView allows adjusting height of items based on the content measured size while loaded by setting the `Height` argument with the value returned from the `QueryNodeSizeEventArgs.GetActualNodeHeight` method.
                                             
{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
       <local:FileManagerViewModel x:Name="viewModel"></local:FileManagerViewModel>
    </ContentPage.BindingContext>
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView"
                              QueryNodeSize="TreeView_QueryNodeSize"
                              ChildPropertyName="SubFiles"
                              ItemsSource="{Binding ImageNodeInfo}"/>
       </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
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

![.NET MAUI TreeView Item Height Customization](Images/item-height-customization/maui-treeview-item-height.png)


## Limitations

 * Define the size of the image when loading an image in the `SfTreeView.ItemTemplate`. Because it does not return the actual measured size when measuring before the item layout.

