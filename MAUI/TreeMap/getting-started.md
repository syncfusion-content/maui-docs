---
layout: post
title: Getting Started with .NET MAUI TreeMap | Syncfusion<sup>&reg;</sup>
description: Learn about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap (SfTreeMap) in mobile and desktop applications from a single shared codebase.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Getting Started with the .NET MAUI TreeMap

This section provides a quick overview of how to get started with the [.NET MAUI SfTreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) for .NET MAUI and a walk-through to configure the .NET MAUI TreeMap in a real-time scenario. Follow the steps below to add .NET MAUI TreeMap control to your project.

To get start quickly with our .NET MAUI TreeMap, you can check the below video.

{% youtube
"youtube:https://youtu.be/ZqorS_FjHxg?si=ojSLI-inAq9_1-aI"%}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are setup:
1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio 2026 (18.0.0).

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.TreeMap](https://www.nuget.org/packages/Syncfusion.Maui.TreeMap/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

using Syncfusion.Maui.Core.Hosting;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
	    builder
		.ConfigureSyncfusionCore()
		.UseMauiApp<App>()
		.ConfigureFonts(fonts =>
		{
		    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
		    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		});

	    return builder.Build();
	}
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI TreeMap control

1. To initialize the control, import the `Syncfusion.Maui.TreeMap` namespace into your code.
2. Initialize [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html).

{% tabs %}
{% highlight XAML hl_lines="3 5" %}

<ContentPage xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap />
</ContentPage>

{% endhighlight %}

{% highlight C# hl_lines="1 9 10" %}

using Syncfusion.Maui.TreeMap;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        this.Content = treeMap;
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are setup:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.TreeMap](https://www.nuget.org/packages/Syncfusion.Maui.TreeMap/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

using Syncfusion.Maui.Core.Hosting;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
	    builder
		.ConfigureSyncfusionCore()
		.UseMauiApp<App>()
		.ConfigureFonts(fonts =>
		{
		    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
		    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		});

	    return builder.Build();
	}
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI TreeMap control

1. To initialize the control, import the `Syncfusion.Maui.TreeMap` namespace into your code.
2. Initialize [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html).

{% tabs %}
{% highlight XAML hl_lines="3 5" %}

<ContentPage xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap />
</ContentPage>

{% endhighlight %}

{% highlight C# hl_lines="1 9 10" %}

using Syncfusion.Maui.TreeMap;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        this.Content = treeMap;
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeMap NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.TreeMap](https://www.nuget.org/packages/Syncfusion.Maui.TreeMap/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

using Syncfusion.Maui.Core.Hosting;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
	    builder
		.ConfigureSyncfusionCore()
		.UseMauiApp<App>()
		.ConfigureFonts(fonts =>
		{
		    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
		    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		});

	    return builder.Build();
	}
}

{% endhighlight %}
{% endtabs %}

## Step 4: Add .NET MAUI TreeMap control

1. To initialize the control, import the `Syncfusion.Maui.TreeMap` namespace into your code.
2. Initialize [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html).

{% tabs %}
{% highlight XAML hl_lines="3 5" %}

<ContentPage xmlns:treemap="clr-namespace:Syncfusion.Maui.TreeMap;assembly=Syncfusion.Maui.TreeMap">
    <treemap:SfTreeMap />
</ContentPage>

{% endhighlight %}

