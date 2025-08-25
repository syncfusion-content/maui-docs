---
layout: post
title: Sorting in .NET MAUI TreeView Control | Syncfusion
description: Learn here all about Sorting support in Syncfusion .NET MAUI TreeView (SfTreeView) Control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Sorting in .NET MAUI TreeView (SfTreeView)

The `SfTreeView` control provides built-in support for sorting data using the `SortDescriptors` property. Items can be sorted in either ascending or descending order. Custom sorting logic is also supported to sort the items.

N> When the `ItemsSource` of the `SfTreeView` is updated, the existing `SortDescriptors` are automatically cleared. To maintain sorting behavior after changing the `ItemsSource`, you must retain sorting in the `SfTreeView`.

## Programmatic sorting

Sort items by creating a `SortDescriptor` with the property name and sort direction, and then adding it to the `SortDescriptors` collection.

`SortDescriptor` object holds the following three properties:

* `PropertyName`: Describes the name of the sorted property.
* `Direction`: Describes an object of type `TreeViewSortDirection` that defines the sorting direction.
* `Comparer`: Describes the comparer to be applied when sorting takes place.

{% tabs %}
{% highlight xaml hl_lines="4 5" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:treeviewengine="clr-namespace:Syncfusion.TreeView.Engine;assembly=Syncfusion.Maui.TreeView">
  <syncfusion:SfTreeView x:Name="treeView">
        <syncfusion:SfTreeView.SortDescriptors>
            <treeviewengine:SortDescriptor PropertyName="ItemName" Direction="Ascending" />
        </syncfusion:SfTreeView.SortDescriptors>                    
  </syncfusion:SfTreeView>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="14 16 17 20" %}
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

![Programmatic sorting in .NET MAUI TreeView](images/sorting/maui-treeView-programmatic-sorting.gif)

N> It is mandatory to specify the `PropertyName` of `SortDescriptor` in programmatic sorting.

## Custom sorting

Custom sorting can be applied by assigning a comparer to the `SortDescriptor.Comparer` property and the comparer will be added to the `SortDescriptors` collection.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 9" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:treeviewengine="clr-namespace:Syncfusion.TreeView.Engine;assembly=Syncfusion.Maui.TreeView">
  <ContentPage.Resources>
    <ResourceDictionary>
      <local:CustomDateSortComparer x:Key="CustomSortComparer" />
    </ResourceDictionary>
  </ContentPage.Resources>
  <syncfusion:SfTreeView x:Name="treeView">
        <syncfusion:SfTreeView.SortDescriptors>
            <treeviewengine:SortDescriptor Comparer="{StaticResource CustomSortComparer}" />
        </syncfusion:SfTreeView.SortDescriptors>                    
  </syncfusion:SfTreeView>
</ContentPage>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="CustomSortComaparer.cs" %}

    public class CustomDateSortComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is FileManager xFile && y is FileManager yFile)
            {
                // Latest file upadted dates will come first (descending order)
                return -DateTime.Compare(xFile.Date, yFile.Date);
            }
            return 0;
        }
    }

{% endhighlight %}
{% endtabs %}

## Clear sorting

When the `SortDescriptors` collection is cleared, it restores the default order of the node collection, and the TreeView reverts to its original order.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeView.SortDescriptors.Clear();
{% endhighlight %}
{% endtabs %}