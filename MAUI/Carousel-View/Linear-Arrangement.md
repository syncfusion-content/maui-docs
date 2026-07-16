---
layout : post
title: Linear Arrangement in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Linear Arrangement support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Linear Arrangement in .NET MAUI Carousel View (SfCarousel)

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Overview

Set [ViewMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ViewMode) to [Linear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Linear) to display the carousel items in a stacked linear layout. When not set, the default value is [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Default), which places a single item in the center of the view.

> **When to use:** Use the `Linear` view mode when you want multiple carousel items to be visible at once along a horizontal axis (similar to a stack of cards), rather than focusing on a single centered item.


## XAML

The following example shows how to configure `SfCarousel` in `Linear` view mode with a custom item template.

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
                    ItemHeight="170"
                    ItemWidth="270"
                    ItemTemplate="{StaticResource itemTemplate}"
                    ItemsSource="{Binding ImageCollection}"
                    ViewMode="Linear"/>

{% endhighlight %}
{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    ViewMode = ViewMode.Linear,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var grid = new Grid();
        var nameLabel = new Image();
        nameLabel.SetBinding(Image.SourceProperty, "Image");
        grid.Children.Add(nameLabel);
        return grid;
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


The following image shows the carousel items arranged in a stacked linear layout.

![Linear mode](images/linearview.png)

## See also

* [Getting Started with .NET MAUI Carousel](https://help.syncfusion.com/maui/carousel-view/getting-started)
- [Populating Items in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/populating-data)
* [UI Virtualization in .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/uivirtualization)
* [Overview of .NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/maui/carousel-view/overview)
