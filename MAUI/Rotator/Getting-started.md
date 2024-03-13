---
layout: post
title: Getting Started with .NET MAUI Rotator control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Rotator (SfRotator) control, its elements and more.
platform: maui 
control: Rotator
documentation: ug
---

# Getting Started with .NET MAUI Rotator (SfRotator)

This section explains how to add the Rotator control and bind data to it. This section covers only the basic features needed to get started with the Syncfusion `.NET MAUI Rotator` control.

## Adding a .NET MAUI Rotator reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add `.NET MAUI Rotator` to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Rotator`, and install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight c# hl_lines="6 17" %}

    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;
    using Microsoft.Maui.Controls.Compatibility;
    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Controls.Xaml;
    using Syncfusion.Maui.Core.Hosting;

    namespace Rotator
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

## Adding the .NET MAUI Rotator control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

	xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Rotator;

{% endhighlight %}
{% endtabs %}


## Create a Simple SfRotator 

The `SfRotator` control is configured entirely in C# code or by using XAML markup.

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
                xmlns:local="clr-namespace:Rotator"
                x:Class="GettingStarted.Rotator">
    <ContentPage.Content>
    <syncfusion:SfRotator x:Name="rotator" />	
    </ContentPage.Content>
    </ContentPage>
	
	
{% endhighlight %}

{% highlight C# %}		

    using Syncfusion.Maui.Rotator;

    namespace GettingStarted
    {
    public partial class RotatorControlPage : ContentPage
        {
            public RotatorControlPage()
            {
                InitializeComponent();
                SfRotator rotator = new SfRotator();
                this.Content = rotator;
            }
        }
    }
        
{% endhighlight %}

{% endtabs %}


## Add Rotator Items

We can populate the rotator’s items by using any one of the following ways,

* Through `SfRotatorItem`

* Through `ItemTemplate`

The below is an simple example for adding rotator items using SfRotatorItem, for more details on populating data click [Here](https://help.syncfusion.com/maui/rotator/Populating-data)

The following code example illustrates to add list of Images in Rotator ,

{% tabs %}

{% highlight C# %}

    using Syncfusion.Maui.Core.Rotator;

    namespace Rotator
    {
        public partial class Rotator : ContentPage
        {
            SfRotator rotator = new SfRotator();
            StackLayout stackLayout = new StackLayout();
            public Rotator()
            {
                InitializeComponent ();
                stackLayout.HeightRequest = 300;
                List<SfRotatorItem> collectionOfItems = new List<SfRotatorItem>();
                collectionOfItems.Add(new SfRotatorItem() { Image = "image1.png" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image2.png" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image3.png" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image4.png" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image5.png" });
                rotator.ItemsSource = collectionOfItems;
                stackLayout.Children.Add(rotator);
                this.Content = stackLayout;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

![Rotator Items](images/RotatorItems.png)
 
## Setting Navigation Mode

`SfRotator` provides option to display the navigating items either in Thumbnail or Dots mode. The navigation mode for navigating the items can be decided using `NavigationStripMode` property.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
                xmlns:local="clr-namespace:Rotator"
                x:Class="Rotator.Rotator">
        <ContentPage.BindingContext>
            <local:RotatorViewModel/>
        </ContentPage.BindingContext>
        <ContentPage.Content>
            <syncfusion:SfRotator x:Name="rotator" 
                            NavigationDelay="2000" 
                            ItemsSource="{Binding ImageCollection}" 
                            SelectedIndex="2"
                            NavigationDirection="Horizontal"
                            NavigationStripMode="Thumbnail" 
                            BackgroundColor="#ececec"
                            WidthRequest="550"
                            HeightRequest="550">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image  Source="{Binding Image}"/>
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}

{% highlight C# %}	

    using Syncfusion.Maui.Core.Rotator;
    using Syncfusion.Maui.Rotator;

    namespace Rotator
    {
        public partial class Rotator : ContentPage
        {
            public Rotator()
            {
                InitializeComponent ();
                SfRotator rotator = new SfRotator();
                var ImageCollection = new List<RotatorModel> {
                new RotatorModel ("image1.png"),
                new RotatorModel ("image2.png"),
                new RotatorModel ("image3.png"),
                new RotatorModel ("image4.png"),
                new RotatorModel ("image5.png")
                };
                var itemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid();
                    var nameLabel = new Image();
                    nameLabel.SetBinding(Image.SourceProperty, "Image");
                    grid.Children.Add(nameLabel);
                    return grid;
                });
                rotator.ItemTemplate = itemTemplate;
                rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
                rotator.ItemsSource = ImageCollection;
                this.Content = rotator;
            }
        }
        public class RotatorModel
        {
            public RotatorModel(string imageString)
            {
                Image = imageString;
            }
            private String _image;
            public String Image
            {
                get { return _image; }
                set { _image = value; }
            }
        }
    }

{% endhighlight %}

{% endtabs %}

![NavigationStripMode](images/NavigationStripMode.png)

## Customizing Position

The placement position of navigation strip items such as `Thumbnail` or `Dots` can be customized in `SfRotator`. This can be specified using `NavigationStripPosition` property.   

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
                xmlns:local="clr-namespace:Rotator"
                x:Class="Rotator.Rotator">
        <ContentPage.BindingContext>
            <local:RotatorViewModel/>
        </ContentPage.BindingContext>
        <ContentPage.Content>
            <syncfusion:SfRotator x:Name="rotator" 
                            NavigationDelay="2000" 
                            ItemsSource="{Binding ImageCollection}" 
                            SelectedIndex="2"
                            NavigationDirection="Horizontal"
                            NavigationStripMode="Dots" 
                            BackgroundColor="#ececec"
                            NavigationStripPosition="Top"
                            WidthRequest="550"
                            HeightRequest="550">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image  Source="{Binding Image}"/>
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </ContentPage.Content>
    </ContentPage>	

{% endhighlight %}

{% highlight C# %}	

    using Syncfusion.Maui.Core.Rotator;
    using Syncfusion.Maui.Rotator;

    namespace Rotator
    {
        public partial class Rotator : ContentPage
        {
            public Rotator()
            {
                InitializeComponent ();
                SfRotator rotator = new SfRotator();
                var ImageCollection = new List<RotatorModel> {
                new RotatorModel ("image1.png"),
                new RotatorModel ("image2.png"),
                new RotatorModel ("image3.png"),
                new RotatorModel ("image4.png"),
                new RotatorModel ("image5.png")
                };
                var itemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid();
                    var nameLabel = new Image();
                    nameLabel.SetBinding(Image.SourceProperty, "Image");
                    grid.Children.Add(nameLabel);
                    return grid;
                });
                rotator.ItemTemplate = itemTemplate;
                rotator.NavigationStripMode = NavigationStripMode.Dots;
                rotator.NavigationStripPosition = NavigationStripPosition.Top;
                rotator.WidthRequest=550;
                rotator.HeightRequest=550;
                rotator.ItemsSource = ImageCollection;
                this.Content = rotator;
            }
        }
        public class RotatorModel
        {
            public RotatorModel(string imageString)
            {
                Image = imageString;
            }
            private String _image;
            public String Image
            {
                get { return _image; }
                set { _image = value; }
            }
        }
    }
	
{% endhighlight %}

{% endtabs %}

![NavigationStripPosition](images/NavigationStripPosition.png)

You can find the complete getting started sample from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-Rotator)