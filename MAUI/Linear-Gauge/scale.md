---
layout: post
title: scale in .NET MAUI linear gauge control | Syncfusion<sup>&reg;</sup>
description: Learn here all about adding and customizing scale of Syncfusion<sup>&reg;</sup> .NET MAUI linear gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge

documentation: ug
---

# scale in .NET MAUI linear gauge (SfLinearGauge)

The linear gauge scale on which a set of values can be plotted. A scale can be customized by changing the thickness, color, and edge styles. scale elements such as labels and ticks can also be easily customized and the scale can be inverted.

## Default scale

By default, scale will have the [`minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_minimum) scale value as 0 and the [`maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_maximum) scale value as 100. Without any changes, the default scale of the linear gauge will be displayed as follows.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge />

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Initialize linear gauge for axis](images/getting-started/default_linear_gauge.PNG)

## Customize minimum and maximum scale values

The [`minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_minimum) and [`maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_maximum) properties of a linear gauge can be used to customize the scale values. In the following code sample, the the scale is customized to have a [`minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_minimum) value of -50 to [`maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_maximum) value of 50. The scale values are displayed by the labels. Customizing these label styles is further explained in the next topics.  

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge  minimum="-50" maximum="50" />

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
gauge.minimum=-50;
gauge.maximum=50;
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Update linear gauge for axis scale](images/axis/minmax_axis_linear_gauge.PNG)

## Customize scale orientation

The orientation of linear scale can be customized by using the [`orientation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_orientation) property of linear gauge.

When the orientation property is Vertical, the scale will be rendered in a bottom-to-top direction.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge orientation="Vertical"/>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.orientation = Gaugeorientation.Vertical;
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Update orientation for axis scale](images/axis/linear_gauge_orientation.PNG)

## Customize scale track style

The linear scale track can be customized using the [`line style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html) property. The [`line style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html) has the following properties.

* [`Thickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_Thickness) – Customizes the thickness of the scale track.
* [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_Fill) – Customizes the color of the scale track with a solid color.
* [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_GradientStops) - Customizes the color of the scale track with a gradient.
* [`corner radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_corner radius) - Customizes the scale track edge corners.
* [`corner style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_corner style) - Customizes the scale track edge style as flat or curve.

The following code sample demonstrates how to customize the [`Thickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_Thickness) and [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_Fill) properties:

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.line style>
                    <gauge:Linearline style Thickness="15"/>
                </gauge:SfLinearGauge.line style>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();

        gauge.line style.Thickness = 15;
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change axis track thickness in linear gauge](images/axis/axis_thickness.PNG)

## Apply solid color

The following code sample sets solid colors to the gauge track.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.line style>
                    <gauge:Linearline style Fill="Blue"/>
                </gauge:SfLinearGauge.line style>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.line style.Fill = new SolidColorBrush(Colors.Blue);
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Apply color to axis in linear gauge](images/axis/axis_solid_color.PNG)

## Apply gradient

The [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_Fill) property of [`line style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html) allows you to set a solid color, while the [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_GradientStops) property of [`line style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html) allows you to apply linear-gradient to scale track.

The following code sample sets gradient colors to the scale track.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.line style>
                    <gauge:Linearline style>
                        <gauge:Linearline style.GradientStops>
                            <gauge:GaugeGradientStop Value="0" Color="Red"/>
                            <gauge:GaugeGradientStop Value="100" Color="Blue"/>
                        </gauge:Linearline style.GradientStops>
                    </gauge:Linearline style>
                </gauge:SfLinearGauge.line style>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.line style.GradientStops.Add(new GaugeGradientStop() { Value = 0, Color = Colors.Red });
        gauge.line style.GradientStops.Add(new GaugeGradientStop() { Value = 100, Color = Colors.Blue });
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Apply color to axis in linear gauge](images/axis/axis_gradient.PNG)

## Customize corners

The [`corner style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_corner style) property of [`line style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html) specifies the corner type for the scale track. The corners can be customized with [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.corner style.html#Syncfusion_Maui_Gauges_corner style_BothFlat), [`BothCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.corner style.html#Syncfusion_Maui_Gauges_corner style_BothCurve), [`StartCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.corner style.html#Syncfusion_Maui_Gauges_corner style_StartCurve), and [`EndCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.corner style.html#Syncfusion_Maui_Gauges_corner style_EndCurve) options. The default value of this property is [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.corner style.html#Syncfusion_Maui_Gauges_corner style_BothFlat).

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.line style>
                    <gauge:Linearline style Thickness="20" 
                                           corner style="BothCurve"/>
                </gauge:SfLinearGauge.line style>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.line style.Thickness = 20;
        gauge.line style.corner style = corner style.BothCurve;
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change axis track edge style](images/axis/axis_corner_style.PNG)

