---
layout: post
title: Getting Started with .NET MAUI Switch | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI Switch (SfSwitch) control, its elements, and more.
platform: maui
control: SfSwitch
documentation: ug
keywords : .net maui switch, maui switch, .net maui switch contrl, maui switch control.
---

# Getting Started with .NET MAUI Switch

This section guides you through setting up and configuring a [Switch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) in your .NET MAUI application. Follow the steps below to add a basic [Switch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) to your project.

To quickly get started with the .NET MAUI Switch, watch this video.

{% youtube "https://www.youtube.com/watch?v=BJDUlLdsQyo" %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
1. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio Code. For Visual Studio Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New MAUI Project

### Visual Studio

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
1. Name the project and choose a location. Then, click **Next.**
1. Select the .NET framework version and click **Create.**

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
1. Choose the **.NET MAUI App** template.
1. Select the project location, type the project name and press **Enter.**
1. Then choose **Create project.**

## Step 2: Install the Syncfusion MAUI Buttons NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
1. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons/) and install the latest version.
1. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace SwitchGettingStarted
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

## Step 4: Adding the .NET MAUI Switch 

1. To initialize the control, import the Buttons namespace into your code.
1. Initialize [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html).

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSwitch x:Name="sfSwitch" />
</ContentPage>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Buttons;
    namespace SwitchGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfSwitch sfSwitch = new SfSwitch();
                this.Content= sfSwitch;
            }
        }   
    }

{% endhighlight %}

{% endtabs %}

![SfSwitch](images/getting-started/SfSwitch.png)

## Performing an action based on state

You can switch between states in the .NET MAUI Switch control. When the state changes,the [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) and [StateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html) events are triggered. These events enable you to perform specific actions depending on the current state of the switch. The [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) event also allows you to cancel the transition to a new state if needed.

The following code example displays a message box when the .NET MAUI Switch is switched to the off state after the work is completed.

{% tabs %}

{% highlight xaml %}

<buttons:SfSwitch x:Name="sfSwitch" StateChanged="SfSwitch_StateChanged"/>
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanged+= SfSwitch_StateChanged;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
private void SfSwitch_StateChanged(object sender, SwitchStateChangedEventArgs e)
{
     DisplayAlert("Message", "SUCCESS", "OK");
}

{% endhighlight %}

{% endtabs %}

N> Find the complete getting started sample of the .NET MAUI Switch from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfSwitch)

N> You can refer to our [.NET MAUI Switch](https://www.syncfusion.com/maui-controls/maui-switch) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Switch Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Buttons/SampleBrowser.Maui.Buttons/Samples/Switch) that shows you how to render the Switch in .NET MAUI.