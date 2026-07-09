---
layout: post
title: Drill Down in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains how to enable and customize drill-down toolbar in the Syncfusion<sup>®</sup> .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Drill Down in .NET MAUI Sunburst Chart

Drill-down provides better visualization of hierarchical data by allowing large datasets to be visualized as simplified views. Users can drill down into each segment level. The Sunburst Chart provides animation along with drill-down support. Double-tapping (or double-clicking) a segment initiates the drill-down operation. A toolbar is enabled during drill-down, allowing zoom-back and reset operations.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Sunburst Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/sunburstchart/getting-started)** guide.

## Enable Drill Down

To enable this feature, set the [EnableDrillDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableDrillDown) property to `true` in [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html). Drill-down requires the chart to be bound to hierarchical data using the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ItemsSource), [ValueMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ValueMemberPath), and [Levels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Levels) properties. By default, the EnableDrillDown property is set to `false`.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True">
    <!-- code omitted for brevity -->
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
// code omitted for brevity
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down in MAUI Sunburst Chart.](drill_down_images/maui_drill_down.gif)

## Toolbar Alignment

The vertical and horizontal alignments of the toolbar can be customized using the [VerticalAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_VerticalAlignment) and [HorizontalAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_HorizontalAlignment) properties of the [SunburstToolbarSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html) class. The default value for both properties is `Start`.

Both alignment properties use the [SunburstToolbarAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarAlignment.html) enum with the following values:

* [Start](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarAlignment.html#Syncfusion_Maui_SunburstChart_SunburstToolbarAlignment_Start): Aligns the toolbar to the top (vertical) or left (horizontal) of the chart plot area.
* [Center](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarAlignment.html#Syncfusion_Maui_SunburstChart_SunburstToolbarAlignment_Center): Aligns the toolbar to the center of the chart plot area.
* [End](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarAlignment.html#Syncfusion_Maui_SunburstChart_SunburstToolbarAlignment_End): Aligns the toolbar to the bottom (vertical) or right (horizontal) of the chart plot area.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True">
    <sunburst:SfSunburstChart.ToolbarSettings>
        <sunburst:SunburstToolbarSettings HorizontalAlignment="End"
                                          VerticalAlignment="End"/>
    </sunburst:SfSunburstChart.ToolbarSettings>
    <!-- code omitted for brevity -->
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
// code omitted for brevity
SunburstToolbarSettings toolbarSettings = new SunburstToolbarSettings()
{
    HorizontalAlignment = SunburstToolbarAlignment.End,
    VerticalAlignment = SunburstToolbarAlignment.End
};
sunburst.ToolbarSettings = toolbarSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down Toolbar Alignment in MAUI Sunburst Chart.](drill_down_images/maui_toolbar_alignment.png)

## Toolbar Positioning

The toolbar's position within the Sunburst Chart can be adjusted both horizontally and vertically using the [OffsetX](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_OffsetX) and [OffsetY](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_OffsetY) properties of the [SunburstToolbarSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html) class. Values are specified in pixels; negative `OffsetX` values move the toolbar to the left, and positive `OffsetY` values move it downward.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True">
    <sunburst:SfSunburstChart.ToolbarSettings>
        <sunburst:SunburstToolbarSettings OffsetX="-50" OffsetY="200"/>
    </sunburst:SfSunburstChart.ToolbarSettings>
    <!-- code omitted for brevity -->
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
// code omitted for brevity
SunburstToolbarSettings toolbarSettings = new SunburstToolbarSettings()
{
    OffsetX = -50,
    OffsetY = 200
};
sunburst.ToolbarSettings = toolbarSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down Toolbar Positioning in MAUI Sunburst Chart.](drill_down_images/maui_toolbar_positioning.png)

## Toolbar Customization

The appearance of the drill-down toolbar in the Sunburst Chart can be customized using the following properties of the [SunburstToolbarSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html) class:

* [IconBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_IconBrush), of type `Brush`, indicates the brush used to style the icons within the drill-down toolbar.
* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_Background), of type `Brush`, indicates the background brush of the drill-down toolbar.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True">
    <sunburst:SfSunburstChart.ToolbarSettings>
        <sunburst:SunburstToolbarSettings IconBrush="White" Background="#2989F9"/>
    </sunburst:SfSunburstChart.ToolbarSettings>
    <!-- code omitted for brevity -->
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
// code omitted for brevity
SunburstToolbarSettings toolbarSettings = new SunburstToolbarSettings()
{
    IconBrush = Colors.White,
    Background = Color.FromArgb("#2989F9")
};
sunburst.ToolbarSettings = toolbarSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down Toolbar Customization in MAUI Sunburst Chart.](drill_down_images/maui_toolbar_customization.png)
