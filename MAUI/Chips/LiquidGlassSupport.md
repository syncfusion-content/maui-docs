---
layout: post
title: Liquid Glass Effect for .NET MAUI Chips | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Chips (SfChip) control.
platform: MAUI
control: SfChip
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Chips (SfChip)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Chips (SfChip) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Chips control:

### Step 1: Enable the liquid glass effect on Chips

Set the `EnableLiquidGlassEffect` property to `true` in the `SfChip` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Chips, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfChip` control:
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}
    <Grid>
        <StackLayout Padding="24" Spacing="16" VerticalOptions="Center">
            <Label Text="Filters" FontSize="18" TextColor="White" />
            <core:SfChipGroup
                x:Name="FilterChips"
                EnableLiquidGlassEffect="True">
                <chip:SfChipGroup.Items>
                    <chip:SfChip Text="Extra Small"/>
                    <chip:SfChip Text="Small" />
                    <chip:SfChip Text="Medium" />
                    <chip:SfChip Text="Large"/>
                    <chip:SfChip Text="Extra Large"/>
                </chip:SfChipGroup.Items>
            </core:SfChipGroup>
        </StackLayout>
    </Grid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}

using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    EnableLiquidGlassEffect = true, // Enables built-in glassy look on chips
};

chipGroup.Items.Add(new SfChip(){Text="Extra Small"});
chipGroup.Items.Add(new SfChip(){Text="Small"});
chipGroup.Items.Add(new SfChip(){Text="Medium"});
chipGroup.Items.Add(new SfChip(){Text="Large"});
chipGroup.Items.Add(new SfChip(){Text="Extra Large" });

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`