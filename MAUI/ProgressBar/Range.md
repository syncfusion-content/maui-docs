---
layout: post
title: Define Range in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about Range support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Define Range in Xamarin ProgressBar (Progress Bar)

Range represents the entire span of the progress bar and can be defined using the [`Minimum`]() and [`Maximum`]() properties. The default value of the range is 0 to 100.

The following code sample demonstrates how to customize the range as factor value to the progress bar.

{% tabs %}  

{% highlight xaml %}

<!--Using linear progress bar-->

<progressBar:SfLinearProgressBar Minimum="0" Progress="0.5" Maximum="1"/>

<!--Using circular progress bar-->

<progressBar:SfCircularProgressBar Minimum="0" Progress="0.5" Maximum="1"/>

{% endhighlight %}

{% highlight c# %}

// Using linear progress bar.

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

linearProgressBar.Minimum = 0;

linearProgressBar.Maximum = 1;

linearProgressBar.Progress = 0.5;

this.Content = linearProgressBar;

// Using circular progress bar.

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();

circularProgressBar.Minimum = 0;

circularProgressBar.Maximum = 1;

circularProgressBar.Progress = 0.5;

this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![range](images/Define_range/range.png)
