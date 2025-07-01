---
layout: post
title: Time Picker Modes in .NET MAUI Time Picker Control | Syncfusion®
description: Learn about the time picker modes in Syncfusion<sup>&reg;</sup> Time Picker for .NET MAUI (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Time Picker mode in .NET MAUI Time Picker (SfTimePicker)

The Time picker mode is specified in the picker property enumeration, which is used to display the time picker based on the modes. It offers three modes: `Default`, `Dialog`, and `RelativeDialog`. The default picker mode is `Default` in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

## Dialog Mode

The dialog mode is used to display the time picker in a pop-up by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`Dialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_Dialog) in [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker"
                     Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker timePicker = new SfTimePicker()
{
    Mode = PickerMode.Dialog
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

The Time Picker can be opened programmatically by setting the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html). By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <picker:SfTimePicker x:Name="timepicker"
                         Mode="Dialog"/>
    <Button Text="Open Picker" 
            x:Name="pickerButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.timepicker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

   ![Dialog mode in .NET MAUI Time picker.](images/time-picker-mode/maui-time-picker-dialog-mode.gif)

## Relative Dialog Mode

The relative dialog mode displays the time picker in a pop-up by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [RelativeDialog](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). It is used to align the picker in a specific position. You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

### Relative position

The [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) is specified in the picker property enumeration, which is used to align the picker in a specific position. It provides eight positions such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft`, and `AlignBottomRight`. The default relative position is `AlignTop` in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).


The Time Picker can be opened programmatically by setting the [`IsOpen`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html). By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <picker:SfTimePicker x:Name="timePicker" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft">
    </picker:SfTimePicker>
    <Button Text="Open picker" 
            x:Name="pickerButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.timepicker.IsOpen = true;
}

{% endhighlight %} 
 
{% endtabs %}

### Relative view

The [RelativeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativeView) is specified in the picker's property enumeration and is used to display the picker dialog relative to a view by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [RelativeDialog](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).


N> It is only applicable in `RelativeDialog` mode. If `no relative view` is specified, the picker base will be set as the `default` relative view.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<Grid>
    <picker:SfTimePicker x:Name="timePicker" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft"
                         RelativeView = "{x:Reference pickerButton}">
    </picker:SfTimePicker>
    <Button Text="Open picker" 
            x:Name="pickerButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.timepicker.IsOpen = true;
    this.timepicker.RelativeView = pickerButton;
}

{% endhighlight %}

{% endtabs %}

   ![Relative dialog mode in .NET MAUI Time picker.](images/time-picker-mode/maui-time-picker-relative-dialog-mode1.png)

   ![Relative dialog mode in .NET MAUI Time picker.](images/time-picker-mode/maui-time-picker-relative-dialog-mode2.png)

### Custom Popup Size

SfTimePicker allows the display of the Popup to render at any desired size by setting the [PopupWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupWidth) and [PopupHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupHeight) properties.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="timePicker" 
                         Mode="Dialog"
                         PopupWidth="300"
                         PopupHeight="400"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

this.timePicker.PopupWidth = 300;
this.timePicker.PopupHeight = 400;

{% endhighlight %} 

{% endtabs %}
