---
layout: post
title: Getting Started with .NET MAUI Barcode Generator control | Syncfusion
description: Learn here all about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Barcode Generator(SfBarcodeGenerator) control and more.
platform: maui
control: SfBarcodeGenerator
documentation: ug
---

# Getting Started with .NET MAUI Barcode Generator

This section explains how to add the [`.NET MAUI Barcode Generator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.html) control to your project, set its symbology, and covers the essential features for getting started with the Syncfusion<sup>&reg;</sup> Barcode Generator control.

To get started quickly with the [.NET MAUI Barcode Generator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.html), you can check the following video.

{% youtube "https://www.youtube.com/watch?v=WwdtIotODpE" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Barcode NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Barcode](https://www.nuget.org/packages/Syncfusion.Maui.Barcode/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the Command Palette by pressing **Ctrl+Shift+P**, type **.NET:New Project**, and press **Enter**.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Barcode NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Barcode` to install the Syncfusion<sup>®</sup> .NET MAUI Barcode NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select **.NET (C#)**, and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Barcode NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Barcode](https://www.nuget.org/packages/Syncfusion.Maui.Barcode/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

The Syncfusion handler must be registered to enable all Syncfusion MAUI controls in your application. Add the following namespace to your `MauiProgram.cs` file:

{% tabs %}
{% highlight c# %}

using Syncfusion.Maui.Core.Hosting;

{% endhighlight %}
{% endtabs %}

Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file:

{% tabs %}
{% highlight c# %}

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Import the Barcode Generator namespace

Add the following namespace in your XAML or C#:

{% tabs %}
{% highlight xml %}

xmlns:barcode="clr-namespace:Syncfusion.Maui.Barcode;assembly=Syncfusion.Maui.Barcode"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Barcode;

{% endhighlight %}
{% endtabs %}

## Step 5: Initialize the Barcode Generator

Initialize the [SfBarcodeGenerator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html) and set a `Value` to display the barcode. The following XAML snippet shows how to add a barcode generator in a `ContentPage`:

{% tabs %}

{% highlight xml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:barcode="clr-namespace:Syncfusion.Maui.Barcode;assembly=Syncfusion.Maui.Barcode"
             x:Class="BarcodeApp.MainPage">

    <barcode:SfBarcodeGenerator Value="12634388927"
                                HeightRequest="150"
                                WidthRequest="300">
    </barcode:SfBarcodeGenerator>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

SfBarcodeGenerator barcode = new SfBarcodeGenerator()
{
    Value = "12634388927",
    HeightRequest = 150,
    WidthRequest = 300
};

this.Content = barcode;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Barcode Generator Initialize Barcode](images/getting-started/maui-intialize-barcode.png)

N> The default symbology of `SfBarcodeGenerator` is [`Code128`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128.html). To render other symbologies such as `QRCode`, `DataMatrix`, or `Codabar`, set the `Symbology` property.

You can download the complete Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-barcode-generator).
