---
layout: post
title: Radial Range Pointer in .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about Range Pointer feature of Syncfusion .NET MAUI Radial Gauge control with customization support.
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

* `Fill` – Customizes the color of range pointer.

* `PointerWidth` - Specifies the width of pointer either in pixels or factor.

* `WidthUnit` – Specifies whether the `PointerWidth` is defined in pixels or factor.

The `PointerWidth` of the pointer can be specified either in pixel or factor. If the `WidthUnit` is specified as Pixel, then the range will be rendered based on the provided pixel value. If the `WidthUnit` is set as factor, the provided factor value will be multiplied with axis radius. For example, if the pointer width is set as 0.1, then 10% of axis radius is considered as range pointer width.

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

 The default value of `WidthUnit` and `OffsetUnit` is `SizeUnit.Pixel`.
 
## Setting gradient brush to the pointer

 The `GradientStops` property of range pointer allows you to specify the smooth color transition to pointer by specifying the different colors based on provided axis value.

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

The `CornerStyle` property of range pointer specifies the corner type for the pointer. The corners can be customized using the `BothFlat`, `BothCurve`, `StartCurve`, and `EndCurve` options. The default value of this property is `BothFlat`.

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

* `PointerOffset` - Specifies the position value for pointer either in pixels or factor.

* `OffsetUnit` – Specifies whether the `PointerOffset` is defined in pixels or factor.

The range pointer can be moved far or near to the axis line using the `PointerOffset` property. The `PointerOffset` can be set either in pixel or factor value using its `OffsetUnit`.

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

When you set the `OffsetUnit` as pixel, the pointer will be moved to the provided pixel value.

If the `OffsetUnit` is specified as factor, the factor value will be multiplied with the axis radius. For example, if you set `PointerOffset` as 0.1, then the pointer offset is considered as 10% of axis radius.
