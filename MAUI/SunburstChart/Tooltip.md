---
layout: post
title: Tooltip in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains about how to enable tooltip in Syncfusion .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Tooltip in .NET MAUI Sunburst Chart 

Tooltip provides additional information about the segments in the sunburst chart. Tooltip is displayed by tapping the segment. By default, the tooltip displays the corresponding segment’s category and value.

## Enable Tooltip

To define the tooltip in the chart, set the [EnableTooltip]() property of [SfSunburstChart]() to true. The default value of the EnableTooltip property is `False`.

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

{% endhighlight %}

{% endtabs %}

![Default tooltip in MAUI Sunburst Chart](Tooltip_images/maui_default_tooltip_image.png)

## Customization

The appearance of the tooltip can be customized using the following properties:

* [Background]() of type `Brush`, indicates background color to the tooltip label.
* [FontAttributes]() of type `FontAttributes`, indicates the font style of * the label.
* [FontFamily]() of type `string`, indicates the font family for the label.
* [FontSize]() of type `float`, indicates the font size.
* [Duration]() of type `int`, indicates the duration for displaying the tooltip.
* [Margin]() of type `Thickness`, indicates the label’s margin.
* [TextColor]() of type `Color`, indicates the color of the displayed text.

{% tabs %}

{% highlight xml %}

    <sunburst:SfSunburstChart EnableTooltip="True">
    . . .
        <sunburst:SfSunburstChart.TooltipSettings>
            <sunburst:SunburstTooltipSettings   
                Background="White"  TextColor="Black"  
                FontSize="14" FontAttributes="Bold" 
                Duration="5"/>
        </sunburst:SfSunburstChart.TooltipSettings>
    . . .
    
{% endhighlight %}

{% highlight c# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.EnableTooltip = true;
    SunburstTooltipSettings tooltipSettings = new SunburstTooltipSettings();
    tooltipSettings.TextColor = Colors.Black;
    tooltipSettings.Background = Brush.White;
    tooltipSettings.FontSize = 14;     
    tooltipSettings.Duration = 5;
    sunburst.TooltipSettings = tooltipSettings;
    . . .

{% endhighlight %}

{% endtabs %}

![Tooltip customization in MAUI Sunburst Chart](Tooltip_images/maui_custom_tooltip_image.png)

## Custom template

The sunburst chart provides support to customize the appearance of the tooltip by using the [TooltipTemplate]() property.

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
    </chart:SfSunburstChart>
    . . .
    
{% endhighlight %}

{% highlight c# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . .
    sunburst.EnableTooltip = true;
    sunburst.TooltipTemplate = (DataTemplate)sunburstChart.Resources["template1"];
    . . .

{% endhighlight %}

{% endtabs %}

![Tooltip template in MAUI Sunburst Chart](Tooltip_images/maui_tooltip_template_image.png)