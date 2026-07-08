---
layout: post
title: Exporting in .NET MAUI Funnel Chart control | Syncfusion
description: Learn how to export the Syncfusion® .NET MAUI Funnel Chart (SfFunnelChart) control as an image and stream.
platform: maui
control: SfFunnelChart
documentation: ug
keywords: .net maui funnel chart, export chart, save image, export stream, png, jpeg, image export.
---

# Exporting in .NET MAUI Funnel Chart (SfFunnelChart)

## Prerequisites

Before exporting the chart, ensure that the Syncfusion.Maui.Charts package is installed and that the following namespaces are imported.

{% tabs %}

{% highlight xml %}

xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Charts;
using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

Next, define a simple data model that represents a data point in the chart. Then, create a `ViewModel` class and initialize a list of `Model` objects. Set the `ViewModel` instance as the `BindingContext` of your page to bind `ViewModel` properties to the chart.

## Export as an image

You can export the chart view as an image in the desired file format using the [SaveAsImage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SaveAsImage_System_String_) method of [SfFunnelChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html). The supported image formats are **JPEG (.jpeg, .jpg) and PNG (.png)**. By default, if no format is specified with the filename, the chart view will be exported as a PNG image.

N> The chart view can be exported as an image only when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

SfFunnelChart chart = new SfFunnelChart()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue"
};

this.Content = chart;
chart.SaveAsImage("ChartSample.jpeg");

{% endhighlight %}

{% endtabs %}

T> Change the file extension (.jpg, .jpeg, or .png) to export in a different image format.

The exported image will be saved in different locations across platforms:

* **Windows and Android** — The image is saved in the Pictures directory.
* **macOS and iOS** — The image is saved in the Photos/Album directory.

### Platform-specific permissions

**Windows and Android**

To save the image on Android and Windows Phone devices, you must enable file writing permissions on the device storage.

**iOS**

To save the image to the photo album on iOS devices, add the following permissions to the `Info.plist` file:

{% tabs %}

{% highlight xml %}

<dict>
    <key>NSPhotoLibraryUsageDescription</key>    
    <string>This app needs permission to access your photos</string>    
    <key>NSPhotoLibraryAddUsageDescription</key>    
    <string>This app needs permission to save to your photo library</string> 
</dict>

{% endhighlight %}

{% endtabs %}

If permission is denied by the user, the `SaveAsImage` method will fail silently. Consider implementing permission handling to notify users of the result.

## Get the chart as a stream

The [GetStreamAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_) method of [SfFunnelChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html) asynchronously returns the chart view as a `Stream` in the desired [ImageFileFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ImageFileFormat.html). The output stream can be passed to other components that accept streams, such as PDF, Excel, and Word. The supported image file formats are **JPEG (.jpeg, .jpg) and PNG (.png)**.

N> The chart stream can only be rendered when the chart view is added to the visual tree.

The following code snippet demonstrates the usage of this method:

{% tabs %}

{% highlight c# %}

using Syncfusion.Maui.Charts;
using Syncfusion.Maui.Core;

SfFunnelChart chart = new SfFunnelChart()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue"
};

this.Content = chart;
Stream stream = await chart.GetStreamAsync(ImageFileFormat.Jpeg);

{% endhighlight %}

{% endtabs %}

## Related resources

* [.NET MAUI Charts feature tour](https://www.syncfusion.com/maui-controls) — Explore groundbreaking features and capabilities.
* [.NET MAUI Charts examples](https://github.com/syncfusion/maui-demos) — Discover various chart types and their configurations.

