---
layout: post
title: Liquid Glass Support for .NET MAUI DateTimeRangeSelector | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI DateTimeRangeSelector (SfDateTimeRangeSelector) control and more.
platform: MAUI
control: SfDateTimeRangeSelector
documentation: ug
---


# Liquid Glass Support

The  [SfDateTimeRangeSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html) provides `liquid glass` effect for its thumbs when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the user is pressing/dragging the thumb, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the slider’s appearance at rest, and works well over images or colorful layouts.

## Availability

1. Supported on .NET 10 or greater.
2. Supported on mac or iOS 26 or greater.
3. On platforms/versions below these requirements, the glass effect is not applied and the slider thumbs render with the standard appearance.

XAML example The thumb’s glass effect appears only while it is pressed/dragged.

{% tabs %}
{% highlight xaml hl_lines="20" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
    x:Class="SliderGlassEffectPage">

    <Grid>
        <!-- Background to make the glass effect visible while pressing the thumb -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center">
            <Label Text="Volume" FontSize="18" TextColor="White" />

            <sliders:SfDateTimeRangeSelector
                Minimum="2010-01-01" 
                Maximum="2018-01-01" 
                RangeStart="2012-01-01" 
                RangeEnd="2016-01-01"
                EnableLiquidGlassEffect="True"/>
        </StackLayout>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="8" %}

using Syncfusion.Maui.Sliders;

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2018, 01, 01),
    RangeStart = new DateTime(2012, 01, 01),
    RangeEnd = new DateTime(2016, 01, 01),
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates SfRangeSlider with the glass effect visible on the thumb while it is pressed.

![date time range selector with liquid glass support](images/getting-started/rangeslider_liquidglass.gif)

N> The glass effect is applied to the thumb only while it is pressed/dragged.