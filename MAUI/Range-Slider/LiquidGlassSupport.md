---
layout: post
title: Liquid Glass Effect for .NET MAUI Range Slider | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Range Slider (SfRangeSlider) control.
platform: MAUI
control: SfRangeSlider
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Range Slider (SfRangeSlider)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Range Slider (SfRangeSlider) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Range Slider control:

### Step 1: Enable the liquid glass effect on Range Slider

Set the `EnableLiquidGlassEffect` property to `true` in the `SfRangeSlider` control to apply the Liquid Glass Effect. When enabled,it provides responsive interaction for a smooth and engaging user experience.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfRangeSlider` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18" %}
    <Grid>
        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center">
            <sliders:SfRangeSlider 
                             Minimum="10"
                             Maximum="20"
                             EnableLiquidGlassEffect="True" />
        </StackLayout>
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="7" %}

using Syncfusion.Maui.Sliders;

var rangeSlider = new SfRangeSlider
{
    Minimum=10,
    Maximum=20,
    EnableLiquidGlassEffect=true
};

{% endhighlight %}
{% endtabs %}

N>
This feature is supported only on .NET 10 along with iOS 26 and macOS 26 