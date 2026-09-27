---
layout: post
title: Getting Started with Syncfusion A2UI for .NET MAUI | Syncfusion®
description: Step-by-step guide to install the Syncfusion® A2UI for .NET MAUI package and render your first A2UI v0.9 surface as a Syncfusion® .NET MAUI control.
control: A2UI Getting Started
platform: MAUI
documentation: ug
---

# Getting Started with Syncfusion A2UI for .NET MAUI

This section explains how to include the [Syncfusion® A2UI for .NET MAUI](https://a2ui.org/specification/v0.9-a2ui/) component in a .NET MAUI app using [Visual Studio](https://visualstudio.microsoft.com/vs/), [Visual Studio Code](https://code.visualstudio.com/), and the [.NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/). The Syncfusion® A2UI for .NET MAUI package converts streamed [A2UI v0.9](https://a2ui.org/specification/v0.9-a2ui/) messages into a `SurfaceModel` that is rendered as Syncfusion® .NET MAUI controls — **DataGrid**, **Chart**, **Scheduler**, **Calendar**, **RichTextEditor**, **PdfViewer**, **TreeView**, **Maps**, **Gauges**, and more.

The runtime is composed of two NuGet packages:

- `Syncfusion.A2UI.Core` — the framework-agnostic A2UI v0.9 engine.
- `Syncfusion.Maui.A2UI` — the .NET MAUI renderer that adds Syncfusion® .NET MAUI control adapters on top of the engine. When you register the combined catalog via `UseA2uiWithSyncfusionComponents()`, it transitively brings in every Syncfusion® MAUI control package it depends on (`Syncfusion.Maui.DataGrid`, `Syncfusion.Maui.Charts`, `Syncfusion.Maui.Scheduler`, `Syncfusion.Maui.Core`, and more).

> Syncfusion® A2UI for .NET MAUI is currently in **preview (beta)** and will be published on NuGet under the package id `Syncfusion.Maui.A2UI` (with `Syncfusion.A2UI.Core` as a transitive dependency).

## Prerequisites

| Tool | Version |
|------|---------|
| .NET SDK | .NET 9 or .NET 10 |
| Visual Studio / VS Code | Latest stable, with the **.NET MAUI workload** installed |
| Target OS | Android, iOS, Mac Catalyst, or Windows 10.0.19041+ |

## Create a new .NET MAUI App

Create a **.NET MAUI App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app) or via the .NET CLI.

```bash
dotnet new maui -o MauiA2UIApp
cd MauiA2UIApp
```

For step-by-step instructions on creating a new .NET MAUI app, see [.NET MAUI Getting Started](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app).

## Install the Syncfusion® A2UI for .NET MAUI package

