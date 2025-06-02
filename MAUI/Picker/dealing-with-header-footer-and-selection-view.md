---
layout: post
title: Header, Footer and Selection in .NET MAUI Picker (SfPicker) Control | Syncfusion<sup>&reg;</sup>
description: Learn here all about Header, Footer and Selection view with Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Header, Footer and Selection in MAUI Picker (SfPicker)

This section explains the Header, Footer and Selection view customization of Picker control.

## Enable or disable Header

SfPicker can enable or disable the Header section by setting the `SfPicker.HeaderView.Height` property to a value greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Height) property is 0.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
    <sfPicker:SfPicker.HeaderView>
        <sfPicker:PickerHeaderView Height="40"/>
    </sfPicker:SfPicker.HeaderView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.HeaderView.Height= 40;

{% endhighlight %}
{% endtabs %}

   ![Enable Header in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-enable-header.png)

## Header customization

SfPicker allows customization of Background, text style.

### Background

The Header’s [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Background) color can be customized by setting the the `SfPicker.HeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
    <sfPicker:SfPicker.HeaderView>
        <sfPicker:PickerHeaderView Background="#D3D3D3"/>
    </sfPicker:SfPicker.HeaderView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.HeaderView.Background = Color.FromArgb("#6750A4");

{% endhighlight %}
{% endtabs %}

   ![Picker Header Background in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-header-background.png)

### Header text style

The .NET MAUI Picker (SfPicker) control and Header [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) such as the `TextColor`, `FontSize`, `FontFamily`, and `FontAttributes` can be customized as shown in the following code examples.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
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

    this.picker.HeaderView.TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Gray,
        FontSize = 18,
        FontAttributes = FontAttributes.Italic
    };

{% endhighlight %}
{% endtabs %}

   ![Header text style in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-header-text-style.png)

### Divider color

The Header’s [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_DividerColor) color can be customized by setting the the `SfPicker.HeaderView.DividerColor` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
    <sfPicker:SfPicker.HeaderView>
        <sfPicker:PickerHeaderView DividerColor="Red"/>
    </sfPicker:SfPicker.HeaderView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.HeaderView.DividerColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

   ![Header divider color in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-header-divider-color.png)

## Enable or disable Footer

SfPicker can enable or disable the Footer section by setting the `SfPicker.FooterView.Height` property to a value greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) property is 0.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView Height="40"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.FooterView.Height= 40;

{% endhighlight %}
{% endtabs %}

   ![Enable Footer in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-enable-footer.png)

## Footer view customization

SfPicker allows customization of the Background, text, and text style of the `OK` and `Cancel` buttons and the visibility of the OK button.

### Background

The Header’s [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background) color can be customized by setting the the `SfPicker.HeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView Background="#D3D3D3"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.FooterView.Background = Color.FromArgb("#6750A4");

{% endhighlight %}
{% endtabs %}

   ![Footer Background in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-footer-background.png)

### Buttons customization

SfPicker can enable or disable the `OK` button by setting the `SfPicker.FooterView.ShowOkButton` property to true or false. The default value of the [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) property is true. Customize the text of the `OK` and `Cancel` buttons using the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView 
            ShowOkButton="False" 
            OkButtonText="Done" 
            CancelButtonText="Exit"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.FooterView.OkButtonShow = false;
    this.picker.FooterView.OkButtonText= "Done";
    this.picker.FooterView.CancelButtonText= "Exit";
  
{% endhighlight %}
{% endtabs %}

   ![Footer button customization in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-footer-custom-button.png)

### Footer text style

The .NET MAUI Picker (SfPicker) control and Footer [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle) such as the `TextColor`, `FontSize`, `FontFamily`, and `FontAttributes` can be customized as shown in the following code examples.

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

    this.picker.FooterView.TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Gray,
        FontSize = 18,
        FontAttributes = FontAttributes.Italic
    };

{% endhighlight %}
{% endtabs %}

   ![Footer text style in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-footer-text-style.png)

### Divider color

The Footer’s [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_DividerColor) color can be customized by setting the the `SfPicker.FooterView.DividerColor` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="picker">
    <sfPicker:SfPicker.FooterView>
        <sfPicker:PickerFooterView DividerColor="Red"/>
    </sfPicker:SfPicker.FooterView>
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.FooterView.DividerColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

   ![Footer divider color in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-footer-divider-color.png)

## Perform validation with default validation button

Picker allows validation based on the OK or Cancel button by hooKing into the `SfPicker.OkButtonClicked` and `SfPicker.CancelButtonClicked` In this event, from the `SelectionChangedEvent` argument, current selected items can be obtained.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="picker"
                       OkButtonClicked="SfPicker_OkButtonClicked"
                       CancelButtonClicked="SfPicker_CancelButtonClicked">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.picker.OkButtonClicked += SfPicker_OkButtonClicked;
    this.picker.CancelButtonClicked += SfPicker_CancelButtonClicked;
    private void SfPicker_OkButtonClicked(object sender, EventArgs e)
    {
      // Perform any operation.
    }

    private void SfPicker_CancelButtonClicked(object sender, EventArgs e)
    {
      // Perform any operation.
    }
    
{% endhighlight %}
{% endtabs %}

## Selection view customization

Customize the Picker Selection view by using the SelectionView property of the SfPicker.

### Background and Selection shape customization

In the SfPicker control, the CornerRadius, strOKe, Background and Padding can be customized by setting the the [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_CornerRadius), [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Stroke), [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Background) and [Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Padding) properties in the [PickerSelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfPicker x:Name="picker" >
    <picker:SfPicker.SelectionView >
        <picker:PickerSelectionView CornerRadius="10" Stroke="#36454F" Padding="10, 5, 10, 5" Background="#808080" />
    </picker:SfPicker.SelectionView>
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfPicker picker  = new SfPicker();
picker .SelectionView = new PickerSelectionView()
{
    CornerRadius = 10,
    StroKe = Color.FromArgb("#36454F"),
    Padding = new Thickness(10, 5, 10, 5),
    Background = Color.FromArgb("#808080"),
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Selected item customization in .NET MAUI Picker (SfPicker).](images/custom-views/maui-picker-selected-item-customization.png)
