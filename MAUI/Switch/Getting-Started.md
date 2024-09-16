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

This section guides you through setting up and configuring a [.NET MAUI Switch control](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) in your .NET MAUI application. Follow the steps below to add a basic [.NET MAUI Switch control](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) to your project.



## Prerequisites

Before proceeding, ensure the following are in place:
1. Install .NET 7 SDK or later.

2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as per the instructions provided [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

To get start quickly with our [.NET MAUI Switch control](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html), you can check the below video.

{% youtube "https://www.youtube.com/watch?v=BJDUlLdsQyo" %}

## Step 1: Create a New MAUI Project

1. Open Visual Studio or VS Code.
2. Go to File > New > Project and choose the .NET MAUI App template.
3. Name the project and choose a location, then click Create.

## Step 2: Install the Syncfusion MAUI Buttons NuGet Package

1. In Solution Explorer, right-click the project and choose Manage NuGet Packages.
2. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.html) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace SwitchSample
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

## Step 4: Adding the namespace

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample, to initialize the .NET MAUI Switch control.

{% tabs %}
{% highlight xaml %}

	xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Buttons;

{% endhighlight %}
{% endtabs %}

## Step 5: Adding the .NET MAUI Switch control

Now, add the [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch x:Name="sfSwitch" />
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();

{% endhighlight %}

{% endtabs %}

![SfSwitch](images/getting-started/SfSwitch.png)

## Performing an action based on switch state

In the [.NET MAUI SfSwitch control](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html), you can switch between "On" and "Off" states. When the state changes,the [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) and [StateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html) events are triggered. These events enable you to perform specific actions depending on the current state of the switch. The [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) event also allows you to cancel the transition to a new state if needed.

The following code example displays a message box when the .NET MAUI Switch is switched to the off state after the work is completed.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch x:Name="sfSwitch" StateChanged="SfSwitch_StateChanged"/>
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanged+= SfSwitch_StateChanged;

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