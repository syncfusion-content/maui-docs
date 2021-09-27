---
layout: post
title: Getting Started with .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Radial Gauge(sfRadialGauge) control and more.
platform: .NET MAUI 
control: SfRadialGauge
documentation: ug
---

# Getting Started with .NET MAUI Radial Gauge

This section explains the steps required to add the `.NET MAUI Radial Gauge` control and its elements such as axis, range, pointer and annotation. This section covers only basic features needed to get started with Syncfusion radial gauge control.

## Creating an application with .NET MAUI Radial Gauge

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfRadialGauge to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Gauges] and then install it.

3. Import the control namespace `Syncfusion.Maui.Gauges` in XAML or C# code.

4. Initialize the SfRadialGauge control

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge />

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

## Add axis to the radial gauge

Axes contain a list of axis elements, where you can add any number of radial axes inside the gauge. You can specify the minimum and maximum values of axis using the `Minimum` and `Maximum` properties as demonstrated in the following code snippet.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis Minimum="0"
                          Maximum="150" />
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();
RadialAxis radialAxis = new RadialAxis();
radialAxis.Minimum = 0;
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge with Axis](images/getting-started/maui-radial-gauge-with-axis.png)

## Add range to the radial gauge

Ranges contain a list of range elements, where you can add any number of ranges inside the axis. You can specify the start value, end value and background color for range using the [`StartValue`](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Gauges.GaugeRange.html#Syncfusion_UI_Xaml_Gauges_GaugeRange_StartValue), [`EndValue`](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Gauges.GaugeRange.html#Syncfusion_UI_Xaml_Gauges_GaugeRange_EndValue) and `Background` properties as demonstrated in the following code.   

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis Interval="10"
                          Maximum="150" >
                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="0"
                                  EndValue="50"
                                  Fill="Red" />
                        <gauge:RadialRange StartValue="50"
                                  EndValue="100"
                                  Fill="Orange" />
                        <gauge:RadialRange StartValue="100"
                                  EndValue="150"
                                  Fill="Green" />
                    </gauge:RadialAxis.Ranges>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.Maximum = 150;
            sfRadialGauge.Axes.Add(radialAxis);

            RadialRange gaugeRange1 = new RadialRange();
            gaugeRange1.StartValue = 0;
            gaugeRange1.EndValue = 50;
            gaugeRange1.Fill = new SolidColorBrush(Colors.Red);
            radialAxis.Ranges.Add(gaugeRange1);

            RadialRange gaugeRange2 = new RadialRange();
            gaugeRange2.StartValue = 50;
            gaugeRange2.EndValue = 100;
            gaugeRange2.Fill = new SolidColorBrush(Colors.Orange);
            radialAxis.Ranges.Add(gaugeRange2);

            RadialRange gaugeRange3 = new RadialRange();
            gaugeRange3.StartValue = 100;
            gaugeRange3.EndValue = 150;
            gaugeRange3.Fill = new SolidColorBrush(Colors.Green);
            radialAxis.Ranges.Add(gaugeRange3);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge with Range](images/getting-started/maui-radial-gauge-with-range.png)

## Add pointer to the radial gauge

Pointers contains a list of pointer elements, where you can add any number of gauge pointers such as `NeedlePointer`, `RangePointer` and `MarkerPointer` inside the axis to indicate the value.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis Maximum="150"
                          Interval="10">
..
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value="90" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);
..

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 90;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge with Pointer](images/getting-started/maui-radial-gauge-with-pointer.png)

## Add annotation to the radial gauge

You can add any number of views such as text or image as an annotation inside the axis. The position of annotation can be customized using the `DirectionUnit` `DirectionValue` and `PositionFactor` properties as demonstrated in the following code.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis Maximum="150"
                          Interval="10">
            ..
                   <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation x:Name="annotation"
                                       DirectionUnit="Angle"
                                       DirectionValue="90"
                                       PositionFactor="0.5">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="90"
                                   FontSize="25"
                                   FontAttributes="Bold" 
                                       TextColor="Black"/>
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
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);
..

GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionUnit = AnnotationDirection.Angle;
            gaugeAnnotation.DirectionValue = 90;
            gaugeAnnotation.PositionFactor = 0.5;
            gaugeAnnotation.Content = new Label() 
            {
                Text = "90", 
                FontAttributes = FontAttributes.Bold, 
                FontSize = 25,
                TextColor = Colors.Black
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge with Annotation](images/getting-started/maui-radial-gauge-with-annotation.png)

The following code example gives you the complete code of above configurations.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis Interval="10"
                          Maximum="150" >
                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="0"
                                  EndValue="50"
                                  Fill="Red" />
                        <gauge:RadialRange StartValue="50"
                                  EndValue="100"
                                  Fill="Orange" />
                        <gauge:RadialRange StartValue="100"
                                  EndValue="150"
                                  Fill="Green" />
                    </gauge:RadialAxis.Ranges>
                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="90" />
                    </gauge:RadialAxis.Pointers>
                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation x:Name="annotation"
                                       DirectionUnit="Angle"
                                       DirectionValue="90"
                                       PositionFactor="0.5">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="90"
                                   FontSize="25"
                                   FontAttributes="Bold" 
                                       TextColor="Black"/>
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
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);

GaugeRange gaugeRange1 = new GaugeRange();
gaugeRange1.StartValue = 0;
gaugeRange1.EndValue = 50;
gaugeRange1.Background = new SolidColorBrush(Colors.Red);
radialAxis.Ranges.Add(gaugeRange1);

GaugeRange gaugeRange2 = new GaugeRange();
gaugeRange2.StartValue = 50;
gaugeRange2.EndValue = 100;
gaugeRange2.Background = new SolidColorBrush(Colors.Orange);
radialAxis.Ranges.Add(gaugeRange2);

GaugeRange gaugeRange3 = new GaugeRange();
gaugeRange3.StartValue = 100;
gaugeRange3.EndValue = 150;
gaugeRange3.Background = new SolidColorBrush(Colors.Green);
radialAxis.Ranges.Add(gaugeRange3);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 90;
radialAxis.Pointers.Add(needlePointer);

GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionUnit = AnnotationDirection.Angle;
            gaugeAnnotation.DirectionValue = 90;
            gaugeAnnotation.PositionFactor = 0.5;
            gaugeAnnotation.Content = new Label() 
            {
                Text = "90", 
                FontAttributes = FontAttributes.Bold, 
                FontSize = 25,
                TextColor = Colors.Black
            };
radialAxis.Annotations.Add(gaugeAnnotation);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}