---
layout: post
title: Sorting in .NET MAUI TreeView Control | Syncfusion
description: Learn here all about Sorting support in Syncfusion .NET MAUI TreeView (SfTreeView) Control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Sorting in .NET MAUI TreeView (SfTreeView)

The `SfTreeView` supports sorting the data either in ascending or descending order by using the `SortDescriptors` property and custom logic.

## Programmatic sorting

Sorting the data by creating a `SortDescriptor` with the required property name and direction and adding it into the `SortDescriptors` property.

`SortDescriptor` object holds the following three properties:

* `PropertyName`: Describes the name of the sorted property.
* `Direction`: Describes an object of type `TreeViewSortDirection` that defines the sorting direction.
* `Comparer`: Describes the comparer to be applied when sorting takes place.

{% tabs %}
{% highlight xaml hl_lines="3 4" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView">
  <syncfusion:SfTreeView x:Name="treeView">
        <syncfusion:SfTreeView.SortDescriptors>
            <treeviewengine:SortDescriptor PropertyName="ItemName" Direction="Ascending" />
        </syncfusion:SfTreeView.SortDescriptors>                    
  </syncfusion:SfTreeView>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="3 4" %}
    treeView.SortDescriptors.Add(new SortDescriptor()
    {
        PropertyName = "ItemName",
        Direction = TreeViewSortDirection.Ascending
    });
{% endhighlight %}
{% endtabs %}

N> It is mandatory to specify the `PropertyName` of `SortDescriptor` in Programmatic Scrolling.

## Custom sorting

Sort the items based on the custom logic and it can be applied to `SortDescriptor.Comparer`, which is added into the `SortDescriptors` collection.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 9" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView">
  <ContentPage.Resources>
    <ResourceDictionary>
      <local:CustomSortComparer x:Key="CustomSortComparer" />
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

    public class CustomSortComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x.GetType() == typeof(FileManager))
            {
                var xitem = (x as FileManager).ItemName;
                var yitem = (y as FileManager).ItemName;

                if (xitem.Length > yitem.Length)
                {
                    return 1;
                }
                else if (xitem.Length < yitem.Length)
                {
                    return -1;
                }
                else
                {
                    if (string.Compare(xitem, yitem) == -1)
                        return -1;
                    else if (string.Compare(xitem, yitem) == 1)
                        return 1;
                }
            }

            return 0;
        }
    }

{% endhighlight %}
{% endtabs %}

## Clear Sorting

When the `SortDescriptors` collection is cleared, it restores the default order of the node collection, and the TreeView reverts to its original order.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView">
  <Grid RowDefinitions="Auto,*">
      <Button Text="Clear Sorting" Clicked="Clear_Sorting"/>
      <syncfusion:SfTreeView x:Name="treeView" Grid.Row="1">
        <syncfusion:SfTreeView.SortDescriptors>
            <treeviewengine:SortDescriptor PropertyName="ItemName" Direction="Ascending" />
        </syncfusion:SfTreeView.SortDescriptors>                    
      </syncfusion:SfTreeView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
   private void Clear_Sorting(object sender, EventArgs e)
   {
	  treeView.SortDescriptors.Clear();
   }
{% endhighlight %}
{% endtabs %}