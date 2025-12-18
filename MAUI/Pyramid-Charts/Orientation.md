---
layout: post
title: Orientation in .NET MAUI Pyramid Chart control (Syncfusion)
description: Learn how to change the rendering direction of segments in .NET MAUI Pyramid Chart (SfPyramidChart) using the Orientation property.
control: SfPyramidChart
documentation: ug
---

# Orientation in .NET MAUI Pyramid Chart

The rendering direction of the pyramid chart can be changed using the [Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_Orientation) property. The default value of this property is Vertical, which arranges segments from top to bottom, and it can be set to Horizontal to render segments from right to left.

{% tabs %}

{% highlight xml %}

<chart:SfPyramidChart Orientation="Horizontal">
. . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.Orientation = Horizontal;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Orientation in MAUI Chart](Orientation_images/MAUI_orientation_chart.png)