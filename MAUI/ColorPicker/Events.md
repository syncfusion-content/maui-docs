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

The `ColorChanging` event is triggered in real-time as the user interacts with the color selector. It allows you to preview color changes immediately while the user is still dragging or adjusting the color.

 {% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <inputs:SfColorPicker x:Name="colorPicker" Grid.Column="0"
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

The `ColorChanged` event is triggered only once, after the user has completed their color selection.

{% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <inputs:SfColorPicker x:Name="colorPicker" Grid.Column="0"
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

## ColorSelected event

The `ColorSelected` event is triggered when the user confirms a color selection, typically by clicking or tapping a predefined color or palette cell.

{% tabs %}

{% highlight xaml %}

<Grid ColumnDefinitions="*,Auto">
    
    <inputs:SfColorPicker x:Name="colorPicker" Grid.Column="0"
                           ColorSelected="ColorPicker_ColorSelected"/>

    <Label x:Name="selectedColor" Grid.Column="1" Text="Selected Color" 
           FontAttributes="Bold" FontSize="16" HeightRequest="40" WidthRequest="200" 
           HorizontalTextAlignment="Center" VerticalTextAlignment="Center"
           TextColor="Black" BackgroundColor="LightGray"/>

</Grid>

{% endhighlight %}

{% highlight c# %}

private void ColorPicker_ColorSelected(object sender, ColorSelectedEventArgs e)
{
    selectedColor.BackgroundColor = e.SelectedColor;
    selectedColor.Text = e.SelectedColor.ToHex();
}

{% endhighlight %}

{% endtabs %}