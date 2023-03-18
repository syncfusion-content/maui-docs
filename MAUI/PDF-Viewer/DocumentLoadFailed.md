---
layout: post
title: Document Load Failures Notification in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about handling document load failures in the Syncfusion .NET MAUI PDF Viewer (SfPdfViewer).
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Document Load Failures Notification in .NET MAUI PDF Viewer (SfPdfViewer)

When a document fails to load in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html), the users will be notified by a message dialog and by [DocumentLoadFailedEvent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed). You can get more details about the error by using the [DocumentLoadFailedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html) of the event. The [Message](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html#Syncfusion_Maui_PdfViewer_DocumentLoadFailedEventArgs_Message) property provides description of the error, while the [Exception](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html#Syncfusion_Maui_PdfViewer_DocumentLoadFailedEventArgs_Exception) property provides information about the exception if any occurred in the control during the load process.

{% tabs %}
{% highlight XAML %}

        <syncfusion:SfPdfViewer 
            x:Name="PdfViewer"
            DocumentLoadFailed="PdfDocumentLoadFailed"/>
			
{% endhighlight %}
{% highlight C#   hl_lines="4" %}

	public MainPage()
	{
		InitializeComponent();
        PdfViewer.DocumentLoadFailed += PdfDocumentLoadFailed;
    }

    private void PdfDocumentLoadFailed(object sender, DocumentLoadFailedEventArgs e)
    {
        string message = e.Message;
        Exception exception = e.Exception;
        if (exception != null)
        {
            string stackTrace = exception.StackTrace;
        }
    }
	
{% endhighlight %}
{% endtabs %}