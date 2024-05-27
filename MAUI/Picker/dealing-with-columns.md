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

## DisplayMemberPath

When you have a collection of objects, and you want to display a specific property of those objects rather than the entire object by using the [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_DisplayMemberPath) property in the [PickerColum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html) class.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<sfPicker:SfPicker x:Name="Picker">
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    public MainPage()
    {
        InitializeComponent();
        ObservableCollection<CountryInfo>  countryDetails = new ObservableCollection<CountryInfo>
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
        this.Picker.Columns.Add(pickerColumn);
    }
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

### Width customization

Customize the [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_Width) of every column by setting the `Width` property in the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value of width is `-1`.

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

Customize the SelectedIndex of every column by setting the `SelectedIndex` property in the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value of the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) property is `0`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<sfPicker:SfPicker x:Name="Picker">
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Columns[0].SelectedIndex = 5;

{% endhighlight %}
{% endtabs %}

### SelectedItem customization

Customize the SelectedItem of every column by setting the `SelectedItem` property in the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value of the [SelectedItem]() property is based on [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) default value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<sfPicker:SfPicker x:Name="Picker">
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Columns[0].SelectedItem = "India";

{% endhighlight %}
{% endtabs %}

N> * If you sets both the `Selected Item` and `Selected Index` properties, the picker will display the item corresponding to the `Selected Index` in the selection view. This ensures the index value takes precedence for display purposes. N> * And in multiple column, if you set any one of the column selected item as `null`, then the other column selected item also will be null.

### HeaderText customization

Customize the Header text of every column by setting the `HeaderText` property in the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value of the [HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_HeaderText) property is `string.empty`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<sfPicker:SfPicker x:Name="Picker">
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Columns[0].HeaderText = "Languages";
    
{% endhighlight %}
{% endtabs %}

   ![Header text customization in .NET MAUI Picker.](images/dealing-with-columns/maui-picker-custom-headertext.png)

### ItemsSource customization

Customize the ItemSource of every column by setting the `ItemSource` property in the [PickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html). The default value of the [ItemSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_ItemsSource) property is `null`.

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

   ![Item souce customization in .NET MAUI Picker.](images/dealing-with-columns/maui-picker-custom-item-source.png)

### Column divider color

Customize the column divider color when the picker consists of more than one column using the [ColumnDividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor) property in [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<sfPicker:SfPicker x:Name="Picker"
                   ColumnDividerColor="Red">
</sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfPicker picker = new SfPicker();
picker.ColumnDividerColor = Colors.Red;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Column divider color in .NET MAUI Picker.](images/dealing-with-columns/maui-picker-column-divider-color.png)