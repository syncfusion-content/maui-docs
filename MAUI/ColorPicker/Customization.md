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

## Selected color

The [SelectedColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectedColor) property of the Color Picker is used to display a default color during initial load. You can also select a color value in the UI using built-in elements like the color spectrum, sliders, palette, or HEX input.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SelectedColor="DodgerBlue"/>       

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectedColor = Colors.DodgerBlue
};
 
{% endhighlight %}

{% endtabs %}

![SelectedColor](Images/Mode/SelectedColor.png)

## Show recent colors

You can display the recently selected colors in the Color Picker when in [Palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorPickerMode.html#Syncfusion_Maui_Inputs_ColorPickerMode_Palette) mode by enabling the [ShowRecentColors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ShowRecentColors) property. By default, it is set to `True`.

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

## ClearRecentColors

You can clear all colors shown in the Recent Colors section of the Color Picker by calling the [ClearRecentColors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ClearRecentColors) method. This method removes all previously selected colors and resets the Recent Colors list.

{% tabs %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker();

// Clear all recent colors
colorPicker.ClearRecentColors();

{% endhighlight %}

{% endtabs %}

## Show input area

You can show or hide the input area of the Color Picker by adjusting the [ShowInputArea](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ShowInputArea) property. By default, it is set to `True`.

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

The alpha slider is used to control the transparency of the selected color. You can show or hide the alpha slider by adjusting the [ShowAlphaSlider](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ShowAlphaSlider) property. By default, it is set to `True`.

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

## Action buttons

You can render the Color Picker without the Apply and Cancel buttons for a seamless color selection experience. When the control buttons are hidden, the selected color is applied instantly, and the Color Picker popup closes automatically upon selection. To enable this, simply set the [IsActionButtonsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsActionButtonsVisible) property to `False`.

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

You can customize the background color for the action buttons by specifying a suitable color for the [ApplyButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ApplyButtonBackground) and [CancelButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_CancelButtonBackground) properties.

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

Also you can customize the text appearance of the action buttons by defining a suitable label style for the [ApplyButtonLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ApplyButtonLabelStyle) and [CancelButtonLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_CancelButtonLabelStyle) properties.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker>
    <inputs:SfColorPicker.ApplyButtonLabelStyle>
        <inputs:LabelStyle
            FontSize="16"
            TextColor="White"
            FontAttributes="Bold" />
    </inputs:SfColorPicker.ApplyButtonLabelStyle>
    <inputs:SfColorPicker.CancelButtonLabelStyle>
        <inputs:LabelStyle
            FontSize="14"
            TextColor="Gray"
            FontAttributes="None" />
    </inputs:SfColorPicker.CancelButtonLabelStyle>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker();

// Set Apply button label style
colorPicker.ApplyButtonLabelStyle = new LabelStyle
{
    FontSize = 16,
    TextColor = Colors.White,
    FontAttributes = FontAttributes.Bold
};

// Set Cancel button label style
colorPicker.CancelButtonLabelStyle = new LabelStyle
{
    FontSize = 14,
    TextColor = Colors.Gray,
    FontAttributes = FontAttributes.None
};
    
{% endhighlight %}

{% endtabs %}

## Customize Recent Colors and Spectrum Input View Label Style

You can customize the text appearance of the recent colors label and the labels displayed in the spectrum input view by defining suitable label styles for the [RecentColorsLabelStyle]
(https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_RecentColorsLabelStyle) and [SpectrumInputViewLabelStyle]
(https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SpectrumInputViewLabelStyle) properties.

- `RecentColorsLabelStyle` applies to the “Recent Colors” text displayed above the recent color palette.
- `SpectrumInputViewLabelStyle` applies to the label texts displayed in the spectrum input view, such as HEX, R, G, B, H, S, V, and A modify labels.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker>
    <!-- Recent colors label style -->
    <syncfusion:SfColorPicker.RecentColorsLabelStyle>
        <syncfusion:LabelStyle
            FontSize="14"
            TextColor="DarkGray"
            FontAttributes="Italic" />
    </syncfusion:SfColorPicker.RecentColorsLabelStyle>
    <!-- Spectrum input view label style (HEX, RGBA labels) -->
    <syncfusion:SfColorPicker.SpectrumInputViewLabelStyle>
        <syncfusion:LabelStyle
            FontSize="14"
            TextColor="Black"
            FontFamily="Arial" />
    </syncfusion:SfColorPicker.SpectrumInputViewLabelStyle>
</syncfusion:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker();

// Set recent colors label style
colorPicker.RecentColorsLabelStyle = new LabelStyle
{
    FontSize = 14,
    TextColor = Colors.DarkGray,
    FontAttributes = FontAttributes.Italic
};

// Set spectrum input view label style (HEX, RGBA, HSV labels)
colorPicker.SpectrumInputViewLabelStyle = new LabelStyle
{
    FontSize = 14,
    TextColor = Colors.Black,
    FontFamily = "Arial"
};
    
{% endhighlight %}

{% endtabs %}

## No color option

The [ShowNoColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ShowNoColor) property determines whether the `No Color` option is displayed in the Color Picker UI. This option allows users to clear their selection from the palette, effectively choosing no color. By default, this property is set to `False`.

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

The [PaletteColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteColumnCount) and [PaletteRowCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteRowCount) properties define the number of columns and rows displayed in the palette grid. By default, both are set to 10.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker PaletteColumnCount="6" PaletteRowCount="5"/>    

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteColumnCount = 6,
    PaletteRowCount = 5
};
    
{% endhighlight %}

{% endtabs %}

![Palette row and column](Images/Customization/PaletteCount.png)

## Palette spacing

The [PaletteColumnSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteColumnSpacing) property defines the horizontal spacing between columns, while the [PaletteRowSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteRowSpacing) property defines the vertical spacing between rows in [Palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorPickerMode.html#Syncfusion_Maui_Inputs_ColorPickerMode_Palette) mode. By default, both properties are set to 0, meaning the swatches are placed directly next to each other without any spacing.

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

## Palette cell customization

### PaletteCellCornerRadius

The [PaletteCellCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteCellCornerRadius) specifies the corner radius of individual palette cells, allowing you to create rounded or custom‑shaped cells.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker PaletteCellCornerRadius="15, 12, 15, 7" />  

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteCellCornerRadius = new CornerRadius(15, 12, 15, 7)
};
    
{% endhighlight %}

{% endtabs %}

### PaletteCellShape

The [PaletteCellShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteCellShape) specifies the shape of the palette cells. It supports the following shapes.

- [Circle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.PaletteCellShape.html#Syncfusion_Maui_Inputs_PaletteCellShape_Circle)
- [Square](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.PaletteCellShape.html#Syncfusion_Maui_Inputs_PaletteCellShape_Square)
- [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.PaletteCellShape.html#Syncfusion_Maui_Inputs_PaletteCellShape_Default)

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker PaletteCellShape="Circle" />   

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteCellShape = PaletteCellShape.Circle
};
    
{% endhighlight %}

{% endtabs %}

### PaletteCellSize

The [PaletteCellSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteCellSize) specifies the width and height of each palette cell, allowing you to increase or decrease the overall size of the color palette items.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker PaletteCellSize="40" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteCellSize = 40
};
    
{% endhighlight %}

{% endtabs %}

### PaletteColors

The [PaletteColors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteColors) allows us to define a custom collection of colors to be displayed in the color picker’s palette view.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker>
    <syncfusion:SfColorPicker.PaletteColors>
        <x:Array Type="{x:Type Color}">
            <x:Static Member="Colors.Red" />
            <x:Static Member="Colors.Green" />
            <x:Static Member="Colors.Blue" />
            <x:Static Member="Colors.Yellow" />
        </x:Array>
    </syncfusion:SfColorPicker.PaletteColors>
</syncfusion:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker();

// Set custom palette colors
colorPicker.PaletteColors = new List<Color>
{
    Colors.Red,
    Colors.Green,
    Colors.Blue,
    Colors.Yellow,
    Colors.Purple,
    Colors.Orange
};

// Add a color to the existing palette
colorPicker.PaletteColors.Add(Colors.Pink);
    
{% endhighlight %}

{% endtabs %}

## Selection indicator customization

### SelectionIndicatorRadius

The [SelectionIndicatorRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectionIndicatorRadius) specifies the corner radius of the selection indicator displayed over the selected color in the palette and spectrum views.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SelectionIndicatorRadius="6" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectionIndicatorRadius = 6
};
    
{% endhighlight %}

{% endtabs %}

### SelectionIndicatorStroke

The [SelectionIndicatorStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectionIndicatorStroke) specifies the stroke color of the selection indicator.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SelectionIndicatorStroke="White" />  

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectionIndicatorStroke = Colors.White
};
    
