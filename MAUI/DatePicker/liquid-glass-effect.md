---
layout: post
title: Liquid Glass Support for .NET MAUI Date Picker | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Date Picker using SfGlassEffectsView.
platform: MAUI
control: SfDatePicker
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Date Picker (SfDatePicker)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Date Picker (SfDatePicker) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Date Picker control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `Date Picker` control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Date Picker

Set the `EnableLiquidGlassEffect` property to `true` in the `SfDatePicker` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Date Picker, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfDatePicker` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:datepicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicDatePickerPage">

    <Grid>
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
{% highlight c# tabtitle="MainPage.xaml.cs" %}

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
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
