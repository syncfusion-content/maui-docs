---
layout: post
title: States in .NET MAUI Circular ProgressBar control | Syncfusion<sup>&reg;</sup>
description: Learn all about states support in the Syncfusion<sup>&reg;</sup> .NET MAUI Circular ProgressBar (SfCircularProgressBar) control.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# States in .NET MAUI Circular ProgressBar (SfCircularProgressBar)

Configure the states of the circular progress bar control depending on the usage.

## Determinate

This is the default state. Use it when the progress estimation is known.

## Indeterminate

By enabling the [`IsIndeterminate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate) property, the state of the circular progress bar can be changed to indeterminate when the progress cannot be estimated or is not being calculated. It can be combined with the determinate mode to indicate that the application estimates progress before the actual progress starts.

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

![.NET MAUI Circular ProgressBar in indeterminate state](images/states/circular-progressbar-indeterminate.gif)

N> Refer to our [.NET MAUI Circular ProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Circular ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfCircularProgressBar in .NET MAUI.