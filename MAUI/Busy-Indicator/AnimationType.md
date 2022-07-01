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

The `AnimationType` property for the SfBusyIndicator allows the users to set one of the animations from the built-in animations. The different types of animations are `CircularMaterial,` `Cupertino,` and `LinearMaterial.`

### Circular Material 

The CircularMaterial animation is an one of the built-in animations in SfBusyIndicator. Refer to the following code example. Here, we’ll set the animation type as `CircularMaterial`.

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

The following gif image illustrates the result of the above code.

![Circular Material](Images/AnimationType/CircularMaterial.gif)

### Cupertino

The Cupertino animation is an one of the built-in animations in SfBusyIndicator. Refer to the following code example. Here, we’ll set the animation type as `Cupertino`.

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
    AnimationType = AnimationType.Cupertino;
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Cupertino](Images/AnimationType/Cupertino.gif)

### Linear Material

The LinearMaterial animation is an one of the built-in animations in SfBusyIndicator. Refer to the following code example. Here, we’ll set the animation type as `LinearMaterial`.

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
    AnimationType = AnimationType.LinearMaterial;
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Linear Material](Images/AnimationType/LinearMaterial.gif)
