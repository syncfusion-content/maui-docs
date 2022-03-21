---
layout: post
title: Mirror in .NET MAUI Linear Gauge control | Syncfusion
description: Learn how to use the IsMirrored property to mirror the Syncfusion.NET MAUI Linear Gauge (SfLinearGauge) control.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Mirrored in .NET MAUI Linear Gauge (SfLinearGauge)

The [`IsMirrored`]() property in [`SfLinearGauge`]() mirrors all the Gauge elements in the `SfLinearGauge`. The following code sample demonstrates how to set the [`IsMirrored`]() property.

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

The following screenshot provides a comparison for the mirrored and normal Linear Gauge. 

![Mirrored linear gauge comparsion](images/mirrored/mirror_comparison.PNG)