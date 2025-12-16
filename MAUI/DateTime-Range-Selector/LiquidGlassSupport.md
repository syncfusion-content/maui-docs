---
layout: post
title: Liquid Glass Effect for .NET MAUI DateTime RangeSelector | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI DateTime RangeSelector (SfDateTimeRangeSelector) control.
platform: MAUI
control: SfDateTimeRangeSelector
documentation: ug
---

# Liquid Glass Effect in .NET MAUI DateTimeRangeSelector

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI DateTime RangeSelector (SfDateTimeRangeSelector) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the DateTime RangeSelector control:

### Step 1: Enable the liquid glass effect on DateTime RangeSelector

Set the [EnableLiquidGlassEffect]() property to `true` in the [SfDateTimeRangeSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html) control to apply the Liquid Glass Effect. When enabled,it provides responsive interaction for a smooth and engaging user experience.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfDateTimeRangeSelector` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="8" %}
    <Grid>
        <Image Source="Wallpaper.png" Aspect="AspectFill">
        <sliders:SfDateTimeRangeSelector
            Minimum="2010-01-01" 
            Maximum="2018-01-01" 
            RangeStart="2012-01-01" 
            RangeEnd="2016-01-01"
            EnableLiquidGlassEffect="True"/>
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="23" %}
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

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2018, 01, 01),
    RangeStart = new DateTime(2012, 01, 01),
    RangeEnd = new DateTime(2016, 01, 01),
    EnableLiquidGlassEffect = true
};

grid.Children.Add(rangeSelector);
this.Content = grid;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates SfRangeSlider with the glass effect visible on the thumb while it is pressed.

![date time range selector with liquid glass support](images/getting-started/rangeslider_liquidglass.gif)

N>
This feature is supported only on .NET 10 along with iOS 26 and macOS 26 