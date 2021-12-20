---
layout: post
title: Tooltip in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Tooltip in .NET MAUI Slider (SfSlider)

This section helps to learn about how to add tooltip in the slider.

## Enable tooltip

You can enable tooltip for the thumb by setting the `ToolTipShape` property to `SliderToolTipShape.Rectangle`. It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat or dateFormat. The default value of the `ToolTipShape` property is `SliderToolTipShape.None`.

{% tabs %}

{% highlight xaml %}

  <sliders:SfSlider ToolTipShape="Rectangle" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ToolTipShape = SliderToolTipShape.Rectangle;

{% endhighlight %}

{% endtabs %}

![Slider tooltip](images/tooltip/tooltip.png)

## Tooltip text format

By default it is formatted based on `NumberFormat` property and `DateFormat` property based on whether it is date type `SfSlider` or numeric `SfSlider`.

You can format or change the whole tooltip label text using the `ToolTipLabelCreated` event. The `SliderLabelCreatedEventArgs` contains the following parameters,

* Text – Change the format of the tooltip text using the `Text` property.
* Style – Change the appearance of the tooltip text like color, stroke color, and padding using the `Style` property.

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

## Tooltip label style

You can change the appearance of the tooltip text like color, stroke color, padding around the text using the `ToolTipStyle` property.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider ToolTipShape="Rectangle">
   <sliders:SfSlider.ToolTipStyle>
      <sliders:SliderToolTipStyle Color="#F7B1AE" 
                                  StrokeColor="#EE3F3F" 
				  StrokeWidth="2" />
    </sliders:SfSlider.ToolTipStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ToolTipShape = SliderToolTipShape.Rectangle;
slider.ToolTipStyle.Color = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
slider.ToolTipStyle.StrokeColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.ToolTipStyle.StrokeWidth = 2;

{% endhighlight %}

{% endtabs %}

![Slider tooltip style](images/tooltip/tooltip-style.png)
