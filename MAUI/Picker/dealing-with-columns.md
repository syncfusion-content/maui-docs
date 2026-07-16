---
layout: post
title: Columns with .NET MAUI Picker Control | Syncfusion®
description: Learn here all about the picker columns and its customization with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Columns in .NET MAUI Picker (SfPicker)

This section explains the customization of picker columns.

## Columns customization 

The `PickerColumn` class exposes `DisplayMemberPath`, `Width`, `SelectedIndex`, `ItemsSource`, and `HeaderText` for enhanced control and flexibility by the following code.

## DisplayMemberPath

When you have a collection of objects, and you want to display a specific property of those objects rather than the entire object by using the [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_DisplayMemberPath) property in the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html) class.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker();
ObservableCollection<CountryInfo> countryDetails = new ObservableCollection<CountryInfo>
{
    new CountryInfo { Language = "Tamil", StateName = "Tamil Nadu" },
    new CountryInfo { Language = "Hindi", StateName = "Uttar Pradesh" },
    new CountryInfo { Language = "Bengali", StateName = "West Bengal" },
    new CountryInfo { Language = "Telugu", StateName = "Andhra Pradesh" },
    new CountryInfo { Language = "Marathi", StateName = "Maharashtra" },
    new CountryInfo { Language = "Kannada", StateName = "Karnataka" },
    new CountryInfo { Language = "Gujarati", StateName = "Gujarat" },
    new CountryInfo { Language = "Punjabi", StateName = "Punjab" },
    new CountryInfo { Language = "Odia", StateName = "Odisha" },
    new CountryInfo { Language = "Malayalam", StateName = "Kerala" },
    new CountryInfo { Language = "Assamese", StateName = "Assam" },
};
PickerColumn pickerColumn = new PickerColumn()
{
    DisplayMemberPath = "Language",
    HeaderText = "Select Languages",
    ItemsSource = countryDetails,
    SelectedIndex = 1,
};
picker.Columns.Add(pickerColumn);

this.Content = picker;
{% endhighlight %}
{% highlight c# tabtitle="CountryInfo.cs" %}

    public class CountryInfo
    {
        public string Language { get; set; }
        public string StateName { get; set; }
    }

{% endhighlight %}
{% endtabs %}

   ![Picker display member path in .NET MAUI Picker.](images/dealing-with-columns/maui-picker-display-member-path.png)

### Width

Set the [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_Width) of each column through the `Width` property on the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value of width is `-1`.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker();
picker.Columns[0].Width = 150;

this.Content = picker;

{% endhighlight %}
{% endtabs %}

### SelectedIndex

Set the `SelectedIndex` of each column through the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) property on the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value is `0`.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker();
picker.Columns[0].SelectedIndex = 5;

this.Content = picker;

{% endhighlight %}
{% endtabs %}

### SelectedItem

Set the `SelectedItem` of each column through the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedItem) property on the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value is derived from the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) default value.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker();
picker.Columns[0].SelectedItem = "India";

this.Content = picker;

{% endhighlight %}
{% endtabs %}

N>
* If you set both the `SelectedItem` and `SelectedIndex` properties, the picker displays the item corresponding to the `SelectedIndex` in the selection view. The index value takes precedence for display purposes.
* In multiple columns, if you set any one column's selected item as `null`, the selected item for the other columns will also become `null`.

### HeaderText

Set the `HeaderText` of each column through the [HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_HeaderText) property on the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value is `string.Empty`.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker();
picker.Columns[0].HeaderText = "Languages";

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Header text customization in .NET MAUI Picker.](images/dealing-with-columns/maui-picker-custom-headertext.png)

### ItemsSource

Set the `ItemsSource` of each column through the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_ItemsSource) property on the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value is `null`.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker();
ObservableCollection<string> languages = new ObservableCollection<string> { "Spanish", "French", "Tamil", "English", "German", "Chinese", "Telegu", "Japanese", "Arabic", "Russian", "Portuguese", "Italian" };
picker.Columns.Add(languages);

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Item source customization in .NET MAUI Picker.](images/dealing-with-columns/maui-picker-custom-item-source.png)

### Column divider color

Customize the column divider color when the picker consists of more than one column using the [ColumnDividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor) property in [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker"
                     ColumnDividerColor="Red">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;
. . .

SfPicker picker = new SfPicker();
picker.ColumnDividerColor = Colors.Red;

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Column divider color in .NET MAUI Picker.](images/dealing-with-columns/maui-picker-column-divider-color.png)