---
layout: post
title: Clear and add custom label using memeber, visiable ranges | Syncfusion
description: Learn here all about to clear and add custom label using memeber, visiable ranges in SfCartesianChart in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Clear and add custom label using memeber, visiable ranges

Create a CustomNumericalAxis class that inherits from the NumericalAxis class to clear and add custom label to chart axis. You need to override the OnCreateLabels method, which will be called whenever new labels are generated. Use the VisibleLabels property to add, clear, or modify the labels.The following code sample demonstrates this.

{% tabs %}

{% highlight xml %}

<chart:SfCartesianChart>
    ...
        <chart:SfCartesianChart.XAxes>
            <model:CustomNumericalAxis />
        </chart:SfCartesianChart.XAxes>

{% endhighlight %}

{% highlight c# %}

public class CustomNumericalAxis : NumericalAxis
{
    protected override void OnCreateLabels()
    {
        base.OnCreateLabels();

        if (VisibleLabels != null)
        {
            VisibleLabels.Clear();

            VisibleLabels.Clear();
            ViewModel viewModel = BindingContext as ViewModel;

            for (int i = 0; i < viewModel.Data2.Count; i++)
            {
                var data = viewModel.Data2[i];
                VisibleLabels.Add(new ChartAxisLabel(data.XValue, data.XValue.ToString()));
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}