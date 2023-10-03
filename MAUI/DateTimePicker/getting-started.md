---
layout: post
title: Getting started with .NET MAUI Date Time Picker control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Getting started with .NET MAUI Date Time Picker (SfDateTimePicker)
This section explains how to add the Date Time Picker control. It covers only the basic features needed to get started with Syncfusion Date Time Picker.

## Creating an application using the .NET MAUI Date Time Picker

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfDateTimePicker` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker), then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Picker` in XAML or C# code.

4. Initialize `SfDateTimePicker.`

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <picker:SfDateTimePicker />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Picker;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
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

## Date Time Picker header

The [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html) control provides the default header which shows the current selected date and selected time.

## Set footer to the Date Time Picker

In the SfDateTimePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) properties in the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html). It allows you to confirm or cancel the selected date and time. The `OkButtonText` can be enabled using the [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) property in the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfDateTimePicker x:Name="Picker">
    <picker:SfDateTimePicker.FooterView>
        <picker:PickerFooterView ShowOkButton="True" Height="40" />
    </picker:SfDateTimePicker.FooterView>
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4 5" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.FooterView= new PickerFooterView()
{  
    ShowOkButton = true,
    Height = 40,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set height and width to the Date Time Picker

The SfDateTimePicker control allows you to change the height and width by using the `HeightRequest` and `WidthRequest` properties in the `SfDateTimePicker`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2 3" %}

<picker:SfDateTimePicker x:Name="Picker" 
                    HeightRequest="280" 
                    WidthRequest="300">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfDateTimePicker picker = new SfDateTimePicker()
{
    HeightRequest = 280,
    WidthRequest = 300,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set selected date and selected time to the Date Time Picker

The SfDateTimePicker control allows you to select the date and time by using the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate) property in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). The default value of the `SelectedDate` is the current date and time.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="Picker" 
                         SelectedDate="9/7/2023 10:15:22">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfDateTimePicker picker = new SfDateTimePicker()
{
    SelectedDate = new DateTime(2023, 09, 07, 10, 15, 22),
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}