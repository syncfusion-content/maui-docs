---
layout: post
title: Events in.NET MAUI Slider control | Syncfusion 
description: Learn here all about adding and customizing through events of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Events in .NET MAUI Slider (SfSlider)

This section explains about how to add the events for slider.

## Handle ValueChanging, ValueChanged, ValueChangeStart, and ValueChangeEnd callbacks

* [ValueChangeStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChangeStart) -  Called when the user selecting a new value for the slider by tap/mouse down in the thumb.
* [ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChanging) - Called when the user is selecting a new value for the slider by dragging the thumb.
* [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChanged) - Called when the user completed selecting a new value.
* [ValueChangeEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChangeEnd) - Called when the user stopped interacting with slider by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider  Minimum="2010-01-01" 
  	           Maximum="2020-01-01" 
		   Value="2014-01-01" 
	           ValueChangeStart="OnValueChangeStart" 
	 	   ValueChanging="OnValueChanging" 
		   ValueChanged="OnValueChanged" 
		   ValueChangeEnd="OnValueChangeEnd">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

{
   SfSlider slider = new SfSlider();
   slider.ValueChangeStart += OnValueChanged;
   slider.ValueChanging += OnValueChanged;
   slider.ValueChanged += OnValueChanged;
   slider.ValueChangeEnd += OnValueChanged;
}

private void OnValueChangeStart(object sender, SliderValueChangeStartEventArgs e)
{
}

private void OnValueChanging(object sender, SliderValueChangingEventArgs e)
{
}

private void OnValueChanged(object sender, SliderValueChangedEventArgs e) 
{
}
private void OnValueChangeEnd(object sender, SliderValueChangeEndEventArgs e)
{
}

{% endhighlight %}

{% endtabs %}


## Customize label text

You can format or change the whole numeric or date label text using the [`LabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_LabelCreated) event. The [`SliderLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html) contains the following parameters,

* Text – Customize the text color using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) parameter.
* Style – Formats the text color, font size, font family, offset using the [`Style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) parameter.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="2" 
                  Maximum="10" 
                  Value="6" 
		  Interval="2" 	           
	          LabelCreated="OnLabelCreated" 
		  ShowLabels="True">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

{
   SfSlider slider = new SfSlider();
   slider.Minimum = 2;
   slider.Maximum = 10;
   slider.Value = 6;
   slider.Interval = 2;
   slider.ShowLabels = true;
   sfslider.LabelCreated += OnLabelCreated;
 }

 private void OnLabelCreated(object sender, SliderLabelCreatedEventArgs e)
 {
   e.Text = "$" + e.Text;
 }

{% endhighlight %}

{% endtabs %}

![Slider custom label](images/labels-and-dividers/custom-label.png)


## Tooltip text format

By default it is formatted based on [`NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_NumberFormat)  property and [`DateFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_DateFormat) property based on whether it is date type [`SfSlider`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html) or numeric [`SfSlider`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html).

You can format or change the whole tooltip label text using the [`ToolTipLabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipLabelCreated) event. The [`SliderLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html) contains the following parameters,

* Text – Change the format of the tooltip text using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Text) property.
* Style – Change the appearance of the tooltip text like color, stroke color, and padding using the [`Style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) property.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider ToolTipLabelCreated="OnTooltipLabelCreated" 
                  ToolTipShape="Rectangle">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

{
   SfSlider slider = new SfSlider();
   slider.ToolTipShape = SliderToolTipShape.Rectangle;
   slider.ToolTipLabelCreated += OnTooltipLabelCreated;
}

private void OnTooltipLabelCreated(object sender, SliderLabelCreatedEventArgs e)
{
    e.Text = "$" + e.Text;
}

{% endhighlight %}

{% endtabs %}

![Slider custom tooltip](images/tooltip/custom-tooltip.png)

