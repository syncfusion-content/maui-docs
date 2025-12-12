---
layout: post
title: Liquid Glass Support for .NET MAUI Backdrop Page | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Backdrop Page using the EnableLiquidGlassEffect property.
platform: MAUI
control: SfBackdropPage
documentation: ug
---

# Liquid Glass Support

The [SfBackdropPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html) supports a liquid glass  appearance on both layers. Enable the effect directly on the [BackdropBackLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.BackdropBackLayer.html) and [BackdropFrontLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.BackdropFrontLayer.html) by setting their [EnableLiquidGlassEffect]() properties to true. This improves visual depth and readability when the backdrop layers are placed over images or colorful layouts.

## Platform and Version Support

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on macOS 26 and iOS 26 or later.
3. On platforms or versions below these requirements, the layers render without the acrylic blur effect and fall back to a standard background.

## Prerequisites

- Add the [Syncfusion.Maui.Backdrop](https://www.nuget.org/packages/Syncfusion.Maui.Backdrop) package (for SfBackdropPage, BackdropFrontLayer, BackdropBackLayer).

## Apply Liquid Glass Effect to the back layer

Turn on the liquid glass effect on the back layer by setting [EnableLiquidGlassEffect]() to true.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="AcrylicBackdropPage"
                         xmlns:backdrop="clr-namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop">

    <backdrop:SfBackdropPage.BackLayer>
        <backdrop:BackdropBackLayer EnableLiquidGlassEffect="True">
            <Grid>
                <!-- Optional: colorful/image background to visualize acrylic -->
                <Image Source="wallpaper.jpg" Aspect="AspectFill" />
                <StackLayout Padding="16">
                    <Label Text="Back layer content" FontSize="16"/>
                </StackLayout>
            </Grid>
        </backdrop:BackdropBackLayer>
    </backdrop:SfBackdropPage.BackLayer>

    <backdrop:SfBackdropPage.FrontLayer>
        <backdrop:BackdropFrontLayer>
            <Grid BackgroundColor="WhiteSmoke" />
        </backdrop:BackdropFrontLayer>
    </backdrop:SfBackdropPage.FrontLayer>
</backdrop:SfBackdropPage>

{% endhighlight %}
{% highlight c# %}

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
    Content = new Grid { BackgroundColor = Colors.WhiteSmoke }
};

{% endhighlight %}
{% endtabs %}

## Apply Liquid Glass Effect to the front layer

You can enable the liquid glass effect for the front layer as well by setting [EnableLiquidGlassEffect]() to true.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="AcrylicBackdropFrontPage"
                         xmlns:backdrop="clr-namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop">

    <backdrop:SfBackdropPage.BackLayer>
        <backdrop:BackdropBackLayer>
            <Grid>
                <Label Text="Menu" HorizontalOptions="Center" VerticalOptions="Center"/>
            </Grid>
        </backdrop:BackdropBackLayer>
    </backdrop:SfBackdropPage.BackLayer>

    <backdrop:SfBackdropPage.FrontLayer>
        <backdrop:BackdropFrontLayer EnableLiquidGlassEffect="True">
            <Grid>
                <!-- Optional: place bright imagery behind the surface to visualize blur -->
                <Image Source="wallpaper.jpg" Aspect="AspectFill" />
                <StackLayout Padding="16">
                    <Label Text="Front layer content" FontSize="16"/>
                </StackLayout>
            </Grid>
        </backdrop:BackdropFrontLayer>
    </backdrop:SfBackdropPage.FrontLayer>
</backdrop:SfBackdropPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Backdrop;

this.BackLayer = new BackdropBackLayer
{
    Content = new Grid
    {
        Children = { new Label { Text = "Menu", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center } }
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
* Liquid Glass effects are most visible over images or colorful backgrounds.
* You can enable the effect independently on either the back layer, the front layer, or both as needed.

## Best Practices and Tips

- The back and front layers use built-in acrylic when their [EnableLiquidGlassEffect]() property is true.
- Place imagery or vibrant backgrounds beneath the layer surface to see the blur clearly.
- Combine with existing layout properties (RevealedHeight, EdgeShape, etc.) to achieve the desired design while using the effect.

The following screenshots illustrate the back and front layers with the liquid glass effect enabled over colorful backgrounds.
