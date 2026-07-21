---
layout : post
title: UIVirtualization in .NET MAUI Carousel View control | Syncfusion®
description: Learn how to enable UI virtualization in the Syncfusion® .NET MAUI Carousel View (SfCarousel) control to improve performance with large data sets.
platform : maui
control : Carousel
documentation : ug
---

# UIVirtualization in .NET MAUI Carousel View (SfCarousel)

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.


UI virtualization in the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control ensures that only the items visible in the viewport are rendered, significantly improving performance when working with large data sets. As users swipe through the carousel, new items are dynamically added to the visible area while off-screen items are removed, maintaining a consistent number of rendered items.

The following property is used to enable UI virtualization:

* [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization)

## Enable UI Virtualization

The UI virtualization concept is implemented by enabling the [EnableVirtualization](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization) property of `SfCarousel`. The property applies to both the [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Default) and [Linear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Linear) [ViewMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html) values. The default value of the `EnableVirtualization` property is `false`.

## Default Mode

{% tabs %}

{% highlight xaml %}

<!-- Default View Mode -->
<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemHeight="170"
                     ItemWidth="270"
                     ViewMode="Default"
                     EnableVirtualization="True">
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
    <carousel:SfCarousel.ItemTemplate>
        <DataTemplate >
            <Image Source="{Binding Image}" Aspect="AspectFit"/>
        </DataTemplate>
    </carousel:SfCarousel.ItemTemplate>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    EnableVirtualization = true,
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

## Linear Mode

{% tabs %}

{% highlight xaml %}
<!-- Linear View Mode -->
<carousel:SfCarousel x:Name="linearCarousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemHeight="170"
                     ItemWidth="270"
                     ItemSpacing="60"
                     ViewMode="Linear"
                     EnableVirtualization="True">
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
    <carousel:SfCarousel.ItemTemplate>
        <DataTemplate >
            <Image Source="{Binding Image}" Aspect="AspectFit"/>
        </DataTemplate>
    </carousel:SfCarousel.ItemTemplate>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    ItemSpacing = 60,
    EnableVirtualization = true,
    ViewMode = ViewMode.Linear,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};

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

![UIVirtualization](images/UIVirtualization.png)

Find the complete UIVirtualization sample from this [link](https://github.com/SyncfusionExamples/maui-carousel-samples/tree/master/UIVirtualization/VirtualizationSample).

## Behavior

When `EnableVirtualization` is set to `true`:

- `SfCarousel` realizes only the items currently inside (or near) the viewport.
- As the user swipes, items that move out of the viewport are recycled and replaced with upcoming items.
- Memory usage stays roughly constant regardless of the total number of items in `ItemsSource`.

When `EnableVirtualization` is `false` (the default), every item in the source collection is realized up front, which can increase memory usage and lengthen initial load time for large data sets.

## See Also

- [Getting Started with .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/getting-started)
- [Populating Items in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/populating-data)
