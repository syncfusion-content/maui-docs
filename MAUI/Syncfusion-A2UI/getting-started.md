---
layout: post
title: Getting Started with Syncfusion® A2UI for .NET MAUI | Syncfusion®
description: Step-by-step guide to install the Syncfusion® A2UI for .NET MAUI package and render your first A2UI v0.9 surface as a Syncfusion® .NET MAUI control.
control: A2UI Getting Started
platform: MAUI
documentation: ug
---

# Getting Started with Syncfusion® A2UI for .NET MAUI

This section explains the steps to add and configure the [Syncfusion® A2UI for .NET MAUI](https://a2ui.org/specification/v0.9-a2ui/) package in a .NET MAUI application. Follow the steps below to integrate the A2UI renderer and render A2UI v0.9 content using Syncfusion® .NET MAUI controls.

The Syncfusion® A2UI for .NET MAUI package converts streamed [A2UI v0.9](https://a2ui.org/specification/v0.9-a2ui/) messages into a `SurfaceModel` that is rendered as Syncfusion® .NET MAUI controls - **DataGrid**, **Chart**, **Scheduler**, **Calendar**, **RichTextEditor**, **PdfViewer**, **TreeView**, **Maps**, **Gauges**, and more.

The runtime is composed of two NuGet packages:

- [Syncfusion.A2UI.Core](https://www.nuget.org/packages/Syncfusion.A2UI.Core) - the framework-agnostic A2UI v0.9 engine.
- [Syncfusion.Maui.A2UI](https://www.nuget.org/packages/Syncfusion.Maui.A2UI) - the .NET MAUI renderer that adds Syncfusion® .NET MAUI control adapters on top of the engine. When you register the combined catalog via `UseA2UIWithSyncfusionComponents()`, it transitively brings in every Syncfusion® MAUI control package it depends on (`Syncfusion.Maui.DataGrid`, `Syncfusion.Maui.Charts`, `Syncfusion.Maui.Scheduler`, `Syncfusion.Maui.Core`, and more).

> Syncfusion® A2UI for .NET MAUI is currently in **preview (beta)** and will be published on NuGet under the package `Syncfusion.Maui.A2UI` (with `Syncfusion.A2UI.Core` as a transitive dependency).

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

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI A2UI NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.A2UI](https://www.nuget.org/packages/Syncfusion.Maui.A2UI) and install the latest version.
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
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI A2UI NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.A2UI` to install the Syncfusion<sup>®</sup> A2UI for .NET MAUI package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI A2UI NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.A2UI](https://www.nuget.org/packages/Syncfusion.Maui.A2UI) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

> The Syncfusion® .NET MAUI control packages the renderer depends on (`Syncfusion.Maui.DataGrid`, `Syncfusion.Maui.Charts`, `Syncfusion.Maui.Scheduler`, `Syncfusion.Maui.Core`, etc.) come in transitively from `Syncfusion.Maui.A2UI`. No separate `dotnet add package` is needed. See [Supported Components](./supported-components) for the full list of control families the agent can render.

## Register the A2UI service

Open **MauiProgram.cs** and call `UseA2UIWithSyncfusionComponents()` on the `MauiAppBuilder`. This single call registers the A2UI Core engine, the combined Syncfusion® catalog (18 basic primitives + 56 Syncfusion® .NET MAUI control schemas), and the `SurfaceHost` in one step.

{% tabs %}
{% highlight C# %}

using Syncfusion.Maui.A2UI.SyncfusionComponents;
using Syncfusion.Maui.Core.Hosting;

builder.ConfigureSyncfusionCore();
builder.UseA2UIWithSyncfusionComponents();

{% endhighlight %}
{% endtabs %}

## Register the Syncfusion® license key

The Syncfusion® .NET MAUI components require a valid license key to be registered before they render without a trial-license. The A2UI adapters call into the same components under the hood, so a registered key is required even when the UI is generated by an agent.

For instructions on generating and registering a license key, see [Register License Key in a .NET MAUI application](https://help.syncfusion.com/maui/licensing).

## Import the A2UI namespace

Add the following namespace in your XAML or C#.
 
{% tabs %}
{% highlight XAML %}
 
xmlns:a2ui="clr-namespace:Syncfusion.Maui.A2UI.Hosting;assembly=Syncfusion.Maui.A2UI"
 
{% endhighlight %}
{% highlight C# %}
 
using System.Text.Json;
using Syncfusion.A2UI.Core.Common;
using Syncfusion.A2UI.Core.Serialization;
using Syncfusion.Maui.A2UI.Hosting;
 
{% endhighlight %}
{% endtabs %}

## Render your first MAUI A2UI surface

Open **MainPage.xaml** and add an `<a2ui:A2uiSurface>` view.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<ScrollView>
  <VerticalStackLayout Spacing="12" Padding="12">
    <Label Text="SyncfusionDataGrid via A2UI" FontSize="22" FontAttributes="Bold" />
      <a2ui:A2uiSurface x:Name="OrdersSurface" />
  </VerticalStackLayout>
</ScrollView>

{% endhighlight %}

{% highlight C# %}

using System.Text.Json;
using Syncfusion.A2UI.Core.Common;
using Syncfusion.A2UI.Core.Serialization;
using Syncfusion.Maui.A2UI.Hosting;

 private readonly SurfaceHost _host;
 public MainPage(SurfaceHost host)
 {
    InitializeComponent();
    _host = host;
 }
 
protected override void OnAppearing()
{
    base.OnAppearing();
    try { _host.Processor.Model.DeleteSurface("orders"); } catch { /* surface didn't exist */ }
    var messages = A2uiJson.ParseMessages(JsonDocument.Parse(Json).RootElement);
    _host.Processor.ProcessMessages(messages);
    var surface = _host.Processor.Model.GetSurface("orders");
    OrdersSurface.Host = _host;
    OrdersSurface.Surface = surface;
    OrdersSurface.Rebuild();
 }

private const string Json = """
{
  "version": "v0.9",
  "messages": [
    { "version": "v0.9", "createSurface": { "surfaceId": "orders", "catalogId": "syncfusion-maui", "sendDataModel": true } },
    { "version": "v0.9", "updateDataModel": {
       "surfaceId": "orders",
        "path": "/orders",
        "value": [
          { "OrderID": 10248, "CustomerID": "VINET",  "Freight":  32.38, "OrderDate": "1996-07-04", "ShipCountry": "France"     },
          { "OrderID": 10249, "CustomerID": "TOMSP",  "Freight":  11.61, "OrderDate": "1996-07-05", "ShipCountry": "Germany"    },
          { "OrderID": 10250, "CustomerID": "HANAR",  "Freight":  65.83, "OrderDate": "1996-07-08", "ShipCountry": "Brazil"     },
          { "OrderID": 10251, "CustomerID": "VICTE",  "Freight":  41.34, "OrderDate": "1996-07-08", "ShipCountry": "France"     },
          { "OrderID": 10252, "CustomerID": "SUPRD",  "Freight":  51.30, "OrderDate": "1996-07-09", "ShipCountry": "Belgium"    },
          { "OrderID": 10253, "CustomerID": "HANAR",  "Freight":  58.17, "OrderDate": "1996-07-10", "ShipCountry": "Brazil"     },
          { "OrderID": 10254, "CustomerID": "CHOPS",  "Freight":  22.98, "OrderDate": "1996-07-11", "ShipCountry": "Switzerland"},
          { "OrderID": 10255, "CustomerID": "RICSU",  "Freight": 148.33, "OrderDate": "1996-07-12", "ShipCountry": "Switzerland"},
          { "OrderID": 10256, "CustomerID": "WELLI",  "Freight":  13.97, "OrderDate": "1996-07-15", "ShipCountry": "Brazil"     },
          { "OrderID": 10257, "CustomerID": "HILAA",  "Freight":  81.91, "OrderDate": "1996-07-16", "ShipCountry": "Venezuela"  },
          { "OrderID": 10258, "CustomerID": "ERNSH",  "Freight": 140.51, "OrderDate": "1996-07-17", "ShipCountry": "Austria"    },
          { "OrderID": 10259, "CustomerID": "CENTC",  "Freight":   3.25, "OrderDate": "1996-07-18", "ShipCountry": "Mexico"     },
          { "OrderID": 10260, "CustomerID": "OTTIK",  "Freight":  55.09, "OrderDate": "1996-07-19", "ShipCountry": "Germany"    },
          { "OrderID": 10261, "CustomerID": "QUEDE",  "Freight":   3.05, "OrderDate": "1996-07-19", "ShipCountry": "Brazil"     },
          { "OrderID": 10262, "CustomerID": "RATTC",  "Freight":  48.29, "OrderDate": "1996-07-22", "ShipCountry": "USA"        }
        ]
    }},

   { "version": "v0.9", "updateDataModel": {
      "surfaceId": "orders",
      "path": "/selectedRowJson",
      "value": ""
   }},

   { "version": "v0.9", "updateComponents": {
      "surfaceId": "orders",
      "components": [
      {
        "id": "root",
        "component": "Column",
        "children": ["grid", "selected-json"]
      },
      {
        "id": "grid",
        "component": "SyncfusionDataGrid",
        "dataSource": { "path": "/orders" },
        "columns": [
          { "mappingName": "OrderID", "headerText": "Order ID", "textAlign": "end", "format": "N0" },
          { "mappingName": "CustomerID", "headerText": "Customer" },
          { "mappingName": "Freight", "headerText": "Freight", "textAlign": "end", "format": "C2" },
          { "mappingName": "OrderDate", "headerText": "Order Date" },
          { "mappingName": "ShipCountry", "headerText": "Ship Country" }
        ],
        "selectionMode": "single",
        "columnWidthMode": "auto"
    },
    {
      "id": "selected-json",
      "component": "Text",
      "text": { "path": "/selectedRowJson" },
      "variant": "caption"
    }
   ]
  }}
 ]
}
""";

{% endhighlight %}

{% highlight c# tabtitle="App.xaml.cs" hl_lines="5 8 9 10 11" %}

  private readonly IServiceProvider _services;
  public App(IServiceProvider services)
  {
      InitializeComponent();
      _services = services;
  }

  protected override Window CreateWindow(IActivationState? activationState)
  {
      return new Window(new AppShell(_services.GetRequiredService<MainPage>()));
  }

{% endhighlight %}
{% endtabs %}

The page renders a Syncfusion® .NET MAUI `SfDataGrid` populated with sample `Orders` rows (Order ID, Customer, Freight, Order Date, Ship Country). The grid enables single-column sorting, filtering, grouping, single-row selection, alternating rows, and grid lines - all driven from a static A2UI v0.9 JSON message list. No agent is involved.

> In production, replace the embedded JSON with messages streamed from an [A2UI v0.9-compatible agent](https://a2ui.org/specification/v0.9-a2ui/). See [AI Integration](./ai-integration) for the agent round-trip pattern.

## See also

- [Overview](./overview)
- [AI Integration](./ai-integration)
- [Supported Components](./supported-components)
- [A2UI v0.9 protocol](https://a2ui.org/specification/v0.9-a2ui/)