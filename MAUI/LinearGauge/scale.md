---
layout: post
title: Axis in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing Axis of Syncfusion .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge

documentation: ug
---

# Axis in .NET MAUI Linear Gauge (SfLinearGauge)

The Linear Gauge axis is a scale where a set of values can be plotted. An axis can be customized by changing the thickness, color and edge styles. Axis elements such as labels and ticks can also be easily customized and you can also inverse the axis.

## Default axis

By default axis will have the [`Minimum`]() axis value as 0 and the [`Maximum`]() axis value as 100. Without any changes the default axis of the Linear Gauge will be displayed as follows. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge />

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Initialize linear gauge for axis](images/getting-started/default_linear_gauge.PNG)

## Customize minimum and maximum axis values

The [`Minimum`]() and [`Maximum`]() properties of a Linear Gauge can be used to customize the axis values. In the below code snippet the axis is customized to have the [`Minimum`]() value of -50 to [`Maximum`]() value of 50. The axis values are displayed by the labels. Customizing these label styles are further explained in next topics.  

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge  Minimum="-50" Maximum="50" />

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.Minimum=-50;
gauge.Maximum=50;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Update linear gauge for axis scale](images/axis/minmax_axis_linear_gauge.PNG)

## Customize scale orientation

The orientation of linear scale can be customized by using the [`Orientation`]() property of linear gauge.

When the Orientation property is Vertical, the axis will be rendered in bottom-to-top direction.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge Orientation="Vertical"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Orientation = GaugeOrientation.Vertical;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Update orientation for axis scale](images/axis/linear_gauge_orientation.PNG)

## Customize axis track style

The linear axis track can be customized using the [`LineStyle`]() property. The [`LineStyle`]() has the following properties.

* [`Thickness`]() – Customizes the thickness of the axis track.
* [`Fill`]() – Customizes the color of the axis track with a solid color.
* [`GradientStops`]() - Customizes the color of the axis track with a gradient.
* [`CornerRadius`]() - Customizes the axis track edge corners.
* [`CornerStyle`]() - Customizes the axis track edge style as flat or curve.

The following code sample demonstrates how to customize the [`Thickness`]() and [`Fill`]() properties.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.LineStyle>
                    <gauge:LinearLineStyle Thickness="15"/>
                </gauge:SfLinearGauge.LineStyle>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();

		gauge.LineStyle.Thickness = 15;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change axis track thickness in linear gauge](images/axis/axis_thickness.PNG)

## Apply solid color

The below code snippet sets solid colors to the axis track.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.LineStyle>
                    <gauge:LinearLineStyle Fill="Blue"/>
                </gauge:SfLinearGauge.LineStyle>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.LineStyle.Fill = new SolidColorBrush(Colors.Blue);
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Apply color to axis in linear guage](images/axis/axis_solid_color.PNG)

## Apply gradient

The [`Fill`]() property of [`LineStyle`]() allows to set a solid color, while the [`GradientStops`]() property of [`LineStyle`]() allows to apply linear-gradient to axis track.

The following code sample sets gradient colors to the axis track.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.LineStyle>
                    <gauge:LinearLineStyle>
                        <gauge:LinearLineStyle.GradientStops>
                            <gauge:GaugeGradientStop Value="0" Color="Red"/>
                            <gauge:GaugeGradientStop Value="100" Color="Blue"/>
                        </gauge:LinearLineStyle.GradientStops>
                    </gauge:LinearLineStyle>
                </gauge:SfLinearGauge.LineStyle>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.LineStyle.GradientStops.Add(new GaugeGradientStop() { Value = 0, Color = Colors.Red });
		gauge.LineStyle.GradientStops.Add(new GaugeGradientStop() { Value = 100, Color = Colors.Blue });
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Apply color to axis in linear guage](images/axis/axis_gradient.PNG)

## Customize corners

The [`CornerStyle`]() property of [`LineStyle`]() specifies the corner type for the axis track. The corners can be customized with `BothFlat`, `BothCurve`, `StartCurve`, and `EndCurve` options. The default value of this property is `BothFlat`.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.LineStyle>
                    <gauge:LinearLineStyle Thickness="20" CornerStyle="BothCurve"/>
                </gauge:SfLinearGauge.LineStyle>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.LineStyle.Thickness = 20;
		gauge.LineStyle.CornerStyle = CornerStyle.BothCurve;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change axis track edge style](images/axis/axis_corner_style.PNG)

Also [`CornerRadius`]() allows to set custom corner style for linear scale. 

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                 <gauge:SfLinearGauge.LineStyle>
                    <gauge:LinearLineStyle Thickness="20" CornerRadius="0,10,0,10"/>
                </gauge:SfLinearGauge.LineStyle>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.LineStyle.Thickness = 20;
		gauge.LineStyle.CornerRadius = new Thickness(0, 10, 0, 10);
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change axis track edge style](images/axis/axis_corner_radius.PNG)

N> If you set both [`CornerStyle`]() and [`CornerRadius`]() in the [`LineStyle`](), [`CornerStyle`]() will be first priority for scale. 

## Inverse the axis

The direction of linear gauge axis can be customized by the [`IsInversed`]() property.
When the [`IsInversed`]() property is true, the axis can be placed in an inverse direction. The default value of the [`IsInversed`]() property is false.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge IsInversed="True">
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.IsInversed = true;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

You can see that the axis values are displayed from 100 to 0 as the axis track is inversed.

![Inverse linear gauge for axis](images/axis/axis_inversed.PNG)

## Change axis track visibility

You can hide the axis track by setting the [`ShowLine`]() property to false. The default value of this property is true.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge ShowLine="False">
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.ShowLine = false;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Hide linear gauge axis track](images/axis/hide_axis_track.PNG)

## Customize axis values

Linear gauge allows you to display a set of values along with a custom axis based on your business logic by using the [`GenerateVisibleLabels`](),[`ValueToFactor`]() and [`FactorToValue`]() callbacks.

{% tabs %}

{% highlight xaml %}

 <local:LinearGauge Minimum="1" Maximum="10000">
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="1000" />
                </gauge:SfLinearGauge.MarkerPointers>
            </local:LinearGauge>

{% endhighlight %}

{% highlight c# %}

public class LinearGauge : SfLinearGauge
{
    int labelsCount;
    public override List<GaugeLabelInfo> GenerateVisibleLabels()
    {
        List<GaugeLabelInfo> labelInfos = new List<GaugeLabelInfo>();
        int minimum = (int)LogBase(this.Minimum, 10);
        int maximum = (int)LogBase(this.Maximum, 10);
        for (int i = minimum; i <= maximum; i++)
        {
            double value = Math.Floor(Math.Pow(10, i)); // logBase  value is
            GaugeLabelInfo label = new GaugeLabelInfo()
            {
                Value = value,
                Text = value.ToString()
            };
            labelInfos.Add(label);
        }

        labelsCount = labelInfos.Count;
        return labelInfos;
    }

    private double LogBase(double value, int baseValue)
    {
        return Math.Log(value) / Math.Log(baseValue);
    }

    public override double ValueToFactor(double value)
    {
        return LogBase(value, 10) / (labelsCount - 1);
    }

    public override double FactorToValue(double factor)
    {
        return Math.Pow(Math.E, factor * (labelsCount - 1) * Math.Log(10));
    }
}

{% endhighlight %}

{% endtabs %}

![Custom axis track](images/axis/custom_axis.PNG)