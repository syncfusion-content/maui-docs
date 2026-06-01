---
layout: post
title: Getting Started with .NET MAUI Digital Gauge control | Syncfusion
description: Learn here about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Digital Gauge (SfDigitalGauge) control, its elements and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---
# Getting Started with the .NET MAUI DigitalGauge

This section explains how to add the [.NET MAUI DigitalGauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge) control. This section covers only the basic features needed to get started with Syncfusion<sup>&reg;</sup> DigitalGauge. Follow the steps below to add .NET MAUI DigitalGauge control to your project.

To get start quickly with our .NET MAUI DigitalGauge, you can check the below video.

{% youtube
"youtube:https://youtu.be/kYZtmp3Mtkk?si=FUhFxyrNdpzRbxxC"%}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install .NET SDK
  - [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later must be installed.
2. Set up a .NET MAUI Environment with Visual Studio. Supported Visual Studio Versions:
  - Visual Studio 2022: Version 17.13 or later (e.g., 17.14.7) for .NET 9 development.
  - Visual Studio 2026: Required for .NET 10 development.

## Step 1: Create a New MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> MAUI Gauges NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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


## Step 5: Display a value in .NET MAUI DigitalGauge

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

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press enter.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> MAUI DigitalGauge NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Gauges` to install the Syncfusion<sup>®</sup> .NET MAUI Gauges NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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


## Step 5: Display a value in .NET MAUI DigitalGauge

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

{% endtabcontent %}


{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI DigitalGauge NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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
{% endtabcontent %}
{% endtabcontents %}

![getting-started](Images\getting-started.png)

N> You can refer to our [.NET MAUI Digital Gauge](https://www.syncfusion.com/maui-controls/maui-digital-gauge) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Digital Gauge Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Gauges/SampleBrowser.Maui.Gauges/Samples/DigitalGauge) that shows you how to render the Digital Gauge in .NET MAUI.