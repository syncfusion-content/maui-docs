---
layout: post
title: Interaction in .NET MAUI Linear Gauge control | Syncfusion<sup>&reg;</sup>
description: Learn here all about the interactions in Syncfusion<sup>&reg;</sup> .NET MAUI Linear Gauge (SfLinearGauge) control and more
platform: maui
control: SfLinearGauge
documentation: ug
---

# Pointers in .NET MAUI Linear Gauge (SfLinearGauge)

The pointer is used to indicate values on a scale. The Linear Gauge control has three types of pointers:

[`Bar pointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html)
[`Shape Pointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html)
[`Content pointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ContentPointer.html)

All the pointers can be customized as needed. You can add multiple pointers to the gauge to point multiple values on the same scale. The value of the pointer is set using the [`Value`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_Value) property.

![Pointer in linear gauge](images/pointers/pointers.PNG)

## Interaction with pointers

The following code sample demonstrates how to update a simple marker pointer value based on swipe or drag gestures.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge >
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="70" IsInteractive="True" 
                                              Fill="Blue"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 70,
			IsInteractive = true,
			Fill=new SolidColorBrush(Colors.Blue)	
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![Simple pointer interaction in linear gauge](images/pointers/simple_interaction.gif)

## Step frequency

The [`StepFrequency`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_StepFrequency) property is used to specify the interval between snap points while dragging the pointer.

For example, if the value of [`StepFrequency`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_StepFrequency) is 20, the pointer will not move continuously while dragging; instead, it will update in terms of 20.

N> To work with the [`StepFrequency`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_StepFrequency) value, enable pointer interaction support.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="70" IsInteractive="True" 
                                              StepFrequency="5" Fill="Blue"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 70,
			IsInteractive = true,
			StepFrequency = 5,
			Fill=new SolidColorBrush(Colors.Blue)	
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}

## Drag offset

The [`DragOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_DragOffset) property is used to specify the outer dragging offset for pointer. When the pointer is pressed close to the pointer, this value helps in dragging the pointer. The default value of [`DragOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_DragOffset) is 15d.

For example, if the value of [`DragOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_DragOffset) is 20, the pointer will be dragged while interacting with that pointer around 20 pixels.	

If the value of [`DragOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_DragOffset) is 0, the pointer will be dragged while interacting with exact pointer bounds alone.

N> To work with the [`DragOffset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_DragOffset) value, enable pointer interaction support.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="70" IsInteractive="True" 
                                              DragOffset="5" Fill="Blue"/>
                </gauge:SfLinearGauge.MarkerPointers>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		gauge.MarkerPointers.Add(new LinearShapePointer()
		{
			Value = 70,
			IsInteractive = true,
			DragOffset = 5,
			Fill=new SolidColorBrush(Colors.Blue)	
		});
		this.Content = gauge;

{% endhighlight %}

{% endtabs %}


## Event

[`ValueChangeStarted`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_ValueChangeStarted) - Occurs whenever the pointer starts to drag.

[`ValueChanging`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_ValueChanging) - Occurs before the current drag value gets updated as pointer value. The [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ValueChangingEventArgs.html#Syncfusion_Maui_Gauges_ValueChangingEventArgs_Cancel) argument of [`ValueChangingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ValueChangingEventArgs.html) allows to restrict the update of current drag value.

[`ValueChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_ValueChanged) - Occurs whenever the pointer value is changed while dragging.

[`ValueChangeCompleted`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearPointer.html#Syncfusion_Maui_Gauges_LinearPointer_ValueChangeCompleted) - Occurs once the dragging of the pointer gets completed.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge >
   <gauge:SfLinearGauge.MarkerPointers>
      <gauge:LinearShapePointer Value="70" IsInteractive="True" 
                                ValueChanging="LinearShapePointer_ValueChanging"
                                ValueChanged="LinearShapePointer_ValueChanged"
                                Fill="Blue"/>
   </gauge:SfLinearGauge.MarkerPointers>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
		LinearShapePointer linearShapePointer = new LinearShapePointer()
		{
			Value = 70,
			IsInteractive = true,
			Fill = new SolidColorBrush(Colors.Blue)
		};
		linearShapePointer.ValueChanging += LinearShapePointer_ValueChanging;
		linearShapePointer.ValueChanged += LinearShapePointer_ValueChanged;
		gauge.MarkerPointers.Add(linearShapePointer);
		this.Content = gauge;

...

private void LinearShapePointer_ValueChanged(object sender, Syncfusion.Maui.Gauges.ValueChangedEventArgs e)
	{

	}

	private void LinearShapePointer_ValueChanging(object sender, ValueChangingEventArgs e)
	{
		if (e.NewValue > 70)
			e.Cancel = true;
	}

{% endhighlight %}

{% endtabs %}
