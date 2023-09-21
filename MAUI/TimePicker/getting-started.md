---
layout: post
title: Getting started with .NET MAUI Time Picker control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Getting started with .NET MAUI Time Picker (SfTimePicker)
This section explains how to add the Time Picker control. It covers only the basic features needed to get started with the Syncfusion Time Picker.

## Creating an application using the .NET MAUI Time Picker

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfTimePicker` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker), then install it.

N> [Syncfusion.Maui.Popup](https://www.nuget.org/packages/Syncfusion.Maui.Popup) is a dependent package for `SfTimePicker`. To add [SfPopup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html) to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Popup`, then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Picker` in XAML or C# code.

4. Initialize `SfTimePicker.`

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <picker:SfTimePicker />
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
        SfTimePicker picker = new SfTimePicker();
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

## Set header to the Time Picker

The SfTimePicker control allows you to add the header text by setting the [Text] property in the [PickerHeaderView]. Enable the header view by setting the [Height] property in the [PickerHeaderView].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfTimePicker x:Name="picker">
    <picker:SfTimePicker.HeaderView>
        <picker:PickerHeaderView Text="Time Picker" Height="40" />
    </picker:SfTimePicker.HeaderView>
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4 5" %}

SfTimePicker picker = new SfTimePicker();
picker.HeaderView = new PickerHeaderView()
{
    Text = "Time Picker",
    Height = 40,
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

## Set footer to the Time Picker

In the SfTimePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText] and [CancelButtonText] properties in the [PickerFooterView]. It allows you to confirm or cancel the selected time. The `OkButtonText` can be enabled using the [ShowOkButton] property in the [PickerFooterView].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfTimePicker x:Name="Picker">
    <picker:SfTimePicker.FooterView>
        <picker:PickerFooterView ShowOkButton="True" Height="40" />
    </picker:SfTimePicker.FooterView>
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4 5" %}

SfTimePicker picker = new SfTimePicker();
picker.FooterView= new PickerFooterView()
{  
    ShowOkButton = true,
    Height = 40,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set height and width to the Time Picker

The SfTimePicker control allows you to change the height and width by using the [HeightRequest] and [WidthRequest] properties in the [SfTimePicker].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<picker:SfTimePicker x:Name="Picker" 
                    HeightRequest="240" 
                    WidthRequest="300">
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfTimePicker picker = new SfTimePicker()
{
    HeightRequest = 240,
    WidthRequest = 300,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set selected time to the Time Picker

The SfTimePicker control allows you to select the time using the [SelectedTime] property in the [SfTimePicker]. The default value of the `SelectedTime` is the current time.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker" 
                     SelectedTime="07:22:01">
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker picker = new SfTimePicker()
{
    SelectedTime = new TimeSpan(07, 22, 01),
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}