---
layout: post
title: Liquid Glass Effect for .NET MAUI DateTime RangeSlider | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI DateTime RangeSlider (SfDateTimeRangeSlider) control.
platform: MAUI
control: SfDateTimeRangeSlider
documentation: ug
---

# Liquid Glass Effect in .NET MAUI DateTime RangeSlider (SfDateTimeRangeSlider)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI DateTime RangeSlider (SfDateTimeRangeSlider) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the DateTime RangeSlider control:

### Step 1: Enable the liquid glass effect on DateTime RangeSlider

Set the `EnableLiquidGlassEffect` property to `true` in the `SfDateTimeRangeSlider` control to apply the Liquid Glass Effect. When enabled,it provides responsive interaction for a smooth and engaging user experience.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfDateTimeRangeSlider` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}
    <Grid>
        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center">
            <sliders:SfDateTimeRangeSlider
                Minimum="2010-01-01" 
                Maximum="2018-01-01" 
                RangeStart="2012-01-01" 
                RangeEnd="2016-01-01"
                EnableLiquidGlassEffect="True" />
        </StackLayout>
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}
using Syncfusion.Maui.Sliders;

SfDateTimeRangeSlider dateTimeRangeSlider = new SfDateTimeRangeSlider
{
    Minimun = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2018, 01, 01),
    RangeStart = new DateTime(2012, 01, 01),
    RangeEnd = new DateTime(2016, 01, 01),
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

N>
This feature is supported only on .NET 10 along with iOS 26 and macOS 26 