---
layout: post
title: Indicator color and Background in Syncfusion<sup>®</sup> .NET MAUI Busy Indicator.
description: Learn here all about color support in Syncfusion<sup>®</sup> .NET MAUI Busy Indicator control (SfBusyIndicator) and more.
platform: maui
control: BusyIndicator
documentation: ug
keywords : .net maui busy indicator color, maui busy indicator color, maui busy indicator customize.
---
# Indicator color and Background in .NET MAUI Busy Indicator

## Indicator color in .NET MAUI Busy Indicator 

[.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) provides an option to customize the color of the indicator. This can be done using the [IndicatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IndicatorColor) property.

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

![Indicator Color](Images/IndicatorColor/IndicatorColor.gif)

## Overlay Background in SfBusyIndicator

[.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) provides an option to customize the overlay background. This can be done using the [OverlayFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_OverlayFill)  property.

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

![Overlay Fill](Images/IndicatorColor/OverlayFillColor.gif)

The [OverlayFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_OverlayFill) property type is `Brush`, so you can set Gradients as background.

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

![Overlay Fill](Images/IndicatorColor/OverlayFillBrush.gif)

