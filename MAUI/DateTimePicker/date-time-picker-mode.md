---
layout: post
title: Mode in .NET MAUI Date Time Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn about date time picker mode in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Date Time picker mode in .NET MAUI Date Time Picker (SfDateTimePicker)
The date time picker mode is specified in the picker property enumeration, which is used to display the date time picker based on the modes. It offers three modes: `Default`, `Dialog`, and `RelativeDialog`. The default picker mode in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html) is `Default`.


## Dialog mode

The dialog mode is used to display the date time picker in a popup by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`Dialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_Dialog) in [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         Mode="Dialog">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.Mode = PickerMode.Dialog;
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

The Date Time picker can be opened programmatically by setting the [`IsOpen`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). By default, the `IsOpen` property is `false`.

Note: This property automatically changes to `false` when you close the dialog by clicking outside of it.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <picker:SfDateTimePicker x:Name="picker" 
                             Mode="Dialog">
    </picker:SfDateTimePicker>
    <Button Text="Open Date Time picker" 
            x:Name="pickerButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs"%}

private void Button_Clicked(object sender, EventArgs e)
{
    this.picker.IsOpen = true;
}

{% endhighlight %}  
{% endtabs %}

   ![Dialog mode in .NET MAUI Date Time picker.](images/date-time-picker-mode/maui-date-time-picker-dialog-mode.gif)

## Relative dialog mode

The relative dialog mode is used to display the date time picker in a pop-up by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [RelativeDialog](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). It is used to align the picker in a specific position. You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

### Relative position

The relative position is specified in the picker property enumeration, which is used to align the picker in a specific position. It provides eight positions such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft`, and `AlignBottomRight`. The default relative position is `AlignTop` in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).


The Date Time picker can be opened programmatically by setting the [`IsOpen`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of the dialog.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <picker:SfDateTimePicker x:Name="picker" 
                             Mode="RelativeDialog"
                             RelativePosition="AlignTopLeft">
    </picker:SfDateTimePicker>
    <Button Text="Open Date Time picker" 
            x:Name="pickerButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs"%}

private void Button_Clicked(object sender, EventArgs e)
{
    this.picker.IsOpen = true;
}

{% endhighlight %}  
{% endtabs %}

### Relative view

The [RelativeView] is specified in the picker's property enumeration and is used to display the picker dialog relative to a view by setting setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [RelativeDialog](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

N>
It is only applicable in `RelativeDialog mode`. If `no` relative view is specified, the picker base will be set as the `default` relative view.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<Grid>
    <picker:SfDateTimePicker x:Name="picker" 
                             Mode="RelativeDialog"
                             RelativePosition="AlignTopLeft"
                             RelativeView = "{x:Reference pickerButton}">
    </picker:SfDateTimePicker>
    <Button Text="Open Date Time picker" 
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

private void Button_Clicked(object sender, EventArgs e)
{
    this.picker.IsOpen = true;
    this.picker.RelativeView = pickerButton;
}

{% endhighlight %}

{% endtabs %}

   ![Relative dialog mode in .NET MAUI Date Time picker.](images/date-time-picker-mode/maui-date-time-picker-relative-dialog-mode1.png)

   ![Relative dialog mode in .NET MAUI Date Time picker.](images/date-time-picker-mode/maui-date-time-picker-relative-dialog-mode2.png)