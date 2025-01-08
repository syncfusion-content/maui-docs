---
layout: post
title: Sizing in .NET MAUI Busy Indicator control | Syncfusion<sup>®</sup>
description: Learn here all about Sizing support in Syncfusion<sup>®</sup> .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
keywords : .net maui busy indicator size, maui busy indicator size.
---
# Sizing in .NET MAUI Busy Indicator (SfBusyIndicator)

## Sizing in .NET MAUI Busy Indicator

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) offers an option to customize the drawing size of the indicator. [SizeFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_SizeFactor) property can be used to set the height and width of the Indicator. Its default value is 0.5 and ranges from 0 to 1.

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