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
<td>{{'[Unload](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_Unload)'| markdownify }}</td>
<td>{{'[UnloadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_UnloadDocument)'| markdownify }}</td>
<td>Unload the current PDF document.</td>
</tr>
</table>

## Upcoming Features   

* Built-in toolbar
* Themes
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