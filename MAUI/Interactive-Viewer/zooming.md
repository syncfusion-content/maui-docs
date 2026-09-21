---
layout: post
title: Zoom in .NET MAUI Interactive Viewer | Syncfusion®
description: Learn about zooming and panning actions on contents in Syncfusion® .NET MAUI Interactive Viewer control for enhanced content viewing.
platform: MAUI
control: SfInteractiveViewer
documentation: ug
---

# Zoom and Pan in .NET MAUI Interactive Viewer

The `.NET MAUI Interactive Viewer` provides intuitive zoom and pan support, allowing users to explore content in greater detail and navigate seamlessly across large or complex views.

## Enable zoom

Use the `IsZoomEnabled` property to enable or disable zooming in the Interactive Viewer. By default, the `IsZoomEnabled` property is set to `true`.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       IsZoomEnabled="False">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}

{% highlight C# hl_lines="4" %}

using Syncfusion.Maui.InteractiveViewer;

SfInteractiveViewer interactiveViewer = new SfInteractiveViewer();
interactiveViewer.IsZoomEnabled = false;
interactiveViewer.Content = new Image()
{
    Source = ImageSource.FromFile("interactiveviewerimage.png"),
    Aspect = Aspect.AspectFit
};

this.Content = interactiveViewer;

{% endhighlight %}
{% endtabs %}

## Change the zoom factor

Use the `ZoomFactor` property to programmatically control the zoom level of the content displayed in the Interactive Viewer.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       ZoomFactor="5">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}

{% highlight C# hl_lines="4" %}

using Syncfusion.Maui.InteractiveViewer;

SfInteractiveViewer interactiveViewer = new SfInteractiveViewer();
interactiveViewer.ZoomFactor = 5;
interactiveViewer.Content = new Image()
{
    Source = ImageSource.FromFile("interactiveviewerimage.png"),
    Aspect = Aspect.AspectFit
};

this.Content = interactiveViewer;

{% endhighlight %}
{% endtabs %}

### Change the minimum zoom factor

Use the `MinimumZoomFactor` property to define the minimum zoom level for the content displayed in the Interactive Viewer.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       MinimumZoomFactor="5">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}

{% highlight C# hl_lines="4" %}

using Syncfusion.Maui.InteractiveViewer;

SfInteractiveViewer interactiveViewer = new SfInteractiveViewer();
interactiveViewer.MinimumZoomFactor = 5;
interactiveViewer.Content = new Image()
{
    Source = ImageSource.FromFile("interactiveviewerimage.png"),
    Aspect = Aspect.AspectFit
};

this.Content = interactiveViewer;

{% endhighlight %}
{% endtabs %}

### Change the maximum zoom factor

Use the `MaximumZoomFactor` property to define the maximum zoom level for the content displayed in the Interactive Viewer.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       MaximumZoomFactor="8">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}

{% highlight C# hl_lines="4" %}

using Syncfusion.Maui.InteractiveViewer;

SfInteractiveViewer interactiveViewer = new SfInteractiveViewer();
interactiveViewer.MaximumZoomFactor = 8;
interactiveViewer.Content = new Image()
{
    Source = ImageSource.FromFile("interactiveviewerimage.png"),
    Aspect = Aspect.AspectFit
};

this.Content = interactiveViewer;

{% endhighlight %}
{% endtabs %}


## Enable Pan

Use the `IsPanEnabled` property to enable or disable panning in the Interactive Viewer. By default, the `IsPanEnabled` property is set to `true`.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       IsPanEnabled="False">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}

{% highlight C# hl_lines="4" %}

using Syncfusion.Maui.InteractiveViewer;

SfInteractiveViewer interactiveViewer = new SfInteractiveViewer();
interactiveViewer.IsPanEnabled = false;
interactiveViewer.Content = new Image()
{
    Source = ImageSource.FromFile("interactiveviewerimage.png"),
    Aspect = Aspect.AspectFit
};

this.Content = interactiveViewer;

{% endhighlight %}
{% endtabs %}

### PanAxis

Use the `PanAxis` property to control the direction in which users can pan content in the Interactive Viewer.

The `PanAxis` property supports the following values:

 * `Horizontal` – Allows panning only in the horizontal direction.
 * `Vertical` – Allows panning only in the vertical direction.
 * `Both` – Allows panning in both horizontal and vertical directions.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer"
                                       PanAxis="Horizontal">
    <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
</interactiveViewer:SfInteractiveViewer>

{% endhighlight %}

{% highlight C# hl_lines="4" %}

using Syncfusion.Maui.InteractiveViewer;

SfInteractiveViewer interactiveViewer = new SfInteractiveViewer();
interactiveViewer.PanAxis = PanAxis.Horizontal;
interactiveViewer.Content = new Image()
{
    Source = ImageSource.FromFile("interactiveviewerimage.png"),
    Aspect = Aspect.AspectFit
};

this.Content = interactiveViewer;

{% endhighlight %}
{% endtabs %}