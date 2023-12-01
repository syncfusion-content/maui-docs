---
layout: post
title: Legend in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains about how to enable legend in Syncfusion .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Legend in .NET MAUI Sunburst Chart

Legends are used to represent the first level (i.e root level) of categories in the sunburst chart.

The following code explains how to initialize the legends.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart>
        . . .
        <sunburst:SfSunburstChart.Legend>
            <sunburst:SunburstLegend/>
        </sunburst:SfSunburstChart.Legend>
    </sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    SunburstLegend legend = new SunburstLegend();
    sunburst.Legend = legend;

{% endhighlight %}

{% endtabs %} 

## Visibility

The visibility of legends can be controlled using the [IsVisible]() property.

The following code shows how to control the visibility of legend.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart>
        . . .
        <sunburst:SfSunburstChart.Legend>
            <sunburst:SunburstLegend IsVisible="True"/>
        </sunburst:SfSunburstChart.Legend>
    </sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    SunburstLegend legend = new SunburstLegend();
    legend.IsVisible = true;
    sunburst.Legend = legend;

{% endhighlight %}

{% endtabs %} 

## Placement

Legends can be docked at the top, right, left, or bottom position using the Placement property.

The following code shows customizing the legend Placement.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart>
        . . .
        <sunburst:SfSunburstChart.Legend>
            <sunburst:SunburstLegend Placement="Right"/>
        </sunburst:SfSunburstChart.Legend>
    </sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    SunburstLegend legend = new SunburstLegend();
    legend.Placement = LegendPlacement.Right;
    sunburst.Legend = legend;

{% endhighlight %}

{% endtabs %} 

![Legend placement in Sunburst Chart](Legend_images/sunburst_chart_legend_placement.png)