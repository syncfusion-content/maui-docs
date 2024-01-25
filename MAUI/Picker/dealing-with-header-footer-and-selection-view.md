---
layout: post
title: Header, footer and selection view with .NET MAUI Picker Control | Syncfusion
description: Learn here all about header, footer and selection view with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Header, Footer and Selection view in .NET MAUI Picker (SfPicker)

This section explains the header, footer and selction view customization of picker control.

## Enable or disable header

SfPicker enables or disables the header section by setting the `SfPicker.HeaderView.Height` property to a value greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Height) property is 0.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.HeaderView>
        <sfPicker:PickerHeaderView Height="40"/>
    </sfPicker:SfPicker.HeaderView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.HeaderView.Height= 40;

{% endhighlight %}
{% endtabs %}

   ![Enable header in .NET MAUI Picker.](images/custom-views/maui-picker-enable-header.png)

## Header customization

SfPicker allows customizing background, text style.

### Background

The Header’s [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Background) color can be customized by setting the `SfPicker.HeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.HeaderView>
        <sfPicker:PickerHeaderView Background="#D3D3D3"/>
    </sfPicker:SfPicker.HeaderView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.HeaderView.Background = Color.FromArgb("#6750A4");

{% endhighlight %}
{% endtabs %}

   ![Picker header background in .NET MAUI Picker.](images/custom-views/maui-picker-header-background.png)

### Header text style

The .NET MAUI Picker control and header [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) such as `TextColor`, `FontSize`, `FontFamily`, and `FontAttributes` can be customized as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.HeaderView>
        <sfPicker:PickerHeaderView>
            <sfPicker:PickerHeaderView.TextStyle>
                <sfPicker:PickerTextStyle TextColor="Gray" 
                FontSize="18" 
                FontAttributes="Italic"/>
            </sfPicker:PickerHeaderView.TextStyle>
        </sfPicker:PickerHeaderView>
    </sfPicker:SfPicker.HeaderView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.HeaderView.TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Gray,
        FontSize = 18,
        FontAttributes = FontAttributes.Italic
    };

{% endhighlight %}
{% endtabs %}

   ![Header text style in .NET MAUI Picker.](images/custom-views/maui-picker-header-text-style.png)

### Divider color

The Header’s [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_DividerColor) color can be customized by setting the `SfPicker.HeaderView.DividerColor` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.HeaderView>
        <sfPicker:PickerHeaderView DividerColor="Red"/>
    </sfPicker:SfPicker.HeaderView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.HeaderView.DividerColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

   ![Header divider color in .NET MAUI Picker.](images/custom-views/maui-picker-header-divider-color.png)

## Enable or disable footer

SfPicker enables or disables the footer section by setting the `SfPicker.FooterView.Height` property to a value greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) property is 0.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView Height="40"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.FooterView.Height= 40;

{% endhighlight %}
{% endtabs %}

   ![Enable Footer in .NET MAUI Picker.](images/custom-views/maui-picker-enable-footer.png)

## Footer view customization

SfPicker allows customizing the background, text, and text style of the `ok` and `cancel` buttons and the visibility of the ok button.

### Background

The Header’s [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background) color can be customized by setting the `SfPicker.HeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView Background="#D3D3D3"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.FooterView.Background = Color.FromArgb("#6750A4");

{% endhighlight %}
{% endtabs %}

   ![Footer background in .NET MAUI Picker.](images/custom-views/maui-picker-footer-background.png)

### Buttons customization

SfPicker enables or disables the `ok` button by setting the `SfPicker.FooterView.ShowOkButton` property to true or false. The default value of the [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) property is true. Customize the text of the `ok` and `cancel` buttons using the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView 
            ShowOkButton="False" 
            OkButtonText="Done" 
            CancelButtonText="Exit"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.FooterView.OkButtonShow = false;
    this.Picker.FooterView.OkButtonText= "Done";
    this.Picker.FooterView.CancelButtonText= "Exit";
  
{% endhighlight %}
{% endtabs %}

   ![Footer button customization in .NET MAUI Picker.](images/custom-views/maui-picker-footer-custom-button.png)

### Footer text style

The .NET MAUI Picker control and footer [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle) such as `TextColor`, `FontSize`, `FontFamily`, and `FontAttributes` can be customized as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker>
<sfPicker:SfPicker.FooterView>
    <sfPicker:PickerFooterView>
    <sfPicker:PickerFooterView.TextStyle>
        <sfPicker:PickerTextStyle TextColor="Gray" FontSize="18" FontAttributes="Italic"/>
    </sfPicker:PickerFooterView.TextStyle>
    </sfPicker:PickerFooterView>
</sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.FooterView.TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Gray,
        FontSize = 18,
        FontAttributes = FontAttributes.Italic
        };
    }

{% endhighlight %}
{% endtabs %}

   ![Footer text style in .NET MAUI Picker.](images/custom-views/maui-picker-footer-text-style.png)

### Divider color

The Footer’s [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_DividerColor) color can be customized by setting the `SfPicker.FooterView.DividerColor` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView DividerColor="Red"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.Picker.FooterView.DividerColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

   ![Footer divider color in .NET MAUI Picker.](images/custom-views/maui-picker-footer-divider-color.png)

## Perform validation with default validation button

Picker allows validation based on the OK or Cancel button by hooking into the `SfPicker.OkButtonClicked` and `SfPicker.CancelButtonClicked` In this event, from the `SelectionChangedEvent` argument, current selected items can be obtained.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker"
                       OkButtonClicked="SfPicker_OkButtonClicked"
                       CancelButtonClicked="SfPicker_CancelButtonClicked">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.OkButtonClicked += SfPicker_OkButtonClicked;
    this.Picker.CancelButtonClicked += SfPicker_CancelButtonClicked;
    private void SfPicker_OkButtonClicked(object sender, EventArgs e)
    {
      //// Perform any operation.
    }

    private void SfPicker_CancelButtonClicked(object sender, EventArgs e)
    {
      //// Perform any operation.
    }
    
{% endhighlight %}
{% endtabs %}

## Selection view customization

Customize the picker selection view by using the SelectionView property of the SfPicker.

### Background and selection shape customization

In the SfPicker control, the corner radius, stroke, background and padding can be customized by setting the [CornerRadius], [Stroke], [Background] and [Padding] properties in the [PickerSelectionView].

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfPicker x:Name="picker" >
    <picker:SfPicker.SelectionView >
        <picker:PickerSelectionView CornerRadius="10" Stroke="#36454F" Padding="10, 5, 10, 5" Background="#808080" />
    </picker:SfPicker.SelectionView>
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfPicker picker = new SfPicker();
picker.SelectionView = new PickerSelectionView()
{
    CornerRadius = 10,
    Stroke = Color.FromArgb("#36454F"),
    Pading = new Thickness(10, 5, 10, 5),
    Background = Color.FromArgb("#808080"),
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Selected item customization in .NET MAUI Picker.](images/custom-views/maui-picker-selected-item-customization.png)
