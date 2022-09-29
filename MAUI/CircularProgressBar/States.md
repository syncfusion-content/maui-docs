---
layout: post
title: States in .NET MAUI SfCircularProgressBar control | Syncfusion
description: Learn here all about States support in Syncfusion .NET MAUI SfCircularProgressBar (Progress Bar) control and more.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# States in .NET MAUI Circular ProgressBar (SfCircularProgressBar)

Configure the states of the circular progress bar control depending on the usage.

## Determinate

This is the default state. Use it when the progress estimation is known.

## Indeterminate

By enabling the `IsIndeterminate` property, the state of the circular progress bar can be changed to indeterminate when the progress cannot be estimated or is not being calculated. It can be combined with a determinate mode to know that the application estimates progress before the actual progress starts.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfCircularProgressBar IsIndeterminate="True"/>

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { IsIndeterminate = true };
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

N> Refer to our `.NET MAUI SfCircularProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI SfCircularProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfCircularProgressBar in .NET MAUI.