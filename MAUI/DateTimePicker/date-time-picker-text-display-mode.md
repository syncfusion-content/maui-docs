---
layout: post
title: Text Dispaly Mode in .NET MAUI Date Time Picker Control | Syncfusion
description: Learn about the date time picker text display mode in Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Text display mode in .NET MAUI Picker (SfDateTimePicker)

The date time picker text display mode is specified in the date time picker property enumeration, which is used to display the date time picker items based on the modes. It offers four modes: `Default`, `Fade`, `Shrink` and `FadeAndShrink`. The default date time picker text display mode is `Default` in the `SfDateTimePicker`.

## Fade Mode

The fade mode in the date time picker gradually decreases the visibility of unselected items relative to the selected item. This effect is achieved by setting the `TextDisplayMode` property to `Fade` in `SfDateTimePicker`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<dateTimePicker:SfDateTimePicker x:Name="dateTimePicker"
                 TextDisplayMode="Fade"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDateTimePicker dateTimePicker = new SfDateTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Fade
};

this.Content = dateTimePicker;

{% endhighlight %}

{% endtabs %}

![Fade mode in .NET MAUI Date Time picker.](images/text-display-mode/fade-mode.png)

## Shrink Mode

The shrink mode is used to display the font size of date time picker items decreased from the selected item by setting the `TextDisplayMode` property to `Shrink` in `SfDateTimePicker`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<dateTimePicker:SfDateTimePicker x:Name="dateTimePicker"
                 TextDisplayMode="Shrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDateTimePicker dateTimePicker = new SfDateTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Shrink
};

this.Content = dateTimePicker;

{% endhighlight %}

{% endtabs %}

![Shrink mode in .NET MAUI Date Time picker.](images/text-display-mode/shrink-mode.png)

## FadeAndShrink Mode

The fade and shrink mode are used to decrease the opacity and font size of date time picker items from the selected item by setting the `TextDisplayMode` property to `FadeAndShrink` in `SfDateTimePicker`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<dateTimePicker:SfDateTimePicker x:Name="dateTimePicker"
                 TextDisplayMode="FadeAndShrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDateTimePicker dateTimePicker = new SfDateTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.FadeAndShrink
};

this.Content = dateTimePicker;

{% endhighlight %}

{% endtabs %}

![Fade and Shrink mode in .NET MAUI Date Time picker.](images/text-display-mode/fade-shrink-mode.png)
