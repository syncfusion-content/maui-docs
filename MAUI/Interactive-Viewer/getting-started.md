---
layout: post
title: Getting Started with .NET MAUI Interactive Viewer | Syncfusion®
description: Learn how to get started with the Syncfusion® .NET MAUI Interactive Viewer control. Explore setup, features, examples, and customization options.
platform: MAUI
control: SfInteractiveViewer
documentation: ug
keywords: .net maui interactiveviewer, image view maui.
---

# Getting Started with .NET MAUI Interactive Viewer

This section provides a quick overview of how to get started with the .NET MAUI Interactive Viewer (SfInteractiveViewer) and a walkthrough to configure the control in a real-time scenario. Follow the steps below to add the .NET MAUI Interactive Viewer control to your project.

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Interactive Viewer NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.InteractiveViewer](https://www.nuget.org/packages/Syncfusion.Maui.InteractiveViewer/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Interactive Viewer NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.InteractiveViewer` to install the Syncfusion<sup>®</sup> .NET MAUI Interactive Viewer NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Interactive Viewer NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.InteractiveViewer](https://www.nuget.org/packages/Syncfusion.Maui.InteractiveViewer/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler
 
Make sure to add the namespace.
 
{% tabs %}
{% highlight C# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.
 
{% tabs %}
{% highlight C# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}
 
## Step 4: Import Interactive Viewer namespace

Add the following namespace in your XAML or C#.
{% tabs %}
{% highlight XAML %}

xmlns:interactiveViewer="clr-namespace:Syncfusion.Maui.InteractiveViewer;assembly=Syncfusion.Maui.InteractiveViewer"

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.InteractiveViewer;

{% endhighlight %}
{% endtabs %}

## Step 5: Add the Interactive Viewer component

Initialize the SfInteractiveViewer to display and interact with any .NET MAUI view.

{% tabs %}
{% highlight XAML hl_lines="2" %}

 <interactiveViewer:SfInteractiveViewer>
     <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
 </interactiveViewer:SfInteractiveViewer>

{% endhighlight %}
{% highlight C# hl_lines="3 4 5 6 7" %}

using Syncfusion.Maui.InteractiveViewer;

SfInteractiveViewer interactiveViewer = new SfInteractiveViewer()
{
    Content = new Image()
    {
        Source = "interactiveviewerimage.png",
        Aspect = Aspect.AspectFit
    }
};

this.Content = interactiveViewer;

{% endhighlight %}
{% endtabs %}