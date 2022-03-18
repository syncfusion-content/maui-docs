---
layout: post
title: Ticks in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing Ticks of Syncfusion .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Ticks in .NET MAUI Linear Gauge (SfLinearGauge)

The default style of axis ticks is as follows.

![Initialize linear gauge for axis](images/getting-started/default_linear_gauge.png)

## Customize tick style

There are two types of ticks in the .NET MAUI Linear Gauge namely major and minor ticks. In the above image, the larger ticks are major ticks and the ticks between the major ticks are minor ticks. The major and minor tick of a [`SfLinearGauge`]() can be customized using the [`MajorTickStyle`]() and [`MinorTickStyle`]() properties. The following properties can be customized for both the major and the minor ticks:
* [`Stroke`]() – Allows to customize the tick color.
* [`StrokeThickness`]() – Allows to customize the thickness of ticks.
* [`Length`]() – Specifics the length of ticks.
* [`StrokeDashArray`]() – Specifics the dash array of ticks.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MajorTickStyle>
                    <gauge:LinearTickStyle Length="25" Stroke="Red" StrokeThickness="2" StrokeDashArray="2,3"/>
                </gauge:SfLinearGauge.MajorTickStyle>
                <gauge:SfLinearGauge.MinorTickStyle>
                    <gauge:LinearTickStyle Length="15" Stroke="Blue" StrokeThickness="1" StrokeDashArray="2,2"/>
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

![Customize the linear gauge axis tick style](images/axis-ticks/axis-tick-style.png)

## Customize minor tick interval

The major ticks are generated based on the [`Interval`]() property which is documented in `Customize the interval between labels` topic. The minor ticks are calculated using the [`MinorTicksPerInterval`]() property of [`SfLinearGauge`](). By default, the value of this property is 1.

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

![Customize linear gauge ticks per interval](images/axis-ticks/minor-ticks-per-interval.png)

## Change tick visibility

The [`ShowTicks`]() property of the axis is used to enable or disable the visibility of both the major and the minor ticks. The default value of this property is true.

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

![Customize linear gauge ticks visibility](images/axis-ticks/linear-gauge-tick-visibility.png)

## Customize tick position

The linear axis allows to position the ticks either inside or outside the axis track using the [`TickPosition`]() property. By default, ticks are positioned inside the axis track.


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

![Set linear gauge tick position](images/axis-labels/label-placement.png)


## Customize tick offset

The ticks can be moved near or far to the axis line using the [`TickOffset`]() property. The default value of tick offset is double.NaN. While setting offset for the ticks, the axis labels are also moved along with the ticks.

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

![Customize linear gauge ticks offset from axis](images/axis-ticks/customize-tick-offset.png)

