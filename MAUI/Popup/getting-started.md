---
layout: post
title: Getting Started with .NET MAUI Popup control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Popup (SfPopup) control, its elements and more.
platform: MAUI
control: SfPopup
documentation: ug
---

# Getting Started with .NET MAUI Popup

This section guides you through setting up and configuring a [Popup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html) in your .NET MAUI application. Follow the steps below to add a basic Popup to your project.

To quickly get started with the .NET MAUI Popup, watch this video:
<style>#MAUIPopupVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIPopupVideoTutorial' src='https://www.youtube.com/embed/HTk6JAGP-qE'></iframe>

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Popup NuGet package

 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for [Syncfusion.Maui.Popup](https://www.nuget.org/packages/Syncfusion.Maui.Popup) and install the latest version.
 3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Popup NuGet package

 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for [Syncfusion.Maui.Popup](https://www.nuget.org/packages/Syncfusion.Maui.Popup) and install the latest version.
 3. Ensure the necessary dependencies are installed correctly, and the project is restored

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Popup NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Popup](https://www.nuget.org/packages/Syncfusion.Maui.Popup) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

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

## Step 4: Import Popup namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}

xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Popup;

{% endhighlight %}
{% endtabs %}

## Step 5: Add the Popup component

Display a popup over your view by calling the [Show](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Boolean_) method.

Refer to the following code example for displaying popup using Button's Click event.

{% tabs %}

{% highlight xaml %}

<StackLayout x:Name="mainLayout">
<Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
        VerticalOptions="Start" HorizontalOptions="Center"
        Clicked="ClickToShowPopup_Clicked" />
        <syncfusion:SfPopup x:Name="popup" />
</StackLayout>

{% endhighlight %}

{% highlight c# %}

private void ClickToShowPopup_Clicked(object sender, EventArgs e)
{
    popup.Show();
}

{% endhighlight %}

{% endtabs %}

![Popup with default appearance](Images/getting-started//maui-popup-with-default-appearance.png)

You can download the Popup Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/getting-started-.net-maui-popup).