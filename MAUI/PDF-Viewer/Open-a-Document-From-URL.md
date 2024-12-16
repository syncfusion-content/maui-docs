---
layout: post
title: Open a Document From URL in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about opening a PDF document from the URL in Syncfusion® .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Open a Document From URL in .NET MAUI PDF Viewer (SfPdfViewer)

A PDF document can be opened in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) from a given URL by converting it to byte[] and assigning the obtained byte[] to the [DocumentSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource) property. 

N>If you experience issues loading a document into the PDF viewer from a URL, it may not be an issue with the PDF viewer itself. If you face issues, please ensure the PDF file is accessible by checking the URL validity, network connectivity, and authentication, and try opening the URL in a web browser.

Just by making a few changes to the `PdfViewerViewModel.cs` shared in the getting started example, you can easily open a document from a given URL. Refer to the following code example:

{% tabs %}
{% highlight c# tabtitle="PdfViewerViewModel.cs" %}

using System.Reflection;
using System.ComponentModel;

namespace PdfViewerExample
{
    class PdfViewerViewModel : INotifyPropertyChanged
    {
        private Stream? m_pdfDocumentStream;

        /// <summary>
        /// An event to detect the change in the value of a property.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// The PDF document stream that is loaded into the instance of the PDF viewer. 
        /// </summary>
        public Stream PdfDocumentStream
        {
            get
            {
                return m_pdfDocumentStream;
            }
            set
            {
                m_pdfDocumentStream = value;
                OnPropertyChanged("PdfDocumentStream");
            }
        }

        /// <summary>
        /// Constructor of the view model class
        /// </summary>
        public PdfViewerViewModel()
        {
            SetPdfDocumentStream(“https://www.syncfusion.com/downloads/support/directtrac/general/pd/PDF_Succinctly1928776572”);
        }

        /// <summary>
        /// Gets and sets the document stream from the given URL. 
        /// </summary>
        /// <param name="URL">Document URL</param>
        private async void SetPdfDocumentStream(string URL)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(URL);

            PdfDocumentStream = await response.Content.ReadAsStreamAsync();
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
{% endhighlight %} 
{% endtabs %}

The example project to open a PDF document from a given URL can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples). 
