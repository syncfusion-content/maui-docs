---
layout: post
title: Picker Mode in .NET MAUI Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn about the picker mode in Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfPicker) control and its basic features.
platform: maui
control: SfPicker
documentation: ug
---

# Picker mode in .NET MAUI Picker (SfPicker)

The picker mode is specified in the picker property enumeration, which is used to display the picker based on the modes. It offers three modes: `Default`, `Dialog`, and `RelativeDialog`. The default picker mode is `Default` in the [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html).

## Dialog Mode

The dialog mode is used to display the picker in a pop-up by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`Dialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_Dialog) in [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfPicker x:Name="Picker"
                 Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfPicker picker = new SfPicker()
{
    Mode = PickerMode.Dialog
};

this.Content = picker;

{% endhighlight %}

{% endtabs %}

The Picker can be opened programmatically by setting the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html). By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <picker:SfPicker x:Name="picker"
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
    this.picker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

   ![Picker mode in .NET MAUI Picker.](images/picker-mode/maui-picker-mode.gif)

## Relative Dialog Mode

The relative dialog mode displays the picker in a pop-up by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`RelativeDialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). It is used to align the picker in a specific position. You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html).

### Relative position

The [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) is specified in the picker property enumeration, which is used to align the picker in a specific position. It provides eight positions such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft`, and `AlignBottomRight`. The default relative position is `AlignTop` in the [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html).


The Picker can be opened programmatically by setting the [`IsOpen`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen) property to `true` of [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html). By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<Grid>
    <picker:SfPicker x:Name="picker" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft">
    </picker:SfPicker>
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

{% highlight c# tabtitle="C#" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.picker.IsOpen = true;
}

{% endhighlight %} 

{% endtabs %}

### Relative view

The [RelativeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativeView) is specified in the picker's property enumeration and is used to display the picker dialog relative to a view by setting the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) property to [`RelativeDialog`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html#Syncfusion_Maui_Picker_PickerMode_RelativeDialog). You can set the position by setting the [RelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition) property in the [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html).


N> It is only applicable in `RelativeDialog` mode. If `no relative view` is specified, the picker base will be set as the `default` relative view.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<Grid>
    <picker:SfPicker x:Name="picker" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft"
                         RelativeView = "{x:Reference pickerButton}">
    </picker:SfPicker>
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

{% highlight c# tabtitle="C#" hl_lines="4" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.picker.IsOpen = true;
    this.picker.RelativeView = pickerButton;
}

{% endhighlight %} 

{% endtabs %}

   ![Relative dialog mode in .NET MAUI Picker.](images/picker-mode/maui-picker-relative-dialog-mode1.png)

   ![Relative dialog mode in .NET MAUI Picker.](images/picker-mode/maui-picker-relative-dialog-mode2.png)

### Custom Popup Size

SfPicker allows the display of the Popup to render at any desired size by setting the [PopupWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupWidth) and [PopupHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupHeight) properties.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<Grid>
    <picker:SfPicker 
            x:Name="picker"
            Mode="Dialog"
            IsOpen="True"
            RelativePosition="AlignToRightOf"
            PopupWidth="200"
            PopupHeight="440">
        <picker:SfPicker.HeaderView >
            <picker:PickerHeaderView Height="40" Text="Select a color" />
        </picker:SfPicker.HeaderView>
        <picker:SfPicker.Columns>
            <picker:PickerColumn HeaderText="Colors" ItemsSource="{Binding DataSource}"/>
        </picker:SfPicker.Columns>
        <picker:SfPicker.ColumnHeaderView >
            <picker:PickerColumnHeaderView Height="40"/>
        </picker:SfPicker.ColumnHeaderView>
        <picker:SfPicker.FooterView>
            <picker:PickerFooterView  Height="40"/>
        </picker:SfPicker.FooterView>
    </picker:SfPicker>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

private void pickerButton_Clicked(object sender, System.EventArgs e)
{
    this.picker.IsOpen = true;
    this.picker.PopupWidth = 300;
    this.picker.PopupHeight = 440;
}

{% endhighlight %} 

{% endtabs %}
