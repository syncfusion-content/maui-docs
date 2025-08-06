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

To display the Color Picker in palette mode, I set its [ColorMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorMode) property to [Palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorPickerMode.html#Syncfusion_Maui_Inputs_ColorPickerMode_Palette). By default, it is configured as [Spectrum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorPickerMode.html#Syncfusion_Maui_Inputs_ColorPickerMode_Spectrum).

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

![Palette](Images/Mode/Palette.png)

## Switch color mode visibility

Disable the mode switcher UI by setting the [IsColorModeSwitcherVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsColorModeSwitcherVisible) property to `False`. By default, it is set to `True`, which allows users to switch between different color modes.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ColorMode="Palette" IsColorModeSwitcherVisible="False"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ColorMode = ColorPickerMode.Palette,
    IsColorModeSwitcherVisible = false
};
    
{% endhighlight %}

{% endtabs %}

![Color mode](Images/Customization/HideSwitchColorMode.png)