---
layout: post
title: Get the touch position in Syncfusion SfCartesianChart
description: Get the touch position in SfCartesianChart
platform: maui
control: SfCartesianChart
documentation: ug
---

# Get the touch position in SfCartesianChart

ChartInteractiveBehavior provides the following override methods to get the x and y positions when touching the [`SfCartesianChart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

* [`OnTouchUp`]() - Called when a user lifts their finger or releases their touch input from the Chart area. 
* [`OnTouchMove`]() - Called when a user's finger or touch input device is in contact with the Chart area and moves across its surface.
* [`OnTouchDown`]() -  Called when the user makes the initial contact of a user's finger or touch input device with the Chart Area.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        .........

        <chart:SfCartesianChart.InteractiveBehavior>
                <local:ChartInteractiveExt/>
        </chart:SfCartesianChart.InteractiveBehavior>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();
    .......
    
    ChartInteractiveExt interactiveExt = new ChartInteractiveExt();
    chart.Behaviors.Add(interactiveExt);

    Content = chart;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}

    public class ChartInteractiveExt: ChartInteractiveBehavior
    {
        protected override void OnTouchDown(ChartBase chart, float pointX, float pointY)
        {
            base.OnTouchDown(chart, pointX, pointY);
        }

        protected override void OnTouchMove(ChartBase chart, float pointX, float pointY)
        {
            base.OnTouchMove(chart, pointX, pointY);
        }

        protected override void OnTouchUp(ChartBase chart, float pointX, float pointY)
        {
            base.OnTouchUp(chart, pointX, pointY);
        }
    }

{% endhighlight  %}

{% endtabs %}

To enhance your understanding, you can explore  
[How to Add Data Points on Interactions in .NET MAUI Chart (SfCartesianChart)?](https://support.syncfusion.com/kb/article/13602/how-to-add-data-points-on-interactions-in-net-maui-chart-sfcartesianchart)
