---
layout: post
title: Plot Area Background View  in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the Plot Area Backgrund and its features in .NET MAUI Chart (SfCartesianChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Plot Area Background View in .NET MAUI Chart

[SfCircularChart ](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html?tabs=tabid-1) allows you to add any view to the chart plot area. The [PlotAreaBackgroundView]() will be visible behind the grid line and series.

## Plot Area Customization:
You can customize the plot area using the following:
* Box View - Use a BoxView as a Background if the plot area is expected to be colored.
* Image - Readability would be a problem if you planned to display your own company logo in the plot area. In that situation, an image may be utilized as the background.
* Label—you can add any text to the plot area background.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
<chart:SfCircularChart.PlotAreaBackgroundView>
    <AbsoluteLayout>
      <Border Stroke="Black" StrokeThickness="2"
              AbsoluteLayout.LayoutBounds="0,0,1,1"
              AbsoluteLayout.LayoutFlags="All"/>
       <Label Text="Copyright @ 2022 Parker Industries"
                    AbsoluteLayout.LayoutBounds="1,1,240,30"
                    AbsoluteLayout.LayoutFlags="PositionProportional"/>
       <Label Text="Confidential" TextColor="Red"
                       AbsoluteLayout.LayoutBounds="0,1,100,29"
                       AbsoluteLayout.LayoutFlags="PositionProportional"/>
    </AbsoluteLayout>
</chart:SfCircularChart.PlotAreaBackgroundView>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
AbsoluteLayout absoluteLayout = new AbsoluteLayout();
var border = new Border() { Stroke = Colors.Black,StrokeThickness = 2 };
AbsoluteLayout.SetLayoutBounds(border, new Rect(0, 0, 1, 1));
AbsoluteLayout.SetLayoutFlags(border, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.All);
absoluteLayout.Children.Add(border);
var copyRight = new Label() { Text = "Copyright @ 2022 Parker Industries" };
AbsoluteLayout.SetLayoutBounds(copyRight, new Rect(1, 1, 240, 30));
AbsoluteLayout.SetLayoutFlags(copyRight, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.
PositionProportional);
absoluteLayout.Children.Add(copyRight);
var watermark = new Label() { Text = "Confidential" };
AbsoluteLayout.SetLayoutBounds(watermark, new Rect(0, 1, 100, 29));
AbsoluteLayout.SetLayoutFlags(watermark, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.
PositionProportional);
absoluteLayout.Children.Add(watermark);
chart.PlotAreaBackgroundView = absoluteLayout;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Plot Area Background View in MAUI chart](Plot-Area-Background-View_images/plot_view.png)

