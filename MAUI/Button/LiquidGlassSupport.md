---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Button | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI Button (SfButton) control and more.
platform: MAUI
control: SfButton
documentation: ug
---

# Liquid glass support

The [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) provides `liquid glass` (acrylic/glassmorphism) effect that gives the button a frosted, translucent appearance blending with the content behind it. When the glass effect is enabled, the button also scales while it is pressed, delivering a subtle, responsive interaction cue. This enhances visual depth and interactivity, especially when the button is placed over images or colorful layouts.

## Availability

1. Supported on .NET 10 or greater.
2. Supported on mac or iOS 26 or greater.
3. On platforms/versions below these requirements, the glass effect and scaling feedback are not applied; the button renders with the standard appearance.

XAML example Enable the glass effect on `SfButton`. When pressed, the button will `scale` while the effect is enabled.

{% tabs %}
{% highlight xaml hl_lines="49 52" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"
    x:Class="ButtonGlassEffectPage">

    <Grid>
        <!-- Background to showcase the glass and scaling effects -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center" HorizontalOptions="Center">
            <buttons:SfButton
                x:Name="GlassButton"
                Text="Continue"
                EnableLiquidGlassEffect="True"
                WidthRequest="180"
                CornerRadius="24"
                HeightRequest="48" />
        </StackLayout>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="74 77" %}

using Syncfusion.Maui.Buttons;

var glassButton = new SfButton
{
    Text = "Continue",
    AutomationId = "Acrylic Button",
    EnableLiquidGlassEffect = true, // Enables glass look and press-time scaling
    WidthRequest = 180,
    HeightRequest = 48
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- When [EnableLiquidGlassEffect]() is true, the button uses a frosted glass appearance and scales while pressed, then returns to its normal size on release.
- Place the button over visually rich content (images, gradients, or colorful panels) to highlight the glass look.
- Visual output and performance can vary by device/platform; keep the background moderately detailed for clarity during interaction.

The following screenshot illustrates SfButton with the glass effect enabled and the pressed-state scaling behavior over a wallpaper background.