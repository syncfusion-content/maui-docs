---
layout: post
title: Header, Footer and Selection in .NET MAUI Picker (SfPicker) Control | Syncfusion<sup>&reg;</sup><sup>&reg;</sup>
description: Learn here all about Header, Footer and Selection view with Syncfusion<sup>&reg;</sup><sup>&reg;</sup> .NET MAUI Picker (SfPicker) (SfPicker) control.
platform: MAUI
control: SfPicker
documentation: ug
---

# Dealing with Header, Footer and Selection in MAUI Picker (SfPicker)

This section explains the Header, Footer and Selection view customization of Picker control.

## Enable or disable Header

SfPicker can enable or disable the Header section by setting the `SfPicker.HeaderView.Height` property to a value greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerHeaderView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerHeaderView_Height) property is 0.

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

   ![Enable Header in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-enable-Header.png)

## Header customization

SfPicker allows customization of Background, text style.

### Background

The Header’s [Background](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerHeaderView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerHeaderView_Background) color can be customized by setting the the `SfPicker.HeaderView.Background` property.

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

   ![Picker Header Background in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-Header-Background.png)

### Header text style

The .NET MAUI Picker (SfPicker) control and Header [TextStyle](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerHeaderView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerHeaderView_TextStyle) such as the `TextColor`, `FontSize`, `FontFamily`, and `FontAttributes` can be customized as shown in the following code examples.

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

   ![Header text style in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-Header-text-style.png)

### Divider color

The Header’s [DividerColor](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerHeaderView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerHeaderView_DividerColor) color can be customized by setting the the `SfPicker.HeaderView.DividerColor` property.

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

   ![Header divider color in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-Header-divider-color.png)

## Enable or disable Footer

SfPicker can enable or disable the Footer section by setting the `SfPicker.FooterView.Height` property to a value greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerFooterView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerFooterView_Height) property is 0.

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

   ![Enable Footer in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-enable-Footer.png)

## Footer view customization

SfPicker allows customization of the Background, text, and text style of the `OK` and `Cancel` buttons and the visibility of the OK button.

### Background

The Header’s [Background](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerFooterView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerFooterView_Background) color can be customized by setting the the `SfPicker.HeaderView.Background` property.

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

   ![Footer Background in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-Footer-Background.png)

### Buttons customization

SfPicker can enable or disable the `OK` button by setting the `SfPicker.FooterView.ShowOkButton` property to true or false. The default value of the [ShowOkButton](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerFooterView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerFooterView_ShowOkButton) property is true. Customize the text of the `OK` and `Cancel` buttons using the [OkButtonText](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerFooterView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerFooterView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerFooterView_CancelButtonText) property.

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

   ![Footer button customization in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-Footer-custom-button.png)

### Footer text style

The .NET MAUI Picker (SfPicker) control and Footer [TextStyle](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerFooterView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerFooterView_TextStyle) such as the `TextColor`, `FontSize`, `FontFamily`, and `FontAttributes` can be customized as shown in the following code examples.

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

{% endhighlight %}
{% endtabs %}

   ![Footer text style in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-Footer-text-style.png)

### Divider color

The Footer’s [DividerColor](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerFooterView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerFooterView_DividerColor) color can be customized by setting the the `SfPicker.FooterView.DividerColor` property.

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

   ![Footer divider color in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-Footer-divider-color.png)

## Perform validation with default validation button

Picker allows validation based on the OK or Cancel button by hoOKing into the `SfPicker.OkButtonClicked` and `SfPicker.CancelButtonClicked` In this event, from the `SelectionChangedEvent` argument, current selected items can be obtained.

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

In the SfPicker control, the CornerRadius, strOKe, Background and Padding can be customized by setting the the [CornerRadius](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerSelectionView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerSelectionView_CornerRadius), [StrOKe](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerSelectionView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerSelectionView_StrOKe), [Background](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerSelectionView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerSelectionView_Background) and [Padding](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerSelectionView.html#Syncfusion<sup>&reg;</sup>_Maui_Picker_PickerSelectionView_Padding) properties in the [PickerSelectionView](https://help.syncfusion.com/cr/MAUI/Syncfusion<sup>&reg;</sup>.Maui.Picker.PickerSelectionView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Picker:SfPicker x:Name="Picker" >
    <Picker:SfPicker.SelectionView >
        <Picker:PickerSelectionView CornerRadius="10" StrOKe="#36454F" Padding="10, 5, 10, 5" Background="#808080" />
    </Picker:SfPicker.SelectionView>
</Picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfPicker Picker = new SfPicker();
Picker.SelectionView = new PickerSelectionView()
{
    CornerRadius = 10,
    StrOKe = Color.FromArgb("#36454F"),
    Padding = new Thickness(10, 5, 10, 5),
    Background = Color.FromArgb("#808080"),
};

this.Content = Picker;

{% endhighlight %}
{% endtabs %}

   ![Selected item customization in .NET MAUI Picker (SfPicker).](images/custom-views/MAUI-Picker-selected-item-customization.png)
