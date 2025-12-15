---
layout: post
title: Liquid Glass Support for .NET MAUI Signature pad | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI Signature pad (SfSignaturePad) control and more.
platform: MAUI
control: SfSignaturePad
documentation: ug
---

# Liquid glass support

The [SignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) supports a `liquid glass` appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when SfSignaturePad is placed over images or colorful layouts

## Availability

- Supported on .NET 10 or greater.
- Supported on mac or iOS 26 or greater.
- On platforms/versions below these requirements, the glassEffects blur is not applied and the control falls back to a standard background.

## Prerequisites

- Add Syncfusion.Maui.Core (for SfGlassEffectsView) and Syncfusion.Maui.SignaturePad (for SfSignaturePad).

XAML example Wrap the SfSignaturePad in an `SfGlassEffectsView` and adjust glassEffects properties to achieve the desired glass effect.

{% tabs %}
{% highlight xaml hl_lines="20" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    xmlns:signature="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad"
    x:Class="glassEffectsSignaturePadPage">

    <Grid>
        <!-- Background to make the glassEffects blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
            <core:SfGlassEffectsView
                CornerRadius="20"
                HeightRequest="40"
                EffectType="Regular"
                EnableShadowEffect="True">

                <signature:SfSignaturePad
                    x:Name="SignaturePad"
                    Background="Transparent"
                    StrokeColor="#1F2937"
                    StrokeWidth="2"/>
            </core:SfGlassEffectsView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="14" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.SignaturePad;

var glassEffects = new SfGlassEffectsView
{
    CornerRadius=20,
    HeightRequest=40,
    EffectType=LiquidGlassEffectType.Regular,
    EnableShadowEffect=True
};

var signaturePad = new SfSignaturePad
{
    Background = Colors.Transparent,
    StrokeColor = Color.FromArgb("#1F2937"),
    StrokeWidth = 2,
    HorizontalOptions = LayoutOptions.Fill,
    VerticalOptions = LayoutOptions.Fill
};

glassEffects.Content = signaturePad;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates SfSignaturePad within an acrylic container, with the dropdown using the glass effect.

![signature pad with liquid glass support](images/getting-started/SignaturePad_liquidglass.png)