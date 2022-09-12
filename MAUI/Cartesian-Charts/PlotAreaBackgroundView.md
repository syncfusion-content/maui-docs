---
layout: post
title: Plot Area Background View  in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the Plot Area Backgrund and its features in .NET MAUI Chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Plot Area Background View in .NET MAUI Chart

[PlotAreaBackgroundView] used to add a view in the chart plot area . The [PlotAreaBackgroundView] will be visible behind the grid line and series.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:SfCircularChart.BindingContext>
        <local:ViewModel/>
    </chart:SfCircularChart.BindingContext>
    <chart:SfCartesianChart.PlotAreaBackgroundView>
        <BoxView Color="Aqua" Margin = "10" CornerRadius = "5" />
    </chart:SfCartesianChart.PlotAreaBackgroundView>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
ViewModel viewModel = new ViewModel();
chart.BindingContext = viewModel;      	 
BoxView boxView = new BoxView()
{
    Color = Colors.Aqua,
    Margin = 10,
    CornerRadius = 5,
};  
chart.PlotAreaBackgroundView = boxView
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

