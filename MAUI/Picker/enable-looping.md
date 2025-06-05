---
layout: post
title: Enable Looping in .NET MAUI Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn about enable looping support in Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Enable Looping in .NET MAUI Picker (SfPicker)

The [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.EnableLooping.html) property allows you to enable looping support in the picker control. With looping enabled, the control seamlessly navigates from the last item to the first item and back again, iterating in both forward and backward directions.

To enable the looping in picker by setting the [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.EnableLooping.html) property as `true`. The default value is `false`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfPicker x:Name="picker"
                 EnableLooping="True"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfPicker picker = new SfPicker()
{
    EnableLooping = True,
};

this.Content = picker;

{% endhighlight %}

{% endtabs %}