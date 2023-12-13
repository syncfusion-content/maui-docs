---
layout: post
title: Title for axis in .NET MAUI Chart control | Syncfusion
description: This section explains about chart axis title, title style, title template and its customization in .NET MAUI chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
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
primaryAxis.Title = new ChartAxisTitle();
primaryAxis.Title.Text = "Category";
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.Title = new ChartAxisTitle();
secondaryAxis.Title.Text = "Values";
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![Title support for ChartAxis in MAUI Chart](Axis_Images/maui_chart_axis_title.jpg)

## Customization

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property in axis provides options to customize the text and font of axis title. Axis does not display title by default. The title can be customized using following properties,

* [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_Text) - Gets or sets the title for axis.
* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Background) - Gets or sets the background color of the labels.
* [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_CornerRadius) - Gets or sets a value that defines the rounded corners for labels.
* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_FontAttributes) - Gets or sets the font style for the label.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_FontFamily) - Gets or sets the font family name for the label.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_FontSize) - Gets or sets the font size for the label.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Margin) - Gets or sets the margin of the label to customize the appearance of label. 
* [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Stroke) - Gets or sets the border stroke color of the labels.
* [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_StrokeWidth) - Gets or sets the border thickness of the label.
* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_TextColor) - Gets or sets the color for the text of the label.

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
primaryAxis.Title = new ChartAxisTitle();
primaryAxis.Title.Text = "Category";
chart.XAxes.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}
