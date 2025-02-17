---
layout : post
title: Animation in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Animation support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Animation in .NET MAUI Carousel View (SfCarousel)

The [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_Duration) property of the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control specifies the time taken to move an item to the selected item position in the Default mode. The duration is specified in milliseconds. The default value is 600 ms.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ItemHeight="200"
                     ItemWidth="200"
                     ItemSpacing="2"
                     Duration="1000"/>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 200,
    ItemWidth = 200,
    ItemSpacing = 2,
    EnableVirtualization = true,
    ViewMode = ViewMode.Linear
};
var itemTemplate = new DataTemplate(() =>
{
    var grid = new Grid();
    var nameLabel = new Image();
    nameLabel.SetBinding(Image.SourceProperty, "Image");
    grid.Children.Add(nameLabel);
    return grid;
});
carousel.BindingContext = carouselViewModel;
carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
carousel.Duration = 1000;

{% endhighlight %}

{% endtabs %}

