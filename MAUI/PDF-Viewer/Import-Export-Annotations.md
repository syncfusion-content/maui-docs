---
layout: post
title: Import and Export annotations in .NET MAUI PDF Viewer | Syncfusion®
description: Learn here all about importing and exporting annotations using Syncfusion® .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Import and Export Annotations in .NET MAUI PDF Viewer (SfPdfViewer)

This section will go through the various functions available in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) to import and export annotations in a PDF document.

The import and export of annotations support the following file data formats:

* XFDF
* FDF
* JSON

The required file format can be chosen from the [AnnotationDataFormat](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.Parsing.AnnotationDataFormat.html) enumeration. In the following sections, only the `XFDF` file format is explained for brevity.

N> The XFDF and FDF are the standard file data formats that can be used across global PDF viewers. Whereas, JSON is the custom format that can only be used across the Syncfusion PDF Viewers supported on other platforms like WPF, Flutter, JavaScript, etc.

## Import annotations

You can add annotations to a PDF document by importing them from FDF and XFDF files by using the [ImportAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ImportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_) method. You need to provide the stream of the file containing the annotations and the data format information as parameters to the method. The following example explains how to import annotations from an XFDF file, assuming that the file is in the application’s data directory. 

{% tabs %}
{% highlight C# %}
void ImportAnnotations()
{
    // Create a file stream from the XFDF file containing the annotations information. Here a file named "AnnotationsInfo.xfdf" is read from the application's data directory.
    string fileName = Path.Combine(FileSystem.Current.AppDataDirectory, "AnnotationsInfo.xfdf");
    Stream inputFileStream = File.OpenRead(fileName);
    inputFileStream.Position = 0;
    
    // Provide the file stream and the data format information as parameters to the [ImportAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ImportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_) method of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance to import the annotations.
    PdfViewer.ImportAnnotations(inputFileStream, Syncfusion.Pdf.Parsing.AnnotationDataFormat.XFdf);
}
{% endhighlight %}
{% endtabs %}

To import the annotations asynchronously, you may use the [ImportAnnotationsAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ImportAnnotationsAsync_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Threading_CancellationToken_) method.

## Export annotations

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to export annotations from a PDF document into FDF and XFDF files. This will help you to save the annotation information in a separate file rather than the complete PDF file. You need to provide the FDF or XFDF file stream as a parameter to the [ExportAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ExportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Collections_Generic_List_Syncfusion_Maui_PdfViewer_Annotation__) method to achieve the same. The annotations information will be exported to the given file stream. The following code explains how to export annotations from a PDF document into an XFDF file in the application’s data directory.

{% tabs %}
{% highlight C# %}
private void ExportAnnotations()
{
    // Create a file stream to export the annotations. Here a file named "ExportedFile.xfdf" is created in the application's data directory.
    string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, "ExportedFile.xfdf");
    FileStream fileStream = File.Create(targetFile);

    // Export the annotations to the file stream by passing stream to the `ExportAnnotations` method of `SfPdfViewer` instance.
    PdfViewer.ExportAnnotations(fileStream, Syncfusion.Pdf.Parsing.AnnotationDataFormat.XFdf);
}
{% endhighlight %}
{% endtabs %}

To import the annotations asynchronously, you may use the [ExportAnnotationsAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ExportAnnotationsAsync_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Collections_Generic_List_Syncfusion_Maui_PdfViewer_Annotation__System_Threading_CancellationToken_) method.

### Export specific list of annotations

You can export only specific list of annotations from a PDF document, by providing the list of annotations as an additional parameter to the [ExportAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ExportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Collections_Generic_List_Syncfusion_Maui_PdfViewer_Annotation__) method. You may use the Annotations property of the SfPdfViewer to obtain a specific list of annotations from the total annotations. The following example explains how to export the first five annotations in a PDF document into an XFDF file.

{% tabs %}
{% highlight C# %}
List<Annotation> GetAnnotations(int count)
{
    // Obtain the annotation collection using [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
    ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;

    // Create a list of annotations to be exported.
    List<Annotation> annotationsToBeExported = new List<Annotation>();

    // Add the annotations in the list.
    for (int i = 0; i < count; i++)
    {
        annotationsToBeExported.Add(annotations[i]);
    }
    return annotationsToBeExported;
}

void ExportSpecificAnnotations()
{
    // Create a file stream to export the annotations. Here a file named "ExportedFile.xfdf" is created in the application's data directory.
    string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, "ExportedFile.xfdf");
    FileStream fileStream = File.Create(targetFile);

    // Get the first five annotations in the PDF document
    List<Annotation> annotationsToBeExported = GetAnnotations(5);

    // Export the annotations to the file stream using [ExportAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ExportAnnotations_System_IO_Stream_Syncfusion_Pdf_Parsing_AnnotationDataFormat_System_Collections_Generic_List_Syncfusion_Maui_PdfViewer_Annotation__) method of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html).
    PdfViewer.ExportAnnotations(fileStream, Syncfusion.Pdf.Parsing.AnnotationDataFormat.XFdf, annotationsToBeExported);
}
{% endhighlight %}
{% endtabs %}
