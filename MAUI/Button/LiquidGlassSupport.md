---
layout: post
title: Liquid Glass Effect for .NET MAUI Buttons | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Buttons (SfButton) control.
platform: MAUI
control: SfButton
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Buttons (SfButton)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Buttons (SfButton) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Buttons control:

### Step 1: Enable the liquid glass effect on Buttons

Set the `EnableLiquidGlassEffect` property to `true` in the `SfButton` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Buttons, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfButton` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}

    <Grid>
        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center" HorizontalOptions="Center">
            <buttons:SfButton
                x:Name="GlassButton"
                Text="Continue"
                EnableLiquidGlassEffect="True"
                Background="Transparent"
                WidthRequest="180"
                CornerRadius="24"
                HeightRequest="48" />
        </StackLayout>
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}

using Syncfusion.Maui.Buttons;

var glassButton = new SfButton
{
    Text = "GlassButton",
    EnableLiquidGlassEffect = true, // Enables glass look and press-time scaling
    WidthRequest = 180,
    Background=Colors.Transparent;
    HeightRequest = 48
};

{% endhighlight %}
{% endtabs %}

N>
This feature is supported only on .NET 10 along with iOS 26 and macOS 26 