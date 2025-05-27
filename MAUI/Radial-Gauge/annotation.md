---
layout: post
title: Annotation in .NET MAUI Radial Gauge control | Syncfusion<sup>&reg;</sup>
description: Learn here all about Annotation feature of Syncfusion<sup>&reg;</sup> .NET MAUI Radial Gauge control with positioning support and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Annotation in .NET MAUI Radial Gauge

The radial axis allows you to add multiple views such as text, icons, and images etc., as an annotation at a specific point of interest in the radial gauge.

The following properties are available in [`Annotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html) for customizing the position and alignment.

* [`DirectionValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionValue) –  Specifies the value indicating the direction of the annotation based on [`DirectionUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionUnit) property. 

* [`DirectionUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionUnit) – Specifies the value indicating the direction of the annotation to be calculated based on [`Axis value`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.AnnotationDirection.html#Syncfusion_Maui_Gauges_AnnotationDirection_AxisValue) or [`Angle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.AnnotationDirection.html#Syncfusion_Maui_Gauges_AnnotationDirection_Angle).

* [`PositionFactor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_PositionFactor) – Specifies the factor value (from 0 to 1) for adjusting the annotation distance from the center point.

* [`HorizontalAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_HorizontalAlignment) – Specifies the horizontal alignment for positioning the annotations.

* [`VerticalAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_VerticalAlignment) – Specifies the vertical alignment for positioning the annotations.

{% tabs %}

{% highlight xaml %}

      <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis>
                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation>
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="50.0"
                                   FontAttributes="Bold"
                                   TextColor="Black"
                                   FontSize="20" />
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

            SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            sfRadialGauge.Axes.Add(radialAxis);

            GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.Content = new Label
            {
                Text = "50.0",
                TextColor = Colors.Black,
                FontAttributes = FontAttributes.Bold,
                FontSize = 20
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Annotation Position](images/annotation/maui-radial-gauge-annotation-position.png)

## Positioning annotation

Annotations can be positioned using either the [`Angle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.AnnotationDirection.html#Syncfusion_Maui_Gauges_AnnotationDirection_Angle) or the [`Axis value`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.AnnotationDirection.html#Syncfusion_Maui_Gauges_AnnotationDirection_AxisValue). It can be controlled by the [`DirectionUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionUnit) property of [`Annotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html). The default value is [`Angle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.AnnotationDirection.html#Syncfusion_Maui_Gauges_AnnotationDirection_Angle).

### Positioning annotation using angle

The following example demonstrates how to position the annotation using angle.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis>
                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="90" />
                    </gauge:RadialAxis.Pointers>
                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation DirectionValue="90"
                                        PositionFactor="0.5">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="90.0"
                                       TextColor="Black"
                                    FontAttributes="Bold"
                                    FontSize="20" />
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>
{% endhighlight %}

{% highlight c# %}

 SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            sfRadialGauge.Axes.Add(radialAxis);

            NeedlePointer needlePointer = new NeedlePointer();
            needlePointer.Value = 90;
            radialAxis.Pointers.Add(needlePointer);

            GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionValue = 90;
            gaugeAnnotation.PositionFactor = 0.5;
            gaugeAnnotation.Content = new Label() 
            { 
                Text = "90.0", 
                FontAttributes = FontAttributes.Bold, 
                TextColor=Colors.Black,
                FontSize = 20
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Annotation Position with Angle](images/annotation/maui-radial-gauge-annotation-position-with-angle.png)

### Positioning annotation using the axis value

The following example demonstrates how to position the annotation using the axis value.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis>
                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation DirectionUnit="AxisValue"
                                       DirectionValue="50"
                                       PositionFactor="0.4">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="50.0"
                                       TextColor="Black"
                                    FontAttributes="Bold"
                                    FontSize="20" />
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            sfRadialGauge.Axes.Add(radialAxis);

            GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionUnit = AnnotationDirection.AxisValue;
            gaugeAnnotation.DirectionValue = 50;
            gaugeAnnotation.PositionFactor = 0.4;
            gaugeAnnotation.Content = new Label()
            {
                Text = "50.0",
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Black,
                FontSize = 20
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Annotation Position with Axis](images/annotation/maui-radial-gauge-annotation-position-with-axis.png)

[`PositionFactor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_PositionFactor) is used to move annotations from the center of axis to the edge of the axis. For example, if you specify the [`PositionFactor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_PositionFactor) as 0.5, the annotation will move from the center in the corresponding direction by half the radius value of the axis.

By default, the value for [`PositionFactor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_PositionFactor) is 0.

## Setting image for annotations

Annotations provide the option to add any image over the gauge control relative to its offset position. Multiple images can be added in a single control.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis Interval="10"
                          StartAngle="0"
                          EndAngle="360"
                          ShowTicks="False"
                          ShowLabels="False">
                    <gauge:RadialAxis.AxisLineStyle>
                        <gauge:RadialLineStyle Thickness="30"/>
                    </gauge:RadialAxis.AxisLineStyle>
                    <gauge:RadialAxis.Pointers>
                        <gauge:RangePointer Value="73"
                                    PointerWidth="30"
                                    EnableAnimation="True"
                                    Fill="#FFFCE38A"
                                    CornerStyle="BothCurve" />
                    </gauge:RadialAxis.Pointers>

                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation>
                            <gauge:GaugeAnnotation.Content>
                                <VerticalStackLayout>
                                    <Image Source="sun.png" HeightRequest="50" WidthRequest="60" />
                                    <Label Text="73° F"
                                       FontSize="22"
                                           TextColor="Black"
                                       FontAttributes="Bold" />
                                </VerticalStackLayout>
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>

                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

 SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.Interval = 10;
            radialAxis.StartAngle = 0;
            radialAxis.EndAngle = 360;
            radialAxis.ShowTicks = false;
            radialAxis.ShowLabels = false;
            radialAxis.AxisLineStyle.Thickness = 30;
            sfRadialGauge.Axes.Add(radialAxis);

            RangePointer rangePointer = new RangePointer();
            rangePointer.Value = 73;
            rangePointer.PointerWidth = 30;
            rangePointer.EnableAnimation = true;
            rangePointer.Fill = new SolidColorBrush(Color.FromRgb(252, 227, 138));
            rangePointer.CornerStyle = CornerStyle.BothCurve;
            radialAxis.Pointers.Add(rangePointer);

            VerticalStackLayout layout = new VerticalStackLayout();

            Image image = new Image();
            image.Source = ImageSource.FromFile("sun.png");
            image.HeightRequest = 50;
            image.WidthRequest = 60;
            layout.Children.Add(image);

            Label label = new Label();
            label.Text = "73°F";
            label.TextColor = Colors.Black;
            label.FontSize = 22;
            label.FontAttributes = FontAttributes.Bold;
            layout.Children.Add(label);

            GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.Content = layout;
            radialAxis.Annotations.Add(gaugeAnnotation);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Image Annotation](images/annotation/maui-radial-gauge-image-annotation.png)

## Alignment of annotation

[`Annotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html) can be aligned to the center, near, or far using the [`HorizontalAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_HorizontalAlignment) and [`VerticalAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_VerticalAlignment) properties of the annotation.

The following code example shows how to set the [`HorizontalAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_HorizontalAlignment) for annotations

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis>
                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation DirectionUnit="AxisValue"
                                       DirectionValue="50"
                                       PositionFactor="0.4"
                                       HorizontalAlignment="Start">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="50.0"
                                       TextColor="Black"
                                    FontAttributes="Bold"
                                    FontSize="20" />
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            sfRadialGauge.Axes.Add(radialAxis);

            GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionUnit = AnnotationDirection.AxisValue;
            gaugeAnnotation.DirectionValue = 50;
            gaugeAnnotation.HorizontalAlignment = GaugeAlignment.Start;
            gaugeAnnotation.PositionFactor = 0.4;
            gaugeAnnotation.Content = new Label()
            {
                Text = "50.0",
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Black,
                FontSize = 20
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Annotation Horizontal Alignment](images/annotation/maui-radial-gauge-annotation-horizontal-alignment.png)

The following code example shows how to set [`VerticalAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_VerticalAlignment) for annotations,

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis>
                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation DirectionUnit="AxisValue"
                                       DirectionValue="80"
                                       PositionFactor="0.4"
                                       VerticalAlignment="Start">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="50.0"
                                       TextColor="Black"
                                    FontAttributes="Bold"
                                    FontSize="20" />
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>
{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            sfRadialGauge.Axes.Add(radialAxis);

            GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionUnit = AnnotationDirection.AxisValue;
            gaugeAnnotation.DirectionValue = 80;
            gaugeAnnotation.VerticalAlignment = GaugeAlignment.Start;
            gaugeAnnotation.PositionFactor = 0.4;
            gaugeAnnotation.Content = new Label()
            {
                Text = "50.0",
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Black,
                FontSize = 20
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Annotation Vertical Alignment](images/annotation/maui-radial-gauge-annotation-vertical-alignment.png)
