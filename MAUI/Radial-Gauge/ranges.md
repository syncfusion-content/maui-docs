---
layout: post
title: Radial Range in .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about Range feature of Syncfusion<sup>&reg;</sup> .NET MAUI Radial Gauge control with customization support and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Radial Range in the .NET MAUI Radial Gauge

Radial range is a visual element that helps to quickly visualize where a value falls on the axis.

## Setting start and end value

The start and end values of range is set by [`StartValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_StartValue) and [`EndValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_EndValue) properties.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis >
                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="30"
                                  EndValue="65" />
                    </gauge:RadialAxis.Ranges>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            sfRadialGauge.Axes.Add(radialAxis);

            RadialRange radialRange = new RadialRange();
            radialRange.StartValue = 30;
            radialRange.EndValue = 65;
            radialAxis.Ranges.Add(radialRange);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Default Range](images/range/maui-radial-gauge-default-range.png)

N> In a 360 degree radial axis, you can maintain the range in reverse order by giving minimum value to EndValue and maximum value to StartValue. These values will be swapped if there is no 360 degree radial axis.

{% tabs %}

{% highlight xaml %}

  <gauge:SfRadialGauge x:Name="gauge">
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis x:Name="radialAxis"
                                  StartAngle="270"
                                  EndAngle="270"
                                  Minimum="0"
                                  Maximum="24"
                                  Interval="6"
                                  MinorTicksPerInterval="5"
                                  ShowFirstLabel="False">

                <gauge:RadialAxis.Ranges>
                    <gauge:RadialRange StartValue="12" EndValue="6"/>
                </gauge:RadialAxis.Ranges>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.StartAngle = 270;
            radialAxis.EndAngle = 270;
            radialAxis.Minimum = 0;
            radialAxis.Maximum = 24;
            radialAxis.Interval = 6;
            radialAxis.MinorTicksPerInterval = 5;
            radialAxis.ShowFirstLabel = false;
            sfRadialGauge.Axes.Add(radialAxis);

            RadialRange radialRange = new RadialRange();
            radialRange.StartValue = 12;
            radialRange.EndValue = 6;

            radialAxis.Ranges.Add(radialRange);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Free Hand Range](images/range/maui-radial-gauge-free-hand-range.png)

## Range customization

The following properties are used for the range customization:

* [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_Fill) – Specifies the color for the range.

* [`StartWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_StartWidth) – Specifies the start width of the range either in pixels or factor.

* [`EndWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_EndWidth) – Specifies the end width of the range either in pixels or factor.

* [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_WidthUnit) – Specifies whether the start width and end width of the range are set in pixels or factor.

* [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_GradientStops) - Specifies the gradient for the range.

### Equal range width

Range width can be controlled by [`StartWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_StartWidth) and [`EndWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_EndWidth) properties of the range.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Ranges>
                <gauge:RadialRange StartValue="30"
                                  EndValue="65"
                                  StartWidth="10"
                                  EndWidth="10" />
            </gauge:RadialAxis.Ranges>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RadialRange gaugeRange = new RadialRange();
gaugeRange.StartValue = 30;
gaugeRange.EndValue = 65;
gaugeRange.StartWidth = 10;
gaugeRange.EndWidth = 10;
radialAxis.Ranges.Add(gaugeRange);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Equal Range Width](images/range/maui-radial-gauge-equal-range-width.png)

### Different range width

By setting different values to [`StartWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_StartWidth) and [`EndWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_EndWidth) property, you can create different width ranges. 

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Ranges>
                <gauge:RadialRange StartValue="30"
                                  EndValue="65"
                                  StartWidth="5"
                                  EndWidth="20" />
            </gauge:RadialAxis.Ranges>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RadialRange gaugeRange = new RadialRange();
gaugeRange.StartValue = 30;
gaugeRange.EndValue = 65;
gaugeRange.StartWidth = 5;
gaugeRange.EndWidth = 20;
radialAxis.Ranges.Add(gaugeRange);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Range Thickness](images/range/maui-radial-gauge-range-thickness.png)

When the [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_WidthUnit) is set as pixels, the range will be rendered based on the provided pixel values in [`StartWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_StartWidth) and [`EndWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_EndWidth)

