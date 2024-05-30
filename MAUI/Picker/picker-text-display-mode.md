---
layout: post
title: Picker Text Dispaly Mode in .NET MAUI Picker Control | Syncfusion
description: Learn about the picker text display mode in Syncfusion .NET MAUI Picker (SfPicker) control and its basic features.
platform: maui
control: SfPicker
documentation: ug
---

# Picker Text display mode in .NET MAUI Picker (SfPicker)

The picker text display mode is specified in the picker property enumeration, which is used to display the picker items based on the modes. It offers four modes: `Default`, `Fade`, `Shrink` and `FadeAndShrink`. The default picker text display mode is `Default` in the [SfPicker].

## Default Mode

In Default mode, for selected items, the text color is white and the font size is 14, and for unselected items, the text color is black and the font size is 14.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfPicker x:Name="Picker"
                 TextDisplayMode="Default"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfPicker picker = new SfPicker()
{
    TextDisplayMode = PickerTextDisplayMode.Default
};

this.Content = picker;

{% endhighlight %}

{% endtabs %}

## Fade Mode

In Fade mode, the text color will fade from the selected item.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfPicker x:Name="Picker"
                 TextDisplayMode="Fade"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfPicker picker = new SfPicker()
{
    TextDisplayMode = PickerTextDisplayMode.Fade
};

this.Content = picker;

{% endhighlight %}

{% endtabs %}

## Shrink Mode

In Shrink mode, the font size will decrease from the selected item.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfPicker x:Name="Picker"
                 TextDisplayMode="Shrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfPicker picker = new SfPicker()
{
    TextDisplayMode = PickerTextDisplayMode.Shrink
};

this.Content = picker;

{% endhighlight %}

{% endtabs %}

## FadeAndShrink Mode

In FadeAndShrink mode, the text color will fade, and the text font size will be reduced from the selected item.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfPicker x:Name="Picker"
                 TextDisplayMode="FadeAndShrink"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfPicker picker = new SfPicker()
{
    TextDisplayMode = PickerTextDisplayMode.FadeAndShrink
};

this.Content = picker;

{% endhighlight %}

{% endtabs %}
