---
layout: post
title: Animation in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing animation of Syncfusion .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Animation in .NET MAUI Linear Gauge (SfLinearGauge)

All Linear Gauge elements such as axis along with ticks and labels, range, bar pointer, shape marker pointer and content marker pointer can be animated separately. 

## Animate axis

The [`EnableAxisAnimation`]() and [`AnimationDuration`]() properties in [`SfLinearGauge`]() is used to  animate the axis track along with the ticks and labels. The axis will have a fade-in with opacity animation when this [`EnableAxisAnimation`]() is set to true. By default, the [`EnableAxisAnimation`]() is set to false. 

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

![Animate axis in linear gauge](images/animation/animation_axis_range/animation_axis.gif)

## Animate range

The [`EnableRangeAnimation`]() and [`AnimationDuration`]() properties in [`SfLinearGauge`]() is used to  animate the axis track along with the ticks and labels. The range will be have a fade-in with opacity animation when this [`EnableRangeAnimation`]() is set to true. By default, the [`EnableRangeAnimation`]() is set to false. 

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

![Animate range in linear gauge](images/animation/animation_axis_range/animation_range.gif)

## Pointer animation

The animation behavior is common for all the three pointers in Linear Gauge - shape, content and bar pointer. 

All the above three pointers have the below properties for animation. 

*  [`EnableAnimation`]() - Enable or disable the animation for pointer. The default value is `false`
*  [`AnimationDuration`]() - Sets the animation duration. The default value is 1000
*  [`AnimationEasing`]() - Sets the animation type. 

The [`AnimationEasing`]() supports the below animations. The default animation type is `Easing.Linear`.

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

The below code example demonstrates updating the animation for bar pointer.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="70" EnableAnimation="True"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 70,
			EnableAnimation = true,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

### Animate marker pointers (Shape and Content Pointers)

Both the shape and content marker pointers will have the same set of properties and behave similarly for animation. So we have demonstrated the [`LinearShapePointer`]() only but the same is applicable for [`LinearContentPointer`]() too. 

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

![Animate marker pointer in linear gauge](images/animation/shape-pointer/cubicout.gif)





