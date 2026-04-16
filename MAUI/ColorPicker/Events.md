---
layout: post
title: Events in .NET MAUI Color Picker Control | Syncfusion®
description: Learn about event support in the Syncfusion® .NET MAUI Color Picker (SfColorPicker) control, its elements, and more.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, .net maui color picker control, maui color picker control, color palette, spectrum, palette.
---

# Events in .NET MAUI Color Picker (SfColorPicker)

The [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) control provides three built-in events to handle color selection changes:

* [ColorChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorChanging)
* [ColorChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorChanged)
* [ColorSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorSelected)

## ColorChanging event

The [ColorChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorChanging) event is triggered while the color is being changed. The event arguments are of type [ColorChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangingEventArgs.html) and provide the following properties:

* [CurrentColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangingEventArgs.html#Syncfusion_Maui_Inputs_ColorChangingEventArgs_CurrentColor) : Gets the current color value before the change.
* [NewColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangingEventArgs.html#Syncfusion_Maui_Inputs_ColorChangingEventArgs_NewColor) : Gets the newly selected color.
* `Cancel:` Determines whether the color selection should be canceled.

 {% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker" ColorChanging="OnColorChanging"/>

{% endhighlight %}

{% highlight c# %}

private void OnColorChanging(object sender, ColorChangingEventArgs e)
{
    // To cancel the color picker change.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## ColorChanged event

The [ColorChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorChanged) event is triggered when the user selects a color. Its behavior depends on the [IsActionButtonsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsActionButtonsVisible) property:

* If [IsActionButtonsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsActionButtonsVisible) is set to false, the event is triggered immediately while selecting a color.
* If [IsActionButtonsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsActionButtonsVisible) is set to true, the event is triggered only when the selected color is applied.

The event arguments are of type [ColorChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangedEventArgs.html) and include the following properties:

* [OldColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangedEventArgs.html#Syncfusion_Maui_Inputs_ColorChangedEventArgs_OldColor) : The previously selected color.
* [NewColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangedEventArgs.html#Syncfusion_Maui_Inputs_ColorChangedEventArgs_NewColor) : The newly selected color.

{% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <inputs:SfColorPicker x:Name="colorPicker" Grid.Column="0"
                           ColorChanged="OnColorChanged"/>

    <Label x:Name="label" Grid.Column="1" Text="Selected Color" 
           HorizontalTextAlignment="Center" VerticalTextAlignment="Center"
           TextColor="Black" BackgroundColor="LightGray"/>

</Grid>

{% endhighlight %}

{% highlight c# %}

private void OnColorChanged(object sender, ColorChangedEventArgs e)
{
    label.BackgroundColor = e.NewColor;
    label.Text = e.NewColor.ToHex();
}

{% endhighlight %}

{% endtabs %}

## ColorSelected event

The [ColorSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorSelected) event is triggered when the user selects a color by clicking or tapping on the selected color view. The event arguments are of type [ColorSelectedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorSelectedEventArgs.html) and include the following property:

* [SelectedColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorSelectedEventArgs.html#Syncfusion_Maui_Inputs_ColorSelectedEventArgs_SelectedColor) : The color currently selected by the user.

{% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <inputs:SfColorPicker x:Name="colorPicker" Grid.Column="0"
                           ColorSelected="OnColorSelected"/>

    <Label x:Name="label" Grid.Column="1" Text="Selected Color"  
           HorizontalTextAlignment="Center" VerticalTextAlignment="Center"
           TextColor="Black" BackgroundColor="LightGray"/>

</Grid>

{% endhighlight %}

{% highlight c# %}

private void OnColorSelected(object sender, ColorSelectedEventArgs e)
{
    label.BackgroundColor = e.SelectedColor;
    label.Text = e.SelectedColor.ToHex();
}

{% endhighlight %}

{% endtabs %}
