---
layout: post
title: Plot Area Background View  in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the Plot Area Backgrund and its features in .NET MAUI Chart (SfCartesianChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Plot Area Background View in .NET MAUI Chart

[SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html?tabs=tabid-1) allows you to add any view to the chart plot area . The [PlotAreaBackGroundView]() will be visible behind the grid line and series.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
       <chart:SfCircularChart.PlotAreaBackgroundView>
            <BoxView Color="Aqua"/>
        </chart:SfCircularChart.PlotAreaBackgroundView>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

 SfCircularChart chart = new SfCircularChart();
        BoxView boxview = new BoxView {Color=Colors.Aqua };
        chart.PlotAreaBackgroundView = boxview;
        this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Plot Area Background View in MAUI chart](Plot-Area-Background-View_images/plot_view.png)