{% endhighlight %}

{% endtabs %}

### SelectionIndicatorStrokeThickness

The [SelectionIndicatorStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectionIndicatorStrokeThickness) specifies the thickness of the selection indicator stroke, allowing us to modify the selection outline.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SelectionIndicatorStrokeThickness="2" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectionIndicatorStrokeThickness = 2
};
    
{% endhighlight %}

{% endtabs %}

## Slider thumb customization

The slider thumb represents the `Hue` and `Alpha` sliders in the color picker. You can customize its appearance using the following properties.

### SliderThumbFill

The [SliderThumbFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbFill) specifies the fill brush for the slider thumb.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SliderThumbFill="Blue" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbFill = new SolidColorBrush(Colors.Blue)
};
    
{% endhighlight %}

{% endtabs %}

### SliderThumbRadius

The [SliderThumbRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbRadius) specifies the radius of the slider thumb.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SliderThumbRadius="12" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbRadius = 12
};
    
{% endhighlight %}

{% endtabs %}

### SliderThumbStroke

The [SliderThumbStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbStroke) specifies the stroke color of the slider thumb.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SliderThumbStroke="Black" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbStroke = Colors.Black
};
    
{% endhighlight %}

{% endtabs %}

### SliderThumbStrokeThickness

The [SliderThumbStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbStrokeThickness) specifies the thickness of the slider thumb stroke.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SliderThumbStrokeThickness="3" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbStrokeThickness = 3
};
    
