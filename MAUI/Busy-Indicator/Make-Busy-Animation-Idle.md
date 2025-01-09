---
layout: post
title: Make Busy Animation Idle in .NET MAUI Busy Indicator | Syncfusion®
description: Learn here all about Make Busy Animation Idle support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
keywords : .net maui busy indicator idle, maui busy indicator idle, maui busy indicator load, maui busy indicator running.
---
# Make Busy Animation Idle in .NET MAUI Busy Indicator (SfBusyIndicator)

## Make Busy Animation Idle in .NET MAUI Busy Indicator

[.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) control provides support to determine whether an animation needs to be executed or not. Setting the [IsRunning](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IsRunning) property to false will stop the animation and removes the control from view.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      AnimationType="CircularMaterial"
                      IsRunning="false" />

{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    AnimationType = AnimationType.CircularMaterial,                    
    IsRunning = "false"                    
};

{% endhighlight %}

{% endtabs %}

N>  The default value is false.


