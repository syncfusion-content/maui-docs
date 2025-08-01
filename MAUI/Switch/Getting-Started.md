---
layout: post
title: Getting Started with .NET MAUI Switch | Syncfusion®
description: Learn about getting started with the Syncfusion® .NET MAUI Switch (SfSwitch) control, its elements, and more.
platform: MAUI
control: SfSwitch
documentation: UG
keywords : .net maui switch, maui switch, .net maui switch control, maui switch control.  
---

# Getting Started with .NET MAUI Switch

This section guides you through setting up and configuring a [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) in your .NET MAUI application. Follow the steps below to add a basic [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) to your project.

To quickly get started with the .NET MAUI Switch, watch this video.

{% youtube "https://www.youtube.com/watch?v=BJDUlLdsQyo" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and select the **.NET MAUI App** template.
2. Name the project, choose a location, and click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Buttons NuGet package

1. In **Solution Explorer**, right-click the project and select **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons/) and install the latest version.
3. Ensure all necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls in .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
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

1. Import the Buttons namespace into your code to initialize the control.
2. Initialize [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html).

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

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Buttons NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Buttons` to install the Syncfusion<sup>®</sup> .NET MAUI Buttons package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
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

1. Import the Buttons namespace into your code to initialize the control.
2. Initialize [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html).

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

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Buttons NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="2 13" %}
using Microsoft.Extensions.Logging;
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

1. Import the Buttons namespace into your code to initialize the control.
2. Initialize [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html).

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

{% endtabcontent %}
{% endtabcontents %}

## Performing an action based on state

You can switch between states in the .NET MAUI Switch control. When the state changes,the [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) and [StateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html) events are triggered. These events allow you to perform specific actions depending on the current state of the Switch. The [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) event also allows you to cancel the transition to a new state if needed.

The following code example displays a message box when the .NET MAUI Switch is switched to the off state after the work is completed.

{% tabs %}

{% highlight xaml %}

<buttons:SfSwitch x:Name="sfSwitch" StateChanged="OnSwitchStateChanged"/>
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanged+= OnSwitchStateChanged;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
private void OnSwitchStateChanged(object sender, SwitchStateChangedEventArgs e)
{
     DisplayAlert("Message", "SUCCESS", "OK");
}

{% endhighlight %}

{% endtabs %}

N> Find the complete getting started sample of the .NET MAUI Switch from this [link](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfSwitch).

N> Refer to our [.NET MAUI Switch](https://www.syncfusion.com/maui-controls/maui-switch) feature tour page for its groundbreaking feature representations. Explore our [.NET MAUI Switch example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Buttons/SampleBrowser.Maui.Buttons/Samples/Switch) for rendering the .NET MAUI Switch.