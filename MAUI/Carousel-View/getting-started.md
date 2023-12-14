---
layout: post
title: Getting Started with .NET MAUI Carousel View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Carousel View (SfCarousel) control, its elements and more.
platform: maui
control: Carousel
documentation: ug
---

# Getting Started with .NET MAUI Carousel (SfCarousel)

This section provides a quick overview of how to get started with the `.NET Maui Carousel` (SfCarousel) for Maui.

## Creating an application using the .NET MAUI Carousel

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfCarousel to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Carousel and then install it.
 3. Import the control namespace `Syncfusion.Maui.Carousel` in XAML or C# code.
 4. Initialize the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.html) control.
 
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel">

    <syncfusion:SfCarousel />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Carousel;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfCarousel carousel = new SfCarousel();
        this.Content = carousel;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="4 20" %}
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
}
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
                         ItemsSource="carouselItems"
                         ItemHeight="170"
                         ItemWidth="270"/>
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
                ItemWidth = 170,
                ItemHeight = 250
            };

            carousel.BindingContext = carouselViewModel;
            carousel.ItemsSource = carouselViewModel.ImageCollection;

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

carousel.ItemsSource = carouselViewModel.ImageCollection;

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
                     SelectedIndex="2"/>
	
{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel()
{
    ItemWidth = 170,
    ItemHeight = 250,
    SelectedIndex = 2
};

carousel.ItemsSource = carouselViewModel.ImageCollection;

{% endhighlight %}

{% endtabs %}

N> The `SelectedIndex` property will be 0 by default.

![OverView image for Carousel](images/gettingstarted.png)

You can find the complete getting started sample from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfCarousel)