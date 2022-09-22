---
layout: post
title: Animation in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about animation support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Animation in .NET MAUI ProgressBar (Progress Bar)

The progress bar provides animation support to visualize the progress value changes in an interactive way. 

The following properties are used to define the duration of animation for the specific states:

* `AnimationDuration`: Represents animation duration of the determinate state’s progress indicator.
* `SecondaryAnimationDuration`: Represents animation duration of the determinate state’s secondary progress indicator.
* `IndeterminateAnimationDuration`: Represents animation duration of the indeterminate state’s indicator.

## Easing effects

The `AnimationEasing` property allows you specify the transfer function that controls animation speed when they run. 

The following code sample demonstrates the `CubicInOut` easing function of the linear progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="75" 
                                 AnimationEasing="{x:Static Easing.CubicInOut}" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 75;
linearProgressBar.AnimationEasing = Easing.CubicInOut;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

The `SetProgress()` method in the progress bar is used to set progress value along with animation duration and easing effect applicable for the specific method call.

{% highlight c# %}

void SetProgress(double progress, double? animationDuration = null, Easing? easing = null)

{% endhighlight %}

N> The animationDuration and easingEffect parameters will not affect the configuration of the `AnimationDuration`and `AnimationEasing` properties.

## Indeterminate Easing Effects

The `IndeterminateAnimationEasing` property allows you to specify a transfer function for indeterminate state, which controls animation speed when they run.

The following code sample demonstrates the `BounceIn` easing function of the linear progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar IsIndeterminate="True" 
                                 IndeterminateAnimationEasing="{x:Static Easing.BounceIn}" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.IsIndeterminate = true;
linearProgressBar.IndeterminateAnimationEasing = Easing.BounceIn;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 
