---
layout: post
title: Dividers in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding and customizing the slider divider feature in .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Dividers in .NET MAUI Slider (SfSlider)

This section explains about how to add the dividers in the slider.

## Show dividers

The [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ShowDividers) property is used to render the dividers on the track. The default value of the [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ShowDividers) property is `False`. It is a shape which is used to represent the major interval points of the track.

For example, if [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Minimum) is 0.0 and [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Minimum) is 10.0 and [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Interval) is 2.0, the slider will render the dividers at 0.0, 2.0, 4.0 and so on.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Interval="0.2" 
                  ShowDividers="True">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Interval = 0.2;
slider.ShowDividers = true;

{% endhighlight %}

{% endtabs %}

![Slider divider](images/labels-and-dividers/divider.png)

## Divider radius

You can change the active and inactive divider radius of the slider using the [`ActiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveRadius) and the [`InactiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveRadius) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Interval="0.2" 
                  ShowDividers="True">
    <sliders:SfSlider.DividerStyle>
         <sliders:SliderDividerStyle ActiveRadius="7" 
                                     InactiveRadius="7" />
    </sliders:SfSlider.DividerStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Interval = 0.2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;

{% endhighlight %}

{% endtabs %}

![Slider divider radius](images/labels-and-dividers/divider-radius.png)

## Divider stroke width and stroke color

You can change the active and inactive divider stroke width of the slider using the [`ActiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStrokeThickness) and the [`InactiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStrokeThickness) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

Also, you can change the active and inactive divider stroke color of the slider using the [`ActiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStroke) and the [`InactiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStroke) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Interval="0.2" 
                  ShowDividers="True">
    <sliders:SfSlider.DividerStyle>
         <sliders:SliderDividerStyle ActiveRadius="7" 
                                     InactiveRadius="7" 
            			     ActiveStrokeThickness="2" 
				     InactiveStrokeThickness="2" 
				     ActiveStroke="#EE3F3F" 
				     InactiveStroke="#F7B1AE"/>
     </sliders:SfSlider.DividerStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Interval = 0.2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;
slider.DividerStyle.ActiveStroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.DividerStyle.InactiveStroke = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
slider.DividerStyle.ActiveStrokeThickness = 2;
slider.DividerStyle.InactiveStrokeThickness = 2;

{% endhighlight %}

{% endtabs %}

![Slider divider stroke color](images/labels-and-dividers/divider-stroke-color.png)

## Divider color

You can change the active and inactive divider color of the slider using the [`ActiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveFill) and [`InactiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveFill) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Interval="0.2" 
                  ShowDividers="True">
    <sliders:SfSlider.DividerStyle>
       <sliders:SliderDividerStyle ActiveRadius="7" 
                                   InactiveRadius="7" 
				   ActiveFill="#EE3F3F" 
				   InactiveFill="#F7B1AE"/>
      </sliders:SfSlider.DividerStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Interval = 0.2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;
slider.DividerStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.DividerStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![Slider divider color](images/labels-and-dividers/divider-color.png)
