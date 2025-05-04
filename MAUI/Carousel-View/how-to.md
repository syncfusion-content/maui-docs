---
layout : post
title: Interaction in Syncfusion® Carousel Control in .NET MAUI.
description: Learn how to perform an operation while changing the carouselItem or Collection in Carousel for .NET MAUI.
platform : maui
control : Carousel
documentation : ug
---

# How to perform an operation while changing the CarouselItem?

We can perform the operation while changing the CarouselItem using the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectionChanged) event. The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectionChanged) event returns the OldItem and selected NewItem.

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

// Trigger when selection changed in the carousel item.
private void Carousel_SelectionChanged(object sender, Syncfusion.Maui.Core.Carousel.SelectionChangedEventArgs e)
{
    int count = (sender as SfCarousel).SelectedIndex + 1;
    DisplayAlert("SelectionChanged", "Carousel item:" + count + " has Selected", "Ok");
}

{% endhighlight %}

{% endtabs %}


