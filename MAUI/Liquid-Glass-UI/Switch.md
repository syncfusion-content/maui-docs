---
layout: post
title: Provide Liquid Glass Support for .NET MAUI Switch | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI Switch (SfSwitch) control and more.
platform: MAUI
control: SfSwitch
documentation: ug
---


# Liquid glass support:

The  [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) provides `liquid glass` (acrylic/glassmorphism) effect for its switch when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the switch is in active state, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the switch’s appearance at rest, and works well over images or colorful layouts.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the switch render with the standard appearance.

XAML example The switch’s glass effect appears only while it is in active state.

{% tabs %}
{% highlight xaml hl_lines="49 52" %}


    <Grid>
        <!-- Background to make the glass effect visible while pressing the switch -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <Switch:SfSwitch
                EnableLiquidGlassEffect="True" />
     
    </Grid>


{% endhighlight %}
{% highlight c# hl_lines="74 77" %}

using Syncfusion.Maui.Sliders;

SfSwitch aSwitch = new SfSwitch
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the switch only during active interactions; at rest, the switch uses the standard look.
- Place the switch over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.

The following screenshot illustrates SfSwitch with the glass effect visible on the switch while it is in active state.

N> The glass effect is applied to the switch only while it is in active state.
