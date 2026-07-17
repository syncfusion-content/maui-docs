---
layout: post
title: Sizing in .NET MAUI Busy Indicator Control | Syncfusion®
description: Learn here all about Sizing support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator size, maui busy indicator size
---
# Sizing in .NET MAUI Busy Indicator (SfBusyIndicator)

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) lets you customize the size of the indicator using the [SizeFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_SizeFactor) property. **Type:** `double`. It sets both the height and width of the indicator. The default value is `0.5`, and the valid range is `0` to `1` (where `0` is the smallest and `1` is the largest).

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

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      SizeFactor="0.7" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    SizeFactor = 0.7,
};
this.Content = busyIndicator;

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![SizeFactor](Images/Sizing/Sizefactor.png)

### Using a smaller SizeFactor

The following example sets `SizeFactor` to `0.3` to make the indicator smaller.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      SizeFactor="0.3" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    SizeFactor = 0.3,
};
this.Content = busyIndicator;

{% endhighlight %}

{% endtabs %}