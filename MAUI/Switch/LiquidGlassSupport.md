---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Switch | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI Switch (SfSwitch) control and more.
platform: MAUI
control: SfSwitch
documentation: ug
---

# Liquid Glass Support for .NET MAUI Switch:

The [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) control supports a glass effect (also called acrylic or glass morphism) when you enable the `EnableLiquidGlassEffect` property. It works best over vibrant images or colorful layouts and enhances the visual depth of your UI. When toggled, the switch provides smooth transitions and clear visual feedback, making interactions feel polished and premium.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the switch render with the standard appearance.

{% tabs %}
{% highlight xaml %}

    <Grid>
        <!-- Background to make the glass effect visible while pressing the switch -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <Switch:SfSwitch EnableLiquidGlassEffect="True" />   
    </Grid>

{% endhighlight %}
{% highlight c# %}

SfSwitch aSwitch = new SfSwitch
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the switch at render time and during user interaction.
- Place the switch over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.

