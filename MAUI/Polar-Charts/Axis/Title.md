---
layout: post
title: Title for axis in .NET MAUI Chart Control | Syncfusion®
description: Learn here all about chart axis title, title style, title template, and its customization in the Syncfusion® .NET MAUI chart (SfPolarChart).
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis Title in MAUI Chart

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property is used to set the title for the chart axis.

N> Polar chart supports title for secondary axis only.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis/>
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis>
            <chart:NumericalAxis.Title>
                <chart:ChartAxisTitle Text="Values"/>
            </chart:NumericalAxis.Title>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
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

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property in axis provides options to customize the text and font of the axis title. The axis does not display the title by default. The title can be customized using following properties,

* `Text` - Gets or sets the title for axis.
* `Background` - Gets or sets the background color of the labels.
* `CornerRadius` - Gets or sets a value that defines the rounded corners for labels.
* `FontAttributes` - Gets or sets the font style for the label.
* `FontFamily` - Gets or sets the font family name for the label.
* `FontSize` - Gets or sets the font size for the label.
* `Margin` - Gets or sets the margin of the label to customize the appearance of the label. 
* `Stroke` - Gets or sets the border stroke color of the labels.
* `StrokeWidth` - Gets or sets the border thickness of the label.
* `TextColor` - Gets or sets the color for the text of the label.

## Label extent

The [LabelExtent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelExtent) property allows you to set the gap between axis labels and the title. This is typically used to maintain the fixed gap between axis labels and title when the digits of the axis value changed in live update.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis LabelExtent="60">
            <chart:NumericalAxis.Title>
                <chart:ChartAxisTitle Text="Numeric"/>
            </chart:NumericalAxis.Title>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
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