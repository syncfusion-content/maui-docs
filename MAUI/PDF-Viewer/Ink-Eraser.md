---
layout: post
title: Ink Eraser in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Ink Eraser in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its functionalities.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Ink Eraser in .NET MAUI PDF Viewer (SfPdfViewer)

The SfPdfViewer allows you to erase all or portions of an ink annotation. This will be useful in correcting mistakes in free hand drawings.

![Ink eraser](Images/Annotations/ink-eraser.gif)

## Enabling the ink eraser

The ink eraser can be enabled by setting the AnnotationMode property of the SfPdfViewer to `InkEraser`. In ink eraser mode, you can drag the pointer over the portions of the ink annotations you want to erase.

{% tabs %}
{% highlight C# %}

void EnableInkEraserMode() 
{ 
	// Set the annotation mode to ink eraser using the `SfPdfViewer` instance. 
	PdfViewer.AnnotationMode = AnnotationMode.InkEraser; 
}

{% endhighlight %}
{% endtabs %}

## Disabling the ink eraser

Once the ink has been erased, the ink eraser can be disabled by setting the AnnotationMode property of the SfPdfViewer to `None`.

{% tabs %}
{% highlight C# %}

void DisableInkEraserMode() 
{ 
	PdfViewer.AnnotationMode = AnnotationMode.None; 
}

{% endhighlight %}
{% endtabs %}

## Customize the ink eraser thickness

The default thickness of the ink eraser is 40. You can adjust the thickness using the InkEraser.Thickness property in the annotation settings.  

{% tabs %}
{% highlight C# %}

PdfViewer.AnnotationSettings.InkEraser.Thickness = 50;

{% endhighlight %}
{% endtabs %}

N> When the AnnotationMode is InkEraser, only the ink annotations will be erased. Other types of annotations will not be erased. 