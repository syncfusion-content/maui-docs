---
layout: post
title: Segments in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about Segments support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Segments in .NET MAUI ProgressBar (Progress Bar)

To visualize the progress of multiple sequential tasks, split the progress bar into multiple segments by setting the `SegmentCount` property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %}

<!--Using the linear progress bar-->

<progressBar:SfLinearProgressBar Progress="25" 
                                 SegmentCount="4" />

<!--Using the circular progress bar-->

<progressBar:SfCircularProgressBar Progress="25" 
                                   SegmentCount="7" />

{% endhighlight %}

{% highlight c# %}

// Using the linear progress bar.

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;
this.Content = linearProgressBar;

// Using the circular progress bar.

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 25;
circularProgressBar.SegmentCount = 7;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI ProgressBar with segment](images/segment/segment.png)

## Gap customization

Customize the default spacing between the segments using the `SegmentGapWidth` property as demonstrated in the following code sample.

{% tabs %} 
{% highlight xaml %}

<!--Using the linear progress bar-->

<progressBar:SfLinearProgressBar Progress="25" 
                                 SegmentCount="4"
                                 SegmentGapWidth="5" />

<!--Using the circular progress bar-->

<progressBar:SfCircularProgressBar Progress="25"
                                   SegmentCount="7" 
                                   SegmentGapWidth="10" />

{% endhighlight %}

{% highlight c# %}

// Using the linear progress bar.

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;
linearProgressBar.SegmentGapWidth = 5;
this.Content = linearProgressBar;

// Using the circular progress bar.

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 25;
circularProgressBar.SegmentCount = 7;
circularProgressBar.SegmentGapWidth = 10;
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI ProgressBar with segment gap width](images/segment/gap-width.png)

N> Refer to our `.NET MAUI ProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a ProgressBar in .NET MAUI.