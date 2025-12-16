---
layout: post
title: Liquid Glass Effect for .NET MAUI Combo Box | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Combo Box (SfComboBox) control.
platform: MAUI
control: SfComboBox
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Combo Box (SfComboBox)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Combo Box (SfComboBox) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Combo Box control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `Combo Box` control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Combo Box

Set the `EnableLiquidGlassEffect` property to `true` in the `SfComboBox` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Combo Box, set the `Background` and `DropDownBackground` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfComboBox` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="9" %}

<Grid BackgroundColor="Transparent">
<Image Source="Wallpaper.png" Aspect="AspectFill">
    <core:SfGlassEffectView EffectType="Regular"
                            CornerRadius="20">
        <ComboBox:SfComboBox x:Name="ComboBox"
                                   Background="Transparent"
                                   ItemsSource="{Binding SocialMedias}"
                                   DropDownBackground="Transparent"
                                   EnableLiquidGlassEffect="True">
        </ComboBox:SfComboBox>
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="26" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Inputs;

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

    ComboBox = new SfComboBox
    {
        Background = Colors.Transparent,
        DropDownBackground = Colors.Transparent,
        EnableLiquidGlassEffect = true
    };

    ComboBox.SetBinding(SfComboBox.ItemsSourceProperty, "SocialMedias");

    glass.Content = ComboBox;
    grid.Children.Add(glass);
    this.Content = grid;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates SfComboBox within an acrylic container, with the dropdown using the glass effect.

![combo box editor with liquid glass support](Images/UICustomization/Combobox_liquidglass.png)

N>
This feature is supported only on .NET 10 along with iOS 26 and macOS 26 