---
layout: post
title: Stamp Annotations in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about Stamp Annotations in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and its types.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Stamp Annotations

The stamp annotations feature of `SfPdfViewer` allows you to add, remove and modify stamps or custom images in the PDF document. This section will go through the various types and functions available in PDF Viewer for working with stamp annotations.

## Types of Stamps

The following stamp annotation types are now available in the PDF Viewer.

1.	Standard (or built-in) stamps.

2.	Custom (or image) stamps

## Adding Stamps

This section will go through how to add stamp annotations to a PDF document programmatically to a PDF document.

### Adding Standard Stamps

There are 18 standard stamp types are available in the `SfPdfViewer` that are most commonly used in documents. The appropriate standard stamp type can be selected from the `StampType` enumeration. 

The following example explains how to create a `Approved` standard stamp and add it to the first page of a PDF document using the `AddAnnotation` method of the `SfPdfViewer`.

{% tabs %}
{% highlight C# %}

        StampAnnotation CreateApprovedStandardStamp()
        {
            int pageNumber = 1;

            // Define the position to place the stamp.
            PointF position = new PointF(100, 100);

            // Create an approved standard stamp.
            StampAnnotation approvedStamp = new StampAnnotation(StampType.Approved, pageNumber, position);
            
            //return the stamp
            return approvedStamp;
        }

        void AddStampAnnotation()
        {
            StampAnnotation stampAnnotation = CreateApprovedStandardStamp();

            //Add the stamp to the PDF document using `SfPdfViewer` instance.
            PdfViewer.AddAnnotation(stampAnnotation);
        }

{% endhighlight %}
{% endtabs %}

The following image represents the approved standard stamp appearance in the PDF document.

![Standard Approved Stamp.](Images/Annotations/approved-stamp.png)

### Adding custom stamps

You can create a custom stamp from any images and add it to a PDF document. The following example explains how to create a custom stamp from an image in the application and add it to a PDF document using the `AddAnnotation` method of the `SfPdfViewer`.

{% tabs %}
{% highlight C# %}

        StampAnnotation CreateCustomStamp()
        {
            int pageNumber = 1;

            //Define the position and size for the stamp to be placed in the PDF page.
            RectF bounds = new RectF(50, 50, 200, 100);

            //Create image stream from the image to be used as stamp.
            Stream imageStream = this.GetType().Assembly.GetManifestResourceStream("Annotations.Assets." + "Logo.png");

            //Create a custom stamp annotation using the image steeam.
            StampAnnotation customStamp = new StampAnnotation(imageStream,pageNumber,bounds);

            //Return the stamp annotation.
            return customStamp;
        }

        void AddCustomStampAnnotation()
        {
            StampAnnotation stampAnnotation = CreateCustomStamp();

            //Add the stamp to the PDF document using `SfPdfViewer` instance.
            PdfViewer.AddAnnotation(stampAnnotation);
        }

{% endhighlight %}
{% endtabs %}

## Edit the Selected Annotation

You can edit the properties of the selected stamp annotation programmatically by accessing the selected annotation instance. The selected annotation instance may be obtained from the `AnnotationSelected` event. 

The following example shows how to edit some of the properties of the selected stamp annotation. Similarly, you can modify the other properties if required.

{% tabs %}
{% highlight C# %}

        /// <summary>
        /// Edit the selected stamp annotation.
        /// </summary>
        /// <param name="selectedAnnotation">The selected annotation instance that may be obtained from the annotation selected event</param>
        void EditSelectedStampAnnotation(Annotation selectedAnnotation)
        {
            //Type cast the selected annotation as stamp annotation.
            if (selectedAnnotation is StampAnnotation stampAnnotation)
            {
                //Change the opacity to 75%.
                stampAnnotation.Opacity = 0.75f;
            }
        }

{% endhighlight %}
{% endtabs %}
