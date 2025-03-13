---
layout: post
title: Date Picker Mode in .NET MAUI Date Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn about the date picker mode in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Picker mode in .NET MAUI Date Picker (SfDatePicker)

The date picker mode is specified in the picker property enumeration, which is used to display the date picker based on the modes. It offers three modes: `Default`, `Dialog`, and `RelativeDialog`. The default picker mode is `Default` in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

## Dialog Mode

The dialog mode is used to display the date picker in a pop-up by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`Dialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_Dialog) in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                     Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    Mode = PickerMode.Dialog
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

The Date Picker can be opened programmatically by setting the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html). By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <picker:SfDatePicker x:Name="datepicker"
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
    this.datepicker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

  ![Dialog mode in .NET MAUI Date picker.](images/date-picker-mode/maui-date-picker-dialog-mode.gif)

## Relative Dialog Mode

The relative dialog mode displays the date picker in a pop-up by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`RelativeDialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). It is used to align the picker in a specific position. You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

### Relative position

The [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) is specified in the picker property enumeration, which is used to align the picker in a specific position. It provides eight positions such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft`, and `AlignBottomRight`. The default relative position is `AlignTop` in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).


The Date Picker can be opened programmatically by setting the [`IsOpen`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html). By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <picker:SfDatePicker x:Name="datePicker" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft">
    </picker:SfDatePicker>
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

{% highlight c# tabtitle="MainPage.xaml.cs"%}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.datepicker.IsOpen = true;
}

{% endhighlight %} 

{% endtabs %}

### Relative view

The [RelativeView] is specified in the picker's property enumeration and is used to display the picker dialog relative to a view by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`RelativeDialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).


N> It is only applicable in `RelativeDialog mode`. If `no` relative view is specified, the picker base will be set as the `default` relative view.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<Grid>
    <picker:SfDatePicker x:Name="datePicker" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft"
                         RelativeView = "{x:Reference pickerButton}">
    </picker:SfDatePicker>
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
    this.datepicker.IsOpen = true;
    this.datepicker.RelativeView = pickerButton;
}

{% endhighlight %}

{% endtabs %}

   ![Relative dialog mode in .NET MAUI Date picker.](images/date-picker-mode/maui-date-picker-relative-dialog-mode1.png)

   ![Relative dialog mode in .NET MAUI Date picker.](images/date-picker-mode/maui-date-picker-relative-dialog-mode2.png)