Also [`corner radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_corner radius) allows you to set custom corner style for linear scale. 

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                 <gauge:SfLinearGauge.line style>
                    <gauge:Linearline style Thickness="20" 
                                           corner radius="0,10,0,10"/>
                </gauge:SfLinearGauge.line style>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.line style.Thickness = 20;
        gauge.line style.corner radius = new Thickness(0, 10, 0, 10);
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change axis track edge style](images/axis/axis_corner_radius.PNG)

N> If you set both [`corner style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_corner style) and [`corner radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_corner radius) in the [`line style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html), [`corner style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.Linearline style.html#Syncfusion_Maui_Gauges_Linearline style_corner style) will be first priority for scale. 

## Inverse the scale

The direction of linear gauge scale can be customized by the [`isInversed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_isInversed) property.
When the [`isInversed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_isInversed) property is true, the scale can be placed in an inverse direction. The default value of the [`isInversed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_isInversed) property is false.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge isInversed="True">
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.isInversed = true;
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

You can see that the scale values are displayed from 100 to 0 as the scale track is inversed.

![Inverse linear gauge for axis](images/axis/axis_inversed.PNG)

## Change scale track visibility

You can hide the scale track by setting the [`showLine`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_showLine) property to false. The default value of this property is true.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge showLine="False">
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        gauge.showLine = false;
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Hide linear gauge axis track](images/axis/hide_axis_track.PNG)

## Customize scale values

Linear gauge allows you to display a set of values along with a custom scale based on your business logic using the [`generateVisibleLabels`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_generateVisibleLabels), [`valueToFactor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_valueToFactor_System_Double_), and [`factorToValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_factorToValue_System_Double_) callbacks.

{% tabs %}

{% highlight xaml %}

 <local:LinearGauge minimum="1" maximum="10000">
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="1000" />
                </gauge:SfLinearGauge.MarkerPointers>
            </local:LinearGauge>

{% endhighlight %}

{% highlight c# %}

public class LinearGauge : SfLinearGauge
{
    int labelsCount;
    public override List<GaugeLabelInfo> generateVisibleLabels()
    {
        List<GaugeLabelInfo> labelInfos = new List<GaugeLabelInfo>();
        int minimum = (int)LogBase(this.minimum, 10);
        int maximum = (int)LogBase(this.maximum, 10);
        for (int i = minimum; i <= maximum; i++)
        {
            double value = Math.Floor(Math.Pow(10, i)); // logBase  value is
            GaugeLabelInfo label = new GaugeLabelInfo()
            {
                Value = value,
                Text = value.ToString()
            };
            labelInfos.Add(label);
        }

        labelsCount = labelInfos.Count;
        return labelInfos;
    }

    private double LogBase(double value, int baseValue)
    {
        return Math.Log(value) / Math.Log(baseValue);
    }

    public override double valueToFactor(double value)
    {
        return LogBase(value, 10) / (labelsCount - 1);
    }

    public override double factorToValue(double factor)
    {
        return Math.Pow(Math.E, factor * (labelsCount - 1) * Math.Log(10));
    }
}

{% endhighlight %}

{% endtabs %}

![Custom axis track](images/axis/custom_axis.PNG)