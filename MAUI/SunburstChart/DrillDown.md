---
layout: post
title: Drill down in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains how to enable and customize drill down in the Syncfusion<sup>®</sup> .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Drill Down in .NET MAUI Sunburst Chart

The drill-down provides better visualization of hierarchy. Large set of data can be virtualized into minimal views. Each level of the segments can be drilled down. The sunburst chart provides animation along with the drill-down support. Double tapping the segment performs the drill-down operation. Toolbar will be enabled on drill-down that helps in performing zoom back and reset operations. 

{% tabs %}

{% highlight xml %}

<sunburst:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.DrillDownSettings>
        <chart:SunburstDrillDownSettings />
    </chart:SfSunburstChart.DrillDownSettings>
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
SunburstDrillDownSettings drillDownSettings = new SunburstDrillDownSettings();
sunburst.DrillDownSettings = drillDownSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

## Positioning Toolbar

Toolbar can be positioned anywhere on the chart by specifying the `OffsetX` and `OffsetY` values. The offset values range from 0 to 1.

{% tabs %}

{% highlight xml %}

<sunburst:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.DrillDownSettings>
        <chart:SunburstDrillDownSettings OffsetX="0.5" OffsetY="0" />
    </chart:SfSunburstChart.DrillDownSettings>
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
SunburstDrillDownSettings drillDownSettings = new SunburstDrillDownSettings()
{
    OffsetX = 0.5,
    OffsetY = 0,
};
sunburst.DrillDownSettings = drillDownSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

## Toolbar alignment

The vertical and the horizontal alignments of the toolbar can be customized using the `ToolbarVerticalAlignment` and `ToolbarHorizontalAlignment` properties, respectively.

Both the alignment properties has the following enum types:

Center: Toolbar takes the specified offset value as the center of the toolbar and get positioned.
End: Toolbar takes the specified offset value as the start of the toolbar and get positioned.
Start: Toolbar takes the specified offset value as the end of the toolbar and get positioned.

{% tabs %}

{% highlight xml %}

<sunburst:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.DrillDownSettings>
        <chart:SunburstDrillDownSettings OffsetX="0.5" OffsetY="0.5" 
                                         ToolbarHorizontalAlignment="Center" 
                                         ToolbarVerticalAlignment="Center"/>
    </chart:SfSunburstChart.DrillDownSettings>
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
SunburstDrillDownSettings drillDownSettings = new SunburstDrillDownSettings()
{
    OffsetX = 0.5,
    OffsetY = 0.5,
    ToolbarHorizontalAlignment = SunburstToolbarAlignment.Center,
    ToolbarVerticalAlignment = SunburstToolbarAlignment.Center,
};
sunburst.DrillDownSettings = drillDownSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}