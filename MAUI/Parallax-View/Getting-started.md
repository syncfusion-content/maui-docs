---
layout: post
title: Getting started with .NET MAUI Parallax View control | Syncfusion
description: Learn about getting started with Syncfusion® .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Getting Started with .NET MAUI Parallax View (SfParallaxView)

This section explains the steps required to configure the [`SfParallaxView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html) control and add basic elements to it using various APIs.

To get start quickly with our .NET MAUI Parallax View, you can check the below video.

{% youtube "https://youtu.be/ezzIDWYYrUc" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure that the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.8 or later).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI Parallax View Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.ParallaxView](https://www.nuget.org/packages/Syncfusion.Maui.ParallaxView/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

Syncfusion.Maui.Core Nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>®</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="2 13" %}

using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace ParallaxViewGettingStarted
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
{% endtabs %} 

## Step 4: Add .NET MAUI Parallax View

1. To initialize the control, import the `Synfusion.Maui.ParallaxView` namespace.
2. Initialize [SfParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html).

{% tabs %} 
{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:parallaxView="clr-namespace:Syncfusion.Maui.ParallaxView;assembly=Syncfusion.Maui.ParallaxView">
    <Grid>
        <parallaxView:SfParallaxView/>
    </Grid>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ParallaxView;
namespace ParallaxViewGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();  
            Grid grid = new Grid();         
            SfParallaxView parallaxView = new SfParallaxView(); 
            grid.Children.Add(parallaxView);
            this.Content = grid;
        }
    }   
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure that the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI Parallax View Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.ParallaxView` to install the Syncfusion<sup>®</sup> .NET MAUI ParallaxView NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

Syncfusion.Maui.Core Nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>®</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="2 13" %}

using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace ParallaxViewGettingStarted
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
{% endtabs %} 

## Step 4: Add .NET MAUI Parallax View

1. To initialize the control, import the `Synfusion.Maui.ParallaxView` namespace.
2. Initialize [SfParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html).

{% tabs %} 
{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:parallaxView="clr-namespace:Syncfusion.Maui.ParallaxView;assembly=Syncfusion.Maui.ParallaxView">
    <Grid>
        <parallaxView:SfParallaxView/>
    </Grid>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ParallaxView;
namespace ParallaxViewGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();  
            Grid grid = new Grid();         
            SfParallaxView parallaxView = new SfParallaxView(); 
            grid.Children.Add(parallaxView);
            this.Content = grid;
        }
    }   
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

### Add content to the parallax view

The [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Content) represents the background view of a parallax view. Set any kind of view to the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Content) property, such as Image and StackLayout.

The following code sample demonstrates how to set the content property to the parallax view.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:local="clr-namespace:ParallaxViewGettingStarted"
    xmlns:parallax="clr-namespace:Syncfusion.Maui.ParallaxView;assembly=Syncfusion.Maui.ParallaxView"
    x:Class="ParallaxViewGettingStarted.MainPage">
      
    <ContentPage.Content>
        <Grid>            
            <parallax:SfParallaxView x:Name="parallaxview">
                <parallax:SfParallaxView.Content>
                    <Image Source="{Binding Image}" BackgroundColor="Transparent" HorizontalOptions="Fill" VerticalOptions="Fill" Aspect="AspectFill" />
                </parallax:SfParallaxView.Content>
            </parallax:SfParallaxView>       
        </Grid>
    </ContentPage.Content>
	
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.ParallaxView;

namespace ParallaxViewGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ParallaxViewModel();
        }
    }

    public class ParallaxViewModel
    {
        public ImageSource Image { get; set; }

        public ParallaxViewModel()
        {
            Image = ImageSource.FromResource("ParallaxViewGettingStarted.parallax.jpg", typeof(MainPage).GetTypeInfo().Assembly);
        }
    }  
}  

{% endhighlight %}
{% endtabs %}

### Bind source to the parallax view

The [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) represents the foreground view of the parallax view. The value of the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) should be a scrollable content or the view which implements the [IParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface.

Currently, the [SfParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html) directly supports the following controls. Bind the control to the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) property.

    1. ScrollView
    2. Syncfusion® ListView

