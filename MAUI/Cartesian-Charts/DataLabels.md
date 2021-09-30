---
layout: post
title: Data label in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the data labels and its features in .NET MAUI Chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Data Label in .NET MAUI Chart (SfCartesianChart)

Data labels are used to display values related to a chart segment. Values from data point(x, y) or other custom properties from a data source can be displayed. 

Each data label can be represented by the following:

* Label - displays the segment label content at the (X, Y) point.
* Connector line - used to connect the (X, Y) point and the label element.

## Enable Data Label 

The `ShowDataLabels` property of series is used to enable the data labels.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
<chart:SfCartesianChart.Series>
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                     XBindingPath="Category"
                     YBindingPath="Value" ShowDataLabels="True">
    </chart:ColumnSeries>
</chart:SfCartesianChart.Series>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Category",
    YBindingPath = "Value",
    ShowDataLabels = true
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Alignment

The alignment of data labels inside the series is defined by using the `BarAlignment` property. 

* `Top` - Positions the data label at the top edge point of a chart segment.
* `Middle` - Positions the data label at the center point of a chart segment.
* `Bottom` - Positions the data label at the bottom edge point of a chart segment.

N> This behavior varies based on the chart series type.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
<chart:ColumnSeries ShowDataLabels="True">
    <chart:ColumnSeries.DataLabelSettings>
        <chart:CartesianDataLabelSettings BarAlignment="Middle"/>
    </chart:ColumnSeries.DataLabelSettings>
</chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
ColumnSeries series = new ColumnSeries();
. . .
series.DataLabelSettings = new CartesianDataLabelSettings()
{
    BarAlignment = Alignment.Middle,
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Position

Other than the above alignment options, Chart providing additional customization option to position the data labels. 

The `LabelPlacement` property is used to position the data labels at `Center`, `Inner` and `Outer` position of the actual data point position. By default, labels are positioned based on the series types for better readability.

## Applying Series Interior

`UseSeriesPalette` property is used to set the interior of the series to the data marker background. 

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ShowDataLabels="True">
        <chart:ColumnSeries.DataLabelSettings>
            <chart:CartesianDataLabelSettings  UseSeriesPalette="True"/>
        </chart:ColumnSeries.DataLabelSettings>
    </chart:ColumnSeries>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ColumnSeries series = new ColumnSeries();
    . . .
    series.DataLabelSettings = new CartesianDataLabelSettings()
    {
        UseSeriesPalette = true,
    };

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}
