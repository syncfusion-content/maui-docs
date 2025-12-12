---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Date Picker | Syncfusion®
description: Learn how to enable liquid glass (acrylic/glassmorphism) support for the Syncfusion® .NET MAUI Date Picker (SfDatePicker) using SfGlassEffectsView, and apply glass effect to the dialog popup via EnableLiquidGlassEffect Property in SfDatePicker.
platform: MAUI
control: SfDatePicker
documentation: ug
---

# Liquid Glass Support

The [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DatePicker.SfDatePicker.html) supports a liquid glass (acrylic/glassmorphism) appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when the date picker is placed over images or colorful layouts.

Additionally, when the date picker is shown in [Dialog]() mode, you can apply the glass effect to the pop-up by enabling the [EnableLiquidGlassEffect]() property on the SfDatePicker.

## Platform and Version Support

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on macOS 26 and iOS 26 or later.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

- Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package (for SfGlassEffectsView).
- Add the [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker/) package (for SfDatePicker).

## Apply Liquid Glass Effect to SfDatePicker

Wrap the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html) inside an [SfGlassEffectsView]() to give the picker surface a glass (blurred or clear) appearance.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:datepicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicDatePickerPage">

    <Grid>
        <!-- Background to make acrylic blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <core:SfGlassEffectsView
            CornerRadius="20"
            Padding="12"
            EffectType="Regular"
            EnableShadowEffect="True">

            <datepicker:SfDatePicker />
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

var datePicker = new SfDatePicker();

glassView.Content = datePicker;

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.
* Use EffectType="Regular" for a blurrier look and "Clear" for a glassy look.

## Enable Glass Effect in Dialog Mode

When the date picker displays its dialog surface, enable the liquid glass effect by setting [EnableLiquidGlassEffect]() to true.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:datepicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="DatePickerDialogGlassPage">

    <Grid>
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <!-- Optional: host the launcher/control within a glass view as well -->
        <core:SfGlassEffectsView
            CornerRadius="16"
            Padding="10"
            EffectType="Clear"
            EnableShadowEffect="True">

            <datepicker:SfDatePicker
                EnableLiquidGlassEffect="True" />
        </core:SfGlassEffectsView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Picker;

var datePicker = new SfDatePicker
{
    // Applies acrylic/glass effect to the dialog surface
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

N>
* The dialog gains the glass effect only when [EnableLiquidGlassEffect]() is true.

## Key Properties

- [EffectType](): Choose between Regular (blurry) and Clear (glassy) effects.
- [EnableShadowEffect](): Enables a soft shadow around the acrylic container.
- [CornerRadius](): Rounds the corners of the acrylic container.
- Padding/Height/Width: Adjust layout around the embedded date picker.
- [EnableLiquidGlassEffect]() (dialog): Enables the glass effect for the date picker’s dialog surface.

## Best Practices and Tips

- Hosting the date picker inside [SfGlassEffectsView]() gives the picker body an acrylic look.
- The dialog surface applies the glass effect only when [EnableLiquidGlassEffect]() is true.
- For the most noticeable effect, place the control over images or vibrant backgrounds.

The following screenshot illustrates [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html) hosted within an acrylic container, and the dialog surface using the glass effect.
