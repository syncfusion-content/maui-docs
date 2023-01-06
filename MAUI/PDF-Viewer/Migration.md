---
layout: post
title: Migrate from Xamarin SfPdfViewer to .NET MAUI SfPdfViewer | Syncfusion 
description: Learn here all about migrating from Syncfusion Xamarin SfPdfViewer to Syncfusion .NET MAUI SfPdfViewer control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
--- 

# Migrate from Xamarin.Forms SfPdfViewer to .NET MAUI SfPdfViewer

To make migration from [Xamarin SfPdfViewer](https://www.syncfusion.com/xamarin-ui-controls/xamarin-pdf-viewer) to [.NET MAUI SfPdfViewer](https://www.syncfusion.com/maui-controls/maui-pdf-viewer) easier, we kept most of the APIs from Xamarin SfPdfViewer in MAUI SfPdfViewer. However, to maintain the consistency of API naming in MAUI SfPdfViewer, we renamed some of the APIs. The APIs that have been changed in MAUI SfPdfViewer from Xamarin SfPdfViewer are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfPdfViewer</th>
<th>.NET MAUI SfPdfViewer</th></tr>
<tr>
<td>Syncfusion.SfPdfViewer.XForms</td>
<td>Syncfusion.Maui.PdfViewer</td></tr>
</table>

## Properties

<table>
<tr>
<th>Xamarin SfPdfViewer</th>
<th>.NET MAUI SfPdfViewer</th>
<th>Description</th></tr>
<tr>
<td>{{'[InputFileStream](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_InputFileStream)'| markdownify }}</td>
<td>{{'[DocumentSource  ](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource)'| markdownify }}</td>
<td>Represents the source object to load PDF files from the stream or byte array. This property helps to load a PDF document during control initialization and switch the documents dynamically.</td>
</tr>
<tr>
<td>{{'[GoToPageCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_GoToPageCommand)'| markdownify }}</td>
<td>{{'[GoToPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToPageCommand)'| markdownify }}</td>
<td>Represents a command to navigate to the specified page of the PDF document.</td>
</tr>
<tr>
<td>{{'[GoToNextPageCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_GoToNextPageCommand)'| markdownify }}</td>
<td>{{'[GoToNextPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToNextPageCommand)'| markdownify }}</td>
<td>Represents a command to navigate to the next page of the PDF document.</td>
</tr>
<tr>
<td>{{'[GoToPreviousPageCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_GoToPreviousPageCommand)'| markdownify }}</td>
<td>{{'[GoToPreviousPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToPreviousPageCommand)'| markdownify }}</td>
<td>Represents a command to navigate to the previous page of the PDF document.</td>
</tr>
<tr>
<td>{{'[HorizontalOffset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_HorizontalOffset)'| markdownify }}</td>
<td>{{'[HorizontalOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_HorizontalOffset)'| markdownify }}</td>
<td>Returns the current horizontal scrolled position of the `SfPdfViewer`.</td>
</tr>
<tr>
<td>{{'[VerticalOffset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_VerticalOffset)'| markdownify }}</td>
<td>{{'[VerticalOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_VerticalOffset)'| markdownify }}</td>
<td>Returns the current vertical scrolled position of the `SfPdfViewer`.</td>
</tr>
<tr>
<td>{{'[ZoomPercentage](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ZoomPercentage)'| markdownify }}</td>
<td>{{'[ZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ZoomFactor)'| markdownify }}</td>
<td>Returns and sets the zoom factor. The default value is 1, which represents 100% zoom. This value can be between 1 and 4.</td>
</tr>
<tr>
<td>{{'[MinimumZoomPercentage](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_MinimumZoomPercentage)'| markdownify }}</td>
<td>{{'[MinZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MinZoomFactor)'| markdownify }}</td>
<td>Returns and sets the minimum zoom factor. The default value is 0.25. This value should not exceed `MaxZoomFactor`.</td>
</tr>
<tr>
<td>{{'[MaximumZoomPercentage](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_MaximumZoomPercentage)'| markdownify }}</td>
<td>{{'[MaxZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MaxZoomFactor)'| markdownify }}</td>
<td>Returns and sets the maximum zoom factor. The default value is 4. This value should not be lower than `MinZoomFactor`.</td>
</tr>
<tr>
<td>{{'[PageNumber](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_PageNumber)'| markdownify }}</td>
<td>{{'[PageNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_PageNumber)'| markdownify }}</td>
<td>Returns the current page number.</td>
</tr>
<tr>
<td>{{'[PageCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_PageCount)'| markdownify }}</td>
<td>{{'[PageCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_PageCount)'| markdownify }}</td>
<td>Returns the total number of pages in the PDF document.</td>
</tr>
<tr>
<td>{{'[EnableScrollHead](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_EnableScrollHead)'| markdownify }}</td>
<td>{{'[ShowScrollHead](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ShowScrollHead)'| markdownify }}</td>
<td>Returns and sets the value indicating whether the scroll head can be shown or not.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfPdfViewer</th>
<th>.NET MAUI SfPdfViewer</th>
<th>Description</th></tr>
<tr>
<td>{{'[DocumentLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_DocumentLoaded)'| markdownify }}</td>
<td>{{'[DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded)'| markdownify }}</td>
<td>Occurs when a PDF document is loaded.</td>
</tr>
<tr>
<td>{{'[UnhandledConditionOccurred](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_UnhandledConditionOccurred)'| markdownify }}</td>
<td>{{'[DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed)'| markdownify }}</td>
<td>Occurs when the PDF Viewer fails to load a PDF document. That is, when any corrupted document is loaded, when any password-protected document is loaded with an invalid or empty password, or when any non-PDF document is loaded.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfPdfViewer</th>
<th>.NET MAUI SfPdfViewer</th>
<th>Description</th></tr>
<tr>
<td>{{'[GoToPage](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_GoToPage_System_Int32_)'| markdownify }}</td>
<td>{{'[GoToPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToPage_System_Int32_)'| markdownify }}</td>
<td>Navigate to the specified page of the document.</td>
</tr>
<tr>
<td>{{'[GoToNextPage](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_GoToNextPage)'| markdownify }}</td>
<td>{{'[GoToNextPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToNextPage)'| markdownify }}</td>
<td>Navigate to the next page of the PDF document.</td>
</tr>
<tr>
<td>{{'[GoToPreviousPage](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_GoToPreviousPage)'| markdownify }}</td>
<td>{{'[GoToPreviousPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToPreviousPage)'| markdownify }}</td>
<td>Navigate to the previous page of the document.</td>
</tr>
<tr>
<td>{{'[LoadDocument](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_LoadDocument_System_IO_Stream_System_String_)'| markdownify }}</td>
<td>{{'[LoadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_LoadDocument_System_IO_Stream_System_String_)'| markdownify }}</td>
<td>Load the PDF document from the specified stream.</td>
</tr>
<tr>
<td>{{'[LoadDocumentAsync](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_LoadDocumentAsync_System_IO_Stream_System_String_System_Threading_CancellationTokenSource_)'| markdownify }}</td>
<td>{{'[LoadDocumentAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_LoadDocumentAsync_System_IO_Stream_System_String_System_Threading_CancellationTokenSource_)'| markdownify }}</td>
<td>Load the PDF document asynchronously from the specified stream.</td>
</tr>
<tr>
<td>{{'[ScrollToOffset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ScrollToOffset_System_Single_System_Single_)'| markdownify }}</td>
<td>{{'[ScrollToOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ScrollToOffset_System_Double_System_Double_)'| markdownify }}</td>
<td>Scroll the content to the specified offset position.</td>
</tr>
<tr>
<td>{{'[Unload](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_Unload)'| markdownify }}</td>
<td>{{'[UnloadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_UnloadDocument)'| markdownify }}</td>
<td>Unload the current PDF document.</td>
</tr>
</table>

## Upcoming Features   

* Built-in toolbar
* Text search
* Text selection and copy
* Bookmark navigation
* Document link or Table of Contents navigation
* Hyperlink navigation
* Right-to-Left (RTL)
* Themes
* Localization
* Accessibility
* Text markup annotations
* Shape annotations
* Ink or Free hand drawing annotation
* Ink eraser tool
* Sticky note annotation
* Free text annotation
* Stamp annotation
* Handwritten signatures
* Lock annotations
* Form Filling
* Save – Form data and Annotations
* Undo/Redo – Form data and Annotations
* Export/Import – Form data and Annotations
* Thumbnail
* Single page view mode
* Print
