---
layout: post
title: Get the touch position in Syncfusion SfCartesianChart
description: Learn here all about getting the touch position in SfCartesianChart in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart touch position, maui chart touch position, .net maui chart touch event, sfcartesianchart touch interaction in .net maui, .net maui chart touch gesture, .net maui chart touch behavior.
---

# Get the touch position in SfCartesianChart

[ChartInteractiveBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartInteractiveBehavior.html) provides the following override methods to get the x and y positions when touching the [`SfCartesianChart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

* [`OnTouchUp`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBehavior.html#Syncfusion_Maui_Charts_ChartBehavior_OnTouchUp_Syncfusion_Maui_Charts_ChartBase_System_Single_System_Single_) - Called when a user lifts their finger or releases their touch input from the Chart area. 
* [`OnTouchMove`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBehavior.html#Syncfusion_Maui_Charts_ChartBehavior_OnTouchMove_Syncfusion_Maui_Charts_ChartBase_System_Single_System_Single_) - Called when a user's finger or touch input device is in contact with the Chart area and moves across its surface.
* [`OnTouchDown`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBehavior.html#Syncfusion_Maui_Charts_ChartBehavior_OnTouchDown_Syncfusion_Maui_Charts_ChartBase_System_Single_System_Single_) -  Called when the user makes the initial contact of a user's finger or touch input device with the Chart Area.

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

this.Content = chart;

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

