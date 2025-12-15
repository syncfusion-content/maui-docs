---
layout: post
title: Liquid Glass Support for .NET MAUI RangeSelector | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI RangeSelector (SfRangeSelector) control and more.
platform: MAUI
control: SfRangeSelector
documentation: ug
---


# Liquid glass support:

The  [SfRangeSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSelector.html) provides `liquid glass` effect for its thumbs when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the user is pressing/dragging the thumb, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the slider’s appearance at rest, and works well over images or colorful layouts.

## Availability

1. Supported on .NET 10 or greater.
2. Supported on mac or iOS 26 or greater.
3. On platforms/versions below these requirements, the glass effect is not applied and the slider thumbs render with the standard appearance.

XAML example The thumb’s glass effect appears only while it is pressed/dragged.

{% tabs %}
{% highlight xaml hl_lines="19" %}

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

            <sliders:SfRangeSelector Minimum="10"
                             Maximum="20"
                             RangeStart="13"
                             RangeEnd="17"
                             EnableLiquidGlassEffect="True" />
        </StackLayout>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="9" %}

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

The following screenshot illustrates SfRangeSlider with the glass effect visible on the thumb while it is pressed.

![range selector with liquid glass support](images/getting-started/rangeslider_liquidglass.gif)

N> The glass effect is applied to the thumb only while it is pressed/dragged.