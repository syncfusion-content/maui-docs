---
layout: post
title: Events in .NET MAUI Interactive Viewer | Syncfusion®
description: Learn about all events supported in Syncfusion® .NET MAUI Interactive Viewer control for content loading, zoom and pan interactions.
platform: MAUI
control: SfInteractiveViewer
documentation: ug
---

# Events in .NET MAUI Interactive Viewer

The `SfInteractiveViewer` supports the `ZoomFactorChanged` and `ScrollChanged` events to interact with the .NET MAUI Interactive Viewer.

## Zoom factor changed event

The `ZoomFactorChanged` event is triggered after a zoom operation is completed in the interactive viewer. The event arguments provide the following information.

* `OldZoomFactor` - Gets the zoom factor before the zoom operation.
* `NewZoomFactor` - Gets the zoom factor after the zoom operation.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       ZoomFactorChanged="OnZoomFactorChanged">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}
{% highlight C# hl_lines="3 4 5 6 7" %}

using Syncfusion.Maui.InteractiveViewer;

private void OnZoomFactorChanged(object sender, ZoomFactorChangedEventArgs e)
{
    double oldZoom = e.OldZoomFactor;
    double newZoom = e.NewZoomFactor;
}

{% endhighlight %}
{% endtabs %}

## Scroll changed event

The `ScrollChanged` event is triggered when the pan position changes in the interactive viewer. The event arguments contain the following information.

* `PanAxis` - Gets the directions in which panning is currently allowed.
* `ZoomFactor` - Gets the current zoom factor applied to the content.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       ScrollChanged="OnScrollChanged">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}
{% highlight C# hl_lines="3 4 5 6 7" %}

using Syncfusion.Maui.InteractiveViewer;

private void OnScrollChanged(object sender, InteractiveScrollChangedEventArgs e)
{
    PanAxis panAxis = e.PanAxis;
    double zoomFactor = e.ZoomFactor;
}

{% endhighlight %}
{% endtabs %}
