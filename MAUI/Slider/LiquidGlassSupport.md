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
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}
    <Grid>
        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center">
            <sliders:SfSlider
                Minimum="0"
                Maximum="100"
                Value="45"
                EnableLiquidGlassEffect="True" />
        </StackLayout>
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}

using Syncfusion.Maui.Sliders;

var slider = new SfSlider
{
    Minimum = 0,
    Maximum = 100,
    EnableLiquidGlassEffect = true,
    Value = 45
};

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
* The glass effect is applied to the thumb only while it is pressed/dragged.