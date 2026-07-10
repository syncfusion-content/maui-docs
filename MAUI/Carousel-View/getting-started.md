---
layout: post
title: Getting Started with .NET MAUI Carousel View control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Carousel View (SfCarousel) control, its elements and more.
platform: maui
control: Carousel
documentation: ug
---

# Getting Started with .NET MAUI Carousel

This section guides you through setting up and configuring a [Carousel](https://www.syncfusion.com/maui-controls/maui-carousel) in your .NET MAUI application. Follow the steps below to add a basic Carousel to your project.

To quickly get started with the .NET MAUI Carousel, watch this video.

{% youtube "https://www.youtube.com/watch?v=pFEqZKlLsi4" %}

{% tabcontents %}
{% tabcontent Visual Studio  %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Carousel NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Carousel](https://www.nuget.org/packages/Syncfusion.Maui.Carousel) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Carousel NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Carousel` to install the Syncfusion<sup>®</sup> .NET MAUI Carousel package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select .NET (C#) and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Carousel NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Carousel](https://www.nuget.org/packages/Syncfusion.Maui.Carousel) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}

{% endtabcontents %}

## Step 3: Register Syncfusion handler
 
Make sure to add the namespace.
 
{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.
 
{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Define Model and View Model

The below is a simple example for adding Carousel items through Model, for more details on populating data click [Here](https://help.syncfusion.com/maui/carousel-view/populating-data)

{% tabs %}
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
{% endtabs %}

N> The images used in the above view model should be added in the Resources folder of the Application.

## Step 5: Import the Carousel View namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}
xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Carousel;
{% endhighlight %}
{% endtabs %}

## Step 6: Add the Carousel View component

Create an instance for the Carousel View control. Set the `CarouselViewModel` instance as the `BindingContext` of your page to bind `CarouselViewModel` properties.

[ItemHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemHeight) and [ItemWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemWidth) properties are used to change the height and width of carouselItem in carousel panel.

We can bring particular item to the center of the screen using [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedIndex) property in [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control.

{% tabs %}

{% highlight xaml %}
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Image Source="{Binding Image}" 
                   Aspect="AspectFit"/>
        </DataTemplate>
    </ResourceDictionary>
<ContentPage.Resources>

<carousel:SfCarousel x:Name="carousel"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ItemsSource="{Binding ImageCollection}"
                     ItemHeight="170"
                     ItemWidth="270"
                     SelectedIndex="4">
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
</carousel:SfCarousel>
{% endhighlight %}

{% highlight C# %}
CarouselViewModel carouselViewModel = new CarouselViewModel();

SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    SelectedIndex = 4
};

var itemTemplate = new DataTemplate(() =>
{
    var grid = new Grid();
    var nameLabel = new Image();
    nameLabel.SetBinding(Image.SourceProperty, "Image");
    grid.Children.Add(nameLabel);
    return grid;
});

carousel.BindingContext = carouselViewModel;
carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

### Set Desire Item to be Selected

We can bring particular item to the center of the screen using [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedIndex) property in [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemTemplate="{StaticResource itemTemplate}" 
                     ItemsSource="{Binding ImageCollection}"
                     SelectedIndex="4"/>
	
{% endhighlight %}

{% highlight C# %}

SfCarousel carousel = new SfCarousel()
{
    SelectedIndex = 4
};

carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

N> The [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedIndex) property will be 0 by default.

The following screenshot illustrates the result of the above code.

![OverView image for Carousel](images/gettingstarted.png)

You can download the Carousel View Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfCarousel).

N> You can also explore our [.NET MAUI Carousel Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Carousel) that shows you how to render and configure the Carousel in .NET MAUI.