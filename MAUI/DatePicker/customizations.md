---
layout: post
title: Customizations in .NET MAUI Date Picker Control | Syncfusion
description: Learn about customizations in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Customizations in .NET MAUI Date Picker (SfDatePicker)

The [.NET MAUI Date Picker](https://www.syncfusion.com/maui-controls/maui-datepicker) header, column header, footer, and selection views can be customized.

## Header Customization

Customize the date picker header by using the `HeaderView` property of the `SfDatePicker`.

### Set the header text

The SfDatePicker control allows you to add the header text by setting the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Text) property in the [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html). To enable the header view, set the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Height) property of [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html) to a value greater than 0. The default value of the Height property is 0.

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

![Header text in .NET MAUI Date picker.](images/customizations/maui-date-picker-header-text.png)

### Set the divider color

The SfDatePicker control allows you to customize the header divider color by setting the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_DividerColor) property of the [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.HeaderView >
        <picker:PickerHeaderView DividerColor="Red" />
    </picker:SfDatePicker.HeaderView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datepicker.HeaderView = new PickerHeaderView()
{
    DividerColor = Colors.Red,
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Header divider color in .NET MAUI Date picker.](images/customizations/maui-date-picker-header-divider-color.png)

### Customization of the header

Customize the header text style and background color of the `Date picker` using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_TextStyle) and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Background) properties of the [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_HeaderView) in the [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html).

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
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Custom Header in .NET MAUI Date picker.](images/customizations/maui-date-picker-custom-header.png)

## Column Header Customization

Customize the date picker column header by using the `ColumnHeaderView` property of the `SfDatePicker`.

### Set custom column header 

The [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html) provides a custom text to its column header by setting the [ColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_ColumnHeaderView) property of the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html), which has [DayHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_DayHeaderText), [MonthHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_MonthHeaderText), and [YearHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_YearHeaderText) properties of the [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html). The default value of the [DayHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_DayHeaderText) property is "Day", [MonthHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_MonthHeaderText) is "Month", and [YearHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_YearHeaderText) is "Year".

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

![Set Column header text in .NET MAUI Date picker.](images/customizations/maui-date-picker-column-header-text.png)

### Set the divider color

The SfDatePicker control allows you to customize the column header divider color by setting the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_DividerColor) property of the [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.ColumnHeaderView >
        <picker:DatePickerColumnHeaderView DividerColor="Red" />
    </picker:SfDatePicker.ColumnHeaderView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
{
    DividerColor = Colors.Red,
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Column header divider color in .NET MAUI Date picker.](images/customizations/maui-date-picker-column-header-divider-color.png)

### Customization of the column header

Customize the column header view text style and background color of the Date Picker using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_TextStyle) and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_Background) properties of the [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.ColumnHeaderView >
        <picker:DatePickerColumnHeaderView Background="#D3D3D3">
            <picker:DatePickerColumnHeaderView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:DatePickerColumnHeaderView.TextStyle>
        </picker:DatePickerColumnHeaderView>
    </picker:SfDatePicker.ColumnHeaderView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.ColumnHeaderView = new DatePickerColumnHeaderView()
{
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Custom Column header text in .NET MAUI Date picker.](images/customizations/maui-date-picker-custom-column-header.png)

## Footer Customization

Customize the date picker footer view by using the FooterView property of the SfDatePicker.

### Set the footer with OK and Cancel button customizations

In the SfDatePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) properties of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html). It allows you to confirm or cancel the selected date. The OkButtonText can be enabled using the [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) property in the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).
The Default value of the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) property is "OK", and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) is "Cancel". To enable the footer view, set the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) property of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html) to a value greater than 0. The default value of the Height property is 0.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.FooterView >
        <picker:PickerFooterView Height="40" OkButtonText="Save"
                                 CancelButtonText="Exit"/>
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.FooterView = new PickerFooterView()
{
    Height = 40,
    OkButtonText = "Save",
    CancelButtonText = "Exit",
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Set Footer text in .NET MAUI Date picker.](images/customizations/maui-date-picker-footer-text.png)

### Set the divider color

The SfDatePicker control allows you to customize the footer divider color by setting the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_DividerColor) property of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.FooterView >
        <picker:PickerFooterView DividerColor="Red" />
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datepicker.FooterView = new PickerFooterView()
{
    DividerColor = Colors.Red,
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Footer divider color in .NET MAUI Date picker.](images/customizations/maui-date-picker-footer-divider-color.png)

### Customization of the footer

Customize the footer text style and background color of the Date Picker using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle) and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background) properties of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.FooterView >
        <picker:PickerFooterView Background="#D3D3D3">
            <picker:PickerFooterView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:PickerFooterView.TextStyle>
        </picker:PickerFooterView>
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.FooterView = new PickerFooterView()
{
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Custom Footer in .NET MAUI Date picker.](images/customizations/maui-date-picker-custom-footer.png)

## Selection View Customization

Customize the date picker selection view by using the `SelectionView` property of the `SfDatePicker`.

### Set selection view

In the SfDatePicker control, the corner radius, stroke, and padding can be customized by setting the [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_CornerRadius), [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Stroke), and [Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Padding) properties in the [PickerSelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker" >
    <picker:SfDatePicker.SelectionView >
        <picker:PickerSelectionView CornerRadius="10" Stroke="#36454F" Padding="10, 5, 10, 5" Background="#808080" />
    </picker:SfDatePicker.SelectionView>
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDatePicker datePicker = new SfDatePicker();
datePicker.SelectionView = new PickerSelectionView()
{
    CornerRadius = 10,
    Stroke = Color.FromArgb("#36454F"),
    Pading = new Thickness(10, 5, 10, 5),
    Background = Color.FromArgb("#808080"),
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Custom selection shape in .NET MAUI Date picker.](images/customizations/maui-date-picker-selection-shape.png)

### Customization of the selected item

Customize the selected view text style of the Date Picker using the [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) property of the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

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

![Custom Selection view in .NET MAUI Date picker.](images/customizations/maui-date-picker-custom-selection-view.png)

## Column divider color

Customize the column divider color using the [ColumnDividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor) property in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDatePicker x:Name="datepicker"
                     ColumnDividerColor="Red">

</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDatePicker datepicker = new SfDatePicker();
datepicker.ColumnDividerColor = Colors.Red;
this.Content = datepicker;

{% endhighlight %}
{% endtabs %}

![Date picker coloumn divider color in .NET MAUI Date picker.](images/customizations/maui-date-picker-column-divider-color.png)