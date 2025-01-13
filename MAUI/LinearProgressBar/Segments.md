---
layout: post
title: Segments in .NET MAUI Linear ProgressBar control | Syncfusion<sup>&reg;</sup>
description: Learn here all about Segments support in Syncfusion<sup>&reg;</sup> .NET MAUI Linear ProgressBar control, its elements and more.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Segments in .NET MAUI Linear ProgressBar (SfLinearProgressBar)

To visualize the progress of multiple sequential tasks, split the linear progress bar into multiple segments by setting the [`SegmentCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount) property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="25" 
                                 SegmentCount="4" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with segment](images/segment/segment.png)

## Gap customization

Customize the default spacing between the segments using the [`SegmentGapWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth) property as demonstrated in the following code sample.

{% tabs %} 
{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="25" 
                                 SegmentCount="4"
                                 SegmentGapWidth="5" />

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;
linearProgressBar.SegmentGapWidth = 5;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with segment gap width](images/segment/gap-width.png)

N> Refer to our [.NET MAUI Linear ProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Linear ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfLinearProgressBar in .NET MAUI.