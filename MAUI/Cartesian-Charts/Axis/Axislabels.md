---
layout: post
title: Axis Labels in .NET MAUI Cartesian Chart | Syncfusion®
description: Axis Labels in .NET MAUI Cartesian Chart display category and value information along chart axes, improving readability and data interpretation.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart axis labels, axis labels customization .net maui, syncfusion maui chart axis labels, cartesian chart axis labels maui, customize axis labels .net maui chart, .net maui chart labels per 100 pixels.
---

# Axis Labels in .NET MAUI Cartesian Chart

Axis labels display the units, measures, or category values of an axis to help users understand the data. They are generated based on the range and the values bound to [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) or [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_YBindingPath) properties of the series.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Cartesian Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

## Positioning the labels

The [LabelsPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsPosition) property is used to position the axis labels inside or outside the chart area. The [AxisElementPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisElementPosition.html) enum provides the following values:

- `Inside` — Positions labels inside the chart area.
- `Outside` (default) — Positions labels outside the chart area.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis LabelsPosition="Inside"/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
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
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis label inside position in .NET MAUI Cartesian Chart.](axis_images/maui_chart_inside_label.png)

## Label rotation

The [LabelRotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelRotation) property defines the rotation angle in degrees for the axis label content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis LabelRotation="90"/>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis()
{
    LabelRotation = 90
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Label customization

The [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelStyle) property of the [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) class provides options to customize axis labels. The [ChartAxisLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html) class provides the following customization properties:

**Appearance**

* `Background` — Sets the background color of the labels.
* `Stroke` — Sets the border stroke color of the labels.
* `StrokeWidth` — Sets the border thickness of the label.
* `CornerRadius` — Defines the rounded corners for labels.
* `Margin` — Sets the margin of the label.

**Text Styling**

* `FontAttributes` — Sets the font style (Bold, Italic, None) for the label.
* `FontFamily` — Sets the font family name for the label.
* `FontSize` — Sets the font size for the label.
* `TextColor` — Sets the color for the label text.

**Formatting and Alignment**

* `LabelFormat` — Sets numeric or date-time format for the axis label.
* `LabelAlignment` — Aligns labels at start, end, or center positions.
* `MaxWidth` — Sets the wrap width of the axis labels.
* `WrappedLabelAlignment` — Sets the horizontal rendering position of wrapped labels. Default is `Start`; other values are `Center` and `End`.


## Edge labels drawing mode

The [EdgeLabelsDrawingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_EdgeLabelsDrawingMode) property customizes the rendering position of edge labels. The [EdgeLabelsDrawingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EdgeLabelsDrawingMode.html) enum provides the following values (default is `Shift`):

| Mode | Description |
|--|--|
| Center | Edge label appears at the center of its grid lines. |
| Fit | Edge labels are fitted within the chart area. |
| Hide | Edge labels are hidden. |
| Shift | Edge labels are shifted left or right to fit within the chart area. |

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis EdgeLabelsDrawingMode="Center"/>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis()
{
    EdgeLabelsDrawingMode = EdgeLabelsDrawingMode.Center
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis edge label positioning support in .NET MAUI Cartesian Chart.](axis_images/maui_chart_axis_edge_labels_drawing.jpg)

## Edge labels visibility

The [EdgeLabelsVisibilityMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_EdgeLabelsVisibilityMode) property controls the visibility of edge labels. The [EdgeLabelsVisibilityMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EdgeLabelsVisibilityMode.html) enum provides the following values:

- `Default` (default) — Displays edge labels based on auto interval calculations.
- `AlwaysVisible` — Shows edge labels even when the chart is zoomed.
- `Visible` — Displays edge labels in normal state until zooming occurs.

### Always visible

Use `AlwaysVisible` to show edge labels even when the chart area is zoomed:

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis EdgeLabelsVisibilityMode="AlwaysVisible"/>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis()
{
    EdgeLabelsVisibilityMode = EdgeLabelsVisibilityMode.AlwaysVisible
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Visible

Use `Visible` to display edge labels regardless of auto interval calculation, but only until zooming:

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis EdgeLabelsVisibilityMode="Visible"/>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis()
{
    EdgeLabelsVisibilityMode = EdgeLabelsVisibilityMode.Visible
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Smart axis labels

Axis labels may overlap based on chart dimensions and label size. The [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction) property prevents overlapping. The [AxisLabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelsIntersectAction.html) enum provides the following values (default is `Hide`):

- `Hide` — Hides overlapping labels.
- `MultipleRows` — Arranges overlapping labels in multiple rows.
- `None` — Displays all labels without any action.
- `Wrap` — Wraps label text to fit within specified width (requires [MaxWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_MaxWidth) property). Alignment can be controlled using [WrappedLabelAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_WrappedLabelAlignment) property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis LabelsIntersectAction="MultipleRows"/>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis()
{
    LabelsIntersectAction = AxisLabelsIntersectAction.MultipleRows
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Smart axis label support in .NET MAUI Cartesian Chart.](axis_images/maui_chart_smart_axis_labels.png)

## Maximum labels

The [MaximumLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MaximumLabels) property in [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) controls the number of axis labels rendered per 100 pixels of axis. By default, 3 labels are displayed per 100 pixels. Set this property to override the default density.

N> `MaximumLabels` only applies during automatic interval calculation and has no effect if the `Interval` property is manually set on the axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis MaximumLabels="5"/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis axis = new()
{
    MaximumLabels = 5
};
chart.YAxes.Add(axis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Maximum labels in .NET MAUI Cartesian Chart.](axis_images/maui_chart_axis_maximum_labels.png)

## Multi-Level Labels

Multi-level labels allow you to display multiple hierarchy levels of labels on the chart axes. This feature is particularly useful for categorizing data at different levels of detail, providing better organization and readability of large datasets. Multi-level labels can be applied to any [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) in the Cartesian chart.

### Creating Multi-Level Labels

Multi-level labels can be added to any axis in the .NET MAUI Cartesian Chart, such as [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html), [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html), [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html), [DateTimeCategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html), or [LogarithmicAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html).

To add multi-level labels to an axis, use the [MultiLevelLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MultiLevelLabels) collection of the axis. Each multi-level label is defined using the following properties, of the [ChartMultiLevelLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelLabel.html) class:

* [Start](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelLabel.html#Syncfusion_Maui_Charts_MultiLevelLabel_Start), of type `object`, sets the starting value of the label range.
* [End](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelLabel.html#Syncfusion_Maui_Charts_MultiLevelLabel_End), of type `object`, sets the ending value of the label range.
* [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelLabel.html#Syncfusion_Maui_Charts_MultiLevelLabel_Text), of type `string`, sets the text displayed for the label.
* [Level](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelLabel.html#Syncfusion_Maui_Charts_MultiLevelLabel_Level), of type `int`, sets the hierarchy level (for example, 1 for the top level, 2 for sub-levels, and so on).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis>
            <chart:NumericalAxis.MultiLevelLabels>
                <chart:ChartMultiLevelLabel Start="0" End="79" Text="Low" Level="1"/>
                <chart:ChartMultiLevelLabel Start="80" End="149" Text="Medium" Level="1"/>
                <chart:ChartMultiLevelLabel Start="150" End="220" Text="High" Level="1"/>
                <chart:ChartMultiLevelLabel Start="0" End="39" Text="0-39" Level="2"/>
                <chart:ChartMultiLevelLabel Start="40" End="79" Text="40-79" Level="2"/>
                <chart:ChartMultiLevelLabel Start="80" End="114" Text="80-114" Level="2"/>
                <chart:ChartMultiLevelLabel Start="115" End="149" Text="115-149" Level="2"/>
                <chart:ChartMultiLevelLabel Start="150" End="184" Text="150-184" Level="2"/>
                <chart:ChartMultiLevelLabel Start="185" End="220" Text="185-220" Level="2"/>
            </chart:NumericalAxis.MultiLevelLabels>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
// code omitted for brevity
NumericalAxis secondaryAxis = new NumericalAxis();

// Create first level multi-level labels
ChartMultiLevelLabel label1 = new ChartMultiLevelLabel() 
{ 
    Start = 0, 
    End = 79, 
    Text = "Low", 
    Level = 1 
};
secondaryAxis.MultiLevelLabels.Add(label1);

ChartMultiLevelLabel label2 = new ChartMultiLevelLabel() 
{ 
    Start = 80, 
    End = 149, 
    Text = "Medium", 
    Level = 1 
};
secondaryAxis.MultiLevelLabels.Add(label2);

ChartMultiLevelLabel label3 = new ChartMultiLevelLabel() 
{ 
    Start = 150, 
    End = 220, 
    Text = "High", 
    Level = 1 
};
secondaryAxis.MultiLevelLabels.Add(label3);

// Create second level multi-level labels
ChartMultiLevelLabel label4 = new ChartMultiLevelLabel() 
{ 
    Start = 0, 
    End = 39, 
    Text = "0-39", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label4);

ChartMultiLevelLabel label5 = new ChartMultiLevelLabel() 
{ 
    Start = 40, 
    End = 79, 
    Text = "40-79", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label5);

ChartMultiLevelLabel label6 = new ChartMultiLevelLabel() 
{ 
    Start = 80, 
    End = 114, 
    Text = "80-114", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label6);

ChartMultiLevelLabel label7 = new ChartMultiLevelLabel() 
{ 
    Start = 115, 
    End = 149, 
    Text = "115-149", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label7);

ChartMultiLevelLabel label8 = new ChartMultiLevelLabel() 
{ 
    Start = 150, 
    End = 184, 
    Text = "150-184", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label8);

ChartMultiLevelLabel label9 = new ChartMultiLevelLabel() 
{ 
    Start = 185, 
    End = 220, 
    Text = "185-220", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label9);

chart.YAxes.Add(secondaryAxis);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Multi-level labels on NumericalAxis in .NET MAUI Cartesian Chart.](axis_images/multi_level_labels_numerical_axis.png)

### Customizing Label Appearance

The appearance of multi-level labels can be customized using the [MultiLevelLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MultiLevelLabelStyle) property. The [MultiLevelLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html) provides the following customization properties:

* [BorderType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html#Syncfusion_Maui_Charts_MultiLevelLabelStyle_BorderType), of type `ChartMultiLevelBorderType`, sets the border type for multi-level labels.
* [BorderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html#Syncfusion_Maui_Charts_MultiLevelLabelStyle_BorderColor), of type `Color`, sets the border color.
* [BorderWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html#Syncfusion_Maui_Charts_MultiLevelLabelStyle_BorderWidth), of type `double`, sets the border width.
* [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html#Syncfusion_Maui_Charts_MultiLevelLabelStyle_LabelStyle), of type `ChartAxisLabelStyle`, sets the text styling for the multi-level label.

### Label Style

The [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html#Syncfusion_Maui_Charts_MultiLevelLabelStyle_LabelStyle) property supports the following [ChartAxisLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html) customization options:

* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_FontAttributes), of type `FontAttributes`, sets the font style for the label text.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_FontSize), of type `double`, sets the size of the label text.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_Margin), of type `Thickness`, sets the space around the label text.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_FontFamily), of type `string`, sets the font family for the label text.
* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_TextColor), of type `Color`, sets the color of the label text.
* [LabelAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_LabelAlignment), of type `ChartAxisLabelAlignment`, sets the alignment of the label text within the label area.

### Border Type

The [BorderType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html#Syncfusion_Maui_Charts_MultiLevelLabelStyle_BorderType) property supports the following [ChartMultiLevelBorderType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelBorderType.html) values:

* [Rectangle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelBorderType.html#Syncfusion_Maui_Charts_ChartMultiLevelBorderType_Rectangle) - Displays the label with a rectangular border on all sides.
* [WithoutTopAndBottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelBorderType.html#Syncfusion_Maui_Charts_ChartMultiLevelBorderType_WithoutTopAndBottom) - Displays the label with a border on left and right sides only (no top and bottom).
* [SquareBrace](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelBorderType.html#Syncfusion_Maui_Charts_ChartMultiLevelBorderType_SquareBrace) - Displays the label with a square brace border style.
* [CurlyBrace](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelBorderType.html#Syncfusion_Maui_Charts_ChartMultiLevelBorderType_CurlyBrace) - Displays the label with a curly brace border style.

The default value is `Rectangle`.

The following example demonstrates how to apply a square brace border style and label style:

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis>
            <chart:NumericalAxis.MultiLevelLabels>
                <chart:ChartMultiLevelLabel Start="0" End="79" Text="Low" Level="1"/>
                <chart:ChartMultiLevelLabel Start="80" End="149" Text="Medium" Level="1"/>
                <chart:ChartMultiLevelLabel Start="150" End="220" Text="High" Level="1"/>
                <chart:ChartMultiLevelLabel Start="0" End="39" Text="0-39" Level="2"/>
                <chart:ChartMultiLevelLabel Start="40" End="79" Text="40-79" Level="2"/>
                <chart:ChartMultiLevelLabel Start="80" End="114" Text="80-114" Level="2"/>
                <chart:ChartMultiLevelLabel Start="115" End="149" Text="115-149" Level="2"/>
                <chart:ChartMultiLevelLabel Start="150" End="184" Text="150-184" Level="2"/>
                <chart:ChartMultiLevelLabel Start="185" End="220" Text="185-220" Level="2"/>
            </chart:NumericalAxis.MultiLevelLabels>
            <chart:NumericalAxis.MultiLevelLabelStyle>
                <chart:MultiLevelLabelStyle BorderColor="DarkBlue" BorderType="SquareBrace" BorderWidth="2">
                    <chart:MultiLevelLabelStyle.LabelStyle>
                        <chart:ChartAxisLabelStyle TextColor="Green" FontAttributes="Bold" FontSize="13" Stroke="DarkGreen" StrokeWidth="2"/>
                    </chart:MultiLevelLabelStyle.LabelStyle>
                </chart:MultiLevelLabelStyle>
            </chart:NumericalAxis.MultiLevelLabelStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
// code omitted for brevity
NumericalAxis secondaryAxis = new NumericalAxis();

// Create multi-level labels for level 1
ChartMultiLevelLabel label1 = new ChartMultiLevelLabel() 
{ 
    Start = 0, 
    End = 79, 
    Text = "Low", 
    Level = 1 
};
secondaryAxis.MultiLevelLabels.Add(label1);

ChartMultiLevelLabel label2 = new ChartMultiLevelLabel() 
{ 
    Start = 80, 
    End = 149, 
    Text = "Medium", 
    Level = 1 
};
secondaryAxis.MultiLevelLabels.Add(label2);

ChartMultiLevelLabel label3 = new ChartMultiLevelLabel() 
{ 
    Start = 150, 
    End = 220, 
    Text = "High", 
    Level = 1 
};
secondaryAxis.MultiLevelLabels.Add(label3);

// Create multi-level labels for level 2
ChartMultiLevelLabel label4 = new ChartMultiLevelLabel() 
{ 
    Start = 0, 
    End = 39, 
    Text = "0-39", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label4);

ChartMultiLevelLabel label5 = new ChartMultiLevelLabel() 
{ 
    Start = 40, 
    End = 79, 
    Text = "40-79", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label5);

ChartMultiLevelLabel label6 = new ChartMultiLevelLabel() 
{ 
    Start = 80, 
    End = 114, 
    Text = "80-114", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label6);

ChartMultiLevelLabel label7 = new ChartMultiLevelLabel() 
{ 
    Start = 115, 
    End = 149, 
    Text = "115-149", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label7);

ChartMultiLevelLabel label8 = new ChartMultiLevelLabel() 
{ 
    Start = 150, 
    End = 184, 
    Text = "150-184", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label8);

ChartMultiLevelLabel label9 = new ChartMultiLevelLabel() 
{ 
    Start = 185, 
    End = 220, 
    Text = "185-220", 
    Level = 2 
};
secondaryAxis.MultiLevelLabels.Add(label9);

// Customize the appearance with square brace border
ChartAxisLabelStyle labelStyle = new ChartAxisLabelStyle()
{
    TextColor = Colors.Green,
    FontAttributes = FontAttributes.Bold,
    FontSize = 13,
    Stroke = new SolidColorBrush(Colors.DarkGreen),
    StrokeWidth = 2
};

MultiLevelLabelStyle multiLevelLabelStyle = new MultiLevelLabelStyle()
{
    BorderColor = Colors.DarkBlue,
    BorderType = ChartMultiLevelBorderType.SquareBrace,
    BorderWidth = 2,
    LabelStyle = labelStyle
};

secondaryAxis.MultiLevelLabelStyle = multiLevelLabelStyle;

chart.YAxes.Add(secondaryAxis);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Multi-level labels with Square Brace border in .NET MAUI Cartesian Chart.](axis_images/multi_level_label_style.png)

## Events

### AxisLabelTapped

The [AxisLabelTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AxisLabelTapped) event occurs when a user taps on an axis label. The [AxisLabelTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelTappedEventArgs.html) class provides the following properties:

* [Axis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelTappedEventArgs.html#Syncfusion_Maui_Charts_AxisLabelTappedEventArgs_Axis) — Gets the associated axis where the label was tapped.
* [AxisLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelTappedEventArgs.html#Syncfusion_Maui_Charts_AxisLabelTappedEventArgs_AxisLabel) — Gets the [ChartAxisLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabel.html) object containing details about the tapped label.
* [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelTappedEventArgs.html#Syncfusion_Maui_Charts_AxisLabelTappedEventArgs_Position) — Gets the screen coordinates (X, Y) of the tap location in device-independent pixels.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart AxisLabelTapped="OnAxisLabelTapped">
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="Category" YBindingPath="Value"/>
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