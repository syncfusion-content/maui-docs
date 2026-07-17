---
layout: post
title: Header Visibility in .NET MAUI Rotator control | Syncfusion®
description: Learn about the Header Visibility support in Syncfusion® .NET MAUI Rotator (SfRotator) control and more.
platform: maui
control: Rotator
documentation: ug
---

# Header Visibility in .NET MAUI Rotator (SfRotator)

## Prerequisites

Before using the [SfRotator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Rotator`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rotator/getting-started) documentation.

## Overview

The [`IsTextVisible`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_IsTextVisible) property enables the text area at the bottom of the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html) control, which displays additional information about each item.

The text area is populated from the [`ItemText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotatorItem.html#Syncfusion_Maui_Rotator_SfRotatorItem_ItemText) property of [`SfRotatorItem`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotatorItem.html) when items are added through the `SfRotatorItem` collection. When items are populated through an `ItemTemplate`, the text area does not appear, even when `IsTextVisible` is `true`.

> **Note:** By default, `IsTextVisible` is `false`.

> **Note:** Ensure that the images referenced in the code snippets (e.g., `image1.png` through `image5.png`) are located in the **Resources/Images** folder of your project.

## Properties Reference

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `IsTextVisible` | `bool` | `false` | Controls whether the text area at the bottom of `SfRotator` is visible. |
| `SfRotatorItem.ItemText` | `string` | `null` | The text shown in the text area for the item. Required for the text area to display. |

## Show the Header Text

To display the header text, set `IsTextVisible` to `true` and populate the `ItemsSource` with `SfRotatorItem` objects that have their `ItemText` property set. The following example uses the C# code-behind to create the items.

The corresponding XAML page is shown below. Note that the XAML approach uses `SfRotatorItem` instances in the code-behind; the `IsTextVisible` text area is not supported with `ItemTemplate`-based data binding.


{% tabs %}

{% highlight xaml %}

<rotator:SfRotator x:Name="rotator"
                    ItemsSource="{Binding ImageCollection}"
                    BackgroundColor="#ececec"
                    IsTextVisible="True"
                    VerticalOptions="Start">
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
    VerticalOptions = LayoutOptions.Start,
    rotator.IsTextVisible = true,
    BackgroundColor = Color.FromArgb("#ececec"),
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


![SfRotator with the header text area visible](images/IsTextVisible.png)

## Troubleshooting

* **Text does not appear** — Confirm that the `ItemsSource` is a collection of `SfRotatorItem` objects (not a generic model) and that each item has its `ItemText` property set. The text area is not supported with `ItemTemplate`-based binding.
* **Dots overlap the text** — Set `DotPlacement` to `DotsPlacement.OutSide` to render the dots below the text area.

## See also

- [Getting Started with .NET MAUI Rotator (SfRotator)](https://help.syncfusion.com/maui/Rotator/getting-started)
- [Navigation Customization in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-customization)
- [Navigation Mode in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-modes)
- [Populating data in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/populating-data)
- [Events in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/events)
- [Placement Modes in.NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/placement-modes)
