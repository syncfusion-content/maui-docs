# Annotations

Annotations display textual information on nodes and connectors. They help describe diagram elements and improve the readability of a diagram.

The Diagram control supports two annotation types:

- **Node annotations** – Use `ShapeAnnotation` for nodes.
- **Connector annotations** – Use `PathAnnotation` for connectors.

Annotations can be customized using the `TextStyle` class and alignment options.

> **Note:** The `TextAlign` property on `TextStyle` and the `TextDecoration` property on `TextStyle` are scheduled for a future release. They are not available in the current package version.

## Prerequisites

Refer to the [Getting started](getting-started.md) page to create a project, install the package, and register the handler. Annotation examples assume that the host node or connector has been assigned to an `SfDiagram` instance.

---

## Node annotations

Node annotations display text within or around a node. They are added through the `Node.Annotations` collection.

```csharp
using Syncfusion.Maui.Diagram;

var node = new Node
{
    ID = "ProcessNode",
    OffsetX = 200,
    OffsetY = 150,
    Width = 120,
    Height = 60
};

node.Annotations.Add(
    new ShapeAnnotation
    {
        Content = "Process Order"
    });
```

A node can contain multiple annotations:

```csharp
node.Annotations.Add(
    new ShapeAnnotation
    {
        ID = "title",
        Content = "Order Processing"
    });

node.Annotations.Add(
    new ShapeAnnotation
    {
        ID = "status",
        Content = "Pending"
    });
```

---

## Connector annotations

Connector annotations display text along a connector path. They are added through the `Connector.Annotations` collection.

```csharp
var connector = new Connector
{
    ID = "connector1",
    SourceID = "node1",
    TargetID = "node2"
};

connector.Annotations.Add(
    new PathAnnotation
    {
        Content = "Approved"
    });
```

---

## Annotation properties

The following properties apply to both `ShapeAnnotation` and `PathAnnotation`.

| Property | Description |
| --- | --- |
| `ID` | Unique identifier for the annotation. |
| `Content` | Display text for the annotation. |
| `Style` | Text style based on the `TextStyle` class. |
| `Offset` | Position of the annotation. Node annotations use node-relative coordinates; connector annotations use path-relative coordinates. |
| `HorizontalAlignment` | Horizontal alignment through the `HorizontalAlignment` enumeration. |
| `VerticalAlignment` | Vertical alignment through the `VerticalAlignment` enumeration. |

> **Note:** The `Offset` property on `ShapeAnnotation` exposes `OffsetX` and `OffsetY` values. The point type used by `PathAnnotation.Offset` should be verified against the package version you use.

### Horizontal and vertical alignment

| Horizontal | Vertical |
| --- | --- |
| `Left` | `Top` |
| `Center` | `Center` |
| `Right` | `Bottom` |
| `Stretch` | `Stretch` |
| `Auto` | `Auto` |

---

## Style annotations

Annotation appearance is customized through the `TextStyle` class.

### TextStyle properties

| Property | Description |
| --- | --- |
| `FontFamily` | Font family for the annotation text. |
| `FontSize` | Text size in device-independent units. |
| `Color` | Text color. |
| `Fill` | Background color behind the text. |
| `Bold` | `true` for bold text. `false` otherwise. |
| `Italic` | `true` for italic text. `false` otherwise. |

### Example

```csharp
node.Annotations.Add(
    new ShapeAnnotation
    {
        Content = "Process",
        Style = new TextStyle
        {
            FontFamily = "Arial",
            FontSize = 14,
            Color = Colors.Black,
            Fill = Colors.LightYellow,
            Bold = true,
            Italic = false
        }
    });
```

---

## Position annotations

### Node annotation positions

For `ShapeAnnotation`, the `Offset` value uses node-relative coordinates.

| Position | Offset values |
| --- | --- |
| Top center | `OffsetX = 0.5`, `OffsetY = 0` |
| Left center | `OffsetX = 0`, `OffsetY = 0.5` |
| Right center | `OffsetX = 1`, `OffsetY = 0.5` |
| Bottom center | `OffsetX = 0.5`, `OffsetY = 1` |
| Center | `OffsetX = 0.5`, `OffsetY = 0.5` |

### Connector annotation positions

For `PathAnnotation`, the `Offset.X` value is a normalized position along the connector path from `0` (start) to `1` (end). The `Offset.Y` value places the label perpendicular to the connector. The exact behavior should be verified against the current package version.

---

## See also

- [Nodes](nodes.md)
- [Connectors](connectors.md)