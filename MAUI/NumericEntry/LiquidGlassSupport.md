---
layout: post
title: Liquid Glass Effect for .NET MAUI NumericEntry | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI NumericEntry (SfNumericEntry) control.
platform: maui
control: SfNumericEntry
documentation: ug
---

# Liquid Glass Effect in .NET MAUI NumericEntry (SfNumericEntry)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI NumericEntry (SfNumericEntry) control.

## Prerequisites

Before using the [SfNumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html), Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet packages in your .NET MAUI project. The `Syncfusion.Maui.Core` package is required for the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) container used to host the Liquid Glass Effect.

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

N>
* The Liquid Glass Effect is supported only on **.NET 10** targeting **macOS 26 or higher** and **iOS 26 or higher**.
* It is not supported on Android or Windows.

## Apply the Liquid Glass Effect

Follow these steps to enable and configure the Liquid Glass Effect in the `SfNumericEntry` control:

1. Add a sample image (for example, `Wallpaper.png`) to the `Resources/Images` folder of your .NET MAUI project. Set the build action to **MauiImage** so the image can be referenced by file name.
2. Wrap the `SfNumericEntry` control inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.
3. Set the `Background` property of the `SfNumericEntry` to `Transparent` so the glass-like effect is preserved across the control.

For more information about the Liquid Glass Effect, refer to the [Liquid Glass Getting Started documentation](https://help.syncfusion.com/maui/liquid-glass-ui/overview).

## Configure the SfGlassEffectView properties

The [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) exposes the following key properties:

- `EffectType`: Defines the glass style. The available values are `Regular` and `Clear`. The default value is `Regular`.
- `CornerRadius`: The corner radius of the glass container.
- `EnableShadowEffect`: Indicates whether a drop shadow is rendered behind the glass container. The default value is `false`.

The following code snippet applies the Liquid Glass Effect to the `SfNumericEntry` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <Image Source="Wallpaper.png"
            Aspect="AspectFill" />
    <core:SfGlassEffectView CornerRadius="20"
                            HeightRequest="40"
                            EffectType="Regular"
                            EnableShadowEffect="True">
        <editors:SfNumericEntry Value="1234.56"
                                CustomFormat="N2"
                                Placeholder="Enter amount"
                                Maximum="1000000"
                                Minimum="0"
                                Background="Transparent"
                                ShowClearButton="True" />
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Inputs;

var grid = new Grid
{
    BackgroundColor = Colors.Transparent,
};

var image = new Image
{
    Source = "Wallpaper.png",
    Aspect = Aspect.AspectFill,
};
grid.Children.Add(image);

var glassEffect = new SfGlassEffectView
{
    CornerRadius = 20,
    HeightRequest = 40,
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true,
};

var numericEntry = new SfNumericEntry
{
    Value = 1234.56,
    CustomFormat = "N2",
    Placeholder = "Enter amount",
    Maximum = 1_000_000,
    Minimum = 0,
    BackgroundColor = Colors.Transparent,
    ShowClearButton = true,
};

glassEffect.Content = numericEntry;
grid.Children.Add(glassEffect);

this.Content = grid;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the `SfNumericEntry` rendered inside a Liquid Glass container:

![.NET MAUI NumericEntry with the Liquid Glass Effect](GettingStarted_images/NumericEntry_liquidGlass.png)

## See Also

* [Basic Features](Basic-Features.md)
* [Formatting](Formatting.md)
* [Restriction](Restriction.md)
* [UpDown-Button](UpDown-Button.md)
