---
layout: post
title: Getting started with .NET MAUI Time Picker control | Syncfusion<sup>&reg;</sup>
description: Learn about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Getting started with .NET MAUI Time Picker
This section explains how to add the [.NET MAUI Time Picker](https://www.syncfusion.com/maui-controls/maui-timepicker) control. It covers only the basic features needed to get started with the Syncfusion Time Picker. Follow the steps below to add a .NET MAUI Time picker to your project.

To get start quickly with our .NET MAUI Time Picker, you can check the below video.

{% youtube "youtube:https://youtu.be/m3Gn6S_8Oeo?si=AK9iY1m8G8sQ0zsA" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later).

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Picker NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI Time picker control

1. To initialize the control, import the `Syncfusion.Maui.Picker` namespace into your code.
2. Initialize [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

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

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Picker NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI Time picker control

1. To initialize the control, import the `Syncfusion.Maui.Picker` namespace into your code.
2. Initialize [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

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

{% endtabcontent %}
{% endtabcontents %}

## Set header to the Time Picker

The SfTimePicker control allows you to add the header text by setting the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Text) property in the [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html). Enable the header view by setting the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_HeightProperty) property in the [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html).

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

   ![Set header view in .NET MAUI Time picker.](images/getting-started/maui-time-picker-set-header-view.png)

## Set footer to the Time Picker

In the SfTimePicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) properties in the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html). It allows you to confirm or cancel the selected time. The `OkButtonText` can be enabled using the [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) property in the [PickerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfTimePicker x:Name="picker">
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

   ![Set footer view in .NET MAUI Time picker.](images/getting-started/maui-time-picker-set-footer-view.png)

## Set height and width to the Time Picker

The SfTimePicker control allows you to change the height and width by using the [HeightRequest] and [WidthRequest] properties in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<picker:SfTimePicker x:Name="picker" 
                    HeightRequest="280" 
                    WidthRequest="300">
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfTimePicker picker = new SfTimePicker()
{
    HeightRequest = 280,
    WidthRequest = 300,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

   ![Set height and width in .NET MAUI Time picker.](images/getting-started/maui-time-picker-set-height-and-width.png)

## Set selected time to the Time Picker

The SfTimePicker control allows you to select the time using the [SelectedTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectedTime) property in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html). The default value of the `SelectedTime` is the current time.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker" 
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

   ![Set Selected time in .NET MAUI Time picker.](images/getting-started/maui-time-picker-set-selected-time.png)

## Clear selection

The .NET MAUI TimePicker provides clear selection support, allowing you to clear the selected time by setting the `SelectedTime` property to `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfTimePicker x:Name="picker" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.picker.SelectedTime = null;

{% endhighlight %}  
{% endtabs %}