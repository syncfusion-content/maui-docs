---
layout: post
title: Open a PDF From Base64 string in MAUI PDF Viewer control | Syncfusion
description: Learn here about opening a PDF document from the Base64 string in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Open a Document from base64 string in .NET MAUI PDF Viewer (SfPdfViewer)

A PDF document can be opened in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) from a given Base64 string by converting it to a byte[] and assigning it to the [DocumentSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource) property.

Just by making a few changes to the `PdfViewerViewModel.cs` shared in the getting started example, you can easily open a document from a given Base64 string by converting the Base64 string to byte array using the [FromBase64String](https://learn.microsoft.com/en-us/dotnet/api/system.convert.frombase64string?view=net-9.0) method of the [Convert](https://github.com/dotnet/runtime/blob/1d1bf92fcf43aa6981804dc53c5174445069c9e4/src/libraries/System.Private.CoreLib/src/System/Convert.cs) class in the `System` namespace and assigning the obtained byte array to the [DocumentSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource) property in the .NET MAUI PDF Viewer. Refer to the following code example for reference:

{% tabs %}
{% highlight c# tabtitle="PdfViewerViewModel.cs" %}

using System.Reflection;
using System.ComponentModel;

namespace PdfViewerExample
{
    class PdfViewerViewModel : INotifyPropertyChanged
    {
        private byte[]? m_pdfDocumentByteArray;

        /// <summary>
        /// An event to detect the change in the value of a property.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// The PDF document byte array that is loaded into the instance of the PDF viewer. 
        /// </summary>
        public byte[]? PdfDocumentByteArray
        {
            get
            {
                return m_pdfDocumentByteArray;
            }
            set
            {
                m_pdfDocumentByteArray = value;
                OnPropertyChanged("PdfDocumentByteArray");
            }
        }

        /// <summary>
        /// Constructor of the view model class
        /// </summary>
        public PdfViewerViewModel()
        {
            SetPdfDocumentByteArray();
        }

        /// <summary>
        /// Gets and sets the document byte array from the given base64 string converted PDF file. 
        /// </summary>
        private void SetPdfDocumentByteArray()
        {
            // Assign the returned byte array to the PdfDocumentByteArray property
            PdfDocumentByteArray = GetByteArrayFromBase64String();
        }

        // Method to return a MemoryStream containing a base64 string converted PDF file
        public byte[]? GetByteArrayFromBase64String()
        {
            // Decode the Base64 string into a byte array and the Convert class is used for Type conversion in C# (Here we are using to convert a base64 string value to a byte array).
            byte[] decodedBytes = System.Convert.FromBase64String(“YourBase64String”);

            // return the byte array.
            return decodedBytes;
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
{% endhighlight %} 
{% endtabs %}

The example project to open a PDF document from a Base64 string can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples/tree/master/Open%20PDF%20From%20Base-64%20String). 
