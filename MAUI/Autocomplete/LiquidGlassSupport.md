---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Autocomplete entry | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI Autocomplete (SfAutocomplete) control and more.
platform: MAUI
control: SfAutocomplete
documentation: ug
---

# Liquid glass support

The [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) supports a liquid `glass` (acrylic/glassmorphism) appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when SfAutocomplete is placed over images or colorful layouts. Additionally, the dropdown portion of SfAutocomplete applies the glass effect only when the [EnableLiquidGlassEffect]() property is set to true.

## Availability

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on mac or iOS 26 or greater.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

- Add the Syncfusion.Maui.Core package (for SfGlassEffectsView) and Syncfusion.Maui.Inputs (for SfAutocomplete).

XAML example Wrap the SfAutocomplete in an SfGlassEffectsView, then enable the dropdown’s glass effect with `EnableLiquidGlassEffect`.

{% tabs %}
{% highlight xaml hl_lines="49 52" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:inputs="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicAutocompleteBoxPage">

    <Grid>
        <!-- Background to make acrylic blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
            <core:SfGlassEffectsView
                CornerRadius="20"
                HeightRequest="40"
                EffectType="Regular"
                EnableShadowEffect="True">

                <inputs:SfAutocomplete
                    EnableLiquidGlassEffect="True"
                    ItemsSource="{Binding Employees}"
                    DisplayMemberPath="Name"
                    DropDownBackground="Transparent"
                    Placeholder="Select employee"/>
            </core:SfGlassEffectsView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="74 77" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Inputs;

var glassEffects = new SfGlassEffectsView
{
    CornerRadius=20,
    HeightRequest=40,
    EffectType=LiquidGlassEffectType.Regular,
    EnableShadowEffect=True
};

var Autocomplete = new SfAutocomplete
{
    EnableLiquidGlassEffect = true, // Dropdown glass effect
    ItemsSource = viewModel.Employees,
    DisplayMemberPath = "Name",
    DropDownBackground= Colors.Transparent,
    Placeholder = "Select employee",
};

glassEffects.Content = Autocomplete;

{% endhighlight %}
{% endtabs %}

## Key properties

- EffectType: Has two types Regular(Blurry) effect and Clear(Glassy) effect.
- EnableShadowEffect: To enable the shadow around the acrylic container
- CornerRadius: Rounds the corners of the acrylic container.
- Padding/Height/Width: Adjust layout around the embedded SfAutocomplete.

## Behavior and tips

- The entry surface inherits the acrylic effect from the surrounding `SfGlassEffectsView`.
- The dropdown gains the glass effect only when `EnableLiquidGlassEffect` is true.
- Acrylic effects are most visible over images or colorful backgrounds.

The following screenshot illustrates SfAutocomplete within an acrylic container, with the dropdown using the glass effect.