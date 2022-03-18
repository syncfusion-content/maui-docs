---
layout: post
title: Shape Marker Pointer in .NET MAUI Linear Gauge control | Syncfusion
description: Learn here all about adding and customizing Shape Marker Pointer of Syncfusion .NET MAUI Linear Gauge (SfLinearGauge) control and more.
platform: maui
control: SfLinearGauge
documentation: ug
---

# Shape Marker Pointer in .NET MAUI Linear Gauge (SfLinearGauge)

The [`LinearShapePointer`]() in [`SfLinearGauge`]() have the following pre-defined shapes to mark a specific value. The default shape pointer is `InvertedTriangle`. 

1. `Triangle`
2. `Inverted Triangle`
3. `Circle`
4. `Diamond`
5. `Rectangle`

The following is the default appearance of default shape pointer.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 50,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Initialize linear gauge for shape pointer](images/shape-pointer/default_shape_pointer.PNG)

## Change the size

The size of the marker pointer can be changed by the [`ShapeHeight`]() and [`ShapeWidth`]() properties of [`LinearShapePointer`](). The following code sample demonstrates how to change the size of a shape pointer.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" ShapeHeight="25" ShapeWidth="25"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 50,
			ShapeHeight = 25,
			ShapeWidth = 25,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Set size of linear gauge shape pointer](images/shape-pointer/shape_pointer_size.PNG)

## Customize color

The color of the shape pointer can be changed by the [`Fill`]() property. The following code example demonstrates the same.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" Fill="Red"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 50,
			Fill=new SolidColorBrush(Colors.Red)
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change shape pointer color](images/shape-pointer/shape_pointer_color.PNG)

## Customize the border

The border can be customized by the [`Stroke`]() and [`StrokeThickness`]() properties of the [`LinearShapePointer`]().

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" StrokeThickness="2" Stroke="Red"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 50,
			StrokeThickness = 2,
			Stroke = Colors.Red
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Customize shape pointer border](images/shape-pointer/shape_border.PNG)

## Shadow support

The shadow can be applied by the [`HasShadow`]() property.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" ShapeType="Circle" HasShadow="True"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 50,
			ShapeType = ShapeType.Circle,
			HasShadow = true,
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change shape pointer elevation](images/shape-pointer/pointer_shadow.PNG)

## Change marker alignment

The marker pointer alignment can be changed by the [`Alignment`]() property of [`LinearShapePointer`]().The available marker pointer alignments are `Start`, `End`, and `Center`.

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" ShapeType="Rectangle" Alignment="End" OffsetY="-5"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 50,
			ShapeType = ShapeType.Rectangle,
			OffsetY = -5,
			Alignment = GaugeAlignment.End
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change shape pointer alignment](images/shape-pointer/shape_marker_alignment.PNG)

## Customize position

By default, the shape pointer is positioned `Outside` the axis. This position can be changed by the [`Position`]() property of pointer. It is possible to position the shape pointer `Inside`, `Cross`, or `Outside` the scale. The following code sample demonstrates how to change the shape pointer position to inside the axis.  

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" ShapeType="Circle" Position="Cross" Fill="Blue"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 50,
			ShapeType = ShapeType.Circle,
			Position=GaugeElementPosition.Cross,
			Fill=new SolidColorBrush(Colors.Blue),
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Change shape pointer position](images/shape-pointer/shape_pointer_position.PNG)

## Customize offset

In addition to position the shape pointer, it is also possible to change the offset of the shape pointer. The [`OffsetX`]() and [`OffsetY`]() are the distance from the axis and the cross positioned elements will not get affected by the [`OffsetX`]() and [`OffsetY`]() values. The following code sample demonstrates how to change the [`OffsetX`]() and [`OffsetY`]() values of the shape pointer. 

{% tabs %}

{% highlight xaml %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" ShapeType="Triangle" Position="Inside" OffsetY="25"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

 <gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="50" ShapeType="Triangle" Position="Inside" OffsetY="25"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% endtabs %}

![Customize linear gauge bar pointer offset](images/shape-pointer/shape_pointer_offset.PNG)

