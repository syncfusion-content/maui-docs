---
layout: post
title: Page Navigation in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about page navigation feature in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Page Navigation in .NET MAUI PDF Viewer (SfPdfViewer)

After loading a document, you can navigate or scroll to different pages using the page navigation options, either programmatically or by dragging the scroll head in the UI. This section walks through the page navigation functionalities supported in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html).

## Page layout modes

The page layout modes of [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allow users to change the layout of the pages while viewing PDF documents. These modes provide flexibility in viewing and navigating PDF pages, responding to various reading styles and document structures. The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) supports the following Page layout modes:

1. Continuous
2. Single page

### Continuous layout mode

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html)’s default page layout mode is `Continuous`. In this mode, the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) displays pages in a continuous vertical scroll, is useful for documents containing a continuous flow of content. It enables users to scroll through the document with ease, providing a more fluid reading experience. 
To enable the continuous page layout mode, you can call the following code in a button click.

{% tabs %}
{% highlight c# %}

// Enable or activate the Continuous Page Layout mode.
void EnableContinuousPageLayoutMode()
{
    // Set the PageLayout mode to Continuous using the `SfPdfViewer` instance.
    PdfViewer.PageLayoutMode = PageLayoutMode.Continuous;
}

{% endhighlight %}
{% endtabs %}

### Single page layout mode

In single page layout mode, the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) shows one page at a time and allows users to swipe or scroll horizontally through the document. It provides a focused view, allowing readers to concentrate on a single page at a time without being distracted. 
To enable the single page layout mode, you can call the following code in a button click.

{% tabs %}
{% highlight c# %}

// Enable or activate the Single Page Layout mode.
void EnableSinglePageLayoutMode()
{
    // Set the PageLayout mode to Single using the `SfPdfViewer` instance.
    PdfViewer.PageLayoutMode = PageLayoutMode.Single;
}

{% endhighlight %}
{% endtabs %}

N> You can download the **Custom Toolbar** sample project for the .NET MAUI PDF Viewer [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples) , which demonstrates fuctionality related to the [PageLayoutMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.PageLayoutMode.html) feature.

## Obtain total page count and current page number

The [PageCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_PageCount) property returns the total number of pages in a PDF document. And the [PageNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_PageNumber) property returns the current page number displayed in the PDF Viewer.

{% tabs %}
{% highlight c# %}
// Returns total number of pages
int totalPageCount = PdfViewer.PageCount;
// Returns current page number
int currentPageNumber = PdfViewer.PageNumber;
{% endhighlight %}
{% endtabs %}

## Navigate to the desired page programmatically

The [GoToPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToPage_System_Int32_) method helps you navigate to the specified page number in a PDF document. If the destination page doesn’t exist, then the navigation will not happen, and the older page will be retained. Refer to the following code example:

{% tabs %}
{% highlight c# %}
// Navigate to the page number 4.
PdfViewer.GoToPage(4);
{% endhighlight %}
{% endtabs %}

## Navigate to the next and previous page programmatically

The [GoToNextPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToNextPage) and [GoToPreviousPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToPreviousPage) methods help you navigate to the next and previous pages of a PDF document. Refer to the following code example:

{% tabs %}
{% highlight c# %}
private void NextPageButton_Clicked(object sender, EventArgs e)
{
    // Navigate to the next page
    PdfViewer.GoToNextPage();
}

private void PreviousPageButton_Clicked(object sender, EventArgs e)
{
    // Navigate to the previous page
    PdfViewer. GoToPreviousPage();
}
{% endhighlight %}
{% endtabs %}

## Navigate to the first and last page programmatically

The [GoToFirstPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToFirstPage) and [GoToLastPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_GoToLastPage) methods help you navigate to the first and last pages of a PDF document. Refer to the following code example:

{% tabs %}
{% highlight c# %}
private void FirstPageButton_Clicked(object sender, EventArgs e)
{
    // Navigate to the first page
    PdfViewer.GoToFirstPage();
}

private void LastPageButton_Clicked(object sender, EventArgs e)
{
    // Navigate to the last page
    PdfViewer.GoToLastPage();
}
{% endhighlight %}
{% endtabs %}

The example project with the page navigation functionalities can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples).