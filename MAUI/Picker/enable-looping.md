---
layout: post
title: Looping support in .NET MAUI Picker Control | Syncfusion®
description: Learn about looping support in Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfPicker) control and its features.
platform: maui
control: SfPicker
documentation: ug
---

# Looping support in .NET MAUI Picker (SfPicker)

The [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property allows you to enable looping support in the picker control. With looping enabled, the control seamlessly navigates from the last item to the first item and back again, iterating in both forward and backward directions.

To enable looping in the picker, set the [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property to `true`. The default value is `false`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker"
                     EnableLooping="True"/>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker()
{
    EnableLooping = true,
};

this.Content = picker;

{% endhighlight %}

{% endtabs %}

![Enable Looping in .NET MAUI picker.](images/enable-looping/maui-picker-enable-looping.gif){:width="330" height="360"}