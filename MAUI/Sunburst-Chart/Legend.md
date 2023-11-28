---
layout: post
title: Legend in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable legend in Syncfusion .NET MAUI Chart (SfSunburstChart) control
platform: maui
control: SfSunburstChart
documentation: ug
---

# Legend in .NET MAUI Chart

Legends are used to represent the first level (i.e root level) of categories in the sunburst chart.

The following code explains how to initialize the legends.

{% tabs %} 

{% highlight xaml %}

    <chart:SfSunburstChart>
        . . .
        <chart:SfSunburstChart.Legend>
            <chart:SunburstLegend/>
        </chart:SfSunburstChart.Legend>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    SunburstLegend legend = new SunburstLegend();
    Chart.Legend = legend;

{% endhighlight %}

{% endtabs %} 

## Visibility

The visibility of legends can be controlled using the [IsVisible]() property.

The following code shows how to control the visibility of legend.

{% tabs %} 

{% highlight xaml %}

    <chart:SfSunburstChart>
        . . .
        <chart:SfSunburstChart.Legend>
            <chart:SunburstLegend IsVisible="True"/>
        </chart:SfSunburstChart.Legend>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    SunburstLegend legend = new SunburstLegend();
    legend.IsVisible = true;
    Chart.Legend = legend;

{% endhighlight %}

{% endtabs %} 

## Placement
Legends can be docked at the top, right, left, or bottom position using the Placement property.

The following code shows customizing the legend Placement.

{% tabs %} 

{% highlight xaml %}

    <chart:SfSunburstChart>
        . . .
        <chart:SfSunburstChart.Legend>
            <chart:SunburstLegend Placement="Right"/>
        </chart:SfSunburstChart.Legend>
    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    SunburstLegend legend = new SunburstLegend();
    legend.Placement = LegendPlacement.Right;
    Chart.Legend = legend;

{% endhighlight %}

{% endtabs %} 

![Legend placement in MAUI chart](Legend_images/sunburst_chart_legend_placement.png)