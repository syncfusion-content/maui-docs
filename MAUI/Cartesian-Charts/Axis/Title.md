---
layout: post
title: Title for axis in .NET MAUI Cartesian Chart control | Syncfusion
description: This section explains the chart axis title, title style, and its customization in .NET MAUI Cartesian Chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian charts, .net maui axis title, cartesian chart axis title, syncfusion cartesian charts maui, maui cartesian chart axis labeling, .net maui cartesian chart axis title, cartesian chart axis title guide maui, .net maui sfCartesianChart axis title.
---

# Axis Title in .NET MAUI Cartesian Chart

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property is used to set the title for the chart axis. The axis does not display a title by default.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
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
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

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
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Title support for ChartAxis in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_title.jpg)

## Customization

The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title) property accepts a [ChartAxisTitle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html) object, which provides the following properties to customize the text and font of the axis title:

* [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_Text), of type `string`, sets the title text for the axis.
* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_Background), of type `Brush`, sets the background color of the title.
* [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_CornerRadius), of type `Thickness`, defines the rounded corners for the title.
* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_FontAttributes), of type `FontAttributes`, sets the font style for the title.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_FontFamily), of type `string`, sets the font family name for the title.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_FontSize), of type `double`, sets the font size for the title.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_Margin), of type `Thickness`, sets the margin of the title to customize its appearance.
* [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_Stroke), of type `Brush`, sets the border stroke color of the title.
* [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_StrokeWidth), of type `double`, sets the border thickness of the title.
* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html#Syncfusion_Maui_Charts_ChartAxisTitle_TextColor), of type `Color`, sets the color of the title text.

The following example demonstrates how to customize the appearance of the axis title:

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis>
            <chart:CategoryAxis.Title>
                <chart:ChartAxisTitle Text="Category"
                                      FontAttributes="Bold"
                                      FontSize="16"
                                      TextColor="Blue"/>
            </chart:CategoryAxis.Title>
        </chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
// code omitted for brevity
CategoryAxis primaryAxis = new CategoryAxis();
primaryAxis.Title = new ChartAxisTitle()
{
    Text = "Category",
    FontAttributes = FontAttributes.Bold,
    FontSize = 16,
    TextColor = Colors.Blue
};
chart.XAxes.Add(primaryAxis);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis title customization in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_title_customization.jpg)

## Label extent

The [LabelExtent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelExtent) property, of type `double` and measured in pixels (px), allows you to set the gap between the axis labels and the title. The default value is `0`. This is typically used to maintain a fixed gap between the axis labels and the title when the axis values change during live updates.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis LabelExtent="60">
            <chart:CategoryAxis.Title>
                <chart:ChartAxisTitle Text="Category"/>
            </chart:CategoryAxis.Title>
        </chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis();
primaryAxis.LabelExtent = 60;
primaryAxis.Title = new ChartAxisTitle()
{
    Text = "Category"
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}
