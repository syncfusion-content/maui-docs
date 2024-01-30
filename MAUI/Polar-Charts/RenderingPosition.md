---
layout: post
title: Polar Axis Angle in .NET MAUI Chart control | Syncfusion
description: Learn here all about the rendering position of the axis in the Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Rendering Position

## Polar Angle

Adjust the rendering position of series on polar chart by leveraging the [StartAngle]() property, offering four degree values: 0, 90, 180, and 270. The default setting for the [StartAngle]() property is [Rotate270]().

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis />
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis PolarAngle="Rotate0"/>
    </chart:SfPolarChart.SecondaryAxis>   

    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}"
					  XBindingPath="Direction"
					  YBindingPath="Tree"/>  

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.PolarAngle = ChartPolarAngle.Rotate0;
chart.SecondaryAxis.Add(secondaryAxis);

PolarAreaSeries series = new PolarAreaSeries()
{
    ItemsSource = new ViewModel().PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Tree",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Polar Axis Angle](Rendering-Position_Images\Polar_Angle.png)