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

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad) and install the latest version.
3. Ensure that the necessary dependencies are installed correctly and that the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project**, then press **Enter**.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.SignaturePad` to install the Syncfusion<sup>®</sup> .NET MAUI SignaturePad package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the .NET MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select **.NET (C#)**, and choose the **.NET MAUI App** template.
2. Enter the **Project Name**, **Solution Name**, and **Location**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad/) and install the latest version.
3. Ensure that the necessary dependencies are installed correctly and that the project is restored. If not, open the terminal in Rider and run `dotnet restore`.

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register the Syncfusion core handler

Add the following `using` directive and call to `ConfigureSyncfusionCore()` in the `CreateMauiApp` method of `MauiProgram.cs` to register the Syncfusion core handler required by the SignaturePad control.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore();
        // ...
        return builder.Build();
    }
}
{% endhighlight %}
{% endtabs %}

## Step 4: Import the SignaturePad namespace

Add the following XAML namespace declaration to your page and `using` directive to your C# files.

{% tabs %}
{% highlight xaml %}

xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SignaturePad;

{% endhighlight %}
{% endtabs %}

## Step 5: Add the SignaturePad control

Add the SignaturePad control to your page. The following examples render a basic SignaturePad and set a stroke color.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <signaturePad:SfSignaturePad x:Name="signaturePad"
                                 StrokeColor="Red" />
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SignaturePad;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Content = new SfSignaturePad
        {
            StrokeColor = Colors.Red,
        };
    }
}

{% endhighlight %}
{% endtabs %}

![SignaturePad default](images/getting-started/default.png)

## Related resources

* [SignaturePad Getting Started sample on GitHub](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-signature-pad)
* [.NET MAUI SignaturePad feature tour page](https://www.syncfusion.com/maui-controls/maui-signaturepad)
* [.NET MAUI SignaturePad example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad)

N> You can refer to our [.NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI SignaturePad Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad) that shows you how to render the SignaturePad in .NET MAUI.

## See Also

* [Customization in .NET MAUI SignaturePad](customization.md)
* [Events and Methods in .NET MAUI SignaturePad](events-and-methods.md)
* [SfSignaturePad API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html)