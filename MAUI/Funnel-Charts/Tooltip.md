---
layout: post
title: Tooltip in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable tooltip and its customization in Syncfusion .NET MAUI Chart (SfFunnelChart) control
platform: maui
control: SfFunnelChart
documentation: ug
---

# Tooltip in .NET MAUI Chart

The tooltip helps in providing additional information while hovering over the funnel segment. By default, the value of the funnel process (Y value) will be shown in the tooltip.

## Enable Tooltip

To define the tooltip in the chart, set the [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_EnableTooltip) property of [SfFunnelChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html) to true. 

{% tabs %}

{% highlight xaml %}

<chart:SfFunnelChart EnableTooltip="True">
    . . .
</chart:SfFunnelChart>


{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart();
. . .      
chart.EnableTooltip = true;

{% endhighlight %}

{% endtabs %}

![Tooltip support in MAUI chart](Tooltip_images/MAUI_chart_tooltip.png)

The [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) is used to customize the tooltip. For customizing the tooltip, create an instance [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) and set it to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property of [SfFunnelChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html). The following properties are used to customize the tooltip:

* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Background) of type `Brush`, indicates background color to the tooltip label.
* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontAttributes) of type `FontAttributes`, indicates the font style of the label.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontFamily) of type `string`, indicates the font family for the label.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontSize) of type `float`, indicates the font size.
* [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Duration) of type `int`, indicates the duration for displaying the tooltip.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Margin) of type `Thickness`, indicates the label's margin.
* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_TextColor) of type `Color`, indicates the color of the displayed text.

{% tabs %}

{% highlight xml %}

<chart:SfFunnelChart EnableTooltip="True">
    . . .
    <chart:SfFunnelChart.TooltipBehavior>
        <chart:ChartTooltipBehavior Duration="4"/>
    </chart:SfFunnelChart.TooltipBehavior>
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.EnableTooltip = true;
chart.TooltipBehavior = new ChartTooltipBehavior()
{
    Duration = 4,
};
. . .

{% endhighlight %}

{% endtabs %}

## Tooltip Template

[TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_TooltipTemplate) is used to show additional information other than the default UI.

{% tabs %}

{% highlight xaml %}

<Grid x:Name="grid">
    <Grid.Resources>
        <DataTemplate x:Key="tooltipTemplate">
            <StackLayout Orientation="Horizontal">
                <Label Text="{Binding Item.XValue}"
                       TextColor="White"
                       FontAttributes="Bold"
                       HorizontalOptions="Center"
                       VerticalOptions="Center"/>
                <Label Text="{Binding Item.YValue,StringFormat=': {0}'}"
                       TextColor="White"
                       FontAttributes="Bold"
                       HorizontalOptions="Center"
                       VerticalOptions="Center"/>
            </StackLayout>
        </DataTemplate>
    </Grid.Resources>

    <chart:SfFunnelChart EnableTooltip="True"
                         TooltipTemplate="{StaticResource tooltipTemplate}">
	. . .
    </chart:SfFunnelChart>
</Grid>

{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.EnableTooltip = true;
chart.TooltipTemplate= grid.Resources["tooltipTemplate"] as DataTemplate;
. . .

{% endhighlight %}

{% endtabs %}

![Tooltip template in MAUI Chart](Tooltip_images/MAUI_chart_tooltip_customization.png)
