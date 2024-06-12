---
layout: post
title: Document Load Notifications in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about events that notifies whether the document has been opened or not opened in the Syncfusion .NET MAUI PDF Viewer (SfPdfViewer).
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Document Load Notifications in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) supports the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) and [DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) events to notify whether the document has been opened and displayed in the view or not.

## Document loaded event

The `DocumentLoaded` event triggers after the document is loaded in the `SfPdfViewer`. Refer to the following code example:

{% tabs %}
{% highlight XAML hl_lines="3" %}

	<syncfusion:SfPdfViewer 
		x:Name="PdfViewer" 
		DocumentLoaded="PdfViewer_DocumentLoaded"/>

{% endhighlight %}
{% highlight C# %}

	private void PdfViewer_DocumentLoaded(object sender, EventArgs e)
	{
	   DisplayAlert("Info", "Document loaded successfully", "OK");
	}

{% endhighlight %}
{% endtabs %}

If you want to perform any operation immediately after the document has loaded, you can handle the operations in this event. For example, if you want to initially open a document with a specific page number or zoom factor, then call the respective APIs in this event handler. The following code example explains opening a document with a specified page number of 4.

{% tabs %}
{% highlight C# %}

private void PdfViewer_DocumentLoaded(object sender, EventArgs e) 
{ 
	pdfViewer.GoToPage(4); 
}

{% endhighlight %}
{% endtabs %}

## Document load failures

When a document fails to load in the `SfPdfViewer`, the users will be notified with a default message prompt by the `DocumentLoadFailedEvent`.

### Document load failed event

The `DocumentLoadFailed` event triggers when the document loading fails in the `SfPdfViewer`. That is,
* When any corrupted document is loaded
* When any password-protected document is loaded with an invalid or empty password
* When any non-PDF document is loaded

The [DocumentLoadFailedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html) will return the error [Message](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html#Syncfusion_Maui_PdfViewer_DocumentLoadFailedEventArgs_Message) and [Exception](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html#Syncfusion_Maui_PdfViewer_DocumentLoadFailedEventArgs_Exception) details for the failure. The following code example explains the same.

{% tabs %}
{% highlight XAML hl_lines="3" %}

	<syncfusion:SfPdfViewer 
		x:Name="PdfViewer" 
		DocumentLoadFailed="PdfViewer_DocumentLoadFailed"/>
	
{% endhighlight %}
{% highlight C# %}

	private void PdfViewer_DocumentLoadFailed(object sender, DocumentLoadFailedEventArgs e)
	{
		DisplayAlert( e.Message, e.Exception.StackTrace, "OK");
	}

{% endhighlight %}
{% endtabs %}

### Handling document load failures

The `DocumentLoadFailed` event allows you to handle the load failures at the application level in your own way. Set the [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html#Syncfusion_Maui_PdfViewer_DocumentLoadFailedEventArgs_Handled) property of the `DocumentFailedEventArgs` to `true` to disable the control’s default error messages and handle your logic with the error information.

{% tabs %}
{% highlight XAML hl_lines="3" %}

        <syncfusion:SfPdfViewer 
            x:Name="PdfViewer"
            DocumentLoadFailed="PdfDocumentLoadFailed"/>
			
{% endhighlight %}
{% highlight C# hl_lines="4" %}

	public MainPage()
	{
		InitializeComponent();
        PdfViewer.DocumentLoadFailed += PdfDocumentLoadFailed;
    }

    private void PdfDocumentLoadFailed(object sender, DocumentLoadFailedEventArgs e)
    {
        e.Handled = true;
        // Handle your logic here.
    }
	
{% endhighlight %}
{% endtabs %}