---
layout: post
title: Plot Area Background View  in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the Plot Area Backgrund and its features in .NET MAUI Chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Plot Area Background View in .NET MAUI Chart

[SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1) allows you to add a view to the chart plot area . The [PlotAreaBackGroundView]() will be visible behind the grid line and series.

{% tabs %}

{% highlight xaml %}

  <chart:SfCartesianChart>
        <chart:SfCartesianChart.PlotAreaBackgroundView>
            <Image Source="https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png"  />
        </chart:SfCartesianChart.PlotAreaBackgroundView>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
Image image = new Image { Source = "https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png" };
chart.PlotAreaBackgroundView = image;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Plot Area Background View in MAUI chart](Plot-Area-Background-View_images/maui_chart_plot_area_background_view.png)

