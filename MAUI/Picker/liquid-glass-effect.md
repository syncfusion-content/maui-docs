---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Picker | Syncfusion®
description: Learn how to enable liquid glass (acrylic/glassmorphism) support for the Syncfusion® .NET MAUI Picker (SfPicker) using SfGlassEffectsView, and apply glass effect to the dialog mode popup via EnableLiquidGlassEffect Property in SfPicker.
platform: MAUI
control: SfPicker
documentation: ug
---

# Liquid glass support

The [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html) supports a liquid glass (acrylic/glassmorphism) appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when the picker is placed over images or colorful layouts.

Additionally, when the picker is shown in [Dialog]() mode, you can apply the glass effect to the pop-up by enabling the [EnableLiquidGlassEffect]() property on the SfPicker.

## Availability

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on mac or iOS 26 or greater.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

- Add the Syncfusion.Maui.Core package (for SfGlassEffectsView).
- Add the Syncfusion.Maui.Picker package (for SfPicker).

## Picker inside a liquid glass view

Wrap the SfPicker inside an SfGlassEffectsView to give the picker surface a glass (blurred or clear) appearance.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicPickerPage">

    <Grid>
        <!-- Background to make acrylic blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <core:SfGlassEffectsView
            CornerRadius="20"
            Padding="12"
            EffectType="Regular"
            EnableShadowEffect="True">

            <picker:SfPicker />
        </core:SfGlassEffectsView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Picker;

var glassView = new SfGlassEffectsView
{
    CornerRadius = 20,
    Padding = new Thickness(12),
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true
};

var picker = new SfPicker();

glassView.Content = picker;

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.
* Use EffectType="Regular" for a blurrier look and "Clear" for a glassy look.

## Liquid glass for picker dialog mode

When the picker displays in a dialog surface, enable the liquid glass effect by setting EnableLiquidGlassEffect to true.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="PickerDialogGlassPage">

    <Grid>
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <!-- Optional: host the launcher/control within a glass view as well -->
        <core:SfGlassEffectsView
            CornerRadius="16"
            Padding="10"
            EffectType="Clear"
            EnableShadowEffect="True">

            <picker:SfPicker
                EnableLiquidGlassEffect="True" />
        </core:SfGlassEffectsView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Picker;

var picker = new SfPicker
{
    // Applies acrylic/glass effect to the dialog surface
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

N>
* The dialog gains the glass effect only when EnableLiquidGlassEffect is true.

## Key properties

- EffectType: Choose between Regular (blurry) and Clear (glassy) effects.
- EnableShadowEffect: Enables a soft shadow around the acrylic container.
- CornerRadius: Rounds the corners of the acrylic container.
- Padding/Height/Width: Adjust layout around the embedded picker.
- EnableLiquidGlassEffect (dialog): Enables the glass effect for the picker’s dialog surface.

## Behavior and tips

- Hosting the picker inside SfGlassEffectsView gives the picker body an acrylic look.
- In dialog usage, the dialog surface applies the glass effect only when EnableLiquidGlassEffect is true.
- For the most noticeable effect, place the control over images or vibrant backgrounds.

The following screenshot illustrates SfPicker hosted within an acrylic container, and the dialog surface using the glass effect.
