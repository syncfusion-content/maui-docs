---
layout: post
title: Getting Started with Syncfusion® .NET MAUI Avatar View
description: Learn all about getting started with the Syncfusion® .NET MAUI Avatar View (SfAvatarView) control, its elements, and more.
platform: MAUI
control: SfAvatarView
documentation: UG
---

# Getting Started with .NET MAUI Avatar View

This section guides you through setting up and configuring a [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add a basic Avatar View to your project.

To quickly get started with the .NET MAUI Avatar View, watch this video.

{% youtube "https://www.youtube.com/watch?v=XrTvIgeeUm0" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P`, type **.NET:New Project** and press **Enter**.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

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

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the terminal in Rider and manually run: `dotnet restore`.

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler
 
Make sure to add the namespace.
 
{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.
 
{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Import the Avatar View namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}
xmlns:sfavatar="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Core;
{% endhighlight %}
{% endtabs %}

## Step 5: Add the Avatar View component

Create an instance for the Avatar View control, and add it as content. You can add a custom image to display in the [.NET MAUI Avatar View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) using the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSource) property. Set the [ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ContentType) to `Custom.` To ensure the avatar image appears correctly, place the image in the `Resources/Images` directory.

{% tabs %}

{% highlight xaml %}
<sfavatar:SfAvatarView ContentType="Custom"
                       ImageSource="alex.png"
                       VerticalOptions="Center"
                       HorizontalOptions="Center"   
                       HeightRequest="100"
                       CornerRadius="50"
                       WidthRequest="100" 
                       Stroke="Black"
                       StrokeThickness="2"/>
{% endhighlight %}

{% highlight c# %}
SfAvatarView avatarView = new SfAvatarView();
avatarView.VerticalOptions = LayoutOptions.Center;
avatarView.HorizontalOptions = LayoutOptions.Center;
avatarView.ContentType = ContentType.Custom;
avatarView.ImageSource = "alex.png";
avatarView.WidthRequest = 100;
avatarView.HeightRequest = 100;
avatarView.CornerRadius = 50;
avatarView.Stroke = Colors.Black;
avatarView.StrokeThickness = 2;
{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![.NET MAUI Avatar View](GettingStarted_Images/Getting_Started_Sample.png) 

You can download the Avatar View Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-AvatarView)

N> You can refer to our [.NET MAUI Avatar View](https://www.syncfusion.com/maui-controls/maui-avatarview) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Avatar View example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/AvatarView) that shows you how to render the Avatar View in .NET MAUI.