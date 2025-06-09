---
layout: post
title: Customization in .NET MAUI Color Picker | Syncfusion®
description: This section explains how to customize the Syncfusion® .NET MAUI Color Picker control (SfColorPicker).
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, .net maui color picker control, maui color picker control, .net maui color picker customization, maui color picker customization
---

# Customization in .NET MAUI Color Picker (SfColorPicker)

## Show recent colors

You can display the recently selected colors in the Color Picker when in `Palette` mode by enabling the `ShowRecentColors` property. By default, it is set to `True`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ShowRecentColors="True"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ShowRecentColors = true
};

{% endhighlight %}

{% endtabs %}

![Recent color](Images/Customization/RecentColors.png)

## Show input area

You can show or hide the input area of the Color Picker by adjusting the `ShowInputArea` property. By default, it is set to `True`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ShowInputArea="False"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ShowInputArea = false
};
    
{% endhighlight %}

{% endtabs %}

![Input area](Images/Customization/InputArea.png)

## Alpha slider

The alpha slider is used to control the transparency of the selected color. You can show or hide the alpha slider by adjusting the `ShowAlphaSlider` property. By default, it is set to `True`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ShowAlphaSlider="True"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ShowAlphaSlider = true
};
    
{% endhighlight %}

{% endtabs %}

![Alpha slider](Images/Customization/AlphaSlider.png)

## Switch color mode

To display the Color Picker in a single mode without allowing users to switch between different modes, set the `ColorMode` property to `Palette` (or Spectrum), and disable the mode switcher UI by setting the `IsColorModeSwitcherVisible` property to `False`. By default, `IsColorModeSwitcherVisible` is set to `True`, allowing users to toggle between modes.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ColorMode="Palette" IsColorModeSwitcherVisible="False"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ColorMode = ColorPickerMode.Palette,
    IsColorModeSwitcherVisible = false
};
    
{% endhighlight %}

{% endtabs %}

![Color mode](Images/Customization/HideSwitchColor.png)

## Action buttons

You can render the Color Picker without the Apply and Cancel buttons for a seamless color selection experience. When the control buttons are hidden, the selected color is applied instantly, and the Color Picker popup closes automatically upon selection. To enable this, simply set the `IsActionButtonsVisible` property to `False`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker IsActionButtonsVisible="False"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    IsActionButtonsVisible = false
};
    
{% endhighlight %}

{% endtabs %}

![Action buttons](Images/Customization/HideActionButtons.png)

## Customize action buttons

You can customize the backgroun color for the action buttons by specifying a suitable color for the `ApplyButtonBackground` and `CancelButtonBackground` properties.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ApplyButtonBackground="Navy"
                      CancelButtonBackground="LightGrey">
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ApplyButtonBackground = Colors.Navy,
    CancelButtonBackground = Colors.LightGrey
};
    
{% endhighlight %}

{% endtabs %}

![Action buttons customization](Images/Customization/CustomizeActionButtons.png)

## No color option

The `ShowNoColor` property determines whether the `No Color` option is displayed in the Color Picker UI. This option allows users to clear their selection from the palette, effectively choosing no color. By default, this property is set to `False`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ShowNoColor="True"/>    

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ShowNoColor = true
};
    
{% endhighlight %}

{% endtabs %}

![No color](Images/Customization/NoColor.png)

## Palette count

The `PaletteColumnCount` and `PaletteRowCount` properties define the number of columns and rows displayed in the palette grid. By default, both are set to 10.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker PaletteColumnCount="4" PaletteRowCount="5"/>    

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteColumnCount = 4,
    PaletteRowCount = 5
};
    
{% endhighlight %}

{% endtabs %}

![Palette row and column](Images/Customization/PaletteCount.png)

## Palette spacing

The `PaletteColumnSpacing` property defines the horizontal spacing between columns, while the `PaletteRowSpacing` property defines the vertical spacing between rows in `Palette` mode. By default, both properties are set to 0, meaning the swatches are placed directly next to each other without any spacing.

{% tabs %}
{% highlight xaml %}

<inputs:SfColorPicker PaletteColumnSpacing="10"
                      PaletteRowSpacing="10"/>

{% endhighlight %}
{% highlight C# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteColumnSpacing = 10,
    PaletteRowSpacing = 10
};

{% endhighlight %}
{% endtabs %}

![Palette row spacing](Images/Customization/PaletteSpacing.png)