---
layout: post
title: Loading Online Images in .NET MAUI Rotator control | Syncfusion®
description: Learn about Loading Online Images support in Syncfusion® .NET MAUI Rotator (SfRotator) control and more.
platform: maui
control: Rotator
documentation: ug
---

# Loading Online Images in .NET MAUI Rotator (SfRotator)

## Prerequisites

Before using the [SfRotator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Rotator`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rotator/getting-started) documentation.

## Overview

The [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html) control can load images from remote URLs by binding a collection of model objects whose `Image` property holds the URL. The `ItemTemplate` resolves the URL through the standard .NET MAUI `Image` control, which handles the network request, caching, and platform-specific configuration (such as ATS on iOS or clear text traffic on Android).


## Create the Model

Create a `RotatorModel` class that holds the image URL.

{% tabs %}

{% highlight C# %}

public class RotatorModel
{
    public RotatorModel(string image)
    {
        Image = image;
    }
    public string Image { get; set; }
}

{% endhighlight %}

{% endtabs %}

## Create the ViewModel

Create a `RotatorViewModel` that exposes a collection of `RotatorModel` items. Use `ObservableCollection<T>` so the UI updates automatically when the collection changes.

{% tabs %}

{% highlight C# %}

public class RotatorViewModel
{
    public RotatorViewModel()
    {
        ImageCollection = new ObservableCollection<RotatorModel>
        {
            new RotatorModel("https://cdn.syncfusion.com/content/images/Images/Camtasia_Succinctly.png"),
            new RotatorModel("https://cdn.syncfusion.com/content/images/Images/SQL_Queries_Succinctly.png"),
            new RotatorModel("https://cdn.syncfusion.com/content/images/Images/Keystonejs_Succinctly.png"),
            new RotatorModel("https://cdn.syncfusion.com/content/images/Images/sql_server_for_c_sharp_developers_succinctly_cover_img.png")
        };
    }

    public ObservableCollection<RotatorModel> ImageCollection { get; set; }
}

{% endhighlight %}

{% endtabs %}

## Load Online Images

Bind the `RotatorViewModel.ImageCollection` to the [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemsSource) property of [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html) and use an [`ItemTemplate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemTemplate) to display each image. The `Image.Source` binding resolves the URL for each item.

{% tabs %}

{% highlight xaml %}

<rotator:SfRotator x:Name="rotator"
                    ItemsSource="{Binding ImageCollection}"
                    NavigationDirection="Horizontal">
    <rotator:SfRotator.ItemTemplate>
        <DataTemplate>
            <Image Source="{Binding Image}" />
        </DataTemplate>
    </rotator:SfRotator.ItemTemplate>
</rotator:SfRotator>

{% endhighlight %}
{% highlight C# %}
    
RotatorViewModel rotatorViewModel = new RotatorViewModel();
SfRotator rotator = new SfRotator()
{
    NavigationDirection = NavigationDirection.Horizontal,
    ItemsSource = rotatorViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
 
{% endhighlight %}
{% endtabs %}

![SfRotator loading images from URLs](images/URLImage.png)

## See also

- [Populating Data in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/populating-data)
- [Sliding Direction in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/sliding-direction)
