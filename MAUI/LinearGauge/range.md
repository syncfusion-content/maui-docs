---
layout: post
title: Range in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing Range of Syncfusion Flutter Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Range in .NET MAUI Linear Gauge (SfLinearGauge)

A range is a visual element that helps you quickly visualize where a range falls on the axis track. Multiple ranges with different styles can be added to a linear gauge. The default style of range will be as below. 

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange StartValue="20" EndValue="80"/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Ranges.Add(new LinearRange()
		{
			StartValue = 20,
			EndValue = 80,
		});
		this.Content= gauge;

{% endhighlight %}

{% endtabs %}

![Initialize linear gauge for range](images/gauge-range/default-range.png)

## Customize range shape 

A Linear Gauge range has three values to draw a range - [`StartValue`](), and [`EndValue`]().These values indicate where the range falls in the axis. In addition to this values, the shape of the range can be customized by [`StartWidth`](), [`MidWidth`]() and [`EndWidth`]() properties. To draw a line or rectangle, just [`StartValue`](), [`StartWidth`](), [`EndValue`]() and [`EndWidth`]() are enough - as like the above code snippet in `Default Linear Gauge Range` topic. But to draw a concave and convex like shapes, [`MidWidth`]() property is needed. The below code snippet demonstrates how to bring a convex shape for a range.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange StartWidth="70" MidWidth="20" EndWidth="70"/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>


