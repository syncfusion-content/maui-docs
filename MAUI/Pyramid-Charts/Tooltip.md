---
layout: post
title: Tooltip in .NET MAUI Pyramid Chart control | Syncfusion
description: This section explains how to enable and customize the tooltip in Syncfusion® .NET MAUI Pyramid Chart (SfPyramidChart) control
platform: maui
control: SfPyramidChart
documentation: ug
---

# Tooltip in .NET MAUI Pyramid Chart

The tooltip provides additional information when hovering over a pyramid segment. By default, the segment's Y value will be shown in the tooltip.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Pyramid Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/pyramid-charts/getting-started)** guide.

## Enable Tooltip

To enable the tooltip in the chart, set the [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_EnableTooltip) property of [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html) to `true`.

{% tabs %}

{% highlight xml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="XValue" 
                      YBindingPath="YValue"
                      EnableTooltip="True">
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.EnableTooltip = true;

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Tooltip support in .NET MAUI Pyramid Chart](Tooltip_images/MAUI_chart_tooltip.png)

## Tooltip Customization

The [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) is used to customize the tooltip. To customize the tooltip, create an instance of [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) and set it to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property of [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html). The following properties are used to customize the tooltip:

* [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Background) of type `Brush` — indicates the background color of the tooltip label.
* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontAttributes) of type `FontAttributes` — indicates the font style of the label.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontFamily) of type `string` — indicates the font family for the label.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_FontSize) of type `float` — indicates the font size.
* [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Duration) of type `int` — indicates the duration for displaying the tooltip.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Margin) of type `Thickness` — indicates the label's margin.
* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_TextColor) of type `Color` — indicates the color of the displayed text.
* [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Stroke) of type `Brush` — indicates the border color of the tooltip.
* [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_StrokeWidth) of type `double` — indicates the thickness of the tooltip border.
* [UseSeriesFillColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_UseSeriesFillColor) of type `bool` — indicates whether the tooltip background should use the fill color of the associated segment; when `true`, the tooltip adopts the segment color as its background.

{% tabs %}

{% highlight xml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="XValue" 
                      YBindingPath="YValue"
                      EnableTooltip="True">
    <chart:SfPyramidChart.TooltipBehavior>
        <chart:ChartTooltipBehavior Duration="4"/>
    </chart:SfPyramidChart.TooltipBehavior>
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.EnableTooltip = true;
chart.TooltipBehavior = new ChartTooltipBehavior()
{
    Duration = 4,
};

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Tooltip Template

[TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_TooltipTemplate) is used to customize the tooltip with additional information beyond the default display. The template binding context is the chart segment's `TooltipInfo` object, which contains an `Item` property for the data point.

{% tabs %}

{% highlight xml %}

<Grid x:Name="grid">
    <Grid.Resources>
        <DataTemplate x:Key="tooltipTemplate">
            <HorizontalStackLayout Padding="8" Spacing="4">
                <Label Text="{Binding Item.XValue}"
                       TextColor="White"
                       FontAttributes="Bold"
                       VerticalOptions="Center"/>
                <Label Text="{Binding Item.YValue, StringFormat=': {0}'}"
                       TextColor="White"
                       FontAttributes="Bold"
                       VerticalOptions="Center"/>
            </HorizontalStackLayout>
        </DataTemplate>
    </Grid.Resources>

    <chart:SfPyramidChart ItemsSource="{Binding Data}" 
                          XBindingPath="XValue" 
                          YBindingPath="YValue"
                          EnableTooltip="True"
                          TooltipTemplate="{StaticResource tooltipTemplate}">
    </chart:SfPyramidChart>
</Grid>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.EnableTooltip = true;
chart.TooltipTemplate = grid.Resources["tooltipTemplate"] as DataTemplate;

grid.Children.Add(chart);
this.Content = grid;

{% endhighlight %}

{% endtabs %}

![Tooltip template in .NET MAUI Pyramid Chart](Tooltip_images/MAUI_chart_tooltip_customization.png)
