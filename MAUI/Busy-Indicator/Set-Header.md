---
layout: post
title: Set Header in .NET MAUI Busy Indicator Control | Syncfusion®
description: Learn here all about Set Header support in Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator title, maui busy indicator title, maui busy indicator header, maui busy indicator title placement
---

# Set Header in .NET MAUI Busy Indicator (SfBusyIndicator)

The Syncfusion<sup>®</sup> [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) allows you display a title and customize its font. This section covers the title, its color, placement, spacing, and font customization.

## Prerequisites

Before using the [`SfBusyIndicator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/busy-indicator/getting-started) documentation.

## Title

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) allows you set text that describes the loading state using the [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_Title) property. The default value is an empty string.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..." />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
};

{% endhighlight %}

{% endtabs %}

The following image illustrates the result of the above code.

![Title](Images/SetHeader/Setheader.png)

## TextColor

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) allows you change the color of the title text using the [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TextColor) property.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor="Red" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
};

{% endhighlight %}

{% endtabs %}

The following image illustrates the result of the above code.

![TitleColor](Images/SetHeader/TitleColor.png)

## TitlePlacement

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) provides options to set the `Title` at the top or bottom of the Busy Indicator using the [TitlePlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TitlePlacement) property. The valid values are `Top`, `Bottom`, and `None` (to omit the title). The default value is `Bottom`.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor="Red"
                      TitlePlacement="Top" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    TitlePlacement = BusyIndicatorTitlePlacement.Top,
};

{% endhighlight %}

{% endtabs %}

The following image illustrates the result of the above code.

![TitlePlacement](Images/SetHeader/TitlePlacement.png)

## TitleSpacing

You can set the space between the indicator and the title using the [TitleSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TitleSpacing) property. The default value is `10`.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor="Red"
                      TitlePlacement="Top"
                      TitleSpacing="20" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    TitlePlacement = BusyIndicatorTitlePlacement.Top,
    TitleSpacing = 20,
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![TitleSpacing](Images/SetHeader/Spacing.png)

## Font customization

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html) allows you customize the title text using the [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontSize) (`double`), [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontAttributes) (`FontAttributes` enum), and [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontFamily) (`string`) properties.


{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor="Red"
                      FontSize="16"
                      FontAttributes="Bold"
                      FontFamily="serif" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    FontSize = 16,
    FontAttributes = FontAttributes.Bold,
    FontFamily = "serif",
};

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Font customization](Images/SetHeader/Fontattributes.png)

## FontAutoScalingEnabled

The [FontAutoScalingEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontAutoScalingEnabled) property automatically scales the Busy Indicator's title font size based on the operating system's text size. The default value of the `FontAutoScalingEnabled` property is `false`.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      FontAutoScalingEnabled="True" />

{% endhighlight %}

{% highlight C# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    FontAutoScalingEnabled = true,
};

{% endhighlight %}

{% endtabs %}

## See Also

- [Sizing in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/sizing)
- [Animation duration in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/duration)
- [Animation types in .NET MAUI Busy Indicator](https://help.syncfusion.com/maui/busy-indicator/animationtype)