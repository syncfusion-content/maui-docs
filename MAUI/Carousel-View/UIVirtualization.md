---
layout : post
title: UIVirtualization in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about UIVirtualization support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# UIVirtualization in .NET MAUI Carousel View (SfCarousel)

UI virtualization in the `SfCarousel` control ensures that only the items visible in the viewport are rendered, significantly improving performance when working with large data sets. As users swipe through the carousel, new items are dynamically added to the visible area while off-screen items are removed, maintaining a consistent number of rendered items.

The following property has been used in UIVirtualization support:

* `EnableVirtualization`  

## EnableVirtualization

The UI virtualization concept is implemented by enabling the [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization) property in SfCarousel, supporting both Default and Linear view modes.

N> The default value of the [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization) property is false.

### Default Mode Example

{% tabs %}

{% highlight xaml %}

<!-- Default View Mode -->
<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ItemHeight="200"
                     ItemWidth="200"
                     ItemSpacing="2"
                     ViewMode="Default"
                     EnableVirtualization="true">
</carousel:SfCarousel>

{% endhighlight %}

{% highlight c# %}

// Default Mode Configuration
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 200,
    ItemWidth = 200,
    ItemSpacing = 2,
    EnableVirtualization = true,
    ViewMode = ViewMode.Default
};

carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

### Linear Mode Example

{% tabs %}

{% highlight xaml %}

<!-- Linear View Mode -->
<carousel:SfCarousel x:Name="linearCarousel"
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

// Linear Mode Configuration
SfCarousel linearCarousel = new SfCarousel()
{
    ItemHeight = 200,
    ItemWidth = 200,
    ItemSpacing = 2,
    EnableVirtualization = true,
    ViewMode = ViewMode.Linear
};

linearCarousel.ItemTemplate = itemTemplate;
linearCarousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

![UIVirtualization](images/UIVirtualization.png)

Find the complete UIVirtualization sample from this [link](https://github.com/SyncfusionExamples/maui-carousel-samples/tree/master/UIVirtualization/VirtualizationSample).