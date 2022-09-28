---
layout: post
title: Segments in .NET MAUI SfCircularProgressBar control | Syncfusion
description: Learn here all about Segments support in Syncfusion .NET MAUI SfCircularProgressBar control, its elements and more.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# Segments in .NET MAUI SfCircularProgressBar (Circular Progress Bar)

To visualize the progress of multiple sequential tasks, split the circular progress bar into multiple segments by setting the `SegmentCount` property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="25" 
                                   SegmentCount="7" />

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 25;
circularProgressBar.SegmentCount = 7;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI SfCircularProgressBar with segment](images/segment/segment.png)

## Gap customization

Customize the default spacing between the segments using the `SegmentGapWidth` property as demonstrated in the following code sample.

{% tabs %} 
{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="25"
                                   SegmentCount="7" 
                                   SegmentGapWidth="10" />

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 25;
circularProgressBar.SegmentCount = 7;
circularProgressBar.SegmentGapWidth = 10;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI SfCircularProgressBar with segment gap width](images/segment/gap-width.png)

N> Refer to our `.NET MAUI SfCircularProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI SfCircularProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfCircularProgressBar in .NET MAUI.