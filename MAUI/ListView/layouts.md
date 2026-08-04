---
layout: post
title: Layouts in .NET MAUI ListView control | Syncfusion®
description: Learn here all about Layouts support in Syncfusion® .NET MAUI ListView (SfListView) control, its elements and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Layouts in .NET MAUI ListView (SfListView)

The `SfListView` supports different layouts such as linear and grid layouts. The [SfListView.ItemsLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsLayout) property is used to define the layout.

## Linear layout

The linear layout arranges items linearly in a single column vertically or a single row horizontally. Initialize a [LinearLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LinearLayout.html) and assign it to the [ItemsLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_ItemsLayout) property to display items in a linear layout. It is the default layout.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 6 7" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                    ItemsSource="{Binding CategoryInfo}"
                    ItemSize="100">
      <syncfusion:SfListView.ItemsLayout>
        <syncfusion:LinearLayout />
      </syncfusion:SfListView.ItemsLayout>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight%}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.ListView;
// ...
listView.ItemsLayout = new LinearLayout();
{% endhighlight%}
{% endtabs %}

![Syncfusion .NET MAUI ListView linear layout](Images/layouts/maui-listview-linear-layout.jpg)


## Grid layout

The grid layout arranges items in a configurable number of columns. Initialize a [GridLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GridLayout.html) and assign it to the [ItemsLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_ItemsLayout) property to display items in a grid layout. 

The number of columns can be defined by using the `SpanCount` property of `GridLayout`. The default `SpanCount` is `2`.

In `Horizontal` orientation, `SpanCount` defines the number of rows.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 6 7" %}
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
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.ListView;
// ...
listView.ItemsLayout = new GridLayout() { SpanCount = 2 };
{% endhighlight%}
{% endtabs %}

![Syncfusion .NET MAUI ListView grid layout](Images/layouts/maui-listview-grid-layout.jpg)


## Change span count based on screen size

In the `SfListView`, the [GridLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GridLayout.html) allows you to change the `SpanCount` based on the application's view size and orientation (portrait or landscape).

N> `ItemSize` represents a single dimension of the item. In a `GridLayout`, divide the available width by the per-cell width to compute the number of columns. In vertical orientation, use the item height; in horizontal orientation, use the item width.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12 13 14 15 16" %}
public partial class GridLayoutPage : ContentPage
{
  public GridLayoutPage()
  {
      InitializeComponent();
      this.PropertyChanged += GridLayoutPage_PropertyChanged;
  }

  private void GridLayoutPage_PropertyChanged(object sender, PropertyChangedEventArgs e)
  {
      if (e.PropertyName == "Width")
      {
          // Use the item's per-cell width to compute the number of columns.
          var cellWidth = listView.ItemSize;
          var size = Application.Current.MainPage.Width / cellWidth;
          gridLayout.SpanCount = Math.Max(1, (int)size);
          listView.ItemsLayout = gridLayout;
      }
  }
}
{% endhighlight %}
{% endtabs %}

                                                                                                                                                                                    