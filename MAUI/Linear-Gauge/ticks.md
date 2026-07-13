---
layout: post
title: Ticks in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing Ticks of Syncfusion<sup>&reg;</sup> .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Ticks in .NET MAUI Linear Gauge (SfLinearGauge)

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Linear Gauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/linear-gauge/getting-started)** guide.

The default style of scale ticks is as follows.

![Initialize .NET MAUI Linear Gauge for axis](images/getting-started/default_linear_gauge.PNG)

## Customize Tick Style

There are two types of ticks in the .NET MAUI Linear Gauge namely major and minor ticks. In the above image, the larger ticks are major ticks and the ticks between the major ticks are minor ticks. The major and minor ticks of a [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1) can be customized using the [`MajorTickStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MajorTickStyle) and [`MinorTickStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MinorTickStyle) properties. Both properties accept a [`LinearTickStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearTickStyle.html) object (which derives from [`GaugeTickStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeTickStyle.html)). The following properties can be customized for both the major and the minor ticks:
* [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeTickStyle.html#Syncfusion_Maui_Gauges_GaugeTickStyle_StrokeProperty) – Customizes the tick color. Accepts a `Brush` value.
* [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeTickStyle.html#Syncfusion_Maui_Gauges_GaugeTickStyle_StrokeThicknessProperty) – Customizes the thickness of ticks.
* [`Length`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeTickStyle.html#Syncfusion_Maui_Gauges_GaugeTickStyle_LengthProperty) – Specifies the length of ticks.
* [`StrokeDashArray`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeTickStyle.html#Syncfusion_Maui_Gauges_GaugeTickStyle_StrokeDashArrayProperty) – Specifies the dash array of ticks.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MajorTickStyle>
                    <gauge:LinearTickStyle Length="25" Stroke="Red" 
                                           StrokeThickness="2" 
                                           StrokeDashArray="2,3"/>
                </gauge:SfLinearGauge.MajorTickStyle>
                <gauge:SfLinearGauge.MinorTickStyle>
                    <gauge:LinearTickStyle Length="15" Stroke="Blue" 
                                           StrokeThickness="1" 
                                           StrokeDashArray="2,2"/>
                </gauge:SfLinearGauge.MinorTickStyle>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();

		DoubleCollection collection = new DoubleCollection();
		collection.Add(2);
		collection.Add(3);
		gauge.MajorTickStyle = new LinearTickStyle()
		{
			Length = 25,
			Stroke = new SolidColorBrush(Colors.Red),
			StrokeThickness = 2,
			StrokeDashArray = collection
		};
		
		collection = new DoubleCollection();
		collection.Add(2);
		collection.Add(2);
		gauge.MinorTickStyle = new LinearTickStyle()
		{
			Length = 15,
			Stroke = new SolidColorBrush(Colors.Blue),
			StrokeThickness = 1,
			StrokeDashArray = collection
		};

		this.Content= gauge;

{% endhighlight %}

{% endtabs %}

![Customize the .NET MAUI Linear Gauge axis tick style](images/axis-ticks/axis-tick-style.PNG)

## Customize Minor Tick Interval

The major ticks are generated based on the [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Interval) property, which defines the interval between major ticks. For more details, refer to the [`Customize the interval between labels`](https://help.syncfusion.com/maui/linear-gauge/labels#customize-interval-between-labels) topic. The minor ticks are calculated using the [`MinorTicksPerInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MinorTicksPerInterval) property of [`SfLinearGauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1). By default, the value of this property is 1.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge MinorTicksPerInterval="4"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MinorTicksPerInterval = 4;
		this.Content= gauge;

{% endhighlight %}

{% endtabs %}

![Customize .NET MAUI Linear Gauge ticks per interval](images/axis-ticks/minor-ticks-per-interval.PNG)

## Change Tick Visibility

The [`ShowTicks`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowTicks) property of the scale is used to enable or disable the visibility of both the major and the minor ticks. The default value of this property is true.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge ShowTicks="False"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.ShowTicks = false;
		this.Content= gauge;

{% endhighlight %}

{% endtabs %}

![Customize .NET MAUI Linear Gauge ticks visibility](images/axis-ticks/linear-gauge-tick-visibility.PNG)

## Customize Tick Position

The linear scale allows you to position the ticks either inside or outside the scale track using the [`TickPosition`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_TickPosition) property. The available positions are [`Inside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html#Syncfusion_Maui_Gauges_GaugeElementPosition_Inside), [`Outside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html#Syncfusion_Maui_Gauges_GaugeElementPosition_Outside), and [`Cross`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html#Syncfusion_Maui_Gauges_GaugeElementPosition_Cross). By default, ticks are positioned inside the scale track. N> The [`LabelPosition`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelPosition) property is also set to `Outside` in the sample below for visual consistency. For details, refer to the [labels](https://help.syncfusion.com/maui/linear-gauge/labels) topic.


{% tabs %}

{% highlight xaml %}

  <gauge:SfLinearGauge  TickPosition="Outside" LabelPosition="Outside">
                
  </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.TickPosition = GaugeElementPosition.Outside;
		gauge.LabelPosition = GaugeLabelsPosition.Outside;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set .NET MAUI Linear Gauge tick position](images/axis-ticks/label-placement.PNG)


## Customize Tick Offset

The ticks can be moved near or far to the scale line using the [`TickOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_TickOffset) property. The offset is specified in device-independent units. The default value of tick offset is `double.NaN`, which means the offset is auto-calculated. When setting an offset for the ticks, the scale labels move with the ticks.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge TickOffset="20"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.TickOffset = 20;
		this.Content= gauge;

{% endhighlight %}

{% endtabs %}

![Customize .NET MAUI Linear Gauge ticks offset from axis](images/axis-ticks/customize-tick-offset.PNG)

