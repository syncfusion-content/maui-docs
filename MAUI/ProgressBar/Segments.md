---
layout: post
title: Segments in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about Segments support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Segments in .NET MAUI ProgressBar (Progress Bar)

To visualize the progress of multiple sequential tasks, split the progress bar into multiple segments by setting the [`SegmentsCount`]() property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %}
<!--Using linear progress bar-->

<progressBar:SfLinearProgressBar Progress="25" SegmentCount="4" />

<!--Using circular progress bar-->

<progressBar:SfCircularProgressBar Progress="25" SegmentCount="7" />

{% endhighlight %}

{% highlight c# %}

// Using linear progress bar.

linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;

// Using circular progress bar.

circularProgressBar.Progress = 25
circularProgressBar.SegmentCount = 7;

{% endhighlight %}

{% endtabs %} 

![Segment](overview_images/Segment.png)

**Gap customization**

You can also customize the default spacing between the segments using the [`GapWidth`]() property as demonstrated in following code sample.

{% tabs %} 
{% highlight xaml %}

<!--Using linear progress bar-->

<progressBar:SfLinearProgressBar Progress="25" SegmentCount="4" GapWidth="5" />

<!--Using circular progress bar-->

<progressBar:SfCircularProgressBar Progress="25" SegmentCount="7" GapWidth="10" />

{% endhighlight %}

{% highlight c# %}
// Using linear progress bar.

linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;
inearProgressBar.GapWidth = 5;

// Using circular progress bar.

circularProgressBar.Progress = 25
circularProgressBar.SegmentCount = 7;
circularProgressBar.GapWidth = 10;

{% endhighlight %}

{% endtabs %} 

![Gap](overview_images/Gap.png)
