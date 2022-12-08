---
layout: post
title: Reveal and conceal event of Syncfusion Backdrop Page | Syncfusion
description: Learn here all about how to hook the event when backdrop page is revealed and concealed.
platform: MAUI
control: SfBackdropPage
documentation: ug
---

# Events in .NET MAUI Backdrop Page (SfBackdropPage)

## BackLayerStateChanged event

The `BackLayerStateChanged` event occurs when the backdrop page back layer is revealed and concealed. The event occurs in the cases mentioned in this `documentation`.

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

private void SfBackdropPage_BackLayerStateChanged(object sender, EventArgs e)
{
    // handle event action.
}

{% endhighlight %}

{% endtabs %}
