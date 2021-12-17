---
layout: post
title: Dividers in .NET MAUI Slider control | Syncfusion
description: Learn here all about the Dividers feature of .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Dividers in .NET MAUI Slider (SfSlider)

This section explains about how to add the dividers in the slider.

## Show dividers

The `ShowDividers` property is used to render the dividers on the track. The default value of the `ShowDividers` property is `False`. It is a shape which is used to represent the major interval points of the track.

For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the slider will render the dividers at 0.0, 2.0, 4.0 and so on.

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

You can change the active and inactive divider radius of the slider using the `ActiveRadius` and the `InactiveRadius` properties of the `DividerStyle` class.

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

You can change the active and inactive divider stroke width of the slider using the `ActiveStrokeWidth` and the `InactiveStrokeWidth` properties of the `DividerStyle` class.

Also, you can change the active and inactive divider stroke color of the slider using the `ActiveStrokeColor` and the `InactiveStrokeColor` properties of the `DividerStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Interval="0.2" 
                  ShowDividers="True">
    <sliders:SfSlider.DividerStyle>
         <sliders:SliderDividerStyle ActiveRadius="7" 
                                     InactiveRadius="7" 
            			     ActiveStrokeWidth="2" 
				     InactiveStrokeWidth="2" 
				     ActiveStrokeColor="#EE3F3F" 
				     InactiveStrokeColor="#F7B1AE"/>
     </sliders:SfSlider.DividerStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Interval = 0.2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;
slider.DividerStyle.ActiveStrokeColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.DividerStyle.InactiveStrokeColor = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
slider.DividerStyle.ActiveStrokeWidth = 2;
slider.DividerStyle.InactiveStrokeWidth = 2;

{% endhighlight %}

{% endtabs %}

![Slider divider stroke color](images/labels-and-dividers/divider-stroke-color.png)

## Divider color

You can change the active and inactive divider color of the slider using the `ActiveColor` and `InactiveColor` properties of the `DividerStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Interval="0.2" 
                  ShowDividers="True">
    <sliders:SfSlider.DividerStyle>
       <sliders:SliderDividerStyle ActiveRadius="7" 
                                   InactiveRadius="7" 
				   ActiveColor="#EE3F3F" 
				   InactiveColor="#F7B1AE"/>
      </sliders:SfSlider.DividerStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Interval = 0.2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;
slider.DividerStyle.ActiveColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.DividerStyle.InactiveColor = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![Slider divider color](images/labels-and-dividers/divider-color.png)
