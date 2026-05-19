---
layout: post
title: Multi-Level Labels in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about multi-level labels and its features in Syncfusion® .NET MAUI Chart (SfCartesianChart) control and more.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian charts, .net maui multi-level labels, cartesian chart multi-level labels, syncfusion cartesian charts maui, maui chart axis labels, .net maui chart axis, multilevel label customization, .net maui sfCartesianChart axis labels.
---

# Multi-Level Labels in .NET MAUI Cartesian Chart

Multi-level labels allow you to display multiple hierarchy levels of labels on the chart axes. This feature is particularly useful for categorizing data at different levels of detail, providing better organization and readability of large datasets. Multi-level labels can be applied to any [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) in the Cartesian chart.

## Overview

[ChartMultiLevelLabel](#) allows you to organize axis labels in multiple hierarchical levels. Each label is defined with a start value, end value, text, and level. The [MultiLevelLabelStyle](#) provides customization options for appearance, including border type, border color, and label styling.

## Creating Multi-Level Labels

Multi-level labels are added to an axis using the [MultiLevelLabels](#) collection of the axis. Each [ChartMultiLevelLabel](#) requires:

* **Start** - The starting value of the label range
* **End** - The ending value of the label range
* **Text** - The label text to display
* **Level** - The hierarchy level (1 for top level, 2 for sub-level, etc.)

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
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
    . . .
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
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

## Customizing Multi-Level Label Appearance

The appearance of multi-level labels can be customized using the [MultiLevelLabelStyle](#) property. This allows you to control border type, border color, border width, and label text styling.

### Border Types

The [BorderType](#) property supports the following [ChartMultiLevelBorderType](#) values:

* **Rectangle** - Displays the label with a rectangular border on all sides
* **WithoutTopAndBottom** - Displays the label with a border on left and right sides only (no top and bottom)
* **SquareBrace** - Displays the label with a square brace border style
* **CurlyBrace** - Displays the label with a curly brace border style

The default value is [Rectangle](#).

### Styling with Square Brace Border

The following example demonstrates how to apply a square brace border style:

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
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
                <chart:MultiLevelLabelStyle BorderColor="Red" BorderType="SquareBrace" BorderWidth="2">
                    <chart:MultiLevelLabelStyle.LabelStyle>
                        <chart:ChartAxisLabelStyle TextColor="Brown" FontAttributes="Bold" FontSize="13" Stroke="DarkGreen" StrokeWidth="2"/>
                    </chart:MultiLevelLabelStyle.LabelStyle>
                </chart:MultiLevelLabelStyle>
            </chart:NumericalAxis.MultiLevelLabelStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>
    . . .
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
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
    TextColor = Colors.Brown,
    FontAttributes = FontAttributes.Bold,
    FontSize = 13,
    Stroke = Colors.DarkGreen,
    StrokeWidth = 2
};

MultiLevelLabelStyle multiLevelLabelStyle = new MultiLevelLabelStyle()
{
    BorderColor = Colors.Red,
    BorderType = ChartMultiLevelBorderType.SquareBrace,
    BorderWidth = 2,
    LabelStyle = labelStyle
};

secondaryAxis.MultiLevelLabelStyle = multiLevelLabelStyle;

chart.YAxes.Add(secondaryAxis);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Multi-Level Labels Properties

The following key properties are used to configure multi-level labels:

| Property | Type | Description |
|----------|------|-------------|
| [MultiLevelLabels](#) | `ObservableCollection<ChartMultiLevelLabel>` | Gets or sets the collection of multi-level labels |
| [Start](#) | `object` | Gets or sets the start value of the label range |
| [End](#) | `object` | Gets or sets the end value of the label range |
| [Text](#) | `string` | Gets or sets the text to display for the label |
| [Level](#) | `int` | Gets or sets the hierarchy level of the label |

## Multi-Level Label Style Properties

The [MultiLevelLabelStyle](#) provides the following customization properties:

| Property | Type | Description |
|----------|------|-------------|
| [BorderType](#) | `ChartMultiLevelBorderType` | Gets or sets the border type for multi-level labels |
| [BorderColor](#) | `Color` | Gets or sets the border color |
| [BorderWidth](#) | `double` | Gets or sets the border width |
| [LabelStyle](#) | `ChartAxisLabelStyle` | Gets or sets the text styling for the multi-level label |

