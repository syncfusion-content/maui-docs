---
layout: post
title: Swipe Events in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Swipe Events support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform: maui
control: Carousel
documentation: ug
---

# Swipe Events in .NET MAUI Carousel View (SfCarousel)

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Overview

The [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control raises swipe events that allow you to respond to swipe gestures on carousel items. The following API members are used to handle swipe interactions:

| Event | EventArgs Type | Description |
| --- | --- | --- |
| [SwipeStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeStarted) | [SwipeStartedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.SwipeStartedEventArgs.html#Syncfusion_Maui_Core_Carousel_SwipeStartedEventArgs__ctor) | Occurs when the swipe gesture starts on a carousel item. |
| [SwipeEnded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SwipeEnded) | EventArgs | Occurs after the swiping is completed on a carousel item. |

N> The `SwipeStarted` and `SwipeEnded` events are available starting with Syncfusion<sup>®</sup> .NET MAUI Carousel `v18.3.0.x` and later.

## SwipeStarted Event

The [SwipeStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeStarted) event occurs when the swipe gesture starts on a carousel item.

The [SwipeStartedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.SwipeStartedEventArgs.html#Syncfusion_Maui_Core_Carousel_SwipeStartedEventArgs__ctor) provides the following member:

| Member | Type | Description |
| --- | --- | --- |
| [IsSwipedLeft](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.SwipeStartedEventArgs.html#Syncfusion_Maui_Core_Carousel_SwipeStartedEventArgs_IsSwipedLeft) | `bool` | Indicates whether the swipe direction is from left to right. |

## SwipeEnded Event

The [SwipeEnded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeEnded) event occurs after the swiping is completed on a carousel item.

## Wiring Up the Swipe Events

The following example shows how to wire the [SwipeStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SwipeStarted) and [SwipeEnded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SwipeEnded) events to the carousel.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Image Source="{Binding Image}"
                    Aspect="AspectFit"/>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>
<carousel:SfCarousel x:Name="carousel"
                        SwipeStarted="carousel_SwipeStarted"
                        SwipeEnded="carousel_SwipeEnded"
                        ItemsSource="{Binding ImageCollection}"
                        ItemTemplate="{StaticResource itemTemplate}"
                        ItemHeight="170"
                        ItemWidth="270"
                        ItemSpacing="2"
                        AllowLoadMore="True"
                        ViewMode="Default"/>

{% endhighlight %}

{% highlight c# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    ItemSpacing = 2,
    AllowLoadMore = true,
    ViewMode = ViewMode.Default,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
carousel.SwipeStarted += carousel_SwipeStarted;
carousel.SwipeEnded += carousel_SwipeEnded;

private void carousel_SwipeStarted(object sender, Syncfusion.Maui.Core.Carousel.SwipeStartedEventArgs e)
{
    // Triggered when the swipe starts on a carousel item.
}

private void carousel_SwipeEnded(object sender, EventArgs e)
{
    // Triggered after the swipe ends on a carousel item.
}
    
{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
public class CarouselModel
{
    public CarouselModel(string imageString)
    {
        Image = imageString;
    }
    private string _image;

    public string Image
    {
        get { return _image; }
        set { _image = value; }
    }
}

//View Model
public class CarouselViewModel
{
    public CarouselViewModel()
    {
        ImageCollection.Add(new CarouselModel("carousel_person1.png"));
        ImageCollection.Add(new CarouselModel("carousel_person2.png"));
        ImageCollection.Add(new CarouselModel("carousel_person3.png"));
        ImageCollection.Add(new CarouselModel("carousel_person4.png"));
        ImageCollection.Add(new CarouselModel("carousel_person5.png"));
    }
    private List<CarouselModel> imageCollection = new List<CarouselModel>();
    public List<CarouselModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

![Carousel Swiping events](images/CarouselSwiping_GIF.gif)

## Troubleshooting

* If the swipe events do not fire, ensure that the carousel contains more than one item, as swiping between items is required.
* If the `IsSwipedLeft` value does not behave as expected, verify that the [ViewMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ViewMode) supports swiping (`Default` and `Linear` only).

## See Also

* [Getting Started with .NET MAUI Carousel](https://help.syncfusion.com/maui/carousel-view/getting-started)
* [Populating Data in .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/populating-data)
* [Load More in .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/loadmore)
* [Overview of .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/overview)
