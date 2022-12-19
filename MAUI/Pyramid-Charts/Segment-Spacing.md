---
layout: post
title: Segment spacing in .NET MAUI Chart control Syncfusion
description: Learn here all about segment spacing customization in .NET MAUI Chart (SfPyramidChart), its elements and more.
platform: maui
control: SfPyramidChart
documentation: ug
---

# Segment spacing in .NET MAUI Pyramid Chart

The gap between each segment in the pyramid chart can be set using the [GapRatio]() property. The default value of [GapRatio] property is 0 and its value ranges from 0 to 1.

{% tabs %}

{% highlight xml %}

<chart:SfPyramidChart GapRatio="0.2">
. . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.GapRatio = 0.2;
. . .

{% endhighlight %}

{% endtabs %}

![Segment spacing in MAUI Chart](Segment_Spacing_images/MAUI_spacing_chart.png)