{% highlight C# hl_lines="1 9 10" %}

using Syncfusion.Maui.TreeMap;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeMap treeMap = new SfTreeMap();
        this.Content = treeMap;
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

## Populate .NET MAUI TreeMap data source

Here are the steps to render treemap items using the .NET MAUI TreeMap control with respective data properties created in a data model class.

* Create a data model for treemap.
* Create view model.
* Bind data source for TreeMap.


#### Create a data model for treemap 

Create a simple data model in a new class file as shown in the following example code.

{% tabs %}
{% highlight C# tabtitle="AirportDetails.cs" %}

public class AirportDetails
{
    public string State { get; set; }
    public string Count { get; set; }
    public int Event { get; set; }
}

{% endhighlight %}
{% endtabs %}

#### Create view model

Create a view model class to set values for the properties listed in the model class as shown in the following example code.

{% tabs %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    public ViewModel()
    {
        this.AirportDetails = new ObservableCollection<AirportDetails>()
        {
            new AirportDetails { State = "Ecuador", Count = 7 },
            new AirportDetails { State = "Chile", Count = 5 },
            new AirportDetails { State = "Peru", Count = 3 },             
            new AirportDetails { State = "Falkland Islands", Count = 1 },
            new AirportDetails { State = "French Guiana", Count = 1 },
        };
    }

    public ObservableCollection<AirportDetails> AirportDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}

#### Bind data source for TreeMap

To populate the treemap items, utilize the [DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_DataSource) property of [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html). Additionally, ensure that the following properties of [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html) are mapped from corresponding properties in the [DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_DataSource) while initializing the treemap control.
* The [PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath) specifies the name of the property within the data object that provides the primary value used to determine the size of each item in the treemap.
* The [RangeColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_RangeColorValuePath) specifies the name of the property within the data object that provides the range color value for each item in the tree map. This value determines the color of the item based on a gradient or range mapping. The [Brush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html#Syncfusion_Maui_TreeMap_TreeMapRangeBrush_Brush) property within [TreeMapRangeBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrush.html) applies colors to items based on [RangeColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_RangeColorValuePath) values using [TreeMapRangeBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrushSettings.html), also defining colors for treemap legend icons, exclusive to [TreeMapRangeBrushSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapRangeBrushSettings.html). The [RangeColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_RangeColorValuePath) is applicable only when the [ShowLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLegendSettings.html#Syncfusion_Maui_TreeMap_TreeMapLegendSettings_ShowLegend) property of [LegendSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LegendSettings) is enabled in the [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html).

Also, specify the path to the data property containing the text you want to display for the treemap leaf item using the [LabelPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapLeafItemSettings.html#Syncfusion_Maui_TreeMap_TreeMapLeafItemSettings_LabelPath) property of [LeafItemSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LeafItemSettings).

{% tabs %}
{% highlight XAML %}

<treemap:SfTreeMap x:Name="treeMap" x:DataType="local:ViewModel" DataSource="{Binding AirportDetails}" Grid.Row="1" Margin="8" RangeColorValuePath="Count" PrimaryValuePath="Count" ShowToolTip="True">
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="State" Spacing="0"/>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
    <treemap:SfTreeMap.LegendSettings>
        <treemap:TreeMapLegendSettings ShowLegend="True" />
    </treemap:SfTreeMap.LegendSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# %}

SfTreeMap treeMap = new SfTreeMap();
ViewModel viewModel = new ViewModel();
treeMap.DataSource = viewModel.AirportDetails;
treeMap.PrimaryValuePath = "Count";
treeMap.RangeColorValuePath = "Count";
treeMap.ShowToolTip = true;
treeMap.LeafItemSettings = new TreeMapLeafItemSettings()
{
    LabelPath = "State",
    Spacing = 0
};
treeMap.LeafItemBrushSettings = new TreeMapUniformBrushSettings()
{
    Brush = new SolidColorBrush(Colors.Orange)
};
treeMap.LegendSettings = new TreeMapLegendSettings()
{
    ShowLegend = true
};

Grid.SetRow(treeMap, 1);

{% endhighlight %}

{% endtabs %}

![Getting Started with MAUI TreeMap ](images/getting-started/treemap-view.png)

N> This is applicable only when [Levels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_Levels) is enabled.


N> You can refer to our [.NET MAUI TreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI TreeMap Example](https://github.com/SyncfusionExamples/maui-treemap-examples/tree/master/) that shows you how to render the TreeMap in .NET MAUI.
