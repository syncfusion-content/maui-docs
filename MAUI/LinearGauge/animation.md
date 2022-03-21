---
layout: post
title: Animation in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing animation of Syncfusion .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Animation in .NET MAUI Linear Gauge (SfLinearGauge)

All Linear Gauge elements including the axis, ticks and labels, range, bar pointer, shape marker pointer, and content marker pointer, can be animated separately. 

## Animate axis

The [`EnableAxisAnimation`]() and [`AnimationDuration`]() properties in [`SfLinearGauge`]() is used to animate the scale along with the ticks and labels. The scale will have a fade-in with opacity animation when this [`EnableAxisAnimation`]() is set to true. By default, the [`EnableAxisAnimation`]() is set to false. 

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge EnableAxisAnimation="True" />

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.EnableAxisAnimation = true;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Animate axis in linear gauge](images/animation/animation_axis.gif)

## Animate range

The [`EnableRangeAnimation`]() and [`AnimationDuration`]() properties in [`SfLinearGauge`]() is used to animate the scale along with the ticks and labels. The range will have a fade-in with opacity animation when this [`EnableRangeAnimation`]() is set to true. By default, the [`EnableRangeAnimation`]() is set to false.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge EnableRangeAnimation="True" />

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.EnableRangeAnimation = true;
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Animate range in linear gauge](images/animation/animation_range.gif)

## Pointer animation

The animation behavior is common for all the three pointers in Linear Gauge - shape, content, and bar pointer.

All the above three pointers have the following properties for the animation:

*  [`EnableAnimation`]() - Enable or disable the animation for pointer. The default value is `false`.
*  [`AnimationDuration`]() - Sets the animation duration. The default value is 1000.
*  [`AnimationEasing`]() - Sets the animation type. 

The [`AnimationEasing`]() supports the following animations. The default animation type is `Easing.Linear`.

* `Linear`

* `SinOut`

* `SinIn`

* `SinInOut`

* `CubicIn`

* `CubicOut`

* `CubicInOut`

* `BounceOut`

* `BounceIn`

* `SpringIn`

* `SpringOut`

### Animate bar pointer

The following code example demonstrates how to update the animation for bar pointer.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:BarPointer Value="70" EnableAnimation="True"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

 SfLinearGauge gauge = new SfLinearGauge();
        gauge.BarPointers.Add(new BarPointer()
        {
            Value = 70,
            EnableAnimation = true,
        });
	this.Content = gauge;

{% endhighlight %}

{% endtabs %}

### Animate marker pointers (Shape and Content Pointers)

Both the shape and content marker pointers will have the same set of properties and behave similarly for animation. 

So, demonstrated the [`LinearShapePointer`]() only but the same is applicable for [`LinearContentPointer`]() too. 

### Marker pointer with `SpringOut` animation

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="70" EnableAnimation="True" 
                              AnimationEasing="{x:Static Easing.SpringOut}"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 70,
			EnableAnimation = true,
			AnimationEasing=Easing.SpringOut
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Animate marker pointer in linear gauge](images/animation/bounceout.gif)