If the [`WidthUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_WidthUnit) is set as factor, the provided factor value in the start width and end width will be multiplied with the axis radius, respectively and calculated values assigned to the range width. The factor value ranges from 0 to 1.

### Setting gradient brush to the range

 The [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_GradientStops) property of [`range`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html) allows you to specify the smooth color transition to the pointer by specifying the different colors based on provided axis value.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis>
                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="30"
                                  EndValue="65"
                                  StartWidth="5"
                                  EndWidth="20">
                            <gauge:RadialRange.GradientStops>
                                <gauge:GaugeGradientStop Value="39"
                                                 Color="#FFBC4E9C" />
                                <gauge:GaugeGradientStop Value="56"
                                                 Color="#FFF80759" />
                            </gauge:RadialRange.GradientStops>
                        </gauge:RadialRange>
                    </gauge:RadialAxis.Ranges>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            sfRadialGauge.Axes.Add(radialAxis);

            RadialRange gaugeRange = new RadialRange();
            gaugeRange.StartValue = 30;
            gaugeRange.EndValue = 65;
            gaugeRange.StartWidth = 5;
            gaugeRange.EndWidth = 20;

            GaugeGradientStop gaugeGradientStop1 = new GaugeGradientStop();
            gaugeGradientStop1.Value = 39;
            gaugeGradientStop1.Color = Color.FromRgb(188, 78, 156);
            gaugeRange.GradientStops.Add(gaugeGradientStop1);

            GaugeGradientStop gaugeGradientStop2 = new GaugeGradientStop();
            gaugeGradientStop2.Value = 56;
            gaugeGradientStop2.Color = Color.FromRgb(248, 7, 89);
            gaugeRange.GradientStops.Add(gaugeGradientStop2);

            radialAxis.Ranges.Add(gaugeRange);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Range Gradient](images/range/maui-radial-gauge-range-gradient.png)

### Position customization

The range can be moved far or near to the axis line by using the [`RangeOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_RangeOffset) property. The [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_OffsetUnit) property of range allows you to specify the [`RangeOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_RangeOffset) either in factor or pixels, and the default value of [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_OffsetUnit) is pixel.

### Range offset in pixel

If the [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_OffsetUnit) is set as a pixels, the range will be moved from axis line based on the provided pixel value.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Ranges>
                <gauge:RadialRange StartValue="30"
                                  EndValue="65"
                                  RangeOffset="70" />
            </gauge:RadialAxis.Ranges>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RadialRange gaugeRange = new RadialRange();
gaugeRange.StartValue = 30;
gaugeRange.EndValue = 65;
gaugeRange.RangeOffset = 70;
radialAxis.Ranges.Add(gaugeRange);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Range Offset in Pixel](images/range/maui-radial-gauge-range-offset-in-pixel.png)

### Range offset in factor

If the [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_OffsetUnit) is set as a factor, the provided factor value in the [`RangeOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_RangeOffset) will be multiplied by the axis radius and the range will be moved from axis line to the corresponding position. The default value of [`OffsetUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_OffsetUnit) is Pixel.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis>
            <gauge:RadialAxis.Ranges>
                <gauge:RadialRange StartValue="30"
                                  EndValue="65"
                                  RangeOffset="0.4"
                                  OffsetUnit="Factor"/>
            </gauge:RadialAxis.Ranges>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
sfRadialGauge.Axes.Add(radialAxis);

RadialRange gaugeRange = new RadialRange();
gaugeRange.StartValue = 30;
gaugeRange.EndValue = 65;
gaugeRange.RangeOffset = 0.4;
gaugeRange.OffsetUnit = SizeUnit.Factor;
radialAxis.Ranges.Add(gaugeRange);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Range Offset in Factor](images/range/maui-radial-gauge-range-offset-in-factor.png)

## Setting range color to axis elements

You can set range color to axis labels and ticks using the [`UseRangeColorForAxis`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_UseRangeColorForAxis) property of axis.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis ShowAxisLine="False"
                          TickPosition="Outside"
                          LabelPosition="Outside"
                          StartAngle="270"
                          EndAngle="270"
                          UseRangeColorForAxis="True"
                          RadiusFactor="0.65"
                          Interval="10"
                          ShowFirstLabel="False"
                          IsInversed="True"
                          MinorTicksPerInterval="4">
                    <gauge:RadialAxis.MajorTickStyle>
                        <gauge:RadialTickStyle LengthUnit="Factor" Length="0.15"/>
                    </gauge:RadialAxis.MajorTickStyle>
                    <gauge:RadialAxis.MinorTickStyle>
                        <gauge:RadialTickStyle LengthUnit="Factor" Length="0.04"/>
                    </gauge:RadialAxis.MinorTickStyle>
            <gauge:RadialAxis.Ranges>
                    <gauge:RadialRange WidthUnit="Factor"
                                  OffsetUnit="Factor"
                                  RangeOffset="0.1"
                                  StartWidth="0.05"
                                  EndWidth="0.25"
                                  StartValue="0"
                                  EndValue="35"
                                  Fill="#FFF8B195">
                    </gauge:RadialRange>
                    <gauge:RadialRange WidthUnit="Factor"
                                  OffsetUnit="Factor"
                                  RangeOffset="0.1"
                                  StartWidth="0.05"
                                  EndWidth="0.25"
                                  StartValue="35"
                                  EndValue="70"
                                  Fill="#FFC06C84">
                    </gauge:RadialRange>
                    <gauge:RadialRange WidthUnit="Factor"
                                  OffsetUnit="Factor"
                                  RangeOffset="0.1"
                                  StartWidth="0.05"
                                  EndWidth="0.25"
                                  StartValue="70"
                                  EndValue="100"
                                  Fill="#FF355C7D">
                    </gauge:RadialRange>
                    </gauge:RadialAxis.Ranges>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowAxisLine = false;
            radialAxis.TickPosition = GaugeElementPosition.Outside;
            radialAxis.LabelPosition = GaugeLabelsPosition.Outside;
            radialAxis.StartAngle = 270;
            radialAxis.EndAngle = 270;
            radialAxis.UseRangeColorForAxis = true;
            radialAxis.RadiusFactor = 0.65;
            radialAxis.Interval = 10;
            radialAxis.ShowFirstLabel = false;
            radialAxis.IsInversed = true;
            radialAxis.MajorTickStyle.LengthUnit = SizeUnit.Factor;
            radialAxis.MinorTickStyle.LengthUnit = SizeUnit.Factor;
            radialAxis.MajorTickStyle.Length = 0.15;
            radialAxis.MinorTickStyle.Length = 0.04;
            radialAxis.MinorTicksPerInterval = 4;
            sfRadialGauge.Axes.Add(radialAxis);

            RadialRange gaugeRange1 = new RadialRange();
            gaugeRange1.WidthUnit = SizeUnit.Factor;
            gaugeRange1.OffsetUnit = SizeUnit.Factor;
            gaugeRange1.RangeOffset = 0.1;
            gaugeRange1.StartWidth = 0.05;
            gaugeRange1.EndWidth = 0.25;
            gaugeRange1.StartValue = 0;
            gaugeRange1.EndValue = 35;
            gaugeRange1.Fill = new SolidColorBrush(Color.FromRgb(248, 177, 149));
            radialAxis.Ranges.Add(gaugeRange1);

            RadialRange gaugeRange2 = new RadialRange();
            gaugeRange2.WidthUnit = SizeUnit.Factor;
            gaugeRange2.OffsetUnit = SizeUnit.Factor;
            gaugeRange2.RangeOffset = 0.1;
            gaugeRange2.StartWidth = 0.05;
            gaugeRange2.EndWidth = 0.25;
            gaugeRange2.StartValue = 35;
            gaugeRange2.EndValue = 70;
            gaugeRange2.Fill = new SolidColorBrush(Color.FromRgb(192, 108, 132));
            radialAxis.Ranges.Add(gaugeRange2);

            RadialRange gaugeRange3 = new RadialRange();
            gaugeRange3.WidthUnit = SizeUnit.Factor;
            gaugeRange3.OffsetUnit = SizeUnit.Factor;
            gaugeRange3.RangeOffset = 0.1;
            gaugeRange3.StartWidth = 0.05;
            gaugeRange3.EndWidth = 0.25;
            gaugeRange3.StartValue = 70;
            gaugeRange3.EndValue = 100;
            gaugeRange3.Fill = new SolidColorBrush(Color.FromRgb(53, 92, 125));
            radialAxis.Ranges.Add(gaugeRange3);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Range Color to Axis Element](images/range/maui-radial-gauge-range-color-to-axis-element.png)

## Range label

A text can be displayed on range using the [`Label`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_Label) property. The provided text can be customized using [`LabelStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_LabelStyle) property. 

