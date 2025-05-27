---
layout: post
title: UI Virtualization in .NET MAUI Carousel View Control | Syncfusion®
description: Learn all about UI Virtualization support in the Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform: maui
control: Carousel
documentation: ug
---

# UI Virtualization in .NET MAUI Carousel View (SfCarousel)

In UI virtualization, only the number of items that fit the viewport of your device are arranged. Even if numerous items are added to the collection, only the viewport adaptable number of carousel items are loaded. When you swipe the items forward, new items are added to the right of the view, and an equal number of items are removed from the left to maintain the viewport item count. Similarly, when swiping backward, items are added to the left, and an equal number are removed from the right. This mechanism achieves virtualization in the carousel control.

## EnableVirtualization

The UI virtualization concept is implemented by enabling the [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization) property in SfCarousel Linear mode.

> Note: The default value of the [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization) property is false.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ItemHeight="200"
                     ItemWidth="200"
                     ItemSpacing="2"
                     ViewMode="Linear"
                     EnableVirtualization="true">
</carousel:SfCarousel>

{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    ItemHeight= 200,
    ItemWidth = 200,
    ItemSpacing = 2,
    EnableVirtualization = true,
    ViewMode = ViewMode.Linear
};

carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

![UIVirtualization](images/UIVirtualization.png)

Find the complete UIVirtualization sample from this [link](https://github.com/SyncfusionExamples/maui-carousel-samples/tree/master/UIVirtualization/VirtualizationSample).