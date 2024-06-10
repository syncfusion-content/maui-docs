---
layout: post
title: Working with the Built-In Toolbar in .NET MAUI Pdf Viewer (SfPdfViewer) | Syncfusion
description: Learn here all about the built-in toolbar in .NET MAUI PDF Viewer (SfPdfViewer) control, its functionalites and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords : .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Working with the Built-In Toolbar in .NET MAUI Pdf Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) has a built-in toolbar, which allows you to perform operations such as adding, modifying annotations, searching text, etc. Additionally, you have the option to show or hide the default built-in toolbar and its sub-toolbars and toolbar items, such as buttons, and you can customize your own toolbar by disabling the built-in toolbar and implementing one at the application and hooking the custom toolbar UI to the PDF viewer APIs. You can see the custom toolbar example [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples/tree/master/Custom%20Toolbar).

## Show/hide the built-in toolbar

By default, the built-in toolbar is visible. You can `hide` it by setting the `ShowToolbars` property of the PDF Viewer to `false`. And you can `show` the built-in toolbar by setting the `ShowToolbars` property of the PDF Viewer to `true`.

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

## Customize the Toolbar 

To customize the toolbar, you can programmatically add, remove, and hide the items based on your needs.

### Customizing toolbar items using the GetByName method

### Accessing and Modifying the Visibility of the Toolbar Items

By using the `GetByName` method with its specified toolbar or icon names, you can access the properties of those toolbars or items. After accessing the item, you can modify its visibility by setting the `IsVisible` property.Here we retrieves the "PrimaryToolbar" and "Search" item using the GetByName method and hides the "Search" item by setting its visibility to false.

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

### Adding a New Toolbar Item

To add an item to the toolbar in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), first, create the button you want to include. Then, convert that button into a ToolbarItem using the `ToolbarItem` method. Finally, add the newly created ToolbarItem to the toolbar using the `Add` method. Here we create the new button fileOpenButton and retrieves the "PrimaryToolbar" using GetByName method.Added the new button in the "Primary Toolbar".

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

### Adding a New Toolbar Item at a Specific Index

To add an item at a specific index in the toolbar in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), first create the button you want to include. Then, convert that button into a ToolbarItem using the `ToolbarItem` method. Finally, add the newly created ToolbarItem to the toolbar using the `Insert` method. Use the `Index` property to get the index of the item you want to add after, and insert the new item at a specific index. Here we create the button fileSaveButton and retrieves the index of the "Print" button in the "PrimaryToolbar".The new button is inserted into the toolbar right after the "Print" button.

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

var index = (int)pdfViewer?.Toolbars?.GetByName("PrimaryToolbar ")?.Items?.GetByName("Print")?.Index;

// We accessed the PrimaryToolbar on the desktop using the GetByName method and inserted the item after the last item index.

pdfViewer.Toolbars?.GetByName("PrimaryToolbar")?.Items?.Insert(index+1, new Syncfusion.Maui.PdfViewer.ToolbarItem(fileSaveButton, "FileSaveButton"));
{% endhighlight %}
{% endtabs %}

### Removing an Item from the Toolbar 

To remove an item from the toolbar in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), you can access the specific item using the `GetByName` method and then remove it from the toolbar's item collection using the `Remove` method.Here we retrieves the "Outline" item from the "PrimaryToolbar" using the GetByName method. If the item is found, it removes it from the toolbar.

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

Similarly, you can customize the other toolbars and their items by accessing their names. We have listed the other toolbar and toolbar item names below:

### Mobile Toolbar Name :

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

### Desktop Toolbar Name :

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

### Mobile Toolbar Items Name