The following code sample demonstrates how to bind the Syncfusion® ListView to the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) property.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:local="clr-namespace:ParallaxViewGettingStarted"
    xmlns:parallax="clr-namespace:Syncfusion.Maui.ParallaxView;assembly=Syncfusion.Maui.ParallaxView"
    xmlns:list="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
    x:Class="ParallaxViewGettingStarted.MainPage">
      
    <ContentPage.Content>
        <Grid>
            <parallax:SfParallaxView Source="{x:Reference Name = listview}" x:Name="parallaxview" >
                <parallax:SfParallaxView.Content>
                    <Image BackgroundColor="Transparent" Source="{Binding Image}" HorizontalOptions="Fill" VerticalOptions="Fill" Aspect="AspectFill" />
                </parallax:SfParallaxView.Content>
            </parallax:SfParallaxView>
     
            <list:SfListView x:Name="listview" ItemsSource="{Binding Items}" BackgroundColor="Transparent" ItemSize="100">
                <list:SfListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <Grid>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="0.5*" />
                                    <ColumnDefinition Width="*" />
                                </Grid.ColumnDefinitions>
                                <Image BackgroundColor="Transparent" HeightRequest="90" HorizontalOptions="CenterAndExpand" 
                                       WidthRequest="90" Source="{Binding ItemImage}" Grid.Column="0" VerticalOptions="CenterAndExpand" Aspect="AspectFit" />
                                <StackLayout BackgroundColor="Transparent" Grid.Column="1" VerticalOptions="CenterAndExpand" 
                                             HorizontalOptions="FillAndExpand" Orientation="Vertical">
                                    <Label HorizontalOptions="FillAndExpand" TextColor="White" Text="{Binding Name}"/>
                                    <Label HorizontalOptions="FillAndExpand" Text="{Binding Author}" TextColor="White"/>
                                </StackLayout>
                            </Grid>
                        </ViewCell>
                    </DataTemplate>
                </list:SfListView.ItemTemplate>
            </list:SfListView>
        </Grid>
    </ContentPage.Content>
	
</ContentPage>

{% endhighlight %}

{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ParallaxViewModel();
    }
}

public class ParallaxViewModel
{
    public ImageSource Image { get; set; }
    public ObservableCollection<Contacts> Items { get; set; }

    public ParallaxViewModel()
    {
        Assembly assembly = typeof(ParallaxViewModel).GetTypeInfo().Assembly;
        Image = ImageSource.FromResource("ParallaxViewGettingStarted.parallax.jpg", assembly);
        Items = new ObservableCollection<Contacts>()
        {
            new Contacts() { Name = "Thriller", Author = "Michael Jackson" },
            new Contacts() { Name = "Like a Prayer", Author = "Madonna" },
            new Contacts() { Name = "When Doves Cry", Author = "Prince" },
            new Contacts() { Name = "I Wanna Dance", Author = "Whitney Houston" },
            new Contacts() { Name = "It’s Gonna Be Me", Author = "N Sync"},
            new Contacts() { Name = "Everybody", Author = "Backstreet Boys"},
            new Contacts() { Name = "Rolling in the Deep", Author = "Adele" },
            new Contacts() { Name = "Don’t Stop Believing", Author = "Journey" },
            new Contacts() { Name = "Billie Jean", Author = "Michael Jackson" },             
            new Contacts() { Name = "Firework", Author = "Katy Perry"},               
            new Contacts() { Name = "Thriller", Author = "Michael Jackson" },
            new Contacts() { Name = "Like a Prayer", Author = "Madonna" },
            new Contacts() { Name = "When Doves Cry", Author = "Prince" },
            new Contacts() { Name = "I Wanna Dance", Author = "Whitney Houston" },
            new Contacts() { Name = "It’s Gonna Be Me", Author = "N Sync" },
            new Contacts() { Name = "Everybody", Author = "Backstreet Boys" },
            new Contacts() { Name = "Rolling in the Deep", Author = "Adele" },
            new Contacts() { Name = "Don’t Stop Believing", Author = "Journey"},
        };

        for (int i = 0; i < Items.Count; i++)
        {
            Items[i].ItemImage = ImageSource.FromResource("ParallaxViewGettingStarted.parallax" + i + ".png", assembly);
        }
    }
}

public class Contacts
{
    public string Name { get; set; }

    public string Author { get; set; }

    public ImageSource ItemImage { get; set; }
}

{% endhighlight %}

{% endtabs %}

T> The size of the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Content) view will automatically be stretched to the size of the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) view.

![Output of Parallax View](ParallaxView_Images/maui_parallaxview.gif)

You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/MAUI-Parallax-View-Sample-Demos).

N> [\#11230](https://github.com/dotnet/maui/issues/11230) In Android, when an image's pixel size cannot stretch to fit the Parallax View Source control during loading, it results in a Java.Lang.RuntimeException. It is necessary to use the image as Parallax View Content without pixelation.
