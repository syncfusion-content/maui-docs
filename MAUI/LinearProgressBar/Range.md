---
layout: post
title: Define Range in .NET MAUI Linear ProgressBar control | Syncfusion
description: Learn here all about Range support in Syncfusion .NET MAUI Linear ProgressBar control, its elements and more.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Define Range in .NET MAUI Linear ProgressBar (SfLinearProgressBar)

The Range represents the entire span of the linear progress bar and can be defined using the `Minimum` and `Maximum` properties. The default value of the range is 0 to 100.

The following code sample demonstrates how to customize the range as factor value to the linear progress bar.

{% tabs %}  

{% highlight xaml %}

<progressBar:SfLinearProgressBar Minimum="0" 
                                 Progress="0.5" 
                                 Maximum="1"/>


{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Minimum = 0;
linearProgressBar.Maximum = 1;
linearProgressBar.Progress = 0.5;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with range customization](images/define-range/range.png)

N> Refer to our `.NET MAUI Linear ProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Linear ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfLinearProgressBar in .NET MAUI.