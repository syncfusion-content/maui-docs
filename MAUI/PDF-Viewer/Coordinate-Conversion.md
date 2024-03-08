---
layout: post
title: Working with PDF coordinate systems in MAUI PDF Viewer control | Syncfusion
description: Learn here all about coordinate conversion in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control for precise positioning and enhanced interaction. 
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Working with PDF coordinate systems in .NET MAUI PDF Viewer (SfPdfViewer)

PDF Viewer allows users to obtain the PDF page coordinates relative to the PDF Viewer’s client coordinates and vice versa. It also allows you to obtain the scroll point relative to the PDF page coordinates and bring the given region into view.

## Client rectangle

The MAUI PDF Viewer the dimensions of the client area(viewport) are known as client rectangle, which is the bounds of the control. The client rectangle in the MAUI PDF Viewer is represented by the red rectangle in the following figure.

![Coordinate conversion in .NET MAUI PDF Viewer](Images\Coordinate-Conversion\Client-Rectangle.jpg)

The client rectangle can be obtained by the `ClientRectangle` property of the PDF Viewer. The following code sample explains the same.

{% tabs %}
{% highlight c# %}
//Retrieve the coordinates of the PDF Viewer's client area (viewport)
Rectangle clientRectangle = pdfViewerControl.ClientRectangle;
{% endhighlight %}
{% endtabs %}

## Client coordinates

The MAUI PDF Viewer specifies the position of points in the client area(viewport) using client coordinates. The upper-left corner of the client area (viewport) of the control is the origin for client coordinates. The client coordinates in the MAUI PDF Viewer is shown in the following figure.

![Coordinate conversion in .NET MAUI PDF Viewer](Images\Coordinate-Conversion\Client-Coordinates.jpg)

### Get page number from client point

You can obtain the page number of the client point using the `GetPageNumberFromClientPoint(Point clientPoint)` method by passing the client point as input parameters. The following code sample explains how to get the page number from the client point.

{% tabs %}
{% highlight c# %}
//Subscribe the Tapped event of PDF Viewer
pdfViewerControl.Tapped += PdfViewerControl_Tapped; 
 
// Handle the tapped event.
private void PdfViewerControl_Tapped(object sender, GestureEventArgs e)
{
    //Retrieve the tapped client area position.
    Point clientPoint = e.Position;
    //Retrieve the page number that corresponds to the client point.
    int pageNumber = pdfViewerControl.GetPageNumberFromClientPoint(clientPoint);
}
{% endhighlight %}
{% endtabs %}

## PDF page coordinates

PDF page coordinates are represented in terms of device-independent coordinate system called user space, which is independent of the output device that will be used for printing or display. The user space coordinate system is initialized to a default state for each page of a PDF document. The length of a unit is 1/72 inch, which is approximately the same as a unit of point(pt). As an example, the dimensions of a letter-sized paper in PDF page coordinates are shown in the diagram below.

![Coordinate conversion in .NET MAUI PDF Viewer](Images\Coordinate-Conversion\Page-Coordinates.jpg)

## Convert PDF Viewer’s coordinates to PDF page coordinates

You can obtain the PDF page coordinates using the `ConvertClientPointToPagePoint(clientPoint, pageNumber)` method by passing the client rectangle point and page number as input parameters. The following code sample explains how to convert a tapped client area position to a page point.

{% tabs %}
{% highlight c# %}
//Subscribe the Tapped event of PDF Viewer
pdfViewerControl.Tapped += PdfViewerControl_Tapped; 
 
// Handle the tapped event.
private void PdfViewerControl_Tapped(object sender, GestureEventArgs e)
{
    //Retrieve the tapped client area position.
    Point clientPoint = e.Position;
    //Retrieve the page number that corresponds to the client point.
    int pageNumber = pdfViewerControl.GetPageNumberFromClientPoint(clientPoint)
    //Retrieve the page point.
    Point pagePoint = pdfViewerControl.ConvertClientPointToPagePoint(clientPoint, pageNumber);
}
{% endhighlight %}
{% endtabs %}

## Convert PDF page coordinates to PDF Viewer’s coordinates

You can obtain the PDF page coordinates using the `ConvertPagePointToClientPoint(pagePoint, pageNumber)` method by passing the page point and page number as input parameters. The following code sample explains how to convert a square annotation’s position in the page coordinates to a client point.

{% tabs %}
{% highlight c# %}
//Get a shape annotation from the Annotations collection.
SquareAnnotation squareAnnotation = pdfViewerControl.Annotations[0] as SquareAnnotation;
//Get the annotation’s page number.
int pageNumber = squareAnnotation.PageNumber;
//Get the annotation bounds.
Rectangle annotationBounds = squareAnnotation.Bounds;
//Find the position of the annotation in page coordinates.
Point pagePoint = new Point(annotationBounds.X, annotationBounds.Y);
//Convert the page point to client point.
Point clientPoint = pdfViewerControl.ConvertPagePointToClientPoint(pagePoint, pageNumber);
{% endhighlight %}
{% endtabs %}

## Convert PDF page coordinates to scroll coordinates

You can obtain the PDF Viewer’s scroll coordinates using the `ConvertPagePointToScrollPoint(pagePoint, pageNumber)` method by passing the page point and page number as input parameters. The following code example explains how to convert a square annotation’s position in the page coordinates to a scroll point.

{% tabs %}
{% highlight c# %}
//Get a shape annotation from the Annotations collection.
SquareAnnotation squareAnnotation = pdfViewerControl.Annotations[0] as SquareAnnotation;
//Get the annotation bounds.
Rectangle annotationBounds = squareAnnotation.Bounds;
//Get the annotation’s page number.
int pageNumber = squareAnnotation.PageNumber;
//Find the position of the annotation in page coordinates.
Point pagePoint = new Point(annotationBounds.X, annotationBounds.Y);
//Convert the page point to scroll point.
Point scrollPoint = pdfViewerControl.ConvertPagePointToScrollPoint(pagePoint, pageNumber);
{% endhighlight %}
{% endtabs %}