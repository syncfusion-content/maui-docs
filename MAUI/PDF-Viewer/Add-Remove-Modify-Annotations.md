---
layout: post
title: Add, Remove and Edit Annotations in .NET MAUI PDF Viewer | Syncfusion
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

You can add a new annotation to the PDF document programmatically by creating an annotation instance and providing it as a parameter to the [AddAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AddAnnotation_Syncfusion_Maui_PdfViewer_Annotation_) method. The following example shows how to create an instance of a circle annotation and add it to the PDF document. Similarly, you can create and add other types of annotation. 

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

The [AnnotationAdded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationAdded) event occurs when an annotation is added successfully to the PDF document. The following example explains how to wire and handle the event.

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

You can remove all the annotations from a document programmatically by calling [RemoveAllAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_RemoveAllAnnotations) method. The following example shows how to remove all the annotations from a PDF document.

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

The [AnnotationRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationRemoved) event occurs when an annotation is removed successfully from the PDF document. The following example explains how to wire and handle the event.

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

You can edit the properties of an annotation from the document programmatically by accessing the specific annotation instance from the [Annotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_Annotations) property of the SfPdfViewer. The following example shows how to edit the first annotation in the annotation collection. Similarly, you can modify the other properties also.

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

### AnnotationEdited event

The [AnnotationEdited](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_AnnotationEdited) event occurs when an annotation is edited in the PDF document. The following example explains how to wire and handle the event.

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

### Adding custom information to a annotation

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to assign custom information to annotations. The `CustomData` property is utilized to store additional information about each annotation instance for reference. However, it's essential to note that these data are solely intended for reference purposes and will not be displayed in the `SfPdfViewer` interface.

The provided code sample illustrates how to set the `CustomData` property for an annotation. Within this code snippet, we set the custom data to represent the created date of the annotation.

{% tabs %}
{% highlight C# %}

private void OnAnnotationAdded(object sender, AnnotationEventArgs e)
{
    e.Annotation.CustomData="Created Date is: " +DateTime.Now.ToString();
}

{% endhighlight %}
{% endtabs %}
