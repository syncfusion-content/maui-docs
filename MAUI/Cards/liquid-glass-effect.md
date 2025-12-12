---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Cards | Syncfusion®
description: Learn how to enable liquid glass (acrylic/glass morphism) support for the Syncfusion® .NET MAUI Card view using the EnableLiquidGlassEffect property.
platform: MAUI
control: SfCardView
documentation: ug
---

# Liquid Glass Support

The [SfCardView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardView.html) supports a liquid glass effect by setting the [EnableLiquidGlassEffect]() property to true. This enhances visual depth and readability when cards are placed over images or colorful layouts.

## Platform and Version Support

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on macOS 26 and iOS 26 or later.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Apply Liquid Glass Effect to SfCardView

Turn on the liquid glass effect on a card view by setting [EnableLiquidGlassEffect]() to true.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:cards="clr-namespace:Syncfusion.Maui.Cards;assembly=Syncfusion.Maui.Cards"
    x:Class="AcrylicCardsPage">

    <Grid>
        <!-- Background to make acrylic blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <cards:SfCardView
            EnableLiquidGlassEffect="True">
            <VerticalStackLayout Spacing="8">
                <Label Text="Glass Card" FontSize="18" FontAttributes="Bold"/>
                <Label Text="This card uses the built-in liquid glass effect."/>
            </VerticalStackLayout>
        </cards:SfCardView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Cards;

var card = new SfCardView
{
    EnableLiquidGlassEffect = true,
};

card.Content = new VerticalStackLayout
{
    Spacing = 8,
    Children =
    {
        new Label { Text = "Glass Card", FontSize = 18, FontAttributes = FontAttributes.Bold },
        new Label { Text = "This card uses the built-in liquid glass effect." },
    }
};

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.

The following screenshot illustrates [SfCardView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardView.html) with the liquid glass effect enabled over a colorful background.
