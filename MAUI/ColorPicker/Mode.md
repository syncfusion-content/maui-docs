---
layout: post
title: Mode and Value Support in .NET MAUI Color Picker Control | Syncfusion®
description: Learn all about mode and value support in the Syncfusion® .NET MAUI Color Picker (SfColorPicker) control and more.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, .net maui color picker control, maui color picker control
---

# Mode and Value in .NET MAUI Color Picker (SfColorPicker)

## Rendering palette at initial load

The [ColorMode]() property determines the interface used to select a color. To display the palette area when the Color Picker pop-up is opened, set the [ColorMode]() property to `Palette`. By default, it is configured as `Spectrum`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ColorMode="Palette"/>          

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ColorMode = ColorPickerMode.Palette
};

{% endhighlight %}

{% endtabs %}

## Default color

The [SelectedColor]() property of the Color Picker is used to display a default color during initial load. You can also select a color value in the UI using built-in elements like the color spectrum, sliders, palette, or HEX input.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SelectedColor="DodgerBlue"/>       

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectedColor = Colors.DodgerBlue
};
 
{% endhighlight %}

{% endtabs %}
