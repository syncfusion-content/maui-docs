---
layout: post
title: Liquid Glass Effect for .NET MAUI Autocomplete | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Autocomplete (SfAutocomplete)

## Prerequisites

Before using the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html), Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet packages in your .NET MAUI project. The `Syncfusion.Maui.Core` package is required for the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) container used to host the Liquid Glass Effect.

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/autocomplete/getting-started) documentation.

N>
* The Liquid Glass Effect is supported only on **.NET 10** targeting **macOS 26 or higher** and **iOS 26 or higher**.
* It is not supported on Android or Windows.

## Overview

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains readable on top of any background. This section explains how to enable and customize the effect in the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control.

## Apply the liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the SfAutocomplete control:

### Step 1: Wrap the control inside the glass effect view

To apply the Liquid Glass Effect to the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control, wrap it inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.

### Step 2: Enable the liquid glass effect on the SfAutocomplete

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_EnableLiquidGlassEffect) property to `true`. The default value is `false`. When enabled, the effect is also applied to the drop-down and suggestion list.

### Step 3: Customize the background

To achieve a glass-like background in the SfAutocomplete, set the `Background` and `DropDownBackground` properties to `Transparent`. The background is then treated as a tinted color, ensuring a consistent glass effect across the input and the drop-down. Make sure the parent layout's background is also transparent or a tinted color so the effect is visible.

**Properties**

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `EnableLiquidGlassEffect` | `bool` | `false` | Gets or sets a value that indicates whether the Liquid Glass Effect is applied. |
| `DropDownBackground` | `Brush` | `null` | Gets or sets the background of the drop-down. Set to `Transparent` for the glass effect. |
| `SfGlassEffectView.EffectType` | `LiquidGlassEffectType` | `Regular` | The thickness of the glass effect. Values: `Clear`, `Regular`. |
| `SfGlassEffectView.CornerRadius` | `double` | `8.0` | The corner radius of the glass container. |

The following code snippet demonstrates how to apply the Liquid Glass Effect to the SfAutocomplete control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="11" %}
<Grid BackgroundColor="Transparent">
    <Image Source="Wallpaper.png" Aspect="AspectFill" />
    <core:SfGlassEffectView EffectType="Regular"
                            CornerRadius="20">
        <autocomplete:SfAutocomplete x:Name="Autocomplete"
                                     Background="Transparent"
                                     HeightRequest="40"
                                     WidthRequest="300"
                                     ItemsSource="{Binding Names}"
                                     DropDownBackground="Transparent"
                                     EnableLiquidGlassEffect="True" />
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight C# tabtitle="MainPage.xaml.cs" %}

var grid = new Grid
{
    BackgroundColor = Colors.Transparent
};

var image = new Image
{
    Source = "Wallpaper.png",
    Aspect = Aspect.AspectFill
};
grid.Children.Add(image);

var glass = new SfGlassEffectView
{
    EffectType = LiquidGlassEffectType.Regular,
    CornerRadius = 20
};

var autocomplete = new SfAutocomplete
{
    Background = Colors.Transparent,
    HeightRequest = 40,
    WidthRequest = 300,
    DropDownBackground = Colors.Transparent,
    ItemsSource = new List<string> { "Jacob", "Will", "Noah", "Dustin" },
    EnableLiquidGlassEffect = true
};

glass.Content = autocomplete;
grid.Children.Add(glass);
this.Content = grid;

{% endhighlight %}
{% endtabs %}

N> The `Wallpaper.png` image must be added to the project's `Resources/Images` folder and have its build action set to **MauiImage**. Register the namespace in `MauiProgram.cs` if required.

The following screenshot illustrates the SfAutocomplete with the Liquid Glass Effect applied to the input and the drop-down:

![SfAutocomplete with the Liquid Glass Effect applied to the input and drop-down](Images/UICustomization/Autocomplete_liquidglass.png)

## Customize the effect

You can change the appearance of the glass effect by adjusting the `EffectType` and `CornerRadius` of the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html):

- `EffectType` - choose `Clear`, `Regular` (default) to control the glass thickness.
- `CornerRadius` - set a value in device-independent units to round the corners of the glass container.
- The `Background` and `DropDownBackground` of the SfAutocomplete can be set to any translucent `Color` (for example, `Colors.Transparent` or `Color.FromArgb("#80FFFFFF")`) to fine-tune the tint.

## See also

- [Selection](https://help.syncfusion.com/maui/autocomplete/selection)
- [UI Customization](https://help.syncfusion.com/maui/autocomplete/ui-customization)
- [Getting Started](https://help.syncfusion.com/maui/autocomplete/getting-started)