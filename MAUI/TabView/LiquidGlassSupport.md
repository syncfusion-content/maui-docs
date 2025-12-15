---
layout: post
title: Provide Liquid Glass Support for .NET MAUI TabView | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI TabView (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: ug
---

# Liquid Glass Support for .NET MAUI TabView:

The  [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1) provides `liquid glass` (acrylic/glass morphism) effect for its Tab View when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the Tab View  is in active state, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the Tab View's appearance at rest, and works well over images or colorful layouts.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the Tab View  render with the standard appearance.

XAML example The Tab View's glass effect appears only while it is in active state.

{% tabs %}
{% highlight xaml hl_lines="49 52" %}

    <Grid>
        <!-- Background to make the glass effect visible while pressing the Tab View  -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <tabview:SfTabView EnableLiquidGlassEffect="True" />
    </Grid>

{% endhighlight %}
{% highlight c# %}

SfTabView tabView = new SfTabView
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the Tab View  only during active interactions; at rest, the Tab View  uses the standard look.
- Place the Tab View  over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.

N> The glass effect is applied to the Tab View  only while it is in active state.
