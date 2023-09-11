---
layout: post
title: Customizations in .NET MAUI TimePicker control | Syncfusion
description: Learn here all about Customizations support in Syncfusion .NET MAUI TimePicker (SfTimePicker) control and more.
platform: maui
control: SfTimePicker
documentation: ug
---

# Customizations in .NET MAUI TimePicker (SfTimePicker)

Each cell of the header, column header, footer and selection views can be customized in [.NET MAUI TimePicker]() (SfTimePicker).

## Header customization

You can customize the time picker header view cell by using the `HeaderView` property of `SfTimePicker`.

### Set header text

The SfTimePicker control allows you to add the header text by setting the [Text] property in the [PickerHeaderView]. To enable the header view by setting the [Height] property in the [PickerHeaderView].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.HeaderView >
        <picker:PickerHeaderView Height="40" Text="Time Picker"/>
    </picker:SfTimePicker.HeaderView>
</picker:SfTimePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}


SfTimePicker timePicker = new SfTimePicker();
timePicker.HeaderView = new PickerHeaderView()
{
    Height = 40,
    Text = "Time Picker"
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of header

*    **Header View** - You can customize the header view text style, divider color and background of the `TimePicker` using the [TextStyle](), [DividerColor]() and [Background]() properties of the [HeaderView]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.HeaderView >
        <picker:PickerHeaderView Height="40" Text="Time Picker" DividerColor="#FFEFD2" Background="#6750A4">
            <picker:PickerHeaderView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="White" />
            </picker:PickerHeaderView.TextStyle>
        </picker:PickerHeaderView>
    </picker:SfTimePicker.HeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.HeaderView = new PickerHeaderView()
{
    Height = 40,
    Text = "Time Picker",
    DividerColor = Color.FromArgb("#FFEFD2")
    Background = Color.FromArgb("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![Header view Customization in .NET MAUI TimePicker.]()

## Column header customization

You can customize the time picker column header view cell by using the `ColumnHeaderView` property of `SfTimePicker`.

### Set custom column header 

[`SfTimePicker`]() allows providing custom text to its column header by setting the [`SfTimePicker.ColumnHeaderView`](). And its contain [`ColumnHeaderView.HourHeaderText`]() [`ColumnHeaderView.MinuteHeaderText`](), and [`ColumnHeaderView.SecondHeaderText`]() properties. Default value of [`ColumnHeaderView.HourHeaderText`]() property is "Hour", [`ColumnHeaderView.MinuteHeaderText`]() is "Minute", and [`ColumnHeaderView.SecondHeaderText`]() is "Second".

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.ColumnHeaderView >
        <picker:TimePickerColumnHeaderView HourHeaderText="Hour Column"
                                            MinuteHeaderText="Minute Column"
                                            SecondHeaderText="Second Column"/>
    </picker:SfTimePicker.ColumnHeaderView>
</picker:SfTimePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
{
    HourHeaderText = "Hour Column",
    MinuteHeaderText = "Minute Column",
    SecondHeaderText = "Second Column"
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of column header

*    **Column Header View** - You can customize the column header view text style, divider color and background of the `TimePicker` using the [TextStyle](), [DividerColor]() and [Background]() properties of the [ColumnHeaderView]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.ColumnHeaderView >
        <picker:TimePickerColumnHeaderView DividerColor="#FFEFD2" Background="#6750A4">
            <picker:TimePickerColumnHeaderView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="White" />
            </picker:TimePickerColumnHeaderView.TextStyle>
        </picker:TimePickerColumnHeaderView>
    </picker:SfTimePicker.ColumnHeaderView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
{
    DividerColor = Color.FromArgb("#FFEFD2")
    Background = Color.FromArgb("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![Column Header view Customization in .NET MAUI TimePicker.]()

## Footer customization

You can customize the time picker footer view cell by using the `FooterView` property of `SfTimePicker`.

### Set footer with ok and cancel button customizations

In the SfTimePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText] and [CancelButtonText] properties in the [PickerFooterView]. It allows you to confirm or cancel the selected Time. The `OkButtonText` can be enabled using the [ShowOkButton] property in the [PickerFooterView].
The Default value of [OkButtonText]() property is "OK", [CancelButtonText]() is "Cancel".

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.FooterView >
        <picker:PickerFooterView Height="40" OkButtonText="Ok Button"
                                    CancelButtonText="Cancel Button"/>
    </picker:SfTimePicker.FooterView>
</picker:SfTimePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.FooterView = new PickerFooterView()
{
    Height = 40,
    OkButtonText = "Ok Button",
    CancelButtonText = "Cancel Button",
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of footer

*    **Footer View** - You can customize the footer view text style, divider color and background of the `TimePicker` using the [TextStyle](), [DividerColor]() and [Background]() properties of the [FooterView]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.FooterView >
        <picker:PickerFooterView Height="40" Text="Time Picker" DividerColor="#FFEFD2" Background="#6750A4">
            <picker:PickerFooterView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="White" />
            </picker:PickerFooterView.TextStyle>
        </picker:PickerFooterView>
    </picker:SfTimePicker.FooterView>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.FooterView = new PickerFooterView()
{
    Height = 40,
    DividerColor = Color.FromArgb("#FFEFD2")
    Background = Color.FromArgb("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![Footer view Customization in .NET MAUI TimePicker.]()

## Selection View Customization

You can customize the time picker selection view cell by using the `SelectionView` property of `SfTimePicker`.

### Set selection view

In the SfTimePicker control, corner radius, stroke , and padding can be customized by setting the [CornerRadius], [Stroke] and [Padding] properties in the [PickerSelectionView].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.SelectionView >
        <picker:PickerSelectionView CornerRadius="5" Stroke="Violet" Padding="5, 10, 5, 10" Background="#6750A4" />
    </picker:SfTimePicker.SelectionView>
</picker:SfTimePicker>
 
{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.SelectionView = new PickerSelectionView()
{
    CornerRadius = 5,
    Stroke = Colors.Violet,
    Pading = new Thickness(5, 10, 5, 10),
    Background = Color.FromArgb("#6750A4"),
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### Customization of selected intem

*    **Selected Item** - You can customize the selected view text style of the `TimePicker` using the [SelectedTextStyle]() property of the [SfTimePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" >
    <picker:SfTimePicker.SelectedTextStyle >
        <picker:PickerTextStyle FontSize="15" TextColor="White"/>
    </picker:SfTimePicker.SelectedTextStyle>
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker();
timePicker.SelectedTextStyle = new PickerTextStyle()
{
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![Selection view Customization in .NET MAUI TimePicker.]()