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

This section explains how to customize the appearance and behavior of the [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) control, including the default selected color, the visibility of UI elements, action button appearance, palette layout, label styles, slider thumb, and popup placement. 

## Selected color

The [SelectedColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectedColor) property is two-way bindable. Bind it to a `Color` property in your view model to react to user selections via the [`ColorChanged`](https://help.syncfusion.com/maui/colorpicker/events#colorchanged-event) event.

The `SelectedColor` property of the Color Picker is used to display a default color during initial load. You can also select a color value in the UI using built-in elements like the color spectrum, sliders, palette, or HEX input.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SelectedColor="DodgerBlue"/>       

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectedColor = Colors.DodgerBlue
};

this.Content = colorPicker;
 
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

this.Content = colorPicker;

{% endhighlight %}

{% endtabs %}

![Recent color](Images/Customization/RecentColors.png)

## Clear recent colors

You can clear all colors shown in the Recent Colors section of the Color Picker by calling the [ClearRecentColors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ClearRecentColors) method. This method removes all previously selected colors and resets the Recent Colors list. Use this method in an event handler such as a button click to let users clear the recent colors history manually.

{% tabs %}

{% highlight c# %}

// Create SfColorPicker
colorPicker = new SfColorPicker()
{
    ShowRecentColors = true
};

// Create Button
clearRecentColorsButton = new Button()
{
    Text = "Clear Recent Colors",
    WidthRequest = 160,
    HeightRequest = 50
};

// Clear all recent colors
clearRecentColorsButton.Clicked += (s,e) => { colorPicker.ClearRecentColors(); } ;

// Create VerticalStackLayout
var stackLayout = new VerticalStackLayout()
{
    Spacing = 10,
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Children = { colorPicker, clearRecentColorsButton }
};
    
this.Content = stackLayout;

{% endhighlight %}

{% endtabs %}

## Show input area

You can show or hide the input area (HEX/RGBA/HSV editors) of the Color Picker by adjusting the [ShowInputArea](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ShowInputArea) property. By default, it is set to `True`. This property is only effective in [HSV](Mode.md) mode.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ShowInputArea="False"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ShowInputArea = false
};

this.Content = colorPicker;
    
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

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

![Alpha slider](Images/Customization/AlphaSlider.png)

## Hide action buttons

You can remove the Apply and Cancel buttons to apply the selected color immediately on selection. To enable this, set the [IsActionButtonsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsActionButtonsVisible) property to `False`. By default, this property is set to `True`.

