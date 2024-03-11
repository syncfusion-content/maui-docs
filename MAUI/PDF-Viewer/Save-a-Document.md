---
layout: post
title: Save a Document in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about saving a PDF document in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control to prevent the work from being lost.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Save a Document in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to save a modified document to the specified file stream. It helps you to prevent your work from being lost. You need to provide the PDF file stream as a parameter to the [SaveDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SaveDocument_System_IO_Stream_) method of the `SfPdfViewer`. The modified document will be saved to the given file stream. 

The following example explains how to save the modified document if the document needs to be saved in the application’s data directory. 

{% tabs %}
{% highlight c# %}
private void SaveDocument()
{
	// Create a file stream to save the PDF document. Here a file named "ModifiedDocument.pdf" is created in the application's data directory.
	string fileName = Path.Combine(FileSystem.Current.AppDataDirectory, "ModifiedDocument.pdf");
	using FileStream fileStream = File.Create(fileName);
	
	// Save the PDF document.
	PdfViewer.SaveDocument(fileStream);
}
{% endhighlight %}
{% endtabs %}

To save a document asynchronously, you may use the [SaveDocumentAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_SaveDocumentAsync_System_IO_Stream_System_Threading_CancellationToken_) method  of the `SfPdfViewer`.

## Flatten annotations and form fields on save

Flattening refers to the process of converting interactive elements, such as annotations and form fields, into a static, non-editable format within a PDF document. The SfPdfViewer allows you to save the annotations and form fields by Flatten using `FlattenOnSave` API.

### Flatten annotation on save

The `FlattenOnSave` API helps you to flatten the specified annotation in a PDF document. The following code sample explains how to flatten the first annotation from the annotation collection.

{% tabs %}
{% highlight c# %}
// Obtain the annotation collection using `SfPdfViewer` instance.
ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;
// Obtain the first annotation in the annotation collection.
Annotation annotation = annotations[0];
// set the FlattenOnSave true to flatten the annotation on save
annotation.FlattenOnSave = true;
{% endhighlight %}
{% endtabs %}

### Flatten form field on save

The `FlattenOnSave` API helps you to flatten the specified form field in a PDF document. The following code sample explains how to flatten the first form field from the form field collection.

{% tabs %}
{% highlight c# %}
// Obtain the form field collection using `SfPdfViewer` instance.
ReadOnlyObservableCollection<FormField> formFields = PdfViewer.FormFields;
// Obtain the first form field in the form fields collection.
FormField formField = formFields[0];
// set the FlattenOnSave true to flatten the formfield on save
formField.FlattenOnSave = true;
{% endhighlight %}
{% endtabs %}

### Limitation

The flattening process does not preserve existing sticky note annotations in the saved document specifically in Maccatalyst and IOS platforms.