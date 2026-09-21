# Symbol palette

The Symbol Palette is a UI element that displays reusable symbols. Users drag symbols from the palette onto the diagram surface to create new nodes.

A symbol palette organizes symbols into one or more palettes. Each palette belongs to a logical category, such as **Basic Shapes** or **Flow Shapes**.

## Prerequisites

Refer to the [Getting started](getting-started.md) page to create a project, install the package, and register the handler. Symbol examples assume that an `SfDiagram` instance is available.

---

## SymbolPalette control

The `SymbolPalette` control exposes the implemented members listed below.

| Property | Description | Status |
| --- | --- | --- |
| `EnableSearch` | `true` to display a search box above the palettes. | Implemented. |
| `SymbolHeight` | Height applied to symbols in the palette. | Implemented. |
| `SymbolWidth` | Width applied to symbols in the palette. | Implemented. |
| `Palettes` | Collection of `Palette` items. | Implemented. |
| `Width` | Width of the Symbol Palette. | Not implemented in the current release. |
| `Height` | Height of the Symbol Palette. | Not implemented in the current release. |

> **Note:** `WidthRequest` and `HeightRequest` are still available because they are inherited from the MAUI `View` base class. The `Width` and `Height` properties listed in legacy documents are not implemented on `SymbolPalette` directly. Verify the supported layout properties in the API reference for your package.

---

## Palette class

A `Palette` represents a category of symbols within the Symbol Palette.

| Property | Description | Status |
| --- | --- | --- |
| `ID` | Unique identifier for the palette. | Implemented. |
| `Title` | Header text displayed for the palette. | Implemented. |
| `Symbols` | Collection of nodes shown as symbols. | Implemented. |
| `Expanded` | Whether the palette is initially expanded. | Implemented. |
| `IconCss` | Icon associated with the palette. | Implemented. |
| `Height` | Height of the palette. | Not implemented in the current release. |

---

## Add symbols

Symbols are added through the `Palette.Symbols` collection. Each symbol is typically a `Node` configured with the desired shape and size.

```csharp
var basicPalette = new Palette
{
    ID = "basicShapes",
    Title = "Basic Shapes"
};

basicPalette.Symbols.Add(
    new Node
    {
        ID = "Rectangle",
        Shape = new BasicShape { Shape = NodeBasicShapes.Rectangle }
    });

basicPalette.Symbols.Add(
    new Node
    {
        ID = "Ellipse",
        Shape = new BasicShape { Shape = NodeBasicShapes.Ellipse }
    });

basicPalette.Symbols.Add(
    new Node
    {
        ID = "Diamond",
        Shape = new BasicShape { Shape = NodeBasicShapes.Diamond }
    });
```

---

## Multiple palettes

The `Palettes` collection holds the palettes that are exposed by the Symbol Palette.

```csharp
symbolPalette.Palettes = new ObservableCollection<Palette>
{
    basicPalette,
    flowPalette
};
```

---

## Search

Enable search to help users locate a symbol quickly when a palette contains many entries.

```csharp
symbolPalette.EnableSearch = true;
```

Supported symbol dimensions such as `SymbolWidth` and `SymbolHeight` control how each symbol is rendered inside the palette.

---

## Layout the palette

Because the `SymbolPalette.Width` and `SymbolPalette.Height` properties are not implemented, use MAUI layout properties to size the control.

```xml
<diagram:SymbolPalette
    x:Name="symbolPalette"
    WidthRequest="250" />
```

If `SymbolPalette` is hosted inside a layout container such as `Grid`, set the row or column size to control the height.

---