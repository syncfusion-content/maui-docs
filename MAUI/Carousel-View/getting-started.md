---
layout: post
title: Getting Started with .NET MAUI Carousel View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Carousel View (SfCarousel) control, its elements and more.
platform: maui
control: Carousel
documentation: ug
---

# Getting Started with .NET MAUI Carousel (SfCarousel)

This section explains how to add the Carousel control and bind data to it. This section covers only the basic features needed to get started with the Syncfusion [.NET MAUI Carousel](https://www.syncfusion.com/maui-controls/maui-carousel) control.

## Adding a .NET MAUI Carousel reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [.NET MAUI Carousel](https://www.syncfusion.com/maui-controls/maui-carousel) to your project, open the NuGet package manager in Visual Studio, search for [`Syncfusion.Maui.Carousel`](https://www.nuget.org/packages/Syncfusion.Maui.Carousel), and install it.

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

Now, add the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control with a required optimal name using the included namespace.

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

* Through [SfCarouselItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html)

* Through [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemTemplate)

The below is an simple example for adding Carousel items using SfCarouselItem, for more details on populating data click [Here](https://help.syncfusion.com/maui/carousel-view/populating-data)

The following code example illustrates how to create a list of Images in Carousel,

{% highlight C# %}

public class CarouselViewModel
{
    public ObservableCollection<SfCarouselItem> CarouselItems;
    public CarouselViewModel()
    {
        CarouselItems = new ObservableCollection<SfCarouselItem>();
        CarouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person1.png" });
        CarouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person2.png" });
        CarouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person3.png" });
        CarouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person4.png" });
        CarouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person5.png" });
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
                         ItemsSource="{Binding CarouselItems}"/>
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
            carousel.SetBinding(SfCarousel.ItemsSourceProperty, "CarouselItems");

            this.Content = carousel;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Setting the height and width of the carousel item

[ItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemHeight) and [ItemWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemWidth) properties are used to change the height and width of carouselItem in carousel panel.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding CarouselItems}"
                     ItemHeight="170"
                     ItemWidth="270"/>

{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel()
{
    ItemWidth = 170,
    ItemHeight = 250
};

carousel.SetBinding(SfCarousel.ItemsSourceProperty, "CarouselItems");

{% endhighlight %}

{% endtabs %}

## Set Desire Item to be Selected

We can bring particular item to the center of the screen using [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedIndex) property in [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding CarouselItems}"
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

carousel.SetBinding(SfCarousel.ItemsSourceProperty, "CarouselItems");

{% endhighlight %}

{% endtabs %}

N> The [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedIndex) property will be 0 by default.

![OverView image for Carousel](images/gettingstarted.png)

N> You can find the complete getting started sample from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfCarousel)

N> You can also explore our [.NET MAUI Carousel Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Carousel) that shows you how to render and configure the Carousel in .NET MAUI.