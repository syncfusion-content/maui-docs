---
layout: post
title: States in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about States support in Syncfusion Xamarin ProgressBar (Progress Bar) control and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# States in .NET MAUI ProgressBar (Progress Bar)

You can configure the states of the progress bar control depending on the usage.

## Determinate

This is the default state. You can use it when the progress estimation is known.

## Indeterminate

By enabling the `IsIndeterminate` property, the state of the progress bar can be changed to indeterminate when the progress cannot be estimated or is not being calculated. It can be combined with determinate mode to know that the application is estimating progress before the actual progress starts.

{% tabs %} 

{% highlight xaml %} 

<!--Using linear progress bar-->

<progressBar:SfLinearProgressBar IsIndeterminate="True"/>

<!--Using circular progress bar-->

<progressBar:SfCircularProgressBar IsIndeterminate="True"/>

{% endhighlight %}

{% highlight c# %}

// Using linear progress bar. 

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar { IsIndeterminate = true};

this.Content = linearProgressBar;

// Using circular progress bar.

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { IsIndeterminate = true };

this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

## Buffer

The secondary task’s progress can be defined using the `SecondaryProgress` property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfLinearProgressBar Progress="25" SecondaryProgress="75"/>

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

linearProgressBar.Progress = 25;

linearProgressBar.SecondaryProgress = 75;

this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![Buffer](images\States\Buffer.png)
