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

{% tabs %}

{% highlight xaml %}

<dict>
...
<key>UIAppFonts</key>
<array>
<string>chip_Segoe MDL2 Assets.ttf</string>
...
</array>
</dict>

{% endhighlight %}

{% endtabs %}


Create the instance for `FontImageSource` and set to [`ImageSource`] property of SfChip as shown in the below code snippet.

{% tabs %}

{% highlight xaml %}

<core:SfChip x:Name="Chip" 
                Text="Syncfusion" 
                ShowIcon="True">
    <core:SfChip.ImageSource>
        <FontImageSource Glyph="&#xEB52;" 
                         Size="40">
        </FontImageSource>
    </core:SfChip.ImageSource> 
</core:SfChip>

{% endhighlight %}

{% highlight c# %}
 
 SfChip chip = new SfChip();
 chip.ShowIcon = true;
 chip.Text = "Syncfusion"; 

 var fontImageSource = new FontImageSource();
 fontImageSource.Glyph = "\uEB52";
 fontImageSource.Size = 40;

            
 chip.ImageSource = fontImageSource;

{% endhighlight %}

{% endtabs %}


N> FontImageSource supported from Xamarin.Forms version 3.6 onwards.

![Xamarin.Forms chip group icon font support]