---
layout : post
title: Populating Data in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Populating Data support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Populating Data in .NET MAUI Carousel View (SfCarousel)

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Overview

The [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control supports binding to different item sources such as `IList` and `ObservableCollection`. Use `ObservableCollection<T>` when the carousel items need to reflect live changes (add, remove, or update).

## Choosing an Approach

[SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) supports two ways to populate items:

| Approach | When to use | Key API |
| --- | --- | --- |
| Through Binding | You have a view model and want data binding with a reusable `DataTemplate` for all items. | `ItemsSource`, `ItemTemplate` |
| Through Carousel Item | Each item needs a different view, or you want to display only an image without writing a template. | `SfCarouselItem.ImageName`, `SfCarouselItem.ItemContent` |

## Through Binding

Populate the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) by setting `ItemsSource` to a collection and applying a custom `ItemTemplate`. This approach is recommended when the same view should be rendered for every item.

### Create the Model

The following model class represents a single carousel item.

{% highlight C# %}

namespace CarouselSample
{
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
}

{% endhighlight %}

### Create the ViewModel

The following view model exposes the image collection that will be bound to the carousel.

{% highlight C# %}

using System.Collections.Generic;

namespace CarouselSample
{
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
}

{% endhighlight %}

> **Tip:** Replace the `List<CarouselModel>` with `ObservableCollection<CarouselModel>` if the items need to be added or removed at runtime.

### Binding the Data with a Custom Template

The [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemTemplate) defines a custom view that is applied to every item. Item data is bound through the `BindingContext` of the templated view.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
             xmlns:local="clr-namespace:CarouselSample"
             x:Class="CarouselSample.MainPage">
    <ContentPage.BindingContext>
        <local:CarouselViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="itemTemplate">
                <Image Source="{Binding Image}" 
                       Aspect="AspectFit"/>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.Content>
        <carousel:SfCarousel x:Name="carousel"  
                             ItemTemplate="{StaticResource itemTemplate}" 
                             ItemsSource="{Binding ImageCollection}"
                             ItemHeight="170"
                             ItemWidth="270"
                             ItemSpacing="2" 
                             HeightRequest="400" 
                             WidthRequest="800" />
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}


using Syncfusion.Maui.Carousel;
using System.Collections.ObjectModel;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
            this.Content = carousel;
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Through Carousel Item

The [SfCarouselItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html) class represents a single carousel item. Use its `ItemContent` or `ImageName` property to provide a view for each item.

The following table summarizes the key `SfCarouselItem` properties:

| Property | Type | Description |
| --- | --- | --- |
| [ItemContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html#Syncfusion_Maui_Carousel_SfCarouselItem_ItemContent) | `View` | Custom view rendered for the carousel item. |
| [ImageName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html#Syncfusion_Maui_Carousel_SfCarouselItem_ImageName) | `string` | Name of the image (resolved from `Resources/Images/`) displayed as the item. |

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
                    <Image Source="carousel_person1.png" Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person2.png" Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person3.png" Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person4.png" Aspect="Fill"/>
                </carousel:SfCarouselItem.ItemContent>
            </carousel:SfCarouselItem>
            <carousel:SfCarouselItem>
                <carousel:SfCarouselItem.ItemContent>
                    <Image Source="carousel_person5.png" Aspect="Fill"/>
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

Use the [ImageName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html#Syncfusion_Maui_Carousel_SfCarouselItem_ImageName) property to display image data without defining a custom view. The image is loaded from the `Resources/Images/` folder using the **MauiImage** build action, and the default aspect is `Aspect.AspectFit`.

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

## Troubleshooting

* If the carousel is empty, verify that `ItemsSource` is set after `BindingContext`, and that the bound property name (`ImageCollection`) matches the view model exactly (case-sensitive).
* If images do not render, confirm that the image files are added to `Resources/Images/` with the **MauiImage** build action and that the file names referenced in code or XAML match the actual file names (case-sensitive on Android and Windows).
* If changes to the items collection are not reflected in the UI, replace `List<T>` with `ObservableCollection<T>` so the carousel is notified of additions and removals.

## See also

* [Getting Started with .NET MAUI Carousel](https://help.syncfusion.com/maui/carousel-view/getting-started)
* [Load More in .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/loadmore)
* [Overview of .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/overview)