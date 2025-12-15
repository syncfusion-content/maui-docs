---
layout: post
title: Liquid Glass Support for .NET MAUI Time Picker | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Time Picker using SfGlassEffectsView.
platform: MAUI
control: SfTimePicker
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Time Picker (SfTimePicker)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Time Picker (SfTimePicker) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Time Picker control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `Time Picker` control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Time Picker

Set the `EnableLiquidGlassEffect` property to `true` in the `SfTimePicker` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Time Picker, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfTimePicker` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 16 20" %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
