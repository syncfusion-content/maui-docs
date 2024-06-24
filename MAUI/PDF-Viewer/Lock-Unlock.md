---
layout: post
title: Locking and Unlocking annotations in .NET MAUI PDF Viewer | Syncfusion
description: Learn here all about locking and unlocking annotations using Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Lock and Unlock Annotations in .NET MAUI PDF Viewer (SfPdfViewer)

You can lock an annotation to prevent it from being edited. The annotation that has been locked cannot be removed or edited further until it is unlocked. This section will go through the process of locking and unlocking annotations in a PDF document.

## Lock all annotations in a document

To lock all annotations in a document, set the [IsLocked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.BaseAnnotationSettings.html#Syncfusion_Maui_PdfViewer_BaseAnnotationSettings_IsLocked) property of the [AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html) to `true`. The following example explains how to lock all annotations in a document.

{% tabs %}
{% highlight C# %}
void LockAllAnnotations()
{
    // Lock all the annotations in a PDF document using the [AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.AnnotationSettings.html) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
    PdfViewer.AnnotationSettings.IsLocked = true;
}
{% endhighlight %}
{% endtabs %}

* Similarly, to unlock all the annotations, set the [IsLocked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.BaseAnnotationSettings.html#Syncfusion_Maui_PdfViewer_BaseAnnotationSettings_IsLocked) property value to `false`.


## Lock specific annotation

To lock a specific annotation in a document, access the annotation instance and set the [IsLocked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.Annotation.html#Syncfusion_Maui_PdfViewer_Annotation_IsLocked) property of the annotation to `true`. The following example explains how to lock the first annotation in a PDF document.

{% tabs %}
{% highlight C# %}
void LockFirstAnnotation()
{
    // Obtain the annotation collection using the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
    ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;

    // Obtain the first annotation in the annotation collection.
    Annotation firstAnnotation = annotations[0];

    // Lock the annotation.
    firstAnnotation.IsLocked = true;
}
{% endhighlight %}
{% endtabs %}

* Similarly, to unlock the annotation, set the[IsLocked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.Annotation.html#Syncfusion_Maui_PdfViewer_Annotation_IsLocked) property value to `false`.


## Lock specific annotation types

You can also use the [AnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSettings) property to lock a specific annotation type in a document. The following example explains how to lock all the circle annotations in a document by accessing the circle annotation settings. Similarly, you can lock other types of annotation.

{% tabs %}
{% highlight C# %}
void LockCircleAnnotations()
{
    // Obtain the default circle annotation settings using [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
    ShapeAnnotationSettings circleAnnotationSettings = PdfViewer.AnnotationSettings.Circle;
    
    // Lock all the circle annotations.
    circleAnnotationSettings.IsLocked = true;
}
{% endhighlight %}
{% endtabs %}

* Similarly, to unlock the specific annotation types, set the [IsLocked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.Annotation.html#Syncfusion_Maui_PdfViewer_Annotation_IsLocked) property value to `false`.


## Lock the selected annotation

To lock the selected annotation, access the selected annotation instance and set the [IsLocked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.Annotation.html#Syncfusion_Maui_PdfViewer_Annotation_IsLocked) property of the annotation to `true`. The selected annotation instance may be obtained from the [AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationSelected) event. The following example explains how to lock the selected annotation in a PDF document.

{% tabs %}
{% highlight C# %}
/// <summary>
/// Locks the selected annotation.
/// </summary>
/// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event<</param>
void LockSelectedAnnotation(Annotation selectedAnnotation)
{
    // Lock the annotation.
    selectedAnnotation.IsLocked = true;
}
{% endhighlight %}
{% endtabs %}

* Similarly, to unlock the selected annotation, set the [IsLocked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.Annotation.html#Syncfusion_Maui_PdfViewer_Annotation_IsLocked) property value to `false`.
