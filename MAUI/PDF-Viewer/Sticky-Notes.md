---
layout: post
title: Sticky Note Annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Sticky Note Annotations in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its functionalities.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Sticky Note Annotation in .NET MAUI PDF Viewer (SfPdfViewer)

The sticky note annotation feature of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to add, remove, and modify sticky notes in a PDF document. This feature will help add comments or notes to specific parts of a document to clarify complex concepts, terms, or ideas. This section will cover the various functions available in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) for working with sticky note annotations.

## Types of sticky notes

The following sticky note icon types are currently available in [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). The icon types can be selected from the `StickyNoteIcon` enumeration.

![Sticky note icon types](Images/Annotations/sticky-note-icon-types.png)

## Add sticky notes

Currently, there is no support for a sticky note annotation mode in the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) property.  However, the sticky notes can be added programmatically using the [AddAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AddAnnotation_Syncfusion_Maui_PdfViewer_Annotation_) method of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html).

The following example explains how to create a sticky note with a comment icon and add it to the first page of a PDF document.

{% tabs %}
{% highlight C# %}
StickyNoteAnnotation CreateCommentStickyNote()
{
    int pageNumber = 1;
        
    // Set the position of the sticky note on the PDF page. 
    PointF position = new PointF(100, 100);

    // Set the icon as Comment.
    StickyNoteIcon icon = StickyNoteIcon.Comment;

    // Set the text for the sticky note.
    string text = "Links are not working and need to be updated";
        
    return new StickyNoteAnnotation(icon, text, pageNumber, position);
}

void AddStickyNote()
{
    StickyNoteAnnotation stickyNote = CreateCommentStickyNote();
    PdfViewer.AddAnnotation(stickyNote);
}

{% endhighlight %}
{% endtabs %}

## Edit the selected sticky note annotation

### Edit the text using UI interaction

When you double-tap the selected sticky note, the text editor opens. Edit the text and click &#34;Save&#34; to modify the text.

![Sticky note editing](Images/Annotations/sticky-notes-edit.gif)

### Edit sticky note properties programmatically

Edit the properties of the selected sticky note annotation programmatically by accessing the selected annotation instance. The selected annotation instance may be obtained from the [AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected) event. The following example shows how to edit the text and icon of the selected sticky note annotation. Similarly, you can modify the other properties.

{% tabs %}
{% highlight C# %}
/// <summary> 
/// Edit the selected sticky note annotation. 
/// </summary> 
/// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event</param>    

void EditSelectedStickyNoteAnnotation(Annotation selectedAnnotation)
{
    if (selectedAnnotation is StickyNoteAnnotation selectedStickyNote)
    {
        selectedStickyNote.Icon = StickyNoteIcon.Note;
        selectedStickyNote.Text = "Changed the comment to note.";
    }
}
{% endhighlight %}
{% endtabs %}

## Sticky note modal view

The sticky note modal view appears when text needs to be input by the user for creating and editing sticky note annotations in Android and iOS platforms. The [Sfpdfviewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) notifies when the modal view is appearing and disappearing through events. The events help you in hiding and showing elements that are part of the app UI that are not necessary as long as the modal view is visible. 

![Sticky note modal view](Images/Annotations/sticky-note-modal-view.png)

The `Sfpdfviewer.StickyNoteModalViewAppearing` event is triggered whenever the modal view opens for either creating or editing a sticky note annotation.

{% tabs %}
{% highlight c# %}

pdfviewer.StickyNoteModalViewAppearing += PdfViewer_StickyNoteModalViewAppearing;

private void PdfViewer_StickyNoteModalViewAppearing(object? Sender, AnnotationModalViewAppearingEventArgs e)
{
    // Implement the logic to hide unwanted UI elements such as toolbar items add in the app UI. 
}

{% endhighlight %}
{% endtabs %}

The `Sfpdfviewer.StickyNoteModalViewDisappearing` event is triggered when the modal view is closing.

{% tabs %}
{% highlight c# %}

pdfviewer.StickyNoteModalViewDisappearing += PdfViewer_StickyNoteModalViewDisappearing;

Private void PdfViewer_StickyNoteModalViewDisappearing(object? Sender, EventArgs e)
{
    // Implement the logic to show the UI elements that were hidden from the StickyNoteModalViewAppearing event handler.
}

{% endhighlight %} 
{% endtabs %}

### Supressing the sticky note modal view and implement your own UI

The [Sfpdfviewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to supress the sticky note modal view and use your own UI in its place. This can be achieved by setting the `AnnotationModalViewAppearingEventArgs.Cancel` property to `true` in the `StickyNoteModalViewAppearing` event handler. 

The below code snippet illustrates supressing the sticky note modal view and using a UI implemented in the app in its place. The sticky note annotation instance that is created or edited can be obtained from the event args. Once the user enters the text in the custom dialog and confirms, the text can be assigned to this sticky note annotation instance. 

{% tabs %}
{% highlight c# %}

Annotation editedAnnotation;
pdfviewer.StickyNoteModalViewAppearing += PdfViewer_StickyNoteModalViewAppearing;

private void PdfViewer_StickyNoteModalViewAppearing(object? Sender, AnnotationModalViewAppearingEventArgs e)
{
    e.Cancel = true;
    editedAnnotation = e.Annotation;
    // Implement your own UI for sticky note editor and show it.
    ShowCustomDialog();
}

Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   //Get the typed text from the custom dialog 
   string newText = customDialog.Text; 
   if(editedAnnotation is StickyNoteAnnotation stickyNote)
   {
      stickyNote.Text = newText;
   }
}

{% endhighlight %} 
{% endtabs %}

N> For WinUI and MacCatalyst platforms, there is no separate modal view to receive text input from the users. As a result, the `StickyNoteModalViewAppearing` and `StickyNoteModalViewDisappearing` events are not applicable for these platforms. 