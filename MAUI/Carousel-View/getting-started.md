---
layout: post
title: Getting Started with .NET MAUI Carousel View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Carousel View (SfCarousel) control, its elements and more.
platform: maui
control: Carousel
documentation: ug
---

# Getting Started with .NET MAUI Carousel

This section provides a quick overview of how to get started with the `.NET MAUI Carousel` control.

## Creating an application with .NET MAUI Carousel

This section explains the steps required to work with the `SfCarousel` control for .NET MAUI.

## Adding a .NET MAUI Carousel reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add `.NET MAUI Carousel` to your project, open the NuGet package manager in Visual Studio, search for [`Syncfusion.Maui.Carousel`](https://www.nuget.org/packages/Syncfusion.Maui.Carousel), and install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace CarouselSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }      
    }
}   

{% endhighlight %} 

## Adding the .NET MAUI Carousel control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

	xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Carousel;

{% endhighlight %}
{% endtabs %}

## Initialize Carousel

Now, add the `SfCarousel` control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfCarousel />
	
{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel();
this.Content = carousel;

{% endhighlight %}

{% endtabs %}

## Add Carousel Items

We can populate the carousel's items by using any one of the following ways,

* Through `SfCarouselItem`

* Through `ItemTemplate`

The below is an simple example for adding Carousel items using SfCarouselItem, for more details on Populating data click [Here](https://help.syncfusion.com/maui/carousel-view/populating-data)

The following code example illustrates how to create a list of Images in Carousel,

{% highlight C# %}

public class CarouselViewModel
{
    public ObservableCollection<SfCarouselItem> carouselItems;
    public CarouselViewModel()
    {
        carouselItems = new ObservableCollection<SfCarouselItem>();
        carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person1.png" });
        carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person2.png" });
        carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person3.png" });
        carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person4.png" });
        carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person5.png" });
    }
}

{% endhighlight %}

The following code example illustrates how to add the collection in Carousel,

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
             xmlns:local="clr-namespace:CarouselSample"
             x:Class="CarouselSample.MainPage">
             
    <ContentPage.BindingContext>
        <local:CarouselViewModel/>
    </ContentPage.BindingContext>

    <carousel:SfCarousel x:Name="carousel"
                         ItemsSource="carouselItems"/>
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
            SfCarousel carousel = new SfCarousel();

            carousel.BindingContext = carouselViewModel;
            carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

            this.Content = carousel;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Setting the height and width of the carousel item

`ItemHeight` and `ItemWidth` properties are used to change the height and width of carouselItem in carousel panel.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="carouselItems"
                     ItemHeight="170"
                     ItemWidth="270"/>

{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel()
{
    ItemWidth = 170,
    ItemHeight = 250
};

carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

## Set Desire Item to be Selected

We can bring particular item to the center of the screen using `SelectedIndex` property in `SfCarousel` control.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="carouselItems"
                     ItemHeight="170"
                     ItemWidth="270"
                     SelectedIndex="4"/>
	
{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel()
{
    ItemWidth = 170,
    ItemHeight = 250,
    SelectedIndex = 4,
};

carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

N> The `SelectedIndex` property will be 0 by default.

![OverView image for Carousel](images/gettingstarted.png)

You can find the complete getting started sample from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfCarousel)