---
layout: post
title: How to apply the FontIcon for Syncfusion chip control | .NET MAUI
description: Learn how to apply the font icon to the Sfchip and its customization options with its available basic features in .NET MAUI
platform: .NET MAUI
control: Chips
documentation: ug
---

# Setting the FontIcon to SfChip

SfChip is supported to display the font icon by setting `FontImageSource` to its [ImageSource] property with following below steps.

Create the instance for `FontImageSource` and set to [`ImageSource`] property of SfChip as shown in the below code snippet.

{% tabs %}

{% highlight xaml %}

   <chip:SfChip x:Name="chip" 
                Text="Syncfusion" 
                ShowIcon="True"
                FontSize="17"
                TextColor="White"
                BackgroundColor="#512dcd"
                WidthRequest="120"
                HeightRequest="40"
                ImageSize="15"
                Padding="0,0,0,2">
        <chip:SfChip.ImageSource>
            <FontImageSource Glyph="&#xEB52;" 
                             Size="12"
                             Color="White"
                             FontFamily="Segoe MDL2 Assets"
                             >
            </FontImageSource>
        </chip:SfChip.ImageSource>
    </chip:SfChip>

{% endhighlight %}

{% highlight c# %}

 Grid grid = new Grid();
 SfChip chip = new SfChip();
 grid.Children.Add(chip);
 chip.ShowIcon = true;
 chip.Text = "Syncfusion"; 
 chip.FontSize = 17;
 chip.TextColor = Colors.White;
 chip.WidthRequest = 120;
 chip.HeightRequest = 40;
 chip.ImageSize = 15;
 chip.Padding = new Thickness(0,0,0,2);
 
 var fontImageSource = new FontImageSource();
 fontImageSource.Glyph = "&#xEB52";
 fontImageSource.Size = 12;
 fontImageSource.Color = Colors.White;
 fontImageSource.FontFamily = "Segoe MDL2 Assets";           
 chip.ImageSource = fontImageSource;
 this.Content = chip;
 
{% endhighlight %}

{% endtabs %}

![.NET MAUI chip icon font support](images/AppIcon.png)
