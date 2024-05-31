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

In Default mode, the text color and font size for selected items are white and 14 respectively, while for unselected items they are black and 14.

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

The fade mode in the time picker gradually decreases the visibility of unselected items relative to the selected item. This effect is achieved by setting the `TextDisplayMode` property to `Fade` in `SfPicker`.

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

The shrink mode is used to display the font size of time picker items decreased from the selected item by setting the `TextDisplayMode` property to `Shrink` in `SfPicker`.

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

The fade and shrink mode are used to decrease the opacity and font size of time picker items from the selected item by setting the `TextDisplayMode` property to `FadeAndShrink` in `SfPicker`.

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
