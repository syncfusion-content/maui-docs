---
layout : post
title: Handling SelectionChanged in Syncfusion® .NET MAUISfCarousel
description: Learn how to perform an operation when the selected item changes in SfCarousel control for .NET MAUI.
platform : maui
control : Carousel
documentation : ug
---

# How to perform an operation when the selected carousel item changes?

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Overview

We can perform an operation when the selected carousel item changes by handling the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectionChanged) event. The `SelectionChanged` event provides the previously selected item through `e.OldItem` and the currently selected item through `e.NewItem`.

## XAML

The following XAML sample binds `SfCarousel` to an `ImageCollection` and handles the `SelectionChanged` event. Make sure to declare the `xmlns:carousel` namespace and define the `itemTemplate` resource in the page resources.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Image Source="{Binding Image}"
                    Aspect="AspectFit"/>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>
<carousel:SfCarousel x:Name="carousel"
                        ItemTemplate="{StaticResource itemTemplate}"
                        ItemsSource="{Binding ImageCollection}"
                        ItemHeight="170"
                        ItemWidth="270"
                        SelectionChanged="Carousel_SelectionChanged">
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
</carousel:SfCarousel>

{% endhighlight %}

{% endtabs %}

## Code-behind

The C# sample shows the equivalent code along with the `SelectionChanged` event handler. `DisplayAlert` is invoked on the page using `this.DisplayAlert`, so the handler must be placed inside the `ContentPage` code-behind.

{% tabs %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
carousel.SelectionChanged += Carousel_SelectionChanged;

// Triggered when the selection changes in the carousel.
private void Carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (sender is SfCarousel sfCarousel)
    {
        int count = sfCarousel.SelectedIndex + 1;
        this.DisplayAlert("SelectionChanged", "Carousel item " + count + " has been selected.", "OK");
    }
}
    
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


> **Note:** The images referenced in the view model must be added to the `Resources` folder of the application.

## Troubleshooting

- **Handler not found error:** Ensure `ConfigureSyncfusionCore()` is called in `MauiProgram.cs` with `using Syncfusion.Maui.Core.Hosting;`.
- **`SelectionChangedEventArgs` namespace error:** Use `Syncfusion.Maui.Carousel.SelectionChangedEventArgs` (not `Syncfusion.Maui.Core.Carousel`).
- **`DisplayAlert` not recognized:** The handler must reside in a `ContentPage` code-behind; invoke it as `this.DisplayAlert(...)`.

## See also

* [Getting Started with .NET MAUI Carousel](https://help.syncfusion.com/maui/carousel-view/getting-started)
- [Populating Items in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/populating-data)
* [UI Virtualization in .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/uivirtualization)
* [Overview of .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/overview)