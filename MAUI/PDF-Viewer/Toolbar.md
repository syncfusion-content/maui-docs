---
layout: post
title: Working with Toolbar in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about the toolbar in .NET MAUI PDF Viewer (SfPdfViewer) control, its functionalites and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords : .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Working with Toolbar in .NET MAUI Pdf Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) has a built-in toolbar, which enhances PDF viewing and editing capabilities, allowing you to perform operations such as adding and modifying annotations, searching text, and more.

## Toolbars structure 

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) features a built-in toolbar that utilizes multiple or multilevel toolbars. This design ensures that the user interface remains clean and accessible. We have incorporated approximately 40 toolbars to ensure comprehensive functionality across various platforms. These toolbars are strategically organized based on the available screen space, adapting to different screen sizes on both mobile and desktop platforms. This approach ensures that tools are easily accessible, preventing the interface from becoming cluttered.

### Need for using multiple toolbars

Depending on the available screen space, the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) organizes its tools into multiple or multilevel toolbars on mobile and desktop platforms. The use of multiple toolbars in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) is essential to maintain a user-friendly interface. By separating tools into different toolbars, users can quickly find and use the tools they need without the interface becoming cluttered.

The names of these toolbars and its description are listed in the following sections. 

### Mobile toolbar names

<table>
<tr>
<th>Key</th>
<th>Description</th>
</tr>
<tr>
<td>TopToolbar</td>
<td>The toolbar appears at the top of the mobile PDF viewer.</td>
</tr>
<tr>
<td>BottomToolbar</td>
<td>The annotation toolbar appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>RectangleAnnotationEditToolbar</td>
<td>The toolbar for editing rectangle annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>CircleAnnotationEditToolbar</td>
<td>The toolbar for editing circle annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>LineAnnotationEditToolbar</td>
<td>The toolbar for editing line annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>ArrowAnnotationEditToolbar</td>
<td>The toolbar for editing arrow annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>PolygonAnnotationEditToolbar</td>
<td>The toolbar for editing polygon annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>PolylineAnnotationEditToolbar</td>
<td>The toolbar for editing polyline annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>InkAnnotationEditToolbar</td>
<td>The toolbar for editing ink annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>EraserEditToolbar</td>
<td>The toolbar for editing eraser annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>FreeTextAnnotationEditToolbar</td>
<td>The toolbar for editing free text annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>StickyNoteAnnotationEditToolbar</td>
<td>The toolbar for editing sticky note annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>HighlightAnnotationEditToolbar</td>
<td>The toolbar for editing highlight annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>StrikeOutAnnotationEditToolbar</td>
<td>The toolbar for editing strikeout annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>UnderlineAnnotationEditToolbar</td>
<td>The toolbar for editing underline annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>SquigglyAnnotationEditToolbar</td>
<td>The toolbar for editing squiggly annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>StampAnnotationEditToolbar</td>
<td>The toolbar for editing stamp annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>TextMarkupToolbar</td>
<td>The toolbar for editing text markup annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>ShapeAnnotationsToolbar</td>
<td>The toolbar for editing shapes annotations appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>StickyNoteIconsToolbar</td>
<td>The toolbar for editing sticky note icons appears at the bottom of the mobile PDF viewer.</td>
</tr>
<tr>
<td>SearchToolbar</td>
<td>The toolbar for text search appears at the top of the mobile PDF viewer.</td>
</tr>
<tr>
<td>MoreOptionToolbar</td>
<td>The toolbar for more options appears at the top of the mobile PDF viewer.</td>
</tr>
</table>

### Desktop toolbar names 

