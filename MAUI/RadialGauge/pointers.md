---
layout: post
title: Pointers in .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about Pointers feature of Syncfusion .NET MAUI Radial Gauge control with multiple pointer support and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Pointers in .NET MAUI Radial Gauge

 Pointer is used to indicate values on an axis. The radial gauge control has three types of pointers: 

* `Marker pointer`
* `Needle Pointer`
* `Range pointer`

All the pointers can be customized as needed. You can add multiple pointers to the gauge to point the multiple values on the same scale. The value of the pointer is set using the `Value` property.

![.NET MAUI Radial Gauge with Pointers](images/pointers/maui-radial-gauge-pointers.png)

## Multiple pointers

In addition to the default pointer, you can add `N` number of pointers to an axis by adding in the `Pointers` collection property.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value="30" />
                <gauge:MarkerPointer Value="70" />
                <gauge:NeedlePointer Value="60" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
RangePointer rangePointer = new RangePointer { Value = 30 };
radialAxis.Pointers.Add(rangePointer);
MarkerPointer markerPointer = new MarkerPointer { Value = 70 };
radialAxis.Pointers.Add(markerPointer);
NeedlePointer needlePointer = new NeedlePointer { Value = 60 };
radialAxis.Pointers.Add(needlePointer);

sfRadialGauge.Axes.Add(radialAxis);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![MAUI radial Gauge with Multiple Pointers](images/pointers/maui-radial-gauge-multiple-pointers.png)

## Pointer interaction

Pointers can be dragged over the axis scale. It can be achieved by swipe or drag gestures. To enable or disable the pointer drag, use the `IsInteractive` property.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis ShowTicks="False">
                    <gauge:RadialAxis.AxisLineStyle>
                        <gauge:RadialLineStyle Thickness="30" Fill="CornflowerBlue"/>
                    </gauge:RadialAxis.AxisLineStyle>
                    <gauge:RadialAxis.Pointers>
                        <gauge:MarkerPointer Value="30"
                                     IsInteractive="True"
                                     MarkerOffset="-30"
                                     Fill="Indigo" />
                    </gauge:RadialAxis.Pointers>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

 SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowTicks = false;
            radialAxis.AxisLineStyle.Fill = new SolidColorBrush(Colors.CornflowerBlue);
            radialAxis.AxisLineStyle.Thickness = 30;
            sfRadialGauge.Axes.Add(radialAxis);

            MarkerPointer markerPointer = new MarkerPointer();
            markerPointer.Value = 30;
            markerPointer.IsInteractive = true;
            markerPointer.Fill = new SolidColorBrush(Colors.Indigo);
            markerPointer.MarkerOffset = -30;
            radialAxis.Pointers.Add(markerPointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

## Event

`ValueChangeStarted` - Occurs whenever the pointer starts to drag.

`ValueChanging` - Occurs before the current drag value gets updated as pointer value. The `Cancel` argument of `ValueChangingEventArgs` allows to restrict the update of current drag value.

`ValueChanged` - Occurs whenever the pointer value is changed while dragging.

`ValueChangeCompleted` - Occurs once the dragging of the pointer gets completed.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:MarkerPointer Value="30"
                                     IsInteractive="True"
                                     ValueChanging="MarkerPointer_ValueChanging"
                                     ValueChanged="MarkerPointer_ValueChanged"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

private void MarkerPointer_ValueChanging(object sender, ValueChangingEventArgs e)
{
    if (e.NewValue > 60)
    {
        e.Cancel = true;
    }
}

private void MarkerPointer_ValueChanged(object sender, ValueChangedEventArgs e)
{

}

{% endhighlight %}

{% endtabs %}
