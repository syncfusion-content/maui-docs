---
layout: post
title: Needle Pointer in .NET MAUI Radial Gauge control | Syncfusion®
description: Learn here all about the Needle Pointer feature of Syncfusion® .NET MAUI Radial Gauge control using the customization support.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Needle Pointer in .NET MAUI Radial Gauge

The [`Needle Pointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html) contains three parts, namely needle, knob, and tail, and can be placed on a gauge to mark values.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfRadialGauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/radial-gauge/getting-started)** guide.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "60" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Default Needle Pointer in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-default-needle-pointer.png)

## Needle customization

The needle can be customized using the following properties:

* [`NeedleLength`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLength) - Specifies the length of the needle. The length can be set either in pixels or factor.

* [`NeedleLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLengthUnit) - Specifies whether the length is set in pixels or factor.

* [`NeedleStartWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleStartWidth) - Specifies the start width of the needle.

* [`NeedleEndWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleEndWidth) - Specifies the end width of the needle.

* [`NeedleFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleFill) - Specifies the color of the needle.

### Needle length customization

The needle length can be controlled using the [`NeedleLength`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLength) and [`NeedleLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLengthUnit) properties. The length can be set either in pixels or factor using [`NeedleLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLengthUnit).

If [`NeedleLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLengthUnit) is set to [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel), the pixel value is set to the [`NeedleLength`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLength) to calculate the needle length.

If [`NeedleLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLengthUnit) is set to [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor), the factor value is set to the [`NeedleLength`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLength). The factor value ranges from 0 to 1. For example, if the needle length is set to 0.5, half of the axis radius is set as the needle length. The default value of [`NeedleLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleLengthUnit) is [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "60"
                                     NeedleLengthUnit = "Pixel"
                                     NeedleLength = "130" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
needlePointer.NeedleLengthUnit = SizeUnit.Pixel;
needlePointer.NeedleLength = 130;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Needle Pointer Length in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-needle-pointer-length.png)

### Needle width customization

The width of the needle pointer can be customized using the [`NeedleStartWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleStartWidth) and [`NeedleEndWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_NeedleEndWidth) properties.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "60"
                                     NeedleLengthUnit = "Factor"
                                     NeedleLength = "0.7"
                                     NeedleStartWidth = "10"
                                     NeedleEndWidth = "10"
                                     NeedleFill = "Red"/>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
needlePointer.NeedleLengthUnit = SizeUnit.Factor;
needlePointer.NeedleLength = 0.7;
needlePointer.NeedleFill = new SolidColorBrush(Colors.Red);
needlePointer.NeedleStartWidth = 10;
needlePointer.NeedleEndWidth = 10;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Custom Needle Width in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-custom-needle-width.png)

## Knob customization

The knob can be customized using the following properties:

* [`KnobRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobRadius) - Specifies the radius of the knob either in pixels or factor.

* [`KnobFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobFill) - Specifies the color of the knob.

* [`KnobStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobStrokeThickness) - Specifies the width of the knob stroke outline either in pixels or factor.

* [`KnobStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobStroke) - Specifies the border color of the knob.

* [`KnobSizeUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobSizeUnit) - Specifies whether the knob radius and stroke width values are in pixels or factor.

### Knob radius customization

The radius of the knob can be customized using the [`KnobRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobRadius) and [`KnobSizeUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobSizeUnit). If [`KnobSizeUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobSizeUnit) is set to [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel), the pixel value can be set to the [`KnobRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobRadius).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "65"
                                     KnobSizeUnit = "Pixel"
                                     KnobRadius = "15"
                                     KnobFill = "Red" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 65;
needlePointer.KnobRadius = 15;
needlePointer.KnobSizeUnit = SizeUnit.Pixel;
needlePointer.KnobFill = new SolidColorBrush(Colors.Red);
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Knob Radius in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-knob-radius.png)

If [`KnobSizeUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobSizeUnit) is set to [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor), the factor value is set to the knob radius. The factor value ranges from 0 to 1. For example, if the knob radius is set to 0.1, 10% of the axis radius is set as the knob radius. By default, the value of [`KnobSizeUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobSizeUnit) is [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor).

### Knob stroke customization

Like the knob radius, the [`KnobStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobStrokeThickness) can be specified either in pixel or factor. The [`KnobSizeUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobSizeUnit) property is common for both the [`KnobRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobRadius) and [`KnobStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_KnobStrokeThickness) properties.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "65"
                                     NeedleEndWidth = "10"
                                     NeedleFill = "Black"
                                     KnobRadius = "0.06"
                                     KnobStrokeThickness = "0.02"
                                     KnobStroke = "Black"
                                     KnobFill = "White" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 65;
needlePointer.NeedleEndWidth = 10;
needlePointer.NeedleFill = new SolidColorBrush(Colors.Black);
needlePointer.KnobRadius = 0.06;
needlePointer.KnobStrokeThickness = 0.02;
needlePointer.KnobFill = new SolidColorBrush(Colors.White);
needlePointer.KnobStroke = new SolidColorBrush(Colors.Black);
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Knob Stroke in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-knob-stroke.png)

## Tail customization

The tail of the needle can be customized using the following properties:

* [`TailLength`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLength) - Specifies the length of the tail either in pixels or factor.

* [`TailLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLengthUnit) - Specifies whether the tail length value is defined in pixels or factor.

* [`TailWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailWidth) - Specifies the width of the tail.

* [`TailFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailFill) - Specifies the color of the tail.

### Tail length customization

The tail length can be controlled using the [`TailLength`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLength) and [`TailLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLengthUnit) properties. The length can be set either in pixels or factor using [`TailLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLengthUnit). The default value of [`TailLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLengthUnit) is [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor).

### Tail length in pixel

If [`TailLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLengthUnit) is set to [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel), the tail is rendered based on the pixel value given in [`TailLength`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLength).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "60"
                                     TailLengthUnit = "Pixel"
                                     TailLength = "40" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
needlePointer.TailLengthUnit = SizeUnit.Pixel;
needlePointer.TailLength = 40;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Tail Length in Pixel in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-tail-length-in-pixel.png)

### Tail length in factor

If [`TailLengthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailLengthUnit) is set to [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor), the provided factor value in the tail length is multiplied by the axis radius. The factor value ranges from 0 to 1. For example, if the tail length is set to 0.5, half of the axis radius is set as the tail length.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "60"
                                     TailLengthUnit = "Factor"
                                     TailLength = "0.2" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
needlePointer.TailLengthUnit = SizeUnit.Factor;
needlePointer.TailLength = 0.2;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Tail Length in Factor in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-tail-length-in-factor.png)

### Tail width customization

The width of the tail can be customized using the [`TailWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html#Syncfusion_Maui_Gauges_NeedlePointer_TailWidth) property of the needle pointer.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value = "60"
                                     TailLength = "0.15"
                                     TailWidth = "10" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 60;
needlePointer.TailLength = 0.15;
needlePointer.TailWidth = 10;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Tail Width in .NET MAUI Radial Gauge](images/needle-pointer/maui-radial-gauge-tail-width.png)