<table>
<tr>
<td>Keys</td>
<td>Description</td>
</tr>
<tr>
<td>Undo</td>
<td>The button that appears in the top toolbar allows you to undo an action.</td>
</tr>
<tr>
<td>Redo</td>
<td>The button that appears in the top toolbar allows you to redo an action.</td>
</tr>
<tr>
<td>ZoomMode</td>
<td>The button that appears in the top toolbar allows you to adjust the magnification level of the PDF viewer content. </td>
</tr>
<tr>
<td>PageSettings</td>
<td>The button that appears in the top toolbar allows you to customizes page display and layout of the PDF viewer content. </td>
</tr>
<tr>
<td>Search</td>
<td>The button that appears in the top toolbar allows you to locate specific text or content in the document quickly. </td>
</tr>
<tr>
<td>MoreItem</td>
<td>The button that appears in the top toolbar allows you to expands the options available in the PDF Viewer.</td>
</tr>
<tr>
<td>TextMarkup</td>
<td>The button that appears in the Bottom toolbar allows you to annotate text in the PDF Viewer.</td>
</tr>
<tr>
<td>FreeText</td>
<td>The button that appears in the bottom toolbar allows you to add text annotations directly onto the document in the PDF Viewer.</td>
</tr>
<tr>
<td>Ink</td>
<td>The button that appears in the bottom toolbar allows you to draw freehand annotations.</td>
</tr>
<tr>
<td>Eraser</td>
<td>The button that appears in the bottom toolbar allows you to erase the ink annotations in the PDF Viewer.</td>
</tr>
<tr>
<td>Shape</td>
<td>The button that appears in the bottom toolbar allows you to add shapes in the document.</td>
</tr>
<tr>
<td>Stamp</td>
<td>The button that appears in the bottom toolbar allows you to add the inbuilt stamps and custom stamps.</td>
</tr>
<tr>
<td>Signature</td>
<td>The button that appears in the bottom toolbar allows you to create and add the signature and indicate the signature annotation type.</td>
</tr>
<tr>
<td>StickyNote</td>
<td>The button that appears in the bottom toolbar allows you to add the sticky note in the document.</td>
</tr>
<tr>
<td>TextMarkupToolbarBackIcon</td>
<td>The button that appears in the text markup toolbar allows you to navigate back from the Text Markup Toolbar.</td>
</tr>
<tr>
<td>Highlight</td>
<td>The button that appears in the text markup toolbar allows you to highlight the text in the document.</td>
</tr>
<tr>
<td>Underline</td>
<td>The button that appears in the text markup toolbar allows you to underline the text in the document.</td>
</tr>
<tr>
<td>StrikeOut</td>
<td>The button that appears in the text markup toolbar allows you to strikeout the text in the document.</td>
</tr>
<tr>
<td>Squiggly</td>
<td>The button that appears in the text markup toolbar allows you to add squiggly lines to the text in the document.</td>
</tr>
<tr>
<td>ShapeToolbarBackIcon</td>
<td>The button that appears in the shape toolbar allows you to navigate back from the Shape Toolbar.</td>
</tr>
<tr>
<td>Line</td>
<td>The button that appears in the shape toolbar allows you to draw a line in the document.</td>
</tr>
<tr>
<td>Arrow</td>
<td>The button that appears in the shape toolbar allows you to draw an arrow in the document.</td>
</tr>
<tr>
<td>Rectangle</td>
<td>The button that appears in the shape toolbar allows you to draw rectangle in the document.</td>
</tr>
<tr>
<td>Circle</td>
<td>The button that appears in the shape toolbar allows you to draw circle in the document.</td>
</tr>
<tr>
<td>Polygon</td>
<td>The button that appears in the shape toolbar allows you to draw polygon in the document.</td>
</tr>
<tr>
<td>Polyline</td>
<td>The button that appears in the shape toolbar allows you to draw polyline in the document.</td>
</tr>
<tr>
<td>Cloud</td>
<td>The button that appears in the shape toolbar allows you to draw a cloud in the document.</td>
</tr>
<tr>
<td>SecondaryAnnotationBackIcon</td>
<td>The button that appears in the annotation edit toolbars allows you to navigate back from the annotation edit toolbar.</td>
</tr>
<tr>
<td>BackIconSeparator</td>
<td>The separator that appears in the annotation edit toolbar positioned after the back button.</td>
</tr>
<tr>
<td>AnnotationType</td>
<td>The button that appears in the annotation edit toolbar allows you to indicate the annotation type.</td>
</tr>
<tr>
<td>BorderStyle</td>
<td>The button that appears in the cloud annotation edit toolbar allows you to indicate the cloud annotation.</td>
</tr>
<tr>
<td>TextColor</td>
<td>The button that appears in the free text annotation edit toolbar allows you to change the free text color.</td>
</tr>
<tr>
<td>TextSize</td>
<td>The button that appears in the free text annotation edit toolbar allows you to change the text size.</td>
</tr>
<tr>
<td>TextPropertySeparator</td>
<td>The separator that appears in the free text annotation edit toolbar positioned after the text size button.</td>
</tr>
<tr>
<td>Edit</td>
<td>The button that appears in the sticky note annotation edit toolbar allows you to edit text in the sticky note.</td>
</tr>
<tr>
<td>TextFillColor</td>
<td>The button that appears in the free text annotation edit toolbar allows you to set the fill color of the text box.</td>
</tr>
<tr>
<td>Thickness</td>
<td>The button that appears in the annotation edit toolbar allows you to set the thickness of the annotations.</td>
</tr>
<tr>
<td>StokeColor</td>
<td>The button that appears in the annotation edit toolbar allows you to set the stroke color of the annotations.</td>
</tr>
<tr>
<td>Notes</td>
<td>The button that appears in the top toolbar allows you to show the sticky note icons.</td>
</tr>
<tr>
<td>FillColor</td>
<td>The button that appears in the annotation edit toolbar allows you to set the fill color of the annotations.</td>
</tr>
<tr>
<td>Opacity</td>
<td>The button that appears in the annotation edit toolbar allows you to set the opacity of the annotations.</td>
</tr>
<tr>
<td>DeleteSeparator</td>
<td>The separator that appears in the annotation edit toolbar positioned before the delete button.</td>
</tr>
<tr>
<td>Delete</td>
<td>The button that appears in the annotation edit toolbar allows you to delete the selected annotations.</td>
</tr>
<tr>
<td>Note</td>
<td>The button that appears in the sticky note icons toolbar allows you to add note type of the sticky note.</td>
</tr>
<tr>
<td>Insert</td>
<td>The button that appears in the sticky note icons toolbar allows you to add insert type of the sticky note.</td>
</tr>
<tr>
<td>Comment</td>
<td>The button that appears in the sticky note icons toolbar allows you to add comment type of the sticky note.</td>
</tr>
<tr>
<td>Key</td>
<td>The button that appears in the sticky note icons toolbar allows you to add key type of the sticky note.</td>
</tr>
<tr>
<td>Help</td>
<td>The button that appears in the sticky note icons toolbar allows you to add help type of the sticky note.</td>
</tr>
<tr>
<td>Paragraph</td>
<td>The button that appears in the sticky note icons toolbar allows you to add paragraph type of the sticky note.</td>
</tr>
<tr>
<td>New Paragraph</td>
<td>The button that appears in the sticky note icons toolbar allows you to add new paragraph type of the sticky note.</td>
</tr>
<tr>
<td>Outline</td>
<td>The button that appears in the more option toolbar allows you to see the outline view of document.</td>
</tr>
<tr>
<td>Print</td>
<td>The button that appears in the more option toolbar allows you to print the document from the PDF Viewer.</td>
</tr>
<tr>
<td>SearchBackIcon</td>
<td>The button that appears in the search toolbar allows you to navigate back from the search toolbar. </td>
</tr>
<tr>
<td>SearchEntry</td>
<td>The entry that appears in the search toolbar allows you to enter the text you want to search.</td>
</tr>
<tr>
<td>SearchBusyIndicator</td>
<td>The button that appears in the search toolbar indicates an ongoing search.</td>
</tr>
<tr>
<td>ClearSearch</td>
<td>The button that appears in the search toolbar allows you to clears the current search text.</td>
</tr>
<tr>
<td>ClearSeparator</td>
<td>The separator that appears in the search toolbar positioned after the clear button</td>
</tr>
<tr>
<td>PreviousSearch</td>
<td>The button that appears in the search toolbar allows you to navigate to the previous search result.</td>
</tr>
<tr>
<td>NextSearch</td>
<td>The button that appears in the search toolbar allows you to navigate to the next search result.</td>
</tr>
<tr>
<td>MoreOption</td>
<td>The button that appears in the search toolbar allows you to search with case sensitivity.</td>
</tr>
</table>

