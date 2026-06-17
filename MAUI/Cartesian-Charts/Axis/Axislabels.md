---
layout: post
title: Axis labels in .NET MAUI Chart control | Syncfusion
description: Learn here all about axis labels and its customization in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart axis labels, axis labels customization .net maui, syncfusion maui chart axis labels, cartesian chart axis labels maui, customize axis labels .net maui chart, .net maui chart labels per 100 pixels.
---

# Axis labels in .NET MAUI Cartesian Chart

Axis labels are used to show the units or measures or category value of axis to visualize the data user friendly. It will be generated based on the range and the values binded to [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) or [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_YBindingPath) properties of series.

## Positioning the labels

The [LabelsPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsPosition) property is used to position the axis labels inside or outside the chart area. [LabelsPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsPosition) property default value is `AxisElementPosition.Outside`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis LabelsPosition="Inside"/>
    </chart:SfCartesianChart.YAxes>
</chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
NumericalAxis secondaryAxis = new NumericalAxis()
{
    LabelsPosition = AxisElementPosition.Inside
};

chart.XAxes.Add(primaryAxis);
chart.YAxes.Add(secondaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis label inside position in .NET MAUI Chart.](axis_images/maui_chart_inside_label.png)

## Label Rotation

The [LabelRotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelRotation) property is used to define the angle for the label content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis LabelRotation="90"/>
    </chart:SfCartesianChart.XAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    LabelRotation = 90
};
chart.XAxes.Add(primaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Label customization

The [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelStyle) property of axis provides options to customize the font-family, font-size, font-attributes and text color of axis labels. The axis labels can be customized using following properties:

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
* `MaxWidth` - Gets or sets the wrap width of the axis labels.
* `WrappedLabelAlignment` - Gets or sets the horizontal rendering position of the wrapped axis labels. The default value is `Start`, other available values are `Center` and `End`.


## Edge Labels Drawing Mode

Chart axis provides support to customize the rendering position of the edge labels using the [EdgeLabelsDrawingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_EdgeLabelsDrawingMode) property. [EdgeLabelsDrawingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_EdgeLabelsDrawingMode) property default value is `Shift`.

| Action | Description |
|--|--|
| Center | Indicates that the edge label should appear at the center of its GridLines. |
| Fit | Indicates that the edge labels should be fit within the area of SfCartesianChart. |
| Hide | Indicates that the edge labels will be hidden |
| Shift | Indicates that edge labels should be shifted to either left or right so that it comes within the area of Chart. |

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis EdgeLabelsDrawingMode="Center"/>
    </chart:SfCartesianChart.XAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . . 
DateTimeAxis primaryAxis = new DateTimeAxis()
{
    EdgeLabelsDrawingMode = EdgeLabelsDrawingMode.Center
};
chart.XAxes.Add(primaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis edge label positioning support in .NET MAUI Chart.](axis_images/maui_chart_axis_edge_labels_drawing.jpg)

## Edge Labels Visibility
 
The visibility of the edge labels of the axis can be controlled using the [EdgeLabelsVisibilityMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_EdgeLabelsVisibilityMode) property. The default value of [EdgeLabelsVisibilityMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_EdgeLabelsVisibilityMode) is `Default`, which displays the edge label based on auto interval calculations.

**Always Visible**

`AlwaysVisible` option in [EdgeLabelsVisibilityMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_EdgeLabelsVisibilityMode) is used to view the edge labels even in chart area zoomed state.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis EdgeLabelsVisibilityMode="AlwaysVisible"/>
    </chart:SfCartesianChart.XAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis()
{
    EdgeLabelsVisibilityMode = EdgeLabelsVisibilityMode.AlwaysVisible
};
chart.XAxes.Add(primaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

**Visible**

`Visible` option is used to display the edge labels irrespective of the auto interval calculation until zooming (i.e., in normal state).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis EdgeLabelsVisibilityMode="Visible"/>
    </chart:SfCartesianChart.XAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis()
{
    EdgeLabelsVisibilityMode = EdgeLabelsVisibilityMode.Visible
};
chart.XAxes.Add(primaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Smart Axis Labels

Axis labels may overlap with each other based on chart dimensions and label size. The [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction) property of axis is used to avoid overlapping of axis labels. The default value of the LabelsIntersectAction is `Hide`, other available values are `MultipleRows`, `None`, and `Wrap`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
       <chart:CategoryAxis LabelsIntersectAction="MultipleRows"/>
    </chart:SfCartesianChart.XAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    LabelsIntersectAction = AxisLabelsIntersectAction.MultipleRows,
};
chart.XAxes.Add(primaryAxis);

this.Content = chart;
 
{% endhighlight %}

{% endtabs %}

![Smart axis lable support in .NET MAUI SfCartesianChart.](axis_images/maui_chart_smart_axis_labels.png)

N> If the [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction) is set to Wrap, we should set the width of the wrap using the [MaxWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_MaxWidth) property. We can align the wrapped axis label using the [WrappedLabelAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_WrappedLabelAlignment) property.

## Maximum Labels

The `MaximumLabels` property in [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) is an integer type property that is used to control the number of axis labels rendered for every 100 pixels of the chart axis. By default, a maximum of `3` labels are displayed per 100 pixels of axis. You can override this behavior by explicitly setting the MaximumLabels property to your desired density.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis MaximumLabels="5" />
        </chart:SfCartesianChart.YAxes>
    . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    NumericalAxis axis = new()
    {
        MaximumLabels = 5,
    };
    chart.YAxes.Add(axis);
    . . .
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Maximum Labels in .NET MAUI SfCartesianChart.](axis_images/maui_chart_axis_maximum_labels.png)

N> `MaximumLabels` only applies during automatic interval calculation. It will have no effect if the `Interval` property is manually set on the axis.

## Event

### AxisLabelTapped

The `AxisLabelTapped` event occurs when a user taps on an axis label. The following properties are included in the event arguments:

* `Axis` - Gets the associated axis where the label was tapped.
* `AxisLabel` - Gets the `ChartAxisLabel` object, which contains details about the tapped label.
* `Position` - Gets the screen coordinates (X, Y) of the tap location in device-independent pixels.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart AxisLabelTapped="OnAxisLabelTapped">

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>

    <chart:ColumnSeries ItemsSource="{Binding Data}"
                        XBindingPath="Category"
                        YBindingPath="Value"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

private void OnAxisLabelTapped(object sender, AxisLabelTappedEventArgs e)
{
    var axis = e.Axis;
    var axisLabel = e.AxisLabel;
    var tapPosition = e.Position;

    string message = $"Label: {axisLabel.Content}\n" +
                     $"Position: {axisLabel.Position:F2}\n" +
                     $"Axis: {axis.GetType().Name}\n" +
                     $"Tap Location: ({tapPosition.X:F0}, {tapPosition.Y:F0})";

    DisplayAlertAsync("Axis Label Details", message, "OK");
}

{% endhighlight %}

{% endtabs %}