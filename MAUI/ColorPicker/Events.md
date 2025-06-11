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

The `SfColorPicker` control provides three built-in events to handle color selection changes:

* ColorChanging
* ColorChanged
* ColorSelected

## ColorChanging event

The `ColorChanging` event allows you to intercept and cancel a color selection before it is applied.

 {% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <inputs:SfColorPicker x:Name="colorPicker" Grid.Column="0"
                           ColorChanging="OnColorChanging"/>

</Grid>

{% endhighlight %}

{% highlight c# %}

private void ColorPicker_ColorChanging(object sender, ColorChangingEventArgs e)
{
    // To cancel the color picker change.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## ColorChanged event

The `ColorChanged` event is triggered when the user has completed their color selection.

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

The `ColorSelected` event is triggered when the user selects a color by clicking or tapping on a predefined color or palette cell.

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