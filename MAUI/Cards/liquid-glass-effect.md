---
layout: post
title: Liquid Glass Support for .NET MAUI Cards | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Card view using the EnableLiquidGlassEffect property.
platform: MAUI
control: SfCardView
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Cards (SfCards)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Cards (SfCards) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Card View:

### Step 1: Enable the liquid glass effect on Card View

Set the `EnableLiquidGlassEffect` property to `true` in the card view to apply the Liquid Glass Effect.

### Step 2: Customize the background

To achieve a glass like background in the card view, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the card view:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`