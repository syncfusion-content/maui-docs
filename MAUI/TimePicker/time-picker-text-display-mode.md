---
layout: post
title: Text Dispaly Mode in .NET MAUI Time Picker Control | Syncfusion
description: Learn about the time picker text display mode in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Time Picker Text display mode in .NET MAUI Picker (SfTimePicker)

The time picker text display mode is specified in the time picker property enumeration, which is used to display the time picker items based on the modes. It offers four modes: `Default`, `Fade`, `Shrink` and `FadeAndShrink`. The default time picker text display mode is `Default` in the `SfTimePicker`.

## Fade Mode

The fade mode in the time picker gradually decreases the visibility of unselected items relative to the selected item. This effect is achieved by setting the `TextDisplayMode` property to `Fade` in `SfTimePicker`.

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

![Fade Mode in .NET MAUI Time Picker.](images/text-display-mode/time-picker-fade-mode.png)

## Shrink Mode

The shrink mode is used to display the font size of time picker items decreased from the selected item by setting the `TextDisplayMode` property to `Shrink` in `SfTimePicker`.

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

![Shrink Mode in .NET MAUI Time Picker.](images/text-display-mode/time-picker-shrink-mode.png)

## FadeAndShrink Mode

The fade and shrink mode are used to decrease the opacity and font size of time picker items from the selected item by setting the `TextDisplayMode` property to `FadeAndShrink` in `SfTimePicker`.

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

![Fade and Shrink Mode in .NET MAUI Time Picker.](images/text-display-mode/time-picker-fade-shrink-mode.png)