<table>
<tr>
<td>Keys</td>
<td>Description</td>
</tr>
<tr>
<td>PrimaryToolbar</td>
<td>The toolbar, appears at the top of the desktop PDF viewer.</td>
</tr>
<tr>
<td>AnnotationsToolbar</td>
<td>The annotation toolbar, appears at the below PrimaryToolbar of the desktop PDF viewer.</td>
</tr>
<tr>
<td>RectangleAnnotationEditToolbar</td>
<td>The toolbar for editing rectangle annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>CircleAnnotationEditToolbar</td>
<td>The toolbar for editing circle annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>LineAnnotationEditToolbar</td>
<td>The toolbar for editing line annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>ArrowAnnotationEditToolbar</td>
<td>The toolbar for editing arrow annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>PolygonAnnotationEditToolbar</td>
<td>The toolbar for editing polygon annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>PolylineAnnotationEditToolbar</td>
<td>The toolbar for editing polyline annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>InkAnnotationEditToolbar</td>
<td>The toolbar for editing ink annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>EraserEditToolbar</td>
<td>The toolbar for editing eraser annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>FreeTextAnnotationEditToolbar</td>
<td>The toolbar for editing free text annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>StickyNoteAnnotationEditToolbar</td>
<td>The toolbar for editing sticky note annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>HighlightAnnotationEditToolbar</td>
<td>The toolbar for editing highlight annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>StrikeOutAnnotationEditToolbar</td>
<td>The toolbar for editing strikeout annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>UnderlineAnnotationEditToolbar</td>
<td>The toolbar for editing underline annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>SquigglyAnnotationEditToolbar</td>
<td>The toolbar for editing squiggly annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
<tr>
<td>StampAnnotationEditToolbar</td>
<td>The toolbar for editing stamp annotations appears at the bottom of the desktop PDF viewer.</td>
</tr>
</table>

### Show/hide the toolbars

The built-in toolbars are visible by default. In certain scenarios, you might want to hide all the toolbars in the PDF Viewer to display the document in full view or to use customized toolbars based on your application needs. You can do this by setting the [ShowToolbars](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ShowToolbars) property of the PDF Viewer to `false`. And you can show the built-in toolbar by setting the [ShowToolbars](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ShowToolbars) property of the PDF Viewer to `true`.

{% tabs %}
{% highlight C# %}

//set the ShowToolbars to false
public MainPage()
{
     SfPdfViewer pdfViewer=new SfPdfViewer();
     pdfViewer.ShowToolbars = false;
}  

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight XAML %}

 <ContentPage.Content>
  <syncfusion:SfPdfViewer x:Name="pdfViewer" DocumentSource ="{Binding PdfDocumentStream} " ShowToolbars="False" />
 </ContentPage.Content>
 
{% endhighlight %}
{% endtabs %}

You can find the sample project from the [link provided here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples/tree/master/Toolbar customization/HideToolbars).

### Customize the toolbar 

Sometimes, you might need to hide specific toolbars instead of all. This can be useful if you want to simplify the user interface by removing unnecessary tools or creating a more focused environment for certain tasks. The Toolbars collection property in the PDF Viewer allows you to hide a specific toolbar by using its index or name.

#### Hide specific toolbars by index

If you know the position of the toolbar you want to hide within the Toolbars collection, you can access and hide it using its index. For example, you can use the following code to hide the first and second toolbars in the collection.

