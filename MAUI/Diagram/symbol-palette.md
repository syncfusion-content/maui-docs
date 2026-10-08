---
layout: post
title: Symbol Palette in MAUI Diagram | Syncfusion®
description: Learn how to use the SymbolPalette in the Syncfusion® .NET MAUI Diagram control to display reusable symbols and drag them onto diagrams.
platform: maui
control: SfDiagram
documentation: ug
---

# Symbol palette in .NET MAUI Diagram

The Symbol Palette is a UI element that displays reusable symbols. Users drag symbols from the palette onto the diagram surface to create new nodes.

A symbol palette organizes symbols into one or more palettes. Each palette belongs to a logical category, such as **Basic Shapes** or **Flow Shapes**.

## Prerequisites

Refer to the [Getting started](https://help.syncfusion.com/maui/diagram/getting-started) page to create a project, install the package, and register the handler. Symbol examples assume that an [SfDiagram](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html) instance is available.

---

## SymbolPalette control

The [SymbolPalette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SymbolPalette.html) control exposes the implemented members listed below.

| Property | Description | Status |
| --- | --- | --- |
| [EnableSearch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SymbolPalette.html#Syncfusion_Maui_Diagram_SymbolPalette_EnableSearch) | `true` to display a search box above the palettes. | Implemented. |
| [SymbolHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SymbolPalette.html#Syncfusion_Maui_Diagram_SymbolPalette_SymbolHeight) | Height applied to symbols in the palette. | Implemented. |
| [SymbolWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SymbolPalette.html#Syncfusion_Maui_Diagram_SymbolPalette_SymbolWidth) | Width applied to symbols in the palette. | Implemented. |
| [Palettes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SymbolPalette.html#Syncfusion_Maui_Diagram_SymbolPalette_Palettes) | Collection of [Palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html) items. | Implemented. |
| `Width` | Width of the Symbol Palette. | Not implemented in the current release. |
| `Height` | Height of the Symbol Palette. | Not implemented in the current release. |
|[ExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SymbolPalette.html#Syncfusion_Maui_Diagram_SymbolPalette_ExpandMode)| Specifies whether one or multiple palettes can be expanded at a time. Default is DiagramPaletteExpandMode.Multiple. | Implemented. |

> **Note:** `WidthRequest` and `HeightRequest` are still available because they are inherited from the MAUI `View` base class. The `Width` and `Height` properties listed in legacy documents are not implemented on `SymbolPalette` directly. Verify the supported layout properties in the API reference for your package.

![SymbolPalette control](diagram_images/Symbol_palette.png)
---

## Palette class

A [Palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html) represents a category of symbols within the Symbol Palette.

| Property | Description | Status |
| --- | --- | --- |
| [Id](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html#Syncfusion_Maui_Diagram_Palette_Id) | Unique identifier for the palette. | Implemented. |
| [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html#Syncfusion_Maui_Diagram_Palette_Title) | Header text displayed for the palette. | Implemented. |
| [Symbols](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html#Syncfusion_Maui_Diagram_Palette_Symbols) | Collection of nodes shown as symbols. | Implemented. |
| [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html#Syncfusion_Maui_Diagram_Palette_IsExpanded) | Whether the palette is initially expanded. | Implemented. |
| [IconCss](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html#Syncfusion_Maui_Diagram_Palette_IconCss) | Icon associated with the palette. | Implemented. |
| `Height` | Height of the palette. | Not implemented in the current release. |

---

## Add symbols

Symbols are added through the [Palette.Symbols](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Palette.html#Syncfusion_Maui_Diagram_Palette_Symbols) collection. Each symbol is typically a [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Node.html) configured with the desired shape and size.

```csharp
var basicPalette = new Palette
{
    Id = "basicShapes",
    Title = "Basic Shapes"
};

ShapeStyle style = new ShapeStyle();
style.Fill = Colors.CornflowerBlue;
style.StrokeColor = Colors.Black;
style.StrokeWidth = 2;
style.StrokeDashArray = "0,0";


basicPalette.Symbols.Add(
    new Node
    {
        Id = "Rectangle",
        Shape = new BasicShape { Shape = NodeBasicShapes.Rectangle },
        Height = 70,
        Width = 70,
        Style = style
    });

basicPalette.Symbols.Add(
    new Node
    {
        Id = "Ellipse",
        Shape = new BasicShape { Shape = NodeBasicShapes.Ellipse },
        Height = 70, Width = 70,
        Style = style
    });

basicPalette.Symbols.Add(
    new Node
    {
        Id = "Diamond",
        Shape = new BasicShape { Shape = NodeBasicShapes.Diamond },
        Height = 70,
        Width = 70,
        Style = style
    });
```
![basic_palette](diagram_images/Basic_palette.png)
---

## Multiple palettes

The [Palettes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SymbolPalette.html#Syncfusion_Maui_Diagram_SymbolPalette_Palettes) collection holds the palettes that are exposed by the Symbol Palette.

```csharp

// First palette
var basicPalette = new Palette
{
    Id = "basicShapes",
    Title = "Basic Shapes"
};
ShapeStyle style = new ShapeStyle();
style.Fill = Colors.CornflowerBlue;
style.StrokeColor = Colors.Black;
style.StrokeWidth = 2;
style.StrokeDashArray = "0,0";

         
basicPalette.Symbols.Add(
    new Node
    {
        Id = "Rectangle",
        Shape = new BasicShape { Shape = NodeBasicShapes.Rectangle },
        Height = 70,
        Width = 70,
        Style = style
    });

basicPalette.Symbols.Add(
    new Node
    {
        Id = "Ellipse",
        Shape = new BasicShape { Shape = NodeBasicShapes.Ellipse },
        Height = 70, Width = 70,
        Style = style
    });

basicPalette.Symbols.Add(
    new Node
    {
        Id = "Diamond",
        Shape = new BasicShape { Shape = NodeBasicShapes.Diamond },
        Height = 70,
        Width = 70,
        Style = style
    });

// First palette
var flowPalette = new Palette
{
    Id = "flowPalette",
    Title = "Flow Shapes"
};

flowPalette.Symbols.Add(
    new Node
    {
        Id = "Rectangle",
        Shape = new FlowShape { Shape = NodeFlowShapes.Annotation },
        Height = 70,
        Width = 70,
        Style = style
    });

flowPalette.Symbols.Add(
    new Node
    {
        Id = "Ellipse",
        Shape = new FlowShape { Shape = NodeFlowShapes.PaperTap },
        Height = 70,
        Width = 70,
        Style = style
    });

flowPalette.Symbols.Add(
    new Node
    {
        Id = "Diamond",
        Shape = new FlowShape { Shape = NodeFlowShapes.SequentialAccessStorage },
        Height = 70,
        Width = 70,
        Style = style
    });

symbolPalette.Palettes = new ObservableCollection<Palette>
{
    basicPalette, flowPalette

};

```
![multiple_palette](diagram_images/multiple_palettes.png)
---

## Search

Enable search to help users locate a symbol quickly when a palette contains many entries.

```csharp

symbolPalette.EnableSearch = true;

```
![Symbol Search](diagram_images/symbol_search.png)
Supported symbol dimensions such as `SymbolWidth` and `SymbolHeight` control how each symbol is rendered inside the palette.

---

## Layout the palette

Because the `SymbolPalette.Width` and `SymbolPalette.Height` properties are not implemented, use MAUI layout properties to size the control.

```XAML
<diagram:SymbolPalette
    x:Name="symbolPalette"
    WidthRequest="250" />
```

If `SymbolPalette` is hosted inside a layout container such as `Grid`, set the row or column size to control the height.

---