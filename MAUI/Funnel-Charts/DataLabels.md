---
layout: post
title: Data label in .NET MAUI Chart control | .NET MAUI | Syncfusion
description: This section explains about how to configure the data labels and its features in .NET MAUI Chart (SfFunnelChart).
platform: maui
control: SfFunnelChart
documentation: ug
---

# Data Label in .NET MAUI Chart

Data labels are used to display values related to a chart segment. Values from data point(x, y) or other custom properties from a data source can be displayed. 

## Enable Data Label 

To define the data label in the chart, set the [ShowDataLabels]() property to true.The default value of [ShowDataLabels]() property is false. 

{% tabs %}

{% highlight xaml %}

<chart:SfFunnelChart ShowDataLabels="True"/>
. . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.ShowDataLabels = true;

{% endhighlight %}

{% endtabs %} 

## Data label customization

 Data labels can be customized by using the [DataLabelSettings]() property of the chart. For customizing, need to create an instance of [FunnelDataLabelSettings]() and set to the [DataLabelSettings]() property.The following properties, which are available in [FunnelDataLabelSettings](), are used to customise the data labels. 

 * LabelPlacement - The [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelPlacement) property is used to position the funnel chart data labels at [DataLabelPlacement.Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Auto), [DataLabelPlacement.Inner](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Inner), [DataLabelPlacement.Center](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Center) and [DataLabelPlacement.Outer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Outer).The default value of LabelPlacement property is [DataLabelPlacement.Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Auto).
 * UseSeriesPalette - [UseSeriesPalette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_UseSeriesPalette) property is used to set the interior of the chart to the data label background.
 * Context - To customize the content of data labels, need to define [DataLabelSettings]() of chart and set [Context]() property of [FunnelDataLabelSettings]() to change the data label content value.
 * LabelStyle - [LabelStyle]() property is used to customise the data label's appearance. The following properties, which are available in [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelStyle), are used to customise the data labels.
    * [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Margin) of type `Thickness`, indicates the margin of the label.
    * [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Background), of type `Brush`, indicates the label background color.
    * [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_FontAttributes), of type `FontAttributes`, indicates the font style for the data label.
    * [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_FontSize), of type `double`, indicates the font size of the label.
    * [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Stroke), of type `Brush`, indicates the stroke color of the data label.
    * [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_StrokeWidth), of type `double`, indicates the stroke width of the data label .
    * [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_CornerRadius), of type `CornerRadius`, indicates the rounded corner for label.
    * [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_TextColor), of type `Color`, indicates the text color of the label.


{% tabs %}

{% highlight xaml %}

<chart:SfFunnelChart ShowDataLabels="True">
. . .
 <chart:SfFunnelChart.DataLabelSettings>
    <chart:FunnelDataLabelSettings LabelPlacement="Outer" Context="XValue" UseSeriesPalette="True">
        <chart:FunnelDataLabelSettings.LabelStyle>
            <chart:ChartDataLabelStyle/>
        </chart:FunnelDataLabelSettings.LabelStyle>
    </chart:FunnelDataLabelSettings>
 </chart:SfFunnelChart.DataLabelSettings>
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.ShowDataLabels = true;
chart.DataLabelSettings = new FunnelDataLabelSettings()
{
    Context=FunnelDataLabelContext.XValue,
    LabelPlacement=DataLabelPlacement.Outer,
    UseSeriesPalette=true,
};
chart.DataLabelSettings.LabelStyle = new ChartDataLabelStyle();

{% endhighlight %}

{% endtabs %} 

![Data label for .NET MAUI Funnel chart](DataLabel_images/MAUI_data_label.png)