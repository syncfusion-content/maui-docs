---
layout: post
title: Getting started with .NET MAUI Time Picker control | Syncfusion®
description: Learn about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Getting started with .NET MAUI Time Picker

This section explains how to add the [.NET MAUI Time Picker](https://www.syncfusion.com/maui-controls/maui-timepicker) control. It covers only the basic features needed to get started with the Syncfusion<sup>&reg;</sup> Time Picker. Follow the steps below to add a .NET MAUI Time Picker to your project.

To get started quickly with our .NET MAUI Time Picker, see the video below.

{% youtube "youtube:https://youtu.be/m3Gn6S_8Oeo?si=AK9iY1m8G8sQ0zsA" %}

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

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Picker NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and press `Enter`.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press `Enter`.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Picker NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you are in the project root directory where your `.csproj` file is located.
3. Run `dotnet add package Syncfusion.Maui.Picker` to install the Syncfusion<sup>&reg;</sup> .NET MAUI Picker NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select **.NET (C#)** and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> MAUI Picker NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register the Syncfusion<sup>&reg;</sup> core handler

Add the following namespace at the top of `MauiProgram.cs`.

{% tabs %}
{% highlight C# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}

Register the Syncfusion<sup>&reg;</sup> core handler in the `CreateMauiApp` method of `MauiProgram.cs`.

{% tabs %}
{% highlight C# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Import the Time Picker namespace

Add the following namespace in your XAML or C# code.

{% tabs %}
{% highlight xaml %}

xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Picker;

{% endhighlight %}
{% endtabs %}

## Step 5: Add the Time Picker component

Initialize the `SfTimePicker` control and configure its properties. The `SfTimePicker` allows you to add header text by setting the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Text) property in the [PickerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html). Enable the header view by setting the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Height) property of the `PickerHeaderView` to a value greater than `0`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="6" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfTimePicker x:Name="picker">
        <picker:SfTimePicker.HeaderView>
            <picker:PickerHeaderView Text="Time Picker" Height="40" />
        </picker:SfTimePicker.HeaderView>
    </picker:SfTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="7 8" %}

using Syncfusion.Maui.Picker;
. . .

SfTimePicker picker = new SfTimePicker();
picker.HeaderView = new PickerHeaderView()
{
    Text = "Time Picker",
    Height = 40,
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

![Set header view in .NET MAUI Time Picker.](images/getting-started/maui-time-picker-set-header-view.png)

## Verify installation

Run `dotnet build` and confirm the project compiles without errors. If you see a `TypeInitializationException` referencing `SfTimePicker`, verify that both `Syncfusion.Maui.Picker` and `Syncfusion.Maui.Core` are installed and that `builder.ConfigureSyncfusionCore();` is called in `MauiProgram.cs`.

You can download the Time Picker Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/dotnet-maui-timepicker-sample).