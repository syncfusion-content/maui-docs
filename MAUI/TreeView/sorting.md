---
layout: post
title: Sorting in .NET MAUI TreeView Control | Syncfusion®
description: Learn about sorting support in the Syncfusion® .NET MAUI TreeView (SfTreeView) control.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Sorting in .NET MAUI TreeView (SfTreeView)

The [SfTreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html) control provides built-in support for sorting data using the [SortDescriptors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SortDescriptors) property. Items can be sorted in either ascending or descending order. Custom sorting logic is also supported to sort the items.

## Programmatic sorting

Sort items by creating a [SortDescriptor](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.SortDescriptor.html) with the property name and sort direction, and then adding it to the `SortDescriptors` collection.

`SortDescriptor` object holds the following three properties:

* [PropertyName](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.SortDescriptor.html#Syncfusion_TreeView_Engine_SortDescriptor_PropertyName): Describes the name of the sorted property.
* [Direction](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.SortDescriptor.html#Syncfusion_TreeView_Engine_SortDescriptor_Direction): Describes an object of type [TreeViewSortDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewSortDirection.html) that defines the sorting direction.
* [Comparer](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.SortDescriptor.html#Syncfusion_TreeView_Engine_SortDescriptor_Comparer): Describes the comparer to be applied when sorting takes place.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 5" %}
<ContentPage>
    <ContentPage.BindingContext>
        <local:FileManagerViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView">
            <syncfusion:SfTreeView.SortDescriptors>
                <treeviewengine:SortDescriptor PropertyName="ItemName" Direction="Ascending" />
            </syncfusion:SfTreeView.SortDescriptors>
        </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="11 13 14 16" %}
using Syncfusion.Maui.TreeView;
using Syncfusion.TreeView.Engine;

public class MainPage : ContentPage
{
    SfTreeView treeView;
    public MainPage()
    {
        InitializeComponent();
        treeView = new SfTreeView();
        var sortDescriptor = new SortDescriptor()
        {
            PropertyName = "ItemName",
            Direction = TreeViewSortDirection.Ascending
        };
        treeView.SortDescriptors.Add(sortDescriptor);
        this.Content = treeView;
    }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI TreeView Programmatic sorting](images/sorting/maui-treeView-programmatic-sorting.gif)

N> It is mandatory to specify the `PropertyName` of `SortDescriptor` when using programmatic sorting.

## Custom sorting

Custom sorting can be applied by assigning a comparer to the `SortDescriptor.Comparer` property. The descriptor is then added to the `SortDescriptors` collection.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="12 13" %}
<ContentPage>
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:CustomDateSortComparer x:Key="CustomSortComparer" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.BindingContext>
        <local:FileManagerViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView">
            <syncfusion:SfTreeView.SortDescriptors>
                <treeviewengine:SortDescriptor Comparer="{StaticResource CustomSortComparer}" />
            </syncfusion:SfTreeView.SortDescriptors>
        </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="CustomSortComparer.cs" %}
using System;
using System.Collections.Generic;

public class CustomDateSortComparer : IComparer<object>
{
    public int Compare(object x, object y)
    {
        if (x is FileManager xFile && y is FileManager yFile)
        {
            // Returns dates in descending order (most recent first)
            return -DateTime.Compare(xFile.Date, yFile.Date);
        }
        return 0;
    }
}
{% endhighlight %}
{% endtabs %}

## Clear sorting

When the `SortDescriptors` collection is cleared, the TreeView control restores the original order of its nodes, displaying them in the default sequence as defined in the underlying data source and effectively removing any applied sorting.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
treeView.SortDescriptors.Clear();
{% endhighlight %}
{% endtabs %}

N> When the new collection is updated to the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource), the `SortDescriptors` should be cleared and reinitialized manually based on the requirements for sorting.

N> [View sample in GitHub](https://github.com/SyncfusionExamples/custom-sorting-in-.net-maui-treeview)