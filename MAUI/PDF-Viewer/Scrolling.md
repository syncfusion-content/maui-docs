---
layout: post
title: Scrolling in .NET MAUI PDF Viewer Control | Syncfusion
description: Explore scrolling features in .NET MAUI PDF Viewer, including how to set scroll positions programmatically and detect scroll changes in real time.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Scrolling in .NET MAUI PDF Viewer (SfPdfViewer)

The .NET MAUI PDF Viewer provides built-in scrolling capabilities that allow users to navigate through PDF content smoothly. This guide covers how to control scroll positions programmatically, detect scroll changes, and manage scroll-related UI elements.

W> Since the PDF Viewer includes built-in scrolling, avoid placing it inside other scrollable containers like [ScrollView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/scrollview?view=net-maui-8.0), as this may lead to unexpected behavior.

## Programmatic Scrolling

Use the [ScrollToOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ScrollToOffset_System_Double_System_Double_) method to scroll to a specific horizontal and vertical offset. Offset values are measured in **device-independent units**. If the specified offset is invalid or out of bounds, the scroll action will be ignored and the viewer will retain its current position.

{% tabs %}
{% highlight c# %}
// Scroll to position (100, 1000)
PdfViewer.ScrollToOffset(100, 1000);
{% endhighlight %}
{% endtabs %}

## Detect Scroll Changes

You can monitor scroll changes using the `PropertyChanged` event. By monitoring the [HorizontalOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_HorizontalOffset) and [VerticalOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_VerticalOffset) property changes, you can respond to both the horizontal and vertical scroll movements respectively. 

The following is the code example for subscribing to the `PropertyChanged` event.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfPdfViewer 
    x:Name = "PdfViewer" PropertyChanged = "PdfViewer_PropertyChanged"/>

{% endhighlight %}
{% highlight C# %}

void SubscribeToPropertyChangedEvent()
{
    SfPdfViewer PdfViewer = new SfPdfViewer();
    // Subscribe to property changed event.
    PdfViewer.PropertyChanged += PdfViewer_PropertyChanged;
}

{% endhighlight %}
{% endtabs %}

The following code example illustrates how implement the event handler and to respond to both horizontal and vertical scroll changes:

{% tabs %}
{% highlight c# %}
private void PdfViewer_PropertyChanged(object sender, 
    System.ComponentModel.PropertyChangedEventArgs e)
{
    if (e.PropertyName == nameof(SfPdfViewer.HorizontalOffset))
    {
        // Horizontal scroll change detected
        // Your code here
    }
    else if (e.PropertyName == nameof(SfPdfViewer.VerticalOffset))
    {
        // Vertical scroll change detected
        // Your code here
    }
}
{% endhighlight %}
{% endtabs %}

## Detecting End of Document

You can determine if the control has reached the vertical end of the document by evaluating the following properties:

* `VerticalOffset`: It provides the current vertically scrolled offset.
* `ClientRectangle`: It provides the viewport area bounds.
* `ExtentHeight`: It provides the overall vertical height of the PDF document.

Below is the code example to detect whether the control has reached the vertical end of the document.

{% tabs %}
{% highlight c# %}
private void PdfViewer_PropertyChanged(object sender, 
    System.ComponentModel.PropertyChangedEventArgs e)
{
    if (e.PropertyName == nameof(SfPdfViewer.VerticalOffset))
    {
        // Determine if the control has reached the vertical end of the document.
        bool isVerticalEndReached = (PdfViewer.VerticalOffset + 
            PdfViewer.ClientRectangle.Height >= PdfViewer.ExtentHeight);
    }
}
{% endhighlight %}
{% endtabs %}

Similarly, for horizontal end detection, refer to the following code example.

{% tabs %}
{% highlight c# %}
private void PdfViewer_PropertyChanged(object sender, 
    System.ComponentModel.PropertyChangedEventArgs e)
{
    if (e.PropertyName == nameof(SfPdfViewer.HorizontalOffset))
    {
        // Determine if the control has reached the horizontal end of the document.
        bool isHorizontalEndReached = (PdfViewer.HorizontalOffset + 
            PdfViewer.ClientRectangle.Width >= PdfViewer.ExtentWidth);
    }
}

{% endhighlight %}
{% endtabs %}

## Scroll Head (Mobile Platforms)

On Android and iOS platforms, the scroll head offers a quick way to move through pages. Users can drag the thumb indicator to scroll within the PDF document.

![Scroll Head](Images\ScrollHead.png)

### Page Navigation via Scroll Head

Tap the scroll head to open a page navigation dialog. Enter a valid page number and tap **OK** to jump directly to that page.

![Page navigation by tapping scroll head](Images\PageNavigationUsingScrollHead.gif)

### Show or Hide the Scroll Head

Use the [ShowScrollHead](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ShowScrollHead) property to control the visibility of the scroll head.

{% tabs %}
{% highlight c# %}
// Hide the scroll head thumb
PdfViewer.ShowScrollHead = false;
{% endhighlight %}
{% endtabs %}

N> The scroll head is available only on **mobile platforms**. It is not supported on **Windows** or **macOS**.
