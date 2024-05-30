---
layout: post
title: Text Dispaly Mode in .NET MAUI Date Picker Control | Syncfusion
description: Learn about the date picker text display mode in Syncfusion .NET MAUI Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Picker Text display mode in .NET MAUI Date Picker (SfDatePicker)

The date picker text display mode is specified in the date picker property enumeration, which is used to display the date picker items based on the modes. It offers four modes: `Default`, `Fade`, `Shrink` and `FadeAndShrink`. The default date picker text display mode is `Default` in the [SfDatePicker].

## Default Mode

In Default mode, for selected items, the text color is white and the font size is 14, and for unselected items, the text color is black and the font size is 14.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<datePicker:SfDatePicker x:Name="datePicker"
                 TextDisplayMode="Default"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    TextDisplayMode = PickerTextDisplayMode.Default
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

## Fade Mode

In Fade mode, the text color will fade from the selected item.

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

## Shrink Mode

In Shrink mode, the font size will decrease from the selected item.

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

## FadeAndShrink Mode

In FadeAndShrink mode, the text color will fade, and the text font size will be reduced from the selected item.

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