{% tabs %}
{% highlight C# %}
/if (PdfViewer.Toolbars.Count > 1)
{
    PdfViewer.Toolbars[0].IsVisible = false; // Hide the first toolbar
    PdfViewer.Toolbars[1].IsVisible = false; // Hide the second toolbar
}
{% endhighlight %}
{% endtabs %}

#### Hide specific toolbars by name

By using the [GetByName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ToolbarItemCollection.html#Syncfusion_Maui_PdfViewer_ToolbarItemCollection_GetByName_System_String) method with its specified toolbar names, you can access the properties of those toolbars. After accessing the toolbar, you can modify its visibility by setting the IsVisible property. Here, we retrieve the toolbar “BottomToolbar” using the GetByName method and hide it by setting its visibility to false.

{% tabs %}
{% highlight C# %}
// On the mobile, we access the primary toolbar using the GetByName method.

 var toolbar = pdfViewer.Toolbars?.GetByName("BottomToolbar");
 if (toolbar != null)
 {
     toolbar.IsVisible = false; // Hide the bottom toolbar
 }
{% endhighlight %}
{% endtabs %}

## Toolbar items

In [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), user  can also manage the items within each toolbar of the PDF Viewer. This allows you to control which tools are available and how they are arranged, providing a tailored user experience that aligns with your application’s requirements.

The names of these toolbar items, along with their descriptions and availability in the toolbars, are listed in the following sections.

### Mobile toolbar item names

<table>
<tr>
<td>Keys</td>
<td>Description</td>
<td>Item available in toolbars</td>
</tr>
<tr>
<td>Undo</td>
<td>The button that appears in the top toolbar allows you to undo an action.</td>
<td>TopToolbar</td>
</tr>
<tr>
<td>Redo</td>
<td>The button that appears in the top toolbar allows you to redo an action.</td>
<td>TopToolbar</td>
</tr>
<tr>
<td>ZoomMode</td>
<td>The button that appears in the top toolbar allows you to adjust the magnification level of the PDF viewer content. </td>
<td>TopToolbar</td>
</tr>
<tr>
<td>PageSettings</td>
<td>The button that appears in the top toolbar allows you to customize the page display and layout of the PDF viewer content. </td>
<td>TopToolbar</td>
</tr>
<tr>
<td>Search</td>
<td>The button that appears in the top toolbar allows you to locate specific text or content in the document quickly. </td>
<td>TopToolbar</td>
</tr>
<tr>
<td>MoreItem</td>
<td>The button that appears in the top toolbar allows you to expand the options available in the PDF Viewer.</td>
<td>TopToolbar</td>
</tr>
<tr>
<td>TextMarkup</td>
<td>The button that appears in the bottom toolbar allows you to annotate text in the PDF Viewer.</td>
<td>BottomToolbar</td>
</tr>
<tr>
<td>FreeText</td>
<td>The button that appears in the bottom toolbar allows you to add text annotations directly to the document in the PDF Viewer.</td>
<td>BottomToolbar</td>
</tr>
<tr>
<td>Ink</td>
<td>The button that appears in the bottom toolbar allows you to draw freehand annotations.</td>
<td>BottomToolbar</td>
</tr>
<tr>
<td>Eraser</td>
<td>The button that appears in the bottom toolbar allows you to erase the ink annotations in the PDF Viewer.</td>
<td>BottomToolbar</td>
</tr>
<tr>
<td>Shape</td>
<td>The button that appears in the bottom toolbar allows you to add shapes to the document.</td>
<td>BottomToolbar</td>
</tr>
<tr>
<td>Stamp</td>
<td>The button that appears in the bottom toolbar allows you to add the in-built and custom stamps.</td>
<td>BottomToolbar</td>
</tr>
<tr>
<td>Signature</td>
<td>The button that appears in the bottom toolbar allows you to create and add the signature and indicate the signature annotation type.</td>
<td>BottomToolbar, HighlightAnnotationEditToolbar, , UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar ,SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar ,ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, StampAnnotationEditToolbar</td>
</tr>
<tr>
<td>StickyNote</td>
<td>The button that appears in the bottom toolbar allows you to add the sticky note to the document.</td>
<td>BottomToolbar</td>
</tr>
<tr>
<td>TextMarkupToolbarBackIcon</td>
<td>The button that appears in the text markup toolbar allows you to navigate back from the text markup toolbar.</td>
<td>TextMarkupToolbar</td>
</tr>
<tr>
<td>Highlight</td>
<td>The button that appears in the text markup toolbar allows you to highlight the text in the document.</td>
<td>TextMarkupToolbar</td>
</tr>
<tr>
<td>Underline</td>
<td>The button that appears in the text markup toolbar allows you to underline the text in the document.</td>
<td>TextMarkupToolbar</td>
</tr>
<tr>
<td>StrikeOut</td>
<td>The button that appears in the text markup toolbar allows you to strikeout the text in the document.</td>
<td>TextMarkupToolbar</td>
</tr>
<tr>
<td>Squiggly</td>
<td>The button that appears in the text markup toolbar allows you to add squiggly lines to the text in the document.</td>
<td>TextMarkupToolbar</td>
</tr>
<tr>
<td>ShapeToolbarBackIcon</td>
<td>The button that appears in the shape toolbar allows you to navigate back from the shape toolbar.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>Line</td>
<td>The button that appears in the shape toolbar allows you to draw a line in the document.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>Arrow</td>
<td>The button that appears in the shape toolbar allows you to draw an arrow in the document.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>Rectangle</td>
<td>The button that appears in the shape toolbar allows you to draw a rectangle in the document.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>Circle</td>
<td>The button that appears in the shape toolbar allows you to draw a circle in the document.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>Polygon</td>
<td>The button that appears in the shape toolbar allows you to draw polygons in the document.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>Polyline</td>
<td>The button that appears in the shape toolbar allows you to draw polylines in the document.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>Cloud</td>
<td>The button that appears in the shape toolbar allows you to draw a cloud in the document.</td>
<td>ShapeAnnotationsToolbar</td>
</tr>
<tr>
<td>SecondaryAnnotationBackIcon</td>
<td>The button that appears in the annotation edit toolbars allows you to navigate back from the annotation edit toolbar.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar,StampAnnotationEditToolbar</td>
</tr>
<tr>
<td>BackIconSeparator</td>
<td>The separator that appears in the annotation edit toolbar is positioned after the back button.</td>
<td> HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar,StampAnnotationEditToolbar</td>
</tr>
<tr>
<td>AnnotationType</td>
<td>The button that appears in the annotation edit toolbar allows you to indicate the annotation type.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, StampAnnotationEditToolbar</td>
</tr>
<tr>
<td>BorderStyle</td>
<td>The button that appears in the cloud annotation edit toolbar allows you to indicate the cloud annotation.</td>
<td>PolygonAnnotationEditToolbar</td>
</tr>
<tr>
<td>TextColor</td>
<td>The button that appears in the free text annotation edit toolbar allows you to change the free text color.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>TextSize</td>
<td>The button that appears in the free text annotation edit toolbar allows you to change the text size.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>TextPropertySeparator</td>
<td>The separator that appears in the free text annotation edit toolbar is positioned after the text size button.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>Edit</td>
<td>The button that appears in the sticky note annotation edit toolbar allows you to edit text in the sticky note.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>TextFillColor</td>
<td>The button that appears in the free text annotation edit toolbar allows you to set the fill color of the text box.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>Thickness</td>
<td>The button that appears in the annotation edit toolbar allows you to set the thickness of the annotations.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar</td>
</tr>
<tr>
<td>StokeColor</td>
<td>The button that appears in the annotation edit toolbar allows you to set the stroke color of the annotations.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar</td>
</tr>
<tr>
<td>Notes</td>
<td>The button that appears in the top toolbar allows you to show the sticky note icons.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar</td>
</tr>
<tr>
<td>FillColor</td>
<td>The button that appears in the annotation edit toolbar allows you to set the fill color of the annotations.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>Opacity</td>
<td>The button that appears in the annotation edit toolbar allows you to set the opacity of the annotations.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>DeleteSeparator</td>
<td>The separator that appears in the annotation edit toolbar positioned before the delete button.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>Delete</td>
<td>The button that appears in the annotation edit toolbar allows you to delete the selected annotations.</td>
<td>HighlightAnnotationEditToolbar, UnderlineAnnotationEditToolbar, StrikeOutAnnotationEditToolbar, SquigglyAnnotationEditToolbar, LineAnnotationEditToolbar, ArrowAnnotationEditToolbar, RectangleAnnotationEditToolbar, CircleAnnotationEditToolbar, PolygonAnnotationEditToolbar, PolylineAnnotationEditToolbar, FreeTextAnnotationEditToolbar, InkAnnotationEditToolbar, EraserEditToolbar, StickyNoteAnnotationEditToolbar, and StampAnnotationEditToolbar.</td>
</tr>
<tr>
<td>Note</td>
<td>The button that appears in the sticky note icons toolbar allows you to add note type of the sticky note.</td>
<td>StickyNoteIconsToolbarView</td>
</tr>
<tr>
<td>Insert</td>
<td>The button that appears in the sticky note icons toolbar allows you to add insert type of the sticky note.</td>
<td>StickyNoteIconsToolbarView</td>
</tr>
<tr>
<td>Comment</td>
<td>The button that appears in the sticky note icons toolbar allows you to add comment type of the sticky note.</td>
<td>StickyNoteIconsToolbarView</td>
</tr>
<tr>
<td>Key</td>
<td>The button that appears in the sticky note icons toolbar allows you to add key type of the sticky note.</td>
<td>StickyNoteIconsToolbarView</td>
</tr>
<tr>
<td>Help</td>
<td>The button that appears in the sticky note icons toolbar allows you to add help type of the sticky note.</td>
<td>StickyNoteIconsToolbarView</td>
</tr>
<tr>
<td>Paragraph</td>
<td>The button that appears in the sticky note icons toolbar allows you to add paragraph type of the sticky note.</td>
<td>StickyNoteIconsToolbarView</td>
</tr>
<tr>
<td>New Paragraph</td>
<td>The button that appears in the sticky note icons toolbar allows you to add new paragraph type of the sticky note.</td>
<td>StickyNoteIconsToolbarView</td>
</tr>
<tr>
<td>Outline</td>
<td>The button that appears in the more option toolbar allows you to see the outline view of document.</td>
<td>MoreOptionToolbar</td>
</tr>
<tr>
<td>Print</td>
<td>The button that appears in the more option toolbar allows you to print the document from the PDF Viewer.</td>
<td>MoreOptionToolbar</td>
</tr>
<tr>
<td>SearchBackIcon</td>
<td>The button that appears in the search toolbar allows you to navigate back from the search toolbar. </td>
<td>SearchToolbar</td>
</tr>
<tr>
<td>SearchEntry</td>
<td>The entry that appears in the search toolbar allows you to enter the text you want to search.</td>
<td>SearchToolbar</td>
</tr>
<tr>
<td>SearchBusyIndicator</td>
<td>The button that appears in the search toolbar indicates an ongoing search.</td>
<td>SearchToolbar</td>
</tr>
<tr>
<td>ClearSearch</td>
<td>The button that appears in the search toolbar allows you to clear the current search text.</td>
<td>SearchToolbar</td>
</tr>
<tr>
<td>ClearSeparator</td>
<td>The separator that appears in the search toolbar is positioned after the clear button.</td>
<td>SearchToolbar</td>
</tr>
<tr>
<td>PreviousSearch</td>
<td>The button that appears in the search toolbar allows you to navigate to the previous search result.</td>
<td>SearchToolbar</td>
</tr>
<tr>
<td>NextSearch</td>
<td>The button that appears in the search toolbar allows you to navigate to the next search result.</td>
<td>SearchToolbar</td>
</tr>
<tr>
<td>MoreOption</td>
<td>The button that appears in the search toolbar allows you to search with case sensitivity.</td>
<td>SearchToolbar</td>
</tr>
</table>

### Desktop toolbar item names

<table>
<tr>
<td>Keys</td>
<td>Description</td>
</tr>
<tr>
<td>Undo</td>
<td>The button that appears in the primary toolbar allows you to undo an action.</td>
</tr>
<tr>
<td>Redo</td>
<td>The button that appears in the primary toolbar allows you to redo an action.</td>
</tr>
<tr>
<td>Previous page</td>
<td>The button that appears in the primary toolbar allows you to navigate to the page before the current one in the PDF Viewer.</td>
</tr>
<tr>
<td>Next page</td>
<td>The button that appears in the primary toolbar allows you to navigate to the page next to the current one in the PDF Viewer.</td>
</tr>
<tr>
<td>Page number entry</td>
<td>The entry that appears in the primary toolbar allows you to navigate to the entered page number.</td>
</tr>
<tr>
<td>Page count</td>
<td>The button that appears in the primary toolbar represents the total number of pages in the document.</td>
</tr>
<tr>
<td>Zoom mode</td>
<td>The button that appears in the primary toolbar allows you to adjust the magnification level of the PDF viewer content. </td>
</tr>
<tr>
<td>Annotations</td>
<td>The button that appears in the primary toolbar allows you to access the annotation toolbar.</td>
</tr>
<tr>
<td>Print</td>
<td>The button that appears in the primary toolbar allows you to print the document from the PDF Viewer.</td>
</tr>
<tr>
<td>Outline</td>
<td>The button that appears in the primary toolbar allows you to see the outline view of the document.</td>
</tr>
<tr>
<td>Search</td>
<td>The button that appears in the primary toolbar allows you to locate specific text or content in the document quickly.</td>
</tr>
<tr>
<td>Page layout mode</td>
<td>The button that appears in the primary toolbar allows you to customize page display and layout in the PDF Viewer.</td>
</tr>
<tr>
<td>Text markups</td>
<td>The button that appears in the annotation toolbar allows you to annotate text in the PDF Viewer.</td>
</tr>
<tr>
<td>Highlight</td>
<td>The button that appears in the annotation toolbar allows you to highlight the text in the document.</td>
</tr>
<tr>
<td>Underline</td>
<td>The button that appears in the annotation toolbar allows you to underline the text in the document.</td>
</tr>
<tr>
<td>Strikeout</td>
<td>The button that appears in the annotation toolbar allows you to strikeout the text in the document.</td>
</tr>
<tr>
<td>Squiggly</td>
<td>The button that appears in the annotation toolbar allows you to add squiggly lines to the text in the document.</td>
</tr>
<tr>
<td>Ink</td>
<td>The button that appears in the annotation toolbar allows you to draw freehand annotations.</td>
</tr>
<tr>
<td>Ink eraser</td>
<td>The button that appears in the annotation toolbar allows you to erase the ink annotations drawn in the document</td>
</tr>
<tr>
<td>Free text</td>
<td>The button that appears in the annotation toolbar allows you to add text annotations directly to the document in the PDF Viewer.</td>
</tr>
<tr>
<td>Shapes</td>
<td>The button that appears in the annotation toolbar allows you to add different shapes to the document.</td>
</tr>
<tr>
<td>Square</td>
<td>The button that appears in the annotation toolbar allows you to draw a square in the document.</td>
</tr>
<tr>
<td>Circle</td>
<td>The button that appears in the annotation toolbar allows you to draw a circle in the document.</td>
</tr>
<tr>
<td>Line</td>
<td>The button that appears in the annotation toolbar allows you to draw a line in the document.</td>
</tr>
<tr>
<td>Arrow</td>
<td>The button that appears in the annotation toolbar allows you to draw an arrow in the document.</td>
</tr>
<tr>
<td>Polyline</td>
<td>The button that appears in the annotation toolbar allows you to draw polylines in the document.</td>
</tr>
<tr>
<td>Polygon</td>
<td>The button that appears in the annotation toolbar allows you to draw polygons in the document.</td>
</tr>
<tr>
<td>Cloud</td>
<td>The button that appears in the annotation toolbar allows you to draw a cloud on the document.</td>
</tr>
<tr>
<td>Stamps</td>
<td>The button that appears in the annotation toolbar allows you to add the inbuilt stamps and custom stamps.</td>
</tr>
<tr>
<td>Sticky note</td>
<td>The button that appears in the annotation toolbar allows you to add the sticky note to the document in the PDF Viewer.</td>
</tr>
<tr>
<td>Signature</td>
<td>The button that appears in the annotation toolbar allows you to create and add a signature.</td>
</tr>
<tr>
<td>Color picker</td>
<td>The button that appears in the annotation toolbar allows you to select and apply colors to the annotations.</td>
</tr>
<tr>
<td>Thickness</td>
<td>The button that appears in the annotation toolbar allows you to set the thickness of the annotations.</td>
</tr>
<tr>
<td>Delete</td>
<td>The button that appears in the annotation toolbar allows you to delete the selected annotation.</td>
</tr>
<tr>
<td>Sticky note icons</td>
<td>The button that appears in the annotation toolbar allows you to select the types of sticky note.</td>
</tr>
<tr>
<td>Font size</td>
<td>The button that appears in the annotation toolbar allows you to change the size of the text.</td>
</tr>
<tr>
<td>ColorPickerSeparator</td>
<td>The separator that appears in the annotation toolbar is positioned before the color picker button.</td>
</tr>
<tr>
<td>Close</td>
<td>The button that appears in the annotation toolbar allows you to close the annotation toolbar.</td>
</tr>
<tr>
<td>PageCountSeparator</td>
<td>The separator that appears in the primary toolbar allows you to separate the page number entry and page count buttons.</td>
</tr>
<tr>
<td>ZoomIconSeparator</td>
<td>The separator that appears in the primary toolbar is positioned before the Zoom mode button.</td>
</tr>
<tr>
<td>AnnotationSeparator</td>
<td>The separator that appears in the primary toolbar is positioned before the annotations button.</td>
</tr>
<tr>
<td>PrintSeparator</td>
<td>The separator that appears in the primary toolbar is positioned after the print button.</td>
</tr>
<tr>
<td>MoreOptionSeparator</td>
<td>The separator that appears in the primary toolbar is positioned before the page layout mode.</td>
</tr>
</table>

### Customize toolbar items 

In addition to customizing the visibility of toolbars, you can customize the items within each toolbar of the .NET MAUI PDF Viewer. This includes adding new items, removing existing ones, or rearranging their order to suit your app’s workflow better.

#### Adding a new toolbar item

To add an item to the toolbar in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), first, create the UI element you want to include. Then, convert that element into a ToolbarItem using the `ToolbarItem` method. Finally, add the newly created ToolbarItem to the toolbar using the `Add` method. Here we create the new button fileOpenButton and retrieve the "PrimaryToolbar" using the GetByName method. Add the new button to the "Primary Toolbar".

{% tabs %}
{% highlight C# %}
//Create a button you want to add.

Button fileOpenButton = new Button
 {
     Text = "\ue712",           
     FontSize = 24,
     IsEnabled = false,
     FontFamily = "Maui Material Assets",
     HorizontalOptions = LayoutOptions.Center,
     VerticalOptions = LayoutOptions.Center,
     BackgroundColor = Colors.Transparent,
     BorderColor = Colors.Transparent,
     Padding = 10,
     Margin = new Thickness(5, 0, 0, 0),
     Opacity = 0.5 
 };
//We access the PrimaryToolbar on the desktop using the GetByName method and add the item you created in it.

pdfViewer.Toolbars?.GetByName("PrimaryToolbar")?.Items?.Add(new Syncfusion.Maui.PdfViewer.ToolbarItem(fileOpenButton, "FileOpenButton"));
{% endhighlight %}
{% endtabs %}

#### Adding a new toolbar item at a specific index

To add an item at a specific index in the toolbar in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), first create the UI element you want to include. Then, convert that element into a ToolbarItem using the [ToolbarItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ToolbarItem.html#Syncfusion_Maui_PdfViewer_ToolbarItem__ctor_Microsoft_Maui_Controls_View_System_String) method. Finally, add the newly created ToolbarItem to the toolbar using the [Insert](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ToolbarItemCollection.html#Syncfusion_Maui_PdfViewer_ToolbarItemCollection_Insert_System_Int32_Syncfusion_Maui_PdfViewer_ToolbarItem) method. Use the [Index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ToolbarItem.html#Syncfusion_Maui_PdfViewer_ToolbarItem_Index) property to get the index of the item you want to add after, and insert the new item at a specific index. Here we create the button fileSaveButton and retrieve the index of the "Print" button in the "PrimaryToolbar". The new button is inserted into the toolbar right after the "Print" button.

{% tabs %}
{% highlight C# %}
//Create a button you want to add.

Button fileSaveButton = new Button
 {
     Text = "\ue75f",           
     FontSize = 24,
     FontFamily = "Maui Material Assets",
     HorizontalOptions = LayoutOptions.Center,
     VerticalOptions = LayoutOptions.Center,
     BackgroundColor = Colors.Transparent,
     BorderColor = Colors.Transparent,
     IsEnabled = false,
     Opacity = 0.5,
     Padding = 10
 };
//We access the PrimaryToolbar on the desktop using the GetByName method and get the item index using Index property.

var index = (int)pdfViewer?.Toolbars?.GetByName("PrimaryToolbar")?.Items?.GetByName("Print")?.Index;

// We accessed the PrimaryToolbar on the desktop using the GetByName method and inserted the item after the last item index.

pdfViewer.Toolbars?.GetByName("PrimaryToolbar")?.Items?.Insert(index+1, new Syncfusion.Maui.PdfViewer.ToolbarItem(fileSaveButton, "FileSaveButton"));
{% endhighlight %}
{% endtabs %}

#### Remove Items from the Toolbar

If you need to remove specific items from the toolbar in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), you can do so from the Items collection. You can remove them either by index or by name.

##### Remove Item by Index

You can access the specific item using its index and then remove it from the toolbar’s item collection using the Remove method. Here we retrieve the first item from the “TopToolbar” using its index. If the item is found, it is removed from the toolbar.

{% tabs %}
{% highlight C# %}
// Get the top toolbar of the PDF Viewer that contains annotation tools on mobile platforms.
Syncfusion.Maui.PdfViewer.Toolbar? topToolbar = PdfViewer.Toolbars?.GetByName("TopToolbar");
if (topToolbar != null)
{
    // Get the first item from the toolbar.
    Syncfusion.Maui.PdfViewer.ToolbarItem? firstItem = topToolbar.Items?[0];
    if (firstItem != null)
    {
        // Remove the first item from the toolbar.
        topToolbar?.Items?.Remove(firstItem);
    }
}
{% endhighlight %}
{% endtabs %}

##### Remove Item by Name

you can access the specific item using the [GetByName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ToolbarItemCollection.html#Syncfusion_Maui_PdfViewer_ToolbarItemCollection_GetByName_System_String) method and then remove it from the toolbar's item collection using the [Remove](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ToolbarItemCollection.html#Syncfusion_Maui_PdfViewer_ToolbarItemCollection_Remove_Syncfusion_Maui_PdfViewer_ToolbarItem) method. Here we retrieve the "Outline" item from the "PrimaryToolbar" using the GetByName method. If the item is found, it is removed from the toolbar.

{% tabs %}
{% highlight C# %}
//We access the outline item in the PrimaryToolbar on the desktop using the GetByName method and remove it.

 var item = pdfViewer.Toolbars?.GetByName("PrimaryToolbar")?.Items?.GetByName("Outline");
 if (item != null)
 {
     pdfViewer.Toolbars?.GetByName("PrimaryToolbar")?.Items?.Remove(item); // Remove the outline item
 }
{% endhighlight %}
{% endtabs %}

#### Remove item in all toolbars

In [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), each toolbar operates independently. Removing an item from one toolbar does not affect others. For example, removing the Sticky note icon from the "AnnotationsToolbar" does not impact other toolbars.

To remove an item from all toolbars, iterate through the toolbar collection and remove the item from each toolbar. Here’s how to remove the "Sticky note" item from all toolbars:

{% tabs %}
{% highlight C# %}
// Iterate through the toolbar collection of the PDF Viewer
for (int i = 0; i < pdfViewer?.Toolbars.Count; i++)
{
// Get the toolbar item with the name "Sticky note" from the current toolbar
var item = pdfViewer.Toolbars[i]?.Items?.GetByName("Sticky note");
if (item != null)
{
// Remove the "Sticky note" item
pdfViewer.Toolbars[i].Items.Remove(item); 
}
}
{% endhighlight %}
{% endtabs %}

You can find the sample project for removing an item from the desktop toolbar using the [link provided here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples/tree/master/Toolbar customization/RemoveToolbarItemDesktop).

#### Hide items from the toolbar

If you need to hide specific items in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), you can do so by modifying the visibility of the items. You can hide them either by index or by name.

##### Hide Item by Index

To hide a toolbar item by its index, you can directly access the item in the toolbar's Items collection using the index and then set its IsVisible property to false. Here’s how you can do it:

{% tabs %}
{% highlight C# %}
// Assuming you want to hide the item at a specific index in the PrimaryToolbar.
int indexToHide = 2; // Replace with the actual index of the item you want to hide.

var toolbar = pdfViewer.Toolbars?.GetByName("PrimaryToolbar");
if (toolbar != null && indexToHide >= 0 && indexToHide < toolbar.Items.Count)
{
    var item = toolbar.Items[indexToHide];
    item.IsVisible = false; // Hide the item by index
}

{% endhighlight %}
{% endtabs %}

##### Hide item by name

By using the [GetByName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ToolbarItemCollection.html#Syncfusion_Maui_PdfViewer_ToolbarItemCollection_GetByName_System_String) method with its specified toolbar names, you can access the items of those toolbars. After accessing the item, you can modify its visibility by setting the `IsVisible` property. Here, we retrieve the toolbar "PrimaryToolbar" and "Search" item using the GetByName method and hide the "Search" item by setting its visibility to false.

{% tabs %}
{% highlight C# %}
// On the desktop, we access the search button located in the primary toolbar using the GetByName method.

var item = pdfViewer.Toolbars?.GetByName("PrimaryToolbar")?.Items?.GetByName("Search");
if (item != null)
{
item.IsVisible = false; // Hide the search item
}
{% endhighlight %}
{% endtabs %}

#### Hide item in all toolbars

In [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html),each toolbar operates independently. Hiding an item in one toolbar does not affect others. For example, changing the visibility of the signature icon in the "AnnotationsToolbar" does not impact other toolbars.

To hide an icon from all toolbars, iterate through the toolbar collection and adjust the visibility of the item in each toolbar. Here’s how to hide the "Signature" icon from all toolbars:

{% tabs %}
{% highlight C# %}
// Iterate through the toolbar collection of the PDF Viewer
for (int i = 0; i < pdfViewer?.Toolbars.Count; i++)
{
    // Get the toolbar item with the name "Signature" from the current toolbar
    var item = pdfViewer.Toolbars[i]?.Items?.GetByName("Signature");
    
    // Check if the item exists in the toolbar
    if (item != null)
    {
        // Set the visibility of the "Signature" item to false, effectively hiding it
        item.IsVisible = false; // Hide the Signature
    }
}
{% endhighlight %}
{% endtabs %} 



