---
layout: post
title: "Animation in .NET MAUI CarouselView Control | Syncfusion®"
description: "Learn about animation support in the Syncfusion® .NET MAUI CarouselView (SfCarousel) control."
platform: maui
control: Carousel
documentation: ug
---

# Animation in .NET MAUI CarouselView (SfCarousel)

The [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_Duration) property in the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control specifies the time taken for an item to transition to the selected item position in Default mode. The duration is specified in milliseconds, with a default value of 600 ms.

## Example

Here's how you can set the animation duration for the SfCarousel:

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     Duration="1000"/>

{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel();
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
carousel.ItemTemplate = itemTemplate;
carousel.Duration = 1000;

{% endhighlight %}

{% endtabs %}