{% tabs %}

{% highlight xaml %}

<Grid >
        <Grid.Resources>
            <gauge:GaugeLabelStyle x:Key="labelStyle" FontSize="20"/>
        </Grid.Resources>
        <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis ShowLabels="False"
                          ShowAxisLine="False"
                          ShowTicks="False"
                          Minimum="0"
                          Maximum="99">

                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="0"
                                  EndValue="33"
                                  Label="Slow"
                                  WidthUnit="Factor"
                                  StartWidth="0.65"
                                  EndWidth="0.65"
                                  LabelStyle="{StaticResource labelStyle}"
                                  Fill="#FFFE2A25" />
                        <gauge:RadialRange StartValue="33"
                                  EndValue="66"
                                  Label="Moderate"
                                  WidthUnit="Factor"
                                  StartWidth="0.65"
                                  EndWidth="0.65"
                                  LabelStyle="{StaticResource labelStyle}"
                                  Fill="#FFFFBA00" />
                        <gauge:RadialRange StartValue="66"
                                  EndValue="99"
                                  Label="Fast"
                                  WidthUnit="Factor"
                                  StartWidth="0.65"
                                  EndWidth="0.65"
                                  LabelStyle="{StaticResource labelStyle}"
                                  Fill="#FF00AB47" />
                        <gauge:RadialRange StartValue="0"
                                  EndValue="99"
                                  WidthUnit="Factor"
                                  StartWidth="0.15"
                                  EndWidth="0.15"
                                  OffsetUnit="Factor"
                                  RangeOffset="0.63"
                                  Fill="#4D9b9b9b" />
                    </gauge:RadialAxis.Ranges>

                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="60"
                                     NeedleLength="0.6"
                                     NeedleStartWidth="2"
                                     NeedleEndWidth="15"
                                     KnobRadius="15"
                                     KnobSizeUnit="Pixel" />
                    </gauge:RadialAxis.Pointers>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

    </Grid>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowLabels = false;
            radialAxis.ShowAxisLine = false;
            radialAxis.ShowTicks = false;
            radialAxis.Minimum = 0;
            radialAxis.Maximum = 99;
            sfRadialGauge.Axes.Add(radialAxis);

            RadialRange gaugeRange1 = new RadialRange();
            gaugeRange1.StartValue = 0;
            gaugeRange1.EndValue = 33;
            gaugeRange1.Label = "Slow";
            gaugeRange1.WidthUnit = SizeUnit.Factor;
            gaugeRange1.StartWidth = 0.65;
            gaugeRange1.EndWidth = 0.65;
            gaugeRange1.LabelStyle.FontSize = 20;
            gaugeRange1.Fill = new SolidColorBrush(Color.FromRgb(254, 42, 37));
            radialAxis.Ranges.Add(gaugeRange1);

            RadialRange gaugeRange2 = new RadialRange();
            gaugeRange2.StartValue = 33;
            gaugeRange2.EndValue = 66;
            gaugeRange2.Label = "Moderate";
            gaugeRange2.WidthUnit = SizeUnit.Factor;
            gaugeRange2.StartWidth = 0.65;
            gaugeRange2.EndWidth = 0.65;
            gaugeRange2.LabelStyle.FontSize = 20;
            gaugeRange2.Fill = new SolidColorBrush(Color.FromRgb(255, 186, 0));
            radialAxis.Ranges.Add(gaugeRange2);

            RadialRange gaugeRange3 = new RadialRange();
            gaugeRange3.StartValue = 66;
            gaugeRange3.EndValue = 99;
            gaugeRange3.Label = "Fast";
            gaugeRange3.WidthUnit = SizeUnit.Factor;
            gaugeRange3.StartWidth = 0.65;
            gaugeRange3.EndWidth = 0.65;
            gaugeRange3.LabelStyle.FontSize = 20;
            gaugeRange3.Fill = new SolidColorBrush(Color.FromRgb(0, 171, 71));
            radialAxis.Ranges.Add(gaugeRange3);

            RadialRange gaugeRange4 = new RadialRange();
            gaugeRange4.StartValue = 0;
            gaugeRange4.EndValue = 99;
            gaugeRange4.WidthUnit = SizeUnit.Factor;
            gaugeRange4.StartWidth = 0.15;
            gaugeRange4.EndWidth = 0.15;
            gaugeRange4.OffsetUnit = SizeUnit.Factor;
            gaugeRange4.RangeOffset = 0.63;
            gaugeRange4.Fill = new SolidColorBrush(Color.FromRgba(155, 155, 155, 77));
            radialAxis.Ranges.Add(gaugeRange4);

            NeedlePointer needlePointer = new NeedlePointer();
            needlePointer.Value = 60;
            needlePointer.NeedleLength = 0.6;
            needlePointer.NeedleStartWidth = 2;
            needlePointer.NeedleEndWidth = 15;
            needlePointer.KnobRadius = 15;
            needlePointer.KnobSizeUnit = SizeUnit.Pixel;
            radialAxis.Pointers.Add(needlePointer);

            this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge Range Label](images/range/maui-radial-gauge-range-label.png)
