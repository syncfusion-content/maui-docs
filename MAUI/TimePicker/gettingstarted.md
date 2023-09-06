---
layout: post
title: Getting Started with .NET MAUI TimePicker control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI TimePicker (SfTimePicker) control, its elements and more.
platform: maui
control: SfTimePicker
documentation: ug
---


# Getting Started with .NET MAUI TimePicker (SfTimePicker)

This section explains how to add the TimePicker control. This section covers only the basic features needed to get started with Syncfusion TimePicker.

## Creating an application using the .NET MAUI Time Picker

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfPicker` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Picker](), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Picker` in XAML or C# code.

4. Initialize `SfTimePicker.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <syncfusion:SfTimePicker />
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
        SfTimePicker TimePicker = new SfTimePicker();
        this.Content = TimePicker;
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

### Creating a simple SfTimePicker

The [`SfTimePicker`]() control is entirely configured in C# code or in XAML markup. The following steps explain how to create a [`SfTimePicker`]() and configure its elements.

### Adding namespace for referred assemblies

{% tabs %}
{% highlight xaml %}
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
{% endhighlight %}
{% highlight c# %}
using Syncfusion.Maui.Picker;
{% endhighlight %}
{% endtabs %}

### Referring SfTimePicker control with declared suffix name for namespace

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker />
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker TimePicker = new SfTimePicker();
            this.Content = TimePicker;
        }
    }
}

{% endhighlight %}
{% endtabs %}

### Selected Time

The Time can be selected by using the [`SelectedTime`]() property. The default value of [`SelectedTime`]() is current Time.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker"
                                 SelectedTime="2:15:26"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker TimePicker = new SfTimePicker()
            {
                SelectedTime = new TimeSpan(2, 15, 26)
            };

            this.Content = TimePicker;
        }
    }
}

{% endhighlight %}
{% endtabs %}


You can find the complete getting started sample here: [GettingStarted]()