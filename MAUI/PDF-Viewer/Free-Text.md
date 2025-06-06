---
layout: post
title: Free Text Annotation in .NET MAUI PDF Viewer Control | Syncfusion
description: Learn here about Free Text Annotation in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control and its functions.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords : .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Free Text Annotations in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to add, remove, and modify free text annotation in the PDF document. This is useful for adding text notes, comments, or feedback to the PDF pages. This section will go through the functions available in PDF Viewer for working with free text annotations.

## Add free text annotations

This section will go through how to add free text annotations to a PDF page using toolbar as well as programmatically.

### Add the free text annotations using the toolbar  

On the built-in toolbar, a free text annotation tool is available. Using that, you can add the free text annotation to the tapped position. Additionally, the toolbar shows the option to modify the properties of existing or new free text annotations.

The following image represents how to add the free text annotations using the toolbar on the desktop.

![Free text Built-in toolbar](Images/desktopfreetext.gif)

The following image represents how to add the free text annotation using the toolbar on mobile.

![Free text Built-in toolbar](Images/mobilefreetext.gif)
 
### Add free text annotation without using the toolbar

You can add free text annotation to a PDF document by tapping with a touch (or mouse down) on a PDF page. The following steps explain how to add free text annotation in a PDF.

1.	Set the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html) property of the SfPdfViewer to [FreeText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_FreeText). It activates the free text annotation mode.
2.	Tap (or mouse down) on a PDF page, where you want to add the free text annotation. This will add a text box with a default style and allow you to write your text inline on the Desktop platforms. In mobile, a popup will be displayed to write and submit the text.
3.	You can add multiple free text annotations in this mode in a similar manner.
4.	Once you have done this, set the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html) to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_None). It will disable the annotation mode. 
5.	You can later select and edit the annotations if required.

The following code explains how to enable the free text annotation mode.

