---
layout: post
title: Liquid Glass Effect for .NET MAUI Slider | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Slider (SfSlider) control.
platform: MAUI
control: SfSlider
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Slider (SfSlider)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Slider (SfSlider) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Slider control:

### Step 1: Enable the liquid glass effect on Slider

Set the `EnableLiquidGlassEffect` property to `true` in the `SfSlider` control to apply the Liquid Glass Effect. When enabled,it provides responsive interaction for a smooth and engaging user experience.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfSlider` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7" %}
    <Grid>
    <Image Source="Wallpaper.png" Aspect="AspectFill">
        <sliders:SfSlider
            Minimum="0"
            Maximum="100"
            Value="45"
            EnableLiquidGlassEffect="True" />
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="18" %}

using Syncfusion.Maui.Sliders;

var grid = new Grid
{
    BackgroundColor = Colors.Transparent
};

var image = new Image
{
    Source = "Wallpaper.png",
    Aspect = Aspect.AspectFill
};
grid.Children.Add(image);

var slider = new SfSlider
{
    Minimum = 0,
    Maximum = 100,
    EnableLiquidGlassEffect = true,
    Value = 45
};

grid.Children.Add(slider);
this.Content = grid;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates SfSlider with the glass effect visible on the thumb while it is pressed.

![slider with liquid glass support](images/getting-started/slider_liquidglass.gif)

N>
This feature is supported only on .NET 10 along with iOS 26 and macOS 26 