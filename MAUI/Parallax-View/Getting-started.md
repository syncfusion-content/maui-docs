---
layout: post
title: Getting started with .NET MAUI Parallax View control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Getting Started with .NET MAUI Parallax View (SfParallaxView)

This section explains the steps required to configure the [`SfParallaxView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html) control and add basic elements to it using various APIs.

## Creating an application using .NET MAUI Parallax View

1. Create a new .NET MAUI application in Visual studio.
2. Syncfusion® .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfParallaxView to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.ParallaxView and then install it.
3. To initialize the control, import the Parallax View namespace.
4. Initialize [SfParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html).

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

## Register the handler

Syncfusion.Maui.Core Nuget is a dependent package for all Syncfusion® controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion® core.

{% highlight C# %}

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


## Add content to the parallax view

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

## Bind source to the parallax view

The [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) represents the foreground view of the parallax view. The value of the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) should be a scrollable content or the view which implements the [IParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface.

Currently, the [SfParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html) directly supports the following controls. Bind the control to the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) property.

    1. ScrollView
    2. Syncfusion ListView

The following code sample demonstrates how to bind the Syncfusion ListView to the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) property.

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
