---
layout: post
title: Animation in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about animation support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Animation in .NET MAUI SfCircularProgressBar (Circular Progress Bar)

The progress bar provides animation support to visualize the progress value changes in an interactive way. 

The following properties are used to define the duration of animation for the specific states.

* `AnimationDuration:` Represents animation duration of the determinate state’s progress indicator.
* `IndeterminateAnimationDuration:` Represents animation duration of the indeterminate state’s indicator.

## Easing effects

The `AnimationEasing` property allows you specify the transfer function that controls animation speed when they run. 

The following code sample demonstrates the `CubicInOut` easing function of the circular progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="75"
                                   AnimationEasing="{x:Static Easing.CubicInOut}"/>

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 75;
circularProgressBar.AnimationEasing = Easing.CubicInOut;
this.Content = circularProgressBar;


{% endhighlight %}

{% endtabs %} 

![.NET MAUI Progress Bar with CubicInOut animation](images/animation/easing-animation.gif)

The `SetProgress()` method in the progress bar is used to set progress value along with animation duration and easing effect applicable for the specific method call.

{% highlight c# %}

void SetProgress(double progress, double? animationDuration = null, Easing? easing = null)

{% endhighlight %}

N> The animation duration and easing effect parameters will not affect the configuration of the `AnimationDuration`and `AnimationEasing` properties.

## Indeterminate Easing Effects

The `IndeterminateAnimationEasing` property allows you to specify a transfer function for indeterminate state, which controls animation speed when they run.

The following code sample demonstrates the `BounceIn` easing function of the circular progress bar.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar IsIndeterminate="True" 
                                   IndeterminateAnimationEasing="{x:Static Easing.BounceIn}" />

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.IsIndeterminate = true;
circularProgressBar.IndeterminateAnimationEasing = Easing.BounceIn;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Progress Bar with indeterminate animation](images/animation/indeterminate.gif)

N> Refer to our `.NET MAUI ProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a ProgressBar in .NET MAUI.