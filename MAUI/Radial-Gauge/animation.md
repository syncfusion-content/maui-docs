---
layout: post
title: Animation in .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about Animation feature of Syncfusion .NET MAUI Radial Gauge control with pointer animation support and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Animation in .NET MAUI Radial Gauge

## Initial animation

The [.NET MAUI Radial Gauge](https://www.syncfusion.com/maui-controls/maui-radial-gauge) allows all of its elements to be animated using the [`EnableLoadingAnimation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_EnableLoadingAnimation) property. The default value for this property is false. The duration of the animation can be controlled by using the [`AnimationDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_AnimationDuration) property of the gauge.

{% tabs %}

{% highlight xaml %}

  <gauge:SfRadialGauge x:Name="gauge">
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis EnableLoadingAnimation="True" Maximum="150">
                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="90"
                                     NeedleStartWidth="0"
                                     NeedleEndWidth="15"
                                     KnobRadius="0.09">
                        </gauge:NeedlePointer>
                    </gauge:RadialAxis.Pointers>
                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="0" EndValue="50" Fill="Green"/>
                        <gauge:RadialRange StartValue="50" EndValue="100" Fill="Orange"/>
                        <gauge:RadialRange StartValue="100" EndValue="150" Fill="Red"/>
                    </gauge:RadialAxis.Ranges>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

 SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.Maximum = 150;
            radialAxis.EnableLoadingAnimation = true;
            sfRadialGauge.Axes.Add(radialAxis);

            NeedlePointer needlePointer = new NeedlePointer();
            needlePointer.Value = 90;
            needlePointer.NeedleStartWidth = 0;
            needlePointer.NeedleEndWidth = 15;
            needlePointer.KnobRadius = 0.09;
            radialAxis.Pointers.Add(needlePointer);

            RadialRange radialRange = new RadialRange();
            radialRange.StartValue = 0;
            radialRange.EndValue = 50;
            radialRange.Fill = new SolidColorBrush(Colors.Green);
            radialAxis.Ranges.Add(radialRange);

            radialRange = new RadialRange();
            radialRange.StartValue = 50;
            radialRange.EndValue = 100;
            radialRange.Fill = new SolidColorBrush(Colors.Orange);
            radialAxis.Ranges.Add(radialRange);

            radialRange = new RadialRange();
            radialRange.StartValue = 100;
            radialRange.EndValue = 150;
            radialRange.Fill = new SolidColorBrush(Colors.Red);
            radialAxis.Ranges.Add(radialRange);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge Loading Animation](images/animation/maui-radial-gauge-loading-animation.gif)


## Pointer animation

