---
layout: post
title: Getting started with .NET MAUI Date Picker control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Getting started with .NET MAUI Date Picker (SfDatePicker)
This section explains how to add the Date Picker control. This section covers only the basic features needed to get started with Syncfusion Date Picker.

## Creating an application using the .NET MAUI Date Picker

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfDatePicker` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Picker` in XAML or C# code.

4. Initialize `SfDatePicker.`

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <picker:SfDatePicker />
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

## Set header to the Date Picker

The SfDatePicker control allows you to add the header text by setting the [Text] property in the [PickerHeaderView]. To enable the header view by setting the [Height] property in [PickerHeaderView].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfDatePicker x:Name="picker">
    <picker:SfDatePicker.HeaderView>
        <picker:PickerHeaderView Text="Date Picker" Height="40" />
    </picker:SfDatePicker.HeaderView>
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4 5" %}

SfDatePicker picker = new SfDatePicker();
picker.HeaderView = new PickerHeaderView()
{
    Text = "Date Picker",
    Height = 40,
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

## Set footer to the Date Picker

In SfDatePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText] and [CancelButtonText] property in the [PickerFooterView]. It allows you to confirm or cancel the selected date.  The `OkButtonText` can be enabled by using the [ShowOkButton] property in [PickerFooterView].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfDatePicker x:Name="Picker">
    <picker:SfDatePicker.FooterView>
        <picker:PickerFooterView ShowOkButton="True" Height="40" />
    </picker:SfDatePicker.FooterView>
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4 5" %}

SfDatePicker picker = new SfDatePicker();
picker.FooterView= new PickerFooterView()
{  
    ShowOkButton = true,
    Height = 40,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set height and width to the Date Picker

The SfDatePicker control allows you to the change the height and the width by using the [HeightRequest] and [WidthRequest] property in [SfDatePicker].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines=" 2 3" %}

<picker:SfDatePicker x:Name="Picker" 
                    HeightRequest="280" 
                    WidthRequest="300">
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfDatePicker picker = new SfDatePicker()
{
    HeightRequest = 280,
    WidthRequest = 300,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set selected date to the Date Picker

The SfDatePicker control allows you to select the date by using the [SelectedDate] property in [SfDatePicker]. The default value of the `SelectedDate` is current date.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker" 
                     SelectedDate="9/7/2023">
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker picker = new SfDatePicker()
{
    SelectedDate = new DateTime(2023, 9, 7).Date,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}