---
layout : post
title: Linear Arrangement in .NET MAUI Carousel View control | Syncfusion
description: Learn here all about Linear Arrangement support in Syncfusion .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Linear Arrangement in .NET MAUI Carousel View (SfCarousel)

The Carousel items can be populated in the view in a stacked linear layout by setting the [ViewMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ViewMode) property to [Linear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Linear). The present option is [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Default).

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"  
                     ItemsSource="{Binding ImageCollection}" 
                     ViewMode="Linear"/>
	
{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel();
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
carousel.ViewMode = ViewMode.Linear;

{% endhighlight %}

{% endtabs %}

![Linear mode](images/linearview.png)



