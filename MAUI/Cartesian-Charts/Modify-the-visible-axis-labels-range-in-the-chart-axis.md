---
layout: post
title: Modify the visible axis labels range in the chart axis. | Syncfusion
description: Learn here all about to add custom label to SfCartesianChart axis in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Add custom label to SfCartesianChart axis

ChartAxis provides the OnCreateLabels override method to modify the visible axis labels range in the chart axis. [`OnCreateLabels`]() method called whenever new labels are generated in chart axis. The following properties are available in chart axis to modify the visible axis labels range.

* VisibleLabels - This property of the chart axis can be used to get Observable Collection of visible axis labels.

* VisibleMaximum - This property of the chart axis can be used to get the double value that represents the maximum observable value of the axis range.

* VisibleMinimum - This property of the chart axis can be used to get the double value that represents the minimum observable value of the axis range.

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