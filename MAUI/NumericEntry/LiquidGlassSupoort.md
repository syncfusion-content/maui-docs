---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Numeric entry | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI NumericEntry (SfNumericEntry) control and more.
platform: MAUI
control: SfNumericEntry
documentation: ug
---

# Liquid glass support

The  [SfNumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) supports a `liquid glass` (glassmorphism) appearance by hosting the control inside the Syncfusion SfGlassEffectsView. The acrylic view creates a blurred, translucent background that blends with the content behind it, producing a frosted `glass effect` around the entry. You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when SfNumericEntry is placed over images or colorful layouts.

## Availability

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on mac or iOS 26 or greater.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

Add the Syncfusion.Maui.Core package (for SfGlassEffectsView) and Syncfusion.Maui.Inputs (for SfNumericEntry).
Initialize Syncfusion in your app startup (once per app):
C# Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY"); builder.ConfigureSyncfusionCore();

XAML example Wrap the SfNumericEntry in an SfGlassEffectsView and adjust visual properties to achieve the desired glass effect.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:inputs="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicNumericEntryPage">

    <!-- Background content to make the acrylic blur visible -->
    <Grid>
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <Grid Padding="24">
            <core:SfGlassEffectsView
                CornerRadius="14"
                EffectType="Regular"
                EnableShadowEffect="True">

                <inputs:SfNumericEntry
                    Value="1234.56"
                    FormatString="N2"
                    Placeholder="Enter amount"
                    Maximum="1000000"
                    Minimum="0"
                    showClearButton="True" />
            </core:SfGlassEffectsView>
        </Grid>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Inputs;

var glassEffect = new SfGlassEffectsView
{
    CornerRadius=14,
    EffectType=LiquidGlassEffectType.Regular,
    EnableShadowEffect=true
};

var numericEntry = new SfNumericEntry
{
    Value = 1234.56,
    FormatString = "N2",
    Placeholder = "Enter amount",
    Maximum = 1_000_000,
    Minimum = 0,
    ShowClearButton=true
};

glassEffect.Content = numericEntry;

{% endhighlight %}
{% endtabs %}

## Key properties

EffectType: Has two type Regular(Blurry) effect and Clear(Glassy) effect.
EnableShadowEffect: To enable the shadow around the acrylic container
CornerRadius: Rounds the corners of the acrylic container.
Padding/Height/Width: Adjust layout around the embedded SfNumericEntry.

## Behavior and tips

Acrylic effects are most visible when there is content behind the control (e.g., images or vivid backgrounds).
Visual output and performance can vary by device; adjust EffectType to balance readability and performance.
Ensure the acrylic container is sufficiently larger than the entry so the glass outline is visible.
