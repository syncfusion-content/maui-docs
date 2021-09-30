---
layout: post
title: Data label in .NET MAUI Chart control | .NET MAUI | Syncfusion
description: This section explains about how to configure the data labels and its features in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Data Label in .NET MAUI Chart (SfCircularChart)

Data labels are used to display values related to a chart segment. Values from data point(x, y) or other custom properties from a data source can be displayed. 

Each data label can be represented by the following:

* Label - displays the segment label content at the (X, Y) point.
* Connector line - used to connect the (X, Y) point and the label element.

## Enable Data Label 

`ShowDataLabels` property of series is used to enable the data labels.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    . . .
    <chart:PieSeries ShowDataLabels="True"
                    ItemsSource="{Binding Data}"  
                    XBindingPath="Product" 
                    YBindingPath="SalesRate"/>
    . . .
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    PieSeries series = new PieSeries();
    series.ShowDataLabels = true;
    . . .
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %} 

## LabelPlacement

`SfCircularChart` providing additional customization option to position the data label smartly based on series types using `LabelPlacement` property.

The following are the values for this property:

`Inner` - Data labels will be  placed inside over the CircularSeries.

`Outer` - Data labels will be  placed just outside over the CircularSeries.


{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    . . .
    <chart:PieSeries ShowDataLabels="True">
        <chart:PieSeries.DataLabelSettings>
            <chart:CircularDataLabelSettings LabelPlacement="Outer" />
        </chart:PieSeries.DataLabelSettings>
    </chart:PieSeries>
    . . .
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    PieSeries series = new PieSeries();
    series.ShowDataLabels = true;
    series.DataLabelSettings = new CircularDataLabelSettings()
    {
        LabelPlacement = Placement.Outer
    };

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Applying Series Interior

`UseSeriesPalette` property is used to set the interior of the series to the data label background. 

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
    . . .
    <chart:PieSeries ShowDataLabels="True">
        <chart:PieSeries.DataLabelSettings>
            <chart:CircularDataLabelSettings UseSeriesPalette="True"/>
        </chart:PieSeries.DataLabelSettings>
    </chart:PieSeries>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    PieSeries series = new PieSeries();
    series.ShowDataLabels = true;
    series.DataLabelSettings = new CircularDataLabelSettings()
    {
        UseSeriesPalette = true,
    };

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

