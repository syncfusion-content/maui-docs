---
layout: post
title: Define Range in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about Range support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Define Range in .NET MAUI ProgressBar (Progress Bar)

The Range represents the entire span of the progress bar and can be defined using the `Minimum` and `Maximum` properties. The default value of the range is 0 to 100.

The following code sample demonstrates how to customize the range as factor value to the progress bar.

{% tabs %}  

{% highlight xaml %}

<progressBar:SfCircularProgressBar Minimum="0" 
                                   Progress="0.5" 
                                   Maximum="1"/>

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Minimum = 0;
circularProgressBar.Maximum = 1;
circularProgressBar.Progress = 0.5;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI ProgressBar with range customization](images/define-range/range.png)

N> Refer to our `.NET MAUI ProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a ProgressBar in .NET MAUI.