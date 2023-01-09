---
layout: post
title: Open a Document in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about opening a PDF document in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Open a Document in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to open PDF documents from various sources, like local storage or URLs. It also lets you view password-protected documents.

This section walks you through the loading and unloading of documents in `SfPdfViewer` and handling the load-specific events.

## Document source types

The document source types accepted by the `SfPdfViewer` are `Stream` and `byte[]`. You can load the PDF document from a specified stream or bytes.

**Load the document from stream** 

{% tabs %}
{% highlight c# %}
// Load the document from Stream
Stream pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("GettingStarted.Assets.PDF_Succinctly.pdf");
PdfViewer.DocumentSource = pdfDocumentStream;
{% endhighlight %}
{% endtabs %}

**Load the document from Byte array**

{% tabs %}
{% highlight c# %}
// Load the document from Byte array
HttpClient httpClient = new HttpClient();
HttpResponseMessage response = await httpClient.GetAsync("https://www.syncfusion.com/downloads/support/directtrac/general/pd/PDF_Succinctly1928776572");
PdfViewer.DocumentSource = await response.Content.ReadAsByteArrayAsync();
{% endhighlight %}
{% endtabs %}

## Unload a document

The `SfPdfViewer` allows you to unload and clear the resources occupied by the PDF document loaded using the [UnloadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_UnloadDocument) method, as shown below.

N> 1. While changing or opening different documents on the same page, the previously loaded document will be unloaded automatically by the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). 
N> 2. And, if you are using multiple pages in your application, then make sure to unload the document from the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) while leaving the page that has it to release the memory and resources consumed by the PDF document that is loaded.  The unloading of documents can be done by calling the [UnloadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_UnloadDocument) method. 

{% tabs %}
{% highlight c# %}
//Unload the document from the PDF viewer.
PdfViewer.UnloadDocument();
{% endhighlight %}
{% endtabs %}

## Events

The `SfPdfViewer` supports the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) and [DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) events to notify whether the document has been opened and displayed in the view or not.

### Document loaded event

The [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) event triggers after the document is loaded in the `SfPdfViewer`. Refer to the following code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="PdfViewer" DocumentSource="{Binding PdfDocumentStream}" DocumentLoaded="PdfViewer_DocumentLoaded">
{% endhighlight %}

{% highlight c# %}
private void PdfViewer_DocumentLoaded(object sender, EventArgs e)
{
   DisplayAlert("Info", "Document loaded successfully", "OK");
}
{% endhighlight %}
{% endtabs %}

If you want to initially open a document with a specific page number or zoom factor, then call the respective APIs in this event handler. The following code example explains opening a document with a specified page number of 4.

{% tabs %}
{% highlight c# %}
private void PdfViewer_DocumentLoaded(object sender, EventArgs e)
{
    pdfViewer.GoToPage(4);
}
{% endhighlight %}
{% endtabs %}

### Document load failed event

The [DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) event triggers when the document loading fails in the `SfPdfViewer`. That is,
* When any corrupted document is loaded
* When any password-protected document is loaded with an invalid or empty password
* When any non-PDF document is loaded

The [DocumentLoadFailedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html) will return the error `Message` and `Exception` details for the failure. The following code example explains the same.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="PdfViewer" DocumentSource="{Binding PdfDocumentStream}" DocumentLoadFailed="PdfViewer_DocumentLoadFailed">
{% endhighlight %}

{% highlight c# %}
private void PdfViewer_DocumentLoadFailed(object sender, DocumentLoadFailedEventArgs e)
{
   DisplayAlert( e.Message, e.Exception.StackTrace, "OK");
}
{% endhighlight %}
{% endtabs %}

## Check other PDF opening options

* [Open a document from local storage](https://help.syncfusion.com/maui/pdf-viewer/open-a-document-from-local-storage)
* [Open a document from URL](https://help.syncfusion.com/maui/pdf-viewer/open-a-document-from-url)
* [Open a password-protected document](https://help.syncfusion.com/maui/pdf-viewer/open-a-password-protected-document)