{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Ranges.Add(new LinearRange()
		{
			StartWidth = 70,
			MidWidth = 20,
			EndWidth = 70,
		});
		this.Content= gauge;

{% endhighlight %}

{% endtabs %}

![Draw linear gauge concave range](images/gauge-range/range-convex.png)

For concave shape, override [`UpdateMidRangePath`]() method and curve for mid shape. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge x:Name="gauge">
                <gauge:SfLinearGauge.Ranges>
                    <local:LinearRangeExt StartWidth="70" MidWidth="-20" EndWidth="70"/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Ranges.Add(new LinearRangeExt()
		{
			StartWidth = 70,
			MidWidth = -20,
			EndWidth = 70,
		});
		this.Content= gauge;

...

public class LinearRangeExt : LinearRange
{
    protected override void UpdateMidRangePath(PathF pathF, PointF startPoint, PointF midPoint, PointF endPoint)
    {
        pathF.CurveTo(startPoint, midPoint, endPoint);
    }
}

{% endhighlight %}

{% endtabs %}

![Draw linear gauge concave range](images/gauge-range/range-concave.png)

## Customize color of a range

The color of a range can be changed by setting the [`Fill`]() property of a range. The below code example demonstrates changing the color property of the range.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange Fill="BlueViolet"/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Ranges.Add(new LinearRangeExt()
		{
			Fill = new SolidColorBrush(Colors.BlueViolet),
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set linear gauge range color](images/gauge-range/color_range.png)

## Apply gradient to a range

The gradient can be applied by using the [`GradientStops`]() property of a range. The below code example demonstrates applying a gradient to the range.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange StartWidth="50">
                        <gauge:LinearRange.GradientStops>
                            <gauge:GaugeGradientStop Value="0" Color="Red"/>
                            <gauge:GaugeGradientStop Value="100" Color="Blue"/>
                        </gauge:LinearRange.GradientStops>
                    </gauge:LinearRange>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		ObservableCollection<GaugeGradientStop> gradientStops = new ObservableCollection<GaugeGradientStop>();
		gradientStops.Add(new GaugeGradientStop() { Value = 0, Color = Colors.Red });
		gradientStops.Add(new GaugeGradientStop() { Value = 100, Color = Colors.Blue });
		gauge.Ranges.Add(new LinearRangeExt()
		{
			StartWidth=50,
			GradientStops=gradientStops,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Apply gradient to linear guage range](images/gauge-range/radial_gardient_range.png)


## Customize range position

It is possible to position the ranges `Inside`, `Cross`, and `Outside` the axis. By default, the range will be positioned `Outside` the axis. The [`Position`]() property of the range is used to position the range. The below code snippet demonstrates the same.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange Position="Inside"/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Ranges.Add(new LinearRange()
		{
			Position = GaugeElementPosition.Inside,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Position the linear gauge range](images/gauge-range/range_position.png)

## Setting range color to axis element

You can set range color to axis elements using the [`UseRangeColorForAxis`]() property of axis.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge x:Name="gauge" UseRangeColorForAxis="True">
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange StartValue="0" EndValue="33" Fill="#ffF45656" Position="Cross"/>
                    <gauge:LinearRange StartValue="33" EndValue="66" Fill="#ffFFC93E" Position="Cross"/>
                    <gauge:LinearRange StartValue="66" EndValue="100" Fill="#ff0DC9AB" Position="Cross"/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.UseRangeColorForAxis = true;
		gauge.Ranges.Add(new LinearRange()
		{
			StartValue = 0,
			EndValue = 33,
			Fill=new SolidColorBrush(Color.FromArgb("ffF45656")),
			Position=GaugeElementPosition.Cross
		});
		gauge.Ranges.Add(new LinearRange()
		{
			StartValue = 33,
			EndValue = 66,
			Fill = new SolidColorBrush(Color.FromArgb("ffFFC93E")),
			Position = GaugeElementPosition.Cross
		});
		gauge.Ranges.Add(new LinearRange()
		{
			StartValue = 66,
			EndValue = 100,
			Fill = new SolidColorBrush(Color.FromArgb("ff0DC9AB")),
			Position = GaugeElementPosition.Cross
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set range color to axis element](images/gauge-range/range_userangeforaxis.png)

## Add multiple ranges

You can add multiple ranges for an axis. The below code example demonstrates adding three ranges in a Linear Gauge.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange StartValue="0" EndValue="50" Fill="#ffF45656"/>
                    <gauge:LinearRange StartValue="50" EndValue="70" Fill="#ffFFC93E"/>
                    <gauge:LinearRange StartValue="70" EndValue="100" Fill="#ff0DC9AB"/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.Ranges.Add(new LinearRange()
		{
			StartValue = 0,
			EndValue = 50,
			Fill=new SolidColorBrush(Color.FromArgb("ffF45656")),
		});
		gauge.Ranges.Add(new LinearRange()
		{
			StartValue = 50,
			EndValue = 70,
			Fill = new SolidColorBrush(Color.FromArgb("ffFFC93E")),
		});
		gauge.Ranges.Add(new LinearRange()
		{
			StartValue = 70,
			EndValue = 100,
			Fill = new SolidColorBrush(Color.FromArgb("ff0DC9AB")),
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Add multiple ranges in a linear gauge](images/gauge-range/multiple_ranges.png)

## Range child content support

Range allows you to add any content as its child using the [`Child`]() property.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge x:Name="gauge">
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange StartWidth="40" EndWidth="40" StartValue="0"
                                       EndValue="30" Fill="#fb7d55">
                        <gauge:LinearRange.Child>
                            <Label Text="Bad" HorizontalOptions="Center"
                                   VerticalOptions="Center" TextColor="Black"/>
                        </gauge:LinearRange.Child>
                    </gauge:LinearRange>
                    <gauge:LinearRange StartWidth="40" EndWidth="40" StartValue="30"
                                       EndValue="70" Fill="#e8da5d">
                        <gauge:LinearRange.Child>
                            <Label Text="Good" HorizontalOptions="Center"
                                   VerticalOptions="Center" TextColor="Black"/>
                        </gauge:LinearRange.Child>
                    </gauge:LinearRange>
                    <gauge:LinearRange StartWidth="40" EndWidth="40" StartValue="70"
                                       EndValue="100" Fill="#42c09a">
                        <gauge:LinearRange.Child>
                            <Label Text="Excellent"  HorizontalOptions="Center"
                                   VerticalOptions="Center" TextColor="Black"/>
                        </gauge:LinearRange.Child>
                    </gauge:LinearRange>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		LinearRange range = new LinearRange();
		range.StartValue = 0;
		range.EndValue = 30;
		range.StartWidth = 40;
		range.EndWidth = 40;
		range.Fill = new SolidColorBrush(Color.FromArgb("#fb7d55"));
		range.Child = new Label()
		{
			Text="Bad",
			HorizontalOptions=LayoutOptions.Center,
			VerticalOptions=LayoutOptions.Center,
			TextColor=Colors.Black
		};
		gauge.Ranges.Add(range);
		range = new LinearRange();
		range.StartValue = 30;
		range.EndValue = 70;
		range.StartWidth = 40;
		range.EndWidth = 40;
		range.Fill = new SolidColorBrush(Color.FromArgb("#e8da5d"));
		range.Child = new Label()
		{
			Text = "Good",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			TextColor = Colors.Black
		};
		gauge.Ranges.Add(range);
		range = new LinearRange();
		range.StartValue = 70;
		range.EndValue = 100;
		range.StartWidth = 40;
		range.EndWidth = 40;
		range.Fill = new SolidColorBrush(Color.FromArgb("#42c09a"));
		range.Child = new Label()
		{
			Text = "Excellent",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			TextColor = Colors.Black
		};
		gauge.Ranges.Add(range);
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Child support for linear gauge range](images/gauge-range/range_child_support.png)