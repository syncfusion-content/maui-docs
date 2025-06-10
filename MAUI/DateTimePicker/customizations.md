---
layout: post
title: Customizations in .NET MAUI DateTimePicker Control | Syncfusion<sup>&reg;</sup>
description: Learn about customizations in Syncfusion<sup>&reg;</sup> .NET MAUI (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Customizations in .NET MAUI DateTimePicker (SfDateTimePicker)

The [.NET MAUI DateTimePicker](https://www.syncfusion.com/maui-controls/maui-datetimepicker) header, column header, footer, and selection views can be customized.

## Header Customization

Customize the DateTimePicker header by using the `HeaderView` property of the `SfDateTimePicker`.

### DateTimePicker header

The DateTimePicker provides pre-defined header text. By default it shows the current date and time. If you want to change the header text using the [DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_DateFormat) and [TimeFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_TimeFormat) properties in [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

### Set the divider color

The SfDateTimePicker control allows you to customize the header divider color by setting the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_DividerColor) property of the [DateTimePickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker>
    <picker:SfDateTimePicker.HeaderView>
        <picker:DateTimePickerHeaderView DividerColor="Red" />
    </picker:SfDateTimePicker.HeaderView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.HeaderView = new DateTimePickerHeaderView()
{
    DividerColor = Colors.Red,
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Set header divider color in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-set-header-divider-color.png)

### Custom Header Appearance using Datatemplate

You can customize the datetime picker header appearance by using the [Template]() property of the [DateTimePickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="datetimepicker" >
    <picker:SfDateTimePicker.HeaderTemplate>
        <DataTemplate>
            <Grid BackgroundColor="#BB9AB1">
                <Label HorizontalOptions="Center" VerticalOptions="Center" Text="Select a Date and Time" TextColor="White"/>
            </Grid>
        </DataTemplate>
    </picker:SfDateTimePicker.HeaderTemplate>
</picker:SfDateTimePicker>

{% endhighlight %}

{% endtabs %}

![Set header template in .NET MAUI Date Time picker.](maui-date-time-picker-header-template.png)

N> 
* If a template is applied to the header in the [DateTimePickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html) will not work except [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_DividerColor) Property.

* When a template is applied to the DateTimePicker Header, the built-in time selection switch becomes non-functional.

### Custom Header appearance using DataTemplateSelector

You can customize the datetime picker header appearance by using the [Template]() property of the [DateTimePickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html). The DataTemplateSelector allows you to choose a DataTemplate at runtime based on the value bound to the datetime picker header. This lets you apply a custom data template to the header and customize its appearance based on specific conditions.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<Grid.Resources>
    <DataTemplate x:Key="todayDatesTimeTemplate">
        <Grid Background="LightBlue">
            <Label HorizontalOptions="Center" VerticalOptions="Center" Text="Select a Date and Time" TextColor="Red"/>
        </Grid>
    </DataTemplate>
    <DataTemplate x:Key="normalDatesTimeTemplate">
        <Grid Background="LightGreen">
            <Label HorizontalOptions="Center" VerticalOptions="Center" Text="Select a Date and Time" TextColor="Orange"/>
        </Grid>
    </DataTemplate>
    <local:DateTimeTemplateSelector x:Key="headerTemplateSelector" TodayDatesTimeTemplate="{StaticResource todayDatesTimeTemplate}"  NormalDatesTimeTemplate="{StaticResource normalDatesTimeTemplate}"/>
    <picker:SfDateTimePicker x:Name="datetimepicker" HeaderTemplate="{StaticResource headerTemplateSelector}">
    </picker:SfDateTimePicker>
</Grid.Resources>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

public class DateTimeTemplateSelector : DataTemplateSelector
{
    public DateTimeTemplateSelector()
    {
    }
    public DataTemplate TodayDatesTimeTemplate { get; set; }
    public DataTemplate NormalDatesTimeTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var Details = item as SfDateTimePicker;
        if (Details != null)
        {
            if (Details.SelectedDate < DateTime.Now.Date)
                return TodayDatesTimeTemplate;
        }
        return NormalDatesTimeTemplate;
    }
}

{% endtabs %}

### Customization of the header

Customize the header text style and background color of the `DateTimePicker` using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerHeaderView_TextStyle) and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerHeaderView_Background) properties of the [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HeaderView) in the[DateTimePickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker>
    <picker:SfDateTimePicker.HeaderView>
        <picker:DateTimePickerHeaderView Background="#D3D3D3">
            <picker:DateTimePickerHeaderView.TextStyle>
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:DateTimePickerHeaderView.TextStyle>
        </picker:DateTimePickerHeaderView>
    </picker:SfDateTimePicker.HeaderView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#"%}

SfDateTimePicker picker = new SfDateTimePicker();
picker.HeaderView = new DateTimePickerHeaderView()
{
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Custom header in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-custom-header.png)

## Column Header Customization

Customize the DateTimePicker column header by using the `ColumnHeaderView` property of the `SfDateTimePicker`.

### Set the custom column header

The `SfDateTimePicker` providess a custom text to its column header by setting the [ColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_ColumnHeaderView) property of the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html), which has [DayHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_DayHeaderText), [MonthHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_MonthHeaderText), [YearHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_YearHeaderText), [HourHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_HourHeaderText), [MinuteHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_MinuteHeaderText), [SecondHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_SecondHeaderText), and [MeridiemHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_MeridiemHeaderText) properties in the [DateTimePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html). The default value of `DayHeaderText` is "Day", `MonthHeaderText` is "Month", `YearHeaderText` is "Year", `HourHeaderText` is "Hour", `MinuteHeaderText` is "Minute", `SecondHeaderText` is "Second", and `MeridiemHeaderText` is "string.Empty".

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker>
    <picker:SfDateTimePicker.ColumnHeaderView>
        <picker:DateTimePickerColumnHeaderView 
            DayHeaderText="Day Column" MonthHeaderText="Month Column" YearHeaderText="Year Column" 
            HourHeaderText="Hour Column" MinuteHeaderText="Minute Column" SecondHeaderText="Second Column" 
            MeridiemHeaderText="Meridiem Column" />
    </picker:SfDateTimePicker.ColumnHeaderView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.ColumnHeaderView = new DateTimePickerColumnHeaderView()
{
    DayHeaderText = "Day Column",
    MonthHeaderText = "Month Column",
    YearHeaderText = "Year Column",
    HourHeaderText = "Hour Column",
    MinuteHeaderText = "Minute Column",
    SecondHeaderText = "Second Column",
    MeridiemHeaderText = "Meridiem Column",
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Custom column header in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-custom-column-header.png)

### Set the divider color

The SfDateTimePicker control allows you to customize the column header divider color by setting the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_DividerColor) property of the [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker>
    <picker:SfDateTimePicker.ColumnHeaderView>
        <picker:DateTimePickerColumnHeaderView DividerColor="Red" />
    </picker:SfDateTimePicker.ColumnHeaderView>
</picker:SfDateTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.ColumnHeaderView = new DateTimePickerColumnHeaderView()
{
    DividerColor = Colors.Red,
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Set column header divider color in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-set-column-header-divider-color.png)

### Customization of the column header

Customize the column header view text style and background color of the `DateTimePicker` using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_TextStyle) and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_Background) properties of the [DateTimePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker>
    <picker:SfDateTimePicker.ColumnHeaderView>
        <picker:DateTimePickerColumnHeaderView Background="#D3D3D3">
            <picker:DateTimePickerColumnHeaderView.TextStyle>
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:DateTimePickerColumnHeaderView.TextStyle>
        </picker:DateTimePickerColumnHeaderView>
    </picker:SfDateTimePicker.ColumnHeaderView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.ColumnHeaderView = new DateTimePickerColumnHeaderView()
{
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    },
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Column header customization in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-column-header-customization.png)

