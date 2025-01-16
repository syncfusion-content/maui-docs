---
layout: post
title: Ink Eraser in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Ink Eraser in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control and its functionalities.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Ink or Freehand Drawing Eraser in .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to erase all or portions of an ink annotation, which will help correct mistakes in freehand drawings.

![Ink eraser](Images/Annotations/ink-eraser.gif)

## Enabling the ink eraser

Enable the ink eraser by setting the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) to [InkEraser](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_InkEraser). In the ink eraser mode, drag the pointer over the portions of the ink annotations you want to erase.

{% tabs %}
{% highlight C# %}

void EnableInkEraserMode() 
{ 
	// Set the annotation mode to ink eraser using the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance. 
	PdfViewer.AnnotationMode = AnnotationMode.InkEraser; 
}

{% endhighlight %}
{% endtabs %}

## Disabling the ink eraser

Once you have erased the ink, disable the ink eraser by setting the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_None).

{% tabs %}
{% highlight C# %}

void DisableInkEraserMode() 
{ 
	PdfViewer.AnnotationMode = AnnotationMode.None; 
}

{% endhighlight %}
{% endtabs %}

## How to erase ink annotation and customize the ink eraser thickness using toolbar

On the built-in toolbar, an ink eraser tool is available. Using that, you can easily erase all or portions of the ink annotation. Additionally, the toolbar shows the option to customize the ink eraser thickness.

The following image demonstrates how to use the ink eraser tool from the toolbar on the desktop to remove ink annotations.

![Ink annotation desktop](Images/Annotations/InkEraserDesktop.gif)

## How to erase ink annotation only using stylus

The ink eraser operation can be customized so that the ink strokes can be added only using a stylus by setting the [AnnotationSettings.Ink.TouchScreenInputMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.TouchScreenInputMode.html) property to TouchScreenInputMode.Stylus. When TouchScreenInputMode is set to TouchScreenInputMode.Stylus, users can easily erase ink strokes using a stylus. However, zooming and scrolling functionality will still be available using their fingers.

By default, the TouchScreenInputMode property is set to TouchScreenInputMode.FingerAndStylus, where both finger and stylus inputs are recognized as ink erasing operations.

{% tabs %}
{% highlight C# %}

PdfViewer.AnnotationSettings.Ink.TouchScreenInputMode = TouchScreenInputMode.Stylus;

{% endhighlight %}
{% endtabs %}

N> * At present, this feature is available only in iOS and Android.

## Customize the ink eraser thickness

The default thickness of the ink eraser is 40. You can adjust the thickness using the [InkEraser.Thickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkEraserSettings.html#Syncfusion_Maui_PdfViewer_InkEraserSettings_Thickness) property in the annotation settings.  

{% tabs %}
{% highlight C# %}

PdfViewer.AnnotationSettings.InkEraser.Thickness = 50;

{% endhighlight %}
{% endtabs %}

N> When the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) is [InkEraser](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_InkEraser)., only the ink annotations will be erased. Other types of annotations will not be erased. 


