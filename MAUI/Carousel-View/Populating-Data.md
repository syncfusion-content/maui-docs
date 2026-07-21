---
layout : post
title: Populating Data in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Populating Data support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Populating Data in .NET MAUI Carousel View (SfCarousel)

The [.NET MAUI Carousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control supports binding to different item sources such as `IList` and `ObservableCollection`. Use `ObservableCollection<T>` when the carousel items need to reflect live changes (add, remove, or update).

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Choosing an Approach

`SfCarousel` supports two ways to populate items:

| Approach | When to use | Key API |
| --- | --- | --- |
| Through Binding | You have a view model and want data binding with a reusable `DataTemplate` for all items. | `ItemsSource`, `ItemTemplate` |
| Through Carousel Item | Each item needs a different view, or you want to display only an image without writing a template. | `SfCarouselItem.ImageName`, `SfCarouselItem.ItemContent` |

## Through Binding

Populate the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) by setting `ItemsSource` to a collection and applying a custom [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemTemplate). This approach is recommended when the same view should be rendered for every item.

### Create a Model with Data

`SfCarousel` items can be populated with a collection of image data. For example, a user may want to create a Carousel control, which will display a list of images.

{% highlight C# %}

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

{% endhighlight %}

### Create the ViewModel

The following view model exposes the image collection that will be bound to the Carousel.

{% highlight C# %}

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


### Binding the Data with a Custom Template

The [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemTemplate) defines a custom view that is applied to every item. Item data is bound through the `BindingContext` of the templated view.

{% tabs %}
{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"  
                     ItemsSource="{Binding ImageCollection}"
                     ItemHeight="170"
                     ItemWidth="270"
                     ItemSpacing="2" 
                     HeightRequest="400" 
                     WidthRequest="800">
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
    <carousel:SfCarousel.ItemTemplate>
        <DataTemplate >
            <Image Source="{Binding Image}" 
                   Aspect="AspectFit"/>
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
    ItemSpacing = 2,
    HeightRequest = 400,
    WidthRequest = 800
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
{% endtabs %}

## Through Carousel Item

The [SfCarouselItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html) class represents a single carousel item. Use its `ItemContent` or `ImageName` property to provide a view for each item.

### Using ItemContent

Use the [ItemContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html#Syncfusion_Maui_Carousel_SfCarouselItem_ItemContent) property to assign a different view to each carousel item.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel" 
                     ItemHeight="170"
                     ItemWidth="270"
                     ItemSpacing="2"
                     HeightRequest="400"
                     WidthRequest="800">
    <carousel:SfCarousel.ItemsSource>
        <x:Array Type="{x:Type carousel:SfCarouselItem}">
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person1.png" 
                           Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person2.png" 
                           Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person3.png" 
                           Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person4.png" 
                           Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person5.png" 
                           Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
        </x:Array>
    </carousel:SfCarousel.ItemsSource>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight C# %}


SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    ItemSpacing = 2,
    HeightRequest = 400,
    WidthRequest = 800
};

ObservableCollection<SfCarouselItem> carouselItems = new ObservableCollection<SfCarouselItem>();

carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person1.png", Aspect = Aspect.Fill } });
carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person2.png", Aspect = Aspect.Fill } });
carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person3.png", Aspect = Aspect.Fill } });
carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person4.png", Aspect = Aspect.Fill } });
carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person5.png", Aspect = Aspect.Fill } });

carousel.ItemsSource = carouselItems;

{% endhighlight %}
{% endtabs %}

### Using ImageName

Use the [ImageName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html#Syncfusion_Maui_Carousel_SfCarouselItem_ImageName) property to display image data without defining a custom view. The image is loaded from the `Resources/Images/` folder using the **MauiImage** build action.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel" 
                     ItemHeight="170"
                     ItemWidth="270"
                     ItemSpacing="2"
                     HeightRequest="400"
                     WidthRequest="800">
    <carousel:SfCarousel.ItemsSource>
        <x:Array Type="{x:Type carousel:SfCarouselItem}">
            <carousel:SfCarouselItem ImageName="carousel_person1.png"/>
            <carousel:SfCarouselItem ImageName="carousel_person2.png"/>
            <carousel:SfCarouselItem ImageName="carousel_person3.png"/>
            <carousel:SfCarouselItem ImageName="carousel_person4.png"/>
            <carousel:SfCarouselItem ImageName="carousel_person5.png"/>
        </x:Array>
    </carousel:SfCarousel.ItemsSource>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    ItemSpacing = 2,
    HeightRequest = 400,
    WidthRequest = 800
};

ObservableCollection<SfCarouselItem> carouselItems = new ObservableCollection<SfCarouselItem>();
carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person1.png" });
carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person2.png" });
carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person3.png" });
carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person4.png" });
carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person5.png" });

carousel.ItemsSource = carouselItems;
           
{% endhighlight %}

{% endtabs %}

You can also create and customize each `SfCarouselItem` individually when a different view is required for each carousel item.

## See also

- [Load More in .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/loadmore)
- [Transformation in .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/transformation)
- [UI Virtualization in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/uivirtualization)

