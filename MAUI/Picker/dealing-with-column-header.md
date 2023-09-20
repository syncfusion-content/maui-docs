---
layout: post
title: Column header with .NET MAUI Picker Control | Syncfusion
description: Learn here all about column header with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Column Header in .NET MAUI Picker (SfPicker)

This section explains the column header customization of picker control.

## Column header view

SfPicker allows enabling or disabling the column header section by setting the `SfPicker.ColumnHeaderView.Height` property greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_Height) property is 0.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
        <sfPicker:SfPicker.ColumnHeaderView>
            <sfPicker:PickerColumnHeaderView Height="50"/>
        </sfPicker:SfPicker.ColumnHeaderView>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.ColumnHeaderView.Height= 50;

{% endhighlight %}
{% endtabs %}

## Column header customization

Enhancing Column Header with `Height`, `Text Style`, `Background`, and `DividerColor` Properties.

### Background

Column header [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_Background) color can be customized by setting `SfPicker.ColumnHeaderView.Background` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
        <sfPicker:SfPicker.ColumnHeaderView>
            <sfPicker:PickerColumnHeaderView Background="Gray"/>
        </sfPicker:SfPicker.ColumnHeaderView>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.ColumnHeaderView.Background=Brush.Gray;

{% endhighlight %}
{% endtabs %}

### Column header text style

The .NET MAUI Picker control, Column header [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) such as text color, font size, font family, and font attributes can be customized as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
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

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.ColumnHeaderView.TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Gray,
        FontSize = 18,
        FontAttributes = FontAttributes.Italic
    };

{% endhighlight %}
{% endtabs %}

### Divider color

The .NET MAUI Picker control, Separator line background customized by setting `SfPicker.ColumnHeaderView.DividerColor` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
        <sfPicker:SfPicker.ColumnHeaderView>
            <sfPicker:PickerColumnHeaderView DividerColor="Gray"/>
        </sfPicker:SfPicker.ColumnHeaderView>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.ColumnHeaderView.DividerColor= Colors.Gray;

{% endhighlight %}
{% endtabs %}