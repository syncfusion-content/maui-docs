---
layout: post
title: Get the touch position in Syncfusion SfPolarChart
description: Learn here all about how to get the touch position in SfPolarChart.
platform: maui
control: SfPolarChart
documentation: ug
---

# Get the touch position in SfPolarChart

[ChartInteractiveBehavior]() provides the following override methods to get the x and y positions when touching the [`SfPolarChart`]().

* [`OnTouchUp`]() - Called when a user lifts their finger or releases their touch input from the Chart area. 
* [`OnTouchMove`]() - Called when a user's finger or touch input device is in contact with the Chart area and moves across its surface.
* [`OnTouchDown`]() -  Called when the user makes the initial contact of a user's finger or touch input device with the Chart area.

{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart>
        .........

        <chart:SfPolarChart.InteractiveBehavior>
                <local:ChartInteractiveExt></local:ChartInteractiveExt>
        </chart:SfPolarChart.InteractiveBehavior>

    </chart:SfPolarChart>

{% endhighlight %}

{% highlight C# %}

    SfPolarChart chart = new SfPolarChart();
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