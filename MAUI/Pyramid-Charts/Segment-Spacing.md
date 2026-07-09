---
layout: post
title: Segment spacing in .NET MAUI Pyramid Chart control (Syncfusion)
description: Learn how to set the gap between segments in .NET MAUI Pyramid Chart (SfPyramidChart) using the GapRatio property.
platform: maui
control: SfPyramidChart
documentation: ug
---

# Segment spacing in .NET MAUI Pyramid Chart

The gap between each segment in the pyramid chart can be set using the [GapRatio](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_GapRatio) property. The default value of the [GapRatio](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_GapRatio) property is `0`, and its value ranges from `0` to `1`. This ratio represents the spacing relative to the segment height; a value of `0.2` means the gap is 20% of the segment's height.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Pyramid Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/pyramid-charts/getting-started)** guide.

{% tabs %}

{% highlight xml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="XValue" 
                      YBindingPath="YValue"
                      GapRatio="0.2">
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
ViewModel viewModel = new ViewModel();
chart.BindingContext = viewModel;

chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.GapRatio = 0.2;

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Segment spacing in .NET MAUI Pyramid Chart](Segment_Spacing_images/MAUI_spacing_chart.png)
