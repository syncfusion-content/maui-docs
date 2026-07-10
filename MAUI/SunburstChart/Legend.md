---
layout: post
title: Legend in .NET MAUI Sunburst Chart control | Syncfusion
description: Learn here all about Legend in Syncfusion<sup>®</sup> .NET MAUI Sunburst Chart control, its elements, and more.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Legend in .NET MAUI Sunburst Chart

The legend provides information about the data points (segments) displayed in the sunburst chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Legend) property of the [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html) is used to enable the legend. By default, this property is `null`.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Sunburst Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/sunburstchart/getting-started)** guide.

## Enable a Legend

To display a legend, set the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Legend) property to an instance of the [SunburstLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html) class. The legend reflects the data bound to the chart via the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ItemsSource), [ValueMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ValueMemberPath), and [Levels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Levels) properties.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart>
    <sunburst:SfSunburstChart.Legend>
        <sunburst:SunburstLegend/>
    </sunburst:SfSunburstChart.Legend>
    <!-- code omitted for brevity -->
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
// code omitted for brevity
sunburst.Legend = new SunburstLegend();
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

## Placement

The placement of the legend relative to the chart area can be customized using the [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html#Syncfusion_Maui_SunburstChart_SunburstLegend_Placement) property of the [SunburstLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html) class. By default, the legend is placed at the `Top` of the chart.

The [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html#Syncfusion_Maui_SunburstChart_SunburstLegend_Placement) property uses the `LegendPlacement` enum with the following values:

* `Top` - Places the legend above the chart plot area (default).
* `Bottom` - Places the legend below the chart plot area.
* `Left` - Places the legend to the left of the chart plot area.
* `Right` - Places the legend to the right of the chart plot area.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart>
    <sunburst:SfSunburstChart.Legend>
        <sunburst:SunburstLegend Placement="Bottom"/>
    </sunburst:SfSunburstChart.Legend>
    <!-- code omitted for brevity -->
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
// code omitted for brevity
sunburst.Legend = new SunburstLegend()
{
    Placement = LegendPlacement.Bottom
};
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

## Visibility

The visibility of the legend can be toggled using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html#Syncfusion_Maui_SunburstChart_SunburstLegend_IsVisible) property of the [SunburstLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html) class. By default, the IsVisible property is set to `true`.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart>
    <sunburst:SfSunburstChart.Legend>
        <sunburst:SunburstLegend IsVisible="False"/>
    </sunburst:SfSunburstChart.Legend>
    <!-- code omitted for brevity -->
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
// code omitted for brevity
sunburst.Legend = new SunburstLegend()
{
    IsVisible = false
};
this.Content = sunburst;

{% endhighlight %}

{% endtabs %} 