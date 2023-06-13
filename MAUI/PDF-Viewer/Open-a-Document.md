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

## Opening a PDF document with annotations

The .NET MAUI PDF Viewer does not currently support annotations comparable to Xamarin.Forms. However, it is possible to view the unsupported annotations in a non-interactive manner. To achieve this, provide the `flattenOptions` (an optional parameter) as `Unsupported` in the `LoadDocument` methods. See the following code example:

{% tabs %}
{% highlight c# hl_lines="2" %}

        Stream pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("GettingStarted.Assets.PDF_Succinctly.pdf");
        FlattenOptions flattenOption = FlattenOptions.Unsupported;
        // Loads the PDF document from the stream with flatten option to render unsupported annotations.
        PdfViewer.LoadDocument(pdfDocumentStream, flattenOptions: flattenOption);

{% endhighlight %}
{% endtabs %}

N> * All the `LoadDocument` methods accept the flatten options parameter.
N> * Refer to this [section](https://help.syncfusion.com/maui/pdf-viewer/migration#upcoming-features) for the upcoming annotation features in the `SfPdfViewer`.

## Check other PDF opening options

* [Open a document from local storage](https://help.syncfusion.com/maui/pdf-viewer/open-a-document-from-local-storage)
* [Open a document from URL](https://help.syncfusion.com/maui/pdf-viewer/open-a-document-from-url)
* [Open a password-protected document](https://help.syncfusion.com/maui/pdf-viewer/open-a-password-protected-document)
