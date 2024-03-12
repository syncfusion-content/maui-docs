---
layout: post
title: Ink Eraser in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Ink Eraser in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its functionalities.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Ink or Freehand Drawing Eraser in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to erase all or portions of an ink annotation, which will help correct mistakes in freehand drawings.

![Ink eraser](Images/Annotations/ink-eraser.gif)

## Enabling the ink eraser

Enable the ink eraser by setting the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) to `InkEraser`. In the ink eraser mode, drag the pointer over the portions of the ink annotations you want to erase.

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

Once you have erased the ink, disable the ink eraser by setting the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) to `None`.

{% tabs %}
{% highlight C# %}

void DisableInkEraserMode() 
{ 
	PdfViewer.AnnotationMode = AnnotationMode.None; 
}

{% endhighlight %}
{% endtabs %}

## How to erase the ink annotation using a stylus and scroll or zoom PDF page with the touch

The ink eraser operation can be customized so that the ink strokes can be erased only using a stylus by setting the AnnotationSettings.Ink.TouchMode API to TouchMode.Stylus. When the TouchMode is set to the stylus, the PDF can be zoomed and scrolled using a finger. The default value of the TouchMode property is TouchMode.FingerAndStylus in which the zooming will be disabled and scrolling can be performed using the scroll head or two-fingers to add ink strokes on pages, and all other touch interactions will be considered as ink eraser operations.

N> * At present, this feature is available only in iOS and Android.

## Customize the ink eraser thickness

The default thickness of the ink eraser is 40. You can adjust the thickness using the `InkEraser.Thickness` property in the annotation settings.  

{% tabs %}
{% highlight C# %}

PdfViewer.AnnotationSettings.InkEraser.Thickness = 50;

{% endhighlight %}
{% endtabs %}

N> When the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) is `InkEraser`, only the ink annotations will be erased. Other types of annotations will not be erased. 