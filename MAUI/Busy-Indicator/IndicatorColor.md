---
layout: post
title: Indicator Color and Background in .NET MAUI Busy Indicator | Syncfusion®
description: Learn here about color support in Syncfusion® .NET MAUI Busy Indicator control (SfBusyIndicator) and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator color, maui busy indicator color, maui busy indicator customize.
---

# Indicator Color and Background in .NET MAUI Busy Indicator

## IndicatorColor

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) allows customization of the indicator's color using the [IndicatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IndicatorColor) property.

{% tabs %}

{% highlight xaml %}

    
<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Searching..."
                      IndicatorColor="Red"/>           
 
{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Searching...",
    IndicatorColor = Colors.Red
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![IndicatorColor](Images/IndicatorColor/IndicatorColor.gif)

## Overlay background

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) also provides an option to customize the overlay background using the [OverlayFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_OverlayFill) property.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Searching..."
                      TextColor="White"
                      IndicatorColor="White"
                      OverlayFill="#512BD4" />       

{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Searching...",
    TextColor = Colors.White,
    IndicatorColor = Colors.White,
    OverlayFill = Color.FromArgb("#512BD4")
};
 
{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![OverlayFill](Images/IndicatorColor/OverlayFillColor.gif)

The [OverlayFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_OverlayFill) property type is `Brush`, which allows setting gradients as the background.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator IsRunning="True" 
                      AnimationType = "CircularMaterial"
                      IndicatorColor="#e64c93" 
                      Title="Searching...">
    <core:SfBusyIndicator.OverlayFill>
        <RadialGradientBrush>
            <GradientStop Color="#44e64c93"
                Offset="0.1" />
            <GradientStop Color="#AA9d40db"
                Offset="1.0" />
        </RadialGradientBrush>
    </core:SfBusyIndicator.OverlayFill>
</core:SfBusyIndicator>  

{% endhighlight %}

{% highlight c# %}
  
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Searching...",
    IndicatorColor = Color.FromArgb("#e64c93"),
    OverlayFill = new RadialGradientBrush()
    {
        GradientStops = new GradientStopCollection()
                            {
                                new GradientStop(){Color= Color.FromArgb("#44e64c93"),Offset= 0.1f},
                                new GradientStop(){ Color = Color.FromArgb("#AA9d40db"), Offset = 1.0f }
                            }
    }

};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![OverlayFill](Images/IndicatorColor/OverlayFillBrush.gif)

