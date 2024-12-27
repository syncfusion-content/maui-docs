---
layout : post
title: UIVirtualization in .NET MAUI Carousel View control | Syncfusion
description: Learn here all about UIVirtualization support in Syncfusion .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# UIVirtualization in .NET MAUI Carousel View (SfCarousel)

In the UI virtualization concept, only the number of items that can be adaptable to the viewport of our device are arranged. Even, if numerous items have been added to the collection, it only loads the viewport adaptable count of the carousel items. Items are added at the right of the view when swiping the countable items in the forward direction. At the same time, the same number of items are removed at the left of the view to maintain the same viewport items count. Similarly, items are added at the left of the view when swiping backward to maintain the same viewport items count. At the same time, the same number of items are removed at the right of the view. Using this mechanism, the virtualization concept is achieved in the carousel control. 

The following property has been used in UIVirtualization support:

* `EnableVirtualization`  

## EnableVirtualization

The UI virtualization concept is implemented by enabling the [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization) property in SfCarousel Linear mode.

N> The default value of the [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization) property is false.

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
this.Content = carousel;

{% endhighlight %}

{% endtabs %}

![UIVirtualization](images/UIVirtualization.png)

Find the complete UIVirtualization sample from this [link](https://github.com/SyncfusionExamples/maui-carousel-samples/tree/master/UIVirtualization/VirtualizationSample).