### Custom Column Header Appearance using Datatemplate

You can customize the datetime picker column header appearance by using the [Template]() property of the [DateTimePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="datetimepicker" >
    <picker:SfDateTimePicker.ColumnHeaderTemplate>
        <DataTemplate>
            <Grid BackgroundColor="#BB9AB1">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <Label Text="Year" Grid.Column="0" TextColor="White" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
                <Label Text="Month" Grid.Column="1" TextColor="White"  HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
                <Label Text="Day" Grid.Column="2" TextColor="White" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
            </Grid>
        </DataTemplate>
    </picker:SfDateTimePicker.ColumnHeaderTemplate>
</picker:SfDateTimePicker>

{% endhighlight %}

{% endtabs %}

![Set column header template in .NET MAUI Date Time picker.](maui-date-time-picker-column-template.png)

N> If a template is applied to the column header in the [DateTimePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html), the remaining column header properties will not have any effect, except for the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DateTimePickerColumnHeaderView_DividerColor) Property.

### Custom Column Header appearance using DataTemplateSelector

You can customize the datetime picker column header appearance by using the [Template]() property of the [DateTimePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html). The DataTemplateSelector allows you to choose a DataTemplate at runtime based on the value bound to the datetime picker column header. This lets you select a different data template for each column header and customize the appearance of a specific column header based on certain conditions.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<Grid.Resources>
    <DataTemplate x:Key="todayDatesTimeTemplate">
        <Grid Background="LightBlue">
            <Grid.ColumnDefinitions>
                <ColumnDefinition/>
                <ColumnDefinition/>
                <ColumnDefinition/>
            </Grid.ColumnDefinitions>
            <Label Text="Year" Grid.Column="0" TextColor="Red" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
            <Label Text="Month" Grid.Column="1" TextColor="Red"  HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
            <Label Text="Day" Grid.Column="2" TextColor="Red" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
        </Grid>
    </DataTemplate>
    <DataTemplate x:Key="normalDatesTimeTemplate">
        <Grid Background="LightGreen">
            <Grid.ColumnDefinitions>
                <ColumnDefinition/>
                <ColumnDefinition/>
                <ColumnDefinition/>
            </Grid.ColumnDefinitions>
            <Label Text="Year" Grid.Column="0" TextColor="Orange" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
            <Label Text="Month" Grid.Column="1" TextColor="Orange"  HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
            <Label Text="Day" Grid.Column="2" TextColor="Orange" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
            </Grid>
    </DataTemplate>
    <local:DateTimeTemplateSelector x:Key="columnHeaderTemplateSelector" TodayDatesTimeTemplate="{StaticResource todayDatesTimeTemplate}"  NormalDatesTimeTemplate="{StaticResource normalDatesTimeTemplate}"/>
    <picker:SfDateTimePicker x:Name="datetimepicker" ColumnHeaderTemplate="{StaticResource columnHeaderTemplateSelector}">
    </picker:SfDateTimePicker>
