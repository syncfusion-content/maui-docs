---
layout: post
title: Swipe Events in .NET MAUI Carousel View control | Syncfusion
description: Learn here all about Swipe Events support in Syncfusion .NET MAUI Carousel View (SfCarousel) control and more.
platform: maui
control: Carousel
documentation: ug
---

# Swipe Events in .NET MAUI Carousel View (SfCarousel)

## SwipeStarted Event

The `SwipeStarted` event will be triggered when the swipe gesture is started.

`SwipeStartedEventArgs` contains the `IsSwipeLeft` value, which denotes whether the swipe direction is from the left side or not.

## SwipeEnded Event

The `SwipeEnded` event can be triggered after the swiping is completed in the carousel items.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
    SwipeStarted="carousel_SwipeStarted"
    SwipeEnded="carousel_SwipeEnded"
    ItemsSource="{Binding ImageCollection}"
    ItemHeight="200"
    ItemWidth="200"
    ItemSpacing="2"
    AllowLoadMore="True"
    ViewMode="Linear">
</carousel:SfCarousel>
	
{% endhighlight %}

{% highlight c# %}

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
