---
layout: post
title: States in .NET MAUI Circular Progress Bar | Syncfusion®
description: Learn about determinate and indeterminate states in Syncfusion® .NET MAUI Circular Progress Bar (SfCircularProgressBar) control.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# States in .NET MAUI Circular Progress Bar

Configure the states of the Circular Progress Bar control depending on the usage.

## Determinate

This is the default state. Use it when the progress estimation is known.

## Indeterminate

By enabling the [`IsIndeterminate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate) property, the state of the Circular Progress Bar can be changed to indeterminate when the progress cannot be estimated or is not being calculated. It can be combined with the determinate mode to indicate that the application estimates progress before the actual progress starts.

{% tabs %}

{% highlight XAML %}

<progressBar:SfCircularProgressBar IsIndeterminate="true"/>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { IsIndeterminate = true };
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Circular Progress Bar in indeterminate state](images/states/circular-progressbar-indeterminate.gif)

N> Refer to our [.NET MAUI Circular Progress Bar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Circular Progress Bar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfCircularProgressBar in .NET MAUI.