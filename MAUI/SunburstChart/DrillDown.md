---
layout: post
title: Drill Down in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains how to enable and customize drill-down toolbar in the Syncfusion<sup>®</sup> .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Drill Down in .NET MAUI Sunburst Chart

Drill Down provides better visualization of hierarchical data. Large datasets can be visualized as simplified views. Each segment level can be drilled down into. The Sunburst Chart provides animation along with the drill-down support. Double-tapping a segment initiates the drill-down operation. A toolbar is enabled during drill-down, allowing zoom-back and reset operations. 

## Enable Drill Down

To enable this feature, set the [EnableDrillDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableDrillDown) property to true in [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html). By default, [EnableDrillDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableDrillDown) is set to false.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True" >
    . . .
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
. . .
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down in MAUI Sunburst Chart.](drill_down_images/maui_drill_down.gif)

## Toolbar Alignment

The vertical and the horizontal alignments of the toolbar can be customized using the [VerticalAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_VerticalAlignment) and [HorizontalAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_HorizontalAlignment) properties, respectively.

Both alignment properties have the following enum types:

* [Start](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarAlignment.html#Syncfusion_Maui_SunburstChart_SunburstToolbarAlignment_Start): Aligns the toolbar to the top (vertical) or left (horizontal) of the chart plot area.
* [Center](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarAlignment.html#Syncfusion_Maui_SunburstChart_SunburstToolbarAlignment_Center): Aligns the toolbar to the center of the chart plot area.
* [End](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarAlignment.html#Syncfusion_Maui_SunburstChart_SunburstToolbarAlignment_End): Aligns the toolbar to the bottom (vertical) or right (horizontal) of the chart plot area.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True">
    . . .
    <chart:SfSunburstChart.ToolbarSettings>
        <chart:SunburstToolbarSettings HorizontalAlignment="End" 
                                       VerticalAlignment="End"/>
    </chart:SfSunburstChart.ToolbarSettings>
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
. . .
SunburstToolbarSettings toolbarSettings = new SunburstToolbarSettings()
{
    HorizontalAlignment = SunburstToolbarAlignment.End,
    VerticalAlignment = SunburstToolbarAlignment.End,
};
sunburst.ToolbarSettings = toolbarSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down Toolbar Alignment.](drill_down_images/maui_toolbar_alignment.png)

## Toolbar Positioning

The toolbar's position within the Sunburst Chart can be adjusted both horizontally and vertically using the [OffsetX](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_OffsetX) and [OffsetY](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_OffsetY) properties of the [SunburstToolbarSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html) class.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True">
    . . .
    <chart:SfSunburstChart.ToolbarSettings >
        <chart:SunburstToolbarSettings OffsetX="-50" OffsetY="200"/>
    </chart:SfSunburstChart.ToolbarSettings>
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
. . .
SunburstToolbarSettings toolbarSettings = new SunburstToolbarSettings()
{
    OffsetX = -50,
    OffsetY = 200,
};
sunburst.ToolbarSettings = toolbarSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down Toolbar Positioning.](drill_down_images/maui_toolbar_positioning.png)

## Toolbar Customization

The appearance of the drill-down toolbar in the Sunburst Chart can be customized using the following properties

* [IconBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_IconBrush): Gets or sets the brush used to style the icons within the drill-down toolbar.
* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html#Syncfusion_Maui_SunburstChart_SunburstToolbarSettings_Background): Gets or sets the background brush of the drill-down toolbar.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableDrillDown="True">
    . . .
    <chart:SfSunburstChart.ToolbarSettings>
        <chart:SunburstToolbarSettings IconBrush="White" Background="#2989F9"/>
    </chart:SfSunburstChart.ToolbarSettings>
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.EnableDrillDown = true;
. . .
SunburstToolbarSettings toolbarSettings = new SunburstToolbarSettings()
{
    IconBrush = Colors.White,
    Background = new SolidColorBrush(Color.FromArgb("#2989F9")),
};
sunburst.ToolbarSettings = toolbarSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Drill Down Toolbar Customization.](drill_down_images/maui_toolbar_customization.png)
