---
layout: post
title: Liquid Glass Effect for .NET MAUI Range Selector | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Range Selector (SfRangeSelector) control.
platform: MAUI
control: SfRangeSelector
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Range Selector (SfRangeSelector)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Range Selector (SfRangeSelector) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Range Selector control:

### Step 1: Enable the liquid glass effect on Range Selector

Set the `EnableLiquidGlassEffect` property to `true` in the `SfRangeSelector` control to apply the Liquid Glass Effect. When enabled,it provides responsive interaction for a smooth and engaging user experience.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfRangeSelector` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="19" %}
    <Grid>
        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center">
            <sliders:SfRangeSelector Minimum="10"
                             Maximum="20"
                             RangeStart="13"
                             RangeEnd="17"
                             EnableLiquidGlassEffect="True" />
        </StackLayout>
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}

using Syncfusion.Maui.Sliders;

var rangeSelector = new SfRangeSelector
{
    Minimum=10,
    Maximum=20,
    RangeStart=13,
    RangeEnd=17,
    EnableLiquidGlassEffect=true
};

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
* The glass effect is applied to the thumb only while it is pressed/dragged.