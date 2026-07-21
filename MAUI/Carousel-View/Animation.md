---
layout : post
title: Animation in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Animation support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Animation in .NET MAUI Carousel View (SfCarousel)

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Duration

The [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_Duration) property of the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control specifies the time, in milliseconds, taken to move an item to the selected position when the carousel is in the Default mode. The default value is 600 ms. You can customize the animation duration by setting the `Duration` property to the desired value in milliseconds. Setting the value close to 0 effectively disables the animation.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemHeight="170"
                     ItemWidth="270"
                     SelectedIndex="2"
                     Duration="1000">
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
    SelectedIndex = 2,
    Duration = 1000,
    BindingContext = carouselViewModel,
    ItemsSource = new CarouselViewModel().ImageCollection,
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

## See Also

- [Populating Data in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/populating-data)
- [LoadMore in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/loadmore)