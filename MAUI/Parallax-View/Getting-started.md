---
layout: post
title: Getting started with .NET MAUI Parallax View control | Syncfusion
description: Learn about getting started with Syncfusion<sup>®</sup> .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Getting Started with .NET MAUI Parallax View (SfParallaxView)

This section explains the steps required to configure the [`SfParallaxView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html) control and add basic elements to it using various APIs.

To get started quickly with our .NET MAUI Parallax View, you can check the below video.

{% youtube "https://youtu.be/ezzIDWYYrUc" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.ParallaxView](https://www.nuget.org/packages/Syncfusion.Maui.ParallaxView/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.ParallaxView](https://www.nuget.org/packages/Syncfusion.Maui.ParallaxView/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.ParallaxView](https://www.nuget.org/packages/Syncfusion.Maui.ParallaxView/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

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

## Step 4: Initialize the view model

Now let us define simple data model and view model.

{% tabs %}
{% highlight c# %}

public class Contacts
{
    public string Name { get; set; }
    public string Author { get; set; }
    public ImageSource ItemImage { get; set; }
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
            new Contacts() { Name = "It's Gonna Be Me", Author = "N Sync"},
            .....
        };
        for (int i = 0; i < Items.Count; i++)
        {
            Items[i].ItemImage = ImageSource.FromResource("ParallaxViewGettingStarted.parallax" + i + ".png", assembly);
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Import the Parallax View namespace
 
Add the following namespace in your XAML or C#.
 
{% tabs %}
{% highlight xaml %}
 
xmlns:parallaxView="clr-namespace:Syncfusion.Maui.ParallaxView;assembly=Syncfusion.Maui.ParallaxView"
 
{% endhighlight %}
{% highlight c# %}
 
using Syncfusion.Maui.ParallaxView;
 
{% endhighlight %}
{% endtabs %}

## Step 5: Add a parallax view component

Initialize the [SfParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html) control and add the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Content), it represents the background view of a parallax view. Set any kind of view to the Content property, such as Image and StackLayout.

The [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) represents the foreground view of the parallax view. The value of the Source should be a scrollable content or the view which implements the [IParallaxView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.IParallaxView.html) interface.

The following code sample demonstrates how to bind the Syncfusion<sup>®</sup> ListView to the Source property.

{% tabs %}

{% highlight xaml %}

<Grid>
    <parallax:SfParallaxView Source="{x:Reference Name = listview}" x:Name="parallaxview" >
        <parallax:SfParallaxView.Content>
            <Image BackgroundColor="Transparent" Source="{Binding Image}" Aspect="AspectFill" />
        </parallax:SfParallaxView.Content>
    </parallax:SfParallaxView> 
        <list:SfListView x:Name="listview" ItemsSource="{Binding Items}">
            <list:SfListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <Grid>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="0.5*" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>
                            <Image BackgroundColor="Transparent" Source="{Binding ItemImage}" Grid.Column="0" Aspect="AspectFit" />
                            <StackLayout BackgroundColor="Transparent" Grid.Column="1">
                                <Label HorizontalOptions="FillAndExpand" TextColor="White" Text="{Binding Name}"/>
                                <Label HorizontalOptions="FillAndExpand" Text="{Binding Author}" TextColor="White"/>
                            </StackLayout>
                        </Grid>
                    </ViewCell>
                </DataTemplate>
            </list:SfListView.ItemTemplate>
        </list:SfListView>
</Grid>

{% endhighlight %}

{% highlight c# %}

var listView = new SfListView
{
    ItemsSource = new Binding("Items")
};

listView.ItemTemplate = new DataTemplate(() =>
{
    var grid = new Grid();

    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.5, GridUnitType.Star) });
    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

    var image = new Image
    {
        BackgroundColor = Colors.Transparent,
        Aspect = Aspect.AspectFit
    };
    image.SetBinding(Image.SourceProperty, "ItemImage");

    var nameLabel = new Label
    {
        TextColor = Colors.White,
        HorizontalOptions = LayoutOptions.FillAndExpand
    };
    nameLabel.SetBinding(Label.TextProperty, "Name");

    var authorLabel = new Label
    {
        TextColor = Colors.White,
        HorizontalOptions = LayoutOptions.FillAndExpand
    };
    authorLabel.SetBinding(Label.TextProperty, "Author");

    var stackLayout = new StackLayout
    {
        BackgroundColor = Colors.Transparent,
        Children = { nameLabel, authorLabel }
    };

    grid.Add(image, 0, 0);
    grid.Add(stackLayout, 1, 0);

    return new ViewCell
    {
        View = grid
    };
});

    var parallaxView = new SfParallaxView
    {
        Source = listView // link with ListView
    };

    var headerImage = new Image
    {
        BackgroundColor = Colors.Transparent,
        Aspect = Aspect.AspectFill
    };
    headerImage.SetBinding(Image.SourceProperty, "Image");

    parallaxView.Content = headerImage;
    var rootGrid = new Grid();
    rootGrid.Children.Add(parallaxView);
    rootGrid.Children.Add(listView);

    Content = rootGrid;

{% endhighlight %}
{% endtabs %}

T> The size of the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Content) view will automatically be stretched to the size of the [`Source`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source) view.

![Output of Parallax View](ParallaxView_Images/maui_parallaxview.gif)

You can download the Parallax View Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/MAUI-Parallax-View-Sample-Demos)

N> [\#11230](https://github.com/dotnet/maui/issues/11230) In Android, when an image's pixel size cannot stretch to fit the Parallax View Source control during loading, it results in a Java.Lang.RuntimeException. It is necessary to use the image as Parallax View Content without degradation in image quality.