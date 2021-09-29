---
layout: post
title: Marker Pointer in .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about Marker Pointer feature of Syncfusion .NET MAUI Radial Gauge control with image, text pointer support and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Marker Pointer in .NET MAUI Radial Gauge

Indicate current values by using different types of marker pointers. You can change the marker shape type using the `MarkerType` property.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:MarkerPointer Value="60" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

MarkerPointer markerPointer = new MarkerPointer();
markerPointer.Value = 60;
radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Default Marker Pointer](images/marker-pointers/maui-radial-gauge-default-marker-pointer.png)

Gauge supports the following types of shapes:

* Circle
* Diamond
* Inverted triangle
* Rectangle
* Triangle

![.NET MAUI Radial Gauge Markers](images/marker-pointers/maui-radial-gauge-markers.png)

## Marker customization

The marker pointer can be customized using the following properties:

* `Fill` – Allows to customize the marker color.
* `MarkerHeight` – Allows to specify the marker height.
* `MarkerWidth` – Allows to specify the marker width.
* `Stroke` – Allows to specify the border color for the marker.
* `BorderWidth` –  Allows to specify the border width of the marker.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:MarkerPointer Value="60"
                                     MarkerHeight="30"
                                     MarkerWidth="30"
                                     Stroke="Black"
                                     BorderWidth="3"
                                     MarkerType="Circle"
                                     Fill="LightBlue"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

MarkerPointer markerPointer = new MarkerPointer();
markerPointer.Value = 60;
markerPointer.MarkerHeight = 30;
markerPointer.MarkerWidth = 30;
markerPointer.Stroke = Colors.Black;
markerPointer.BorderWidth = 3;
markerPointer.MarkerType = MarkerType.Circle;
markerPointer.Fill = new SolidColorBrush(Colors.LightBlue);
radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Custom Marker Pointer](images/marker-pointers/maui-radial-gauge-custom-marker-pointer.png)

## Marker position customization

The marker pointer can be moved near or far from its actual position using the `MarkerOffset` and `OffsetUnit` properties. 

When you set `OffsetUnit` to pixel, the marker pointer will be moved based on the pixel value. If you set `OffsetUnit` to factor, then provided factor will be multiplied with the axis radius value, and then the pointer will be moved to corresponding value. The default value of `OffsetUnit` is `SizeUnit.Pixel`.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:MarkerPointer Value="60"
                                     MarkerOffset="-18"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

MarkerPointer markerPointer = new MarkerPointer();
markerPointer.Value = 60;
markerPointer.MarkerOffset = -18;
radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Marker Offset](images/marker-pointers/maui-radial-gauge-marker-offset.png)
