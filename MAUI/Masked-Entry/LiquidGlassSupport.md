---
layout: post
title: Liquid Glass Support for .NET MAUI Masked entry | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI MaskedEntry (SfMaskedEntry) control and more.
platform: MAUI
control: SfMaskedEntry
documentation: ug
---

# Liquid Glass Support

The  [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) supports a `liquid glass` appearance by hosting the control inside the Syncfusion [SfGlassEffectView](). The acrylic view creates a blurred, translucent background that blends with the content behind it, producing a frosted `glass effect` around the entry. You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when SfMaskedEntry is placed over images or colorful layouts.

## Availability

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on mac or iOS 26 or greater.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

- Add the Syncfusion.Maui.Core package (for SfGlassEffectView) and Syncfusion.Maui.Inputs (for SfMaskedEntry).

XAML example Wrap the `SfMaskedEntry` in an `SfGlassEffectView` and adjust visual properties to achieve the desired glass effect.

{% tabs %}
{% highlight xaml hl_lines="20" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:inputs="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicMaskedEntryPage">

    <!-- Background content to make the acrylic blur visible -->
    <Grid>
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
            <core:SfGlassEffectView
                CornerRadius="20"
                HeightRequest="40"
                EffectType="Regular"
                EnableShadowEffect="True">

                <inputs:SfMaskedEntry
                    WidthRequest="200"
                    Background="Transparent"
                    ClearButtonVisibility="WhileEditing"
                    MaskType="RegEx"
                    Mask="[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}" />
            </core:SfGlassEffectView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="8" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Inputs;

var glassEffect = new SfGlassEffectView
{
    CornerRadius=20,
    HeightRequest=40,
    EffectType=LiquidGlassEffectType.Regular,
    EnableShadowEffect=true
};

var maskedEntry = new SfMaskedEntry
{
    WidthRequest = 200,
    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
    MaskType = MaskedEntryMaskType.RegEx,
    Background=Colors.Transparent,
    Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}"
};

glassEffect.Content = maskedEntry;

{% endhighlight %}
{% endtabs %}


The following screenshot illustrates SfMaskedEntry within an acrylic container using the glass effect.

![Masked entry with liquid glass support](MaskedEntry_Images/Maskedentry_liquidglass.png)