---
layout: post
title: Events in .NET MAUI Color Picker Control | Syncfusion®
description: Learn about event support in the Syncfusion® .NET MAUI Color Picker (SfColorPicker) control, its elements, and more.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, .net maui color picker control, maui color picker control, color palette, spectrum, palette.
---

# Events and Commands in .NET MAUI Color Picker

The [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) control provides three events and one command that let you respond to color selection changes from XAML, code-behind, or a view model:

* [ColorChanging](#colorchanging-event) — raised while the color is being changed (cancellable).
* [ColorChanged](#colorchanged-event) — raised when the user commits a color.
* [ColorSelected](#colorselected-event) — raised when the user clicks/taps the selected-color display area.
* [ColorChangedCommand](#commands) — `ICommand` invoked when `SelectedColor` changes.

## ColorChanging event

The [ColorChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorChanging) event is raised continuously while the user is changing the color. The event arguments are of type [ColorChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangingEventArgs.html):

| Property | Type | Default | Description |
| --- | --- | --- | --- |
| [CurrentColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangingEventArgs.html#Syncfusion_Maui_Inputs_ColorChangingEventArgs_CurrentColor) | `Color` | — | The color value before the change. |
| [NewColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangingEventArgs.html#Syncfusion_Maui_Inputs_ColorChangingEventArgs_NewColor) | `Color` | — | The newly selected color. |
| `Cancel` | `bool` | `false` | Set to `true` to veto the change and keep `CurrentColor`. |

### Cancel a color change

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker" ColorChanging="OnColorChanging"/>

{% endhighlight %}

{% highlight c# %}

private void OnColorChanging(object sender, ColorChangingEventArgs e)
{
    // Veto the new selection and keep the current color.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## ColorChanged event

The [ColorChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorChanged) event is raised when the user commits a color. Its exact timing depends on the [IsActionButtonsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_IsActionButtonsVisible) property:

* When `IsActionButtonsVisible` is `false`, the event is raised immediately while the user selects a color.
* When `IsActionButtonsVisible` is `true`, the event is raised only after the user clicks **OK** (the picker shows OK/Cancel action buttons).

The event arguments are of type [ColorChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangedEventArgs.html):

| Property | Type | Description |
| --- | --- | --- |
| [OldColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangedEventArgs.html#Syncfusion_Maui_Inputs_ColorChangedEventArgs_OldColor) | `Color` | The previously selected color. |
| [NewColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorChangedEventArgs.html#Syncfusion_Maui_Inputs_ColorChangedEventArgs_NewColor) | `Color` | The newly selected color. |

### Wire up a code-behind handler

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

The [ColorSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorSelected) event is raised when the user clicks or taps the selected-color display area in the header. The event arguments are of type [ColorSelectedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorSelectedEventArgs.html):

| Property | Type | Description |
| --- | --- | --- |
| [SelectedColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ColorSelectedEventArgs.html#Syncfusion_Maui_Inputs_ColorSelectedEventArgs_SelectedColor) | `Color` | The color currently selected by the user. |

### Wire up a code-behind handler

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

## Commands

The [ColorChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_ColorChangedCommand) is an `ICommand` that is invoked when the `SelectedColor` property of the color picker changes. The command parameter is the new `Color`.

N> Only `ColorChangedCommand` is exposed by the color picker. `ColorChanging` and `ColorSelected` are available only as events.

### Assign a command in code

Use this approach when the color picker lives in a page that has no view model.

{% tabs %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker();

// Run an inline command when the color changes.
colorPicker.ColorChangedCommand = new Command<Color>(color =>
{
    // Perform actions based on the selected color, e.g., update other UI.
    System.Diagnostics.Debug.WriteLine($"Selected: {color.ToHex()}");
});

Content = colorPicker;

{% endhighlight %}

{% endtabs %}

### Bind a command from a view model

Use this approach to keep your page free of UI logic. The bound command property on the view model must expose `ICommand`.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker ColorChangedCommand="{Binding ColorChangedCommand}">
    <inputs:SfColorPicker.BindingContext>
        <local:ColorPickerViewModel/>
    </inputs:SfColorPicker.BindingContext>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# tabtitle="ViewModel" %}

// View model
public class ColorPickerViewModel
{
    public ICommand ColorChangedCommand { get; }

    public ColorPickerViewModel()
    {
        // The command receives the new Color as its parameter.
        ColorChangedCommand = new Command<Color>(color =>
        {
            // Apply business logic, save the value, etc.
        });
    }
}

{% endhighlight %}

{% endtabs %}