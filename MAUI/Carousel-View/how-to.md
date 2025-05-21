---
layout: post
title: "Interaction in Syncfusion® Carousel Control in .NET MAUI"
description: "Learn how to perform operations when changing the CarouselItem or collection in Carousel for .NET MAUI."
platform: maui
control: Carousel
documentation: ug
---

# How to Perform an Operation While Changing the CarouselItem?

You can perform operations while changing the CarouselItem using the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectionChanged) event. This event returns both the OldItem and the newly selected NewItem.

## Example

Here is an example of how to handle the SelectionChanged event in a Carousel:

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ItemHeight="170"
                     ItemWidth="270"
                     SelectionChanged="Carousel_SelectionChanged"/>

{% endhighlight %}

{% highlight C# %}


SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
};

carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
carousel.SelectionChanged += Carousel_SelectionChanged;

// Event handler triggered when the carousel item's selection changes.
private void Carousel_SelectionChanged(object sender, Syncfusion.Maui.Core.Carousel.SelectionChangedEventArgs e)
{
    int count = (sender as SfCarousel).SelectedIndex + 1;
    DisplayAlert("SelectionChanged", "Carousel item:" + count + " has Selected", "Ok");
}

{% endhighlight %}

{% endtabs %}


