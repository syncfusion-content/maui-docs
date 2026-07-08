---
layout: post
title: Data Labels in .NET MAUI Funnel Chart control | Syncfusion
description: Learn how to configure, customize, and format data labels in the Syncfusion® .NET MAUI Funnel Chart (SfFunnelChart) control.
platform: maui
control: SfFunnelChart
documentation: ug
keywords: .net maui funnel chart, data labels, label customization, label placement, label formatting.
---

# Data Labels in .NET MAUI Funnel Chart

Data labels are used to display values related to a chart segment. Values from data points (x, y) or other custom properties from a data source can be displayed.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Funnel Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/funnel-charts/getting-started)** guide.

## Enable data labels

To enable data labels in the chart, set the [ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ShowDataLabels) property to `true`. The default value is `false`. By default, the Y-value of each data point is displayed in the label.

{% tabs %}

{% highlight xml %}

<chart:SfFunnelChart ItemsSource="{Binding Data}"
                     XBindingPath="XValue"
                     YBindingPath="YValue"
                     ShowDataLabels="True">
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    ShowDataLabels = true
};

this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Customize data labels

Data labels can be customized using the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_DataLabelSettings) property of the chart. To customize data labels, create an instance of [FunnelDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FunnelDataLabelSettings.html) and assign it to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_DataLabelSettings) property.

### Data label settings

The following properties in [FunnelDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FunnelDataLabelSettings.html) are used to customize data labels:

* [`LabelPlacement`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelPlacement) — Positions the funnel chart data labels at [Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Auto), [Inner](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Inner), [Center](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Center), or [Outer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Outer). Default value is `Auto`.
* [`UseSeriesPalette`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_UseSeriesPalette) — Sets the chart segment color as the data label background color.
* [`Context`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FunnelDataLabelSettings.html#Syncfusion_Maui_Charts_FunnelDataLabelSettings_Context) — Gets or sets the content to be displayed in the label using the [FunnelDataLabelContext](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FunnelDataLabelContext.html) enum. Supported values are `XValue` and `YValue`.
* [`LabelStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelStyle) — Customizes the appearance of the data labels. Properties available in the [ChartDataLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelStyle.html) class include:
  * [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Margin) — Gets or sets the label margin (type: `Thickness`).
  * [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Background) — Gets or sets the label background color (type: `Brush`).
  * [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_FontAttributes) — Gets or sets the font style (type: `FontAttributes`).
  * [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_FontSize) — Gets or sets the font size (type: `double`).
  * [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_Stroke) — Gets or sets the border color (type: `Brush`).
  * [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_StrokeWidth) — Gets or sets the border width (type: `double`).
  * [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_CornerRadius) — Gets or sets the rounded corners for the label (type: `CornerRadius`).
  * [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html#Syncfusion_Maui_Charts_ChartLabelStyle_TextColor) — Gets or sets the label text color (type: `Color`).

{% tabs %}

{% highlight xml %}

<chart:SfFunnelChart ItemsSource="{Binding Data}"
                     XBindingPath="XValue"
                     YBindingPath="YValue"
                     ShowDataLabels="True">
    <chart:SfFunnelChart.DataLabelSettings>
        <chart:FunnelDataLabelSettings LabelPlacement="Outer" 
                                       Context="XValue" 
                                       UseSeriesPalette="True">
            <chart:FunnelDataLabelSettings.LabelStyle>
                <chart:ChartDataLabelStyle Margin="2"/>
            </chart:FunnelDataLabelSettings.LabelStyle>
        </chart:FunnelDataLabelSettings>
    </chart:SfFunnelChart.DataLabelSettings>
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    ShowDataLabels = true
};

ChartDataLabelStyle labelStyle = new ChartDataLabelStyle()
{
    Margin = 2
};

chart.DataLabelSettings = new FunnelDataLabelSettings()
{
    Context = FunnelDataLabelContext.XValue,
    LabelPlacement = DataLabelPlacement.Outer,
    UseSeriesPalette = true,
    LabelStyle = labelStyle
};

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Data labels in .NET MAUI Funnel Chart](DataLabel_images/MAUI_data_label.png)