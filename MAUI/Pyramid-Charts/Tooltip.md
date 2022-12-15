---
layout: post
title: Tooltip in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable tooltip and its customization in Syncfusion .NET MAUI Chart (SfPyramidChart) control
platform: maui
control: SfPyramidChart
documentation: ug
---

# Tooltip in .NET MAUI Chart

Tooltip is used to display any information or metadata of the mouse over or tapped segment.

## Define Tooltip

To define the tooltip in the chart, set the [EnableTooltip]() property of [SfPyramidChart]() to true. The default value of [EnableTooltip]() property is false.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart EnableTooltip="True">
. . .
</chart:SfPyramidChart>


{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .      
chart.EnableTooltip = true;

{% endhighlight %}

{% endtabs %}

![Tooltip support in MAUI chart](Tooltip_images/MAUI_chart_tooltip.png)

The [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) is used to customize the tooltip. For customizing the tooltip, create an instance [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) and set it to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property of [SfPyramidChart](). The following properties are used to customize the tooltip:

* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Background) of type `Brush`, indicates background color to the tooltip label.
* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontAttributes) of type `FontAttributes`, indicates the font style for the label.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontFamily) of type `string`, indicates the font family name for the label.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontSize) of type `float`, indicates the font size for the label.
* [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Duration) of type `int`, indicates the duration of the tooltip text in seconds.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Margin) of type `Thickness`, indicates the margin of the label.
* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_TextColor) of type `Color`, indicates the text color of the label.

{% tabs %}

{% highlight xml %}

<chart:SfPyramidChart EnableTooltip="True">
. . .
<chart:SfPyramidChart.TooltipBehavior>
    <chart:ChartTooltipBehavior/>
</chart:SfPyramidChart.TooltipBehavior>
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.EnableTooltip = true;
chart.TooltipBehavior = new ChartTooltipBehavior();
. . .

{% endhighlight %}

{% endtabs %}

## Template

Pyramid chart provides support to customize the appearance of the tooltip by using the [TooltipTemplate]() property.

{% tabs %}

{% highlight xaml %}

<Grid x:Name="grid">
    <Grid.Resources>
        <DataTemplate x:Key="tooltipTemplate">
            <StackLayout Orientation="Horizontal">
                <Label Text="{Binding Item.Name}"
					   TextColor="White"
					   FontAttributes="Bold"
					   FontSize="12"
					   HorizontalOptions="Center"
					   VerticalOptions="Center"/>
                <Label Text=" : " 
					   TextColor="White"
					   FontAttributes="Bold"
					   FontSize="12"
					   HorizontalOptions="Center"
					   VerticalOptions="Center"/>
                <Label Text="{Binding Item.Value}"
					   TextColor="White"
					   FontAttributes="Bold"
					   FontSize="12"
					   HorizontalOptions="Center"
					   VerticalOptions="Center"/>
            </StackLayout>
        </DataTemplate>
    </Grid.Resources>

    <chart:SfPyramidChart EnableTooltip="True"
                          TooltipTemplate="{StaticResource tooltipTemplate}">
	. . .
    </chart:SfPyramidChart>
</Grid>


{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.EnableTooltip = true;
chart.TooltipTemplate= grid.Resources["tooltipTemplate"] as DataTemplate;
. . .     

{% endhighlight %}

{% endtabs %}

![Tooltip template in MAUI Chart](Tooltip_images/MAUI_chart_tooltip_customization.png)