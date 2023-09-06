---
layout: post
title: Getting started with MAUI DatePicker control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI DatePicker (SfDatePicker) control and its basic features.
platform: maui
control: SfCalendar
documentation: ug
---

# Getting started with .NET MAUI DatePicker (SfDatePicker)
This section explains how to add the DatePicker control. This section covers only the basic features needed to get started with Syncfusion DatePicker.

## Creating an application using the .NET MAUI DatePicker

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfDatePicker` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Picker` in XAML or C# code.

4. Initialize `SfDatePicker.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <picker:SfDatePicker />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 10" %}

using Syncfusion.Maui.Picker;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDatePicker picker = new SfDatePicker();
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Segoe-mdl2.ttf", "SegoeMDL2");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Set header to the DatePicker

The SfDatePicker control allows you to the add the header text by setting the [Text] property in the [PickerHeaderView]. To enable the header view by setting the [Height] property in [PickerHeaderView] and you can cutomize the header text and its background color.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfDatePicker x:Name="picker">
    <picker:SfDatePicker.HeaderView>
        <picker:PickerHeaderView Text="Date Picker" Height="40" Background="#6750A4">
            <picker:PickerHeaderView.TextStyle>
                <picker:PickerTextStyle TextColor="White" FontSize="15" />
            </picker:PickerHeaderView.TextStyle>
        </picker:PickerHeaderView>
    </picker:SfDatePicker.HeaderView>
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfDatePicker picker = new SfDatePicker();
picker.HeaderView = new PickerHeaderView()
{
    Text = "Date Format",
    Height = 40,
    Background = Color.FromRgba("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    },
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

## Set column header to the DatePicker

The SfDatePicker control allows you to the customize the column header text by setting the [YearHeaderText], [MonthHeaderText] and [DayHeaderText] property in the [DatePickerColumnHeaderView]. The default value of [YearHeaderText] is "Year", [MonthHeaderText] is Month and [DayHeaderText] is Day. You can customize the height of the column header by setting the [Height] property in [DatePickerColumnHeaderView], its text style and background color are customizable.

{% tabs %}  
{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfDatePicker x:Name="Picker">
   <picker:SfDatePicker.ColumnHeaderView>
        <picker:DatePickerColumnHeaderView YearHeaderText="Year text" MonthHeaderText="Month text"
            DayHeaderText="Day text" Height="40" Background="#6750A4">
            <picker:DatePickerColumnHeaderView.TextStyle>
                <picker:PickerTextStyle TextColor="White" FontSize="15" />
            </picker:DatePickerColumnHeaderView.TextStyle>
        </picker:DatePickerColumnHeaderView>
    </picker:SfDatePicker.ColumnHeaderView>
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfDatePicker picker = new SfDatePicker();
    picker.ColumnHeaderView= new DatePickerColumnHeaderView()
    {
        YearHeaderText = "Year text",
        MonthHeaderText = "Month text",
        DayHeaderText = "Day text",
        Height = 40,
        Background = Color.FromRgba("#6750A4"),
        TextStyle = new PickerTextStyle()
        {
            TextColor = Colors.White,
            FontSize = 15,
        },
    };

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set footer to the DatePicker

In SfDatePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText] and [CancelButtonText] property in the [PickerFooterView]. It allows you to confirm or cancel the selected date.  The `OkButtonText` can be enabled by using the [ShowOkButton] property in [PickerFooterView]. You can customize the height of the footer view by setting the [Height] property in [PickerFooterView], its text style and background are customizable.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfDatePicker x:Name="Picker">
    <picker:SfDatePicker.FooterView>
        <picker:PickerFooterView ShowOkButton="True" OkButtonText="OK" CancelButtonText="Cancel" Height="40" Background="#6750A4">
            <picker:PickerFooterView.TextStyle>
                <picker:PickerTextStyle TextColor="White" FontSize="15" />
            </picker:PickerFooterView.TextStyle>
        </picker:PickerFooterView>
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfDatePicker picker = new SfDatePicker();
picker.FooterView= new PickerFooterView()
{  
    ShowOkButton = true,
    OkButtonText = "OK",
    CancelButtonText = "Cancel",
    Height = 40,
    Background = Color.FromRgba("#6750A4"),
    TextStyle = new PickerTextStyle()
    {
        TextColor = Colors.White,
        FontSize = 15,
    },
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}