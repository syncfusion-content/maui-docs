---
layout: post
title: Customize the built-in modal view in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about customizing the built-in modal view in .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Customize the built-in modal view in .NET MAUI PDF Viewer (SfPdfViewer)

The [Sfpdfviewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows receives notifications when the following operations appear and disappear:

* Creating and editing free text.

* Creating and editing sticky notes.

* Creating custom stamps.

* Creating signatures using the signature pad.

### Free Text Modal View

The `Sfpdfviewer.FreeTextModalViewAppearing` event is triggered whenever the modal view opens for free text annotation. You can cancel the opening of the modal view for the current free text annotation being edited by setting `e.Cancel = true`, allowing you to display your own custom dialog.

{% tabs %}
{% highlight c# %}

Annotation editedAnnotation;
CustomIcon customIcon;
pdfviewer.FreeTextModalViewAppearing += PdfViewer_AnnotationModalViewAppearing;
………
private void PdfViewer_FreeTextModalViewAppearing(object? sender, Syncfusion.Maui.PdfViewer.AnnotationModalViewAppearingEventArgs e)
{
    e.Cancel = true;
    editedAnnotation = e.Annotation;
    // Implement your own UI for free text editor and show it.
    ShowCustomDialog();
    customIcon.IsVisible = false;
}

Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   //Get the typed text in the custom dialog 
   string newText = customDialog.Text; 
   if(editedAnnotation is FreeTextAnnotation freeText)
   freeText.Text = newText;
}

{% endhighlight %} 
{% endtabs %}

The `Sfpdfviewer.FreeTextModalViewDisappearing` event is triggered whenever the modal view for free text annotation is closing.

{% tabs %}
{% highlight c# %}

pdfviewer.FreeTextModalViewDisappearing += PdfViewer_FreeTextModalViewDisappearing;
….
private void PdfViewer_FreeTextModalViewDisappearing(object? sender, EventArgs e)
 {
    // Show your own icons / custom dialog while disappearing the modal view at application level. 
    customIcon.IsVisible = true;
 }

{% endhighlight %} 
{% endtabs %}


N> These notifications are only available on Android and iOS platforms.

### Sticky note modal view

The `Sfpdfviewer.StickyNoteModalViewAppearing` event is triggered whenever the modal view opens for sticky note annotation. You can cancel the opening of the modal view for the current sticky note annotation being edited by setting `e.Cancel = true`, allowing you to display your own custom dialog.

{% tabs %}
{% highlight c# %}

Annotation editedAnnotation;
CustomIcon customIcon;
pdfviewer.StickyNoteModalViewAppearing += PdfViewer_StickyNoteModalViewAppearing;
……
private void PdfViewer_StickyNoteModalViewAppearing(object? Sender, AnnotationModalViewAppearingEventArgs e)
 {
    e.Cancel = true;
    editedAnnotation = e.Annotation;
    // Implement your own UI for sticky note editor and show it.
    ShowCustomDialog();
    customIcon.IsVisible = false;

}
….
Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   //Get the typed text in the custom dialog 
   string newText = customDialog.Text; 
   if(editedAnnotation is StickyNoteAnnotation stickyNote)
   stickyNote.Text = newText;
}

{% endhighlight %} 
{% endtabs %}

The `Sfpdfviewer.StickyNoteModalViewDisappearing` event is triggered whenever the modal view for sticky note annotation is closing.

{% tabs %}
{% highlight c# %}

Pdfviewer.StickyNoteModalViewDisappearing += PdfViewer_StickyNoteModalViewDisappearing;
….
Private void PdfViewer_StickyNoteModalViewDisappearing(object? Sender, EventArgs e)
{
     // Show your own icons / custom dialog while disappearing the modal view at application level. 
      customIcon.IsVisible = true;
}

{% endhighlight %} 
{% endtabs %}

N> These notifications are only available on Android and iOS platforms. 

### Custom stamp modal view

The `Sfpdfviewer.CustomStampModalViewAppearing` event is triggered whenever the modal view opens for custom stamp. You can cancel the opening of the modal view for the current stamp annotation being edited by setting `e.Cancel = true`, allowing you to display your own custom dialog.

{% tabs %}
{% highlight c# %}

PdfViewer.CustomStampModalViewAppearing += PdfViewer_CustomStampModalViewAppearing;
CustomIcon customIcon;
Annotation editedAnnotation;
……
private void PdfViewer_CustomStampModalViewAppearing(object? sender, AnnotationModalViewAppearingEventArgs e)
{
    e.Cancel = true;
    editedAnnotation = e.Annotation;
    // Implement your own UI for custom stamp annotation and show it.
    ShowCustomDialog();
    customIcon.IsVisible = false;
}

Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   //Get the typed opacity value in the custom dialog 
   float newOpacity = customDialog.OpacityValue; 
   if (annotation is StampAnnotation customStamp)
   {
     customStamp.Opacity = newOpacity;
   }
}

{% endhighlight %} 
{% endtabs %}

The `Sfpdfviewer.CustomStampModalViewDisappearing` event is triggered whenever the modal view for stamp annotation is closing.

{% tabs %}
{% highlight c# %}

pdfviewer.CustomStampModalViewDisappearing += PdfViewer_StickyNoteModalViewDisappearing;
….
private void PdfViewer_CustomStampModalViewDisappearing(object? sender, EventArgs e)
{
    // Show your own icons / custom dialog while disappearing the modal view at application level. 
      customIcon.IsVisible = true;
}

{% endhighlight %} 
{% endtabs %}

### Signature Pad Modal View 

The `Sfpdfviewer.SignatureModalViewAppearing` event is triggered whenever the modal view opens for signature pad. You can cancel the opening of the modal view for the current signature pad being edited by setting `e.Cancel = true`, allowing you to display your own custom dialog.

{% tabs %}
{% highlight c# %}

FormField formField;
CustomIcon customIcon;
……..
pdfviewer.SignatureModalViewAppearing += PdfViewer_SignatureModalViewAppearing;
……..

private void PdfViewer_SignatureModalViewAppearing(object? sender, FormFieldModalViewAppearingEventArgs e)
 {
     e.Cancel = true;
     formField = e.FormField;
    // Implement your own UI for signature pad annotation and show it.
    ShowCustomDialog();
    customIcon.IsVisible = false;
 }

Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   if(formField is SignatureFormField signatureField)
  {
     List<List<float>> inkPointsCollection  = customDialog.InkPointsCollection;
     InkAnnotation inkSignature = new InkAnnotation(inkPointsCollection, signature.PageNumber);

     inkSignature.Color = Colors.Red;
      // Add the created handwritten signature to the signature form field.
     signatureField.Signature = inkSignature;
  }  
}

{% endhighlight %} 
{% endtabs %}

The `Sfpdfviewer.SignatureModalViewDisappearing` event is triggered whenever the modal view for signature pad is closing.

{% tabs %}
{% highlight c# %}

pdfviewer.SignatureModalViewDisappearing += PdfViewer_SignatureModalViewDisappearing;
…..
private void PdfViewer_SignatureModalViewDisappearing(object? sender, EventArgs e)
 {
      // Show your icons / custom dialog while disappearing the modal view at application level. 
      customIcon.IsVisible = true;     
 }

{% endhighlight %} 
{% endtabs %}