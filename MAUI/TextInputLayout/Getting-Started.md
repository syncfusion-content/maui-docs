---
layout: post
title: Getting Started with .NET MAUI Text Input Layout control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control, its elements and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui hint label.
---

# Getting Started with .NET MAUI TextInputLayout

This section guides you through setting up and configuring a [TextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) in your .NET MAUI application. Follow the steps below to add a basic TextInputLayout to your project.

To quickly get started with the .NET MAUI TextInputLayout, watch this video.

{% youtube "https://www.youtube.com/watch?v=VKo3vNBzNbw" %}

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

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


## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Core` to install the Syncfusion<sup>®</sup> .NET MAUI Core package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

Make sure to add the namespace.

{% highlight csharp %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %} 

Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.

{% highlight csharp %}
builder.ConfigureSyncfusionCore();
{% endhighlight %} 

## Step 4: Import TextInputLayout namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}

xmlns:inputLayout="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

{% endhighlight %}
{% endtabs %}

## Step 5: Add the TextInputLayout Component

Configure the `TextInputLayout` component to enhance input fields with additional context and styling. Floating label for the text input layout can be added by setting the [Hint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfCore.html#Syncfusion_Maui_Core_SfTextInputLayout_Hint) property. Visibility of the hint can be collapsed by setting the [ShowHint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowHint) property to `false.` By default, this property is set to `true.`

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name">
   <Entry />
</inputLayout:SfTextInputLayout>  

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name"; 
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

When focusing on the input view, the hint label will be moved to the top position; it will be returned to the original position when proceeding further (on unfocused) without entering any value.

![Adding hint](images/GettingStarted/GettingStarted.png)

You can download the TextInputLayout Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/maui-textinputlayout-samples)

N> You can refer to our [.NET MAUI Text Input Layout](https://www.syncfusion.com/maui-controls/maui-textinputlayout) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Text Input Layout Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/TextInputLayout) that shows you how to render the Text Input Layout in .NET MAUI.