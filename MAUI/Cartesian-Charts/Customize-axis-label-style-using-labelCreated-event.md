---
layout: post
title: Customize axis label style using labelCreated event | Syncfusion
description: Learn here all about to customize axis label style using labelCreated event in chart axis in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Customize axis label style using labelCreated event

The [`LabelCreated`]() event is triggered upon label creation in a chart axis, providing the option to customize axis labels style.
The [LabelStyle]() property is available to customize the appearance of axis label based on condition.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.XAxes>
            <chart:NumericalAxis LabelCreated="XAxes_LabelCreated"/>
        </chart:SfCartesianChart.XAxes>
        . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% tabs %}

{% highlight c# %}

        //Customize the style of chart axis labels and edit the axis labels using the labelCreated event.
        private void XAxes_LabelCreated(object sender, ChartAxisLabelEventArgs e)
        {
            e.LabelStyle.Background = Colors.LightBlue;
            e.LabelStyle.FontSize = 15;
            e.LabelStyle.CornerRadius = 5;
            e.LabelStyle.StrokeWidth = 2;
            e.LabelStyle.Stroke = Colors.Gray;            
        }
    
{% endhighlight  %}

{% endtabs %}