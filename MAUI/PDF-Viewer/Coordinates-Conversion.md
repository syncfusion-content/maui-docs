---
layout: post
title: Working with PDF coordinates systems in MAUI PDF Viewer | Syncfusion
description: Learn here all about coordinates conversion in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control. 
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Working with PDF coordinates systems in .NET MAUI PDF Viewer

PDF Viewer allows users to obtain the PDF page coordinates relative to the PDF Viewer’s client coordinates and vice versa. It also allows you to obtain the scroll point relative to the PDF page coordinates and bring the given region into view.

## Client rectangle

The [ClientRectangle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ClientRectangle) in MAUI PdfViewer control is  a rectangular area that represents the dimensions of the client area or viewport. The client area denotes the visible portion of the PDF document within the control. In the MAUI PDF Viewer, this client rectangle is illustrated by the red rectangle in the following figure.

![Client rectangle in .NET MAUI PDF Viewer](Images\Coordinates-Conversion\Client-Rectangle.png)

The client rectangle can be obtained by the [ClientRectangle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ClientRectangle) property of the PDF Viewer. The following code sample explains the same.

{% tabs %}
{% highlight c# %}
//Retrieve the coordinates of the PDF Viewer's client area (viewport)
Rect clientRectangle = PdfViewer.ClientRectangle;
{% endhighlight %}
{% endtabs %}

## Client coordinates

The MAUI PDF Viewer specifies the position of points in the client area(viewport) using client coordinates. The upper-left corner of the client area (viewport) of the control is the origin for client coordinates. The client coordinates in the MAUI PDF Viewer is shown in the following figure.

![Client coordinates in .NET MAUI PDF Viewer](Images\Coordinates-Conversion\Client-Coordinates.png)

### Get page number from client point

You can obtain the page number of the client point using the [GetPageNumberFromClientPoint(Point clientPoint)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GetPageNumberFromClientPoint_Microsoft_Maui_Graphics_Point_) method by passing the client point as input parameter. The following code sample explains how to get the page number from the client point.

{% tabs %}
{% highlight c# %}
//Subscribe the Tapped event of PDF Viewer
PdfViewer.Tapped += PdfViewer_Tapped;  
 
// Handle the tapped event.
private void PdfViewer_Tapped(object sender, GestureEventArgs e)
{
    //Retrieve the tapped client area position.
    Point clientPoint = e.Position;
    //Retrieve the page number that corresponds to the client point.
    int pageNumber = PdfViewer.GetPageNumberFromClientPoint(clientPoint);
}
{% endhighlight %}
{% endtabs %}

## PDF page coordinates

PDF page coordinates are represented in terms of device-independent coordinates system called user space, which is independent of the output device that will be used for printing or display. The user space coordinates system is initialized to a default state for each page of a PDF document. The length of a unit is 1/72 inch, which is approximately the same as a unit of point(pt). As an example, the dimensions of a letter-sized paper in PDF page coordinates are shown in the diagram below.

![Page coordinates in .NET MAUI PDF Viewer](Images\Coordinates-Conversion\Page-Coordinates.png)

## Scroll coordinates

Scroll coordinates in the MAUI PdfViewer denote pixel-based positions as pages are scrolled, indicating precise locations within the entire document. The coordinate system originates from the top-left corner of the visible area.

## Convert PDF Viewer’s coordinates to PDF page coordinates

You can obtain the PDF page coordinates using the [ConvertClientPointToPagePoint(clientPoint, pageNumber)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ConvertClientPointToPagePoint_Microsoft_Maui_Graphics_Point_System_Int32_) method by passing the client point and page number as input parameters. The following code sample explains how to convert a tapped client area position to a page point.

{% tabs %}
{% highlight c# %}
//Subscribe the Tapped event of PDF Viewer
PdfViewer.Tapped += PdfViewer_Tapped;
 
// Handle the tapped event.
private void PdfViewer_Tapped(object sender, GestureEventArgs e)
{
    //Retrieve the tapped client area position.
    Point clientPoint = e.Position;
    //Retrieve the page number that corresponds to the client point.
    int pageNumber = PdfViewer.GetPageNumberFromClientPoint(clientPoint);
    //Retrieve the page point.
    Point pagePoint = PdfViewer.ConvertClientPointToPagePoint(clientPoint, pageNumber);
}
{% endhighlight %}
{% endtabs %}

## Convert PDF page coordinates to PDF Viewer’s coordinates

You can obtain the PDF Viewer’s coordinates using the [ConvertPagePointToClientPoint(pagePoint, pageNumber)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ConvertPagePointToClientPoint_Microsoft_Maui_Graphics_Point_System_Int32_) method by passing the page point and page number as input parameters. The following code sample explains how to convert a square annotation’s position in the page coordinates to a client point.

{% tabs %}
{% highlight c# %}
// Obtain the annotation collection using [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;

// Obtain the first annotation in the annotation collection.
Annotation annotation = annotations[0];

// Type cast to the specific annotation type. Here the first annotation is a square annotation.
if (annotation is SquareAnnotation squareAnnotation)
{
    //Get the annotation’s page number.
    int pageNumber = squareAnnotation.PageNumber;
    //Get the annotation bounds.
    RectF annotationBounds = squareAnnotation.Bounds;
    //Find the position of the annotation in page coordinates.
    Point pagePoint = new Point(annotationBounds.X, annotationBounds.Y);
    //Convert the page point to client point.
    Point clientPoint = PdfViewer.ConvertPagePointToClientPoint(pagePoint, pageNumber);
}
{% endhighlight %}
{% endtabs %}

## Convert PDF page coordinates to scroll coordinates

You can obtain the PDF Viewer’s scroll coordinates using the [ConvertPagePointToScrollPoint(pagePoint, pageNumber)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ConvertPagePointToScrollPoint_Microsoft_Maui_Graphics_Point_System_Int32_) method by passing the page point and page number as input parameters. The following code example explains how to convert a square annotation’s position in the page coordinates to a scroll point.

{% tabs %}
{% highlight c# %}
// Obtain the annotation collection using [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) instance.
ReadOnlyObservableCollection<Annotation> annotations = PdfViewer.Annotations;

// Obtain the first annotation in the annotation collection.
Annotation annotation = annotations[0];

// Type cast to the specific annotation type. Here the first annotation is a square annotation.
if (annotation is SquareAnnotation squareAnnotation)
{
    //Get the annotation bounds.
    RectF annotationBounds = squareAnnotation.Bounds;
    //Get the annotation’s page number.
    int pageNumber = squareAnnotation.PageNumber;
    //Find the position of the annotation in page coordinates.
    Point pagePoint = new Point(annotationBounds.X, annotationBounds.Y);
    //Convert the page point to scroll point.
    Point scrollPoint = PdfViewer.ConvertPagePointToScrollPoint(pagePoint, pageNumber);
}
{% endhighlight %}
{% endtabs %}
