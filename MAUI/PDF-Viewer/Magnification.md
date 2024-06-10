---
layout: post
title: Magnification in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about magnification feature in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
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

The example project with the zoom or magnification functionalities can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples/tree/master/Zoom).
