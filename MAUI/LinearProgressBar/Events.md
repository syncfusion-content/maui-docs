---
layout: post
title: Events in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about Events support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Events in .NET MAUI SfLinearProgressBar (Linear Progress Bar)

## ProgressChanged

This event is triggered when the progress value is changed. This event contains the following event argument.

* `Progress:` Represents the progress value.

The following code sample demonstrates how to customize the color of a progress indicator based on progress using this event. 

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar x:Name="LinearProgressBar" 
                                 ProgressChanged="LinearProgressBar_ProgressChanged" 
                                 Progress="100" />

{% endhighlight %}

{% highlight c# %}

private void LinearProgressBar_ProgressChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.LinearProgressBar.ProgressFill = Colors.Red;
    }
    else
    {
        this.LinearProgressBar.ProgressFill = Colors.Green;
    }
}

{% endhighlight %}

{% endtabs %} 

## ProgressCompleted

This event is triggered when the `Progress` attains the `Maximum` value. This event contains the following argument.

* `Progress:` Represents the progress value.

The following code sample demonstrates how to customize the progress bar when the progress reaches maximum using this event. 

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar x:Name="LinearProgressBar" 
                                 ProgressCompleted="LinearProgressBar_ProgressCompleted" 
                                 Progress="100" />

{% endhighlight %}

{% highlight c# %}

private void LinearProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
{
    this.LinearProgressBar.ProgressFill = Colors.Green;
}

{% endhighlight %}

{% endtabs %} 

N> Refer to our `.NET MAUI ProgressBar` feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a ProgressBar in .NET MAUI.