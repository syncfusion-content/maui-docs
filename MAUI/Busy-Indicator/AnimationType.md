---
layout: post
title: Animation Type in .NET MAUI Busy Indicator Control | Syncfusion®
description: Learn here all about AnimationType support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator animation type, maui busy indicator animation type, maui busy indicator animation.
---
# Animation Type in .NET MAUI Busy Indicator (SfBusyIndicator)

The [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) property for the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) allows users to set one of the built-in animations. By default, the animation type is `CircularMaterial`. The different types of animations are [CircularMaterial](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_CircularMaterial), [Cupertino](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_Cupertino), [LinearMaterial](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_LinearMaterial), [SingleCircle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_SingleCircle), [DoubleCircle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_DoubleCircle), [Globe](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_Globe) and [HorizontalPulsingBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_HorizontalPulsingBox).

## Prerequisites

Before using the [`SfBusyIndicator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/busy-indicator/getting-started) documentation.

### CircularMaterial 

The CircularMaterial animation is one of the built-in animations in the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). It displays a circular material-style progress animation. Refer to the following code example where we set the animation type as [CircularMaterial](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_CircularMaterial).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![CircularMaterial](Images/AnimationType/CircularMaterial.gif)

### Cupertino

The Cupertino animation is one of the built-in animations in the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). It displays an iOS-style activity indicator and is best suited for iOS targets. Refer to the following code example where we set the animation type as [Cupertino](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_Cupertino).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="Cupertino" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.Cupertino,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Cupertino](Images/AnimationType/Cupertino.gif)

### LinearMaterial

The LinearMaterial animation is one of the built-in animations in the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). It displays a horizontal material-style progress animation. Refer to the following code example where we set the animation type as [LinearMaterial](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_LinearMaterial).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="LinearMaterial" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.LinearMaterial,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![LinearMaterial](Images/AnimationType/LinearMaterial.gif)

### SingleCircle

The SingleCircle animation is one of the built-in animations in the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). It displays a single rotating circle animation. Refer to the following code example where we set the animation type as [SingleCircle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_SingleCircle).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="SingleCircle" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.SingleCircle,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![SingleCircle](Images/AnimationType/SingleCircle.png)

### DoubleCircle

The DoubleCircle animation is one of the built-in animations in the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). It displays two concentric rotating circles. Refer to the following code example where we set the animation type as [DoubleCircle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_DoubleCircle).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="DoubleCircle" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.DoubleCircle,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![DoubleCircle](Images/AnimationType/DoubleCircle.png)

### Globe

The Globe animation is one of the built-in animations in the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). It displays a rotating globe-style animation. Refer to the following code example where we set the [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) as [Globe](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_Globe).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="Globe" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.Globe,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Globe](Images/AnimationType/Globe.gif)

### HorizontalPulsingBox

The HorizontalPulsingBox animation is one of the built-in animations in the [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). It displays a row of horizontally pulsing boxes. Refer to the following code example where we set the [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) as [HorizontalPulsingBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_HorizontalPulsingBox).

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="HorizontalPulsingBox" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.HorizontalPulsingBox,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![HorizontalPulsingBox](Images/AnimationType/HorizontalPulsingBox.gif)

## See Also

- [Sizing in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/sizing)
- [Animation duration in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/duration)
- [Header in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/set-header)