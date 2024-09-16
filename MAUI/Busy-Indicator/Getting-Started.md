---
layout: post
title: Getting Started with .NET MAUI Busy Indicator control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control, its elements, and more.
platform: maui
control: BusyIndicator
documentation: ug
keywords : .net maui busy indicator, maui busy indicator, .net maui activity indicator, maui activity indicator, .net maui loading indicator, maui loading indicator.
---

# Getting Started with .NET MAUI Busy Indicator (SfBusyIndicator)

## Getting started with .NET MAUI Busy Indicator
This section guides you through setting up and configuring a
[.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1)
in your .NET MAUI application. Follow the steps below to add a basic
[.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1)
to your project.

## Prerequisites
Before proceeding, ensure the following are in place:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://github.com/dotnet/maui/wiki/).

{% youtube "https://www.youtube.com/watch?v=EY1y5PUBkCw" %}

## Step 1: Create a New MAUI Project
1. Open Visual Studio or VS Code.
2. Go to **File** > **New** > **Project** and choose the .NET MAUI App template.
3. Name the project and choose a location, then click Create.

## Step 2: Install the Syncfusion MAUI Core NuGet Package
1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Handler registration 

In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace BusyIndicatorSample
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

## Step 4: Create a Simple .NET MAUI Busy Indicator

The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) control is configured entirely in C# code or by using XAML markup. The following steps explain how to create a [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) (SfBusyIndicator) and configure its elements.

### Adding the .NET MAUI Busy Indicator control

Open the `MainPage.xaml` file, and define the `SfBusyIndicator` control with a standardized instance name as follows:

{% tabs %}

{% highlight xaml %}

    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}`

{% tabs %}

{% highlight xaml %}

<ContentPage.Content>    
    <core:SfBusyIndicator x:Name="busyIndicator"
                          IsRunning = "True" />
</ContentPage.Content>


{% endhighlight %}

{% highlight c# %}
          
SfBusyIndicator busyIndicator = new SfBusyIndicator(){IsRunning = true}; 
Content = busyIndicator;  

{% endhighlight %}

{% endtabs %}

## Customizing the Busy Indicator

[.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) provides some predefined animation types like Cupertino, LinearMaterial, and CircularMaterial. Users can select any one of the animation types using the [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) property.

The following example depicts the CircularMaterial type animation of .NET  MAUI Busy Indicator.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
        xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
        xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
        x:Class="BusyIndicatorSample.MainPage">

    <ContentPage.Content>
        <core:SfBusyIndicator x:Name="busyIndicator"
                              IsRunning="True"
                              AnimationType="CircularMaterial" />
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace BusyIndicatorSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfBusyIndicator busyIndicator = new SfBusyIndicator()
            {
                IsRunning = true,
                AnimationType = AnimationType.CircularMaterial;
            };
        this.Content = busyIndicator;
        }
    }
}

{% endhighlight %}

{% endtabs %}

The following gif image illustrates the result of the above code.

![Getting Started](Images/GettingStarted/CircularMaterial.gif)

You can find the complete getting started sample of .NET MAUI Busy Indicator from this [link.](https://github.com/SyncfusionExamples/maui-busyindicator-samples)

