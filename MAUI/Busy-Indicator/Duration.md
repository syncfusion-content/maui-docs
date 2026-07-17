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

The [DurationFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_DurationFactor) property of the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) controls the animation speed. **Type:** `double`. The default value is `0.5`, and the valid range is `0` to `1` (where `0` is the fastest and `1` is the slowest).

> **Prerequisites:** Add the `Syncfusion.Maui.Core` NuGet package to your .NET MAUI project. Refer to the [Getting Started](Getting-Started.md) documentation to set up the control.

N> Ensure that the following namespace is added in your XAML page for using SfBusyIndicator.

{% tabs %}

{% highlight xaml %}

xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

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