> **NOTE:** When hosted inside a popup container (for example, as the dropdown content of a [SfComboBox](https://help.syncfusion.com/maui/combobox/getting-started) or in a `SfPopup`), hiding the action buttons causes the popup to close automatically when a color is selected. For the standalone `SfColorPicker` control, the action buttons only affect the in-place Apply/Cancel behavior.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker IsActionButtonsVisible="False"/>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    IsActionButtonsVisible = false
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

![Action buttons](Images/Customization/HideActionButtons.png)

## Customize action buttons

You can customize the background color for the action buttons by specifying a suitable color for the [ApplyButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ApplyButtonBackground) and [CancelButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_CancelButtonBackground) properties. Both properties are of type `Color`; the default value is `White`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ApplyButtonBackground="Navy"
                      CancelButtonBackground="LightGray">
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    ApplyButtonBackground = Colors.Navy,
    CancelButtonBackground = Colors.LightGray
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

![Action buttons customization](Images/Customization/CustomizeActionButtons.png)

You can also customize the text appearance of the action buttons by defining a suitable label style for the [ApplyButtonLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ApplyButtonLabelStyle) and [CancelButtonLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_CancelButtonLabelStyle) properties.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker>
    <inputs:SfColorPicker.ApplyButtonLabelStyle>
        <core:LabelStyle
            FontSize="16"
            TextColor="White"
            FontAttributes="Bold" />
    </inputs:SfColorPicker.ApplyButtonLabelStyle>
    <inputs:SfColorPicker.CancelButtonLabelStyle>
        <core:LabelStyle
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

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

## Customize label styles

### Recent colors label style

You can customize the text appearance of the recent colors label by defining a suitable label style for the [RecentColorsLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_RecentColorsLabelStyle) property. This style applies to the "Recent Colors" text displayed above the recent color palette.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker>
    <inputs:SfColorPicker.RecentColorsLabelStyle>
        <core:LabelStyle
            FontSize="14"
            TextColor="DarkGray"
            FontAttributes="Italic" />
    </inputs:SfColorPicker.RecentColorsLabelStyle>
</inputs:SfColorPicker>

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

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### Spectrum input view label style

You can customize the text appearance of the labels displayed in the spectrum input view by defining a suitable label style for the [SpectrumInputViewLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SpectrumInputViewLabelStyle) property. This style applies to the label texts displayed in the spectrum input view, such as HEX, R, G, B, H, S, V, and A input labels.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker>
    <inputs:SfColorPicker.SpectrumInputViewLabelStyle>
        <core:LabelStyle
            FontSize="14"
            TextColor="Black"
            FontFamily="Arial" />
    </inputs:SfColorPicker.SpectrumInputViewLabelStyle>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker();

// Set spectrum input view label style (HEX, RGBA, HSV labels)
colorPicker.SpectrumInputViewLabelStyle = new LabelStyle
{
    FontSize = 14,
    TextColor = Colors.Black,
    FontFamily = "Arial"
};

this.Content = colorPicker;

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

this.Content = colorPicker;
    
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

this.Content = colorPicker;
    
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

this.Content = colorPicker;

{% endhighlight %}
{% endtabs %}

![Palette row spacing](Images/Customization/PaletteSpacing.png)

## Palette cell customization

### PaletteCellCornerRadius

You can customize the corner radius of individual palette cells by adjusting the [PaletteCellCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteCellCornerRadius) property. The default value is `0` (square corners).

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker PaletteCellCornerRadius="15, 12, 15, 7" />  

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteCellCornerRadius = new CornerRadius(15, 12, 15, 7)
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### PaletteCellShape

You can define the shape of the color palette cells using the [PaletteCellShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteCellShape) property.

- [Circle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.PaletteCellShape.html#Syncfusion_Maui_Inputs_PaletteCellShape_Circle)
- [Square](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.PaletteCellShape.html#Syncfusion_Maui_Inputs_PaletteCellShape_Square)
- [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.PaletteCellShape.html#Syncfusion_Maui_Inputs_PaletteCellShape_Default)

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker PaletteCellShape="Circle" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteCellShape = PaletteCellShape.Circle
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### PaletteCellSize

You can control the width and height (in device-independent pixels) of each color cell in the palette by setting the [PaletteCellSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteCellSize) property. The default value is `24`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker PaletteCellSize="40" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PaletteCellSize = 40
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### PaletteColors

You can define a custom collection of `Color` values displayed in the palette view by using the [PaletteColors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PaletteColors) property. The `PaletteColors` collection is only rendered when [ColorPickerMode](Mode.md) is set to `Palette`.

{% tabs %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker();

// Set custom palette colors
colorPicker.ColorMode = ColorPickerMode.Palette;
colorPicker.PaletteColumnCount = 7;
colorPicker.PaletteRowCount = 3;
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

this.Content = colorPicker;

{% endhighlight %}

{% endtabs %}

> **NOTE:** The number of entries in `PaletteColors` should not exceed `PaletteColumnCount * PaletteRowCount`. Additional colors are ignored.

## Selection indicator customization

### SelectionIndicatorRadius

You can customize the corner radius of the selection indicator by setting the [SelectionIndicatorRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectionIndicatorRadius) property. The default value is `4`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SelectionIndicatorRadius="6" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectionIndicatorRadius = 6
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### SelectionIndicatorStroke

You can specify the stroke color of the selection indicator using the [SelectionIndicatorStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectionIndicatorStroke) property. The default value is `White`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SelectionIndicatorStroke="White" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectionIndicatorStroke = Colors.White
};

this.Content = colorPicker;

{% endhighlight %}

{% endtabs %}

### SelectionIndicatorStrokeThickness

You can modify the thickness of the selection outline by adjusting the [SelectionIndicatorStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectionIndicatorStrokeThickness) property. The default value is `2`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SelectionIndicatorStrokeThickness="2" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectionIndicatorStrokeThickness = 2
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

## Slider thumb customization

The Slider thumb represents the `Hue` and `Alpha` Sliders in the Color Picker. You can customize its appearance using the following properties.

### SliderThumbFill

You can customize the fill brush of the Slider thumb by setting the [SliderThumbFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbFill) property. The property is of type `Brush`; in XAML you can pass a color name (converted to a `SolidColorBrush`) or a `SolidColorBrush` instance in code. The default value is `White`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SliderThumbFill="Blue" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbFill = new SolidColorBrush(Colors.Blue)
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### SliderThumbRadius

You can control the size and roundness of the Slider thumb by adjusting the [SliderThumbRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbRadius) property. The default value is `10`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SliderThumbRadius="12" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbRadius = 12
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### SliderThumbStroke

You can customize the stroke color of the Slider thumb by adjusting the [SliderThumbStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbStroke) property. The default value is `Black`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SliderThumbStroke="Black" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbStroke = Colors.Black
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

### SliderThumbStrokeThickness

You can control the thickness of the Slider thumb's outline by adjusting the [SliderThumbStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SliderThumbStrokeThickness) property. The default value is `1`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker SliderThumbStrokeThickness="3" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SliderThumbStrokeThickness = 3
};

this.Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

## Popup customization

### IsOpen

The [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsOpen) property in the Color Picker control allows you to programmatically open the popup by setting it to `True`. By default, this property is set to `False`. Set `IsOpen = true` after the control has been added to the visual tree (for example, in `OnAppearing` or a user-action handler) to ensure the popup is displayed correctly.

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout Spacing="10" 
                     HorizontalOptions="Center">

    <Label Text="IsOpen Switch"/>
    <Switch IsToggled="{Binding Source={x:Reference colorPicker}, Path=IsOpen, Mode=TwoWay}" />

    <inputs:SfColorPicker x:Name="colorPicker" 
                          IsOpen="False" />

</VerticalStackLayout>

{% endhighlight %}
{% highlight C# %}

// Create the color picker
var colorPicker = new SfColorPicker
{
    IsOpen = false
};

// Create the switch with binding
var switchControl = new Switch();
switchControl.SetBinding(Switch.IsToggledProperty, 
    new Binding 
    { 
        Source = colorPicker, 
        Path = "IsOpen", 
        Mode = BindingMode.TwoWay 
    });

// Create the label
var label = new Label
{
    Text = "IsOpen Switch"
};

// Create the vertical stack layout
var stackLayout = new VerticalStackLayout
{
    Spacing = 10,
    HorizontalOptions = LayoutOptions.Center,
    Children =
    {
        label,
        switchControl,
        colorPicker
    }
};

this.Content = stackLayout;

{% endhighlight %}
{% endtabs %}

### Popup background

The [PopupBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_PopupBackground) property specifies the background color of the popup panel in the Color Picker control. The default value is `White`.

{% tabs %}
{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker" PopupBackground="Thistle"/>

{% endhighlight %}
{% highlight C# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    PopupBackground = Colors.Thistle
};

this.Content = colorPicker;

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
* [AlignToRightOf](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html#Syncfusion_Maui_Popup_PopupRelativePosition_AlignToRightOf)

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

this.Content = colorPicker;

{% endhighlight %}
{% endtabs %}

![Align top](Images/Customization/AlignTop.png)
