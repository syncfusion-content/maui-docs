---
layout: post
title: Stamp Annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Stamp Annotations in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its types.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Stamp Annotations in .NET MAUI PDF Viewer (SfPdfViewer)

The stamp annotations feature of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to add, remove and modify stamps or custom images in the PDF document. This section will go through the various types and functions available in PDF Viewer for working with stamp annotations.

## Types of stamps

The following stamp annotation types are now available in the PDF Viewer.

1.	Standard (or built-in) stamps.
2.	Custom (or image) stamps.

## Add stamps to a PDF document

This section will go through how to add stamp annotations to a PDF document programmatically to a PDF document.

### Add standard stamps

There are 18 standard stamp types are available in the `SfPdfViewer` that are most commonly used in documents. The appropriate standard stamp type can be selected from the [StampType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.StampType.html) enumeration. 

The following example explains how to create a [Approved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.StampType.html#Syncfusion_Maui_PdfViewer_StampType_Approved) standard stamp and add it to the first page of a PDF document using the [AddAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AddAnnotation_Syncfusion_Maui_PdfViewer_Annotation_) method of the `SfPdfViewer`.

{% tabs %}
{% highlight C# %}
StampAnnotation CreateApprovedStandardStamp()
{
    int pageNumber = 1;

    // Define the position to place the stamp.
    PointF position = new PointF(100, 100);

    // Create an approved standard stamp.
    StampAnnotation approvedStamp = new StampAnnotation(StampType.Approved, pageNumber, position);
    
    //return the stamp
    return approvedStamp;
}

void AddStampAnnotation()
{
    StampAnnotation stampAnnotation = CreateApprovedStandardStamp();

    // Add the stamp to the PDF document using `SfPdfViewer` instance.
    PdfViewer.AddAnnotation(stampAnnotation);
}
{% endhighlight %}
{% endtabs %}

The following image represents the approved standard stamp appearance in the PDF document.

![Standard Approved Stamp.](Images/Annotations/approved-stamp.png)

### Add custom stamps

You can create a custom stamp from any images and add it to a PDF document. The following example explains how to create a custom stamp from an image in the application and add it to a PDF document using the `AddAnnotation` method of the `SfPdfViewer`.

{% tabs %}
{% highlight C# %}
StampAnnotation CreateCustomStamp()
{
    int pageNumber = 1;

    // Define the position and size for the stamp to be placed in the PDF page.
    RectF bounds = new RectF(50, 50, 200, 100);

    // Create image stream from the image to be used as stamp.
    Stream imageStream = this.GetType().Assembly.GetManifestResourceStream("Annotations.Assets." + "Logo.png");

    // Create a custom stamp annotation using the image steeam.
    StampAnnotation customStamp = new StampAnnotation(imageStream,pageNumber,bounds);

    // Return the stamp annotation.
    return customStamp;
}

void AddCustomStampAnnotation()
{
    StampAnnotation stampAnnotation = CreateCustomStamp();

    // Add the stamp to the PDF document using `SfPdfViewer` instance.
    PdfViewer.AddAnnotation(stampAnnotation);
}
{% endhighlight %}
{% endtabs %}

## Edit the selected stamp

You can edit the properties of the selected stamp annotation programmatically by accessing the selected annotation instance. The selected annotation instance may be obtained from the [AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected) event. 

The following example shows how to edit some of the properties of the selected stamp annotation. Similarly, you can modify the other properties if required.

{% tabs %}
{% highlight C# %}
/// <summary>
/// Edit the selected stamp annotation.
/// </summary>
/// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event</param>
void EditSelectedStampAnnotation(Annotation selectedAnnotation)
{
    // Type cast the selected annotation as stamp annotation.
    if (selectedAnnotation is StampAnnotation stampAnnotation)
    {
        // Change the opacity to 75%.
        stampAnnotation.Opacity = 0.75f;
    }
}
{% endhighlight %}
{% endtabs %}

## Custom stamp modal view

The custom stamp modal view appears when the user wants to create a custom stamp from a typed text. The [Sfpdfviewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) notifies when the modal view is appearing and disappearing through events. The events help you in hiding and showing elements that are part of the app UI that are not necessary as long as the modal view is visible.

### Custom stamp modal view mobile

![Custom stamp modal view mobile](Images/Annotations/custom-stamp-modal-view-mobile.png)

### Custom stamp modal view desktop

![Custom stamp modal view desktop](Images/Annotations/custom-stamp-modal-view-mobile-desktop.png)

The `Sfpdfviewer.CustomStampModalViewAppearing` event is triggered when the modal view opens for creating a custom stamp.

{% tabs %}
{% highlight c# %}

PdfViewer.CustomStampModalViewAppearing += PdfViewer_CustomStampModalViewAppearing;

private void PdfViewer_CustomStampModalViewAppearing(object? sender, AnnotationModalViewAppearingEventArgs e)
{
    // Implement the logic to hide unwanted UI elements such as toolbar items add in the app UI. 
}

{% endhighlight %} 
{% endtabs %}

The `Sfpdfviewer.CustomStampModalViewDisappearing` event is triggered whenever the modal view for stamp annotation is closing.

{% tabs %}
{% highlight c# %}

pdfviewer.CustomStampModalViewDisappearing += PdfViewer_StickyNoteModalViewDisappearing;

private void PdfViewer_CustomStampModalViewDisappearing(object? sender, EventArgs e)
{
    // Implement the logic to show the UI elements that were hidden from the CustomStampModalViewAppearing event handler.
}

{% endhighlight %} 
{% endtabs %}

### Supressing the sticky note modal view and implement your own UI

The [Sfpdfviewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to supress the custom stamp modal view and use your own UI in its place. This can be achieved by setting the `CustomStampModalViewAppearingEventArgs.Cancel` property to `true` in the `CustomStampModalViewAppearing` event handler. 

The below code snippet illustrates supressing the custom stamp modal view and using a UI implemented in the app in its place. In this illustration, when the user types a text in your own dialog and clicks the ok button, the text is converted into an image stream and a StampAnnotation instance is created. When the PDF viewer is tapped, the stamp annotation is added in the tapped position. 

{% tabs %}
{% highlight c# %}

Stream stampImageStream;
pdfviewer.CustomStampModalViewAppearing += PdfViewer_CustomStampModalViewAppearing;
pdfViewer.Tapped += PdfViewer_Tapped;

private void PdfViewer_CustomStampModalViewAppearing(object? Sender, AnnotationModalViewAppearingEventArgs e)
{
    e.Cancel = true;
    // Implement your own UI for sticky note editor and show it.
    ShowCustomDialog();
}

Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   //Get the typed text from the custom dialog 
   string newText = customDialog.Text;

   // Implement the logic to create an image stream instance from the typed text. 
   stampImageStream = GetStampAnnotationFromText();
}

private void PdfViewer_Tapped(object sender, GestureEventArgs e)
{
    PointF position = e.PagePosition;
    int pageNumber = e.PageNumber;
    StampAnnotation stamp = new StampAnnotation(stampImageStream, pageNumber,  new RectF(position.X, position.Y, 200, 200));
    pdfViewer.AddAnnotation(stamp);
}

{% endhighlight %} 
{% endtabs %}