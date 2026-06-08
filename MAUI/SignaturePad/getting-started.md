---
layout: post
title: Getting started with .NET MAUI SignaturePad control | Syncfusion®
description: Learn here about getting started with .NET MAUI SignaturePad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Getting Started with .NET MAUI SignaturePad

This section guides you through setting up and configuring a [SignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) in your .NET MAUI application. Follow the steps below to add a basic SignaturePad to your project.

To quickly get started with the .NET MAUI SignaturePad, watch this video.

{% youtube "https://www.youtube.com/watch?v=gV2stNPCgYo" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

 [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 12" %} 
using Syncfusion.Maui.Core.Hosting;

namespace SignaturePadGettingStarted
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

## Step 4: Add a Basic SignaturePad

Import the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) namespace and initialize the SignaturePad as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <signaturePad:SfSignaturePad />
</ContentPage>

{% endhighlight %}

{% highlight C# %}
using Syncfusion.Maui.SignaturePad;

namespace SignaturePadGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Creating a SignaturePad control.
            SfSignaturePad signaturePad = new SfSignaturePad();
            this.Content = signaturePad;
        }
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a New .NET MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.SignaturePad` to install the Syncfusion<sup>®</sup> .NET MAUI SignaturePad package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

 [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 12" %} 
using Syncfusion.Maui.Core.Hosting;

namespace SignaturePadGettingStarted
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

## Step 4: Add a Basic SignaturePad

Import the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) namespace and initialize the SignaturePad as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <signaturePad:SfSignaturePad />
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.SignaturePad;

namespace SignaturePadGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Creating a SignaturePad control.
            SfSignaturePad signaturePad = new SfSignaturePad();
            this.Content = signaturePad;
        }
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

 [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 12" %} 
using Syncfusion.Maui.Core.Hosting;

namespace SignaturePadGettingStarted
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

## Step 4: Add a Basic SignaturePad

Import the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) namespace and initialize the SignaturePad as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <signaturePad:SfSignaturePad />
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.SignaturePad;

namespace SignaturePadGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Creating a SignaturePad control.
            SfSignaturePad signaturePad = new SfSignaturePad();
            this.Content = signaturePad;
        }
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

![SignaturePad default](images/getting-started/default.png)

N> You can refer to our [.NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI SignaturePad Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad) that shows you how to render the SignaturePad in .NET MAUI.