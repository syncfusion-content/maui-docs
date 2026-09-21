# Nodes

Nodes are the primary visual elements used to represent processes, activities, decisions, documents, and other business entities in a diagram.

A node can be customized using built-in properties for position, size, rotation, annotations, ports, shape, and styling.

This topic is the conceptual reference for the `Node` class. For step-by-step examples, see the [how-to guides](#see-also).

## Prerequisites

Refer to the [Getting started](getting-started.md) page to create a project, install the package, and register the handler.

---

## Node class

A node is created using the `Node` class and added to the `SfDiagram.Nodes` collection.

```csharp
using Syncfusion.Maui.Diagram;

var node = new Node
{
    ID = "node1",
    OffsetX = 200,
    OffsetY = 150,
    Width = 120,
    Height = 60
};

diagram.Nodes.Add(node);
```

## Node properties

| Property | Description |
| --- | --- |
| `ID` | Unique identifier for the node. |
| `OffsetX` | Horizontal center of the node inside the diagram surface. |
| `OffsetY` | Vertical center of the node inside the diagram surface. |
| `Width` | Node width. |
| `Height` | Node height. |
| `RotateAngle` | Rotation in degrees around the node center. |
| `Shape` | Built-in or custom shape assigned to the node. |
| `Style` | Visual style assigned through the `ShapeStyle` class. |
| `Ports` | Collection of `PointPort` connection points. |
| `Annotations` | Collection of `ShapeAnnotation` labels. |

---

## Position nodes

Use `OffsetX` and `OffsetY` to position a node on the diagram surface.

```csharp
node.OffsetX = 300;
node.OffsetY = 200;
```

> **Note**
>
> - Increasing `OffsetX` moves the node toward the right.
> - Increasing `OffsetY` moves the node downward.
> - `OffsetX` and `OffsetY` represent the node center, not the top-left corner.

---

## Resize nodes

Use the `Width` and `Height` properties to size a node.

```csharp
node.Width = 180;
node.Height = 90;
```

---

## Rotate nodes

Use the `RotateAngle` property to rotate a node in degrees.

```csharp
node.RotateAngle = 45;
```

> **Note:** `RotateAngle` rotates the node around its center point.

---

## Style nodes

For a complete beginner guide, see [Style nodes](How-To%20Guides/style-nodes.md). The conceptual styling properties are listed below.

| Property | Description |
| --- | --- |
| `Fill` | Background color. |
| `StrokeColor` | Border color. |
| `StrokeWidth` | Border thickness. |
| `Opacity` | Transparency from `0` (transparent) to `1` (opaque). |
| `StrokeDashArray` | Dash pattern for the border. The accepted value format depends on the package version. |

For connector styling, see the [Connectors](connectors.md) topic.

---

## Basic shapes

The Diagram control provides built-in geometric shapes through the `BasicShape` type and the `NodeBasicShapes` enumeration.

```csharp
node.Shape = new BasicShape
{
    Shape = NodeBasicShapes.Rectangle,
    CornerRadius = 8
};
```

Supported basic shapes:

- Rectangle
- Ellipse
- Hexagon
- Parallelogram
- Triangle
- Plus
- Star
- Pentagon
- Heptagon
- Octagon
- Trapezoid
- Decagon
- RightTriangle
- Cylinder
- Diamond
- Polygon

For full usage examples, see [create basic shapes](How-To%20Guides/create-basic-shapes.md).

---

## Flow shapes

Flowcharts can be built using the `FlowShape` type and the `NodeFlowShapes` enumeration.

```csharp
node.Shape = new FlowShape
{
    Shape = NodeFlowShapes.Process
};
```

For a full list of supported flow shapes and conventions, see [create flow shapes](How-To%20Guides/create-flow-shapes.md).

---

## See also

- [Getting started](getting-started.md)
- [Style nodes](How-To%20Guides/style-nodes.md)
- [Create basic shapes](How-To%20Guides/create-basic-shapes.md)
- [Create flow shapes](How-To%20Guides/create-flow-shapes.md)
- [Add node annotations](annotations.md)
- [Ports](ports.md)