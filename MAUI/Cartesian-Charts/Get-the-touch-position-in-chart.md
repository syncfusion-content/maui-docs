---
layout: post
title: Get the touch position in Syncfusion SfCartesianChart
description: Get the touch position in SfCartesianChart
platform: maui
control: SfCartesianChart
documentation: ug
---

ChartInteractiveBehavior provides the following override methods to get the x and y positions when touch the [`SfCartesianChart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

* [`OnTouchUp`]() - Called when a user lifts their finger or release their touch input from the Chart area. 
* [`OnTouchMove`]() - Called when a user's finger or touch input device is in contact within the Chart area and moves across it's surface.
* [`OnTouchDown`]() -  Called when the user made the initial contact of a user's finger or touch input device with the Chart Area.

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