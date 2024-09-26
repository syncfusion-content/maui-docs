---
layout: post
title: Getting Started with .NET MAUI Digital Gauge control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Digital Gauge (SfDigitalGauge) control, its elements and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---
# Getting Started with the .NET MAUI DigitalGauge

This section explains how to add the [.NET MAUI DigitalGauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge) control. This section covers only the basic features needed to get started with Syncfusion DigitalGauge. Follow the steps below to add .NET MAUI DigitalGauge control to your project.

To get start quickly with our .NET MAUI DigitalGauge, you can check the below video.

{% youtube
"youtube:https://youtu.be/kYZtmp3Mtkk?si=FUhFxyrNdpzRbxxC"%}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New MAUI Project

### Visual Studio

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press enter.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion MAUI DigitalGauge NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion core.

{% highlight c# tabtitle="~/MauiProgram.cs" hl_lines="17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace GaugeMauiSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %} 

## Step 4: Add .NET MAUI DigitalGauge control
1. To initialize the control, import the `Syncfusion.Maui.Gauges` namespace into your code.
2. Initialize [SfDigitalGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html).

{% tabs %}

{% highlight xaml %}
<ContentPage
. . .
   xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"

   <gauge:SfDigitalGauge/> 
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDigitalGauge digitalGauge = new SfDigitalGauge();
        this.Content = digitalGauge;
    }
}


{% endhighlight %}

{% endtabs %}


## Step 3: Display a value in .NET MAUI DigitalGauge

In [.NET MAUI DigitalGauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge) user can display value using [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_Text) property.

{% tabs %}

{% highlight xaml %}

   <gauge:SfDigitalGauge Text="SYNCFUSION"/> 

{% endhighlight %}

{% highlight c# %}

        SfDigitalGauge digitalGauge = new SfDigitalGauge();

        digital.Text = "SYNCFUSION";

        this.Content = digitalGauge;
 
{% endhighlight %}

{% endtabs %}

![getting-started](Images\getting-started.png)

