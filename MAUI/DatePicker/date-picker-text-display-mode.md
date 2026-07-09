---
layout: post
title: Text Display Mode in .NET MAUI Date Picker Control | Syncfusion
description: Learn about the date picker text display mode in Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Picker Text display mode in .NET MAUI Date Picker (SfDatePicker)

Use the text display mode to control how the date picker items appear. It offers four modes: [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_Default), [Fade](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_Fade), [Shrink](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_Shrink), and [FadeAndShrink](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_FadeAndShrink). The default text display mode is [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_Default) in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

## Fade Mode

The fade mode in the date picker gradually decreases the visibility of unselected items relative to the selected item. This effect is achieved by setting the [TextDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextDisplayMode) property to [Fade](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_Fade) in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<datePicker:SfDatePicker x:Name="datePicker"
                 TextDisplayMode="Fade"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Fade
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Fade mode in .NET MAUI Date picker.](images/text-display-mode/date-picker-fade.png)

## Shrink Mode

The shrink mode reduces the font size of date picker items relative to the selected item by setting the [TextDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextDisplayMode) property to [Shrink](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_Shrink) in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<datePicker:SfDatePicker x:Name="datePicker"
                 TextDisplayMode="Shrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Shrink
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Shrink mode in .NET MAUI Date picker.](images/text-display-mode/date-picker-shrink.png)

## Fade and Shrink Mode

The fade and shrink mode decreases both the opacity and font size of date picker items relative to the selected item by setting the [TextDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextDisplayMode) property to [FadeAndShrink](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html#Syncfusion_Maui_Picker_PickerTextDisplayMode_FadeAndShrink) in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<datePicker:SfDatePicker x:Name="datePicker"
                 TextDisplayMode="FadeAndShrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    TextDisplayMode = PickerTextDisplayMode.FadeAndShrink
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Fade and Shrink mode in .NET MAUI Date Picker.](images/text-display-mode/date-picker-fade-shrink.png)
