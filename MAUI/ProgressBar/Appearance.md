---
layout: post
title: Appearance in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about appearance support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Appearance in .NET MAUI ProgressBar (Progress Bar)

## Angle

The appearance of the circular progress bar can be customized to semi-circle, arc, etc. The start and end angles can be customized using the [`StartAngle`]() and [`EndAngle`]() properties. 

The following code sample demonstrates how to change the appearance of the circular progress bar to semi-circle.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="75" StartAngle="180" EndAngle="360" />

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();

circularProgressBar.Progress = 75;

circularProgressBar.StartAngle = 180;

circularProgressBar.EndAngle = 360;

{% endhighlight %}

{% endtabs %} 

![angle]()

## Range colors

You can visualize the multiple ranges with different colors that are mapped to each range to enhance the readability of progress. 

The colors can be mapped to the specific ranges using the [`GradientStops`]() property, which holds a collection of [`ProgressGradientStop`](). 

The following properties in the [`GradientStops`]() are used to map the colors to a range:

* [`Color`](): Represents the color to the specified range.
* [`Value`]():

The following code sample demonstrates how to map the solid color range in the progress bar.

{% tabs %} 

{% highlight xaml %}


{% endhighlight %}

{% highlight c# %}

// Using linear progress bar.



{% endhighlight %}

{% endtabs %} 

![rangecolors]()

The following code sample demonstrates how to apply gradient transition effect to the range colors in the linear progress bar.

{% tabs %} 

{% highlight xaml %}

{% endhighlight %}

{% highlight c# %}

{% endhighlight %}

{% endtabs %} 

![gradient]()

## Thickness

### Linear progress bar

In the linear progress bar, the height of the track, progress and secondary progress can be customized using the [`TrackHeight`]() and [`ProgressHeight`]() and [`SecondaryProgressHeight`]() properties, respectively.

{% tabs %} 

{% highlight xaml %}

{% endhighlight %}

{% highlight c# %}


{% endhighlight %}

{% endtabs %} 

![thickness_linear]()

### Circular progress bar

The following properties are used to customize the appearance of the circular progress bar:

* [`IndicatorOuterRadius`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorOuterRadius): Defines the outer radius of the progress indicator.
* [`IndicatorInnerRadius`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorInnerRadius): Defines the inner radius of the progress indicator.
* [`TrackOuterRadius`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackOuterRadius): Defines the outer radius of the track indicator.
* [`TrackInnerRadius`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackInnerRadius): Defines the inner radius of the track indicator.

The following code sample demonstrates how to customize the appearance of circular progress bar.

{% tabs %} 

{% highlight xaml %}

<!--Circular progress bar with radius customization -->

<progressBar:SfCircularProgressBar x:Name="TrackOutsideProgressBar" Grid.Column="0" Grid.Row="0"
                                   Progress="75" Margin="0,10,0,0" IndicatorOuterRadius="0.7" 
                                   IndicatorInnerRadius="0.65" ShowProgressValue="False">
</progressBar:SfCircularProgressBar>       

{% endhighlight %}

{% highlight c# %}
SfCircularProgressBar trackOutsideProgressBar = new SfCircularProgressBar();

trackOutsideProgressBar.Progress = 75;

trackOutsideProgressBar.IndicatorOuterRadius = 0.7;

trackOutsideProgressBar.IndicatorInnerRadius = 0.65;

trackOutsideProgressBar.ShowProgressValue = false;

{% endhighlight %}

{% endtabs %} 

![appearance](overview_images/appearance.png)

## Corner radius

The [`CornerRadius`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_CornerRadius) property is used to customize the rounded edges in the linear progress bar as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %}
<progressBar:SfLinearProgressBar Progress="50" TrackHeight="10" CornerRadius="10">

</progressBar:SfLinearProgressBar>

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

linearProgressBar.Progress = 50;

linearProgressBar.CornerRadius = 10;

{% endhighlight %}

{% endtabs %} 

![cornerradius](overview_images/cornerradius.png)

## Color customization

The following properties are used to customize the color in the progress bar:

* [`ProgressColor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressColor): Represents the color of the progress indicator.
* [`TrackColor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_TrackColor): Represents the color of the track indicator.

The following code sample demonstrates the color customization in progress and track indicator.

{% tabs %} 

{% highlight xaml %}
<progressBar:SfLinearProgressBar Progress="75" TrackColor="#3351483a" ProgressColor="#FF51483a">

</progressBar:SfLinearProgressBar>

{% endhighlight %}

{% highlight c# %}
SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

linearProgressBar.Progress = 75;

linearProgressBar.ProgressColor = Color.FromHex("FF51483a");

linearProgressBar.TrackColor = Color.FromHex("3351483a");

{% endhighlight %}

{% endtabs %} 

![color1](overview_images/color1.png)

The linear progress bar provides support to customize the color for the secondary progress bar using the [`SecondaryProgressColor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryProgressColor) property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %}
<progressBar:SfLinearProgressBar Progress="25" SecondaryProgress="75" SecondaryProgressColor="CornflowerBlue"></progressBar:SfLinearProgressBar>
{% endhighlight %}

{% highlight c# %}
SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

linearProgressBar.Progress = 25;

linearProgressBar.SecondaryProgress = 75;

linearProgressBar.SecondaryProgressColor = Color.CornflowerBlue;

{% endhighlight %}

{% endtabs %} 

![color2](overview_images/color2.png)

