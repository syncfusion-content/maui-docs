---
layout: post
title: Radial Range Pointer in .NET MAUI Radial Gauge control | Syncfusion<sup>&reg;</sup>
description: Learn all about the Range Pointer feature in the Syncfusion<sup>&reg;</sup> .NET MAUI Radial Gauge control with customization support.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Range Pointer in .NET MAUI Radial Gauge

A range pointer is an accenting line or shaded background range that can be placed on a gauge to mark the current value.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value="30" />
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

![.NET MAUI Radial Gauge Default Range Pointer](images/range-pointer/maui-radial-gauge-default-range-pointer.png)

The following properties are used to customize the range pointer:

* [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_Fill) – Customizes the color of range pointer.

* [`PointerWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerWidth) - Specifies the width of pointer either in pixels or factor.

* [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_WidthUnit) – Specifies whether the [`PointerWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerWidth) is defined in pixels or factor.

The [`PointerWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerWidth) can be specified in pixels or as a factor. When [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_WidthUnit) is set to Pixel, the range is rendered using the given pixel value. If set to Factor, the value is multiplied by the axis radius. For example, if the pointer width is set as 0.1, then 10% of axis radius is considered as range pointer width.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value="30"
                                    PointerWidth="0.1"
                                    WidthUnit="Factor"
                                    Fill="Indigo" />
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

![.NET MAUI Radial Gauge Custom Range Pointer](images/range-pointer/maui-radial-gauge-custom-range-pointer.png)

 The default value of [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_WidthUnit) and [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit) is [`SizeUnit.Pixel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html#Syncfusion_Maui_Gauges_SizeUnit_Pixel).
 
## Setting gradient brush to the pointer

 The [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_GradientStops) property of the range pointer allows smooth color transitions by specifying different colors at specific axis values.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis >
                    <gauge:RadialAxis.AxisLineStyle>
                        <gauge:RadialLineStyle ThicknessUnit="Factor" Thickness="0.1"/>
                    </gauge:RadialAxis.AxisLineStyle>
                    <gauge:RadialAxis.Pointers>
                        <gauge:RangePointer Value="40"
                                    PointerWidth="0.1"
                                    WidthUnit="Factor">
                            <gauge:RangePointer.GradientStops>
                                <gauge:GaugeGradientStop Value="10"
                                                 Color="#FFCC2B5E" />
                                <gauge:GaugeGradientStop Value="30"
                                                 Color="#FF753A88" />
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

![.NET MAUI Radial Gauge Range Pointer Gradient](images/range-pointer/maui-radial-gauge-range-pointer-gradient.png)

## Corner style customization

The [`CornerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_CornerStyle) property of range pointer specifies the corner type for the pointer. The corners can be customized using the [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothFlat), [`BothCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothCurve), [`StartCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_StartCurve), and [`EndCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_EndCurve) options. The default value of this property is [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothFlat).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value="30"
                                    CornerStyle="BothCurve" />
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

![.NET MAUI Radial Gauge Pointer Corner Style](images/range-pointer/maui-radial-gauge-pointer-corner-style.png)

## Position customization

The following properties are used to customize the position of range pointer:

* [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) - Specifies the position value for pointer either in pixels or factor.

* [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit) – Specifies whether the [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) is defined in pixels or factor.

The range pointer can be moved far or near to the axis line using the [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) property. The [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) can be set either in pixel or factor value using its [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit).

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Pointers>
                <gauge:RangePointer Value="30"
                                    PointerOffset="70" />
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

![.NET MAUI Radial Gauge Pointer Position](images/range-pointer/maui-radial-gauge-pointer-position.png)

If the [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_OffsetUnit) is set to Pixel, the pointer is offset by the specified pixel value. If set to Factor, the value is interpreted as a percentage of the axis radius. For example, if you set [`PointerOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html#Syncfusion_Maui_Gauges_RangePointer_PointerOffset) as 0.1, then the pointer offset is considered as 10% of axis radius.
