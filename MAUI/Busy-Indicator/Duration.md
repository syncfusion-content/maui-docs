---
layout: post
title: Animation Duration in .NET MAUI Busy Indicator Control | Syncfusion®
description: Learn here all about Animation Duration support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator duration, maui busy indicator duration
---

# Animation Duration in .NET MAUI Busy Indicator (SfBusyIndicator)

## Prerequisites

Before using the [`SfBusyIndicator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/busy-indicator/getting-started) documentation.

The [DurationFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_DurationFactor) property of the `.NET MAUI Busy Indicator` controls the animation speed. **Type:** `double`. The default value is `0.5`, and the valid range is `0` to `1` (where `0` is the fastest and `1` is the slowest).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      DurationFactor="0.2" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    DurationFactor = 0.2,
};
this.Content = busyIndicator;

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Duration](Images/Duration/Duration.gif)

### Using DurationFactor with other animation types

The `DurationFactor` property works with any of the built-in animation types. The following example demonstrates it with the `Globe` animation.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="Globe"
                      DurationFactor="0.8" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.Globe,
    DurationFactor = 0.8,
};
this.Content = busyIndicator;

{% endhighlight %}

{% endtabs %}