---
layout: post
title: Axis labels in .NET MAUI Chart control | Syncfusion
description: Learn here all about axis labels and their customization in the Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis labels in .NET MAUI Chart

Axis labels are used to display the units, measures, or category values of an axis in a user-friendly way. They are generated based on the range and the values bound to the [XBindingPath]() or [YBindingPath]() properties of the series.

## Label Rotation

The [LabelRotation]() property is used to define the angle for the label content.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis LabelRotation="90"/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .

NumericalAxis secondaryAxis = new NumericalAxis()
{
    LabelRotation = 90
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Label customization

The [LabelStyle]() property of the axis provides options to customize the font family, font size, font attributes, and text color of axis labels. The axis labels can be customized using the following properties:

* `Background` - Gets or sets the background color of the labels.
* `CornerRadius` - Gets or sets a value that defines the rounded corners for labels.
* `FontAttributes` - Gets or sets the font style for the label.
* `FontFamily` - Gets or sets the font family name for the label.
* `FontSize` - Gets or sets the font size for the label.
* `Margin` - Gets or sets the margin of the label to customize the appearance of label. 
* `Stroke` - Gets or sets the border stroke color of the labels.
* `StrokeWidth` - Gets or sets the border thickness of the label.
* `TextColor` - Gets or sets the color for the text of the label.
* `LabelFormat` - Gets or sets the label format. This property is used to set numeric or date-time format to the chart axis label.
* `LabelAlignment` - Gets or sets the axis label at start, end, and center positions.

## Edge Labels Drawing Mode

The chart axis provides support for customizing the rendering position of the edge labels using the [EdgeLabelsDrawingMode]() property. The default value of the [EdgeLabelsDrawingMode]() property is `Shift`.

| Action | Description |
|--|--|
| Center | Indicates that the edge label should appear at the center of its GridLines. |
| Fit | Indicates that the edge labels should be fit within the area of SfPolarChart. |
| Hide | Indicates that the edge labels will be hidden |
| Shift | Indicates that edge labels should be shifted to either left or right so that it comes within the area of Chart. |

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:DateTimeAxis EdgeLabelsDrawingMode="Center"/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . . 
DateTimeAxis secondaryAxis = new DateTimeAxis()
{
    EdgeLabelsDrawingMode = EdgeLabelsDrawingMode.Center
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}


## Edge Labels Visibility
 
The visibility of the edge labels of the axis can be controlled using the [EdgeLabelsVisibilityMode]() property. The default value of [EdgeLabelsVisibilityMode]() is `Default`, which displays the edge label based on auto interval calculations.

**Always Visible**

`AlwaysVisible` option in [EdgeLabelsVisibilityMode]() is used to view the edge labels even in chart area zoomed state.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis EdgeLabelsVisibilityMode="AlwaysVisible"/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis()
{
    EdgeLabelsVisibilityMode = EdgeLabelsVisibilityMode.AlwaysVisible
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

**Visible**

`Visible` option is used to display the edge labels irrespective of the auto interval calculation until zooming (i.e., in normal state).

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis EdgeLabelsVisibilityMode="Visible"/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis()
{
    EdgeLabelsVisibilityMode = EdgeLabelsVisibilityMode.Visible
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}