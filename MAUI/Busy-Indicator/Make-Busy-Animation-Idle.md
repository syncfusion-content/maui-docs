---
layout: post
title: Make Busy Animation Idle in .NET MAUI Busy Indicator | Syncfusion®
description: Learn here all about Make Busy Animation Idle support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator idle, maui busy indicator idle, maui busy indicator load, maui busy indicator running.
---
# Make Busy Animation Idle in .NET MAUI Busy Indicator (SfBusyIndicator)

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) lets you control whether the animation is running. Setting the [IsRunning](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IsRunning) property to `false` stops the animation and hides the indicator.

## Prerequisites

Before using the [`SfBusyIndicator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/busy-indicator/getting-started) documentation.

## Stop the animation (idle)

Use `IsRunning="False"` to stop the animation and hide the indicator.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      AnimationType="CircularMaterial"
                      IsRunning="False" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    AnimationType = AnimationType.CircularMaterial,
    IsRunning = false,
};

{% endhighlight %}

{% endtabs %}

N>  The default value for the [IsRunning](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IsRunning) property is `false`.

## Start the animation (running)

Set `IsRunning="True"` to display the indicator and start the animation.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      AnimationType="CircularMaterial"
                      IsRunning="True" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    AnimationType = AnimationType.CircularMaterial,
    IsRunning = true,
};

{% endhighlight %}

{% endtabs %}

## See Also

- [Animation types in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/animationtype)
- [Animation duration in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/duration)