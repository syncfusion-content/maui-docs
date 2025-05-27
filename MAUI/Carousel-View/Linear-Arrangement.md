---
layout: post
title: "Linear Arrangement in .NET MAUI Carousel View Control | Syncfusion®"
description: "Learn about Linear Arrangement support in the Syncfusion® .NET MAUI Carousel View (SfCarousel) control."
platform: maui
control: Carousel
documentation: ug
---

# Linear Arrangement in .NET MAUI Carousel View (SfCarousel)

Carousel items can be arranged in a linear stacked layout by setting the [ViewMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ViewMode) property to [Linear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Linear). The default option is [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Default).

## Example

Here is how you can configure the Carousel in Linear ViewMode:

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"  
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ViewMode="Linear"/>
	
{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel();
carousel.ViewMode = ViewMode.Linear;
carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");


{% endhighlight %}

{% endtabs %}

![Linear mode](images/linearview.png)



