---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Chips | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI Chips (SfChip) control and more.
platform: MAUI
control: SfChip
documentation: ug
---


# Liquid glass support

The [Chips](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) provides `liquid glass` (acrylic/glassmorphism) effect that can be enabled directly on the control using the public API [EnableLiquidGlassEffect](). When enabled, each chip surface adopts a frosted, translucent appearance that blends with the content behind it, improving visual depth and readability over images or colorful layouts.

## Availability

1. Supported on .NET 10 or greater.
2. Supported on mac or iOS 26 or greater.
3. On platforms/versions below these requirements, the glass effect is not applied and the chips render with the standard background.

{% tabs %}
{% highlight xaml hl_lines="49 52" %}

XAML example Enable the glass effect on SfChipGroup by setting EnableLiquidGlassEffect to True.

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="ChipGroupGlassPage">

    <Grid>
        <!-- Background to showcase glass effect -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center">
            <Label Text="Filters" FontSize="18" TextColor="White" />

            <core:SfChipGroup
                x:Name="FilterChips"
                EnableLiquidGlassEffect="True">
                <chip:SfChipGroup.Items>
                    <chip:SfChip Text="Extra Small" Background="Blue"/>
                    <chip:SfChip Text="Small" Background="Blue"/>
                    <chip:SfChip Text="Medium" Background="Blue"/>
                    <chip:SfChip Text="Large" Background="Blue"/>
                    <chip:SfChip Text="Extra Large" Background="Blue"/>
                </chip:SfChipGroup.Items>
            </core:SfChipGroup>
        </StackLayout>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="74 77" %}

using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    EnableLiquidGlassEffect = true, // Enables built-in glassy look on chips
};

chipGroup.Items.Add(new SfChip(){Text="Extra Small", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Small", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Medium", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Large", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Extra Large", Background = Colors.Blue });

{% endhighlight %}
{% endtabs %}


The following screenshot illustrates SfChipGroup with the built-in glass effect enabled via EnableLiquidGlassEffect, displayed over a wallpaper background.