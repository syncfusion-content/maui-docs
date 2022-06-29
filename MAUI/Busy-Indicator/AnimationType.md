---
layout: post
title: Animation Type in .NET MAUI Busy Indicator control | Syncfusion
description: Learn here all about Animation Type support in Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
---
# Animation Type in .NET MAUI Busy Indicator (SfBusyIndicator)

## Animation Type in SfBusyIndicator

The `AnimationType` property for the SfBusyIndicator allows the users to set one of the animations from the built-in animations. The different types of animations are `CircularMaterial,` `LinearMaterial,` and `Cupertino.`

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
    AnimationType = AnimationType.CircularMaterial;
};

{% endhighlight %}

{% endtabs %}

The following gif image contains the types of animation in BusyIndicator.

![Animation Types](Images/AnimationType/AnimationType.gif)
