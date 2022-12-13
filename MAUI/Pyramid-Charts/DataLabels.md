---
layout: post
title: Data label in .NET MAUI Chart control | .NET MAUI | Syncfusion
description: This section explains about how to configure the data labels and its features in .NET MAUI Chart (SfPyramidChart).
platform: maui
control: SfPyramidChart
documentation: ug
---

# Data Label in .NET MAUI Chart

Data labels are used to display values related to a chart segment. Values from data point(x, y) or other custom properties from a data source can be displayed. 

## Enable Data Label 

To define the data label in the chart, set the [ShowDataLabels]() property to true.The default value of [ShowDataLabels]() property is false. 

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ShowDataLabels="True"
                      ItemsSource="{Binding Data}"  
                      XBindingPath="Name" 
                      YBindingPath="Value"/>
. . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.ShowDataLabels = true;

{% endhighlight %}

{% endtabs %} 

## Context

To customize the content of data labels, need to define [DataLabelSettings]() of chart and set [Context]() property of [PyramidDataLabelSettings]() to change the data label content value.

## LabelPlacement

The [LabelPlacement]() property is used to position the pyramid chart data labels at [DataLabelPlacement.Auto](), [DataLabelPlacement.Inner](), [DataLabelPlacement.Center]() and [DataLabelPlacement.Outer]().The default value of LabelPlacement property is [DataLabelPlacement.Auto]().

## UseSeriesPalette

[UseSeriesPalette]() property is used to set the interior of the chart to the data label background.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ShowDataLabels="True"
                      ItemsSource="{Binding Data}"  
                      XBindingPath="Name" 
                      YBindingPath="Value"/>
. . .
<chart:SfPyramidChart.DataLabelSettings>
    <chart:PyramidDataLabelSettings LabelPlacement="Outer" Context="XValue" UseSeriesPalette="True"/>
</chart:SfPyramidChart.DataLabelSettings>
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.ShowDataLabels = true;
chart.DataLabelSettings = new PyramidDataLabelSettings()
{
    Context=PyramidDataLabelContext.XValue,
    LabelPlacement=DataLabelPlacement.Outer,
    UseSeriesPalette=true,
};

{% endhighlight %}

{% endtabs %} 

![Data label for .NET MAUI Pyramid chart](DataLabel_images/MAUI_data_label.png)

## LabelStyle

Data labels can be customized by using the [DataLabelSettings]() property of the chart. For customizing, need to create an instance of [PyramidDataLabelSettings]() and set to the [DataLabelSettings]() property.The following properties, which are available in [LabelStyle](), are used to customise the data labels. 

* Margin - used to change the margin of the label.
* Background - used to change the label background color.
* FontAttributes - used to change the font style for the data label.
* FontSize - used to change font size of the label.
* Stroke - used to change the stroke color of the data label.
* StrokeWidth - used to change the stroke width of the data label .
* CornerRadius - used to customize the rounded corners for labels.
* TextColor- used to change the text color of the label.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ShowDataLabels="True"
                     ItemsSource="{Binding Data}"  
                     XBindingPath="Name" 
                     YBindingPath="Value"/>
. . .
 <chart:SfPyramidChart.DataLabelSettings>
    <chart:PyramidDataLabelSettings>
        <chart:PyramidDataLabelSettings.LabelStyle>
            <chart:ChartDataLabelStyle Margin="2" 
                                       FontAttributes="Italic" 
                                       FontSize="12" 
                                       CornerRadius="2" 
                                       Stroke="white"
                                       StrokeWidth="1.5"
                                       TextColor="White"/>
        </chart:PyramidDataLabelSettings.LabelStyle>
    </chart:PyramidDataLabelSettings>
 </chart:SfPyramidChart.DataLabelSettings>
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.ShowDataLabels = true;
chart.DataLabelSettings = new PyramidDataLabelSettings();
chart.DataLabelSettings.LabelStyle = new ChartDataLabelStyle()
{
    Margin = 2,
    FontAttributes = FontAttributes.Italic,
    FontSize = 12,
    CornerRadius = 2,
    Stroke = Colors.White,
    StrokeWidth = 1.5,
    TextColor = Colors.White,
};

{% endhighlight %}

{% endtabs %} 

![Customized the data label in MAUI chart](DataLabel_images/MAUI_data_label_style.png)