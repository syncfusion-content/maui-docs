---
layout: post
title: Header and footer with .NET MAUI Picker control | Syncfusion
description: Learn here all about header and footer with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Header and Footer in .NET MAUI Picker (SfPicker)

This section explains about the header and footer customization of picker control.

## Enable or disable header

SfPicker allows enabling or disabling the header section by setting  `SfPicker.HeaderView.Height` property grater than 0. Default value of `SfPicker.HeaderView.Height` property is 0.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="Picker_29.MainPage">

    <sfPicker:SfPicker x:Name="picker">
        <sfPicker:SfPicker.HeaderView>
            <sfPicker:PickerHeaderView Height="50"/>
        </sfPicker:SfPicker.HeaderView>
    </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.HeaderView.Height= 50;

{% endhighlight %}
{% endtabs %}

## Header customization

SfPicker allows customizing background, text style.

### Background

Header’s background color can be customized by setting `SfPicker.HeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
              xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
              x:Class="Picker_29.MainPage">

      <sfPicker:SfPicker x:Name="picker">
          <sfPicker:SfPicker.HeaderView>
              <sfPicker:PickerHeaderView Background="Gray"/>
          </sfPicker:SfPicker.HeaderView>
      </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.HeaderView.Background=Brush.Gray;

{% endhighlight %}
{% endtabs %}

### Header text style

The .NET MAUI Picker control, Header text style such as text color, font size, font family, font attributes can be customize as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
                xmlns:local ="clr-namespace:Picker_29"
                x:Class="Picker_29.MainPage">

        <sfPicker:SfPicker>
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
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    using Syncfusion.Maui.Picker;
    using System.Collections.ObjectModel;
    namespace Picker_29;
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfPicker picker = new SfPicker();
            picker.HeaderView.TextStyle = new PickerTextStyle()
            {
                TextColor = Colors.Gray,
                FontSize = 18,
                FontAttributes = FontAttributes.Italic
            };
        }
    }

{% endhighlight %}
{% endtabs %}

## Enable or disable footer

SfPicker allows enabling or disabling the footer section by setting  `SfPicker.FooterView.Height` property grater than 0. Default value of `SfPicker.FooterView.Height` property is 0.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="Picker_29.MainPage">

    <sfPicker:SfPicker x:Name="picker">
        <sfPicker:SfPicker.FooterView>
            <sfPicker:PickerFooterView Height="50"/>
        </sfPicker:SfPicker.FooterView>
    </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.FooterView.Height= 50;

{% endhighlight %}
{% endtabs %}

## Footer view customization

SfPicker allows customizing background, text and text style style of the `ok` and `cancel` button and also visibility of the the `ok` button.

### Background

Header’s background color can be customized by setting `SfPicker.HeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
            x:Class="Picker_29.MainPage">

    <sfPicker:SfPicker x:Name="picker">
        <sfPicker:SfPicker.FooterView>
            <sfPicker:PickerFooterView Background="Gray"/>
        </sfPicker:SfPicker.FooterView>
    </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.FooterView.Background=Brush.Gray;

{% endhighlight %}
{% endtabs %}

### Buttons customization

SfPicker allows enabling or disabling the `ok` button by setting SfPicker.FooterView.ShowOkButton property to True or False. Default value of SfPicker.FooterView.ShowOkButton property is True. We can customize the text of the `ok` and and `cancel` buttons.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
                x:Class="Picker_29.MainPage">

        <sfPicker:SfPicker>
            <sfPicker:SfPicker.FooterView>
                <sfPicker:PickerFooterView 
                    ShowOkButton="False" 
                    OkButtonText="Done" 
                    CancelButtonText="Exit"/>
            </sfPicker:SfPicker.FooterView>
        </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    using Syncfusion.Maui.Picker;
    namespace Picker_29;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfPicker picker = new SfPicker();
            picker.FooterView.OkButtonShow = false;
            picker.FooterView.OkButtonText= "Done";
            picker.FooterView.CancelButtonText= "Exit";
        }
    }
  
{% endhighlight %}
{% endtabs %}

### Footer text style

The .NET MAUI Picker control, Footer text style such as text color, font size, font family, font attributes can be customize as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
                x:Class="Picker_29.MainPage">

        <sfPicker:SfPicker>
        <sfPicker:SfPicker.FooterView>
          <sfPicker:PickerFooterView>
            <sfPicker:PickerFooterView.TextStyle>
              <sfPicker:PickerTextStyle TextColor="Gray" FontSize="18" FontAttributes="Italic"/>
            </sfPicker:PickerFooterView.TextStyle>
          </sfPicker:PickerFooterView>
        </sfPicker:SfPicker.FooterView>
        </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    using Syncfusion.Maui.Picker;
    namespace Picker_29;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfPicker picker = new SfPicker();
            picker.FooterView.TextStyle = new PickerTextStyle()
            {
                TextColor = Colors.Gray,
                FontSize = 18,
                FontAttributes = FontAttributes.Italic
            };
        }
    }
  
{% endhighlight %}
{% endtabs %}

## Perform validation with default validation button

Picker allows performing validation based on `OK` or `Cancel` button by hooking SfPicker.OkButtonClicked and SfPicker.CancelButtonClicked. In this event, from the SelectionChangedEvent argument, current selected items can be obtained.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             xmlns:local ="clr-namespace:Picker_29"
             x:Class="Picker_29.MainPage">

    <sfPicker:SfPicker x:Name="picker"
                       OkButtonClicked="SfPicker_OkButtonClicked"
                       CancelButtonClicked="SfPicker_CancelButtonClicked">
    </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.OkButtonClicked += SfPicker_OkButtonClicked;
    picker.CancelButtonClicked += SfPicker_CancelButtonClicked;
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