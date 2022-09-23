---
layout: post
title: Plot Area Background View  in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the Plot Area Backgrund and its features in .NET MAUI Chart (SfCircularChart).
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
         <Label Text="Copyright @ 2022 Parker Industries"
                FontSize="18"
                AbsoluteLayout.LayoutBounds="1,1,310,33"
                AbsoluteLayout.LayoutFlags="PositionProportional"
                Opacity="0.4" />
         <Label Text="CONFIDENTIAL"
                Rotation="340"
                FontSize="80"
                FontAttributes="Bold,Italic"
                TextColor="Gray"
                Margin="10,0,0,0"
                AbsoluteLayout.LayoutBounds="0.5,0.5,-1,-1"
                AbsoluteLayout.LayoutFlags="PositionProportional"
                Opacity="0.3" />
    </AbsoluteLayout>
   </chart:SfCircularChart.PlotAreaBackgroundView>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
AbsoluteLayout absoluteLayout = new AbsoluteLayout();
var copyRight = new Label() { Text = "Copyright @ 2022 Parker Industries", FontSize = 18, Opacity = 0.4 };
AbsoluteLayout.SetLayoutBounds(copyRight, new Rect(1, 1, 240, 30));
AbsoluteLayout.SetLayoutFlags(copyRight, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.PositionProportional);
absoluteLayout.Children.Add(copyRight);
var watermark = new Label()
{
   Text = "CONFIDENTIAL",
   Rotation = 340,
   FontSize = 80,
   FontAttributes = FontAttributes.Bold,
   TextColor = Colors.Gray,
   Opacity = 0.3,
};
AbsoluteLayout.SetLayoutBounds(watermark, new Rect(0.5, 0.5, -1, -1));
AbsoluteLayout.SetLayoutFlags(watermark, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.PositionProportional);
absoluteLayout.Children.Add(watermark);
chart.PlotAreaBackgroundView = absoluteLayout;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Watermark in .NET MAUI Charts](Plot-Area-Background-View_images/plot_view.png)

