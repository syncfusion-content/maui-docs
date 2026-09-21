# Save and load

The Diagram control supports saving the current diagram state and restoring it later. Serialization preserves nodes, connectors, ports, annotations, styles, and connector settings so users can resume their work after closing the application.

For a complete beginner tutorial with persistence and auto-save patterns, see [Save and restore diagram](How-To%20Guides/save-and-restore-diagram.md).

## Prerequisites

Refer to the [Getting started](getting-started.md) page to create a project, install the package, and register the handler. Serialization examples assume that an `SfDiagram` instance named `diagram` is available.

> **Note:** Visit the [save-load API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html) for the package version you use to verify the exact `SaveDiagram` return type and the parameter accepted by `LoadDiagramAsync`.

---

## Serialization members

The following members control serialization on `SfDiagram`.

| Member | Description | Status |
| --- | --- | --- |
| `SaveDiagram` | Returns serialized diagram data. | Implemented (sync). |
| `LoadDiagramAsync` | Restores the diagram from serialized data. | Implemented (async). |

---

## What is saved

The serialized representation contains information about:

- Nodes, including position, size, rotation, shape, and style.
- Connectors, including source, target, type, decorators, and annotations.
- Ports on nodes.
- Annotations on nodes and connectors.
- Visual styling such as `ShapeStyle` and `TextStyle`.

The exact data contract is defined by the package version. Refer to the API documentation to confirm the structure.

---

## Save a diagram

Use `SaveDiagram` to serialize the diagram. Store the returned data using the persistence mechanism that suits your application, such as a file, database, or application settings.

```csharp
var serializedData = diagram.SaveDiagram();
```

A typical pattern is to save in response to a button click:

```csharp
private void SaveButton_Clicked(object sender, EventArgs e)
{
    var data = diagram.SaveDiagram();
    // Persist `data` using your storage solution.
}
```

---

## Load a diagram

Use `LoadDiagramAsync` to restore a previously saved diagram.

```csharp
await diagram.LoadDiagramAsync(serializedData);
```

---

## Load on page appearing

Restore the diagram when the page appears so that users see their previous work automatically.

```csharp
protected override async void OnAppearing()
{
    base.OnAppearing();

    var savedData = await LoadDiagramDataAsync();

    if (savedData is not null)
    {
        await diagram.LoadDiagramAsync(savedData);
    }
}
```

---

## Common scenarios

- **Workflow designers** – Save a user's workflow and reload it when the application restarts.
- **Flowchart templates** – Persist shared templates so that other users can start from a common baseline.
- **Auto-save** – Use the `CollectionChanged` event to detect changes and persist the diagram on a schedule.

---

## Best practices

- Persist `SaveDiagram` data using the storage mechanism that fits your platform and security requirements.
- Validate serialized data before calling `LoadDiagramAsync` to avoid restoring corrupt or outdated content.
- Subscribe to `CollectionChanged` to detect modifications when implementing auto-save.
- Call `FitToPage` after loading a diagram to make sure that all elements are visible.

---

## See also

- [Save and restore diagram](How-To%20Guides/save-and-restore-diagram.md)
- [Diagram operations](diagram-operations.md)
- [Events](events.md)