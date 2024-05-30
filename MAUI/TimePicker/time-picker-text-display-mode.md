---
layout: post
title: Time Picker Text Dispaly Mode in .NET MAUI Time Picker Control | Syncfusion
description: Learn about the time picker text display mode in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Time Picker Text dispaly mode in .NET MAUI Picker (SfTimePicker)

The time picker text display mode is specified in the time picker property enumeration, which is used to display the time picker items based on the modes. It offers four modes: `Default`, `Fade`, `Shrink` and `FadeAndShrink`. The default time picker text display mode is `Default` in the [SfTimePicker].

## Default Mode

In Default mode, for selected items, the text color is white and the font size is 14, and for unselected items, the text color is black and the font size is 14.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<timePicker:SfTimePicker x:Name="timePicker"
                 TextDisplayMode="Default"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker timePicker = new SfTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Default
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Fade Mode

In Fade mode, the text color will fade from the selected item.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<timePicker:SfTimePicker x:Name="timePicker"
                 TextDisplayMode="Fade"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker timePicker = new SfTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Fade
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Shrink Mode

In Shrink mode, the font size will decrease from the selected item.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<timePicker:SfTimePicker x:Name="timePicker"
                 TextDisplayMode="Shrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker timePicker = new SfTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Shrink
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## FadeAndShrink Mode

In FadeAndShrink mode, the text color will fade, and the text font size will be reduced from the selected item.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<timePicker:SfTimePicker x:Name="timePicker"
                 TextDisplayMode="FadeAndShrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker timePicker = new SfTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.FadeAndShrink
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}
