---
layout: post
title: Add custom label to SfCartesianChart axis | Syncfusion
description: Learn here all about to add custom label to SfCartesianChart axis in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Add custom label to SfCartesianChart axis

ChartAxis provides the OnCreateLabels override method to add custom label to chart axis. [`OnCreateLabels`]() method called whenever new labels are generated in chart axis.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        .........

       <chart:SfCartesianChart.XAxes>
            <model:CustomNumericalAxis />
        </chart:SfCartesianChart.XAxes>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();
    .......
    CustomNumericalAxis primaryAxis = new CustomNumericalAxis();
    chart.XAxes.Add(primaryAxis);
    
{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}

    public class CustomNumericalAxis : NumericalAxis
    {
        protected override void OnCreateLabels()
        {
            base.OnCreateLabels();

        }
    }
    
{% endhighlight  %}

{% endtabs %}

## VisibleMaximum

The VisibleMaximum property of the chart axis can be used only to get the double value that represents the maximum observable value of the axis range in runtime.

## VisibleMinimum
The VisibleMinimum property of the chart axis can be used only to get the double value that represents the minimum observable value of the axis range in runtime.