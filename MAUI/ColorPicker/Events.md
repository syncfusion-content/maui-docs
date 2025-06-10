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

There are three built-in events in the `SfColorPicker` control, namely:

* ColorChanging
* ColorChanged
* ColorSelected

## ColorChanging event

The `ColorChanging` event activates in real-time as the user drags or modifies the color selector within the picker. This allows you to see the selected color instantly before it is finalized.

 {% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <editors:SfColorPicker x:Name="colorPicker" Grid.Column="0"
                           ColorChanging="ColorPicker_ColorChanging"/>

    <Label x:Name="colorPreviewLabel" Grid.Column="1" Text="Selected Color" 
           FontAttributes="Bold" FontSize="16" HeightRequest="40" WidthRequest="200" 
           HorizontalTextAlignment="Center" VerticalTextAlignment="Center"
           TextColor="Black" BackgroundColor="LightGray"/>

</Grid>

{% endhighlight %}

{% highlight c# %}

private void ColorPicker_ColorChanging(object sender, ColorChangingEventArgs e)
{
    colorPreviewLabel.BackgroundColor = e.NewColor;
    colorPreviewLabel.Text = e.NewColor.ToHex();
}

{% endhighlight %}

{% endtabs %}

## ColorChanged event

The `ColorChanged` event is activated only once, after the user has completed their color selection, such as when they release the selector or finalize the change.

{% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <editors:SfColorPicker x:Name="colorPicker" Grid.Column="0"
                           ColorChanged="ColorPicker_ColorChanged"/>

    <Label x:Name="selectedColor" Grid.Column="1" Text="Selected Color" 
           FontAttributes="Bold" FontSize="16" HeightRequest="40" WidthRequest="200" 
           HorizontalTextAlignment="Center" VerticalTextAlignment="Center"
           TextColor="Black" BackgroundColor="LightGray"/>

</Grid>

{% endhighlight %}

{% highlight c# %}

private void ColorPicker_ColorChanged(object sender, ColorChangedEventArgs e)
{
    selectedColor.BackgroundColor = e.NewColor;
    selectedColor.Text = e.NewColor.ToHex();
}

{% endhighlight %}

{% endtabs %}
