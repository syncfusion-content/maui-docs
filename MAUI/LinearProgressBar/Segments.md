---
layout: post
title: Segments in .NET MAUI Linear Progress Bar | Syncfusion®
description: Learn about segmented progress visualization and multiple progress sections in Syncfusion® .NET MAUI Linear Progress Bar control.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Segments in .NET MAUI Linear Progress Bar

To visualize the progress of multiple sequential tasks, split the Linear Progress Bar into multiple segments by setting the [`SegmentCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount) property as demonstrated in the following code sample.

{% tabs %}

{% highlight XAML %}

<progressBar:SfLinearProgressBar Progress="25"
                                 SegmentCount="4" />

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Linear Progress Bar with segment](images/segment/segment.png)

## Gap customization

Customize the default spacing between the segments using the [`SegmentGapWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth) property as demonstrated in the following code sample.

{% tabs %}
{% highlight XAML %}

<progressBar:SfLinearProgressBar Progress="25"
                                 SegmentCount="4"
                                 SegmentGapWidth="5" />

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 25;
linearProgressBar.SegmentCount = 4;
linearProgressBar.SegmentGapWidth = 5;
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Linear Progress Bar with segment gap width](images/segment/gap-width.png)

N> Refer to our [.NET MAUI Linear Progress Bar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Linear Progress Bar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfLinearProgressBar in .NET MAUI.