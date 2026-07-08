---
layout: post
title: Liquid Glass Effect for .NET MAUI SignaturePad | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI SignaturePad (SfSignaturePad) control.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Liquid Glass Effect in .NET MAUI SignaturePad (SfSignaturePad)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI SignaturePad (SfSignaturePad) control.

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install the [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) and target `net10.0` in your .NET MAUI project.
2. Install the [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad) NuGet package.
3. Install the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet package, which provides the `SfGlassEffectView` class.
4. Register the Syncfusion core handler in the `CreateMauiApp` method of `MauiProgram.cs`. For details, see [Getting Started with .NET MAUI SignaturePad](getting-started.md).
5. The Liquid Glass Effect is supported only on iOS 26 and macOS 26.

> **Note:** The Liquid Glass Effect is supported only on .NET 10 together with iOS 26 and macOS 26.

## Apply the Liquid Glass Effect

Follow these steps to enable and configure the Liquid Glass Effect in the SignaturePad control:

1. Add a sample image (for example, `Wallpaper.png`) to the `Resources/Images` folder of your .NET MAUI project. Set the build action to **MauiImage** so the image can be referenced by file name.
2. Wrap the `SfSignaturePad` control inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.
3. Set the `Background` property of the `SfSignaturePad` to `Transparent` so that the glass-like effect is preserved across the control.

For more information about the Liquid Glass Effect, refer to the [Liquid Glass Getting Started documentation](https://help.syncfusion.com/maui/liquid-glass-ui/overview).

## Configure the SfGlassEffectView properties

The following table describes the key `SfGlassEffectView` properties used to configure the effect:

| Property | Type | Description |
| --- | --- | --- |
| `CornerRadius` | `double` | The radius of the rounded corners applied to the glass container. Default is `0`. |
| `HeightRequest` | `double` | The height of the glass container. |
| `EffectType` | `LiquidGlassEffectType` | The style of the Liquid Glass Effect. See the enum members below. |
| `EnableShadowEffect` | `bool` | Indicates whether a drop shadow is rendered behind the glass container. Default is `false`. |

The `LiquidGlassEffectType` enum exposes the following members:

* `Regular`
* `Clear`

The following code snippet applies the Liquid Glass Effect to the `SfSignaturePad` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <Image Source="Wallpaper.png"
           Aspect="AspectFill" />
    <core:SfGlassEffectView CornerRadius="20"
                            HeightRequest="40"
                            EffectType="Regular"
                            EnableShadowEffect="True">
        <signaturePad:SfSignaturePad x:Name="SignaturePad"
                                     Background="Transparent"
                                     StrokeColor="#1F2937"
                                     MaximumStrokeThickness="2"
                                     MinimumStrokeThickness="2" />
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.SignaturePad;

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

var glassEffects = new SfGlassEffectView
{
    CornerRadius = 20,
    HeightRequest = 40,
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true,
};

var signaturePad = new SfSignaturePad
{
    BackgroundColor = Colors.Transparent,
    StrokeColor = Color.FromArgb("#1F2937"),
    StrokeWidth = 2,
    HorizontalOptions = LayoutOptions.Fill,
    VerticalOptions = LayoutOptions.Fill,
};

glassEffects.Content = signaturePad;
grid.Children.Add(glassEffects);

this.Content = grid;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the `SfSignaturePad` rendered inside a Liquid Glass container:

![SignaturePad with Liquid Glass Effect](images/getting-started/SignaturePad_liquidglass.png)

## See Also

* [Getting Started](getting-started.md)
* [Customization](customization.md)
* [Events and Methods](events-and-methods.md)
