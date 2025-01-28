---
layout: post
title: Column header with .NET MAUI Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn here all about column header with Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfPicker) control and its basic features.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Column Header in .NET MAUI Picker (SfPicker)

This section explains the column header customization of picker control.

## Column header view

The SfPicker enables or disables the column header section by setting the SfPicker.ColumnHeaderView.Height property to a value greater than 0. The default value of the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_Height) property is 0.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

    <sfPicker:SfPicker x:Name="picker">
        <sfPicker:SfPicker.ColumnHeaderView>
            <sfPicker:PickerColumnHeaderView Height="40"/>
        </sfPicker:SfPicker.ColumnHeaderView>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.ColumnHeaderView.Height= 40;

{% endhighlight %}
{% endtabs %}

   ![Set Column header in .NET MAUI Picker.](images/dealing-with-column-header/maui-picker-column-header.png)

## Column header customization

Enhancing Column Header with `Height`, `Text Style`, `Background`, and `DividerColor` Properties.

### Background

The column header [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_Background) color can be customized by setting the SfPicker.ColumnHeaderView.Background property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

    <sfPicker:SfPicker x:Name="picker">
        <sfPicker:SfPicker.ColumnHeaderView>
            <sfPicker:PickerColumnHeaderView Background="#E5E4E2"/>
        </sfPicker:SfPicker.ColumnHeaderView>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.ColumnHeaderView.Background = Color.FromArgb("#E5E4E2"),

{% endhighlight %}
{% endtabs %}

   ![Column header background color in .NET MAUI Picker.](images/dealing-with-column-header/maui-picker-column-header-background.png)

### Column header text style

The .NET MAUI Picker control and column header [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumnHeaderView.html#Syncfusion_Maui_Picker_PickerColumnHeaderView_TextStyle) such as text color, font size, font family, and font attributes can be customized as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

    <sfPicker:SfPicker x:Name="picker">
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
{% highlight c# tabtitle="C#" %}

    this.picker.ColumnHeaderView.TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Gray,
        FontSize = 18,
        FontAttributes = FontAttributes.Italic
    };

{% endhighlight %}
{% endtabs %}

   ![Column header text style in .NET MAUI Picker.](images/dealing-with-column-header/maui-picker-column-header-text-style.png)

### Divider color

The .NET MAUI Picker control, Separator line background customized by setting `SfPicker.ColumnHeaderView.DividerColor` property.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

    <sfPicker:SfPicker x:Name="picker">
        <sfPicker:SfPicker.ColumnHeaderView>
            <sfPicker:PickerColumnHeaderView DividerColor="Red"/>
        </sfPicker:SfPicker.ColumnHeaderView>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

    this.picker.ColumnHeaderView.DividerColor = Colors.Red;

{% endhighlight %}
{% endtabs %}

   ![Column header divider color in .NET MAUI Picker.](images/dealing-with-column-header/maui-picker-column-header-divider-color.png)