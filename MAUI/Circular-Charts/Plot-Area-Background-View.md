---
layout: post
title: Plot Area Background View  in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the Plot Area Backgrund and its features in .NET MAUI Chart (SfCartesianChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Plot Area Background View in .NET MAUI Chart

[SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html?tabs=tabid-1) allows you to add a view to the chart plot area . The [PlotAreaBackGroundView]() will be visible behind the grid line and series.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:SfCircularChart.PlotAreaBackgroundView>
        <Image Source="syncfusion_logo_image.png"/>
    </chart:SfCircularChart.PlotAreaBackgroundView>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
Image image = new Image { Source = "https://help.syncfusion.com/maui/circular-charts/explode_images/maui_exploded_doughnut_chart.png" };
chart.PlotAreaBackgroundView = image;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Plot Area Background View in MAUI chart](Tooltip_images/maui_chart_tooltip_customization.png)

