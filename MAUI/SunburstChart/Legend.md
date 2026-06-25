---
layout: post
title: Legend in .NET MAUI Sunburst Chart control | Syncfusion
description: Learn here all about Legend in Syncfusion<sup>®</sup> .NET MAUI Sunburst Chart control, its elements, and more.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Legend in .NET MAUI Sunburst Chart

## Enable a Legend

The legend provides information about the data points displayed in the sunburst chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Legend) property of the chart enables the [SunburstLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html).

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
sunburst.Legend = new SunburstLegend();
this.Content = sunburst;

{% endhighlight %}

{% endtabs %} 