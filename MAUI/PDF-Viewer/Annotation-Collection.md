---
layout: post
title: Annotation Collection in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about annotation collection in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its uses.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Annotation Collection

The existing annotations in a PDF document can be accessed using the `Annotations` property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). This read only property will have the annotation collection information as soon as the document is loaded into the PDF Viewer. The following example explains how to use the property to obtain the information about a square annotation that is the first on a specific document.

{% tabs %}
{% highlight c# %}
public void WireDocumentLoadedEvent()
{
    // Wire the document loaded event of the `SfPdfViewer` to occur when a PDF document is loaded.
    PdfViewer.DocumentLoaded += OnDocumentLoaded;
}

private void OnDocumentLoaded(object sender, EventArgs e)
{
    if (sender is SfPdfViewer pdfViewer)
    {
        // Obtain the annotation collection.
        ReadOnlyObservableCollection<Annotation> annotations = pdfViewer.Annotations;
        
        if (annotations.Count > 0)
        {
            // Type cast the annotation to get the annotation specific properties.
            if (annotations[0] is SquareAnnotation squareAnnotation)
            {
                RectF bounds = squareAnnotation.Bounds;
                Color color = squareAnnotation.Color;
            }
        }
    }
}
{% endhighlight %}
{% endtabs %}