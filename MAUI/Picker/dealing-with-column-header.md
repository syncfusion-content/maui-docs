---
layout: post
title: Column header with .NET MAUI Picker control | Syncfusion
description: Learn here all about column header with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Column Header in .NET MAUI Picker (SfPicker)

This section explains about the column header customization of picker control.

## Column header view

SfPicker allows enabling or disabling the column header section by setting  `SfPicker.ColumnHeaderView.Height` property grater than 0. Default value of `SfPicker.ColumnHeaderView.Height` property is 0.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="Picker_29.MainPage">

    <sfPicker:SfPicker x:Name="picker">
        <sfPicker:SfPicker.ColumnHeaderView>
            <sfPicker:PickerColumnHeaderView Height="50"/>
        </sfPicker:SfPicker.ColumnHeaderView>
    </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.ColumnHeaderView.Height= 50;

{% endhighlight %}
{% endtabs %}

## Column header customization

Enhancing Column Header with `Height`, `Text Style`, `Background`, and `DividerColor` Properties.

### Background

Column header background color can be customized by setting `SfPicker.ColumnHeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
  <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
              xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
              x:Class="Picker_29.MainPage">

      <sfPicker:SfPicker x:Name="picker">
          <sfPicker:SfPicker.ColumnHeaderView>
              <sfPicker:PickerColumnHeaderView Background="Gray"/>
          </sfPicker:SfPicker.ColumnHeaderView>
      </sfPicker:SfPicker>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.ColumnHeaderView.Background=Brush.Gray;

{% endhighlight %}
{% endtabs %}

### Column header text style

The .NET MAUI Picker control, Column header text style such as text color, font size, font family, font attributes can be customize as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
              xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
              xmlns:local ="clr-namespace:Picker_29"
              x:Class="Picker_29.MainPage">

      <sfPicker:SfPicker>
          <sfPicker:SfPicker.ColumnHeaderView>
              <sfPicker:PickerColumnHeaderView>
                  <sfPicker:PickerColumnHeaderView.TextStyle>
                      <sfPicker:PickerTextStyle TextColor="Gray" 
                      FontSize="18" 
                      FontAttributes="Italic"/>
                  </sfPicker:PickerColumnHeaderView.TextStyle>
              </sfPicker:PickerColumnHeaderView>
          </sfPicker:SfPicker.ColumnHeaderView>
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
            picker.ColumnHeaderView.TextStyle = new PickerTextStyle()
            {
                TextColor = Colors.Gray,
                FontSize = 18,
                FontAttributes = FontAttributes.Italic
            };
        }
    }

{% endhighlight %}
{% endtabs %}

### Divider color

The .NET MAUI Picker control, Separator line background customized by setting `SfPicker.ColumnHeaderView.DividerColor` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
              xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
              xmlns:local ="clr-namespace:Picker_29"
              x:Class="Picker_29.MainPage">

      <sfPicker:SfPicker x:Name="picker">
          <sfPicker:SfPicker.ColumnHeaderView>
              <sfPicker:PickerColumnHeaderView DividerColor="Gray"/>
          </sfPicker:SfPicker.ColumnHeaderView>
      </sfPicker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    picker.ColumnHeaderView.DividerColor= Colors.Gray;

{% endhighlight %}
{% endtabs %}