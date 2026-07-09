---
layout: post
title: Orientation in .NET MAUI Pyramid Chart control (Syncfusion)
description: Learn how to change the rendering direction of segments in .NET MAUI Pyramid Chart (SfPyramidChart) using the Orientation property.
platform: maui
control: SfPyramidChart
documentation: ug
---

# Orientation in .NET MAUI Pyramid Chart

The rendering direction of the pyramid chart can be changed using the [Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_Orientation) property. The default value of this property is `Vertical`, which arranges segments from top to bottom. It can be set to `Horizontal` to render segments from right to left.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Pyramid Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/pyramid-charts/getting-started)** guide.

{% tabs %}

{% highlight xml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="XValue" 
                      YBindingPath="YValue"
                      Orientation="Horizontal">
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
ViewModel viewModel = new ViewModel();
chart.BindingContext = viewModel;

chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.Orientation = ChartOrientation.Horizontal;

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Orientation in .NET MAUI Pyramid Chart](Orientation_images/MAUI_orientation_chart.png)