---
layout: post
title: Animation Type in .NET MAUI Busy Indicator control | Syncfusion®
description: Learn here all about Animation Type support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
keywords : .net maui busy indicator animation type, maui busy indicator animation type, maui busy indicator animation.
---
# Animation Type in .NET MAUI Busy Indicator (SfBusyIndicator)

## Animation Type in .NET MAUI Busy Indicator

The [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) property for the .NET MAUI Busy Indicator allows the users to set one of the animations from the built-in animations. The different types of animations are [CircularMaterial](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_CircularMaterial), [Cupertino](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_Cupertino), and [LinearMaterial.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_LinearMaterial)

### Circular Material 

The CircularMaterial animation is an one of the built-in animations in [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). Refer to the following code example. Here, we’ll set the animation type as [CircularMaterial.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_CircularMaterial)

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

The Cupertino animation is an one of the built-in animations in [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). Refer to the following code example. Here, we’ll set the animation type as [Cupertino](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_Cupertino).

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

The LinearMaterial animation is an one of the built-in animations in [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). Refer to the following code example. Here, we’ll set the animation type as [LinearMaterial](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_LinearMaterial).

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

### Single Circle

The SingleCircle animation is an one of the built-in animations in [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). Refer to the following code example. Here, we’ll set the animation type as [SingleCircle.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_SingleCircle)

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
    AnimationType = AnimationType.SingleCircle;
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Single Circle](Images/AnimationType/SingleCircle.png)

### Double Circle

The DoubleCircle animation is an one of the built-in animations in [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). Refer to the following code example. Here, we’ll set the animation type as [DoubleCircle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_DoubleCircle)

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
    AnimationType = AnimationType.DoubleCircle;
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Double Circle](Images/AnimationType/DoubleCircle.png)

### Globe

The Globe animation is one of the built-in animations in [.NET MAUI BusyIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1). Refer to the following code example. Here, we’ll set the [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) as [Globe.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_Globe)

{% tabs %}

{% highlight xaml %}

    <core:SfBusyIndicator AnimationType="Globe" IsRunning="True"/>                        
                          
{% endhighlight %}

{% highlight C# %}

    SfBusyIndicator busyIndicator = new SfBusyIndicator()
    {
        AnimationType = AnimationType.Globe,
        IsRunning = true
    };

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Global](Images/AnimationType/Globe.gif)

### Horizontal Pulsing Box

The horizontal pulsing box animation is one of the built-in animations in [.NET MAUI BusyIndicator.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) Refer to the following code example. Here, we’ll set the [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) as [HorizontalPulsingBox.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html#Syncfusion_Maui_Core_AnimationType_HorizontalPulsingBox)

{% tabs %}

{% highlight xaml %}

    <core:SfBusyIndicator AnimationType="HorizontalPulsingBox" IsRunning="True"/>                        
                          
{% endhighlight %}

{% highlight C# %}

    SfBusyIndicator busyIndicator = new SfBusyIndicator()
    {
        AnimationType = AnimationType.HorizontalPulsingBox,
        IsRunning = true
    };

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Horizontal Pulsing Box](Images/AnimationType/HorizontalPulsingBox.gif)
