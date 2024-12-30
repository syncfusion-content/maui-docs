---
layout: post
title: Title for axis in .NET MAUI Chart control | Syncfusion®
description: This section explains about chart axis title, title style, title template and its customization in .NET MAUI chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian charts, .net maui axis title, cartesian chart axis title, syncfusion cartesian charts maui, maui chart axis labeling, .net maui chart axis title, cartesian chart axis title guide maui, .net maui sfCartesianChart axis title.
---

# Axis Title in MAUI Chart

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property is used to set the title for the chart axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis>
            <chart:CategoryAxis.Title>
                <chart:ChartAxisTitle Text="Category"/>
            </chart:CategoryAxis.Title>
        </chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis>
            <chart:NumericalAxis.Title>
                <chart:ChartAxisTitle Text="Values"/>
            </chart:NumericalAxis.Title>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis();
primaryAxis.Title = new ChartAxisTitle()
{
    Text = "Category"
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.Title = new ChartAxisTitle()
{
    Text = "Values"
};
chart.YAxes.Add(secondaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Title support for ChartAxis in MAUI Chart](Axis_Images/maui_chart_axis_title.jpg)

## Customization

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property in axis provides options to customize the text and font of axis title. Axis does not display title by default. The title can be customized using following properties,

* `Text` - Gets or sets the title for axis.
* `Background` - Gets or sets the background color of the labels.
* `CornerRadius` - Gets or sets a value that defines the rounded corners for labels.
* `FontAttributes` - Gets or sets the font style for the label.
* `FontFamily` - Gets or sets the font family name for the label.
* `FontSize` - Gets or sets the font size for the label.
* `Margin` - Gets or sets the margin of the label to customize the appearance of label. 
* `Stroke` - Gets or sets the border stroke color of the labels.
* `StrokeWidth` - Gets or sets the border thickness of the label.
* `TextColor` - Gets or sets the color for the text of the label.

## Label extent

The [LabelExtent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelExtent) property allows to set the gap between axis labels and title. This is typically used to maintain the fixed gap between axis labels and title when the digits of the axis value changed in live update.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis LabelExtent="60">
            <chart:CategoryAxis.Title>
                <chart:ChartAxisTitle Text="Category"/>
            </chart:CategoryAxis.Title>
        </chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis();
primaryAxis.LabelExtent = 60;
primaryAxis.Title = new ChartAxisTitle()
{
    Text = "Category"
};
chart.XAxes.Add(primaryAxis);
this.Content = chart;

{% endhighlight %}

{% endtabs %}
