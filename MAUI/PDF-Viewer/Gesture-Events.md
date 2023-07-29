---
layout: post
title: Gesture events in .NET MAUI PDF Viewer control | Syncfusion
description: This guide discusses about the gesture events provided by Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Gesture events in .NET MAUI PDF Viewer (SfPdfViewer)

## Tapped Event

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) provides a [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_Tapped) event that occurs when a tap gesture is detected in the control and allows you to perform custom actions when a tap occurs. This event provides information about the page number and position at the tapped location through the [GestureEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.GestureEventArgs.html). 
The following code example demonstrates how to subscribe to the `Tapped` event.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfPdfViewer x:Name="PdfViewer" Tapped="PdfViewer_Tapped"/>
{% endhighlight %}

{% highlight c# %}
        SfPdfViewer PdfViewer = new SfPdfViewer();
        PdfViewer.Tapped += PdfViewer_Tapped;
{% endhighlight %}
{% endtabs %}

In the above example, the `PdfViewer_Tapped` method is registered as the event handler for the Tapped event of the `SfPdfViewer`. The `PdfViewer_Tapped` method will be invoked whenever a tap occurs on the PDF Viewer. You can handle the custom action in the method as demonstrated in the following code example.

{% tabs %}
{% highlight c# %}
    private void PdfViewer_Tapped(object sender, GestureEventArgs e)
    {
        // Handle the tap event here.
    }
{% endhighlight %}
{% endtabs %}

### GestureEventArgs

The `GesturEventArgs` provides information available on the tapped location and it includes the following properties.

1.	[PageNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.GestureEventArgs.html#Syncfusion_Maui_PdfViewer_GestureEventArgs_PageNumber) – This property returns the page number on which the tap took place. The value ranges from 1 to the total number of pages in the PDF document. If the tap occurs outside of any PDF page boundaries, the result will be -1.
2.	[PagePositon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.GestureEventArgs.html#Syncfusion_Maui_PdfViewer_GestureEventArgs_PagePosition) – The property returns the page’s tapped position in the PDF coordinates. The coordinates have their origin at the top-left of the page. The number of the tapped page is identified by the `PageNumber` property. If the tap occurs outside of any PDF page boundaries, the result will be (-1, -1).
3.	[Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.GestureEventArgs.html#Syncfusion_Maui_PdfViewer_GestureEventArgs_Position) – This property returns the tapped position on the PDF Viewer control. The coordinate space starts at the top left of the control.

The following code example that demonstrates how to retrieve information from the `GestureEventArgs` and handle the tapped event.

{% tabs %}
{% highlight c# %}
    private void PdfViewer_Tapped(object sender, GestureEventArgs e)
    {
        // To get the pointer position on the control where the tap occurred.
        var pointerPosition = e.Position;
        // To get the page number where the tap occurred.
        var pageNumber = e.PageNumber;
        // To get the page position where the tap occurred.
        var pagePoistion = e.PagePosition;

        // Handle the tap event here with the above information if required.
    }
{% endhighlight %}
{% endtabs %}	