---
layout: post
title: Set Header in .NET MAUI Busy Indicator control | Syncfusion®
description: Learn here all about Set Header support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: MAUI
control: Busy Indicator
documentation: UG
keywords : .NET MAUI Busy Indicator Title, MAUI Busy Indicator Title, MAUI Busy Indicator Header, MAUI Busy Indicator Title Placement
---
# Set Header in .NET MAUI Busy Indicator (SfBusyIndicator)

## Overview

The Syncfusion<sup>®</sup> .NET MAUI Busy Indicator provides a feature to display a title with customizable fonts.

## Title

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) allows you to set text that indicates loading-related information using the [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_Title) property.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..." />

{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title](Images/SetHeader/Setheader.png)

## Text Color

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) allows you to change the color of the title text using the [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TextColor) property.

{% tabs %}

{% highlight xaml %}
  
<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" />           
       
{% endhighlight %}

{% highlight c# %}
   
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Color](Images/SetHeader/TitleColor.png)


## Title Placement

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) provides options to set the [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_Title) at the top or bottom of the Busy Indicator using the [TitlePlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TitlePlacement) property. To omit the title, set the [TitlePlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TitlePlacement) property to `None`.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" 
                      TitlePlacement="Top"/>           

{% endhighlight %}

{% highlight c# %}
  
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    TitlePlacement = BusyIndicatorTitlePlacement.Top
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Placement](Images/SetHeader/TitlePlacement.png)


## Title Spacing

You can set the space between the indicator and the title using the [TitleSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TitleSpacing) property.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" 
                      TitlePlacement="Top"
                      TitleSpacing="20"/>           

{% endhighlight %}

{% highlight c# %}

    
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    TitlePlacement = BusyIndicatorTitlePlacement.Top,
    TitleSpacing = 20
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Spacing](Images/SetHeader/Spacing.png)


## Font Customization

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) allows customization of the title text using properties such as [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontSize), [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontAttributes), and [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontFamily) properties.


{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" 
                      FontSize = "16"
                      FontAttributes="Bold"
                      FontFamily="serif" />           
 
{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    FontSize = 16,
    FontAttributes=FontAttributes.Bold,
    FontFamily="serif"
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Font Customization](Images/SetHeader/Fontattributes.png)

## Font Auto Scaling Enabled

The `FontAutoScalingEnabled` property automatically scales the Busy Indicator's title font size based on the operating system's text size. The default value of the `FontAutoScalingEnabled` property is `false`.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator FontAutoScalingEnabled="True"/>

{% endhighlight %}

{% highlight c# %}

    
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    FontAutoScalingEnabled = true
};

{% endhighlight %}

{% endtabs %}