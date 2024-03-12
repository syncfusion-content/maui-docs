---
layout: post
title: Ink Annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Ink Annotations in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its functionalities.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Ink or Freehand Drawing Annotation in .NET MAUI PDF Viewer (SfPdfViewer)

The ink annotation feature of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to add, remove and modify free hand drawings (ink) in the PDF document. This is useful for making corrections or emphasizing important points in the document. This section will go through the various functions available in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) for working with ink annotations.

## Add ink annotations

This section will go through how to add ink annotations to a PDF document interactively by drawing on the PDF document as well as programmatically.

## Add ink annotation with UI interaction

You can draw and add ink annotations to a PDF document with UI interaction using touch or mouse. The following steps explains how to draw ink annotation on a PDF.

1.	Set the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) property of the SfPdfViewer to [Ink](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_Ink). It activates the ink drawing mode on the control.
2.	Place your finger (or mouse) on the screen, where you want to start drawing the ink stroke.
3.	Draw the stroke by dragging the finger (or cursor) across the screen.
4.	Finish the stroke by releasing the finger (or cursor).
5.	Repeat the steps 2-4, if you want to create multiple strokes on other areas during the ink drawing mode.
6.	Once you have done, set the `AnnotationMode` to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_None). It will disable the drawing mode and save the drawn strokes to the PDF page as a single ink annotation.
7.	You can later move, resize, or edit the annotation.


The following code explains how to enable the ink annotation mode.

{% tabs %}
{% highlight C# %}
// Enable or activate the ink drawing mode.
void EnableInkDrawingMode()
{
    // Set the annotation mode to ink using the `SfPdfViewer` instance.
    PdfViewer.AnnotationMode = AnnotationMode.Ink;
}
{% endhighlight %}
{% endtabs %}

Similarly, refer to following code to disable the ink annotation mode.

{% tabs %}
{% highlight C# %}
// Disable or deactivate the ink drawing mode.
void DisableInkDrawingMode()
{
    // Set the annotation mode to none using the `SfPdfViewer` instance.
    PdfViewer.AnnotationMode = AnnotationMode.None;
}
{% endhighlight %}
{% endtabs %}

## Add ink annotations programmatically

You can create and add an ink annotation to a PDF document programmatically using the [AddAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AddAnnotation_Syncfusion_Maui_PdfViewer_Annotation_) method of the `SfPdfViewer`. The following example explains how to create an ink annotation and add it to the first page of a PDF document.

{% tabs %}
{% highlight C# %}
// Create an ink annotation
InkAnnotation CreateInkAnnotation()
{
    int pageNumber = 1;
    
    // Provide the points collection to draw a stroke. Here a single stroke is created.
    List<List<float>> pointsCollection = new List<List<float>>()
    {
        new List<float> { 40, 300, 60, 100, 40, 50, 40, 300 }
    };

    // Create an ink annotation.
    InkAnnotation annotation = new InkAnnotation(pointsCollection, pageNumber);

    // Set the appearance for the ink annotation.
    annotation.Color = Colors.Red; //Stroke color
    annotation.BorderWidth = 2; //Stroke thickness.
    annotation.Opacity = 0.75f; // 75% opacity

    // return the annotation.
    return annotation;
}

void AddInkAnnotation()
{
    Annotation inkAnnotation = CreateInkAnnotation();

    // Add the ink annotation to the PDF document using `AddAnnotation` method of the `SfPdfViewer` instance.
    PdfViewer.AddAnnotation(inkAnnotation);
}
{% endhighlight %}
{% endtabs %}

## Annotation settings

In the ink annotation mode, the ink annotation will be drawn with a default appearance and behavior. You can modify the annotation after it has been added to the pages. However, if you need to define the appearance and behavior before drawing on the document, you can change its default settings using the [AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSettings) property of the `SfPdfViewer`.

### Customize the default appearance

You can customize the default appearance of ink annotation using the [InkAnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotationSettings.html). The following example explains how to obtain the default ink annotation settings and modify its appearance properties. Similarly, you can modify other available properties also.

{% tabs %}
{% highlight C# %}
void CustomizeDefaultInkSettings()
{
    // Obtain the default ink annotation settings from the `SfPdfViewer` instance.
    InkAnnotationSettings inkSettings = PdfViewer.AnnotationSettings.Ink;

    // Modify the default appearance properties
    inkSettings.Color = Colors.Blue; // Stroke color
    inkSettings.BorderWidth = 2; // Stroke thickness
    inkSettings.Opacity = 0.75f; // 75% opacity
}
{% endhighlight %}
{% endtabs %}

### Consider each stroke as a separate ink annotation

When drawing ink annotations on a PDF document interactively, all the strokes that are created during a session are treated as a single ink annotation. The session here refers to the duration between enabling and disabling the ink drawing mode. However, if you wish to consider each stroke as an individual ink annotation, set the [AggregateInkStrokes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.InkAnnotationSettings.html#Syncfusion_Maui_PdfViewer_InkAnnotationSettings_AggregateInkStrokes) property of the default ink annotation settings to `false`. This allows you to access and modify individual strokes. The following example explains how to access the default ink annotation settings and set the property to `false`.

{% tabs %}
{% highlight C# %}
void DisableAggregateInkStrokes()
{
    // Obtain the default ink annotation settings from the `SfPdfViewer` instance.
    InkAnnotationSettings inkSettings = PdfViewer.AnnotationSettings.Ink;

    // Disable aggregating the insk strokes
    inkSettings.AggregateInkStrokes = false;
}
{% endhighlight %}
{% endtabs %}

### How to draw the ink annotation using a stylus and scroll or zoom PDF page with the touch

The ink annotation operation can be customized so that the ink strokes can be added only using a stylus by setting the AnnotationSettings.Ink.TouchMode API to TouchMode.Stylus. When the TouchMode is set to the stylus, the PDF can be zoomed and scrolled using a finger. The default value of the TouchMode property is TouchMode.FingerAndStylus in which the zooming will be disabled and scrolling can be performed using the scroll head or two-fingers to add ink strokes on pages, and all other touch interactions will be considered as ink operations.

N> * At present, this feature is available only in iOS and Android.

## Edit the selected ink annotation

You can edit the properties of the selected ink annotation programmatically by accessing the selected annotation instance. The selected annotation instance may be obtained from the [AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected) event. The following example shows how to edit some of the properties of the selected ink annotation. Similar you can modify the other properties.

{% tabs %}
{% highlight C# %}
/// <summary>
/// Edit the selected ink annotation.
/// </summary>
/// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event</param>
void EditSelectedInkAnnotation(Annotation selectedAnnotation)
{
    // Type cast the selected annotation as ink annotation.
    if(selectedAnnotation is InkAnnotation inkAnnotation)
    {
        inkAnnotation.Color = Colors.Blue; // Change the color to blue.
        inkAnnotation.BorderWidth = 1; // Change the stroke thickness to 1.
        inkAnnotation.Opacity = 0.75f; // Change the opacity to 75%.
    }
}
{% endhighlight %}
{% endtabs %}