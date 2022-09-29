---
layout: post
title: Define Range in .NET MAUI Circular ProgressBar control | Syncfusion
description: Learn here all about Range support in Syncfusion .NET MAUI Circular ProgressBar control, its elements and more.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# Define Range in .NET MAUI Circular ProgressBar

The Range represents the entire span of the circular progress bar and can be defined using the `Minimum` and `Maximum` properties. The default value of the range is 0 to 100.

The following code sample demonstrates how to customize the range as factor value to the circular progress bar.

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

![.NET MAUI Circular ProgressBar with range customization](images/define-range/range.png)

N> Refer to our `.NET MAUI Circular ProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Circular ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfCircularProgressBar in .NET MAUI.