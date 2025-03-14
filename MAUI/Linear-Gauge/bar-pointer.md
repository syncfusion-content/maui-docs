---
layout: post
title: Bar Pointer in .NET MAUI Linear Gauge control | Syncfusion<sup>&reg;</sup>
description: Learn here all about adding and customizing Bar Pointer of Syncfusion<sup>&reg;</sup> .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Bar Pointer in .NET MAUI Linear Gauge (SfLinearGauge)

A bar pointer is an accenting line or shaded background that can be placed on a Linear Gauge to mark any current value in the scale track. The bar pointers always start from the minimum value of the scale and end with the specified value. So, the [`Value`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_Value) property is a required parameter for creating a bar pointer.

## Default bar pointer

The following code sample creates a default bar pointer with the value 50. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value="50"/>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.BarPointers.Add(new BarPointer()
		{
			Value = 50,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Initialize linear gauge for bar pointer](images/bar-pointer/default_bar_pointer.PNG)

## Customize bar pointer thickness

The thickness can be changed using the [`PointerSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_PointerSize) property of the bar pointer. The following code sample demonstrates the same. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value="50" PointerSize="10"/>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.BarPointers.Add(new BarPointer()
		{
			Value = 50,
			PointerSize = 10
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change the bar pointer thickness](images/bar-pointer/bar_thickness.PNG)

## Customize edge style

The edge style can be changed using the [`CornerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_CornerStyle) property of the bar pointer. The edge style can be any of the [`StartCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_StartCurve), [`EndCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_EndCurve), [`BothCurve`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothCurve), and [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothFlat) options. The default value is [`BothFlat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.CornerStyle.html#Syncfusion_Maui_Gauges_CornerStyle_BothFlat).

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value="50" PointerSize="10" 
                                      Offset="5"
                                      Position="Outside" 
                                      CornerStyle="BothCurve"/>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.BarPointers.Add(new BarPointer()
		{
			Value = 50,
			PointerSize = 10,
			Offset = 5,
			Position = GaugeElementPosition.Outside,
			CornerStyle = CornerStyle.BothCurve
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change the bar pointer edge style](images/bar-pointer/edge_style.PNG)

## Customize the position

By default, the bar pointer is positioned cross to the scale. This position can be changed by the [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_Position) property of a pointer. It is possible to position the bar pointer [`Inside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html#Syncfusion_Maui_Gauges_GaugeElementPosition_Inside), [`Cross`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html#Syncfusion_Maui_Gauges_GaugeElementPosition_Cross), or [`Outside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html#Syncfusion_Maui_Gauges_GaugeElementPosition_Outside) the scale. The following code sample demonstrates how to change the bar pointer position to inside the scale.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value="50" Position="Inside"/>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.BarPointers.Add(new BarPointer()
		{
			Value = 50,
			Position = GaugeElementPosition.Inside,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize linear gauge for bar pointer position](images/bar-pointer/bar_pointer_change_position.PNG)

## Customize the offset

In addition to position the bar pointer, it is also possible to change the offset of the bar pointer. The [`Offset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_Offset) value is the distance from the scale and it has no effect on cross-positioned elements. The following  code sample demonstrates how to change the offset value of the bar pointer. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value="50" Position="Outside" Offset="5"/>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.BarPointers.Add(new BarPointer()
		{
			Value = 50,
			Position = GaugeElementPosition.Outside,
			Offset = 5
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize linear gauge bar pointer offset](images/bar-pointer/bar_pointer_offset.PNG)

## Change the color of bar pointer 

The color of the bar pointer can be changed by the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_Fill) property. The following code sample demonstrates the same. 

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value="50" Fill="Red"/>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.BarPointers.Add(new BarPointer()
		{
			Value = 50,
			Fill = new SolidColorBrush(Colors.Red),
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Apply color to bar pointer](images/bar-pointer/bar_color.PNG)

## Apply gradient

The gradient can be applied by using the [`GradientStops`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_GradientStops) property of bar pointer. The following code sample demonstrates how to apply a gradient to the bar pointer.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Position="Outside" Offset="5" 
                                      CornerStyle="BothCurve" Value="70">
                        <gauge:BarPointer.GradientStops>
                            <gauge:GaugeGradientStop Value="0" Color="Green"/>
                            <gauge:GaugeGradientStop Value="35" 
                                                     Color="#ff0074E3"/>
                        </gauge:BarPointer.GradientStops>
                    </gauge:BarPointer>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
ObservableCollection<GaugeGradientStop> gradientStops = new ObservableCollection<GaugeGradientStop>();
gradientStops.Add(new GaugeGradientStop() { Value = 0, Color = Colors.Green });
gradientStops.Add(new GaugeGradientStop() { Value = 35, Color = Color.FromArgb("#ff0074E3") });
gauge.BarPointers.Add(new BarPointer()
{
	Value = 70,
	Position = GaugeElementPosition.Outside,
	Offset = 5,
	CornerStyle = CornerStyle.BothCurve,
	GradientStops = gradientStops
});
this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Apply radial gradient to bar pointer](images/bar-pointer/gradient_bar.PNG)

## Child support

By using the [`Child`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html#Syncfusion_Maui_Gauges_BarPointer_Child) property of bar pointer, you can provide a child for the bar pointer. To improve readability, the child content is used to add any UI content, such as text or images, inside the bar pointer.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge ShowLabels="False" ShowTicks="False">
                <gauge:SfLinearGauge.LineStyle>
                    <gauge:LinearLineStyle CornerStyle="BothCurve" 
                                           Thickness="30"/>
                </gauge:SfLinearGauge.LineStyle>
                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer CornerStyle="BothCurve" Value="50" 
                                      PointerSize="30">
                        <gauge:BarPointer.Child>
                            <Label Text="50%" Margin="0,0,10,0" 
                                   HorizontalOptions="End"
                                   TextColor="White" VerticalOptions="Center"/>
                        </gauge:BarPointer.Child>
                    </gauge:BarPointer>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.ShowLabels = false;
		gauge.ShowTicks = false;
		gauge.LineStyle.Thickness = 30;
		gauge.LineStyle.CornerStyle = CornerStyle.BothCurve;
		Label label = new Label()
		{
			Text = "50%",
			Margin = new Thickness(0, 0, 10, 0),
			TextColor = Colors.White,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center
		};
		gauge.BarPointers.Add(new BarPointer()
		{
			Value = 50,
			PointerSize = 30,
			CornerStyle = CornerStyle.BothCurve,
			Child = label
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Child support in bar pointers in a linear gauge](images/bar-pointer/bar_pointer_child_support.PNG)