</Grid.Resources>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

public class DateTimeTemplateSelector : DataTemplateSelector
{
    public DateTimeTemplateSelector()
    {
    }
    public DataTemplate TodayDatesTimeTemplate { get; set; }
    public DataTemplate NormalDatesTimeTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var Details = item as SfDateTimePicker;
        if (Details != null)
        {
            if (Details.SelectedDate < DateTime.Now.Date)
                return TodayDatesTimeTemplate;
        }
        return NormalDatesTimeTemplate;
    }
}

{% endtabs %}

## Footer Customization

Customize the DateTimePicker footer view by using the `FooterView` property of the `SfDateTimePicker`.

### Set the footer text with Ok and Cancel button customizations

In the SfDateTimePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) properties of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html). It allows you to confirm or cancel the selected date and time. The `OkButtonText` can be enabled using the [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) property in the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html). The default value of the `OkButtonText` property is "OK", and `CancelButtonText` is "Cancel". To enable the footer view, set the `Height` property of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html) to a value greater than 0. The default value of the `Height` property is 0.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="picker" >
    <picker:SfDateTimePicker.FooterView >
        <picker:PickerFooterView Height="40" OkButtonText="Save"
                                 CancelButtonText="Exit"/>
    </picker:SfDateTimePicker.FooterView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.FooterView = new PickerFooterView()
{
    Height = 40,
    OkButtonText = "Save",
    CancelButtonText = "Exit",
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Set Footer text in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-footer-text.png)

### Set the divider color

The SfDateTimePicker control allows you to customize the footer divider color by setting the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_DividerColor) property of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="picker" >
    <picker:SfDateTimePicker.FooterView >
        <picker:PickerFooterView DividerColor="Red" />
    </picker:SfDateTimePicker.FooterView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.FooterView = new PickerFooterView()
{
    DividerColor = Colors.Red,
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Footer divider color in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-footer-divider-color.png)

### Customization of the footer

Customize the footer text style and background color of the `DateTimePicker` using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_TextStyle) and [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Background) properties of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="picker" >
    <picker:SfDateTimePicker.FooterView >
        <picker:PickerFooterView Background="#D3D3D3">
            <picker:PickerFooterView.TextStyle >
                <picker:PickerTextStyle FontSize="15" TextColor="Black" />
            </picker:PickerFooterView.TextStyle>
        </picker:PickerFooterView>
    </picker:SfDateTimePicker.FooterView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.FooterView = new PickerFooterView()
{
    Background = Color.FromArgb("#D3D3D3"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.Black,
        FontSize = 15,
    }
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Footer customization in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-footer-customization.png)

### Custom Footer Header Appearance using Datatemplate

You can customize the datetime picker footer appearance by using the [Template]() property of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="datetimepicker">
    <picker:SfDateTimePicker.FooterTemplate>
        <DataTemplate>
            <Grid BackgroundColor="#BB9AB1">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <Button Grid.Column="0" Text="Decline" TextColor="White" Background="Transparent" />
                <Button Grid.Column="1" Text="Accept" TextColor="White" Background="Transparent" />
            </Grid>
        </DataTemplate>
    </picker:SfDateTimePicker.FooterTemplate>
