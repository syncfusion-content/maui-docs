---
layout: post
title: Orientation in .NET MAUI Funnel Chart control (Syncfusion)
description: Learn how to change the rendering direction of segments in .NET MAUI Funnel Chart (SfFunnelChart) using the Orientation property.
control: SfFunnelChart
documentation: ug
---

# Orientation in .NET MAUI Funnel Chart

The rendering direction of the funnel chart can be changed using the [Orientation]() property. The default value of this property is Vertical, which arranges segments from top to bottom, and it can be set to Horizontal to render segments from left to right.

{% tabs %}

{% highlight xml %}

<chart:SfFunnelChart Orientation="Horizontal">
. . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.Orientation = Horizontal;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Orientation in MAUI Chart](Orientation_images/MAUI_orientation_chart.png)