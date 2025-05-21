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

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) control provides support to determine if an animation needs to be executed. Setting the [IsRunning](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IsRunning) property to `false` will stop the animation and remove the control from view.

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

N>  The default value for the [IsRunning](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IsRunning) property is `false`.


