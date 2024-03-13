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
<tr>
<td>{{'[AnnotationMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_AnnotationMode)'| markdownify}}</td>
<td>{{'[AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode)'| markdownify}}</td>
<td>Gets or sets a value indicating the type of annotation that should be drawn using UI interaction on the PDF pages.</td>
</tr>
<tr>
<td>{{'[Annotations](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_AnnotationSettings)'| markdownify}}</td>
<td>{{'[Annotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_Annotations)'| markdownify}}</td>
<td>Gets the list of annotations in the PDF.</td>
</tr>
<tr>
<td>{{'[AnnotationSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_AnnotationSettings)'| markdownify}}</td>
<td>{{'[AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSettings)'| markdownify}}</td>
<td>Gets or sets the default annotation settings.</td>
</tr>
<tr>
<td>{{'[ClearAllAnnotationsCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ClearAllAnnotationsCommand)'| markdownify}}</td>
<td>{{'[RemoveAllAnnotationsCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_RemoveAllAnnotationsCommand)'| markdownify}}</td>
<td>The command that removes all annotations from the PDF document.</td>
</tr>
<tr>
<td>{{'[PerformUndoCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_PerformUndoCommand)'| markdownify}}</td>
<td>{{'[UndoCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_UndoCommand)'| markdownify}}</td>
<td>The command that performs the undo operation.</td>
</tr>
<tr>
<td>{{'[PerformRedoCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_PerformRedoCommand)'| markdownify}}</td>
<td>{{'[RedoCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_RedoCommand)'| markdownify}}</td>
<td>The command that performs the redo operation.</td>
</tr>
<tr>
<td>{{'[InkPointsCollection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotation.html#Syncfusion_SfPdfViewer_XForms_InkAnnotation_InkPointsCollection)'| markdownify}}</td>
<td>{{'[PointsCollection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotation.html#Syncfusion_Maui_PdfViewer_InkAnnotation_PointsCollection)'| markdownify}}</td>
<td>Gets or sets the series of coordinates that represent the ink points of an ink annotation.</td>
</tr>
<tr>
<td>{{'[InkAnnotationSettings.Thickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_Thickness)'| markdownify}}</td>
<td>{{'[InkAnnotationSettings.BorderWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotationSettings.html#Syncfusion_Maui_PdfViewer_InkAnnotationSettings_BorderWidth)'| markdownify}}</td>
<td>Gets or sets the border thickness of an ink annotation.</td>
</tr>
<tr>
<td>{{'[ShapeAnnotationSettings.Thickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotationSettings_Thickness)'| markdownify }}</td>
<td>{{'[ShapeAnnotationSettings.BorderWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ShapeAnnotationSettings.html#Syncfusion_Maui_PdfViewer_ShapeAnnotationSettings_BorderWidth)'| markdownify}}</td>
<td>Gets or sets the border thickness of shape annotation.</td>
</tr>
<tr>
<td>{{'[InkAnnotationSettings.EnableSeparateAttributesForEachStroke](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_EnableSeparateAttributesForEachStroke)'| markdownify}}</td>
<td>{{'[InkAnnotationSettings.AggregateInkStrokes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotationSettings.html#Syncfusion_Maui_PdfViewer_InkAnnotationSettings_AggregateInkStrokes)'| markdownify}}</td>
<td>Gets or sets a value indicating whether each ink strokes should be treated as separate ink annotations.</td>
</tr>
<tr>
<td>{{'[ShapeAnnotationSettings.StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotationSettings_StrokeColor)'| markdownify}}</td>
<td>{{'[ShapeAnnotationSettings.Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationAppearanceSettings.html#Syncfusion_Maui_PdfViewer_AnnotationAppearanceSettings_Color)'| markdownify}}</td>
<td>Gets or sets the default stroke color of shape annotation.</td>
</tr>
<tr>
<td>{{'[SelectorSettings.StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SelectorSettings.html#Syncfusion_SfPdfViewer_XForms_SelectorSettings_StrokeColor)'| markdownify }}</td>
<td>{{'[AnnotationSelectorSettings.Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSelectorSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSelectorSettings_Color)'| markdownify}}</td>
<td>Gets or sets the default color of annotation selector.</td>
</tr>
<tr>
<td>{{'[LockedStrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SelectorSettings.html#Syncfusion_SfPdfViewer_XForms_SelectorSettings_LockedStrokeColor)'| markdownify}}</td>
<td>{{'[LockedColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSelectorSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSelectorSettings_LockedColor)'| markdownify}}</td>
<td>Gets or sets the default color of annotation selector when the selected annotation is locked.</td>
</tr>
<tr>
<td>{{'[LinePoints](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotation.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotation_LinePoints)'| markdownify}}</td>
<td>{{'[LineAnnotation.Points](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.LineAnnotation.html#Syncfusion_Maui_PdfViewer_LineAnnotation_Points)'| markdownify}}</td>
<td>Gets or sets the series of coordinates that represent the starting point and ending point of a line annotation.</td>
</tr>
<tr>
<td>{{'[Rectangle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Rectangle)'| markdownify}}</td>
<td>{{'[ShapeAnnotationSettings.Square](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSettings_Square)'| markdownify}}</td>
<td>Gets or sets the default settings for square annotations.</td>
</tr>
<tr>
<td>{{'[Circle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Circle)'| markdownify}}</td>
<td>{{'[AnnotationSettings.Circle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSettings_Circle)'| markdownify}}</td>
<td>Gets or sets the default settings for circle annotations.</td>
</tr>
<tr>
<td>{{'[Line](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Line)'| markdownify}}</td>
<td>{{'[AnnotationSettings.Line](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSettings_Line)'| markdownify}}</td>
<td>Gets or sets the default settings for line annotations.</td>
</tr>
<tr>
<td>{{'[Arrow](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Arrow)'| markdownify}}</td>
<td>{{'[AnnotationSettings.Arrow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSettings_Arrow)'| markdownify}}</td>
<td>Gets or sets the default settings for arrow annotations.</td>
</tr>
<tr>
<td>{{'[Ink](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Ink)'| markdownify}}</td>
<td>{{'[AnnotationSettings.Ink](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSettings_Ink)'| markdownify}}</td>
<td>Gets or sets the default settings for ink annotations.</td>
</tr>
<tr>
<td>{{'[Stamp](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Stamp)'| markdownify}}</td>
<td>{{'[AnnotationSettings.Stamp](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSettings_Stamp)'| markdownify}}</td>
<td>Gets or sets the default settings for stamp annotations.</td>
</tr>
<tr>
<td>{{'[Selector](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Selector)'| markdownify}}</td>
<td>{{'[AnnotationSettings.Selector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html#Syncfusion_Maui_PdfViewer_AnnotationSettings_Selector)'| markdownify}}</td>
<td>Gets or sets the default settings for the annotation selector.</td>
</tr>
<tr>
<td>{{'[FormField.CanEdit](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.FormField.html#Syncfusion_SfPdfViewer_XForms_FormField_CanEdit)'| markdownify}}</td>
<td>{{'FormField.ReadOnly'| markdownify}}</td>
<td>Gets or sets a value that indicates whether the form field can be edited or not.</td>
</tr>
<tr>
<td>{{'[SignatureFormField.HandwrittenSignature](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SignatureFormField.html#Syncfusion_SfPdfViewer_XForms_SignatureFormField_HandwrittenSignature)'| markdownify}}</td>
<td>{{'SignatureFormField.Signature'| markdownify}}</td>
<td>Gets or sets the ink annotation signature in the signature field.</td>
</tr>
<tr>
<td>{{'[ClientRectangle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ClientRectangle)'| markdownify}}</td>
<td>`ClientRectangle`</td>
<td>Gets the rectangle that represents the client area (viewport) of the control.</td>
</tr>
<tr>
<td>{{'[PageViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_PageViewMode)'| markdownify}}</td>
<td>{{'PageLayoutMode'| markdownify}}</td>
<td>Gets or sets the layout mode in which the pages will be displayed.</td>
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
<td>Occurs when the text search is in progress.</td>
</tr>
<tr>
<td>{{'[TextSelectionCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_TextSelectionCompleted)'| markdownify}}</td>
<td>{{'[TextSelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_TextSelectionChanged)'| markdownify}}</td>
<td>Occurs when the text is selected or when the selected text is changed.</td>
</tr>
<tr>
<td>
<div>{{'[InkAdded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_InkAdded)'| markdownify }},</div>
<div>{{'[ShapeAnnotationAdded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ShapeAnnotationAdded)'| markdownify }},</div>
<div>{{'[StampAnnotationAdded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_StampAnnotationAdded)'| markdownify }},</div>
<div>{{'[TextMarkupAdded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_TextMarkupAdded)'| markdownify }} </div>
</td>
<td>{{'[AnnotationAdded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationAdded)'| markdownify }}</td>
<td>Occurs when an annotation is added to a page.</td>
</tr>
<tr>
<td>
<div>{{'[InkDeselected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_InkDeselected)'| markdownify }},</div>
<div>{{'[ShapeAnnotationDeselected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ShapeAnnotationDeselected)'| markdownify }},</div>
<div>{{'[StampAnnotationDeselected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_StampAnnotationDeselected)'| markdownify }},</div>
<div>{{'[TextMarkupDeselected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_TextMarkupDeselected)'| markdownify }} </div>
</td>
<td>{{'[AnnotationDeselected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationDeselected)'| markdownify }}</td>
<td>Occurs when a selected annotation gets deselected.</td>
</tr>
<tr>
<td>
<div>{{'[InkEdited](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_InkEdited)'| markdownify }},</div>
<div>{{'[ShapeAnnotationEdited](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ShapeAnnotationEdited)'| markdownify }},</div>
<div>{{'[StampAnnotationMovedOrResized](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_StampAnnotationMovedOrResized)'| markdownify }},</div>
<div>{{'[TextMarkupEdited](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_TextMarkupEdited)'| markdownify }} </div>
</td>
<td>{{'[AnnotationEdited](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationEdited)'| markdownify }}</td>
<td>Occurs when annotation is modified.</td>
</tr>
<tr>
<td>
<div>{{'[InkRemoved](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_InkRemoved)'| markdownify }},</div>
<div>{{'[ShapeAnnotationRemoved](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ShapeAnnotationRemoved)'| markdownify }},</div>
<div>{{'[StampAnnotationRemoved](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_StampAnnotationRemoved)'| markdownify }},</div>
<div>{{'[TextMarkupRemoved](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_TextMarkupRemoved)'| markdownify }} </div>
</td>
<td>{{'[AnnotationRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationRemoved)'| markdownify }}</td>
<td>Occurs when an annotation is removed from the page.</td>
</tr>
<tr>
<td>
<div>{{'[InkSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_InkSelected)'| markdownify }},</div>
<div>{{'[ShapeAnnotationSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ShapeAnnotationSelected)'| markdownify }},</div>
<div>{{'[StampAnnotationSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_StampAnnotationSelected)'| markdownify }},</div>
<div>{{'[TextMarkupSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_TextMarkupSelected)'| markdownify }} </div>
</td>
<td>{{'[AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected)'| markdownify }}</td>
<td>Occurs when an annotation is selected.</td>
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
<tr>
<td>{{'[ClearAllAnnotations](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ClearAllAnnotations)'| markdownify}}</td>
<td>{{'[RemoveAllAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_RemoveAllAnnotations)'| markdownify}}</td>
<td>Removes all annotations from the PDF document.</td>
</tr>
<tr>
<td>{{'[AddAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_AddAnnotation_Syncfusion_SfPdfViewer_XForms_IAnnotation_)'| markdownify}}</td>
<td>{{'[AddAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AddAnnotation_Syncfusion_Maui_PdfViewer_Annotation_)'| markdownify}}</td>
<td>Adds the given annotation to the page represented by the annotation’s PageNumber property.</td>
</tr>
<tr>
<td>{{'[DeselectAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_DeselectAnnotation_Syncfusion_SfPdfViewer_XForms_IAnnotation_)'| markdownify}}</td>
<td>{{'[DeselectAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DeselectAnnotation_Syncfusion_Maui_PdfViewer_Annotation_)'| markdownify}}</td>
<td>Deselects the given annotation.</td>
</tr>
<tr>
<td>{{'[ExportAnnotations](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ExportAnnotations_Syncfusion_Pdf_Parsing_AnnotationDataFormat_)'| markdownify}}</td>
<td>{{'[ExportAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ExportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Collections_Generic_List_Syncfusion_Maui_PdfViewer_Annotation__)'| markdownify}}</td>
<td>Exports the annotations in the PDF document to the specified format and writes the exported data to the given output stream.</td>
</tr>
<tr>
<td>{{'[ExportAnnotationsAsync](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ExportAnnotationsAsync_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Threading_CancellationToken_)'| markdownify}}</td>
<td>{{'[ExportAnnotationsAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ExportAnnotationsAsync_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Collections_Generic_List_Syncfusion_Maui_PdfViewer_Annotation__System_Threading_CancellationToken_)'| markdownify}}</td>
<td>Exports the annotations in the PDF document to the specified format and writes the exported data to the given output stream.</td>
</tr>
<tr>
<td>{{'[ImportAnnotations](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ImportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_)'| markdownify}}</td>
<td>{{'[ImportAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ImportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_)'| markdownify}}</td>
<td>Imports annotation data into the PDF document. </td>
</tr>
<tr>
<td>{{'[RemoveAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_RemoveAnnotation_Syncfusion_SfPdfViewer_XForms_IAnnotation_)'| markdownify}}</td>
<td>{{'[RemoveAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_RemoveAnnotation_Syncfusion_Maui_PdfViewer_Annotation_)'| markdownify}}</td>
<td>Removes the given annotation from the page. </td>
</tr>
<tr>
<td>{{'[SaveDocument](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SaveDocument)'| markdownify}}</td>
<td>{{'[SaveDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SaveDocument_System_IO_Stream_)'| markdownify}}</td>
<td>Saves the PDF document and writes the final document into the given output stream.</td>
</tr>
<tr>
<td>{{'[SaveDocumentAsync](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SaveDocumentAsync_System_Threading_CancellationToken_)'| markdownify}}</td>
<td>{{'[SaveDocumentAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SaveDocumentAsync_System_IO_Stream_System_Threading_CancellationToken_)'| markdownify}}</td>
<td>Saves the PDF document and writes the final document into the given output stream.</td>
</tr>
<tr>
<td>{{'[SelectAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_SelectAnnotation_Syncfusion_SfPdfViewer_XForms_IAnnotation_)'| markdownify}}</td>
<td>{{'[SelectAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SelectAnnotation_Syncfusion_Maui_PdfViewer_Annotation_)'| markdownify}}</td>
<td>Selects the given annotation.</td>
</tr>
<tr>
<td>{{'[Print](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_Print)'| markdownify }}</td>
<td>{{'PrintDocument'| markdownify }}</td>
<td>Prints the PDF document.</td>
</tr>
<tr>
<td>{{'[ConvertClientPointToPagePoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ConvertClientPointToPagePoint_Xamarin_Forms_Point_System_Int32_)'| markdownify}}</td>
<td>`ConvertClientPointToPagePoint`</td>
<td>Converts a point from the client area coordinates to PDF page coordinates.</td>
</tr>
<tr>
<td>{{'[ConvertPagePointToClientPoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ConvertPagePointToClientPoint_Xamarin_Forms_Point_System_Int32_)'| markdownify}}</td>
<td>`ConvertPagePointToClientPoint`</td>
<td>Converts a point from PDF page coordinates to client area coordinates.</td>
</tr>
<tr>
<td>{{'[ConvertPagePointToScrollPoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ConvertPagePointToScrollPoint_Xamarin_Forms_Point_System_Int32_)'| markdownify}}</td>
<td>`ConvertPagePointToScrollPoint`</td>
<td>Converts a point from the PDF page coordinates to the scroll area coordinates.</td>
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
<tr>
<td>{{'[TextMarkupAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextMarkupAnnotation.html)'| markdownify }}</td>
<td>
<div>{{'[HighlightAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.HighlightAnnotation.html)'| markdownify }},</div>
<div>{{'[SquigglyAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SquigglyAnnotation.html)'| markdownify }},</div>
<div>{{'[StrikeOutAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.StrikeOutAnnotation.html)'| markdownify }},</div>
<div>{{'[UnderlineAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.UnderlineAnnotation.html)'| markdownify }} </div>
</td>
<td>Represents the textmarkup annotation on the text contents in the page.</td>
</tr>
<tr>
<td>{{'[ShapeAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ShapeAnnotation.html)'| markdownify }}</td>
<td>
<div>{{'[CircleAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.CircleAnnotation.html)'| markdownify }},</div>
<div>{{'[LineAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotation.html)'| markdownify }},</div>
<div>{{'[SquareAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SquareAnnotation.html)'| markdownify }}</div>
</td>
<td>Represents an annotation that displays a shape on the page.</td>
</tr>
<tr>
<td>{{'[PopupAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.PopupAnnotation.html)'| markdownify }}</td>
<td>StickyNoteAnnotation</td>
<td>Represents the sticky note annotation on the text contents in the page.</td>
</tr>
<tr>
<td>
<div>{{'[AnnotationMovedOrResizedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMovedOrResizedEventArgs.html)'| markdownify }},</div>
<div>{{'[InkAddedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAddedEventArgs.html)'| markdownify }},</div>
<div>{{'[InkDeselectedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkDeselectedEventArgs.html)'| markdownify }},</div>
<div>{{'[InkEditedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkEditedEventArgs.html)'| markdownify }},</div>
<div>{{'[InkRemovedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkRemovedEventArgs.html)'| markdownify }},</div>
<div>{{'[InkSelectedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkSelectedEventArgs.html)'| markdownify }},</div>
<div>{{'[ShapeAnnotationAddedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationAddedEventArgs.html)'| markdownify }},</div>
<div>{{'[ShapeAnnotationDeselectedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationDeselectedEventArgs.html)'| markdownify }},</div>
<div>{{'[ShapeAnnotationEditedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationEditedEventArgs.html)'| markdownify }},</div>
<div>{{'[ShapeAnnotationRemovedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationRemovedEventArgs.html)'| markdownify }},</div>
<div>{{'[ShapeAnnotationSelectedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSelectedEventArgs.html)'| markdownify }},</div>
<div>{{'[StampAnnotationAddedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotationAddedEventArgs.html)'| markdownify }},</div>
<div>{{'[StampAnnotationDeselectedEventArgs ](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotationDeselectedEventArgs.html)'| markdownify }},</div>
<div>{{'[StampAnnotationMovedOrResizedEventArgs ](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotationMovedOrResizedEventArgs.html)'| markdownify }},</div>
<div>{{'[StampAnnotationRemovedEventArgs ](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotationRemovedEventArgs.html)'| markdownify }},</div>
<div>{{'[StampAnnotationSelectedEventArgs ](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotationSelectedEventArgs.html)'| markdownify }},</div>
<div>{{'[TextMarkupAddedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextMarkupAddedEventArgs.html)'| markdownify }},</div>
<div>{{'[TextMarkupDeselectedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextMarkupDeselectedEventArgs.html)'| markdownify }},</div>
<div>{{'[TextMarkupEditedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextMarkupEditedEventArgs.html)'| markdownify }},</div>
<div>{{'[TextMarkupRemovedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextMarkupRemovedEventArgs.html)'| markdownify }},</div>
<div>{{'[TextMarkupSelectedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.TextMarkupSelectedEventArgs.html)'| markdownify }}</div>
</td>
<td>{{'[AnnotationEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationEventArgs.html)'| markdownify}}</td>
<td>Provides data for the {{'[AnnotationAdded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationAdded)'| markdownify}}, {{'[AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected)'| markdownify}}, {{'[AnnotationDeselected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationDeselected)'| markdownify}}, {{'[AnnotationEdited](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationEdited)'| markdownify}}, {{'[AnnotationRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationRemoved)'| markdownify}} events.</td>
</tr>
</table>

## Upcoming Features   

* Built-in toolbar
* Themes
* Handwritten signatures
* Thumbnail
* Single page view mode
* Print