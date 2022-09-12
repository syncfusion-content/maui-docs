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
        <Image Source="syncfusion_logo_image.png" HeightRequest="300" WidthRequest="300" HorizontalOptions="Center" VerticalOptions="Center" Opacity="0.8"/>
    </chart:SfCartesianChart.PlotAreaBackgroundView>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
ViewModel viewModel = new ViewModel();
chart.BindingContext = viewModel;      	 
Image image = new Image()
{
    Source = ImageSource.FromFile("syncfusion_logo_image.png"),
    HeightRequest = 300,
    WidthRequest = 300,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
};  
chart.PlotAreaBackgroundView = image;
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Plot Area Background View in MAUI chart](PlotAreabackgroundView_images/maui_charts_plot_area_background_view.png)

