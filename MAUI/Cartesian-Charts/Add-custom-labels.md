---
layout: post
title: Add custom labels to the chart axis. | Syncfusion®
description: Learn here all about how to add custom labels to the chart axis in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
Keywords: .net maui chart custom axis labels, .net maui chart axis label customization, sfCartesianchart custom axis labels in .net maui, .net maui chart axis label customization.
---

# Add custom labels to the chart axis

[ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) provides the [OnCreateLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_OnCreateLabels) override method to add custom axis labels. The [OnCreateLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_OnCreateLabels) method is called whenever new labels are generated. The following properties are available to add custom labels.

* [VisibleLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_VisibleLabels) - This property is used to get an Observable Collection of visible axis labels.

* [VisibleMaximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_VisibleMaximum) - This property is used to get the double value that represents the maximum observable value of the axis range.

* [VisibleMinimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_VisibleMinimum) - This property is used to get the double value that represents the minimum observable value of the axis range.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <model:CustomNumericalAxis/>
    </chart:SfCartesianChart.XAxes>
    . . .
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CustomNumericalAxis primaryAxis = new CustomNumericalAxis();
chart.XAxes.Add(primaryAxis);
. . .
this.Content = chart;
    
{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}

public class CustomNumericalAxis : NumericalAxis
{
    //Adding a custom axis label is achieved by displaying the axis label only on the x-axis values in the CustomNumericalAxis of the chart.
    
    protected override void OnCreateLabels()
    {
        base.OnCreateLabels();

        if (VisibleLabels != null)
        {
            VisibleLabels.Clear();

            ViewModel viewModel = BindingContext as ViewModel;

            for (int i = 0; i < viewModel.Data.Count; i++)
            {
                var data = viewModel.Data[i];
                VisibleLabels.Add(new ChartAxisLabel(data.XValue, data.XValue.ToString()));
            }
        }
    }
}
    
{% endhighlight  %}

{% endtabs %}

![Add custom labels to chart axis](How-to_images/MAUI_Add_custom_labels.png)

N> This applies to all types of axes. Labels are rendered only if the label position presents within the visible range. The labels should be created only if users call the base of `OnCreateLabels`.