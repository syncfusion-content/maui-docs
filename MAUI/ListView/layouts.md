---
layout: post
title: Layouts in .NET MAUI ListView control | Syncfusion
description: Learn here all about Layouts support in Syncfusion .NET MAUI ListView (SfListView) control, its elements and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Layouts in .NET MAUI ListView (SfListView)

The `SfListView` supports different layouts such as linear layout and grid layout. The `SfListView.ItemsLayout` property is used to define the layout.

## Linear Layout

Linear layout arrange items in a single column. Initialize the `LinearLayout`, and assign it to the `SfListView.ItemsLayout` property to load the `SfListView` in linear layout. It is the default layout.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                    ItemsSource="{Binding GalleryInfo}"
                    ItemSize="100">
      <syncfusion:SfListView.ItemsLayout>
        <syncfusion:LinearLayout />
      </syncfusion:SfListView.ItemsLayout>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight%}
{% highlight c# %}
listView.ItemsLayout = new LinearLayout();
{% endhighlight%}
{% endtabs %}

## Grid Layout

Grid layout arrange items in a predefined number of columns. Initialize the `GridLayout`, and assign it to the `SfListView.ItemsLayout` property to load the `SfListView` in grid layout. 

The number of columns can be defined by using the `SpanCount` property of `GridLayout`. Default `SpanCount` is `2`.

In `Horizontal` orientation, `SpanCount` defines the number of rows.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                    ItemsSource="{Binding GalleryInfo}"
                    ItemSize="100">
      <syncfusion:SfListView.ItemsLayout>
        <syncfusion:GridLayout SpanCount="2" />
      </syncfusion:SfListView.ItemsLayout>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight%}
{% highlight c# %}
listView.ItemsLayout = new GridLayout() { SpanCount = 2 };
{% endhighlight%}
{% endtabs %}

## Change span count based on screen size

In the `SfListView`, the `GridLayout` allows changing the `SpanCount` based on the view size of application with orientation in either portrait or landscape mode.

{% tabs %}
{% highlight c# %}
public partial class GridLayoutPage : ContentPage
{
  protected override void OnSizeAllocated(double width, double height) 
  { 
    base.OnSizeAllocated(width, height); 
 
    if (width > 0 && pageWidth != width) 
    {       
        var size = Application.Current.MainPage.Width / listView.ItemSize; 
        gridLayout.SpanCount = (int)size; 
        listView.LayoutManager = gridLayout; 
     } 
  }
}
{% endhighlight %}
{% endtabs %}

                                                                                                                                                                                    