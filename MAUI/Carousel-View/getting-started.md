---
layout: post
title: Getting Started with .NET MAUI Carousel View control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Carousel View (SfCarousel) control, its elements and more.
platform: maui
control: Carousel
documentation: ug
---

# Getting Started with .NET MAUI Carousel

This section guides you through setting up and configuring a [Carousel](https://www.syncfusion.com/maui-controls/maui-carousel) in your .NET MAUI application. Follow the steps below to add a basic Carousel to your project.

To quickly get started with the .NET MAUI Carousel, watch this video.

{% youtube "https://www.youtube.com/watch?v=pFEqZKlLsi4" %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio Code. For Visual Studio Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

### Visual Studio

1.  Go to **File > New > Project** and choose the **.NET MAUI App** template.
2.  Name the project and choose a location. Then, click **Next**.
3.  Select the .NET framework version and click **Create**.

### Visual Studio Code

1.  Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2.  Choose the **.NET MAUI App** template.
3.  Select the project location, type the project name and press Enter.
4.  Then choose **Create project**

## Step 2: Install the Syncfusion MAUI Inputs NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Carousel](https://www.nuget.org/packages/Syncfusion.Maui.Carousel) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

 [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

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

## Step 4: Add a Basic Carousel

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

Step 3: Add the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfCarousel />
	
{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel();
this.Content = carousel;

{% endhighlight %}

{% endtabs %}

## Step 5: Add Carousel Items

We can populate the carousel's items by using any one of the following ways,

* Through [SfCarouselItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarouselItem.html)

* Through Model

The below is a simple example for adding Carousel items through Model, for more details on populating data click [Here](https://help.syncfusion.com/maui/carousel-view/populating-data)

The following code example illustrates how to create a list of Images in Carousel,

{% highlight C# %}

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

N> The images used in the above view model should be added in the Resources folder of the Application.

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
            this.BindingContext = carouselViewModel;

            SfCarousel carousel = new SfCarousel();
            carousel.SetBinding(SfCarousel.ItemsSourceProperty, "CarouselItems");

            this.Content = carousel;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Step 6: Setting the height and width of the carousel item

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

## Step 7: Set Desire Item to be Selected

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

N> You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfCarousel).

N> You can also explore our [.NET MAUI Carousel Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Carousel) that shows you how to render and configure the Carousel in .NET MAUI.