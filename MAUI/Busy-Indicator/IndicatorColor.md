---
layout: post
title: Indicator color and Background in .NET MAUI Busy Indicator control
description: Learn here all about color support in Syncfusion .NET MAUI Busy Indicator control (SfBusyIndicator) and more.
platform: maui
control: BusyIndicator
documentation: ug
---
# Indicator color and Background in .NET MAUI Busy Indicator

## Indicator color in SfBusyIndicator 

SfBusyIndicator provides option to set the color for indicator. This can be done using `IndicatorColor` property.

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

![Indicator Color](Images/IndicatorColor/IndicatorColor.png)

## Overlay Background in SfBusyIndicator

SfBusyIndicator provides option to set the overlay background. This can be done using `OverlayFill` property.

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

![Overlay Fill](Images/IndicatorColor/OverlayFillColor.png)

The `OverlayFill` property type is `Brush`, so you can set Gradients as background.

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

![Overlay Fill](Images/IndicatorColor/OverlayFillBrush.png)