{% tabs %}
{% highlight C# %}
// Enable or activate the free text mode.
void EnableFreetextMode()
{
    // Set the annotation mode to FreeText using the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
    PdfViewer.AnnotationMode = AnnotationMode.FreeText;
}
{% endhighlight %}
{% endtabs %}

Similarly, refer to the following code to disable the free text annotation mode.

{% tabs %}
{% highlight C# %}
// Disable or deactivate the free text mode.
void DisableFreetextMode()
{
    // Set the annotation mode to none using the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
    PdfViewer.AnnotationMode = AnnotationMode.None;
}
{% endhighlight %}
{% endtabs %}

### Adding Annotations Programmatically

You can create and add a free Text annotation to a PDF document programmatically using the [AddAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AddAnnotation_Syncfusion_Maui_PdfViewer_Annotation_) method of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). The following example explains how to create a free text annotation and add it to the first page of a PDF document.

{% tabs %}
{% highlight C# %}
// Create a free text annotation. 
FreeTextAnnotation CreateFreeTextAnnotation() 
{ 
   int pageNumber = 1;  
   // Set the text for the free text.
   string text = "Free Text Annotation";
   // Set the bounds of the free text annotation.
   RectF bounds = new RectF(100,100,100,28);
   // Create a free text annotation.
   FreeTextAnnotation annotation = new FreeTextAnnotation(text, pageNumber, bounds);
   // Set the appearance of the free text annotation (if required).
   annotation.FontSize = 16; // Font size
   annotation.BorderColor = Colors.Yellow; // Border color
   annotation.BorderWidth = 4; // Border thickness
   annotation.Color = Colors.White; // Text color
   annotation.FillColor= Colors.Black; // Background fill color
   // Return the annotation. 
   return annotation;
} 
 
void AddFreeTextAnnotation() 
{ 
    Annotation freeTextAnnotation = CreateFreeTextAnnotation (); 
 
    // Add the free text annotation to the PDF document using the `AddAnnotation` method of the `SfPdfViewer` instance. 
    PdfViewer.AddAnnotation(freeTextAnnotation); 
} 
{% endhighlight %}
{% endtabs %}

## Free text annotation settings

In the free text annotation mode, the annotation will be added with a default appearance. You can modify the annotation after it has been added to the pages. However, if you need to define the appearance before adding free text annotation on the document, you can change its default settings using the [AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). For that, you need to obtain the default free text annotation settings.

The following example explains how to obtain the default free text annotation settings and modify some of its properties. Similarly, you can modify all the other properties.

{% tabs %}
{% highlight C# %}
void CustomizeDefaultFreeTextSettings() 
{ 
   // Obtain the default free text annotation settings from the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance. 
   FreeTextAnnotationSettings freeTextSettings = PdfViewer.AnnotationSettings.FreeText; 
 
   // Modify the default appearance properties. 
   freeTextSettings.Color = Colors.White; // Text color 
   freeTextSettings.BorderWidth = 2; // Border thickness 
   freeTextSettings.FillColor = Colors.Black; // Fill color
   freeTextSettings.BorderColor = Colors.Yellow; // Border Color
   freeTextSettings.FontSize = 16; // Font size
   freeTextSettings.Opacity = 0.75f; // 75% opacity 
}
{% endhighlight %}
{% endtabs %}

### How to create a borderless free text annotation?

The PDF Viewer allows you to customize annotation properties using the [AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html) property. By default, free text annotations include a visible border. To create a borderless free text annotation, set the [BorderWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.FreeTextAnnotationSettings.html#Syncfusion_Maui_PdfViewer_FreeTextAnnotationSettings_BorderWidth) property to 0 using the [FreeTextAnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.FreeTextAnnotationSettings.html#properties).

The following example demonstrates how to create a borderless free text annotation:

{% tabs %}
{% highlight C# %}
// Access the default free text annotation settings
FreeTextAnnotationSettings freeTextSettings = pdfViewer.AnnotationSettings.FreeText;

// Set the border width to zero to remove the border
freeTextSettings.BorderWidth = 0;
{% endhighlight %}
{% endtabs %}

## Edit the selected free text annotation

### Edit the text with UI interaction

Double-tapping the selected free text annotation will allow you to edit its text content.

* In the desktop platforms (Windows and macOS), double tapping the selected annotation will activate editing mode, which lets you type text directly into the annotation.
* In the mobile platforms (Android and iOS), double tapping the selected annotation will open a text editor where you can make changes to the text and save it.

### Edit free text annotation properties programmatically

You can also edit the properties of the selected free text annotation programmatically by accessing the selected annotation instance. The selected annotation instance may be obtained from the [AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected) event. The following example shows how to edit some of the properties of the selected free text annotation. Similarly, you can modify the other free text properties.

{% tabs %}
{% highlight C# %}
/// <summary>
/// Edit the selected free text annotation.
/// </summary>
/// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event</param>
void EditSelectedFreeTextAnnotation(Annotation selectedAnnotation) 
{ 
    // Typecast the selected annotation as a free text annotation. 
    if (selectedAnnotation is FreeTextAnnotation freeTextAnnotation) 
    { 
       freeTextAnnotation.Color = Colors.White;    
       freeTextAnnotation.BorderWidth = 6;       
       freeTextAnnotation.Opacity = 0.75f;       
       freeTextAnnotation.FillColor = Colors.Black; 
       freeTextAnnotation.BorderColor = Colors.Yellow; 
       freeTextAnnotation.FontSize = 16;
       freeTextAnnotation.Text = "Modified content";
    } 
}
{% endhighlight %}
{% endtabs %}

## Free text modal view

The free text modal view appears when text needs to be input by the user for creating and editing free text annotations in Android and iOS platforms. The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) notifies when the modal view is appearing and disappearing through events. The events help you in hiding and showing elements that are part of the app UI that are not necessary as long as the modal view is visible.

![Free text modal view](Images/Annotations/free-text-modal-view.png)

The `SfPdfViewer.FreeTextModalViewAppearing` event is triggered whenever the modal view opens for either creating or editing a free text annotation.

{% tabs %}
{% highlight c# %}

pdfviewer.FreeTextModalViewAppearing += PdfViewer_FreeTextModalViewAppearing;

private void PdfViewer_FreeTextModalViewAppearing(object? Sender, AnnotationModalViewAppearingEventArgs e)
{
    // Implement the logic to hide unwanted UI elements such as toolbar items added to the app UI. 
}

{% endhighlight %}
{% endtabs %}

The `SfPdfViewer.FreeTextModalViewDisappearing` event is triggered when the modal view is closing.

{% tabs %}
{% highlight c# %}

pdfviewer.FreeTextModalViewDisappearing += PdfViewer_FreeTextModalViewDisappearing;

Private void PdfViewer_FreeTextModalViewDisappearing(object? Sender, EventArgs e)
{
    // Implement the logic to show the UI elements that were hidden from the FreeTextModalViewAppearing event handler.
}

{% endhighlight %} 
{% endtabs %}

### Suppressing the free text modal view and implementing your own UI

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to suppress the free text modal view and use your own UI in its place. This can be achieved by setting the [AnnotationModalViewAppearingEventArgs.Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ModalViewAppearingEventArgs.html#Syncfusion_Maui_PdfViewer_ModalViewAppearingEventArgs_Cancel) property to `true` in the [FreeTextModalViewAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_FreeTextModalViewAppearing) event handler. 

The below code snippet illustrates suppressing the free text modal view and using a UI implemented in the app in its place. The free text annotation instance that is created or edited can be obtained from the event args. Once the user enters the text in the custom dialog and confirms, the text can be assigned to this free text annotation instance. 

{% tabs %}
{% highlight c# %}

Annotation editedAnnotation;
pdfviewer.FreeTextModalViewAppearing += PdfViewer_FreeTextModalViewAppearing;

private void PdfViewer_FreeTextModalViewAppearing(object? Sender, AnnotationModalViewAppearingEventArgs e)
{
    e.Cancel = true;
    editedAnnotation = e.Annotation;
    // Implement your own UI for free text editor and show it.
    ShowCustomDialog();
}

Private void customDialogOkButton_Clicked(object sender, EventArgs e)
{
   //Get the typed text from the custom dialog 
   string newText = customDialog.Text; 
   if(editedAnnotation is FreeTextAnnotation freeText)
   {
      freeText.Text = newText;
   }
}

{% endhighlight %} 
{% endtabs %}

N> For WinUI and MacCatalyst platforms, there is no separate modal view to receive text input from the users. As a result, the [FreeTextModalViewAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_FreeTextModalViewAppearing) and [FreeTextModalViewDisappearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_FreeTextModalViewDisappearing) events are not applicable for these platforms. 
