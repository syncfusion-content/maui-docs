---
layout: post
title: Liquid Glass Support for .NET MAUI Backdrop Page | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Backdrop Page using the EnableLiquidGlassEffect property.
platform: MAUI
control: SfBackdropPage
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Backdrop Page (SfBackdropPage)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in .NET MAUI Backdrop Page's Front or Back layer.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Front or Back Layer:

### Step 1: Enable the liquid glass effect on Front or Back Layer

Set the `EnableLiquidGlassEffect` property to `true` in the `SfBackdropPage` control's Front or Back Layer to apply the Liquid Glass Effect.

### Step 2: Customize the background

To achieve a glass like background in the Front or Back Layer, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the Front or Back layer of the `SfBackdropPage` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="AcrylicBackdropPage"
                         xmlns:backdrop="clr-namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop">

    <backdrop:SfBackdropPage.BackLayer>
        <backdrop:BackdropBackLayer EnableLiquidGlassEffect="True">
            <Grid>
                <Image Source="wallpaper.jpg" Aspect="AspectFill" />
                <StackLayout Padding="16">
                    <Label Text="Back layer content" FontSize="16"/>
                </StackLayout>
            </Grid>
        </backdrop:BackdropBackLayer>
    </backdrop:SfBackdropPage.BackLayer>

    <backdrop:SfBackdropPage.FrontLayer>
        <backdrop:BackdropFrontLayer EnableLiquidGlassEffect="True">
            <Grid>
                <Image Source="wallpaper.jpg" Aspect="AspectFill" />
                <StackLayout Padding="16">
                    <Label Text="Front layer content" FontSize="16"/>
                </StackLayout>
            </Grid>
        </backdrop:BackdropFrontLayer>
    </backdrop:SfBackdropPage.FrontLayer>
</backdrop:SfBackdropPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Backdrop;

this.BackLayer = new BackdropBackLayer
{
    EnableLiquidGlassEffect = true,
    Content = new Grid
    {
        Children =
        {
            new Image { Source = "wallpaper.jpg", Aspect = Aspect.AspectFill },
            new VerticalStackLayout
            {
                Padding = 16,
                Children = { new Label { Text = "Back layer content", FontSize = 16 } }
            }
        }
    }
};

this.FrontLayer = new BackdropFrontLayer
{
    EnableLiquidGlassEffect = true,
    Content = new Grid
    {
        Children =
        {
            new Image { Source = "wallpaper.jpg", Aspect = Aspect.AspectFill },
            new VerticalStackLayout
            {
                Padding = 16,
                Children = { new Label { Text = "Front layer content", FontSize = 16 } }
            }
        }
    }
};

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`