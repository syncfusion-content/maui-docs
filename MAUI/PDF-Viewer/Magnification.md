---
layout: post
title: Magnification in .NET MAUI PDF Viewer control | Syncfusion
description: Learn how to use the magnification features in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control, including zoom factor adjustments and zoom modes.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view.
---

# Magnification .NET MAUI PDF Viewer (SfPdfViewer)

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) control supports intuitive magnification features, allowing users to zoom in and out of PDF content using gestures or programmatic controls.

## Adjusting the Zoom Factor

You can control the zoom level using the [ZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ZoomFactor) property. Refer to the following code example.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="PdfViewer" DocumentSource="{Binding PdfDocumentStream}" ZoomFactor ="3" />
{% endhighlight %}

{% highlight c# %}
PdfViewer.ZoomFactor = 3;
{% endhighlight %}
{% endtabs %}

You can also retrieve the current zoom level using the same property.

### Setting Minimum and Maximum Zoom Limits

By default, the zoom range varies by platform:
* **Mobile (Android/iOS):** 1.0 to 4.0
* **Desktop (Windows/macOS):** 0.25 to 4.0

To restrict zoom levels, use the [MinZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MinZoomFactor) and [MaxZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MaxZoomFactor) properties.

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

N> If the [ZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ZoomFactor)  is set outside the defined [MinZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MinZoomFactor) and [MaxZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_MaxZoomFactor) range, it will be ignored.

You can download a sample project demonstrating magnification features [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples).

## Zoom Modes 

The PDF Viewer supports the following zoom modes via the [ZoomMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ZoomMode.html#fields) property:

1. **Fit to Page** – Displays the entire page within the viewport.
2. **Fit to Width** – Expands the page to fill the width of the viewer.

The default value is [ZoomMode.Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ZoomMode.html#Syncfusion_Maui_PdfViewer_ZoomMode_Default)

### Zoom Mode via Built-In Toolbar

#### Desktop Toolbar

The built-in toolbar includes a magnification dropdown showing the current zoom percentage. Users can select predefined zoom levels or choose **Fit to Page** / **Fit to Width**.

![Desktop Zoom Mode Combo Box](Images/windowszoom.gif)

#### Mobile Toolbar

On mobile, the magnification tool appears only after the zoom factor changes. Users can then select **Fit to Page** or **Fit to Width**. Once selected, the icon disappears until the zoom factor changes again.

![Mobile Zoom Mode Combo box](Images/ZoomModeforMobile.gif)

### Programmatically Setting Zoom Mode 

#### Fit to Page

You can change the [SfPdfViewer.ZoomMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ZoomMode.html#fields) using the [ZoomMode.FitToPage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ZoomMode.html#Syncfusion_Maui_PdfViewer_ZoomMode_FitToPage) enumeration. It will magnify the PDF document so that the entire PDF page is visible in the view port. 
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

#### Fit to Width

You can change the [SfPdfViewer.ZoomMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ZoomMode.html#fields) using the [ZoomMode.FitToWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.ZoomMode.html#Syncfusion_Maui_PdfViewer_ZoomMode_FitToWidth) enumeration. It will magnify the PDF document so that the widest page of the PDF document fits the width of the view port. 
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

N> When the `ZoomFactor` is manually changed, the `ZoomMode` resets to `Default`. You can reapply the desired zoom mode afterward. 
