---
layout: post
title: Crosshair in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable crosshair and its customization in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart crosshair, maui chart crosshair, .net maui crosshair customization, syncfusion maui crosshair chart, cartesian crosshair maui, .net maui crosshair visualization.
---

# Crosshair in .NET MAUI Chart

Crosshair allows you to view exact values on the chart by showing vertical and horizontal lines at the interaction point. These lines help you read the corresponding axis values clearly. On mobile, long‑press the chart to show the crosshair and drag to change its position. On desktop, move the cursor over the chart area to display the crosshair.

## Enable Crosshair 

To enable the crosshair in the chart, create an instance of the `ChartCrossHairBehavior` and set it to the `CrossHairBehavior` property of `SfCartesianChart`.


{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:SfCartesianChart.CrossHairBehavior>
        <chart:ChartCrossHairBehavior/>
    </chart:SfCartesianChart.CrossHairBehavior>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
ChartCrossHairBehavior crosshair = new ChartCrossHairBehavior();
chart.CrossHairBehavior = crosshair;
...
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Show Crosshair axis labels

To view the axis labels then set the `ShowTrackballLabel` property to true as shown in the below code snippet. The default value of the `ChartAxis.ShowTrackballLabel` is False.


{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:SfCartesianChart.CrossHairBehavior>
        <chart:ChartCrossHairBehavior/>
    </chart:SfCartesianChart.CrossHairBehavior> 
   
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis ShowTrackballLabel="True"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis ShowTrackballLabel="True"/>
    </chart:SfCartesianChart.YAxes>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
ChartCrossHairBehavior crosshair = new ChartCrossHairBehavior();
chart.CrossHairBehavior = crosshair;

CategoryAxis chartAxis = new CategoryAxis()
{
  chartAxis.ShowTrackballLabel = true
}

NumericalAxis chartAxis = new NumericalAxis()
{
  chartAxis.ShowTrackballLabel = true
}
...
this.Content = chart;

{% endhighlight %}

{% endtabs %}


## Vertical and Horizontal Line Customization

When you add the `ChartCrossHairBehavior` to a chart, horizontal and vertical lines appear. These lines can be customized individually using the `HorizontalLineStyle` and `VerticalLineStyle` properties.

The appearance of the track line in crosshair can be customized using the following properties.

* `StrokeWidth`, of type `double`, used to change the stroke width of the line.
* `Stroke`, of type `Brush`, used to change the stroke color of the line.
* `StrokeDashArray`, of type `DoubleCollection`, specifies the dashes to be applied on the line.

### HorizontalLineStyle


{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.CrossHairBehavior>
        <chart:ChartCrossHairBehavior>
            <chart:ChartCrossHairBehavior.HorizontalLineStyle>
                 <chart:ChartLineStyle 
                    Stroke="Red" 
                    StrokeWidth="1.5",
                    StrokeDashArray="2,2"/>
            </chart:ChartCrossHairBehavior.HorizontalLineStyle>
        </chart:ChartCrossHairBehavior>
    </chart:SfCartesianChart.CrossHairBehavior>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
ChartCrossHairBehavior crosshair = new ChartCrossHairBehavior();
chart.CrossHairBehavior = crosshair;

ChartLineStyle horizontalLineStyle = new ChartLineStyle()
{
    Stroke = "Red",
    StrokeWidth = 1.5,
    StrokeDashArray = "2,2"
};
crosshair.HorizontalLineStyle = horizontalLineStyle;
...
this.Content = chart;

{% endhighlight %}

{% endtabs %}

### VerticalLineStyle


{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.CrossHairBehavior>
        <chart:ChartCrossHairBehavior>
            <chart:ChartCrossHairBehavior.VerticalLineStyle>
                 <chart:ChartLineStyle 
                    Stroke="Blue" 
                    StrokeWidth="2"
                    StrokeDashArray="5,3"/>
            </chart:ChartCrossHairBehavior.VerticalLineStyle>
        </chart:ChartCrossHairBehavior>
    </chart:SfCartesianChart.CrossHairBehavior>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
ChartCrossHairBehavior crosshair = new ChartCrossHairBehavior();
chart.CrossHairBehavior = crosshair;

ChartLineStyle verticalLineStyle = new ChartLineStyle()
{
    Stroke = "Blue",
    StrokeWidth = 2,
    StrokeDashArray = "5,3"
};
crosshair.VerticalLineStyle = verticalLineStyle;
...
this.Content = chart;

{% endhighlight %}

{% endtabs %}


## Crosshair Axis Labels Customization

The `LabelStyle` property allows you to customize the appearance of crosshair axis labels. These options are:

* `Background`, of type `Brush`, used to change the label background color.
* `Margin`, of type `Thickness`, used to change the margin of the label.
* `TextColor`, of type `Color`, used to change the text color.
* `StrokeWidth`, of type `double`, used to change the stroke thickness of the label.
* `Stroke`, of type `Brush`, used to customize the border of the label.
* `LabelFormat`, of type `string`, used to change the format of the label.
* `FontFamily`, of type `string`, used to change the font family for the trackball label.
* `FontAttributes`, of type `FontAttributes`, used to change the font style for the trackball label.
* `FontSize`, of type `double`, used to change the font size for the trackball label.
* `CornerRadius`, of type `CornerRadius`, used to set the rounded corners for labels.


{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:CategoryAxis.TrackballLabelStyle>
        <chart:ChartAxisLabelStyle Background="LightBlue"   
                               FontSize="15" 
                               CornerRadius="5"
                               StrokeWidth="2" 
                               Stroke="Gray"/>
    </chart:CategoryAxis.TrackballLabelStyle>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ChartCrossHairBehavior crosshair = new ChartCrossHairBehavior();
chart.CrossHairBehavior = crosshair;

ChartAxisLabelStyle axisLabelStyle = new ChartAxisLabelStyle()
{
    Background = Colors.LightBlue,
    FontSize = 15,
    CornerRadius = 5,
    StrokeWidth = 2,
    Stroke = Colors.Gray
};
trackball.ChartAxisLabelStyle = axisLabelStyle;
. . .
this.Content = chart;

{% endhighlight %}

{% endtabs %}