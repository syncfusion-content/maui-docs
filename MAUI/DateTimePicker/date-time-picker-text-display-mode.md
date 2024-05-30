---
layout: post
title: Text Dispaly Mode in .NET MAUI Date Time Picker Control | Syncfusion
description: Learn about the date time picker text display mode in Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Text display mode in .NET MAUI Picker (SfDateTimePicker)

The date time picker text display mode is specified in the date time picker property enumeration, which is used to display the date time picker items based on the modes. It offers four modes: `Default`, `Fade`, `Shrink` and `FadeAndShrink`. The default date time picker text display mode is `Default` in the [SfDateTimePicker].

## Default Mode

In Default mode, for selected items, the text color is white and the font size is 14, and for unselected items, the text color is black and the font size is 14.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<dateTimePicker:SfDateTimePicker x:Name="dateTimePicker"
                 TextDisplayMode="Default"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDateTimePicker dateTimePicker = new SfDateTimePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Default
};

this.Content = dateTimePicker;

{% endhighlight %}

{% endtabs %}

## Fade Mode

In Fade mode, the text color will fade from the selected item.

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

## Shrink Mode

In Shrink mode, the font size will decrease from the selected item.

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

## FadeAndShrink Mode

In FadeAndShrink mode, the text color will fade, and the text font size will be reduced from the selected item.

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
