---
layout: post
title: Customizations in .NET MAUI Time Picker Control | Syncfusion
description: Learn about customizations in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Customizations in .NET MAUI Time Picker (SfTimePicker)

The [.NET MAUI Time Picker] header, column header, footer, and selection views can be customized.

## Header Customization

Customize the time picker header by using the `HeaderView` property of the `SfTimePicker`.

### Set the header text

The SfTimePicker control allows you to add the header text by setting the [Text] property in the [PickerHeaderView]. To enable the header view, set the [Height] property of the [PickerHeaderView] to a value greater than 0. The default value of the `Height` property is 0.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.HeaderView >
        <picker:PickerHeaderView Height="40" Text="Time Picker"/>
    </picker:SfTimePicker.HeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timepicker.HeaderView = new PickerHeaderView()
{
    Height = 40,
    Text = "Time Picker"
};

this.Content = TimePicker;

{% endhighlight %}

{% endtabs %}

### Set the divider color

The SfTimePicker control allows you to customize the header divider color by setting the [DividerColor] property of the [PickerHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.HeaderView >
        <picker:PickerHeaderView Height="40" Text="Time Picker" DividerColor="#36454F" />
    </picker:SfTimePicker.HeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timepicker.HeaderView = new PickerHeaderView()
{
    Height = 40,
    Text = "Time Picker",
    DividerColor = Color.FromArgb("#36454F")
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of the header

Customize the header text style and background color of the `Time picker` using the [TextStyle] and [Background] properties of the [HeaderView] in the [PickerHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.HeaderView >
        <picker:PickerHeaderView Height="40" Text="Time Picker" Background="#D3D3D3">
            <picker:PickerHeaderView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:PickerHeaderView.TextStyle>
        </picker:PickerHeaderView>
    </picker:SfTimePicker.HeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.HeaderView = new PickerHeaderView()
{
    Height = 40,
    Text = "Time Picker",
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Column Header Customization

Customize the time picker column header by using the `ColumnHeaderView` property of the `SfTimePicker`.

### Set the custom column header

The [SfTimePicker] provides a custom text to its column header by setting the [ColumnHeaderView] property of the [SfTimePicker]. It contains [HourHeaderText], [MinuteHeaderText], [SecondHeaderText], and [MeridiemHeaderText] properties of the [TimePickerColumnHeaderView]. The default value of the [HourHeaderText] property is "Hour", [MinuteHeaderText] is "Minute", [SecondHeaderText] is "Second", and [MerdiemHeaderText] is "string.Empty".

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.ColumnHeaderView >
        <picker:TimePickerColumnHeaderView HourHeaderText="Hour Column"
                                           MinuteHeaderText="Minute Column"
                                           SecondHeaderText="Second Column"
                                           MeridiemHeaderText="Meridiem Column"/>
    </picker:SfTimePicker.ColumnHeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
{
    HourHeaderText = "Hour Column",
    MinuteHeaderText = "Minute Column",
    SecondHeaderText = "Second Column",
    MerdiemHeaderText = "Merdiem Column"
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Set the divider color

The SfTimePicker control allows you to customize the column header divider color by setting the [DividerColor] property of the [TimePickerColumnHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.ColumnHeaderView >
        <picker:TimePickerColumnHeaderView DividerColor="#36454F" />
    </picker:SfTimePicker.ColumnHeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timepicker.ColumnHeaderView = new TimePickerColumnHeaderView()
{
    DividerColor = Color.FromArgb("#36454F")
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of the column header

Customize the column header view text style and background color of the `Time Picker` using the [TextStyle] and [Background] properties of the [TimePickerColumnHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.ColumnHeaderView >
        <picker:TimePickerColumnHeaderView Background="#E5E4E2">
            <picker:TimePickerColumnHeaderView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:TimePickerColumnHeaderView.TextStyle>
        </picker:TimePickerColumnHeaderView>
    </picker:SfTimePicker.ColumnHeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
{
    Background = Color.FromArgb("#E5E4E2"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Footer Customization

Customize the time picker footer view by using the `FooterView` property of the`SfTimePicker`.

### Set the footer with Ok and Cancel button customizations

In the SfTimePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText] and [CancelButtonText] properties of the [PickerFooterView]. It allows you to confirm or cancel the selected time. The `OkButtonText` can be enabled using the [ShowOkButton] property in the [PickerFooterView].
The Default value of the [OkButtonText] property is "OK", and [CancelButtonText] is "Cancel". To enable the footer view, set the [Height] property of the [PickerFooterView] to a value greater than 0. The default value of the `Height` property is 0.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.FooterView >
        <picker:PickerFooterView Height="40" OkButtonText="Save"
                                 CancelButtonText="Exit"/>
    </picker:SfTimePicker.FooterView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.FooterView = new PickerFooterView()
{
    Height = 40,
    OkButtonText = "Save",
    CancelButtonText = "Exit",
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Set the divider color

The SfTimePicker control allows you to customize the footer divider color by setting the [DividerColor] property of the [PickerFooterView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.FooterView >
        <picker:PickerFooterView Height="40" DividerColor="#36454F" />
    </picker:SfTimePicker.FooterView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timepicker.FooterView = new PickerFooterView()
{
    Height = 40,
    DividerColor = Color.FromArgb("#36454F")
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of the footer

Customize the footer text style and background color of the `Time Picker` using the [TextStyle] and [Background] properties of the [PickerFooterView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.FooterView >
        <picker:PickerFooterView Height="40" Background="#D3D3D3">
            <picker:PickerFooterView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:PickerFooterView.TextStyle>
        </picker:PickerFooterView>
    </picker:SfTimePicker.FooterView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.FooterView = new PickerFooterView()
{
    Height = 40,
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Selection View Customization

Customize the time picker selection view by using the `SelectionView` property of the `SfTimePicker`.

### Set the selection view

In the SfTimePicker control, the corner radius, stroke, and padding can be customized by setting the [CornerRadius], [Stroke], and [Padding] properties in the [PickerSelectionView].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.SelectionView >
        <picker:PickerSelectionView CornerRadius="10" Stroke="Black" Padding="10, 5, 10, 5" Background="#808080" />
    </picker:SfTimePicker.SelectionView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.SelectionView = new PickerSelectionView()
{
    CornerRadius = 10,
    Stroke = Colors.Black,
    Pading = new Thickness(10, 5, 10, 5),
    Background = Color.FromArgb("#808080"),
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of the selected item

Customize the selected view text style of the `Time Picker` using the [SelectedTextStyle] property of the [SfTimePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfTimePicker x:Name="Timepicker" >
    <picker:SfTimePicker.SelectedTextStyle >
        <picker:PickerTextStyle FontSize="15" TextColor="White"/>
    </picker:SfTimePicker.SelectedTextStyle>
    <picker:SfTimePicker.SelectionView>
        <picker:PickerSelectionView Background="#808080" />
    </picker:SfTimePicker.SelectionView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.SelectedTextStyle = new PickerTextStyle()
{
    TextColor = Colors.White,
    FontSize = 15,
};

timePicker.SelectionView = new PickerSelectionView()
{
    Background = Color.FromArgb("#808080"),
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}