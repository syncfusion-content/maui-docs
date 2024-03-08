---
layout: post
title: Printing PDF files in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about printing feature in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Printing PDF Files in .NET MAUI PDF Viewer (SfPdfViewer)

The print feature of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to effortlessly print PDF documents directly from your application code. Also, the modified form fields and annotations in SfPdfViewer will be preserved properly in the printed document.

![Printing PDF Files in .NET MAUI PDF Viewer](Images\Print\print.jpg)

Moreover, when performing a print operation, the default device print dialog opens, providing users with familiar options and settings to customize their printing experience. Within this dialog, users can adjust settings such as printer selection, the number of copies, page orientation, and more, ensuring that their printed documents meet their specific requirements.

To print a PDF programmatically, you can use the `PrintDocument` method provided by SfPdfViewer. This method enables you to trigger the printing action seamlessly within your application.

{% tabs %}
{% highlight c# %}
// Prints the PDF document.
PdfViewer. PrintDocument();
{% endhighlight %}
{% endtabs %}

Also, SfPdfViewer provides another way to printing through command binding using the `PrintDocumentCommand`. This makes printing easier, especially when used with buttons.

{% tabs %}
{% highlight xaml %}
<!-- Prints the PDF document. -->
<Button Text="&#xe77f;" Command="{Binding Source={x:Reference PdfViewer},Path=PrintDocumentCommand}"/>
{% endhighlight %} 
{% endtabs %}

## Limitations

Currently, when printing a document that contains sticky note annotations, the sticky note icon always appears as the default [comment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.StickyNoteIcon.html#Syncfusion_Maui_PdfViewer_StickyNoteIcon_Comment) icon appearance in the printed document.