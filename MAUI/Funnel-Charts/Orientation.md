---
layout: post
title: Orientation in .NET MAUI Funnel Chart control (Syncfusion)
description: Learn how to change the rendering direction of segments in .NET MAUI Funnel Chart (SfFunnelChart) using the Orientation property.
platform: maui
control: SfFunnelChart
documentation: ug
---

# Orientation in .NET MAUI Funnel Chart

The rendering direction of the funnel chart can be changed using the [Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_Orientation) property. The default value of this property is `Vertical`, which arranges segments from bottom to top. It can be set to `Horizontal` to render segments from right to left.

> **Prerequisite:** For a complete introduction to the Funnel Chart control, see the [getting-started](getting-started.md) topic.

{% tabs %}

{% highlight xml %}

xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"

<chart:SfFunnelChart ItemsSource="{Binding Data}" 
                     XBindingPath="XValue" 
                     YBindingPath="YValue"
                     Orientation="Horizontal">
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Charts;

SfFunnelChart chart = new SfFunnelChart();
AdmissionViewModel viewModel = new AdmissionViewModel();
chart.BindingContext = viewModel;

chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.Orientation = ChartOrientation.Horizontal;

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Orientation in .NET MAUI Funnel Chart](Orientation_images/MAUI_orientation_chart.png)
