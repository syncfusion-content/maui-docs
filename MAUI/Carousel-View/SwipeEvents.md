---
layout: post
title: Swipe Events in .NET MAUI Carousel View Control | Syncfusion®
description: Learn all about Swipe Events support in the Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform: maui
control: Carousel
documentation: ug
---

# Swipe Events in .NET MAUI Carousel View (SfCarousel)

## SwipeStarted Event

The [SwipeStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeStarted) event is triggered when the swipe gesture starts.

[SwipeStartedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.SwipeStartedEventArgs.html#Syncfusion_Maui_Core_Carousel_SwipeStartedEventArgs__ctor) contains the [IsSwipeLeft](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.SwipeStartedEventArgs.html#Syncfusion_Maui_Core_Carousel_SwipeStartedEventArgs_IsSwipedLeft) value, indicating whether the swipe direction is from the left side.

## SwipeEnded Event

The [SwipeEnded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeEnded) event triggers after the swiping is completed in the carousel items.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
    SwipeStarted="carousel_SwipeStarted"
    SwipeEnded="carousel_SwipeEnded"
    ItemsSource="{Binding ImageCollection}"
    ItemTemplate="{StaticResource itemTemplate}" 
    ItemHeight="200"
    ItemWidth="200"
    ItemSpacing="2"
    AllowLoadMore="True"
    ViewMode="Default">
</carousel:SfCarousel>
	
{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    ItemHeight= 200,
    ItemWidth = 200,
    ItemSpacing = 2,
    AllowLoadMore = true,
    ViewMode = ViewMode.Default
};
carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
carousel.SwipeStarted += carousel_SwipeStarted;
carousel.SwipeEnded += carousel_SwipeEnded;

private async void carousel_SwipeStarted(object sender, Syncfusion.Maui.Core.Carousel.SwipeStartedEventArgs e)
{
    // Trigger when swipe starts in the carousel item.
}

private async void carousel_SwipeEnded(object sender, System.EventArgs e)
{
    // Trigger before swipe ends in the carousel item.
}

{% endhighlight %}

{% endtabs %}

![Carousel Swiping events](images/CarouselSwiping_GIF.gif)
