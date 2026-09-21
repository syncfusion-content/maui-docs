# Export and print

The Diagram control supports exporting the current diagram and sending it to the system printing pipeline. These capabilities let users share, archive, review, and distribute diagram content outside the application.

For step-by-step examples and platform notes, see the linked API references and the how-to guides.

> **Note:** Visit the [export-print API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html) for your package version to confirm the export format parameters and platform availability.

## Prerequisites

Refer to the [Getting started](getting-started.md) page to create a project, install the package, and register the handler. Export and print examples assume that an `SfDiagram` instance named `diagram` is available.

---

## Export members

| Member | Description | Status |
| --- | --- | --- |
| `ExportDiagramAsync` | Exports the diagram to a file or stream. | Implemented (async). |

> **Note:** `ExportDiagram` is not implemented as a synchronous method in the current release. Use `ExportDiagramAsync` instead.

---

## Print members

| Member | Description | Status |
| --- | --- | --- |
| `PrintAsync` | Sends the diagram to the system printing pipeline. | Implemented (async). |

> **Note:** `Print` is not implemented as a synchronous method in the current release. Use `PrintAsync` instead.

---

## Export the diagram

Exporting creates an external representation of the diagram that can be shared with stakeholders. Common use cases include attaching diagrams to reports, archiving workflow definitions, and reviewing diagrams offline.

```csharp
await diagram.ExportDiagramAsync();
```

A typical application exports the latest diagram when the user clicks an **Export** button:

```csharp
private async void ExportButton_Clicked(object sender, EventArgs e)
{
    await diagram.ExportDiagramAsync();
}
```

Call `FitToPage` before exporting if you want the visible area to be exported:

```csharp
diagram.FitToPage();
await diagram.ExportDiagramAsync();
```

---

## Print the diagram

Printing is available through `PrintAsync`. Common use cases include discussions, design reviews, process workshops, and physical archives.

```csharp
await diagram.PrintAsync();
```

Call `FitToPage` before printing if needed:

```csharp
diagram.FitToPage();
await diagram.PrintAsync();
```

> **Note:** Printing on mobile platforms depends on the underlying operating system support. Validate the supported platforms in the API reference for your package.

---

## Best practices

- Use the asynchronous `ExportDiagramAsync` and `PrintAsync` methods to keep the UI thread responsive.
- Call `FitToPage` before exporting or printing to make sure that all elements are visible.
- Combine export and print with save and load to support versioned archives of diagrams.
- Verify the supported export formats and printing platforms against the API reference for the package version in use.

---

## See also

- [Save and load](save-load.md)
- [Diagram operations](diagram-operations.md)
- [Getting started](getting-started.md)