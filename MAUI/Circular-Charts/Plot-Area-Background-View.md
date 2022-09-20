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

## Plot Area Customization:
You can customize the plot area using the following:
* BoxView - Use a BoxView as a Background if the plot area is expected to be coloured.
* Image - Readability would be a problem if you planned to display your own company logo at the plot area. In that situation, an image may be utilised as the background.
* Label—you can add any text to the plot area background.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
<chart:SfCircularChart.PlotAreaBackgroundView>
    <AbsoluteLayout>
       <Label Text="Copyright @ 2022 Parker Industries"
                    AbsoluteLayout.LayoutBounds="1,1,240,30"
                    AbsoluteLayout.LayoutFlags="PositionProportional"/>

       <Image Source="https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png"
                     AbsoluteLayout.LayoutBounds="0,1,300,35"
                     AbsoluteLayout.LayoutFlags="PositionProportional" />
    </AbsoluteLayout>
</chart:SfCircularChart.PlotAreaBackgroundView>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
AbsoluteLayout absoluteLayout = new AbsoluteLayout();
var label = new Label() { Text = "Copyright @ 2022 Parker Industries" };
AbsoluteLayout.SetLayoutBounds(label, new Rect(1, 1, 240, 30));
AbsoluteLayout.SetLayoutFlags(label, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.PositionProportional);
absoluteLayout.Children.Add(label);
var image = new Image() { Source = "https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png" };
AbsoluteLayout.SetLayoutBounds(image, new Rect(0, 1, 100, 49));
AbsoluteLayout.SetLayoutFlags(image, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.
        PositionProportional);
absoluteLayout.Children.Add(image);
chart.PlotAreaBackgroundView = absoluteLayout;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Plot Area Background View in MAUI chart](Plot-Area-Background-View_images/plot_view.png)