### Desktop Toolbar Items Name

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
<td>The button that appears in the primary toolbar allows you to navigate to the page next the current one in the PDF Viewer.</td>
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
<td>The button that appears in the primary toolbar allows you to see the outline view of document.</td>
</tr>
<tr>
<td>Search</td>
<td>The button that appears in the primary toolbar allows you to locate specific text or content in the document quickly.</td>
</tr>
<tr>
<td>Page layout mode</td>
<td>The button that appears in the primary toolbar allows you to customizes page display and layout in the PDF Viewer.</td>
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
<td>The button that appears in the annotation toolbar allows you to erase the ink annotations drawn in the document.</td>
</tr>
<tr>
<td>Free text</td>
<td>The button that appears in the annotation toolbar allows you to add text annotations directly onto the document in the PDF Viewer.</td>
</tr>
<tr>
<td>Shapes</td>
<td>The button that appears in the annotation toolbar allows you to add different shapes in the document.</td>
</tr>
<tr>
<td>Square</td>
<td>The button that appears in the annotation toolbar allows you to draw square in the document.</td>
</tr>
<tr>
<td>Circle</td>
<td>The button that appears in the annotation toolbar allows you to draw circle in the document.</td>
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
<td>The button that appears in the annotation toolbar allows you to draw polyline in the document.</td>
</tr>
<tr>
<td>Polygon</td>
<td>The button that appears in the annotation toolbar allows you to draw polygon in the document.</td>
</tr>
<tr>
<td>Cloud</td>
<td>The button that appears in the annotation toolbar allows you to draw a cloud in the document.</td>
</tr>
<tr>
<td>Stamps</td>
<td>The button that appears in the annotation toolbar allows you to add the inbuilt stamps and custom stamps.</td>
</tr>
<tr>
<td>Sticky note</td>
<td>The button that appears in the annotation toolbar allows you to add the sticky note in the document in the PDF Viewer.</td>
</tr>
<tr>
<td>Signature</td>
<td>The button that appears in the annotation toolbar allows you to create and add the signature.</td>
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
<td>The separator that appears in the annotation toolbar positioned before the color picker button.</td>
</tr>
<tr>
<td>Close</td>
<td>The button that appears in the annotation toolbar allows you to close the annotations toolbar.</td>
</tr>
<tr>
<td>PageCountSeparator</td>
<td>The separator that appears in the primary toolbar allows you to separate the page number entry and page count buttons.</td>
</tr>
<tr>
<td>ZoomIconSeparator</td>
<td>The separator that appears in the primary toolbar positioned before the Zoom mode button.</td>
</tr>
<tr>
<td>AnnotationSeparator</td>
<td>The separator that appears in the primary toolbar positioned before the annotations button.</td>
</tr>
<tr>
<td>PrintSeparator</td>
<td>The separator that appears in the primary toolbar positioned after the print button.</td>
</tr>
<tr>
<td>MoreOptionSeparator</td>
<td>The separator that appears in the primary toolbar positioned before the page layout mode.</td>
</tr>
</table>