Install the [Syncfusion.Maui.A2UI](https://www.nuget.org/packages/Syncfusion.Maui.A2UI) NuGet package. All Syncfusion® .NET MAUI packages are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.maui).

{% tabcontents %}

{% tabcontent Visual Studio %}

1. Go to *Tools → NuGet Package Manager → Manage NuGet Packages for Solution*.
2. Search `Syncfusion.Maui.A2UI` and install it.

Alternatively, install using the Package Manager Console:

```powershell
Install-Package Syncfusion.Maui.A2UI
```

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run:

```bash
dotnet add package Syncfusion.Maui.A2UI
```

{% endtabcontent %}

{% tabcontent .NET CLI %}

Open the command prompt and run:

```bash
dotnet add package Syncfusion.Maui.A2UI
```

{% endtabcontent %}

{% endtabcontents %}

> The Syncfusion® .NET MAUI control packages the renderer depends on (`Syncfusion.Maui.DataGrid`, `Syncfusion.Maui.Charts`, `Syncfusion.Maui.Scheduler`, `Syncfusion.Maui.Core`, etc.) come in transitively from `Syncfusion.Maui.A2UI`. No separate `dotnet add package` is needed. See [Supported Components](./supported-components) for the full list of control families the agent can render.

## Add import namespaces

After the package is installed, open **MauiProgram.cs** and import the Syncfusion® A2UI namespaces alongside the base `Syncfusion.Maui.A2UI` namespace.

```csharp
using Syncfusion.Maui.A2UI.SyncfusionComponents;
using Syncfusion.Maui.A2UI.Hosting;
```

## Register the A2UI service

Open **MauiProgram.cs** and call `UseA2uiWithSyncfusionComponents()` on the `MauiAppBuilder`. This single call registers the A2UI Core engine, the combined Syncfusion® catalog (18 basic primitives + 56 Syncfusion® .NET MAUI control schemas), and the `SurfaceHost` in one step.

```csharp
using Syncfusion.Maui.A2UI.SyncfusionComponents;
using Syncfusion.Maui.Core.Hosting;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .UseA2uiWithSyncfusionComponents()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
```

The extension is overloaded to accept an optional `catalogId` (default `"syncfusion-maui"`) and an optional `IA2uiMarkdownRenderer` (default `BasicMarkdownRenderer`).

## Register the Syncfusion® license key

Syncfusion® .NET MAUI controls require a valid license key to render without a trial-license watermark. Register the key in **MauiProgram.cs** before `Build()`:

```csharp
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY");
```

For instructions on generating and registering a license key, see [Register License Key in a .NET MAUI application](https://help.syncfusion.com/maui/licensing).

## Render your first MAUI A2UI surface

Open **MainPage.xaml** and add the markup below. The page declares an A2UI v0.9 JSON envelope with four messages (`createSurface`, two `updateDataModel` payloads, and `updateComponents` that mounts the `SyncfusionDataGrid`), parses it through `A2uiJson.ParseMessages(...)`, feeds it to the `MessageProcessor`, and renders the resulting `SurfaceModel` through the `<a2ui:A2uiSurface>` view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:a2ui="clr-namespace:Syncfusion.Maui.A2UI.Hosting;assembly=Syncfusion.Maui.A2UI"
             x:Class="MauiA2UIApp.MainPage"
             Title="SyncfusionDataGrid sample">

    <ScrollView>
        <VerticalStackLayout Spacing="12" Padding="12">
            <Label Text="SyncfusionDataGrid via A2UI" FontSize="22" FontAttributes="Bold" />
            <a2ui:A2uiSurface x:Name="OrdersSurface" />
        </VerticalStackLayout>
    </ScrollView>

</ContentPage>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight csharp tabtitle="MainPage.xaml.cs" %}

using System.Text.Json;
using Syncfusion.A2UI.Core.Common;
using Syncfusion.A2UI.Core.Processing;
using Syncfusion.A2UI.Core.Serialization;
using Syncfusion.Maui.A2UI.Hosting;

namespace MauiA2UIApp;

public partial class MainPage : ContentPage
{
    private readonly MessageProcessor _processor;
    private readonly SurfaceHost _host;

    public MainPage(MessageProcessor processor, SurfaceHost host)
    {
        InitializeComponent();
        _processor = processor;
        _host = host;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Tear down any prior surface (e.g. on a second visit) before re-creating.
        try { _processor.Model.DeleteSurface("orders"); } catch { /* surface didn't exist */ }

        var messages = A2uiJson.ParseMessages(JsonDocument.Parse(Json).RootElement);
        _processor.ProcessMessages(messages);

        var surface = _processor.Model.GetSurface("orders");
        OrdersSurface.Surface = surface;
        OrdersSurface.Host = _host;
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

                "sortingMode":     "single",
                "allowFiltering":  true,
                "allowGrouping":   true,
                "selectionMode":   "single",
                "navigationMode":  "row",
                "gridLinesVisibility": "both",
                "alternationRowCount": 1,

                "sortDescriptions": [
                  { "columnName": "OrderID", "direction": "ascending" }
                ],

                "columns": [
                  { "mappingName": "OrderID",    "headerText": "Order ID",    "width": 110, "textAlign": "end",   "format": "N0" },
                  { "mappingName": "CustomerID", "headerText": "Customer",    "width": 140 },
                  { "mappingName": "Freight",    "headerText": "Freight",     "width": 120, "textAlign": "end",   "format": "C2" },
                  { "mappingName": "OrderDate",  "headerText": "Order Date",  "width": 150 },
                  { "mappingName": "ShipCountry","headerText": "Ship Country","width": 150 }
                ]
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
}

{% endhighlight %}
{% endtabs %}

![Syncfusion A2UI getting-started output](./images/getting-started.png)

What the snippet does, in order:

1. **MainPage.xaml** declares a `ContentPage` that hosts an `<a2ui:A2uiSurface>` view. The page takes `MessageProcessor` and `SurfaceHost` from the MAUI DI container.
2. **MainPage.xaml.cs** injects `MessageProcessor` and `SurfaceHost` (both registered as singletons by `UseA2uiWithSyncfusionComponents()`).
3. **The JSON envelope** is a static string carrying four A2UI v0.9 messages — `createSurface` → two `updateDataModel` payloads → `updateComponents`. The `updateComponents` mounts a `Column` containing a fully featured `SyncfusionDataGrid` and a `Text` caption wired to `{ "path": "/selectedRowJson" }`. Each message carries its own `version` field per the A2UI v0.9 spec, even though the top-level envelope also has one.
4. **In the page lifecycle (`OnAppearing`)**, the code tears down any prior surface (so re-entering the page doesn't collide on a duplicate `createSurface`), parses the JSON via `A2uiJson.ParseMessages(...)`, calls `Processor.ProcessMessages(...)`, reads the assembled `SurfaceModel` from `Processor.Model.GetSurface("orders")`, and binds both `Surface` and `Host` on the `A2uiSurface` view.
5. **The grid renders** 15 `Orders` rows with single-column sorting, ascending sort by `OrderID`, filtering, grouping, single-row selection, alternating rows, and grid lines — driven from the column schema (`mappingName`, `headerText`, `width`, `format`, `textAlign`).
6. **The `Text` caption under the grid** binds to `/selectedRowJson`. Because the data model seeds that path with `""` and nothing in the sample writes to it, the caption stays empty until you forward grid events to the agent (or write back from a handler). The `<a2ui:A2uiSurface>` is generic — swap `SyncfusionDataGrid` for `SyncfusionCartesianChart`, `SyncfusionScheduler`, `SyncfusionCalendar`, `SyncfusionNumericEntry`, `SyncfusionPdfViewer`, `SyncfusionTreeView`, … and the same pipeline renders it.

> In production, replace the embedded JSON with messages streamed from an [A2UI v0.9-compatible agent](https://a2ui.org/specification/v0.9-a2ui/). See [AI Integration](./ai-integration) for the agent round-trip pattern.

## Run the application

{% tabcontents %}

{% tabcontent Visual Studio %}

Pick an Android emulator, iOS simulator, Mac Catalyst, or Windows machine from the run-target dropdown and press <kbd>F5</kbd> to launch with the debugger (or <kbd>Ctrl</kbd>+<kbd>F5</kbd> without).

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run on your target platform:

```bash
dotnet build -t:Run -f net10.0-android
# or net10.0-ios / net10.0-maccatalyst / net10.0-windows10.0.19041.0
```

{% endtabcontent %}

{% tabcontent .NET CLI %}

Open the command prompt and run:

```bash
dotnet build -t:Run -f net10.0-android
```

{% endtabcontent %}

{% endtabcontents %}

The page renders a Syncfusion® .NET MAUI `SfDataGrid` populated with 15 sample `Orders` rows (Order ID, Customer, Freight, Order Date, Ship Country). The grid enables single-column sorting, filtering, grouping, single-row selection, alternating rows, and grid lines — all driven from a static A2UI v0.9 JSON message list. No agent or backend is involved.

## See also

- [Overview](./overview)
- [AI Integration](./ai-integration)
- [Supported Components](./supported-components)
- [A2UI v0.9 protocol](https://a2ui.org/specification/v0.9-a2ui/)