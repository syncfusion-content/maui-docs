---
layout: post
title: How to Apply a Font Icon to the Syncfusion® Chip Control | .NET MAUI
description: Learn how to apply a font icon to the SfChip and explore its customization options along with basic features in .NET MAUI.
platform: maui
control: Chips
documentation: ug
---

# Setting the FontIcon for SfChip

The SfChip supports displaying a font icon by setting a [`FontImageSource`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.fontimagesource) to its [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_ImageSource) property. Follow the steps below.

Create an instance of `FontImageSource` and set it to the `ImageSource` property of SfChip as shown in the code snippet below.

{% tabs %}

{% highlight xaml %}

   <chip:SfChip x:Name="chip" 
                Text="Syncfusion" 
                ShowIcon="True"
                FontSize="17"
                TextColor="White"
                Background="#512dcd"
                WidthRequest="120"
                HeightRequest="40"
                ImageSize="15"
                Padding="0,0,0,2">
        <chip:SfChip.ImageSource>
            <FontImageSource Glyph="&#xEB52;" 
                             Size="12"
                             Color="White"
                             FontFamily="Segoe MDL2 Assets">
            </FontImageSource>
        </chip:SfChip.ImageSource>
    </chip:SfChip>

{% endhighlight %}

{% highlight c# %}

var fontImageSource = new FontImageSource
{
    Glyph = "\uEB52",
    Size = 12,
    Color = Colors.White,
    FontFamily = "Segoe MDL2 Assets"
};
SfChip chip = new SfChip
{
    ShowIcon = true,
    Text = "Syncfusion",
    FontSize = 17,
    TextColor = Colors.White,
    Background = Color.FromArgb("#512dcd"), 
    WidthRequest = 120,
    HeightRequest = 40,
    ImageSize = 15,
    Padding = new Thickness(0, 0, 0, 2),
    ImageSource = fontImageSource
};
 
{% endhighlight %}

{% endtabs %}

![.NET MAUI chip icon font support](images/AppIcon.png)
