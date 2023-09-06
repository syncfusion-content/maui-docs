---
layout: post
title: Getting Started with .NET MAUI DatePicker control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI DatePicker (SfDatePicker) control, its elements and more.
platform: maui
control: SfDatePicker
documentation: ug
---


# Getting Started with .NET MAUI DatePicker (SfDatePicker)

This section explains how to add the DatePicker control. This section covers only the basic features needed to get started with Syncfusion DatePicker.

## Creating an application using the .NET MAUI Date Picker

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfPicker` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Picker](), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Picker` in XAML or C# code.

4. Initialize `SfDatePicker.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfDatePicker />
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
        SfDatePicker datePicker = new SfDatePicker();
        this.Content = datePicker;
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

### Creating a simple SfDatePicker

The [`SfDatePicker`]() control is entirely configured in C# code or in XAML markup. The following steps explain how to create a [`SfDatePicker`]() and configure its elements.

### Adding namespace for referred assemblies

{% tabs %}
{% highlight xaml %}
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
{% endhighlight %}
{% highlight c# %}
using Syncfusion.Maui.Picker;
{% endhighlight %}
{% endtabs %}

### Referring SfDatePicker control with declared suffix name for namespace

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker />
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfDatePicker datePicker = new SfDatePicker();
            this.Content = datePicker;
        }
    }
}

{% endhighlight %}
{% endtabs %}

### Selected Date

The date can be selected by using the [`SelectedDate`]() property. The default value of [`SelectedDate`]() is current date.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker"
                                 SelectedDate="09/05/2023"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfDatePicker datePicker = new SfDatePicker()
            {
                SelectedDate = new System.DateTime(2023, 09, 05)
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}
{% endtabs %}


You can find the complete getting started sample here: [GettingStarted]()