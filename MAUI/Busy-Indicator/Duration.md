---
layout: post
title: Animation Duration in .NET MAUI Busy Indicator control | Syncfusion
description: Learn here all about Animation Duration support in Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
---
# Animation Duration in .NET MAUI Busy Indicator (SfBusyIndicator)

## Animation Duration in SfBusyIndicator

The `DurationFactor` property of SfBusyIndicator can be used to set the animation speed based on given value. Setting smaller duration value accelerates animation speed. Its default value is 0.5 and ranges from 0 to 1. 

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
    AnimationType = AnimationType.CircularMaterial;
    DurationFactor= 0.2
};


{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Animation Duration](Images/Duration/Duration.gif)