The [`EnableAnimation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html#Syncfusion_Maui_Gauges_RadialPointer_EnableAnimation) property of pointer allows you to enable or disable animation for pointer.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis ShowTicks="False">
                    <gauge:RadialAxis.AxisLineStyle>
                        <gauge:RadialLineStyle Thickness="30"/>
                    </gauge:RadialAxis.AxisLineStyle>
                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="60"
                                     EnableAnimation="True"
                                     NeedleStartWidth="0"
                                     NeedleEndWidth="15"
                                     NeedleFill="#FFDADADA"
                                     KnobFill="White"
                                     KnobStroke="#FFDADADA"
                                     KnobRadius="0.09"
                                     KnobStrokeThickness="0.04"
                                     TailFill="#FFDADADA"
                                     TailLength="0.15"
                                     TailWidth="15">
                        </gauge:NeedlePointer>
                        <gauge:RangePointer Value="60"
                                    PointerWidth="30"
                                    EnableAnimation="True"
                                    Fill="Orange" />
                    </gauge:RadialAxis.Pointers>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowTicks = false;
            radialAxis.AxisLineStyle.Thickness = 30;
            sfRadialGauge.Axes.Add(radialAxis);

            NeedlePointer needlePointer = new NeedlePointer();
            needlePointer.Value = 60;
            needlePointer.EnableAnimation = true;
            needlePointer.NeedleStartWidth = 0;
            needlePointer.NeedleEndWidth = 15;
            needlePointer.NeedleFill = new SolidColorBrush(Color.FromRgb(218, 218, 218));
            needlePointer.KnobFill = new SolidColorBrush(Colors.White);
            needlePointer.KnobStroke = Color.FromRgb(218, 218, 218);
            needlePointer.KnobRadius = 0.09;
            needlePointer.KnobStrokeThickness = 0.04;
            needlePointer.TailFill = new SolidColorBrush(Color.FromRgb(218, 218, 218));
            needlePointer.TailLength = 0.15;
            needlePointer.TailWidth = 15;
            radialAxis.Pointers.Add(needlePointer);

            RangePointer rangePointer = new RangePointer();
            rangePointer.Value = 60;
            rangePointer.PointerWidth = 30;
            rangePointer.EnableAnimation = true;
            rangePointer.Fill = new SolidColorBrush(Colors.Orange);
            radialAxis.Pointers.Add(rangePointer);

            this.Content = sfRadialGauge;
{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge Animation](images/animation/maui-radial-gauge-animation.gif)

## Animation duration

The pointers [`AnimationDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html#Syncfusion_Maui_Gauges_RadialPointer_AnimationDuration) property allows you to control the animation duration (in milliseconds). The default value of animation duration is 1000ms.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis ShowTicks="False">
                    <gauge:RadialAxis.AxisLineStyle>
                        <gauge:RadialLineStyle Thickness="30"/>
                    </gauge:RadialAxis.AxisLineStyle>
                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="60"
                                     EnableAnimation="True"
                                     AnimationDuration="3000"
                                     NeedleStartWidth="0"
                                     NeedleEndWidth="15"
                                     NeedleFill="#FFDADADA"
                                     KnobFill="White"
                                     KnobStroke="#FFDADADA"
                                     KnobRadius="0.09"
                                     KnobStrokeThickness="0.04"
                                     TailFill="#FFDADADA"
                                     TailLength="0.15"
                                     TailWidth="15">
                        </gauge:NeedlePointer>
                        <gauge:RangePointer Value="60"
                                    PointerWidth="30"
                                    EnableAnimation="True"
                                    AnimationDuration="3000"
                                    Fill="Orange" />
                    </gauge:RadialAxis.Pointers>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowTicks = false;
            radialAxis.AxisLineStyle.Thickness = 30;
            sfRadialGauge.Axes.Add(radialAxis);

            NeedlePointer needlePointer = new NeedlePointer();
            needlePointer.Value = 60;
            needlePointer.EnableAnimation = true;
            needlePointer.AnimationDuration = 3000;
            needlePointer.NeedleStartWidth = 0;
            needlePointer.NeedleEndWidth = 15;
            needlePointer.NeedleFill = new SolidColorBrush(Color.FromRgb(218, 218, 218));
            needlePointer.KnobFill = new SolidColorBrush(Colors.White);
            needlePointer.KnobStroke = Color.FromRgb(218, 218, 218);
            needlePointer.KnobRadius = 0.09;
            needlePointer.KnobStrokeThickness = 0.04;
            needlePointer.TailFill = new SolidColorBrush(Color.FromRgb(218, 218, 218));
            needlePointer.TailLength = 0.15;
            needlePointer.TailWidth = 15;
            radialAxis.Pointers.Add(needlePointer);

            RangePointer rangePointer = new RangePointer();
            rangePointer.Value = 60;
            rangePointer.PointerWidth = 30;
            rangePointer.EnableAnimation = true;
            rangePointer.AnimationDuration = 3000;
            rangePointer.Fill = new SolidColorBrush(Colors.Orange);
            radialAxis.Pointers.Add(rangePointer);

            this.Content = sfRadialGauge;
{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge Animation Duration](images/animation/maui-radial-gauge-animation-duration.gif)

## Animation easing

The [`AnimationEasing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html#Syncfusion_Maui_Gauges_RadialPointer_AnimationEasing) property of pointer allows you to use below type of easing function in pointer animation. 

* `Linear`

* `SinOut`

* `SinIn`

* `SinInOut`

* `CubicIn`

* `CubicOut`

* `CubicInOut`

* `BounceOut`

* `BounceIn`

* `SpringIn`

* `SpringOut`

The default value of [`AnimationEasing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html#Syncfusion_Maui_Gauges_RadialPointer_AnimationEasing) property is `Linear`.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis ShowTicks="False">
                    <gauge:RadialAxis.AxisLineStyle>
                        <gauge:RadialLineStyle Thickness="30"/>
                    </gauge:RadialAxis.AxisLineStyle>
                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="60"
                                     EnableAnimation="True"
                                     AnimationDuration="3000"
                                     AnimationEasing="{x:Static Easing.SpringOut}"
                                     NeedleStartWidth="0"
                                     NeedleEndWidth="15"
                                     NeedleFill="#FFDADADA"
                                     KnobFill="White"
                                     KnobStroke="#FFDADADA"
                                     KnobRadius="0.09"
                                     KnobStrokeThickness="0.04"
                                     TailFill="#FFDADADA"
                                     TailLength="0.15"
                                     TailWidth="15">

                        </gauge:NeedlePointer>
                        <gauge:RangePointer Value="60"
                                    PointerWidth="30"
                                    EnableAnimation="True"
                                    AnimationDuration="3000"
                                    AnimationEasing="{x:Static Easing.SpringOut}"
                                    Fill="Orange">
                        </gauge:RangePointer>
                    </gauge:RadialAxis.Pointers>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowTicks = false;
            radialAxis.AxisLineStyle.Thickness = 30;
            sfRadialGauge.Axes.Add(radialAxis);

            NeedlePointer needlePointer = new NeedlePointer();
            needlePointer.Value = 60;
            needlePointer.EnableAnimation = true;
            needlePointer.AnimationDuration = 3000;
            needlePointer.AnimationEasing = Easing.SpringOut;
            needlePointer.NeedleStartWidth = 0;
            needlePointer.NeedleEndWidth = 15;
            needlePointer.NeedleFill = new SolidColorBrush(Color.FromRgb(218, 218, 218));
            needlePointer.KnobFill = new SolidColorBrush(Colors.White);
            needlePointer.KnobStroke = Color.FromRgb(218, 218, 218);
            needlePointer.KnobRadius = 0.09;
            needlePointer.KnobStrokeThickness = 0.04;
            needlePointer.TailFill = new SolidColorBrush(Color.FromRgb(218, 218, 218));
            needlePointer.TailLength = 0.15;
            needlePointer.TailWidth = 15;
            radialAxis.Pointers.Add(needlePointer);

            RangePointer rangePointer = new RangePointer();
            rangePointer.Value = 60;
            rangePointer.PointerWidth = 30;
            rangePointer.EnableAnimation = true;
            rangePointer.AnimationDuration = 3000;
            rangePointer.AnimationEasing = Easing.SpringOut;
            rangePointer.Fill = new SolidColorBrush(Colors.Orange);
            radialAxis.Pointers.Add(rangePointer);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}
