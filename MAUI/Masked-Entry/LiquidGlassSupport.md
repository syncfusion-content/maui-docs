---
layout: post
title: Liquid Glass Effect for .NET MAUI MaskedEntry | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI MaskedEntry (SfMaskedEntry) control.
platform: MAUI
control: SfMaskedEntry
documentation: ug
---

# Liquid Glass Effect in .NET MAUI MaskedEntry (SfMaskedEntry)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI MaskedEntry (SfMaskedEntry) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the MaskedEntry control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `MaskedEntry` control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Customize the background

To achieve a glass like background in the MaskedEntry, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfMaskedEntry` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}
    <Grid>
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

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}
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

N>
This feature is supported only on .NET 10 along with iOS 26 and macOS 26 