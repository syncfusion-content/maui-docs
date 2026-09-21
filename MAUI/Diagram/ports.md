---
layout: post
title: Ports in MAUI Diagram | Syncfusion®
description: Learn how to add and customize PointPort connections in the Syncfusion® .NET MAUI Diagram control for precise node connector interactions.
platform: diagram-sdk
control: SfDiagram
documentation: ug
---

# Ports in .NET MAUI Diagram

Ports define specific connection points on a node. They provide precise control over where connectors begin and terminate, helping users build structured and visually organized diagrams.

Ports are commonly used in workflow designers, flowcharts, process diagrams, and node-based editors where connection locations must be predictable.

## Prerequisites

Refer to the [Getting started](getting-started.md) page to create a project, install the package, and register the handler. Port examples assume that the host node has been created in the diagram.

---

## Port class

A port is created using the `PointPort` class and added to the `Node.Ports` collection.

```csharp
using Syncfusion.Maui.Diagram;

var node = new Node
{
    ID = "node1",
    Width = 120,
    Height = 60
};

node.Ports.Add(
    new PointPort
    {
        ID = "TopPort"
    });
```

## Port properties

| Property | Description |
| --- | --- |
| `ID` | Unique identifier for the port within the host node. |
| `Offset` | Port position. The accepted coordinate type depends on the package version. |
| `Visibility` | Controls when the port is visible through the `PortVisibility` enumeration. |
| `Style` | Visual style for the port based on the `ShapeStyle` class. |

> **Note:** The `Offset` type is implemented in a different class than `DiagramPoint`. Verify the supported type in the API reference for your package version.

---

## Position ports

`Offset` values are typically normalized from `0` to `1` on each axis relative to the host node's bounds.

| Axis | `0` | `1` |
| --- | --- | --- |
| `X` | Left edge | Right edge |
| `Y` | Top edge | Bottom edge |

Common port placements:

| Port | Offset |
| --- | --- |
| Top center | `X = 0.5`, `Y = 0` |
| Left center | `X = 0`, `Y = 0.5` |
| Right center | `X = 1`, `Y = 0.5` |
| Bottom center | `X = 0.5`, `Y = 1` |
| Center | `X = 0.5`, `Y = 0.5` |

---

## Port visibility

The `Visibility` property determines when a port is displayed.

| Visibility | Description |
| --- | --- |
| `Visible` | The port is always visible. |
| `Hidden` | The port is never displayed. |
| `Hover` | The port becomes visible when the pointer hovers over the node. |
| `Connect` | The port becomes visible during connection operations. |

```csharp
port.Visibility = PortVisibility.Visible;
port.Visibility = PortVisibility.Hidden;
port.Visibility = PortVisibility.Hover;
port.Visibility = PortVisibility.Connect;
```

---

## Style ports

Port appearance is customized through the `ShapeStyle` class.

```csharp
port.Style = new ShapeStyle
{
    Fill = Colors.LightBlue,
    StrokeColor = Colors.DarkBlue,
    StrokeWidth = 2,
    Opacity = 1
};
```

| Property | Description |
| --- | --- |
| `Fill` | Port background color. |
| `StrokeColor` | Port border color. |
| `StrokeWidth` | Border thickness. |
| `Opacity` | Port transparency from `0` to `1`. |
| `StrokeDashArray` | Dash pattern for the border. The accepted value format depends on the package version. |

---

## Connect through ports

Connectors reference source and target ports through `SourcePortID` and `TargetPortID`.

```csharp
Connector connector = new Connector
{
    ID = "connector1",
    SourceID = "node1",
    SourcePortID = "RightPort",
    TargetID = "node2",
    TargetPortID = "LeftPort"
};
```

---

## Multiple ports

A node can contain any number of ports, each scoped to the host node by its `ID`.

```csharp
node.Ports.Add(new PointPort { ID = "TopPort",    Offset = new DiagramPoint { X = 0.5, Y = 0 } });
node.Ports.Add(new PointPort { ID = "BottomPort", Offset = new DiagramPoint { X = 0.5, Y = 1 } });
node.Ports.Add(new PointPort { ID = "LeftPort",   Offset = new DiagramPoint { X = 0,   Y = 0.5 } });
node.Ports.Add(new PointPort { ID = "RightPort",  Offset = new DiagramPoint { X = 1,   Y = 0.5 } });
```

> **Note:** `DiagramPoint` is not implemented in the current release. Verify the supported coordinate type for port positioning before using this property.

---

## Best practices

- Use the same `ID` scheme (`TopPort`, `BottomPort`, `LeftPort`, `RightPort`) for ports across similar nodes so that connectors can be reused in symbol palettes.
- Use `PortVisibility.Hover` or `PortVisibility.Connect` to keep the diagram surface clean when ports are not actively used.
- Combine ports with orthogonal connectors to keep workflow diagrams aligned and predictable.

---

## See also

- [Nodes](nodes.md)
- [Connectors](connectors.md)