</picker:SfDateTimePicker>

{% endhighlight %}

{% endtabs %}

![Footer template in .NET MAUI Date Time picker.](maui-date-time-footer-template.png)

N> If a template is applied to the footer in the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html), the remaining footer properties will not have any effect, except for the [DividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_DividerColor) Property.

### Custom Footer appearance using DataTemplateSelector

You can customize the datetime picker footer appearance by using the [Template]() property of the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html). The DataTemplateSelector allows you to choose a DataTemplate at runtime based on the value bound to the datetime picker footer. This lets you apply a custom data template to the footer and customize its appearance based on specific conditions.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<Grid.Resources>
    <DataTemplate x:Key="todayDatesTimeTemplate">
        <Grid Background="LightBlue">
            <Grid.ColumnDefinitions>
                <ColumnDefinition/>
                <ColumnDefinition/>
            </Grid.ColumnDefinitions>
            <Button Grid.Column="0" Text="Decline" TextColor="Red" Background="Transparent" />
            <Button Grid.Column="1" Text="Accept" TextColor="Red" Background="Transparent" />
        </Grid>
    </DataTemplate>
    <DataTemplate x:Key="normalDatesTimeTemplate">
        <Grid Background="LightGreen">
            <Grid.ColumnDefinitions>
                <ColumnDefinition/>
                <ColumnDefinition/>
            </Grid.ColumnDefinitions>
            <Button Grid.Column="0" Text="Decline" TextColor="Orange" Background="Transparent" />
            <Button Grid.Column="1" Text="Accept" TextColor="Orange" Background="Transparent" />
        </Grid>
    </DataTemplate>
    <local:DateTimeTemplateSelector x:Key="footerTemplateSelector" TodayDatesTimeTemplate="{StaticResource todayDatesTimeTemplate}"  NormalDatesTimeTemplate="{StaticResource normalDatesTimeTemplate}"/>
    <picker:SfDateTimePicker x:Name="datetimepicker" FooterTemplate="{StaticResource footerTemplateSelector}">
    </picker:SfDateTimePicker>
</Grid.Resources>

{% endhighlight %}

{% highlight c# tabtitle="C#" %}

public class DateTimeTemplateSelector : DataTemplateSelector
{
    public DateTimeTemplateSelector()
    {
    }
    public DataTemplate TodayDatesTimeTemplate { get; set; }
    public DataTemplate NormalDatesTimeTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var Details = item as SfDateTimePicker;
        if (Details != null)
        {
            if (Details.SelectedDate < DateTime.Now.Date)
                return TodayDatesTimeTemplate;
        }
        return NormalDatesTimeTemplate;
    }
}

{% endtabs %}

## Selection View Customization

Customize the DateTimePicker selection view by using the `SelectionView` property of the `SfDateTimePicker`.

### Set the selection view

In the SfDateTimePicker control, the corner radius, stroke , and padding can be customized by setting the [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_CornerRadius), [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Stroke), and [Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html#Syncfusion_Maui_Picker_PickerSelectionView_Padding) properties in the [PickerSelectionView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="picker" >
    <picker:SfDateTimePicker.SelectionView >
        <picker:PickerSelectionView CornerRadius="10" Stroke="#36454F" Padding="10, 5, 10, 5" Background="#808080" />
    </picker:SfDateTimePicker.SelectionView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.SelectionView = new PickerSelectionView()
{
    CornerRadius = 10,
    Stroke = Color.FromArgb("#36454F"),
    Padding = new Thickness(10, 5, 10, 5),
    Background = Color.FromArgb("#808080"),
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Set selection shape in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-set-selection-shape.png)

### Customization of the selected item

Customize the selected view text style of the `DateTimePicker` using the [SelectedTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle) property of the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="picker" >
    <picker:SfDateTimePicker.SelectedTextStyle >
        <picker:PickerTextStyle FontSize="15" TextColor="White"/>
    </picker:SfDateTimePicker.SelectedTextStyle>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.SelectedTextStyle = new PickerTextStyle()
{
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    }
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Selected item customization in .NET MAUI DateTimePicker.](images/customizations/maui-date-time-picker-selected-item-customization.png)

## Column divider color

Customize the column divider color using the [ColumnDividerColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor) property in [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<picker:SfDateTimePicker x:Name="picker"
                         ColumnDividerColor="Red">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.ColumnDividerColor = Colors.Red;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![DateTimePicker column divider color in .NET MAUI DateTimePicker.](images/customizations/maui-time-picker-column-divider-color.png)