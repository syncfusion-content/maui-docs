# PdfViewer Sample

A getting-started sample for the Syncfusion .NET MAUI `SfPdfViewer` control.

## What it is

The `SfPdfViewer` enables loading, viewing, navigating, zooming, and interacting with PDF documents within a .NET MAUI application.

## NuGet package

`Syncfusion.Maui.PdfViewer`

## Documentation

https://help.syncfusion.com/maui/pdf-viewer/getting-started

## Sample organization

- `PdfViewerPage.xaml` — the page hosting the `SfPdfViewer` control.
- `PdfViewerPage.xaml.cs` — contains page initialization and related view logic.
- `PdfViewerViewModel.cs` — provides PDF document source and view model logic.
- `Pdf/PDF_Succinctly.pdf` — sample PDF document loaded into the viewer.

## Layout and sample data

The sample displays the `PDF Succinctly` document using the `SfPdfViewer` control. The viewer fills the page content area and supports built-in PDF viewing features such as page navigation, zooming, scrolling, text selection, and annotation interaction.

## Document loading and unloading

- `Pdf/PDF_Succinctly.pdf` is included in the project as an `EmbeddedResource` (a CLI-managed `<EmbeddedResource>` item with a fixed logical name is added to the `.csproj`). The view model opens it with `GetManifestResourceStream`, so the document loads without any network access.
- The page calls `UnloadDocument()` in `OnDisappearing`, disposing the stream and releasing the document when the sample page is left. Reopening the sample reloads the document.