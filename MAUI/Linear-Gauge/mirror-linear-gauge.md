---
layout: post
title: Mirror in .NET MAUI Linear Gauge Control | Syncfusion<sup>&reg;</sup>
description: Learn how to use the IsMirrored property to mirror the Syncfusion<sup>&reg;</sup> .NET MAUI Linear Gauge (SfLinearGauge) control.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Mirror in .NET MAUI Linear Gauge (SfLinearGauge)

The [`IsMirrored`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored) property in [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1) mirrors all the Gauge elements in the [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1). The following code sample demonstrates how to set the [`IsMirrored`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored) property.

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

![Mirror linear gauge](images/mirrored/mirrored.PNG)

## Comparison for the mirrored and normal gauge

The following screenshot shows a comparison between the mirrored and normal Linear Gauge. 

![Mirrored linear gauge comparison](images/mirrored/mirror_comparison.PNG)