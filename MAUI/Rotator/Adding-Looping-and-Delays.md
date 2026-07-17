---
layout: post
title: Adding Looping and Delays in .NET MAUI Rotator control | Syncfusion®
description: Learn about adding looping and delay support in the Syncfusion® .NET MAUI Rotator (SfRotator) control.
platform: maui 
control: Rotator
documentation: ug
---

# Adding Looping and Delays in .NET MAUI Rotator (SfRotator)

## Prerequisites

Before using the [SfRotator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Rotator`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rotator/getting-started) documentation.

## Overview

Looping and delay can be enabled in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1) control in .NET MAUI.


## Properties Reference

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `EnableAutoPlay` | `bool` | `false` | Specifies whether the items should navigate automatically. |
| `NavigationDelay` | `double` | `2000` | Specifies the delay (in milliseconds) before switching to the next item. Effective only when `EnableAutoPlay` is `true`. |
| `EnableLooping` | `bool` | `false` | Specifies whether the items should loop back to the first item after reaching the last item. |
| `EnableSwiping` | `bool` | `true` | Specifies whether the user can swipe between items. |

## Enable AutoPlay

The [`EnableAutoPlay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableAutoPlay) property specifies whether the items should navigate automatically based on the [`NavigationDelay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDelay) property when `EnableAutoPlay` is set to `true`.

N> By default, the property value is set to `false`.

{% tabs %}

{% highlight xaml %}

<rotator:SfRotator x:Name="rotator" 
                ItemsSource="{Binding ImageCollection}" 
                SelectedIndex="2"
                NavigationDirection="Horizontal"
                NavigationStripMode="Thumbnail" 
                BackgroundColor="#ececec"
                EnableAutoPlay="true"
                NavigationStripPosition="Bottom">
    <rotator:SfRotator.ItemTemplate>
        <DataTemplate>
            <Image  Source="{Binding Image}"/>
        </DataTemplate>
    </rotator:SfRotator.ItemTemplate>
</rotator:SfRotator>

{% endhighlight %}
{% highlight C# %}
    
 RotatorViewModel rotatorViewModel = new RotatorViewModel();
 SfRotator rotator = new SfRotator()
 {
    SelectedIndex = 2,
    NavigationDirection = NavigationDirection.Horizontal,
    NavigationStripMode = NavigationStripMode.Thumbnail,
    BackgroundColor = Color.FromArgb("#ececec"),
    EnableAutoPlay = true,
    NavigationStripPosition = NavigationStripPosition.Bottom,
    ItemsSource = rotatorViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
 
{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
public class RotatorModel
{
    public RotatorModel(string imageString)
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

// ViewModel
public class RotatorViewModel
{
    public RotatorViewModel()
    {
        imageCollection = new List<RotatorModel>
        {
            new RotatorModel("image1.png"),
            new RotatorModel("image2.png"),
            new RotatorModel("image3.png"),
            new RotatorModel("image4.png"),
            new RotatorModel("image5.png")
        };
    }
    private List<RotatorModel> imageCollection;
    public List<RotatorModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Setting Navigation Delay

The [`NavigationDelay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDelay) property specifies the delay duration before switching to the next item when [`EnableAutoPlay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableAutoPlay) is enabled.

N> The property value should be in milliseconds. If `EnableAutoPlay` is `false`, the `NavigationDelay` value has no effect.

{% tabs %}

{% highlight xaml %}

<rotator:SfRotator x:Name="rotator" 
                NavigationDelay="2000" 
                ItemsSource="{Binding ImageCollection}" 
                SelectedIndex="2"
                NavigationDirection="Horizontal"
                NavigationStripMode="Thumbnail" 
                BackgroundColor="#ececec"
                EnableAutoPlay="true"
                NavigationStripPosition="Bottom">
    <rotator:SfRotator.ItemTemplate>
        <DataTemplate>
            <Image  Source="{Binding Image}"/>
        </DataTemplate>
    </rotator:SfRotator.ItemTemplate>
</rotator:SfRotator>
    
	
{% endhighlight %}

{% highlight C# %}
    
 RotatorViewModel rotatorViewModel = new RotatorViewModel();
 SfRotator rotator = new SfRotator()
 {
    SelectedIndex = 2,
    NavigationDirection = NavigationDirection.Horizontal,
    NavigationStripMode = NavigationStripMode.Thumbnail,
    BackgroundColor = Color.FromArgb("#ececec"),
    NavigationDelay = 2000,
    EnableAutoPlay = true,
    NavigationStripPosition = NavigationStripPosition.Bottom,
    ItemsSource = rotatorViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
 
{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
public class RotatorModel
{
    public RotatorModel(string imageString)
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

// ViewModel
public class RotatorViewModel
{
    public RotatorViewModel()
    {
        imageCollection = new List<RotatorModel>
        {
            new RotatorModel("image1.png"),
            new RotatorModel("image2.png"),
            new RotatorModel("image3.png"),
            new RotatorModel("image4.png"),
            new RotatorModel("image5.png")
        };
    }
    private List<RotatorModel> imageCollection;
    public List<RotatorModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Looping Items

The [`EnableLooping`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableLooping) property specifies whether the items should navigate to the first item once they reach the last item and vice-versa.

N> By default, the property value is set to `false`.

{% tabs %}

{% highlight xaml %}

<rotator:SfRotator x:Name="rotator" 
                NavigationDelay="2000" 
                ItemsSource="{Binding ImageCollection}" 
                SelectedIndex="2"
                NavigationDirection="Horizontal"
                NavigationStripMode="Thumbnail" 
                BackgroundColor="#ececec"
                EnableAutoPlay="true"
                EnableLooping="true"
                NavigationStripPosition="Bottom">
    <rotator:SfRotator.ItemTemplate>
        <DataTemplate>
            <Image  Source="{Binding Image}"/>
        </DataTemplate>
    </rotator:SfRotator.ItemTemplate>
</rotator:SfRotator>

{% endhighlight %}
{% highlight C# %}
    
 RotatorViewModel rotatorViewModel = new RotatorViewModel();
 SfRotator rotator = new SfRotator()
 {
    SelectedIndex = 2,
    NavigationDirection = NavigationDirection.Horizontal,
    NavigationStripMode = NavigationStripMode.Thumbnail,
    BackgroundColor = Color.FromArgb("#ececec"),
    EnableAutoPlay = true,
    EnableLooping = true,
    NavigationDelay = 2000,
    NavigationStripPosition = NavigationStripPosition.Bottom,
    ItemsSource = rotatorViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
 
{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
public class RotatorModel
{
    public RotatorModel(string imageString)
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

// ViewModel
public class RotatorViewModel
{
    public RotatorViewModel()
    {
        imageCollection = new List<RotatorModel>
        {
            new RotatorModel("image1.png"),
            new RotatorModel("image2.png"),
            new RotatorModel("image3.png"),
            new RotatorModel("image4.png"),
            new RotatorModel("image5.png")
        };
    }
    private List<RotatorModel> imageCollection;
    public List<RotatorModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## See Also

- [Getting Started with .NET MAUI Rotator (SfRotator)](https://help.syncfusion.com/maui/Rotator/getting-started)
- [Navigation Customization in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-customization)
- [Navigation Mode in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-modes)
- [Populating data in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/populating-data)
- [Events in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/events)
- [Placement Modes in.NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/placement-modes)
