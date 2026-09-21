# Overview

The .NET MAUI Diagram control is a versatile component used to create, visualize, and interact with diagrams. It enables developers to build flowcharts, workflow designers, process diagrams, organizational charts, and other graphical applications using nodes, connectors, annotations, ports, and symbol palettes.

The Diagram control provides built-in support for shape rendering, diagram interaction, serialization, exporting, printing, and event notifications, helping developers create rich diagramming experiences with minimal effort.

---

## Key Features

## Nodes

Nodes are the primary visual elements in a diagram and are used to represent processes, tasks, decisions, documents, and other business entities.

### Features

- Create and position nodes.
- Resize and rotate nodes.
- Apply custom styling.
- Display annotations.
- Add connection ports.
- Use built-in shapes.

---

## Connectors

Connectors establish relationships between nodes and represent the flow of information between diagram elements.

### Features

- Connect nodes using identifiers.
- Connect nodes using ports.
- Create straight and orthogonal connectors.
- Customize connector appearance.
- Display connector annotations.
- Add decorators to indicate direction.

---

## Annotations

Annotations provide textual information on nodes and connectors.

### Features

- Add labels to nodes.
- Add labels to connectors.
- Customize text appearance.
- Control text alignment.
- Position text using offset and alignment options.

---

## Ports

Ports define specific connection points on nodes.

### Features

- Create multiple ports.
- Position ports anywhere within a node.
- Control port visibility.
- Connect connectors through ports.
- Create precise workflow connections.

---

## Symbol Palette

The Symbol Palette provides a collection of reusable symbols that can be dragged and dropped onto the diagram canvas.

### Features

- Organize symbols into categories.
- Support drag-and-drop interaction.
- Search symbols.
- Customize symbol size.
- Display flowchart and basic shapes.

---

## Diagram Operations

The diagram provides various built-in operations for manipulating diagram elements.

### Features

- Add and remove objects.
- Copy and paste elements.
- Undo and redo changes.
- Zoom and pan.
- Rotate and scale objects.
- Fit content into the viewport.

---

## Serialization

Diagram content can be saved and restored.

### Features

- Save diagram state.
- Restore previously saved diagrams.
- Preserve nodes, connectors, ports, and annotations.

---

## Export and Print

The Diagram control supports exporting and printing.

### Features

- Export diagram content.
- Print diagram content.
- Share diagram output.

---

## Supported Diagram Elements

The following diagram elements are supported in the current release.

| Element | Description |
|----------|-------------|
| Node | Represents a diagram object. |
| Connector | Represents a relationship between nodes. |
| Shape Annotation | Displays text on nodes. |
| Path Annotation | Displays text on connectors. |
| Point Port | Defines node connection points. |
| Symbol Palette | Displays reusable symbols. |

---

## Supported Connector Types

The Diagram control supports the following connector types.

## Straight

Creates a direct connection between two points.

### Use Cases

- Process diagrams
- Simple workflows
- Network diagrams

---

## Orthogonal

Creates connectors with right-angle segments.

### Use Cases

- Flowcharts
- Business process diagrams
- Approval workflows

---

## Supported Basic Shapes

The following basic shapes are available through the `BasicShape` class.

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

---

## Supported Flow Shapes

The following flowchart shapes are available through the `FlowShape` class.

- Terminator
- Process
- Decision
- Document
- PreDefinedProcess
- PaperTap
- DirectData
- SequentialData
- Sort
- MultiDocument
- Collate
- SummingJunction
- Or
- InternalStorage
- Extract
- ManualOperation
- Merge
- OffPageReference
- SequentialAccessStorage
- Annotation
- Annotation2
- Data
- Card
- Delay
- Preparation
- Display
- ManualInput
- LoopLimit
- StoredData

---

## Common Use Cases

## Flowchart Designer

Create and edit flowcharts using built-in flow shapes, connectors, ports, and annotations.

---

## Workflow Designer

Build business workflow applications with drag-and-drop functionality and reusable symbols.

---

## Approval Process Diagram

Visualize approval processes using process, decision, and connector elements.

---

## Organizational Chart

Represent hierarchical relationships between departments and employees.

---

## Process Mapping

Document business processes using standardized flowchart symbols.

---

## State Transition Diagrams

Represent transitions between states using nodes and connectors.

---

## Architecture Overview

A typical diagram consists of the following building blocks.

```text
SfDiagram
│
├── Nodes
│   ├── Shape
│   ├── Style
│   ├── Ports
│   └── Annotations
│
├── Connectors
│   ├── Type
│   ├── Style
│   ├── Decorators
│   └── Annotations
│
└── Symbol Palette
    └── Symbols
```

---

## Next Steps

To start using the Diagram control:

1. [Create a .NET MAUI application](getting-started.md).
2. Install the Syncfusion Diagram package and register the handler.
3. Create an instance of `SfDiagram` and [add nodes](nodes.md).
4. [Connect nodes](connectors.md) using connectors.
5. Customize nodes with [styles](How-To%20Guides/style-nodes.md), annotations, and ports.

---

## See Also

- [Getting started](getting-started.md)
- [Nodes](nodes.md)
- [Connectors](connectors.md)
- [Annotations](annotations.md)
- [Ports](ports.md)
- [Symbol palette](symbol-palette.md)
- [Diagram operations](diagram-operations.md)
- [Save and load](save-load.md)
- [Export and print](export-print.md)
- [Events](events.md)