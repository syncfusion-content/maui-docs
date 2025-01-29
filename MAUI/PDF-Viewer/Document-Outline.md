---
layout: post
title: Document outline in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about the document outline and outline navigation in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Document outline in .NET MAUI PDF Viewer

A PDF document may optionally have a document outline (also called as bookmarks) which allows the user to navigate from one part of the document to another. The PDF viewer control displays the document outline in a tree-structured hierarchy of outline elements.

## Showing/hiding the outline view

The PDF viewer’s built-in outline view that displays the document outline in a tree like structure can be shown or hidden using the [IsOutlineViewVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_IsOutlineViewVisible) property. The default value of this property is `false`. 

{% tabs %}
{% highlight XAML %}

<pdfViewer:SfPdfViewer x:Name="pdfViewer" IsOutlineViewVisible="{Binding OutlineViewVisible}" />

{% endhighlight %}
{% highlight c# %}

pdfViewer.IsOutlineViewVisible = true;

{% endhighlight %}
{% endtabs %}

## Accessing outline elements

To access the document outline and its elements, you can use the [DocumentOutline](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentOutline) property. This property provides a list of outline elements. 

{% tabs %}
{% highlight c# %}

var documentOutline = pdfViewer.DocumentOutline;

{% endhighlight %}
{% endtabs %}

## Accessing nested child elements

The outline elements nested within each outline element can be accessed from the [OutlineElement.Children](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.OutlineElement.html#Syncfusion_Maui_PdfViewer_OutlineElement_Children) property. Below code snippet illustrates accessing the 2nd element in the document outline. And then accessing its 3rd child.

{% tabs %}
{% highlight c# %}

OutlineElement outlineElement = pdfViewer.DocumentOutline[2];
OutlineElement nestedElement = outlineElement.Children[3];

{% endhighlight %}
{% endtabs %}

## Navigating to outline elements

### Navigating using UI

As mentioned above, you can show the outline view by setting the [IsOutlineViewVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_IsOutlineViewVisible) property to `true`. When the outline view is showing, you can tap on any element to navigate to the destination pointed by that element. 

![Document outline in .NET MAUI PDF Viewer](Images\outline-view.png)

### Navigating programmatically

The PDF viewer allows the users to navigate to an outline element using the [GoToOutlineElement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToOutlineElement_Syncfusion_Maui_PdfViewer_OutlineElement_) method. The below code snippet illustrates the same.

{% tabs %}
{% highlight c# %}

//Get the required outline element
OutlineElement outlineElement = pdfViewer.DocumentOutline.Where(x => x.Title.Contains("Chapter 2")).FirstOrDefault();

if (outlineElement != null)
   pdfViewer.GoToOutlineElement(outlineElement);

{% endhighlight %}
{% endtabs %}