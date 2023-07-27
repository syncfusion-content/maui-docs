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
<tr>
<td>{{'[BookmarkPaneVisible](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_BookmarkPaneVisible)'| markdownify}}</td>
<td>{{'[IsOutlineViewVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_IsOutlineViewVisible)'| markdownify}}</td>
<td>Gets or sets a value indicating whether the outline view is visible.</td>
</tr>
<tr>
<td>{{'[EnableDocumentLinkAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_EnableDocumentLinkAnnotation)'| markdownify}}</td>
<td>{{'[EnableDocumentLinkNavigation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_EnableDocumentLinkNavigation)'| markdownify}}</td>
<td>Gets or sets a value that indicates whether document link annotations (TOC) in the PDF can be interacted with.</td>
</tr>
<tr>
<td>{{'[AllowHyperlinkNavigation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_AllowHyperlinkNavigation)'| markdownify}}</td>
<td>{{'[EnableHyperlinkNavigation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_EnableHyperlinkNavigation)'| markdownify}}</td>
<td>Gets or sets a value that indicates whether document link annotations (TOC) in the PDF can be interacted with.</td>
</tr>
<tr>
<td>{{'[Bookmarks](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_Bookmarks)'| markdownify}}</td>
<td>{{'[DocumentOutline](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentOutline)'| markdownify}}</td>
<td>Gets the oultline for the document.</td>
</tr>
<tr>
<td>{{'[IsTextSelectionEnabled](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_IsTextSelectionEnabled)'| markdownify}}</td>
<td>{{'[EnableTextSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_EnableTextSelection)'| markdownify}}</td>
<td>Gets or sets a value that indicates whether the text selection is enabled or not. The default value is true.</td>
</tr>
<tr>
<td>{{'[TextSelectionColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextSelectionSettings.html#Syncfusion_SfPdfViewer_XForms_TextSelectionSettings_TextSelectionColor)'| markdownify}}</td>
<td>{{'[HighlightColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSelectionSettings.html#Syncfusion_Maui_PdfViewer_TextSelectionSettings_HighlightColor)'| markdownify}}</td>
<td>Gets or sets the color to highlight the selected text. The default value is <code>Color.FromRgba(0, 0, 205, 80)</code>.</td>
</tr>
<tr>
<td>{{'[CurrentInstanceColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextSearchSettings.html#Syncfusion_SfPdfViewer_XForms_TextSearchSettings_CurrentInstanceColor)'| markdownify}}</td>
<td>{{'[CurrentMatchHighlightColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchSettings.html#Syncfusion_Maui_PdfViewer_TextSearchSettings_CurrentMatchHighlightColor)'| markdownify}}</td>
<td>Gets or sets the color for highlighting the current match of the searched text. The default value is <code>Color.FromRgba(249, 125, 0, 80)</code>.
</td>
</tr>
<tr>
<td>{{'[OtherInstanceColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextSearchSettings.html#Syncfusion_SfPdfViewer_XForms_TextSearchSettings_OtherInstanceColor)'| markdownify}}</td>
<td>{{'[OtherMatchesHighlightColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchSettings.html#Syncfusion_Maui_PdfViewer_TextSearchSettings_OtherMatchesHighlightColor)'| markdownify}}</td>
<td>Gets or sets the color for highlighting the other matches of the searched text. The default value is <code>Color.FromRgba(255, 255, 0, 50)</code>.
</td>
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
<tr>
<td>{{'[SearchInitiated](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SearchInitiated)'| markdownify}}, {{'[SearchCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SearchCompleted)'| markdownify}}</td>
<td>{{'[TextSearchProgress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_TextSearchProgress)'| markdownify }}</td>
<td>Occurs when the text search is in progress.
</td>
</tr>
<tr>
<td>{{'[TextSelectionCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_TextSelectionCompleted)'| markdownify}}</td>
<td>{{'[TextSelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_TextSelectionChanged)'| markdownify}}</td>
<td>Occurs when the text is selected or when the selected text is changed.</td>
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
<tr>
<td>{{'[GoToBookmark](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_GoToBookmark_Syncfusion_Pdf_Interactive_PdfBookmark_)'| markdownify}}</td>
<td>{{'[GoToOutlineElement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToOutlineElement_Syncfusion_Maui_PdfViewer_OutlineElement_)'| markdownify}}</td>
<td>Navigates to the location of the given outline element.</td>
</tr>
<tr>
<td>{{'[SearchText](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SearchText_System_String_)'| markdownify}}</td>
<td>{{'[SearchTextAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SearchTextAsync_System_String_TextSearchOptions_System_Threading_CancellationTokenSource_)'| markdownify}}</td>
<td>Finds and highlights all occurrences of the given text in the PDF document asynchronously.</td>
</tr>
<tr>
<td>{{'[CancelSearch](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_CancelSearch)'| markdownify}}</td>
<td>{{'[Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_Clear)'| markdownify}}</td>
<td>Clears the highlighted searched text in the PDF document and the search information from the results. Also, it cancels the progress while the text search is running.
</td>
</tr>
<tr>
<td>{{'[SearchNext](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SearchNext)'| markdownify}}</td>
<td>{{'[GoToNextMatch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_GoToNextMatch)'| markdownify}}</td>
<td>Navigates to the next match of the searched text.</td>
</tr>
<tr>
<td>{{'[SearchPrevious](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SearchPrevious)'| markdownify}}</td>
<td>{{'[GoToPreviousMatch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSearchResult.html#Syncfusion_Maui_PdfViewer_TextSearchResult_GoToPreviousMatch)'| markdownify}}</td>
<td>Navigates to the previous match of the searched text.</td>
</tr>
</table>

## Classes

<table>
<tr>
<th>Xamarin SfPdfViewer</th>
<th>.NET MAUI SfPdfViewer</th>
<th>Description</th></tr>
<tr>
<td>{{'[TextSelectionCompletedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextSelectionCompletedEventArgs.html)'| markdownify }}</td>
<td>{{'[TextSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TextSelectionChangedEventArgs.html)'| markdownify}}</td>
<td>Provides data for TextSelectionChanged event.</td>
</tr>
<tr>
<td>{{'[UnhandledConditionEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.UnhandledConditionEventArgs.html#Syncfusion_SfPdfViewer_XForms_UnhandledConditionEventArgs)'| markdownify }}</td>
<td>{{'[DocumentLoadFailedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html)'| markdownify }}</td>
<td>Provides data for the {{'[DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed)'| markdownify }} event.</td>
</tr>
</table>

## Upcoming Features   

* Built-in toolbar
* Themes
* Accessibility
* Shape annotations (polygon and polylines)
* Ink eraser tool
* Sticky note annotation
* Free text annotation
* Handwritten signatures
* Form Filling
* Save – Form data
* Undo/Redo – Form data
* Export/Import – Form data
* Thumbnail
* Single page view mode
* Print