---
layout : post
title: Animation in .NET MAUI Carousel View control | Syncfusion
description: Learn here all about Animation support in Syncfusion .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Animation in .NET MAUI Carousel View (SfCarousel)

The [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_Duration) property of the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control specifies the time taken to move an item to the selected item position in the Default mode. The duration is specified in milliseconds. The default value is 600 ms.
The `Duration` property of the `SfCarousel` control specifies the time taken to move an item to the selected item position in the Default mode. The duration is specified in milliseconds. The default value is 600 ms.

{% tabs %}

{% highlight xaml %}
<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     Duration="1000"/>
{% endhighlight %}
{% highlight C# %}
SfCarousel carousel = new SfCarousel();
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
carousel.Duration = 1000;
{% endhighlight %}
{% endtabs %}
