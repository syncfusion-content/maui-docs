---
layout: post
title: Modify the visible axis labels count in the chart axis. | Syncfusion
description: Learn here all about modify the visible axis labels count in the chart axis in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Modify the visible axis labels count in the chart axis

[ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) provides the [OnCreateLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_OnLabelCreated_Syncfusion_Maui_Charts_ChartAxisLabel_) override method to modify the visible axis labels count in the chart axis. [OnCreateLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_OnLabelCreated_Syncfusion_Maui_Charts_ChartAxisLabel_) method called whenever new labels are generated in chart axis. The following properties are available in chart axis to modify the visible axis labels count.

* [VisibleLabels]() - This property of the chart axis can be used to get Observable Collection of visible axis labels.

* [VisibleMaximum]() - This property of the chart axis can be used to get the double value that represents the maximum observable value of the axis range.

* [VisibleMinimum]() - This property of the chart axis can be used to get the double value that represents the minimum observable value of the axis range.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
       . . .
       <chart:SfCartesianChart.XAxes>
            <model:CustomNumericalAxis />
       </chart:SfCartesianChart.XAxes>
       . . .
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

            if (VisibleLabels != null)
            {
                //Clear labels in chart axis
                VisibleLabels.Clear();

                //Considered that we need 5 labels. so divided by 5.
                var interval = (VisibleMaximum - VisibleMinimum) / 5;

                var start = VisibleMinimum;
                while (start <= VisibleMaximum)
                {
                    //Add labels to chart axis
                    VisibleLabels.Add(new ChartAxisLabel(start, start.ToString()));
                    start += interval;
                }
            }
        }
    }
    
{% endhighlight  %}

{% endtabs %}