---
layout: post
title: Columns with .NET MAUI Picker Control | Syncfusion
description: Learn here all about columns with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Columns in .NET MAUI Picker (SfPicker)

This section explains the customization of picker columns.

## Columns customization 

You can customize various properties, including `DisplayMemberPath`, `Width`, `SelectedIndex`, `ItemsSource`, and `HeaderText` for enhanced control and flexibility by the following code.

### Width customization

You can customize the [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_Width) of every column by setting the `SfPicker.Columns[Column index value].Width` property. The default value of width is `-1`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Columns[0].Width = 150;
    
{% endhighlight %}
{% endtabs %}
 
### SelectedIndex customization

You can customize the SelectedIndex of every column by setting the `SfPicker.Columns[Column index value].SelectedIndex` property. The default value of the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) property is `0`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Columns[0].SelectedIndex = 5;

{% endhighlight %}
{% endtabs %}

### HeaderText customization

You can customize the Header text of every column by setting the `SfPicker.Columns[Column index value].HeaderText` property. The default value of the [HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_HeaderText) property is `string.empty`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Columns[0].HeaderText = "Languages";
    
{% endhighlight %}
{% endtabs %}

### ItemsSource customization

You can customize the ItemSource of every column by setting the `SfPicker.Columns[Column index value].ItemSource` property. The default value of the [ItemSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_ItemsSource) property is `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    ObservableCollection<string> languages = new ObservableCollection<string> { "Spanish", "French", "Tamil", "English", "German", "Chinese", "Telegu", "Japanese", "Arabic", "Russian", "Portuguese", "Italian" };
    this.Picker.Columns.Add(languages);

{% endhighlight %}
{% endtabs %}

