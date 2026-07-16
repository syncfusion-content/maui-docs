---
layout: post
title: Getting Started with .NET MAUI TreeMap | Syncfusion®
description: Learn about getting started with Syncfusion® .NET MAUI TreeMap (SfTreeMap) in mobile and desktop applications from a single shared codebase.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Getting Started with the .NET MAUI TreeMap

This section provides a quick overview of how to get started with the [.NET MAUI SfTreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) and a walk-through to configure the .NET MAUI TreeMap in a real-time scenario. Follow the steps below to add the .NET MAUI TreeMap control to your project.

To get started quickly with our .NET MAUI TreeMap, you can check the below video.

{% youtube
"youtube:https://youtu.be/ZqorS_FjHxg?si=ojSLI-inAq9_1-aI"%}

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

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.TreeMap](https://www.nuget.org/packages/Syncfusion.Maui.TreeMap/) and install the latest version.
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

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap NuGet package

1. Open the Terminal and run `dotnet add package Syncfusion.Maui.TreeMap` to install the latest version.
2. Ensure the necessary dependencies are installed correctly, and the project is restored by running `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select .NET (C#), and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap NuGet package

1. In the **NuGet** window, search for [Syncfusion.Maui.TreeMap](https://www.nuget.org/packages/Syncfusion.Maui.TreeMap/) and install the latest version.
2. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the Terminal in Rider and manually run: `dotnet restore`

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

## Step 4: Create a data model for TreeMap 

Create a simple data model in a new class file as shown in the following example code.

{% tabs %}
{% highlight c# %}

public class PopulationDetails
{
    public string State { get; set; }
    public double Population { get; set; }
}

{% endhighlight %}
{% endtabs %}

## Step 5: Create a view model

Create a view model class to set values for the properties listed in the model class as shown in the following example code.

{% tabs %}
{% highlight c# %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails { State = "Ecuador", Population = 7 },
            new PopulationDetails { State = "Chile", Population = 5 },
            new PopulationDetails { State = "Peru", Population = 3 },             
            new PopulationDetails { State = "Falkland", Population = 1 },
            new PopulationDetails { State = "French", Population = 1 },
            new PopulationDetails { State = "German", Population = 3 },
            new PopulationDetails { State = "Islands", Population = 1 },
            new PopulationDetails { State = "Guiana", Population = 1 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

## Step 6: Add the TreeMap Component

Initialize the `TreeMap` control and configure its properties to represent hierarchical data using a compact, space-efficient visualization. The TreeMap organizes data into nested rectangles, where each item's size and color can reflect specific values. To populate the TreeMap items, utilize the [DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_DataSource) property of [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html). Additionally, ensure that the [PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath) property of [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html) is mapped from the corresponding property in the [DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_DataSource) while initializing the TreeMap control.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap"
             xmlns:local="clr-namespace:TreeMapSample">
    <ContentPage.BindingContext>
        <local:PopulationViewModel />
    </ContentPage.BindingContext>
    <treemap:SfTreeMap DataSource="{Binding PopulationDetails}"
                       PrimaryValuePath="Population">
        <treemap:SfTreeMap.LeafItemBrushSettings>
           <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
        </treemap:SfTreeMap.LeafItemBrushSettings>
    </treemap:SfTreeMap>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

SfTreeMap treeMap = new SfTreeMap();
PopulationViewModel viewModel = new PopulationViewModel();
treeMap.BindingContext = viewModel;
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings() { Brush = Brush.Orange };
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

N> When publishing in AOT mode on iOS and macOS, ensure that `[Preserve(AllMembers = true)]` is added to the model class to retain model bindings during AOT compilation.

![.NET MAUI TreeMap getting started](images/getting-started/treemap-view.png)

You can download the TreeMap Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/maui-treemap-examples/tree/master/GettingStarted).

N> You can refer to our [.NET MAUI TreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI TreeMap Example](https://github.com/SyncfusionExamples/maui-treemap-examples/tree/master/) that shows you how to render the TreeMap in .NET MAUI.
