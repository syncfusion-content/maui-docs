---
layout: post
title: Placement Modes in .NET MAUI Rotator control | Syncfusion®
description: Learn about the Placement Modes support in Syncfusion® .NET MAUI Rotator (SfRotator) control and more.
platform: maui
control: Rotator
documentation: ug
---

# Placement Modes in .NET MAUI Rotator (SfRotator)

## Prerequisites

Before using the [SfRotator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Rotator`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rotator/getting-started) documentation.

## Overview

The [`DotPlacement`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_DotPlacement) property controls where the navigation dots are rendered for each item in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html). The property is of type `DotsPlacement` (enum) and the default value is `Default`.

> **Note:** The XAML property is `DotPlacement` (one "s") and the C# enum type is `DotsPlacement` (with an "s"). The same `DotsPlacement` enum is used to set the value in C#.

The following `DotsPlacement` values are available:

* [`Default`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.DotsPlacement.html#Syncfusion_Maui_Core_Rotator_DotsPlacement_Default) — Displays dots for each item inside the rotator area.
* [`None`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.DotsPlacement.html#Syncfusion_Maui_Core_Rotator_DotsPlacement_None) — Hides the dots, creating a clean appearance with no navigation indicators.
* [`OutSide`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.DotsPlacement.html#Syncfusion_Maui_Core_Rotator_DotsPlacement_OutSide) — Displays dots outside the rotator area, around the slider.

Use `Default` for the standard appearance, `None` when the navigation indicator is not needed, and `OutSide` when you want the dots to appear around (above, below, or beside) the slider rather than over it.



## Properties Reference

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `DotPlacement` (XAML) / `DotPlacement` (C#) | `DotsPlacement` | `Default` | Controls where the navigation dots are rendered for each item. |

## Set the DotPlacement

The `DotPlacement` property controls where the dots are rendered for the rotator items. The following example sets the placement to `None` to hide the dots.

{% tabs %}

{% highlight xaml %}

<rotator:SfRotator x:Name="rotator"
                    ItemsSource="{Binding ImageCollection}"
                    SelectedIndex="2"
                    BackgroundColor="#ececec"
                    WidthRequest="550"
                    HeightRequest="550"
                    DotPlacement="None">
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
    SelectedIndex = 2,
    BackgroundColor = Color.FromArgb("#ececec"),
    NavigationStripMode = NavigationStripMode.Thumbnail,
    WidthRequest = 550,
    HeightRequest = 550,
    DotPlacement = DotsPlacement.None,
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


![SfRotator with DotPlacement set to None](images/DotsPlacement.png)

## See also

- [Getting Started with .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/getting-started)
- [Navigation Modes in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-modes)
- [Sliding Direction in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/sliding-direction)
- [Navigation Customization in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-customization)
- [Populating Data in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/populating-data)
