---
layout: post
title: Customizations in .NET MAUI Date Picker Control | Syncfusion
description: Learn about customizations in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Customizations in .NET MAUI Date Picker (SfDatePicker)

In the [.NET MAUI Date Picker] of the header, column header, footer and selection views can be customized.

## Header customization

You can customize the date picker header by using the `HeaderView` property of `SfDatePicker`.

### Set header text

The SfDatePicker control allows you to add the header text by setting the [Text] property in the [PickerHeaderView]. To enable the header view by setting the [Height] property grater than 0 of [PickerHeaderView]. The default value of `Height` property is 0.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.HeaderView >
        <picker:PickerHeaderView Height="40" Text="Date Picker"/>
    </picker:SfDatePicker.HeaderView>
</picker:SfDatePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datepicker.HeaderView = new PickerHeaderView()
{
    Height = 40,
    Text = "Date Picker"
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### Set divider color

The SfDatePicker control allows you to customize the header divider color by setting the [DividerColor] property of [PickerHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.HeaderView >
        <picker:PickerHeaderView DividerColor="#A9A9A9" />
    </picker:SfDatePicker.HeaderView>
</picker:SfDatePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datepicker.HeaderView = new PickerHeaderView()
{
    DividerColor = Color.FromArgb("#A9A9A9")
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### Customization of header

*    **Header View** - You can customize the header text style and background of the `DatePicker` using the [TextStyle] and [Background] properties of the [HeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.HeaderView >
        <picker:PickerHeaderView Background="#D3D3D3">
            <picker:PickerHeaderView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:PickerHeaderView.TextStyle>
        </picker:PickerHeaderView>
    </picker:SfDatePicker.HeaderView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.HeaderView = new PickerHeaderView()
{
    Background = Color.FromArgb("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

## Column header customization

You can customize the date picker column header by using the `ColumnHeaderView` property of `SfDatePicker`.

### Set custom column header 

[SfDatePicker] allows providing custom text to its column header by setting the [ColumnHeaderView] property of [SfDatePicker]. And its contain [DayHeaderText] [MonthHeaderText], and [YearHeaderText] properties of [DatePickerColumnHeaderView]. Default value of [DayHeaderText] property is "Day", [MonthHeaderText] is "Month", and [YearHeaderText] is "Year".

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.ColumnHeaderView >
        <picker:DatePickerColumnHeaderView DayHeaderText="Day Column"
                                           MonthHeaderText="Month Column"
                                           YearHeaderText="Year Column"/>
    </picker:SfDatePicker.ColumnHeaderView>
</picker:SfDatePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.ColumnHeaderView = new DatePickerColumnHeaderView()
{
    DayHeaderText = "Day Column",
    MonthHeaderText = "Month Column",
    YearHeaderText = "Year Column"
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### Set divider color

The SfDatePicker control allows you to customize the column header divider color by setting the [DividerColor] property of [DatePickerColumnHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.ColumnHeaderView >
        <picker:DatePickerColumnHeaderView DividerColor="#A9A9A9" />
    </picker:SfDatePicker.ColumnHeaderView>
</picker:SfDatePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
{
    DividerColor = Color.FromArgb("#A9A9A9")
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### Customization of column header

*    **Column Header View** - You can customize the column header view text style and background of the `DatePicker` using the [TextStyle] and [Background] properties of the [ColumnHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.ColumnHeaderView >
        <picker:DatePickerColumnHeaderView Background="#6750A4">
            <picker:DatePickerColumnHeaderView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="White" />
            </picker:DatePickerColumnHeaderView.TextStyle>
        </picker:DatePickerColumnHeaderView>
    </picker:SfDatePicker.ColumnHeaderView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.ColumnHeaderView = new DatePickerColumnHeaderView()
{
    Background = Color.FromArgb("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

## Footer customization

You can customize the date picker footer view by using the `FooterView` property of `SfDatePicker`.

### Set footer with ok and cancel button customizations

In the SfDatePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText] and [CancelButtonText] properties of [PickerFooterView]. It allows you to confirm or cancel the selected date. The `OkButtonText` can be enabled using the [ShowOkButton] property in the [PickerFooterView].
The Default value of [OkButtonText] property is "OK", [CancelButtonText] is "Cancel". To enable the footer view by setting the [Height] property grater than 0 of [PickerFooterView]. The default value of `Height` property is 0.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.FooterView >
        <picker:PickerFooterView Height="40" OkButtonText="Ok Button"
                                 CancelButtonText="Cancel Button"/>
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.FooterView = new PickerFooterView()
{
    Height = 40,
    OkButtonText = "Ok Button",
    CancelButtonText = "Cancel Button",
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### Set divider color

The SfDatePicker control allows you to customize the footer divider color by setting the [DividerColor] property of [PickerFooterView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.FooterView >
        <picker:PickerFooterView DividerColor="#A9A9A9" />
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datepicker.FooterView = new PickerFooterView()
{
    DividerColor = Color.FromArgb("#A9A9A9")
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### Customization of footer

*    **Footer View** - You can customize the footer text style and background of the `DatePicker` using the [TextStyle] and [Background] properties of the [FooterView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.FooterView >
        <picker:PickerFooterView Background="#6750A4">
            <picker:PickerFooterView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="White" />
            </picker:PickerFooterView.TextStyle>
        </picker:PickerFooterView>
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.FooterView = new PickerFooterView()
{
    Background = Color.FromArgb("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

## Selection View Customization

You can customize the date picker selection view by using the `SelectionView` property of `SfDatePicker`.

### Set selection view

In the SfDatePicker control, corner radius, stroke , and padding can be customized by setting the [CornerRadius], [Stroke] and [Padding] properties in the [PickerSelectionView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.SelectionView >
        <picker:PickerSelectionView CornerRadius="5" Stroke="Violet" Padding="5, 10, 5, 10" Background="#6750A4" />
    </picker:SfDatePicker.SelectionView>
</picker:SfDatePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.SelectionView = new PickerSelectionView()
{
    CornerRadius = 5,
    Stroke = Colors.Violet,
    Pading = new Thickness(5, 10, 5, 10),
    Background = Color.FromArgb("#6750A4"),
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### Customization of selected intem

*    **Selected Item** - You can customize the selected view text style of the `DatePicker` using the [SelectedTextStyle] property of the [SfDatePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.SelectedTextStyle >
        <picker:PickerTextStyle FontSize="15" TextColor="White"/>
    </picker:SfDatePicker.SelectedTextStyle>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.SelectedTextStyle = new PickerTextStyle()
{
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}