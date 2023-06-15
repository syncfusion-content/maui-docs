---
layout: post
title: Navigate using document link navigation in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about document link navigation in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Document link navigation

The PDF viewer allows navigating from one part of the PDF document to another using document link annotations. When a document link annotation is tapped, the PDF viewer scrolls to its destination. This type of link annotations is most often used to represent the table of contents of a PDF document. 

The document link navigation can be turned on or off using the [EnableDocumentLinkNavigation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_EnableDocumentLinkNavigation) property. The default value of this property is true. The below code snippet illustrates disabling the document link navigation.

{% tabs %}
{% highlight c# %}

pdfViewer.EnableDocumentLinkNavigation = false;

{% endhighlight %}
{% endtabs %}
