---
layout: post
title: Getting Started with .NET MAUI Toolbar Control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Toolbar (SfToolbar) control, its elements and more.
platform: maui
control: Toolbar (SfToolbar)
documentation: ug
---

# Getting Started with .NET MAUI Toolbar

This section provides a quick overview of how to get started with the [.NET MAUI SfToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) for .NET MAUI and a walk-through to configure the .NET MAUI Toolbar in a real-time scenario. Follow the steps below to add .NET MAUI Toolbar control to your project.

To get start quickly with our .NET MAUI Toolbar, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=U4ZFNr0nsB0"%}

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Toolbar NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Toolbar](https://www.nuget.org/packages/Syncfusion.Maui.Toolbar/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Toolbar NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Toolbar](https://www.nuget.org/packages/Syncfusion.Maui.Toolbar/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Toolbar NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Toolbar](https://www.nuget.org/packages/Syncfusion.Maui.Toolbar/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

## Step 3: Register Syncfusion handler
 
Make sure to add the namespace.
 
{% highlight MauiProgram.cs %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
 
Register the Syncfusion core handler in your CreateMauiApp method of `MauiProgram.cs` file to use Syncfusion controls.
 
{% highlight MauiProgram.cs %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}

## Step 4: Import the Toolbar namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}

xmlns:treemap="xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar""

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Toolbar;

{% endhighlight %}
{% endtabs %}

## Step 5: Add Toolbar Component

You can use [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_Items) property of [SfToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) to populate the toolbar items.
 
{% tabs %}

{% highlight xaml %}

<toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
    <toolbar:SfToolbar.Items>
        <toolbar:SfToolbarItem Name="Bold" ToolTipText="Bold">
            <toolbar:SfToolbarItem.Icon>
                <FontImageSource Glyph="&#xE770;" FontFamily="MauiMaterialAssets" />
            </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline" ToolTipText="Underline">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;" FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic" ToolTipText="Italic">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;" FontFamily="MauiMaterialAssets" />
            </toolbar:SfToolbarItem.Icon>
            <!--Add more items-->
        </toolbar:SfToolbarItem>
    </toolbar:SfToolbar.Items>
</toolbar:SfToolbar>

{% endhighlight %}

{% highlight c# %}

SfToolbar toolbar = new SfToolbar();
toolbar.HeightRequest = 56;
ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
{
    new SfToolbarItem
    {
        Name = "Bold",
        ToolTipText = "Bold",
        Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
    },
    new SfToolbarItem
    {
        Name = "Underline",
        ToolTipText = "Underline",
        Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
    },
    new SfToolbarItem
    {
        Name = "Italic",
        ToolTipText = "Italic",
        Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
    },
    // add more toolbar items
};
            
toolbar.Items = itemCollection;
this.Content = toolbar;

{% endhighlight %}

{% endtabs %}

![getting-started](images/Icons.png)

>N Please refer to the [link](https://help.syncfusion.com/maui/icons) to add the `MauiMaterialAssets` custom font. 

You can download the Toolbar Getting Started sample from [here](https://github.com/SyncfusionExamples/maui-toolbar/tree/Gettingstarted/GettingStarted).