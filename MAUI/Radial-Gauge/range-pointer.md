---
layout: post
title: Range Pointer in .NET MAUI Radial Gauge control | Syncfusion®
description: Learn here all about the Range Pointer feature of Syncfusion® .NET MAUI Radial Gauge control with customization support.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Range Pointer in .NET MAUI Radial Gauge

A range pointer is an accenting line or shaded background range that can be placed on a gauge to mark the current value.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfRadialGauge** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/radial-gauge/getting-started)** guide.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value = "30" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RangePointer rangePointer = new RangePointer();
rangePointer.Value = 30;
radialAxis.Pointers.Add(rangePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Default Range Pointer in .NET MAUI Radial Gauge](images/range-pointer/maui-radial-gauge-default-range-pointer.png)

The following properties are used to customize the range pointer:

* [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_Fill) - Specifies the color of the range pointer.

* [`PointerWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerWidth) - Specifies the width of the pointer either in pixels or factor.

* [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_WidthUnit) - Specifies whether the [`PointerWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerWidth) is defined in pixels or factor.

The [`PointerWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerWidth) of the pointer can be specified either in pixel or factor. If [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_WidthUnit) is set to [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel), the range is rendered based on the provided pixel value. If [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_WidthUnit) is set to [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor), the provided factor value is multiplied with the axis radius. For example, if the pointer width is set to 0.1, then 10% of the axis radius is considered as the range pointer width.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value = "30"
                                    PointerWidth = "0.1"
                                    WidthUnit = "Factor"
                                    Fill = "Indigo" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RangePointer rangePointer = new RangePointer();
rangePointer.Value = 30;
rangePointer.PointerWidth = 0.1;
rangePointer.WidthUnit = SizeUnit.Factor;
rangePointer.Fill = new SolidColorBrush(Colors.Indigo);
radialAxis.Pointers.Add(rangePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Custom Range Pointer in .NET MAUI Radial Gauge](images/range-pointer/maui-radial-gauge-custom-range-pointer.png)

 The default value of [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_WidthUnit) and [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit) is [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel).
 
## Setting a gradient brush to the pointer

The [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_GradientStops) property of the range pointer allows you to apply a smooth color transition by specifying different colors at specific axis values.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis >
            <gauge:RadialAxis.AxisLineStyle>
                <gauge:RadialLineStyle ThicknessUnit = "Factor" Thickness = "0.1"/>
            </gauge:RadialAxis.AxisLineStyle>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value = "40"
                                    PointerWidth = "0.1"
                                    WidthUnit = "Factor">
                    <gauge:RangePointer.GradientStops>
                        <gauge:GaugeGradientStop Value = "10"
                                                 Color = "#FFCC2B5E" />
                        <gauge:GaugeGradientStop Value = "30"
                                                 Color = "#FF753A88" />
                    </gauge:RangePointer.GradientStops>
                </gauge:RangePointer>
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
radialAxis.AxisLineStyle.Thickness = 0.1;
radialAxis.AxisLineStyle.ThicknessUnit = SizeUnit.Factor;
sfRadialGauge.Axes.Add(radialAxis);

RangePointer rangePointer = new RangePointer();
rangePointer.Value = 40;
rangePointer.PointerWidth = 0.1;
rangePointer.WidthUnit = SizeUnit.Factor;
rangePointer.GradientStops.Add(new GaugeGradientStop { Value = 10, Color = Color.FromRgb(204, 43, 94) });
rangePointer.GradientStops.Add(new GaugeGradientStop { Value = 30, Color = Color.FromRgb(117, 58, 136) });

radialAxis.Pointers.Add(rangePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Range Pointer Gradient in .NET MAUI Radial Gauge](images/range-pointer/maui-radial-gauge-range-pointer-gradient.png)

## Corner style customization

The [`CornerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_CornerStyle) property of the range pointer specifies the corner type for the pointer. The corners can be customized using the [`CornerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html) enum, which provides the following values:

* [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothFlat) - Both the start and end corners of the range pointer are flat.
* [`BothCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothCurve) - Both the start and end corners of the range pointer are curved.
* [`StartCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_StartCurve) - Only the start corner of the range pointer is curved.
* [`EndCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_EndCurve) - Only the end corner of the range pointer is curved.

The default value is [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothFlat).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value = "30"
                                    CornerStyle = "BothCurve" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RangePointer rangePointer = new RangePointer();
rangePointer.Value = 30;
rangePointer.CornerStyle = CornerStyle.BothCurve;
radialAxis.Pointers.Add(rangePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Pointer Corner Style in .NET MAUI Radial Gauge](images/range-pointer/maui-radial-gauge-pointer-corner-style.png)

## Range pointer position customization

The following properties are used to customize the position of the range pointer:

* [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) - Specifies the position value for the pointer either in pixels or factor.

* [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit) - Specifies whether the [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) is defined in pixels or factor.

The range pointer can be moved far or near to the axis line using the [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) property. The [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) can be set in either pixel or factor value using its [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value = "30"
                                    PointerOffset = "70" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RangePointer rangePointer = new RangePointer();
rangePointer.Value = 30;
rangePointer.PointerOffset = 70;
radialAxis.Pointers.Add(rangePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![Pointer Position in .NET MAUI Radial Gauge](images/range-pointer/maui-radial-gauge-pointer-position.png)

When [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit) is set to [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel), the pointer is moved by the provided pixel value.

When [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit) is set to [`SizeUnit.Factor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Factor), the factor value is multiplied with the axis radius. For example, if [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) is set to 0.1, then the pointer offset is considered as 10% of the axis radius.
