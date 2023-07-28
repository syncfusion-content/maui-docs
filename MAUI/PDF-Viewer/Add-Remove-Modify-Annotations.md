---
layout: post
title: Add, Remove and Edit Annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about adding, removing and editing annotations in a PDF document using Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Add, Remove and Edit Annotations in .NET MAUI PDF Viewer (SfPdfViewer)

This section will go through the various functions available in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) for adding, removing and  editing annotations in a PDF document. 

## Add annotations to a PDF document

This section will go through how to add annotations to a PDF document programmatically.

### Add annotations programmatically 

You can add a new annotation to the PDF document programmatically by creating an annotation instance and providing it as a parameter to the `AddAnnotation` method. The following example shows how to create an instance of a circle annotation and add it to the PDF document. Similarly, you can create and add other types of annotation. 

{% tabs %}
{% highlight c# %}
void AddCircleAnnotation()
{
    int pageNumber = 1;
    // Define the bounds for circle in the PDF coordinates.
    RectF circleBounds = new RectF(10, 10, 100, 100);
    
    // Create a circle annotation.
    CircleAnnotation annotation = new CircleAnnotation(circleBounds, pageNumber); 

    // Set the appearance for the circle annotation.
    annotation.Color = Colors.Red; //Stroke color
    annotation.FillColor = Colors.Green; //Fill color
    annotation.BorderWidth = 2; //Stroke thickness
    annotation.Opacity = 0.75f; // 75% Opacity

    // Add the annotation to the PDF document using `AddAnnotation` method of `SfPdfViewer`.
    PdfViewer.AddAnnotation(annotation);
}
{% endhighlight %}
{% endtabs %}

### AnnotationAdded event

The `AnnotationAdded` event occurs when an annotation is added successfully to the PDF document. The following example explains how to wire and handle the event.

{% tabs %}
{% highlight c# %}
void WireAnnotationAddedEvent()
{
    // Wire the annotation added event of `SfPdfViewer` control.
    PdfViewer.AnnotationAdded += OnAnnotationAdded;
}

private void OnAnnotationAdded(object sender, AnnotationEventArgs e)
{
    Annotation addedAnnotation = e.Annotation;
    Debug.WriteLine("{0} is added to the document successfully", addedAnnotation.Name);
}
{% endhighlight %}
{% endtabs %}

## Remove annotations from the PDF document

This section will go through different methods of removing annotations from a PDF document.

### Remove the selected annotation

You can remove the selected annotation programmatically by providing the selected annotation instance as the parameter to `RemoveAnnotation` method. The selected annotation instance may be obtained from the `AnnotationSelected` event. The following example shows how to remove the selected annotation.

{% tabs %}
{% highlight c# %}
/// <summary>
/// Remove the selected annotation.
/// </summary>
/// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event</param>
void RemoveSelectedAnnotation(Annotation selectedAnnotation)
{
    // Remove the annotation using the RemoveAnnotation method of SfPdfViewer instance.
    PdfViewer.RemoveAnnotation(selectedAnnotation);
}
{% endhighlight %}
{% endtabs %}

In desktop platforms like macOS and Windows, you can also use the keyboard shortcut `Delete` to remove the selected annotation from the PDF document directly.

### Remove a specific annotation

You can remove an annotation from the document programmatically by providing the specific annotation instance as the parameter to `RemoveAnnotation` method of `SfPdfViewer`. The following example shows how to remove the first annotation in the annotation collection from a PDF document.

{% tabs %}
{% highlight c# %}
void RemoveFirstAnnotation()
{
    //Obtain the annotation collection using `SfPdfViewer` instance.
    ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;

    //Obtain the first annotation in the annotation collection.
    Annotation firstAnnotation = annotations[0];

    //Remove the annotation using RemoveAnnotation method of `SfPdfViewer`.
    PdfViewer.RemoveAnnotation(firstAnnotation);
}
{% endhighlight %}
{% endtabs %}

### Remove all the annotations

You can remove all the annotations from a document programmatically by calling `RemoveAllAnnotations` method. The following example shows how to remove all the annotations from a PDF document.

{% tabs %}
{% highlight c# %}
void RemoveAllAnnotations()
{
    // Removes all the annotations from a PDF document using `RemoveAllAnnotations` method of `SfPdfViewer`.
    PdfViewer.RemoveAllAnnotations();
}		
{% endhighlight %}
{% endtabs %}

### AnnotationRemoved event

The `AnnotationRemoved` event occurs when an annotation is removed successfully from the PDF document. The following example explains how to wire and handle the event.

{% tabs %}
{% highlight c# %}
void WireAnnotationRemovedEvent()
{
    // Wire the annotation removed event of `SfPdfViewer`.
    PdfViewer.AnnotationRemoved += OnAnnotationRemoved;
}

private void OnAnnotationRemoved(object sender, AnnotationEventArgs e)
{
    Annotation removedAnnotation = e.Annotation;
    Debug.WriteLine("{0} is removed from the document successfully", removedAnnotation.Name);
}
{% endhighlight %}
{% endtabs %}

## Edit annotations

This section will go through different methods of editing annotations in a PDF document programmatically.

### Edit a specific annotation

You can edit the properties of an annotation from the document programmatically by accessing the specific annotation instance from the `Annotations` property of the SfPdfViewer. The following example shows how to edit the first annotation in the annotation collection. Similarly, you can modify the other properties also.

{% tabs %}
{% highlight c# %}
void EditFirstAnnotation()
{
    // Obtain the annotation collection using `SfPdfViewer` instance.
    ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;

    // Obtain the first annotation in the annotation collection.
    Annotation annotation = annotations[0];

    // Edit the annotation properties.
    annotation.Color = Colors.Green; //Stroke color.
    annotation.Opacity = 0.75f; // 75% Opacity

    // Type cast to edit the properties of the specific annotation type. Here the first annotation is a circle annotation.
    if (annotation is CircleAnnotation circleAnnotation)
    {
        circleAnnotation.FillColor = Colors.Red; //Inner fill color.
        circleAnnotation.BorderWidth = 2; //Stroke thickness.
        circleAnnotation.Bounds = new RectF(10, 10, 100, 100); // Bounds in PDF coordinates.
    }
}
{% endhighlight %}
{% endtabs %}

### Edit the selected annotation

You can edit the properties of the selected annotation programmatically by accessing the selected annotation instance. The selected annotation instance may be obtained from the `AnnotationSelected` event. The following example shows how to edit the selected annotation assuming that the annotation is a circle type.

{% tabs %}
{% highlight c# %}
/// <summary>
/// Edits the selected annotation.
/// </summary>
/// <param name="selectedAnnotation">The selected annotation instance may be obtained from the annotation selected event</param>
void EditSelectedAnnotation(Annotation selectedAnnotation)
{
    // Edit the annotation properties.
    selectedAnnotation.Color = Colors.Green; //Stroke color.
    selectedAnnotation.Opacity = 0.75f; // 75% Opacity

    // Type cast to edit the properties of the specific annotation type. Here the first annotation is a circle annotation.
    if (selectedAnnotation is CircleAnnotation circleAnnotation)
    {
        circleAnnotation.FillColor = Colors.Red; //Inner fill color.
        circleAnnotation.BorderWidth = 2; //Stroke thickness.
        circleAnnotation.Bounds = new RectF(0, 0, 100, 100); // Bounds in PDF coordinates.
    }
}
{% endhighlight %}
{% endtabs %}

### AnnotationEdited event

The `AnnotationEdited` event occurs when an annotation is edited in the PDF document. The following example explains how to wire and handle the event.

{% tabs %}
{% highlight c# %}
void WireAnnotationEditedEvent()
{
    // Wire the annotation edited event of `SfPdfViewer`.
    PdfViewer.AnnotationEdited += OnAnnotationEdited;
}

private void OnAnnotationEdited(object sender, AnnotationEventArgs e)
{
    Annotation editedAnnotation = e.Annotation;
    Debug.WriteLine("The {0} is edited successfully", editedAnnotation.Name);
}
{% endhighlight %}
{% endtabs %}