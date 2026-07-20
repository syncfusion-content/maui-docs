---
layout: post
title: Multi-Level Labels in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about multi-level labels and its features in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control and more.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian charts, .net maui multi-level labels, cartesian chart multi-level labels, syncfusion cartesian charts maui, maui cartesian chart axis labels, .net maui cartesian chart axis, multilevel label customization, .net maui sfCartesianChart axis labels.
---

# Multi-Level Labels in .NET MAUI Cartesian Chart

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

Multi-level labels allow you to display multiple hierarchy levels of labels on the chart axes. This feature is particularly useful for categorizing data at different levels of detail, providing better organization and readability of large datasets. Multi-level labels can be applied to any [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) in the Cartesian chart.

## Creating Multi-Level Labels

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

## Customizing Label Appearance

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
