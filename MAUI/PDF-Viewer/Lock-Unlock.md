---
layout: post
title: Locking and Unlocking annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about locking and unlocking annotations using Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Lock and Unlock Annotations

You can lock an annotation to prevent it from being edited. The annotation that has been locked cannot be removed or edited further until it is unlocked. This section will go through the process of locking and unlocking annotations in a PDF document.

## Lock All Annotations in a Document

To lock all annotations in a document, set the `IsLocked` property of the `AnnotationSettings` to `true`. The following example explains how to lock all annotations in a document.

{% tabs %}
{% highlight C# %}
void LockAllAnnotations()
{
    // Lock all the annotations in a PDF document using the `AnnnotationSettings` property of the `SfPdfViewer` instance.
    PdfViewer.AnnotationSettings.IsLocked = true;
}
{% endhighlight %}
{% endtabs %}

* Similarly, to unlock all the annotations, set the `IsLocked` property value to `false`.

## Lock Specific Annotation Types

You can also use the `AnnotationSettings` property to lock a specific annotation type in a document. The following example explains how to lock all the circle annotations in a document by accessing the circle annotation settings. Similarly, you can lock other types of annotation.

{% tabs %}
{% highlight C# %}
void LockCircleAnnotations()
{
    // Obtain the default circle annotation settings using `SfPdfViewer` instance.
    ShapeAnnotationSettings circleAnnotationSettings = PdfViewer.AnnotationSettings.Circle;
    
    // Lock all the circle annotations.
    circleAnnotationSettings.IsLocked = true;
}
{% endhighlight %}
{% endtabs %}

* Similarly, to unlock the specific annotation types, set the `IsLocked` property value to `false`.

## Lock Specific Annotation

To lock a specific annotation in a document, access the annotation instance and set the `IsLocked` property of the annotation to `true`. The following example explains how to lock the first annotation in a PDF document.

{% tabs %}
{% highlight C# %}
void LockFirstAnnotation()
{
    // Obtain the annotation collection using the `SfPdfViewer` instance.
    ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;

    // Obtain the first annotation in the annotation collection.
    Annotation firstAnnotation = annotations[0];

    // Lock the annotation.
    firstAnnotation.IsLocked = true;
}
{% endhighlight %}
{% endtabs %}

* Similarly, to unlock the annotation, set the `IsLocked` property value to `false`.

## Lock the Selected Annotation

To lock the selected annotation, access the selected annotation instance and set the `IsLocked` property of the annotation to `true`. The selected annotation instance may be obtained from the `AnnotationSelected` event. The following example explains how to lock the selected annotation in a PDF document.

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

* Similarly, to unlock the selected annotation, set the `IsLocked` property value to `false`.