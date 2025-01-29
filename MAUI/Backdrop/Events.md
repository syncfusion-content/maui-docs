---
layout: post
title: Reveal and conceal event of Syncfusion<sup>&reg;</sup> Backdrop Page | Syncfusion<sup>&reg;</sup>
description: Learn here all about how to hook the event when Syncfusion<sup>&reg;</sup> .NET MAUI backdrop page is revealed and concealed.
platform: MAUI
control: SfBackdropPage
documentation: ug
---

# Events in .NET MAUI Backdrop Page (SfBackdropPage)

## BackLayerStateChanged event

The [`BackLayerStateChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_BackLayerStateChanged) event occurs when the backdrop page back layer is revealed and concealed. The event occurs in the cases mentioned in this [`documentation`](https://help.syncfusion.com/maui/backdrop/getting-started#reveal-and-conceal-the-back-layer). This event contains the following argument.

- [`Percentage:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.BackLayerStateChangedEventArgs.html#Syncfusion_Maui_Backdrop_BackLayerStateChangedEventArgs_Percentage) Represents the FrontLayer revealed height percentage.

{% tabs %} 

{% highlight xaml %} 

<backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="BackdropGettingStarted.BackdropSamplePage"
                         Title="Menu"
                         xmlns:backdrop="clr-namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop"
                         BackLayerStateChanged="SfBackdropPage_BackLayerStateChanged"
                         >

</backdrop:SfBackdropPage>

{% endhighlight %}

{% highlight C# %} 

private void SfBackdropPage_BackLayerStateChanged(object sender, BackLayerStateChangedEventArgs e)
{
    // handle event action.
}

{% endhighlight %}

{% endtabs %}
