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
                        Title="Loading..."
                        IndicatorColor="Red"/>           
 
{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    IndicatorColor = Colors.Red
};

{% endhighlight %}

{% endtabs %}



## Overlay Background in SfBusyIndicator

SfBusyIndicator provides option to set the overlay background. This can be done using `OverlayFill` property.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                        IsRunning="True"
                        AnimationType="CircularMaterial"
                        Title="Loading..."
                        IndicatorColor="Red"
                        OverlayFill = "DarkViolet"/>           

{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    IndicatorColor = Colors.Red,
    OverlayFill = Colors.DarkViolet
};
 
{% endhighlight %}

{% endtabs %}


The `OverlayFill` property type is `Brush`, so you can set Gradients as background.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator IsRunning="True" 
                        AnimationType = "CircularMaterial"
                        IndicatorColor="#e64c93" 
                        Title="Loading...">
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
    Title = "Loading...",
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

The following screenshot illustrates the indicator color and background of SfBusyIndicator.

![IndicatorColor and OverlayFill](Images/IndicatorColor/Indicator_Background.png)

