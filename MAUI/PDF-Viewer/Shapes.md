---
layout: post
title: Shape Annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Shape Annotations in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its types.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Shape Annotations in .NET MAUI PDF Viewer (SfPdfViewer)

The shape annotations feature of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to add, remove and modify shapes in the PDF document. This is useful for making corrections or emphasizing important points in the document. This section will go through the various types and functions available in PDF Viewer for working with shape annotations.

## Types of shapes

The following shape annotation types are now available in the PDF Viewer.

1.	Arrow
2.	Circle.
3.	Line.
4.	Square.

## Add shapes to a PDF document

This section will go through how to add shape annotations to a PDF document interactively by drawing on the PDF document as well as programmatically.

### Add shapes with UI interaction

You can draw and add shape annotations to a PDF document interactively by touch (or mouse down) and drag. The following steps explains how to draw shape annotation on a PDF.

1.	Set the [AnnotationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationMode) property of the SfPdfViewer to any shape (say [Circle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_Circle)). It activates the circle drawing mode on the control.
2.	Place your finger (or mouse) on the screen, where you want to start drawing the circle.
3.	Draw the circle by dragging the finger (or cursor) across the screen.
4.	Finish the circle by releasing the finger (or cursor).
5.	Repeat the steps 2-4, if you want to create multiple circles on other areas during the drawing mode.
6.	Once you have done, set the `AnnotationMode` to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationMode.html#Syncfusion_Maui_PdfViewer_AnnotationMode_None). It will disable the circle drawing mode and save the drawn circles to the PDF pages as circle annotations. 
7.	You can later move, resize, or edit the annotation.


The following code explains how to enable the circle annotation mode. Similarly, you can change the annotation mode for drawing other shapes.

{% tabs %}
{% highlight C# %}
// Enable or activate the circle drawing mode.
void EnableCircleDrawingMode()
{
    // Set the `AnnotationMode` property of `SfPdfViewer` instance to `Circle`.
    PdfViewer.AnnotationMode = AnnotationMode.Circle;
}
{% endhighlight %}
{% endtabs %}

Similarly, refer to following code to disable the circle annotation mode.

{% tabs %}
{% highlight C# %}
// Disable or deactivate the circle drawing mode.
void DisableCircleDrawingMode()
{
    // Set the `AnnotationMode` property of `SfPdfViewer` instance to `None`.
    PdfViewer.AnnotationMode = AnnotationMode.None;
}
{% endhighlight %}
{% endtabs %}

### Add shapes programmatically

You can create and add circle annotation to a PDF document programmatically using the [AddAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AddAnnotation_Syncfusion_Maui_PdfViewer_Annotation_) method of the `SfPdfViewer`. The following example explains how to create a circle annotation and add it to the first page of a PDF document. Similarly, you can add other shapes also.

{% tabs %}
{% highlight C# %}
CircleAnnotation CreateCircleAnnoation()
{
    int pageNumber = 1;
    // Define the bounds for circle in the PDF coordinates.
    RectF circleBounds = new RectF(10, 10, 100, 100); 

    // Create a circle annotation.
    CircleAnnotation annotation = new CircleAnnotation(circleBounds, pageNumber);
    
    // Set the appearance for the circle annotation.
    annotation.Color = Colors.Red; // set the stroke color
    annotation.FillColor = Colors.Green; // set the inner fill color.
    annotation.BorderWidth = 2; // set the stroke thickness.
    annotation.Opacity = 0.75f; // set the opacity 75%

    return annotation;
}

void AddCircleAnnotation()
{
    Annotation circleAnnotation = CreateCircleAnnoation();

    //Add the circle annotation to the PDF document using the AddAnnotation method of `SfPdfViewer` instance.
    PdfViewer.AddAnnotation(circleAnnotation);
}
{% endhighlight %}
{% endtabs %}

## Shape annotation settings

In the shape annotation mode, the shape annotations will be drawn with a default appearance. You can modify the annotation after it has been added to the pages. However, if you need to define the appearance before drawing on the document, you can change its default settings using the [AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSettings) property of the `SfPdfViewer`. For that you need to obtain the default shape annotation settings.

The following example explains how to obtain the default circle annotation settings and modify some of its properties. Similarly, you can modify properties of other shape annotations also.

{% tabs %}
{% highlight C# %}
void CustomizeDefaultCircleSettings()
{
    //Obtain the default circle annotation settings from the `SfPdfViewer` instance.
    ShapeAnnotationSettings circleAnnotationSettings = PdfViewer.AnnotationSettings.Circle;

    //Modify the default properties.

    circleAnnotationSettings.Color = Colors.Blue; // Set the default stroke color to blue.
    circleAnnotationSettings.FillColor = Colors.Red; // Set the inner fill color to red.
    circleAnnotationSettings.BorderWidth = 2; // Set the default stroke thickness to 2.
    circleAnnotationSettings.Opacity = 0.75f; // Set the default opacity to 75%.
}
{% endhighlight %}
{% endtabs %}

## Edit the selected shape annotation

You can edit the properties of the selected shape annotation programmatically by accessing the selected annotation instance. The selected annotation instance may be obtained from the [AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected) event. The following example shows how to edit some of the properties of the selected circle annotation. Similarly, you can modify the other shape annotations properties.

{% tabs %}
{% highlight C# %}
/// <summary>
/// Edit the selected circle annotation.
/// </summary>
/// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event</param>
void EditSelectedCicleAnnotation(Annotation selectedAnnotation)
{
    // Type cast the selected annotation as circle annotation.
    if (selectedAnnotation is CircleAnnotation circleAnnotation)
    {
        circleAnnotation.Color = Colors.Blue; // Change the color to blue.
        circleAnnotation.BorderWidth = 1; // Change the stroke thickness to 1.
        circleAnnotation.Opacity = 0.75f; // Change the opacity to 75%.
    }
}
{% endhighlight %}
{% endtabs %}