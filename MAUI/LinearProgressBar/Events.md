---
layout: post
title: Events in .NET MAUI Linear Progress Bar | Syncfusion®
description: Learn about events supported in Syncfusion® .NET MAUI Linear Progress Bar (SfLinearProgressBar) control for progress tracking and user interactions.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Events in .NET MAUI Linear Progress Bar

## ProgressChanged

This event is triggered when the progress value is changed. This event contains the following argument.

* [`Progress:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html#Syncfusion_Maui_ProgressBar_ProgressValueEventArgs_Progress) Represents the progress value.

The following code sample demonstrates how to customize the color of a progress indicator based on progress using this event.

{% tabs %}

{% highlight XAML %}

<progressBar:SfLinearProgressBar x:Name="linearProgressBar"
                                 ProgressChanged="OnProgressChanged"
                                 Progress="100" />

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;

private void OnProgressChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.linearProgressBar.ProgressFill = Colors.Red;
    }
    else
    {
        this.linearProgressBar.ProgressFill = Colors.Green;
    }
}

{% endhighlight %}

{% endtabs %}

## ProgressCompleted

This event is triggered when the [`Progress`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress) reaches the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Maximum) value. This event contains the following argument.

* [`Progress:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html#Syncfusion_Maui_ProgressBar_ProgressValueEventArgs_Progress) Represents the progress value.

The following code sample demonstrates how to customize the progress bar when the progress reaches the maximum using this event.

{% tabs %}

{% highlight XAML %}

<progressBar:SfLinearProgressBar x:Name="linearProgressBar"
                                 ProgressCompleted="OnProgressCompleted"
                                 Progress="100" />

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;

private void OnProgressCompleted(object sender, ProgressValueEventArgs e)
{
    this.linearProgressBar.ProgressFill = Colors.Green;
}

{% endhighlight %}

{% endtabs %}

N> Refer to our [.NET MAUI Linear Progress Bar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Linear Progress Bar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfLinearProgressBar in .NET MAUI.