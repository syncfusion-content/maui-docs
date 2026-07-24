---
layout: post
title: Liquid Glass Effect for .NET MAUI Buttons | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Buttons (SfButton) control.
platform: maui
control: SfButton
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Buttons (SfButton)

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), Install the [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) and [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet packages in your .NET MAUI project. The `Syncfusion.Maui.Core` package is required for the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) container used to host the Liquid Glass Effect.

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

N>
* The Liquid Glass Effect is supported only on **.NET 10** targeting **macOS 26 or higher** and **iOS 26 or higher**.
* It is not supported on Android or Windows.

## Overview

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible. This page explains how to enable and customize the effect in the Syncfusion® .NET MAUI Button (SfButton) control.

## Apply Liquid Glass Effect

Follow these steps to enable and configure the Liquid Glass Effect in `SfButton`:

### Step 1: Provide a background image

Place a background image behind the button so the Liquid Glass Effect has something to refract and tint. In the example below, the image and the button are both children of a `Grid`.

### Step 2: Enable the Liquid Glass Effect on the button

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_EnableLiquidGlassEffect) property to `true` on `SfButton` to apply the effect. When enabled, the button renders as a translucent surface and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass-like background, set the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Background) property to `Transparent`. The background is then treated as a tinted color, ensuring a consistent Liquid Glass effect across the controls.

## Code Example

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfButton` control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <Image Source="Wallpaper.png" 
           Aspect="AspectFill" />
    <buttons:SfButton x:Name="GlassButton"
                      Text="GlassButton"
                      EnableLiquidGlassEffect="True"
                      Background="Transparent"
                      WidthRequest="180"
                      HeightRequest="48"
                      CornerRadius="24" />
</Grid>

{% endhighlight %}
{% highlight C# %}

var grid = new Grid();
var image = new Image
{
    Source = "Wallpaper.png",
    Aspect = Aspect.AspectFill
};
grid.Children.Add(image);

var glassButton = new SfButton
{
    Text = "GlassButton",
    Background = Colors.Transparent,
    WidthRequest = 180,
    HeightRequest = 48,
    CornerRadius = 24,
    EnableLiquidGlassEffect = true
};
grid.Children.Add(glassButton);
Content = grid;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates `SfButton` with the Liquid Glass effect enabled.

![SfButton with the Liquid Glass effect enabled](Images/customization-images/Button_liquidglass.png)

## See Also

- [Customization](https://help.syncfusion.com/maui/button/customization)
- [Right-to-Left](https://help.syncfusion.com/maui/button/right-to-left)
- [Visual States](https://help.syncfusion.com/maui/button/visual-states)