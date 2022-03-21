---
layout: post
title: Labels in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing Labels of Syncfusion .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Labels in .NET MAUI Linear Gauge (SfLinearGauge)

The default style of axis labels is as follows.

![Initialize linear gauge for axis](images/getting-started/default_linear_gauge.PNG)

## Customize label styles

Axis labels can be customized using the [`LabelStyle`]() property of [`SfLinearGauge`](). The [`LabelStyle`]() property has the following properties to customize the axis labels.

* `TextColor` – Allows to customize the color of the labels.
* `FontFamily` – Allows to specify the font family for labels.
* `FontAttributes` – Allows to specify the font weight for labels.
* `FontSize` – Allows to specify the font size for labels.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.LabelStyle>
                    <gauge:GaugeLabelStyle FontAttributes="Bold" FontSize="15" 
                                           TextColor="Red" FontFamily="TimesNewRoman"/>
                </gauge:SfLinearGauge.LabelStyle>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.LabelStyle.FontSize = 15;
		gauge.LabelStyle.FontFamily = "TimesNewRoman";
		gauge.LabelStyle.TextColor = Colors.Red;
		gauge.LabelStyle.FontAttributes = FontAttributes.Bold;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize linear gauge axis label style](images/axis-labels/customize_label_style.PNG)

## Change visibility

The [`ShowLabels`]() property of [`SfLinearGauge`]() allows you to show or hide the visibility of axis labels. The default value of this property is true.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge ShowLabels="False">
                
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.ShowLabels = false;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change visibility](images/axis-labels/axis_label_visibility.PNG)

## Customize interval between labels

The [`Interval`]() between labels can be customized using the [`Interval`]() property of [`SfLinearGauge`](). The major ticks are generated based on this [`Interval`]() property.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge Interval="20">
                
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Interval = 20;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set label interval in axis track](images/axis-labels/axis_label_interval.PNG)

## Change label position

The linear axis allows to position the labels either `Inside` or `Outside` the axis track using the [`LabelPosition`]() property. By default, labels are positioned `Inside` the axis track.

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

![Set linear gauge label position](images/axis-labels/label-placement.PNG)

## Change label offset

The [`LabelOffset`]() property allows you to adjust the distance between the tick-end and the labels. 

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge LabelOffset="20"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.LabelOffset = 20;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set linear gauge label offset](images/axis-labels/label_offset.PNG)

##  Customize maximum number of visible labels

By default, a maximum of three labels is displayed for every 100 logical pixels in an axis. The maximum number of labels that should present within 100 logical pixels length can be customized using the [`MaximumLabelsCount`]() property of the axis. 

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge MaximumLabelsCount="1"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MaximumLabelsCount = 1;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set maximum number of labels in axis track](images/axis-labels/axis_maximum_labels.PNG)

## Customize label text

You can format or change the whole numeric label text using the [`LabelCreated`]() event.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge LabelCreated="Gauge_LabelCreated"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.LabelCreated += Gauge_LabelCreated;
		this.Content = gauge;

...

private void Gauge_LabelCreated(object sender, LabelCreatedEventArgs e)
{
		if (e.Text == "0")
			e.Text = "Start";
		else if (e.Text == "50")
			e.Text = "Mid";
		else if (e.Text == "100")
			e.Text = "End";
}

{% endhighlight %}

{% endtabs %}

![Customize Label Text in axis track](images/axis-labels/custom_label_text.PNG)

## Label format

The [`LabelFormat`]() property is used to format the numeric labels. The default value of this property is null.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge LabelFormat="C" Interval="25"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.LabelFormat = "C";
		gauge.Interval = 25;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize Label Format in Axis Label](images/axis-labels/axis_label_number_format.PNG)