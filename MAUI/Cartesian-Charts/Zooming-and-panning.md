---
layout: post
title: Zooming and Panning in .NET MAUI Chart control | Syncfusion
description: Learn here all about Zooming and Panning feature of Syncfusion .NET MAUI Chart(SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Zooming and Panning in .NET MAUI Chart (SfCartesianChart)

`SfCartesianChart` allows you to zoom the chart area with the help of the zoom feature. This behavior is mostly used to view the data point in the specific area, when there are large number of data points inside the chart.

Zooming and panning provides you to take a close-up look of the data point plotted in the series

## Enable Zooming

To enable the zooming and panning in the chart, create an instance of `ChartZoomPanBehavior` and add it to the `ChartBehaviors` collection of `SfCartesianChart`.

{% tabs %}

{% highlight xml %}

    <chart:SfCartesianChart>
        ...
    <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartZoomPanBehavior />
        </chart:SfCartesianChart.ChartBehaviors>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ...
    ChartZoomPanBehavior zooming = new ChartZoomPanBehavior();
    chart.ChartBehaviors.Add(zooming);
    ...

{% endhighlight %}

{% endtabs %}

## Zooming the Plot Area

Zooming the plot area can be achieved by pinch zooming, and also using the properties `ZoomFactor` and `ZoomPosition`.

### Pinch Zooming

Pinch zooming is enable by using the `EnablePinchZooming` property to `true` as shown in the below code snippet.

{% tabs %}

{% highlight xml %}

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartZoomPanBehavior EnablePinchZooming="True"/>
        </chart:SfCartesianChart.ChartBehaviors>
        ...
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ...
    ChartZoomPanBehavior zooming = new ChartZoomPanBehavior()
    {
        EnablePinchZooming = true
    };

    chart.ChartBehaviors.Add(zooming);
    ...

{% endhighlight %}

{% endtabs %}

### Zooming by setting ZoomFactor and ZoomPosition

`ZoomFactor` defines the percentage of visible range from the total range of axis values. `ZoomPosition` defines the position for ranges of values that need to be displayed as a result of `ZoomFactor`. 

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis ZoomFactor="0.3" ZoomPosition="0.5"/>
        </chart:SfCartesianChart.PrimaryAxis>
        ...
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    chart.PrimaryAxis = new CategoryAxis()
    {
        ZoomFactor = 0.3,
        ZoomPosition = 0.5
    };
    ...

{% endhighlight %}

{% endtabs %}

![Zooming support in MAUI Chart](Zooming-and-panning_images/MAUI_chart_zooming.png)

## Zooming Mode

The zooming can be done both horizontally and vertically. The zooming direction is defined by using the `ZoomMode` property.

Following code example illustrates how to restrict the chart to be zoomed only along horizontal axis.

{% tabs %}

{% highlight xml %}

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartZoomPanBehavior ZoomMode="X" />
        </chart:SfCartesianChart.ChartBehaviors>
        ...
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ...
    ChartZoomPanBehavior zooming = new ChartZoomPanBehavior()
    {
        ZoomMode = ZoomMode.X
    };

    chart.ChartBehaviors.Add(zooming);
    ...

{% endhighlight %}

{% endtabs %}

Following code example illustrates how to restrict the chart to be zoomed only along vertical axis.

{% tabs %}

{% highlight xml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.ChartBehaviors>
        <chart:ChartZoomPanBehavior ZoomMode="Y" />
    </chart:SfCartesianChart.ChartBehaviors>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
ChartZoomPanBehavior zooming = new ChartZoomPanBehavior()
{
    ZoomMode = ZoomMode.Y
};

chart.ChartBehaviors.Add(zooming);
...

{% endhighlight %}

{% endtabs %}

## Enable Panning

Panning feature allows moving the visible area of the chart when it is zoomed in. To enable panning, you have to set `EnablePanning` property to `true`.

{% tabs %}

{% highlight xml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.ChartBehaviors>
        <chart:ChartZoomPanBehavior EnablePanning="True"/>
    </chart:SfCartesianChart.ChartBehaviors>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
ChartZoomPanBehavior zooming = new ChartZoomPanBehavior()
{
    EnablePanning = true
};

chart.ChartBehaviors.Add(zooming);
...

{% endhighlight %}

{% endtabs %}