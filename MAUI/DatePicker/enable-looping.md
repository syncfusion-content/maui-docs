---
layout: post
title: Looping support in .NET MAUI Date Picker Control | Syncfusion®
description: Learn about looping support in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control.
platform: maui
control: SfDatePicker
documentation: ug
---

# Looping support in .NET MAUI Date Picker (SfDatePicker)

The [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property allows you to enable looping support in the date picker control. With looping enabled, the control seamlessly navigates from the last item to the first item and back again, iterating in both forward and backward directions.

Enable looping by setting the [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property to `true`. The default value is `false`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
             . . .
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="datepicker"
                         EnableLooping="True"/>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="6" %}

using Syncfusion.Maui.Picker;

. . .
SfDatePicker datePicker = new SfDatePicker()
{
    EnableLooping = true
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Enable Looping in .NET MAUI Date Picker.](images/enable-looping/date-picker-enable-looping.gif){:width="330" height="360"}