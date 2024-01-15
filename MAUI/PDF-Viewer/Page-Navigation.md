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

## Navigate to the desired offset programmatically

The [ScrollToOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ScrollToOffset_System_Double_System_Double_) method moves the scroll position of the SfPdfViewer to the specified horizontal and vertical offsets. If the specified offset value is wrong, then the scroll will not happen, and the older position will be retained.

{% tabs %}
{% highlight c# %}
// Navigate to the scroll offset position (100,1000)
PdfViewer.ScrollToOffset(100, 1000);
{% endhighlight %}
{% endtabs %}

The example project with the page navigation functionalities can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples).

N> Please note that the PDF Viewer has built-in scrolling capability. Therefore, it is advised avoid placing the PDF Viewer inside other controls that also offer scrolling, such as [ScrollView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/scrollview?view=net-maui-8.0). Nesting within such controls may cause unexpected issues.
