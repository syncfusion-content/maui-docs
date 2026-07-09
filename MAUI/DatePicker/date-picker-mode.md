---
layout: post
title: Date Picker Mode in .NET MAUI Date Picker Control | Syncfusion
description: Learn about the date picker mode in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Picker mode in .NET MAUI Date Picker (SfDatePicker)

The `Mode` property specifies how the date picker is displayed. It supports the following values of the [`PickerMode`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html) enum. The default value is `Default`.

| Mode | Description | Default value |
|------|-------------|---------------|
| `Default` | Embeds the picker directly in the page layout. | Yes |
| `Dialog` | Displays the picker in a pop-up. | No |
| `RelativeDialog` | Displays the picker in a pop-up aligned to a target view. Supported on iOS, Android, and Windows. | No |

## Default mode

In the default mode, the date picker is embedded directly in the page layout and is always visible. No additional configuration is required.

```xaml
<picker:SfDatePicker x:Name="datePicker" />
```

## Dialog mode

Displays the date picker in a pop-up. Set the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`Dialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_Dialog).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="datePicker"
                         Mode="Dialog"/>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="2" %}

using Syncfusion.Maui.Picker;

SfDatePicker datePicker = new SfDatePicker()
{
    Mode = PickerMode.Dialog
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

Open the dialog programmatically by setting the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true`. The default value is `false`.

N> The `IsOpen` property is automatically reset to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <Grid>
        <picker:SfDatePicker x:Name="datePicker"
                             Mode="Dialog"/>
        <Button Text="Open Picker"
                x:Name="pickerButton"
                Clicked="Button_Clicked"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                HeightRequest="50"
                WidthRequest="150"/>
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.datePicker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

  ![Dialog mode in .NET MAUI Date picker.](images/date-picker-mode/maui-date-picker-dialog-mode.gif)

## Relative dialog mode

Displays the date picker in a pop-up aligned to a target view. Set the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`RelativeDialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog) and use the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property to choose the alignment.

N> `RelativeDialog` mode is supported on iOS, Android, and Windows.

### Relative position

The [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property aligns the picker relative to the target view. The default value is `AlignTop`. The following table lists the supported values.

| Value | Description |
|-------|-------------|
| `AlignTop` | Places the picker above the target view. |
| `AlignTopLeft` | Places the picker above and to the left of the target view. |
| `AlignTopRight` | Places the picker above and to the right of the target view. |
| `AlignBottom` | Places the picker below the target view. |
| `AlignBottomLeft` | Places the picker below and to the left of the target view. |
| `AlignBottomRight` | Places the picker below and to the right of the target view. |
| `AlignToLeftOf` | Places the picker to the left of the target view. |
| `AlignToRightOf` | Places the picker to the right of the target view. |

N> The `IsOpen` property is automatically reset to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <Grid>
        <picker:SfDatePicker x:Name="datePicker"
                             Mode="RelativeDialog"
                             RelativePosition="AlignTopLeft"/>
        <Button Text="Open picker"
                x:Name="pickerButton"
                Clicked="Button_Clicked"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                HeightRequest="50"
                WidthRequest="150"/>
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.datePicker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

### Relative view

The [RelativeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativeView) property specifies the view that the picker is positioned relative to. The default value is `null`, in which case the picker base is used as the default relative view.

N> `RelativeView` is only applicable in `RelativeDialog` mode.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="6" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <Grid>
        <picker:SfDatePicker x:Name="datePicker"
                             Mode="RelativeDialog"
                             RelativePosition="AlignTopLeft"
                             RelativeView="{x:Reference pickerButton}"/>
        <Button Text="Open picker"
                x:Name="pickerButton"
                Clicked="Button_Clicked"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                HeightRequest="50"
                WidthRequest="150"/>
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.datePicker.IsOpen = true;
    this.datePicker.RelativeView = this.pickerButton;
}

{% endhighlight %}

{% endtabs %}

   ![Relative dialog mode in .NET MAUI Date picker.](images/date-picker-mode/maui-date-picker-relative-dialog-mode1.png)

   ![Relative dialog mode in .NET MAUI Date picker.](images/date-picker-mode/maui-date-picker-relative-dialog-mode2.png)

### Custom popup size

Render the pop-up at a custom size by setting the [PopupWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupWidth) and [PopupHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupHeight) properties. Both properties are of type `double` (in device-independent units) and apply to both `Dialog` and `RelativeDialog` modes.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="datePicker"
                         Mode="Dialog"
                         PopupWidth="300"
                         PopupHeight="400"/>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

this.datePicker.PopupWidth = 300;
this.datePicker.PopupHeight = 400;

{% endhighlight %}

{% endtabs %}

## See also

- [Selection in .NET MAUI Date Picker](selection.md)
- [Formatting in .NET MAUI Date Picker](formatting.md)
- [Events in .NET MAUI Date Picker](events.md)
- [Customizations in .NET MAUI Date Picker](customizations.md)
