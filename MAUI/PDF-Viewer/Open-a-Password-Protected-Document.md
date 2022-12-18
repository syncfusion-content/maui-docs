---
layout: post
title: Open an Encryted Document in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about opening a password-protected document in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Open an Encrypted Document in .NET MAUI PDF Viewer (SfPdfViewer)

To open a password-protected or encrypted PDF document, you can use the `LoadDocument()` method by providing the password along with the document source. The following code example explains the same.

{% tabs %}
{% highlight c# %}
string password = "PASSWORD";
pdfViewer.LoadDocument(pdfDocumentStream, password);
{% endhighlight %}
{% endtabs %}

In the above code snippet, `pdfDocumentStream` is the `Stream` instance read from the encrypted PDF, and `password` is the key with which the PDF is encrypted.

## Detecting a password-protected document

You can identify whether a PDF document to be opened is a password protected or not by using the `PasswordRequested` event. This event triggers when the document to be loaded in the `SfPdfViewer` requires a password. In this event handler method, you can set the `password` property from the `PasswordRequestedEventArgs` with the correct password to load the document. Refer to the following code example.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="pdfViewer " DocumentSource="{Binding PdfDocumentStream}" PasswordRequested ="PdfViewer_PasswordRequested">
{% endhighlight %}

{% highlight c# %}
public MainPage()
{
    InitializeComponent();
    Stream pdfDocumentStream = this.GetType().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.Encrypted.pdf");
    PdfViewer.DocumentSource = pdfDocumentStream;
}

private void PdfViewer_PasswordRequested(object sender, PasswordRequestedEventArgs e)
{        
    e.Password = "PASSWORD";
    e.Handled = true;
}
{% endhighlight %}
{% endtabs %}
