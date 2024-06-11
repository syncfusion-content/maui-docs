---
layout: post
title: Magnification in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about magnification feature in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view.
---

# Magnification .NET MAUI PDF Viewer (SfPdfViewer)

The content of a PDF document can be efficiently zoomed in and out by pinching or changing the zoom factor programmatically. This section walks through the magnification functionalities supported in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html).

## Change the zoom factor

You can change or control the zoom in the PDF Viewer using the [ZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ZoomFactor) property. Refer to the following code example.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="PdfViewer" DocumentSource="{Binding PdfDocumentStream}" ZoomFactor ="3" />
{% endhighlight %}

{% highlight c# %}
PdfViewer.ZoomFactor = 3;
{% endhighlight %}
{% endtabs %}

You can also obtain the current zoom factor at which the document is displayed in the PDF Viewer using the `ZoomFactor` property.

## Change the minimum and maximum zoom factor

By default, the zoom factor can be adjusted or set between 1 and 4 to magnify the document displayed in the PDF Viewer. But it can also be restricted to a certain level by adjusting the [minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MinZoomFactor) and [maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MaxZoomFactor) zoom factors.

The following code example explains restricting the zoom factor between 0.5 and 2.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="PdfViewer" DocumentSource="{Binding PdfDocumentStream}"  MinZoomFactor = “0.5” MaxZoomFactor ="2" />
{% endhighlight %}

{% highlight c# %}
PdfViewer.MinZoomFactor = 0.5;
PdfViewer.MaxZoomFactor = 2;
{% endhighlight %}
{% endtabs %}

N>If the `ZoomFactor` value is set beyond the [MinZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MinZoomFactor) and [MaxZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MaxZoomFactor) limits, then it will not be effective.

The example project with the zoom or magnification functionalities can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples).

## Zoom modes 

The .NET MAUI PDF Viewer supports the below zoom modes: 
1. Fit to Page
2. Fit to Width

Fit-to-page ensures that users can see the entire page content to get a quick overview without having to scroll. Fit-to-width is helpful when reading documents with narrow columns, such as newspaper articles or other multicolumn layouts.
You can change the zoom mode using the `SfPdfViewer.ZoomMode` property of the PDF Viewer, default value for `SfPdfViewer.ZoomMode` is `ZoomMode.Default`.

### Change zoom mode from the toolbar

#### Using the magnification drop-down tool on the desktop 

On the desktop built-in toolbar, a magnifying tool is available that shows the current zoom percentage of the document. Using the tool, you can choose a zoom percentage from a predefined set of values. Additionally, you can choose the fit-to-width or fit-to-page option.

![Desktop Zoom Mode Combo Box](Images/windowszoom.gif)

#### Using the zoom mode tool on the mobile

On the mobile built-in toolbar, by default, the magnifying tool is not visible. When the document `ZoomFactor` is changed, it becomes visible. Using the tool, you can choose the `Fit to Width` or `Fit to Page` option. When an option is selected, the icon will no longer be visible until the zoom percentage changes again. 

![Mobile Zoom Mode Combo box](Images/ZoomModeforMobile.gif)

### Setting zoom mode programmatically 

#### Change to fit-to-page

You can change the `SfPdfViewer.ZoomMode` using the `ZoomMode.FitToPage` enumeration. It will magnify the PDF document so that the entire PDF page is visible in the view port. 
Refer to the following code example: 

{% tabs %}
{% highlight xaml %}
<Syncfusion:PdfViewer x:Name="pdfViewer" ZoomMode="FitToPage"/> 
{% endhighlight %}

{% highlight c# %}
// To apply fit-to-page zoom mode. 
pdfViewer.ZoomMode = ZoomMode.FitToPage; 
{% endhighlight %}
{% endtabs %}

#### Change to fit-to-width 

You can change the `SfPdfViewer.ZoomMode` using the `ZoomMode.FitToWidth` enumeration. It will magnify the PDF document so that the widest page of the PDF document fits the width of the view port. 
Refer to the following code example:

{% tabs %}
{% highlight xaml %}
<Syncfusion:PdfViewer x:Name="pdfViewer" ZoomMode="FitToWidth"/> 
{% endhighlight %}

{% highlight c# %}
// To apply fit-to-page zoom mode. 
pdfViewer.ZoomMode = ZoomMode.FitToWidth; 
{% endhighlight %}
{% endtabs %}

N> When the zoom factor of a PDF is changed, the zoom mode automatically changes to the default setting. After this change, you can manually adjust the zoom mode to either "Fit to Page" or "Fit to Width" as needed. 
