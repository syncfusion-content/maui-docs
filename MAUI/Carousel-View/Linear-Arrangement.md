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
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ItemHeight="200"
                     ItemWidth="200"
                     ItemSpacing="2"
                     ViewMode="Linear"/>
	
{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 200,
    ItemWidth = 200,
    ItemSpacing = 2,
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


{% endhighlight %}

{% endtabs %}

![Linear mode](images/linearview.png)



