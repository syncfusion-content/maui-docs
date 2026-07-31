---
layout: post
title: Title for axis in .NET MAUI Polar Chart Control | Syncfusion
description: Learn here all about chart axis title, title style, title template, and its customization in the Syncfusion® .NET MAUI Polar Chart (SfPolarChart).
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis title in .NET MAUI Polar Chart

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property is used to set the title for the chart axis.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfPolarChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/polar-charts/getting-started)** guide.

N> The polar chart supports a title for the secondary axis only.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    <!-- code omitted for brevity -->
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis/>
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis>
            <chart:NumericalAxis.Title>
                <chart:ChartAxisTitle Text = "Values"/>
            </chart:NumericalAxis.Title>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
// code omitted for brevity
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;

NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.Title = new ChartAxisTitle()
{
    Text = "Values"
};
chart.SecondaryAxis = secondaryAxis;

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Customization

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property in axis provides options to customize the text and font of the axis title. The axis does not display the title by default. The title can be customized using the following properties:

* `Text`, of type `string`, specifies the title for the axis.
* `Background`, of type `Brush`, specifies the background color of the title.
* `CornerRadius`, of type `CornerRadius`, defines the rounded corners for the title.
* `FontAttributes`, of type `FontAttributes`, specifies the font style for the title.
* `FontFamily`, of type `string`, specifies the font family name for the title.
* `FontSize`, of type `double`, specifies the font size for the title.
* `Margin`, of type `Thickness`, specifies the margin of the title to customize its appearance.
* `Stroke`, of type `Brush`, specifies the border stroke color of the title.
* `StrokeWidth`, of type `double`, specifies the border thickness of the title.
* `TextColor`, of type `Color`, specifies the color for the text of the title.

## Label extent

The [LabelExtent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelExtent) property allows you to set the gap between axis labels and the title. This is typically used to maintain a fixed gap between axis labels and the title when the digits of the axis value change during live updates. The value is specified in pixels (px).

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    <!-- code omitted for brevity -->
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis LabelExtent = "60">
            <chart:NumericalAxis.Title>
                <chart:ChartAxisTitle Text = "Numeric"/>
            </chart:NumericalAxis.Title>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
// code omitted for brevity
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.LabelExtent = 60;
secondaryAxis.Title = new ChartAxisTitle()
{
    Text = "Numeric"
};
chart.SecondaryAxis = secondaryAxis;

this.Content = chart;

{% endhighlight %}

{% endtabs %}