---
layout: post
title: Sizing in .NET MAUI Busy Indicator control | Syncfusion®
description: Learn here all about Sizing support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: MAUI
control: Busy Indicator
documentation: UG
keywords : .NET MAUI Busy Indicator Size, MAUI Busy Indicator Size
---
# Sizing in .NET MAUI Busy Indicator (SfBusyIndicator)

## Overview

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) provides an option to customize the drawing size of the indicator using the [SizeFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_SizeFactor) property. This property sets the height and width of the indicator, with default values of 0.5, and allows a range from 0 to 1.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."                            
                      SizeFactor="0.7"/>           

{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    SizeFactor = 0.7
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Size Factor](Images/Sizing/Sizefactor.png)