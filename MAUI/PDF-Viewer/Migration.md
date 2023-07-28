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
<td>{{'[Arrow](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Arrow)'| markdownify}}</td>
<td>Arrow</td>
<td>Represents the annotation mode for drawing arrow shape.</td>
</tr>
<tr>
<td>{{'[Circle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Circle)'| markdownify}}</td>
<td>Circle</td>
<td>Represents the annotation mode for drawing circle shape.</td>
</tr>
<tr>
<td>{{'[Highlight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Highlight)'| markdownify}}</td>
<td>Highlight</td>
<td>Represents the annotation mode for highlighting text.</td>
</tr>
<tr>
<td>{{'[Ink](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Ink)'| markdownify}}</td>
<td>Ink</td>
<td>Represents the annotation mode for drawing free hand inks.</td>
</tr>
<tr>
<td>{{'[Line](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Line)'| markdownify}}</td>
<td>Line</td>
<td>Represents the annotation mode for drawing line shape.</td>
</tr>
<tr>
<td>{{'[None](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_None)'| markdownify}}</td>
<td>None</td>
<td>Represents the mode in which no annotation can be drawn.</td>
</tr>
<tr>
<td>{{'[Rectangle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Rectangle)'| markdownify}}</td>
<td>Square</td>
<td>Represents the annotation mode for drawing square shape.</td>
</tr>
<tr>
<td>{{'[Squiggly](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Squiggly)'| markdownify}}</td>
<td>Squiggly</td>
<td>Represents the annotation mode for adding squiggly lines on the text.</td>
</tr>
<tr>
<td>{{'[Strikethrough](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Strikethrough)'| markdownify}}</td>
<td>StrikeOut</td>
<td>Represents the annotation mode for striking out text.</td>
</tr>
<tr>
<td>{{'[Underline](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationMode.html#Syncfusion_SfPdfViewer_XForms_AnnotationMode_Underline)'| markdownify}}</td>
<td>Underline</td>
<td>Represents the annotation mode for underlining text.</td>
</tr>
<tr>
<td>{{'[InkPointsCollection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotation.html#Syncfusion_SfPdfViewer_XForms_InkAnnotation_InkPointsCollection)'| markdownify}}</td>
<td>Points Collection</td>
<td>Gets or sets the series of coordinates that represent the ink points of an ink annotation.</td>
</tr>
<tr>
<td>{{'[Bounds](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotation.html#Syncfusion_SfPdfViewer_XForms_InkAnnotation_Bounds)'| markdownify}}</td>
<td>InkAnnotation.Bounds</td>
<td>Gets or sets the bounds for the ink annotation.</td>
</tr>
<tr>
<td>{{'[Bounds](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotation.html#Syncfusion_SfPdfViewer_XForms_StampAnnotation_Bounds)'| markdownify}}</td>
<td>StampAnnotation.Bounds</td>
<td>Gets or sets the bounds for the stamp annotation.</td>
</tr>
<tr>
<td>{{'[Bounds](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotation.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotation_Bounds)'| markdownify}}</td>
<td>ShapeAnnotation.Bounds</td>
<td>Gets or sets the bounds for the shape annotation.</td>
</tr>
<tr>
<td>{{'[Name](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotation.html#Syncfusion_SfPdfViewer_XForms_InkAnnotation_Name)'| markdownify}}</td>
<td>InkAnnotation.Name</td>
<td>Gets or sets the name of an annotation.</td>
</tr>
<tr>
<td>{{'[Name](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotation.html#Syncfusion_SfPdfViewer_XForms_StampAnnotation_Name)'| markdownify}}</td>
<td>StampAnnotation.Name</td>
<td>Gets or sets the name of an annotation.</td>
</tr>
<tr>
<td>{{'[Name](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotation.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotation_Name)'| markdownify}}</td>
<td>ShapeAnnotation.Name</td>
<td>Gets or sets the name of an annotation.</td>
</tr>
<tr>
<td>{{'[PageNumber](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotation.html#Syncfusion_SfPdfViewer_XForms_InkAnnotation_PageNumber)'| markdownify}}</td>
<td>InkAnnotation.PageNumber</td>
<td>Gets the page number of an annotation.</td>
</tr>
<tr>
<td>{{'[PageNumber](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotation.html#Syncfusion_SfPdfViewer_XForms_StampAnnotation_PageNumber)'| markdownify}}</td>
<td>StampAnnotation.PageNumber</td>
<td>Gets the page number of an annotation.</td>
</tr>
<tr>
<td>{{'[PageNumber](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotation.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotation_PageNumber)'| markdownify}}</td>
<td>ShapeAnnotation.PageNumber</td>
<td>Gets the page number of an annotation.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_IsLocked)'| markdownify}}</td>
<td>AnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.RectangleAnnotation.html#Syncfusion_SfPdfViewer_XForms_RectangleAnnotation_IsLocked)'| markdownify}}</td>
<td>SquareAnnotation.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.CircleAnnotation.html#Syncfusion_SfPdfViewer_XForms_CircleAnnotation_IsLocked)'| markdownify}}</td>
<td>CircleAnnotation.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.LineAnnotation.html#Syncfusion_SfPdfViewer_XForms_LineAnnotation_IsLocked)'| markdownify}}</td>
<td>LineAnnotation.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_IsLocked)'| markdownify}}</td>
<td>InkAnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotationSettings_IsLocked)'| markdownify}}</td>
<td>ShapeAnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StampAnnotation.html#Syncfusion_SfPdfViewer_XForms_StampAnnotation_IsLocked)'| markdownify}}</td>
<td>StampAnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.HighlightAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_HighlightAnnotationSettings_IsLocked)'| markdownify}}</td>
<td>HighlightAnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SquigglyAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_SquigglyAnnotationSettings_IsLocked)'| markdownify}}</td>
<td>SquigglyAnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StrikethroughAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_StrikethroughAnnotationSettings_IsLocked)'| markdownify}}</td>
<td>StrikeOutAnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[IsLocked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.UnderlineAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_UnderlineAnnotationSettings_IsLocked)'| markdownify}}</td>
<td>UnderlineAnnotationSettings.IsLocked</td>
<td>Gets or sets a value indicating whether annotations should be locked.</td>
</tr>
<tr>
<td>{{'[MinimumSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_MinimumSize'| markdownify}}</td>
<td>InkAnnotationSettings.MinimumSize</td>
<td>Gets or sets the minimum size for ink annotation.</td>
</tr>
<tr>
<td>{{'[MinimumSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotationSettings_MinimumSize)'| markdownify}}</td>
<td>MinimumSize</td>
<td>Gets or sets the minimum size for shape annotations.</td>
</tr>
<tr>
<td>{{'[Thickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_Thickness)'| markdownify}}</td>
<td>InkAnnotationSettings.BorderWidth</td>
<td>Gets or sets the border thickness of an ink annotation.</td>
</tr>
<tr>
<td>{{'[Thickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotationSettings_Thickness)'| markdownify}}</td>
<td>ShapeAnnotationSettings.BorderWidth</td>
<td>Gets or sets the border thickness of an shape annotation.</td>
</tr>
<tr>
<td>{{'[EnableSeparateAttributesForEachStroke](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_EnableSeparateAttributesForEachStroke)'| markdownify}}</td>
<td>AggregateInkStrokes</td>
<td>Gets or sets a value indicating whether each ink strokes should be treated as separate ink annotations. </td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_Color)'| markdownify}}</td>
<td>InkAnnotationSettings.Color</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotationSettings_StrokeColor)'| markdownify}}</td>
<td>ShapeAnnotationSettings.Color</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SelectorSettings.html#Syncfusion_SfPdfViewer_XForms_SelectorSettings_StrokeColor)'| markdownify}}</td>
<td>AnnotationSelectorSettings.Color</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.HighlightAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_HighlightAnnotationSettings_Color)'| markdownify}}</td>
<td>HighlightAnnotationSettings.Color</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SquigglyAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_SquigglyAnnotationSettings_Color)'| markdownify}}</td>
<td>SquigglyAnnotationSettings.Color</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StrikethroughAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_StrikethroughAnnotationSettings_Color)'| markdownify}}</td>
<td>StrikeOutAnnotationSettings.Color</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.UnderlineAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_UnderlineAnnotationSettings_Color)'| markdownify}}</td>
<td>UnderlineAnnotationSettings.Color</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.InkAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_InkAnnotationSettings_Opacity)'| markdownify}}</td>
<td>InkAnnotationSettings.Opacity</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotationSettings_Opacity)'| markdownify}}</td>
<td>ShapeAnnotationSettings.Opacity</td>
<td>Gets or sets the default stroke color of annotations.</td>
</tr>
<tr>
<td>{{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.HighlightAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_HighlightAnnotationSettings_Opacity)'| markdownify}}</td>
<td>HighlightAnnotationSettings.Opacity</td>
<td>Gets or sets the default opacity of annotations.</td>
</tr>
<tr>
<td>{{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SquigglyAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_SquigglyAnnotationSettings_Opacity)'| markdownify}}</td>
<td>SquigglyAnnotationSettings.Opacity</td>
<td>Gets or sets the default opacity of annotations.</td>
</tr>
<tr>
<td>{{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.StrikethroughAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_StrikethroughAnnotationSettings_Opacity)'| markdownify}}</td>
<td>StrikeOutAnnotationSettings.Opacity</td>
<td>Gets or sets the default opacity of annotations.</td>
</tr>
<tr>
<td>{{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.UnderlineAnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_UnderlineAnnotationSettings_Opacity)'| markdownify}}</td>
<td>UnderlineAnnotationSettings.Opacity</td>
<td>Gets or sets the default opacity of annotations.</td>
</tr>
<tr>
<td>{{'[LockedStrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SelectorSettings.html#Syncfusion_SfPdfViewer_XForms_SelectorSettings_LockedStrokeColor)'| markdownify}}</td>
<td>LockedColor</td>
<td>Gets or sets the default color of annotation selector when the selected annotation is locked.</td>
</tr>
<tr>
<tr>
<td>{{'[LinePoints](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.ShapeAnnotation.html#Syncfusion_SfPdfViewer_XForms_ShapeAnnotation_LinePoints)'| markdownify}}</td>
<td>LineAnnotation.Points</td>
<td>Gets or sets the series of coordinates that represent the starting point and ending point of a line annotation.</td>
</tr>
<tr>
<td>{{'[Rectangle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Rectangle)'| markdownify}}</td>
<td>ShapeAnnotationSettings.Square</td>
<td>Gets or sets the default settings for square annotations.</td>
</tr>
<tr>
<td>{{'[Circle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Circle)'| markdownify}}</td>
<td>ShapeAnnotationSettings.Circle</td>
<td>Gets or sets the default settings for circle annotations.</td>
</tr>
<tr>
<td>{{'[Line](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Line)'| markdownify}}</td>
<td>ShapeAnnotationSettings.Line</td>
<td>Gets or sets the default settings for line annotations.</td>
</tr>
<tr>
<td>{{'[Arrow](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Arrow)'| markdownify}}</td>
<td>ShapeAnnotationSettings.Arrow</td>
<td>Gets or sets the default settings for arrow annotations.</td>
</tr>
<tr>
<td>{{'[Ink](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Ink)'| markdownify}}</td>
<td>InkAnnotationSettings.Ink</td>
<td>Gets or sets the default settings for ink annotations.</td>
</tr>
<tr>
<td>{{'[Stamp](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Stamp)'| markdownify}}</td>
<td>StampAnnotationSettings.Stamp</td>
<td>Gets or sets the default settings for stamp annotations.</td>
</tr>
<tr>
<td>{{'[Selector](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.AnnotationSettings.html#Syncfusion_SfPdfViewer_XForms_AnnotationSettings_Selector)'| markdownify}}</td>
<td>AnnotationSelectorSettings.Selector</td>
<td>Gets or sets the default settings for the annotation selector.</td>
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
<tr>
<td>{{'[ClearAllAnnotations](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.SfPdfViewer.html#Syncfusion_SfPdfViewer_XForms_SfPdfViewer_ClearAllAnnotations)'| markdownify}}</td>
<td>{{'RemoveAllAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_RemoveAllAnnotations)'| markdownify}}</td>
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