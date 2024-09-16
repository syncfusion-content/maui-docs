---
layout: post
title: Getting Started with .NET MAUI Busy Indicator control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control, its elements, and more.
platform: maui
control: BusyIndicator
documentation: ug
keywords : .net maui busy indicator, maui busy indicator, .net maui activity indicator, maui activity indicator, .net maui loading indicator, maui loading indicator.
---

# Getting Started with .NET MAUI Busy Indicator

This section guides you through setting up and configuring a [Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add a basic Busy Indicator to your project.

To get start quickly with our .NET MAUI BusyIndicator, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=EY1y5PUBkCw" %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

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

## Step 2: Install the Syncfusion MAUI Core NuGet Package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

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

## Step 4: Add a Basic Busy Indicator

1. To initialize the control, import the Core namespace into your code.

2. Initialize [SfBusyIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1)

{% tabs %}

{% highlight xaml %}

<ContentPage 
            ...
            xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <ContentPage.Content> 
	 	<core:SfBusyIndicator x:Name="busyIndicator"
                          IsRunning = "True" />
	</ContentPage.Content> 
</ContentPage>
	
{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace BusyIndicatorSample   
{  
	public partial class MainPage : ContentPage                  
	{ 
	    SfEffectsView effectsView;

		public MainPage()   
		{   
			InitializeComponent();       
			SfBusyIndicator busyIndicator = new SfBusyIndicator(){IsRunning = true};
            Content = busyIndicator;   
		}  
	}  
}  

{% endhighlight %}

{% endtabs %}

## Step 5: Setting Animation Type in .NET MAUI Busy Indicator

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