{% endhighlight %}

{% endtabs %}

## Popup customization

### IsOpen

The [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsOpen) property in the Color Picker control allows you to programmatically open the popup by setting it to `True.` By default, this property is set to `False.`

{% tabs %}
{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker" IsOpen="True"/>

{% endhighlight %}
{% highlight C# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    IsOpen = true
};

{% endhighlight %}
{% endtabs %}

### Popup background

The [PopupBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PopupBackground) property specifies the background color of the popup panel in the Color Picker control.

{% tabs %}
{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker" PopupBackground="Thistle"/>

{% endhighlight %}
{% highlight C# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PopupBackground = Colors.Thistle
};

{% endhighlight %}
{% endtabs %}

![Popup background](Images/Customization/PopupBackground.png)

### Popup relative position

The [PopupRelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PopupRelativePosition) property specifies the placement of the popup in the Color Picker control. It supports the following eight positioning options:

* [AlignBottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignBottom)
* [AlignBottomLeft](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignBottomLeft)
* [AlignBottomRight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignBottomRight)
* [AlignToLeftOf](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignToLeftOf)
* [AlignTop](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignTop)
* [AlignTopLeft](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignTopLeft)
* [AlignTopRight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignTopRight)
* [AlignTopRightOf](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignToRightOf)

The default position is [AlignBottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignBottom).

{% tabs %}
{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker" PopupRelativePosition="AlignTop"/>

{% endhighlight %}
{% highlight C# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PopupRelativePosition = PopupRelativePosition.AlignTop
};

{% endhighlight %}
{% endtabs %}

![Align top](Images/Customization/AlignTop.png)
