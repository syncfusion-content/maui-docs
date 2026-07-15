---
layout: post
title: Mirroring in .NET MAUI Linear Gauge control | Syncfusion®
description: Learn how to use the IsMirrored property to mirror the Syncfusion® .NET MAUI Linear Gauge (SfLinearGauge) control.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Mirroring in .NET MAUI Linear Gauge (SfLinearGauge)

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Linear Gauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/linear-gauge/getting-started)** guide.

The [`IsMirrored`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored) property in [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1) mirrors all the Linear Gauge elements (scale, labels, ticks, and pointers) in the [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1). This is useful for right-to-left (RTL) layout support. The default value of this property is `false`. The following code sample demonstrates how to set the [`IsMirrored`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored) property.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge IsMirrored="True"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.IsMirrored = true;
		this.Content= gauge;

{% endhighlight %}

{% endtabs %}

![Mirror .NET MAUI Linear Gauge](images/mirrored/mirrored.PNG)

## Comparison of Mirrored and Normal Gauge

The following screenshot provides a comparison of the mirrored and normal Linear Gauge. In the image, the left side shows the normal gauge and the right side shows the mirrored gauge.

![Mirrored .NET MAUI Linear Gauge comparison](images/mirrored/mirror_comparison.PNG)