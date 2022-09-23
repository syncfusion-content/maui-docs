---
layout: post
title: States in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about States support in Syncfusion .NET MAUI ProgressBar (Progress Bar) control and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# States in .NET MAUI ProgressBar (Progress Bar)

Configure the states of the progress bar control depending on the usage.

## Determinate

This is the default state. Use it when the progress estimation is known.

## Indeterminate

By enabling the `IsIndeterminate` property, the state of the progress bar can be changed to indeterminate when the progress cannot be estimated or is not being calculated. It can be combined with a determinate mode to know that the application is estimating progress before the actual progress starts.

{% tabs %} 

{% highlight xaml %} 

<!--Using the linear progress bar-->

<progressBar:SfLinearProgressBar IsIndeterminate="True"/>

<!--Using the circular progress bar-->

<progressBar:SfCircularProgressBar IsIndeterminate="True"/>

{% endhighlight %}

{% highlight c# %}

// Using the linear progress bar. 

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar { IsIndeterminate = true};
this.Content = linearProgressBar;

// Using the circular progress bar.

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { IsIndeterminate = true };
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

## Buffer

The secondary task’s progress can be defined using the `SecondaryProgress` property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfLinearProgressBar Progress="25" 
                                 SecondaryProgress="75"/>

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SecondaryProgress = 75;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI ProgressBar with buffer](images\states\buffer.png)

N> Refer to our `.NET MAUI ProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a ProgressBar in .NET MAUI.