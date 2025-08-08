---
layout: post
title: Scrolling in .NET MAUI PDF Viewer Control | Syncfusion
description: Learn here all about scrolling functionality in .NET MAUI PDF Viewer including programmatically setting scroll positions and detecting scroll changes.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Scrolling in .NET MAUI PDF Viewer (SfPdfViewer)

The NET MAUI PDF Viewer has scrolling capabilities that allow users to navigate through content seamlessly. This section will walk you through various aspects of scrolling, including programmatically setting scroll positions and detecting scroll changes.

W> Please note that since the PDF Viewer has built-in scrolling capability, it is advised to avoid placing the PDF Viewer inside other controls that also offer scrolling, such as [ScrollView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/scrollview?view=net-maui-8.0). Nesting within such controls may cause unexpected issues.

## Scroll Head

You can scroll through pages by simply dragging the scroll head within the UI on Android and iOS platforms.

![Scroll Head](Images\ScrollHead.png)

### Page navigation using scroll head
To navigate to a specific page, tap the scroll head to open the page navigation dialog. Enter a valid page number in the input field present in the dialog, then tap the OK button. Then it navigates to the selected page of the PDF document. For further more 

![Page navigation by tapping scroll head](Images\PageNavigationUsingScrollHead.gif)

### Show or hide the scroll head

The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to show or hide the scroll head thumb displayed using the [ShowScrollHead](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ShowScrollHead) property. Refer to the following code example.

{% tabs %}
{% highlight c# %}
// Hide the scroll head thumb
PdfViewer.ShowScrollHead = false;
{% endhighlight %}
{% endtabs %}

N> The Scroll Head is not available for the Desktop platform (Windows and MAC)

## Navigate to the desired offset programmatically

The [ScrollToOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ScrollToOffset_System_Double_System_Double_) method moves the scroll position of the SfPdfViewer to the specified horizontal and vertical offsets. If the specified offset value is wrong, the scroll will not happen, and the older position will be retained. The offset values are represented in device-independent units.

{% tabs %}
{% highlight c# %}
// Navigate to the scroll offset position (100,1000).
PdfViewer.ScrollToOffset(100, 1000);
{% endhighlight %}
{% endtabs %}

## Scroll changes detection

The `PropertyChanged` event can be used to identify the scroll changes in the PDF Viewer effectively. By monitoring the [HorizontalOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_HorizontalOffset) and [VerticalOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_VerticalOffset) property changes, you can respond to both the horizontal and vertical scroll movements respectively. 

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

Handle scroll changes by implementing the event handler method. The following code example illustrates how to respond to both horizontal and vertical scroll changes:

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

## Detecting the end of the document

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
