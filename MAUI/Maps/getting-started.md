---
layout: post
title: Getting started with .NET MAUI Maps control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Maps (SfMaps) control, its elements, and more. 
platform: MAUI
control: SfMaps
documentation: ug
keywords: .net maui maps, .net maui maps library.
---

# Getting started with .NET MAUI Maps (SfMaps)

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Maps** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/maps/getting-started)** guide.

This section explains the steps required to add the maps control with the shape layer and its elements such as data labels, tooltip, markers, and legends. This section covers only basic features needed to know to get started with Syncfusion® maps. Follow the steps below to add .NET MAUI Maps control to your project.

To get started quickly with our .NET MAUI Maps, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=ibUB70vM5DU"%}

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Maps NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Maps](https://www.nuget.org/packages/Syncfusion.Maui.Maps/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then, choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Maps NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Maps` to install the Syncfusion<sup>®</sup> .NET MAUI Maps package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**. Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Maps NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Maps](https://www.nuget.org/packages/Syncfusion.Maui.Maps/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the Terminal in Rider and manually run: `dotnet restore`

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
public static MauiApp CreateMauiApp()
{
    var builder = MauiApp.CreateBuilder();
    builder
        .UseMauiApp<App>()
        .ConfigureSyncfusionCore();

    //code omitted for brevity

    return builder.Build();
}
{% endhighlight %}
{% endtabs %}

## Step 4: Import the Maps namespace
 
Add the following namespace in your XAML or C#.
 
{% tabs %}
{% highlight xaml %}
 
<ContentPage xmlns:map="clr-namespace:Syncfusion.Maui.Maps;assembly=Syncfusion.Maui.Maps">
 
</ContentPage>
 
{% endhighlight %}
{% highlight c# %}
 
using Syncfusion.Maui.Maps;
 
{% endhighlight %}
{% endtabs %}

## Step 5: Add a Maps component

Initialize the [`SfMaps`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html) and add a [`Layer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer) which contains [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html) elements. The actual geographical rendering is done in each [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html). The [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) property of the [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html) is of type [`MapSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html). The [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) can be set as the .json source or shapefile.

I> The Mercator projection is the default projection in the maps.

### Set GeoJSON data or shapefile for the shape layer from various sources

The [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) property is used to load shapes from different sources:

* [`FromFile`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromFile_System_String_) returns a MapSource that reads a shape source from a local file.
* [`FromUri`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromUri_System_Uri_) returns a MapSource that downloads and reads a shape source from a specified URI.
* [`FromResource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromResource_System_String_) returns a MapSource that reads a shape source file embedded in an assembly.
* [`FromStream`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromStream_System_IO_Stream_) returns a MapSource that reads a shape source from a stream that supplies source data.

### Loading a local file

`SfMaps` provides support to load the JSON data or shapefile from local path. 

The [`MapSource.FromFile`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromFile_System_String_) method requires a string argument, and returns a new [`MapSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html) object that reads the data from the shape source file. There's also an implicit conversion operator that enables the filename to be specified as a string argument to the [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) property.

N> When using absolute file paths like `D:\MyProject\usa_state.shp`, ensure cross-platform compatibility. On iOS and Android, use the app data directory or `FileSystem.AppDataDirectory` to construct valid paths.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="D:\MyProject\usa_state.shp" />
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps map = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromFile(@"D:\MyProject\usa_state.shp");
map.Layer = layer;

{% endhighlight %}

{% endtabs %}

### Loading a remote file

`SfMaps` provides support to load the JSON data or shapefile from the URI.

The [`MapSource.FromUri`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromUri_System_Uri_) method requires a Uri argument, and returns a new [`MapSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html) object that reads the shape source from the Uri. There's also an implicit conversion for string-based URIs.

N> To download remote GeoJSON or shapefile data on Android, ensure the `INTERNET` permission is declared in the `AndroidManifest.xml` file.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json" />
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps map = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
map.Layer = layer;

{% endhighlight %}

{% endtabs %}

### Loading an embedded file

* Embedded sources are loaded based on their resource ID, which is composed of the name of the project and its location in the project. 
* You can load both JSON data and shapefile.
* For example, placing `australia.json` in the root folder of a project named `MyProject` will result in a resource ID of `MyProject.australia.json`. Similarly, placing `world1.shp` in the Assets folder of a project named `MyProject` will result in a resource ID of `MyProject.Assets.world1.shp`.

To set the build action for the embedded file, follow these steps:

1. Right-click the added shapefile or JSON file, and navigate to properties.
2. Choose the `EmbeddedResource` option under Build Action of the respective file.

N> The resource ID differs based on the folder location. For a file in the project root, the resource ID is `MyProject.australia.json`. For a file in the Assets folder, the resource ID is `MyProject.Assets.australia.json`. Ensure the resource ID used in code matches the file's folder location.

N> You can get the [`australia.json`](https://www.syncfusion.com/downloads/support/directtrac/general/ze/australia-json-910278184.zip) file here.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="MyProject.australia.json" />
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps map = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromResource("MyProject.australia.json");
map.Layer = layer;

{% endhighlight %}

{% endtabs %}

### Loading from stream

`SfMaps` provides support to load the JSON data or shapefile as bytes from stream.

The `GetManifestResourceStream` method returns `null` if the resource name is not found. For more reliable assembly resolution, use `typeof(App).GetTypeInfo().Assembly` to get the project assembly.

{% tabs %}

{% highlight c# %}

SfMaps map = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
var assembly = typeof(App).GetTypeInfo().Assembly;
var jsonStream = assembly?.GetManifestResourceStream("MyProject.Assets.australia.json");
layer.ShapesSource = MapSource.FromStream(jsonStream);
map.Layer = layer;

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![.NET MAUI Maps basic view.](images/getting-started/net-maui-map-basic-view.png)

You can download the Maps Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/.NET-MAUI-Maps-Getting-Started).

N>
* You can refer to our [.NET MAUI Maps](https://www.syncfusion.com/maui-controls/maui-maps) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Maps Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Maps) that shows you how to render the Maps in .NET MAUI.