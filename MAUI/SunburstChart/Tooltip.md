---
layout: post
title: Tooltip in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains about how to enable tooltip in the Syncfusion .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Tooltip in .NET MAUI Sunburst Chart 

Tooltip provides additional information about the segments in the sunburst chart. Tooltip is displayed by tapping the segment. By default, the tooltip displays the corresponding segment’s category and value.

## Enable Tooltip

To define the tooltip in the chart, set the [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableTooltip) property of [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html) to true. The default value of the EnableTooltip property is `False`.

{% tabs %}

{% highlight xaml %}

<sunburst:SfSunburstChart EnableTooltip="True">
. . .
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .      
sunburst.EnableTooltip = true;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Default tooltip in MAUI Sunburst Chart.](Tooltip_images/maui_default_tooltip_image.png)

## Customization

The appearance of the tooltip can be customized using the following properties:

* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html#Syncfusion_Maui_SunburstChart_SunburstTooltipSettings_Background) of type `Brush`, indicates background color to the tooltip label.
* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html#Syncfusion_Maui_SunburstChart_SunburstTooltipSettings_FontAttributes) of type `FontAttributes`, indicates the font style of * the label.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html#Syncfusion_Maui_SunburstChart_SunburstTooltipSettings_FontFamily) of type `string`, indicates the font family for the label.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html#Syncfusion_Maui_SunburstChart_SunburstTooltipSettings_FontSize) of type `float`, indicates the font size.
* [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html#Syncfusion_Maui_SunburstChart_SunburstTooltipSettings_Duration) of type `int`, indicates the duration for displaying the tooltip.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html#Syncfusion_Maui_SunburstChart_SunburstTooltipSettings_Margin) of type `Thickness`, indicates the label’s margin.
* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html#Syncfusion_Maui_SunburstChart_SunburstTooltipSettings_TextColor) of type `Color`, indicates the color of the displayed text.

{% tabs %}

{% highlight xml %}

<sunburst:SfSunburstChart EnableTooltip="True">
    . . .
    <sunburst:SfSunburstChart.TooltipSettings>
        <sunburst:SunburstTooltipSettings   
            Background="White" TextColor="Black"  
            FontSize="14" FontAttributes="Bold" 
            Duration="5"/>
    </sunburst:SfSunburstChart.TooltipSettings>
    . . .
</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
sunburst.EnableTooltip = true;
SunburstTooltipSettings tooltipSettings = new SunburstTooltipSettings()
{
    TextColor = Colors.Black,
    Background = Brush.White,
    FontSize = 14,
    Duration = 5
};
sunburst.TooltipSettings = tooltipSettings;
. . .
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Tooltip customization in MAUI Sunburst Chart.](Tooltip_images/maui_custom_tooltip_image.png)

## Custom Template

The sunburst chart provides support for customizing the appearance of the tooltip by using the [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_TooltipTemplate) property.

{% tabs %}

{% highlight xml %}

<sunburst:SfSunburstChart EnableTooltip="True" 
                          TooltipTemplate="{StaticResource template1}">
    . . .
    <sunburst:SfSunburstChart.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="template1">
                <StackLayout Orientation="Horizontal">
                    <Rectangle HeightRequest="30" WidthRequest="8" Fill="{Binding Fill}"/>
                    <StackLayout Orientation="Vertical">
                        <Label Text="{Binding Item[0]}" 
                               TextColor="White" FontFamily="Helvetica" 
                               FontSize="12.5" Padding="5,0,0,0"
                               FontAttributes="Bold"/>
                        <Label Text="{Binding Item[1],StringFormat='Count : {0}M'}" 
                               TextColor="White" FontFamily="Helvetica" 
                               FontSize="12" Padding="5,0,0,0" Margin="0,2,0,0"/>
                    </StackLayout>
                </StackLayout>
            </DataTemplate>
        </ResourceDictionary>
    </sunburst:SfSunburstChart.Resources>
    . . .

</sunburst:SfSunburstChart>
    
{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
sunburst.EnableTooltip = true;
sunburst.TooltipTemplate = (DataTemplate)sunburstChart.Resources["template1"];
. . .
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Tooltip template in MAUI Sunburst Chart.](Tooltip_images/maui_tooltip_template_image.png)